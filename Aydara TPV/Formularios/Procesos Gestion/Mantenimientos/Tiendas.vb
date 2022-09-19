Public Class Tiendas

#Region "Tiendas_FormClosing"
    Private Sub Tiendas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.bttCancelar.Text = "Cancelar" And Me.DsTiendas.HasChanges Then
            If MsgBox("Está editando una tienda. ¿Seguro que desea salir sin guardar los cambios?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then e.Cancel = True Else Me.Dispose()
        Else
            'Me.Dispose()
        End If
    End Sub
#End Region

#Region "Tiendas_KeyUp"
    Private Sub Tiendas_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "Tiendas_Load"
    Private Sub Tiendas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'Datos tienda
            Me.TIENDASTableAdapter.Fill(Me.DsTiendas.TIENDAS)

            'Puerto lector, báscula
            For Each str As String In IO.Ports.SerialPort.GetPortNames()
                Me.txtPuertoTerminales.Properties.Items.Add(str)
                Me.txtPuertoBascula.Properties.Items.Add(str)
            Next

            'Impresoras
            Dim impresoras As New System.Drawing.Printing.PrinterSettings
            For i As Integer = 0 To System.Drawing.Printing.PrinterSettings.InstalledPrinters.Count - 1
                Me.cmbImpresorasTicket.Properties.Items.Add(System.Drawing.Printing.PrinterSettings.InstalledPrinters(i))
                Me.cmbImpresorasFactura.Properties.Items.Add(System.Drawing.Printing.PrinterSettings.InstalledPrinters(i))
                Me.cmbImpresorasEtiquetas.Properties.Items.Add(System.Drawing.Printing.PrinterSettings.InstalledPrinters(i))
            Next

            ' Skins disponibles
            Dim skins As DevExpress.Skins.SkinContainerCollection = DevExpress.Skins.SkinManager.Default.Skins
            For i As Integer = 0 To skins.Count - 1
                Me.cmbApariencia.Properties.Items.Add(skins(i).SkinName)
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

        'Datos configuración terminal
        Me.cmbApariencia.EditValue = My.Settings.Apariencia
        Me.cmbImpresorasTicket.EditValue = My.Settings.ImpresoraTickets
        Me.cmbImpresorasFactura.EditValue = My.Settings.ImpresoraFacturas
        Me.cmbImpresorasEtiquetas.EditValue = My.Settings.ImpresoraEtiquetas
        Me.txtPuertoBascula.EditValue = My.Settings.PuertoBascula
        Me.txtTiempoEsperaBascula.EditValue = My.Settings.TiempoEsperaBascula
        Me.txtPuertoTerminales.EditValue = My.Settings.PuertoLector
        Me.txtDirectorioBasculas.EditValue = My.Settings.DirectorioBascula

    End Sub
#End Region

#Region "bttModificar_Click"
    Private Sub bttModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttModificar.Click
        Try
            ActivaDesactivaMenu(False)
            ActivaDesactivaCampos(False)
            Me.txtNombreFiscal.Focus()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Try
            If sender.text = "Salir" Then Me.Close() : Exit Sub

            'If MsgBox("¿Seguro que desea deshacer los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Deshacer cambios") = MsgBoxResult.No Then Exit Sub
            Me.TIENDASBindingSource.CancelEdit()

            'Datos configuración terminal
            Me.cmbApariencia.EditValue = My.Settings.Apariencia
            Me.cmbImpresorasTicket.EditValue = My.Settings.ImpresoraTickets
            Me.cmbImpresorasFactura.EditValue = My.Settings.ImpresoraFacturas
            Me.cmbImpresorasEtiquetas.EditValue = My.Settings.ImpresoraEtiquetas
            Me.txtPuertoBascula.EditValue = My.Settings.PuertoBascula
            Me.txtTiempoEsperaBascula.EditValue = My.Settings.TiempoEsperaBascula
            Me.txtPuertoTerminales.EditValue = My.Settings.PuertoLector
            Me.txtDirectorioBasculas.EditValue = My.Settings.DirectorioBascula

            ActivaDesactivaMenu(True)
            ActivaDesactivaCampos(True)

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttGuardar_Click"
    Private Sub bttGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttGuardar.Click
        Try
            'If MsgBox("¿Seguro que desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar cambios") = MsgBoxResult.No Then Exit Sub

            If Me.checkImpresionEtiquetas.Checked And Me.txtPrefijoEtiqueta.EditValue = String.Empty Then
                MsgBox("Introduzca el prefijo para sus etiquetas", MsgBoxStyle.Information)
                Me.txtPrefijoEtiqueta.Focus()
                Exit Sub
            End If

            Me.TIENDASBindingSource.EndEdit()
            Me.TIENDASTableAdapter.Update(Me.DsTiendas.TIENDAS)

            'Guardar fichero de configuración
            My.Settings.Apariencia = Me.cmbApariencia.EditValue
            My.Settings.ImpresoraTickets = Me.cmbImpresorasTicket.EditValue
            My.Settings.ImpresoraFacturas = Me.cmbImpresorasFactura.EditValue
            My.Settings.ImpresoraEtiquetas = Me.cmbImpresorasEtiquetas.EditValue
            My.Settings.PuertoBascula = Me.txtPuertoBascula.EditValue
            My.Settings.TiempoEsperaBascula = Me.txtTiempoEsperaBascula.EditValue
            My.Settings.PuertoLector = Me.txtPuertoTerminales.EditValue
            My.Settings.DirectorioBascula = Me.txtDirectorioBasculas.EditValue
            My.Settings.Save()
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(Me.cmbApariencia.EditValue)

            ActivaDesactivaMenu(True)
            ActivaDesactivaCampos(True)

            DatosTiendaActual(CodigoTienda)

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "ActivaDesactivaMenu"
    Private Sub ActivaDesactivaMenu(ByVal activa As Boolean)
        Me.bttModificar.Enabled = IIf(Me.TIENDASBindingSource.Count = 0, False, activa)
        Me.bttCancelar.Text = IIf(activa, "Salir", "Cancelar")
        Me.bttGuardar.Enabled = Not activa
    End Sub
#End Region

#Region "ActivaDesactivaCampos"
    Private Sub ActivaDesactivaCampos(ByVal activa As Boolean)
        Try
            'Me.txtCodigo.Properties.ReadOnly = IIf(activa, False, True)
            Me.txtNIF.Properties.ReadOnly = activa
            Me.txtNombreFiscal.Properties.ReadOnly = activa
            Me.txtDireccion.Properties.ReadOnly = activa
            Me.txtCodigoPostal.Properties.ReadOnly = activa
            Me.txtPoblacion.Properties.ReadOnly = activa
            Me.txtProvincia.Properties.ReadOnly = activa
            Me.txtTelefonos.Properties.ReadOnly = activa
            Me.checkRecargoEquivalencia.Properties.ReadOnly = activa

            Me.txtCabecera1.Properties.ReadOnly = activa
            Me.txtCabecera2.Properties.ReadOnly = activa
            Me.txtPie.Properties.ReadOnly = activa
            'Me.bttPruebaTicket.Enabled = IIf(activa, False, True)

            Me.txtDescuentoTarjeta.Properties.ReadOnly = activa
            Me.txtDecimalesImporte.Properties.ReadOnly = activa
            Me.txtDecimalesPrecio.Properties.ReadOnly = activa
            Me.txtPrefijoEtiqueta.Properties.ReadOnly = activa
            Me.txtTipoIva1.Properties.ReadOnly = activa
            Me.txtTipoIva2.Properties.ReadOnly = activa
            Me.txtTipoIva3.Properties.ReadOnly = activa
            Me.txtTipoIva4.Properties.ReadOnly = activa
            Me.txtTipoRecargo1.Properties.ReadOnly = activa
            Me.txtTipoRecargo2.Properties.ReadOnly = activa
            Me.txtTipoRecargo3.Properties.ReadOnly = activa
            Me.txtTipoRecargo4.Properties.ReadOnly = activa
            Me.txtTextoImpuesto.Properties.ReadOnly = activa
            Me.txtNumeroVale.Properties.ReadOnly = activa
            Me.txtNumeroPedido.Properties.ReadOnly = activa

            'Venta crédito
            Me.checkVentaCredito.Properties.ReadOnly = activa
            Me.txtSerieAlbaran.Properties.ReadOnly = activa
            Me.txtSerieFactura1.Properties.ReadOnly = activa
            Me.txtSerieFactura2.Properties.ReadOnly = activa
            Me.txtNumeroAlbaran.Properties.ReadOnly = activa
            Me.txtNumeroFactura1.Properties.ReadOnly = activa
            Me.txtNumeroFactura2.Properties.ReadOnly = activa
            Me.CheckTPVTactil.Properties.ReadOnly = activa
            Me.txtFormatoEmpresa.Properties.ReadOnly = activa
            Me.txtRegistroMercantil.Properties.ReadOnly = activa

            Me.checkCantidadManual.Properties.ReadOnly = activa
            Me.checkControlVendedores.Properties.ReadOnly = activa
            Me.checkDescuentoLinea.Properties.ReadOnly = activa
            Me.checkDescuentoSobrePromociones.Properties.ReadOnly = activa
            Me.checkGestionTallas.Properties.ReadOnly = activa
            Me.CheckGestionColores.Properties.ReadOnly = activa
            Me.checkGestionTarjetas.Properties.ReadOnly = activa
            Me.checkImpresionEtiquetas.Properties.ReadOnly = activa
            Me.checkPrecioManual.Properties.ReadOnly = activa
            Me.checkTicketBascula.Properties.ReadOnly = activa
            Me.checkVentasFamilia.Properties.ReadOnly = activa
            Me.checkVentasVendedor.Properties.ReadOnly = activa
            Me.checkControlTarjetas.Properties.ReadOnly = activa

            Me.checkAlbaranFormatoTicket.Properties.ReadOnly = activa
            Me.checkAlbaranFormatoA4.Properties.ReadOnly = activa

            'Etiqueta electrónica
            Me.checkEtiquetaElectronica.Properties.ReadOnly = activa
            Me.txtEE_DireccionFTP.Properties.ReadOnly = activa
            Me.txtEE_UsuarioFTP.Properties.ReadOnly = activa
            Me.txtEE_PasswordFTP.Properties.ReadOnly = activa

            Me.bttLogo.Enabled = Not activa

            Me.checkGestionTarjetas_CheckedChanged(Nothing, Nothing)
            Me.checkTicketBascula_CheckedChanged(Nothing, Nothing)

            'Configuración terminal
            Me.cmbApariencia.Properties.ReadOnly = activa
            Me.cmbImpresorasTicket.Properties.ReadOnly = activa
            Me.cmbImpresorasFactura.Properties.ReadOnly = activa
            Me.cmbImpresorasEtiquetas.Properties.ReadOnly = activa
            Me.txtPuertoBascula.Properties.ReadOnly = activa
            Me.txtTiempoEsperaBascula.Properties.ReadOnly = activa
            Me.txtPuertoTerminales.Properties.ReadOnly = activa

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "checkGestionTarjetas_CheckedChanged"
    Private Sub checkGestionTarjetas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkGestionTarjetas.CheckedChanged

        If Me.checkGestionTarjetas.EditValue Is System.DBNull.Value Then
            Me.txtDescuentoTarjeta.Text = 0
            Me.lblDescuentoTarjeta.Visible = False
            Me.txtDescuentoTarjeta.Visible = False
            Me.checkControlTarjetas.Visible = False
            Exit Sub
        End If

        If Me.checkGestionTarjetas.EditValue = True Then
            Me.lblDescuentoTarjeta.Visible = True
            Me.txtDescuentoTarjeta.Visible = True
            Me.checkControlTarjetas.Visible = True
        Else
            Me.txtDescuentoTarjeta.Text = 0
            Me.lblDescuentoTarjeta.Visible = False
            Me.txtDescuentoTarjeta.Visible = False
            Me.checkControlTarjetas.Visible = False
        End If

    End Sub
#End Region

#Region "checkTicketBascula_CheckedChanged"
    Private Sub checkTicketBascula_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkTicketBascula.CheckedChanged

        Me.bttParametrosBascula.Visible = Me.checkTicketBascula.Checked

        'If checkTicketBascula.EditValue Is System.DBNull.Value Then
        '    Me.txtPrefijoBascula1.Text = String.Empty
        '    Me.lblPrefijoBascula1.Visible = False
        '    Me.txtPrefijoBascula1.Visible = False

        '    Me.txtPrefijoBascula2.Text = String.Empty
        '    Me.lblPrefijoBascula2.Visible = False
        '    Me.txtPrefijoBascula2.Visible = False

        '    Me.txtPrefijoBascula3.Text = String.Empty
        '    Me.lblPrefijoBascula3.Visible = False
        '    Me.txtPrefijoBascula3.Visible = False
        '    Exit Sub
        'End If

        'If Me.checkTicketBascula.EditValue = True Then

        '    Me.lblPrefijoBascula1.Visible = True
        '    Me.txtPrefijoBascula1.Visible = True

        '    Me.lblPrefijoBascula2.Visible = True
        '    Me.txtPrefijoBascula2.Visible = True

        '    Me.lblPrefijoBascula3.Visible = True
        '    Me.txtPrefijoBascula3.Visible = True
        'Else
        '    Me.txtPrefijoBascula1.Text = String.Empty
        '    Me.lblPrefijoBascula1.Visible = False
        '    Me.txtPrefijoBascula1.Visible = False

        '    Me.txtPrefijoBascula2.Text = String.Empty
        '    Me.lblPrefijoBascula2.Visible = False
        '    Me.txtPrefijoBascula2.Visible = False

        '    Me.txtPrefijoBascula3.Text = String.Empty
        '    Me.lblPrefijoBascula3.Visible = False
        '    Me.txtPrefijoBascula3.Visible = False
        'End If
    End Sub
#End Region

#Region "bttPruebaTicket_Click"
    Private Sub bttPruebaTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttPruebaTicket.Click
        Try
            Dim ticket As String
            ticket = ActivaExpandido()
            ticket += Me.txtCabecera1.Text
            ticket += DesactivaExpandido()
            ticket += vbCrLf & vbCrLf & Me.txtCabecera2.Text
            ticket += vbCrLf & vbCrLf & vbCrLf & vbCrLf & Me.txtPie.Text

            If ActivaCorteTicket Then ticket += CorteTicket()

            Imprimir.SendStringToPrinter(My.Settings.ImpresoraTickets, ticket)

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "checkImpresionEtiquetas_CheckedChanged"
    Private Sub checkImpresionEtiquetas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkImpresionEtiquetas.CheckedChanged
        Me.lblPrefijoEtiqueta.Visible = Me.checkImpresionEtiquetas.Checked
        Me.txtPrefijoEtiqueta.Visible = Me.checkImpresionEtiquetas.Checked
    End Sub
#End Region

#Region "bttLogo_Click"
    Private Sub bttLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttLogo.Click
        Me.imgLogo.LoadImage()
        Me.DsTiendas.TIENDAS.Rows(0).Item("Logo") = Me.imgLogo.EditValue
    End Sub
#End Region

#Region "bttParametrosBascula_Click"
    Private Sub bttParametrosBascula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttParametrosBascula.Click
        ParametrosBascula.ShowDialog()
    End Sub
#End Region

#Region "txtDirectorioBasculas_ButtonClick"
    Private Sub txtDirectorioFicheroBasculas_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtDirectorioFicheroBasculas.ButtonClick
        Try
            If Not Me.bttGuardar.Enabled Then Exit Try

            Dim Directorio As New FolderBrowserDialog

            If Directorio.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.txtDirectorioFicheroBasculas.EditValue = Directorio.SelectedPath
            End If

        Catch ex As Exception
            MsgBox("Error al guardar directorio del fichero." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "txtDirectorioBasculas_ButtonClick"
    Private Sub txtDirectorioBasculas_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtDirectorioBasculas.ButtonClick
        Try
            If Not Me.bttGuardar.Enabled Then Exit Try

            Dim Directorio As New FolderBrowserDialog

            If Directorio.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.txtDirectorioBasculas.EditValue = Directorio.SelectedPath
            End If

        Catch ex As Exception
            MsgBox("Error al guardar directorio del fichero." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

End Class