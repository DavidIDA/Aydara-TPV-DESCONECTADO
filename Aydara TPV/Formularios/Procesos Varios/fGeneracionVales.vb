Public Class fGeneracionVales 

    Private Sub fGeneracionVales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.txtPorcentaje.Text = 0
            Me.txtNumVale.Text = AGI2005.BaseDatos.ConsultaDevuelveValor("SELECT NumeroVale FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda, AGI2005.BaseDatos.TipoValor.Entero, My.Settings.AydaraTPVConnectionString) + 1
        Catch ex As Exception
            MsgBox(ex.Message, , Me.Text)
        End Try
    End Sub

    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click
        Try
            Dim miDs As New dsHistorico
            Dim ClienteDesde As Integer = -1
            Dim ClienteHasta As Integer = -1

            If IsNumeric(Me.txtNumeroInicio.EditValue) Then
                ClienteDesde = Me.txtNumeroInicio.EditValue
            End If

            If IsNumeric(Me.txtNumeroFin.EditValue) Then
                ClienteHasta = Me.txtNumeroFin.EditValue
            End If

            Me.DsValesTienda1.Clear()

            If miDs.CargarTotales(Me.txtFechaInicio.EditValue, Me.txtFechaFin.EditValue, ClienteDesde, ClienteHasta) > 0 Then
                miDs.GenerarVales(Me.DsValesTienda1, Me.txtPorcentaje.EditValue, Me.txtNumVale.EditValue, Me.txtFechaCaducidad.EditValue)
            Else
                MsgBox("No hay datos para el filtro introducido", , Me.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , Me.Text)
        End Try
    End Sub

    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.Close()
    End Sub

    Private Sub bttGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttGuardar.Click
        Try
            Dim VistaSeleccion As DevExpress.XtraGrid.Views.Grid.GridView = Me.dgVales.FocusedView
            VistaSeleccion.CloseEditor()
            VistaSeleccion.UpdateCurrentRow()

            If MsgBox("Se generarán " & Me.DsValesTienda1.VALES_TIENDA.Count & " vales de cliente, y saldrán todos por impresora." & vbCrLf & "¿Desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                Me.DsValesTienda1.Actualizar()

                Dim UltimoNum As Integer = Me.DsValesTienda1.DameUltimoVale
                If UltimoNum <> -1 Then
                    AGI2005.BaseDatos.ConsultaNonQuery("UPDATE TIENDAS SET NumeroVale=" & UltimoNum & " WHERE CodigoTienda=" & CodigoTienda, My.Settings.AydaraTPVConnectionString)
                End If

                'For i As Integer = 0 To Me.DsValesTienda1.VALES_TIENDA.Count - 1
                '    Me.ImprimirVale(Me.DsValesTienda1.VALES_TIENDA(i))
                'Next

                Me.txtNumVale.Text = AGI2005.BaseDatos.ConsultaDevuelveValor("SELECT NumeroVale FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda, AGI2005.BaseDatos.TipoValor.Entero, My.Settings.AydaraTPVConnectionString) + 1
                Me.DsValesTienda1.Clear()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, , Me.Text)
        End Try
    End Sub


    Private Sub ImprimirVale(ByRef miVale As dsValesTienda.VALES_TIENDARow)

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            With miVale
                Dim ticket As String = String.Empty

                ticket &= ActivaExpandido()

                'Datos tienda
                cmd.CommandText = "SELECT * FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
                dr = cmd.ExecuteReader
                If dr.Read Then
                    ticket &= dr("TextoCabecera1")
                    ticket &= DesactivaExpandido()
                    ticket &= vbCrLf & vbCrLf & "FECHA: " & Format(.FechaVale, "dd-MM-yyyy")
                End If
                dr.Close()

                ticket &= vbCrLf & vbCrLf & "NUM. VALE : " & .CodigoVale & vbCrLf

                Dim i As Integer = Len("NUM. VALE : " & .CodigoVale)
                While i > 0
                    ticket &= "="
                    i -= 1
                End While
                ticket &= DesactivaExpandido() & vbCrLf & vbCrLf

                ticket &= "VALE DE COMPRA A FAVOR DE:" & vbCrLf
                ticket &= .Nombre & vbCrLf
                ticket &= "EN CONCEPTO DE:" & vbCrLf
                ticket &= .Concepto & vbCrLf
                ticket &= "POR IMPORTE DE: " & Math.Round(.Importe, DecimalesImporte, MidpointRounding.AwayFromZero) & " euros"

                If IsDate(Me.txtFechaCaducidad.EditValue) Then
                    ticket &= vbCrLf & vbCrLf & "VALIDO HASTA " & CDate(Me.txtFechaCaducidad.EditValue).ToString("dd-MM-yyyy")
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

End Class