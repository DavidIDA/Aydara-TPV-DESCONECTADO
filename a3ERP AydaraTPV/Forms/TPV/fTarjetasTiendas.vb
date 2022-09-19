Public Class fTarjetasTiendas

    Dim regkey_Formulario As String, regkey_Tarjetas As String

#Region "Eventos formulario"
    Private Sub fTarjetasTiendas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
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
            Me.gvTarjetas.SaveLayoutToRegistry(Me.regkey_Tarjetas)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub fTarjetasTiendas_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Try
            Select Case e.KeyCode
                Case Keys.G
                    If e.Control Then Aydara.ConfigurarGrilla(Me.gvTarjetas, Me.regkey_Tarjetas & "\Default")
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub fTarjetasTiendas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.regkey_Formulario = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name
            My.Computer.Registry.CurrentUser.CreateSubKey(Me.regkey_Formulario)

            'Configuración grillas
            Me.regkey_Tarjetas = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\Cajas"
            Me.gvTarjetas.SaveLayoutToRegistry(regkey_Tarjetas & "\Default")
            Me.gvTarjetas.RestoreLayoutFromRegistry(Me.regkey_Tarjetas)
            Me.gvTarjetas.ActiveFilterString = String.Empty
            Me.gvTarjetas.FindFilterText = String.Empty

            Me.bttImportar.Visible = (My.Settings.Usuario.ToLower = "sa")

            'Datos
            Me.DsTarjetas.Cargar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub fTarjetasTiendas_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            If Me.MdiParent Is Nothing Then
                'Posición y tamaño
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("WindowState", Nothing) Is Nothing Then Me.WindowState = CInt(My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("WindowState", Me.WindowState))
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Left", Nothing) Is Nothing Then Me.Left = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Left", Me.Left)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Top", Nothing) Is Nothing Then Me.Top = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Top", Me.Top)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Width", Nothing) Is Nothing Then Me.Width = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Width", Me.Width)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Height", Nothing) Is Nothing Then Me.Height = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Height", Me.Height)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

#End Region

#Region "Eventos Dataset"
    Private Sub DsAlbaranVenta_ActualizaDatos() Handles DsTarjetas.ActualizaDatos
        Me.ActivaMenu(False)
    End Sub
#End Region

#Region "Opciones menú"
    Private Sub bttGuardar_Click(sender As Object, e As EventArgs) Handles bttGuardar.Click
        Try
            Me.dgTarjetas.FocusedView.CloseEditor()
            Me.dgTarjetas.FocusedView.UpdateCurrentRow()

            Me.DsTarjetas.Guardar()

            Me.ActivaMenu(True)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttCancelar_Click(sender As Object, e As EventArgs) Handles bttCancelar.Click
        Try
            Me.DsTarjetas.Cancelar()

            Me.ActivaMenu(True)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttExportarExcel_Click(sender As Object, e As EventArgs) Handles bttExportarExcel.Click
        Try
            Dim Fichero As New System.Windows.Forms.SaveFileDialog
            Fichero.Filter = "Hoja Excel|*.xls;*.xlsx"
            If Fichero.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.dgTarjetas.ExportToXlsx(Fichero.FileName)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimir.Click
        Try
            If Me.gvTarjetas.SelectedRowsCount = 0 Then
                MsgBox("Seleccione las tarjetas a imprimir", MsgBoxStyle.Information, Me.Text)
                Exit Try
            End If

            Dim sr As New IO.StreamWriter("C:\TARJETAS\TARJETAS.TXT", False, System.Text.Encoding.Default)

            Try
                For i As Integer = 0 To Me.gvTarjetas.SelectedRowsCount - 1
                    With DirectCast(Me.gvTarjetas.GetDataRow(Me.gvTarjetas.GetSelectedRows()(i)), dsTarjetas.IDA_TARJETASRow)
                        sr.WriteLine(.NUMTARJETA & vbTab & .NOMCLI & vbTab)
                    End With
                Next

            Catch ex As Exception
                MsgBox("Error al generar fichero." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, Me.Text)
            Finally
                sr.Close()
            End Try

        Catch ex As Exception
            MsgBox("Error al generar fichero." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

#End Region

#Region "ActivaMenu"
    Private Sub ActivaMenu(activa As Boolean)
        Try
            Me.bttImprimir.Enabled = activa
            Me.bttGuardar.Enabled = Not activa
            Me.bttCancelar.Enabled = Not activa

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "bttCODCLI_ButtonClick"
    Private Sub bttCODCLI_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bttCODCLI.ButtonClick

        Dim Cliente As New dsClientes
        Dim Codigo As String

        Try
            Codigo = Cliente.Seleccionar

            If Not Codigo Is Nothing Then
                If Me.gvTarjetas.GetFocusedRow Is Nothing Then Me.gvTarjetas.AddNewRow()
                Me.gvTarjetas.SetFocusedValue(Codigo)
            End If

        Catch ex As Exception
            MsgBox("Error al buscar cliente." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub
#End Region

#Region "bttImportar_Click"
    Private Sub bttImportar_Click(sender As Object, e As EventArgs) Handles bttImportar.Click
        Try
            Dim BuscaFichero As New OpenFileDialog

            If BuscaFichero.ShowDialog = Windows.Forms.DialogResult.OK Then

                Me.DsTarjetas.ImportarFichero(BuscaFichero.FileName)

                MsgBox("Fichero importado correctamente", MsgBoxStyle.Information, Me.Text)

            Else
                Exit Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        Finally
            Aydara.Estado()
        End Try
    End Sub
#End Region

End Class