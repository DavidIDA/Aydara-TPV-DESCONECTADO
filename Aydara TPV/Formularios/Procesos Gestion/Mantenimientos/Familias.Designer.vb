<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Familias
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
        Me.components = New System.ComponentModel.Container()
        Me.bttNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.bttEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.FAMILIASARTICULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New AydaraTPV.dsArticulos()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigo = New DevExpress.XtraEditors.ButtonEdit()
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtCtaCompras = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCtaVentas = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.checkTpvTactil = New DevExpress.XtraEditors.CheckEdit()
        Me.imgImagen = New DevExpress.XtraEditors.PictureEdit()
        Me.lblDescuentoTarjeta = New DevExpress.XtraEditors.LabelControl()
        Me.txtEtiqueta = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescuentoTarjeta = New DevExpress.XtraEditors.TextEdit()
        Me.bttNuevaImagen = New DevExpress.XtraEditors.SimpleButton()
        Me.bttEliminarImagen = New DevExpress.XtraEditors.SimpleButton()
        Me.FAMILIASARTICULOSTableAdapter = New AydaraTPV.dsArticulosTableAdapters.FAMILIASARTICULOSTableAdapter()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.dgSubfamilias = New DevExpress.XtraGrid.GridControl()
        Me.SUBFAMILIASARTICULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvSubfamilias = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFamilia_Id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskCodigo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDescuentoTarjeta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.mskDescuento = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.NavListadoSubfamilias = New DevExpress.XtraEditors.DataNavigator()
        Me.SUBFAMILIASARTICULOSTableAdapter = New AydaraTPV.dsArticulosTableAdapters.SUBFAMILIASARTICULOSTableAdapter()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FAMILIASARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtCtaCompras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaVentas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkTpvTactil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgImagen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEtiqueta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuentoTarjeta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dgSubfamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUBFAMILIASARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSubfamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttNuevo
        '
        Me.bttNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttNuevo.Image = Global.AydaraTPV.My.Resources.Resources._new
        Me.bttNuevo.Location = New System.Drawing.Point(12, 509)
        Me.bttNuevo.Name = "bttNuevo"
        Me.bttNuevo.Size = New System.Drawing.Size(106, 45)
        Me.bttNuevo.TabIndex = 8
        Me.bttNuevo.TabStop = False
        Me.bttNuevo.Text = "Nuevo"
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Location = New System.Drawing.Point(671, 89)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl6.TabIndex = 15
        Me.LabelControl6.Text = "Provincia:"
        '
        'bttEliminar
        '
        Me.bttEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttEliminar.Enabled = False
        Me.bttEliminar.Image = Global.AydaraTPV.My.Resources.Resources.delete2
        Me.bttEliminar.Location = New System.Drawing.Point(348, 509)
        Me.bttEliminar.Name = "bttEliminar"
        Me.bttEliminar.Size = New System.Drawing.Size(106, 45)
        Me.bttEliminar.TabIndex = 32
        Me.bttEliminar.TabStop = False
        Me.bttEliminar.Text = "Eliminar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(562, 509)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 31
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'bttGuardar
        '
        Me.bttGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttGuardar.Enabled = False
        Me.bttGuardar.Image = Global.AydaraTPV.My.Resources.Resources.save
        Me.bttGuardar.Location = New System.Drawing.Point(674, 509)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(106, 45)
        Me.bttGuardar.TabIndex = 30
        Me.bttGuardar.TabStop = False
        Me.bttGuardar.Text = "Guardar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(13, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FAMILIASARTICULOSBindingSource, "Descripcion", True))
        Me.txtDescripcion.EnterMoveNextControl = True
        Me.txtDescripcion.Location = New System.Drawing.Point(89, 34)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.MaxLength = 50
        Me.txtDescripcion.Properties.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(370, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'FAMILIASARTICULOSBindingSource
        '
        Me.FAMILIASARTICULOSBindingSource.DataMember = "FAMILIASARTICULOS"
        Me.FAMILIASARTICULOSBindingSource.DataSource = Me.DsArticulos
        '
        'DsArticulos
        '
        Me.DsArticulos.DataSetName = "dsArticulos"
        Me.DsArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FAMILIASARTICULOSBindingSource, "Codigo", True))
        Me.txtCodigo.EnterMoveNextControl = True
        Me.txtCodigo.Location = New System.Drawing.Point(55, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigo.Properties.Mask.EditMask = "000"
        Me.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCodigo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCodigo.Size = New System.Drawing.Size(62, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'bttBuscar
        '
        Me.bttBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.search
        Me.bttBuscar.Location = New System.Drawing.Point(236, 509)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(106, 45)
        Me.bttBuscar.TabIndex = 37
        Me.bttBuscar.TabStop = False
        Me.bttBuscar.Text = "Buscar"
        '
        'bttModificar
        '
        Me.bttModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttModificar.Enabled = False
        Me.bttModificar.Image = Global.AydaraTPV.My.Resources.Resources.menu_vales
        Me.bttModificar.Location = New System.Drawing.Point(124, 509)
        Me.bttModificar.Name = "bttModificar"
        Me.bttModificar.Size = New System.Drawing.Size(106, 45)
        Me.bttModificar.TabIndex = 36
        Me.bttModificar.TabStop = False
        Me.bttModificar.Text = "Modificar"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtCtaCompras)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtCtaVentas)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.checkTpvTactil)
        Me.GroupControl1.Controls.Add(Me.imgImagen)
        Me.GroupControl1.Controls.Add(Me.lblDescuentoTarjeta)
        Me.GroupControl1.Controls.Add(Me.txtEtiqueta)
        Me.GroupControl1.Controls.Add(Me.txtDescuentoTarjeta)
        Me.GroupControl1.Controls.Add(Me.txtDescripcion)
        Me.GroupControl1.Controls.Add(Me.bttNuevaImagen)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.bttEliminarImagen)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 54)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(631, 170)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "DATOS FAMILIA"
        '
        'txtCtaCompras
        '
        Me.txtCtaCompras.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FAMILIASARTICULOSBindingSource, "CtaCompras", True))
        Me.txtCtaCompras.Location = New System.Drawing.Point(89, 122)
        Me.txtCtaCompras.Name = "txtCtaCompras"
        Me.txtCtaCompras.Properties.ReadOnly = True
        Me.txtCtaCompras.Size = New System.Drawing.Size(100, 20)
        Me.txtCtaCompras.TabIndex = 99
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(13, 125)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl4.TabIndex = 98
        Me.LabelControl4.Text = "Cta. Compras:"
        '
        'txtCtaVentas
        '
        Me.txtCtaVentas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FAMILIASARTICULOSBindingSource, "CtaVentas", True))
        Me.txtCtaVentas.Location = New System.Drawing.Point(89, 95)
        Me.txtCtaVentas.Name = "txtCtaVentas"
        Me.txtCtaVentas.Properties.ReadOnly = True
        Me.txtCtaVentas.Size = New System.Drawing.Size(100, 20)
        Me.txtCtaVentas.TabIndex = 97
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(13, 98)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl3.TabIndex = 96
        Me.LabelControl3.Text = "Cta. Ventas:"
        '
        'checkTpvTactil
        '
        Me.checkTpvTactil.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FAMILIASARTICULOSBindingSource, "TpvTactil", True))
        Me.checkTpvTactil.Location = New System.Drawing.Point(406, 141)
        Me.checkTpvTactil.Name = "checkTpvTactil"
        Me.checkTpvTactil.Properties.AutoWidth = True
        Me.checkTpvTactil.Properties.Caption = "Mostrar en TPV:"
        Me.checkTpvTactil.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.checkTpvTactil.Properties.ReadOnly = True
        Me.checkTpvTactil.Size = New System.Drawing.Size(99, 19)
        Me.checkTpvTactil.TabIndex = 95
        Me.checkTpvTactil.TabStop = False
        '
        'imgImagen
        '
        Me.imgImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgImagen.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FAMILIASARTICULOSBindingSource, "Imagen", True))
        Me.imgImagen.Location = New System.Drawing.Point(512, 23)
        Me.imgImagen.Name = "imgImagen"
        Me.imgImagen.Properties.NullText = "Sin imagen"
        Me.imgImagen.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.imgImagen.Properties.ReadOnly = True
        Me.imgImagen.Properties.ShowMenu = False
        Me.imgImagen.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.imgImagen.Size = New System.Drawing.Size(114, 119)
        Me.imgImagen.TabIndex = 84
        '
        'lblDescuentoTarjeta
        '
        Me.lblDescuentoTarjeta.Location = New System.Drawing.Point(13, 63)
        Me.lblDescuentoTarjeta.Name = "lblDescuentoTarjeta"
        Me.lblDescuentoTarjeta.Size = New System.Drawing.Size(63, 13)
        Me.lblDescuentoTarjeta.TabIndex = 21
        Me.lblDescuentoTarjeta.Text = "Dto. Tarjeta:"
        '
        'txtEtiqueta
        '
        Me.txtEtiqueta.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FAMILIASARTICULOSBindingSource, "Etiqueta", True))
        Me.txtEtiqueta.EnterMoveNextControl = True
        Me.txtEtiqueta.Location = New System.Drawing.Point(512, 141)
        Me.txtEtiqueta.Name = "txtEtiqueta"
        Me.txtEtiqueta.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEtiqueta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtEtiqueta.Properties.MaxLength = 10
        Me.txtEtiqueta.Properties.ReadOnly = True
        Me.txtEtiqueta.Size = New System.Drawing.Size(114, 20)
        Me.txtEtiqueta.TabIndex = 3
        '
        'txtDescuentoTarjeta
        '
        Me.txtDescuentoTarjeta.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FAMILIASARTICULOSBindingSource, "DescuentoTarjeta", True))
        Me.txtDescuentoTarjeta.EnterMoveNextControl = True
        Me.txtDescuentoTarjeta.Location = New System.Drawing.Point(89, 60)
        Me.txtDescuentoTarjeta.Name = "txtDescuentoTarjeta"
        Me.txtDescuentoTarjeta.Properties.Mask.EditMask = "P2"
        Me.txtDescuentoTarjeta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDescuentoTarjeta.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDescuentoTarjeta.Properties.ReadOnly = True
        Me.txtDescuentoTarjeta.Size = New System.Drawing.Size(65, 20)
        Me.txtDescuentoTarjeta.TabIndex = 2
        '
        'bttNuevaImagen
        '
        Me.bttNuevaImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttNuevaImagen.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.bttNuevaImagen.Appearance.Options.UseBackColor = True
        Me.bttNuevaImagen.BackgroundImage = Global.AydaraTPV.My.Resources.Resources.find
        Me.bttNuevaImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bttNuevaImagen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.bttNuevaImagen.Enabled = False
        Me.bttNuevaImagen.Location = New System.Drawing.Point(482, 23)
        Me.bttNuevaImagen.Name = "bttNuevaImagen"
        Me.bttNuevaImagen.Size = New System.Drawing.Size(31, 28)
        Me.bttNuevaImagen.TabIndex = 85
        Me.bttNuevaImagen.TabStop = False
        '
        'bttEliminarImagen
        '
        Me.bttEliminarImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttEliminarImagen.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.bttEliminarImagen.Appearance.Options.UseBackColor = True
        Me.bttEliminarImagen.BackgroundImage = Global.AydaraTPV.My.Resources.Resources._1321518972_close
        Me.bttEliminarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bttEliminarImagen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.bttEliminarImagen.Enabled = False
        Me.bttEliminarImagen.Location = New System.Drawing.Point(482, 50)
        Me.bttEliminarImagen.Name = "bttEliminarImagen"
        Me.bttEliminarImagen.Size = New System.Drawing.Size(31, 28)
        Me.bttEliminarImagen.TabIndex = 86
        Me.bttEliminarImagen.TabStop = False
        '
        'FAMILIASARTICULOSTableAdapter
        '
        Me.FAMILIASARTICULOSTableAdapter.ClearBeforeFill = True
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.dgSubfamilias)
        Me.GroupControl2.Controls.Add(Me.NavListadoSubfamilias)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 246)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(631, 241)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "SUBFAMILIAS"
        '
        'dgSubfamilias
        '
        Me.dgSubfamilias.DataSource = Me.SUBFAMILIASARTICULOSBindingSource
        Me.dgSubfamilias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSubfamilias.Location = New System.Drawing.Point(2, 21)
        Me.dgSubfamilias.MainView = Me.gvSubfamilias
        Me.dgSubfamilias.Name = "dgSubfamilias"
        Me.dgSubfamilias.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskCodigo, Me.mskDescuento, Me.maskDescripcion})
        Me.dgSubfamilias.Size = New System.Drawing.Size(627, 199)
        Me.dgSubfamilias.TabIndex = 0
        Me.dgSubfamilias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSubfamilias})
        '
        'SUBFAMILIASARTICULOSBindingSource
        '
        Me.SUBFAMILIASARTICULOSBindingSource.DataMember = "SUBFAMILIASARTICULOS"
        Me.SUBFAMILIASARTICULOSBindingSource.DataSource = Me.DsArticulos
        '
        'gvSubfamilias
        '
        Me.gvSubfamilias.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colFamilia_Id, Me.colCodigo, Me.colDescripcion, Me.colDescuentoTarjeta})
        Me.gvSubfamilias.GridControl = Me.dgSubfamilias
        Me.gvSubfamilias.Name = "gvSubfamilias"
        Me.gvSubfamilias.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvSubfamilias.OptionsView.ShowGroupPanel = False
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.ReadOnly = True
        '
        'colFamilia_Id
        '
        Me.colFamilia_Id.FieldName = "Familia_Id"
        Me.colFamilia_Id.Name = "colFamilia_Id"
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.ColumnEdit = Me.maskCodigo
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.MaxWidth = 60
        Me.colCodigo.MinWidth = 60
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 60
        '
        'maskCodigo
        '
        Me.maskCodigo.AutoHeight = False
        Me.maskCodigo.Mask.EditMask = "000"
        Me.maskCodigo.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskCodigo.Mask.UseMaskAsDisplayFormat = True
        Me.maskCodigo.MaxLength = 15
        Me.maskCodigo.Name = "maskCodigo"
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.ColumnEdit = Me.maskDescripcion
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        '
        'maskDescripcion
        '
        Me.maskDescripcion.AutoHeight = False
        Me.maskDescripcion.MaxLength = 50
        Me.maskDescripcion.Name = "maskDescripcion"
        '
        'colDescuentoTarjeta
        '
        Me.colDescuentoTarjeta.Caption = "Dto.Tarjeta"
        Me.colDescuentoTarjeta.ColumnEdit = Me.mskDescuento
        Me.colDescuentoTarjeta.FieldName = "DescuentoTarjeta"
        Me.colDescuentoTarjeta.MaxWidth = 80
        Me.colDescuentoTarjeta.MinWidth = 80
        Me.colDescuentoTarjeta.Name = "colDescuentoTarjeta"
        Me.colDescuentoTarjeta.Visible = True
        Me.colDescuentoTarjeta.VisibleIndex = 2
        Me.colDescuentoTarjeta.Width = 80
        '
        'mskDescuento
        '
        Me.mskDescuento.AutoHeight = False
        Me.mskDescuento.Mask.EditMask = "P2"
        Me.mskDescuento.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.mskDescuento.Mask.UseMaskAsDisplayFormat = True
        Me.mskDescuento.Name = "mskDescuento"
        '
        'NavListadoSubfamilias
        '
        Me.NavListadoSubfamilias.Buttons.Append.Enabled = False
        Me.NavListadoSubfamilias.Buttons.CancelEdit.Visible = False
        Me.NavListadoSubfamilias.Buttons.EndEdit.Visible = False
        Me.NavListadoSubfamilias.Buttons.Remove.Enabled = False
        Me.NavListadoSubfamilias.DataSource = Me.SUBFAMILIASARTICULOSBindingSource
        Me.NavListadoSubfamilias.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NavListadoSubfamilias.Location = New System.Drawing.Point(2, 220)
        Me.NavListadoSubfamilias.Name = "NavListadoSubfamilias"
        Me.NavListadoSubfamilias.Size = New System.Drawing.Size(627, 19)
        Me.NavListadoSubfamilias.TabIndex = 10
        Me.NavListadoSubfamilias.Text = "Subfamilias"
        '
        'SUBFAMILIASARTICULOSTableAdapter
        '
        Me.SUBFAMILIASARTICULOSTableAdapter.ClearBeforeFill = True
        '
        'Familias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.bttBuscar)
        Me.Controls.Add(Me.bttModificar)
        Me.Controls.Add(Me.bttNuevo)
        Me.Controls.Add(Me.bttGuardar)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttEliminar)
        Me.Controls.Add(Me.LabelControl1)
        Me.KeyPreview = True
        Me.Name = "Familias"
        Me.Text = "Familias"
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FAMILIASARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtCtaCompras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaVentas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkTpvTactil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgImagen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEtiqueta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuentoTarjeta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.dgSubfamilias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUBFAMILIASARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSubfamilias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DsArticulos As AydaraTPV.dsArticulos
    Friend WithEvents FAMILIASARTICULOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FAMILIASARTICULOSTableAdapter As AydaraTPV.dsArticulosTableAdapters.FAMILIASARTICULOSTableAdapter
    Friend WithEvents lblDescuentoTarjeta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescuentoTarjeta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bttEliminarImagen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttNuevaImagen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imgImagen As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgSubfamilias As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSubfamilias As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SUBFAMILIASARTICULOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SUBFAMILIASARTICULOSTableAdapter As AydaraTPV.dsArticulosTableAdapters.SUBFAMILIASARTICULOSTableAdapter
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFamilia_Id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescuentoTarjeta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents maskCodigo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents NavListadoSubfamilias As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents txtEtiqueta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mskDescuento As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents maskDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents checkTpvTactil As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtCtaCompras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCtaVentas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
