Partial Class dsClientes

    Public a3ERPMaestro As New a3ERPActiveX.Maestro

    Public Event ActualizaDatos()

    Public Sub AddEvents()
        AddHandler Me.CLIENTES.RowChanged, AddressOf Me.CLIENTES.CLIENTESDataTable_RowChanged
    End Sub

    Public Sub RemoveEvents()
        RemoveHandler Me.CLIENTES.RowChanged, AddressOf Me.CLIENTES.CLIENTESDataTable_RowChanged
    End Sub

#Region "Eventos Dataset"
    Private Sub dsClientes_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Try
            Me.a3ERPMaestro.Acabar()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub onActualizaDatos()
        RaiseEvent ActualizaDatos()
    End Sub
#End Region

#Region "Funciones"
    Public Sub Cargar(Optional CODCLI As String = "")

        Dim taClientes As New dsClientesTableAdapters.CLIENTESTableAdapter

        Try
            If CODCLI <> String.Empty Then
                Aydara.Estado("Cargando cliente")
                taClientes.FillBy(Me.CLIENTES, CODCLI)
            Else
                Aydara.Estado("Cargando clientes")
                taClientes.Fill(Me.CLIENTES)
            End If

        Catch ex As Exception
            Throw ex
        Finally
            Aydara.Estado()
        End Try
    End Sub

    Public Sub Editar(CODCLI As String)

        Dim a3ERPOpcion As New a3ERPActiveX.Opcion

        Try
            a3ERPOpcion.Iniciar()
            a3ERPOpcion.IdOpcion = "manClientes"
            a3ERPOpcion.AnadirParametro("Accion", "Edicion")
            a3ERPOpcion.AnadirParametro("CODIGO", CODCLI)
            a3ERPOpcion.Ejecutar()

        Catch ex As Exception
            Throw ex
        Finally
            a3ERPOpcion.Acabar()
        End Try

    End Sub

    Public Sub Nuevo()

        Dim a3ERPOpcion As New a3ERPActiveX.Opcion

        Try
            a3ERPOpcion.Iniciar()
            a3ERPOpcion.IdOpcion = "manClientes"
            a3ERPOpcion.AnadirParametro("Accion", "Edicion")
            a3ERPOpcion.Ejecutar()

        Catch ex As Exception
            Throw ex
        Finally
            a3ERPOpcion.Acabar()
        End Try

    End Sub

    Public Sub Mantenimiento()
       
        Dim a3ERPOpcion As New a3ERPActiveX.Opcion

        Try
            a3ERPOpcion.Iniciar()
            a3ERPOpcion.IdOpcion = "manClientes"
            a3ERPOpcion.Ejecutar()

        Catch ex As Exception
            Throw ex
        Finally
            a3ERPOpcion.Acabar()
        End Try

    End Sub

    Public Function Seleccionar() As String

        Dim SeleccionIDA As Boolean = False

        Try
            Select Case a3ERP.Empresa
                Case a3ERP.FormatoEmpresa.Garrido
                    SeleccionIDA = True
            End Select

            If SeleccionIDA Then

                Dim dsSeleccion As New dsSeleccion
                Return dsSeleccion.Seleccionar(dsSeleccion.Fichero.Clientes)

            Else

                Return Aydara.Seleccionar("CLIENTES", "CODCLI", "BLOQUEADO='F'")

            End If

        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Public Sub Eliminar(CODCLI As String)

        Dim a3ERPMaestro As New a3ERPActiveX.Maestro

        Try
            a3ERPMaestro.Iniciar("CLIENTES")

            If a3ERPMaestro.Buscar(CODCLI) Then
                a3ERPMaestro.Borrar()
            End If

        Catch ex As Exception
            Throw ex
        Finally
            a3ERPMaestro.Acabar()
        End Try
    End Sub

    Public Function Referencia(CODCLI As String) As String
        Try
            Dim a3ERPSeleccion As New a3ERPActiveX.Seleccion

            a3ERPSeleccion.Tabla = "REFCLI"
            a3ERPSeleccion.Filtro = "CODCLI='" & CODCLI & "'"
            a3ERPSeleccion.CampoResultado = "REFERENCIA"

            Return a3ERPSeleccion.Ejecutar()

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar() As String
        Try
            Me.RemoveEvents()

            Aydara.Estado("Guardando cliente")

            Me.a3ERPMaestro.Guarda(True)

            Return Me.a3ERPMaestro.AsString("CODCLI")

        Catch ex As Exception
            Throw ex
        Finally
            Me.AddEvents()
            Aydara.Estado()
        End Try
    End Function

