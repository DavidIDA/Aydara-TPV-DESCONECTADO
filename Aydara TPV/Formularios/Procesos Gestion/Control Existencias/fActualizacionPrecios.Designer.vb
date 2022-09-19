<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fActualizacionPrecios
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.DsActualizacionPrecios = New AydaraTPV.dsActualizacionPrecios
        Me.ARTICULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtPrecioCoste_Articulo = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtPrecioCoste_Proveedor = New DevExpress.XtraEditors.TextEdit
        Me.REFERENCIASPROVEEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit
        Me.REFERENCIAS_PROVEEDORESTableAdapter = New AydaraTPV.dsActualizacionPreciosTableAdapters.REFERENCIAS_PROVEEDORESTableAdapter
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit
        Me.txtPrecioLinea = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtPrecioLinea2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        CType(Me.DsActualizacionPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioCoste_Articulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioCoste_Proveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REFERENCIASPROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioLinea2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Código:"
        '
        'DsActualizacionPrecios
        '
        Me.DsActualizacionPrecios.DataSetName = "dsActualizacionPrecios"
        Me.DsActualizacionPrecios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ARTICULOSBindingSource
        '
        Me.ARTICULOSBindingSource.DataMember = "ARTICULOS"
        Me.ARTICULOSBindingSource.DataSource = Me.DsActualizacionPrecios
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(10, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Descripción:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(10, 89)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Precio coste: "
        '
        'txtPrecioCoste_Articulo
        '
        Me.txtPrecioCoste_Articulo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "PrecioCoste", True))
        Me.txtPrecioCoste_Articulo.EnterMoveNextControl = True
        Me.txtPrecioCoste_Articulo.Location = New System.Drawing.Point(81, 86)
        Me.txtPrecioCoste_Articulo.Name = "txtPrecioCoste_Articulo"
        Me.txtPrecioCoste_Articulo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrecioCoste_Articulo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPrecioCoste_Articulo.Properties.Mask.EditMask = "c3"
        Me.txtPrecioCoste_Articulo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioCoste_Articulo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioCoste_Articulo.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecioCoste_Articulo.TabIndex = 2
        Me.txtPrecioCoste_Articulo.ToolTip = "(A) Actualiza precio"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "Precio", True))
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(81, 112)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit1.Properties.Mask.EditMask = "c2"
        Me.TextEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit1.Size = New System.Drawing.Size(68, 20)
        Me.TextEdit1.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(10, 115)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl4.TabIndex = 70
        Me.LabelControl4.Text = "Precio venta: "
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(6, 35)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl5.TabIndex = 72
        Me.LabelControl5.Text = "Referencia: "
        '
        'txtPrecioCoste_Proveedor
        '
        Me.txtPrecioCoste_Proveedor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.REFERENCIASPROVEEDORESBindingSource, "PrecioCoste", True))
        Me.txtPrecioCoste_Proveedor.EnterMoveNextControl = True
        Me.txtPrecioCoste_Proveedor.Location = New System.Drawing.Point(81, 84)
        Me.txtPrecioCoste_Proveedor.Name = "txtPrecioCoste_Proveedor"
        Me.txtPrecioCoste_Proveedor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrecioCoste_Proveedor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPrecioCoste_Proveedor.Properties.Mask.EditMask = "c3"
        Me.txtPrecioCoste_Proveedor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioCoste_Proveedor.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioCoste_Proveedor.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecioCoste_Proveedor.TabIndex = 6
        Me.txtPrecioCoste_Proveedor.ToolTip = "(A) Actualiza precio"
        '
        'REFERENCIASPROVEEDORESBindingSource
        '
        Me.REFERENCIASPROVEEDORESBindingSource.DataMember = "REFERENCIAS_PROVEEDORES"
        Me.REFERENCIASPROVEEDORESBindingSource.DataSource = Me.DsActualizacionPrecios
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(6, 87)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl6.TabIndex = 73
        Me.LabelControl6.Text = "Precio coste: "
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.REFERENCIASPROVEEDORESBindingSource, "PrecioVenta", True))
        Me.TextEdit3.EnterMoveNextControl = True
        Me.TextEdit3.Location = New System.Drawing.Point(81, 110)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit3.Properties.Mask.EditMask = "c2"
        Me.TextEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit3.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit3.Size = New System.Drawing.Size(68, 20)
        Me.TextEdit3.TabIndex = 7
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(6, 113)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl7.TabIndex = 75
        Me.LabelControl7.Text = "P.V.R.: "
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.REFERENCIASPROVEEDORESBindingSource, "UnidadesCaja", True))
        Me.TextEdit4.EnterMoveNextControl = True
        Me.TextEdit4.Location = New System.Drawing.Point(81, 58)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit4.Properties.Mask.EditMask = "n0"
        Me.TextEdit4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit4.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit4.Size = New System.Drawing.Size(68, 20)
        Me.TextEdit4.TabIndex = 5
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(6, 61)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl8.TabIndex = 77
        Me.LabelControl8.Text = "Uds/Caja: "
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.REFERENCIASPROVEEDORESBindingSource, "Referencia", True))
        Me.TextEdit5.EnterMoveNextControl = True
        Me.TextEdit5.Location = New System.Drawing.Point(81, 32)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.MaxLength = 50
        Me.TextEdit5.Size = New System.Drawing.Size(137, 20)
        Me.TextEdit5.TabIndex = 4
        '
        'REFERENCIAS_PROVEEDORESTableAdapter
        '
        Me.REFERENCIAS_PROVEEDORESTableAdapter.ClearBeforeFill = True
        '
        'bttGuardar
        '
        Me.bttGuardar.Image = Global.AydaraTPV.My.Resources.Resources.ok_32
        Me.bttGuardar.Location = New System.Drawing.Point(299, 317)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(95, 44)
        Me.bttGuardar.TabIndex = 2
        Me.bttGuardar.Text = "Guardar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources._1321518972_close
        Me.bttCancelar.Location = New System.Drawing.Point(12, 317)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(95, 44)
        Me.bttCancelar.TabIndex = 3
        Me.bttCancelar.Text = "Cancelar"
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "Descripcion", True))
        Me.TextEdit6.EditValue = ""
        Me.TextEdit6.EnterMoveNextControl = True
        Me.TextEdit6.Location = New System.Drawing.Point(81, 58)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Properties.MaxLength = 40
        Me.TextEdit6.Size = New System.Drawing.Size(296, 20)
        Me.TextEdit6.TabIndex = 1
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "Codigo", True))
        Me.TextEdit7.EnterMoveNextControl = True
        Me.TextEdit7.Location = New System.Drawing.Point(81, 32)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Properties.ReadOnly = True
        Me.TextEdit7.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit7.TabIndex = 0
        Me.TextEdit7.TabStop = False
        '
        'txtPrecioLinea
        '
        Me.txtPrecioLinea.EnterMoveNextControl = True
        Me.txtPrecioLinea.Location = New System.Drawing.Point(232, 86)
        Me.txtPrecioLinea.Name = "txtPrecioLinea"
        Me.txtPrecioLinea.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrecioLinea.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPrecioLinea.Properties.Mask.EditMask = "c3"
        Me.txtPrecioLinea.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioLinea.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioLinea.Properties.ReadOnly = True
        Me.txtPrecioLinea.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecioLinea.TabIndex = 79
        Me.txtPrecioLinea.TabStop = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(165, 89)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl9.TabIndex = 78
        Me.LabelControl9.Text = "Precio línea: "
        '
        'txtPrecioLinea2
        '
        Me.txtPrecioLinea2.EnterMoveNextControl = True
        Me.txtPrecioLinea2.Location = New System.Drawing.Point(230, 84)
        Me.txtPrecioLinea2.Name = "txtPrecioLinea2"
        Me.txtPrecioLinea2.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrecioLinea2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPrecioLinea2.Properties.Mask.EditMask = "c3"
        Me.txtPrecioLinea2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioLinea2.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioLinea2.Properties.ReadOnly = True
        Me.txtPrecioLinea2.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecioLinea2.TabIndex = 81
        Me.txtPrecioLinea2.TabStop = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(163, 87)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl10.TabIndex = 80
        Me.LabelControl10.Text = "Precio línea: "
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.TextEdit6)
        Me.GroupControl1.Controls.Add(Me.txtPrecioLinea)
        Me.GroupControl1.Controls.Add(Me.TextEdit7)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtPrecioCoste_Articulo)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(382, 148)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Datos artículo"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.TextEdit5)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.txtPrecioLinea2)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.txtPrecioCoste_Proveedor)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.TextEdit4)
        Me.GroupControl2.Controls.Add(Me.TextEdit3)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 166)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(382, 145)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Datos proveedor"
        '
        'fActualizacionPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 373)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fActualizacionPrecios"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Precios artículo"
        CType(Me.DsActualizacionPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioCoste_Articulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioCoste_Proveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REFERENCIASPROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioLinea2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ARTICULOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsActualizacionPrecios As AydaraTPV.dsActualizacionPrecios
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrecioCoste_Articulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrecioCoste_Proveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents REFERENCIASPROVEEDORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents REFERENCIAS_PROVEEDORESTableAdapter As AydaraTPV.dsActualizacionPreciosTableAdapters.REFERENCIAS_PROVEEDORESTableAdapter
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPrecioLinea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrecioLinea2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
End Class
