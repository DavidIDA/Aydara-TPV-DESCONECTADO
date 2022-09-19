Public Class TraspasoAlmacenes 

#Region "TraspasoAlmacenes_FormClosing"
    Private Sub TraspasoAlmacenes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.bttCancelar.Text = "Cancelar" And Me.DsTraspasoAlmacenes.HasChanges Then
            If MsgBox("Está editando un traspaso. ¿Seguro que desea salir sin guardar los cambios?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then e.Cancel = True Else Me.Dispose()
        Else
            'Me.Dispose()
        End If
    End Sub
#End Region

#Region "TraspasoAlmacenes_KeyUp"
    Private Sub TraspasoAlmacenes_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape And Not Me.bttGuardar.Enabled Then Me.Close()
    End Sub
#End Region

#Region "TraspasoAlmacenes_Shown"
    Private Sub TraspasoAlmacenes_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txtNumeroalmacen.Focus()
    End Sub
#End Region

#Region "bttNuevo_Click"
    Private Sub bttNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttNuevo.Click
        Try
            Me.txtNumeroalmacen.EditValue = String.Empty
            Me.DsTraspasoAlmacenes.Clear()
            Me.txtNumeroalmacen.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttModificar_Click"
    Private Sub bttModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttModificar.Click
        Try
            Me.ActivaDesactivaMenu(False)
            Me.ActivaDesactivaCampos(False)
            Me.gvLineasTraspaso.MoveLastVisible()
            Me.dgLineasTraspaso.Focus()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click
        Try

            Dim dsTraspasoAlmacenes As New dsTraspasoAlmacenes, tTraspasoAlmacenes As New dsTraspasoAlmacenesTableAdapters.TRASPASO_ALMACENESTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("FechaEnvio") 'Campo
            Columnas.Add("Fecha envío") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("AlmacenDestino")
            Columnas.Add("Destino")
            Columnas.Add(60)
            Columnas.Add(60)

            Columnas.Add("CodigoArticulo")
            Columnas.Add("Artículo")
            Columnas.Add(150)
            Columnas.Add(150)

            Columnas.Add("Descripcion")
            Columnas.Add("Descripción")
            Columnas.Add(0)
            Columnas.Add(0)

            Columnas.Add("Cantidad")
            Columnas.Add("Cantidad")
            Columnas.Add(60)
            Columnas.Add(60)

            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT FechaEnvio, AlmacenDestino, CodigoArticulo, Descripcion, Cantidad FROM TRASPASO_ALMACENES LEFT JOIN ARTICULOS ON TRASPASO_ALMACENES.CodigoArticulo = ARTICULOS.Codigo"

            dsTraspasoAlmacenes.TRASPASO_ALMACENES.Load(cmd.ExecuteReader)

            cmd.Connection.Close()

            If Buscar(dsTraspasoAlmacenes, "TRASPASO_ALMACENES", Columnas, 0).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtNumeroalmacen.EditValue = ResultadoBusqueda
                Me.txtNumeroalmacen.IsModified = True
                Me.txtNumeroAlmacen_Validated(Nothing, Nothing)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttEliminar_Click"
    Private Sub bttEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttEliminar.Click
        Try
            If MsgBox("¿Seguro que desea eliminar los traspasos al almacén?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar traspaso") = MsgBoxResult.Yes Then
                Me.EliminaTraspasoAlmacen()
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Try
            If sender.text = "Salir" Then Me.Close()

            'If MsgBox("¿Seguro que desea deshacer los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Deshacer cambios") = MsgBoxResult.No Then Exit Sub

            Me.TRASPASOALMACENESBindingSource.CancelEdit()
            Me.DsTraspasoAlmacenes.RejectChanges()

            Me.ActivaDesactivaMenu(True)
            Me.ActivaDesactivaCampos(True)

            If Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES.Rows.Count = 0 Then Me.txtNumeroalmacen.EditValue = String.Empty
            Me.txtNumeroalmacen.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttGuardar_Click"
    Private Sub bttGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttGuardar.Click

        'Si es botón de envío preparar fichero para enviar
        If Me.bttGuardar.Text = "Enviar" Then

            If MsgBox("¿Seguro que desea enviar el traspaso?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            Dim NombreFichero As String = "tras" & Format(General.NumeroAlmacen, "00") & Format(Date.Today.Day, "00") & "_" & Date.Now.ToString("HHmmss") & ".seq"

            If Comunicacion.GeneraTraspasoAlmacenes(Me.DsTraspasoAlmacenes, NombreFichero) Then

                If Comunicacion.Envio(NombreFichero) Then

                    Dim FechaEnvio As Date = Date.Now
                    Dim Lineas As DataRow() = Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES.Select
                    For i As Integer = 0 To Lineas.Length - 1
                        With CType(Lineas(i), dsTraspasoAlmacenes.TRASPASO_ALMACENESRow)
                            .FechaEnvio = FechaEnvio
                        End With
                    Next
                    Me.TRASPASO_ALMACENESTableAdapter.Update(Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES)

                    MsgBox("Traspaso enviado correctamente", MsgBoxStyle.Information)

                    Me.DsTraspasoAlmacenes.Clear()
                    Me.ActivaDesactivaMenu(True)
                    Me.ActivaDesactivaCampos(True)

                    Me.txtNumeroalmacen.EditValue = String.Empty
                    Me.txtNumeroalmacen.Focus()

                Else
                    MsgBox("Error al enviar el fichero generado.", MsgBoxStyle.Exclamation)
                End If

            Else
                MsgBox("Error en la generación del fichero", MsgBoxStyle.Exclamation)
            End If

            Exit Sub

        End If

        Try
            Me.TRASPASOALMACENESBindingSource.EndEdit()
            Me.TRASPASO_ALMACENESTableAdapter.Update(Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES)

            'Actualizar existencias
            Dim i As Integer
            Dim rLinea As dsTraspasoAlmacenes.TRASPASO_ALMACENESRow

            For i = 0 To Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES.Count - 1

                rLinea = Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES(i)

                If Not rLinea.RowState = DataRowState.Deleted Then

                    If rLinea.Cantidad <> rLinea.CantidadAnterior Then
                        Almacen.ActualizaStock(rLinea.CodigoArticulo, 0, 1, (rLinea.Cantidad - rLinea.CantidadAnterior) * -1)
                        rLinea.CantidadAnterior = rLinea.Cantidad
                    End If

                End If

            Next

            Me.ActivaDesactivaMenu(True)
            Me.ActivaDesactivaCampos(True)
            
            Me.txtNumeroalmacen.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttCodigoArticulo_ButtonClick"
    Private Sub bttCodigoArticulo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bttCodigoArticulo.ButtonClick
        Try
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
                If Me.gvLineasTraspaso.GetRow(Me.gvLineasTraspaso.FocusedRowHandle) Is Nothing Then Me.gvLineasTraspaso.AddNewRow()
                Me.gvLineasTraspaso.SetFocusedValue(ResultadoBusqueda)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "gvLineasTraspaso_CellValueChanged"
    Private Sub gvLineasTraspaso_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvLineasTraspaso.CellValueChanged
        Try
            RemoveHandler gvLineasTraspaso.CellValueChanged, AddressOf gvLineasTraspaso_CellValueChanged

            Select Case e.Column.Name
                Case Me.colCodigoArticulo.Name

                    Dim CodigoArticulo As String = String.Empty, ControlBaja As Boolean

                    Dim dr As SqlClient.SqlDataReader
                    Dim cmd As New SqlClient.SqlCommand

                    Try
                        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
                        cmd.Connection.Open()

                        'Comprobar si es un código de barras de báscula
                        If Len(Me.gvLineasTraspaso.GetFocusedRowCellValue(Me.colCodigoArticulo)) = 13 And IsNumeric(Mid(Me.gvLineasTraspaso.GetFocusedRowCellValue(Me.colCodigoArticulo), 8, 5)) And (Mid(Me.gvLineasTraspaso.GetFocusedRowCellValue(Me.colCodigoArticulo), 1, 2) = PrefijoBascula1 Or Mid(Me.gvLineasTraspaso.GetFocusedRowCellValue(Me.colCodigoArticulo), 1, 2) = PrefijoBascula2 Or Mid(Me.gvLineasTraspaso.GetFocusedRowCellValue(Me.colCodigoArticulo), 1, 2) = PrefijoBascula3) Then
                            'Mostrar información del artículo
                            CodigoArticulo = "00" & Mid(Me.gvLineasTraspaso.GetFocusedRowCellValue(Me.colCodigoArticulo), 3, 5)

                            cmd.CommandText = "SELECT Codigo, ControlBaja FROM Articulos WHERE Codigo='" & CodigoArticulo & "'"

                            dr = cmd.ExecuteReader
                            If dr.Read Then
                                CodigoArticulo = dr("Codigo")
                                ControlBaja = dr("ControlBaja")
                            End If
                            dr.Close()

                            If ControlBaja Then
                                MsgBox("Artículo marcado con control de baja", MsgBoxStyle.Information, "Control de Baja")
                                Me.gvLineasTraspaso.SetFocusedValue(String.Empty)
                                Me.gvLineasTraspaso.SetFocusedRowCellValue(Me.colDescripcion, String.Empty)
                                Me.gvLineasTraspaso.FocusedColumn = Me.colId
                                Exit Sub
                            ElseIf CodigoArticulo <> String.Empty Then
                                Me.gvLineasTraspaso.SetFocusedValue(CodigoArticulo)
                                Me.gvLineasTraspaso.SetFocusedRowCellValue(Me.colDescripcion, Almacen.DameDescripcionArticulo(CodigoArticulo))
                                Me.gvLineasTraspaso.FocusedColumn = Me.colDescripcion
                            Else
                                MsgBox("No existe ningún artículo asociado con ese código", MsgBoxStyle.Information, "No existe")
                                Me.gvLineasTraspaso.SetFocusedValue(String.Empty)
                                Me.gvLineasTraspaso.SetFocusedRowCellValue(Me.colDescripcion, String.Empty)
                                Me.gvLineasTraspaso.FocusedColumn = Me.colId
                            End If

                            Me.InfoArticulo()
                            Me.ComprobarArticulo(CodigoArticulo, e.RowHandle)

                            Exit Sub

                        End If

                        'Mostrar información del artículo
                        cmd.CommandText = "SELECT Codigo, PrecioCoste, ControlBaja, TipoArticulo FROM Articulos WHERE Codigo='" & Me.gvLineasTraspaso.FocusedValue & "'"
                        dr = cmd.ExecuteReader
                        If dr.Read Then
                            CodigoArticulo = dr("Codigo")
                            ControlBaja = dr("ControlBaja")
                        End If
                        dr.Close()

                        'Comprobar si es un código de barras
                        If CodigoArticulo = String.Empty Then

                            cmd.CommandText = "SELECT Codigo, PrecioCoste, ControlBaja, TipoArticulo " & _
                                              "FROM Articulos INNER JOIN Codigo_Barras on Articulos.Id=Codigo_Barras.Articulo_Id " & _
                                              "WHERE Codigo_Barras.Codigobarras='" & Me.gvLineasTraspaso.GetFocusedRowCellValue(Me.colCodigoArticulo) & "'"

                            dr = cmd.ExecuteReader
                            If dr.Read Then
                                CodigoArticulo = dr("Codigo")
                                ControlBaja = dr("ControlBaja")
                            End If
                            dr.Close()

                            If ControlBaja Then
                                MsgBox("Artículo marcado con control de baja", MsgBoxStyle.Information, "Control de Baja")
                                Me.gvLineasTraspaso.SetFocusedValue(String.Empty)
                                Me.gvLineasTraspaso.FocusedColumn = Me.colCodigoArticulo
                                Exit Sub
                            ElseIf CodigoArticulo <> String.Empty Then
                                Me.gvLineasTraspaso.SetFocusedValue(CodigoArticulo)
                                Me.gvLineasTraspaso.SetFocusedRowCellValue(Me.colDescripcion, Almacen.DameDescripcionArticulo(CodigoArticulo))
                                Me.gvLineasTraspaso.FocusedColumn = Me.colDescripcion
                            Else
                                MsgBox("No existe ningún artículo asociado a ese código de barras.", MsgBoxStyle.Information, "No existe")
                                Me.gvLineasTraspaso.SetFocusedValue(String.Empty)
                                Me.gvLineasTraspaso.SetFocusedRowCellValue(Me.colDescripcion, String.Empty)
                                Me.gvLineasTraspaso.FocusedColumn = Me.colId
                            End If

                            Me.InfoArticulo()
                            Me.ComprobarArticulo(CodigoArticulo, e.RowHandle)

                            Exit Sub

                        End If

                        If ControlBaja Then
                            MsgBox("Artículo marcado con control de baja.", MsgBoxStyle.Information, "Control de Baja")
                            Me.gvLineasTraspaso.SetFocusedValue(String.Empty)
                            Me.gvLineasTraspaso.SetFocusedRowCellValue(Me.colDescripcion, String.Empty)
                            Me.gvLineasTraspaso.FocusedColumn = Me.colId
                            Exit Sub
                        ElseIf CodigoArticulo <> String.Empty Then
                            Me.gvLineasTraspaso.SetFocusedValue(CodigoArticulo)
                            Me.gvLineasTraspaso.SetFocusedRowCellValue(Me.colDescripcion, Almacen.DameDescripcionArticulo(CodigoArticulo))
                            Me.gvLineasTraspaso.FocusedColumn = Me.colDescripcion
                        Else
                            MsgBox("No existe ningún artículo asociado con ese código.", MsgBoxStyle.Information, "No existe")
                            Me.gvLineasTraspaso.SetFocusedValue(String.Empty)
                            Me.gvLineasTraspaso.SetFocusedRowCellValue(Me.colDescripcion, String.Empty)
                            Me.gvLineasTraspaso.FocusedColumn = Me.colId
                        End If

                    Catch ex As Exception
                        'Error al obtener datos del artículo
                    Finally
                        If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                    End Try

                    Me.InfoArticulo()
                    Me.ComprobarArticulo(CodigoArticulo, e.RowHandle)

                Case Me.colCajas.Name, Me.colCantidad.Name

                    If e.Column Is Me.colCajas Then
                        'Calcular unidades por caja
                        Dim UnidadesCaja As Integer
                        UnidadesCaja = Almacen.DameUnidadesCajaArticulo(Me.gvLineasTraspaso.GetRowCellValue(Me.gvLineasTraspaso.FocusedRowHandle, Me.colCodigoArticulo))
                        Me.gvLineasTraspaso.SetRowCellValue(Me.gvLineasTraspaso.FocusedRowHandle, Me.colCantidad, e.Value * UnidadesCaja)
                    Else
                        'Calcular cajas
                        Dim UnidadesCaja As Integer
                        UnidadesCaja = Almacen.DameUnidadesCajaArticulo(Me.gvLineasTraspaso.GetRowCellValue(Me.gvLineasTraspaso.FocusedRowHandle, Me.colCodigoArticulo))
                        If UnidadesCaja <> 0 Then
                            If e.Value Mod UnidadesCaja = 0 Then
                                Me.gvLineasTraspaso.SetRowCellValue(Me.gvLineasTraspaso.FocusedRowHandle, Me.colCajas, Int(e.Value / UnidadesCaja))
                            Else
                                Me.gvLineasTraspaso.SetRowCellValue(Me.gvLineasTraspaso.FocusedRowHandle, Me.colCajas, 0)
                            End If
                        Else
                            Me.gvLineasTraspaso.SetRowCellValue(Me.gvLineasTraspaso.FocusedRowHandle, Me.colCajas, 0)
                        End If
                    End If

            End Select

        Catch ex As Exception

        Finally
            AddHandler gvLineasTraspaso.CellValueChanged, AddressOf gvLineasTraspaso_CellValueChanged
        End Try
    End Sub
#End Region

#Region "gvLineasTraspaso_FocusedRowChanged"
    Private Sub gvLineasTraspaso_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvLineasTraspaso.FocusedRowChanged
        Me.InfoArticulo()
    End Sub
#End Region

#Region "InfoArticulo"
    Private Sub InfoArticulo()

        Me.lblInfoArticulo.Text = String.Empty

        If Me.gvLineasTraspaso.GetRow(Me.gvLineasTraspaso.FocusedRowHandle) Is Nothing Then Exit Sub

        'Mostrar datos del artículo
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT ISNULL(Sum(StockMinimo),0) AS StockMinimo, ISNULL(Sum(StockMaximo),0) AS StockMaximo, ISNULL(Sum(ExistenciaActual),0) AS ExistenciaActual, UnidadCaja, MinimoCompra " & _
                              "FROM ARTICULOS LEFT JOIN Existencias ON Articulos.Id = EXISTENCIAS.Articulo_Id " & _
                              "WHERE CodigoTienda=" & CodigoTienda & " AND Codigo='" & Me.gvLineasTraspaso.GetRowCellValue(Me.gvLineasTraspaso.FocusedRowHandle, Me.colCodigoArticulo) & "' " & _
                              "GROUP BY UnidadCaja, MinimoCompra"

            dr = cmd.ExecuteReader
            If dr.Read Then
                Me.lblInfoArticulo.Text = "Stock mínimo: " & dr("StockMinimo") & "   Stock máximo: " & dr("StockMaximo") & "   Existencias: " & dr("ExistenciaActual") & "   Unidades/Caja: " & dr("UnidadCaja") & "   Mínimo compra: " & dr("MinimoCompra")
            End If
            dr.Close()

        Catch ex As Exception
            'Error al obtener datos del artículo
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "ComprobarArticulo"
    Private Sub ComprobarArticulo(ByVal Codigo As String, ByVal fila As Integer)
        Try
            If Codigo = String.Empty Then Exit Try

            'Comprobar si la referencia ya está en el traspaso
            Dim i As Integer
            For i = 0 To Me.gvLineasTraspaso.RowCount - 1
                If i <> fila And Me.gvLineasTraspaso.GetRowCellValue(i, Me.colCodigoArticulo) = Codigo Then
                    MsgBox("El artículo seleccionado ya se encuentra en el traspaso", MsgBoxStyle.Information)
                    Me.gvLineasTraspaso.CancelUpdateCurrentRow()
                    Me.gvLineasTraspaso.FocusedColumn = Me.colAlmacenDestino
                    Me.gvLineasTraspaso.MoveLastVisible()
                    Exit For
                End If
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "txtNumeroAlmacen_Validated"
    Private Sub txtNumeroAlmacen_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumeroalmacen.Validated

        If Not Me.txtNumeroalmacen.IsModified Then Exit Sub

        If Not IsNumeric(Me.txtNumeroalmacen.EditValue) Or Me.txtNumeroalmacen.EditValue = General.NumeroAlmacen.ToString Then
            Me.txtNumeroalmacen.EditValue = String.Empty
            Me.DsTraspasoAlmacenes.Clear()
            Me.txtNumeroalmacen.Focus()
            Exit Sub
        End If

        Me.txtNumeroalmacen.EditValue = Format(Int(Me.txtNumeroalmacen.EditValue), "00")

        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT *, Cantidad AS CantidadAnterior FROM TRASPASO_ALMACENES WHERE FechaEnvio IS NULL AND AlmacenDestino=" & Int(Me.txtNumeroalmacen.EditValue)

            Me.DsTraspasoAlmacenes.Clear()
            Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES.Load(cmd.ExecuteReader)
            Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES.AlmacenDestinoColumn.DefaultValue = Int(Me.txtNumeroalmacen.EditValue)

            'Calcula cajas y muestra descripción
            Dim i As Integer
            Dim UnidadesCaja As Integer
            Dim rLineaTraspaso As dsTraspasoAlmacenes.TRASPASO_ALMACENESRow
            For i = 0 To Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES.Rows.Count - 1
                rLineaTraspaso = Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES.Rows(i)
                rLineaTraspaso.Descripcion = Almacen.DameDescripcionArticulo(rLineaTraspaso.CodigoArticulo)
                UnidadesCaja = Almacen.DameUnidadesCajaArticulo(rLineaTraspaso.CodigoArticulo)
                If UnidadesCaja <> 0 Then
                    rLineaTraspaso.Cajas = Int(rLineaTraspaso.Cantidad / UnidadesCaja)
                End If
            Next

            Me.ActivaDesactivaMenu(False)
            Me.ActivaDesactivaCampos(False)

            Me.gvLineasTraspaso.MoveLastVisible()
            Me.dgLineasTraspaso.Focus()

        Catch ex As Exception
            MsgBox("Error al mostrar traspasos pendientes del almacén", MsgBoxStyle.Exclamation)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try
    End Sub
#End Region

#Region "txtNumeroalmacen_ButtonClick"
    Private Sub txtNumeroalmacen_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtNumeroalmacen.ButtonClick
        Me.bttBuscar_Click(Nothing, Nothing)
    End Sub
#End Region

#Region "ActivaDesactivaMenu"
    Private Sub ActivaDesactivaMenu(ByVal activa As Boolean)

        Me.bttNuevo.Enabled = activa
        Me.bttBuscar.Enabled = activa
        Me.bttModificar.Enabled = IIf(Me.TRASPASOALMACENESBindingSource.Count = 0, False, activa)
        Me.bttEliminar.Enabled = IIf(Me.TRASPASOALMACENESBindingSource.Count = 0, False, activa)
        Me.NavTraspasoAlmacenes.Buttons.Remove.Enabled = IIf(Me.TRASPASOALMACENESBindingSource.Count = 0, False, activa)

        Me.bttImprimir.Enabled = IIf(Me.TRASPASOALMACENESBindingSource.Count = 0, False, activa)
        'Me.bttCancelar.Enabled = Not activa
        Me.bttCancelar.Text = IIf(activa, "Salir", "Cancelar")
        Me.bttGuardar.Enabled = Not activa

        If Me.bttModificar.Enabled Then
            'Comprobar si tiene comunicaciones para activar botón envío
            General.DatosTiendaActual(CodigoTienda)
            If General.Comunicaciones_Tipo > 0 Then
                Me.bttGuardar.Text = "Enviar"
                Me.bttGuardar.Enabled = True
            End If
        Else
            Me.bttGuardar.Text = "Guardar"
        End If

    End Sub
#End Region

#Region "ActivaDesactivaCampos"
    Private Sub ActivaDesactivaCampos(ByVal activa As Boolean)
        Me.txtNumeroalmacen.Properties.ReadOnly = IIf(activa, False, True)
        Me.txtNumeroalmacen.Properties.Buttons(0).Enabled = activa
        Me.gvLineasTraspaso.OptionsView.NewItemRowPosition = IIf(activa, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom)
        Me.gvLineasTraspaso.OptionsBehavior.AllowAddRows = IIf(activa, DevExpress.Utils.DefaultBoolean.False, DevExpress.Utils.DefaultBoolean.True)
        Me.gvLineasTraspaso.OptionsBehavior.AllowDeleteRows = IIf(activa, DevExpress.Utils.DefaultBoolean.False, DevExpress.Utils.DefaultBoolean.True)
        Me.NavTraspasoAlmacenes.Buttons.Append.Enabled = Not activa
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = activa
        Me.colCajas.OptionsColumn.ReadOnly = activa
        Me.colCantidad.OptionsColumn.ReadOnly = activa
    End Sub
#End Region

#Region "bttImprimir_Click"
    Private Sub bttImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimir.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            'Dim Informe As New DevExpress.XtraPrinting.PrintableComponentLink
            'Dim ps As DevExpress.XtraPrinting.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()

            'Informe.PageHeaderFooter = Informes.CabeceraInforme("Traspaso al almacén " & Me.txtNumeroalmacen.Text, Nothing)

            'Informe.Component = Me.dgLineasTraspaso

            'Informe.PrintingSystem = ps

            'Informe.CreateDocument()

            'Informes.AbrirVistaPrevia("Traspaso al almacén " & Me.txtNumeroalmacen.Text, Informe)

            Me.ImprimirTicket()

        Catch ex As Exception
            MsgBox("Error al generar el informe", MsgBoxStyle.Exclamation)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "ImprimirTicket"
    Private Sub ImprimirTicket()
        Try
            Dim ticket As String
            Dim i As Integer

            ticket = "ALMACEN DE ORIGEN : " & Format(General.NumeroAlmacen, "00")
            ticket &= vbCrLf & "ALMACEN DE DESTINO: " & Format(CInt(Me.txtNumeroalmacen.EditValue), "00")
            ticket &= vbCrLf & "NUMERO DE TRASPASO: " & Format(General.NumeroAlmacen, "00") & "  " & Format(Date.Today, "dd-MM-yyyy")
            ticket &= vbCrLf & "----------------------------------------"
            ticket &= vbCrLf & "CODIGO  DESCRIPCION             UNIDADES"
            ticket &= vbCrLf & "----------------------------------------"

            For i = 0 To Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES.Count - 1
                ticket &= vbCrLf & Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES(i).CodigoArticulo & " "
                ticket &= Mid(Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES(i).Descripcion, 1, 24)
                ticket &= String.Format("{0,7}", Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES(i).Cantidad)
            Next

            If ActivaCorteTicket Then ticket &= CorteTicket()

            Imprimir.SendStringToPrinter(My.Settings.ImpresoraTickets, ticket)

        Catch ex As Exception
            MsgBox("Error al imprimir ticket." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "EliminaTraspasoAlmacen"
    Private Sub EliminaTraspasoAlmacen()
        Try
            Dim i As Integer
            For i = 0 To Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES.Rows.Count - 1
                Almacen.ActualizaStock(Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES(i).CodigoArticulo, 0, 1, Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES(i).Cantidad)
                Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES.Rows(i).Delete()
            Next
            Me.TRASPASO_ALMACENESTableAdapter.Update(Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES)

            Me.txtNumeroalmacen.EditValue = String.Empty
            Me.txtNumeroalmacen.Focus()

        Catch ex As Exception
            MsgBox("Error al eliminar el traspaso de almacenes", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "NavTraspasoAlmacenes_ButtonClick"
    Private Sub NavTraspasoAlmacenes_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles NavTraspasoAlmacenes.ButtonClick
        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Remove Then

            If MsgBox("¿Seguro que desea eliminar la línea seleccionada?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                Almacen.ActualizaStock(Me.gvLineasTraspaso.GetFocusedRowCellValue(Me.colCodigoArticulo), 0, 1, Me.gvLineasTraspaso.GetFocusedRowCellValue(Me.colCantidadAnterior))

                Me.gvLineasTraspaso.DeleteRow(Me.gvLineasTraspaso.FocusedRowHandle)
                Me.TRASPASOALMACENESBindingSource.EndEdit()
                Me.TRASPASO_ALMACENESTableAdapter.Update(Me.DsTraspasoAlmacenes.TRASPASO_ALMACENES)
            Else

                e.Handled = True

            End If

        End If
    End Sub
#End Region

End Class