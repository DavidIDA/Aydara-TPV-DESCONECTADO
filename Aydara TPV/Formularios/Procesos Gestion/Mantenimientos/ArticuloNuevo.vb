Public Class ArticuloNuevo

    Dim CodigoFamilia As Integer, CodigoSubfamilia As Integer

#Region "ArticuloNuevo_KeyUp"
    Private Sub ArticuloNuevo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "ArticuloNuevo_Shown"
    Private Sub ArticuloNuevo_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        'Datos IVA
        Me.lblTextoImpuesto.Text = TextoImpuesto
        Me.cmbTipoIVA.Properties.Items(0) = IIf(TipoIva1 Mod 1 = 0, Int(TipoIva1), TipoIva1)
        Me.cmbTipoIVA.Properties.Items(1) = IIf(TipoIva2 Mod 1 = 0, Int(TipoIva2), TipoIva2)
        Me.cmbTipoIVA.Properties.Items(2) = IIf(TipoIva3 Mod 1 = 0, Int(TipoIva3), TipoIva3)
        Me.cmbTipoIVA.Properties.Items(3) = IIf(TipoIva4 Mod 1 = 0, Int(TipoIva4), TipoIva4)
        Me.cmbTipoIVA.SelectedIndex = 0

        'Decimales en precios
        Me.txtPrecioCoste.Properties.Mask.EditMask = "c" & DecimalesPrecio
        Me.txtPrecioVenta.Properties.Mask.EditMask = "c" & DecimalesPrecio

    End Sub
#End Region

