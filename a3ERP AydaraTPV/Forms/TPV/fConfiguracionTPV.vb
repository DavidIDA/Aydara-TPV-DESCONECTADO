Public Class fConfiguracionTPV

#Region "Eventos formulario"
    Private Sub fConfiguracionTPV_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.IDAAYDARATPVBindingSource.EndEdit()

            If Me.DsTPVConfiguracion.HasChanges Then
                If MsgBox("¿Desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                    Me.IDA_AYDARATPVTableAdapter.Update(Me.DsTPVConfiguracion.IDA_AYDARATPV)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub fConfiguracionTPV_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.F3
                If e.Alt Then
                    Me.bttCancelar_Click(Me.bttCancelar, Nothing)
                Else
                    Me.bttAceptar_Click(Me.bttAceptar, Nothing)
                End If
        End Select
    End Sub

    Private Sub fConfiguracionTPV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.DsSeries.Cargar()
            Me.DsTiposIVA.Cargar()
            Me.DsTiposOperacion.Cargar()
            Me.IDA_AYDARATPVTableAdapter.Fill(Me.DsTPVConfiguracion.IDA_AYDARATPV)

            If Me.IDAAYDARATPVBindingSource.Count = 0 Then
                Me.IDAAYDARATPVBindingSource.AddNew()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

#End Region

#Region "Selección cuenta"
    Private Function SeleccionarCuenta() As String

        Dim naxSeleccion As New a3ERPActiveX.Seleccion

        Try
            naxSeleccion.Tabla = "CUENTAS"
            naxSeleccion.CampoResultado = "CUENTA"

            Dim CUENTA = naxSeleccion.Ejecutar

            If Not IsNothing(CUENTA) Then
                Return CUENTA
            Else
                Return String.Empty
            End If

        Catch ex As Exception
            Throw ex
            Return String.Empty
        End Try

    End Function

    Private Sub txtCUENTAS_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        Dim Cuenta As String = Me.SeleccionarCuenta
        If Cuenta <> String.Empty Then sender.EditValue = Cuenta
    End Sub

#End Region

#Region "txtDirectorioFicheros_ButtonClick"
    Private Sub txtDirectorioFicheros_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtDirectorioFicheros.ButtonClick
        Try
            Dim Directorio As New System.Windows.Forms.FolderBrowserDialog()
            Directorio.ShowDialog()
            Me.txtDirectorioFicheros.EditValue = Directorio.SelectedPath

        Catch ex As Exception
            Me.txtDireccionEnvio.EditValue = String.Empty
        End Try
    End Sub
#End Region

#Region "txtCODCLI_ButtonClick"
    Private Sub txtCODCLI_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCODCLIDESGLOSE.ButtonClick

        Dim Cliente As New dsClientes
        Dim Codigo As String

        Try
            Codigo = Cliente.Seleccionar
            If Not Codigo Is Nothing Then Me.txtCODCLIDESGLOSE.EditValue = Codigo

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Sub
#End Region

#Region "Opciones menú"
    Private Sub bttAceptar_Click(sender As Object, e As EventArgs) Handles bttAceptar.Click
        Try
            Me.IDAAYDARATPVBindingSource.EndEdit()
            Me.IDA_AYDARATPVTableAdapter.Update(Me.DsTPVConfiguracion.IDA_AYDARATPV)
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub bttCancelar_Click(sender As Object, e As EventArgs) Handles bttCancelar.Click
        Try
            Me.IDAAYDARATPVBindingSource.CancelEdit()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

End Class