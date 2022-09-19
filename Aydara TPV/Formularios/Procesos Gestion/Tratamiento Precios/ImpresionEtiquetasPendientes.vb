Public Class ImpresionEtiquetasPendientes

#Region "ImpresionEtiquetasPendientes_KeyUp"
    Private Sub ImpresionEtiquetasPendientes_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "ImpresionEtiquetasPendientes_Load"
    Private Sub ImpresionEtiquetasPendientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            Me.Cursor = Cursors.WaitCursor

            'Cargar etiquetas pendientes
            Dim rEtiqueta As dsEtiquetas.ETIQUETASRow
            Dim DatosUnidad As New Almacen.DatosUnidad
            Dim i As Integer

            cmd.CommandText = "SELECT ETIQUETAS.CodigoArticulo, ETIQUETAS.CodigoColor, ETIQUETAS.CodigoTalla, ETIQUETAS.Etiquetas, ARTICULOS.Descripcion, " & _
                              "CASE WHEN EXISTENCIAS.PrecioVenta <> 0 THEN EXISTENCIAS.PrecioVenta ELSE ARTICULOS.Precio END AS Precio, " & _
                              "ISNULL(ARTICULOS.PesoUnidad,0) AS DescripcionPrecioUnidad " & _
                              "FROM (ETIQUETAS INNER JOIN ARTICULOS ON ETIQUETAS.CodigoArticulo = ARTICULOS.Codigo) " & _
                              "INNER JOIN EXISTENCIAS ON ARTICULOS.Id = EXISTENCIAS.Articulo_Id " & _
                              "WHERE EXISTENCIAS.CodigoTienda = " & CodigoTienda & " AND EXISTENCIAS.CodigoColor = ETIQUETAS.CodigoColor AND EXISTENCIAS.CodigoTalla = ETIQUETAS.CodigoTalla"

            Me.DsEtiquetas.ETIQUETAS.Load(cmd.ExecuteReader)

            For i = 0 To Me.DsEtiquetas.ETIQUETAS.Rows.Count - 1
                rEtiqueta = Me.DsEtiquetas.ETIQUETAS.Rows(i)
                'rEtiqueta.Descripcion = DameDescripcionArticulo(rEtiqueta.CodigoArticulo)
                If GestionColores Then rEtiqueta.DescripcionColor = DameColor(rEtiqueta.CodigoColor)
                If GestionTallas Then rEtiqueta.DescripcionTalla = DameTallaArticulo(rEtiqueta.CodigoArticulo, rEtiqueta.CodigoTalla)
                'rEtiqueta.Precio = Math.Round(DamePrecioArticulo(rEtiqueta.CodigoArticulo, rEtiqueta.CodigoColor, rEtiqueta.CodigoTalla), DecimalesPrecio, MidpointRounding.AwayFromZero)
                'DatosUnidad = Almacen.DameDatosUnidadArticulo(rEtiqueta.CodigoArticulo)
                'If DatosUnidad.Peso <> 0 And DatosUnidad.Peso <> 1 Then rEtiqueta.DescripcionPrecioUnidad = "EL " & DatosUnidad.Descripcion & " LE SALE A " & Math.Round(rEtiqueta.Precio / DatosUnidad.Peso, DecimalesPrecio, MidpointRounding.AwayFromZero)
                rEtiqueta.Precio = Math.Round(CType(rEtiqueta.Precio, Decimal), DecimalesPrecio, MidpointRounding.AwayFromZero)
                If rEtiqueta.DescripcionPrecioUnidad <> 0 And rEtiqueta.DescripcionPrecioUnidad <> 1 Then
                    DatosUnidad = Almacen.DameDatosUnidadArticulo(rEtiqueta.CodigoArticulo)
                    If DatosUnidad.Peso <> 0 And DatosUnidad.Peso <> 1 Then rEtiqueta.DescripcionPrecioUnidad = "EL " & DatosUnidad.Descripcion & " LE SALE A " & Math.Round(rEtiqueta.Precio / DatosUnidad.Peso, DecimalesPrecio, MidpointRounding.AwayFromZero)
                Else
                    rEtiqueta.DescripcionPrecioUnidad = String.Empty
                End If

                rEtiqueta.Stock = Almacen.DatosExistenciasArticulo(rEtiqueta.CodigoArticulo, rEtiqueta.CodigoColor, rEtiqueta.CodigoTalla).ExistenciaActual

            Next

            Me.DsEtiquetas.AcceptChanges()

        Catch ex As Exception
            MsgBox("Error al cargar las etiquetas pendientes", MsgBoxStyle.Exclamation)
        Finally
            Me.Cursor = Cursors.Default
        End Try

        cmd.Connection.Close()

    End Sub
