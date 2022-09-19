Public Class fIncidencias 

#Region "FormClosing"
    Private Sub fIncidencias_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Not IsNothing(Me.DsIncidencias1.INCIDENCIAS.GetChanges) Then
                If MsgBox("Existen cambios sin guardar. ¿Seguro que desea salir sin guardar los cambios?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , Me.Text)
        End Try
    End Sub
#End Region

#Region "Load"
    Private Sub fIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.DsIncidenciasTipos1.Cargar()
            Me.DsEmpleados1.Cargar()

            Me.txtFechaDesde.EditValue = Date.Today.AddMonths(-1)
            Me.txtFechaHasta.EditValue = Date.Today

            Me.bttBuscarMovimientos_Click(Nothing, Nothing)

        Catch ex As Exception
            MsgBox(ex.Message, , Me.Text)
        End Try
    End Sub
#End Region

#Region "btnAñadir"
    Private Sub btnAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAñadir.Click
        Try
            Dim miform As New fNuevaIncidencia
            If miform.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim mirow As dsIncidencias.INCIDENCIASRow = Me.DsIncidencias1.INCIDENCIAS.NewINCIDENCIASRow
                With mirow
                    .Fecha = miform.dtFecha.Text
                    .OperarioID = miform.cboEmpleado.EditValue
                    .Comentario = miform.txtComentarios.Text

                    If miform.cboES.Text = "Entrada" Then
                        .Cantidad = CType(miform.txtCantidad.Text, Decimal)
                    Else
                        .Cantidad = CType(miform.txtCantidad.Text, Decimal) * -1
                    End If

                    .ArticuloID = miform.IDArticulo
                    .AfectaStock = miform.chkAfectaStock.Checked
                    .PrecioCoste = AGI2005.BaseDatos.ConsultaDevuelveValor("SELECT PrecioCoste FROM ARTICULOS WHERE Id=" & .ArticuloID, AGI2005.BaseDatos.TipoValor.Texto, My.Settings.AydaraTPVConnectionString)
                    .TempArticulo = AGI2005.BaseDatos.ConsultaDevuelveValor("SELECT Descripcion FROM ARTICULOS WHERE Id=" & .ArticuloID, AGI2005.BaseDatos.TipoValor.Texto, My.Settings.AydaraTPVConnectionString)
                    .TempCodigo = AGI2005.BaseDatos.ConsultaDevuelveValor("SELECT Codigo FROM ARTICULOS WHERE Id=" & .ArticuloID, AGI2005.BaseDatos.TipoValor.Texto, My.Settings.AydaraTPVConnectionString)
                    .TempOperario = AGI2005.BaseDatos.ConsultaDevuelveValor("SELECT Nombre FROM OPERARIOS WHERE Codigo=" & .OperarioID, AGI2005.BaseDatos.TipoValor.Texto, My.Settings.AydaraTPVConnectionString)
                    .TipoID = miform.cboTipo.EditValue
                    .TempTipo = AGI2005.BaseDatos.ConsultaDevuelveValor("SELECT Descripcion FROM INCIDENCIAS_TIPOS WHERE IDTipo=" & .TipoID, AGI2005.BaseDatos.TipoValor.Texto, My.Settings.AydaraTPVConnectionString)
                End With

                Me.DsIncidencias1.INCIDENCIAS.AddINCIDENCIASRow(mirow)

                Me.bsIncidencias.ResetBindings(False)

                Me.DsIncidencias1.Actualizar()

                If MsgBox("¿Desea imprimir ticket de la incidencia?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                    Me.ImprimirIncidencia(mirow)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, , Me.Text)
        End Try
    End Sub
#End Region

#Region "btnEliminar"
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If Me.gvIncidencias.FocusedRowHandle >= 0 Then
                If MsgBox("¿Desea eliminar la incidencia seleccionada?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                    Dim Cantidad As Decimal = Me.gvIncidencias.GetFocusedRowCellValue(Me.colCantidad)
                    Me.gvIncidencias.DeleteRow(Me.gvIncidencias.FocusedRowHandle)
                    Me.DsIncidencias1.Actualizar()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , Me.Text)
        End Try
    End Sub
#End Region

#Region "btnCancelar"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, , Me.Text)
        End Try
    End Sub
#End Region

    Private Sub bttImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimir.Click
        Try
            Dim Informe As New DevExpress.XtraPrinting.PrintableComponentLink
            Dim ps As DevExpress.XtraPrinting.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()

            Informe.PaperKind = Printing.PaperKind.A4

            Informe.PageHeaderFooter = Informes.CabeceraInforme(Me.Text, Nothing)

            Informe.Component = Me.dgIncidencias

            Informe.PrintingSystem = ps

            Informe.Landscape = True

            Informe.CreateDocument()

            Informes.AbrirVistaPrevia(Me.Text, Informe)

        Catch ex As Exception
            MsgBox("Error al generar el informe", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ImprimirIncidencia(ByRef miIncidencia As dsIncidencias.INCIDENCIASRow)

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            With miIncidencia
                Dim ticket As String = String.Empty

                ticket &= ActivaExpandido()

                'Datos tienda
                cmd.CommandText = "SELECT * FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
                dr = cmd.ExecuteReader
                If dr.Read Then
                    ticket &= dr("TextoCabecera1")
                    ticket &= DesactivaExpandido()
                    ticket &= vbCrLf & vbCrLf & "FECHA: " & Format(.Fecha, "dd-MM-yyyy")
                    ticket &= " HORA: " & Format(.Fecha, "HH:mm")
                End If
                dr.Close()

                ticket &= vbCrLf & vbCrLf & "INCIDENCIA : " & .TempTipo & vbCrLf

                Dim i As Integer = Len("INCIDENCIA : " & .TempTipo)
                While i > 0
                    ticket &= "="
                    i -= 1
                End While
                ticket &= DesactivaExpandido() & vbCrLf & vbCrLf

                ticket &= "EMPLEADO: " & .TempOperario & vbCrLf
                ticket &= "ARTICULO: " & .TempCodigo & vbCrLf
                ticket &= .TempArticulo & vbCrLf
                ticket &= "CANTIDAD: " & Math.Round(.Cantidad, 2) & vbCrLf

                If .Comentario <> String.Empty Then
                    ticket &= vbCrLf & vbCrLf & .Comentario
                End If

                If ActivaCorteTicket Then ticket += CorteTicket()

                Imprimir.SendStringToPrinter(My.Settings.ImpresoraTickets, ticket)
            End With

        Catch ex As Exception
            Throw ex
        Finally
            cmd.Connection.Close()
        End Try
    End Sub

    Private Sub bttBuscarMovimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscarMovimientos.Click
        Try
            Me.bsIncidencias.Filter = String.Empty

            If Not Me.txtFechaDesde.EditValue Is Nothing Then
                Me.bsIncidencias.Filter &= "Fecha >= '" & Me.txtFechaDesde.EditValue & "'"
            End If

            If Not Me.txtFechaHasta.EditValue Is Nothing Then
                Me.bsIncidencias.Filter &= IIf(Me.bsIncidencias.Filter <> String.Empty, " AND ", "") & "Fecha <= '" & CDate(Me.txtFechaHasta.EditValue).AddDays(1).AddMinutes(-1) & "'"
            End If

            Me.DsIncidencias1.Cargar()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttPendiente_Click(sender As Object, e As EventArgs) Handles bttPendiente.Click
        Try
            If MsgBox("¿Marcar incidencias seleccionadas para volver a enviar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then Exit Try

            For i As Integer = 0 To Me.gvIncidencias.SelectedRowsCount - 1
                With CType(Me.gvIncidencias.GetDataRow(Me.gvIncidencias.GetSelectedRows()(i)), dsIncidencias.INCIDENCIASRow)
                    .SetFechaCierreNull()
                End With
            Next

            Me.DsIncidencias1.Guardar()

            MsgBox("Proceso completo." & vbCrLf & "Las incidencias serán enviadas con el cierre de tienda.", MsgBoxStyle.Information, Me.Text)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

End Class