Public Class ArqueoCaja

    Public CodigoCaja As Integer
    Public TotalEfectivo As Decimal
    Public CierreCaja As Boolean = True

#Region "ArqueoCaja_Load"
    Private Sub ArqueoCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If CierreCaja Then
            Me.ActivaArqueo(True)
        Else
            Me.lblEfectivoCaja.Visible = False
            Me.txtEfectivoCaja.Visible = False
            Me.bttConforme.Visible = False
            Me.bttCancelar.Visible = True
            Me.bttAceptar.Visible = True
        End If
    End Sub
#End Region

#Region "ArqueoCaja_Shown"
    Private Sub ArqueoCaja_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales importe
        Me.txtImpBilletes500.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtImpBilletes200.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtImpBilletes100.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtImpBilletes50.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtImpBilletes20.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtImpBilletes10.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtImpBilletes5.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtImpMonedas2.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtImpMonedas1.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtImpMonedas050.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtImpMonedas020.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtImpMonedas010.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtImpMonedas005.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtImpMonedas002.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtImpMonedas001.Properties.Mask.EditMask = "c" & DecimalesImporte
        'Foco al principio
        Me.txtNumBilletes500.Focus()
    End Sub
#End Region

#Region "txtValores_Validated"
    Private Sub txtValores_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumMonedas001.Validated, txtNumMonedas002.Validated, txtNumMonedas005.Validated, txtNumMonedas010.Validated, txtNumMonedas020.Validated, txtNumMonedas050.Validated, txtNumMonedas1.Validated, txtNumMonedas2.Validated, txtNumBilletes5.Validated, txtNumBilletes10.Validated, txtNumBilletes20.Validated, txtNumBilletes50.Validated, txtNumBilletes100.Validated, txtNumBilletes200.Validated, txtNumBilletes500.Validated, txtImpMonedas001.Validated, txtImpMonedas002.Validated, txtImpMonedas005.Validated, txtImpMonedas010.Validated, txtImpMonedas020.Validated, txtImpMonedas050.Validated, txtImpMonedas1.Validated, txtImpMonedas2.Validated, txtImpBilletes5.Validated, txtImpBilletes10.Validated, txtImpBilletes20.Validated, txtImpBilletes50.Validated, txtImpBilletes100.Validated, txtImpBilletes200.Validated, txtImpBilletes500.Validated

        Select Case sender.Name

            'Nº billetes/monedas
            Case Me.txtNumBilletes500.Name
                Me.txtImpBilletes500.EditValue = Math.Round(Me.txtNumBilletes500.EditValue * 500, DecimalesImporte, MidpointRounding.AwayFromZero)
                If sender.IsModified Then Me.txtNumBilletes200.Focus()
            Case Me.txtNumBilletes200.Name
                Me.txtImpBilletes200.EditValue = Math.Round(Me.txtNumBilletes200.EditValue * 200, DecimalesImporte, MidpointRounding.AwayFromZero)
                If sender.IsModified Then Me.txtNumBilletes100.Focus()
            Case Me.txtNumBilletes100.Name
                Me.txtImpBilletes100.EditValue = Math.Round(Me.txtNumBilletes100.EditValue * 100, DecimalesImporte, MidpointRounding.AwayFromZero)
                If sender.IsModified Then Me.txtNumBilletes50.Focus()
            Case Me.txtNumBilletes50.Name
                Me.txtImpBilletes50.EditValue = Math.Round(Me.txtNumBilletes50.EditValue * 50, DecimalesImporte, MidpointRounding.AwayFromZero)
                If sender.IsModified Then Me.txtNumBilletes20.Focus()
            Case Me.txtNumBilletes20.Name
                Me.txtImpBilletes20.EditValue = Math.Round(Me.txtNumBilletes20.EditValue * 20, DecimalesImporte, MidpointRounding.AwayFromZero)
                If sender.IsModified Then Me.txtNumBilletes10.Focus()
            Case Me.txtNumBilletes10.Name
                Me.txtImpBilletes10.EditValue = Math.Round(Me.txtNumBilletes10.EditValue * 10, DecimalesImporte, MidpointRounding.AwayFromZero)
                If sender.IsModified Then Me.txtNumBilletes5.Focus()
            Case Me.txtNumBilletes5.Name
                Me.txtImpBilletes5.EditValue = Math.Round(Me.txtNumBilletes5.EditValue * 5, DecimalesImporte, MidpointRounding.AwayFromZero)
                If sender.IsModified Then Me.txtNumMonedas2.Focus()
            Case Me.txtNumMonedas2.Name
                Me.txtImpMonedas2.EditValue = Math.Round(Me.txtNumMonedas2.EditValue * 2, DecimalesImporte, MidpointRounding.AwayFromZero)
                If sender.IsModified Then Me.txtNumMonedas1.Focus()
            Case Me.txtNumMonedas1.Name
                Me.txtImpMonedas1.EditValue = Math.Round(Me.txtNumMonedas1.EditValue * 1, DecimalesImporte, MidpointRounding.AwayFromZero)
                If sender.IsModified Then Me.txtNumMonedas050.Focus()
            Case Me.txtNumMonedas050.Name
                Me.txtImpMonedas050.EditValue = Math.Round(Me.txtNumMonedas050.EditValue * 0.5, DecimalesImporte, MidpointRounding.AwayFromZero)
                If sender.IsModified Then Me.txtNumMonedas020.Focus()
            Case Me.txtNumMonedas020.Name
                Me.txtImpMonedas020.EditValue = Math.Round(Me.txtNumMonedas020.EditValue * 0.2, DecimalesImporte, MidpointRounding.AwayFromZero)
                If sender.IsModified Then Me.txtNumMonedas010.Focus()
            Case Me.txtNumMonedas010.Name
                Me.txtImpMonedas010.EditValue = Math.Round(Me.txtNumMonedas010.EditValue * 0.1, DecimalesImporte, MidpointRounding.AwayFromZero)
                If sender.IsModified Then Me.txtNumMonedas005.Focus()
            Case Me.txtNumMonedas005.Name
                Me.txtImpMonedas005.EditValue = Math.Round(Me.txtNumMonedas005.EditValue * 0.05, DecimalesImporte, MidpointRounding.AwayFromZero)
                If sender.IsModified Then Me.txtNumMonedas002.Focus()
            Case Me.txtNumMonedas002.Name
                Me.txtImpMonedas002.EditValue = Math.Round(Me.txtNumMonedas002.EditValue * 0.02, DecimalesImporte, MidpointRounding.AwayFromZero)
                If sender.IsModified Then Me.txtNumMonedas001.Focus()
            Case Me.txtNumMonedas001.Name
                Me.txtImpMonedas001.EditValue = Math.Round(Me.txtNumMonedas001.EditValue * 0.01, DecimalesImporte, MidpointRounding.AwayFromZero)
                If sender.IsModified Then Me.bttAceptar.Focus()

                'Importes
            Case Me.txtImpBilletes500.Name
                Me.txtNumBilletes500.EditValue = CInt(Me.txtImpBilletes500.EditValue / 500)
                Me.txtValores_Validated(Me.txtNumBilletes500, Nothing)
            Case Me.txtImpBilletes200.Name
                Me.txtNumBilletes200.EditValue = CInt(Me.txtImpBilletes200.EditValue / 200)
                Me.txtValores_Validated(Me.txtNumBilletes200, Nothing)
            Case Me.txtImpBilletes100.Name
                Me.txtNumBilletes100.EditValue = CInt(Me.txtImpBilletes100.EditValue / 100)
                Me.txtValores_Validated(Me.txtNumBilletes100, Nothing)
            Case Me.txtImpBilletes50.Name
                Me.txtNumBilletes50.EditValue = CInt(Me.txtImpBilletes50.EditValue / 50)
                Me.txtValores_Validated(Me.txtNumBilletes50, Nothing)
            Case Me.txtImpBilletes20.Name
                Me.txtNumBilletes20.EditValue = CInt(Me.txtImpBilletes20.EditValue / 20)
                Me.txtValores_Validated(Me.txtNumBilletes20, Nothing)
            Case Me.txtImpBilletes10.Name
                Me.txtNumBilletes10.EditValue = CInt(Me.txtImpBilletes10.EditValue / 10)
                Me.txtValores_Validated(Me.txtNumBilletes10, Nothing)
            Case Me.txtImpBilletes5.Name
                Me.txtNumBilletes5.EditValue = CInt(Me.txtImpBilletes5.EditValue / 5)
                Me.txtValores_Validated(Me.txtNumBilletes5, Nothing)
            Case Me.txtImpMonedas2.Name
                Me.txtNumMonedas2.EditValue = CInt(Me.txtImpMonedas2.EditValue / 2)
                Me.txtValores_Validated(Me.txtNumMonedas2, Nothing)
            Case Me.txtImpMonedas1.Name
                Me.txtNumMonedas1.EditValue = CInt(Me.txtImpMonedas1.EditValue / 1)
                Me.txtValores_Validated(Me.txtNumMonedas1, Nothing)
            Case Me.txtImpMonedas050.Name
                Me.txtNumMonedas050.EditValue = CInt(Me.txtImpMonedas050.EditValue / 0.5)
                Me.txtValores_Validated(Me.txtNumMonedas050, Nothing)
            Case Me.txtImpMonedas020.Name
                Me.txtNumMonedas020.EditValue = CInt(Me.txtImpMonedas020.EditValue / 0.2)
                Me.txtValores_Validated(Me.txtNumMonedas020, Nothing)
            Case Me.txtImpMonedas010.Name
                Me.txtNumMonedas010.EditValue = CInt(Me.txtImpMonedas010.EditValue / 0.1)
                Me.txtValores_Validated(Me.txtNumMonedas010, Nothing)
            Case Me.txtImpMonedas005.Name
                Me.txtNumMonedas005.EditValue = CInt(Me.txtImpMonedas005.EditValue / 0.05)
                Me.txtValores_Validated(Me.txtNumMonedas005, Nothing)
            Case Me.txtImpMonedas002.Name
                Me.txtNumMonedas002.EditValue = CInt(Me.txtImpMonedas002.EditValue / 0.02)
                Me.txtValores_Validated(Me.txtNumMonedas002, Nothing)
            Case Me.txtImpMonedas001.Name
                Me.txtNumMonedas001.EditValue = CInt(Me.txtImpMonedas001.EditValue / 0.01)
                Me.txtValores_Validated(Me.txtNumMonedas001, Nothing)

        End Select

        CalculaTotal()

    End Sub
