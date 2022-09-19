Public Class InventarioArticulos 

#Region "InventarioArticulos_Load"
    Private Sub InventarioArticulos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtCodigoInicio.EditValue = String.Empty
        Me.txtCodigoFin.EditValue = String.Empty
        Me.txtCodigoFamiliaInicio.EditValue = String.Empty
        Me.txtDescripcionFamiliaInicio.EditValue = String.Empty
        Me.txtCodigoFamiliaFin.EditValue = String.Empty
        Me.txtDescripcionFamiliaFin.EditValue = String.Empty
        Me.txtCodigoSubfamiliaInicio.EditValue = String.Empty
        Me.txtDescripcionSubfamiliaInicio.EditValue = String.Empty
        Me.txtCodigoSubfamiliaFin.EditValue = String.Empty
        Me.txtDescripcionSubfamiliaFin.EditValue = String.Empty
        Me.txtCodigoProveedor.EditValue = String.Empty
        Me.txtNombreProveedor.EditValue = String.Empty
        Me.checkValorado.Checked = False
        Me.rgValorado.EditValue = "Coste"
        Me.checkBajoMinimo.Checked = False
        Me.checkExistenciaPositiva.Checked = False
        Me.checkExistenciaNegativa.Checked = False
        Me.checkExistencia0.Checked = False
        Me.checkControlBaja.Checked = False
        Me.checkAgruparFamilia.Checked = True
    End Sub
#End Region

#Region "InventarioArticulos_Shown"
    Private Sub InventarioArticulos_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en precios
        'Me.maskPrecio.Mask.EditMask = "c" & DecimalesPrecio
        Me.maskImporte.Mask.EditMask = "c" & DecimalesImporte
    End Sub
#End Region

#Region "txtCodigoInicio_Validated"
    Private Sub txtCodigoInicio_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoInicio.Validated
        If Not Me.txtCodigoInicio.IsModified Then Exit Sub
        'If IsNumeric(Me.txtCodigoInicio.EditValue) Then Me.txtCodigoInicio.EditValue = Format(CType(Me.txtCodigoInicio.EditValue, Integer), "0000000")
    End Sub
#End Region

#Region "txtCodigoFin_Validated"
    Private Sub txtCodigoFin_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoFin.Validated
        If Not Me.txtCodigoFin.IsModified Then Exit Sub
        'If IsNumeric(Me.txtCodigoFin.EditValue) Then Me.txtCodigoFin.EditValue = Format(CType(Me.txtCodigoFin.EditValue, Integer), "0000000")
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

        Me.txtCodigoSubfamiliaInicio.Properties.ReadOnly = (Me.txtCodigoFamiliaInicio.EditValue <> Me.txtCodigoFamiliaFin.EditValue)
        Me.txtCodigoSubfamiliaFin.Properties.ReadOnly = (Me.txtCodigoFamiliaInicio.EditValue <> Me.txtCodigoFamiliaFin.EditValue)
        If Me.txtCodigoSubfamiliaInicio.Properties.ReadOnly Then Me.txtCodigoSubfamiliaInicio.EditValue = String.Empty
        If Me.txtCodigoSubfamiliaFin.Properties.ReadOnly Then Me.txtCodigoSubfamiliaFin.EditValue = String.Empty

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

        Me.txtCodigoSubfamiliaInicio.Properties.ReadOnly = (Me.txtCodigoFamiliaInicio.EditValue <> Me.txtCodigoFamiliaFin.EditValue)
        Me.txtCodigoSubfamiliaFin.Properties.ReadOnly = (Me.txtCodigoFamiliaInicio.EditValue <> Me.txtCodigoFamiliaFin.EditValue)
        If Me.txtCodigoSubfamiliaInicio.Properties.ReadOnly Then Me.txtCodigoSubfamiliaInicio.EditValue = String.Empty
        If Me.txtCodigoSubfamiliaFin.Properties.ReadOnly Then Me.txtCodigoSubfamiliaFin.EditValue = String.Empty

    End Sub
