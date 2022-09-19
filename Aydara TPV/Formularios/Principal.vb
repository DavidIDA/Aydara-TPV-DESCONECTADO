Public Class Principal

    Dim SinConexion As Boolean = False

#Region "Principal_FormClosing"
    Private Sub Principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
    Private Sub Principal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.Tag = "update" Then Exit Sub

Comprueba_formularios:
        If My.Application.OpenForms.Count > 1 Then
            Dim Mensaje As String = "Cierre todos los procesos antes de salir"
            Mensaje &= vbCrLf & "-----------------------------------------"
            Dim i As Integer
            For i = 1 To My.Application.OpenForms.Count - 1
                If My.Application.OpenForms(i).Text = String.Empty Then My.Application.OpenForms(i).Close() : GoTo Comprueba_formularios
                Mensaje &= vbCrLf & " - " & My.Application.OpenForms(i).Text
            Next
            MsgBox(Mensaje, MsgBoxStyle.Information)
            e.Cancel = True
        End If

    End Sub
#End Region

#Region "Principal_Shown"
    Private Sub Principal_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        'Leer parámetros
        If Environment.GetCommandLineArgs.Length > 1 Then
            If Environment.GetCommandLineArgs(1).ToUpper = "E" Then
                Try
                    Dim Articulos As New dsArticulos
                    Articulos.GeneraFicheroBalanzas()

                    Dim Etiquetas As New dsEtiquetas
                    Etiquetas.GeneraFicheroEtiquetasElectronicas(False)

                Catch ex As Exception
                    MsgBox(ex.Message, vbExclamation, Me.Text)
                Finally
                    Application.Exit()
                End Try
            End If
        End If

        If Me.SinConexion Then Exit Sub

        Me.Cursor = Cursors.WaitCursor

        'Comprobar si existe alguna actualización de la aplicación
        'General.ComprobarVersionApp()

        'Comprobar si existen actualizaciones pendientes
        If General.Comunicaciones_Tipo > 0 And Date.Today > General.FechaUltimaActualizacion Then
            Dim Comunicacion As New dsComunicaciones
            Comunicacion.ActualizarDatos()
        End If

        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Error al intentar conectar con la base de datos", MsgBoxStyle.Critical)
            Exit Sub
            'Application.Exit()
        End Try

        Try
            'Comprobar si existen precios pendientes de actualizar
            Dim tModificaciones As New dsModificacionesPendientes.MODIFICACIONES_PENDIENTESDataTable
            cmd.CommandText = "SELECT * FROM MODIFICACIONES_PENDIENTES WHERE FechaVigor<='" & Date.Today & "'"

            tModificaciones.Load(cmd.ExecuteReader)

            If tModificaciones.Rows.Count > 0 Then

                If MsgBox("Existen precios de artículos pendientes de actualizar. ¿desea actualizarlos ahora?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Actualizar precios") = MsgBoxResult.Yes Then

                    Dim rModificaciones As dsModificacionesPendientes.MODIFICACIONES_PENDIENTESRow
                    Dim i As Integer

                    For i = 0 To tModificaciones.Rows.Count - 1
                        rModificaciones = tModificaciones.Rows(i)
                        Almacen.ActualizaPrecio(rModificaciones.CodigoArticulo, rModificaciones.CodigoColor, rModificaciones.CodigoTalla, rModificaciones.PrecioTarifa)
                    Next

                    cmd.CommandText = "DELETE FROM MODIFICACIONES_PENDIENTES"
                    cmd.ExecuteNonQuery()

                    MsgBox("Los precios de los artículos han sido actualizados correctamente", MsgBoxStyle.Information)

                End If

            End If

        Catch ex As Exception
            MsgBox("Error al actualizar los precios de los artículos", MsgBoxStyle.Exclamation)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

        Me.Cursor = Cursors.Default

    End Sub
#End Region

