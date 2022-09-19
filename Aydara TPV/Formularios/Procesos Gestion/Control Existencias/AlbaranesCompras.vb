Public Class AlbaranesCompras

    Dim rAlbaran As dsAlbaranesCompras.ALBARANES_COMPRASRow

#Region "AlbaranesCompras_FormClosing"
    Private Sub AlbaranesCompras_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.bttCancelar.Text = "Cancelar" And Me.DsAlbaranesCompras.HasChanges Then
            If MsgBox("Está editando un albarán. ¿Seguro que desea salir sin guardar los cambios?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then e.Cancel = True Else Me.Dispose()
        Else
            'Me.Dispose()
        End If
    End Sub
#End Region

#Region "AlbaranesCompras_KeyUp"
    Private Sub AlbaranesCompras_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "AlbaranesCompras_Load"
    Private Sub AlbaranesCompras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If GestionColores Then Me.COLORESTableAdapter.Fill(Me.DsArticulos.COLORES)
        Me.DsAlbaranesCompras.ALBARANES_COMPRAS.CodigoTiendaColumn.DefaultValue = CodigoTienda
        Me.DsAlbaranesCompras.ALBARANES_COMPRAS.FechaColumn.DefaultValue = Date.Now
        Me.dgLineasAlbaran.LevelTree.Nodes.Add("FK_ALBARANES_COMPRAS_LINEAS_ALBARANES_COMPRAS_LINEAS_DETALLE", Me.gvDetalleLineasAlbaran)
    End Sub
#End Region

#Region "AlbaranesCompras_Shown"
    Private Sub AlbaranesCompras_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en precios
        'Me.maskPrecio.Mask.EditMask = "c" & DecimalesPrecio
        Me.maskPrecio.Mask.EditMask = "c3"
        Me.maskImporte.Mask.EditMask = "c" & DecimalesImporte
        'Detalle color-talla
        If GestionTallas Or GestionColores Then
            Me.gvLineasAlbaran.OptionsView.ShowDetailButtons = True
            Me.gvDetalleLineasAlbaran.ActiveFilterString = "Cantidad<>0"
        End If
    End Sub
#End Region

#Region "bttNuevo_Click"
    Private Sub bttNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttNuevo.Click
        Try
            Me.DsAlbaranesCompras.Clear()

            rAlbaran = DsAlbaranesCompras.ALBARANES_COMPRAS.NewALBARANES_COMPRASRow
            Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS.AlbaranCompra_IdColumn.DefaultValue = rAlbaran.Id
            Me.DsAlbaranesCompras.ALBARANES_COMPRAS.AddALBARANES_COMPRASRow(rAlbaran)

            Me.ActivaDesactivaMenu(False)
            Me.ActivaDesactivaCampos(False)
            Me.txtNumeroAlbaran.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttModificar_Click"
    Private Sub bttModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttModificar.Click
        Try
            ActivaDesactivaMenu(False)
            ActivaDesactivaCampos(False)
            Me.gvLineasAlbaran.Focus()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click
        Try
            Dim dsAlbaranesCompras As New dsAlbaranesCompras, tAlbaranesCompras As New dsAlbaranesComprasTableAdapters.ALBARANES_COMPRASTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Id") 'Campo
            Columnas.Add("Id") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("NumeroAlbaran")
            Columnas.Add("Nº Albarán")
            Columnas.Add(80)
            Columnas.Add(80)

            Columnas.Add("Fecha")
            Columnas.Add("Fecha")
            Columnas.Add(80)
            Columnas.Add(80)

            Columnas.Add("NombreProveedor")
            Columnas.Add("Proveedor")
            Columnas.Add(0)
            Columnas.Add(0)

            tAlbaranesCompras.Fill(dsAlbaranesCompras.ALBARANES_COMPRAS)

            If Buscar(dsAlbaranesCompras, "ALBARANES_COMPRAS", Columnas, 1, True).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.DameAlbaran(ResultadoBusqueda)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttEliminar_Click"
    Private Sub bttEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttEliminar.Click
        Try
            If MsgBox("¿Seguro que desea eliminar el Albaran?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar cliente") = MsgBoxResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                'Restar stock artículos del albarán
                Dim i As Integer
                For i = 0 To Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS.Count - 1
                    Almacen.ActualizaStock(Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS(i).CodigoArticulo, 0, 1, Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS(i).Cantidad * -1)
                Next

                Me.ALBARANESCOMPRASBindingSource.RemoveCurrent()
                Me.ALBARANES_COMPRASTableAdapter.Update(Me.DsAlbaranesCompras.ALBARANES_COMPRAS)
                Me.txtTotalAlbaran.EditValue = 0
                Me.ActivaDesactivaMenu(True)
                Me.txtNumeroAlbaran.Focus()
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Try
            If sender.text = "Salir" Then Me.Close() : Exit Sub

            'If MsgBox("¿Seguro que desea deshacer los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Deshacer cambios") = MsgBoxResult.No Then Exit Sub

            Me.ALBARANESCOMPRASBindingSource.CancelEdit()

            'If Me.AlbaranesComprasBindingSource.Count = 0 Then
            '    Me.DsAlbaranesCompras.Clear()
            'Else
            '    Me.AlbaranesComprasLINEASBindingSource.CancelEdit()
            'End If

            Me.DsAlbaranesCompras.RejectChanges()

            Me.ActivaDesactivaMenu(True)
            Me.ActivaDesactivaCampos(True)

            Me.txtNumeroAlbaran.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttGuardar_Click"
    Private Sub bttGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttGuardar.Click

        'Comprobar datos obligatorios
        If Not IsNumeric(Me.txtCodigoProveedor.EditValue) Then
            MsgBox("Falta indicar el proveedor", MsgBoxStyle.Information)
            Me.txtCodigoProveedor.Focus()
            Exit Sub
        End If
        If Me.txtNumeroAlbaran.EditValue = String.Empty Then
            MsgBox("Falta indicar el nº de albarán", MsgBoxStyle.Information)
            Me.txtNumeroAlbaran.Focus()
            Exit Sub
        End If

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            'If MsgBox("¿Seguro que desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar cambios") = MsgBoxResult.No Then Exit Sub

            Me.ALBARANESCOMPRASBindingSource.EndEdit()
            Me.ALBARANESCOMPRASLINEASBindingSource.EndEdit()
            Me.ALBARANESCOMPRASLINEASDETALLEBindingSource.EndEdit()

            Me.ALBARANES_COMPRASTableAdapter.Update(Me.DsAlbaranesCompras.ALBARANES_COMPRAS)
            Me.ALBARANES_COMPRAS_LINEASTableAdapter.Update(Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS)
            Me.ALBARANES_COMPRAS_LINEAS_DETALLETableAdapter.Update(Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE)
            If Me.DsAlbaranesCompras.ALBARANES_COMPRAS.Count > 0 Then
                Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS.AlbaranCompra_IdColumn.DefaultValue = Me.DsAlbaranesCompras.ALBARANES_COMPRAS(0).Id
            End If

            'Actualizar cantidad servida de pedidos
            Dim taLineasPedido As New dsPedidosTableAdapters.PEDIDOS_LINEASTableAdapter
            taLineasPedido.Update(PedidosPendientes.DsPedidos.PEDIDOS_LINEAS)
            Dim taLineasPedidoDetalle As New dsPedidosTableAdapters.PEDIDOS_LINEAS_DETALLETableAdapter
            taLineasPedidoDetalle.Update(PedidosPendientes.DsPedidos.PEDIDOS_LINEAS_DETALLE)

            'Actualizar existencias
            Dim i As Integer
            
            If GestionTallas Or GestionColores Then

                Dim rLineaDetalle As dsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLERow
                Dim CodigoArticulo As String

                For i = 0 To Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE.Rows.Count - 1

                    rLineaDetalle = Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE.Rows(i)

                    If Not rLineaDetalle.RowState = DataRowState.Deleted Then

                        cmd.CommandText = "SELECT CodigoArticulo FROM ALBARANES_COMPRAS_LINEAS WHERE Id=" & rLineaDetalle.LineaAlbaranCompra_Id
                        CodigoArticulo = cmd.ExecuteScalar

                        If CodigoArticulo <> String.Empty And rLineaDetalle.Cantidad <> rLineaDetalle.CantidadAnterior Then
                            Almacen.ActualizaStock(CodigoArticulo, rLineaDetalle.CodigoColor, rLineaDetalle.CodigoTalla, rLineaDetalle.Cantidad - rLineaDetalle.CantidadAnterior)
                            rLineaDetalle.CantidadAnterior = rLineaDetalle.Cantidad
                        End If

                    End If

                Next

            Else
                Dim rLinea As dsAlbaranesCompras.ALBARANES_COMPRAS_LINEASRow

                For i = 0 To Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS.Rows.Count - 1

                    rLinea = Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS.Rows(i)

                    If Not rLinea.RowState = DataRowState.Deleted Then

                        If rLinea.Cantidad <> rLinea.CantidadAnterior Then
                            Almacen.ActualizaStock(rLinea.CodigoArticulo, 0, 1, rLinea.Cantidad - rLinea.CantidadAnterior)
                            rLinea.CantidadAnterior = rLinea.Cantidad
                        End If

                    End If

                Next

            End If

            Me.ActivaDesactivaMenu(True)
            Me.ActivaDesactivaCampos(True)

            Me.txtNumeroAlbaran.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            cmd.Connection.Close()
        End Try

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

#Region "txtCodigoProveedor_Validated"
    Private Sub txtCodigoProveedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoProveedor.Validated
        Try
            If Not Me.bttCancelar.Enabled Then Exit Sub

            If IsNumeric(Me.txtCodigoProveedor.EditValue) Then Me.txtCodigoProveedor.EditValue = Format(CType(Me.txtCodigoProveedor.EditValue, Integer), "00000")

            Me.DatosProveedor()

            If Me.txtCodigoProveedor.Text = String.Empty Then Me.txtCodigoProveedor.Focus() Else Me.gvLineasAlbaran.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "ActivaDesactivaMenu"
    Private Sub ActivaDesactivaMenu(ByVal activa As Boolean)

        Me.bttNuevo.Enabled = activa
        Me.bttBuscar.Enabled = activa
        Me.bttModificar.Enabled = IIf(Me.ALBARANESCOMPRASBindingSource.Count = 0, False, activa)
        Me.bttEliminar.Enabled = IIf(Me.ALBARANESCOMPRASBindingSource.Count = 0, False, activa)
        Me.bttImprimir.Enabled = IIf(Me.ALBARANESCOMPRASBindingSource.Count = 0, False, activa)
        'Me.bttCancelar.Enabled = Not activa
        Me.bttCancelar.Text = IIf(activa, "Salir", "Cancelar")
        Me.bttGuardar.Enabled = Not activa
        If (GestionTallas Or GestionColores) Then Me.colCantidad.ColumnEdit = IIf(activa, Me.maskCantidad, Me.linkCantidad)

        'Comprobar si tiene pedidos pendientes
        If Not activa And IsNumeric(Me.txtCodigoProveedor.EditValue) And Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS.Rows.Count = 0 Then
            Me.bttPedidosPendientes.Enabled = Me.TienePedidosPendientes
        Else
            Me.bttPedidosPendientes.Enabled = False
        End If

        Me.CalculaTotal()
        Me.gvLineasAlbaran.CollapseAllDetails()

    End Sub
#End Region

#Region "ActivaDesactivaCampos"
    Private Sub ActivaDesactivaCampos(ByVal activa As Boolean)
        Me.txtNumeroAlbaran.Properties.ReadOnly = activa
        Me.txtFecha.Properties.ReadOnly = activa
        Me.txtCodigoProveedor.Properties.ReadOnly = activa
        Me.txtCodigoProveedor.Properties.Buttons(0).Enabled = Not activa
        Me.txtNombreProveedor.Properties.ReadOnly = activa
        Me.txtObservaciones.Properties.ReadOnly = activa
        Me.gvLineasAlbaran.OptionsView.NewItemRowPosition = IIf(activa, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom)
        Me.gvLineasAlbaran.OptionsBehavior.AllowAddRows = IIf(activa, DevExpress.Utils.DefaultBoolean.False, DevExpress.Utils.DefaultBoolean.True)
        Me.gvLineasAlbaran.OptionsBehavior.AllowDeleteRows = IIf(activa, DevExpress.Utils.DefaultBoolean.False, DevExpress.Utils.DefaultBoolean.True)
        Me.colDescripcion.OptionsColumn.ReadOnly = activa
        Me.colCantidad.OptionsColumn.ReadOnly = activa
        Me.colPrecio.OptionsColumn.ReadOnly = activa
        Me.colDescuento.OptionsColumn.ReadOnly = activa
        Me.colObservaciones.OptionsColumn.ReadOnly = activa
    End Sub
#End Region

#Region "DatosProveedor"
    Private Sub DatosProveedor()

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT Nombre FROM PROVEEDORES WHERE Codigo=" & IIf(IsNumeric(Me.txtCodigoProveedor.EditValue), Me.txtCodigoProveedor.EditValue, -1)
            dr = cmd.ExecuteReader

            If dr.Read Then
                Me.txtCodigoProveedor.EditValue = Format(CType(Me.txtCodigoProveedor.EditValue, Integer), "00000")
                Me.txtNombreProveedor.EditValue = dr("Nombre")
            Else
                Me.txtCodigoProveedor.EditValue = String.Empty
                Me.txtNombreProveedor.EditValue = String.Empty
            End If
            dr.Close()

            'Comprobar si tiene pedidos pendientes
            If Me.bttGuardar.Enabled And IsNumeric(Me.txtCodigoProveedor.EditValue) Then
                Me.bttPedidosPendientes.Enabled = Me.TienePedidosPendientes
            Else
                Me.bttPedidosPendientes.Enabled = False
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            cmd.Connection.Close()
        End Try
    End Sub
#End Region

#Region "bttCodigoArticulo_ButtonClick"
    Private Sub bttCodigoArticulo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bttCodigoArticulo.ButtonClick
        Try
            Dim dsArticulos As New dsArticulos, tArticulos As New dsArticulosTableAdapters.ARTICULOSTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("Descripcion")
            Columnas.Add("Descripción")
            Columnas.Add(0)
            Columnas.Add(0)

            tArticulos.Fill(dsArticulos.ARTICULOS)

            If Buscar(dsArticulos, "ARTICULOS", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                If Me.gvLineasAlbaran.GetRow(Me.gvLineasAlbaran.FocusedRowHandle) Is Nothing Then Me.gvLineasAlbaran.AddNewRow()
                Me.gvLineasAlbaran.SetFocusedValue(ResultadoBusqueda)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "gvLineasAlbaran_CellValueChanged"
    Private Sub gvLineasAlbaran_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvLineasAlbaran.CellValueChanged
        Try
            RemoveHandler gvLineasAlbaran.CellValueChanged, AddressOf gvLineasAlbaran_CellValueChanged

            Select Case e.Column.Name
                Case Me.colCodigoArticulo.Name

                    Dim CodigoArticulo As String = String.Empty, ControlBaja As Boolean, PrecioCoste As Decimal

                    Me.LimpiaLinea()

                    Dim dr As SqlClient.SqlDataReader
                    Dim cmd As New SqlClient.SqlCommand
                    cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
                    cmd.Connection.Open()

                    'Comprobar si es un código de barras de báscula
                    If Len(Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCodigoArticulo)) = 13 And IsNumeric(Mid(Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCodigoArticulo), 8, 5)) And (Mid(Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCodigoArticulo), 1, 2) = PrefijoBascula1 Or Mid(Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCodigoArticulo), 1, 2) = PrefijoBascula2 Or Mid(Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCodigoArticulo), 1, 2) = PrefijoBascula3) Then
                        'Mostrar información del artículo
                        CodigoArticulo = "00" & Mid(Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCodigoArticulo), 3, 5)

                        cmd.CommandText = "SELECT Codigo, PrecioCoste, ControlBaja FROM Articulos WHERE Codigo='" & CodigoArticulo & "'"

                        dr = cmd.ExecuteReader
                        If dr.Read Then
                            CodigoArticulo = dr("Codigo")
                            PrecioCoste = dr("PrecioCoste")
                            ControlBaja = dr("ControlBaja")
                        End If
                        dr.Close()

                        If ControlBaja Then
                            MsgBox("Artículo marcado con control de baja", MsgBoxStyle.Information, "Control de Baja")
                            Me.gvLineasAlbaran.SetFocusedValue(String.Empty)
                            Me.gvLineasAlbaran.SetFocusedRowCellValue(Me.colDescripcion, String.Empty)
                            Me.gvLineasAlbaran.FocusedColumn = Me.colId
                            Exit Sub
                        ElseIf CodigoArticulo <> String.Empty Then
                            Me.gvLineasAlbaran.SetFocusedValue(CodigoArticulo)
                            Me.gvLineasAlbaran.SetFocusedRowCellValue(Me.colDescripcion, Almacen.DameDescripcionArticulo(CodigoArticulo))
                            Me.gvLineasAlbaran.SetFocusedRowCellValue(Me.colPrecio, PrecioCoste)
                            Me.gvLineasAlbaran.FocusedColumn = Me.colDescripcion
                        Else
                            MsgBox("No existe ningún artículo asociado con ese código", MsgBoxStyle.Information, "No existe")
                            Me.gvLineasAlbaran.SetFocusedValue(String.Empty)
                            Me.gvLineasAlbaran.SetFocusedRowCellValue(Me.colDescripcion, String.Empty)
                            Me.gvLineasAlbaran.FocusedColumn = Me.colId
                        End If

                        Exit Sub
                    End If

                    'Comprobar si es un código de barras
                    If Len(Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCodigoArticulo)) > 7 Then

                        cmd.CommandText = "SELECT Codigo, PrecioCoste, ControlBaja " & _
                                          "FROM Articulos INNER JOIN Codigo_Barras on Articulos.Id=Codigo_Barras.Articulo_Id " & _
                                          "WHERE Codigo_Barras.Codigobarras='" & Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCodigoArticulo) & "'"

                        dr = cmd.ExecuteReader
                        If dr.Read Then
                            CodigoArticulo = dr("Codigo")
                            PrecioCoste = dr("PrecioCoste")
                            ControlBaja = dr("ControlBaja")
                        End If
                        dr.Close()

                        If ControlBaja Then
                            MsgBox("Artículo marcado con control de baja", MsgBoxStyle.Information, "Control de Baja")
                            Me.gvLineasAlbaran.SetFocusedValue(String.Empty)
                            Me.gvLineasAlbaran.FocusedColumn = Me.colCodigoArticulo
                            Exit Sub
                        ElseIf CodigoArticulo <> String.Empty Then
                            Me.gvLineasAlbaran.SetFocusedValue(CodigoArticulo)
                            Me.gvLineasAlbaran.SetFocusedRowCellValue(Me.colDescripcion, Almacen.DameDescripcionArticulo(CodigoArticulo))
                            Me.gvLineasAlbaran.SetFocusedRowCellValue(Me.colPrecio, PrecioCoste)
                            Me.gvLineasAlbaran.FocusedColumn = Me.colDescripcion
                        Else
                            MsgBox("No existe ningún artículo asociado a ese código de barras.", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "No existe")
                            Me.gvLineasAlbaran.SetFocusedValue(String.Empty)
                            Me.gvLineasAlbaran.SetFocusedRowCellValue(Me.colDescripcion, String.Empty)
                            Me.gvLineasAlbaran.FocusedColumn = Me.colId
                        End If

                        Exit Sub
                    End If

                    'If IsNumeric(Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCodigoArticulo)) Then Me.gvLineasAlbaran.SetFocusedValue(Format(CType(Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCodigoArticulo), Integer), "0000000"))

                    'Mostrar información del artículo
                    cmd.CommandText = "SELECT Articulos.Codigo, CASE IsNull(REFERENCIAS_PROVEEDORES.PrecioCoste,0) WHEN 0 THEN Articulos.PrecioCoste ELSE IsNull(REFERENCIAS_PROVEEDORES.PrecioCoste,0) END PrecioCoste, Articulos.ControlBaja " & _
                                      "FROM Articulos " & _
                                      "LEFT JOIN REFERENCIAS_PROVEEDORES ON Articulos.Id = REFERENCIAS_PROVEEDORES.Articulo_Id AND REFERENCIAS_PROVEEDORES.CodigoProveedor = " & Me.txtCodigoProveedor.EditValue & _
                                      "WHERE Articulos.Codigo='" & Me.gvLineasAlbaran.FocusedValue & "'"
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        CodigoArticulo = dr("Codigo")
                        PrecioCoste = dr("PrecioCoste")
                        ControlBaja = dr("ControlBaja")
                    End If
                    dr.Close()

                    If ControlBaja Then
                        MsgBox("Artículo marcado con control de baja.", MsgBoxStyle.Information, "Control de Baja")
                        Me.gvLineasAlbaran.SetFocusedValue(String.Empty)
                        Me.gvLineasAlbaran.SetFocusedRowCellValue(Me.colDescripcion, String.Empty)
                        Me.gvLineasAlbaran.FocusedColumn = Me.colId
                        Exit Sub
                    ElseIf CodigoArticulo <> String.Empty Then
                        Me.gvLineasAlbaran.SetFocusedValue(CodigoArticulo)
                        Me.gvLineasAlbaran.SetFocusedRowCellValue(Me.colDescripcion, Almacen.DameDescripcionArticulo(CodigoArticulo))
                        Me.gvLineasAlbaran.SetFocusedRowCellValue(Me.colPrecio, PrecioCoste)
                        Me.gvLineasAlbaran.FocusedColumn = Me.colDescripcion
                    Else
                        MsgBox("No existe ningún artículo asociado con ese código.", MsgBoxStyle.Information, "No existe")
                        Me.gvLineasAlbaran.SetFocusedValue(String.Empty)
                        Me.gvLineasAlbaran.SetFocusedRowCellValue(Me.colDescripcion, String.Empty)
                        Me.gvLineasAlbaran.FocusedColumn = Me.colId
                    End If

                Case Me.colCantidad.Name, Me.colPrecio.Name, Me.colDescuento.Name

                    'Si cambia cantidad comprobar gestión de tallas y colores
                    If e.Column Is Me.colCantidad And (GestionTallas Or GestionColores) Then
                        If GestionTallas Or GestionColores Then
                            Me.gvLineasAlbaran.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
                            If Me.gvLineasAlbaran.IsNewItemRow(Me.gvLineasAlbaran.FocusedRowHandle) Then Me.gvLineasAlbaran.UpdateCurrentRow()
                            If AlbaranesComprasDetalle.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                                Me.LimpiaLinea(True)
                                Me.gvLineasAlbaran.FocusedColumn = Me.colDescripcion
                            End If
                            Me.gvLineasAlbaran.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                        End If
                    End If
                    'Calcula total
                    Dim Total As Decimal
                    Total = Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCantidad) * Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colPrecio)
                    Total -= Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCantidad) * Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colPrecio) * Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colDescuento) / 100
                    Me.gvLineasAlbaran.SetFocusedRowCellValue(Me.colTotal, Total)

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        Finally
            AddHandler gvLineasAlbaran.CellValueChanged, AddressOf gvLineasAlbaran_CellValueChanged
        End Try

        If e.Column Is Me.colCodigoArticulo Then
            If IsNumeric(Me.txtCodigoProveedor.EditValue) Then Me.DsAlbaranesCompras.InfoArticulo(Me.txtCodigoProveedor.EditValue, Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCodigoArticulo))
        End If

    End Sub