#End Region

#Region "ImpresionEtiquetasPendientes_Shown"
    Private Sub ImpresionEtiquetasPendientes_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en precios
        Me.maskPrecio.Mask.EditMask = "c" & DecimalesPrecio
        'Mostrar color y talla
        Me.gbColor.Visible = GestionColores
        Me.gbTalla.Visible = GestionTallas
    End Sub
#End Region

#Region "ImpresionEtiquetasPendientes_FormClosing"
    Private Sub ImpresionEtiquetasPendientes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.ETIQUETASBindingSource.EndEdit()
        If Me.DsEtiquetas.HasChanges Then
            If MsgBox("¿Desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.ETIQUETASTableAdapter.Update(Me.DsEtiquetas.ETIQUETAS)
            End If
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
                Me.gvArticulos.FocusedColumn = IIf(GestionColores, Me.colCodigoColor, IIf(GestionTallas, Me.colCodigoTalla, Me.colPrecioActual))
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
            Me.DsEtiquetas.COLORES.Clear()
            Me.DsEtiquetas.TALLAS.Clear()

            'Comprobar si es un código de barras
            If Len(Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo)) > 7 Then

                cmd.CommandText = "select ISNULL(articulos.Codigo,'') from articulos " & _
                                  "left join Codigo_Barras on articulos.id=codigo_barras.articulo_id " & _
                                  "where codigo_barras.codigobarras='" & Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo) & "'"

                CodigoArticulo = cmd.ExecuteScalar

                If CodigoArticulo <> String.Empty Then
                    Me.gvArticulos.SetFocusedRowCellValue(Me.colCodigoArticulo, CodigoArticulo)
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
                Me.gvArticulos.SetFocusedRowCellValue(Me.colPrecioActual, 0)
                Me.gvArticulos.SetFocusedRowCellValue(Me.colStock, 0)
                'Me.txtCodigoArticulo.Focus()
                Exit Sub
            End If

            'Cargar colores y tallas del artículo
            If GestionColores Or GestionTallas Then Me.CargarTallasColores()

            'Preciotarifa del artículo
            Me.gvArticulos.SetFocusedRowCellValue(Me.colPrecioActual, Math.Round(DamePrecioArticulo(Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo), IIf(Not Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoColor) Is System.DBNull.Value, Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoColor), 0), IIf(Not Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoTalla) Is System.DBNull.Value, Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoTalla), 1)), DecimalesPrecio, MidpointRounding.AwayFromZero))
            'Me.gvArticulos.SetFocusedRowCellValue(Me.colPrecioActual, Me.gvArticulos.GetFocusedRowCellValue(Me.colPrecioActual))
            Me.gvArticulos.SetFocusedRowCellValue(Me.colStock, Almacen.DatosExistenciasArticulo(Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo), Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoColor), Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoTalla)).ExistenciaActual)

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
                Me.gvArticulos.SetFocusedRowCellValue(Me.colPrecioActual, Me.gvArticulos.GetFocusedRowCellValue(Me.colPrecioActual))
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

        Me.DsEtiquetas.COLORES.Clear()
        Me.DsEtiquetas.TALLAS.Clear()

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
            Me.COLORESTableAdapter.Articulo(Me.DsEtiquetas.COLORES, Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoArticulo))

            cmd.CommandText = "SELECT * FROM Tallas WHERE CodigoTalla=" & CodigoTalla
            dr = cmd.ExecuteReader
            If dr.Read Then
                Dim i As Integer
                For i = 1 To 18
                    Me.DsEtiquetas.TALLAS.AddTALLASRow(i, dr("Talla_" & i))
                Next
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox("Error al mostrar información de tallas y colores del artículo", MsgBoxStyle.Exclamation)
        End Try

        cmd.Connection.Close()

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

