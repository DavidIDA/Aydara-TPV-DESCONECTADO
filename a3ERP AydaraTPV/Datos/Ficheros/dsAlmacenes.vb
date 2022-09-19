Partial Class dsAlmacenes

    Public Sub Cargar(Optional CODALM As String = "")
        Try
            Dim taAlmacenes As New dsAlmacenesTableAdapters.ALMACENTableAdapter

            If CODALM <> String.Empty Then
                taAlmacenes.FillBy(Me.ALMACEN, CODALM)
            Else
                taAlmacenes.Fill(Me.ALMACEN)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargarUbicaciones(Optional CODALM As String = "")
        Try
            Dim taUbicaciones As New dsAlmacenesTableAdapters.__UBICACIONESALMACENTableAdapter

            If CODALM <> String.Empty Then
                taUbicaciones.FillBy(Me.__UBICACIONESALMACEN, CODALM)
            Else
                taUbicaciones.Fill(Me.__UBICACIONESALMACEN)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub StockActual(CODALM As String)
        Try
            Dim taStock As New dsAlmacenesTableAdapters.STOCKALMTableAdapter

            taStock.FillBy(Me.STOCKALM, CODALM)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub StockAlmacenDia(CODALM As String, FECHA As Date)
        Try
            Dim taStock As New dsAlmacenesTableAdapters.STOCK_ALMACEN_DIATableAdapter
            taStock.daStock.SelectCommand.CommandTimeout = 600000
            taStock.StockAlmacen(Me.STOCK_ALMACEN_DIA, CODALM, FECHA)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function StockDiaArticulo(CODALM As String, FECHA As Date, CODART As String) As Double
        Try
            Dim taStock As New dsAlmacenesTableAdapters.STOCK_ALMACEN_DIATableAdapter

            taStock.StockArticulo(Me.STOCK_ALMACEN_DIA, CODALM, FECHA, CODART)

            If Me.STOCK_ALMACEN_DIA.Count > 0 Then
                Return Me.STOCK_ALMACEN_DIA(0).UNIDADES
            Else
                Return 0
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class

Namespace dsAlmacenesTableAdapters
    Partial Public Class STOCK_ALMACEN_DIATableAdapter
        Public ReadOnly Property daStock() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
    End Class

End Namespace
