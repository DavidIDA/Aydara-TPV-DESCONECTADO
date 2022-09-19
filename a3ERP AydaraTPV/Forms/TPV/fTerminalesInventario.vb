Public Class fTerminalesInventario

    Dim regkey_Formulario As String, regKey_Inventario As String

    Dim WithEvents PopupMenuArticulo As fPopupMenu

#Region "Eventos formulario"
    Private Sub fTerminalesInventario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Me.MdiParent Is Nothing Then
                If Me.WindowState = FormWindowState.Minimized Then Me.WindowState = FormWindowState.Normal
                My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario, True).SetValue("WindowState", CInt(Me.WindowState))
                If Me.WindowState = FormWindowState.Normal Then
                    My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario, True).SetValue("Left", Me.Left)
                    My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario, True).SetValue("Top", Me.Top)
                    My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario, True).SetValue("Width", Me.Width)
                    My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario, True).SetValue("Height", Me.Height)
                End If
            End If
            Me.gvInventario.SaveLayoutToRegistry(regKey_Inventario)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub fTerminalesInventario_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Try
            Select Case e.KeyCode
                Case Keys.F3 'Buscar
                    If Me.bttGuardar.Enabled Then
                        If e.Alt Then
                            Me.bttCancelar_Click(Me.bttCancelar, Nothing)
                        Else
                            Me.bttGuardar_Click(Me.bttGuardar, Nothing)
                        End If
                    End If
                Case Keys.F5 'Buscar
                    If Me.bttBuscar.Enabled Then Me.bttBuscar_Click(Me.bttBuscar, Nothing)
                Case Keys.G
                    If e.Control And Not e.Alt Then Aydara.ConfigurarGrilla(Me.gvInventario, Me.regKey_Inventario & "\Default")
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub fTerminalesInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.regkey_Formulario = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name
            My.Computer.Registry.CurrentUser.CreateSubKey(Me.regkey_Formulario)

            'Configuración grillas
            Me.regKey_Inventario = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\Inventario"
            Me.gvInventario.SaveLayoutToRegistry(regKey_Inventario & "\Default")
            Me.gvInventario.RestoreLayoutFromRegistry(Me.regKey_Inventario)
            Me.gvInventario.ActiveFilterString = String.Empty
            Me.gvInventario.FindFilterText = String.Empty

            'Valores por defecto
            Me.txtFechaInventario.EditValue = Date.Today
            Me.txtFechaRegularizacion.EditValue = Date.Today

            'Configuración empresa
            With a3ERP.DatosConfig
                Me.maskUnidades.Mask.EditMask = "n" & .NUMDECUNI
            End With

            'Menús contextuales
            Me.PopupMenuArticulo = New fPopupMenu(fPopupMenu.TipoMenu.Articulo, Me)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub fTerminalesInventario_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            If Me.MdiParent Is Nothing Then
                'Posición y tamaño
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("WindowState", Nothing) Is Nothing Then Me.WindowState = CInt(My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("WindowState", Me.WindowState))
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Left", Nothing) Is Nothing Then Me.Left = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Left", Me.Left)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Top", Nothing) Is Nothing Then Me.Top = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Top", Me.Top)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Width", Nothing) Is Nothing Then Me.Width = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Width", Me.Width)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Height", Nothing) Is Nothing Then Me.Height = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Height", Me.Height)
            End If

            Me.txtCODALM.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

#End Region

#Region "Eventos txtCODALM"
    Private Sub txtCODALM_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCODALM.ButtonClick

        Dim NaxMaestro As New a3ERPActiveX.Maestro

        Try
            NaxMaestro.Iniciar("ALMACEN")

            Dim Codigo As String = NaxMaestro.Seleccionar
            If Not Codigo Is Nothing Then Me.txtCODALM.EditValue = Codigo : Me.txtCODALM.DoValidate()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtCODALM_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCODALM.Validated
        Try
            If Not Me.txtCODALM.IsModified Then Exit Try

            Me.txtCODALM.EditValue = Aydara.SentenciaSQL("SELECT CODALM FROM ALMACEN WHERE LTRIM(CODALM) = '" & Trim(Me.txtCODALM.EditValue) & "'")
            Me.txtDESCALM.EditValue = Aydara.SentenciaSQL("SELECT DESCALM FROM ALMACEN WHERE CODALM = '" & Me.txtCODALM.EditValue & "'")

            Me.DsInventarios.IDA_INVENTARIOTERMINAL.CODALMColumn.DefaultValue = Me.txtCODALM.EditValue

        Catch ex As Exception
            MsgBox("Error al buscar el almacén", MsgBoxStyle.Information)
        End Try
    End Sub

