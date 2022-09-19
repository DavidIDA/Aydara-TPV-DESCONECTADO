Public Class fLogin

    Dim aeERPEnlace As a3ERPActiveX.Enlace
    Dim _Usuario As String, _Password As String

#Region "Properties"
    Property Usuario() As String
        Get
            Return Me._Usuario
        End Get
        Set(ByVal value As String)
            Me._Usuario = value
        End Set
    End Property

    Property Password() As String
        Get
            Return Me._Password
        End Get
        Set(ByVal value As String)
            Me._Password = value
        End Set
    End Property
#End Region

#Region "New"
    Public Sub New(ByVal aeERPEnlace As a3ERPActiveX.Enlace, ByVal Usuario As String, ByVal PassWord As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.txtUsuario.EditValue = Usuario
        Me.txtPassword.EditValue = PassWord
        Me.aeERPEnlace = aeERPEnlace

        ' Skins disponibles
        Dim skins As DevExpress.Skins.SkinContainerCollection = DevExpress.Skins.SkinManager.Default.Skins
        For i As Integer = 0 To skins.Count - 1
            Me.cmbSkins.Properties.Items.Add(skins(i).SkinName)
        Next

        Me.txtUsuario.TabStop = (Usuario = String.Empty)

    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

#Region "bttAceptar_Click"
    Private Sub bttAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttAceptar.Click
        Try
            Me.Usuario = Me.txtUsuario.EditValue.ToString
            Me.Password = Me.txtPassword.EditValue.ToString
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

    Private Sub cmbSkins_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSkins.SelectedIndexChanged
        My.Settings.Skin = Me.cmbSkins.SelectedItem.ToString
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(My.Settings.Skin)
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter And Me.txtUsuario.EditValue <> String.Empty Then
            Me.bttAceptar_Click(Me.bttAceptar, Nothing)
        End If
    End Sub

End Class