#End Region

#Region "gvLineasAlbaran_RowUpdated"
    Private Sub gvLineasAlbaran_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvLineasAlbaran.FocusedRowChanged
        Try
            Me.colCodigoArticulo.OptionsColumn.ReadOnly = Not Me.gvLineasAlbaran.IsNewItemRow(e.FocusedRowHandle)
            Me.bttCodigoArticulo.Buttons(0).Enabled = Me.gvLineasAlbaran.IsNewItemRow(e.FocusedRowHandle)
            If IsNumeric(Me.txtCodigoProveedor.EditValue) Then Me.DsAlbaranesCompras.InfoArticulo(Me.txtCodigoProveedor.EditValue, Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCodigoArticulo))
            If Me.gvLineasAlbaran.IsNewItemRow(e.FocusedRowHandle) Then Me.gvLineasAlbaran.FocusedColumn = Me.colCodigoArticulo

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub gvLineasAlbaran_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvLineasAlbaran.RowUpdated
        Try
            Me.gvLineasAlbaran.MoveLastVisible()
            Me.CalculaTotal()

            If IsNumeric(Me.txtCodigoProveedor.EditValue) Then
                With DirectCast(e.Row.Row, dsAlbaranesCompras.ALBARANES_COMPRAS_LINEASRow)
                    If .CodigoArticulo <> String.Empty Then
                        Dim fActualizar As New fActualizacionPrecios(Me.txtCodigoProveedor.EditValue, .CodigoArticulo, .Precio)
                        fActualizar.ShowDialog()
                    End If
                End With
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "CalculaTotal"
    Private Sub CalculaTotal()
        Dim i As Integer, Total As Decimal
        For i = 0 To Me.gvLineasAlbaran.RowCount - 1
            Total += Me.gvLineasAlbaran.GetRowCellValue(i, Me.colTotal)
        Next
        Me.txtTotalAlbaran.EditValue = Total
    End Sub
