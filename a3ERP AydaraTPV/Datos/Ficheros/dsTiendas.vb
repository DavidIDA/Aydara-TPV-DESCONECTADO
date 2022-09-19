Partial Class dsTiendas

    Public Sub Cargar(Optional CODALM As String = "")
        Try
            Dim taTiendas As New dsTiendasTableAdapters.TIENDASTableAdapter

            If CODALM <> String.Empty Then
                taTiendas.FillBy(Me.TIENDAS, CODALM)
            Else
                taTiendas.Fill(Me.TIENDAS)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub TiposTienda()
        Try
            Dim taTipos As New dsTiendasTableAdapters.IDA_TIPOSTIENDATableAdapter

            taTipos.Fill(Me.IDA_TIPOSTIENDA)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CierreTienda(CODALM As String, CODCLI As String, TARIFA As String, SERIE As String)
        Try
            Aydara.Estado("Calculando existencia actual")

            Dim Stock As New dsAlmacenes

            Stock.StockActual(CODALM)

            Dim Lineas As DataRow() = Stock.STOCKALM.Select("UNIDADES <> 0")

            If Lineas.Length > 0 Then

                Dim a3ERPFactura As New a3ERPActiveX.Factura

                Try
                    a3ERP.fWaitForm.SetCaption("Creando factura de venta")

                    a3ERPFactura.Iniciar()
                    a3ERPFactura.OmitirMensajes = True
                    a3ERPFactura.ActivarAlarmaCab = False
                    a3ERPFactura.ActivarAlarmaLin = False

                    a3ERPFactura.Nuevo(Date.Today.ToShortDateString, CODCLI, False, False, True, True)
                    a3ERPFactura.AsStringCab("CODALM") = CODALM
                    a3ERPFactura.AsStringCab("SERIE") = SERIE
                    a3ERPFactura.AsStringCab("TARIFA") = TARIFA

                    a3ERPFactura.AsStringCab("IVAINCLUIDO") = Aydara.SentenciaSQL("SELECT ISNULL(IDA_IVAINCLUIDO,'F') FROM TARIFAS WHERE TARIFA = '" & a3ERPFactura.AsStringCab("TARIFA") & "'")

                    For i As Integer = 0 To Lineas.Length - 1
                        With DirectCast(Lineas(i), dsAlmacenes.STOCKALMRow)
                            Try
                                a3ERP.fWaitForm.SetCaption("Añadiendo artículo " & i + 1 & " de " & Lineas.Length)

                                a3ERPFactura.NuevaLinea()
                                a3ERPFactura.AsStringLin("CODART") = .CODART
                                a3ERPFactura.AsFloatLin("UNIDADES") = .UNIDADES

                                'Datos trazabilidad
                                If Aydara.SentenciaSQL("SELECT HAYLOTES FROM ARTICULO WHERE CODART = '" & a3ERPFactura.AsStringLin("CODART") & "'") = "T" Then
                                    a3ERPFactura.AnadirDetalle(.UNIDADES, String.Empty, IIf(.LOTE <> String.Empty, .LOTE, "TIENDA"), String.Empty, String.Empty)
                                End If

                                a3ERPFactura.AnadirLinea()

                            Catch ex As Exception
                                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                            End Try
                        End With
                    Next

                    a3ERP.fWaitForm.SetCaption("Guardando factura")
                    a3ERPFactura.Anade()

                Catch ex As Exception
                    Throw ex
                Finally
                    a3ERPFactura.Acabar()
                End Try

            End If

        Catch ex As Exception
            Throw ex
        Finally
            Aydara.Estado()
        End Try
    End Sub

    Public Sub AbonarExistencias(CODALM As String, CODCLI As String, TARIFA As String, SERIE As String, FECHASTOCK As Date)
        Try
            Aydara.Estado("Calculando existencia a fecha " & FECHASTOCK.ToShortDateString)

            Dim Stock As New dsAlmacenes

            Stock.StockAlmacenDia(CODALM, FECHASTOCK)

            Dim Lineas As DataRow() = Stock.STOCK_ALMACEN_DIA.Select("UNIDADES <> 0")

            If Lineas.Length > 0 Then

                Dim a3ERPFactura As New a3ERPActiveX.Factura

                Try
                    a3ERP.fWaitForm.SetCaption("Creando factura de venta")

                    a3ERPFactura.Iniciar()
                    a3ERPFactura.OmitirMensajes = True
                    a3ERPFactura.ActivarAlarmaCab = False
                    a3ERPFactura.ActivarAlarmaLin = False

                    a3ERPFactura.Nuevo(Date.Today.ToShortDateString, CODCLI, False, True, True, True)
                    a3ERPFactura.AsStringCab("CODALM") = CODALM
                    a3ERPFactura.AsStringCab("SERIE") = SERIE
                    a3ERPFactura.AsStringCab("TARIFA") = TARIFA

                    a3ERPFactura.AsStringCab("IVAINCLUIDO") = Aydara.SentenciaSQL("SELECT ISNULL(IDA_IVAINCLUIDO,'F') FROM TARIFAS WHERE TARIFA = '" & a3ERPFactura.AsStringCab("TARIFA") & "'")

                    For i As Integer = 0 To Lineas.Length - 1
                        With DirectCast(Lineas(i), dsAlmacenes.STOCK_ALMACEN_DIARow)
                            Try
                                a3ERP.fWaitForm.SetCaption("Añadiendo artículo " & i + 1 & " de " & Lineas.Length)

                                a3ERPFactura.NuevaLinea()
                                a3ERPFactura.AsStringLin("DESCLIN") = .ARTICULO_DESCART
                                a3ERPFactura.AsStringLin("TIPIVA") = .ARTICULO_TIPIVA
                                If a3ERPFactura.AsStringCab("IVAINCLUIDO") = "T" Then
                                    a3ERPFactura.AsFloatLin("PRCMONEDAMASIVA") = .UNIDADES * Aydara.ObtPrecioTarifa(TARIFA, .CODART) * -1
                                Else
                                    a3ERPFactura.AsFloatLin("PRCMONEDA") = .UNIDADES * Aydara.ObtPrecioTarifa(TARIFA, .CODART) * -1
                                End If
                                a3ERPFactura.AsStringLin("PARAM1") = .CODART
                                a3ERPFactura.AsFloatLin("PARAM2") = Math.Round(.UNIDADES, a3ERP.DatosConfig.NUMDECUNI, MidpointRounding.AwayFromZero)

                                a3ERPFactura.AnadirLinea()

                            Catch ex As Exception
                                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                            End Try
                        End With
                    Next

                    a3ERP.fWaitForm.SetCaption("Guardando factura")
                    a3ERPFactura.Anade()

                Catch ex As Exception
                    Throw ex
                Finally
                    a3ERPFactura.Acabar()
                End Try

            End If

        Catch ex As Exception
            Throw ex
        Finally
            Aydara.Estado()
        End Try
    End Sub

    Public Sub TraspasarExistencias(CODALM As String)
        Try
            Aydara.Estado("Calculando existencia actual")

            Dim Stock As New dsAlmacenes

            Stock.StockActual(CODALM)

            Dim Lineas As DataRow() = Stock.STOCKALM.Select("UNIDADES <> 0")

            If Lineas.Length > 0 Then

                Dim a3ERPTraspaso As New a3ERPActiveX.Traspaso

                Try
                    a3ERP.fWaitForm.SetCaption("Creando traspaso entre almacenes")

                    a3ERPTraspaso.Iniciar()
                    a3ERPTraspaso.OmitirMensajes = True

                    a3ERPTraspaso.Nuevo(Date.Today.ToShortDateString, CODALM, a3ERP.DatosConfig.CODALM)

                    For i As Integer = 0 To Lineas.Length - 1
                        With DirectCast(Lineas(i), dsAlmacenes.STOCKALMRow)
                            Try
                                a3ERP.fWaitForm.SetCaption("Añadiendo artículo " & i + 1 & " de " & Lineas.Length)

                                a3ERPTraspaso.NuevaLineaArt(.CODART, .UNIDADES)
                                a3ERPTraspaso.AnadirLinea()

                            Catch ex As Exception
                                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                            End Try
                        End With
                    Next

                    a3ERP.fWaitForm.SetCaption("Guardando traspaso")
                    a3ERPTraspaso.Anade()

                Catch ex As Exception
                    Throw ex
                Finally
                    a3ERPTraspaso.Acabar()
                End Try

            End If

        Catch ex As Exception
            Throw ex
        Finally
            Aydara.Estado()
        End Try
    End Sub

End Class
