Partial Class dsTPVLog

    Dim taLog As New dsTPVLogTableAdapters.IDA_LOGTIENDASTableAdapter

    Public Event ActualizaEstado(Texto As String)

    Public Sub onActualizaEstado(Optional Texto As String = "")
        RaiseEvent ActualizaEstado(Texto)
    End Sub

    Public Sub Cargar(filtro As String)
        Try
            Me.onActualizaEstado("Cargando log de comunicaciones...")

            taLog.daLog.SelectCommand.CommandText = "SELECT * FROM IDA_LOGTIENDAS " & _
                                                    "LEFT JOIN ALMACEN ON IDA_LOGTIENDAS.CODALM = ALMACEN.CODALM " & _
                                                    filtro

            taLog.Fill(Me.IDA_LOGTIENDAS)

        Catch ex As Exception
            Throw ex
        Finally
            Me.onActualizaEstado()
        End Try
    End Sub

    Public Sub Nuevo(ESTADO As String, DESCRIPCION As String, Optional CODALM As String = "")
        Try
            Dim rLog As dsTPVLog.IDA_LOGTIENDASRow

            rLog = Me.IDA_LOGTIENDAS.NewIDA_LOGTIENDASRow
            With rLog
                .FECHA = Date.Now
                .ESTADO = ESTADO
                .DESCRIPCION = Mid(DESCRIPCION, 1, 250)
                If CODALM <> String.Empty Then .CODALM = CODALM
            End With
            Me.IDA_LOGTIENDAS.AddIDA_LOGTIENDASRow(rLog)

            taLog.Update(Me.IDA_LOGTIENDAS)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class

Namespace dsTPVLogTableAdapters
    Partial Public Class IDA_LOGTIENDASTableAdapter
        Public ReadOnly Property daLog() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
    End Class
End Namespace
