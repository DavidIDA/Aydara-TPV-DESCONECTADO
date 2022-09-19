Imports System.Threading

Public Class BusquedaArticulos

#Region "BusquedaArticulos_KeyUp"
    Private Sub BusquedaArticulos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Try
            Select Case e.KeyCode
                Case Keys.Enter

                    Dim Teclado As Process
                    Dim Teclados As Process() = Process.GetProcessesByName("osk") 'creates an array with all running processes with the same name

                    For Each Teclado In Teclados
                        Teclado.Kill()
                    Next

                Case Keys.Escape
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "BusquedaArticulos_FormClosing"
    Private Sub BusquedaArticulos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Me.Dispose()
    End Sub
#End Region

#Region "BusquedaArticulos_Load"
    Private Sub BusquedaArticulos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            RemoveHandler gvArticulos.FocusedRowChanged, AddressOf gvArticulos_FocusedRowChanged

            Me.gvArticulos.ClearColumnsFilter()

            If GestionColores Then Me.COLORESTableAdapter.Fill(Me.DsArticulos.COLORES)
            Me.DsArticulos.EXISTENCIAS.Clear()
            ListadoArticulos()

            Me.dgExistencias.Visible = (GestionColores Or GestionTallas)
            Me.lblTallasColores.Visible = (GestionColores Or GestionTallas)

        Finally
            'AddHandler gvArticulos.FocusedRowChanged, AddressOf gvArticulos_FocusedRowChanged
        End Try
    End Sub
#End Region

#Region "BusquedaArticulos_Shown"
    Private Sub BusquedaArticulos_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            'Decimales en precios
            Me.maskPrecio.Mask.EditMask = "c" & DecimalesPrecio
            Me.maskPrecioVenta.Mask.EditMask = "c" & DecimalesPrecio

            'Me.SplitContainerControl1.PanelVisibility = IIf(GestionColores Or GestionTallas, DevExpress.XtraEditors.SplitPanelVisibility.Both, DevExpress.XtraEditors.SplitPanelVisibility.Panel1)

            Me.SplitContainerControl1.Panel1.MinSize = IIf(GestionColores Or GestionTallas, 150, Me.SplitContainerControl1.Height - Me.bttTeclado.Height)
            Me.SplitContainerControl1.SplitterPosition = IIf(GestionColores Or GestionTallas, Me.SplitContainerControl1.Height / 2, Me.SplitContainerControl1.Height - Me.bttTeclado.Height)

            Me.colDescripcionTalla.Visible = GestionTallas
            Me.colCodigoColor.Visible = GestionColores

            Me.gvArticulos.ClearColumnsFilter()
            Me.gvArticulos.FindFilterText = String.Empty

            If Me.gvArticulos.IsFindPanelVisible Then
                Dim find As DevExpress.XtraGrid.Controls.FindControl = TryCast(Me.gvArticulos.GridControl.Controls.Find("FindControl", True)(0), DevExpress.XtraGrid.Controls.FindControl)
                find.FindEdit.Focus()
            Else
                Me.gvArticulos.FocusedRowHandle = -999997 'Foco en la línea de búsqueda
                Me.gvArticulos.FocusedColumn = Me.colDescripcion
            End If

        Finally
            AddHandler gvArticulos.FocusedRowChanged, AddressOf gvArticulos_FocusedRowChanged
        End Try
    End Sub
#End Region

#Region "gvArticulos_FocusedRowChanged"
    Private Sub gvArticulos_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvArticulos.FocusedRowChanged
        If (GestionTallas Or GestionColores) And Not Me.gvArticulos.GetFocusedRow Is Nothing Then
            Me.Cursor = Cursors.WaitCursor
            MostrarExistencias()
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region