#End Region

#Region "gvDetalleLineasAlbaran_CustomDrawCell"
    Private Sub gvDetalleLineasAlbaran_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvDetalleLineasAlbaran.CustomDrawCell
        Try
            Select Case e.Column.Name
                Case Me.colDetalleCodigoColor.Name
                    If IsNumeric(e.DisplayText) Then
                        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(e.DisplayText)), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
                        e.Appearance.ForeColor = Color.FromArgb(e.DisplayText)
                    End If

                Case Me.colDetalleDescripcionTalla.Name
                    If e.DisplayText = String.Empty Then
                        Dim rLineaAlbaran As dsAlbaranesCompras.ALBARANES_COMPRAS_LINEASRow
                        Dim rLineaDetalleAlbaran As dsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLERow
                        rLineaDetalleAlbaran = Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE.Rows(e.RowHandle)
                        rLineaAlbaran = Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS.FindById(rLineaDetalleAlbaran.LineaAlbaranCompra_Id)
                        rLineaDetalleAlbaran.DescripcionTalla = Almacen.DameTallaArticulo(rLineaAlbaran.CodigoArticulo, rLineaDetalleAlbaran.CodigoTalla)
                    End If
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "LimpiaLinea"
    Private Sub LimpiaLinea(Optional ByVal SoloCantidades As Boolean = False)
        Me.gvLineasAlbaran.SetFocusedRowCellValue(Me.colCantidad, 0)
        If Not SoloCantidades Then
            Me.gvLineasAlbaran.SetFocusedRowCellValue(Me.colDescuento, 0)
            Me.gvLineasAlbaran.SetFocusedRowCellValue(Me.colObservaciones, String.Empty)
        End If
        'Eliminar detalles color-talla
        Dim i As Integer, rDetalle As dsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLERow
        For i = Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE.Rows.Count - 1 To 0 Step -1
            rDetalle = Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE.Rows(i)
            If rDetalle.LineaAlbaranCompra_Id = Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colId) Then rDetalle.Delete()
        Next
    End Sub
