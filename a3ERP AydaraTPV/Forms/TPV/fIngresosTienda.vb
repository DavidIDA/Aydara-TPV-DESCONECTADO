Public Class fIngresosTienda

    Dim regkey_Formulario As String, regkey_Cajas As String

#Region "Eventos formulario"
    Private Sub fIngresosTienda_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
            Me.gvIngresos.SaveLayoutToRegistry(Me.regkey_Cajas)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub fIngresosTienda_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Try
            Select Case e.KeyCode

                Case Keys.F3
                    If Me.bttGuardar.Enabled Then
                        If e.Alt Then
                            Me.bttCancelar_Click(Me.bttCancelar, Nothing)
                        Else
                            Me.bttGuardar_Click(Me.bttGuardar, Nothing)
                        End If
                    End If

                Case Keys.F5 'Buscar
                    If Me.bttBuscar.Enabled Then Me.bttBuscar_Click(Me.bttBuscar, Nothing)

                Case Keys.G
                    If e.Control Then Aydara.ConfigurarGrilla(Me.gvIngresos, Me.regkey_Cajas & "\Default")

                Case Keys.Add
                    Try
                        If Not Me.dgIngresos.IsFocused Then Exit Try
                        If Me.gvIngresos.GetFocusedDataRow Is Nothing Then Exit Try

                        With DirectCast(Me.gvIngresos.GetFocusedDataRow, dsTickets.IDA_INGRESOSTIENDASRow)
                            If Me.gvIngresos.FocusedColumn Is Me.colNUMAPUNTE And .IsNUMAPUNTENull Then
                                Me.bttApunte_ButtonClick(Me.bttApunte, Nothing)
                            ElseIf Me.gvIngresos.FocusedColumn Is Me.colNUMAPUNTE_CAJA And .IsNUMAPUNTE_CAJANull Then
                                Me.bttApunteCaja_ButtonClick(Me.bttApunteCaja, Nothing)
                            End If
                        End With

                    Catch ex As Exception
                        Throw ex
                    End Try

                Case Keys.Subtract

                    If Not Me.dgIngresos.IsFocused Then Exit Try

                    Dim a3ERPAsiento As New a3ERPActiveX.Asiento

                    Try
                        If Me.bttGuardar.Enabled Then Exit Try
                        If Me.gvIngresos.GetFocusedDataRow Is Nothing Then Exit Try

                        a3ERPAsiento.Iniciar()

                        With DirectCast(Me.gvIngresos.GetFocusedDataRow, dsTickets.IDA_INGRESOSTIENDASRow)

                            If Me.gvIngresos.FocusedColumn Is Me.colNUMAPUNTE And Not .IsNUMAPUNTENull Then
                                If MsgBox("¿Seguro que desea eliminar el asiento contable del ingreso?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                                    a3ERPAsiento.Borra(.NUMAPUNTE)
                                    Me.bttBuscar_Click(Me.bttBuscar, Nothing)
                                End If
                            ElseIf Me.gvIngresos.FocusedColumn Is Me.colNUMAPUNTE_CAJA And Not .IsNUMAPUNTE_CAJANull Then
                                If MsgBox("¿Seguro que desea eliminar el asiento contable de caja?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                                    a3ERPAsiento.Borra(.NUMAPUNTE_CAJA)
                                     Me.bttBuscar_Click(Me.bttBuscar, Nothing)
                                End If
                            End If

                        End With

                    Catch ex As Exception
                        Throw ex
                    Finally
                        a3ERPAsiento.Acabar()
                    End Try

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub fIngresosTienda_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.regkey_Formulario = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name
            My.Computer.Registry.CurrentUser.CreateSubKey(Me.regkey_Formulario)

            'Configuración grillas
            Me.regkey_Cajas = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\Cajas"
            Me.gvIngresos.SaveLayoutToRegistry(regkey_Cajas & "\Default")
            Me.gvIngresos.RestoreLayoutFromRegistry(Me.regkey_Cajas)
            Me.gvIngresos.ActiveFilterString = String.Empty
            Me.gvIngresos.FindFilterText = String.Empty

            Me.bttImportar.Visible = (My.Settings.Usuario.ToLower = "sa")

            'Datos
            Me.DsTiendas.TiposTienda()
            Me.txtEjercicio.EditValue = Today.Year
            Me.txtMes.SelectedIndex = Today.Month - 1
            Me.rgFecha.EditValue = 1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub fIngresosTienda_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            If Me.MdiParent Is Nothing Then
                'Posición y tamaño
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("WindowState", Nothing) Is Nothing Then Me.WindowState = CInt(My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("WindowState", Me.WindowState))
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Left", Nothing) Is Nothing Then Me.Left = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Left", Me.Left)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Top", Nothing) Is Nothing Then Me.Top = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Top", Me.Top)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Width", Nothing) Is Nothing Then Me.Width = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Width", Me.Width)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Height", Nothing) Is Nothing Then Me.Height = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Height", Me.Height)
            End If

            Me.txtCODALM.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