#Region "Principal_Load"
    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor

            'Versión
            Me.txtVersion.Caption = "Aydara TPV - " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & Format(My.Application.Info.Version.Build, "00")

            'Comprueba cadena de conexión
            General.CompruebaCadenaConexion(My.Settings.CadenaConexion)

            'Apariencia
            DevExpress.UserSkins.OfficeSkins.Register()
            DevExpress.UserSkins.BonusSkins.Register()

            ''Comprobar activación
            'Dim sDatosActivacion As Activacion.sDatosActivacion = Activacion.DatosActivacion
            'If sDatosActivacion.DiasRestantes <= Activacion.DiasDemo Then
            '    Me.Inicio1.Visible = False
            '    DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Black")
            '    Dim fInfo As New Info
            '    If Not fInfo.ShowDialog() = Windows.Forms.DialogResult.OK Then Me.Close()
            '    Me.Inicio1.Visible = True
            'End If

            'Obtener parámetros de la tienda
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(My.Settings.Apariencia)
            General.CodigoTienda = 1

            If DatosTiendaActual(CodigoTienda) Then
                General.CodigoCaja = 1
                General.DatosCajaActual(General.CodigoCaja)
            Else
                Me.SinConexion = True
            End If

            'Comprobar gestión de tallas y colores
            Me.menuColores.Visibility = IIf(GestionColores, DevExpress.XtraBars.BarItemVisibility.Always, DevExpress.XtraBars.BarItemVisibility.Never)
            Me.menuTallas.Visibility = IIf(GestionTallas, DevExpress.XtraBars.BarItemVisibility.Always, DevExpress.XtraBars.BarItemVisibility.Never)

            'variable impresora
            Dim impresora As New PrintDialog

            'Impresora de tickets
            If My.Settings.ImpresoraTickets = String.Empty Then
                MsgBox("Seleccione la impresora de tickets", MsgBoxStyle.Information)
                impresora.ShowDialog()
                My.Settings.ImpresoraTickets = impresora.PrinterSettings.PrinterName
                My.Settings.Save()
                Me.bttImpresora.Caption = impresora.PrinterSettings.PrinterName
            End If
            Me.bttImpresora.Caption = My.Settings.ImpresoraTickets

            'Puerto lector, báscula
            For Each str As String In IO.Ports.SerialPort.GetPortNames()
                Me.cmbPuertosLector.Items.Add(str)
                Me.cmbPuertosBascula.Items.Add(str)
            Next
            Me.menuPuertoLector.EditValue = My.Settings.PuertoLector
            Me.menuPuertoBascula.EditValue = My.Settings.PuertoBascula

            Me.menuTiempoEspera.EditValue = My.Settings.TiempoEsperaBascula

            'If My.Computer.Network.IsAvailable Then
            '    Me.bttWebIda_ItemClick(Nothing, Nothing)
            'End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

    Private Sub Main_PageAdded(ByVal sender As Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles Main.PageAdded
        Me.panelInicio.Visible = False
    End Sub

    Private Sub Main_PageRemoved(ByVal sender As Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles Main.PageRemoved
        If Me.MdiChildren.Length = 0 Then Me.panelInicio.Visible = True
    End Sub

    Private Sub menuClientes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuClientes.ItemClick
        AbrirFormulario(Clientes, "Fichero de Clientes")
    End Sub

    Private Sub menuArticulos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuArticulos.ItemClick
        AbrirFormulario(Articulos, "Fichero de Artículos")
    End Sub

    Private Sub menuFamilias_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuFamilias.ItemClick
        AbrirFormulario(Familias, "Fichero de Familias")
    End Sub

    Private Sub menuProveedores_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuProveedores.ItemClick
        AbrirFormulario(Proveedores, "Fichero de Proveedores")
    End Sub

    Private Sub menuEmpleados_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuEmpleados.ItemClick
        AbrirFormulario(Empleados, "Fichero de Empleados")
    End Sub

    Private Sub menuTiendas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuTiendas.ItemClick
        Dim ftiendas As New Tiendas
        ftiendas.ShowDialog()
    End Sub

    Private Sub menuCajas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuCajas.ItemClick
        AbrirFormulario(Cajas, "Fichero de Cajas")
    End Sub

    Private Sub bttClientes_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttClientes.LinkClicked
        menuClientes_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub bttArticulos_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttArticulos.LinkClicked
        menuArticulos_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub bttFamilias_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttFamilias.LinkClicked
        menuFamilias_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub bttProveedores_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttProveedores.LinkClicked
        menuProveedores_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub bttEmpleados_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttEmpleados.LinkClicked
        menuEmpleados_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub bttCajas_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttCajas.LinkClicked
        menuCajas_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub bttTiendas_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttTiendas.LinkClicked
        menuTiendas_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub XtraTabbedMdiManager1_PageAdded(ByVal sender As Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles Main.PageAdded

        Me.panelInicio.Visible = False
        Me.bttCerrarNavegador_ItemClick(Nothing, Nothing)
        Me.bttWebIda.Enabled = False

    End Sub

    Private Sub XtraTabbedMdiManager1_PageRemoved(ByVal sender As Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles Main.PageRemoved

        If Me.MdiChildren.Length = 0 Then Me.panelInicio.Visible = True : Me.bttWebIda.Enabled = True

    End Sub

    Private Sub bttWebIda_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttWebIda.ItemClick

        Me.panelDatosIDA.Visible = False
        Me.WebBrowser1.Visible = True
        Me.WebBrowser1.Navigate("http://www.ida.es")
        Me.bttPaginaSiguiente.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bttPaginaAnterior.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bttCerrarNavegador.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bttWebIda.Caption = "Home"
        Me.bttWebIda.ImageIndex = 26

    End Sub

    Private Sub bttPaginaAnterior_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttPaginaAnterior.ItemClick

        Me.WebBrowser1.GoBack()

    End Sub

    Private Sub bttPaginaSiguiente_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttPaginaSiguiente.ItemClick

        Me.WebBrowser1.GoForward()

    End Sub

    Private Sub bttCerrarNavegador_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttCerrarNavegador.ItemClick

        Me.bttPaginaSiguiente.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bttPaginaAnterior.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bttCerrarNavegador.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.WebBrowser1.Visible = False
        Me.bttWebIda.Caption = "Integración y Desarrollo de Aplicaciones, S.L."
        Me.bttWebIda.ImageIndex = 47
        Me.panelDatosIDA.Visible = True

    End Sub

    Private Sub menuValesTienda_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        ValesTienda.ShowDialog()
    End Sub

    Private Sub menuTallas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuTallas.ItemClick
        Tallas.ShowDialog()
    End Sub

    Private Sub menuColores_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuColores.ItemClick
        Colores.ShowDialog()
    End Sub

    Private Sub bttImpresora_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttImpresora.ItemClick
        'Dim impresora As New PrintDialog
        'impresora.ShowDialog()
        'My.Settings.ImpresoraTickets = impresora.PrinterSettings.PrinterName
        'My.Settings.Save()
        'Me.bttImpresora.Caption = impresora.PrinterSettings.PrinterName
    End Sub

    Private Sub menuVales_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        FicheroVales.ShowDialog()
    End Sub

    Private Sub menuPendienteCobro_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        PendientesCobro.ShowDialog()
    End Sub

    Private Sub menuMovimientosCaja_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuMovimientosCaja.ItemClick

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()
        cmd.CommandText = "SELECT COUNT(CodigoCaja) FROM CAJAS WHERE CodigoTienda=" & CodigoTienda & " AND CajaCerrada = 0"

        If cmd.ExecuteScalar = 0 Then
            MsgBox("No hay ninguna caja abierta", MsgBoxStyle.Information)
        Else
            MovimientosCaja.ShowDialog()
        End If

        cmd.Connection.Close()

    End Sub

    Private Sub bttMovimientosCaja_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttMovimientosCaja.LinkClicked
        Me.menuMovimientosCaja_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub menuPromociones_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuPromociones.ItemClick
        AbrirFormulario(Promociones, "Promociones")
    End Sub

    Private Sub bttEmisionTikets_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttEmisionTikets.LinkClicked
        Me.menuEmisionTickets_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub menuListadoFicheroClientes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuListadoFicheroClientes.ItemClick
        'ListadoClientes.ShowDialog()
        AbrirFormulario(ListadoClientes, "Listado de clientes")
    End Sub

    Private Sub menuListadoFicheroProveedores_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuListadoFicheroProveedores.ItemClick
        'ListadoProveedores.ShowDialog()
        AbrirFormulario(ListadoProveedores, "Listado de proveedores")
    End Sub

    Private Sub bttTeclado_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttTeclado.ItemClick
        System.Diagnostics.Process.Start("osk.exe")
    End Sub

    Private Sub menuEmisionTickets_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuEmisionTickets.ItemClick
        'Dim f As New TPV_Tactil
        'f.Show()
        TPV_Tactil.Show()
    End Sub

    Private Sub bttTratamientoPromociones_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttTratamientoPromociones.LinkClicked
        Me.menuPromociones_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub menuMantenimientoVales_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuMantenimientoVales.ItemClick
        ValesTienda.ShowDialog()
    End Sub

    Private Sub bttMantenimientoVales_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttMantenimientoVales.LinkClicked
        menuMantenimientoVales_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub menuCargaManualPedidosAlmacen_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuCargaManualPedidosAlmacen.ItemClick
        AbrirFormulario(Pedidos, "Pedidos")
    End Sub

    Private Sub menuModificacionTarifasPrecios_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuModificacionTarifasPrecios.ItemClick
        AbrirFormulario(ModificacionPrecios, "Modificación de precios")
    End Sub

    Private Sub bttModificacionPrecios_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttModificacionPrecios.LinkClicked
        Me.menuModificacionTarifasPrecios_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub bttPedidos_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttPedidos.LinkClicked
        Me.menuCargaManualPedidosAlmacen_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub menuListadoFicheroArticulos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuListadoFicheroArticulos.ItemClick
        'ListadoArticulos.ShowDialog()
        AbrirFormulario(ListadoArticulos, "Listado de artículos")
    End Sub

    Private Sub menuConsultaValesPendientes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuConsultaValesPendientes.ItemClick
        'ListadoVales.ShowDialog()
        AbrirFormulario(ListadoVales, "Vales pendientes")
    End Sub

    Private Sub menuConsultaSaldosClientes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuConsultaSaldosClientes.ItemClick
        'ListadoSaldoClientes.ShowDialog()
        AbrirFormulario(ListadoSaldoClientes, "Saldos de clientes")
    End Sub

    Private Sub menuListadoInventarioTienda_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuListadoInventarioTienda.ItemClick
        'ListadoInventario.ShowDialog()
        AbrirFormulario(InventarioArticulos, "Listado inventario de artículos")
    End Sub

    Private Sub menuListadoTarifasPrecios_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuListadoTarifasPrecios.ItemClick
        'ListadoTarifas.ShowDialog()
        AbrirFormulario(ListadoArticulos, "Listado de tarifas")
    End Sub

    Private Sub menuListadoEtiquetas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuListadoEtiquetas.ItemClick
        General.AbrirFormulario(ImpresionEtiquetasPendientes, "Impresión etiquetas")
    End Sub

    Private Sub menuTiposUnidades_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuTiposUnidades.ItemClick
        TiposUnidades.ShowDialog()
    End Sub

    Private Sub menuEntradasMercancia_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuEntradasMercancia.ItemClick
        AbrirFormulario(AlbaranesCompras, "Entrada mercancías")
    End Sub

    Private Sub menuSituacionTienda_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuSituacionTienda.ItemClick
        SituacionTienda.ShowDialog()
    End Sub

    Private Sub bttSituacionTienda_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttSituacionTienda.LinkClicked
        Me.menuSituacionTienda_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub menuCierreCaja_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuCierreCaja.ItemClick
        CierreCaja.ShowDialog()
    End Sub

    Private Sub bttCierreCaja_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttCierreCaja.LinkClicked
        Me.menuCierreCaja_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub menuCierreTienda_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuCierreTienda.ItemClick
        CierreTienda.ShowDialog()
    End Sub

    Private Sub bttCierreTienda_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttCierreTienda.LinkClicked
        Me.menuCierreTienda_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub bttEntradasMercancia_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttEntradasMercancia.LinkClicked
        Me.menuEntradasMercancia_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub menuCopiasSeguridad_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuCopiasSeguridad.ItemClick
        Me.Cursor = Cursors.WaitCursor
        General.CopiaSeguridad()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub menuConsultaHistoricoTicket_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuConsultaHistoricoTicket.ItemClick
        ConsultaTickets.Historico = True
        ConsultaTickets.ShowDialog()
    End Sub

    Private Sub menuRelacionTicketDia_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuRelacionTicketDia.ItemClick
        'EstadisticasTickets.ShowDialog()
        AbrirFormulario(EstadisticasTickets, "Estadísticas tickets")
    End Sub

    Private Sub menuTema_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuTema.EditValueChanged
        My.Settings.Apariencia = Me.menuTema.EditValue
        My.Settings.Save()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(My.Settings.Apariencia)
    End Sub

    Private Sub bttConsultasHistoricoTicket_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttConsultasHistoricoTicket.LinkClicked
        Me.menuConsultaHistoricoTicket_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub bttRelacionTicketDia_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttRelacionTicketDia.LinkClicked
        Me.menuRelacionTicketDia_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub menuCubosEstadisticos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuCubosEstadisticos.ItemClick
        General.AbrirFormulario(CubosEstadisticos, "Cubos estadísticos")
    End Sub

    Private Sub bttCubosEstadisticos_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttCubosEstadisticos.LinkClicked
        Me.menuCubosEstadisticos_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub menuComunicaciones_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuComunicaciones.ItemClick
        Dim fComunicaciones As New Comunicaciones
        fComunicaciones.ShowDialog()
    End Sub

    Private Sub bttComunicaciones_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bttComunicaciones.LinkClicked
        Me.menuComunicaciones_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub menuRecepcion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuRecepcion.ItemClick
        Try
            If MsgBox("¿Seguro que desea recepcionar nuevos datos?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim Comunicacion As New dsComunicaciones
                Comunicacion.ActualizarDatos()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub menuSorteos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuSorteos.ItemClick
        General.AbrirFormulario(Sorteos, "Fidelización")
    End Sub

    Private Sub menuTraspasoAlmacenes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuTraspasoAlmacenes.ItemClick
        General.AbrirFormulario(TraspasoAlmacenes, "Traspaso entre almacenes")
    End Sub

    Private Sub menuRecepcionEtiquetas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuRecepcionEtiquetas.ItemClick
        If MsgBox("¿Seguro que desea recepcionar ETIQUETAS?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            General.AbrirFormulario(RecepcionTelxon, "Recepción de etiquetas Telxon")
            RecepcionTelxon.Tag = 0
        End If
    End Sub

    Private Sub menuRecepcionPedidos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuRecepcionPedidos.ItemClick
        If MsgBox("¿Seguro que desea recepcionar PEDIDOS?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            General.AbrirFormulario(RecepcionTelxon, "Recepción de pedidos Telxon")
            RecepcionTelxon.Tag = 1
        End If
    End Sub

    Private Sub menuRecepcionInventario_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuRecepcionInventario.ItemClick
        If MsgBox("¿Seguro que desea recepcionar INVENTARIO?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            General.AbrirFormulario(RecepcionTelxon, "Recepción de inventario Telxon")
            RecepcionTelxon.Tag = 2
        End If
    End Sub

    Private Sub menuComprobacionInventario_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuComprobacionInventario.ItemClick
        General.AbrirFormulario(Inventario, "Inventario")
    End Sub

    Private Sub menuEnvio_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuEnvio.ItemClick
        If MsgBox("¿Seguro que desea enviar los ficheros generados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Me.Cursor = Cursors.WaitCursor

                If Comunicacion.Envio() Then
                    MsgBox("Los ficheros han sido enviados correctamente", MsgBoxStyle.Information)
                Else
                    MsgBox("Error al intentar enviar los ficheros", MsgBoxStyle.Exclamation)
                End If

            Finally
                Me.Cursor = Cursors.Default
            End Try
        End If
    End Sub

#Region "bttActualizarAplicacion_ItemClick"
    Private Sub bttActualizarAplicacion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttActualizarAplicacion.ItemClick
        Try
            If Not Me.Main.SelectedPage Is Nothing Then
                MsgBox("Cierre todas las ventanas antes de actualizar la aplicación", MsgBoxStyle.Information, "Actualizar aplicación")
                Exit Sub
            End If

            If MsgBox("¿Seguro que desea instalar la última versión del producto?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                Cursor = Cursors.WaitCursor

                If Ftp.ActualizaAplicacion(General.Comunicaciones_Direccion, General.Comunicaciones_Usuario, General.Comunicaciones_Password) Then
                    Me.Tag = "update"
                    Application.Exit()
                Else
                    MsgBox("No existe ninguna actualización o no está disponible en estos momentos.", MsgBoxStyle.Information)
                End If

            End If

        Catch ex As Exception
            MsgBox("Error al intentar actualizar la aplicación." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "menuConexion_ItemClick"
    Private Sub menuConexion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuConexion.ItemClick
        Dim CadenaConexion As String = AGI2005.BaseDatos.OpenBDDialog(My.Settings.CadenaConexion)
        My.Settings.CadenaConexion = CadenaConexion
        Me.Principal_Load(Me, Nothing)
        Me.Principal_Shown(Me, Nothing)
    End Sub
#End Region

    Private Sub menuStockMinimoMaximo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuStockMinimoMaximo.ItemClick
        AbrirFormulario(MaximosMinimos, "Mantenimiento mínimo/máximo")
    End Sub

    Private Sub menuPuertoLector_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuPuertoLector.EditValueChanged
        My.Settings.PuertoLector = Me.menuPuertoLector.EditValue
        My.Settings.Save()
    End Sub

    Private Sub menuPuertoBascula_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuPuertoBascula.EditValueChanged
        My.Settings.PuertoBascula = Me.menuPuertoBascula.EditValue
        My.Settings.Save()
    End Sub

    Private Sub menuTiempoEspera_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuTiempoEspera.EditValueChanged
        My.Settings.TiempoEsperaBascula = Me.menuTiempoEspera.EditValue
        My.Settings.Save()
    End Sub

    Private Sub bttExportarImagenes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttExportarImagenes.ItemClick
        If MsgBox("¿Seguro que desea exportar el fichero de imágenes?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Me.Cursor = Cursors.WaitCursor

                'Tiendas seleccionadas
                Dim fTiendas As New DameTiendas
                If fTiendas.ShowDialog() = Windows.Forms.DialogResult.OK Then

                    If Comunicacion.ExportarImagenes(fTiendas.arrayTiendas) Then
                        MsgBox("El fichero ha sido generado correctamente", MsgBoxStyle.Information)
                    Else
                        MsgBox("Error al generar fichero de imágenes.", MsgBoxStyle.Exclamation)
                    End If

                End If

            Finally
                Me.Cursor = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub bttImportarImagenes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttImportarImagenes.ItemClick
        If MsgBox("¿Seguro que desea importar el fichero de imágenes?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Me.Cursor = Cursors.WaitCursor

                If Comunicacion.ImportarImagenes Then
                    MsgBox("El fichero de imágenes ha sido importado correctamente", MsgBoxStyle.Information)
                Else
                    MsgBox("Error al importar fichero de imágenes.", MsgBoxStyle.Exclamation)
                End If

            Finally
                Me.Cursor = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub bttExportarPromociones_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttExportarPromociones.ItemClick
        If MsgBox("¿Seguro que desea exportar el fichero de promociones especiales?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Me.Cursor = Cursors.WaitCursor

                If Comunicacion.ExportarPromociones() Then
                    MsgBox("El fichero ha sido generado correctamente", MsgBoxStyle.Information)
                Else
                    MsgBox("Error al generar fichero de promociones.", MsgBoxStyle.Exclamation)
                End If

            Finally
                Me.Cursor = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub bttReenviarVentas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttReenviarVentas.ItemClick
        CierreTienda.Tag = "R"
        CierreTienda.ShowDialog()
        CierreTienda.Tag = String.Empty
    End Sub

    Private Sub menuInfo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuInfo.ItemClick
        Dim fInfo As New Info
        fInfo.ShowDialog()
    End Sub

    Private Sub bttRedimensionarImagenes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttRedimensionarImagenes.ItemClick
        If MsgBox("¿Seguro que desea redimensionar todas las imágenes de los artículos?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Me.Cursor = Cursors.WaitCursor

                If General.RedimensionarImagenes() Then
                    MsgBox("Todas las imágenes han sido redimensionadas correctamente", MsgBoxStyle.Information)
                Else
                    MsgBox("Error al redimensionar imágenes", MsgBoxStyle.Exclamation)
                End If

            Finally
                Me.Cursor = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub bttDirectorioComunicacion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttDirectorioComunicacion.ItemClick
        Try
            Dim Directorio As New FolderBrowserDialog

            If Directorio.ShowDialog() = Windows.Forms.DialogResult.OK Then
                My.Settings.DirectorioBascula = Directorio.SelectedPath
            End If

        Catch ex As Exception
            MsgBox("Error al guardar directorio del fichero." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub bttReiniciarComunicacionBascula_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttReiniciarComunicacionBascula.ItemClick
        Try
            General.ReiniciarComunicacionBascula()
        Catch ex As Exception
            MsgBox("Error al crear fichero de reinicio." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

#Region "Generacion de Vales de Cliente"
    Private Sub menuGeneracionVales_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuGeneracionVales.ItemClick
        Try
            AbrirFormulario(fGeneracionVales, "Generación de Vales de Cliente")
        Catch ex As Exception
            MsgBox(ex.Message, , Me.Text)
        End Try
    End Sub
#End Region

    Private Sub menuExportarContabilidad_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuExportarContabilidad.ItemClick
        Try
            AbrirFormulario(fExportarContabilidad, "Exportación a Contabilidad")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub menuIncidencias_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuIncidencias.ItemClick
        AbrirFormulario(fIncidencias, "Mantenimiento de Incidencias")
    End Sub

    Private Sub menuExportarAlbaranes_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuExportarAlbaranes.ItemClick
        Try
            AbrirFormulario(fExportaralbaranes, "Exportación Albaranes")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttTiposIncidencias_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttTiposIncidencias.ItemClick
        TiposIncidencia.ShowDialog()
    End Sub

    Private Sub bttEHLIS_Tarifas_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttEHLIS_Tarifas.ItemClick
        Try
            AbrirFormulario(TarifasEHLIS, "Tarifa EHLIS")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttEHLIS_Albaranes_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttEHLIS_Albaranes.ItemClick
        Try
            AbrirFormulario(AlbaranesEHLIS, "Albaranes EHLIS")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttEHLIS_Promociones_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttEHLIS_Promociones.ItemClick
        Try
            AbrirFormulario(PromocionesEHLIS, "Promociones EHLIS")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttEnviarDatosTerminal_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttEnviarDatosTerminal.ItemClick
        Try
            If MsgBox("¿Seguro que desea enviar datos al terminal?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim Articulo As New dsArticulos
                Articulo.EnviarDatosTerminal()
                MsgBox("Ficheros enviados correctamente.", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub menuPreciosBasculas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuPreciosBasculas.ItemClick
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Articulos As New dsArticulos

            Articulos.GeneraFicheroBalanzas()

            MsgBox("Fichero enviado correctamente", MsgBoxStyle.Information, Me.Text)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub menuActualizarEtiquetasElectronicas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuActualizarEtiquetasElectronicas.ItemClick
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Etiquetas As New dsEtiquetas

            Dim resultado As Integer = MsgBox("¿Enviar sólo artículos con modificaciones?" & vbCrLf & "No: Enviar todos artículos", MsgBoxStyle.Information + MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton3, "No existe")
            If resultado = MsgBoxResult.Yes Then
                Etiquetas.GeneraFicheroEtiquetasElectronicas(False)
            ElseIf resultado = MsgBoxResult.No Then
                Etiquetas.GeneraFicheroEtiquetasElectronicas(True)
            Else
                Exit Try
            End If

            MsgBox("Fichero enviado correctamente", MsgBoxStyle.Information, Me.Text)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class