#End Region

#Region "Eventos cliente"
    Partial Class CLIENTESDataTable
        Private Sub CLIENTESDataTable_ColumnChanged(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanged

            With DirectCast(e.Row, dsClientes.CLIENTESRow)
                Select Case e.Column.ColumnName

                    Case Me.DTOCLIColumn.ColumnName
                        .POBCLI = Aydara.SentenciaSQL("SELECT PUEBLO FROM [A3ERP$SISTEMA].[dbo].[POSTAL] WHERE CODIGO = '" & e.ProposedValue & "'")

                    Case Me.RAZONColumn.ColumnName
                        .NOMFISCAL = e.ProposedValue
                        If .NOMCLI = String.Empty Then
                            .NOMCLI = e.ProposedValue
                        End If

                End Select
            End With

            Try
                RemoveHandler Me.ColumnChanged, AddressOf CLIENTESDataTable_ColumnChanged

                With DirectCast(Me.DataSet, dsClientes).a3ERPMaestro

                    If Not (.Estado = a3ERPActiveX.EstadoMaestro.estM_NUEVO Or .Estado = a3ERPActiveX.EstadoMaestro.estM_EDICION) Then Exit Try

                    Select Case Type.GetTypeCode(e.Column.DataType)
                        Case TypeCode.Int16, TypeCode.Int32, TypeCode.Int64
                            .AsInteger(e.Column.ColumnName) = CInt(e.ProposedValue)
                        Case TypeCode.Decimal
                            .AsFloat(e.Column.ColumnName) = CDec(e.ProposedValue)
                        Case TypeCode.DateTime
                            If Not e.ProposedValue Is System.DBNull.Value Then
                                .AsString(e.Column.ColumnName) = CDate(e.ProposedValue).ToShortDateString
                            Else
                                .AsString(e.Column.ColumnName) = String.Empty
                            End If
                        Case TypeCode.Double
                            .AsFloat(e.Column.ColumnName) = CDbl(e.ProposedValue)
                        Case TypeCode.Boolean
                            .AsBoolean(e.Column.ColumnName) = CBool(e.ProposedValue)
                        Case Else
                            .AsString(e.Column.ColumnName) = e.ProposedValue.ToString
                    End Select

                    'Actualiza datos
                    For i As Integer = 0 To Me.Columns.Count - 1
                        Select Case Type.GetTypeCode(Me.Columns(i).DataType)
                            Case TypeCode.Int16, TypeCode.Int32, TypeCode.Int64
                                e.Row.Item(Me.Columns(i)) = .AsInteger(Me.Columns(i).ColumnName)
                            Case TypeCode.Decimal
                                e.Row.Item(Me.Columns(i)) = .AsFloat(Me.Columns(i).ColumnName)
                            Case TypeCode.DateTime
                                If Not .AsString(Me.Columns(i).ColumnName) Is Nothing Then
                                    e.Row.Item(Me.Columns(i)) = .AsString(Me.Columns(i).ColumnName)
                                Else
                                    e.Row.Item(Me.Columns(i)) = System.DBNull.Value
                                End If
                            Case TypeCode.Double
                                e.Row.Item(Me.Columns(i)) = .AsFloat(Me.Columns(i).ColumnName)
                            Case TypeCode.Boolean
                                e.Row.Item(Me.Columns(i)) = .AsBoolean(Me.Columns(i).ColumnName)
                            Case Else
                                If Not .AsString(Me.Columns(i).ColumnName) Is Nothing Then
                                    e.Row.Item(Me.Columns(i)) = .AsString(Me.Columns(i).ColumnName)
                                Else
                                    e.Row.Item(Me.Columns(i)) = String.Empty
                                End If
                        End Select
                    Next

                End With

            Catch ex As Exception
                e.ProposedValue = e.Row.Item(e.Column)
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Finally
                AddHandler Me.ColumnChanged, AddressOf CLIENTESDataTable_ColumnChanged
                DirectCast(Me.DataSet, dsClientes).onActualizaDatos()
            End Try
        End Sub

        Public Sub CLIENTESDataTable_RowChanged(sender As Object, e As DataRowChangeEventArgs) Handles Me.RowChanged

        End Sub

    End Class

#End Region

End Class