#End Region

#Region "CalculaTotal"
    Private Sub CalculaTotal()
        Me.txtTotalEfectivo.EditValue = Me.txtImpMonedas001.EditValue + Me.txtImpMonedas002.EditValue + Me.txtImpMonedas005.EditValue + Me.txtImpMonedas010.EditValue + Me.txtImpMonedas020.EditValue + Me.txtImpMonedas050.EditValue + Me.txtImpMonedas1.EditValue + Me.txtImpMonedas2.EditValue + Me.txtImpBilletes5.EditValue + Me.txtImpBilletes10.EditValue + Me.txtImpBilletes20.EditValue + Me.txtImpBilletes50.EditValue + Me.txtImpBilletes100.EditValue + Me.txtImpBilletes200.EditValue + Me.txtImpBilletes500.EditValue
    End Sub
#End Region

#Region "bttAceptar_Click"
    Private Sub bttAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttAceptar.Click
        Me.TotalEfectivo = Me.txtTotalEfectivo.EditValue
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

#Region "bttConforme_Click"
    Private Sub bttConforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttConforme.Click

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            Me.Cursor = Cursors.WaitCursor

            'Total efectivo
            Dim TotalEfectivo As Decimal
            cmd.CommandText = "SELECT ISNULL(Sum(ImporteEfectivo-ImporteCambios),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & CodigoCaja
            TotalEfectivo = cmd.ExecuteScalar

            cmd.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & CodigoCaja & _
                                     " AND FechaCierre IS NULL AND (TipoMovimiento='EC' OR TipoMovimiento='CC' OR (TipoMovimiento='EV' AND TipoCobro=1))"
            TotalEfectivo += cmd.ExecuteScalar

            cmd.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & CodigoCaja & _
                                     " AND FechaCierre IS NULL AND (TipoMovimiento='RF' OR TipoMovimiento='PC')"
            TotalEfectivo -= cmd.ExecuteScalar

            Me.txtEfectivoCaja.EditValue = TotalEfectivo

        Catch ex As Exception
            Me.txtEfectivoCaja.EditValue = 0
            MsgBox("Error al calcular efectivo caja", MsgBoxStyle.Exclamation, "Efectivo caja")
        Finally
            Me.Cursor = Cursors.Default
        End Try

        ActivaArqueo(False)

    End Sub