#End Region

#Region "Eventos Dataset"
    Private Sub DsAlbaranVenta_ActualizaDatos() Handles DsTickets.ActualizaDatos
        Me.ActivaMenu(False)
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

        Catch ex As Exception
            MsgBox("Error al buscar la tienda", MsgBoxStyle.Information)
        End Try

    End Sub

#End Region

#Region "Eventos fechas"
    Private Sub rgFecha_EditValueChanged(sender As Object, e As EventArgs) Handles rgFecha.EditValueChanged

        Me.txtMes.Properties.ReadOnly = (CInt(Me.rgFecha.EditValue) <> 3)
        Me.txtEjercicio.Properties.ReadOnly = (CInt(Me.rgFecha.EditValue) <> 3 And CInt(Me.rgFecha.EditValue) <> 5)

        Select Case CInt(Me.rgFecha.EditValue)
            Case 1
                Me.txtFechaInicio.EditValue = Date.Today
                Me.txtFechaFin.EditValue = Date.Today
            Case 2
                Me.txtFechaInicio.EditValue = DateAdd(DateInterval.WeekOfYear, -1, Date.Today)
                Me.txtFechaFin.EditValue = Date.Today
            Case 3
                Me.txtMes.Focus()
                Me.txtMes_EditValueChanged(Nothing, Nothing)
            Case 4
                Me.txtFechaInicio.EditValue = DateAdd(DateInterval.Month, -1, Date.Today)
                Me.txtFechaFin.EditValue = Date.Today
            Case 5
                Me.txtEjercicio.Focus()
                Me.txtEjercicio_EditValueChanged(Nothing, Nothing)
            Case 6
                Me.txtFechaInicio.EditValue = System.DBNull.Value
                Me.txtFechaFin.EditValue = System.DBNull.Value
        End Select

    End Sub

    Private Sub txtMes_EditValueChanged(sender As Object, e As EventArgs) Handles txtMes.EditValueChanged
        Dim Fecha As Date = New Date(CInt(Me.txtEjercicio.EditValue), Me.txtMes.SelectedIndex + 1, 1)
        Me.txtFechaInicio.EditValue = Fecha
        Me.txtFechaFin.EditValue = DateAdd(DateInterval.Month, 1, Fecha).AddDays(-1)
    End Sub

    Private Sub txtEjercicio_EditValueChanged(sender As Object, e As EventArgs) Handles txtEjercicio.EditValueChanged
        Dim Fecha As Date = New Date(CInt(Me.txtEjercicio.EditValue), 1, 1)
        Me.txtFechaInicio.EditValue = Fecha
        Me.txtFechaFin.EditValue = DateAdd(DateInterval.Year, 1, Fecha).AddDays(-1)
        If Not Me.txtMes.Properties.ReadOnly Then Me.txtMes_EditValueChanged(Nothing, Nothing)
    End Sub
#End Region

