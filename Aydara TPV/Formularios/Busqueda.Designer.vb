<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busqueda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Busqueda))
        Me.dgBusqueda = New DevExpress.XtraGrid.GridControl()
        Me.gvBusqueda = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.panelImprimir = New DevExpress.XtraEditors.PanelControl()
        Me.bttTeclado = New DevExpress.XtraEditors.SimpleButton()
        Me.bttSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bttSeleccionar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.bttNuevo = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.dgBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelImprimir.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgBusqueda
        '
        Me.dgBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.dgBusqueda.MainView = Me.gvBusqueda
        Me.dgBusqueda.Name = "dgBusqueda"
        Me.dgBusqueda.Size = New System.Drawing.Size(784, 496)
        Me.dgBusqueda.TabIndex = 0
        Me.dgBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBusqueda})
        '
        'gvBusqueda
        '
        Me.gvBusqueda.GridControl = Me.dgBusqueda
        Me.gvBusqueda.GroupPanelText = "Arrastre una columna para agrupar por esa columna"
        Me.gvBusqueda.Name = "gvBusqueda"
        Me.gvBusqueda.OptionsBehavior.Editable = False
        Me.gvBusqueda.OptionsFind.AlwaysVisible = True
        Me.gvBusqueda.OptionsMenu.EnableColumnMenu = False
        Me.gvBusqueda.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvBusqueda.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvBusqueda.OptionsView.EnableAppearanceEvenRow = True
        Me.gvBusqueda.OptionsView.ShowDetailButtons = False
        Me.gvBusqueda.OptionsView.ShowGroupPanel = False
        '
        'panelImprimir
        '
        Me.panelImprimir.Controls.Add(Me.bttNuevo)
        Me.panelImprimir.Controls.Add(Me.bttTeclado)
        Me.panelImprimir.Controls.Add(Me.bttSalir)
        Me.panelImprimir.Controls.Add(Me.bttSeleccionar)
        Me.panelImprimir.Controls.Add(Me.bttImprimir)
        Me.panelImprimir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelImprimir.Location = New System.Drawing.Point(0, 496)
        Me.panelImprimir.Name = "panelImprimir"
        Me.panelImprimir.Size = New System.Drawing.Size(784, 66)
        Me.panelImprimir.TabIndex = 1
        '
        'bttTeclado
        '
        Me.bttTeclado.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bttTeclado.Image = Global.AydaraTPV.My.Resources.Resources.keyboard
        Me.bttTeclado.Location = New System.Drawing.Point(367, 1)
        Me.bttTeclado.Name = "bttTeclado"
        Me.bttTeclado.Size = New System.Drawing.Size(75, 65)
        Me.bttTeclado.TabIndex = 9
        Me.bttTeclado.TabStop = False
        Me.bttTeclado.Tag = "1"
        Me.bttTeclado.Text = "Teclado"
        '
        'bttSalir
        '
        Me.bttSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttSalir.Appearance.Options.UseFont = True
        Me.bttSalir.Dock = System.Windows.Forms.DockStyle.Left
        Me.bttSalir.Image = CType(resources.GetObject("bttSalir.Image"), System.Drawing.Image)
        Me.bttSalir.Location = New System.Drawing.Point(2, 2)
        Me.bttSalir.Name = "bttSalir"
        Me.bttSalir.Size = New System.Drawing.Size(131, 62)
        Me.bttSalir.TabIndex = 8
        Me.bttSalir.Text = "Cancelar"
        '
        'bttSeleccionar
        '
        Me.bttSeleccionar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttSeleccionar.Appearance.Options.UseFont = True
        Me.bttSeleccionar.Dock = System.Windows.Forms.DockStyle.Right
        Me.bttSeleccionar.Image = Global.AydaraTPV.My.Resources.Resources.ok_32
        Me.bttSeleccionar.Location = New System.Drawing.Point(651, 2)
        Me.bttSeleccionar.Name = "bttSeleccionar"
        Me.bttSeleccionar.Size = New System.Drawing.Size(131, 62)
        Me.bttSeleccionar.TabIndex = 0
        Me.bttSeleccionar.Text = "Seleccionar"
        '
        'bttImprimir
        '
        Me.bttImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttImprimir.Image = Global.AydaraTPV.My.Resources.Resources.menu_tickets
        Me.bttImprimir.Location = New System.Drawing.Point(528, 0)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.Size = New System.Drawing.Size(117, 66)
        Me.bttImprimir.TabIndex = 0
        Me.bttImprimir.Text = "Imprimir listado"
        Me.bttImprimir.Visible = False
        '
        'bttNuevo
        '
        Me.bttNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttNuevo.Appearance.Options.UseFont = True
        Me.bttNuevo.Image = Global.AydaraTPV.My.Resources.Resources._new
        Me.bttNuevo.Location = New System.Drawing.Point(139, 2)
        Me.bttNuevo.Name = "bttNuevo"
        Me.bttNuevo.Size = New System.Drawing.Size(117, 62)
        Me.bttNuevo.TabIndex = 10
        Me.bttNuevo.Text = "Nuevo"
        Me.bttNuevo.Visible = False
        '
        'Busqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.dgBusqueda)
        Me.Controls.Add(Me.panelImprimir)
        Me.KeyPreview = True
        Me.Name = "Busqueda"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Busqueda"
        CType(Me.dgBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelImprimir.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBusqueda As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents panelImprimir As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttSeleccionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttTeclado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttNuevo As DevExpress.XtraEditors.SimpleButton
End Class
