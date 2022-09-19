Public Class DameColorTalla

    Public IdArticulo As Integer, CodigoTallaje As Integer

#Region "DameColorTalla_FormClosing"
    Private Sub DameColorTalla_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Me.Dispose()
    End Sub
#End Region

#Region "DameColorTalla_Load"
    Private Sub DameColorTalla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Vaciar datos anterior y ajustar pantalla
        Me.DsArticulos.Clear()
        Me.PanelColores.Visible = True
        Me.PanelColores.Height = 190
        Me.PanelTallas.Visible = True
        Me.PanelTallas.Top = 210
        Me.PanelTallas.Height = 220

        'Mostrar colores y tallas
        If GestionColores Then
            Me.ARTICULOS_COLORESTableAdapter.Articulo(Me.DsArticulos.ARTICULOS_COLORES, IdArticulo)
            Me.COLORESTableAdapter.Fill(Me.DsArticulos.COLORES)
        End If

        If Me.DsArticulos.ARTICULOS_COLORES.Count <= 1 Then
            Me.PanelColores.Visible = False
            Me.PanelTallas.Top = Me.PanelColores.Top
            Me.PanelTallas.Height += Me.PanelColores.Height
        End If

        If GestionTallas Then DatosTalla()

        If Me.DsArticulos.TALLAS.Count <= 1 Then
            Me.PanelTallas.Visible = False
            Me.PanelColores.Height += Me.PanelTallas.Height
        End If

        If Me.DsArticulos.ARTICULOS_COLORES.Count = 1 And Me.DsArticulos.TALLAS.Count = 1 Then
            ResultadoBusqueda = Me.DsArticulos.ARTICULOS_COLORES(0).Color_Id & "+" & Me.DsArticulos.TALLAS(0).CodigoTalla
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub
#End Region

#Region "DameColorTalla_Shown"
    Private Sub DameColorTalla_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If GestionColores Then
            Dim i As Integer
            For i = 0 To Me.lvColores.RowCount - 1
                Dim Condicion As New DevExpress.XtraGrid.StyleFormatCondition
                Condicion.Appearance.BackColor = Color.FromArgb(Me.lvColores.GetRowCellDisplayText(i, Me.colColor_Id))
                Condicion.Appearance.ForeColor = Color.FromArgb(Me.lvColores.GetRowCellDisplayText(i, Me.colColor_Id))
                Condicion.Appearance.Options.UseBackColor = True
                Condicion.Appearance.Options.UseForeColor = True
                Condicion.Column = Me.colCodigoColor
                Condicion.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
                Condicion.Value1 = Me.lvColores.GetRowCellValue(i, Me.colCodigoColor)
                Me.lvColores.FormatConditions.Add(Condicion)
            Next
        Else
            Me.lvTallas.Focus()
        End If
        If IsNumeric(Me.lvColores.GetFocusedRowCellDisplayText(Me.colColor_Id)) Then Me.BackColor = Color.FromArgb(Me.lvColores.GetFocusedRowCellDisplayText(Me.colColor_Id))
    End Sub
#End Region

#Region "DatosTalla"
    Public Sub DatosTalla()

        'Cargar tallas
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        Dim i As Integer
        Dim rTallas As dsArticulos.TALLASRow

        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT * FROM TALLAS WHERE CodigoTalla=" & CodigoTallaje
            dr = cmd.ExecuteReader

            If dr.Read Then
                For i = 1 To IIf(GestionTallas, 18, 1) 'Nº de tallas 
                    If dr("Talla_" & i) <> String.Empty Then
                        Try
                            rTallas = Me.DsArticulos.TALLAS.NewTALLASRow
                            rTallas.CodigoTalla = i
                            rTallas.Descripcion = dr("Talla_" & i)
                            Me.DsArticulos.TALLAS.AddTALLASRow(rTallas)
                        Catch ex As Exception
                            'Error al añadir existencia
                        End Try
                    End If
                Next
            End If
            dr.Close()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try
    End Sub
#End Region

#Region "lvColores_Click"
    Private Sub lvColores_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvColores.Click
        If Me.lvColores.GetFocusedRow Is Nothing Or GestionTallas Then
            If Me.DsArticulos.TALLAS.Count = 1 Then
                ResultadoBusqueda = Me.lvColores.GetFocusedRowCellValue(Me.colCodigoColor) & "+" & Me.DsArticulos.TALLAS(0).CodigoTalla
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.lvTallas.Focus()
                Exit Sub
            End If
        End If
        ResultadoBusqueda = Me.lvColores.GetFocusedRowCellValue(Me.colCodigoColor) & "+1"
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
#End Region

#Region "lvTallas_Click"
    Private Sub lvTallas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvTallas.Click
        If Me.lvTallas.GetFocusedRow Is Nothing Then Exit Sub
        ResultadoBusqueda = IIf(GestionColores, Me.lvColores.GetFocusedRowCellValue(Me.colCodigoColor), 0) & "+" & Me.lvTallas.GetFocusedRowCellValue(Me.colCodigoTalla)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
#End Region

#Region "lvColores_BeforeLeaveRow"
    Private Sub lvColores_BeforeLeaveRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles lvColores.BeforeLeaveRow
        Me.lvColores.SetFocusedRowCellValue(Me.colArticulo_Id, 0)
    End Sub
#End Region

#Region "lvColores_FocusedRowChanged"
    Private Sub lvColores_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles lvColores.FocusedRowChanged
        If IsNothing(Me.lvColores.GetFocusedRow) Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Me.lvColores.SetFocusedRowCellValue(Me.colArticulo_Id, 1)
        If IsNumeric(Me.lvColores.GetFocusedRowCellDisplayText(Me.colColor_Id)) Then Me.BackColor = Color.FromArgb(Me.lvColores.GetFocusedRowCellDisplayText(Me.colColor_Id))
        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region "lvColores_KeyDown"
    Private Sub lvColores_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvColores.KeyDown
        If e.KeyCode = Keys.Enter Then Me.lvColores_Click(Nothing, Nothing)
    End Sub
#End Region

#Region "lvTallas_KeyDown"
    Private Sub lvTallas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvTallas.KeyDown
        If e.KeyCode = Keys.Enter Then Me.lvTallas_Click(Nothing, Nothing)
    End Sub
#End Region

End Class