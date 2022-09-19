Public Class Promociones

#Region "Promociones_FormClosing"
    Private Sub Promociones_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.bttCancelar.Text = "Cancelar" And Me.DsPromociones.HasChanges Then
            If MsgBox("Está editando una promoción. ¿Seguro que desea salir sin guardar los cambios?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then e.Cancel = True Else Me.Dispose()
        Else
            'Me.Dispose()
        End If
    End Sub
#End Region

#Region "Promociones_KeyUp"
    Private Sub Promociones_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "Promociones_Shown"
    Private Sub Promociones_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.DsPromociones.PROMOCIONES.CodigoTiendaColumn.DefaultValue = CodigoTienda
        'Decimales en precios
        Me.maskPrecio.Mask.EditMask = "c" & DecimalesPrecio
        'Mostrar color y talla
        Me.gbColor.Visible = GestionColores
        Me.gbTalla.Visible = GestionTallas
    End Sub
#End Region

#Region "bttNuevo_Click"
    Private Sub bttNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttNuevo.Click
        Try
            Me.DsPromociones.PROMOCIONES.Clear()

            Me.ActivaDesactivaMenu(False)
            Me.ActivaDesactivaCampos(False)
            Me.txtFechaInicio.EditValue = Date.Today
            Me.txtFechaInicio_Validated(Nothing, Nothing)
            Me.txtFechaInicio.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttModificar_Click"
    Private Sub bttModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttModificar.Click
        Try
            Me.ActivaDesactivaMenu(False)
            Me.ActivaDesactivaCampos(False)
            Me.gvPromociones.MoveLastVisible()
            Me.gvPromociones.Focus()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            BusquedaPromociones.ShowDialog()
            Me.ActivaDesactivaMenu(True)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "bttEliminar_Click"
    Private Sub bttEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttEliminar.Click
        Try
            If MsgBox("¿Seguro que desea eliminar la promoción seleccionada?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar promoción") = MsgBoxResult.Yes Then
                Me.PROMOCIONESBindingSource.RemoveCurrent()
                Me.PROMOCIONESTableAdapter.Update(Me.DsPromociones.PROMOCIONES)
                Me.ActivaDesactivaMenu(True)
                Me.txtFechaInicio.Focus()
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Try
            If sender.text = "Salir" Then Me.Close() : Exit Sub

            'If MsgBox("¿Seguro que desea deshacer los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Deshacer cambios") = MsgBoxResult.No Then Exit Sub
            Me.DsPromociones.RejectChanges()

            Me.ActivaDesactivaMenu(True)
            Me.ActivaDesactivaCampos(True)

            Me.txtFechaInicio.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttGuardar_Click"
    Private Sub bttGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttGuardar.Click
        Try
            'If MsgBox("¿Seguro que desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar cambios") = MsgBoxResult.No Then Exit Sub

            'Comprobar datos
            If Not IsDate(Me.txtFechaInicio.EditValue) Then
                MsgBox("Seleccione la fecha de inicio de la promoción", MsgBoxStyle.Information, "Falta fecha de inicio")
                Me.txtFechaInicio.Focus()
                Exit Sub
            End If
            If Not IsDate(Me.txtFechaFinal.EditValue) Then
                MsgBox("Seleccione la fecha final de la promoción", MsgBoxStyle.Information, "Falta fecha final")
                Me.txtFechaFinal.Focus()
                Exit Sub
            End If

            'Actualizar fechas de las promociones
            Dim i As Integer
            For i = 0 To Me.gvPromociones.RowCount - 1
                Me.gvPromociones.SetRowCellValue(i, Me.colFechaInicio, Me.txtFechaInicio.EditValue)
                Me.gvPromociones.SetRowCellValue(i, Me.colFechaFinal, Me.txtFechaFinal.EditValue)
            Next

            Me.PROMOCIONESBindingSource.EndEdit()
            Me.PROMOCIONESTableAdapter.Update(Me.DsPromociones.PROMOCIONES)

            Me.ActivaDesactivaMenu(True)
            Me.ActivaDesactivaCampos(True)

            Me.txtFechaInicio.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "ActivaDesactivaMenu"
    Private Sub ActivaDesactivaMenu(ByVal activa As Boolean)
        Me.bttNuevo.Enabled = activa
        Me.bttBuscar.Enabled = activa
        Me.bttModificar.Enabled = IIf(Me.PROMOCIONESBindingSource.Count = 0, False, activa)
        Me.bttEliminar.Enabled = IIf(Me.PROMOCIONESBindingSource.Count = 0, False, activa)
        Me.bttImprimirEtiquetas.Enabled = IIf(Me.PROMOCIONESBindingSource.Count = 0, False, activa)
        Me.bttImprimirPromocion.Enabled = IIf(Me.PROMOCIONESBindingSource.Count = 0, False, activa)
        Me.bttCancelar.Text = IIf(activa, "Salir", "Cancelar")
        Me.bttGuardar.Enabled = Not activa
    End Sub
#End Region

#Region "ActivaDesactivaCampos"
    Private Sub ActivaDesactivaCampos(ByVal activa As Boolean)
        'Panel fechas
        Me.txtFechaInicio.Properties.ReadOnly = activa
        Me.txtFechaFinal.Properties.ReadOnly = activa
        'Panel añadir artículos
        Me.txtCodigoFamilia.Properties.ReadOnly = activa
        Me.txtCodigoFamilia.Properties.Buttons(0).Enabled = Not activa
        If Me.txtCodigoFamilia.EditValue <> String.Empty Then
            Me.txtCodigoSubfamilia.Properties.ReadOnly = activa
            Me.txtCodigoSubfamilia.Properties.Buttons(0).Enabled = Not activa
        Else
            Me.txtCodigoSubfamilia.Properties.ReadOnly = True
            Me.txtCodigoSubfamilia.Properties.Buttons(0).Enabled = False
        End If
        Me.txtDescuento.Properties.ReadOnly = activa
        Me.txtTipoRedondeo.Properties.ReadOnly = activa
        Me.bttImportarArticulos.Enabled = Not activa
        'Grilla datos
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = activa
        Me.bttCodigoArticulo.Buttons(0).Enabled = Not activa
        Me.colCodigoColor.OptionsColumn.ReadOnly = activa
        Me.cmbColores.Buttons(0).Enabled = Not activa
        Me.colCodigoTalla.OptionsColumn.ReadOnly = activa
        Me.cmbTallas.Buttons(0).Enabled = Not activa
        Me.colPrecioPromocion.OptionsColumn.ReadOnly = activa
        Me.colCodigoArticuloRegalo.OptionsColumn.ReadOnly = activa
        Me.colFraccionSinCargo.OptionsColumn.ReadOnly = activa
        Me.colUnidadesSinCargo.OptionsColumn.ReadOnly = activa
        Me.colPrecioArticuloRegalo.OptionsColumn.ReadOnly = activa
        Me.bttArticuloRegalo.Buttons(0).Enabled = Not activa
        Me.gvPromociones.OptionsView.NewItemRowPosition = IIf(activa, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom)
        Me.NavLineas.Buttons.Append.Enabled = Not activa
        Me.NavLineas.Buttons.Remove.Enabled = Not activa
    End Sub
#End Region

#Region "bttCodigoArticulo_ButtonClick"
    Private Sub bttCodigoArticulo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bttCodigoArticulo.ButtonClick, bttArticuloRegalo.ButtonClick
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
                If Me.gvPromociones.GetRow(Me.gvPromociones.FocusedRowHandle) Is Nothing Then Me.gvPromociones.AddNewRow()
                Me.gvPromociones.SetFocusedValue(ResultadoBusqueda)
                Me.gvPromociones.FocusedColumn = IIf(GestionColores, Me.colCodigoColor, IIf(GestionTallas, Me.colCodigoTalla, Me.colPrecioPromocion))
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
            RemoveHandler gvPromociones.CellValueChanged, AddressOf gvPromociones_CellValueChanged

            'Vaciar colores y tallas
            Me.DsPromociones.COLORES.Clear()
            Me.DsPromociones.TALLAS.Clear()

            'Comprobar si es un código de barras
            If Len(Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticulo)) > 7 Then

                cmd.CommandText = "select ISNULL(Codigo,'') from (articulos left join existencias on articulos.id=existencias.articulo_id) " & _
                                  "left join Codigo_Barras on articulos.id=codigo_barras.articulo_id " & _
                                  "where articulos.codigo='" & Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticulo) & "' or codigo_barras.codigobarras='" & Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticulo) & "'"

                CodigoArticulo = cmd.ExecuteScalar

                If CodigoArticulo <> String.Empty Then
                    Me.gvPromociones.SetFocusedRowCellValue(Me.colCodigoArticulo, CodigoArticulo)
                Else
                    Me.gvPromociones.SetFocusedRowCellValue(Me.colCodigoArticulo, String.Empty)
                    Me.gvPromociones.SetFocusedRowCellValue(Me.colDescripcionArticulo, String.Empty)
                    Me.gvPromociones.SetFocusedRowCellValue(Me.colPrecioTarifa, 0)
                    Me.gvPromociones.FocusedColumn = Me.colId
                    Exit Sub
                End If

            End If

            'If IsNumeric(Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticulo)) Then Me.gvPromociones.SetFocusedRowCellValue(Me.colCodigoArticulo, Format(CType(Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticulo), Integer), "0000000"))

            'Mostrar información del artículo
            Dim CodigoTalla As Integer = 0
            Dim ControlBaja As Boolean

            cmd.CommandText = "SELECT Codigo, CodigoTalla, Controlbaja FROM Articulos WHERE Codigo='" & Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticulo) & "'"
            dr = cmd.ExecuteReader

            If Not dr.HasRows Then
                Me.gvPromociones.SetFocusedRowCellValue(Me.colCodigoArticulo, String.Empty)
                Me.gvPromociones.SetFocusedRowCellValue(Me.colDescripcionArticulo, String.Empty)
                Me.gvPromociones.SetFocusedRowCellValue(Me.colPrecioTarifa, 0)
                Me.gvPromociones.FocusedColumn = Me.colId
                Exit Sub
            End If

            If dr.Read Then
                ControlBaja = dr("ControlBaja")
                CodigoTalla = dr("CodigoTalla")
            End If
            dr.Close()

            If ControlBaja Then
                MsgBox("Artículo marcado con control de baja", MsgBoxStyle.Information, "Control de Baja")
                Me.gvPromociones.SetFocusedRowCellValue(Me.colCodigoArticulo, String.Empty)
                Me.gvPromociones.SetFocusedRowCellValue(Me.colDescripcionArticulo, String.Empty)
                Me.gvPromociones.SetFocusedRowCellValue(Me.colPrecioTarifa, 0)
                Me.gvPromociones.FocusedColumn = Me.colId
                Exit Sub
            Else
                Me.gvPromociones.SetFocusedRowCellValue(Me.colDescripcionArticulo, DameDescripcionArticulo(Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticulo)))
            End If

            'Cargar colores y tallas del artículo
            If GestionColores Or GestionTallas Then Me.CargarTallasColores()

            'Preciotarifa del artículo
            Me.gvPromociones.SetFocusedRowCellValue(Me.colPrecioTarifa, DamePrecioArticulo(Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticulo), IIf(Not Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoColor) Is System.DBNull.Value, Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoColor), 0), IIf(Not Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoTalla) Is System.DBNull.Value, Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoTalla), 1)))

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            AddHandler gvPromociones.CellValueChanged, AddressOf gvPromociones_CellValueChanged
        End Try

        cmd.Connection.Close()

    End Sub
