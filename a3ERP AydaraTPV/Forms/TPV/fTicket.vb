Public Class fTicket 

    Dim IDTICKET As Integer

    Dim regkey_Formulario As String, regkey_Lineas As String

#Region "Eventos formulario"
    Public Sub New(Optional IDTICKET As Integer = 0)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.BarManager.RegistryPath = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name

        Me.IDTICKET = IDTICKET

        If Me.IDTicket = 0 Then
            Me.Text = "Nuevo ticket de venta"
        Else
            Me.Text = "Ticket de venta nº " & Aydara.SentenciaSQL("SELECT NUMDOC FROM IDA_TICKETS WHERE IDTICKET = " & Me.IDTICKET)
        End If

    End Sub

    Private Sub Ticket_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Try
            Select Case e.KeyCode
                Case Keys.F3
                    If Me.bttGuardar.Enabled Then
                        Me.bttGuardar_ItemClick(Me.bttGuardar, Nothing)
                    ElseIf Me.bttNuevo.Enabled Then
                        Me.bttNuevo_ItemClick(Me.bttNuevo, Nothing)
                    End If

                Case Keys.F5
                    If Me.bttImprimir.Enabled Then

                        Me.Cursor = Cursors.WaitCursor

                        Me.DsTickets.Cancelar()
                        Me.dgLineas.Focus()
                        Me.gvLineas.MoveLastVisible()

                    End If

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub fTicket_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.IDATICKETSBindingSource.EndEdit()
            Me.IDATICKETSLINEASBindingSource.EndEdit()

            If Me.DsTickets.HasChanges Then
                If MsgBox("Está editando un ticket." & vbCrLf & "¿Seguro que desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then e.Cancel = True
            End If

            If Me.MdiParent Is Nothing Then
                If Me.WindowState = FormWindowState.Minimized Then Me.WindowState = FormWindowState.Normal
                My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario, True).SetValue("WindowState", CInt(Me.WindowState))
                If Me.WindowState = FormWindowState.Normal Then
                    My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario, True).SetValue("Left", Me.Left)
                    My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario, True).SetValue("Top", Me.Top)
                    My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario, True).SetValue("Width", Me.Width)
                    My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario, True).SetValue("Height", Me.Height)
                End If
            End If
            Me.gvLineas.SaveLayoutToRegistry(Me.regkey_Lineas)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub fTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.regkey_Formulario = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name
            My.Computer.Registry.CurrentUser.CreateSubKey(Me.regkey_Formulario)

            'Configuración empresa
            With a3ERP.DatosConfig
                Me.maskUNIDADES.Mask.EditMask = "n" & .NUMDECUNI
                Me.maskPRECIO.Mask.EditMask = "c" & .NUMDECPRC
                Me.maskDESC.Mask.EditMask = "P" & .NUMDECDESC
            End With

            'Configuración grillas
            Me.regkey_Lineas = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\Lineas"
            Me.gvLineas.SaveLayoutToRegistry(regkey_Lineas & "\Default")
            Me.gvLineas.RestoreLayoutFromRegistry(Me.regkey_Lineas)

            'Datos
            Me.DsAlmacenes.Cargar()

            If Me.IDTICKET = 0 Then
                Me.DsTickets.Nuevo()
            Else
                Me.DsTickets.Cargar(Me.IDTICKET)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        Finally
            Me.TopMost = False
        End Try
    End Sub

    Private Sub fTicket_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        If Me.MdiParent Is Nothing Then
            Try
                'Posición y tamaño
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("WindowState", Nothing) Is Nothing Then Me.WindowState = CInt(My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("WindowState", Me.WindowState))
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Left", Nothing) Is Nothing Then Me.Left = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Left", Me.Left)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Top", Nothing) Is Nothing Then Me.Top = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Top", Me.Top)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Width", Nothing) Is Nothing Then Me.Width = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Width", Me.Width)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Height", Nothing) Is Nothing Then Me.Height = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Height", Me.Height)

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
            End Try
        End If

        'Foco
        If Me.IDTICKET = 0 Then
            Me.txtCODCLI.Focus()
        Else
            Me.dgLineas.Focus()
            Me.gvLineas.MoveLastVisible()
            Me.ActivaMenu(True)
        End If

    End Sub

    Private Sub AlbaranVenta_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        Me.txtTITULO.Text = Space(6) & Me.Text
    End Sub

#End Region

#Region "Eventos Dataset"
    Private Sub DsTickets_ActualizaDatos() Handles DsTickets.ActualizaDatos
        Me.IDATICKETSBindingSource.ResetBindings(False)
        Me.ActivaMenu(False)
    End Sub
#End Region

#Region "Funciones menu"
    Private Sub bttNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttNuevo.ItemClick
        Try
            Me.DsTickets.Nuevo()
            Me.IDTICKET = 0
            Me.Text = "Nuevo ticket de venta"
            Me.txtCODCLI.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttGuardar.ItemClick
        Try
            Me.IDATICKETSBindingSource.EndEdit()
            Me.IDATICKETSLINEASBindingSource.EndEdit()

            Me.DsTickets.Guardar()

            Me.dgLineas.Focus()
            Me.gvLineas.MoveLastVisible()

            Me.ActivaMenu(True)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttCancelar.ItemClick
        Try
            Me.DsTickets.Cancelar()

            If IDTICKET = 0 Then
                Me.txtCODCLI.Focus()
            Else
                Me.dgLineas.Focus()
                Me.gvLineas.MoveLastVisible()
            End If

            Me.ActivaMenu(True)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

#End Region

#Region "ActivaMenu"
    Private Sub ActivaMenu(activa As Boolean)
        Me.bttNuevo.Enabled = activa
        Me.bttImprimir.Enabled = activa
        Me.bttGuardar.Enabled = Not activa
        Me.bttCancelar.Enabled = Not activa
    End Sub
#End Region

End Class