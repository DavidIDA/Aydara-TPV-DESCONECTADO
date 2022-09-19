Public Class ModificacionPrecios

#Region "ModificacionPrecios_KeyUp"
    Private Sub ModificacionPrecios_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "ModificacionPrecios_Shown"
    Private Sub ModificacionPrecios_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en precios
        Me.maskPrecio.Mask.EditMask = "c" & DecimalesPrecio
        'Mostrar color y talla
        Me.gbColor.Visible = GestionColores
        Me.gbTalla.Visible = GestionTallas
        'Fecha en vigor por defecto hoy
        Me.txtFechaVigor.EditValue = Date.Today
        Me.DsModificacionesPendientes.MODIFICACIONES_PENDIENTES.FechaVigorColumn.DefaultValue = Date.Today
    End Sub
#End Region

#Region "ModificacionPrecios_FormClosing"
    Private Sub ModificacionPrecios_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.DsModificacionesPendientes.MODIFICACIONES_PENDIENTES.Rows.Count > 0 Then
            If MsgBox("¿Seguro que desea cancelar la modificación de precios?" & vbCrLf & "Si continua perderá toda la información cargada.", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then e.Cancel = True
        End If
    End Sub
#End Region

#Region "bttCodigoArticulo_ButtonClick"
    Private Sub bttCodigoArticulo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bttCodigoArticulo.ButtonClick
        Try
            Dim dsArticulos As New dsArticulos, tArticulos As New dsArticulosTableAdapters.ARTICULOSTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(0) 'Tamaño columna
            Columnas.Add(0) 'Tamaño máximo columna

            Columnas.Add("Etiqueta")
            Columnas.Add("Familia-Subf")
            Columnas.Add(80)
            Columnas.Add(80)

            Columnas.Add("Codigo")
            Columnas.Add("Código")
            Columnas.Add(80)
            Columnas.Add(80)

            Columnas.Add("Descripcion")
            Columnas.Add("Descripción")
            Columnas.Add(0)
            Columnas.Add(0)

            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT (SELECT Codigo FROM FAMILIASARTICULOS WHERE FAMILIASARTICULOS.Id=ARTICULOS.CodigoFamilia) + ' - ' + " & _
                              "(SELECT Codigo FROM SUBFAMILIASARTICULOS WHERE Familia_Id=ARTICULOS.CodigoFamilia AND SUBFAMILIASARTICULOS.Id=ARTICULOS.CodigoSubfamilia) AS Etiqueta, " & _
                              "Codigo, Descripcion FROM ARTICULOS ORDER BY Etiqueta, Descripcion"

            dsArticulos.ARTICULOS.Load(cmd.ExecuteReader)

            If Buscar(dsArticulos, "ARTICULOS", Columnas, 3, True).ShowDialog = Windows.Forms.DialogResult.OK Then
                If Me.gvArticulos.GetRow(Me.gvArticulos.FocusedRowHandle) Is Nothing Then Me.gvArticulos.AddNewRow()
                Me.gvArticulos.SetFocusedValue(ResultadoBusqueda)
                Me.gvArticulos.FocusedColumn = IIf(GestionColores, Me.colCodigoColor, IIf(GestionTallas, Me.colCodigoTalla, Me.colPrecioTarifa))
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "DatosArticulo"
    Private Sub DatosArticulo()

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        Dim CodigoArticulo As String
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            RemoveHandler gvArticulos.CellValueChanged, AddressOf gvArticulos_CellValueChanged

            'Vaciar colores y tallas
            Me.DsModificacionesPendientes.COLORES.Clear()
            Me.DsModificacionesPendientes.TALLAS.Clear()

            'Comprobar si es un código de barras
            If Len(Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo)) > 7 Then

                cmd.CommandText = "select ISNULL(Codigo,'') from (articulos left join existencias on articulos.id=existencias.articulo_id) " & _
                                  "left join Codigo_Barras on articulos.id=codigo_barras.articulo_id " & _
                                  "where existencias.codigobarras='" & Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo) & "' or codigo_barras.codigobarras='" & Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo) & "'"

                CodigoArticulo = cmd.ExecuteScalar

                If CodigoArticulo <> String.Empty Then
                    Me.gvArticulos.SetFocusedRowCellValue(Me.colCodigoArticulo, CodigoArticulo)
                Else
                    'MsgBox("No existe ningún artículo asociado a ese código de barras", MsgBoxStyle.Information, "No existe")
                    Me.gvArticulos.SetFocusedRowCellValue(Me.colCodigoArticulo, String.Empty)
                    Me.gvArticulos.SetFocusedRowCellValue(Me.colDescripcion, String.Empty)
                    Me.gvArticulos.SetFocusedRowCellValue(Me.colPrecioTarifa, 0)
                    'Me.txtCodigoArticulo.Focus()
                    Exit Try
                End If

            End If

            'If IsNumeric(Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo)) Then Me.gvArticulos.SetFocusedRowCellValue(Me.colCodigoArticulo, Format(CType(Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo), Integer), "0000000"))

            'Mostrar información del artículo
            Dim CodigoTalla As Integer = 0

            cmd.CommandText = "SELECT * FROM Articulos WHERE Codigo='" & Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo) & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                Me.gvArticulos.SetFocusedRowCellValue(Me.colDescripcion, dr("descripcion"))
                CodigoTalla = dr("CodigoTalla")
                dr.Close()
            Else
                'MsgBox("No existe ningún artículo con ese código", MsgBoxStyle.Information, "No existe")
                Me.gvArticulos.SetFocusedRowCellValue(Me.colCodigoArticulo, String.Empty)
                Me.gvArticulos.SetFocusedRowCellValue(Me.colDescripcion, String.Empty)
                Me.gvArticulos.SetFocusedRowCellValue(Me.colPrecioTarifa, 0)
                'Me.txtCodigoArticulo.Focus()
                Exit Try
            End If

            'Cargar colores y tallas del artículo
            If GestionColores Or GestionTallas Then Me.CargarTallasColores()

            'Preciotarifa del artículo
            Me.gvArticulos.SetFocusedRowCellValue(Me.colPrecioActual, DamePrecioArticulo(Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo), IIf(Not Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoColor) Is System.DBNull.Value, Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoColor), 0), IIf(Not Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoTalla) Is System.DBNull.Value, Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoTalla), 1)))
            Me.gvArticulos.SetFocusedRowCellValue(Me.colPrecioTarifa, Me.gvArticulos.GetFocusedRowCellValue(Me.colPrecioActual))

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            AddHandler gvArticulos.CellValueChanged, AddressOf gvArticulos_CellValueChanged
        End Try

        cmd.Connection.Close()

    End Sub