#End Region

#Region "DatosArticuloRegalo"
    Private Sub DatosArticuloRegalo()

        Dim cmd As New SqlClient.SqlCommand
        Dim CodigoArticulo As String
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            RemoveHandler gvPromociones.CellValueChanged, AddressOf gvPromociones_CellValueChanged

            'Vaciar colores y tallas
            Me.DsPromociones.COLORES.Clear()
            Me.DsPromociones.TALLAS.Clear()

            'Comprobar si es un código de barras
            If Len(Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticuloRegalo)) > 7 Then

                cmd.CommandText = "select ISNULL(Codigo,'') from (articulos left join existencias on articulos.id=existencias.articulo_id) " & _
                                  "left join Codigo_Barras on articulos.id=codigo_barras.articulo_id " & _
                                  "where articulos.codigo='" & Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticuloRegalo) & "' or codigo_barras.codigobarras='" & Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticuloRegalo) & "'"

                CodigoArticulo = cmd.ExecuteScalar

                If CodigoArticulo <> String.Empty Then
                    Me.gvPromociones.SetFocusedRowCellValue(Me.colCodigoArticuloRegalo, CodigoArticulo)
                Else
                    'MsgBox("No existe ningún artículo asociado a ese código de barras", MsgBoxStyle.Information, "No existe")
                    Me.gvPromociones.SetFocusedRowCellValue(Me.colCodigoArticuloRegalo, String.Empty)
                    Me.gvPromociones.SetFocusedRowCellValue(Me.colDescripcionArticuloRegalo, String.Empty)
                    'Me.txtCodigoArticulo.Focus()
                    Exit Sub
                End If

            End If

            'If IsNumeric(Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticuloRegalo)) Then Me.gvPromociones.SetFocusedRowCellValue(Me.colCodigoArticuloRegalo, Format(CType(Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticuloRegalo), Integer), "0000000"))

            'Mostrar información del artículo
            cmd.CommandText = "SELECT Descripcion FROM Articulos WHERE Codigo='" & Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticuloRegalo) & "'"
            Me.gvPromociones.SetFocusedRowCellValue(Me.colDescripcionArticuloRegalo, cmd.ExecuteScalar)

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            AddHandler gvPromociones.CellValueChanged, AddressOf gvPromociones_CellValueChanged
        End Try

        cmd.Connection.Close()

    End Sub