#Region "txtTipoTienda_ButtonClick"
    Private Sub txtTipoTienda_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtTipoTienda.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Close Then
            Me.txtTipoTienda.EditValue = Nothing
        End If
    End Sub
#End Region

#Region "Opciones menú"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim sql_Where As New System.Text.StringBuilder

            sql_Where.Append("WHERE ALMACEN.IDA_TIPOTIENDA IS NOT NULL ")

            If Me.txtCODALM.EditValue.ToString <> String.Empty Then
                sql_Where.Append(" AND IDA_INGRESOSTIENDAS.CODALM = '" & Me.txtCODALM.EditValue.ToString & "'")
            End If

            If IsDate(Me.txtFechaInicio.EditValue) Then
                sql_Where.Append(" AND IDA_INGRESOSTIENDAS.FECHA >= '" & CDate(Me.txtFechaInicio.EditValue).ToShortDateString & "'")
            End If

            If IsDate(Me.txtFechaFin.EditValue) Then
                sql_Where.Append(" AND IDA_INGRESOSTIENDAS.FECHA <= '" & CDate(Me.txtFechaFin.EditValue).ToShortDateString & "'")
            End If

            If Not Me.txtTipoTienda.EditValue Is Nothing Then
                sql_Where.Append(" AND ALMACEN.IDA_TIPOTIENDA = '" & Me.txtTipoTienda.EditValue & "'")
            End If

            Me.DsTickets.IngresosTienda(sql_Where.ToString)

            'Configurar columnas
            If Me.txtCODALM.EditValue.ToString <> String.Empty Then

                Dim Tienda As New dsTiendas

                Tienda.Cargar(Me.txtCODALM.EditValue)

                If Tienda.TIENDAS.Count > 0 Then
                    With Tienda.TIENDAS(0)

                        If .IsFACTURADIARIANull Then Exit Try

                        If a3ERP.Empresa = a3ERP.FormatoEmpresa.Calavia And .CODALM.Trim = "4" Then .INTEXT = "T"

                        Me.colEFECTIVO.Visible = (.INTEXT = "T")
                        Me.colPROPIA_BASE.Visible = (.INTEXT = "F")
                        Me.colPROPIA_TOTAL.Visible = (.INTEXT = "F")
                        Me.colTIENDA_BASE.Visible = (.INTEXT = "F")
                        Me.colTIENDA_TOTAL.Visible = (.INTEXT = "F")
                        Me.colNUMAPUNTE_CAJA.Visible = (.INTEXT = "T")

                    End With
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub bttImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimir.Click
        Try
            Dim Informe As New DevExpress.XtraPrinting.PrintableComponentLink
            Dim ps As DevExpress.XtraPrinting.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()

            Informe.PageHeaderFooter = Informes.CabeceraInforme("Ingresos tienda", Nothing)

            Informe.Component = Me.dgIngresos

            Informe.PrintingSystem = ps

            Informe.CreateDocument()

            Informes.AbrirVistaPrevia("Ingresos tienda", Informe)

        Catch ex As Exception
            MsgBox("Error al generar el informe", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub bttGuardar_Click(sender As Object, e As EventArgs) Handles bttGuardar.Click
        Try
            Me.dgIngresos.FocusedView.CloseEditor()
            Me.dgIngresos.FocusedView.UpdateCurrentRow()

            Me.DsTickets.Guardar()

            Me.ActivaMenu(True)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttCancelar_Click(sender As Object, e As EventArgs) Handles bttCancelar.Click
        Try
            Me.DsTickets.Cancelar()

            Me.ActivaMenu(True)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

#End Region

#Region "ActivaMenu"
    Private Sub ActivaMenu(activa As Boolean)
        Try
            Me.bttBuscar.Enabled = activa
            Me.bttImprimir.Enabled = activa
            Me.bttGuardar.Enabled = Not activa
            Me.bttCancelar.Enabled = Not activa

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "Eventos grilla"
    Private Sub gvCajas_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvIngresos.FocusedRowChanged
        Try
            Me.colCODALM.OptionsColumn.AllowEdit = Me.gvIngresos.IsNewItemRow(e.FocusedRowHandle)
            Me.colCODALM.OptionsColumn.AllowFocus = Me.gvIngresos.IsNewItemRow(e.FocusedRowHandle)
            Me.colFECHA.OptionsColumn.AllowEdit = Me.gvIngresos.IsNewItemRow(e.FocusedRowHandle)
            Me.colFECHA.OptionsColumn.AllowFocus = Me.gvIngresos.IsNewItemRow(e.FocusedRowHandle)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "bttApunte_ButtonClick"
    Private Sub bttApunte_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bttApunte.ButtonClick
        Try
            With DirectCast(Me.gvIngresos.GetFocusedDataRow, dsTickets.IDA_INGRESOSTIENDASRow)

                If .IsNUMAPUNTENull Then
                    If MsgBox("¿Desea generar el asiento contable del ingreso?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                        Dim CuentaBanco As String = Aydara.SentenciaSQL("SELECT IDA_CTABANCO FROM ALMACEN WHERE CODALM = '" & .CODALM & "'")
                        Dim CuentaEfectivo As String = Aydara.SentenciaSQL("SELECT IDA_CTAEFECTIVO FROM ALMACEN WHERE CODALM = '" & .CODALM & "'")
                        Dim CuentaCliente As String = Aydara.SentenciaSQL("SELECT CUENTA FROM CLIENTES INNER JOIN ALMACEN ON CLIENTES.CODCLI = ALMACEN.IDA_CODCLI WHERE ALMACEN.CODALM = '" & .CODALM & "'")
                        Dim NombreCliente As String = Aydara.SentenciaSQL("SELECT NOMCLI FROM CLIENTES INNER JOIN ALMACEN ON CLIENTES.CODCLI = ALMACEN.IDA_CODCLI WHERE ALMACEN.CODALM = '" & .CODALM & "'")
                        Dim CentroCoste As String = Aydara.SentenciaSQL("SELECT CENTROCOSTE FROM CLIENTES INNER JOIN ALMACEN ON CLIENTES.CODCLI = ALMACEN.IDA_CODCLI WHERE ALMACEN.CODALM = '" & .CODALM & "'")

                        If CuentaBanco = String.Empty Then CuentaBanco = Aydara.SentenciaSQL("SELECT CTABANCOS FROM DATOSCON")
                        If CuentaCliente = String.Empty Or CuentaBanco = String.Empty Then Exit Try

                        Dim a3ERPAsiento As New a3ERPActiveX.Asiento

                        Try
                            a3ERPAsiento.Iniciar()

                            a3ERPAsiento.Nuevo(.FECHA, a3ERP.DatosConfig.TIPOCONT, "N")
                            a3ERPAsiento.AApunte(a3ERP.DatosConfig.CODMON, IIf(CuentaEfectivo <> String.Empty, CuentaEfectivo, CuentaCliente), 0, "INGRESO TDA - " & .CODALM.Trim & " " & NombreCliente, .IMPORTE, CentroCoste, String.Empty)
                            a3ERPAsiento.AApunte(a3ERP.DatosConfig.CODMON, CuentaBanco, .IMPORTE, String.Empty, 0, CentroCoste, String.Empty)
                            .NUMAPUNTE = a3ERPAsiento.Anade()

                            Me.bttGuardar_Click(Me.bttGuardar, Nothing)

                        Catch ex As Exception
                            Throw ex
                        Finally
                            a3ERPAsiento.Acabar()
                        End Try

                    Else
                        Exit Try
                    End If
                End If

                If Not .IsNUMAPUNTENull Then
                    Dim Parametros() As String = {"Accion", "Edicion", "NumApunte", .NUMAPUNTE}
                    Aydara.VerOpcion("EditAsiento", Parametros)
                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

#End Region

#Region "bttApunteCaja_ButtonClick"
    Private Sub bttApunteCaja_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bttApunteCaja.ButtonClick
        Try
            With DirectCast(Me.gvIngresos.GetFocusedDataRow, dsTickets.IDA_INGRESOSTIENDASRow)

                If .IsNUMAPUNTE_CAJANull Then
                    If MsgBox("¿Desea generar el asiento contable de caja?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                        Try
                            Dim NumApunte As Integer = Me.AsientoCobros(.CODALM, .FECHA, .EFECTIVO)

                            If NumApunte > 0 Then
                                .NUMAPUNTE_CAJA = NumApunte
                                Me.bttGuardar_Click(Me.bttGuardar, Nothing)
                            End If

                        Catch ex As Exception
                            Throw ex
                        End Try

                    Else
                        Exit Try
                    End If
                End If

                If Not .IsNUMAPUNTE_CAJANull Then
                    Dim Parametros() As String = {"Accion", "Edicion", "NumApunte", .NUMAPUNTE_CAJA}
                    Aydara.VerOpcion("EditAsiento", Parametros)
                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

#End Region

#Region "AsientoCobros"
    Private Function AsientoCobros(CODALM As String, FECHA As Date, Optional TotalEfectivo As Double = 0) As Decimal

        Dim a3ERPAsiento As New a3ERPActiveX.Asiento
        Dim dsTiendas As New dsTiendas
        Dim Tienda As dsTiendas.TIENDASRow

        Dim dtTotalesCaja As New dsFacturacion.IDA_CAJASDataTable
        Dim taSituacion As New dsFacturacionTableAdapters.IDA_CAJASTableAdapter

        Dim NumAsiento As Integer = 0

        Try
            dsTiendas.Cargar(CODALM)

            If dsTiendas.TIENDAS.Count > 0 Then
                Tienda = dsTiendas.TIENDAS(0)
            Else
                Exit Try
            End If

            If Tienda.FACTURADIARIA = "F" Then
                MsgBox("El tipo de tienda seleccionada no permite realizar asientos contable de caja", MsgBoxStyle.Information, Me.Text)
                Exit Try
            End If

            'Totales caja tienda
            taSituacion.SituacionTotales(dtTotalesCaja, FECHA, FECHA, CODALM)

            If dtTotalesCaja.Count = 0 Then Return 0

            For i As Integer = 0 To dtTotalesCaja.Count - 1
                With dtTotalesCaja(i)

                    Try
                        a3ERPAsiento.Iniciar()

                        Dim CuentaCliente As String = Aydara.SentenciaSQL("SELECT CUENTA FROM CLIENTES INNER JOIN ALMACEN ON CLIENTES.CODCLI = ALMACEN.IDA_CODCLI WHERE ALMACEN.CODALM = '" & .CODALM & "'")
                        Dim CentroCoste As String = Aydara.SentenciaSQL("SELECT CENTROCOSTE FROM CLIENTES INNER JOIN ALMACEN ON CLIENTES.CODCLI = ALMACEN.IDA_CODCLI WHERE ALMACEN.CODALM = '" & .CODALM & "'")
                        Dim VentaTickets As Double = .VENTA - .TOTALBARANES - .TOTFACTURAS

                        a3ERPAsiento.Nuevo(FECHA.ToShortDateString, a3ERP.DatosConfig.TIPOCONT, "N")

                        If a3ERP.Empresa = a3ERP.FormatoEmpresa.Calavia And .CODALM.Trim = "4" Then
                            a3ERPAsiento.AApunte(a3ERP.DatosConfig.CODMON, Tienda.IDA_CTAEFECTIVO, TotalEfectivo, "EFECTIVO " & FECHA.ToShortDateString, 0, CentroCoste, String.Empty)
                            a3ERPAsiento.AApunte(a3ERP.DatosConfig.CODMON, CuentaCliente, 0, "VENTAS " & FECHA.ToShortDateString, TotalEfectivo, CentroCoste, String.Empty)
                            NumAsiento = a3ERPAsiento.Anade()
                            Exit Try
                        End If

                        If (.EFECTIVO + .RETIRADAFONDOS - .ENTRADACAMBIOS) <> 0 Then a3ERPAsiento.AApunte(a3ERP.DatosConfig.CODMON, Tienda.IDA_CTAEFECTIVO, (.EFECTIVO + .RETIRADAFONDOS - .ENTRADACAMBIOS), "EFECTIVO " & FECHA.ToShortDateString, 0, CentroCoste, String.Empty)
                        If .TARJETA <> 0 Then a3ERPAsiento.AApunte(a3ERP.DatosConfig.CODMON, Tienda.IDA_CTATARJETA, .TARJETA, "TARJETAS " & FECHA.ToShortDateString, 0, CentroCoste, String.Empty)
                        If .VALESPROVEEDOR <> 0 Then a3ERPAsiento.AApunte(a3ERP.DatosConfig.CODMON, Tienda.IDA_CTAVALESPROVEEDOR, .VALESPROVEEDOR, "VALES", 0, CentroCoste, String.Empty)
                        If .PENDIENTECOBRO <> 0 Then a3ERPAsiento.AApunte(a3ERP.DatosConfig.CODMON, Tienda.IDA_CTAPENDIENTECOBRO, .PENDIENTECOBRO, "PENDIENTES DE COBRO", 0, CentroCoste, String.Empty)
                        If .COBROSCLIENTE <> 0 Then a3ERPAsiento.AApunte(a3ERP.DatosConfig.CODMON, Tienda.IDA_CTACOBROSCLIENTE, 0, "COBROS DE CLIENTES", .COBROSCLIENTE, CentroCoste, String.Empty)
                        If .VALESEMITIDOS <> 0 Then a3ERPAsiento.AApunte(a3ERP.DatosConfig.CODMON, Tienda.IDA_CTAVALESPROPIOS, 0, "VALES EMITIDOS", .VALESEMITIDOS, CentroCoste, String.Empty)
                        If .VALESCOBRADOS <> 0 Then a3ERPAsiento.AApunte(a3ERP.DatosConfig.CODMON, Tienda.IDA_CTAVALESCOBRADOS, .VALESCOBRADOS, "VALES COBRADOS", 0, CentroCoste, String.Empty)
                        'If .VALESCLIENTE <> 0 Then a3ERPAsiento.AApunte(a3ERP.DatosConfig.CODMON, Tienda.IDA_CTAVALESCLIENTE, .VALESCLIENTE, "VALES CLIENTES", 0, CentroCoste, String.Empty)
                        If .TALON <> 0 Then a3ERPAsiento.AApunte(a3ERP.DatosConfig.CODMON, Tienda.IDA_CTATALON, .TALON, "TALON", 0, CentroCoste, String.Empty)
                        If .ENVASES <> 0 Then a3ERPAsiento.AApunte(a3ERP.DatosConfig.CODMON, Tienda.IDA_CTAABONOENVASES, .ENVASES, "ABONO ENVASES", 0, CentroCoste, String.Empty)
                        If VentaTickets <> 0 Then a3ERPAsiento.AApunte(a3ERP.DatosConfig.CODMON, CuentaCliente, 0, "VENTAS " & FECHA.ToShortDateString, VentaTickets, CentroCoste, String.Empty)

                        NumAsiento = a3ERPAsiento.Anade()

                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
                    Finally
                        a3ERPAsiento.Acabar()
                    End Try

                End With
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

        Return NumAsiento

    End Function
#End Region

#Region "bttImportar_Click"
    Private Sub bttImportar_Click(sender As Object, e As EventArgs) Handles bttImportar.Click
        Try
            Dim BuscaFichero As New OpenFileDialog

            If BuscaFichero.ShowDialog = Windows.Forms.DialogResult.OK Then

                Me.DsTickets.ImportarFicheroCajas(BuscaFichero.FileName)

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