#End Region

#Region "gvArticulos_CellValueChanged"
    Private Sub gvArticulos_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvArticulos.CellValueChanged
        Try
            'Actualizar modificación columna
            Select Case e.Column.Name
                Case Me.colCodigoArticulo.Name
                    Me.DatosArticulo()
                Case Me.colCodigoColor.Name
                    Me.gvArticulos.SetFocusedRowCellValue(Me.colDescripcionColor, DameColor(e.Value))
                Case Me.colCodigoTalla.Name
                    Me.gvArticulos.SetFocusedRowCellValue(Me.colDescripcionTalla, DameTallaArticulo(Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo), e.Value))
            End Select
            'Actualizar precio
            If e.Column Is Me.colCodigoColor Or e.Column Is Me.colCodigoTalla Then
                Me.gvArticulos.SetFocusedRowCellValue(Me.colPrecioActual, DamePrecioArticulo(Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo), IIf(Not Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoColor) Is System.DBNull.Value, Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoColor), 0), IIf(Not Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoTalla) Is System.DBNull.Value, Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoTalla), 1)))
                Me.gvArticulos.SetFocusedRowCellValue(Me.colPrecioTarifa, Me.gvArticulos.GetFocusedRowCellValue(Me.colPrecioActual))
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "gvArticulos_FocusedRowChanged"
    Private Sub gvArticulos_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvArticulos.FocusedRowChanged
        If GestionColores Or GestionTallas Then Me.CargarTallasColores()
    End Sub
#End Region

#Region "CargarTallasColores"
    Private Sub CargarTallasColores()

        Me.DsModificacionesPendientes.COLORES.Clear()
        Me.DsModificacionesPendientes.TALLAS.Clear()

        If Me.gvArticulos.GetFocusedRow Is Nothing Then Exit Sub

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            Dim CodigoTalla As Integer

            'Código tallaje del artículo
            cmd.CommandText = "SELECT CodigoTalla FROM Articulos WHERE Codigo='" & Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo) & "'"
            CodigoTalla = cmd.ExecuteScalar

            'Cargar colores y tallas del artículo
            Me.COLORESTableAdapter.Articulo(Me.DsModificacionesPendientes.COLORES, Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo))

            cmd.CommandText = "SELECT * FROM Tallas WHERE CodigoTalla=" & CodigoTalla
            dr = cmd.ExecuteReader
            If dr.Read Then
                Dim i As Integer
                For i = 1 To 18
                    Me.DsModificacionesPendientes.TALLAS.AddTALLASRow(i, dr("Talla_" & i))
                Next
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox("Error al mostrar información de tallas y colores del artículo", MsgBoxStyle.Exclamation)
        End Try

        cmd.Connection.Close()

    End Sub