#End Region

#Region "txtFechaFinal_Validated"
    Private Sub txtFechaFinal_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFechaFinal.Validated
        If Not Me.txtFechaFinal.EditValue Is System.DBNull.Value Then
            If CType(Me.txtFechaFinal.EditValue, Date).Hour = 0 And CType(Me.txtFechaFinal.EditValue, Date).Minute = 0 Then
                Me.txtFechaFinal.EditValue = CDate(Me.txtFechaFinal.EditValue).AddHours(23)
                Me.txtFechaFinal.EditValue = CDate(Me.txtFechaFinal.EditValue).AddMinutes(59)
            End If
            If Me.txtFechaFinal.EditValue < Me.txtFechaInicio.EditValue Then
                Me.txtFechaFinal.EditValue = Me.txtFechaFinal.OldEditValue
                Me.txtFechaFinal.Focus()
            End If
        End If
    End Sub
#End Region

#Region "txtFechaInicio_Validated"
    Private Sub txtFechaInicio_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFechaInicio.Validated
        If Not Me.txtFechaInicio.EditValue Is System.DBNull.Value Then
            If Me.txtFechaInicio.EditValue > Me.txtFechaFinal.EditValue Then
                Me.txtFechaFinal.EditValue = CDate(Me.txtFechaInicio.EditValue).AddHours(23)
                Me.txtFechaFinal.EditValue = CDate(Me.txtFechaFinal.EditValue).AddMinutes(59)
            End If
        End If
    End Sub
