<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bttAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValorParametro = New DevExpress.XtraEditors.TextEdit()
        Me.btnGrabaArticulo = New DevExpress.XtraEditors.SimpleButton()
        Me.txtPRCMONEDA = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdOpcion = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.txtValorParametro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPRCMONEDA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdOpcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttAceptar
        '
        Me.bttAceptar.Location = New System.Drawing.Point(218, 7)
        Me.bttAceptar.Name = "bttAceptar"
        Me.bttAceptar.Size = New System.Drawing.Size(80, 23)
        Me.bttAceptar.TabIndex = 1
        Me.bttAceptar.Text = "Aceptar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Valor Parametro"
        '
        'txtValorParametro
        '
        Me.txtValorParametro.EditValue = "5155219"
        Me.txtValorParametro.Location = New System.Drawing.Point(160, 54)
        Me.txtValorParametro.Name = "txtValorParametro"
        Me.txtValorParametro.Size = New System.Drawing.Size(104, 20)
        Me.txtValorParametro.TabIndex = 16
        '
        'btnGrabaArticulo
        '
        Me.btnGrabaArticulo.Location = New System.Drawing.Point(124, 127)
        Me.btnGrabaArticulo.Name = "btnGrabaArticulo"
        Me.btnGrabaArticulo.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabaArticulo.TabIndex = 15
        Me.btnGrabaArticulo.Text = "CREA albaran"
        '
        'txtPRCMONEDA
        '
        Me.txtPRCMONEDA.EditValue = "-17"
        Me.txtPRCMONEDA.Location = New System.Drawing.Point(160, 80)
        Me.txtPRCMONEDA.Name = "txtPRCMONEDA"
        Me.txtPRCMONEDA.Size = New System.Drawing.Size(104, 20)
        Me.txtPRCMONEDA.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "UNIDADESSTOCK"
        '
        'txtIdOpcion
        '
        Me.txtIdOpcion.EditValue = "ida_InformeVentasComp"
        Me.txtIdOpcion.Location = New System.Drawing.Point(12, 10)
        Me.txtIdOpcion.Name = "txtIdOpcion"
        Me.txtIdOpcion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtIdOpcion.Properties.Items.AddRange(New Object() {"ida_PedidoTraspaso", "ida_PreciosDescuentos", "ida_PreciosDescuentos_Cliente", "ida_PreciosDescuentos_Proveedor", "ida_PreciosDescuentos_Articulo", "ida_TarifasVenta", "ida_TarifasVenta_Proveedor", "ida_TarifasVenta_Articulo", "ida_Promociones", "ida_ConfiguracionTPV", "ida_EnvioTiendas", "ida_RecepcionTiendas", "ida_ActualizacionTiendas", "ida_EstadisticasTienda", "ida_SituacionTienda", "ida_TicketsTiendas", "ida_LogComunicacionTiendas", "ida_FacturacionTiendas", "ida_EnvioPreventa", "ida_RecepcionPreventa", "ida_TerminalesInventario", "ida_Escandallo", "ida_FacturacionAlbaranes", "ida_TotalesCaja", "ida_EtiquetasTienda", "ida_TarjetasTienda", "ida_PreparacionReparto", "ida_CierreTienda", "ida_PedidoCompra", "ida_AlbaranCompra", "ida_FacturaCompra", "ida_PedidoVenta", "ida_AlbaranVenta", "ida_FacturaVenta", "ida_Logistica", "ida_SituacionPedidos", "ida_EtiquetasUbicacion", "ida_Inventario", "ida_Picking", "ida_EnvioPrestashop", "ida_Prov_SanMiguel", "ida_Prov_GrupoConecta", "ida_Estadis_Proveedor", "ida_Estadis_Cliente", "ida_Estadis_Representante", "ida_Estadis_Ruta", "ida_Estadis_Almacen", "ida_Estadis_Articulo", "ida_Estadis_Familia", "ida_ConfiguracionMail", "ida_Mailing", "ida_PedidosPlataforma", "ida_InformeVentas", "ida_InformeVentasComp"})
        Me.txtIdOpcion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtIdOpcion.Size = New System.Drawing.Size(200, 20)
        Me.txtIdOpcion.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 165)
        Me.Controls.Add(Me.txtIdOpcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPRCMONEDA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtValorParametro)
        Me.Controls.Add(Me.btnGrabaArticulo)
        Me.Controls.Add(Me.bttAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opción"
        CType(Me.txtValorParametro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPRCMONEDA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdOpcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtValorParametro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGrabaArticulo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPRCMONEDA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdOpcion As DevExpress.XtraEditors.ComboBoxEdit

End Class