#End Region

#Region "DameAlbaran"
    Private Sub DameAlbaran(ByVal IdAlbaran As Integer)

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            Me.DsAlbaranesCompras.Clear()

            'Cabecera Albaran
            cmd.CommandText = "SELECT * FROM ALBARANES_COMPRAS WHERE Id=" & IdAlbaran
            Me.DsAlbaranesCompras.ALBARANES_COMPRAS.Load(cmd.ExecuteReader)

            'Líneas del Albaran
            Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS.AlbaranCompra_IdColumn.DefaultValue = IdAlbaran
            cmd.CommandText = "SELECT *, 0 AS LineaPedido_Id, Cantidad AS CantidadAnterior FROM ALBARANES_COMPRAS_LINEAS WHERE AlbaranCompra_Id=" & IdAlbaran
            Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS.Load(cmd.ExecuteReader)

            'Detalles Albaran color-talla
            If GestionTallas Or GestionColores Then
                cmd.CommandText = "SELECT *, 0 AS LineaDetallePedido_Id, Cantidad AS CantidadAnterior FROM ALBARANES_COMPRAS_LINEAS_DETALLE " & _
                                  "WHERE LineaAlbaranCompra_Id IN (SELECT Id FROM ALBARANES_COMPRAS_LINEAS WHERE AlbaranCompra_Id=" & IdAlbaran & ")"
                Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE.Load(cmd.ExecuteReader)
            End If

            Me.CalculaTotal()

            Me.ActivaDesactivaMenu(True)
            Me.gvLineasAlbaran.MoveLastVisible()
            Me.gvLineasAlbaran.Focus()

        Catch ex As Exception
            MsgBox("Error al cargar el albarán de compra." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "linkCantidad_DoubleClick"
    Private Sub linkCantidad_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles linkCantidad.DoubleClick
        Try
            If Not Me.bttCancelar.Enabled Or Me.gvLineasAlbaran.IsNewItemRow(Me.gvLineasAlbaran.FocusedRowHandle) Then Exit Sub
            RemoveHandler gvLineasAlbaran.CellValueChanged, AddressOf gvLineasAlbaran_CellValueChanged

            'Si cambia cantidad comprobar gestión de tallas y colores
            If GestionTallas Or GestionColores Then
                If GestionTallas Or GestionColores Then
                    Me.gvLineasAlbaran.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
                    If AlbaranesComprasDetalle.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                        Me.LimpiaLinea(True)
                        Me.gvLineasAlbaran.FocusedColumn = Me.colDescripcion
                    End If
                    Me.gvLineasAlbaran.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                End If
            End If
            'Calcula total
            Dim Total As Decimal
            Total = Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCantidad) * Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colPrecio)
            Total -= Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCantidad) * Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colPrecio) * Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colDescuento) / 100
            Me.gvLineasAlbaran.SetFocusedRowCellValue(Me.colTotal, Total)

        Catch ex As Exception

        Finally
            AddHandler gvLineasAlbaran.CellValueChanged, AddressOf gvLineasAlbaran_CellValueChanged
        End Try
    End Sub
