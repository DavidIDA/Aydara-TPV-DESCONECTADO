Public Class DameTiendas

    Public arrayTiendas As New ArrayList

    Private Sub DameTiendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 99
            Me.lstTiendas.Items.Add(Format(i, "00"), "Tienda " & Format(i, "00"), CheckState.Unchecked, True)
        Next
    End Sub

    Private Sub bttAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttAceptar.Click
        For i As Integer = 0 To Me.lstTiendas.Items.Count - 1
            If Me.lstTiendas.Items(i).CheckState = CheckState.Checked Then
                IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Imagenes" & Me.lstTiendas.Items(i).Value & ".SEQ")
                arrayTiendas.Add(Me.lstTiendas.Items(i).Value)
            End If
        Next
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class