#Region "ListadoArticulos"
    Private Sub ListadoArticulos()
        Try
            Me.DsArticulos.ARTICULOS.Clear()

            Dim rArticulos As dsArticulos.ARTICULOSRow
            Dim cmd As New SqlClient.SqlCommand
            Dim i As Integer

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

            cmd.Connection.Open()

            cmd.CommandText = "SELECT Id, Codigo, Descripcion, Precio, CodigoTalla, ControlBaja, " & _
                               "(SELECT ISNULL(Sum(ExistenciaActual),0) FROM Existencias WHERE Articulo_Id=Articulos.Id) AS Descuento, " & _
                               "(SELECT ISNULL(Max(PrecioPromocion),0) FROM Promociones WHERE CodigoArticulo=Articulos.Codigo AND ISNULL(CodigoColor,-1)=-1 AND ISNULL(CodigoTalla,-1)=-1 " & _
                               "AND FechaInicio<='" & Date.Now & "' AND FechaFinal>='" & Date.Now & "') AS PrecioCoste " & _
                               "FROM Articulos " & _
                               "ORDER BY Descripcion"

            Me.DsArticulos.ARTICULOS.Load(cmd.ExecuteReader)

            'Marcar promociones
            For i = 0 To Me.DsArticulos.ARTICULOS.Rows.Count - 1
                rArticulos = Me.DsArticulos.ARTICULOS.Rows(i)
                If rArticulos.PrecioCoste > 0 Then
                    rArticulos.Precio = rArticulos.PrecioCoste
                    rArticulos.CantidadVariable = True
                End If
            Next

        Catch ex As Exception
            MsgBox("Error al mostrar listado de artículos", MsgBoxStyle.Exclamation, "Error en listado")
        End Try
    End Sub
#End Region

#Region "gvArticulos_KeyUp"
    Private Sub gvArticulos_KeyUp(sender As Object, e As KeyEventArgs) Handles gvArticulos.KeyUp
        If e.KeyCode = Keys.Enter Then Me.dgArticulos_MouseDoubleClick(Nothing, Nothing)
    End Sub
#End Region