#End Region

#Region "TienePedidosPendientes"
    Private Function TienePedidosPendientes() As Boolean

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT ISNULL(SUM(CASE WHEN ISNULL(Cantidad,0)>ISNULL(CantidadServida,0) THEN ISNULL(Cantidad,0)-ISNULL(CantidadServida,0) ELSE 0 END),0) " & _
                              "FROM PEDIDOS INNER JOIN PEDIDOS_LINEAS ON PEDIDOS.Id=PEDIDOS_LINEAS.Pedido_Id " & _
                              "WHERE CodigoProveedor=" & CType(Me.txtCodigoProveedor.EditValue, Integer)

            Return cmd.ExecuteScalar

        Catch ex As Exception
            MsgBox("Error al comprobar si existen pedidos pendientes", MsgBoxStyle.Exclamation)
            Return False
        Finally
            cmd.Connection.Close()
        End Try

    End Function
#End Region

#Region "bttPedidosPendientes_Click"
    Private Sub bttPedidosPendientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttPedidosPendientes.Click

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT *, 0 AS Traspasar FROM PEDIDOS " & _
                              "WHERE CodigoProveedor=" & CType(Me.txtCodigoProveedor.EditValue, Integer) & _
                              " AND (SELECT SUM(CASE WHEN Cantidad>CantidadServida THEN Cantidad-CantidadServida ELSE 0 END) FROM PEDIDOS_LINEAS WHERE Pedido_Id=PEDIDOS.Id)>0"

            PedidosPendientes.DsPedidos.Clear()
            PedidosPendientes.DsPedidos.PEDIDOS.Load(cmd.ExecuteReader)

            cmd.CommandText = "SELECT PEDIDOS_LINEAS.*, Cantidad-CantidadServida AS CantidadPendiente, 0 AS CantidadAlbaran, 0 AS Traspasar " & _
                              "FROM PEDIDOS INNER JOIN PEDIDOS_LINEAS ON PEDIDOS.Id=PEDIDOS_LINEAS.Pedido_Id " & _
                              "WHERE CodigoProveedor=" & CType(Me.txtCodigoProveedor.EditValue, Integer) & _
                              " AND CASE WHEN Cantidad>CantidadServida THEN Cantidad-CantidadServida ELSE 0 END > 0"

            PedidosPendientes.DsPedidos.PEDIDOS_LINEAS.Load(cmd.ExecuteReader)

            cmd.CommandText = "SELECT PEDIDOS_LINEAS_DETALLE.*, PEDIDOS_LINEAS_DETALLE.Cantidad-PEDIDOS_LINEAS_DETALLE.CantidadServida AS CantidadPendiente, 0 AS CantidadAlbaran, 0 AS Traspasar " & _
                              "FROM PEDIDOS INNER JOIN PEDIDOS_LINEAS ON PEDIDOS.Id=PEDIDOS_LINEAS.Pedido_Id " & _
                              "INNER JOIN PEDIDOS_LINEAS_DETALLE ON PEDIDOS_LINEAS.Id=PEDIDOS_LINEAS_DETALLE.LineaPedido_ID " & _
                              "WHERE CodigoProveedor=" & CType(Me.txtCodigoProveedor.EditValue, Integer) & _
                              " AND CASE WHEN PEDIDOS_LINEAS.Cantidad>PEDIDOS_LINEAS.CantidadServida THEN PEDIDOS_LINEAS.Cantidad-PEDIDOS_LINEAS.CantidadServida ELSE 0 END > 0 " & _
                              " AND CASE WHEN PEDIDOS_LINEAS_DETALLE.Cantidad>PEDIDOS_LINEAS_DETALLE.CantidadServida THEN PEDIDOS_LINEAS_DETALLE.Cantidad-PEDIDOS_LINEAS_DETALLE.CantidadServida ELSE 0 END > 0"

            PedidosPendientes.DsPedidos.PEDIDOS_LINEAS_DETALLE.Load(cmd.ExecuteReader)

        Catch ex As Exception
            MsgBox("Error al mostrar pedidos pendientes", MsgBoxStyle.Exclamation)
        Finally

        End Try

        If PedidosPendientes.ShowDialog() = Windows.Forms.DialogResult.OK Then Me.bttPedidosPendientes.Enabled = False : Me.CalculaTotal()

    End Sub
