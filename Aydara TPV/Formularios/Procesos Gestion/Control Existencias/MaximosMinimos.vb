Public Class MaximosMinimos

#Region "MaximosMinimos_KeyUp"
    Private Sub MaximosMinimos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "MaximosMinimos_Shown"
    Private Sub MaximosMinimos_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en precios
        Me.maskPrecio.Mask.EditMask = "c" & DecimalesPrecio
        'Mostrar color y talla
        Me.gbColor.Visible = GestionColores
        Me.gbTalla.Visible = GestionTallas
    End Sub
#End Region

#Region "MaximosMinimos_FormClosing"
    Private Sub MaximosMinimos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.DsInventario.EXISTENCIAS.Rows.Count > 0 Then
            If MsgBox("¿Seguro que desea cancelar la actualización del inventario?" & vbCrLf & "Si continua perderá toda la información cargada.", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then e.Cancel = True
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
                Me.gvArticulos.FocusedColumn = IIf(GestionColores, Me.colCodigoColor, IIf(GestionTallas, Me.colCodigoTalla, Me.colStockMinimo))
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
            Me.DsInventario.COLORES.Clear()
            Me.DsInventario.TALLAS.Clear()

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
                    Me.gvArticulos.SetFocusedRowCellValue(Me.colExistencias_Id, 0)
                    Me.gvArticulos.SetFocusedRowCellValue(Me.colExistenciaInicial, 0)
                    Me.gvArticulos.SetFocusedRowCellValue(Me.colExistenciaActual, 0)
                    Me.gvArticulos.SetFocusedRowCellValue(Me.colStockMinimo, 0)
                    Me.gvArticulos.SetFocusedRowCellValue(Me.colStockMaximo, 0)
                    Me.gvArticulos.SetFocusedRowCellValue(Me.colPrecioVenta, 0)
                    'Me.txtCodigoArticulo.Focus()
                    Exit Try
                End If

            End If

            'If IsNumeric(Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo)) Then Me.gvArticulos.SetFocusedRowCellValue(Me.colCodigoArticulo, Format(CType(Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo), Integer), "0000000"))

            'Mostrar información del artículo
            Dim CodigoTalla As Integer = 0

            cmd.CommandText = "SELECT ARTICULOS.Codigo AS CodigoArticulo, ARTICULOS.Descripcion, ARTICULOS.UnidadCaja, EXISTENCIAS.* " & _
                              "FROM ARTICULOS INNER JOIN EXISTENCIAS ON ARTICULOS.Id = EXISTENCIAS.Articulo_Id " & _
                              "WHERE EXISTENCIAS.CodigoTienda=" & General.CodigoTienda & " AND ARTICULOS.Codigo='" & Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo) & "'"

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                Me.gvArticulos.SetFocusedRowCellValue(Me.colDescripcion, dr("Descripcion"))
                CodigoTalla = dr("CodigoTalla")
                dr.Close()
            Else
                'MsgBox("No existe ningún artículo con ese código", MsgBoxStyle.Information, "No existe")
                Me.gvArticulos.SetFocusedRowCellValue(Me.colCodigoArticulo, String.Empty)
                Me.gvArticulos.SetFocusedRowCellValue(Me.colDescripcion, String.Empty)
                Me.gvArticulos.SetFocusedRowCellValue(Me.colExistencias_Id, 0)
                Me.gvArticulos.SetFocusedRowCellValue(Me.colExistenciaInicial, 0)
                Me.gvArticulos.SetFocusedRowCellValue(Me.colExistenciaActual, 0)
                Me.gvArticulos.SetFocusedRowCellValue(Me.colUnidadesCaja, 0)
                Me.gvArticulos.SetFocusedRowCellValue(Me.colStockMinimo, 0)
                Me.gvArticulos.SetFocusedRowCellValue(Me.colStockMaximo, 0)
                Me.gvArticulos.SetFocusedRowCellValue(Me.colPrecioVenta, 0)
                'Me.txtCodigoArticulo.Focus()
                Exit Try
            End If

            'Cargar colores y tallas del artículo
            If GestionColores Or GestionTallas Then Me.CargarTallasColores()

            'Datos de existencias del artículo
            Dim ExistenciasArticulo As Almacen.DatosExistencias = Almacen.DatosExistenciasArticulo(Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo), IIf(Not Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoColor) Is System.DBNull.Value, Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoColor), 0), IIf(Not Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoTalla) Is System.DBNull.Value, Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoTalla), 1))
            Me.gvArticulos.SetFocusedRowCellValue(Me.colExistencias_Id, ExistenciasArticulo.Id)
            Me.gvArticulos.SetFocusedRowCellValue(Me.colExistenciaInicial, ExistenciasArticulo.ExistenciaInicial)
            Me.gvArticulos.SetFocusedRowCellValue(Me.colExistenciaActual, ExistenciasArticulo.ExistenciaActual)
            Me.gvArticulos.SetFocusedRowCellValue(Me.colUnidadesCaja, Almacen.DameUnidadesCajaArticulo(Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo)))
            Me.gvArticulos.SetFocusedRowCellValue(Me.colStockMinimo, ExistenciasArticulo.StockMinimo)
            Me.gvArticulos.SetFocusedRowCellValue(Me.colStockMaximo, ExistenciasArticulo.StockMaximo)
            Me.gvArticulos.SetFocusedRowCellValue(Me.colPrecioVenta, ExistenciasArticulo.PrecioVenta)

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
            'Actualizar existencias
            If e.Column Is Me.colCodigoColor Or e.Column Is Me.colCodigoTalla Then
                'Datos de existencias del artículo
                Dim ExistenciasArticulo As Almacen.DatosExistencias = Almacen.DatosExistenciasArticulo(Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo), IIf(Not Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoColor) Is System.DBNull.Value, Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoColor), 0), IIf(Not Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoTalla) Is System.DBNull.Value, Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoTalla), 1))
                Me.gvArticulos.SetFocusedRowCellValue(Me.colExistencias_Id, ExistenciasArticulo.Id)
                Me.gvArticulos.SetFocusedRowCellValue(Me.colExistenciaInicial, ExistenciasArticulo.ExistenciaInicial)
                Me.gvArticulos.SetFocusedRowCellValue(Me.colExistenciaActual, ExistenciasArticulo.ExistenciaActual)
                Me.gvArticulos.SetFocusedRowCellValue(Me.colStockMinimo, ExistenciasArticulo.StockMinimo)
                Me.gvArticulos.SetFocusedRowCellValue(Me.colStockMaximo, ExistenciasArticulo.StockMaximo)
                Me.gvArticulos.SetFocusedRowCellValue(Me.colPrecioVenta, ExistenciasArticulo.PrecioVenta)
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "gvArticulos_FocusedRowChanged"
    Private Sub gvArticulos_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvArticulos.FocusedRowChanged
        If Me.gvArticulos.IsNewItemRow(e.FocusedRowHandle) Then
            Me.colCodigoArticulo.OptionsColumn.AllowFocus = True
            Me.gvArticulos.FocusedColumn = Me.colCodigoArticulo
        Else
            Me.colCodigoArticulo.OptionsColumn.AllowFocus = False
            Me.gvArticulos.FocusedColumn = Me.colStockMinimo
        End If
        If GestionColores Or GestionTallas Then Me.CargarTallasColores()
    End Sub
