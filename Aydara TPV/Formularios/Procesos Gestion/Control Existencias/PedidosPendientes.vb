Public Class PedidosPendientes 

#Region "PedidosPendientes_Load"
    Private Sub PedidosPendientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If GestionColores Then Me.COLORESTableAdapter.Fill(Me.DsArticulos.COLORES)
        Me.dgPedidos.LevelTree.Nodes.Add("PEDIDOS_PEDIDOS_LINEAS", Me.gvLineasPedidos)
        Me.dgPedidos.LevelTree.Nodes(2).Nodes.Add("FK_PEDIDOS_LINEAS_PEDIDOS_LINEAS_DETALLE", Me.gvDetalleLineasPedidos)
    End Sub
#End Region

#Region "PedidosPendientes_Shown"
    Private Sub PedidosPendientes_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en precios
        Me.maskImporte.Mask.EditMask = "c" & DecimalesPrecio
        Me.maskImporte.Mask.EditMask = "c" & DecimalesImporte
        'Detalle color-talla
        If GestionTallas Or GestionColores Then
            Me.colCantidadAlbaran.Visible = False
            Me.gvLineasPedidos.OptionsDetail.SmartDetailExpand = True
        End If
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

#Region "gvPedidos_CellValueChanged"
    Private Sub gvPedidos_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvLineasPedidos.CellValueChanged, gvDetalleLineasPedidos.CellValueChanged
        Try
            Select Case e.Column.Name
                Case Me.colCantidadAlbaran.Name

                    Dim grilla As DevExpress.XtraGrid.Views.Grid.GridView = Me.dgPedidos.FocusedView

                    If e.Value > grilla.GetFocusedRowCellValue(Me.colCantidadPendiente) Then
                        grilla.SetFocusedValue(grilla.GetFocusedRowCellValue(Me.colCantidadPendiente))
                    End If

                    grilla.SetFocusedRowCellValue(Me.colTraspasarLinea, (e.Value > 0))

                Case Me.colCantidadAlbaranDetalle.Name

                    Dim grilla As DevExpress.XtraGrid.Views.Grid.GridView = Me.dgPedidos.FocusedView

                    If e.Value > grilla.GetFocusedRowCellValue(Me.colCantidadPendienteDetalle) Then
                        grilla.SetFocusedValue(grilla.GetFocusedRowCellValue(Me.colCantidadPendiente))
                    End If

                    grilla.SetFocusedRowCellValue(Me.colTraspasarLineaDetalle, (e.Value > 0))



            End Select
        Catch ex As Exception
            MsgBox("Error al actualizar la cantidad servida", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "gvPedidos_CellValueChanging"
    Private Sub gvPedidos_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvPedidos.CellValueChanging, gvLineasPedidos.CellValueChanging, gvDetalleLineasPedidos.CellValueChanging
        Try
            Select Case e.Column.Name
                Case Me.colTraspasarPedido.Name

                    'Actualizar líneas del pedido
                    Dim rLineaPedido As dsPedidos.PEDIDOS_LINEASRow
                    Dim i As Integer

                    For i = 0 To Me.DsPedidos.PEDIDOS_LINEAS.Rows.Count - 1

                        rLineaPedido = Me.DsPedidos.PEDIDOS_LINEAS.Rows(i)
                        If rLineaPedido.Pedido_Id = Me.gvPedidos.GetFocusedRowCellValue(Me.colId) Then

                            rLineaPedido.Traspasar = e.Value
                            rLineaPedido.CantidadAlbaran = IIf(e.Value = True, rLineaPedido.CantidadPendiente, 0)

                            'Actualizar detalle de líneas del pedido
                            If GestionTallas Or GestionColores Then
                                Dim rLineaPedidoDetalle As dsPedidos.PEDIDOS_LINEAS_DETALLERow
                                Dim j As Integer
                                For j = 0 To Me.DsPedidos.PEDIDOS_LINEAS_DETALLE.Rows.Count - 1
                                    rLineaPedidoDetalle = Me.DsPedidos.PEDIDOS_LINEAS_DETALLE.Rows(j)
                                    If rLineaPedidoDetalle.LineaPedido_Id = rLineaPedido.Id Then
                                        rLineaPedidoDetalle.Traspasar = e.Value
                                        rLineaPedidoDetalle.CantidadAlbaran = IIf(e.Value = True, rLineaPedidoDetalle.CantidadPendiente, 0)
                                    End If
                                Next
                            End If

                        End If
                    Next

                Case Me.colTraspasarLinea.Name

                    Dim grilla As DevExpress.XtraGrid.Views.Grid.GridView = Me.dgPedidos.FocusedView
                    grilla.SetFocusedRowCellValue(Me.colCantidadAlbaran, IIf(e.Value = True, grilla.GetFocusedRowCellValue(Me.colCantidadPendiente), 0))

                    'Actualizar detalle de líneas del pedido
                    If GestionTallas Or GestionColores Then
                        Dim rLineaPedidoDetalle As dsPedidos.PEDIDOS_LINEAS_DETALLERow
                        Dim j As Integer
                        For j = 0 To Me.DsPedidos.PEDIDOS_LINEAS_DETALLE.Rows.Count - 1
                            rLineaPedidoDetalle = Me.DsPedidos.PEDIDOS_LINEAS_DETALLE.Rows(j)
                            If rLineaPedidoDetalle.LineaPedido_Id = grilla.GetFocusedRowCellValue(Me.colLineaPedido_Id) Then
                                rLineaPedidoDetalle.Traspasar = e.Value
                                rLineaPedidoDetalle.CantidadAlbaran = IIf(e.Value = True, rLineaPedidoDetalle.CantidadPendiente, 0)
                            End If
                        Next
                    End If

                Case Me.colTraspasarLineaDetalle.Name

                    Dim grilla As DevExpress.XtraGrid.Views.Grid.GridView = Me.dgPedidos.FocusedView
                    grilla.SetFocusedRowCellValue(Me.colCantidadAlbaran, IIf(e.Value = True, grilla.GetFocusedRowCellValue(Me.colCantidadPendiente), 0))


            End Select
        Catch ex As Exception
            MsgBox("Error al actualizar cantidades", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "bttAceptar_Click"
    Private Sub bttAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttAceptar.Click

        Try
            Dim rLineaAlbaran As dsAlbaranesCompras.ALBARANES_COMPRAS_LINEASRow
            Dim rLineaAlbaranDetalle As dsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLERow

            Dim rLineaPedido As dsPedidos.PEDIDOS_LINEASRow
            Dim rLineaPedidoDetalle As dsPedidos.PEDIDOS_LINEAS_DETALLERow

            Dim i As Integer, j As Integer

            For i = 0 To Me.DsPedidos.PEDIDOS_LINEAS.Rows.Count - 1

                rLineaPedido = Me.DsPedidos.PEDIDOS_LINEAS.Rows(i)

                rLineaAlbaran = AlbaranesCompras.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS.NewALBARANES_COMPRAS_LINEASRow
                rLineaAlbaran.AlbaranCompra_Id = AlbaranesCompras.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS.AlbaranCompra_IdColumn.DefaultValue
                rLineaAlbaran.CodigoArticulo = rLineaPedido.CodigoArticulo
                rLineaAlbaran.Descripcion = rLineaPedido.Descripcion
                If Not (GestionColores Or GestionTallas) Then rLineaAlbaran.Cantidad = rLineaPedido.CantidadAlbaran
                rLineaAlbaran.Precio = rLineaPedido.Precio
                rLineaAlbaran.Descuento = rLineaPedido.Descuento
                rLineaAlbaran.Total = rLineaAlbaran.Cantidad * rLineaAlbaran.Precio - rLineaAlbaran.Cantidad * rLineaAlbaran.Precio * rLineaAlbaran.Descuento / 100
                rLineaAlbaran.LineaPedido_Id = rLineaPedido.Id
                AlbaranesCompras.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS.AddALBARANES_COMPRAS_LINEASRow(rLineaAlbaran)

                'Traspasar detalle de la línea
                For j = 0 To Me.DsPedidos.PEDIDOS_LINEAS_DETALLE.Rows.Count - 1

                    rLineaPedidoDetalle = Me.DsPedidos.PEDIDOS_LINEAS_DETALLE.Rows(j)

                    If rLineaPedidoDetalle.LineaPedido_Id = rLineaPedido.Id And rLineaPedidoDetalle.CantidadAlbaran > 0 Then

                        rLineaAlbaranDetalle = AlbaranesCompras.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE.NewALBARANES_COMPRAS_LINEAS_DETALLERow
                        rLineaAlbaranDetalle.LineaAlbaranCompra_Id = rLineaAlbaran.Id
                        rLineaAlbaranDetalle.CodigoColor = rLineaPedidoDetalle.CodigoColor
                        rLineaAlbaranDetalle.CodigoTalla = rLineaPedidoDetalle.CodigoTalla
                        rLineaAlbaranDetalle.Cantidad = rLineaPedidoDetalle.CantidadAlbaran
                        rLineaAlbaranDetalle.LineaDetallePedido_Id = rLineaPedidoDetalle.Id
                        AlbaranesCompras.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE.AddALBARANES_COMPRAS_LINEAS_DETALLERow(rLineaAlbaranDetalle)

                        rLineaPedidoDetalle.CantidadServida += rLineaPedidoDetalle.CantidadAlbaran
                        rLineaAlbaran.Cantidad += rLineaPedidoDetalle.CantidadAlbaran

                    End If
                Next

                If rLineaAlbaran.Cantidad > 0 Then
                    rLineaPedido.CantidadServida += rLineaAlbaran.Cantidad
                Else
                    rLineaAlbaran.Delete()
                End If

            Next

            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MsgBox("Error al traspasar líneas al albarán de compra", MsgBoxStyle.Exclamation)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Try

    End Sub
#End Region

#Region "gvDetalleLineasPedidos_CustomDrawCell"
    Private Sub gvDetalleLineasPedidos_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvDetalleLineasPedidos.CustomDrawCell
        Try
            Select Case e.Column.Name
                Case Me.colCodigoColor.Name
                    If IsNumeric(e.DisplayText) Then
                        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(e.DisplayText)), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
                        e.Appearance.ForeColor = Color.FromArgb(e.DisplayText)
                    End If

                Case Me.colDescripcionTalla.Name
                    If e.DisplayText = String.Empty Then
                        Dim rLineaPedido As dsPedidos.PEDIDOS_LINEASRow
                        Dim rLineaDetallePedido As dsPedidos.PEDIDOS_LINEAS_DETALLERow
                        rLineaDetallePedido = Me.DsPedidos.PEDIDOS_LINEAS_DETALLE.Rows(e.RowHandle)
                        rLineaPedido = Me.DsPedidos.PEDIDOS_LINEAS.FindById(rLineaDetallePedido.LineaPedido_Id)
                        rLineaDetallePedido.DescripcionTalla = Almacen.DameTallaArticulo(rLineaPedido.CodigoArticulo, rLineaDetallePedido.CodigoTalla)
                    End If
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

End Class