<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CubosEstadisticos
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel
        Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel
        Me.lstCabecerasTickets = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.lstLineasTickets = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.dgEstadisticas = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.lstArticulos = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.lstFamilias = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.lstSubfamilias = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.checkCabecerasTickets = New DevExpress.XtraEditors.CheckEdit
        Me.checkLineasTicket = New DevExpress.XtraEditors.CheckEdit
        Me.checkArticulos = New DevExpress.XtraEditors.CheckEdit
        Me.checkFamilias = New DevExpress.XtraEditors.CheckEdit
        Me.checkSubfamilias = New DevExpress.XtraEditors.CheckEdit
        Me.grafico = New DevExpress.XtraCharts.ChartControl
        Me.panelEstadisticas = New DevExpress.XtraEditors.SplitContainerControl
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.bttImprimirGrafico = New DevExpress.XtraEditors.SimpleButton
        Me.bttImprimirListado = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtTituloListado = New DevExpress.XtraEditors.TextEdit
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.bttActualizar = New DevExpress.XtraEditors.SimpleButton
        Me.bttPropiedades = New DevExpress.XtraEditors.SimpleButton
        CType(Me.lstCabecerasTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstLineasTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEstadisticas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstSubfamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkCabecerasTickets.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkLineasTicket.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkArticulos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkFamilias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkSubfamilias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grafico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelEstadisticas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelEstadisticas.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtTituloListado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstCabecerasTickets
        '
        Me.lstCabecerasTickets.CheckOnClick = True
        Me.lstCabecerasTickets.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("CodigoCaja", "Nº caja"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("NumeroTicket", "Nº Ticket"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("FechaTicket", "Fecha"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("HoraTicket", "Hora"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("CodigoCliente", "Cliente"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("NombreCliente", "Nombre")})
        Me.lstCabecerasTickets.Location = New System.Drawing.Point(12, 31)
        Me.lstCabecerasTickets.Name = "lstCabecerasTickets"
        Me.lstCabecerasTickets.Size = New System.Drawing.Size(120, 109)
        Me.lstCabecerasTickets.TabIndex = 0
        '
        'lstLineasTickets
        '
        Me.lstLineasTickets.CheckOnClick = True
        Me.lstLineasTickets.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("NombreEmpleado", "Vendedor"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Cantidad", "Cantidad"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Precio", "Precio"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("DescuentoLinea", "Dto."), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Importe", "Importe")})
        Me.lstLineasTickets.Location = New System.Drawing.Point(138, 31)
        Me.lstLineasTickets.Name = "lstLineasTickets"
        Me.lstLineasTickets.Size = New System.Drawing.Size(120, 109)
        Me.lstLineasTickets.TabIndex = 2
        '
        'dgEstadisticas
        '
        Me.dgEstadisticas.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgEstadisticas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgEstadisticas.Location = New System.Drawing.Point(0, 0)
        Me.dgEstadisticas.Name = "dgEstadisticas"
        Me.dgEstadisticas.Size = New System.Drawing.Size(760, 172)
        Me.dgEstadisticas.TabIndex = 4
        '
        'lstArticulos
        '
        Me.lstArticulos.CheckOnClick = True
        Me.lstArticulos.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Articulos_Codigo", "Código"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Articulos_Descripcion", "Descripción"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Articulos_Proveedor", "Proveedor"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Articulos_PrecioCoste", "Precio Coste")})
        Me.lstArticulos.Location = New System.Drawing.Point(264, 31)
        Me.lstArticulos.Name = "lstArticulos"
        Me.lstArticulos.Size = New System.Drawing.Size(120, 109)
        Me.lstArticulos.TabIndex = 6
        '
        'lstFamilias
        '
        Me.lstFamilias.CheckOnClick = True
        Me.lstFamilias.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Familias_Codigo", "Código"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Familias_Descripcion", "Descripción")})
        Me.lstFamilias.Location = New System.Drawing.Point(390, 31)
        Me.lstFamilias.Name = "lstFamilias"
        Me.lstFamilias.Size = New System.Drawing.Size(120, 109)
        Me.lstFamilias.TabIndex = 8
        '
        'lstSubfamilias
        '
        Me.lstSubfamilias.CheckOnClick = True
        Me.lstSubfamilias.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Subfamilias_Codigo", "Código"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Subfamilias_Descripcion", "Descripción")})
        Me.lstSubfamilias.Location = New System.Drawing.Point(516, 31)
        Me.lstSubfamilias.Name = "lstSubfamilias"
        Me.lstSubfamilias.Size = New System.Drawing.Size(120, 109)
        Me.lstSubfamilias.TabIndex = 10
        '
        'checkCabecerasTickets
        '
        Me.checkCabecerasTickets.Location = New System.Drawing.Point(13, 9)
        Me.checkCabecerasTickets.Name = "checkCabecerasTickets"
        Me.checkCabecerasTickets.Properties.Caption = "Cabeceras de ticket"
        Me.checkCabecerasTickets.Size = New System.Drawing.Size(120, 19)
        Me.checkCabecerasTickets.TabIndex = 120
        '
        'checkLineasTicket
        '
        Me.checkLineasTicket.Location = New System.Drawing.Point(139, 9)
        Me.checkLineasTicket.Name = "checkLineasTicket"
        Me.checkLineasTicket.Properties.Caption = "Líneas de ticket"
        Me.checkLineasTicket.Size = New System.Drawing.Size(120, 19)
        Me.checkLineasTicket.TabIndex = 121
        '
        'checkArticulos
        '
        Me.checkArticulos.Location = New System.Drawing.Point(265, 9)
        Me.checkArticulos.Name = "checkArticulos"
        Me.checkArticulos.Properties.Caption = "Artículos"
        Me.checkArticulos.Size = New System.Drawing.Size(120, 19)
        Me.checkArticulos.TabIndex = 122
        '
        'checkFamilias
        '
        Me.checkFamilias.Location = New System.Drawing.Point(391, 9)
        Me.checkFamilias.Name = "checkFamilias"
        Me.checkFamilias.Properties.Caption = "Familias"
        Me.checkFamilias.Size = New System.Drawing.Size(120, 19)
        Me.checkFamilias.TabIndex = 123
        '
        'checkSubfamilias
        '
        Me.checkSubfamilias.Location = New System.Drawing.Point(517, 9)
        Me.checkSubfamilias.Name = "checkSubfamilias"
        Me.checkSubfamilias.Properties.Caption = "Subfamilias"
        Me.checkSubfamilias.Size = New System.Drawing.Size(120, 19)
        Me.checkSubfamilias.TabIndex = 124
        '
        'grafico
        '
        Me.grafico.DataSource = Me.dgEstadisticas
        XyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisY.Range.SideMarginsEnabled = True
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.grafico.Diagram = XyDiagram1
        Me.grafico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grafico.Legend.Visible = False
        Me.grafico.Location = New System.Drawing.Point(0, 0)
        Me.grafico.Name = "grafico"
        Me.grafico.SeriesDataMember = "Series"
        SideBySideBarSeriesLabel1.LineVisible = True
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.Name = "Series 1"
        SideBySideBarSeriesLabel2.LineVisible = True
        Series2.Label = SideBySideBarSeriesLabel2
        Series2.Name = "Series 2"
        Me.grafico.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
        Me.grafico.SeriesTemplate.ArgumentDataMember = "Arguments"
        SideBySideBarSeriesLabel3.LineVisible = True
        Me.grafico.SeriesTemplate.Label = SideBySideBarSeriesLabel3
        Me.grafico.SeriesTemplate.ValueDataMembersSerializable = "Values"
        Me.grafico.Size = New System.Drawing.Size(754, 175)
        Me.grafico.TabIndex = 125
        '
        'panelEstadisticas
        '
        Me.panelEstadisticas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelEstadisticas.Horizontal = False
        Me.panelEstadisticas.Location = New System.Drawing.Point(12, 146)
        Me.panelEstadisticas.Name = "panelEstadisticas"
        Me.panelEstadisticas.Panel1.Controls.Add(Me.dgEstadisticas)
        Me.panelEstadisticas.Panel1.Text = "Panel1"
        Me.panelEstadisticas.Panel2.Controls.Add(Me.SplitContainerControl1)
        Me.panelEstadisticas.Panel2.Text = "Panel2"
        Me.panelEstadisticas.Size = New System.Drawing.Size(760, 353)
        Me.panelEstadisticas.SplitterPosition = 172
        Me.panelEstadisticas.TabIndex = 126
        Me.panelEstadisticas.Text = "SplitContainerControl1"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.grafico)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(760, 175)
        Me.SplitContainerControl1.SplitterPosition = 0
        Me.SplitContainerControl1.TabIndex = 131
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PanelControl2.Controls.Add(Me.bttImprimirGrafico)
        Me.PanelControl2.Controls.Add(Me.bttImprimirListado)
        Me.PanelControl2.Controls.Add(Me.LabelControl8)
        Me.PanelControl2.Controls.Add(Me.txtTituloListado)
        Me.PanelControl2.Location = New System.Drawing.Point(333, 505)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(439, 45)
        Me.PanelControl2.TabIndex = 128
        '
        'bttImprimirGrafico
        '
        Me.bttImprimirGrafico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttImprimirGrafico.Appearance.Options.UseTextOptions = True
        Me.bttImprimirGrafico.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttImprimirGrafico.Image = Global.AydaraTPV.My.Resources.Resources._3_1_2_ESTADISTICA
        Me.bttImprimirGrafico.Location = New System.Drawing.Point(355, 0)
        Me.bttImprimirGrafico.Name = "bttImprimirGrafico"
        Me.bttImprimirGrafico.Size = New System.Drawing.Size(83, 45)
        Me.bttImprimirGrafico.TabIndex = 5
        Me.bttImprimirGrafico.Text = "Imprimir Gráfico"
        '
        'bttImprimirListado
        '
        Me.bttImprimirListado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttImprimirListado.Appearance.Options.UseTextOptions = True
        Me.bttImprimirListado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttImprimirListado.Image = Global.AydaraTPV.My.Resources.Resources.menu_tickets
        Me.bttImprimirListado.Location = New System.Drawing.Point(266, 0)
        Me.bttImprimirListado.Name = "bttImprimirListado"
        Me.bttImprimirListado.Size = New System.Drawing.Size(83, 45)
        Me.bttImprimirListado.TabIndex = 0
        Me.bttImprimirListado.Text = "Imprimir Listado"
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Location = New System.Drawing.Point(5, 5)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl8.TabIndex = 3
        Me.LabelControl8.Text = "Título del listado:"
        '
        'txtTituloListado
        '
        Me.txtTituloListado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTituloListado.EditValue = "Cubo estadístico"
        Me.txtTituloListado.Location = New System.Drawing.Point(5, 20)
        Me.txtTituloListado.Name = "txtTituloListado"
        Me.txtTituloListado.Size = New System.Drawing.Size(255, 20)
        Me.txtTituloListado.TabIndex = 4
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(12, 505)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 119
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'bttActualizar
        '
        Me.bttActualizar.Image = Global.AydaraTPV.My.Resources.Resources.search
        Me.bttActualizar.Location = New System.Drawing.Point(642, 95)
        Me.bttActualizar.Name = "bttActualizar"
        Me.bttActualizar.Size = New System.Drawing.Size(107, 45)
        Me.bttActualizar.TabIndex = 5
        Me.bttActualizar.Text = "Actualizar"
        '
        'bttPropiedades
        '
        Me.bttPropiedades.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttPropiedades.Image = Global.AydaraTPV.My.Resources.Resources.update
        Me.bttPropiedades.Location = New System.Drawing.Point(124, 505)
        Me.bttPropiedades.Name = "bttPropiedades"
        Me.bttPropiedades.Size = New System.Drawing.Size(106, 45)
        Me.bttPropiedades.TabIndex = 131
        Me.bttPropiedades.Text = "Propiedades"
        '
        'CubosEstadisticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.bttPropiedades)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.panelEstadisticas)
        Me.Controls.Add(Me.checkSubfamilias)
        Me.Controls.Add(Me.checkFamilias)
        Me.Controls.Add(Me.checkArticulos)
        Me.Controls.Add(Me.checkLineasTicket)
        Me.Controls.Add(Me.checkCabecerasTickets)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.lstSubfamilias)
        Me.Controls.Add(Me.lstFamilias)
        Me.Controls.Add(Me.lstArticulos)
        Me.Controls.Add(Me.bttActualizar)
        Me.Controls.Add(Me.lstLineasTickets)
        Me.Controls.Add(Me.lstCabecerasTickets)
        Me.KeyPreview = True
        Me.Name = "CubosEstadisticos"
        Me.Text = "Estadísticas tienda"
        CType(Me.lstCabecerasTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstLineasTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEstadisticas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstSubfamilias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkCabecerasTickets.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkLineasTicket.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkArticulos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkFamilias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkSubfamilias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grafico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelEstadisticas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelEstadisticas.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtTituloListado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstCabecerasTickets As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents lstLineasTickets As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents dgEstadisticas As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents bttActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lstArticulos As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents lstFamilias As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents lstSubfamilias As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents checkCabecerasTickets As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkLineasTicket As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkArticulos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkFamilias As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkSubfamilias As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents grafico As DevExpress.XtraCharts.ChartControl
    Friend WithEvents panelEstadisticas As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttImprimirListado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTituloListado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bttImprimirGrafico As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents bttPropiedades As DevExpress.XtraEditors.SimpleButton
End Class