#Region "bttImprimir_Click"
    Private Sub bttImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimir.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Informe As New InfListadoEtiquetas

            Dim dsImprimir As New dsEtiquetas
            Dim rEtiqueta As dsEtiquetas.IMPRIMIRRow

            Dim i As Integer, j As Integer
            For i = 0 To Me.DsEtiquetas.ETIQUETAS.Count - 1
                If Me.DsEtiquetas.ETIQUETAS(i).Imprimir Then
                    For j = 1 To Me.DsEtiquetas.ETIQUETAS(i).Etiquetas
                        rEtiqueta = dsImprimir.IMPRIMIR.NewIMPRIMIRRow
                        rEtiqueta.CodigoArticulo = Me.DsEtiquetas.ETIQUETAS(i).CodigoArticulo
                        rEtiqueta.CodigoColor = Me.DsEtiquetas.ETIQUETAS(i).CodigoColor
                        rEtiqueta.CodigoTalla = Me.DsEtiquetas.ETIQUETAS(i).CodigoTalla
                        rEtiqueta.Descripcion = Me.DsEtiquetas.ETIQUETAS(i).Descripcion
                        rEtiqueta.DescripcionColor = Me.DsEtiquetas.ETIQUETAS(i).DescripcionColor
                        rEtiqueta.DescripcionTalla = Me.DsEtiquetas.ETIQUETAS(i).DescripcionTalla
                        rEtiqueta.Precio = Me.DsEtiquetas.ETIQUETAS(i).Precio
                        rEtiqueta.DescripcionPrecioUnidad = Me.DsEtiquetas.ETIQUETAS(i).DescripcionPrecioUnidad
                        rEtiqueta.ReferenciaProveedor = AGI2005.BaseDatos.ConsultaDevuelveValor("SELECT REFERENCIAS_PROVEEDORES.Referencia FROM ARTICULOS LEFT JOIN REFERENCIAS_PROVEEDORES ON ARTICULOS.Id = REFERENCIAS_PROVEEDORES.Articulo_Id AND ARTICULOS.CodigoProveedor = REFERENCIAS_PROVEEDORES.CodigoProveedor WHERE ARTICULOS.Codigo = '" & rEtiqueta.CodigoArticulo & "'", AGI2005.BaseDatos.TipoValor.Texto, My.Settings.AydaraTPVConnectionString)
                        dsImprimir.IMPRIMIR.AddIMPRIMIRRow(rEtiqueta)
                    Next
                End If
            Next

            Informe.DataSource = dsImprimir

            Informe.Prefijo.Value = PrefijoEtiqueta
            Informe.RequestParameters = False

            Informe.CreateDocument()

            Dim f As New PreImpreso
            f.Informe.PrintingSystem = Informe.PrintingSystem

            General.AbrirFormulario(f, "Listado de etiquetas")

            'Eliminar etiquetas
            'Me.bttEliminar_Click(Nothing, Nothing)

        Catch ex As Exception
            MsgBox("Error al cargar los datos del listado", MsgBoxStyle.Exclamation)
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

