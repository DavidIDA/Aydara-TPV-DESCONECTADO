Public Class ListadoTarifas

#Region "ListadoTarifas_Load"
    Private Sub ListadoTarifas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtCodigoInicio.EditValue = String.Empty
        Me.txtDescripcionInicio.EditValue = String.Empty
        Me.txtCodigoFin.EditValue = String.Empty
        Me.txtDescripcionFin.EditValue = String.Empty
        Me.txtCodigoFamiliaInicio.EditValue = String.Empty
        Me.txtDescripcionFamiliaInicio.EditValue = String.Empty
        Me.txtCodigoFamiliaFin.EditValue = String.Empty
        Me.txtDescripcionFamiliaFin.EditValue = String.Empty
        Me.txtCodigoProveedor.EditValue = String.Empty
        Me.txtNombreProveedor.EditValue = String.Empty
        Me.checkControlBaja.Checked = False
        Me.checkAgruparFamilia.Checked = True
        Me.txtOrden.EditValue = "Código"
        Me.txtTipoOrden.EditValue = "Ascendente"
    End Sub
#End Region

#Region "txtCodigoInicio_ButtonClick"
    Private Sub txtCodigoInicio_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoInicio.ButtonClick
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

            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT (SELECT Codigo FROM FAMILIASARTICULOS WHERE FAMILIASARTICULOS.Id=ARTICULOS.CodigoFamilia) + ' - ' + " & _
                              "(SELECT Codigo FROM SUBFAMILIASARTICULOS WHERE Familia_Id=ARTICULOS.CodigoFamilia AND SUBFAMILIASARTICULOS.Id=ARTICULOS.CodigoSubfamilia) AS Etiqueta, " & _
                              "Codigo, Descripcion FROM ARTICULOS ORDER BY Etiqueta, Descripcion"

            dsArticulos.ARTICULOS.Load(cmd.ExecuteReader)

            If Buscar(dsArticulos, "ARTICULOS", Columnas, 3, True).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoInicio.EditValue = ResultadoBusqueda
                Me.txtCodigoInicio.IsModified = True
                Me.txtCodigoInicio_Validated(Nothing, Nothing)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoInicio_Validated"
    Private Sub txtCodigoInicio_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoInicio.Validated

        If Not Me.txtCodigoInicio.IsModified Then Exit Sub

        If Not IsNumeric(Me.txtCodigoInicio.EditValue) Then Me.txtDescripcionInicio.EditValue = String.Empty : Exit Sub

        'Me.txtCodigoInicio.EditValue = Format(CType(Me.txtCodigoInicio.EditValue, Integer), "0000000")

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT Descripcion FROM Articulos WHERE Codigo=" & Me.txtCodigoInicio.EditValue
            Me.txtDescripcionInicio.EditValue = cmd.ExecuteScalar

        Catch ex As Exception
            MsgBox("Error al mostrar descripción del artículo", MsgBoxStyle.Exclamation)
        End Try

        cmd.Connection.Close()

    End Sub
#End Region

#Region "txtCodigoFin_ButtonClick"
    Private Sub txtCodigoFin_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoFin.ButtonClick
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

            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT (SELECT Codigo FROM FAMILIASARTICULOS WHERE FAMILIASARTICULOS.Id=ARTICULOS.CodigoFamilia) + ' - ' + " & _
                              "(SELECT Codigo FROM SUBFAMILIASARTICULOS WHERE Familia_Id=ARTICULOS.CodigoFamilia AND SUBFAMILIASARTICULOS.Id=ARTICULOS.CodigoSubfamilia) AS Etiqueta, " & _
                              "Codigo, Descripcion FROM ARTICULOS ORDER BY Etiqueta, Descripcion"

            dsArticulos.ARTICULOS.Load(cmd.ExecuteReader)

            If Buscar(dsArticulos, "ARTICULOS", Columnas, 3, True).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoFin.EditValue = ResultadoBusqueda
                Me.txtCodigoFin.IsModified = True
                Me.txtCodigoFin_Validated(Nothing, Nothing)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoFin_Validated"
    Private Sub txtCodigoFin_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoFin.Validated

        If Not Me.txtCodigoFin.IsModified Then Exit Sub

        If Not IsNumeric(Me.txtCodigoFin.EditValue) Then Me.txtDescripcionFin.EditValue = String.Empty : Exit Sub

        'Me.txtCodigoFin.EditValue = Format(CType(Me.txtCodigoFin.EditValue, Integer), "0000000")

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT Descripcion FROM Articulos WHERE Codigo=" & Me.txtCodigoFin.EditValue
            Me.txtDescripcionFin.EditValue = cmd.ExecuteScalar

        Catch ex As Exception
            MsgBox("Error al mostrar descripción del artículo", MsgBoxStyle.Exclamation)
        End Try

        cmd.Connection.Close()

    End Sub
#End Region

