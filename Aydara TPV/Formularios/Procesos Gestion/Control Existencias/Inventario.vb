Public Class Inventario 

#Region "Inventario_Load"
    Private Sub Inventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DatosInventario()
    End Sub
#End Region

#Region "Inventario_Shown"
    Private Sub Inventario_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.gvInventario.MoveLastVisible()
        Me.txtFechaActualizacion.EditValue = Date.Today
        'Me.rgTipoactualizacion.EditValue = 0
    End Sub
#End Region

#Region "Inventario_KeyUp"
    Private Sub Inventario_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "Inventario_FormClosing"
    Private Sub Inventario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.DsInventario.HasChanges Then
            If MsgBox("¿Desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.INVENTARIOTableAdapter.Update(Me.DsInventario.INVENTARIO)
            End If
        End If
    End Sub
#End Region

#Region "DatosInventario"
    Private Sub DatosInventario()

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Dim rInventario As dsInventario.INVENTARIORow

        Try
            Me.DsInventario.Clear()

            cmd.CommandText = "SELECT INVENTARIO.*, ARTICULOS.Descripcion, ARTICULOS.UnidadCaja, EXISTENCIAS.ExistenciaActual " & _
                              "FROM (INVENTARIO INNER JOIN ARTICULOS ON INVENTARIO.CodigoArticulo = ARTICULOS.Codigo) " & _
                              "INNER JOIN EXISTENCIAS ON ARTICULOS.Id = EXISTENCIAS.Articulo_Id " & _
                              "WHERE EXISTENCIAS.CodigoTienda=" & CodigoTienda & " AND EXISTENCIAS.CodigoColor=0 AND EXISTENCIAS.CodigoTalla=1"

            dr = cmd.ExecuteReader
            While dr.Read
                rInventario = Me.DsInventario.INVENTARIO.NewINVENTARIORow
                rInventario.Id = dr("Id")
                rInventario.CodigoArticulo = dr("CodigoArticulo")
                rInventario.Descripcion = dr("Descripcion")
                rInventario.Cantidad = dr("Cantidad")
                If dr("UnidadCaja") <> 0 Then rInventario.Cajas = Int(rInventario.Cantidad / CType(dr("UnidadCaja"), Decimal))
                rInventario.ExistenciaActual = dr("ExistenciaActual")
                Me.DsInventario.INVENTARIO.AddINVENTARIORow(rInventario)
            End While
            dr.Close()

            Me.DsInventario.AcceptChanges()

        Catch ex As Exception
            MsgBox("Error al cargar datos del inventario", MsgBoxStyle.Exclamation)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
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
                If Me.gvInventario.GetRow(Me.gvInventario.FocusedRowHandle) Is Nothing Then Me.gvInventario.AddNewRow()
                Me.gvInventario.SetFocusedValue(ResultadoBusqueda)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "gvInventario_CellValueChanged"
    Private Sub gvInventario_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvInventario.CellValueChanged
        Try
            RemoveHandler gvInventario.CellValueChanged, AddressOf gvInventario_CellValueChanged

            Select Case e.Column.Name
                Case Me.colCodigoArticulo.Name

                    Dim CodigoArticulo As String = String.Empty

                    Dim cmd As New SqlClient.SqlCommand

                    Try
                        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
                        cmd.Connection.Open()

                        'Comprobar si es un código de barras
                        If Len(Me.gvInventario.GetFocusedRowCellValue(Me.colCodigoArticulo)) > 15 Then

                            cmd.CommandText = "SELECT ISNULL(Codigo,'') " & _
                                              "FROM Articulos INNER JOIN Codigo_Barras on Articulos.Id=Codigo_Barras.Articulo_Id " & _
                                              "WHERE Codigo_Barras.Codigobarras='" & Me.gvInventario.GetFocusedRowCellValue(Me.colCodigoArticulo) & "'"
                            CodigoArticulo = cmd.ExecuteScalar

                            If CodigoArticulo <> String.Empty Then
                                Me.gvInventario.SetFocusedValue(CodigoArticulo)
                                Me.gvInventario.SetFocusedRowCellValue(Me.colDescripcion, Almacen.DameDescripcionArticulo(CodigoArticulo))
                                Me.gvInventario.FocusedColumn = Me.colDescripcion
                            Else
                                MsgBox("No existe ningún artículo asociado a ese código de barras.", MsgBoxStyle.Information, "No existe")
                                Me.gvInventario.CancelUpdateCurrentRow()
                                If Me.gvInventario.IsNewItemRow(e.RowHandle) Then
                                    Me.gvInventario.FocusedColumn = Me.colId
                                    Me.gvInventario.MoveLastVisible()
                                Else
                                    Me.gvInventario.FocusedColumn = Me.colCodigoArticulo
                                End If
                                Exit Select
                            End If

                            Me.InfoArticulo()
                            Me.ComprobarArticulo(CodigoArticulo, e.RowHandle)

                            Exit Sub

                        End If

                        'If IsNumeric(Me.gvInventario.GetFocusedRowCellValue(Me.colCodigoArticulo)) Then Me.gvInventario.SetFocusedValue(Format(CType(Me.gvInventario.GetFocusedRowCellValue(Me.colCodigoArticulo), Integer), "0000000"))

                        'Mostrar información del artículo
                        cmd.CommandText = "SELECT Codigo FROM Articulos WHERE Codigo='" & Me.gvInventario.FocusedValue & "'"
                        CodigoArticulo = cmd.ExecuteScalar

                        If CodigoArticulo <> String.Empty Then
                            Me.gvInventario.SetFocusedValue(CodigoArticulo)
                            Me.gvInventario.SetFocusedRowCellValue(Me.colDescripcion, Almacen.DameDescripcionArticulo(CodigoArticulo))
                            Me.gvInventario.FocusedColumn = Me.colDescripcion
                        Else
                            MsgBox("No existe ningún artículo asociado con ese código.", MsgBoxStyle.Information, "No existe")
                            Me.gvInventario.CancelUpdateCurrentRow()
                            If Me.gvInventario.IsNewItemRow(e.RowHandle) Then
                                Me.gvInventario.FocusedColumn = Me.colId
                                Me.gvInventario.MoveLastVisible()
                            Else
                                Me.gvInventario.FocusedColumn = Me.colCodigoArticulo
                            End If
                            Exit Select
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
                        UnidadesCaja = Almacen.DameUnidadesCajaArticulo(Me.gvInventario.GetRowCellValue(Me.gvInventario.FocusedRowHandle, Me.colCodigoArticulo))
                        Me.gvInventario.SetRowCellValue(Me.gvInventario.FocusedRowHandle, Me.colCantidad, e.Value * UnidadesCaja)
                    Else
                        'Calcular cajas
                        Dim UnidadesCaja As Integer
                        UnidadesCaja = Almacen.DameUnidadesCajaArticulo(Me.gvInventario.GetRowCellValue(Me.gvInventario.FocusedRowHandle, Me.colCodigoArticulo))
                        If UnidadesCaja <> 0 Then
                            If e.Value Mod UnidadesCaja = 0 Then
                                Me.gvInventario.SetRowCellValue(Me.gvInventario.FocusedRowHandle, Me.colCajas, Int(e.Value / UnidadesCaja))
                            Else
                                Me.gvInventario.SetRowCellValue(Me.gvInventario.FocusedRowHandle, Me.colCajas, 0)
                            End If
                        Else
                            Me.gvInventario.SetRowCellValue(Me.gvInventario.FocusedRowHandle, Me.colCajas, 0)
                        End If
                    End If

            End Select

        Catch ex As Exception

        Finally
            AddHandler gvInventario.CellValueChanged, AddressOf gvInventario_CellValueChanged
        End Try
    End Sub
#End Region

#Region "gvInventario_FocusedRowChanged"
    Private Sub gvInventario_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvInventario.FocusedRowChanged
        Me.InfoArticulo()
    End Sub
#End Region

#Region "InfoArticulo"
    Private Sub InfoArticulo()

        Me.lblInfoArticulo.Text = String.Empty

        If Me.gvInventario.GetRow(Me.gvInventario.FocusedRowHandle) Is Nothing Then Exit Sub

        'Mostrar datos del artículo
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT ISNULL(Sum(StockMinimo),0) AS StockMinimo, ISNULL(Sum(StockMaximo),0) AS StockMaximo, ISNULL(Sum(ExistenciaActual),0) AS ExistenciaActual, UnidadCaja, MinimoCompra " & _
                              "FROM ARTICULOS LEFT JOIN Existencias ON Articulos.Id = EXISTENCIAS.Articulo_Id " & _
                              "WHERE CodigoTienda=" & CodigoTienda & " AND Codigo='" & Me.gvInventario.GetRowCellValue(Me.gvInventario.FocusedRowHandle, Me.colCodigoArticulo) & "' " & _
                              "GROUP BY UnidadCaja, MinimoCompra"

            dr = cmd.ExecuteReader
            If dr.Read Then
                Me.lblInfoArticulo.Text = "Stock mínimo: " & dr("StockMinimo") & "   Stock máximo: " & dr("StockMaximo") & "   Existencias: " & dr("ExistenciaActual") & "   Unidades/Caja: " & dr("UnidadCaja") & "   Mínimo compra: " & dr("MinimoCompra")
                Me.gvInventario.SetFocusedRowCellValue(Me.colExistenciaActual, dr("ExistenciaActual"))
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
            'Comprobar si la referencia ya está en el inventario
            Dim i As Integer
            For i = 0 To Me.gvInventario.RowCount - 1
                If i <> fila And Me.gvInventario.GetRowCellValue(i, Me.colCodigoArticulo) = Codigo Then

                    MsgBox("El artículo seleccionado ya se encuentra en el inventario", MsgBoxStyle.Information)
                    Me.gvInventario.CancelUpdateCurrentRow()

                    Me.gvInventario.MoveFirst()
                    Me.gvInventario.MoveBy(i)
                    Me.gvInventario.FocusedColumn = Me.colCajas

                    Exit For

                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "bttEliminar_Click"
    Private Sub bttEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttEliminar.Click

        Try
            If MsgBox("¿Seguro que desea eliminar el inventario actual?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar inventario") = MsgBoxResult.Yes Then
                Dim i As Integer
                For i = 0 To Me.DsInventario.INVENTARIO.Rows.Count - 1
                    Me.DsInventario.INVENTARIO.Rows(i).Delete()
                Next
                Me.INVENTARIOTableAdapter.Update(Me.DsInventario.INVENTARIO)
            End If

        Catch ex As Exception
            MsgBox("Error al eliminar el inventario", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "bttImprimir_Click"
    Private Sub bttImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimir.Click
        Try
            Dim Informe As New DevExpress.XtraPrinting.PrintableComponentLink
            Dim ps As DevExpress.XtraPrinting.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()

            Informe.PageHeaderFooter = Informes.CabeceraInforme("Inventario", Nothing)

            Informe.Component = Me.dgInventario

            Informe.PrintingSystem = ps

            Informe.CreateDocument()

            Informes.AbrirVistaPrevia("Listado inventario", Informe)

        Catch ex As Exception
            MsgBox("Error al generar el informe", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "gvInventario_CustomDrawCell"
    Private Sub gvInventario_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvInventario.CustomDrawCell
        Try
            If Not IsNothing(Me.gvInventario.GetDataRow(e.RowHandle)) Then
                Select Case e.Column.Name
                    Case Me.colExistenciaActual.Name
                        If e.CellValue <> Me.gvInventario.GetRowCellValue(e.RowHandle, Me.colCantidad) Then
                            e.Graphics.FillRectangle(Brushes.Orange, e.Bounds)
                        Else
                            e.Graphics.FillRectangle(Brushes.Transparent, e.Bounds)
                        End If
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "bttActualizar_Click"
    Private Sub bttActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttActualizar.Click

        If Me.rgTipoactualizacion.EditValue Is Nothing Then
            MsgBox("Seleccione el tipo de actualización", MsgBoxStyle.Information, Me.Text)
            Me.rgTipoactualizacion.Focus()
            Exit Sub
        End If

        Dim conexion As New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        conexion.Open()

        Dim transaccion As SqlClient.SqlTransaction
        transaccion = conexion.BeginTransaction()

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = conexion
        cmd.Transaction = transaccion

        Try
            Me.Cursor = Cursors.WaitCursor

            'Actualizar inventario
            Me.INVENTARIOTableAdapter.Update(Me.DsInventario.INVENTARIO)

            'Si es actualización general, inicializar existencias de todos artículo
            If Me.rgTipoactualizacion.EditValue = 0 Then
                cmd.CommandText = "UPDATE EXISTENCIAS SET ExistenciaActual = 0 " & _
                                  "WHERE CodigoTienda=" & CodigoTienda & " AND CodigoColor=0 AND CodigoTalla=1"
                cmd.ExecuteNonQuery()
            End If

            'Actualizar existencias de los artículos del inventario
            cmd.CommandText = "UPDATE EXISTENCIAS SET ExistenciaActual = INVENTARIO.Cantidad " & _
                              "FROM (ARTICULOS INNER JOIN INVENTARIO ON ARTICULOS.Codigo = INVENTARIO.CodigoArticulo) " & _
                              "INNER JOIN EXISTENCIAS ON ARTICULOS.Id = EXISTENCIAS.Articulo_Id " & _
                              "WHERE EXISTENCIAS.CodigoTienda=" & CodigoTienda & " AND EXISTENCIAS.CodigoColor=0 AND EXISTENCIAS.CodigoTalla=1"
            cmd.ExecuteNonQuery()

            'Añadir histórico de inventario
            cmd.CommandText = "INSERT INTO HISTORICO_INVENTARIO (Articulo_Id, CodigoTienda, Fecha, Cantidad) " & _
                              "SELECT ARTICULOS.Id, " & CodigoTienda & ", '" & Me.txtFechaActualizacion.EditValue & "', ISNULL(INVENTARIO.Cantidad,0) " & _
                              "FROM (ARTICULOS " & IIf(Me.rgTipoactualizacion.EditValue = 0, "LEFT", "INNER") & " JOIN INVENTARIO ON ARTICULOS.Codigo = INVENTARIO.CodigoArticulo)"
            cmd.ExecuteNonQuery()

            'Actualizar existencias de movimientos posteriores a la fecha de actualización
            '-----------------------------------------------------------------------------

            'Sumar stock de entradas de mercancía
            cmd.CommandText = "UPDATE EXISTENCIAS SET ExistenciaActual = ExistenciaActual + (SELECT ISNULL(SUM(ALBARANES_COMPRAS_LINEAS.Cantidad),0) " & _
                              "FROM ((ALBARANES_COMPRAS INNER JOIN ALBARANES_COMPRAS_LINEAS ON ALBARANES_COMPRAS.Id = ALBARANES_COMPRAS_LINEAS.AlbaranCompra_Id) " & _
                              "INNER JOIN ARTICULOS ON ALBARANES_COMPRAS_LINEAS.CodigoArticulo = ARTICULOS.Codigo) " & _
                              "WHERE ARTICULOS.Id = EXISTENCIAS.Articulo_Id AND ALBARANES_COMPRAS.CodigoTienda=" & CodigoTienda & " AND ALBARANES_COMPRAS.Fecha > '" & Me.txtFechaActualizacion.EditValue & "') " & _
                              "WHERE EXISTENCIAS.CodigoTienda=" & CodigoTienda & " AND EXISTENCIAS.CodigoColor=0 AND EXISTENCIAS.CodigoTalla=1"
            cmd.ExecuteNonQuery()

            'Restar stock de histórico de tickets
            cmd.CommandText = "UPDATE EXISTENCIAS SET ExistenciaActual = ExistenciaActual - (SELECT ISNULL(SUM(HISTORICO_TICKETS_LINEAS.Cantidad),0) " & _
                              "FROM ((HISTORICO_TICKETS INNER JOIN HISTORICO_TICKETS_LINEAS ON HISTORICO_TICKETS.Id = HISTORICO_TICKETS_LINEAS.Ticket_Id) " & _
                              "INNER JOIN ARTICULOS ON HISTORICO_TICKETS_LINEAS.CodigoArticulo = ARTICULOS.Codigo) " & _
                              "WHERE ARTICULOS.Id = EXISTENCIAS.Articulo_Id AND HISTORICO_TICKETS.CodigoTienda=" & CodigoTienda & " AND HISTORICO_TICKETS.FechaTicket > '" & Me.txtFechaActualizacion.EditValue & "') " & _
                              "WHERE EXISTENCIAS.CodigoTienda=" & CodigoTienda & " AND EXISTENCIAS.CodigoColor=0 AND EXISTENCIAS.CodigoTalla=1"
            cmd.ExecuteNonQuery()

            'Restar stock de tickets del día que no estén en espera
            cmd.CommandText = "UPDATE EXISTENCIAS SET ExistenciaActual = ExistenciaActual - (SELECT ISNULL(SUM(TICKETS_LINEAS.Cantidad),0) " & _
                              "FROM ((TICKETS INNER JOIN TICKETS_LINEAS ON TICKETS.Id = TICKETS_LINEAS.Ticket_Id) " & _
                              "INNER JOIN ARTICULOS ON TICKETS_LINEAS.CodigoArticulo = ARTICULOS.Codigo) " & _
                              "WHERE ARTICULOS.Id = EXISTENCIAS.Articulo_Id AND TICKETS.CodigoTienda=" & CodigoTienda & " AND TICKETS.EnEspera=0 AND TICKETS.FechaTicket > '" & Me.txtFechaActualizacion.EditValue & "') " & _
                              "WHERE EXISTENCIAS.CodigoTienda=" & CodigoTienda & " AND EXISTENCIAS.CodigoColor=0 AND EXISTENCIAS.CodigoTalla=1"
            cmd.ExecuteNonQuery()

            transaccion.Commit()

            MsgBox("Proceso de actualización finalizado", MsgBoxStyle.Information)

        Catch ex As Exception
            transaccion.Rollback()
            MsgBox("Error al actualizar el inventario", MsgBoxStyle.Exclamation)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            Me.Cursor = Cursors.Default
        End Try

        Me.DatosInventario()

    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click

        If Me.DsInventario.HasChanges Then
            If MsgBox("¿Desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.INVENTARIOTableAdapter.Update(Me.DsInventario.INVENTARIO)
            End If
        End If

        Dim dsArticulos As New dsArticulos
        Dim Columnas As New ArrayList
        Dim cmd As New SqlClient.SqlCommand()

        Try
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

            Columnas.Add("MinimoVenta")
            Columnas.Add("Exis.Actual")
            Columnas.Add(80)
            Columnas.Add(80)

            Columnas.Add("MinimoCompra")
            Columnas.Add("Inventario")
            Columnas.Add(80)
            Columnas.Add(80)

            Columnas.Add("UnidadCaja")
            Columnas.Add("Diferencias")
            Columnas.Add(80)
            Columnas.Add(80)

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "select familiasarticulos.codigo + ' - ' + subfamiliasarticulos.codigo as Etiqueta, articulos.codigo, articulos.descripcion, " & _
                              "existencias.existenciaactual as MinimoVenta, inventario.cantidad as MinimoCompra, inventario.cantidad - existencias.existenciaactual as UnidadCaja " & _
                              "from " & _
                              "(((articulos left join familiasarticulos on articulos.codigofamilia=familiasarticulos.id) " & _
                              "left join subfamiliasarticulos on familiasarticulos.id=subfamiliasarticulos.familia_id " & _
                              "and articulos.codigosubfamilia=subfamiliasarticulos.id) " & _
                              "left join existencias on articulos.id = existencias.articulo_id) " & _
                              "left join inventario on articulos.codigo = inventario.codigoarticulo " & _
                              "where existencias.codigotienda=" & CodigoTienda & " and existencias.codigocolor=0 and existencias.codigotalla=1 " & _
                              "and existencias.existenciaactual <> isnull(inventario.cantidad,0)"

            dsArticulos.ARTICULOS.Load(cmd.ExecuteReader)

            Buscar(dsArticulos, "ARTICULOS", Columnas, 2).ShowDialog()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try
    End Sub
#End Region

#Region "bttEnviar_Click"
    Private Sub bttEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttEnviar.Click
        If Comunicacion.GeneraInventario(Me.DsInventario) Then
            MsgBox("Inventario listo para enviar", MsgBoxStyle.Information)
        Else
            MsgBox("Error en la generación del inventario", MsgBoxStyle.Exclamation)
        End If
    End Sub
#End Region

End Class