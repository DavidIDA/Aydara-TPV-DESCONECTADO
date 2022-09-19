<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecepcionTelxon
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
        Me.components = New System.ComponentModel.Container
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.bttIniciar = New DevExpress.XtraEditors.SimpleButton
        Me.dgTelxon = New DevExpress.XtraGrid.GridControl
        Me.TELXONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsComunicaciones = New AydaraTPV.dsComunicaciones
        Me.gvTelxon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoBarras = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCajas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnidades = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.bttContinuar = New DevExpress.XtraEditors.SimpleButton
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgTelxon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TELXONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsComunicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTelxon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.bttIniciar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(784, 69)
        Me.PanelControl1.TabIndex = 0
        '
        'bttIniciar
        '
        Me.bttIniciar.Image = Global.AydaraTPV.My.Resources.Resources._32package
        Me.bttIniciar.Location = New System.Drawing.Point(12, 12)
        Me.bttIniciar.Name = "bttIniciar"
        Me.bttIniciar.Size = New System.Drawing.Size(131, 45)
        Me.bttIniciar.TabIndex = 0
        Me.bttIniciar.Text = "Iniciar recepción"
        '
        'dgTelxon
        '
        Me.dgTelxon.DataSource = Me.TELXONBindingSource
        Me.dgTelxon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTelxon.Location = New System.Drawing.Point(0, 69)
        Me.dgTelxon.MainView = Me.gvTelxon
        Me.dgTelxon.Name = "dgTelxon"
        Me.dgTelxon.Size = New System.Drawing.Size(784, 424)
        Me.dgTelxon.TabIndex = 1
        Me.dgTelxon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTelxon})
        '
        'TELXONBindingSource
        '
        Me.TELXONBindingSource.DataMember = "TELXON"
        Me.TELXONBindingSource.DataSource = Me.DsComunicaciones
        '
        'DsComunicaciones
        '
        Me.DsComunicaciones.DataSetName = "dsComunicaciones"
        Me.DsComunicaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvTelxon
        '
        Me.gvTelxon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFecha, Me.colCodigoBarras, Me.colCodigo, Me.colDescripcion, Me.colCajas, Me.colUnidades})
        Me.gvTelxon.GridControl = Me.dgTelxon
        Me.gvTelxon.Name = "gvTelxon"
        Me.gvTelxon.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvTelxon.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvTelxon.OptionsBehavior.Editable = False
        Me.gvTelxon.OptionsCustomization.AllowColumnMoving = False
        Me.gvTelxon.OptionsCustomization.AllowColumnResizing = False
        Me.gvTelxon.OptionsCustomization.AllowFilter = False
        Me.gvTelxon.OptionsCustomization.AllowGroup = False
        Me.gvTelxon.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvTelxon.OptionsCustomization.AllowSort = False
        Me.gvTelxon.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvTelxon.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvTelxon.OptionsView.ShowGroupPanel = False
        '
        'colFecha
        '
        Me.colFecha.DisplayFormat.FormatString = "G"
        Me.colFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.MaxWidth = 120
        Me.colFecha.MinWidth = 120
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 0
        Me.colFecha.Width = 120
        '
        'colCodigoBarras
        '
        Me.colCodigoBarras.FieldName = "CodigoBarras"
        Me.colCodigoBarras.MaxWidth = 120
        Me.colCodigoBarras.MinWidth = 120
        Me.colCodigoBarras.Name = "colCodigoBarras"
        Me.colCodigoBarras.Visible = True
        Me.colCodigoBarras.VisibleIndex = 1
        Me.colCodigoBarras.Width = 120
        '
        'colCodigo
        '
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.MaxWidth = 80
        Me.colCodigo.MinWidth = 80
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 2
        Me.colCodigo.Width = 80
        '
        'colDescripcion
        '
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 3
        Me.colDescripcion.Width = 303
        '
        'colCajas
        '
        Me.colCajas.FieldName = "Cajas"
        Me.colCajas.MaxWidth = 60
        Me.colCajas.MinWidth = 60
        Me.colCajas.Name = "colCajas"
        Me.colCajas.Visible = True
        Me.colCajas.VisibleIndex = 4
        Me.colCajas.Width = 60
        '
        'colUnidades
        '
        Me.colUnidades.FieldName = "Unidades"
        Me.colUnidades.MaxWidth = 70
        Me.colUnidades.MinWidth = 70
        Me.colUnidades.Name = "colUnidades"
        Me.colUnidades.Visible = True
        Me.colUnidades.VisibleIndex = 5
        Me.colUnidades.Width = 70
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.bttImprimir)
        Me.PanelControl2.Controls.Add(Me.bttCancelar)
        Me.PanelControl2.Controls.Add(Me.bttContinuar)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 493)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(784, 69)
        Me.PanelControl2.TabIndex = 2
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(12, 12)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 45
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'bttContinuar
        '
        Me.bttContinuar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttContinuar.Image = Global.AydaraTPV.My.Resources.Resources.ok_32
        Me.bttContinuar.Location = New System.Drawing.Point(650, 12)
        Me.bttContinuar.Name = "bttContinuar"
        Me.bttContinuar.Size = New System.Drawing.Size(122, 45)
        Me.bttContinuar.TabIndex = 1
        Me.bttContinuar.Text = "Continuar"
        '
        'bttImprimir
        '
        Me.bttImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttImprimir.Image = Global.AydaraTPV.My.Resources.Resources.tickets
        Me.bttImprimir.Location = New System.Drawing.Point(124, 12)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.Size = New System.Drawing.Size(106, 45)
        Me.bttImprimir.TabIndex = 107
        Me.bttImprimir.TabStop = False
        Me.bttImprimir.Text = "Imprimir"
        '
        'RecepcionTelxon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.dgTelxon)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.Name = "RecepcionTelxon"
        Me.Text = "Recepción Telxon"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.dgTelxon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TELXONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsComunicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTelxon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttIniciar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgTelxon As DevExpress.XtraGrid.GridControl
    Friend WithEvents TELXONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsComunicaciones As AydaraTPV.dsComunicaciones
    Friend WithEvents gvTelxon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoBarras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCajas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidades As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttContinuar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
End Class
