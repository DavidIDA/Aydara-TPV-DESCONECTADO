Imports System.IO

Public Class fExportarContabilidad

    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click
        Try
            Me.DsHistorico1.Cargar(Me.txtFechaInicio.Text, Me.txtFechaFin.Text, Me.chkSoloPendientes.Checked)
        Catch ex As Exception
            MsgBox(ex.Message, , Me.Text)
        End Try
    End Sub

    Private Sub bttGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttGuardar.Click
        Try
            If Me.DsHistorico1.HISTORICO_TICKETS.Count > 0 Then
                Dim miform As New FolderBrowserDialog
                miform.SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString
                'Dim Fichero As String = "Exportacion " & Date.Today.Year & Date.Today.Month.ToString("00") & Date.Today.Day.ToString("00") & ".txt"
                Dim Fichero As String = "EXTRAC.txt"

                If miform.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim Ruta As String = miform.SelectedPath

                    If File.Exists(Ruta & "\" & Fichero) Then
                        File.Delete(Ruta & "\" & Fichero)
                    End If

                    Me.DsHistorico1.ExportarContabilidad(Ruta & "\" & Fichero)

                    MsgBox("Exportación Finalizada.", , Me.Text)

                End If
            Else
                MsgBox("No hay ningún dato para exportar.", , Me.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , Me.Text)
        End Try
    End Sub

    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.Close()
    End Sub

End Class