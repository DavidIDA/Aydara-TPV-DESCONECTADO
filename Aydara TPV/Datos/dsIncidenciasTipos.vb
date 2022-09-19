Partial Class dsIncidenciasTipos

    Dim taTipos As New dsIncidenciasTiposTableAdapters.INCIDENCIAS_TIPOSTableAdapter

#Region "Cargar"
    Public Sub Cargar()
        Try
            Me.taTipos.Fill(Me.INCIDENCIAS_TIPOS)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

End Class
