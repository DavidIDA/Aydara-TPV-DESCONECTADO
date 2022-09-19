Public Class BusquedaPromociones

#Region "BusquedaPromociones_KeyUp"
    Private Sub BusquedaPromociones_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "BusquedaPromociones_Load"
    Private Sub BusquedaPromociones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FECHAS_PROMOCIONESTableAdapter.Fill(Me.DsPromociones.FECHAS_PROMOCIONES)
        Me.gvPromociones.FormatConditions(0).Value1 = Date.Now
    End Sub
#End Region

#Region "BusquedaPromociones_Shown"
    Private Sub BusquedaPromociones_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en precios
        Me.maskPrecio.Mask.EditMask = "c" & DecimalesPrecio
        'Mostrar color y talla
        Me.colDescripcionColor.Visible = GestionColores
        Me.colDescripcionTalla.Visible = GestionTallas
    End Sub
#End Region

#Region "MostrarPrecios"
    Private Sub MostrarPrecios()
        Try
            Dim i As Integer
            Dim rPromociones As dsPromociones.PROMOCIONESRow
            For i = 0 To Me.DsPromociones.PROMOCIONES.Rows.Count - 1
                rPromociones = Me.DsPromociones.PROMOCIONES.Rows(i)
                rPromociones.PrecioTarifa = DamePrecioArticulo(rPromociones.CodigoArticulo, IIf(Not rPromociones.Item("CodigoColor") Is System.DBNull.Value, rPromociones.Item("CodigoColor"), -1), IIf(Not rPromociones.Item("CodigoTalla") Is System.DBNull.Value, rPromociones.Item("CodigoTalla"), -1))
                If Not rPromociones.Item("CodigoColor") Is System.DBNull.Value Then rPromociones.DescripcionColor = DameColor(rPromociones.Item("CodigoColor"))
                If Not rPromociones.Item("CodigoTalla") Is System.DBNull.Value Then rPromociones.DescripcionTalla = DameTallaArticulo(rPromociones.CodigoArticulo, rPromociones.Item("CodigoTalla"))
            Next
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "gvPromociones_DoubleClick"
    Private Sub gvPromociones_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvPromociones.DoubleClick
        Try
            If Not Me.gvPromociones.GetFocusedRow Is Nothing Then
                Promociones.txtFechaInicio.EditValue = Me.gvPromociones.GetFocusedRowCellValue(Me.colFechaInicio)
                Promociones.txtFechaFinal.EditValue = Me.gvPromociones.GetFocusedRowCellValue(Me.colFechaFinal)
                Promociones.DsPromociones.Clear()
                Promociones.DsPromociones.Merge(Me.DsPromociones)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "gvPromociones_FocusedRowChanged"
    Private Sub gvPromociones_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvPromociones.FocusedRowChanged
        If Not Me.gvPromociones.GetFocusedRow Is Nothing Then
            Me.Cursor = Cursors.WaitCursor
            Me.txtFechaInicio.EditValue = Me.gvPromociones.GetFocusedRowCellValue(Me.colFechaInicio)
            Me.txtFechaFinal.EditValue = Me.gvPromociones.GetFocusedRowCellValue(Me.colFechaFinal)
            Me.PROMOCIONESTableAdapter.DetallePromocion(Me.DsPromociones.PROMOCIONES, Me.gvPromociones.GetFocusedRowCellValue(Me.colFechaInicio), Me.gvPromociones.GetFocusedRowCellValue(Me.colFechaFinal))
            Me.MostrarPrecios()
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region

#Region "bttEliminarPromocion_Click"
    Private Sub bttEliminarPromocion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttEliminarPromocion.Click
        Try
            If MsgBox("¿Seguro que desea eliminar la promoción seleccionada?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar promoción") = MsgBoxResult.Yes Then
                Dim i As Integer
                For i = 0 To Me.DsPromociones.PROMOCIONES.Rows.Count - 1
                    Me.DsPromociones.PROMOCIONES.Rows(i).Delete()
                Next
                Me.PROMOCIONESTableAdapter.Update(Me.DsPromociones.PROMOCIONES)
                Me.FECHAS_PROMOCIONESTableAdapter.Fill(Me.DsPromociones.FECHAS_PROMOCIONES)
                MsgBox("La promoción ha sido eliminada correctamente", MsgBoxStyle.Information, "Promoción eliminada")
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttActalizarFechas_Click"
    Private Sub bttActalizarFechas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttActalizarFechas.Click
        Try
            If MsgBox("¿Seguro que desea actualizar las fechas de la promoción seleccionada?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Actualizar promoción") = MsgBoxResult.Yes Then
                Dim i As Integer
                Dim rPromociones As dsPromociones.PROMOCIONESRow
                For i = 0 To Me.DsPromociones.PROMOCIONES.Rows.Count - 1
                    rPromociones = Me.DsPromociones.PROMOCIONES.Rows(i)
                    rPromociones.FechaInicio = Me.txtFechaInicio.EditValue
                    rPromociones.FechaFinal = Me.txtFechaFinal.EditValue
                Next
                Me.PROMOCIONESTableAdapter.Update(Me.DsPromociones.PROMOCIONES)
                Me.FECHAS_PROMOCIONESTableAdapter.Fill(Me.DsPromociones.FECHAS_PROMOCIONES)
                MsgBox("La promoción ha sido actualizada correctamente", MsgBoxStyle.Information, "Promoción actualizada")
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "gvDetallePromocion_CustomDrawCell"
    Private Sub gvDetallePromocion_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvDetallePromocion.CustomDrawCell
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

End Class