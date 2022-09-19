Public Class Pedidos

    Dim rPedido As dsPedidos.PEDIDOSRow

#Region "Pedidos_FormClosing"
    Private Sub Pedidos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.bttCancelar.Text = "Cancelar" And Me.DsPedidos.HasChanges Then
            If MsgBox("Está editando un pedido. ¿Seguro que desea salir sin guardar los cambios?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then e.Cancel = True Else Me.Dispose()
        Else
            'Me.Dispose()
        End If
    End Sub
#End Region

#Region "Pedidos_KeyUp"
    Private Sub Pedidos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape And Not Me.bttGuardar.Enabled Then Me.Close()
    End Sub
#End Region

#Region "Pedidos_Load"
    Private Sub Pedidos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If GestionColores Then Me.COLORESTableAdapter.Fill(Me.DsArticulos.COLORES)
        Me.DsPedidos.PEDIDOS.CodigoTiendaColumn.DefaultValue = CodigoTienda
        Me.DsPedidos.PEDIDOS.FechaColumn.DefaultValue = Date.Now
        Me.dgLineasPedido.LevelTree.Nodes.Add("FK_PEDIDOS_LINEAS_PEDIDOS_LINEAS_DETALLE", Me.gvDetalleLineasPedido)
    End Sub
#End Region

#Region "Pedidos_Shown"
    Private Sub Pedidos_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en precios
        'Me.maskPrecio.Mask.EditMask = "c" & DecimalesPrecio
        Me.maskPrecio.Mask.EditMask = "c3"
        Me.maskImporte.Mask.EditMask = "c" & DecimalesImporte
        'Detalle color-talla
        If GestionTallas Or GestionColores Then
            Me.gvLineasPedido.OptionsView.ShowDetailButtons = True
            Me.gvDetalleLineasPedido.ActiveFilterString = "Cantidad<>0"
        End If
    End Sub
#End Region

#Region "bttNuevo_Click"
    Private Sub bttNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttNuevo.Click
        Try
            Me.DsPedidos.Clear()

            rPedido = DsPedidos.PEDIDOS.NewPEDIDOSRow
            Me.DsPedidos.PEDIDOS_LINEAS.Pedido_IdColumn.DefaultValue = rPedido.Id
            Me.DsPedidos.PEDIDOS.AddPEDIDOSRow(rPedido)

            Me.ActivaDesactivaMenu(False)
            Me.ActivaDesactivaCampos(False)
            Me.txtCodigoProveedor.Focus()

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
            Me.gvLineasPedido.Focus()
            Me.gvLineasPedido.MoveLastVisible()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click
        Try
            Dim dsPedidos As New dsPedidos
            Dim Columnas As New ArrayList

            Columnas.Add("Id") 'Campo
            Columnas.Add("Id") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("NumeroPedido")
            Columnas.Add("Nº Pedido")
            Columnas.Add(80)
            Columnas.Add(80)

            Columnas.Add("Fecha")
            Columnas.Add("Fecha")
            Columnas.Add(80)
            Columnas.Add(80)

            Columnas.Add("FechaEntrega")
            Columnas.Add("F.Entrega")
            Columnas.Add(80)
            Columnas.Add(80)

            Columnas.Add("NombreProveedor")
            Columnas.Add("Proveedor")
            Columnas.Add(0)
            Columnas.Add(0)

            Columnas.Add("Traspasar")
            Columnas.Add("Pendiente")
            Columnas.Add(70)
            Columnas.Add(70)

            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT PEDIDOS.*, (SELECT SUM(CASE WHEN ISNULL(Cantidad,0)>ISNULL(CantidadServida,0) THEN 1 ELSE 0 END) FROM PEDIDOS_LINEAS WHERE Pedido_Id=PEDIDOS.Id) AS Traspasar FROM PEDIDOS"
            If Not My.Computer.Keyboard.CtrlKeyDown Then cmd.CommandText &= " WHERE FechaEnvio IS NULL"

            dsPedidos.PEDIDOS.Load(cmd.ExecuteReader)

            cmd.Connection.Close()

            If Buscar(dsPedidos, "Pedidos", Columnas, 1, True, "[Traspasar]=True").ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.DamePedido(ResultadoBusqueda)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttEliminar_Click"
    Private Sub bttEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttEliminar.Click
        Try
            If MsgBox("¿Seguro que desea eliminar el pedido?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar cliente") = MsgBoxResult.Yes Then
                Me.EliminarPedido()
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Try
            If sender.text = "Salir" Then Me.Close()

            'If MsgBox("¿Seguro que desea deshacer los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Deshacer cambios") = MsgBoxResult.No Then Exit Sub

            Me.PEDIDOSBindingSource.CancelEdit()

            'If Me.PEDIDOSBindingSource.Count = 0 Then
            '    Me.DsPedidos.Clear()
            'Else
            '    Me.PEDIDOSLINEASBindingSource.CancelEdit()
            'End If

            Me.DsPedidos.RejectChanges()

            Me.ActivaDesactivaMenu(True)
            Me.ActivaDesactivaCampos(True)

            Me.txtNumeroPedido.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttGuardar_Click"
    Private Sub bttGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttGuardar.Click

        'Si es botón de envío preparar fichero para enviar
        If Me.bttGuardar.Text = "Enviar" Then

            If MsgBox("¿Seguro que desea enviar el pedido?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            Dim NombreFichero As String

            If Trim(Me.txtCodigoProveedor.EditValue) = "00101" Then
                NombreFichero = "ffr" & Format(General.NumeroAlmacen, "00") & ".seq"
            Else
                NombreFichero = "fpedi" & Format(General.NumeroAlmacen, "00") & ".seq"
            End If

            If Comunicacion.GeneraPedido(Me.DsPedidos, NombreFichero) Then

                'Me.EliminarPedido()

                If Comunicacion.Envio(NombreFichero) Then

                    'Marcar pedido como enviado
                    If Me.DsPedidos.PEDIDOS.Count > 0 Then
                        Me.PEDIDOSTableAdapter.PedidoEnviado(Me.DsPedidos.PEDIDOS(0).Id)
                    End If

                    MsgBox("Pedido enviado correctamente", MsgBoxStyle.Information)

                    Me.Close()

                Else
                    MsgBox("Error al enviar el fichero generado.", MsgBoxStyle.Exclamation)
                End If

            Else
                MsgBox("Error en la generación del pedido", MsgBoxStyle.Exclamation)
            End If

            Exit Sub

        End If

        'Comprobar datos obligatorios
        If Not IsNumeric(Me.txtCodigoProveedor.EditValue) Then
            MsgBox("Falta indicar el proveedor", MsgBoxStyle.Information)
            Me.txtCodigoProveedor.Focus()
            Exit Sub
        End If

        Dim conexion As New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        conexion.Open()
        Dim transaccion As SqlClient.SqlTransaction
        transaccion = conexion.BeginTransaction()

        Try
            'If MsgBox("¿Seguro que desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar cambios") = MsgBoxResult.No Then Exit Sub

            'Contador nº pedido de tienda
            If Me.txtNumeroPedido.EditValue Is System.DBNull.Value Then
                Dim cmd As New SqlClient.SqlCommand("UPDATE TIENDAS SET NumeroPedido=NumeroPedido+1 WHERE CodigoTienda=" & CodigoTienda, conexion)
                cmd.Transaction = transaccion
                cmd.ExecuteNonQuery()
                cmd.CommandText = "SELECT NumeroPedido FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
                Me.txtNumeroPedido.EditValue = cmd.ExecuteScalar
            End If

            Me.PEDIDOSBindingSource.EndEdit()
            Me.PEDIDOSLINEASBindingSource.EndEdit()
            Me.PEDIDOSLINEASDETALLEBindingSource.EndEdit()

            Me.PEDIDOSTableAdapter.Update(Me.DsPedidos.PEDIDOS)
            Me.PEDIDOS_LINEASTableAdapter.Update(Me.DsPedidos.PEDIDOS_LINEAS)
            Me.PEDIDOS_LINEAS_DETALLETableAdapter.Update(Me.DsPedidos.PEDIDOS_LINEAS_DETALLE)

            transaccion.Commit()

            Me.ActivaDesactivaMenu(True)
            Me.ActivaDesactivaCampos(True)

            Me.txtNumeroPedido.Focus()

        Catch ex As Exception
            transaccion.Rollback()
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        conexion.Close()

        If Me.DsPedidos.PEDIDOS.Count > 0 Then
            Me.DsPedidos.PEDIDOS_LINEAS.Pedido_IdColumn.DefaultValue = Me.DsPedidos.PEDIDOS(0).Id
        End If

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

    Private Sub txtCodigoProveedor_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoProveedor.EditValueChanged
        If IsNumeric(Me.txtCodigoProveedor.EditValue) Then Me.txtCodigoProveedor.EditValue = Format(CType(Me.txtCodigoProveedor.EditValue, Integer), "00000")
    End Sub

    Private Sub txtCodigoProveedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoProveedor.Validated
        Try
            If Not Me.bttCancelar.Enabled Then Exit Sub

            Me.DatosProveedor()

            If Me.txtCodigoProveedor.EditValue = String.Empty Then Me.txtCodigoProveedor.Focus() : Exit Try Else Me.gvLineasPedido.Focus()

            'Si es calavia comprobar si existe pedido
            If General.FormatoEmpresa = 2 And Me.txtCodigoProveedor.EditValue = 1 Then Me.ComprobarPedido()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "ActivaDesactivaMenu"
    Private Sub ActivaDesactivaMenu(ByVal activa As Boolean)

        Me.bttNuevo.Enabled = activa
        Me.bttBuscar.Enabled = activa
        Me.bttModificar.Enabled = IIf(Me.PEDIDOSBindingSource.Count = 0, False, activa)
        Me.bttEliminar.Enabled = IIf(Me.PEDIDOSBindingSource.Count = 0, False, activa)
        Me.bttImprimir.Enabled = IIf(Me.PEDIDOSBindingSource.Count = 0, False, activa)
        'Me.bttCancelar.Enabled = Not activa
        Me.bttCancelar.Text = IIf(activa, "Salir", "Cancelar")
        Me.bttGuardar.Enabled = Not activa
        If (GestionTallas Or GestionColores) Then Me.colCantidad.ColumnEdit = IIf(activa, Me.maskCantidad, Me.linkCantidad)
        Me.CalculaTotal()
        Me.gvLineasPedido.CollapseAllDetails()

        If Me.bttModificar.Enabled Then
            'Comprobar si tiene comunicaciones para activar botón envío
            General.DatosTiendaActual(CodigoTienda)
            If General.Comunicaciones_Tipo > 0 Then
                Me.bttGuardar.Text = "Enviar"
                Me.bttGuardar.Enabled = True
            End If
        Else
            Me.bttGuardar.Text = "Guardar"
        End If

    End Sub
#End Region

#Region "ActivaDesactivaCampos"
    Private Sub ActivaDesactivaCampos(ByVal activa As Boolean)
        'Me.txtNumeroPedido.Properties.ReadOnly = activa
        Me.txtFecha.Properties.ReadOnly = activa
        Me.txtFechaEntrega.Properties.ReadOnly = activa
        Me.txtCodigoProveedor.Properties.ReadOnly = activa
        Me.txtCodigoProveedor.Properties.Buttons(0).Enabled = Not activa
        Me.txtNombreProveedor.Properties.ReadOnly = activa
        Me.bttGenerarPedido.Enabled = IIf(activa, False, (Me.DsPedidos.PEDIDOS_LINEAS.Rows.Count = 0))
        Me.txtObservaciones.Properties.ReadOnly = activa
        Me.gvLineasPedido.OptionsView.NewItemRowPosition = IIf(activa, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom)
        Me.gvLineasPedido.OptionsBehavior.AllowAddRows = IIf(activa, DevExpress.Utils.DefaultBoolean.False, DevExpress.Utils.DefaultBoolean.True)
        Me.gvLineasPedido.OptionsBehavior.AllowDeleteRows = IIf(activa, DevExpress.Utils.DefaultBoolean.False, DevExpress.Utils.DefaultBoolean.True)
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = activa
        Me.colDescripcion.OptionsColumn.ReadOnly = activa
        Me.colCantidad.OptionsColumn.ReadOnly = activa
        Me.colPrecio.OptionsColumn.ReadOnly = activa
        Me.colDescuento.OptionsColumn.ReadOnly = activa
        Me.colObservaciones.OptionsColumn.ReadOnly = activa
    End Sub
#End Region

#Region "DatosProveedor"
    Private Sub DatosProveedor()
        Try
            Dim dr As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
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

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
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
                If Me.gvLineasPedido.GetRow(Me.gvLineasPedido.FocusedRowHandle) Is Nothing Then Me.gvLineasPedido.AddNewRow()
                Me.gvLineasPedido.SetFocusedValue(ResultadoBusqueda)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "gvLineasPedido_CellValueChanged"
    Private Sub gvLineasPedido_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvLineasPedido.CellValueChanged
        Try
            RemoveHandler gvLineasPedido.CellValueChanged, AddressOf gvLineasPedido_CellValueChanged

            Select Case e.Column.Name
                Case Me.colCodigoArticulo.Name

                    Dim CodigoArticulo As String = String.Empty, ControlBaja As Boolean, PrecioCoste As Decimal, TipoArticulo As String = String.Empty

                    Me.LimpiaLinea()

                    Dim dr As SqlClient.SqlDataReader
                    Dim cmd As New SqlClient.SqlCommand
                    cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
                    cmd.Connection.Open()

                    'Comprobar si es un código de barras de báscula
                    If Len(Me.gvLineasPedido.GetFocusedRowCellValue(Me.colCodigoArticulo)) = 13 And IsNumeric(Mid(Me.gvLineasPedido.GetFocusedRowCellValue(Me.colCodigoArticulo), 8, 5)) And (Mid(Me.gvLineasPedido.GetFocusedRowCellValue(Me.colCodigoArticulo), 1, 2) = PrefijoBascula1 Or Mid(Me.gvLineasPedido.GetFocusedRowCellValue(Me.colCodigoArticulo), 1, 2) = PrefijoBascula2 Or Mid(Me.gvLineasPedido.GetFocusedRowCellValue(Me.colCodigoArticulo), 1, 2) = PrefijoBascula3) Then

                        'Mostrar información del artículo
                        CodigoArticulo = "00" & Mid(Me.gvLineasPedido.GetFocusedRowCellValue(Me.colCodigoArticulo), 3, 5)

                        cmd.CommandText = "SELECT Codigo, PrecioCoste, ControlBaja, TipoArticulo FROM Articulos WHERE Codigo='" & CodigoArticulo & "'"

                        dr = cmd.ExecuteReader
                        If dr.Read Then
                            CodigoArticulo = dr("Codigo")
                            PrecioCoste = dr("PrecioCoste")
                            ControlBaja = dr("ControlBaja")
                            TipoArticulo = dr("TipoArticulo")
                        End If
                        dr.Close()

                        If General.FormatoEmpresa = 2 And Me.txtCodigoProveedor.EditValue = 1 Then 'CALAVIA
                            If Not IsNumeric(CodigoArticulo) Then
                                Me.gvLineasPedido.SetFocusedValue(String.Empty)
                                Me.gvLineasPedido.FocusedColumn = Me.colId
                                Exit Sub
                            End If
                            If Int(CodigoArticulo) < 1000 Or Int(CodigoArticulo) > 99999 Then
                                Me.gvLineasPedido.SetFocusedValue(String.Empty)
                                Me.gvLineasPedido.FocusedColumn = Me.colId
                                Exit Sub
                            End If
                            If General.TipoTienda <> 0 And (TipoArticulo = "5" Or UCase(TipoArticulo) = "X") Then
                                Me.gvLineasPedido.SetFocusedValue(String.Empty)
                                Me.gvLineasPedido.FocusedColumn = Me.colId
                                Exit Sub
                            End If
                        End If

                        If ControlBaja Then
                            MsgBox("Artículo marcado con control de baja", MsgBoxStyle.Information, "Control de Baja")
                            Me.gvLineasPedido.SetFocusedValue(String.Empty)
                            Me.gvLineasPedido.SetFocusedRowCellValue(Me.colDescripcion, String.Empty)
                            Me.gvLineasPedido.FocusedColumn = Me.colId
                            Exit Sub
                        ElseIf CodigoArticulo <> String.Empty Then
                            Me.gvLineasPedido.SetFocusedValue(CodigoArticulo)
                            Me.gvLineasPedido.SetFocusedRowCellValue(Me.colDescripcion, Almacen.DameDescripcionArticulo(CodigoArticulo))
                            Me.gvLineasPedido.SetFocusedRowCellValue(Me.colPrecio, PrecioCoste)
                            Me.gvLineasPedido.FocusedColumn = Me.colDescripcion
                        Else
                            MsgBox("No existe ningún artículo asociado con ese código", MsgBoxStyle.Information, "No existe")
                            Me.gvLineasPedido.SetFocusedValue(String.Empty)
                            Me.gvLineasPedido.SetFocusedRowCellValue(Me.colDescripcion, String.Empty)
                            Me.gvLineasPedido.FocusedColumn = Me.colId
                        End If

                        Me.InfoArticulo()
                        Me.ComprobarArticulo(CodigoArticulo, e.RowHandle)

                        Exit Sub

                    End If

                    'Mostrar información del artículo
                    cmd.CommandText = "SELECT Codigo, PrecioCoste, ControlBaja, TipoArticulo FROM Articulos WHERE Codigo='" & Me.gvLineasPedido.FocusedValue & "'"
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        CodigoArticulo = dr("Codigo")
                        PrecioCoste = dr("PrecioCoste")
                        ControlBaja = dr("ControlBaja")
                        TipoArticulo = dr("TipoArticulo")
                    End If
                    dr.Close()

                    'Comprobar si es un código de barras
                    If CodigoArticulo = String.Empty Then

                        cmd.CommandText = "SELECT Codigo, PrecioCoste, ControlBaja, TipoArticulo " & _
                                          "FROM Articulos INNER JOIN Codigo_Barras on Articulos.Id=Codigo_Barras.Articulo_Id " & _
                                          "WHERE Codigo_Barras.Codigobarras='" & Me.gvLineasPedido.GetFocusedRowCellValue(Me.colCodigoArticulo) & "'"

                        dr = cmd.ExecuteReader
                        If dr.Read Then
                            CodigoArticulo = dr("Codigo")
                            PrecioCoste = dr("PrecioCoste")
                            ControlBaja = dr("ControlBaja")
                            TipoArticulo = dr("TipoArticulo")
                        End If
                        dr.Close()

                        If General.FormatoEmpresa = 2 And Me.txtCodigoProveedor.EditValue = 1 Then 'CALAVIA
                            If Not IsNumeric(CodigoArticulo) Then
                                Me.gvLineasPedido.SetFocusedValue(String.Empty)
                                Me.gvLineasPedido.FocusedColumn = Me.colCodigoArticulo
                                Exit Sub
                            End If
                            If Int(CodigoArticulo) < 1000 Or Int(CodigoArticulo) > 99999 Then
                                Me.gvLineasPedido.SetFocusedValue(String.Empty)
                                Me.gvLineasPedido.FocusedColumn = Me.colCodigoArticulo
                                Exit Sub
                            End If
                            If General.TipoTienda <> 0 And (TipoArticulo = "5" Or UCase(TipoArticulo) = "X") Then
                                Me.gvLineasPedido.SetFocusedValue(String.Empty)
                                Me.gvLineasPedido.FocusedColumn = Me.colCodigoArticulo
                                Exit Sub
                            End If
                        End If

                        If ControlBaja Then
                            MsgBox("Artículo marcado con control de baja", MsgBoxStyle.Information, "Control de Baja")
                            Me.gvLineasPedido.SetFocusedValue(String.Empty)
                            Me.gvLineasPedido.FocusedColumn = Me.colCodigoArticulo
                            Exit Sub
                        ElseIf CodigoArticulo <> String.Empty Then
                            Me.gvLineasPedido.SetFocusedValue(CodigoArticulo)
                            Me.gvLineasPedido.SetFocusedRowCellValue(Me.colDescripcion, Almacen.DameDescripcionArticulo(CodigoArticulo))
                            Me.gvLineasPedido.SetFocusedRowCellValue(Me.colPrecio, PrecioCoste)
                            Me.gvLineasPedido.FocusedColumn = Me.colDescripcion
                        Else
                            MsgBox("No existe ningún artículo asociado a ese código de barras.", MsgBoxStyle.Information, "No existe")
                            Me.gvLineasPedido.SetFocusedValue(String.Empty)
                            Me.gvLineasPedido.SetFocusedRowCellValue(Me.colDescripcion, String.Empty)
                            Me.gvLineasPedido.FocusedColumn = Me.colId
                        End If

                        Me.InfoArticulo()
                        Me.ComprobarArticulo(CodigoArticulo, e.RowHandle)

                        Exit Sub

                    End If

                    If General.FormatoEmpresa = 2 And Me.txtCodigoProveedor.EditValue = 1 Then 'CALAVIA
                        If Not IsNumeric(CodigoArticulo) Then
                            Me.gvLineasPedido.SetFocusedValue(String.Empty)
                            Me.gvLineasPedido.FocusedColumn = Me.colCodigoArticulo
                            Exit Sub
                        End If
                        If Int(CodigoArticulo) < 1000 Or Int(CodigoArticulo) > 99999 Then
                            Me.gvLineasPedido.SetFocusedValue(String.Empty)
                            Me.gvLineasPedido.FocusedColumn = Me.colCodigoArticulo
                            Exit Sub
                        End If
                        If General.TipoTienda <> 0 And (TipoArticulo = "5" Or UCase(TipoArticulo) = "X") Then
                            Me.gvLineasPedido.SetFocusedValue(String.Empty)
                            Me.gvLineasPedido.FocusedColumn = Me.colCodigoArticulo
                            Exit Sub
                        End If
                    End If

                    If ControlBaja Then
                        MsgBox("Artículo marcado con control de baja.", MsgBoxStyle.Information, "Control de Baja")
                        Me.gvLineasPedido.SetFocusedValue(String.Empty)
                        Me.gvLineasPedido.SetFocusedRowCellValue(Me.colDescripcion, String.Empty)
                        Me.gvLineasPedido.FocusedColumn = Me.colId
                        Exit Sub
                    ElseIf CodigoArticulo <> String.Empty Then
                        Me.gvLineasPedido.SetFocusedValue(CodigoArticulo)
                        Me.gvLineasPedido.SetFocusedRowCellValue(Me.colDescripcion, Almacen.DameDescripcionArticulo(CodigoArticulo))
                        Me.gvLineasPedido.SetFocusedRowCellValue(Me.colPrecio, PrecioCoste)
                        Me.gvLineasPedido.FocusedColumn = Me.colDescripcion
                    Else
                        MsgBox("No existe ningún artículo asociado con ese código.", MsgBoxStyle.Information, "No existe")
                        Me.gvLineasPedido.SetFocusedValue(String.Empty)
                        Me.gvLineasPedido.SetFocusedRowCellValue(Me.colDescripcion, String.Empty)
                        Me.gvLineasPedido.FocusedColumn = Me.colId
                    End If

                    Me.InfoArticulo()
                    Me.ComprobarArticulo(CodigoArticulo, e.RowHandle)

                Case Me.colCajas.Name, Me.colCantidad.Name

                    If e.Column Is Me.colCajas Then
                        'Calcular unidades por caja
                        Dim UnidadesCaja As Integer
                        UnidadesCaja = Almacen.DameUnidadesCajaArticulo(Me.gvLineasPedido.GetRowCellValue(Me.gvLineasPedido.FocusedRowHandle, Me.colCodigoArticulo))
                        Me.gvLineasPedido.SetRowCellValue(Me.gvLineasPedido.FocusedRowHandle, Me.colCantidad, e.Value * UnidadesCaja)
                    Else
                        'Calcular cajas
                        Dim UnidadesCaja As Integer
                        UnidadesCaja = Almacen.DameUnidadesCajaArticulo(Me.gvLineasPedido.GetRowCellValue(Me.gvLineasPedido.FocusedRowHandle, Me.colCodigoArticulo))
                        If UnidadesCaja <> 0 Then
                            If e.Value Mod UnidadesCaja = 0 Then
                                Me.gvLineasPedido.SetRowCellValue(Me.gvLineasPedido.FocusedRowHandle, Me.colCajas, Int(e.Value / UnidadesCaja))
                            Else
                                Me.gvLineasPedido.SetRowCellValue(Me.gvLineasPedido.FocusedRowHandle, Me.colCajas, 0)
                            End If
                        Else
                            Me.gvLineasPedido.SetRowCellValue(Me.gvLineasPedido.FocusedRowHandle, Me.colCajas, 0)
                        End If
                    End If

                    'Comprobar mínimo compra
                    Dim MinimoCompra As Decimal = Almacen.DameMinimoCompraArticulo(Me.gvLineasPedido.GetRowCellValue(e.RowHandle, Me.colCodigoArticulo))
                    If Me.gvLineasPedido.GetRowCellValue(e.RowHandle, Me.colCantidad) < MinimoCompra Then
                        MsgBox("El mínimo de compra del artículo es " & MinimoCompra)
                    End If

                    'Si cambia cantidad comprobar gestión de tallas y colores
                    If (e.Column Is Me.colCajas Or e.Column Is Me.colCantidad) And (GestionTallas Or GestionColores) Then
                        If GestionTallas Or GestionColores Then
                            Me.gvLineasPedido.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
                            If Me.gvLineasPedido.IsNewItemRow(Me.gvLineasPedido.FocusedRowHandle) Then Me.gvLineasPedido.UpdateCurrentRow()
                            If PedidosDetalle.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                                Me.LimpiaLinea(True)
                                Me.gvLineasPedido.FocusedColumn = Me.colDescripcion
                            End If
                            Me.gvLineasPedido.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                        End If
                    End If

                    'Calcular total línea
                    Me.CalculaTotalLinea()

                Case Me.colPrecio.Name, Me.colDescuento.Name
                    Me.CalculaTotalLinea()

            End Select

        Catch ex As Exception

        Finally
            AddHandler gvLineasPedido.CellValueChanged, AddressOf gvLineasPedido_CellValueChanged
        End Try
    End Sub
#End Region

#Region "gvLineasPedido_RowUpdated"
    Private Sub gvLineasPedido_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvLineasPedido.RowUpdated
        Me.gvLineasPedido.MoveLastVisible()
        Me.gvLineasPedido.FocusedColumn = Me.colCodigoArticulo
        Me.CalculaTotal()
        Me.bttGenerarPedido.Enabled = (Me.DsPedidos.PEDIDOS_LINEAS.Rows.Count = 0)
    End Sub
#End Region

#Region "CalculaTotal"
    Private Sub CalculaTotal()
        Dim i As Integer, Total As Decimal
        For i = 0 To Me.gvLineasPedido.RowCount - 1
            Total += Me.gvLineasPedido.GetRowCellValue(i, Me.colTotal)
        Next
        Me.txtTotalPedido.EditValue = Total
    End Sub
#End Region

#Region "CalculaTotalLinea"
    Private Sub CalculaTotalLinea()
        'Calcula total
        Dim Total As Decimal
        Total = Me.gvLineasPedido.GetFocusedRowCellValue(Me.colCantidad) * Me.gvLineasPedido.GetFocusedRowCellValue(Me.colPrecio)
        Total -= Me.gvLineasPedido.GetFocusedRowCellValue(Me.colCantidad) * Me.gvLineasPedido.GetFocusedRowCellValue(Me.colPrecio) * Me.gvLineasPedido.GetFocusedRowCellValue(Me.colDescuento) / 100
        Me.gvLineasPedido.SetFocusedRowCellValue(Me.colTotal, Total)
    End Sub
#End Region

#Region "gvDetalleLineasPedido_CustomDrawCell"
    Private Sub gvDetalleLineasPedido_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvDetalleLineasPedido.CustomDrawCell
        Try
            Select Case e.Column.Name
                Case Me.colDetalleCodigoColor.Name
                    If IsNumeric(e.DisplayText) Then
                        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(e.DisplayText)), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
                        e.Appearance.ForeColor = Color.FromArgb(e.DisplayText)
                    End If

                Case Me.colDetalleDescripcionTalla.Name
                    If e.DisplayText = String.Empty Then
                        Dim rLineaPedido As dsPedidos.PEDIDOS_LINEASRow
                        Dim rLineaDetallePedido As dsPedidos.PEDIDOS_LINEAS_DETALLERow
                        rLineaDetallePedido = Me.DsPedidos.PEDIDOS_LINEAS_DETALLE.Rows(e.RowHandle)
                        If rLineaDetallePedido.RowState <> DataRowState.Deleted Then
                            rLineaPedido = Me.DsPedidos.PEDIDOS_LINEAS.FindById(rLineaDetallePedido.LineaPedido_Id)
                            rLineaDetallePedido.DescripcionTalla = Almacen.DameTallaArticulo(rLineaPedido.CodigoArticulo, rLineaDetallePedido.CodigoTalla)
                        End If
                    End If
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "LimpiaLinea"
    Private Sub LimpiaLinea(Optional ByVal SoloCantidades As Boolean = False)
        Me.gvLineasPedido.SetFocusedRowCellValue(Me.colCantidad, 0)
        If Not SoloCantidades Then
            Me.gvLineasPedido.SetFocusedRowCellValue(Me.colDescuento, 0)
            Me.gvLineasPedido.SetFocusedRowCellValue(Me.colObservaciones, String.Empty)
        End If
        'Eliminar detalles color-talla
        Dim i As Integer, rDetalle As dsPedidos.PEDIDOS_LINEAS_DETALLERow
        For i = Me.DsPedidos.PEDIDOS_LINEAS_DETALLE.Rows.Count - 1 To 0 Step -1
            rDetalle = Me.DsPedidos.PEDIDOS_LINEAS_DETALLE.Rows(i)
            If rDetalle.LineaPedido_Id = Me.gvLineasPedido.GetFocusedRowCellValue(Me.colId) Then rDetalle.Delete()
        Next
    End Sub
#End Region

#Region "DamePedido"
    Private Sub DamePedido(ByVal IdPedido As Integer)

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            Me.DsPedidos.Clear()

            'Cabecera pedido
            cmd.CommandText = "SELECT * FROM PEDIDOS WHERE Id=" & IdPedido
            Me.DsPedidos.PEDIDOS.Load(cmd.ExecuteReader)

            'Líneas del pedido
            Me.DsPedidos.PEDIDOS_LINEAS.Pedido_IdColumn.DefaultValue = IdPedido
            cmd.CommandText = "SELECT * FROM PEDIDOS_LINEAS WHERE Pedido_Id=" & IdPedido
            Me.DsPedidos.PEDIDOS_LINEAS.Load(cmd.ExecuteReader)

            'Calcula cajas
            Dim i As Integer
            Dim UnidadesCaja As Integer
            Dim rLineaPedido As dsPedidos.PEDIDOS_LINEASRow
            For i = 0 To Me.DsPedidos.PEDIDOS_LINEAS.Rows.Count - 1
                rLineaPedido = Me.DsPedidos.PEDIDOS_LINEAS.Rows(i)
                UnidadesCaja = Almacen.DameUnidadesCajaArticulo(rLineaPedido.CodigoArticulo)
                If UnidadesCaja <> 0 Then
                    rLineaPedido.Cajas = Int(rLineaPedido.Cantidad / UnidadesCaja)
                End If
            Next

            'Detalles pedido color-talla
            If GestionTallas Or GestionColores Then
                cmd.CommandText = "SELECT * FROM PEDIDOS_LINEAS_DETALLE " & _
                                  "WHERE LineaPedido_Id IN (SELECT Id FROM PEDIDOS_LINEAS WHERE Pedido_Id=" & IdPedido & ")"
                Me.DsPedidos.PEDIDOS_LINEAS_DETALLE.Load(cmd.ExecuteReader)
            End If

            Me.CalculaTotal()

            Me.ActivaDesactivaMenu(True)
            Me.gvLineasPedido.MoveLastVisible()
            Me.gvLineasPedido.Focus()

        Catch ex As Exception
            MsgBox("Error al cargar el pedido." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "linkCantidad_DoubleClick"
    Private Sub linkCantidad_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles linkCantidad.DoubleClick
        Try
            If Not Me.bttCancelar.Enabled Or Me.gvLineasPedido.IsNewItemRow(Me.gvLineasPedido.FocusedRowHandle) Then Exit Sub
            RemoveHandler gvLineasPedido.CellValueChanged, AddressOf gvLineasPedido_CellValueChanged

            'Si cambia cantidad comprobar gestión de tallas y colores
            If GestionTallas Or GestionColores Then
                If GestionTallas Or GestionColores Then
                    Me.gvLineasPedido.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
                    If PedidosDetalle.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                        Me.LimpiaLinea(True)
                        Me.gvLineasPedido.FocusedColumn = Me.colDescripcion
                    End If
                    Me.gvLineasPedido.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                End If
            End If
            'Calcula total
            Dim Total As Decimal
            Total = Me.gvLineasPedido.GetFocusedRowCellValue(Me.colCantidad) * Me.gvLineasPedido.GetFocusedRowCellValue(Me.colPrecio)
            Total -= Me.gvLineasPedido.GetFocusedRowCellValue(Me.colCantidad) * Me.gvLineasPedido.GetFocusedRowCellValue(Me.colPrecio) * Me.gvLineasPedido.GetFocusedRowCellValue(Me.colDescuento) / 100
            Me.gvLineasPedido.SetFocusedRowCellValue(Me.colTotal, Total)

        Catch ex As Exception

        Finally
            AddHandler gvLineasPedido.CellValueChanged, AddressOf gvLineasPedido_CellValueChanged
        End Try
    End Sub
#End Region

#Region "bttGenerarPedido_Click"
    Private Sub bttGenerarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttGenerarPedido.Click

        If Not IsNumeric(Me.txtCodigoProveedor.EditValue) Then
            MsgBox("Seleccione primero un proveedor", MsgBoxStyle.Information)
            Me.txtCodigoProveedor.Focus()
            Exit Sub
        End If

        If MsgBox("¿Seguro que desea generar automáticamente el pedido al proveedor?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Me.Cursor = Cursors.WaitCursor

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            Dim dr As SqlClient.SqlDataReader

            'Líneas del pedido
            Dim rLineaPedido As dsPedidos.PEDIDOS_LINEASRow

            Dim sqlCantidadPedidos As String
            If GestionTallas Or GestionColores Then
                sqlCantidadPedidos = "(SELECT ISNULL(SUM(CASE WHEN ISNULL(PEDIDOS_LINEAS_DETALLE.Cantidad,0)>ISNULL(PEDIDOS_LINEAS_DETALLE.CantidadServida,0) THEN ISNULL(PEDIDOS_LINEAS_DETALLE.Cantidad,0)-ISNULL(PEDIDOS_LINEAS_DETALLE.CantidadServida,0) ELSE 0 END),0) FROM (PEDIDOS INNER JOIN PEDIDOS_LINEAS ON PEDIDOS.Id=PEDIDOS_LINEAS.Pedido_Id) INNER JOIN PEDIDOS_LINEAS_DETALLE ON PEDIDOS_LINEAS.Id=PEDIDOS_LINEAS_DETALLE.LineaPedido_Id WHERE PEDIDOS.FechaEnvio IS NULL AND PEDIDOS_LINEAS.CodigoArticulo=Articulos.Codigo)"
            Else
                sqlCantidadPedidos = "(SELECT ISNULL(SUM(CASE WHEN ISNULL(Cantidad,0)>ISNULL(CantidadServida,0) THEN ISNULL(Cantidad,0)-ISNULL(CantidadServida,0) ELSE 0 END),0) FROM PEDIDOS INNER JOIN PEDIDOS_LINEAS ON PEDIDOS.Id=PEDIDOS_LINEAS.Pedido_Id WHERE PEDIDOS.FechaEnvio IS NULL AND PEDIDOS_LINEAS.CodigoArticulo=Articulos.Codigo)"
            End If

            cmd.CommandText = "SELECT Articulos.Codigo, Articulos.Descripcion, Articulos.TipoArticulo, Articulos.MinimoCompra, Articulos.UnidadCaja, Articulos.PrecioCoste, " & _
                              "SUM(ISNULL(CASE WHEN Existencias.StockMaximo <> 0 THEN Existencias.StockMaximo - " & IIf(Me.checkPedirStockMaximo.Checked, "0", "Existencias.ExistenciaActual") & " ELSE Existencias.StockMinimo - Existencias.ExistenciaActual END, 0)) - " & sqlCantidadPedidos & " AS Cantidad " & _
                              "FROM Articulos INNER JOIN Existencias ON Articulos.Id = Existencias.Articulo_Id "

            cmd.CommandText &= "WHERE Existencias.CodigoTienda=" & CodigoTienda & " AND ControlBaja=0 AND CodigoProveedor=" & CType(Me.txtCodigoProveedor.EditValue, Integer) & " AND StockMinimo<>0 " & _
                               "AND ExistenciaActual<StockMinimo "

            'cmd.CommandText &= "WHERE Existencias.CodigoTienda=" & CodigoTienda & " AND ControlBaja=0 AND CodigoProveedor=" & CType(Me.txtCodigoProveedor.EditValue, Integer) & " AND StockMinimo<>0 " & _
            '                  "AND ExistenciaActual<StockMinimo AND CASE WHEN StockMaximo<>0 THEN StockMaximo-ExistenciaActual ELSE StockMinimo-ExistenciaActual END >0 "

            'If General.ArticuloPropioInicio <> String.Empty Then cmd.CommandText &= " AND Articulos.Codigo<='" & General.ArticuloPropioInicio & "' "
            'If General.ArticuloPropioFin <> String.Empty Then cmd.CommandText &= " AND Articulos.Codigo>='" & General.ArticuloPropioFin & "' "

            cmd.CommandText &= "GROUP BY Articulos.Codigo, Articulos.Descripcion, Articulos.TipoArticulo, Articulos.MinimoCompra, Articulos.UnidadCaja, Articulos.PrecioCoste"

            dr = cmd.ExecuteReader
            While dr.Read
                If dr("Cantidad") > 0 Then

                    Try

                        If General.FormatoEmpresa = 2 And Me.txtCodigoProveedor.EditValue = 1 Then 'CALAVIA
                            If Not IsNumeric(dr("Codigo")) Then
                                Exit Try
                            End If
                            If Int(dr("Codigo")) < 1000 Or Int(dr("Codigo")) > 99999 Then
                                Exit Try
                            End If
                            If General.TipoTienda <> 0 And (dr("TipoArticulo") = "5" Or UCase(dr("TipoArticulo")) = "X") Then
                                Exit Try
                            End If
                        End If

                        'Añadir línea al pedido
                        rLineaPedido = Me.DsPedidos.PEDIDOS_LINEAS.NewPEDIDOS_LINEASRow
                        rLineaPedido.CodigoArticulo = dr("Codigo")
                        rLineaPedido.Descripcion = dr("Descripcion")
                        rLineaPedido.Cantidad = IIf(dr("MinimoCompra") <> 0 And dr("Cantidad") < dr("MinimoCompra"), dr("MinimoCompra"), dr("Cantidad"))
                        If Me.checkRedondearCajas.Checked And dr("UnidadCaja") <> 0 Then
                            rLineaPedido.Cajas = Math.Round(rLineaPedido.Cantidad / dr("UnidadCaja"), 0)
                            If rLineaPedido.Cajas = 0 Then rLineaPedido.Cajas = 1
                            rLineaPedido.Cantidad = rLineaPedido.Cajas * dr("UnidadCaja")
                        End If
                        rLineaPedido.Precio = dr("PrecioCoste")
                        rLineaPedido.Total = rLineaPedido.Cantidad * rLineaPedido.Precio
                        Me.DsPedidos.PEDIDOS_LINEAS.AddPEDIDOS_LINEASRow(rLineaPedido)

                    Catch ex As Exception
                        MsgBox("Error al añadir el artículo " & dr("Codigo"))
                    End Try

                End If
            End While
            dr.Close()

            'Detalles de las líneas de pedido
            If GestionTallas Or GestionColores Then

                Dim rLineaDetallePedido As dsPedidos.PEDIDOS_LINEAS_DETALLERow
                Dim i As Integer

                sqlCantidadPedidos = "(SELECT ISNULL(SUM(PEDIDOS_LINEAS_DETALLE.Cantidad),0) FROM PEDIDOS_LINEAS INNER JOIN PEDIDOS_LINEAS_DETALLE ON PEDIDOS_LINEAS.Id=PEDIDOS_LINEAS_DETALLE.LineaPedido_Id WHERE PEDIDOS_LINEAS.CodigoArticulo=Articulos.Codigo AND PEDIDOS_LINEAS_DETALLE.CodigoColor=Existencias.CodigoColor AND PEDIDOS_LINEAS_DETALLE.CodigoTalla=Existencias.CodigoTalla)"

                For i = 0 To Me.DsPedidos.PEDIDOS_LINEAS.Rows.Count - 1

                    rLineaPedido = Me.DsPedidos.PEDIDOS_LINEAS.Rows(i)

                    cmd.CommandText = "SELECT Existencias.CodigoColor, Existencias.CodigoTalla, CASE WHEN Existencias.StockMaximo<>0 THEN Existencias.StockMaximo-Existencias.ExistenciaActual ELSE Existencias.StockMinimo-Existencias.ExistenciaActual END - " & sqlCantidadPedidos & "  AS Cantidad " & _
                                      "FROM Articulos INNER JOIN Existencias ON Articulos.Id = Existencias.Articulo_Id " & _
                                      "WHERE Existencias.CodigoTienda=" & CodigoTienda & " AND Articulos.Codigo='" & rLineaPedido.CodigoArticulo & "'"

                    dr = cmd.ExecuteReader
                    While dr.Read
                        rLineaDetallePedido = Me.DsPedidos.PEDIDOS_LINEAS_DETALLE.NewPEDIDOS_LINEAS_DETALLERow
                        rLineaDetallePedido.LineaPedido_Id = rLineaPedido.Id
                        rLineaDetallePedido.CodigoColor = dr("CodigoColor")
                        rLineaDetallePedido.CodigoTalla = dr("CodigoTalla")
                        rLineaDetallePedido.DescripcionTalla = Almacen.DameTallaArticulo(rLineaPedido.CodigoArticulo, rLineaDetallePedido.CodigoTalla)
                        rLineaDetallePedido.Cantidad = dr("Cantidad")
                        Me.DsPedidos.PEDIDOS_LINEAS_DETALLE.AddPEDIDOS_LINEAS_DETALLERow(rLineaDetallePedido)
                    End While
                    dr.Close()

                Next

            End If

            Me.gvLineasPedido.Focus()
            Me.gvLineasPedido.MoveLastVisible()
            Me.gvLineasPedido.FocusedColumn = Me.colCodigoArticulo

            Me.CalculaTotal()

            Me.bttGenerarPedido.Enabled = False

        Catch ex As Exception
            MsgBox("Error al generar el pedido automáticamente." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation)
        Finally
            cmd.Connection.Close()
            Me.Cursor = Cursors.Default
        End Try

    End Sub
#End Region

#Region "bttImprimir_Click"
    Private Sub bttImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimir.Click

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Informe As New InfPedido

            'Informe.PrintingSystem.PreviewFormEx.PrintBarManager.AllowQuickCustomization = False
            'Informe.PrintingSystem.PreviewFormEx.Text = "Pedido Nº" & Me.txtNumeroPedido.EditValue
            'Informe.PrintingSystem.PreviewFormEx.MdiParent = Principal

            Dim dsInfPedido As New dsInfPedido

            'Datos tienda
            cmd.CommandText = "SELECT * FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
            dsInfPedido.TIENDAS.Load(cmd.ExecuteReader)

            'Datos proveedor
            cmd.CommandText = "SELECT * FROM PROVEEDORES WHERE Codigo=" & Me.txtCodigoProveedor.EditValue
            dsInfPedido.PROVEEDORES.Load(cmd.ExecuteReader)

            'Datos pedido
            dsInfPedido.PEDIDOS.Merge(Me.DsPedidos.PEDIDOS)
            dsInfPedido.PEDIDOS_LINEAS.Merge(Me.DsPedidos.PEDIDOS_LINEAS)
            dsInfPedido.PEDIDOS_LINEAS_DETALLE.Merge(Me.DsPedidos.PEDIDOS_LINEAS_DETALLE)

            Informe.DataSource = dsInfPedido

            If GestionTallas Or GestionColores Then
                'Cargar descripciones de tallas y colores
                Dim i As Integer
                For i = 0 To dsInfPedido.PEDIDOS_LINEAS_DETALLE.Rows.Count - 1
                    Dim rLineaPedido As dsInfPedido.PEDIDOS_LINEASRow
                    Dim rLineaDetallePedido As dsInfPedido.PEDIDOS_LINEAS_DETALLERow
                    rLineaDetallePedido = dsInfPedido.PEDIDOS_LINEAS_DETALLE.Rows(i)
                    If rLineaDetallePedido.RowState <> DataRowState.Deleted Then
                        rLineaPedido = dsInfPedido.PEDIDOS_LINEAS.FindById(rLineaDetallePedido.LineaPedido_Id)
                        rLineaDetallePedido.DescripcionColor = Almacen.DameDescripcionColor(rLineaDetallePedido.CodigoColor)
                        rLineaDetallePedido.DescripcionTalla = Almacen.DameTallaArticulo(rLineaPedido.CodigoArticulo, rLineaDetallePedido.CodigoTalla)
                    End If
                Next
            Else
                Informe.DetalleLineas.Visible = False
            End If

            'Calcular cajas
            For i As Integer = 0 To dsInfPedido.PEDIDOS_LINEAS.Count - 1
                With dsInfPedido.PEDIDOS_LINEAS(i)

                    Dim UnidadesCaja As Integer = Almacen.DameUnidadesCajaArticulo(.CodigoArticulo)
                    If UnidadesCaja <> 0 Then
                        If .Cantidad Mod UnidadesCaja = 0 Then
                            .Cajas = Int(.Cantidad / UnidadesCaja)
                        End If
                    End If

                    If .Cajas = 0 Then .SetCajasNull()

                End With
            Next

            Informe.CreateDocument()

            Dim f As New PreImpreso
            f.Informe.PrintingSystem = Informe.PrintingSystem

            General.AbrirFormulario(f, "Pedido Nº" & Me.txtNumeroPedido.EditValue)

        Catch ex As Exception
            MsgBox("Error al cargar los datos del pedido", MsgBoxStyle.Exclamation)
        Finally
            cmd.Connection.Close()
            Me.Cursor = Cursors.Default
        End Try

    End Sub
#End Region

#Region "EliminarPedido"
    Private Sub EliminarPedido()
        Try
            Me.PEDIDOSBindingSource.RemoveCurrent()
            Me.PEDIDOSTableAdapter.Update(Me.DsPedidos.PEDIDOS)
            Me.PEDIDOS_LINEASTableAdapter.Update(Me.DsPedidos.PEDIDOS_LINEAS)
            Me.PEDIDOS_LINEAS_DETALLETableAdapter.Update(Me.DsPedidos.PEDIDOS_LINEAS_DETALLE)
            Me.txtTotalPedido.EditValue = 0
            Me.ActivaDesactivaMenu(True)
            Me.txtNumeroPedido.Focus()
        Catch ex As Exception
            MsgBox("Error al eliminar el pedido", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "gvLineasPedido_FocusedRowChanged"
    Private Sub gvLineasPedido_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvLineasPedido.FocusedRowChanged
        Me.InfoArticulo()
        If Me.gvLineasPedido.IsNewItemRow(e.FocusedRowHandle) Then Me.gvLineasPedido.FocusedColumn = Me.colCodigoArticulo
    End Sub
#End Region

#Region "InfoArticulo"
    Private Sub InfoArticulo()

        Me.lblInfoArticulo.Text = String.Empty

        If Me.gvLineasPedido.GetRow(Me.gvLineasPedido.FocusedRowHandle) Is Nothing Then Exit Sub

        'Mostrar datos del artículo
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT ISNULL(Sum(StockMinimo),0) AS StockMinimo, ISNULL(Sum(StockMaximo),0) AS StockMaximo, ISNULL(Sum(ExistenciaActual),0) AS ExistenciaActual, UnidadCaja, MinimoCompra " & _
                              "FROM ARTICULOS LEFT JOIN Existencias ON Articulos.Id = EXISTENCIAS.Articulo_Id " & _
                              "WHERE CodigoTienda=" & CodigoTienda & " AND Codigo='" & Me.gvLineasPedido.GetRowCellValue(Me.gvLineasPedido.FocusedRowHandle, Me.colCodigoArticulo) & "' " & _
                              "GROUP BY UnidadCaja, MinimoCompra"

            dr = cmd.ExecuteReader
            If dr.Read Then
                Me.lblInfoArticulo.Text = "Stock mínimo: " & dr("StockMinimo") & "   Stock máximo: " & dr("StockMaximo") & "   Existencias: " & dr("ExistenciaActual") & "   Unidades/Caja: " & dr("UnidadCaja") & "   Mínimo compra: " & dr("MinimoCompra")
            End If
            dr.Close()

        Catch ex As Exception
            'Error al obtener datos del artículo
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "ComprobarArticulo"
    Private Sub ComprobarArticulo(ByVal Codigo As String, ByVal fila As Integer)
        Try
            If Codigo = String.Empty Then Exit Try

            'Comprobar si la referencia ya está en el pedido
            Dim i As Integer
            For i = 0 To Me.gvLineasPedido.RowCount - 1
                If i <> fila And Me.gvLineasPedido.GetRowCellValue(i, Me.colCodigoArticulo) = Codigo Then
                    MsgBox("El artículo seleccionado ya se encuentra en el pedido", MsgBoxStyle.Information)
                    Me.gvLineasPedido.CancelUpdateCurrentRow()
                    Me.gvLineasPedido.FocusedColumn = Me.colId
                    Me.gvLineasPedido.MoveLastVisible()
                    Exit For
                End If
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "ComprobarPedido"
    Private Sub ComprobarPedido()

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Dim IdPedido As Integer

        Try
            cmd.CommandText = "SELECT Id FROM PEDIDOS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoProveedor=1 AND FechaEnvio IS NULL"
            IdPedido = cmd.ExecuteScalar

            If IdPedido > 0 Then
                Me.DamePedido(IdPedido)
                Me.bttModificar_Click(Nothing, Nothing)
            End If

        Catch ex As Exception
            'Error al comprobar si existe etiqueta
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Sub
#End Region

End Class