#End Region

#Region "NavLineasAlbaran_ButtonClick"
    Private Sub NavLineasAlbaran_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Remove Then
            If MsgBox("¿Seguro que desea eliminar la línea del albarán seleccionada?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If GestionTallas Or GestionColores Then

                    Dim i As Integer, LineaAlbaran_Id As Integer, rLineaDetalle As dsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLERow

                    LineaAlbaran_Id = Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colId)

                    For i = 0 To Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE.Rows.Count - 1
                        rLineaDetalle = Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE.Rows(i)
                        If rLineaDetalle.LineaAlbaranCompra_Id = LineaAlbaran_Id Then
                            Almacen.ActualizaStock(Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCodigoArticulo), rLineaDetalle.CodigoColor, rLineaDetalle.CodigoTalla, rLineaDetalle.CantidadAnterior * -1)
                        End If
                    Next

                Else

                    Almacen.ActualizaStock(Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCodigoArticulo), 0, 1, Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCantidadAnterior) * -1)

                End If

                Me.gvLineasAlbaran.DeleteRow(Me.gvLineasAlbaran.FocusedRowHandle)
                Me.ALBARANESCOMPRASLINEASBindingSource.EndEdit()
                Me.ALBARANES_COMPRAS_LINEASTableAdapter.Update(Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS)
                Me.ALBARANES_COMPRAS_LINEAS_DETALLETableAdapter.Update(Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE)

            End If

            e.Handled = True

        End If
    End Sub
