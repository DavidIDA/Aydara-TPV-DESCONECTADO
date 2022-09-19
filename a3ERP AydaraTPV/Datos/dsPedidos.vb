Partial Class dsPedidos

    Public Sub Cargar(IDPED As Integer, DeCompra As Boolean)
        Try
            Dim taPedido As New dsPedidosTableAdapters.LINEPEDITableAdapter

            If DeCompra Then
                taPedido.FillC(Me.LINEPEDI, IDPED)
            Else
                taPedido.FillV(Me.LINEPEDI, IDPED)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Traspaso() As Integer

        Dim Lineas As DataRow() = Me.LINEPEDI.Select("UNISERVIDA > 0")
        If Lineas.Length = 0 Then Return 0

        Aydara.Estado("Generando traspaso a tienda")

        Dim a3ERP_Traspaso As New a3ERPActiveX.Traspaso

        Try
            a3ERP_Traspaso.Iniciar()
            a3ERP_Traspaso.Nuevo(Date.Today.ToShortDateString, "1", "2")
            a3ERP_Traspaso.AsStringCab("MOTIVO") = "Pedido tienda"

            For i As Integer = 0 To Lineas.Length - 1
                With CType(Lineas(i), dsPedidos.LINEPEDIRow)
                    a3ERP_Traspaso.NuevaLineaArt(.CODART, .UNISERVIDA)
                End With
            Next

            Return a3ERP_Traspaso.Anade

        Catch ex As Exception
            Throw ex
        Finally
            a3ERP_Traspaso.Acabar()
            Aydara.Estado()
        End Try
    End Function

    Public Sub AnulaPedido(IDPED As Integer, DeCompra As Boolean)

        Aydara.Estado("Anulando pedido tienda")

        Dim a3ERP_Albaran As New a3ERPActiveX.Albaran
        Dim CODCLIPRO As String

        If DeCompra Then
            CODCLIPRO = Aydara.SentenciaSQL("SELECT CODPRO FROM CABEPEDC WHERE IDPEDC = " & IDPED)
        Else
            CODCLIPRO = Aydara.SentenciaSQL("SELECT CODCLI FROM CABEPEDV WHERE IDPEDV = " & IDPED)
        End If

        Try
            a3ERP_Albaran.Iniciar()
            a3ERP_Albaran.OmitirMensajes = True
            a3ERP_Albaran.ActivarAlarmaCab = False
            a3ERP_Albaran.ActivarAlarmaLin = False
            a3ERP_Albaran.Nuevo(Date.Today.ToShortDateString, CODCLIPRO, DeCompra)
            a3ERP_Albaran.IniciarServir("P", IDPED, False)

            For i As Integer = 0 To Me.LINEPEDI.Count - 1
                With Me.LINEPEDI(i)
                    a3ERP_Albaran.AnularLinea(.NUMLINPED, .BULTOS, .PAQUETES, .UNIDADES)
                End With
            Next

            a3ERP_Albaran.FinServir()
            a3ERP_Albaran.Anade()

        Catch ex As Exception
            Throw ex
        Finally
            a3ERP_Albaran.Acabar()
            Aydara.Estado()
        End Try
    End Sub

End Class