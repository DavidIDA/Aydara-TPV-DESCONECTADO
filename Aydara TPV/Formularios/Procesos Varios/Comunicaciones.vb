Public Class Comunicaciones

#Region "Comunicaciones_FormClosed"
    Private Sub Comunicaciones_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            Me.TIENDASBindingSource.EndEdit()
            If Me.DsTiendas.HasChanges Then
                If MsgBox("¿Desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) Then
                    Me.TIENDASTableAdapter.Update(Me.DsTiendas.TIENDAS)
                    General.DatosTiendaActual(General.CodigoTienda)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al guardar los cambios." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "Comunicaciones_Load"
    Private Sub Comunicaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.TIENDASTableAdapter.Fill(Me.DsTiendas.TIENDAS)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "rgTipoComunicacion_SelectedIndexChanged"
    Private Sub rgTipoComunicacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgTipoComunicacion.SelectedIndexChanged
        Me.panelConfiguracion.Visible = (Me.rgTipoComunicacion.EditValue > 1)
    End Sub
#End Region

#Region "rgTipoTienda_SelectedIndexChanged"
    Private Sub rgTipoTienda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgTipoTienda.SelectedIndexChanged
        Me.panelOtrosDatos.Visible = (Me.rgTipoTienda.EditValue = 2)
    End Sub
#End Region

#Region "txtArticulos_Validated"
    Private Sub txtArticulos_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtArticuloPropioInicio.Validated, txtArticuloPropioFin.Validated
        'If IsNumeric(sender.EditValue) Then sender.EditValue = Format(CType(sender.EditValue, Integer), "0000000")
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.Close()
    End Sub
#End Region

End Class