#End Region

#Region "CargarTallasColores"
    Private Sub CargarTallasColores()

        Me.DsInventario.COLORES.Clear()
        Me.DsInventario.TALLAS.Clear()

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
            Me.COLORESTableAdapter.Articulo(Me.DsInventario.COLORES, Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo))

            cmd.CommandText = "SELECT * FROM Tallas WHERE CodigoTalla=" & CodigoTalla
            dr = cmd.ExecuteReader
            If dr.Read Then
                Dim i As Integer
                For i = 1 To 18
                    Me.DsInventario.TALLAS.AddTALLASRow(i, dr("Talla_" & i))
                Next
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox("Error al mostrar información de tallas y colores del artículo", MsgBoxStyle.Exclamation)
        End Try

        cmd.Connection.Close()

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

        Dim cmd As New SqlClient.SqlCommand

        Try
            Me.Cursor = Cursors.WaitCursor

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT ARTICULOS.Codigo AS CodigoArticulo, ARTICULOS.Descripcion, ARTICULOS.UnidadCaja, EXISTENCIAS.* " & _
                              "FROM ARTICULOS INNER JOIN EXISTENCIAS ON ARTICULOS.Id = EXISTENCIAS.Articulo_Id " & _
                              "WHERE ARTICULOS.ControlBaja=0 AND EXISTENCIAS.CodigoTienda=" & General.CodigoTienda

            If Me.txtCodigoFamilia.EditValue <> String.Empty Then
                cmd.CommandText &= " AND CodigoFamilia IN (SELECT Id FROM FAMILIASARTICULOS WHERE Codigo='" & Me.txtCodigoFamilia.EditValue & "')"
            End If

            If Me.txtCodigoSubfamilia.EditValue <> String.Empty Then
                cmd.CommandText &= " AND CodigoSubfamilia IN (SELECT Id FROM SUBFAMILIASARTICULOS WHERE Codigo='" & Me.txtCodigoSubfamilia.EditValue & "')"
            End If

            Me.DsInventario.EXISTENCIAS.Load(cmd.ExecuteReader)

            Me.txtCodigoFamilia.EditValue = String.Empty
            Me.txtDescripcionFamilia.EditValue = String.Empty
            Me.txtCodigoSubfamilia.EditValue = String.Empty
            Me.txtDescripcionSubfamilia.EditValue = String.Empty
            Me.gvArticulos.MoveLastVisible()
            Me.gvArticulos.Focus()

        Catch ex As Exception
            MsgBox("Error al importar los artículos", MsgBoxStyle.Exclamation)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
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
                    Me.gvArticulos.FocusedColumn = Me.colExistencias_Id
                    Exit Try
                End If
            End If

            'Si es nueva línea comprobar que no exista ya en la promoción
            If Me.gvArticulos.IsNewItemRow(e.RowHandle) Then
                Dim i As Integer
                For i = 0 To Me.gvArticulos.RowCount - 1
                    If Me.gvArticulos.GetRowCellValue(i, Me.colCodigoArticulo) = Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo) And Me.gvArticulos.GetRowCellValue(i, Me.colCodigoColor) = Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoColor) And Me.gvArticulos.GetRowCellValue(i, Me.colCodigoTalla) = Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoTalla) Then
                        MsgBox("El artículo seleccionado ya ha sido añadido anteriormente", MsgBoxStyle.Information)
                        Me.gvArticulos.CancelUpdateCurrentRow()
                        Me.gvArticulos.FocusedColumn = Me.colExistencias_Id
                        Me.gvArticulos.MoveLastVisible()
                        Exit Try
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

#Region "bttActualizar_Click"
    Private Sub bttActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttActualizar.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim i As Integer
            Dim rExistencias As dsInventario.EXISTENCIASRow

            For i = 0 To Me.DsInventario.EXISTENCIAS.Rows.Count - 1
                rExistencias = Me.DsInventario.EXISTENCIAS.Rows(i)
                If rExistencias.RowState = DataRowState.Added Or rExistencias.RowState = DataRowState.Modified Then
                    Almacen.ActualizaExistencias(rExistencias.Id, rExistencias.ExistenciaInicial, rExistencias.ExistenciaActual, rExistencias.StockMinimo, rExistencias.StockMaximo, rExistencias.PrecioVenta)
                End If
            Next

            Me.DsInventario.Clear()
            Me.txtCodigoFamilia.EditValue = String.Empty
            Me.txtDescripcionFamilia.EditValue = String.Empty
            Me.txtCodigoSubfamilia.EditValue = String.Empty
            Me.txtDescripcionSubfamilia.EditValue = String.Empty

        Catch ex As Exception
            MsgBox("Error al actualizar el inventario", MsgBoxStyle.Exclamation)
        Finally
            Me.Cursor = Cursors.Default
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