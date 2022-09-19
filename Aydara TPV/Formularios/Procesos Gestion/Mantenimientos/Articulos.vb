Public Class Articulos

    Dim rArticulo As dsArticulos.ARTICULOSRow

#Region "Articulos_FormClosing"
    Private Sub Articulos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.bttCancelar.Text = "Cancelar" And Me.DsArticulos.HasChanges Then
            If MsgBox("Está editando un artículo. ¿Seguro que desea salir sin guardar los cambios?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then e.Cancel = True Else Me.Dispose()
        Else
            'Me.Dispose()
        End If
    End Sub
#End Region

#Region "Articulos_KeyUp"
    Private Sub Articulos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "Articulos_Shown"
    Private Sub Articulos_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        'Etiqueta electrónica
        Me.gcEtiquetaElectronica.Visible = EtiquetaElectronica
        Me.DsArticulos.FORMATOS_EE.AddFORMATOS_EERow(0, "NORMAL")
        Me.DsArticulos.FORMATOS_EE.AddFORMATOS_EERow(1, "GRANDE")

        If Not GestionTallas Then
            Me.lblCodigoTalla.Visible = False
            Me.txtCodigoTalla.Visible = False
            Me.lblTipoIVA.Left -= 143
            Me.cmbTipoIVA.Left -= 143
            Me.lblTextoImpuesto.Left -= 143
        End If

        'Datos IVA
        Me.lblTextoImpuesto.Text = TextoImpuesto
        Me.cmbTipoIVA.Properties.Items(0) = IIf(TipoIva1 Mod 1 = 0, Int(TipoIva1), TipoIva1)
        Me.cmbTipoIVA.Properties.Items(1) = IIf(TipoIva2 Mod 1 = 0, Int(TipoIva2), TipoIva2)
        Me.cmbTipoIVA.Properties.Items(2) = IIf(TipoIva3 Mod 1 = 0, Int(TipoIva3), TipoIva3)
        Me.cmbTipoIVA.Properties.Items(3) = IIf(TipoIva4 Mod 1 = 0, Int(TipoIva4), TipoIva4)

        'Decimales en precios
        Me.txtPrecioCoste.Properties.Mask.EditMask = "c3" '& DecimalesPrecio
        Me.txtPrecioVenta.Properties.Mask.EditMask = "c" & DecimalesPrecio
        Me.maskPrecio.Mask.EditMask = "c" & DecimalesPrecio
        Me.maskPrecio_Proveedor.Mask.EditMask = "c" & DecimalesPrecio
        Me.txtImporteEcoraee.Properties.Mask.EditMask = "c" & DecimalesPrecio

        'Me.colPrecio.DisplayFormat.FormatString = "c" & DecimalesPrecio

        Me.colCodigoBarras_Color.Visible = GestionColores
        Me.colCodigoBarras_Talla.Visible = GestionTallas
        Me.colDescripcionColor.Visible = GestionColores
        Me.colDescripciontalla.Visible = GestionTallas

        Me.DsArticulos.ARTICULOS.CodigoTallaColumn.DefaultValue = IIf(GestionTallas, System.DBNull.Value, 0)

        'Comprobar si lleva gestión de tallas o colores
        If Not GestionColores And Not GestionTallas Then
            Me.txtExistenciaInicial.DataBindings.Add("EditValue", Me.DsArticulos.EXISTENCIAS, "ExistenciaInicial")
            Me.txtExistenciasActual.DataBindings.Add("EditValue", Me.DsArticulos.EXISTENCIAS, "ExistenciaActual")
            Me.txtStockMinimo.DataBindings.Add("EditValue", Me.DsArticulos.EXISTENCIAS, "StockMinimo")
            Me.txtStockMaximo.DataBindings.Add("EditValue", Me.DsArticulos.EXISTENCIAS, "StockMaximo")
            Me.TabArticulo.TabPages.Remove(Me.TabTallasColores)
            Exit Sub
        End If

        'Si lleva gestión de tallas mostrar grilla de existencias
        Me.dgExistencias.Visible = True
        Me.colExistenciasCodigoBarras.Visible = True
        Me.colExistenciasTalla.Visible = GestionTallas

        'Si lleva gestión de colores mostrar grilla de colores
        Me.dgColores.Visible = GestionColores
        Me.NavListadoColores.Visible = GestionColores

        'Posición de existencias y carga de colores si lleva gestión de colores
        If GestionColores Then
            Me.COLORESTableAdapter.Fill(Me.DsArticulos.COLORES)
        Else
            Me.dgExistencias.Left = Me.dgColores.Left
        End If

        Me.lblColorSeleccionado.Visible = GestionColores
        Me.lblEtiquetaColor.Visible = GestionColores

    End Sub
#End Region

#Region "bttNuevo_Click"
    Private Sub bttNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttNuevo.Click
        Try
            Me.DsArticulos.Clear()
            Me.DsInventario.Clear()

            Me.DsArticulos.ARTICULOS.AddARTICULOSRow(Me.DsArticulos.ARTICULOS.NewARTICULOSRow)
            rArticulo = Me.DsArticulos.ARTICULOS.Rows(0)

            ActivaDesactivaMenu(False)
            Me.bttGuardar.Enabled = False
            'ActivaDesactivaCampos(False)
            Me.txtCodigo.Properties.ReadOnly = False
            Me.txtCodigo.Focus()
            Me.txtFechaAlta.EditValue = Date.Now
            Me.gcPromocion.Visible = False

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttModificar_Click"
    Private Sub bttModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttModificar.Click
        Try
            ActivaDesactivaMenu(False)
            ActivaDesactivaCampos(False)
            Me.txtDescripcion.Focus()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click
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
                Me.txtCodigo.Text = ResultadoBusqueda
                Me.txtCodigo.IsModified = True
                Me.txtCodigo_Validated(Nothing, Nothing)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttEliminar_Click"
    Private Sub bttEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttEliminar.Click
        Try
            If MsgBox("¿Seguro que desea eliminar el artículo seleccionado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar artículo") = MsgBoxResult.Yes Then

                'Eliminar Codigo de Barras de Articulo
                While Me.gvCodigoBarras.RowCount > 0
                    Me.gvCodigoBarras.DeleteRow(0)
                End While

                'Me.gvCodigoBarras.SelectRows(0, Me.gvCodigoBarras.RowCount - 1)
                'Me.gvCodigoBarras.DeleteSelectedRows()
                Me.CODIGO_BARRASTableAdapter.Update(Me.DsArticulos.CODIGO_BARRAS)

                Me.ARTICULOSBindingSource.RemoveCurrent()
                Me.ARTICULOSTableAdapter.Update(Me.DsArticulos.ARTICULOS)

                Me.ActivaDesactivaMenu(True)
                Me.txtCodigo.Focus()

            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Try
            If sender.text = "Salir" Then Me.Close() : Exit Sub

            'If MsgBox("¿Seguro que desea deshacer los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Deshacer cambios") = MsgBoxResult.No Then Exit Sub
            Me.ARTICULOSBindingSource.CancelEdit()
            If rArticulo.RowState = DataRowState.Added Then
                Me.DsArticulos.Clear()
                Me.gcPromocion.Visible = False
            End If

            ActivaDesactivaMenu(True)
            ActivaDesactivaCampos(True)

            Me.txtCodigo.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttGuardar_Click"
    Private Sub bttGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttGuardar.Click
        Try
            'If MsgBox("¿Seguro que desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar cambios") = MsgBoxResult.No Then Exit Sub

            Me.ARTICULOSBindingSource.EndEdit()

            'Comprobar código de artículo
            If Me.txtCodigo.Text = String.Empty Then
                MsgBox("Introduce el código del artículo", MsgBoxStyle.Information, "Falta código de artículo")
                Me.txtCodigo.Focus()
                Exit Sub
            End If

            If GestionTallas And Me.txtCodigoTalla.Text = String.Empty Then
                MsgBox("Introduce el código de tallaje", MsgBoxStyle.Information, "Falta código de talla")
                Me.txtCodigoTalla.Focus()
                Exit Sub
            End If

            If Me.txtCodigoFamilia.Text = String.Empty Then
                MsgBox("Introduce el código del familia", MsgBoxStyle.Information, "Falta código de familia")
                Me.txtCodigoFamilia.Focus()
                Exit Sub
            End If

            If Me.txtCodigoSubfamilia.Text = String.Empty Then
                MsgBox("Introduce el código del subfamilia", MsgBoxStyle.Information, "Falta código de subfamilia")
                Me.txtCodigoSubfamilia.Focus()
                Exit Sub
            End If

            If GestionColores And Me.DsArticulos.ARTICULOS_COLORES.Rows.Count = 0 Then
                MsgBox("Introduce los colores del artículo", MsgBoxStyle.Information, "Falta asignar colores")
                Me.dgColores.Focus()
                Exit Sub
            End If

            'Tipo de IVA
            rArticulo.TipoIva= Me.cmbTipoIVA.SelectedIndex + 1

            'Guardar en base de datos
            Me.ARTICULOSTableAdapter.Update(Me.DsArticulos.ARTICULOS)

            Dim i As Integer

            'Guardar códigos de barras en base de datos
            For i = 0 To Me.gvCodigoBarras.RowCount - 1
                Me.gvCodigoBarras.SetRowCellValue(i, Me.colArticulo_Id, rArticulo.Id)
            Next
            Me.CODIGOBARRASBindingSource.EndEdit()
            Me.CODIGO_BARRASTableAdapter.Update(Me.DsArticulos.CODIGO_BARRAS)

            'Guardar referencias de proveedores en base de datos
            Me.REFERENCIASPROVEEDORESBindingSource.EndEdit()
            For i = 0 To Me.DsArticulos.REFERENCIAS_PROVEEDORES.Count - 1
                With Me.DsArticulos.REFERENCIAS_PROVEEDORES(i)
                    If Not .RowState = DataRowState.Deleted Then .Articulo_Id = rArticulo.Id
                End With
            Next
            Me.REFERENCIAS_PROVEEDORESTableAdapter.Update(Me.DsArticulos.REFERENCIAS_PROVEEDORES)

            'Guardar inventarios en base de datos
            Me.HISTORICOINVENTARIOBindingSource.EndEdit()
            For i = 0 To Me.DsInventario.HISTORICO_INVENTARIO.Count - 1
                With Me.DsInventario.HISTORICO_INVENTARIO(i)
                    If Not .RowState = DataRowState.Deleted Then .Articulo_Id = rArticulo.Id
                End With
            Next
            Me.HISTORICO_INVENTARIOTableAdapter.Update(Me.DsInventario.HISTORICO_INVENTARIO)

            'Guardar colores en base de datos
            For i = 0 To Me.gvColores.RowCount - 1
                Me.gvColores.SetRowCellValue(i, Me.colColores_Articulo_Id, rArticulo.Id)
            Next
            Me.ARTICULOSCOLORESBindingSource.EndEdit()
            Me.ARTICULOS_COLORESTableAdapter.Update(Me.DsArticulos.ARTICULOS_COLORES)

            'Guardar existencias en base de datos
            Dim rExistencias As dsArticulos.EXISTENCIASRow
            For i = Me.DsArticulos.EXISTENCIAS.Rows.Count - 1 To 0 Step -1
                rExistencias = DsArticulos.EXISTENCIAS.Rows(i)
                If rExistencias.RowState <> DataRowState.Deleted Then rExistencias.Articulo_Id = rArticulo.Id
                'If rExistencias.RowState = DataRowState.Added And rExistencias.ExistenciaInicial = 0 And rExistencias.ExistenciaActual = 0 And rExistencias.StockMinimo = 0 And rExistencias.StockMaximo = 0 And rExistencias.PrecioVenta = 0 Then
                '    rExistencias.Delete()
                'Else
                '    rExistencias.Articulo_Id = rArticulo.Item("Id")
                'End If
            Next
            Me.EXISTENCIASBindingSource.EndEdit()
            Me.EXISTENCIASTableAdapter.Update(Me.DsArticulos.EXISTENCIAS)

            Me.ActivaDesactivaMenu(True)
            Me.ActivaDesactivaCampos(True)

            Me.txtCodigo.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigo_ButtonClick"
    Private Sub txtCodigo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigo.ButtonClick
        Me.bttBuscar_Click(Nothing, Nothing)
    End Sub
#End Region

#Region "txtCodigo_Validated"
    Public Sub txtCodigo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Validated
        Try
            If Not Me.txtCodigo.IsModified Or Me.txtCodigo.Text = String.Empty Then Exit Sub

            Me.Cursor = Cursors.WaitCursor

            Dim CodigoArticulo As String

            'Si es nuevo registro comprobar si existe el código de artículo
            If Me.bttCancelar.Text = "Cancelar" Then
                Dim cmd As New SqlClient.SqlCommand
                cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
                cmd.Connection.Open()
                cmd.CommandText = "SELECT * FROM ARTICULOS WHERE Codigo='" & Me.txtCodigo.Text & "'"
                If CType(cmd.ExecuteReader, SqlClient.SqlDataReader).HasRows Then
                    MsgBox("Ya existe un artículo con ese código", MsgBoxStyle.Information, "Ya existe")
                    Me.txtCodigo.Text = String.Empty
                    Me.txtCodigo.Focus()
                Else
                    Me.bttGuardar.Enabled = True
                    ActivaDesactivaCampos(False)
                End If
                Exit Sub
            End If

            'Comprobar código
            CodigoArticulo = Me.txtCodigo.Text
            Me.ARTICULOSTableAdapter.DameArticulo(Me.DsArticulos.ARTICULOS, CodigoArticulo)

            'Comprobar si es un código de barras
            If Me.ARTICULOSBindingSource.Count = 0 Then
                Dim cmd As New SqlClient.SqlCommand
                cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
                cmd.Connection.Open()
                cmd.CommandText = "SELECT ISNULL(Codigo,'') FROM ARTICULOS " & _
                                  "INNER JOIN Codigo_Barras on ARTICULOS.Id=Codigo_Barras.Articulo_Id " & _
                                  "WHERE Codigo_Barras.CodigoBarras='" & CodigoArticulo & "'"
                Dim Codigo As String = cmd.ExecuteScalar
                If Codigo <> String.Empty Then CodigoArticulo = Codigo
                cmd.Connection.Close()
            End If

            'Mostrar información del artículo
            Me.ARTICULOSTableAdapter.DameArticulo(Me.DsArticulos.ARTICULOS, CodigoArticulo)
            Me.DsArticulos.Movimientos.Clear()

            If Me.ARTICULOSBindingSource.Count = 0 Then
                If MsgBox("No existe ningún artículo con ese código." & vbCrLf & "¿Desea dar de alta un nuevo artículo?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "No existe") = MsgBoxResult.Yes Then
                    Me.bttNuevo_Click(Nothing, Nothing)
                    Me.txtCodigo.Text = CodigoArticulo
                    Me.txtDescripcion.Focus()
                    Me.bttGuardar.Enabled = True
                    ActivaDesactivaCampos(False)
                Else
                    ActivaDesactivaMenu(True)
                    ActivaDesactivaCampos(True)
                    Me.txtCodigo.Focus()
                End If
            Else
                rArticulo = Me.DsArticulos.ARTICULOS.Rows(0)
                ActivaDesactivaMenu(True)
                ActivaDesactivaCampos(True)
                Me.txtCodigo.Focus()
            End If

            'Buscar promociones
            Dim Promocion As Almacen.DatosPromocion
            Promocion = DamePrecioPromocion(CodigoArticulo, -1, -1)
            If Promocion.CodigoArticulo <> String.Empty Then
                If Promocion.Precio <> 0 And Promocion.UnidadesSinCargo <> 0 Then
                    Me.lblPrecioPromocion.Font = New Font(Me.lblPrecioPromocion.Font.FontFamily, 10, FontStyle.Bold)
                    Me.lblPrecioPromocion.Text = Math.Round(Promocion.Precio, DecimalesPrecio, MidpointRounding.AwayFromZero) & vbCrLf & Int(Promocion.FraccionSinCargo) & " - " & Int(Promocion.UnidadesSinCargo)
                Else
                    Me.lblPrecioPromocion.Font = New Font(Me.lblPrecioPromocion.Font.FontFamily, 20, FontStyle.Bold)
                    If Promocion.Precio <> 0 Then
                        Me.lblPrecioPromocion.Text = Math.Round(Promocion.Precio, DecimalesPrecio, MidpointRounding.AwayFromZero)
                    Else
                        Me.lblPrecioPromocion.Text = Int(Promocion.FraccionSinCargo) & " - " & Int(Promocion.UnidadesSinCargo)
                    End If
                End If
                Me.lblValidezPromocion.Text = "Válido hasta el " & Promocion.FechaFinal
                Me.gcPromocion.Visible = True
            Else
                Me.gcPromocion.Visible = False
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
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
                Me.txtCodigoProveedor.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error al mostrar listado de proveedores", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "txtCodigoproveedor_ButtonClick"
    Private Sub txtCodigoproveedor_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoProveedor.ButtonClick
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
                Me.txtCodigoEnvase.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error al mostrar listado de proveedores", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "DatosFamilia"
    Public Sub DatosFamilia()
        Try
            Dim dr As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT * FROM FAMILIASARTICULOS WHERE Id=" & IIf(IsNumeric(rArticulo.Item("CodigoFamilia")), rArticulo.Item("CodigoFamilia"), -1)
            dr = cmd.ExecuteReader

            If dr.Read Then
                rArticulo.Item("CodigoFamilia") = dr("Id")
                Me.txtCodigoFamilia.Text = dr("Codigo")
                Me.txtDescripcionFamilia.Text = dr("Descripcion")
            Else
                rArticulo.Item("CodigoFamilia") = System.DBNull.Value
                Me.txtCodigoFamilia.Text = String.Empty
                Me.txtDescripcionFamilia.Text = String.Empty
            End If
            dr.Close()

            cmd.CommandText = "SELECT * FROM SUBFAMILIASARTICULOS WHERE Id=" & IIf(IsNumeric(rArticulo.Item("CodigoSubfamilia")), rArticulo.Item("CodigoSubfamilia"), -1) & _
                              " AND Familia_id=" & IIf(IsNumeric(rArticulo.Item("CodigoFamilia")), rArticulo.Item("CodigoFamilia"), -1)
            dr = cmd.ExecuteReader
            If dr.Read Then
                rArticulo.Item("CodigoSubfamilia") = dr("Id")
                Me.txtCodigoSubfamilia.Text = dr("Codigo")
                Me.txtDescripcionSubfamilia.Text = dr("Descripcion")
            Else
                rArticulo.Item("CodigoSubfamilia") = System.DBNull.Value
                Me.txtCodigoSubfamilia.Text = String.Empty
                Me.txtDescripcionSubfamilia.Text = String.Empty
            End If
            dr.Close()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "DatosProveedor"
    Private Sub DatosProveedor()
        Try
            If Not IsNumeric(Me.txtCodigoProveedor.EditValue) Then
                Me.txtNombreProveedor.Text = String.Empty
                Exit Sub
            End If

            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT Nombre FROM PROVEEDORES WHERE Codigo=" & Int(Me.txtCodigoProveedor.EditValue)

            Me.txtNombreProveedor.Text = cmd.ExecuteScalar

            cmd.Connection.Close()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "DatosEnvase"
    Private Sub DatosEnvase()
        Try
            Dim dr As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT Descripcion FROM ARTICULOS WHERE Codigo='" & Me.txtCodigoEnvase.Text & "'"
            dr = cmd.ExecuteReader

            If dr.Read And Me.txtCodigoEnvase.EditValue <> Me.txtCodigo.EditValue Then
                Me.txtDescripcionEnvase.Text = dr("Descripcion")
            Else
                Me.txtCodigoEnvase.EditValue = String.Empty
                Me.txtDescripcionEnvase.Text = String.Empty
            End If
            dr.Close()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "DatosTalla"
    Public Sub DatosTalla()
        Try
            RemoveHandler txtCodigoTalla.EditValueChanged, AddressOf txtCodigoTalla_EditValueChanged

            If Not IsNumeric(Me.txtCodigoTalla.EditValue) Then Exit Sub

            Dim rTallas As dsArticulos.TALLASRow
            Dim rExistencias As dsArticulos.EXISTENCIASRow

            'Vaciar tabla de tallas y existencias
            Me.DsArticulos.TALLAS.Clear()
            Me.DsArticulos.EXISTENCIAS.Clear()

            If Me.DsArticulos.ARTICULOS.Rows.Count = 0 Then Exit Sub

            Dim dr As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand
            Dim i As Integer, j As Integer, filas As Integer

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            'Cargar existencias actuales
            cmd.CommandText = "SELECT * FROM EXISTENCIAS " & _
                              "WHERE Articulo_Id=" & rArticulo.Item("Id") & " AND CodigoTienda=" & CodigoTienda

            If Not GestionTallas Then cmd.CommandText += " AND CodigoTalla=1"

            If Not GestionColores Then cmd.CommandText += " AND CodigoColor=0"

            Me.DsArticulos.EXISTENCIAS.Load(cmd.ExecuteReader)

            If Not GestionColores And Not GestionTallas Then
                If Me.DsArticulos.EXISTENCIAS.Rows.Count = 0 Then
                    rExistencias = Me.DsArticulos.EXISTENCIAS.NewEXISTENCIASRow
                    rExistencias.CodigoTienda = CodigoTienda
                    rExistencias.Articulo_Id = rArticulo.Item("Id")
                    rExistencias.CodigoColor = 0
                    rExistencias.CodigoTalla = 1
                    Me.DsArticulos.EXISTENCIAS.AddEXISTENCIASRow(rExistencias)
                    Exit Sub
                End If
            End If

            'Cargar tallas
            cmd.CommandText = "SELECT * FROM TALLAS WHERE CodigoTalla=" & IIf(GestionTallas, IIf(IsNumeric(Me.txtCodigoTalla.EditValue), Me.txtCodigoTalla.EditValue, -1), 0)
            dr = cmd.ExecuteReader
            If dr.Read Then

                'Carga tallas en código de barras
                Try
                    For j = 1 To 18 'Nº de tallas 
                        If dr("Talla_" & j) <> String.Empty Then
                            rTallas = DsArticulos.TALLAS.NewTALLASRow
                            rTallas.CodigoTalla = j
                            rTallas.Descripcion = dr("Talla_" & j)
                            Me.DsArticulos.TALLAS.AddTALLASRow(rTallas)
                        End If
                    Next
                Catch ex As Exception
                    'Error al añadir talla en código de barras
                End Try

                'Carga tallas en existencias
                For i = 0 To IIf(GestionColores, Me.DsArticulos.ARTICULOS_COLORES.Rows.Count - 1, 0)
                    For j = 1 To 18 'Nº de tallas 
                        If dr("Talla_" & j) <> String.Empty Then

                            Try
                                'Comprobar si existen existencias
                                For filas = 0 To Me.DsArticulos.EXISTENCIAS.Rows.Count - 1
                                    rExistencias = Me.DsArticulos.EXISTENCIAS.Rows(filas)
                                    If rExistencias.CodigoTalla = j Then
                                        If GestionColores And Me.DsArticulos.ARTICULOS_COLORES.Rows.Count > 0 Then
                                            If rExistencias.CodigoColor = Me.DsArticulos.ARTICULOS_COLORES.Rows(i).Item("Color_Id") Then
                                                rExistencias.DescripcionTalla = dr("Talla_" & j)
                                                Exit Try
                                            End If
                                        Else
                                            rExistencias.DescripcionTalla = dr("Talla_" & j)
                                            Exit Try
                                        End If
                                    End If
                                Next
                                rExistencias = DsArticulos.EXISTENCIAS.NewEXISTENCIASRow
                                rExistencias.CodigoTienda = CodigoTienda
                                rExistencias.Articulo_Id = rArticulo.Item("Id")
                                If GestionColores And Me.DsArticulos.ARTICULOS_COLORES.Rows.Count > 0 Then rExistencias.CodigoColor = Me.DsArticulos.ARTICULOS_COLORES.Rows(i).Item("Color_Id")
                                rExistencias.CodigoTalla = j
                                rExistencias.DescripcionTalla = dr("Talla_" & j)
                                Me.DsArticulos.EXISTENCIAS.AddEXISTENCIASRow(rExistencias)
                            Catch ex As Exception
                                'Error al añadir existencia
                            End Try

                        End If
                    Next
                Next
            Else
                Me.txtCodigoTalla.EditValue = 0
            End If
            dr.Close()

            cmd.Connection.Close()

            If IsNumeric(Me.txtCodigoTalla.EditValue) Then Me.txtCodigoTalla.EditValue = Format(CType(Me.txtCodigoTalla.EditValue, Integer), "00")
            Me.gvExistencias.Columns("CodigoTalla").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

            Me.TotalesExistencias()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            AddHandler txtCodigoTalla.EditValueChanged, AddressOf txtCodigoTalla_EditValueChanged
        End Try
    End Sub
#End Region

#Region "ActivaDesactivaMenu"
    Private Sub ActivaDesactivaMenu(ByVal activa As Boolean)

        Me.bttNuevo.Enabled = activa
        Me.bttBuscar.Enabled = activa
        Me.bttModificar.Enabled = IIf(Me.ARTICULOSBindingSource.Count = 0, False, activa)
        Me.bttEliminar.Enabled = IIf(Me.ARTICULOSBindingSource.Count = 0, False, activa)
        Me.bttImprimirEtiqueta.Enabled = IIf(Me.ARTICULOSBindingSource.Count = 0, False, activa)
        Me.bttCancelar.Text = IIf(activa, "Salir", "Cancelar")
        Me.bttGuardar.Enabled = IIf(activa, False, True)
        Me.bttAnterior.Enabled = IIf(Me.ARTICULOSBindingSource.Count = 0, False, activa)
        Me.bttSiguiente.Enabled = IIf(Me.ARTICULOSBindingSource.Count = 0, False, activa)

        'Obtener el IVA de la empresa
        If Me.DsArticulos.ARTICULOS.Rows.Count > 0 Then
            Me.cmbTipoIVA.SelectedIndex = rArticulo.Item("TipoIVA") - 1
            If GestionColores Then Me.ARTICULOS_COLORESTableAdapter.Articulo(Me.DsArticulos.ARTICULOS_COLORES, rArticulo.Item("Id"))
        Else
            Me.cmbTipoIVA.SelectedIndex = 0
            Me.DsArticulos.ARTICULOS_COLORES.Clear()
            Me.lblColorSeleccionado.BackColor = Color.Transparent
            Me.EXISTENCIASBindingSource.Filter = String.Empty
        End If

        'Datos de familia, subfamilia, proveedor...
        If Me.DsArticulos.ARTICULOS.Rows.Count > 0 Then
            DatosFamilia()
            DatosProveedor()
            DatosTalla()
            DatosEnvase()
            Me.CODIGO_BARRASTableAdapter.Articulo(Me.DsArticulos.CODIGO_BARRAS, CType(IIf(IsNumeric(rArticulo.Item("Id")), rArticulo.Item("Id"), 0), Integer))
            Me.REFERENCIAS_PROVEEDORESTableAdapter.FillBy(Me.DsArticulos.REFERENCIAS_PROVEEDORES, CType(IIf(IsNumeric(rArticulo.Item("Id")), rArticulo.Item("Id"), 0), Integer))
            Me.HISTORICO_INVENTARIOTableAdapter.FillBy(Me.DsInventario.HISTORICO_INVENTARIO, CType(IIf(IsNumeric(rArticulo.Item("Id")), rArticulo.Item("Id"), 0), Integer))
            If GestionColores Then Me.COLORESTableAdapter.Fill(Me.DsArticulos.COLORES)
            If GestionTallas Then
                Dim i As Integer
                For i = 0 To Me.DsArticulos.CODIGO_BARRAS.Rows.Count - 1
                    If Not Me.DsArticulos.CODIGO_BARRAS.Rows(i).Item("CodigoTalla") Is System.DBNull.Value Then
                        Me.DsArticulos.CODIGO_BARRAS.Rows(i).Item("DescripcionTalla") = DameTallaArticulo(Me.txtCodigo.EditValue, Me.DsArticulos.CODIGO_BARRAS.Rows(i).Item("CodigoTalla"))
                    End If
                Next
            End If
        Else
            Me.txtCodigoTalla.Text = String.Empty
            Me.txtCodigoFamilia.Text = String.Empty
            Me.txtDescripcionFamilia.Text = String.Empty
            Me.txtCodigoSubfamilia.Text = String.Empty
            Me.txtDescripcionSubfamilia.Text = String.Empty
            Me.txtCodigoProveedor.Text = String.Empty
            Me.txtNombreProveedor.Text = String.Empty
            Me.txtCodigoEnvase.Text = String.Empty
            Me.txtDescripcionEnvase.Text = String.Empty
        End If

        'Actualizar tipos de unidades
        Me.TIPOS_UNIDADESTableAdapter.Fill(Me.DsArticulos.TIPOS_UNIDADES)

    End Sub
#End Region

#Region "ActivaDesactivaCampos"
    Private Sub ActivaDesactivaCampos(ByVal activa As Boolean)
        Me.txtCodigo.Properties.ReadOnly = IIf(activa, False, True)
        Me.txtCodigo.Properties.Buttons(0).Enabled = activa
        Me.txtCodigoTalla.Properties.ReadOnly = IIf(GestionTallas, activa, True)
        Me.txtCodigoTalla.Properties.Buttons(0).Enabled = IIf(GestionTallas, IIf(activa, False, True), False)
        Me.cmbTipoIVA.Properties.ReadOnly = activa
        Me.txtDescripcion.Properties.ReadOnly = activa
        Me.txtCodigoFamilia.Properties.ReadOnly = activa
        Me.txtCodigoFamilia.Properties.Buttons(0).Enabled = IIf(activa, False, True)
        Me.txtCodigoSubfamilia.Properties.ReadOnly = activa
        Me.txtCodigoSubfamilia.Properties.Buttons(0).Enabled = IIf(activa, False, True)
        Me.txtCodigoProveedor.Properties.ReadOnly = activa
        Me.txtCodigoProveedor.Properties.Buttons(0).Enabled = IIf(activa, False, True)
        Me.txtCodigoEnvase.Properties.ReadOnly = activa
        Me.txtCodigoEnvase.Properties.Buttons(0).Enabled = IIf(activa, False, True)
        Me.CheckCantidadVariable.Properties.ReadOnly = activa
        Me.CheckControlEtiquetas.Properties.ReadOnly = activa
        Me.CheckControlBaja.Properties.ReadOnly = activa
        Me.checkArticuloPeso.Properties.ReadOnly = activa
        Me.txtFechaAlta.Properties.ReadOnly = activa
        Me.txtUnidadCaja.Properties.ReadOnly = activa
        Me.txtMinimoVenta.Properties.ReadOnly = activa
        Me.txtMinimoCompra.Properties.ReadOnly = activa
        Me.txtTipoArticulo.Properties.ReadOnly = activa
        Me.txtPesoUnidad.Properties.ReadOnly = activa
        Me.cmbTipoUnidad.Properties.ReadOnly = activa
        Me.txtDescuento.Properties.ReadOnly = activa
        Me.txtDtoFidelizacion.Properties.ReadOnly = activa
        Me.txtPrecioVenta.Properties.ReadOnly = activa
        Me.txtPrecioCoste.Properties.ReadOnly = activa
        Me.txtCodigoBascula.Properties.ReadOnly = activa
        Me.txtPLU.Properties.ReadOnly = activa
        Me.imgImagen.Properties.ReadOnly = activa
        Me.bttNuevaImagen.Enabled = IIf(activa, False, True)
        Me.bttEliminarImagen.Enabled = IIf(activa, False, True)
        Me.txtEtiqueta.Properties.ReadOnly = activa
        Me.checkTpvTactil.Properties.ReadOnly = activa
        Me.txtImporteEcoraee.Properties.ReadOnly = activa
        Me.txtEquivalencia.Properties.ReadOnly = activa

        'Etiqueta electrónica
        Me.cmbCodigosBarras.Properties.ReadOnly = activa
        Me.txtEE_Formato.Properties.ReadOnly = activa
        Me.txtEE_Categoria.Properties.ReadOnly = activa
        Me.txtEE_Calibre.Properties.ReadOnly = activa
        Me.txtEE_Origen.Properties.ReadOnly = activa

        'Grilla código de barras
        Me.colCodigoBarras.OptionsColumn.ReadOnly = activa
        Me.colCodigoBarras_Color.OptionsColumn.ReadOnly = activa
        Me.colCodigoBarras_Talla.OptionsColumn.ReadOnly = activa
        Me.NavListadoCodigoBarras.Buttons.Append.Enabled = IIf(activa, False, True)
        Me.NavListadoCodigoBarras.Buttons.Remove.Enabled = IIf(activa, False, True)

        'Grilla colores
        Me.NavListadoColores.Buttons.Append.Enabled = IIf(activa, False, True)
        Me.NavListadoColores.Buttons.Remove.Enabled = IIf(activa, False, True)

        'Grilla existencias
        Me.colExistenciasExistenciaInicial.OptionsColumn.ReadOnly = activa
        Me.colExistenciasExistenciaActual.OptionsColumn.ReadOnly = activa
        Me.colExistenciasStockMinimo.OptionsColumn.ReadOnly = activa
        Me.colExistenciasStockMaximo.OptionsColumn.ReadOnly = activa
        Me.colExistenciasPrecioVenta.OptionsColumn.ReadOnly = activa
        Me.colExistenciasCodigoBarras.OptionsColumn.ReadOnly = activa

        'Grilla proveedores
        Me.gvProveedores.OptionsBehavior.Editable = Not activa

        'Grilla inventarios
        Me.gvInventarios.OptionsBehavior.Editable = Not activa

        If Not GestionColores And Not GestionTallas Then
            Me.txtExistenciaInicial.Properties.ReadOnly = activa
            Me.txtExistenciasActual.Properties.ReadOnly = activa
            Me.txtStockMinimo.Properties.ReadOnly = activa
            Me.txtStockMaximo.Properties.ReadOnly = activa
        End If

    End Sub
#End Region

#Region "txtCodigoTalla_ButtonClick"
    Private Sub txtCodigoTalla_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoTalla.ButtonClick
        Try

            Dim dsArticulos As New dsArticulos, tTallas As New dsArticulosTableAdapters.TALLASTableAdapter
            Dim Columnas As New ArrayList
            Dim i As Integer

            Columnas.Add("CodigoTalla") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            For i = 1 To 18 'Nº de tallas
                Columnas.Add("Talla_" & i)
                Columnas.Add("T_" & i)
                Columnas.Add(0)
                Columnas.Add(0)
            Next

            tTallas.Fill(dsArticulos.TALLAS)

            If Buscar(dsArticulos, "TALLAS", Columnas, 0).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoTalla.Text = ResultadoBusqueda
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoFamilia_Validated"
    Private Sub txtCodigoFamilia_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoFamilia.Validated

        If Not Me.txtCodigoFamilia.IsModified Then Exit Sub

        Dim cmd As New SqlClient.SqlCommand

        Try
            If IsNumeric(Me.txtCodigoFamilia.EditValue) Then Me.txtCodigoFamilia.EditValue = Format(CType(Me.txtCodigoFamilia.EditValue, Integer), "000")

            'Vaciar subfamilia
            rArticulo.Item("CodigoSubfamilia") = System.DBNull.Value

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT Id FROM FAMILIASARTICULOS WHERE Codigo='" & Me.txtCodigoFamilia.Text & "'"

            rArticulo.Item("CodigoFamilia") = CType(cmd.ExecuteScalar, Integer)

            DatosFamilia()

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

        Dim cmd As New SqlClient.SqlCommand

        Try
            If IsNumeric(Me.txtCodigoSubfamilia.EditValue) Then Me.txtCodigoSubfamilia.EditValue = Format(CType(Me.txtCodigoSubfamilia.EditValue, Integer), "000")

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT Id FROM SUBFAMILIASARTICULOS WHERE Familia_Id=" & rArticulo.Item("CodigoFamilia") & " AND Codigo='" & Me.txtCodigoSubfamilia.Text & "'"

            rArticulo.Item("CodigoSubfamilia") = CType(cmd.ExecuteScalar, Integer)

            DatosFamilia()

            If rArticulo.Item("CodigoSubfamilia") Is System.DBNull.Value Then Me.txtCodigoSubfamilia.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
        End Try
    End Sub
#End Region

#Region "txtCodigoProveedor_EditValueChanged"
    Private Sub txtCodigoProveedor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoProveedor.EditValueChanged
        Try
            If Me.txtCodigoProveedor.IsModified Then Me.DatosProveedor()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoEnvase_Validated"
    Private Sub txtCodigoEnvase_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoEnvase.Validated
        Try
            If Not Me.txtCodigoEnvase.IsModified Then Exit Sub

            'If IsNumeric(Me.txtCodigoEnvase.EditValue) Then Me.txtCodigoEnvase.EditValue = Format(CType(Me.txtCodigoEnvase.EditValue, Integer), "0000000")

            Me.DatosEnvase()

            If Me.txtCodigoEnvase.Text = String.Empty Then Me.txtCodigoEnvase.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoEnvase_ButtonClick"
    Private Sub txtCodigoEnvase_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoEnvase.ButtonClick
        Try
            If e.Button.Index = 0 Then 'Botón buscar

                Dim dsArticulos As New dsArticulos, tArticulos As New dsArticulosTableAdapters.ARTICULOSTableAdapter
                Dim Columnas As New ArrayList

                Columnas.Add("Codigo") 'Campo
                Columnas.Add("Código") 'Encabezado
                Columnas.Add(80) 'Tamaño columna
                Columnas.Add(80) 'Tamaño máximo columna

                Columnas.Add("Descripcion")
                Columnas.Add("Descripción")
                Columnas.Add(0)
                Columnas.Add(0)

                tArticulos.Fill(dsArticulos.ARTICULOS)

                If Buscar(dsArticulos, "ARTICULOS", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.txtCodigoEnvase.Text = ResultadoBusqueda
                    Me.txtCodigoEnvase.IsModified = True
                    Me.txtCodigoEnvase_Validated(Nothing, Nothing)
                End If

            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "cmbTipoIVA_GotFocus"
    Private Sub cmbTipoIVA_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipoIVA.GotFocus
        Me.cmbTipoIVA.Properties.Items(0) = IIf(TipoIva1 Mod 1 = 0, Int(TipoIva1), TipoIva1)
        Me.cmbTipoIVA.Properties.Items(1) = IIf(TipoIva2 Mod 1 = 0, Int(TipoIva2), TipoIva2)
        Me.cmbTipoIVA.Properties.Items(2) = IIf(TipoIva3 Mod 1 = 0, Int(TipoIva3), TipoIva3)
        Me.cmbTipoIVA.Properties.Items(3) = IIf(TipoIva4 Mod 1 = 0, Int(TipoIva4), TipoIva4)
    End Sub
#End Region

#Region "bttNuevaImagen_Click"
    Private Sub bttNuevaImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttNuevaImagen.Click
        Try
            Me.imgImagen.LoadImage()
            Me.txtEtiqueta.EditValue = Mid(Me.txtDescripcion.EditValue, 1, 20)
            Me.checkTpvTactil.Checked = True
        Catch ex As Exception
            Me.bttEliminarImagen_Click(Nothing, Nothing)
        End Try
    End Sub
#End Region

#Region "bttEliminarImagen_Click"
    Private Sub bttEliminarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttEliminarImagen.Click
        Me.imgImagen.EditValue = System.DBNull.Value
        Me.txtEtiqueta.EditValue = String.Empty
        Me.checkTpvTactil.Checked = False
    End Sub
#End Region

#Region "gvColores_FocusedRowChanged"
    Private Sub gvColores_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvColores.FocusedRowChanged
        If Me.gvColores.IsNewItemRow(e.FocusedRowHandle) Then
            Me.colColores_Color_Id.OptionsColumn.ReadOnly = False
        Else
            Me.gvColores.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            Me.colColores_Color_Id.OptionsColumn.ReadOnly = True
        End If
        'Cargar existencias
        If Not Me.gvColores.GetRow(e.FocusedRowHandle) Is Nothing Then
            Me.EXISTENCIASBindingSource.Filter = "CodigoColor=" & Me.gvColores.GetRowCellValue(e.FocusedRowHandle, Me.colColores_Color_Id)
            If IsNumeric(Me.gvColores.GetRowCellDisplayText(e.FocusedRowHandle, Me.colColores_Color)) Then Me.lblColorSeleccionado.BackColor = Color.FromArgb(Me.gvColores.GetRowCellDisplayText(e.FocusedRowHandle, Me.colColores_Color))
        End If
    End Sub
#End Region

#Region "gvColores_CustomDrawCell"
    Private Sub gvColores_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvColores.CustomDrawCell
        Try
            If e.Column Is Me.colColores_Color Then
                If IsNumeric(e.DisplayText) Then
                    e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(e.DisplayText)), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
                    e.Appearance.ForeColor = Color.FromArgb(e.DisplayText)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "gvCodigoBarras_CellValueChanged"
    Private Sub gvCodigoBarras_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvCodigoBarras.CellValueChanged
        Select Case e.Column.Name
            Case Me.colCodigoBarras_Color.Name
                Me.gvCodigoBarras.SetFocusedRowCellValue(Me.colDescripcionColor, DameColor(e.Value))
            Case Me.colCodigoBarras_Talla.Name
                Me.gvCodigoBarras.SetFocusedRowCellValue(Me.colDescripciontalla, DameTallaArticulo(Me.txtCodigo.EditValue, e.Value))
        End Select
    End Sub
#End Region

#Region "gvCodigoBarras_CustomDrawCell"
    Private Sub gvCodigoBarras_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvCodigoBarras.CustomDrawCell
        Try
            If e.Column Is Me.colDescripcionColor Then
                'e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(e.DisplayText)), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
                'e.Appearance.ForeColor = Color.FromArgb(e.DisplayText)
                If IsNumeric(Me.gvCodigoBarras.GetRowCellValue(e.RowHandle, Me.colCodigoBarras_Color)) Then
                    e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(DameColor(Me.gvCodigoBarras.GetRowCellValue(e.RowHandle, Me.colCodigoBarras_Color)))), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
                    e.Appearance.ForeColor = Color.FromArgb(DameColor(Me.gvCodigoBarras.GetRowCellValue(e.RowHandle, Me.colCodigoBarras_Color)))
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "gvColores_ValidateRow"
    Private Sub gvColores_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvColores.ValidateRow
        'Comprobar que no está ya el código seleccionado
        Dim CodigoColor As Integer = Me.gvColores.GetRowCellValue(e.RowHandle, Me.colColores_Color_Id)
        Dim LineaActual As Integer = IIf(Me.gvColores.IsNewItemRow(e.RowHandle), Me.gvColores.RowCount - 1, e.RowHandle)
        Dim i As Integer
        For i = 0 To Me.gvColores.RowCount - 1
            If LineaActual <> i And Me.gvColores.GetRowCellValue(e.RowHandle, Me.colColores_Color_Id) = Me.gvColores.GetRowCellValue(i, Me.colColores_Color_Id) Then
                MsgBox("El color seleccionado ya existe", MsgBoxStyle.Information, "Ya existe")
                Me.gvColores.CancelUpdateCurrentRow()
                Exit Sub
            End If
        Next
        If Me.gvColores.IsNewItemRow(e.RowHandle) Then

            'Cargar tallas del color nuevo
            Dim dr As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand
            Dim j As Integer
            Dim rExistencias As dsArticulos.EXISTENCIASRow

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT * FROM TALLAS WHERE CodigoTalla=" & IIf(IsNumeric(Me.txtCodigoTalla.Text), Me.txtCodigoTalla.Text, -1)
            dr = cmd.ExecuteReader

            If dr.Read Then
                For j = 1 To 18 'Nº de tallas 
                    If dr("Talla_" & j) <> String.Empty Then
                        Try
                            rExistencias = DsArticulos.EXISTENCIAS.NewEXISTENCIASRow
                            rExistencias.CodigoTienda = CodigoTienda
                            rExistencias.Articulo_Id = rArticulo.Item("Id")
                            rExistencias.CodigoColor = Me.gvColores.GetRowCellValue(e.RowHandle, Me.colColores_Color_Id)
                            rExistencias.CodigoTalla = j
                            rExistencias.DescripcionTalla = dr("Talla_" & j)
                            Me.DsArticulos.EXISTENCIAS.AddEXISTENCIASRow(rExistencias)
                        Catch ex As Exception
                            'Error al añadir existencia
                        End Try
                    End If
                Next
            End If
            dr.Close()

        End If
    End Sub
#End Region

#Region "gvColores_gvCodigoBarras_InvalidRowException"
    Private Sub gvColores_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvColores.InvalidRowException, gvCodigoBarras.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
#End Region

#Region "gvCodigoBarras_ValidateRow"
    Private Sub gvCodigoBarras_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvCodigoBarras.ValidateRow
        'If MsgBox("¿Seguro que desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar cambios") = MsgBoxResult.No Then
        '    e.Valid = False
        '    Exit Sub
        'End If

        'Comprobar datos

        If Me.gvCodigoBarras.GetRowCellValue(e.RowHandle, Me.colCodigoBarras) = String.Empty Then
            MsgBox("Introduce el código de barras", MsgBoxStyle.Information, "Falta código de barras")
            Me.gvCodigoBarras.CancelUpdateCurrentRow()
            Exit Sub
        End If

        'If Len(Me.gvCodigoBarras.GetRowCellValue(e.RowHandle, Me.colCodigoBarras)) < 8 Then
        '    MsgBox("El código de barras no puede tener menos de 8 caracteres", MsgBoxStyle.Information, "Atención")
        '    Me.gvCodigoBarras.CancelUpdateCurrentRow()
        '    Me.gvCodigoBarras.FocusedColumn = Me.colCodigoBarras
        '    Exit Sub
        'End If

        'Comprobar que el código de barras no exista ya en el artículo
        Dim Codigos As DataRow() = Me.DsArticulos.CODIGO_BARRAS.Select("CodigoBarras = '" & Me.gvCodigoBarras.GetRowCellValue(e.RowHandle, Me.colCodigoBarras) & "'")
        If Codigos.Length > 0 Then
            MsgBox("Ya existe ese código de barras en el artículo", MsgBoxStyle.Information, "Ya existe")
            Me.gvCodigoBarras.CancelUpdateCurrentRow()
            Me.gvCodigoBarras.FocusedColumn = Me.colCodigoBarras
            Exit Sub
        End If

        'Comprobar que el código de barras no exista en la base de datos
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()
        cmd.CommandText = "SELECT * FROM CODIGO_BARRAS INNER JOIN ARTICULOS ON ARTICULOS.Id=CODIGO_BARRAS.Articulo_Id " & _
                          "WHERE CodigoBarras='" & Me.gvCodigoBarras.GetRowCellValue(e.RowHandle, Me.colCodigoBarras) & "'"
        dr = cmd.ExecuteReader
        If dr.Read Then
            MsgBox("Ya existe ese código de barras asociado al artículo: " & dr("Codigo") & " - " & dr("Descripcion"), MsgBoxStyle.Information, "Ya existe")
            Me.gvCodigoBarras.CancelUpdateCurrentRow()
            Me.gvCodigoBarras.FocusedColumn = Me.colCodigoBarras
            Exit Sub
        End If
        dr.Close()

    End Sub
#End Region

#Region "gvCodigoBarras_FocusedRowChanged"
    Private Sub gvCodigoBarras_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvCodigoBarras.FocusedRowChanged
        If Me.gvCodigoBarras.IsNewItemRow(e.FocusedRowHandle) Then
            Me.colCodigoBarras.OptionsColumn.ReadOnly = False
            Me.colCodigoBarras_Color.OptionsColumn.ReadOnly = False
            Me.colCodigoBarras_Talla.OptionsColumn.ReadOnly = False
        Else
            Me.gvCodigoBarras.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            Me.colCodigoBarras.OptionsColumn.ReadOnly = True
            Me.colCodigoBarras_Color.OptionsColumn.ReadOnly = True
            Me.colCodigoBarras_Talla.OptionsColumn.ReadOnly = True
        End If
    End Sub
#End Region

#Region "NavListadoCodigoBarras_ButtonClick"
    Private Sub NavListadoCodigoBarras_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles NavListadoCodigoBarras.ButtonClick
        Select Case e.Button.ButtonType
            Case DevExpress.XtraEditors.NavigatorButtonType.NextPage
                Me.gvCodigoBarras.MoveNextPage()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.PrevPage
                Me.gvCodigoBarras.MovePrevPage()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.Append
                Me.gvCodigoBarras.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                Me.gvCodigoBarras.MoveLastVisible()
                Me.gvCodigoBarras.Focus()
                Me.gvCodigoBarras.FocusedColumn = Me.colCodigoBarras
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.Remove
                If MsgBox("¿Seguro que desea eliminar el código de barras seleccionado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar código de barras") = MsgBoxResult.No Then
                    e.Handled = True
                End If
        End Select
    End Sub
#End Region

#Region "NavListadoColores_ButtonClick"
    Private Sub NavListadoColores_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles NavListadoColores.ButtonClick
        Select Case e.Button.ButtonType
            Case DevExpress.XtraEditors.NavigatorButtonType.NextPage
                Me.gvColores.MoveNextPage()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.PrevPage
                Me.gvColores.MovePrevPage()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.Append
                If GestionTallas And IsNumeric(Me.txtCodigoTalla.EditValue) Then
                    Me.gvColores.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                    Me.gvColores.MoveLastVisible()
                    Me.gvColores.Focus()
                    Me.gvColores.FocusedColumn = Me.colColores_Color_Id
                Else
                    MsgBox("Seleccione primero el código de tallaje del artículo", MsgBoxStyle.Information)
                    Me.txtCodigoTalla.Focus()
                End If
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.Remove
                If MsgBox("¿Seguro que desea eliminar el color seleccionado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar color") = MsgBoxResult.Yes Then
                    'Eliminar tallas
                    For i As Integer = Me.DsArticulos.EXISTENCIAS.Count - 1 To 0 Step -1
                        If Me.DsArticulos.EXISTENCIAS(i).CodigoColor = Me.gvColores.GetFocusedRowCellValue(Me.colColores_Color_Id) Then
                            Me.DsArticulos.EXISTENCIAS(i).Delete()
                        End If
                    Next
                Else
                    e.Handled = True
                End If
        End Select
    End Sub
#End Region

#Region "TotalesExistencias"
    Private Sub TotalesExistencias()
        Dim rExistencias As dsArticulos.EXISTENCIASRow
        Dim TotalExistenciaInicial As Decimal, TotalExistenciaActual As Decimal, TotalStockMinimo As Integer, TotalStockMaximo As Integer
        Dim i As Integer
        For i = 0 To Me.DsArticulos.EXISTENCIAS.Rows.Count - 1
            rExistencias = Me.DsArticulos.EXISTENCIAS.Rows(i)
            TotalExistenciaInicial += rExistencias.ExistenciaInicial
            TotalExistenciaActual += rExistencias.ExistenciaActual
            TotalStockMinimo += rExistencias.StockMinimo
            TotalStockMaximo += rExistencias.StockMaximo
        Next
        Me.txtExistenciaInicial.Text = TotalExistenciaInicial
        Me.txtExistenciasActual.Text = TotalExistenciaActual
        Me.txtStockMinimo.Text = TotalStockMinimo
        Me.txtStockMaximo.Text = TotalStockMaximo
    End Sub
#End Region

#Region "gvExistencias_ValidateRow"
    Private Sub gvExistencias_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvExistencias.ValidateRow
        'Comprobar datos
        If Me.gvExistencias.GetRowCellValue(e.RowHandle, Me.colExistenciasCodigoBarras) <> String.Empty Then

            'If Len(Me.gvExistencias.GetRowCellValue(e.RowHandle, Me.colExistenciasCodigoBarras)) < 8 Then
            '    MsgBox("El código de barras no puede tener menos de 8 caracteres", MsgBoxStyle.Information, "Atención")
            '    Me.gvExistencias.CancelUpdateCurrentRow()
            '    Me.gvExistencias.FocusedColumn = Me.colExistenciasCodigoBarras
            '    Exit Sub
            'End If

            Dim i As Integer

            'Comprobar que el código de barras no exista ya en el artíclo
            For i = 0 To Me.DsArticulos.CODIGO_BARRAS.Rows.Count - 1
                If Me.DsArticulos.CODIGO_BARRAS.Rows(i).Item("CodigoBarras") = Me.gvExistencias.GetRowCellValue(e.RowHandle, Me.colExistenciasCodigoBarras) Then
                    MsgBox("Ya existe ese código de barras en el artículo", MsgBoxStyle.Information, "Ya existe")
                    Me.gvExistencias.CancelUpdateCurrentRow()
                    Me.gvExistencias.FocusedColumn = Me.colExistenciasCodigoBarras
                    Exit Sub
                End If
            Next

            'Comprobar que el código de barras no exista en la base de datos
            Dim dr As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT * FROM CODIGO_BARRAS INNER JOIN ARTICULOS ON ARTICULOS.Id=CODIGO_BARRAS.Articulo_Id " & _
                              "WHERE CodigoBarras='" & Me.gvExistencias.GetRowCellValue(e.RowHandle, Me.colExistenciasCodigoBarras) & "'"

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Ya existe ese código de barras asociado al artículo: " & dr("Codigo") & " - " & dr("Descripcion"), MsgBoxStyle.Information, "Ya existe")
                Me.gvExistencias.CancelUpdateCurrentRow()
                Me.gvExistencias.FocusedColumn = Me.colExistenciasCodigoBarras
                Exit Sub
            End If
            dr.Close()

            'Añadir código de barras
            Dim rCodigoBarras As dsArticulos.CODIGO_BARRASRow
            rCodigoBarras = Me.DsArticulos.CODIGO_BARRAS.NewCODIGO_BARRASRow()
            rCodigoBarras.CodigoBarras = Me.gvExistencias.GetFocusedRowCellValue(Me.colExistenciasCodigoBarras)
            rCodigoBarras.CodigoColor = IIf(GestionColores, Me.gvColores.GetFocusedRowCellValue(Me.colColores_Color_Id), 0)
            rCodigoBarras.CodigoTalla = IIf(GestionTallas, Me.gvExistencias.GetFocusedRowCellValue(Me.colExistenciasCodigoTalla), 1)
            rCodigoBarras.DescripcionTalla = Me.gvExistencias.GetFocusedRowCellValue(Me.colExistenciasTalla)
            Me.DsArticulos.CODIGO_BARRAS.AddCODIGO_BARRASRow(rCodigoBarras)

            MsgBox("El código de barras ha sido añadido correctamente", MsgBoxStyle.Information, "Código de barras")
            Me.gvExistencias.SetFocusedRowCellValue(Me.colExistenciasCodigoBarras, String.Empty)

        End If
    End Sub
#End Region

#Region "txtCodigoTalla_EditValueChanged"
    Private Sub txtCodigoTalla_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoTalla.EditValueChanged
        Try
            If Me.txtCodigoTalla.IsModified Then Me.DatosTalla()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttAnterior_Click"
    Private Sub bttAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttAnterior.Click

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            Me.Cursor = Cursors.WaitCursor

            cmd.Connection.Open()

            Dim CodigoArticulo As String
            Dim selectSQL As String, whereSQL As String, orderSQL As String

            selectSQL = "SELECT ARTICULOS.Codigo FROM ARTICULOS " & _
                              "LEFT JOIN FAMILIASARTICULOS ON ARTICULOS.CodigoFamilia = FAMILIASARTICULOS.Id " & _
                              "LEFT JOIN SUBFAMILIASARTICULOS ON SUBFAMILIASARTICULOS.Familia_Id = FAMILIASARTICULOS.Id AND ARTICULOS.CodigoSubfamilia = SUBFAMILIASARTICULOS.Id "

            whereSQL = "WHERE FAMILIASARTICULOS.Codigo='" & Me.txtCodigoFamilia.EditValue & "' " & _
                       "AND SUBFAMILIASARTICULOS.Codigo='" & Me.txtCodigoSubfamilia.EditValue & "' " & _
                       "AND ARTICULOS.Codigo < '" & Me.txtCodigo.EditValue & "' "

            orderSQL = "ORDER BY FAMILIASARTICULOS.Codigo DESC, SUBFAMILIASARTICULOS.Codigo DESC, ARTICULOS.Codigo DESC"

            cmd.CommandText = selectSQL & whereSQL & orderSQL
            CodigoArticulo = cmd.ExecuteScalar

            If CodigoArticulo = String.Empty Then
                'Si no encuentra artículo de la subfamilia buscar en siguiente subfamilia
                whereSQL = "WHERE FAMILIASARTICULOS.Codigo='" & Me.txtCodigoFamilia.EditValue & "' " & _
                           "AND SUBFAMILIASARTICULOS.Codigo<'" & Me.txtCodigoSubfamilia.EditValue & "'"
                cmd.CommandText = selectSQL & whereSQL & orderSQL
                CodigoArticulo = cmd.ExecuteScalar
            End If

            If CodigoArticulo = String.Empty Then
                'Si no encuentra subfamilia buscar en siguiente familia
                whereSQL = "WHERE FAMILIASARTICULOS.Codigo<'" & Me.txtCodigoFamilia.EditValue & "'"
                cmd.CommandText = selectSQL & whereSQL & orderSQL
                CodigoArticulo = cmd.ExecuteScalar
            End If

            If CodigoArticulo <> String.Empty Then
                Me.txtCodigo.EditValue = CodigoArticulo
                Me.txtCodigo.IsModified = True
                Me.txtCodigo_Validated(Nothing, Nothing)
            Else
                MsgBox("No existe ningún artículo anterior", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Error al buscar el artículo anterior", MsgBoxStyle.Exclamation)
        Finally
            Me.Cursor = Cursors.Default
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "bttSiguiente_Click"
    Private Sub bttSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttSiguiente.Click

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            Me.Cursor = Cursors.WaitCursor

            cmd.Connection.Open()

            Dim CodigoArticulo As String
            Dim selectSQL As String, whereSQL As String, orderSQL As String

            selectSQL = "SELECT ARTICULOS.Codigo FROM ARTICULOS " & _
                              "LEFT JOIN FAMILIASARTICULOS ON ARTICULOS.CodigoFamilia = FAMILIASARTICULOS.Id " & _
                              "LEFT JOIN SUBFAMILIASARTICULOS ON SUBFAMILIASARTICULOS.Familia_Id = FAMILIASARTICULOS.Id AND ARTICULOS.CodigoSubfamilia = SUBFAMILIASARTICULOS.Id "

            whereSQL = "WHERE FAMILIASARTICULOS.Codigo='" & Me.txtCodigoFamilia.EditValue & "' " & _
                       "AND SUBFAMILIASARTICULOS.Codigo='" & Me.txtCodigoSubfamilia.EditValue & "' " & _
                       "AND ARTICULOS.Codigo > '" & Me.txtCodigo.EditValue & "' "

            orderSQL = "ORDER BY FAMILIASARTICULOS.Codigo, SUBFAMILIASARTICULOS.Codigo, ARTICULOS.Codigo"

            cmd.CommandText = selectSQL & whereSQL & orderSQL
            CodigoArticulo = cmd.ExecuteScalar

            If CodigoArticulo = String.Empty Then
                'Si no encuentra artículo de la subfamilia buscar en siguiente subfamilia
                whereSQL = "WHERE FAMILIASARTICULOS.Codigo='" & Me.txtCodigoFamilia.EditValue & "' " & _
                           "AND SUBFAMILIASARTICULOS.Codigo>'" & Me.txtCodigoSubfamilia.EditValue & "'"
                cmd.CommandText = selectSQL & whereSQL & orderSQL
                CodigoArticulo = cmd.ExecuteScalar
            End If

            If CodigoArticulo = String.Empty Then
                'Si no encuentra subfamilia buscar en siguiente familia
                whereSQL = "WHERE FAMILIASARTICULOS.Codigo>'" & Me.txtCodigoFamilia.EditValue & "'"
                cmd.CommandText = selectSQL & whereSQL & orderSQL
                CodigoArticulo = cmd.ExecuteScalar
            End If

            If CodigoArticulo <> String.Empty Then
                Me.txtCodigo.EditValue = CodigoArticulo
                Me.txtCodigo.IsModified = True
                Me.txtCodigo_Validated(Nothing, Nothing)
            Else
                MsgBox("No existe ningún artículo posterior", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Error al buscar el artículo posterior", MsgBoxStyle.Exclamation)
        Finally
            Me.Cursor = Cursors.Default
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "cmbCodigoBarrasColores_EditValueChanged"
    Private Sub cmbCodigoBarrasColores_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCodigoBarrasColores.EditValueChanged
        Me.gvCodigoBarras.FocusedColumn = Me.colCodigoBarras_Talla
    End Sub
#End Region

#Region "cmbCodigoBarrasTallas_EditValueChanged"
    Private Sub cmbCodigoBarrasTallas_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCodigoBarrasTallas.EditValueChanged
        Me.gvCodigoBarras.FocusedColumn = Me.colCodigoBarras
    End Sub
#End Region

#Region "bttCargaRapida_Click"
    Private Sub bttCargaRapida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fCargaRapida As New ArticuloNuevo
        fCargaRapida.ShowDialog()
    End Sub
#End Region

#Region "bttBuscarMovimientos_Click"
    Private Sub bttBuscarMovimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscarMovimientos.Click
        Try
            'If Me.txtFechaDesde.EditValue Is Nothing Or Me.txtFechaHasta.EditValue Is Nothing Then
            '    MsgBox("Seleccione un rango de fechas.", MsgBoxStyle.Information)
            '    Exit Try
            'End If

            Dim FechaInicio As Date = IIf(IsNothing(Me.txtFechaDesde.EditValue), "01-01-2000", Me.txtFechaDesde.EditValue)
            Dim FechaFin As Date = IIf(IsNothing(Me.txtFechaHasta.EditValue), "31-12-9999", CDate(Me.txtFechaHasta.EditValue).AddDays(1).AddSeconds(-1))

            Me.DsArticulos.CargarMovimientos(AGI2005.BaseDatos.ConsultaDevuelveValor("SELECT Id FROM Articulos WHERE Codigo='" & Me.txtCodigo.Text & "'", AGI2005.BaseDatos.TipoValor.ID, My.Settings.AydaraTPVConnectionString), FechaInicio, FechaFin)

        Catch ex As Exception
            MsgBox("Error al buscar movimientos." & vbCrLf & ex.Message)
        End Try
    End Sub
#End Region

#Region "bttProveedor_ButtonClick"
    Private Sub bttProveedor_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bttProveedor.ButtonClick
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
                If Me.gvProveedores.GetRow(Me.gvProveedores.FocusedRowHandle) Is Nothing Then Me.gvProveedores.AddNewRow()
                Me.gvProveedores.SetFocusedRowCellValue(Me.colCodigoProveedor, ResultadoBusqueda)
            End If

        Catch ex As Exception
            MsgBox("Error al mostrar listado de proveedores", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "gvProveedores_CellValueChanged"
    Private Sub gvProveedores_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvProveedores.CellValueChanged
        If e.Column Is Me.colCodigoProveedor Then
            If IsNumeric(e.Value) Then
                Me.gvProveedores.SetFocusedRowCellValue(Me.colNombreProveedor, AGI2005.BaseDatos.ConsultaDevuelveValor("SELECT Nombre FROM PROVEEDORES WHERE Codigo = " & e.Value, AGI2005.BaseDatos.TipoValor.Texto, My.Settings.AydaraTPVConnectionString))
            End If
        End If
    End Sub
#End Region

#Region "Etiqueta electrónica"
    Private Sub cmbCodigosBarras_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbCodigosBarras.ButtonClick
        Try
            If e.Button.Index = 0 Then Exit Try

            Dim Codigo As Double = PrefijoEtiqueta & CInt(Me.txtCodigoFamilia.EditValue).ToString("000") & CInt(Me.txtCodigo.EditValue).ToString("0000000")
            Me.txtEE_CodigoBarras.EditValue = Codigo & Me.GetDCBarCodEAN13(Codigo)

            'Comprobar que el código de barras no exista ya en el artículo
            Dim Codigos As DataRow() = Me.DsArticulos.CODIGO_BARRAS.Select("CodigoBarras = '" & Me.txtEE_CodigoBarras.EditValue & "'")
            If Codigos.Length = 0 Then
                Dim rCodigo As dsArticulos.CODIGO_BARRASRow = Me.DsArticulos.CODIGO_BARRAS.NewCODIGO_BARRASRow
                rCodigo.CodigoBarras = Me.txtEE_CodigoBarras.EditValue
                Me.DsArticulos.CODIGO_BARRAS.AddCODIGO_BARRASRow(rCodigo)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub cmbCodigosBarras_EditValueChanged(sender As Object, e As EventArgs) Handles cmbCodigosBarras.EditValueChanged
        Try
            If Me.cmbCodigosBarras.GetSelectedDataRow Is Nothing Then Exit Try

            With CType(Me.cmbCodigosBarras.GetSelectedDataRow.Row, dsArticulos.CODIGO_BARRASRow)
                Me.txtEE_CodigoBarras.EditValue = .CodigoBarras
                Me.cmbCodigosBarras.EditValue = Nothing
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Public Function GetDCBarCodEAN13(ByRef number As String) As Integer

        If (number.Length <> 12) Then
            number = ""
            Throw New System.ArgumentException
        Else
            Dim ch As Char
            For Each ch In number
                If (Not Char.IsNumber(ch)) Then
                    number = ""
                    Throw New System.ArgumentException
                End If
            Next
        End If

        Dim x, digito, sumaCod As Integer

        ' Extraigo el valor del dígito, y voy
        ' sumando los valores resultantes.
        For x = 11 To 0 Step -1

            digito = CInt(number.Substring(x, 1))

            Select Case x
                Case 1, 3, 5, 7, 9, 11
                    ' Las posiciones impares se multiplican por 3
                    sumaCod += (digito * 3)

                Case Else
                    ' Las posiciones pares se multiplican por 1
                    sumaCod += (digito * 1)
            End Select

        Next

        ' Calculo la decena superior
        digito = (sumaCod Mod 10)

        ' Calculo el dígito de control
        digito = 10 - digito

        ' Código de barras completo
        number &= CStr(digito)

        ' Devuelvo el dígito de control
        Return digito

    End Function

#End Region

#Region "bttExportarMovimientos_Click"
    Private Sub bttExportarMovimientos_Click(sender As Object, e As EventArgs) Handles bttExportarMovimientos.Click
        Try
            Dim BuscaFichero As New OpenFileDialog
            BuscaFichero.CheckFileExists = False
            BuscaFichero.DefaultExt = "xlsx"

            If BuscaFichero.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.dgMovimientos.ExportToXlsx(BuscaFichero.FileName)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

    Private Sub bttImprimirEtiqueta_Click(sender As Object, e As EventArgs) Handles bttImprimirEtiqueta.Click
        Try
            Dim Copias As Integer = 0
            Dim dameCantidad As New DameCantidad
            dameCantidad.txtCantidad.EditValue = 1
            If dameCantidad.ShowDialog = Windows.Forms.DialogResult.OK Then
                Copias = dameCantidad.txtCantidad.EditValue
            Else
                Exit Try
            End If

            Dim CodigoBarras As String = Me.toEAN8(Me.rArticulo.Id)

            Dim res As New System.Text.StringBuilder

            res.Append("I8,A,001" & vbCrLf)
            res.Append(vbCrLf)
            res.Append(vbCrLf)
            res.Append("Q96,024" & vbCrLf)
            res.Append("q863" & vbCrLf)
            res.Append("rN" & vbCrLf)
            res.Append("S2" & vbCrLf)
            res.Append("D15" & vbCrLf)
            res.Append("ZT" & vbCrLf)
            res.Append("JF" & vbCrLf)
            res.Append("O" & vbCrLf)
            res.Append("R335,0" & vbCrLf)
            res.Append("f100" & vbCrLf)
            res.Append("N" & vbCrLf)
            res.Append("B20,32,0,E80,2,4,42,B,""" & CodigoBarras & """" & vbCrLf)
            res.Append("A33,4,0,1,1,2,N,""" & Me.txtCodigo.EditValue & """" & vbCrLf)
            res.Append("P" & Copias & vbCrLf)

            Imprimir.SendStringToPrinter(My.Settings.ImpresoraEtiquetas, res.ToString)

            'Comprobar que el código de barras exista en el artículo
            Dim Codigos As DataRow() = Me.DsArticulos.CODIGO_BARRAS.Select("CodigoBarras = '" & CodigoBarras & "'")
            If Codigos.Length = 0 Then
                Dim rCodigo As dsArticulos.CODIGO_BARRASRow = Me.DsArticulos.CODIGO_BARRAS.NewCODIGO_BARRASRow
                rCodigo.CodigoBarras = CodigoBarras
                rCodigo.Articulo_Id = Me.rArticulo.Id
                Me.DsArticulos.CODIGO_BARRAS.AddCODIGO_BARRASRow(rCodigo)
                Me.CODIGO_BARRASTableAdapter.Update(Me.DsArticulos.CODIGO_BARRAS)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, , Me.Text)
        End Try
    End Sub

    Private Function toEAN8(ByVal ID As Integer) As String
        Try
            Dim res As Integer = 0
            Dim sID As String = "0000000" & CType(ID, String)
            sID = "8" & sID.Substring(sID.Length - 6, 6)
            Dim pares As Integer = Val(sID.Chars(1)) + Val(sID.Chars(3)) + Val(sID.Chars(5))
            Dim impares As Integer = Val(sID.Chars(0)) + Val(sID.Chars(2)) + Val(sID.Chars(4)) + Val(sID.Chars(6))
            impares = impares * 3
            Dim suma As Integer = impares + pares
            res = 10 - (suma Mod 10)
            If res = 10 Then res = 0
            Return sID & res
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
