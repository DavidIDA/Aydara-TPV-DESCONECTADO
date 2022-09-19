Public Class AlbaranesComprasDetalle

#Region "AlbaranesComprasDetalle_FormClosing"
    Private Sub AlbaranesComprasDetalle_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.bttAceptar.Enabled Then
            Me.bttAceptar_Click(Nothing, Nothing)
        Else
            If MsgBox("La cantidad asignada no coincide con la cantidad indicada." & vbCrLf & "¿Seguro que desea cancelar la línea del albarán?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then e.Cancel = True
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub
#End Region

#Region "AlbaranesComprasDetalle_Load"
    Private Sub AlbaranesComprasDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DsAlbaranesCompras = AlbaranesCompras.DsAlbaranesCompras
        Me.ALBARANESCOMPRASLINEASDETALLEBindingSource.DataSource = AlbaranesCompras.DsAlbaranesCompras
        Me.ALBARANESCOMPRASLINEASDETALLEBindingSource.Filter = "LineaAlbaranCompra_Id=" & AlbaranesCompras.gvLineasAlbaran.GetFocusedRowCellValue(AlbaranesCompras.colId)
    End Sub
#End Region

#Region "AlbaranesComprasDetalle_Shown"
    Private Sub AlbaranesComprasDetalle_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            Me.Text = "Cantidad: " & AlbaranesCompras.gvLineasAlbaran.GetFocusedRowCellValue(AlbaranesCompras.colCantidad)

            'Si lleva gestión de tallas mostrar columna de talla
            Me.colDescripcionTalla.Visible = GestionTallas

            'Si lleva gestión de colores mostrar grilla de colores
            Me.dgColores.Visible = GestionColores

            'Posición de existencias y carga de colores si lleva gestión de colores
            If GestionColores Then
                Me.COLORESTableAdapter.Fill(Me.DsArticulos.COLORES)
                Me.ARTICULOS_COLORESTableAdapter.CodigoArticulo(Me.DsArticulos.ARTICULOS_COLORES, AlbaranesCompras.gvLineasAlbaran.GetFocusedRowCellValue(AlbaranesCompras.colCodigoArticulo))
            Else
                Me.Width = 190
            End If

            Me.DetalleLineasAlbaran()

            Me.SumaCantidades()

            Me.dgDetalleLineasAlbaran.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "gvColores_FocusedRowChanged"
    Private Sub gvColores_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvColores.FocusedRowChanged
        'Cargar datos
        If Not Me.gvColores.GetRow(e.FocusedRowHandle) Is Nothing Then
            Me.ALBARANESCOMPRASLINEASDETALLEBindingSource.Filter = "LineaAlbaranCompra_Id=" & AlbaranesCompras.gvLineasAlbaran.GetFocusedRowCellValue(AlbaranesCompras.colId) & " AND CodigoColor=" & Me.gvColores.GetRowCellValue(e.FocusedRowHandle, Me.colColores_Color_Id)
            If IsNumeric(Me.gvColores.GetRowCellDisplayText(e.FocusedRowHandle, Me.colColores_Color)) Then Me.BackColor = Color.FromArgb(Me.gvColores.GetRowCellDisplayText(e.FocusedRowHandle, Me.colColores_Color))
        End If
    End Sub
#End Region

#Region "gvColores_CustomDrawCell"
    Private Sub gvColores_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvColores.CustomDrawCell
        Try
            If Not e.Column Is Me.colColores_Color Then Exit Sub
            If IsNumeric(e.DisplayText) Then
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(e.DisplayText)), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
                e.Appearance.ForeColor = Color.FromArgb(e.DisplayText)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "DetalleLineasAlbaran"
    Public Sub DetalleLineasAlbaran()
        Try
            Dim rDetalleLineasAlbaran As dsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLERow

            Dim dr As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand
            Dim i As Integer, j As Integer, filas As Integer

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            'Cargar tallas
            cmd.CommandText = "SELECT * FROM ARTICULOS INNER JOIN TALLAS ON ARTICULOS.CodigoTalla=TALLAS.CodigoTalla " & _
                              "WHERE ARTICULOS.Codigo='" & AlbaranesCompras.gvLineasAlbaran.GetFocusedRowCellValue(AlbaranesCompras.colCodigoArticulo) & "'"
            dr = cmd.ExecuteReader

            If dr.Read Then
                For i = 0 To IIf(GestionColores, IIf(Me.DsArticulos.ARTICULOS_COLORES.Rows.Count = 0, 0, Me.DsArticulos.ARTICULOS_COLORES.Rows.Count - 1), 0)
                    For j = 1 To IIf(GestionTallas, 18, 1) 'Nº de tallas 
                        If dr("Talla_" & j) <> String.Empty Then
                            Try
                                'Comprobar si existen datos
                                For filas = 0 To Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE.Rows.Count - 1
                                    rDetalleLineasAlbaran = Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE.Rows(filas)
                                    If Not rDetalleLineasAlbaran.RowState = DataRowState.Deleted Then
                                        If rDetalleLineasAlbaran.LineaAlbaranCompra_Id = AlbaranesCompras.gvLineasAlbaran.GetFocusedRowCellValue(AlbaranesCompras.colId) And rDetalleLineasAlbaran.CodigoTalla = j Then
                                            If GestionColores And Me.DsArticulos.COLORES.Rows.Count > 0 Then
                                                If rDetalleLineasAlbaran.CodigoColor = Me.DsArticulos.ARTICULOS_COLORES.Rows(i).Item("Color_Id") Then
                                                    rDetalleLineasAlbaran.DescripcionTalla = dr("Talla_" & j)
                                                    Exit Try
                                                End If
                                            Else
                                                rDetalleLineasAlbaran.DescripcionTalla = dr("Talla_" & j)
                                                Exit Try
                                            End If
                                        End If
                                    End If
                                Next
                                rDetalleLineasAlbaran = DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE.NewALBARANES_COMPRAS_LINEAS_DETALLERow
                                rDetalleLineasAlbaran.LineaAlbaranCompra_Id = AlbaranesCompras.gvLineasAlbaran.GetFocusedRowCellValue(AlbaranesCompras.colId)
                                If GestionColores And Me.DsArticulos.ARTICULOS_COLORES.Rows.Count > 0 Then rDetalleLineasAlbaran.CodigoColor = Me.DsArticulos.ARTICULOS_COLORES.Rows(i).Item("Color_Id")
                                rDetalleLineasAlbaran.CodigoTalla = j
                                rDetalleLineasAlbaran.DescripcionTalla = dr("Talla_" & j)
                                Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE.AddALBARANES_COMPRAS_LINEAS_DETALLERow(rDetalleLineasAlbaran)
                            Catch ex As Exception
                                'Error al añadir existencia
                            End Try

                        End If
                    Next
                Next
            End If
            dr.Close()

            Me.gvDetalleLineasAlbaran.Columns("CodigoTalla").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttAceptar_Click"
    Private Sub bttAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        'Me.Dispose()
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Dispose()
    End Sub