#End Region

#Region "txtCodigoProveedor_ButtonClick"
    Private Sub txtCodigoProveedor_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoProveedor.ButtonClick
        Try

            Dim dsProveedores As New dsProveedores, tProveedores As New dsProveedoresTableAdapters.PROVEEDORESTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("Nombre")
            Columnas.Add("Nombre Fiscal")
            Columnas.Add(0)
            Columnas.Add(0)

            Columnas.Add("Direccion")
            Columnas.Add("Dirección")
            Columnas.Add(0)
            Columnas.Add(0)

            tProveedores.Fill(dsProveedores.PROVEEDORES)

            If Buscar(dsProveedores, "Proveedores", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoProveedor.Text = ResultadoBusqueda
                Me.txtCodigoProveedor.IsModified = True
                Me.txtCodigoProveedor_Validated(Nothing, Nothing)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoFamilia_ButtonClick"
    Private Sub txtCodigoFamilia_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoFamilia.ButtonClick
        Try
            Dim dsFamilias As New dsArticulos
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("Descripcion")
            Columnas.Add("Descripción")
            Columnas.Add(0)
            Columnas.Add(0)

            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT Codigo, Descripcion FROM FAMILIASARTICULOS"

            dsFamilias.FAMILIASARTICULOS.Load(cmd.ExecuteReader)

            If Buscar(dsFamilias, "FAMILIASARTICULOS", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoFamilia.EditValue = ResultadoBusqueda
                Me.txtCodigoFamilia.IsModified = True
                Me.txtCodigoFamilia_Validated(Nothing, Nothing)
            End If

        Catch ex As Exception
            MsgBox("Error en la búsqeda de familias", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "txtCodigoSubFamilia_ButtonClick"
    Private Sub txtCodigoSubFamilia_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoSubfamilia.ButtonClick
        Try
            Dim dsSubfamilias As New dsArticulos
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("Descripcion")
            Columnas.Add("Descripción")
            Columnas.Add(0)
            Columnas.Add(0)

            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT SUBFAMILIASARTICULOS.Codigo, SUBFAMILIASARTICULOS.Descripcion " & _
                              "FROM FAMILIASARTICULOS INNER JOIN SUBFAMILIASARTICULOS ON FAMILIASARTICULOS.Id=SUBFAMILIASARTICULOS.Familia_Id " & _
                              "WHERE FAMILIASARTICULOS.Codigo='" & Me.txtCodigoFamilia.EditValue & "'"

            dsSubfamilias.SUBFAMILIASARTICULOS.Load(cmd.ExecuteReader)

            If Buscar(dsSubfamilias, "SUBFAMILIASARTICULOS", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoSubfamilia.EditValue = ResultadoBusqueda
                Me.txtCodigoSubfamilia.IsModified = True
                Me.txtCodigoSubfamilia_Validated(Nothing, Nothing)
            End If

            cmd.Connection.Close()

        Catch ex As Exception
            MsgBox("Error en la búsqeda de familias", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "txtCodigoProveedor_Validated"
    Private Sub txtCodigoProveedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoProveedor.Validated
        Try
            If Not Me.txtCodigoProveedor.IsModified Then Exit Sub

            If IsNumeric(Me.txtCodigoProveedor.EditValue) Then
                Me.txtCodigoProveedor.EditValue = Format(CType(Me.txtCodigoProveedor.EditValue, Integer), "00000")
            Else
                Me.txtCodigoProveedor.EditValue = String.Empty
                Me.txtNombreProveedor.EditValue = String.Empty
                Me.txtCodigoProveedor.Focus()
                Exit Try
            End If

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT Nombre FROM PROVEEDORES WHERE Codigo=" & CInt(Me.txtCodigoProveedor.EditValue)

            Me.txtNombreProveedor.EditValue = cmd.ExecuteScalar

            If Me.txtNombreProveedor.EditValue = String.Empty Then
                Me.txtCodigoProveedor.EditValue = String.Empty
                Me.txtCodigoProveedor.Focus()
            End If

            cmd.Connection.Close()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoFamilia_Validated"
    Private Sub txtCodigoFamilia_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoFamilia.Validated
        Try
            If Not Me.txtCodigoFamilia.IsModified Then Exit Sub

            If IsNumeric(Me.txtCodigoFamilia.EditValue) Then Me.txtCodigoFamilia.EditValue = Format(CType(Me.txtCodigoFamilia.EditValue, Integer), "000")

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT Descripcion FROM FAMILIASARTICULOS WHERE Codigo='" & Me.txtCodigoFamilia.EditValue & "'"

            Me.txtDescripcionFamilia.EditValue = cmd.ExecuteScalar

            If Me.txtDescripcionFamilia.EditValue = String.Empty Then
                Me.txtCodigoFamilia.EditValue = String.Empty
                Me.txtCodigoSubfamilia.Properties.ReadOnly = True
                Me.txtCodigoSubfamilia.Properties.Buttons(0).Enabled = False
                Me.txtCodigoFamilia.Focus()
            Else
                Me.txtCodigoSubfamilia.Properties.ReadOnly = False
                Me.txtCodigoSubfamilia.Properties.Buttons(0).Enabled = True
            End If

            Me.txtCodigoSubfamilia.EditValue = String.Empty
            Me.txtDescripcionSubfamilia.EditValue = String.Empty

            cmd.Connection.Close()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoSubfamilia_Validated"
    Private Sub txtCodigoSubfamilia_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoSubfamilia.Validated
        Try
            If Not Me.txtCodigoSubfamilia.IsModified Then Exit Sub

            If IsNumeric(Me.txtCodigoSubfamilia.EditValue) Then Me.txtCodigoSubfamilia.EditValue = Format(CType(Me.txtCodigoSubfamilia.EditValue, Integer), "000")

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT SUBFAMILIASARTICULOS.Descripcion " & _
                              "FROM FAMILIASARTICULOS INNER JOIN SUBFAMILIASARTICULOS ON FAMILIASARTICULOS.Id=SUBFAMILIASARTICULOS.Familia_Id " & _
                              "WHERE FAMILIASARTICULOS.Codigo='" & Me.txtCodigoFamilia.EditValue & "' AND SUBFAMILIASARTICULOS.Codigo='" & Me.txtCodigoSubfamilia.EditValue & "'"

            Me.txtDescripcionSubfamilia.EditValue = cmd.ExecuteScalar

            If Me.txtDescripcionSubfamilia.EditValue = String.Empty Then Me.txtCodigoSubfamilia.EditValue = String.Empty

            cmd.Connection.Close()


        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttImportarArticulos_Click"
    Private Sub bttImportarArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImportarArticulos.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim rArticulo As dsModificacionesPendientes.MODIFICACIONES_PENDIENTESRow

            Dim dr As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT Codigo, Descripcion FROM ARTICULOS " & _
                              "WHERE ControlBaja=0"

            If IsNumeric(Me.txtCodigoProveedor.EditValue) Then
                cmd.CommandText &= " AND CodigoProveedor =" & Int(Me.txtCodigoProveedor.EditValue)
            End If

            If Me.txtCodigoFamilia.EditValue <> String.Empty Then
                cmd.CommandText &= " AND CodigoFamilia IN (SELECT Id FROM FAMILIASARTICULOS WHERE Codigo='" & Me.txtCodigoFamilia.EditValue & "')"
            End If

            If Me.txtCodigoSubfamilia.EditValue <> String.Empty Then
                cmd.CommandText &= " AND CodigoSubfamilia IN (SELECT Id FROM SUBFAMILIASARTICULOS WHERE Codigo='" & Me.txtCodigoSubfamilia.EditValue & "')"
            End If

            Me.txtIncremento.Properties.Mask.UseMaskAsDisplayFormat = False

            dr = cmd.ExecuteReader
            While dr.Read
                Try
                    If Me.LineaRepetida(dr("Codigo"), 0, 1) Then Exit Try
                    rArticulo = Me.DsModificacionesPendientes.MODIFICACIONES_PENDIENTES.NewMODIFICACIONES_PENDIENTESRow
                    rArticulo.FechaVigor = Me.txtFechaVigor.EditValue
                    rArticulo.CodigoArticulo = dr("Codigo")
                    rArticulo.Descripcion = dr("Descripcion")
                    rArticulo.PrecioActual = DamePrecioArticulo(rArticulo.CodigoArticulo, 0, 1)
                    rArticulo.PrecioTarifa = Math.Round(rArticulo.PrecioActual + (rArticulo.PrecioActual * Me.txtIncremento.EditValue / 100), DecimalesPrecio, MidpointRounding.AwayFromZero)
                    rArticulo.Actualiza = Not Me.checkConformidad.Checked
                    'Aplicar tipo redondeo
                    Select Case Me.txtTipoRedondeo.SelectedIndex
                        Case 1 '0.00/0.50
                            If rArticulo.PrecioTarifa <= 0.5 Then Exit Select
                            Dim diferencia As Decimal = Math.Round((rArticulo.PrecioTarifa - Int(rArticulo.PrecioTarifa)), 1) * 10
                            Select Case diferencia
                                Case 0, 5, 10
                                    diferencia = 0
                                Case 1, 6
                                    diferencia = -0.1
                                Case 2, 7
                                    diferencia = -0.2
                                Case 3, 8
                                    diferencia = 0.2
                                Case 4, 9
                                    diferencia = 0.1
                            End Select
                            rArticulo.PrecioTarifa = Math.Round(rArticulo.PrecioTarifa + diferencia, 1)

                        Case 2 '0.00/0.05
                            Dim diferencia As Decimal = Math.Round((rArticulo.PrecioTarifa - (Int(rArticulo.PrecioTarifa * 10) / 10)), 2) * 100
                            Select Case diferencia
                                Case 0, 5, 10
                                    diferencia = 0
                                Case 1, 6
                                    diferencia = -0.01
                                Case 2, 7
                                    diferencia = -0.02
                                Case 3, 8
                                    diferencia = 0.02
                                Case 4, 9
                                    diferencia = 0.01
                            End Select
                            rArticulo.PrecioTarifa = Math.Round((rArticulo.PrecioTarifa + diferencia), 2)

                        Case 3 'Anterior 0.90
                            If rArticulo.PrecioTarifa <= 0.86 Then Exit Select
                            rArticulo.PrecioTarifa = Math.Round(Int(rArticulo.PrecioTarifa + 0.14) - 0.1, 2)
                    End Select
                    Me.DsModificacionesPendientes.MODIFICACIONES_PENDIENTES.AddMODIFICACIONES_PENDIENTESRow(rArticulo)
                Catch ex As Exception
                    MsgBox("Error al importar el artículo " & dr("codigo") & ": " & dr("Descripcion"), MsgBoxStyle.Exclamation)
                End Try
            End While
            dr.Close()

            'Cargar precios de color/talla de los artículos
            Dim i As Integer
            For i = 0 To Me.gvArticulos.RowCount - 1
                cmd.CommandText = "SELECT * FROM EXISTENCIAS INNER JOIN ARTICULOS ON EXISTENCIAS.Articulo_Id=ARTICULOS.Id " & _
                                  "WHERE ARTICULOS.Codigo='" & Me.gvArticulos.GetRowCellValue(i, Me.colCodigoArticulo) & "'"
                If Not GestionColores Then cmd.CommandText += " AND EXISTENCIAS.CodigoColor=0"
                If Not GestionTallas Then cmd.CommandText += " AND EXISTENCIAS.CodigoTalla=1"
                dr = cmd.ExecuteReader
                While dr.Read
                    If dr("PrecioVenta") <> 0 Then
                        Try
                            If Me.LineaRepetida(dr("Codigo"), dr("CodigoColor"), dr("CodigoTalla")) Then Exit Try
                            rArticulo = Me.DsModificacionesPendientes.MODIFICACIONES_PENDIENTES.NewMODIFICACIONES_PENDIENTESRow
                            rArticulo.FechaVigor = Me.txtFechaVigor.EditValue
                            rArticulo.CodigoArticulo = dr("Codigo")
                            rArticulo.Descripcion = dr("Descripcion")
                            rArticulo.CodigoColor = dr("CodigoColor")
                            rArticulo.CodigoTalla = dr("CodigoTalla")
                            'rArticulo.DescripcionColor = DameDescripcionColor(rArticulo.CodigoColor)
                            rArticulo.DescripcionColor = DameColor(rArticulo.CodigoColor)
                            rArticulo.DescripcionTalla = DameTallaArticulo(rArticulo.CodigoArticulo, rArticulo.CodigoTalla)
                            rArticulo.PrecioActual = DamePrecioArticulo(rArticulo.CodigoArticulo, dr("CodigoColor"), dr("CodigoTalla"))
                            rArticulo.PrecioTarifa = Math.Round(rArticulo.PrecioActual + (rArticulo.PrecioActual * Me.txtIncremento.EditValue / 100), DecimalesPrecio, MidpointRounding.AwayFromZero)
                            'Aplicar tipo redondeo
                            Select Case Me.txtTipoRedondeo.SelectedIndex
                                Case 1 '0.00/0.50
                                    If rArticulo.PrecioTarifa <= 0.5 Then Exit Select
                                    Dim diferencia As Decimal = Math.Round((rArticulo.PrecioTarifa - Int(rArticulo.PrecioTarifa)), 1) * 10
                                    Select Case diferencia
                                        Case 0, 5, 10
                                            diferencia = 0
                                        Case 1, 6
                                            diferencia = -0.1
                                        Case 2, 7
                                            diferencia = -0.2
                                        Case 3, 8
                                            diferencia = 0.2
                                        Case 4, 9
                                            diferencia = 0.1
                                    End Select
                                    rArticulo.PrecioTarifa = Math.Round(rArticulo.PrecioTarifa + diferencia, 1)

                                Case 2 '0.00/0.05
                                    Dim diferencia As Decimal = Math.Round((rArticulo.PrecioTarifa - (Int(rArticulo.PrecioTarifa * 10) / 10)), 2) * 100
                                    Select Case diferencia
                                        Case 0, 5, 10
                                            diferencia = 0
                                        Case 1, 6
                                            diferencia = -0.01
                                        Case 2, 7
                                            diferencia = -0.02
                                        Case 3, 8
                                            diferencia = 0.02
                                        Case 4, 9
                                            diferencia = 0.01
                                    End Select
                                    rArticulo.PrecioTarifa = Math.Round((rArticulo.PrecioTarifa + diferencia), 2)

                                Case 3 'Anterior 0.90
                                    If rArticulo.PrecioTarifa <= 0.86 Then Exit Select
                                    rArticulo.PrecioTarifa = Math.Round(Int(rArticulo.PrecioTarifa + 0.14) - 0.1, 2)
                            End Select
                            Me.DsModificacionesPendientes.MODIFICACIONES_PENDIENTES.AddMODIFICACIONES_PENDIENTESRow(rArticulo)

                        Catch ex As Exception
                            MsgBox("Error al importar el artículo " & dr("codigo") & ": " & dr("Descripcion"), MsgBoxStyle.Exclamation)
                        End Try
                    End If
                End While
                dr.Close()
            Next

            cmd.Connection.Close()

            Me.txtCodigoFamilia.EditValue = String.Empty
            Me.txtDescripcionFamilia.EditValue = String.Empty
            Me.txtCodigoSubfamilia.EditValue = String.Empty
            Me.txtDescripcionSubfamilia.EditValue = String.Empty
            Me.gvArticulos.MoveLastVisible()
            Me.gvArticulos.Focus()

        Catch ex As Exception
            MsgBox("Error al importar los artículos", MsgBoxStyle.Exclamation)
        Finally
            Me.txtIncremento.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "gvArticulos_ValidateRow"
    Private Sub gvArticulos_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvArticulos.ValidateRow
        Try
            'Comprobar columnas
            If Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo) = String.Empty Then
                If MsgBox("Seleccione el artículo", MsgBoxStyle.Information + MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    Me.gvArticulos.FocusedColumn = Me.colCodigoArticulo
                    e.Valid = False
                    Exit Sub
                Else
                    Me.gvArticulos.CancelUpdateCurrentRow()
                    Me.gvArticulos.FocusedColumn = Me.colFechaVigor
                    Exit Sub
                End If
            End If

            'Si es nueva línea comprobar que no exista ya en la promoción
            If Me.gvArticulos.IsNewItemRow(e.RowHandle) Then
                Dim i As Integer
                For i = 0 To Me.gvArticulos.RowCount - 1
                    If Me.gvArticulos.GetRowCellValue(i, Me.colCodigoArticulo) = Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo) And Me.gvArticulos.GetRowCellValue(i, Me.colCodigoColor) = Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoColor) And Me.gvArticulos.GetRowCellValue(i, Me.colCodigoTalla) = Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoTalla) Then
                        MsgBox("El artículo seleccionado ya ha sido añadido anteriormente", MsgBoxStyle.Information)
                        Me.gvArticulos.CancelUpdateCurrentRow()
                        Me.gvArticulos.FocusedColumn = Me.colFechaVigor
                        Me.gvArticulos.MoveLastVisible()
                        Exit Sub
                    End If
                Next
            End If

        Catch ex As Exception
            MsgBox("Error al validar la línea", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "gvArticulos_InvalidRowException"
    Private Sub gvArticulos_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvArticulos.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
#End Region

#Region "checkActualizacionDirecta_CheckedChanged"
    Private Sub checkActualizacionDirecta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkActualizacionDirecta.CheckedChanged
        Me.txtFechaVigor.Properties.ReadOnly = Me.checkActualizacionDirecta.Checked
        If Me.checkActualizacionDirecta.Checked Then
            Me.bttActualizar.Text = "Actualiza precios"
        Else
            Me.bttActualizar.Text = "Guardar cambios"
        End If
    End Sub
#End Region

#Region "bttActualizar_Click"
    Private Sub bttActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttActualizar.Click
        Try
            Dim i As Integer

            Me.Cursor = Cursors.WaitCursor

            'Desmarcar los que no cambia precio
            For i = 0 To Me.gvArticulos.RowCount - 1
                If Me.gvArticulos.GetRowCellValue(i, Me.colPrecioActual) = Me.gvArticulos.GetRowCellValue(i, Me.colPrecioTarifa) Then
                    Me.gvArticulos.SetRowCellValue(i, Me.colActualiza, False)
                End If
            Next

            If Me.checkActualizacionDirecta.Checked Then
                For i = 0 To Me.gvArticulos.RowCount - 1
                    If Me.gvArticulos.GetRowCellValue(i, Me.colActualiza) Then
                        Almacen.ActualizaPrecio(Me.gvArticulos.GetRowCellValue(i, Me.colCodigoArticulo), Me.gvArticulos.GetRowCellValue(i, Me.colCodigoColor), Me.gvArticulos.GetRowCellValue(i, Me.colCodigoTalla), Me.gvArticulos.GetRowCellValue(i, Me.colPrecioTarifa), ImpresionEtiquetas)
                    End If
                Next
            Else
                'Eliminar artículos sin marca de actualizar
                For i = Me.gvArticulos.RowCount - 1 To 0 Step -1
                    If Not Me.gvArticulos.GetRowCellValue(i, Me.colActualiza) Then
                        Me.gvArticulos.DeleteRow(i)
                    End If
                Next
                Me.MODIFICACIONESPENDIENTESBindingSource.EndEdit()
                Me.MODIFICACIONES_PENDIENTESTableAdapter.Update(Me.DsModificacionesPendientes.MODIFICACIONES_PENDIENTES)
            End If

            Me.DsModificacionesPendientes.Clear()
            Me.txtCodigoProveedor.EditValue = String.Empty
            Me.txtNombreProveedor.EditValue = String.Empty
            Me.txtCodigoFamilia.EditValue = String.Empty
            Me.txtDescripcionFamilia.EditValue = String.Empty
            Me.txtCodigoSubfamilia.EditValue = String.Empty
            Me.txtDescripcionSubfamilia.EditValue = String.Empty
            Me.txtIncremento.EditValue = 0
            Me.txtTipoRedondeo.SelectedIndex = 0
            Me.checkConformidad.Checked = False
            Me.checkActualizacionDirecta.Checked = True
            Me.txtFechaVigor.EditValue = Date.Today

        Catch ex As Exception
            MsgBox("Error al actualizar los precios de los artículos", MsgBoxStyle.Exclamation)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "txtFechaVigor_EditValueChanged"
    Private Sub txtFechaVigor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFechaVigor.EditValueChanged
        Try
            'Valor por defecto para nuevas líneas
            Me.DsModificacionesPendientes.MODIFICACIONES_PENDIENTES.FechaVigorColumn.DefaultValue = Me.txtFechaVigor.EditValue
            'Actualizar líneas actuales
            Dim i As Integer
            For i = 0 To Me.gvArticulos.RowCount - 1
                Me.gvArticulos.SetRowCellValue(i, Me.colFechaVigor, Me.txtFechaVigor.EditValue)
            Next
        Catch ex As Exception
            MsgBox("Error al actualizar la fecha de entrada en vigor de los artículos", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "gvArticulos_CustomDrawCell"
    Private Sub gvArticulos_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvArticulos.CustomDrawCell
        Try
            If Not e.Column Is Me.colDescripcionColor Then Exit Sub
            If IsNumeric(e.DisplayText) Then
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(e.DisplayText)), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
                e.Appearance.ForeColor = Color.FromArgb(e.DisplayText)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click

        Dim conexion As New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        conexion.Open()
        Dim transaccion As SqlClient.SqlTransaction
        transaccion = conexion.BeginTransaction()

        Try
            Dim dsPendientes As New dsModificacionesPendientes
            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = conexion
            cmd.Transaction = transaccion
            cmd.CommandText = "SELECT FechaVigor,'' AS CodigoArticulo FROM MODIFICACIONES_PENDIENTES GROUP BY FechaVigor"
            dsPendientes.MODIFICACIONES_PENDIENTES.Load(cmd.ExecuteReader)

            Dim Columnas As New ArrayList
            Columnas.Add("FechaVigor")
            Columnas.Add("Fecha Vigor")
            Columnas.Add(80)
            Columnas.Add(80)

            If Buscar(dsPendientes, "MODIFICACIONES_PENDIENTES", Columnas, 0).ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim dr As SqlClient.SqlDataReader
                Dim rModificacionesPendientes As dsModificacionesPendientes.MODIFICACIONES_PENDIENTESRow

                Me.DsModificacionesPendientes.Clear()
                cmd.CommandText = "SELECT * FROM MODIFICACIONES_PENDIENTES WHERE FechaVigor='" & ResultadoBusqueda & "'"

                dr = cmd.ExecuteReader
                While dr.Read
                    rModificacionesPendientes = Me.DsModificacionesPendientes.MODIFICACIONES_PENDIENTES.NewMODIFICACIONES_PENDIENTESRow
                    rModificacionesPendientes.FechaVigor = ResultadoBusqueda
                    rModificacionesPendientes.CodigoArticulo = dr("CodigoArticulo")
                    rModificacionesPendientes.Descripcion = DameDescripcionArticulo(rModificacionesPendientes.CodigoArticulo)
                    rModificacionesPendientes.PrecioTarifa = dr("PrecioTarifa")
                    rModificacionesPendientes.CodigoColor = dr("CodigoColor")
                    rModificacionesPendientes.CodigoTalla = dr("CodigoTalla")
                    rModificacionesPendientes.PrecioActual = DamePrecioArticulo(rModificacionesPendientes.CodigoArticulo, IIf(Not rModificacionesPendientes.Item("CodigoColor") Is System.DBNull.Value, rModificacionesPendientes.Item("CodigoColor"), 0), IIf(Not rModificacionesPendientes.Item("CodigoTalla") Is System.DBNull.Value, rModificacionesPendientes.Item("CodigoTalla"), 1))
                    If Not rModificacionesPendientes.Item("CodigoColor") Is System.DBNull.Value Then rModificacionesPendientes.DescripcionColor = DameColor(rModificacionesPendientes.Item("CodigoColor"))
                    If Not rModificacionesPendientes.Item("CodigoTalla") Is System.DBNull.Value Then rModificacionesPendientes.DescripcionTalla = DameTallaArticulo(rModificacionesPendientes.CodigoArticulo, rModificacionesPendientes.Item("CodigoTalla"))
                    Me.DsModificacionesPendientes.MODIFICACIONES_PENDIENTES.AddMODIFICACIONES_PENDIENTESRow(rModificacionesPendientes)
                End While
                dr.Close()

                Me.checkActualizacionDirecta.Checked = False
                Me.txtFechaVigor.EditValue = ResultadoBusqueda
                Me.gvArticulos.MoveLastVisible()
                Me.gvArticulos.Focus()

                'Borrar registros de la base de datos
                cmd.CommandText = "DELETE FROM MODIFICACIONES_PENDIENTES WHERE FechaVigor='" & ResultadoBusqueda & "'"
                cmd.ExecuteNonQuery()

            End If

            transaccion.Commit()

        Catch ex As Exception
            transaccion.Rollback()
            MsgBox("Error al buscar modificaciones pendientes", MsgBoxStyle.Exclamation)
        End Try

        conexion.Close()

    End Sub
#End Region

#Region "LineaRepetida"
    Private Function LineaRepetida(ByVal CodigoArticulo As String, ByVal CodigoColor As Integer, ByVal CodigoTalla As Integer)
        Dim Existe As Boolean
        Dim i As Integer

        For i = 0 To Me.gvArticulos.RowCount - 1
            If Me.gvArticulos.GetRowCellValue(i, Me.colCodigoArticulo) = CodigoArticulo And Me.gvArticulos.GetRowCellValue(i, Me.colCodigoColor) = CodigoColor And Me.gvArticulos.GetRowCellValue(i, Me.colCodigoTalla) = CodigoTalla Then
                Existe = True
                Exit For
            End If
        Next

        Return Existe

    End Function
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.Close()
    End Sub
#End Region

End Class