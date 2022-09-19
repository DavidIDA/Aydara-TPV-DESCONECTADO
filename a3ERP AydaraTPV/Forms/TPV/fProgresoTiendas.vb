Public Class fProgresoTiendas

    Dim DatosRecepcion As New dsTPVRecepcion

#Region "Eventos formulario"
    Public Sub New(DatosRecepcion As dsTPVRecepcion)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DatosRecepcion = DatosRecepcion.Copy
        Me.DatosRecepcion.DirectorioFicheros = DatosRecepcion.DirectorioFicheros
        Me.RECEPCIONBindingSource.DataSource = Me.DatosRecepcion

    End Sub

    Private Sub fProgreso_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.bwVentas.IsBusy Or Me.bwAlbaranes.IsBusy Or Me.bwTraspasos.IsBusy Or Me.bwPedidos.IsBusy Then
            If MsgBox("¿Seguro que desea cacelar el proceso de actualización?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Procesos en curso") = MsgBoxResult.Yes Then

                Try
                    Aydara.Estado("Cancelando proceso de actualición")

                    Me.bwVentas.CancelAsync()
                    Me.bwAlbaranes.CancelAsync()
                    Me.bwTraspasos.CancelAsync()
                    Me.bwPedidos.CancelAsync()

                    While Not Me.bwVentas.CancellationPending Or Not Me.bwAlbaranes.CancellationPending Or Not Me.bwTraspasos.CancellationPending Or Not Me.bwPedidos.CancellationPending
                    End While

                Catch ex As Exception
                    Throw ex
                Finally
                    Aydara.Estado()
                End Try

            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub fProgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Me.bwVentas.RunWorkerAsync()
            'Me.bwAlbaranes.RunWorkerAsync()
            Me.bwTraspasos.RunWorkerAsync()
            Me.bwPedidos.RunWorkerAsync()

            Try
                For i As Integer = 0 To DatosRecepcion.RECEPCION.Count - 1
                    With DatosRecepcion.RECEPCION(i)
                        'Dim fProgreso As New fProgresoFacturacion(.CODALM)
                        'fProgreso.Show()

                        Dim bwAlbaranes As New System.ComponentModel.BackgroundWorker
                        AddHandler bwAlbaranes.DoWork, AddressOf Subproceso_DoWork
                        AddHandler bwAlbaranes.ProgressChanged, AddressOf Subproceso_ProgressChanged
                        AddHandler bwAlbaranes.RunWorkerCompleted, AddressOf Subproceso_RunWorkerCompleted

                        bwAlbaranes.WorkerReportsProgress = True
                        bwAlbaranes.RunWorkerAsync(DatosRecepcion.RECEPCION(i))

                    End With
                Next

            Catch ex As Exception
                Me.bwAlbaranes.CancelAsync()
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

#End Region

#Region "Proceso ventas"
    Private Sub bwVentas_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwVentas.DoWork
        Try
            'DatosRecepcion.ImportarTicketsSegundoPlano(Me.bwVentas, e)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub bwVentas_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwVentas.ProgressChanged
        Me.pbTicketsVentas.EditValue = e.ProgressPercentage
    End Sub

    Private Sub bwVentas_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwVentas.RunWorkerCompleted
        'MsgBox("Tickets importados")
    End Sub
#End Region

#Region "Proceso traspasos"
    Private Sub bwTraspasos_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwTraspasos.DoWork
        Try
            'DatosRecepcion.GenerarTraspasoSegundoPlano(Me.bwTraspasos, e)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub bwTraspasos_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwTraspasos.ProgressChanged
        Me.pbTraspasos.EditValue = e.ProgressPercentage
    End Sub

    Private Sub bwTraspasos_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwTraspasos.RunWorkerCompleted

    End Sub
#End Region

#Region "Proceso pedidos"
    Private Sub bwPedidos_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwPedidos.DoWork
        Try
            'DatosRecepcion.GenerarPedidosSegundoPlano(Me.bwPedidos, e)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub bwPedidos_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwPedidos.ProgressChanged
        Me.pbPedidos.EditValue = e.ProgressPercentage
    End Sub

    Private Sub bwPedidos_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwPedidos.RunWorkerCompleted

    End Sub
#End Region

#Region "Eventos subproceso"
    Private Sub Subproceso_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
        Try
            DirectCast(e.Argument, dsTPVRecepcion.RECEPCIONRow).PROGRESO = 50
            DirectCast(sender, System.ComponentModel.BackgroundWorker).ReportProgress(0)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Subproceso_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs)
        'Me.pbAlbaranes.EditValue = e.ProgressPercentage
        Me.GridView1.RefreshData()
    End Sub

    Private Sub Subproceso_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)
        'Me.Refresh()
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(sender As Object, e As EventArgs) Handles bttCancelar.Click
        If MsgBox("¿Seguro que desea cacelar el proceso de actualización?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Procesos en curso") = MsgBoxResult.Yes Then
            Me.bwVentas.CancelAsync()
            Me.bwAlbaranes.CancelAsync()
            Me.bwTraspasos.CancelAsync()
            Me.bwPedidos.CancelAsync()
            Me.Close()
        End If
    End Sub
#End Region

End Class