#Region "txtCodigoFamiliaInicio_ButtonClick"
    Private Sub txtCodigoFamiliaInicio_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoFamiliaInicio.ButtonClick
        Try

            Dim DsArticulos As New dsArticulos, tFamilias As New dsArticulosTableAdapters.FAMILIASARTICULOSTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("Descripcion")
            Columnas.Add("Descripción")
            Columnas.Add(0)
            Columnas.Add(0)

            tFamilias.Fill(DsArticulos.FAMILIASARTICULOS)

            If Buscar(DsArticulos, "FAMILIASARTICULOS", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoFamiliaInicio.EditValue = ResultadoBusqueda
                Me.txtCodigoFamiliaInicio.IsModified = True
                Me.txtCodigoFamiliaInicio_Validated(Nothing, Nothing)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoFamiliaInicio_Validated"
    Private Sub txtCodigoFamiliaInicio_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoFamiliaInicio.Validated

        If Not Me.txtCodigoFamiliaInicio.IsModified Then Exit Sub

        If Not IsNumeric(Me.txtCodigoFamiliaInicio.EditValue) Then Me.txtDescripcionFamiliaInicio.EditValue = String.Empty : Exit Sub

        Me.txtCodigoFamiliaInicio.EditValue = Format(CType(Me.txtCodigoFamiliaInicio.EditValue, Integer), "000")

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT Descripcion FROM FAMILIASARTICULOS WHERE Codigo=" & Me.txtCodigoFamiliaInicio.EditValue
            Me.txtDescripcionFamiliaInicio.EditValue = cmd.ExecuteScalar

        Catch ex As Exception
            MsgBox("Error al mostrar descripción de la familia", MsgBoxStyle.Exclamation)
        End Try

        cmd.Connection.Close()

    End Sub
#End Region

#Region "txtCodigoFamiliaFin_ButtonClick"
    Private Sub txtCodigoFamiliaFin_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoFamiliaFin.ButtonClick
        Try

            Dim DsArticulos As New dsArticulos, tFamilias As New dsArticulosTableAdapters.FAMILIASARTICULOSTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("Descripcion")
            Columnas.Add("Descripción")
            Columnas.Add(0)
            Columnas.Add(0)

            tFamilias.Fill(DsArticulos.FAMILIASARTICULOS)

            If Buscar(DsArticulos, "FAMILIASARTICULOS", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoFamiliaFin.EditValue = ResultadoBusqueda
                Me.txtCodigoFamiliaFin.IsModified = True
                Me.txtCodigoFamiliaFin_Validated(Nothing, Nothing)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoFamiliaFin_Validated"
    Private Sub txtCodigoFamiliaFin_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoFamiliaFin.Validated

        If Not Me.txtCodigoFamiliaFin.IsModified Then Exit Sub

        If Not IsNumeric(Me.txtCodigoFamiliaFin.EditValue) Then Me.txtDescripcionFamiliaFin.EditValue = String.Empty : Exit Sub

        Me.txtCodigoFamiliaFin.EditValue = Format(CType(Me.txtCodigoFamiliaFin.EditValue, Integer), "000")

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT Descripcion FROM FAMILIASARTICULOS WHERE Codigo=" & Me.txtCodigoFamiliaFin.EditValue
            Me.txtDescripcionFamiliaFin.EditValue = cmd.ExecuteScalar

        Catch ex As Exception
            MsgBox("Error al mostrar descripción de la familia", MsgBoxStyle.Exclamation)
        End Try

        cmd.Connection.Close()

    End Sub
#End Region

#Region "txtCodigoProveedor_ButtonClick"
    Private Sub txtCodigoProveedor_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoProveedor.ButtonClick
        Try

            Dim dsProveedores As New dsProveedores, tProveedores As New dsProveedoresTableAdapters.PROVEEDORESTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("Nombre")
            Columnas.Add("Nombre Fiscal")
            Columnas.Add(0)
            Columnas.Add(0)

            Columnas.Add("Direccion")
            Columnas.Add("Dirección")
            Columnas.Add(0)
            Columnas.Add(0)

            tProveedores.Fill(dsProveedores.PROVEEDORES)

            If Buscar(dsProveedores, "Proveedores", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoProveedor.EditValue = ResultadoBusqueda
                Me.txtCodigoProveedor.IsModified = True
                Me.txtCodigoProveedor_Validated(Nothing, Nothing)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoProveedor_Validated"
    Private Sub txtCodigoProveedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoProveedor.Validated

        If Not Me.txtCodigoProveedor.IsModified Then Exit Sub

        If Not IsNumeric(Me.txtCodigoProveedor.EditValue) Then Me.txtNombreProveedor.EditValue = String.Empty : Exit Sub

        Me.txtCodigoProveedor.EditValue = Format(CType(Me.txtCodigoProveedor.EditValue, Integer), "00000")

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT Nombre FROM PROVEEDORES WHERE Codigo=" & Me.txtCodigoProveedor.EditValue
            Me.txtNombreProveedor.EditValue = cmd.ExecuteScalar

        Catch ex As Exception
            MsgBox("Error al mostrar nombre del proveedor", MsgBoxStyle.Exclamation)
        End Try

        cmd.Connection.Close()

    End Sub
#End Region

#Region "bttImprimir_Click"
    Private Sub bttImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimir.Click

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            Me.Cursor = Cursors.WaitCursor

            cmd.CommandText = "SELECT ARTICULOS.Codigo, ARTICULOS.Descripcion, FAMILIASARTICULOS.Codigo AS CodigoFamilia, FAMILIASARTICULOS.Descripcion AS DescripcionFamilia, " & _
                              "SUBFAMILIASARTICULOS.Codigo AS CodigoSubFamilia, SUBFAMILIASARTICULOS.Descripcion AS DescripcionSubFamilia, TipoIVA, UnidadCaja, " & _
                              "PrecioCoste, Precio AS PrecioVenta, CodigoProveedor " & _
                              "FROM Articulos LEFT JOIN FAMILIASARTICULOS ON ARTICULOS.CodigoFamilia=FAMILIASARTICULOS.Id " & _
                              "LEFT JOIN SUBFAMILIASARTICULOS ON FAMILIASARTICULOS.Id=SUBFAMILIASARTICULOS.Familia_Id AND ARTICULOS.CodigoSubFamilia=SUBFAMILIASARTICULOS.Id"

            'Aplicar filtros
            Dim Filtro As String = String.Empty
            If IsNumeric(Me.txtCodigoInicio.EditValue) Then Filtro = " WHERE ARTICULOS.Codigo>='" & Me.txtCodigoInicio.EditValue & "'"
            If IsNumeric(Me.txtCodigoFin.EditValue) Then Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & "ARTICULOS.Codigo<='" & Me.txtCodigoFin.EditValue & "'"
            If IsNumeric(Me.txtCodigoFamiliaInicio.EditValue) Then Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & "FAMILIASARTICULOS.Codigo>='" & Me.txtCodigoFamiliaInicio.EditValue & "'"
            If IsNumeric(Me.txtCodigoFamiliaFin.EditValue) Then Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & "FAMILIASARTICULOS.Codigo<='" & Me.txtCodigoFamiliaFin.EditValue & "'"
            If IsNumeric(Me.txtCodigoProveedor.EditValue) Then Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & "CodigoProveedor<=" & Me.txtCodigoProveedor.EditValue
            Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & "ControlBaja=" & Math.Abs(CType(Me.checkControlBaja.EditValue, Integer))

            cmd.CommandText &= Filtro

            'Ordenación
            Select Case Me.txtOrden.EditValue
                Case "Código"
                    cmd.CommandText &= " ORDER BY Codigo"
                Case "Descripción"
                    cmd.CommandText &= " ORDER BY Descripcion"
                Case "Proveedor"
                    cmd.CommandText &= " ORDER BY CodigoProveedor"
            End Select
            If Me.txtTipoOrden.EditValue = "Descendente" Then cmd.CommandText &= " DESC"

            Dim dsArticulos As New dsListadoArticulos

            dsArticulos.ListadoArticulos.Load(cmd.ExecuteReader)

            Dim Informe As New InfListadoTarifas

            Informe.PaperKind = Printing.PaperKind.A4

            Select Case Me.rgValorado.EditValue
                Case "PrecioCoste"
                    Informe.lblPrecioVenta.Dispose()
                    Informe.txtPrecioVenta.Dispose()
                    Informe.lblPrecioNeto.Dispose()
                    Informe.txtPrecioNeto.Dispose()
                    Informe.lblMargen.Dispose()
                    Informe.txtMargen.Dispose()
                Case "Precio"
                    Informe.lblPrecioCosto.Dispose()
                    Informe.txtPrecioCosto.Dispose()
                    Informe.lblMargen.Dispose()
                    Informe.txtMargen.Dispose()
            End Select

            If Not Me.checkAgruparFamilia.Checked Then
                Informe.ghFamilia.Dispose()
                Informe.ghSubFamilia.Dispose()
            End If

            Informe.DataSource = dsArticulos

            Informe.Parameters("TipoIVA1").Value = TipoIva1
            Informe.Parameters("TipoIVA2").Value = TipoIva2
            Informe.Parameters("TipoIVA3").Value = TipoIva3
            Informe.RequestParameters = False

            Informe.CreateDocument()

            Dim f As New PreImpreso
            f.Informe.PrintingSystem = Informe.PrintingSystem

            General.AbrirFormulario(f, "Listado de tarifas")

            Me.Close()

        Catch ex As Exception
            MsgBox("Error al cargar los datos del listado", MsgBoxStyle.Exclamation)
        Finally
            Me.Cursor = Cursors.Default
        End Try

        cmd.Connection.Close()

    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.Close()
    End Sub
#End Region

End Class