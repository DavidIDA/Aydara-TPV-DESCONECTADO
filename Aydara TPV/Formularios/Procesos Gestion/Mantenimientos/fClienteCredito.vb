Public Class fClienteCredito

    Dim _CODCLI As String

    Property CODCLI As String
        Get
            Return Me._CODCLI
        End Get
        Set(value As String)
            Me._CODCLI = value
        End Set
    End Property

    Public Sub New(Optional CODCLI As String = "")

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.CODCLI = CODCLI

    End Sub

    Private Sub fClienteCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Me.CODCLI <> String.Empty Then Me.CLICREDITableAdapter.FillBy(Me.DsClientes.CLICREDI, Me.CODCLI)

            If Me.DsClientes.CLICREDI.Count = 0 Then
                Me.CLICREDIBindingSource.AddNew()
                Me.txtCodigo.EditValue = Me.CLICREDITableAdapter.NuevoCodigo
                Me.txtCodigo.Properties.ReadOnly = False
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub bttGuardar_Click(sender As Object, e As EventArgs) Handles bttGuardar.Click
        Try
            Me.CLICREDIBindingSource.EndEdit()
            Me.CLICREDITableAdapter.Update(Me.DsClientes.CLICREDI)

            Me.CODCLI = Me.txtCodigo.EditValue

            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub bttCancelar_Click(sender As Object, e As EventArgs) Handles bttCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class