#Region "gvArticulos_CustomDrawCell"
    Private Sub gvArticulos_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvArticulos.CustomDrawCell
        Try
            If Not IsNothing(Me.gvArticulos.GetDataRow(e.RowHandle)) Then
                Select Case e.Column.Name
                    Case Me.colPrecio.Name
                        If Me.gvArticulos.GetRowCellValue(e.RowHandle, Me.colPromocion) = True Then
                            e.Graphics.FillRectangle(Brushes.GreenYellow, e.Bounds)
                        End If
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "gvExistencias_CustomDrawCell"
    Private Sub gvColores_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvExistencias.CustomDrawCell
        Try
            If Not IsNothing(Me.gvExistencias.GetDataRow(e.RowHandle)) Then
                Select Case e.Column.Name
                    Case Me.colCodigoColor.Name
                        If IsNumeric(e.DisplayText) Then
                            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(e.DisplayText)), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
                            e.Appearance.ForeColor = Color.FromArgb(e.DisplayText)
                        End If
                    Case Me.colPrecioVenta.Name
                        If Me.gvExistencias.GetRowCellValue(e.RowHandle, Me.colPromocionExistencias) = True Then
                            e.Graphics.FillRectangle(Brushes.GreenYellow, e.Bounds)
                        End If
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "MostrarExistencias"
    Public Sub MostrarExistencias()
        Try
            Dim rExistencias As dsArticulos.EXISTENCIASRow

            'Vaciar tablae existencias
            Me.DsArticulos.EXISTENCIAS.Clear()

            If Me.DsArticulos.ARTICULOS.Rows.Count = 0 Then Exit Sub

            Dim dr As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand
            Dim i As Integer, j As Integer, filas As Integer

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            'Cargar existencias actuales
            'cmd.CommandText = "SELECT * FROM EXISTENCIAS " & _
            '                  "WHERE Articulo_Id=" & Me.gvArticulos.GetFocusedRowCellValue(Me.colIdArticulo) & " AND CodigoTienda=" & CodigoTienda

            cmd.CommandText = "SELECT ISNULL((Select Max(PrecioPromocion) from Promociones Where CodigoTienda=" & CodigoTienda & " AND CodigoArticulo='" & Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigo) & "' AND CodigoColor=Existencias.CodigoColor AND CodigoTalla=Existencias.CodigoTalla AND FechaInicio<='" & Date.Now & "' AND FechaFinal>='" & Date.Now & "'), " & _
                              "ISNULL((Select Max(PrecioPromocion) from Promociones Where CodigoTienda=" & CodigoTienda & " AND CodigoArticulo='" & Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigo) & "' AND CodigoColor=Existencias.CodigoColor AND FechaInicio<='" & Date.Now & "' AND FechaFinal>='" & Date.Now & "'), " & _
                              "ISNULL((Select Max(PrecioPromocion) from Promociones Where CodigoTienda=" & CodigoTienda & " AND CodigoArticulo='" & Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigo) & "' AND CodigoColor=Existencias.CodigoColor AND CodigoTalla=Existencias.CodigoTalla AND FechaInicio<='" & Date.Now & "' AND FechaFinal>='" & Date.Now & "'),0))) AS PrecioPromocion, " & _
                              "* FROM EXISTENCIAS WHERE Articulo_Id=" & Me.gvArticulos.GetFocusedRowCellValue(Me.colIdArticulo) & " AND CodigoTienda=" & CodigoTienda

            If Not GestionTallas Then cmd.CommandText += " AND CodigoTalla=1"

            If Not GestionColores Then
                cmd.CommandText += " AND CodigoColor=0"
            Else
                Me.ARTICULOS_COLORESTableAdapter.Articulo(Me.DsArticulos.ARTICULOS_COLORES, Me.gvArticulos.GetFocusedRowCellValue(Me.colIdArticulo))
            End If

            Me.DsArticulos.EXISTENCIAS.Load(cmd.ExecuteReader)

            If Not GestionColores And Not GestionTallas Then
                If Me.DsArticulos.EXISTENCIAS.Rows.Count = 0 Then
                    rExistencias = Me.DsArticulos.EXISTENCIAS.NewEXISTENCIASRow
                    rExistencias.CodigoTienda = CodigoTienda
                    rExistencias.Articulo_Id = Me.gvArticulos.GetFocusedRowCellValue(Me.colIdArticulo)
                    rExistencias.CodigoColor = 0
                    rExistencias.CodigoTalla = 1
                    Me.DsArticulos.EXISTENCIAS.AddEXISTENCIASRow(rExistencias)
                    Exit Sub
                End If
            End If

            'Cargar tallas
            cmd.CommandText = "SELECT * FROM TALLAS WHERE CodigoTalla=" & IIf(GestionTallas, IIf(IsNumeric(Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoTallaArticulo)), Me.gvArticulos.GetFocusedRowCellValue(Me.colCodigoTallaArticulo), -1), 0)
            dr = cmd.ExecuteReader

            If dr.Read Then
                For i = 0 To IIf(GestionColores, IIf(Me.DsArticulos.ARTICULOS_COLORES.Rows.Count = 0, 0, Me.DsArticulos.ARTICULOS_COLORES.Rows.Count - 1), 0)
                    For j = 1 To 18 'Nº de tallas 
                        If dr("Talla_" & j) <> String.Empty Then
                            Try
                                'Comprobar si existen existencias
                                For filas = 0 To Me.DsArticulos.EXISTENCIAS.Rows.Count - 1
                                    rExistencias = Me.DsArticulos.EXISTENCIAS.Rows(filas)
                                    If rExistencias.CodigoTalla = j Then
                                        If GestionColores And Me.DsArticulos.COLORES.Rows.Count > 0 Then
                                            If rExistencias.CodigoColor = Me.DsArticulos.ARTICULOS_COLORES.Rows(i).Item("Color_Id") Then
                                                rExistencias.DescripcionTalla = dr("Talla_" & j)
                                                If rExistencias.PrecioPromocion <> 0 Then
                                                    rExistencias.PrecioVenta = rExistencias.PrecioPromocion
                                                    rExistencias.Promocion = True
                                                ElseIf Me.gvArticulos.GetFocusedRowCellValue(Me.colPromocion) Then
                                                    rExistencias.PrecioVenta = Me.gvArticulos.GetFocusedRowCellValue(Me.colPrecio)
                                                    rExistencias.Promocion = True
                                                End If
                                                If rExistencias.PrecioVenta = 0 Then
                                                    rExistencias.PrecioVenta = Me.gvArticulos.GetFocusedRowCellValue(Me.colPrecio)
                                                    rExistencias.Promocion = Me.gvArticulos.GetFocusedRowCellValue(Me.colPromocion)
                                                End If
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
                                rExistencias.Articulo_Id = Me.gvArticulos.GetFocusedRowCellValue(Me.colIdArticulo)
                                If GestionColores And Me.DsArticulos.ARTICULOS_COLORES.Rows.Count > 0 Then rExistencias.CodigoColor = Me.DsArticulos.ARTICULOS_COLORES.Rows(i).Item("Color_Id")
                                rExistencias.CodigoTalla = j
                                rExistencias.DescripcionTalla = dr("Talla_" & j)
                                If rExistencias.PrecioPromocion <> 0 Then
                                    rExistencias.PrecioVenta = rExistencias.PrecioPromocion
                                    rExistencias.Promocion = True
                                ElseIf Me.gvArticulos.GetFocusedRowCellValue(Me.colPromocion) Then
                                    rExistencias.PrecioVenta = Me.gvArticulos.GetFocusedRowCellValue(Me.colPrecio)
                                    rExistencias.Promocion = True
                                End If
                                If rExistencias.PrecioVenta = 0 Then
                                    rExistencias.PrecioVenta = Me.gvArticulos.GetFocusedRowCellValue(Me.colPrecio)
                                    rExistencias.Promocion = Me.gvArticulos.GetFocusedRowCellValue(Me.colPromocion)
                                End If
                                Me.DsArticulos.EXISTENCIAS.AddEXISTENCIASRow(rExistencias)
                            Catch ex As Exception
                                'Error al añadir existencia
                            End Try

                        End If
                    Next
                Next
            End If
            dr.Close()

            Me.EXISTENCIASBindingSource.Sort = "CodigoColor ASC, CodigoTalla ASC"

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "dgArticulos_MouseDoubleClick"
    Private Sub dgArticulos_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgArticulos.MouseDoubleClick
        If Me.gvArticulos.GetRow(Me.gvArticulos.FocusedRowHandle) Is Nothing Then Exit Sub
        If Me.Tag = "Id" Then
            Me.Tag = String.Empty
            ResultadoBusqueda = Me.gvArticulos.GetRowCellValue(Me.gvArticulos.FocusedRowHandle, Me.colIdArticulo)
        Else
            ResultadoBusqueda = Me.gvArticulos.GetRowCellValue(Me.gvArticulos.FocusedRowHandle, Me.colCodigo)
        End If
        Me.DialogResult = Windows.Forms.DialogResult.Retry 'Selecciona artículo
    End Sub
