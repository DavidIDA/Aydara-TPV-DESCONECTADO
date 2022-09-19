Public Class ListadoArticulos

#Region "ListadoArticulos_Load"
    Private Sub ListadoArticulos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtTituloListado.EditValue = Me.Text
        If Me.Text = "Listado de tarifas" Then Me.rgValorado.EditValue = 1
    End Sub
#End Region

#Region "ListadoArticulos_Shown"
    Private Sub ListadoArticulos_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en precios
        Me.maskPrecio.Mask.EditMask = "c" & DecimalesPrecio
    End Sub
#End Region

#Region "ListadoArticulos_KeyUp"
    Private Sub ListadoArticulos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
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

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT Descripcion FROM Articulos WHERE Codigo = '" & Me.txtCodigoInicio.EditValue & "'"
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

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT Descripcion FROM Articulos WHERE Codigo = '" & Me.txtCodigoFin.EditValue & "'"
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

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click

        Dim cmd As New SqlClient.SqlCommand

        Try
            Me.Cursor = Cursors.WaitCursor

            Me.DsListadoArticulos.ListadoArticulos.Clear()

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT ARTICULOS.Codigo, ARTICULOS.Descripcion, FAMILIASARTICULOS.Codigo AS CodigoFamilia, FAMILIASARTICULOS.Descripcion AS DescripcionFamilia, " & _
                              "SUBFAMILIASARTICULOS.Codigo AS CodigoSubFamilia, SUBFAMILIASARTICULOS.Descripcion AS DescripcionSubFamilia, TipoIVA, UnidadCaja, " & _
                              "PrecioCoste, Precio AS PrecioVenta, CodigoProveedor, " & _
                              "ISNULL((SELECT SUM(ExistenciaActual) FROM EXISTENCIAS WHERE Articulo_Id = ARTICULOS.Id),0) AS Existencias " & _
                              "FROM Articulos LEFT JOIN FAMILIASARTICULOS ON ARTICULOS.CodigoFamilia=FAMILIASARTICULOS.Id " & _
                              "LEFT JOIN SUBFAMILIASARTICULOS ON FAMILIASARTICULOS.Id=SUBFAMILIASARTICULOS.Familia_Id AND ARTICULOS.CodigoSubFamilia=SUBFAMILIASARTICULOS.Id"

            'Aplicar filtros
            Dim Filtro As String = String.Empty
            If IsNumeric(Me.txtCodigoInicio.EditValue) Then Filtro = " WHERE ARTICULOS.Codigo>='" & Me.txtCodigoInicio.EditValue & "'"
            If IsNumeric(Me.txtCodigoFin.EditValue) Then Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & "ARTICULOS.Codigo<='" & Me.txtCodigoFin.EditValue & "'"
            If IsNumeric(Me.txtCodigoFamiliaInicio.EditValue) Then Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & "FAMILIASARTICULOS.Codigo>='" & Me.txtCodigoFamiliaInicio.EditValue & "'"
            If IsNumeric(Me.txtCodigoFamiliaFin.EditValue) Then Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & "FAMILIASARTICULOS.Codigo<='" & Me.txtCodigoFamiliaFin.EditValue & "'"
            Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & "ControlBaja=" & Math.Abs(CType(Me.checkControlBaja.EditValue, Integer))

            'Filtro proveedor
            Dim FiltroProveedor As String = String.Empty
            If IsNumeric(Me.txtCodigoProveedor.EditValue) Then
                FiltroProveedor = "("
                FiltroProveedor &= "CodigoProveedor = " & Me.txtCodigoProveedor.EditValue
                FiltroProveedor &= " OR ARTICULOS.Id IN (SELECT Articulo_Id FROM REFERENCIAS_PROVEEDORES WHERE CodigoProveedor = " & Me.txtCodigoProveedor.EditValue & ")"
                FiltroProveedor &= ")"
            End If
            If FiltroProveedor <> String.Empty Then Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & FiltroProveedor

            'Componer grilla
            Me.colDescripcionFamilia.GroupIndex = IIf(Me.checkAgruparFamilia.Checked, 0, -1)
            Me.colDescripcionSubFamilia.GroupIndex = IIf(Me.checkAgruparFamilia.Checked, 1, -1)
            Me.colPrecioCoste.Visible = (Me.rgValorado.EditValue <> 1)
            Me.colPrecioVenta.Visible = (Me.rgValorado.EditValue <> 0)

            cmd.CommandText &= Filtro

            Me.DsListadoArticulos.ListadoArticulos.Load(cmd.ExecuteReader)

            Me.colCodigoProveedor.Visible = (Me.txtCodigoProveedor.Text = String.Empty)

        Catch ex As Exception
            MsgBox("Error al cargar los datos del listado", MsgBoxStyle.Exclamation)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            Me.Cursor = Cursors.Default
        End Try

    End Sub
#End Region

#Region "bttImprimir_Click"
    Private Sub bttImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimir.Click
        Try
            Dim Informe As New DevExpress.XtraPrinting.PrintableComponentLink
            Dim ps As DevExpress.XtraPrinting.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()

            Informe.PaperKind = Printing.PaperKind.A4

            Informe.PageHeaderFooter = Informes.CabeceraInforme(Me.txtTituloListado.EditValue, Nothing)

            Informe.Component = Me.dgBusqueda

            Informe.PrintingSystem = ps

            Informe.CreateDocument()

            Informes.AbrirVistaPrevia(Me.Text, Informe)

        Catch ex As Exception
            MsgBox("Error al generar el informe", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.Close()
    End Sub
#End Region

End Class