#End Region

#Region "gvPromociones_CellValueChanged"
    Private Sub gvPromociones_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvPromociones.CellValueChanged
        Try
            'Actualizar modificación columna
            Select Case e.Column.Name
                Case Me.colCodigoArticulo.Name
                    Me.DatosArticulo()
                Case Me.colCodigoArticuloRegalo.Name
                    Me.DatosArticuloRegalo()
                    Me.colFraccionSinCargo.OptionsColumn.AllowEdit = (Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticuloRegalo) <> String.Empty)
                    Me.colFraccionSinCargo.OptionsColumn.AllowFocus = (Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticuloRegalo) <> String.Empty)
                Case Me.colFraccionSinCargo.Name
                    Me.colUnidadesSinCargo.OptionsColumn.AllowEdit = (Me.gvPromociones.GetFocusedRowCellValue(Me.colFraccionSinCargo) <> 0)
                    Me.colUnidadesSinCargo.OptionsColumn.AllowFocus = (Me.gvPromociones.GetFocusedRowCellValue(Me.colFraccionSinCargo) <> 0)
                Case Me.colUnidadesSinCargo.Name
                    Me.colPrecioArticuloRegalo.OptionsColumn.AllowEdit = (Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticuloRegalo) <> String.Empty)
                    Me.colPrecioArticuloRegalo.OptionsColumn.AllowFocus = (Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticuloRegalo) <> String.Empty)
                Case Me.colCodigoColor.Name
                    Me.gvPromociones.SetFocusedRowCellValue(Me.colDescripcionColor, DameColor(e.Value))
                Case Me.colCodigoTalla.Name
                    Me.gvPromociones.SetFocusedRowCellValue(Me.colDescripcionTalla, DameTallaArticulo(Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticulo), e.Value))
            End Select
            'Actualizar precio
            If e.Column Is Me.colCodigoColor Or e.Column Is Me.colCodigoTalla Then
                Me.gvPromociones.SetFocusedRowCellValue(Me.colPrecioTarifa, DamePrecioArticulo(Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticulo), IIf(Not Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoColor) Is System.DBNull.Value, Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoColor), 0), IIf(Not Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoTalla) Is System.DBNull.Value, Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoTalla), 1)))
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "gvPromociones_FocusedRowChanged"
    Private Sub gvPromociones_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvPromociones.FocusedRowChanged
        If GestionColores Or GestionTallas Then Me.CargarTallasColores()
        If Me.gvPromociones.GetFocusedRow Is Nothing Then
            Me.colFraccionSinCargo.OptionsColumn.AllowEdit = False
            Me.colFraccionSinCargo.OptionsColumn.AllowFocus = False
            Me.colUnidadesSinCargo.OptionsColumn.AllowEdit = False
            Me.colUnidadesSinCargo.OptionsColumn.AllowFocus = False
            Me.colPrecioArticuloRegalo.OptionsColumn.AllowEdit = False
            Me.colPrecioArticuloRegalo.OptionsColumn.AllowFocus = False
        Else
            Me.colFraccionSinCargo.OptionsColumn.AllowEdit = (Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticuloRegalo) <> String.Empty)
            Me.colFraccionSinCargo.OptionsColumn.AllowFocus = (Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticuloRegalo) <> String.Empty)
            Me.colUnidadesSinCargo.OptionsColumn.AllowEdit = (Me.gvPromociones.GetFocusedRowCellValue(Me.colFraccionSinCargo) <> 0)
            Me.colUnidadesSinCargo.OptionsColumn.AllowFocus = (Me.gvPromociones.GetFocusedRowCellValue(Me.colFraccionSinCargo) <> 0)
            Me.colPrecioArticuloRegalo.OptionsColumn.AllowEdit = (Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticuloRegalo) <> String.Empty)
            Me.colPrecioArticuloRegalo.OptionsColumn.AllowFocus = (Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticuloRegalo) <> String.Empty)
        End If
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
        Try
            If Me.txtCodigoFamilia.EditValue = String.Empty Then
                MsgBox("Seleccione la familias de los artículos que desea añadir a la promoción", MsgBoxStyle.Information)
                Me.txtCodigoFamilia.Focus()
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            Dim rPromocion As dsPromociones.PROMOCIONESRow

            Dim dr As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT Codigo, Descripcion FROM ARTICULOS " & _
                              "WHERE ControlBaja=0 AND CodigoFamilia IN (SELECT Id FROM FAMILIASARTICULOS WHERE Codigo='" & Me.txtCodigoFamilia.EditValue & "')"

            If Me.txtCodigoSubfamilia.EditValue <> String.Empty Then
                cmd.CommandText &= " AND CodigoSubfamilia IN (SELECT Id FROM SUBFAMILIASARTICULOS WHERE Codigo='" & Me.txtCodigoSubfamilia.EditValue & "')"
            End If

            Me.txtDescuento.Properties.Mask.UseMaskAsDisplayFormat = False

            dr = cmd.ExecuteReader
            While dr.Read
                Try
                    If Me.LineaRepetida(dr("Codigo"), -1, -1, 0) Then Exit Try
                    rPromocion = Me.DsPromociones.PROMOCIONES.NewPROMOCIONESRow
                    rPromocion.CodigoArticulo = dr("Codigo")
                    rPromocion.DescripcionArticulo = dr("Descripcion")
                    rPromocion.PrecioTarifa = DamePrecioArticulo(rPromocion.CodigoArticulo, -1, -1)
                    rPromocion.PrecioPromocion = Math.Round(rPromocion.PrecioTarifa - (rPromocion.PrecioTarifa * Me.txtDescuento.EditValue / 100), DecimalesPrecio, MidpointRounding.AwayFromZero)
                    'Aplicar tipo redondeo
                    Select Case Me.txtTipoRedondeo.SelectedIndex
                        Case 1 '0.00/0.50
                            If rPromocion.PrecioTarifa <= 0.5 Then Exit Select
                            Dim diferencia As Decimal = Math.Round((rPromocion.PrecioTarifa - Int(rPromocion.PrecioTarifa)), 1) * 10
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
                            rPromocion.PrecioTarifa = Math.Round(rPromocion.PrecioTarifa + diferencia, 1)

                        Case 2 '0.00/0.05
                            Dim diferencia As Decimal = Math.Round((rPromocion.PrecioTarifa - (Int(rPromocion.PrecioTarifa * 10) / 10)), 2) * 100
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
                            rPromocion.PrecioTarifa = Math.Round((rPromocion.PrecioTarifa + diferencia), 2)

                        Case 3 'Anterior 0.90
                            If rPromocion.PrecioTarifa <= 0.86 Then Exit Select
                            rPromocion.PrecioTarifa = Math.Round(Int(rPromocion.PrecioTarifa + 0.14) - 0.1, 2)
                    End Select
                    Me.DsPromociones.PROMOCIONES.AddPROMOCIONESRow(rPromocion)

                Catch ex As Exception
                    MsgBox("Error al importar el artículo " & dr("codigo") & ": " & dr("Descripcion"), MsgBoxStyle.Exclamation)
                End Try
            End While
            dr.Close()

            'Cargar precios de color/talla de los artículos
            Dim i As Integer
            For i = 0 To Me.gvPromociones.RowCount - 1
                cmd.CommandText = "SELECT * FROM EXISTENCIAS INNER JOIN ARTICULOS ON EXISTENCIAS.Articulo_Id=ARTICULOS.Id " & _
                                  "WHERE ARTICULOS.Codigo='" & Me.gvPromociones.GetRowCellValue(i, Me.colCodigoArticulo) & "'"
                dr = cmd.ExecuteReader
                While dr.Read
                    If dr("PrecioVenta") <> 0 Then
                        Try
                            If Me.LineaRepetida(dr("Codigo"), dr("CodigoColor"), dr("CodigoTalla"), 0) Then Exit Try
                            rPromocion = Me.DsPromociones.PROMOCIONES.NewPROMOCIONESRow
                            rPromocion.CodigoArticulo = dr("Codigo")
                            rPromocion.DescripcionArticulo = dr("Descripcion")
                            rPromocion.CodigoColor = dr("CodigoColor")
                            rPromocion.CodigoTalla = dr("CodigoTalla")
                            rPromocion.DescripcionColor = DameDescripcionColor(rPromocion.CodigoColor)
                            rPromocion.DescripcionTalla = DameTallaArticulo(rPromocion.CodigoArticulo, rPromocion.CodigoTalla)
                            rPromocion.PrecioTarifa = DamePrecioArticulo(rPromocion.CodigoArticulo, dr("CodigoColor"), dr("CodigoTalla"))
                            rPromocion.PrecioPromocion = rPromocion.PrecioTarifa - (rPromocion.PrecioTarifa * Me.txtDescuento.EditValue / 100)
                            'Aplicar tipo redondeo
                            Select Case Me.txtTipoRedondeo.SelectedIndex
                                Case 1 '0.00/0.50
                                    If rPromocion.PrecioPromocion <= 0.5 Then Exit Select
                                    Dim diferencia As Decimal = Int(rPromocion.PrecioPromocion * 10) / 10 - Int(Int(rPromocion.PrecioPromocion * 10) / 10)
                                    Select Case diferencia
                                        Case 1, 6
                                            diferencia = -0.1
                                        Case 2, 7
                                            diferencia = -0.2
                                        Case 3, 8
                                            diferencia = 0.2
                                        Case 4, 9
                                            diferencia = 0.1
                                    End Select
                                    rPromocion.PrecioPromocion += diferencia

                                Case 2 '0.00/0.05
                                    Dim diferencia As Decimal = (rPromocion.PrecioPromocion - (Int(rPromocion.PrecioPromocion * 10) / 10)) * 100
                                    Select Case diferencia
                                        Case 1, 6
                                            diferencia = -0.01
                                        Case 2, 7
                                            diferencia = -0.02
                                        Case 3, 8
                                            diferencia = 0.02
                                        Case 4, 9
                                            diferencia = 0.01
                                    End Select
                                    rPromocion.PrecioPromocion += diferencia

                                Case 3 'Anterior 0.90
                                    If rPromocion.PrecioPromocion <= 1 Then Exit Select
                                    rPromocion.PrecioPromocion = Int(rPromocion.PrecioPromocion + 0.14) - 0.1
                            End Select
                            Me.DsPromociones.PROMOCIONES.AddPROMOCIONESRow(rPromocion)

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
            'Me.colCodigoArticulo.SortIndex = 0
            'Me.colCodigoColor.SortIndex = 1
            'Me.colCodigoTalla.SortIndex = 2
            Me.gvPromociones.MoveLastVisible()
            Me.gvPromociones.Focus()

        Catch ex As Exception
            MsgBox("Error al importar los artículos a la promoción", MsgBoxStyle.Exclamation)
        Finally
            Me.txtDescuento.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "gvPromociones_ValidateRow"
    Private Sub gvPromociones_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvPromociones.ValidateRow
        Try
            'Comprobar columnas
            If Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticulo) = String.Empty Then
                If MsgBox("Seleccione el artículo", MsgBoxStyle.Information + MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    Me.gvPromociones.FocusedColumn = Me.colCodigoArticulo
                    e.Valid = False
                    Exit Sub
                Else
                    Me.gvPromociones.CancelUpdateCurrentRow()
                    Me.gvPromociones.FocusedColumn = Me.colId
                    Exit Sub
                End If
            End If
            If Me.gvPromociones.GetFocusedRowCellValue(Me.colPrecioPromocion) = 0 And Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticuloRegalo) = String.Empty Then
                If MsgBox("Indique el precio de la promoción o el artículo de regalo", MsgBoxStyle.Information + MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    Me.gvPromociones.FocusedColumn = Me.colPrecioPromocion
                    e.Valid = False
                    Exit Sub
                Else
                    Me.gvPromociones.CancelUpdateCurrentRow()
                    Me.gvPromociones.FocusedColumn = Me.colId
                    Exit Sub
                End If
            End If
            If Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticuloRegalo) <> String.Empty And (Me.gvPromociones.GetFocusedRowCellValue(Me.colFraccionSinCargo) = 0 Or Me.gvPromociones.GetFocusedRowCellValue(Me.colUnidadesSinCargo) = 0) Then
                If MsgBox("Indique las condiciones del artículo regalo", MsgBoxStyle.Information + MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    Me.gvPromociones.FocusedColumn = Me.colFraccionSinCargo
                    e.Valid = False
                    Exit Sub
                Else
                    Me.gvPromociones.CancelUpdateCurrentRow()
                    Me.gvPromociones.FocusedColumn = Me.colId
                    Exit Sub
                End If
            End If

            'Si es nueva línea comprobar que no exista ya en la promoción
            If Me.gvPromociones.IsNewItemRow(e.RowHandle) Then
                If Me.LineaRepetida(Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticulo), Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoColor), Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoTalla), Me.gvPromociones.GetFocusedRowCellValue(Me.colUnidades)) Then
                    MsgBox("El artículo seleccionado ya existe en la promoción", MsgBoxStyle.Information)
                    Me.gvPromociones.CancelUpdateCurrentRow()
                    Me.gvPromociones.FocusedColumn = Me.colId
                    Me.gvPromociones.MoveLastVisible()
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al validar la línea", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "gvPromociones_InvalidRowException"
    Private Sub gvPromociones_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvPromociones.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
