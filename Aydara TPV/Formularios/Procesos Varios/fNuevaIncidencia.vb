Public Class fNuevaIncidencia 

    Public IDArticulo As Integer = -1

    Private Sub fNuevaIncidencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.DsIncidenciasTipos1.Cargar()
            Me.DsEmpleados1.Cargar()

            Me.txtCantidad.Text = 0
            Me.dtFecha.Text = Date.Now
        Catch ex As Exception
            MsgBox(ex.Message, , Me.Text)
        End Try
    End Sub

    Private Sub bttGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttGuardar.Click
        Try
            If Trim(Me.cboTipo.Text) = String.Empty Then
                MsgBox("Falta selecionar un Tipo de Incidencia.", , Me.Text)
                Exit Sub
            End If

            If Trim(Me.cboEmpleado.Text) = String.Empty Then
                MsgBox("Falta selecionar un Empleado.", , Me.Text)
                Exit Sub
            End If

            If CType(Trim(Me.txtCantidad.Text), Decimal) = 0 Then
                MsgBox("No se puede guardar una incidencia con Cantidad 0.", , Me.Text)
                Exit Sub
            End If

            If Me.IDArticulo = -1 Then
                MsgBox("Falta selecionar un Artículo.", , Me.Text)
                Exit Sub
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, , Me.Text)
        End Try
    End Sub


    Private Sub btnArticulo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnArticulo.ButtonClick
        Try
            Dim dsArticulos As New dsArticulos
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(0) 'Tamaño columna
            Columnas.Add(0) 'Tamaño máximo columna

            Columnas.Add("Etiqueta")
            Columnas.Add("Familia-Subf")
            Columnas.Add(80)
            Columnas.Add(80)

            Columnas.Add("Codigo")
            Columnas.Add("Código")
            Columnas.Add(80)
            Columnas.Add(80)

            Columnas.Add("Descripcion")
            Columnas.Add("Descripción")
            Columnas.Add(0)
            Columnas.Add(0)

            Columnas.Add("ControlBaja")
            Columnas.Add("C.Baja")
            Columnas.Add(60)
            Columnas.Add(60)

            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT (SELECT Codigo FROM FAMILIASARTICULOS WHERE FAMILIASARTICULOS.Id=ARTICULOS.CodigoFamilia) + ' - ' + " & _
                              "(SELECT Codigo FROM SUBFAMILIASARTICULOS WHERE Familia_Id=ARTICULOS.CodigoFamilia AND SUBFAMILIASARTICULOS.Id=ARTICULOS.CodigoSubfamilia) AS Etiqueta, " & _
                              "Codigo, Descripcion, ControlBaja FROM ARTICULOS ORDER BY Etiqueta, Descripcion"

            dsArticulos.ARTICULOS.Load(cmd.ExecuteReader)

            cmd.Connection.Close()

            If Buscar(dsArticulos, "ARTICULOS", Columnas, 3, True).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.IDArticulo = AGI2005.BaseDatos.ConsultaDevuelveValor("SELECT Id FROM ARTICULOS WHERE Codigo='" & ResultadoBusqueda & "'", AGI2005.BaseDatos.TipoValor.ID, My.Settings.AydaraTPVConnectionString)
                Me.btnArticulo.Text = AGI2005.BaseDatos.ConsultaDevuelveValor("SELECT Codigo FROM ARTICULOS WHERE Id=" & Me.IDArticulo, AGI2005.BaseDatos.TipoValor.ID, My.Settings.AydaraTPVConnectionString)
                Me.lblArticulo.Text = AGI2005.BaseDatos.ConsultaDevuelveValor("SELECT Descripcion FROM ARTICULOS WHERE Id=" & Me.IDArticulo, AGI2005.BaseDatos.TipoValor.ID, My.Settings.AydaraTPVConnectionString)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, , Me.Text)
        End Try
    End Sub

    Private Sub btnArticulo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnArticulo.Validated
        Try
            Me.btnArticulo.Text = Trim(Me.btnArticulo.Text)

            'Comprobar código
            Dim sql As String = "SELECT ID FROM ARTICULOS WHERE Codigo='" & Me.btnArticulo.Text & "'"

            If Me.btnArticulo.Text <> String.Empty Then

                Me.IDArticulo = AGI2005.BaseDatos.ConsultaDevuelveValor(sql, AGI2005.BaseDatos.TipoValor.ID, My.Settings.AydaraTPVConnectionString)

                If Me.IDArticulo = -1 Then

                    'Comprobar si es un código de barras
                    sql = "SELECT ARTICULOS.ID FROM ARTICULOS " & _
                          "INNER JOIN Codigo_Barras on ARTICULOS.Id=Codigo_Barras.Articulo_Id " & _
                          "WHERE Codigo_Barras.CodigoBarras='" & Me.btnArticulo.Text & "'"

                    Me.IDArticulo = AGI2005.BaseDatos.ConsultaDevuelveValor(sql, AGI2005.BaseDatos.TipoValor.ID, My.Settings.AydaraTPVConnectionString)

                End If

                If Me.IDArticulo <> -1 Then
                    Me.btnArticulo.Text = AGI2005.BaseDatos.ConsultaDevuelveValor("SELECT Codigo FROM ARTICULOs WHERE Id=" & Me.IDArticulo, AGI2005.BaseDatos.TipoValor.Texto, My.Settings.AydaraTPVConnectionString)
                    Me.lblArticulo.Text = AGI2005.BaseDatos.ConsultaDevuelveValor("SELECT Descripcion FROM ARTICULOs WHERE Id=" & Me.IDArticulo, AGI2005.BaseDatos.TipoValor.Texto, My.Settings.AydaraTPVConnectionString)
                Else
                    Me.IDArticulo = -1
                    Me.lblArticulo.Text = String.Empty
                    Me.btnArticulo.Text = String.Empty
                End If
            Else
                Me.IDArticulo = -1
                Me.lblArticulo.Text = String.Empty
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , Me.Text)
        End Try
    End Sub
End Class