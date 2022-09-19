Public Class NuevaTienda

    Dim _CadenaConexion As String

    Public Sub New(ByVal CadenaConexion As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me._CadenaConexion = CadenaConexion

    End Sub

    Private Sub NuevaTienda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbTipoTienda.SelectedIndex = 0
    End Sub

    Private Sub bttContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttContinuar.Click

        Dim conexion As New SqlClient.SqlConnection(Me._CadenaConexion)

        Try
            Me.Cursor = Cursors.WaitCursor

            conexion.Open()

            Dim cmd As New SqlClient.SqlCommand()

            cmd.Connection = conexion

            Dim sql() As String = Nothing

            Select Case Me.cmbTipoTienda.SelectedIndex
                Case 0 'Empresa vacía
                    sql = Split(My.Resources.ScriptsBD.BBDD_Vacia, "GO" & vbCrLf)
                Case 1 'Datos alimentación
                    sql = Split(My.Resources.ScriptsBD.BBDD_Alimentacion, "GO" & vbCrLf)
                Case 2 'Datos tallas y colores
                    sql = Split(My.Resources.ScriptsBD.BBDD_TallasColores, "GO" & vbCrLf)
            End Select

            For j As Integer = 0 To sql.Length - 1
                cmd.CommandText = sql(j)
                cmd.ExecuteNonQuery()
            Next

            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MsgBox("Error al crear la base de datos." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            Me.DialogResult = Windows.Forms.DialogResult.Abort
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
            Me.Cursor = Cursors.Default
        End Try

    End Sub

End Class