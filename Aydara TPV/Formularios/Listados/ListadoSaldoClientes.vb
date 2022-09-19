Public Class ListadoSaldoClientes

#Region "ListadoSaldoClientes_Load"
    Private Sub ListadoSaldoClientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtTituloListado.EditValue = Me.Text
    End Sub
#End Region

#Region "ListadoSaldoClientes_Shown"
    Private Sub ListadoSaldoClientes_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en precios
        Me.maskImporte.Mask.EditMask = "c" & DecimalesImporte
        Me.colImporteTicket.SummaryItem.DisplayFormat = "{0:c" & DecimalesImporte & "}"
        Me.colImporteCobrado.SummaryItem.DisplayFormat = "{0:c" & DecimalesImporte & "}"
        Me.colImportePendiente.SummaryItem.DisplayFormat = "{0:c" & DecimalesImporte & "}"
    End Sub
#End Region

#Region "ListadoSaldoClientes_KeyUp"
    Private Sub ListadoSaldoClientes_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "txtCodigoInicio_ButtonClick"
    Private Sub txtCodigoInicio_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoInicio.ButtonClick
        Try

            Dim dsClientes As New dsClientes, tClientes As New dsClientesTableAdapters.CLIENTESTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("NombreFiscal")
            Columnas.Add("Nombre Fiscal")
            Columnas.Add(0)
            Columnas.Add(0)

            Columnas.Add("Direccion")
            Columnas.Add("Dirección")
            Columnas.Add(0)
            Columnas.Add(0)

            tClientes.Fill(dsClientes.CLIENTES)

            If Buscar(dsClientes, "CLIENTES", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoInicio.EditValue = ResultadoBusqueda
                Me.txtCodigoInicio.IsModified = True
                Me.txtCodigoInicio_Validated(Nothing, Nothing)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoInicio_Validated"
    Private Sub txtCodigoInicio_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoInicio.Validated

        If Not Me.txtCodigoInicio.IsModified Then Exit Sub

        If Not IsNumeric(Me.txtCodigoInicio.EditValue) Then Me.txtNombreInicio.EditValue = String.Empty : Exit Sub

        Me.txtCodigoInicio.EditValue = Format(CType(Me.txtCodigoInicio.EditValue, Integer), "00000000")

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT NombreFiscal FROM CLIENTES WHERE Codigo=" & Me.txtCodigoInicio.EditValue
            Me.txtNombreInicio.EditValue = cmd.ExecuteScalar

        Catch ex As Exception
            MsgBox("Error al mostrar nombre del cliente", MsgBoxStyle.Exclamation)
        End Try

        cmd.Connection.Close()

    End Sub
#End Region

#Region "txtCodigoFin_ButtonClick"
    Private Sub txtCodigoFin_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoFin.ButtonClick
        Try

            Dim dsClientes As New dsClientes, tClientes As New dsClientesTableAdapters.CLIENTESTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("NombreFiscal")
            Columnas.Add("Nombre Fiscal")
            Columnas.Add(0)
            Columnas.Add(0)

            Columnas.Add("Direccion")
            Columnas.Add("Dirección")
            Columnas.Add(0)
            Columnas.Add(0)

            tClientes.Fill(dsClientes.CLIENTES)

            If Buscar(dsClientes, "CLIENTES", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoFin.EditValue = ResultadoBusqueda
                Me.txtCodigoFin.IsModified = True
                Me.txtCodigoFin_Validated(Nothing, Nothing)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoFin_Validated"
    Private Sub txtCodigoFin_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoFin.Validated

        If Not Me.txtCodigoFin.IsModified Then Exit Sub

        If Not IsNumeric(Me.txtCodigoFin.EditValue) Then Me.txtNombreFin.EditValue = String.Empty : Exit Sub

        Me.txtCodigoFin.EditValue = Format(CType(Me.txtCodigoFin.EditValue, Integer), "00000000")

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT NombreFiscal FROM CLIENTES WHERE Codigo=" & Me.txtCodigoFin.EditValue
            Me.txtNombreFin.EditValue = cmd.ExecuteScalar

        Catch ex As Exception
            MsgBox("Error al mostrar nombre del cliente", MsgBoxStyle.Exclamation)
        End Try

        cmd.Connection.Close()

    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click

        Dim cmd As New SqlClient.SqlCommand

        Try
            Me.Cursor = Cursors.WaitCursor

            Me.DsClientes.PENDIENTES_COBRO.Clear()

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            If Me.checkDetallado.Checked Then
                cmd.CommandText = "SELECT *, (ImporteTicket - ImporteCobrado) AS ImportePendiente FROM PENDIENTES_COBRO"
            Else
                cmd.CommandText = "SELECT CodigoCliente, Nombre, '1' AS CodigoTienda, '1' AS CodigoCaja, '1' AS CodigoTicket, '" & Date.Today & "' AS Fecha, " & _
                                  "SUM(ImporteTicket) AS ImporteTicket, SUM(ImporteCobrado) AS ImporteCobrado, SUM(ImporteTicket - ImporteCobrado)AS ImportePendiente FROM PENDIENTES_COBRO"
            End If

            'Aplicar filtros
            Dim Filtro As String = String.Empty
            If IsNumeric(Me.txtCodigoInicio.EditValue) Then Filtro = " WHERE CodigoCliente>=" & Me.txtCodigoInicio.EditValue
            If IsNumeric(Me.txtCodigoFin.EditValue) Then Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & "CodigoCliente<=" & Me.txtCodigoFin.EditValue

            cmd.CommandText &= Filtro

            If Not Me.checkDetallado.Checked Then
                cmd.CommandText &= " GROUP BY CodigoCliente, Nombre"
            End If

            Me.colCodigoCliente.GroupIndex = IIf(Me.checkDetallado.Checked, 0, -1)
            Me.colCodigoTicket.Visible = Me.checkDetallado.Checked
            Me.colFecha.Visible = Me.checkDetallado.Checked

            Me.DsClientes.PENDIENTES_COBRO.Load(cmd.ExecuteReader)

            'Componer grilla
            Me.gvBusqueda.OptionsView.ShowGroupExpandCollapseButtons = Me.checkDetallado.Checked
            Me.gvBusqueda.OptionsPrint.ExpandAllGroups = Me.checkDetallado.Checked
            If Me.checkDetallado.Checked Then Me.gvBusqueda.ExpandAllGroups()

        Catch ex As Exception
            MsgBox("Error al cargar los datos del listado", MsgBoxStyle.Exclamation)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            Me.Cursor = Cursors.Default
        End Try

    End Sub
#End Region

#Region "bttImprimir_Click"
    Private Sub bttImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimir.Click
        Try
            Dim Informe As New DevExpress.XtraPrinting.PrintableComponentLink
            Dim ps As DevExpress.XtraPrinting.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()

            Informe.PaperKind = Printing.PaperKind.A4

            Informe.PageHeaderFooter = Informes.CabeceraInforme(Me.txtTituloListado.EditValue, Nothing)

            Informe.Component = Me.dgBusqueda

            Informe.PrintingSystem = ps

            Informe.CreateDocument()

            Informes.AbrirVistaPrevia(Me.Text, Informe)

        Catch ex As Exception
            MsgBox("Error al generar el informe", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.Close()
    End Sub
#End Region

End Class