#End Region

#Region "CargarTallasColores"
    Private Sub CargarTallasColores()

        Me.DsPromociones.COLORES.Clear()
        Me.DsPromociones.TALLAS.Clear()

        If Me.gvPromociones.GetFocusedRow Is Nothing Then Exit Sub

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            Dim CodigoTalla As Integer

            'Código tallaje del artículo
            cmd.CommandText = "SELECT CodigoTalla FROM Articulos WHERE Codigo='" & Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticulo) & "'"
            CodigoTalla = cmd.ExecuteScalar

            'Cargar colores y tallas del artículo
            Me.COLORESTableAdapter.Articulo(Me.DsPromociones.COLORES, Me.gvPromociones.GetFocusedRowCellValue(Me.colCodigoArticulo))

            cmd.CommandText = "SELECT * FROM Tallas WHERE CodigoTalla=" & CodigoTalla
            dr = cmd.ExecuteReader
            If dr.Read Then
                Dim i As Integer
                For i = 1 To 18
                    If dr("Talla_" & i) <> String.Empty Then Me.DsPromociones.TALLAS.AddTALLASRow(i, dr("Talla_" & i))
                Next
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox("Error al mostrar información de tallas y colores del artículo", MsgBoxStyle.Exclamation)
        End Try

        cmd.Connection.Close()

    End Sub