#End Region

#Region "ActivaArqueo"
    Private Sub ActivaArqueo(ByVal activa As Boolean)

        If activa Then
            Me.txtNumBilletes500.EditValue = 0
            Me.txtNumBilletes200.EditValue = 0
            Me.txtNumBilletes100.EditValue = 0
            Me.txtNumBilletes50.EditValue = 0
            Me.txtNumBilletes20.EditValue = 0
            Me.txtNumBilletes10.EditValue = 0
            Me.txtNumBilletes5.EditValue = 0
            Me.txtNumMonedas2.EditValue = 0
            Me.txtNumMonedas1.EditValue = 0
            Me.txtNumMonedas050.EditValue = 0
            Me.txtNumMonedas020.EditValue = 0
            Me.txtNumMonedas010.EditValue = 0
            Me.txtNumMonedas005.EditValue = 0
            Me.txtNumMonedas002.EditValue = 0
            Me.txtNumMonedas001.EditValue = 0
            Me.txtImpBilletes500.EditValue = 0
            Me.txtImpBilletes200.EditValue = 0
            Me.txtImpBilletes100.EditValue = 0
            Me.txtImpBilletes50.EditValue = 0
            Me.txtImpBilletes20.EditValue = 0
            Me.txtImpBilletes10.EditValue = 0
            Me.txtImpBilletes5.EditValue = 0
            Me.txtImpMonedas2.EditValue = 0
            Me.txtImpMonedas1.EditValue = 0
            Me.txtImpMonedas050.EditValue = 0
            Me.txtImpMonedas020.EditValue = 0
            Me.txtImpMonedas010.EditValue = 0
            Me.txtImpMonedas005.EditValue = 0
            Me.txtImpMonedas002.EditValue = 0
            Me.txtImpMonedas001.EditValue = 0
            Me.txtTotalEfectivo.EditValue = 0
            Me.txtEfectivoCaja.EditValue = 0
        End If

        'Me.txtNumBilletes500.Properties.ReadOnly = Not activa
        'Me.txtNumBilletes200.Properties.ReadOnly = Not activa
        'Me.txtNumBilletes100.Properties.ReadOnly = Not activa
        'Me.txtNumBilletes50.Properties.ReadOnly = Not activa
        'Me.txtNumBilletes20.Properties.ReadOnly = Not activa
        'Me.txtNumBilletes10.Properties.ReadOnly = Not activa
        'Me.txtNumBilletes5.Properties.ReadOnly = Not activa
        'Me.txtNumMonedas2.Properties.ReadOnly = Not activa
        'Me.txtNumMonedas1.Properties.ReadOnly = Not activa
        'Me.txtNumMonedas050.Properties.ReadOnly = Not activa
        'Me.txtNumMonedas020.Properties.ReadOnly = Not activa
        'Me.txtNumMonedas010.Properties.ReadOnly = Not activa
        'Me.txtNumMonedas005.Properties.ReadOnly = Not activa
        'Me.txtNumMonedas002.Properties.ReadOnly = Not activa
        'Me.txtNumMonedas001.Properties.ReadOnly = Not activa
        'Me.txtImpBilletes500.Properties.ReadOnly = Not activa
        'Me.txtImpBilletes200.Properties.ReadOnly = Not activa
        'Me.txtImpBilletes100.Properties.ReadOnly = Not activa
        'Me.txtImpBilletes50.Properties.ReadOnly = Not activa
        'Me.txtImpBilletes20.Properties.ReadOnly = Not activa
        'Me.txtImpBilletes10.Properties.ReadOnly = Not activa
        'Me.txtImpBilletes5.Properties.ReadOnly = Not activa
        'Me.txtImpMonedas2.Properties.ReadOnly = Not activa
        'Me.txtImpMonedas1.Properties.ReadOnly = Not activa
        'Me.txtImpMonedas050.Properties.ReadOnly = Not activa
        'Me.txtImpMonedas020.Properties.ReadOnly = Not activa
        'Me.txtImpMonedas010.Properties.ReadOnly = Not activa
        'Me.txtImpMonedas005.Properties.ReadOnly = Not activa
        'Me.txtImpMonedas002.Properties.ReadOnly = Not activa
        'Me.txtImpMonedas001.Properties.ReadOnly = Not activa

        Me.lblEfectivoCaja.Visible = Not activa
        Me.txtEfectivoCaja.Visible = Not activa
        Me.bttSituacionTienda.Visible = Not activa
        Me.bttCancelar.Visible = Not activa
        Me.bttAceptar.Visible = Not activa
        Me.bttConforme.Visible = activa

        If activa Then
            Me.txtNumBilletes500.Focus()
        Else
            Me.bttAceptar.Focus()
        End If

    End Sub
#End Region

#Region "bttSituacionTienda_Click"
    Private Sub bttSituacionTienda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttSituacionTienda.Click
        SituacionTienda.ShowDialog()
    End Sub
#End Region

End Class