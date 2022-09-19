Public Class fCierreTienda 

#Region "Eventos formulario"
    Private Sub fCierreTienda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.DsTarifas.Cargar("V")
            Me.DsSeries.Cargar()

            Me.txtFecha.EditValue = Date.Today

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "Eventos txtCODALM"
    Private Sub txtCODALM_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCODALM.ButtonClick

        Dim NaxMaestro As New a3ERPActiveX.Maestro

        Try
            NaxMaestro.Iniciar("ALMACEN")

            Dim Codigo As String = NaxMaestro.Seleccionar
            If Not Codigo Is Nothing Then Me.txtCODALM.EditValue = Codigo : Me.txtCODALM.DoValidate()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtCODALM_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCODALM.Validated
        Try
            If Not Me.txtCODALM.IsModified Then Exit Try

            Me.txtCODALM.EditValue = Aydara.SentenciaSQL("SELECT CODALM FROM ALMACEN WHERE LTRIM(CODALM) = '" & Trim(Me.txtCODALM.EditValue) & "'")
            Me.txtDESCALM.EditValue = Aydara.SentenciaSQL("SELECT DESCALM FROM ALMACEN WHERE CODALM = '" & Me.txtCODALM.EditValue & "'")

            Me.txtCODCLI.EditValue = Aydara.SentenciaSQL("SELECT IDA_CODCLI FROM ALMACEN WHERE CODALM = '" & Me.txtCODALM.EditValue & "'")

        Catch ex As Exception
            MsgBox("Error al buscar la tienda", MsgBoxStyle.Information)
        End Try

    End Sub

#End Region

#Region "Eventos txtCODCLI"
    Private Sub txtCODCLI_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCODCLI.ButtonClick

        Dim Cliente As New dsClientes

        Try
            Dim Codigo As String = Cliente.Seleccionar
            If Not Codigo Is Nothing Then Me.txtCODCLI.EditValue = Codigo : Me.txtCODCLI.DoValidate()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Sub

    Private Sub txtCODCLI_Validated(sender As Object, e As EventArgs) Handles txtCODCLI.Validated
        Try
            Me.txtCODCLI.EditValue = Aydara.SentenciaSQL("SELECT CODCLI FROM CLIENTES WHERE LTRIM(CODCLI) = '" & Trim(Me.txtCODCLI.EditValue) & "'")
            Me.txtNOMCLI.EditValue = Aydara.SentenciaSQL("SELECT NOMCLI FROM CLIENTES WHERE CODCLI = '" & Me.txtCODCLI.EditValue & "'")

            Me.txtTARIFA.EditValue = Aydara.SentenciaSQL("SELECT TARIFA FROM CLIENTES WHERE CODCLI = '" & Me.txtCODCLI.EditValue & "'")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "bttAceptar_Click"
    Private Sub bttAceptar_Click(sender As Object, e As EventArgs) Handles bttAceptar.Click
        Try
            If Me.txtCODALM.EditValue = String.Empty Then
                MsgBox("Seleccione la tienda", MsgBoxStyle.Information, Me.Text)
                Me.txtCODALM.Focus()
                Exit Try
            End If

            If Me.txtCODCLI.EditValue = String.Empty Then
                MsgBox("Seleccione el cliente", MsgBoxStyle.Information, Me.Text)
                Me.txtCODCLI.Focus()
                Exit Try
            End If

            If Me.txtTARIFA.EditValue Is Nothing Then
                MsgBox("Seleccione la tarifa", MsgBoxStyle.Information, Me.Text)
                Me.txtTARIFA.Focus()
                Exit Try
            End If

            If Me.txtSERIE Is Nothing Then
                MsgBox("Seleccione la serie", MsgBoxStyle.Information, Me.Text)
                Me.txtSERIE.Focus()
                Exit Try
            End If

            Dim Tienda As New dsTiendas
            If Me.checkAbonar.Checked Then
                Tienda.AbonarExistencias(Me.txtCODALM.EditValue, Me.txtCODCLI.EditValue, Me.txtTARIFA.EditValue, Me.txtSERIE.EditValue, Me.txtFecha.EditValue)
            ElseIf Me.checkTraspaso.Checked Then
                Tienda.TraspasarExistencias(Me.txtCODALM.EditValue)
            Else
                Tienda.CierreTienda(Me.txtCODALM.EditValue, Me.txtCODCLI.EditValue, Me.txtTARIFA.EditValue, Me.txtSERIE.EditValue)
            End If

            MsgBox("Proceso completo", MsgBoxStyle.Information, Me.Text)

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

End Class