#End Region

#Region "Funciones menú"
    Private Sub bttBuscar_Click(sender As Object, e As EventArgs) Handles bttBuscar.Click
        Try
            If Me.txtCODALM.EditValue = String.Empty Then
                MsgBox("Seleccione un almacén.", MsgBoxStyle.Information)
                Me.txtCODALM.Focus()
                Exit Try
            End If

            Me.DsInventarios.Cargar(Me.txtCODALM.EditValue, Me.txtFechaInventario.EditValue)

            Me.dgInventario.Focus()
            Me.gvInventario.FocusedColumn = Me.colCODART
            Me.gvInventario.MoveLastVisible()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttBorrarInventario_Click(sender As Object, e As EventArgs) Handles bttBorrarInventario.Click
        Try
            If MsgBox("¿Seguro que desea eliminar el inventario?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                Me.DsInventarios.Eliminar()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttImprimir_Click(sender As Object, e As EventArgs) Handles bttImprimir.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Informe As New DevExpress.XtraPrinting.PrintableComponentLink
            Dim ps As DevExpress.XtraPrinting.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()

            Informe.PaperName = "Inventario"
            Informe.PageHeaderFooter = Informes.CabeceraInforme("Inventario almacén " & Trim(Me.txtCODALM.EditValue) & " a fecha " & Me.txtFechaInventario.EditValue, Nothing)
            Informe.Component = Me.dgInventario

            Informe.PrintingSystem = ps

            Informe.CreateDocument()

            Informes.AbrirVistaPrevia(Informe.PaperName, Informe)

        Catch ex As Exception
            MsgBox("Error al generar el informe." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub bttDiferencias_Click(sender As Object, e As EventArgs) Handles bttDiferencias.Click
        Try
            If Me.IDAINVENTARIOTERMINALBindingSource.Filter = String.Empty Then
                Me.IDAINVENTARIOTERMINALBindingSource.Filter = "UNIDADES <> STOCK"
                Me.bttDiferencias.Text = "Ver todos"
            Else
                Me.IDAINVENTARIOTERMINALBindingSource.Filter = String.Empty
                Me.bttDiferencias.Text = "Ver diferencias"
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub bttActualizar_Click(sender As Object, e As EventArgs) Handles bttActualizar.Click
        Try
            If Me.txtCODALM.EditValue = String.Empty Then
                MsgBox("Seleccione un almacén", MsgBoxStyle.Information)
                Me.txtCODALM.Focus()
                Exit Try
            End If

            If Me.rgInventarioGeneral.EditValue Is Nothing Then
                MsgBox("Indique el tipo de actualización", MsgBoxStyle.Information)
                Me.rgInventarioGeneral.Focus()
                Exit Try
            End If

            If Me.DsInventarios.IDA_INVENTARIOTERMINAL.Count = 0 Then
                Me.DsInventarios.Cargar(Me.txtCODALM.EditValue, Me.txtFechaInventario.EditValue)
            End If

            If MsgBox("¿Seguro que desea regularizar las existencias?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                Me.DsInventarios.Actualizar(Me.txtCODALM.EditValue, Me.txtFechaInventario.EditValue, Me.txtFechaRegularizacion.EditValue, Me.rgInventarioGeneral.EditValue)
                Me.DsInventarios.Cargar(Me.txtCODALM.EditValue, Me.txtFechaInventario.EditValue)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttCancelar_Click(sender As Object, e As EventArgs) Handles bttCancelar.Click
        Try
            Me.DsInventarios.Cancelar()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttGuardar_Click(sender As Object, e As EventArgs) Handles bttGuardar.Click
        Try
            Me.DsInventarios.Guardar()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttDescargar_Click(sender As Object, e As EventArgs) Handles bttDescargar.Click
        Try
            If Me.txtCODALM.EditValue = String.Empty Then
                MsgBox("Seleccione un almacén", MsgBoxStyle.Information)
                Me.txtCODALM.Focus()
                Exit Try
            End If

            If MsgBox("¿Seguro que desea descargar los ficheros de los terminales?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                Dim Inventario As New dsInventarios

                Inventario.DescargarTerminales(Me.txtCODALM.EditValue)

                MsgBox("Ficheros descargados correctamente", MsgBoxStyle.Information, Me.Text)

                Me.bttBuscar_Click(Me.bttBuscar, Nothing)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

#End Region

#Region "Eventos txtFechaInventario"
    Private Sub txtFechaInventario_EditValueChanged(sender As Object, e As EventArgs) Handles txtFechaInventario.EditValueChanged
        Me.DsInventarios.FECHA = Me.txtFechaInventario.EditValue
    End Sub
#End Region

#Region "Eventos bttCODART"
    Private Sub bttCODART_KeyUp(sender As Object, e As KeyEventArgs) Handles bttCODART.KeyUp
        Select Case e.KeyCode
            Case Keys.F11
                Me.BuscaArticulo()
        End Select
    End Sub

    Private Sub bttCODART_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bttCODART.ButtonClick
        Me.BuscaArticulo()
    End Sub

    Private Sub BuscaArticulo()
        Try
            Dim CodigoArticulo As String = Aydara.Seleccionar("ARTICULO", "CODART", "AFESTOCK = 'T'")

            If Me.gvInventario.GetDataRow(Me.gvInventario.FocusedRowHandle) Is Nothing Then Me.gvInventario.AddNewRow()
            Me.gvInventario.SetFocusedRowCellValue(Me.colCODART, CodigoArticulo)

            'Mover foco
            If Me.gvInventario.GetFocusedRowCellValue(Me.colCODART) <> String.Empty Then
                Me.gvInventario.FocusedColumn = Me.gvInventario.VisibleColumns(Me.colDESCART.VisibleIndex + 1)
            Else
                Me.gvInventario.FocusedColumn = Me.colCODART
            End If

        Catch ex As Exception
            MsgBox("Error al buscar artículo." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "Eventos grilla"
    Private Sub gvInventario_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvInventario.FocusedRowChanged
        If Me.gvInventario.IsNewItemRow(e.FocusedRowHandle) Then Me.gvInventario.FocusedColumn = Me.colCODART
    End Sub

    Private Sub gvInventario_InvalidRowException(sender As Object, e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvInventario.InvalidRowException
        Me.gvInventario.CancelUpdateCurrentRow()
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore
        Me.gvInventario.FocusedColumn = Me.colCODART
        Me.gvInventario.MoveLastVisible()
    End Sub

    Private Sub gvInventario_InvalidValueException(sender As Object, e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gvInventario.InvalidValueException
        Me.gvInventario.CancelUpdateCurrentRow()
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore
        Me.gvInventario.FocusedColumn = Me.colCODART
        Me.gvInventario.MoveLastVisible()
    End Sub

    Private Sub gvLineas_InvalidRowException(sender As Object, e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvInventario.InvalidRowException
        Try
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub gvLineas_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles gvInventario.PopupMenuShowing
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            If Not Me.gvInventario.GetFocusedDataRow Is Nothing Then
                Me.PopupMenuArticulo.CODART = DirectCast(Me.gvInventario.GetFocusedDataRow, dsInventarios.IDA_INVENTARIOTERMINALRow).CODART
            Else
                Me.PopupMenuArticulo.CODART = String.Empty
            End If
            Me.PopupMenuArticulo.PopupMenuArticulo.ShowPopup(MousePosition)
        End If
    End Sub

#End Region

#Region "Popup menu"
    Private Sub PopupMenuArticulo_SeleccionarArticulo(CODART As String) Handles PopupMenuArticulo.Seleccionar
        Try
            If CODART <> String.Empty Then

                If Me.gvInventario.GetRow(Me.gvInventario.FocusedRowHandle) Is Nothing Then Me.gvInventario.AddNewRow()
                DirectCast(Me.gvInventario.GetFocusedDataRow, dsInventarios.IDA_INVENTARIOTERMINALRow).CODART = CODART

                'Mover foco
                If DirectCast(Me.gvInventario.GetFocusedDataRow, dsInventarios.IDA_INVENTARIOTERMINALRow).CODART <> String.Empty Then
                    Me.gvInventario.FocusedColumn = Me.gvInventario.VisibleColumns(Me.colDESCART.VisibleIndex + 1)
                Else
                    Me.gvInventario.FocusedColumn = Me.colCODART
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

#End Region

End Class