#End Region

#Region "dgExistencias_MouseDoubleClick"
    Private Sub dgExistencias_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgExistencias.MouseDoubleClick
        If Me.gvExistencias.GetRow(Me.gvExistencias.FocusedRowHandle) Is Nothing Then Exit Sub
        If Me.Tag = "Id" Then
            Me.Tag = String.Empty
            ResultadoBusqueda = Me.gvArticulos.GetRowCellValue(Me.gvArticulos.FocusedRowHandle, Me.colIdArticulo) & "+" & Me.gvExistencias.GetRowCellValue(Me.gvExistencias.FocusedRowHandle, Me.colCodigoColor) & "+" & Me.gvExistencias.GetRowCellValue(Me.gvExistencias.FocusedRowHandle, Me.colCodigoTalla)
        Else
            ResultadoBusqueda = Me.gvArticulos.GetRowCellValue(Me.gvArticulos.FocusedRowHandle, Me.colCodigo) & "+" & Me.gvExistencias.GetRowCellValue(Me.gvExistencias.FocusedRowHandle, Me.colCodigoColor) & "+" & Me.gvExistencias.GetRowCellValue(Me.gvExistencias.FocusedRowHandle, Me.colCodigoTalla)
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK 'Selecciona artículo + color + talla
    End Sub
#End Region

#Region "bttTeclado_Click"
    Private Sub bttTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttTeclado.Click
        Try
            System.Diagnostics.Process.Start("osk.exe")
            Me.dgArticulos.Focus()

            If Me.gvArticulos.IsFindPanelVisible Then
                Dim find As DevExpress.XtraGrid.Controls.FindControl = TryCast(Me.gvArticulos.GridControl.Controls.Find("FindControl", True)(0), DevExpress.XtraGrid.Controls.FindControl)
                find.FindEdit.Focus()
            Else
                Me.gvArticulos.FocusedRowHandle = -999997 'Foco en la línea de búsqueda
                Me.gvArticulos.FocusedColumn = Me.colDescripcion
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "bttSeleccionar_Click"
    Private Sub bttSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttSeleccionar.Click
        Me.dgArticulos_MouseDoubleClick(Nothing, Nothing)
    End Sub
#End Region

#Region "bttSalir_Click"
    Private Sub bttSalir_Click(sender As Object, e As EventArgs) Handles bttSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

#Region "checkControlBaja_CheckedChanged"
    Private Sub checkControlBaja_CheckedChanged(sender As Object, e As EventArgs) Handles checkControlBaja.CheckedChanged
        Me.ARTICULOSBindingSource.Filter = "ControlBaja = " & Me.checkControlBaja.Checked
    End Sub
#End Region

End Class