#End Region

#Region "LineaRepetida"
    Private Function LineaRepetida(ByVal CodigoArticulo As String, ByVal CodigoColor As Integer, ByVal CodigoTalla As Integer, ByVal Unidades As Decimal)
        Dim Existe As Boolean
        Dim i As Integer

        For i = 0 To Me.gvPromociones.RowCount - 1
            If (GestionTallas Or GestionColores) Then
                If Me.gvPromociones.GetRowCellValue(i, Me.colCodigoArticulo) = CodigoArticulo And Me.gvPromociones.GetRowCellValue(i, Me.colUnidades) = Unidades And Me.gvPromociones.GetRowCellValue(i, Me.colCodigoColor) = CodigoColor And Me.gvPromociones.GetRowCellValue(i, Me.colCodigoTalla) = CodigoTalla Then
                    Existe = True
                    Exit For
                End If
            Else
                If Me.gvPromociones.GetRowCellValue(i, Me.colCodigoArticulo) = CodigoArticulo And Me.gvPromociones.GetRowCellValue(i, Me.colUnidades) = Unidades Then
                    Existe = True
                    Exit For
                End If
            End If
        Next

        Return Existe

    End Function
#End Region

#Region "gvPromociones_CustomDrawCell"
    Private Sub gvPromociones_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvPromociones.CustomDrawCell
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