#End Region

#Region "bttImprimir_Click"
    Private Sub bttImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimir.Click

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Informe As New InfAlbaranCompra

            'Informe.PrintingSystem.PreviewFormEx.PrintBarManager.AllowQuickCustomization = False
            'Informe.PrintingSystem.PreviewFormEx.Text = "Pedido Nº" & Me.txtNumeroPedido.EditValue
            'Informe.PrintingSystem.PreviewFormEx.MdiParent = Principal

            Dim dsInfAlbaranCompra As New dsInfAlbaranCompra

            'Datos tienda
            cmd.CommandText = "SELECT * FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
            dsInfAlbaranCompra.TIENDAS.Load(cmd.ExecuteReader)

            'Datos proveedor
            cmd.CommandText = "SELECT * FROM PROVEEDORES WHERE Codigo=" & Me.txtCodigoProveedor.EditValue
            dsInfAlbaranCompra.PROVEEDORES.Load(cmd.ExecuteReader)

            'Datos pedido
            dsInfAlbaranCompra.ALBARANES.Merge(Me.DsAlbaranesCompras.ALBARANES_COMPRAS)
            dsInfAlbaranCompra.ALBARANES_LINEAS.Merge(Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS)
            dsInfAlbaranCompra.ALBARANES_LINEAS_DETALLE.Merge(Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE)

            Informe.DataSource = dsInfAlbaranCompra

            If GestionTallas Or GestionColores Then
                'Cargar descripciones de tallas y colores
                Dim i As Integer
                For i = 0 To dsInfAlbaranCompra.ALBARANES_LINEAS_DETALLE.Rows.Count - 1
                    Dim rLineaAlbaran As dsInfAlbaranCompra.ALBARANES_LINEASRow
                    Dim rLineaDetalleAlbaran As dsInfAlbaranCompra.ALBARANES_LINEAS_DETALLERow
                    rLineaDetalleAlbaran = dsInfAlbaranCompra.ALBARANES_LINEAS_DETALLE.Rows(i)
                    If rLineaDetalleAlbaran.RowState <> DataRowState.Deleted Then
                        rLineaAlbaran = dsInfAlbaranCompra.ALBARANES_LINEAS.FindById(rLineaDetalleAlbaran.LineaAlbaranCompra_Id)
                        rLineaDetalleAlbaran.DescripcionColor = Almacen.DameDescripcionColor(rLineaDetalleAlbaran.CodigoColor)
                        rLineaDetalleAlbaran.DescripcionTalla = Almacen.DameTallaArticulo(rLineaAlbaran.CodigoArticulo, rLineaDetalleAlbaran.CodigoTalla)
                    End If
                Next
            Else
                Informe.DetalleLineas.Visible = False
            End If

            Informe.CreateDocument()

            Dim f As New PreImpreso
            f.Informe.PrintingSystem = Informe.PrintingSystem

            General.AbrirFormulario(f, "Albarán Nº" & Me.txtNumeroAlbaran.EditValue)

        Catch ex As Exception
            MsgBox("Error al cargar los datos del albarán", MsgBoxStyle.Exclamation)
        Finally
            cmd.Connection.Close()
            Me.Cursor = Cursors.Default
        End Try

    End Sub
