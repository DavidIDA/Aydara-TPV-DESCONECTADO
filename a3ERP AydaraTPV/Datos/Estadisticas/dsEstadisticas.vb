Partial Class dsEstadisticas

    Dim taVentas As New dsEstadisticasTableAdapters.VENTASTableAdapter
    Dim taDetalle As New dsEstadisticasTableAdapters.DETALLE_VENTASTableAdapter

    Dim _EJERCICIO As Integer, _MES As Integer
    Dim _CODCLI As String, _CODREP As String, _RUTA As String, _CODALM As String, _CODART As String, _CODFAM As String, _CODPRO As String

    Dim _VENTA_CREDITO As Double, _VENTA_CONTADO As Double, _VENTA_TOTAL As Double
    Dim _COSTE_CREDITO As Double, _COSTE_CONTADO As Double, _COSTE_TOTAL As Double
    Dim _RENT_CREDITO As Double, _RENT_CONTADO As Double, _RENT_TOTAL As Double
    Dim _COMPRA As Double

#Region "Properties"
    Property EJERCICIO As Integer
        Get
            Return Me._EJERCICIO
        End Get
        Set(value As Integer)
            Me._EJERCICIO = value
        End Set
    End Property
    Property MES As Integer
        Get
            Return Me._MES
        End Get
        Set(value As Integer)
            Me._MES = value
        End Set
    End Property
    Property CODCLI As String
        Get
            Return Me._CODCLI
        End Get
        Set(value As String)
            Me._CODCLI = value
        End Set
    End Property

    Property CODREP As String
        Get
            Return Me._CODREP
        End Get
        Set(value As String)
            Me._CODREP = value
        End Set
    End Property

    Property RUTA As String
        Get
            Return Me._RUTA
        End Get
        Set(value As String)
            Me._RUTA = value
        End Set
    End Property

    Property CODALM As String
        Get
            Return Me._CODALM
        End Get
        Set(value As String)
            Me._CODALM = value
        End Set
    End Property

    Property CODART As String
        Get
            Return Me._CODART
        End Get
        Set(value As String)
            Me._CODART = value
        End Set
    End Property

    Property CODFAM As String
        Get
            Return Me._CODFAM
        End Get
        Set(value As String)
            Me._CODFAM = value
        End Set
    End Property

    Property CODPRO As String
        Get
            Return Me._CODPRO
        End Get
        Set(value As String)
            Me._CODPRO = value
        End Set
    End Property

    Property VENTA_CREDITO As Double
        Get
            Return Me._VENTA_CREDITO
        End Get
        Set(value As Double)
            Me._VENTA_CREDITO = value
        End Set
    End Property

    Property VENTA_CONTADO As Double
        Get
            Return Me._VENTA_CONTADO
        End Get
        Set(value As Double)
            Me._VENTA_CONTADO = value
        End Set
    End Property

    Property VENTA_TOTAL As Double
        Get
            Return Me._VENTA_TOTAL
        End Get
        Set(value As Double)
            Me._VENTA_TOTAL = value
        End Set
    End Property

    Property COSTE_CREDITO As Double
        Get
            Return Me._COSTE_CREDITO
        End Get
        Set(value As Double)
            Me._COSTE_CREDITO = value
        End Set
    End Property

    Property COSTE_CONTADO As Double
        Get
            Return Me._COSTE_CONTADO
        End Get
        Set(value As Double)
            Me._COSTE_CONTADO = value
        End Set
    End Property

    Property COSTE_TOTAL As Double
        Get
            Return Me._COSTE_TOTAL
        End Get
        Set(value As Double)
            Me._COSTE_TOTAL = value
        End Set
    End Property

    Property RENT_CREDITO As Double
        Get
            Return Me._RENT_CREDITO
        End Get
        Set(value As Double)
            Me._RENT_CREDITO = value
        End Set
    End Property

    Property RENT_CONTADO As Double
        Get
            Return Me._RENT_CONTADO
        End Get
        Set(value As Double)
            Me._RENT_CONTADO = value
        End Set
    End Property

    Property RENT_TOTAL As Double
        Get
            Return Me._RENT_TOTAL
        End Get
        Set(value As Double)
            Me._RENT_TOTAL = value
        End Set
    End Property

    Property COMPRA As Double
        Get
            Return Me._COMPRA
        End Get
        Set(value As Double)
            Me._COMPRA = value
        End Set
    End Property

#End Region

