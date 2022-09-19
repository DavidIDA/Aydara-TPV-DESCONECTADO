Public Class fSeleccion

    Dim regkey_Seleccion As String

    Dim _ValorDevuelto As String
    Dim CampoDevuelto As String
    Dim DataTable As DataTable
    Dim Filtro As String

    Property ValorDevuelto As String
        Get
            Return Me._ValorDevuelto
        End Get
        Set(value As String)
            Me._ValorDevuelto = value
        End Set
    End Property

#Region "Eventos formulario"
    Public Sub New(DataTable As DataTable, CampoDevuelto As String, Optional Filtro As String = "")

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DataTable = DataTable
        Me.CampoDevuelto = CampoDevuelto
        Me.Filtro = Filtro

    End Sub

    Private Sub Seleccion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Me.WindowState = FormWindowState.Minimized Then Me.WindowState = FormWindowState.Normal
            My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Seleccion, True).SetValue("WindowState", CInt(Me.WindowState))
            If Me.WindowState = FormWindowState.Normal Then
                My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Seleccion, True).SetValue("Left", Me.Left)
                My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Seleccion, True).SetValue("Top", Me.Top)
                My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Seleccion, True).SetValue("Width", Me.Width)
                My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Seleccion, True).SetValue("Height", Me.Height)
            End If

            Me.gvSeleccion.SaveLayoutToRegistry(Me.regkey_Seleccion)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub Seleccion_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Configuración grillas
            Me.regkey_Seleccion = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\" & Me.DataTable.TableName
            My.Computer.Registry.CurrentUser.CreateSubKey(Me.regkey_Seleccion)

            Me.dgSeleccion.DataSource = Me.DataTable

            Me.gvSeleccion.RestoreLayoutFromRegistry(Me.regkey_Seleccion)
            Me.gvSeleccion.ActiveFilterString = Filtro
            Me.gvSeleccion.FindFilterText = String.Empty

            'Ocultar columna Id
            For i As Integer = 0 To Me.gvSeleccion.Columns.Count - 1
                With Me.gvSeleccion.Columns(i)
                    If .GetCaption = "Id" Then
                        .Visible = False
                        .OptionsColumn.ShowInCustomizationForm = False
                    End If
                End With
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub Seleccion_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            'Posición y tamaño
            If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Seleccion).GetValue("WindowState", Nothing) Is Nothing Then Me.WindowState = CInt(My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Seleccion).GetValue("WindowState", Me.WindowState))
            If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Seleccion).GetValue("Left", Nothing) Is Nothing Then Me.Left = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Seleccion).GetValue("Left", Me.Left)
            If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Seleccion).GetValue("Top", Nothing) Is Nothing Then Me.Top = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Seleccion).GetValue("Top", Me.Top)
            If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Seleccion).GetValue("Width", Nothing) Is Nothing Then Me.Width = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Seleccion).GetValue("Width", Me.Width)
            If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Seleccion).GetValue("Height", Nothing) Is Nothing Then Me.Height = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Seleccion).GetValue("Height", Me.Height)

            If Me.gvSeleccion.IsFindPanelVisible Then
                Me.gvSeleccion.ShowFindPanel()
            Else
                Me.gvSeleccion.FocusedRowHandle = -999997
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

#End Region

#Region "Eventos grilla"
    Private Sub dgSeleccion_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgSeleccion.MouseDoubleClick
        If Not IsNothing(Me.gvSeleccion.GetFocusedRow) Then
            Me.ValorDevuelto = Me.gvSeleccion.GetFocusedRowCellValue(Me.CampoDevuelto).ToString
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub gvSeleccion_KeyUp(sender As Object, e As KeyEventArgs) Handles gvSeleccion.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.dgSeleccion_MouseDoubleClick(Me.dgSeleccion, Nothing)
        End If
    End Sub

#End Region

End Class