#End Region

#Region "bttFichaArticulo_Click"
    Private Sub bttFichaArticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttFichaArticulo.Click
        Try
            Dim Articulo As New Articulos

            AbrirFormulario(Articulo, "Fichero de Artículos")
            Articulo.txtCodigo.EditValue = Me.gvLineasAlbaran.GetFocusedRowCellValue(Me.colCodigoArticulo)
            Articulo.txtCodigo.IsModified = True
            Articulo.txtCodigo_Validated(Articulo.txtCodigo, Nothing)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "DatosCabecera_Validated"
    Private Sub txtNumeroAlbaran_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumeroAlbaran.Validated, txtFecha.Validated, txtCodigoProveedor.Validated

        If Not IsDate(Me.txtFecha.Text) Or Me.txtNumeroAlbaran.Text = "" Or Not IsNumeric(Me.txtCodigoProveedor.EditValue) Then Exit Sub

        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT COUNT(*) FROM ALBARANES_COMPRAS WHERE NumeroAlbaran = '" & Me.txtNumeroAlbaran.EditValue & "' AND CONVERT(varchar,Fecha,103) = '" & CDate(Me.txtFecha.EditValue).ToString("dd/MM/yyyy") & "' AND CodigoProveedor = " & CInt(Me.txtCodigoProveedor.EditValue)

            If cmd.ExecuteScalar > 0 Then
                MsgBox("Ya existe un albarán del proveedor con ese número y fecha", MsgBoxStyle.Exclamation, Me.Text)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        Finally
            cmd.Connection.Close()
        End Try

    End Sub
#End Region

End Class