#Region "Funciones"
    Public Sub TotalVentas()
        Try
            Aydara.Estado("Calculando ventas")

            If Me.CODPRO <> String.Empty Then
                Me.taVentas.Proveedor(Me.VENTAS, Me.CODPRO)
            ElseIf Me.CODCLI <> String.Empty Then
                Me.taVentas.Cliente(Me.VENTAS, Me.CODCLI)
            ElseIf Me.CODREP <> String.Empty Then
                Me.taVentas.Representante(Me.VENTAS, Me.CODREP)
            ElseIf Me.RUTA <> String.Empty Then
                Me.taVentas.Ruta(Me.VENTAS, Me.RUTA)
            ElseIf Me.CODART <> String.Empty Then
                If a3ERP.Empresa = a3ERP.FormatoEmpresa.Molina Then
                    Me.taVentas.ArtículoAMM(Me.VENTAS, Me.CODART, Me.CODALM)
                Else
                    Me.taVentas.Artículo(Me.VENTAS, Me.CODART, Me.CODALM)
                End If
            ElseIf Me.CODFAM <> String.Empty Then
                If a3ERP.Empresa = a3ERP.FormatoEmpresa.Molina Then
                    Me.taVentas.FamiliaAMM(Me.VENTAS, Me.CODALM, Me.CODFAM)
                Else
                    Me.taVentas.Familia(Me.VENTAS, Me.CODALM, Me.CODFAM)
                End If
            ElseIf Me.CODALM <> String.Empty Then
                Me.taVentas.Almacen(Me.VENTAS, Me.CODALM)
            Else
                Me.Clear()
            End If

            a3ERP.fWaitForm.SetCaption("Calculando rentabilidad")

            Me.VENTA_CONTADO = 0 : Me.VENTA_CREDITO = 0 : Me.VENTA_TOTAL = 0
            Me.COSTE_CONTADO = 0 : Me.COSTE_CREDITO = 0 : Me.COSTE_TOTAL = 0
            Me.RENT_CONTADO = 0 : Me.RENT_CREDITO = 0 : Me.RENT_TOTAL = 0

            For i As Integer = 0 To Me.VENTAS.Count - 1
                With Me.VENTAS(i)

                    If .COSTE_CONTADO <> 0 Then .RENT_CONTADO = (.VENTA_CONTADO - .COSTE_CONTADO) / .COSTE_CONTADO Else .RENT_CONTADO = 1
                    If .COSTE_CREDITO <> 0 Then .RENT_CREDITO = (.VENTA_CREDITO - .COSTE_CREDITO) / .COSTE_CREDITO Else .RENT_CREDITO = 1
                    If .COSTE_TOTAL <> 0 Then .RENT_TOTAL = (.VENTA_TOTAL - .COSTE_TOTAL) / .COSTE_TOTAL Else .RENT_TOTAL = 1

                    'Totales ejercicio
                    If .EJERCICIO = Me.EJERCICIO Then

                        Me.VENTA_CONTADO += .VENTA_CONTADO
                        Me.VENTA_CREDITO += .VENTA_CREDITO
                        Me.VENTA_TOTAL += .VENTA_TOTAL

                        Me.COSTE_CONTADO += .COSTE_CONTADO
                        Me.COSTE_CREDITO += .COSTE_CREDITO
                        Me.COSTE_TOTAL += .COSTE_TOTAL

                        Me.COMPRA += .COMPRA

                    End If

                End With
            Next

            If Me.COSTE_CONTADO <> 0 Then Me.RENT_CONTADO = (Me.VENTA_CONTADO - Me.COSTE_CONTADO) / Me.COSTE_CONTADO Else Me.RENT_CONTADO = 1
            If Me.COSTE_CREDITO <> 0 Then Me.RENT_CREDITO = (Me.VENTA_CREDITO - Me.COSTE_CREDITO) / Me.COSTE_CREDITO Else Me.RENT_CREDITO = 1
            If Me.COSTE_TOTAL <> 0 Then Me.RENT_TOTAL = (Me.VENTA_TOTAL - Me.COSTE_TOTAL) / Me.COSTE_TOTAL Else Me.RENT_TOTAL = 1

            'Meses
            For i As Integer = 1 To 12

                Dim DatosMes As DataRow() = Me.VENTAS.Select("EJERCICIO = " & Me.EJERCICIO & " AND MES = " & i)
                Dim rMes As dsEstadisticas.VENTASRow

                If DatosMes.Length = 0 Then
                    rMes = Me.VENTAS.NewVENTASRow
                    rMes.EJERCICIO = Me.EJERCICIO
                    rMes.MES = i
                    Me.VENTAS.AddVENTASRow(rMes)
                Else
                    rMes = DatosMes(0)
                End If

                rMes.NOMBRE_MES = StrConv(MonthName(rMes.MES), VbStrConv.ProperCase)

            Next

        Catch ex As Exception
            Throw ex
        Finally
            Aydara.Estado()
        End Try
    End Sub

    Public Sub DetalleVentas()
        Try
            If Me.CODPRO <> String.Empty Then
                Me.taDetalle.Proveedor(Me.DETALLE_VENTAS, Me.EJERCICIO, Me.MES, Me.CODPRO)
            ElseIf Me.CODCLI <> String.Empty Then
                Me.taDetalle.Cliente(Me.DETALLE_VENTAS, Me.EJERCICIO, Me.MES, Me.CODCLI)
            ElseIf Me.CODREP <> String.Empty Then
                Me.taDetalle.Representante(Me.DETALLE_VENTAS, Me.EJERCICIO, Me.MES, Me.CODREP)
            ElseIf Me.RUTA <> String.Empty Then
                Me.taDetalle.Ruta(Me.DETALLE_VENTAS, Me.EJERCICIO, Me.MES, Me.RUTA)
            ElseIf Me.CODART <> String.Empty Then
                If a3ERP.Empresa = a3ERP.FormatoEmpresa.Molina Then
                    Me.taDetalle.ArtículoAMM(Me.DETALLE_VENTAS, Me.EJERCICIO, Me.MES, Me.CODART, Me.CODALM)
                Else
                    Me.taDetalle.Artículo(Me.DETALLE_VENTAS, Me.EJERCICIO, Me.MES, Me.CODART, Me.CODALM)
                End If
            ElseIf Me.CODFAM <> String.Empty Then
                If a3ERP.Empresa = a3ERP.FormatoEmpresa.Molina Then
                    Me.taDetalle.FamiliaAMM(Me.DETALLE_VENTAS, Me.EJERCICIO, Me.MES, Me.CODALM, Me.CODFAM)
                Else
                    Me.taDetalle.Familia(Me.DETALLE_VENTAS, Me.EJERCICIO, Me.MES, Me.CODALM, Me.CODFAM)
                End If
            ElseIf Me.CODALM <> String.Empty Then
                Me.taDetalle.Almacen(Me.DETALLE_VENTAS, Me.EJERCICIO, Me.MES, Me.CODALM)
            Else
                Me.Clear()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class
