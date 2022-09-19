Partial Class dsSeleccion

    Enum Fichero
        Artículos
        Clientes
        Proveedores
    End Enum

    Dim _Filtro As String = String.Empty

    Property Filtro As String
        Get
            Return Me._Filtro
        End Get
        Set(value As String)
            Me._Filtro = value
        End Set
    End Property

    Public Function Seleccionar(Fichero As Fichero) As String
        Try
            Dim DataTable As DataTable = Nothing
            Dim CampoDevuelto As String = String.Empty

            Select Case Fichero
                Case dsSeleccion.Fichero.Artículos
                    Dim taSeleccion As New dsSeleccionTableAdapters.ARTICULOSTableAdapter
                    taSeleccion.Fill(Me.ARTICULOS)
                    DataTable = Me.ARTICULOS
                    CampoDevuelto = Me.ARTICULOS.CODARTColumn.ColumnName

                Case dsSeleccion.Fichero.Clientes
                    Dim taSeleccion As New dsSeleccionTableAdapters.CLIENTESTableAdapter
                    taSeleccion.Fill(Me.CLIENTES)
                    DataTable = Me.CLIENTES
                    CampoDevuelto = Me.CLIENTES.CODCLIColumn.ColumnName

                Case dsSeleccion.Fichero.Proveedores
                    'Dim taSeleccion As New dsSeleccionTableAdapters.PROVEEDORESTableAdapter
                    'taSeleccion.Fill(Me.PROVEEDORES)
                    'DataTable = Me.PROVEEDORES
                    'CampoDevuelto = Me.PROVEEDORES.CODPROColumn.ColumnName

            End Select

            If IsNothing(DataTable) Then Return String.Empty

            Dim fSeleccion As New fSeleccion(DataTable, CampoDevuelto, Filtro)
            fSeleccion.Text = "Selección de " & LCase(DataTable.TableName)

            If fSeleccion.ShowDialog() = DialogResult.OK Then
                Return fSeleccion.ValorDevuelto
            Else
                Return String.Empty
            End If

        Catch ex As Exception
            Throw ex
            Return String.Empty
        End Try
    End Function

End Class