#Region "Nuevo"
    Private Sub Nuevo()
        Try
            If IsNumeric(Me.txtCodigo.EditValue) Then
                Me.txtCodigo.EditValue = Me.DameCodigo(Me.txtCodigo.EditValue & "R")
                Me.txtCodigoBarras.Focus()
            Else
                Me.txtCodigo.EditValue = System.DBNull.Value
                Me.txtCodigo.Focus()
            End If

            Me.txtCodigoBarras.EditValue = String.Empty
            Me.txtDescripcion.EditValue = String.Empty
            Me.txtPrecioCoste.EditValue = CDec(0)
            Me.txtPrecioVenta.EditValue = CDec(0)

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoFamilia_ButtonClick"
    Private Sub txtCodigoFamilia_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoFamilia.ButtonClick
        Try
            Dim dsFamilias As New dsArticulos
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("Descripcion")
            Columnas.Add("Descripción")
            Columnas.Add(0)
            Columnas.Add(0)

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT Codigo, Descripcion FROM FAMILIASARTICULOS"
            dsFamilias.FAMILIASARTICULOS.Load(cmd.ExecuteReader)
            cmd.Connection.Close()

            If Buscar(dsFamilias, "FAMILIASARTICULOS", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoFamilia.EditValue = ResultadoBusqueda
                Me.txtCodigoSubfamilia.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error al mostrar listado de proveedores", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "txtCodigoSubFamilia_ButtonClick"
    Private Sub txtCodigoSubFamilia_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoSubfamilia.ButtonClick
        Try
            If Me.txtCodigoFamilia.EditValue = String.Empty Then
                MsgBox("Seleccione antes la familia del artículo", MsgBoxStyle.Information)
                Me.txtCodigoFamilia.Focus()
                Exit Sub
            End If

            Dim dsSubfamilias As New dsArticulos
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("Descripcion")
            Columnas.Add("Descripción")
            Columnas.Add(0)
            Columnas.Add(0)

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT Codigo, Descripcion FROM SUBFAMILIASARTICULOS " & _
                              "WHERE Familia_Id IN (SELECT Id FROM FAMILIASARTICULOS WHERE Codigo='" & Me.txtCodigoFamilia.EditValue & "')"
            dsSubfamilias.SUBFAMILIASARTICULOS.Load(cmd.ExecuteReader)
            cmd.Connection.Close()

            If Buscar(dsSubfamilias, "SUBFAMILIASARTICULOS", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoSubfamilia.EditValue = ResultadoBusqueda
                Me.txtCodigo.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error al mostrar listado de proveedores", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "txtCodigoFamilia_Validated"
    Private Sub txtCodigoFamilia_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoFamilia.Validated

        If Not Me.txtCodigoFamilia.IsModified Then Exit Sub

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand

        Try
            Me.CodigoSubfamilia = 0
            Me.txtCodigoSubfamilia.EditValue = String.Empty
            Me.txtDescripcionSubfamilia.EditValue = String.Empty

            If IsNumeric(Me.txtCodigoFamilia.EditValue) Then Me.txtCodigoFamilia.EditValue = Format(CType(Me.txtCodigoFamilia.EditValue, Integer), "000")

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT * FROM FAMILIASARTICULOS WHERE Codigo='" & Me.txtCodigoFamilia.Text & "'"

            dr = cmd.ExecuteReader
            If dr.Read Then
                Me.CodigoFamilia = dr("Id")
                Me.txtDescripcionFamilia.EditValue = dr("Descripcion")
                Me.txtCodigoSubfamilia.Focus()
            Else
                Me.CodigoFamilia = 0
                Me.txtCodigoFamilia.EditValue = String.Empty
                Me.txtDescripcionFamilia.EditValue = String.Empty
                Me.txtCodigoFamilia.Focus()
            End If
            dr.Close()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
        End Try
    End Sub
#End Region

#Region "txtCodigoSubfamilia_Validated"
    Private Sub txtCodigoSubfamilia_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoSubfamilia.Validated

        If Not Me.txtCodigoSubfamilia.IsModified Then Exit Sub

        If Not IsNumeric(Me.txtCodigoFamilia.EditValue) Then
            Me.txtCodigoSubfamilia.EditValue = String.Empty
            Me.txtCodigoFamilia.Focus()
            Exit Sub
        End If

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand

        Try
            If IsNumeric(Me.txtCodigoSubfamilia.EditValue) Then Me.txtCodigoSubfamilia.EditValue = Format(CType(Me.txtCodigoSubfamilia.EditValue, Integer), "000")

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT * FROM SUBFAMILIASARTICULOS WHERE Familia_Id=" & Me.CodigoFamilia & " AND Codigo='" & Me.txtCodigoSubfamilia.Text & "'"

            dr = cmd.ExecuteReader
            If dr.Read Then
                Me.CodigoSubfamilia = dr("Id")
                Me.txtDescripcionSubfamilia.EditValue = dr("Descripcion")
                Me.txtCodigo.EditValue = String.Empty
                Me.txtCodigo.Focus()
            Else
                Me.CodigoSubfamilia = 0
                Me.txtCodigoSubfamilia.EditValue = String.Empty
                Me.txtDescripcionSubfamilia.EditValue = String.Empty
                Me.txtCodigoSubfamilia.Focus()
            End If
            dr.Close()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
        End Try
    End Sub
#End Region

#Region "txtCodigo_Validated"
    Private Sub txtCodigo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Validated

        If Not Me.txtCodigo.IsModified Then Exit Sub

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand

        Try
            If IsNumeric(Me.txtCodigo.EditValue) Then

                'Me.txtCodigo.EditValue = Format(CType(Me.txtCodigo.EditValue, Integer), "0000000")

                'Comprobar que el código de barras no exista en la base de datos
                cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
                cmd.Connection.Open()
                cmd.CommandText = "SELECT Codigo, Descripcion FROM ARTICULOS " & _
                                  "WHERE Codigo='" & Me.txtCodigo.EditValue & "'"
                dr = cmd.ExecuteReader
                If dr.Read Then
                    MsgBox("Ya existe ese código  al artículo: " & dr("Codigo") & " - " & dr("Descripcion"), MsgBoxStyle.Information, "Ya existe")
                    Me.txtCodigo.EditValue = String.Empty
                    Me.txtCodigo.Focus()
                    Exit Try
                End If
                dr.Close()

            Else
                Me.txtCodigo.EditValue = Me.DameCodigo(Me.txtCodigo.EditValue)
            End If

        Catch ex As Exception
            MsgBox("Error al comprobar código de artículo." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
        End Try

    End Sub
#End Region

#Region "txtCodigoBarras_Validated"
    Private Sub txtCodigoBarras_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoBarras.Validated

        'Comprobar longitud del código de barras
        If Me.txtCodigoBarras.EditValue <> String.Empty And Len(Me.txtCodigoBarras.EditValue) < 8 Then
            MsgBox("El código de barras no puede tener menos de 8 caracteres", MsgBoxStyle.Information, "Atención")
            Me.txtCodigoBarras.EditValue = String.Empty
            Me.txtCodigoBarras.Focus()
            Exit Sub
        End If

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand

        Try
            'Comprobar que el código de barras no exista en la base de datos
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT ARTICULOS.Codigo, ARTICULOS.Descripcion FROM CODIGO_BARRAS INNER JOIN ARTICULOS ON ARTICULOS.Id=CODIGO_BARRAS.Articulo_Id " & _
                              "WHERE CodigoBarras='" & Me.txtCodigoBarras.EditValue & "'"
            dr = cmd.ExecuteReader
            If dr.Read Then
                MsgBox("Ya existe ese código de barras asociado al artículo: " & dr("Codigo") & " - " & dr("Descripcion"), MsgBoxStyle.Information, "Ya existe")
                Me.txtCodigoBarras.EditValue = String.Empty
                Me.txtCodigoBarras.Focus()
                Exit Try
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox("Error al comprobar código de barras." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
        End Try
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

#Region "bttGuardar_Click"
    Private Sub bttGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttGuardar.Click

        If Me.CodigoFamilia = 0 Or Me.CodigoSubfamilia = 0 Then
            MsgBox("Indique familia y subfamilia del artículo.", MsgBoxStyle.Information)
            Me.txtCodigoFamilia.Focus()
            Exit Sub
        End If

        If Me.txtCodigo.EditValue = String.Empty Then
            MsgBox("Indique el código del artículo.", MsgBoxStyle.Information)
            Me.txtCodigo.Focus()
            Exit Sub
        End If

        If Me.txtDescripcion.EditValue = String.Empty Then
            MsgBox("Indique la descripción del artículo.", MsgBoxStyle.Information)
            Me.txtDescripcion.Focus()
            Exit Sub
        End If

        Dim dsArticulos As New dsArticulos

        Dim taArticulos As New dsArticulosTableAdapters.ARTICULOSTableAdapter
        Dim rArticulos As dsArticulos.ARTICULOSRow

        Dim taCodigoBarras As New dsArticulosTableAdapters.CODIGO_BARRASTableAdapter
        Dim rCodigoBarras As dsArticulos.CODIGO_BARRASRow

        Try
            rArticulos = dsArticulos.ARTICULOS.NewARTICULOSRow
            With rArticulos
                .Codigo = Me.txtCodigo.EditValue
                .Descripcion = Me.txtDescripcion.EditValue
                .CodigoFamilia = Me.CodigoFamilia
                .CodigoSubfamilia = Me.CodigoSubfamilia
                .PrecioCoste = Me.txtPrecioCoste.EditValue
                .Precio = Me.txtPrecioVenta.EditValue
                .TipoIva = Me.cmbTipoIVA.SelectedIndex + 1
            End With
            dsArticulos.ARTICULOS.AddARTICULOSRow(rArticulos)

            taArticulos.Update(dsArticulos.ARTICULOS)

            If Me.txtCodigoBarras.EditValue <> String.Empty Then

                'Añadir código de barras
                rCodigoBarras = dsArticulos.CODIGO_BARRAS.NewCODIGO_BARRASRow
                rCodigoBarras.Articulo_Id = dsArticulos.ARTICULOS(0).Id
                rCodigoBarras.CodigoBarras = Me.txtCodigoBarras.EditValue
                dsArticulos.CODIGO_BARRAS.AddCODIGO_BARRASRow(rCodigoBarras)

                taCodigoBarras.Update(dsArticulos.CODIGO_BARRAS)

            End If

            Me.Nuevo()

        Catch ex As Exception
            MsgBox("Error al crear artículo." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            dsArticulos.Clear()
        End Try
    End Sub
#End Region

#Region "bttTeclado_Click"
    Private Sub bttTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttTeclado.Click
        System.Diagnostics.Process.Start("osk.exe")
    End Sub
#End Region

#Region "DameCodigo"
    Private Function DameCodigo(ByVal Referencia As String) As String

        If Me.CodigoFamilia = 0 Or Me.CodigoSubfamilia = 0 Then Return String.Empty

        Dim cmd As New SqlClient.SqlCommand

        Dim Codigo() As String = Split(UCase(Referencia), "R")

        If Codigo.Length <= 1 Then Return Referencia

        Referencia = Codigo(0)

        If IsNumeric(Referencia) Then
            While Len(Referencia) < 7
                Referencia &= "0"
            End While
        End If

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT ISNULL(MIN(Codigo),'') " & _
                              "FROM (SELECT Codigo FROM ARTICULOS WHERE IsNumeric(Codigo) = 1) AS ART " & _
                              "WHERE Codigo >= '" & Referencia & "' " & _
                              "AND CONVERT(varchar, Codigo + 1) NOT IN (SELECT CONVERT(varchar, Codigo + 0) FROM ARTICULOS WHERE IsNumeric(Codigo) = 1)"

            Referencia = cmd.ExecuteScalar

            If IsNumeric(Referencia) Then
                Referencia = Format(CInt(Referencia) + 1, "0000000")
            Else
                Referencia = String.Empty
            End If

            Return Referencia

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            Return Referencia
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
        End Try

    End Function
#End Region

End Class