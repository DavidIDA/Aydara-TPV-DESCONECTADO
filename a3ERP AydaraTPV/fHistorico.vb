Public Class fHistorico 

    Dim _CODART As String
    Dim ConexionSQL As ADODB.Connection

    Dim regKey_Formulario As String, regKey_Historico As String, regKey_Detalle As String

    Property CODART
        Get
            Return Me._CODART
        End Get
        Set(value)
            Me._CODART = value
        End Set
    End Property

#Region "Eventos formulario"
    Public Sub New(Historico As dsHistorico, ConexionSQL As ADODB.Connection)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.VENTASBindingSource.DataSource = Historico
        Me.ConexionSQL = ConexionSQL

    End Sub

    Private Sub fHistorico_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Me.MdiParent Is Nothing Then
                If Me.WindowState = Windows.Forms.FormWindowState.Minimized Then Me.WindowState = Windows.Forms.FormWindowState.Normal
                My.Computer.Registry.CurrentUser.SetValue(regKey_Formulario, "WindowState", CInt(Me.WindowState))
                If Me.WindowState = Windows.Forms.FormWindowState.Normal Then
                    My.Computer.Registry.CurrentUser.OpenSubKey(regKey_Formulario, True).SetValue("Left", Me.Left)
                    My.Computer.Registry.CurrentUser.OpenSubKey(regKey_Formulario, True).SetValue("Top", Me.Top)
                    My.Computer.Registry.CurrentUser.OpenSubKey(regKey_Formulario, True).SetValue("Width", Me.Width)
                    My.Computer.Registry.CurrentUser.OpenSubKey(regKey_Formulario, True).SetValue("Height", Me.Height)
                End If
            End If
            Me.gvHistorico.SaveLayoutToRegistry(regKey_Historico)
            Me.gvDetalle.SaveLayoutToRegistry(regKey_Detalle)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub fHistorico_KeyUp(sender As Object, e As Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Windows.Forms.Keys.Escape
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Select
    End Sub

    Private Sub fHistorico_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If Me.MdiParent Is Nothing Then Me.Visible = False
            Me.regKey_Formulario = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name
            My.Computer.Registry.CurrentUser.CreateSubKey(Me.regKey_Formulario)

            'Configuración grillas
            regKey_Historico = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\Historico"
            Me.gvHistorico.RestoreLayoutFromRegistry(regKey_Historico)
            Me.gvHistorico.ClearColumnsFilter()
            Me.gvHistorico.FindFilterText = String.Empty

            regKey_Detalle = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\Detalle"
            Me.gvDetalle.RestoreLayoutFromRegistry(regKey_Detalle)
            Me.gvDetalle.ClearColumnsFilter()

            Dim RecordAffected As New Object
            Dim rs As New ADODB.Recordset

            rs = ConexionSQL.Execute("SELECT * FROM DATOSCONFIG", RecordAffected)

            If Not rs.EOF Then

                Me.colBULTOS.Caption = rs.Fields("SIGNIFICADOBULTOS").Value
                Me.colPAQUETES.Caption = rs.Fields("SIGNIFICADOPAQUETES").Value

                Me.colBULTOS_Detalle.Caption = rs.Fields("SIGNIFICADOBULTOS").Value
                Me.colPAQUETES_Detalle.Caption = rs.Fields("SIGNIFICADOPAQUETES").Value

                Me.colBULTOS.DisplayFormat.FormatString = "{0:n" & rs.Fields("NUMDECUNI").Value & "}"
                Me.colPAQUETES.DisplayFormat.FormatString = "{0:n" & rs.Fields("NUMDECUNI").Value & "}"
                Me.colUNIDADES.DisplayFormat.FormatString = "{0:n" & rs.Fields("NUMDECUNI").Value & "}"
                Me.colPRCMONEDA.DisplayFormat.FormatString = "{0:c" & rs.Fields("NUMDECPRC").Value & "}"
                Me.colDESC1.DisplayFormat.FormatString = "{0:n" & rs.Fields("NUMDECDESC").Value & "}"
                Me.colDESC2.DisplayFormat.FormatString = "{0:n" & rs.Fields("NUMDECDESC").Value & "}"
                Me.colDESC3.DisplayFormat.FormatString = "{0:n" & rs.Fields("NUMDECDESC").Value & "}"
                Me.colDESC4.DisplayFormat.FormatString = "{0:n" & rs.Fields("NUMDECDESC").Value & "}"

                Me.colBULTOS_Detalle.DisplayFormat.FormatString = "{0:n" & rs.Fields("NUMDECUNI").Value & "}"
                Me.colPAQUETES_Detalle.DisplayFormat.FormatString = "{0:n" & rs.Fields("NUMDECUNI").Value & "}"
                Me.colUNIDADES_Detalle.DisplayFormat.FormatString = "{0:n" & rs.Fields("NUMDECUNI").Value & "}"
                Me.colPRCMONEDA_Detalle.DisplayFormat.FormatString = "{0:c" & rs.Fields("NUMDECPRC").Value & "}"
                Me.colDESC1_Detalle.DisplayFormat.FormatString = "{0:n" & rs.Fields("NUMDECDESC").Value & "}"
                Me.colDESC2.DisplayFormat.FormatString = "{0:n" & rs.Fields("NUMDECDESC").Value & "}"
                Me.colDESC3_Detalle.DisplayFormat.FormatString = "{0:n" & rs.Fields("NUMDECDESC").Value & "}"
                Me.colDESC4_Detalle.DisplayFormat.FormatString = "{0:n" & rs.Fields("NUMDECDESC").Value & "}"

            End If

            rs.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub fHistorico_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            If Me.MdiParent Is Nothing Then
                'Posición y tamaño
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regKey_Formulario).GetValue("WindowState", Nothing) Is Nothing Then Me.WindowState = CInt(My.Computer.Registry.CurrentUser.OpenSubKey(regKey_Formulario).GetValue("WindowState", Me.WindowState))
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regKey_Formulario).GetValue("Left", Nothing) Is Nothing Then Me.Left = My.Computer.Registry.CurrentUser.OpenSubKey(regKey_Formulario).GetValue("Left", Me.Left)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regKey_Formulario).GetValue("Top", Nothing) Is Nothing Then Me.Top = My.Computer.Registry.CurrentUser.OpenSubKey(regKey_Formulario).GetValue("Top", Me.Top)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regKey_Formulario).GetValue("Width", Nothing) Is Nothing Then Me.Width = My.Computer.Registry.CurrentUser.OpenSubKey(regKey_Formulario).GetValue("Width", Me.Width)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regKey_Formulario).GetValue("Height", Nothing) Is Nothing Then Me.Height = My.Computer.Registry.CurrentUser.OpenSubKey(regKey_Formulario).GetValue("Height", Me.Height)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            Me.Visible = True
        End Try

        Try
            If Me.gvHistorico.IsFindPanelVisible Then
                Dim find As DevExpress.XtraGrid.Controls.FindControl = TryCast(Me.gvHistorico.GridControl.Controls.Find("FindControl", True)(0), DevExpress.XtraGrid.Controls.FindControl)
                find.FindEdit.Focus()
            Else
                Me.gvHistorico.FocusedRowHandle = -999997 'Foco en la línea de búsqueda
                Me.gvHistorico.FocusedColumn = Me.colDESCLIN
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

#End Region

#Region "Eventos grilla"
    Private Sub dgHistorico_MouseDoubleClick(sender As Object, e As Windows.Forms.MouseEventArgs) Handles dgHistorico.MouseDoubleClick
        Try
            If Not Me.gvHistorico.GetFocusedDataRow Is Nothing Then
                Me.CODART = CType(Me.gvHistorico.GetFocusedDataRow, dsHistorico.VENTASRow).CODART
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

#End Region

End Class