Public Class Form1
    Dim a3 As a3ERP_AydaraTPV.a3ERP
    Private Sub bttAceptar_Click(sender As Object, e As EventArgs) Handles bttAceptar.Click
        Try
            a3.Opcion(Me.txtIdOpcion.EditValue, Me.txtValorParametro.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGrabaArticulo_Click(sender As Object, e As EventArgs) Handles btnGrabaArticulo.Click

        Dim a3doc As New a3ERPActiveX.Albaran
        Try
            a3doc.Iniciar()
            a3doc.Nuevo(Date.Today, "  000005", False)
            a3doc.NuevaLinea()
            a3doc.AsStringLin("CODART") = Me.txtValorParametro.Text
            'a3doc.AsIntegerLin("PAQUETES") = 1
            a3doc.AsFloatLin("UNIDADESSTOCK") = CDbl(Me.txtPRCMONEDA.Text)
            a3doc.AnadirLinea()
            Dim id As Decimal = a3doc.Anade
            MsgBox("creado albaran de VENTAS con id: " & id)

        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & vbCrLf & ex.StackTrace)
        Finally
            a3doc.Acabar()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

            Me.btnGrabaArticulo.Text = "CREAR albaran"
            a3 = New a3ERP_AydaraTPV.a3ERP
            a3.Iniciar("", "", "ARAESTETIC", "sa", "Isl#Web2009")
            'a3.Iniciar("", "", "NAVAL", "naval", "")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub
End Class