#End Region

#Region "SumaCantidades"
    Private Sub SumaCantidades()
        Dim i As Integer
        Dim Cantidad As Integer
        Dim rDetalle As dsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLERow
        For i = 0 To Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE.Rows.Count - 1
            rDetalle = Me.DsAlbaranesCompras.ALBARANES_COMPRAS_LINEAS_DETALLE.Rows(i)
            If Not rDetalle.RowState = DataRowState.Deleted Then
                If rDetalle.LineaAlbaranCompra_Id = AlbaranesCompras.gvLineasAlbaran.GetFocusedRowCellValue(AlbaranesCompras.colId) Then
                    Cantidad += rDetalle.Cantidad
                End If
            End If
        Next
        If AlbaranesCompras.gvLineasAlbaran.GetFocusedRowCellValue(AlbaranesCompras.colCantidad) <> Cantidad Then
            Me.Text = "Faltan por asignar: " & AlbaranesCompras.gvLineasAlbaran.GetFocusedRowCellValue(AlbaranesCompras.colCantidad) - Cantidad
        Else
            Me.Text = "Cantidad pedida: " & AlbaranesCompras.gvLineasAlbaran.GetFocusedRowCellValue(AlbaranesCompras.colCantidad)
        End If
        Me.bttAceptar.Enabled = (AlbaranesCompras.gvLineasAlbaran.GetFocusedRowCellValue(AlbaranesCompras.colCantidad) - Cantidad = 0)
    End Sub
#End Region

#Region "gvDetalleLineasAlbaran_RowUpdated"
    Private Sub gvDetalleLineasAlbaran_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvDetalleLineasAlbaran.RowUpdated
        SumaCantidades()
    End Sub
#End Region

End Class