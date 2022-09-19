Public Class ListadoVales

#Region "ListadoVales_Load"
    Private Sub ListadoVales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtTituloListado.EditValue = Me.Text
    End Sub
#End Region

#Region "ListadoVales_Shown"
    Private Sub ListadoVales_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en precios
        Me.maskImporte.Mask.EditMask = "c" & DecimalesImporte
    End Sub
#End Region

#Region "ListadoVales_KeyUp"
    Private Sub ListadoVales_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click

        Dim cmd As New SqlClient.SqlCommand

        Try
            Me.Cursor = Cursors.WaitCursor

            Me.DsValesTienda.VALES_TIENDA.Clear()

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT * FROM VALES_TIENDA"

            'Aplicar filtros
            Dim Filtro As String = String.Empty
            If IsNumeric(Me.txtNumeroInicio.EditValue) Then Filtro = " WHERE CodigoVale>=" & Me.txtNumeroInicio.EditValue
            If IsNumeric(Me.txtNumeroFin.EditValue) Then Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & "CodigoVale<=" & Me.txtNumeroFin.EditValue
            If IsDate(Me.txtFechaInicio.EditValue) Then Filtro = " WHERE FechaVale>='" & Me.txtFechaInicio.EditValue & "'"
            If IsDate(Me.txtFechaFin.EditValue) Then Filtro = " WHERE FechaVale<='" & Me.txtFechaFin.EditValue & "'"

            cmd.CommandText &= Filtro

            Me.DsValesTienda.VALES_TIENDA.Load(cmd.ExecuteReader)

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