#Region "bttEliminar_Click"
    Public Sub bttEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttEliminar.Click
        Try
            If MsgBox("¿Desea eliminar las etiquetas pendientes de imprimir?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                While Me.gvArticulos.RowCount > 0
                    If IsNothing(Me.gvArticulos.GetRow(0)) Then Exit While
                    Me.gvArticulos.DeleteRow(0)
                End While

                Me.ETIQUETASBindingSource.EndEdit()
                Me.ETIQUETASTableAdapter.Update(Me.DsEtiquetas.ETIQUETAS)
            End If

        Catch ex As Exception
            MsgBox("Error al eliminar las etiquetas pendientes", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.Close()
    End Sub
#End Region

#Region "bttCodigosBarras_Click"
    Private Sub bttCodigosBarras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCodigosBarras.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Informe As New InfCodigosBarras

            Dim dsImprimir As New dsEtiquetas
            Dim rEtiqueta As dsEtiquetas.IMPRIMIRRow

            Dim i As Integer, j As Integer
            For i = 0 To Me.DsEtiquetas.ETIQUETAS.Count - 1
                If Me.DsEtiquetas.ETIQUETAS(i).Imprimir Then
                    For j = 1 To Me.DsEtiquetas.ETIQUETAS(i).Etiquetas
                        rEtiqueta = dsImprimir.IMPRIMIR.NewIMPRIMIRRow
                        rEtiqueta.CodigoArticulo = Me.DsEtiquetas.ETIQUETAS(i).CodigoArticulo
                        rEtiqueta.CodigoColor = Me.DsEtiquetas.ETIQUETAS(i).CodigoColor
                        rEtiqueta.CodigoTalla = Me.DsEtiquetas.ETIQUETAS(i).CodigoTalla
                        rEtiqueta.Descripcion = Me.DsEtiquetas.ETIQUETAS(i).Descripcion
                        rEtiqueta.DescripcionColor = Me.DsEtiquetas.ETIQUETAS(i).DescripcionColor
                        rEtiqueta.DescripcionTalla = Me.DsEtiquetas.ETIQUETAS(i).DescripcionTalla
                        rEtiqueta.Precio = Me.DsEtiquetas.ETIQUETAS(i).Precio
                        rEtiqueta.DescripcionPrecioUnidad = Me.DsEtiquetas.ETIQUETAS(i).DescripcionPrecioUnidad
                        dsImprimir.IMPRIMIR.AddIMPRIMIRRow(rEtiqueta)
                    Next
                End If
            Next

            Informe.DataSource = dsImprimir

            Informe.Prefijo.Value = PrefijoEtiqueta
            Informe.RequestParameters = False

            Informe.CreateDocument()

            Dim f As New PreImpreso
            f.Informe.PrintingSystem = Informe.PrintingSystem

            General.AbrirFormulario(f, "Códigos de barras")

            'Eliminar etiquetas
            'Me.bttEliminar_Click(Nothing, Nothing)

        Catch ex As Exception
            MsgBox("Error al cargar los datos del listado", MsgBoxStyle.Exclamation)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "cmbColores_EditValueChanged"
    Private Sub cmbColores_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbColores.EditValueChanged
        Me.gvArticulos.FocusedColumn = Me.colCodigoTalla
    End Sub
#End Region

#Region "cmbTallas_EditValueChanged"
    Private Sub cmbTallas_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTallas.EditValueChanged
        Me.gvArticulos.FocusedColumn = Me.colImprimir
    End Sub
#End Region

    'Panel añadir artículos

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

#Region "txtCodigoInicio_Validated"
    Private Sub txtCodigoArticulo_Desde_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoArticulo_Desde.Validated
        If Not Me.txtCodigoArticulo_Desde.IsModified Then Exit Sub
        'If IsNumeric(Me.txtCodigoArticulo_Desde.EditValue) Then Me.txtCodigoArticulo_Desde.EditValue = Format(CType(Me.txtCodigoArticulo_Desde.EditValue, Integer), "0000000")
    End Sub
#End Region

#Region "txtCodigoFin_Validated"
    Private Sub txtCodigoArticulo_Hasta_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoArticulo_Hasta.Validated
        If Not Me.txtCodigoArticulo_Hasta.IsModified Or Me.txtCodigoArticulo_Hasta.EditValue = String.Empty Then Exit Sub
        'If IsNumeric(Me.txtCodigoArticulo_Hasta.EditValue) Then Me.txtCodigoArticulo_Hasta.EditValue = Format(CType(Me.txtCodigoArticulo_Hasta.EditValue, Integer), "0000000")
    End Sub
#End Region

#Region "bttImportarArticulos_Click"
    Private Sub bttImportarArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImportarArticulos.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim rEtiqueta As dsEtiquetas.ETIQUETASRow

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

            If Me.txtCodigoArticulo_Desde.EditValue <> String.Empty Then
                cmd.CommandText &= " AND Codigo >= '" & Me.txtCodigoArticulo_Desde.EditValue & "'"
            End If

            If Me.txtCodigoArticulo_Hasta.EditValue <> String.Empty Then
                cmd.CommandText &= " AND Codigo <= '" & Me.txtCodigoArticulo_Hasta.EditValue & "'"
            End If

            dr = cmd.ExecuteReader
            While dr.Read
                Try
                    If Me.LineaRepetida(dr("Codigo"), 0, 1) Then Exit Try
                    rEtiqueta = Me.DsEtiquetas.ETIQUETAS.NewETIQUETASRow
                    rEtiqueta.CodigoArticulo = dr("Codigo")
                    rEtiqueta.Descripcion = dr("Descripcion")
                    rEtiqueta.Precio = Math.Round(DamePrecioArticulo(rEtiqueta.CodigoArticulo, 0, 1), DecimalesPrecio, MidpointRounding.AwayFromZero)
                    rEtiqueta.Stock = Almacen.DatosExistenciasArticulo(rEtiqueta.CodigoArticulo, rEtiqueta.CodigoColor, rEtiqueta.CodigoTalla).ExistenciaActual
                    Me.DsEtiquetas.ETIQUETAS.AddETIQUETASRow(rEtiqueta)

                Catch ex As Exception
                    MsgBox("Error al importar el artículo " & dr("codigo") & ": " & dr("Descripcion"), MsgBoxStyle.Exclamation)
                End Try
            End While
            dr.Close()

            cmd.Connection.Close()

            Me.txtCodigoFamilia.EditValue = String.Empty
            Me.txtDescripcionFamilia.EditValue = String.Empty
            Me.txtCodigoSubfamilia.EditValue = String.Empty
            Me.txtDescripcionSubfamilia.EditValue = String.Empty
            Me.txtCodigoArticulo_Desde.EditValue = String.Empty
            Me.txtCodigoArticulo_Hasta.EditValue = String.Empty
            Me.gvArticulos.MoveLastVisible()
            Me.gvArticulos.Focus()

        Catch ex As Exception
            MsgBox("Error al importar los artículos", MsgBoxStyle.Exclamation)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

    Private Sub checkFidelizacion_CheckedChanged(sender As Object, e As EventArgs) Handles checkFidelizacion.CheckedChanged
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttEtiquetaIndividual_Click(sender As Object, e As EventArgs) Handles bttEtiquetaIndividual.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Informe As New InfEtiquetaIndividual

            Dim dsImprimir As New dsEtiquetas
            Dim rEtiqueta As dsEtiquetas.IMPRIMIRRow

            Dim i As Integer, j As Integer
            For i = 0 To Me.DsEtiquetas.ETIQUETAS.Count - 1
                If Me.DsEtiquetas.ETIQUETAS(i).Imprimir Then
                    For j = 1 To Me.DsEtiquetas.ETIQUETAS(i).Etiquetas
                        rEtiqueta = dsImprimir.IMPRIMIR.NewIMPRIMIRRow
                        rEtiqueta.CodigoArticulo = Me.DsEtiquetas.ETIQUETAS(i).CodigoArticulo
                        rEtiqueta.CodigoColor = Me.DsEtiquetas.ETIQUETAS(i).CodigoColor
                        rEtiqueta.CodigoTalla = Me.DsEtiquetas.ETIQUETAS(i).CodigoTalla
                        rEtiqueta.Descripcion = Me.DsEtiquetas.ETIQUETAS(i).Descripcion
                        rEtiqueta.DescripcionColor = Me.DsEtiquetas.ETIQUETAS(i).DescripcionColor
                        rEtiqueta.DescripcionTalla = Me.DsEtiquetas.ETIQUETAS(i).DescripcionTalla
                        rEtiqueta.Precio = Me.DsEtiquetas.ETIQUETAS(i).Precio
                        rEtiqueta.DescripcionPrecioUnidad = Me.DsEtiquetas.ETIQUETAS(i).DescripcionPrecioUnidad
                        rEtiqueta.ReferenciaProveedor = AGI2005.BaseDatos.ConsultaDevuelveValor("SELECT REFERENCIAS_PROVEEDORES.Referencia FROM ARTICULOS LEFT JOIN REFERENCIAS_PROVEEDORES ON ARTICULOS.Id = REFERENCIAS_PROVEEDORES.Articulo_Id AND ARTICULOS.CodigoProveedor = REFERENCIAS_PROVEEDORES.CodigoProveedor WHERE ARTICULOS.Codigo = '" & rEtiqueta.CodigoArticulo & "'", AGI2005.BaseDatos.TipoValor.Texto, My.Settings.AydaraTPVConnectionString)
                        dsImprimir.IMPRIMIR.AddIMPRIMIRRow(rEtiqueta)
                    Next
                End If
            Next

            Informe.DataSource = dsImprimir

            Informe.Prefijo.Value = PrefijoEtiqueta
            Informe.RequestParameters = False

            Informe.CreateDocument()

            Dim f As New PreImpreso
            f.Informe.PrintingSystem = Informe.PrintingSystem

            General.AbrirFormulario(f, "Listado de etiquetas")

            'Eliminar etiquetas
            'Me.bttEliminar_Click(Nothing, Nothing)

        Catch ex As Exception
            MsgBox("Error al cargar los datos del listado", MsgBoxStyle.Exclamation)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

End Class