#Region "bttImprimirEtiquetas_Click"
    Private Sub bttImprimirEtiquetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimirEtiquetas.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Informe As New InfEtiquetasPromocion

            'Cargar datos
            Dim i As Integer
            Dim rEtiqueta As dsPromociones.ETIQUETASRow
            Dim rPromocion As dsPromociones.PROMOCIONESRow
            Dim DatosUnidad As New Almacen.DatosUnidad

            Me.DsPromociones.ETIQUETAS.Clear()
            For i = 0 To Me.DsPromociones.PROMOCIONES.Rows.Count - 1

                rPromocion = Me.DsPromociones.PROMOCIONES.Rows(i)

                If rPromocion.PrecioPromocion <> 0 Then
                    rEtiqueta = Me.DsPromociones.ETIQUETAS.NewETIQUETASRow
                    rEtiqueta.CodigoArticulo = rPromocion.CodigoArticulo
                    rEtiqueta.Descripcion = rPromocion.DescripcionArticulo
                    rEtiqueta.Precio = "OFERTA " & Math.Round(rPromocion.PrecioPromocion, DecimalesPrecio, MidpointRounding.AwayFromZero)
                    rEtiqueta.PrecioTarifa = "PVP " & Math.Round(rPromocion.PrecioTarifa, DecimalesPrecio, MidpointRounding.AwayFromZero)
                    rEtiqueta.FechaFin = "FIN OFERTA: " & Format(rPromocion.FechaFinal, "dd-MM-yyyy")
                    DatosUnidad = Almacen.DameDatosUnidadArticulo(rEtiqueta.CodigoArticulo)
                    If DatosUnidad.Peso <> 0 And DatosUnidad.Peso <> 1 Then rEtiqueta.DescripcionPrecioUnidad = "EL " & DatosUnidad.Descripcion & " LE SALE A " & Math.Round(rPromocion.PrecioPromocion / DatosUnidad.Peso, DecimalesPrecio, MidpointRounding.AwayFromZero)
                    Me.DsPromociones.ETIQUETAS.AddETIQUETASRow(rEtiqueta)
                End If

            Next

            Informe.DataSource = Me.DsPromociones

            Informe.Prefijo.Value = PrefijoEtiqueta
            Informe.RequestParameters = False

            Informe.CreateDocument()

            Dim f As New PreImpreso
            f.Informe.PrintingSystem = Informe.PrintingSystem

            General.AbrirFormulario(f, "Etiquetas promoción")

        Catch ex As Exception
            MsgBox("Error al cargar los datos del listado", MsgBoxStyle.Exclamation)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "cmbColores_EditValueChanged"
    Private Sub cmbColores_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbColores.EditValueChanged
        Me.gvPromociones.FocusedColumn = Me.colCodigoTalla
    End Sub
#End Region

#Region "cmbTallas_EditValueChanged"
    Private Sub cmbTallas_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTallas.EditValueChanged
        Me.gvPromociones.FocusedColumn = Me.colPrecioPromocion
    End Sub
#End Region

#Region "bttImprimirPromocion_Click"
    Private Sub bttImprimirPromocion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimirPromocion.Click
        Try
            Dim Informe As New DevExpress.XtraPrinting.PrintableComponentLink
            Dim ps As DevExpress.XtraPrinting.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()

            Informe.PageHeaderFooter = Informes.CabeceraInforme("Promoción desde " & Me.txtFechaInicio.EditValue & " hasta " & Me.txtFechaFinal.EditValue, Nothing)

            Informe.Margins.Left = 10
            Informe.Margins.Right = 10
            Informe.Component = Me.dgPromociones

            Informe.PrintingSystem = ps

            Informe.CreateDocument()

            Informes.AbrirVistaPrevia(Me.Text, Informe)

        Catch ex As Exception
            MsgBox("Error al generar el informe", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

End Class