#End Region

#Region "txtCodigoSubfamiliaInicio_ButtonClick"
    Private Sub txtCodigoSubfamiliaInicio_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoSubfamiliaInicio.ButtonClick
        Try
            If Me.txtCodigoSubfamiliaInicio.Properties.ReadOnly Then Exit Try

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

            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT SUBFAMILIASARTICULOS.Codigo, SUBFAMILIASARTICULOS.Descripcion " & _
                              "FROM FAMILIASARTICULOS INNER JOIN SUBFAMILIASARTICULOS ON FAMILIASARTICULOS.Id=SUBFAMILIASARTICULOS.Familia_Id " & _
                              "WHERE FAMILIASARTICULOS.Codigo='" & Me.txtCodigoFamiliaInicio.EditValue & "'"

            dsSubfamilias.SUBFAMILIASARTICULOS.Load(cmd.ExecuteReader)

            If Buscar(dsSubfamilias, "SUBFAMILIASARTICULOS", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoSubfamiliaInicio.EditValue = ResultadoBusqueda
                Me.txtCodigoSubfamiliaInicio.IsModified = True
                Me.txtCodigoSubfamiliaInicio_Validated(Nothing, Nothing)
            End If

            cmd.Connection.Close()

        Catch ex As Exception
            MsgBox("Error en la búsqeda de familias", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "txtCodigoSubfamiliaInicio_Validated"
    Private Sub txtCodigoSubfamiliaInicio_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoSubfamiliaInicio.Validated
        Try
            If Not Me.txtCodigoSubfamiliaInicio.IsModified Then Exit Sub

            If IsNumeric(Me.txtCodigoSubfamiliaInicio.EditValue) Then Me.txtCodigoSubfamiliaInicio.EditValue = Format(CType(Me.txtCodigoSubfamiliaInicio.EditValue, Integer), "000")

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT SUBFAMILIASARTICULOS.Descripcion " & _
                              "FROM FAMILIASARTICULOS INNER JOIN SUBFAMILIASARTICULOS ON FAMILIASARTICULOS.Id=SUBFAMILIASARTICULOS.Familia_Id " & _
                              "WHERE FAMILIASARTICULOS.Codigo='" & Me.txtCodigoFamiliaInicio.EditValue & "' AND SUBFAMILIASARTICULOS.Codigo='" & Me.txtCodigoSubfamiliaInicio.EditValue & "'"

            Me.txtDescripcionSubfamiliaInicio.EditValue = cmd.ExecuteScalar

            If Me.txtDescripcionSubfamiliaInicio.EditValue = String.Empty Then Me.txtCodigoSubfamiliaInicio.EditValue = String.Empty

            cmd.Connection.Close()


        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoSubfamiliaFin_ButtonClick"
    Private Sub txtCodigoSubfamiliaFin_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoSubfamiliaFin.ButtonClick
        Try
            If Me.txtCodigoSubfamiliaFin.Properties.ReadOnly Then Exit Try

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

            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT SUBFAMILIASARTICULOS.Codigo, SUBFAMILIASARTICULOS.Descripcion " & _
                              "FROM FAMILIASARTICULOS INNER JOIN SUBFAMILIASARTICULOS ON FAMILIASARTICULOS.Id=SUBFAMILIASARTICULOS.Familia_Id " & _
                              "WHERE FAMILIASARTICULOS.Codigo='" & Me.txtCodigoFamiliaInicio.EditValue & "'"

            dsSubfamilias.SUBFAMILIASARTICULOS.Load(cmd.ExecuteReader)

            If Buscar(dsSubfamilias, "SUBFAMILIASARTICULOS", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoSubfamiliaFin.EditValue = ResultadoBusqueda
                Me.txtCodigoSubfamiliaFin.IsModified = True
                Me.txtCodigoSubfamiliaFin_Validated(Nothing, Nothing)
            End If

            cmd.Connection.Close()

        Catch ex As Exception
            MsgBox("Error en la búsqeda de familias", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "txtCodigoSubfamiliaFin_Validated"
    Private Sub txtCodigoSubfamiliaFin_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoSubfamiliaFin.Validated
        Try
            If Not Me.txtCodigoSubfamiliaFin.IsModified Then Exit Sub

            If IsNumeric(Me.txtCodigoSubfamiliaFin.EditValue) Then Me.txtCodigoSubfamiliaFin.EditValue = Format(CType(Me.txtCodigoSubfamiliaFin.EditValue, Integer), "000")

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT SUBFAMILIASARTICULOS.Descripcion " & _
                              "FROM FAMILIASARTICULOS INNER JOIN SUBFAMILIASARTICULOS ON FAMILIASARTICULOS.Id=SUBFAMILIASARTICULOS.Familia_Id " & _
                              "WHERE FAMILIASARTICULOS.Codigo='" & Me.txtCodigoFamiliaInicio.EditValue & "' AND SUBFAMILIASARTICULOS.Codigo='" & Me.txtCodigoSubfamiliaFin.EditValue & "'"

            Me.txtDescripcionSubfamiliaFin.EditValue = cmd.ExecuteScalar

            If Me.txtDescripcionSubfamiliaFin.EditValue = String.Empty Then Me.txtCodigoSubfamiliaFin.EditValue = String.Empty

            cmd.Connection.Close()


        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
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
        Try
            Dim Informe As New DevExpress.XtraPrinting.PrintableComponentLink
            Dim ps As DevExpress.XtraPrinting.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()

            Informe.PaperKind = Printing.PaperKind.A4

            Informe.PageHeaderFooter = Informes.CabeceraInforme("Listado inventario de artículos", Nothing)

            Informe.Component = Me.dgArticulos

            Informe.PrintingSystem = ps

            Informe.CreateDocument()

            Informes.AbrirVistaPrevia("Listado inventario de artículos", Informe)

        Catch ex As Exception
            MsgBox("Error al generar el informe", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "checkValorado_CheckedChanged"
    Private Sub checkValorado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkValorado.CheckedChanged
        Me.rgValorado.Visible = Me.checkValorado.Checked
    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click

        Dim fWait As New DevExpress.Utils.WaitDialogForm("Buscando artículos", "Calculando inventario", New Drawing.Size(300, 75))

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.CommandTimeout = 600000
        cmd.Connection.Open()

        Try
            Me.Cursor = Cursors.WaitCursor

            Me.DsListadoArticulos.Clear()

            Dim FechaValoracion As Date = "31-12-9999"
            If IsDate(Me.txtFechaHasta.EditValue) Then FechaValoracion = Me.txtFechaHasta.EditValue

            cmd.CommandText = "SELECT ARTICULOS.Codigo, ARTICULOS.Descripcion, FAMILIASARTICULOS.Codigo AS CodigoFamilia, FAMILIASARTICULOS.Codigo + ': ' + FAMILIASARTICULOS.Descripcion AS DescripcionFamilia, " & _
                              "SUBFAMILIASARTICULOS.Codigo AS CodigoSubFamilia, SUBFAMILIASARTICULOS.Codigo + ': ' + SUBFAMILIASARTICULOS.Descripcion AS DescripcionSubFamilia, ISNULL(" & IIf(Me.rgValorado.EditValue = "Coste", "PrecioCoste", "Precio") & ",0) AS Precio, CodigoProveedor, " & _
                              "ISNULL((SELECT TOP 1 Precio FROM ALBARANES_COMPRAS INNER JOIN ALBARANES_COMPRAS_LINEAS ON ALBARANES_COMPRAS.Id = ALBARANES_COMPRAS_LINEAS.AlbaranCompra_Id WHERE CodigoArticulo = ARTICULOS.Codigo AND ALBARANES_COMPRAS.Fecha <= '" & FechaValoracion & "' ORDER BY ALBARANES_COMPRAS.Fecha DESC, ALBARANES_COMPRAS.Id DESC), 0) AS UltimaCompra"

            If Not (GestionTallas Or GestionColores) Then
                cmd.CommandText &= ", ISNULL((SELECT SUM(ExistenciaActual) FROM EXISTENCIAS WHERE Articulo_Id=ARTICULOS.Id),0) AS Existencias"
            End If

            cmd.CommandText &= " FROM Articulos LEFT JOIN FAMILIASARTICULOS ON ARTICULOS.CodigoFamilia=FAMILIASARTICULOS.Id " & _
                               "LEFT JOIN SUBFAMILIASARTICULOS ON FAMILIASARTICULOS.Id=SUBFAMILIASARTICULOS.Familia_Id AND ARTICULOS.CodigoSubFamilia=SUBFAMILIASARTICULOS.Id"

            'Aplicar filtros
            Dim Filtro As String = String.Empty
            If IsNumeric(Me.txtCodigoInicio.EditValue) Then Filtro = " WHERE ARTICULOS.Codigo>='" & Me.txtCodigoInicio.EditValue & "'"
            If IsNumeric(Me.txtCodigoFin.EditValue) Then Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & "ARTICULOS.Codigo<='" & Me.txtCodigoFin.EditValue & "'"
            If IsNumeric(Me.txtCodigoFamiliaInicio.EditValue) Then Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & "FAMILIASARTICULOS.Codigo>='" & Me.txtCodigoFamiliaInicio.EditValue & "'"
            If IsNumeric(Me.txtCodigoFamiliaFin.EditValue) Then Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & "FAMILIASARTICULOS.Codigo<='" & Me.txtCodigoFamiliaFin.EditValue & "'"
            If IsNumeric(Me.txtCodigoSubfamiliaInicio.EditValue) Then Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & "SUBFAMILIASARTICULOS.Codigo>='" & Me.txtCodigoSubfamiliaInicio.EditValue & "'"
            If IsNumeric(Me.txtCodigoSubfamiliaFin.EditValue) Then Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & "SUBFAMILIASARTICULOS.Codigo<='" & Me.txtCodigoSubfamiliaFin.EditValue & "'"
            Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & "ControlBaja=" & IIf(Me.checkControlBaja.Checked, "ControlBaja", 0)

            'Filtro proveedor
            Dim FiltroProveedor As String = String.Empty
            If IsNumeric(Me.txtCodigoProveedor.EditValue) Then
                FiltroProveedor = "("
                FiltroProveedor &= "CodigoProveedor = " & Me.txtCodigoProveedor.EditValue
                FiltroProveedor &= " OR ARTICULOS.Id IN (SELECT Articulo_Id FROM REFERENCIAS_PROVEEDORES WHERE CodigoProveedor = " & Me.txtCodigoProveedor.EditValue & ")"
                FiltroProveedor &= ")"
            End If
            If FiltroProveedor <> String.Empty Then Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & FiltroProveedor

            ''Filtro existencias
            'Dim FiltroExistencias As String = String.Empty
            'If Me.checkExistenciaPositiva.Checked Or Me.checkExistenciaNegativa.Checked Or Me.checkExistencia0.Checked Then
            '    FiltroExistencias = "("
            '    If Me.checkExistenciaPositiva.Checked Then
            '        FiltroExistencias &= "(SELECT SUM(ExistenciaActual) FROM EXISTENCIAS WHERE Articulo_Id=ARTICULOS.Id) > 0"
            '    End If
            '    If Me.checkExistenciaNegativa.Checked Then
            '        If FiltroExistencias <> "(" Then FiltroExistencias &= " OR "
            '        FiltroExistencias &= "(SELECT SUM(ExistenciaActual) FROM EXISTENCIAS WHERE Articulo_Id=ARTICULOS.Id) < 0"
            '    End If
            '    If Me.checkExistencia0.Checked Then
            '        If FiltroExistencias <> "(" Then FiltroExistencias &= " OR "
            '        FiltroExistencias &= "(SELECT SUM(ExistenciaActual) FROM EXISTENCIAS WHERE Articulo_Id=ARTICULOS.Id) = 0"
            '    End If
            '    FiltroExistencias &= ")"
            'End If
            'If FiltroExistencias <> String.Empty Then Filtro &= IIf(Filtro = String.Empty, " WHERE ", " AND ") & FiltroExistencias

            If Me.checkBajoMinimo.Checked Then Filtro &= " AND (SELECT SUM(ExistenciaActual) FROM EXISTENCIAS WHERE Articulo_Id=ARTICULOS.Id)<(SELECT SUM(StockMinimo) FROM EXISTENCIAS WHERE Articulo_Id=ARTICULOS.Id)"

            cmd.CommandText &= Filtro

            Me.DsListadoArticulos.ListadoInventario.Load(cmd.ExecuteReader)

            If GestionTallas Or GestionColores Then

                'Cargar existencias de artículos
                cmd.CommandText = "SELECT ARTICULOS.Codigo, Existencias.ExistenciaActual, StockMinimo, " & IIf(Me.rgValorado.EditValue = "Coste", "ARTICULOS.PrecioCoste", "CASE WHEN EXISTENCIAS.PrecioVenta<>0 THEN EXISTENCIAS.PrecioVenta ELSE Articulos.Precio END") & " AS Precio, EXISTENCIAS.CodigoColor, EXISTENCIAS.CodigoTalla " & _
                                  "FROM ARTICULOS LEFT JOIN FAMILIASARTICULOS ON ARTICULOS.CodigoFamilia=FAMILIASARTICULOS.Id " & _
                                  "LEFT JOIN SUBFAMILIASARTICULOS ON FAMILIASARTICULOS.Id=SUBFAMILIASARTICULOS.Familia_Id AND ARTICULOS.CodigoSubFamilia=SUBFAMILIASARTICULOS.Id " & _
                                  "INNER JOIN EXISTENCIAS ON ARTICULOS.Id=EXISTENCIAS.Articulo_Id"

                'If Not Me.checkSinExistencias.Checked Then Filtro &= " AND Existencias.ExistenciaActual<>0"
                If Me.checkBajoMinimo.Checked Then Filtro &= " AND Existencias.ExistenciaActual<Existencias.StockMinimo"

                cmd.CommandText &= Filtro

                Me.DsListadoArticulos.ListadoInventario_TallasColores.Load(cmd.ExecuteReader)

                'Buscar descripciones colores y tallas
                Dim rExistencias As dsListadoArticulos.ListadoInventario_TallasColoresRow
                Dim i As Integer
                For i = 0 To Me.DsListadoArticulos.ListadoInventario_TallasColores.Rows.Count - 1
                    rExistencias = Me.DsListadoArticulos.ListadoInventario_TallasColores.Rows(i)
                    If GestionColores Then rExistencias.DescripcionColor = DameDescripcionColor(rExistencias.CodigoColor)
                    If GestionTallas Then rExistencias.DescripcionTalla = DameTallaArticulo(rExistencias.Codigo, rExistencias.CodigoTalla)
                Next
            End If

            'Calcular existencias a una fecha
            If Not Me.txtFechaHasta.EditValue Is Nothing Then

                Dim dsArticulo As New dsArticulos

                For i As Integer = 0 To Me.DsListadoArticulos.ListadoInventario.Count - 1
                    With Me.DsListadoArticulos.ListadoInventario(i)

                        fWait.SetCaption("Calculando existencias artículo " & i + 1 & " de " & Me.DsListadoArticulos.ListadoInventario.Count)

                        Dim dr As SqlClient.SqlDataReader

                        Dim IdArticulo As Integer = 0
                        Dim FechaInventario As Date = Me.txtFechaHasta.EditValue
                        Dim UnidadesInventario As Double = 0

                        cmd.CommandText = "SELECT ARTICULOS.Id, HISTORICO_INVENTARIO.Fecha, HISTORICO_INVENTARIO.Cantidad " & _
                                          "FROM HISTORICO_INVENTARIO INNER JOIN ARTICULOS ON HISTORICO_INVENTARIO.Articulo_Id = ARTICULOS.Id " & _
                                          "WHERE ARTICULOS.Codigo='" & .Codigo & "' AND HISTORICO_INVENTARIO.Fecha <= '" & FechaInventario & "' ORDER BY HISTORICO_INVENTARIO.Fecha DESC"

                        dr = cmd.ExecuteReader
                        If dr.Read Then
                            IdArticulo = dr("Id")
                            FechaInventario = dr("Fecha")
                            UnidadesInventario = dr("Cantidad")
                        End If
                        dr.Close()

                        If FechaInventario <> Me.txtFechaHasta.EditValue Then

                            .Existencias = UnidadesInventario

                            dsArticulo.CargarMovimientos(IdArticulo, FechaInventario, Me.txtFechaHasta.EditValue)

                            For mov As Integer = 0 To dsArticulo.Movimientos.Count - 1
                                If Not dsArticulo.Movimientos(mov).IsEntradaNull Then .Existencias += dsArticulo.Movimientos(mov).Entrada
                                If Not dsArticulo.Movimientos(mov).IsSalidaNull Then .Existencias -= dsArticulo.Movimientos(mov).Salida
                            Next

                        End If

                    End With
                Next

            End If

            'Filtro existencias
            Dim FiltroExistencias As String = String.Empty
            If Me.checkExistenciaPositiva.Checked Or Me.checkExistenciaNegativa.Checked Or Me.checkExistencia0.Checked Then
                FiltroExistencias = "("
                If Me.checkExistenciaPositiva.Checked Then
                    FiltroExistencias &= "Existencias > 0"
                End If
                If Me.checkExistenciaNegativa.Checked Then
                    If FiltroExistencias <> "(" Then FiltroExistencias &= " OR "
                    FiltroExistencias &= "Existencias < 0"
                End If
                If Me.checkExistencia0.Checked Then
                    If FiltroExistencias <> "(" Then FiltroExistencias &= " OR "
                    FiltroExistencias &= "Existencias = 0"
                End If
                FiltroExistencias &= ")"
            End If
            Me.ListadoInventarioBindingSource.Filter = FiltroExistencias

            If Me.checkAgruparFamilia.Checked Then
                Me.colDescripcionFamilia.Group()
            Else
                Me.colDescripcionFamilia.UnGroup()
            End If

            If Me.checkValorado.Checked Then
                Me.colPrecio.Visible = True
                Me.colImporte.Visible = True

                'Calcular totales
                Dim i As Integer
                Dim rArticulo As dsListadoArticulos.ListadoInventarioRow
                For i = 0 To Me.DsListadoArticulos.ListadoInventario.Rows.Count - 1
                    rArticulo = Me.DsListadoArticulos.ListadoInventario.Rows(i)
                    If Me.rgValorado.EditValue = "Compra" And rArticulo.UltimaCompra <> 0 Then rArticulo.Precio = rArticulo.UltimaCompra
                    rArticulo.Importe = rArticulo.Existencias * rArticulo.Precio
                Next

                Me.gvArticulos.GroupSummary.Clear()
                Me.gvArticulos.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, Me.colImporte.FieldName, Me.colImporte, "{0:c2}")
                Me.gvArticulos.OptionsView.ShowFooter = True

            Else
                Me.gvArticulos.GroupSummary.Clear()
                Me.colPrecio.Visible = False
                Me.colImporte.Visible = False
                Me.gvArticulos.OptionsView.ShowFooter = False
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los datos del listado", MsgBoxStyle.Exclamation)
        Finally
            cmd.Connection.Close()
            Me.Cursor = Cursors.Default
            fWait.Close()
        End Try

    End Sub
#End Region

#Region "bttReiniciar_Click"
    Private Sub bttReiniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttReiniciar.Click
        Me.InventarioArticulos_Load(Nothing, Nothing)
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.Close()
    End Sub
#End Region

End Class