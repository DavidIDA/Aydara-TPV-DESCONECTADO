<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recepcion
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
        Me.lblFicheros = New DevExpress.XtraEditors.LabelControl
        Me.pbFicheros = New DevExpress.XtraEditors.ProgressBarControl
        Me.pbRegistros = New DevExpress.XtraEditors.ProgressBarControl
        Me.lblRegistros = New DevExpress.XtraEditors.LabelControl
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        CType(Me.pbFicheros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegistros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFicheros
        '
        Me.lblFicheros.Location = New System.Drawing.Point(12, 12)
        Me.lblFicheros.Name = "lblFicheros"
        Me.lblFicheros.Size = New System.Drawing.Size(40, 13)
        Me.lblFicheros.TabIndex = 0
        Me.lblFicheros.Text = "Ficheros"
        '
        'pbFicheros
        '
        Me.pbFicheros.EditValue = "0"
        Me.pbFicheros.Location = New System.Drawing.Point(12, 31)
        Me.pbFicheros.Name = "pbFicheros"
        Me.pbFicheros.Size = New System.Drawing.Size(466, 18)
        Me.pbFicheros.TabIndex = 1
        '
        'pbRegistros
        '
        Me.pbRegistros.EditValue = "0"
        Me.pbRegistros.Location = New System.Drawing.Point(12, 55)
        Me.pbRegistros.Name = "pbRegistros"
        Me.pbRegistros.Size = New System.Drawing.Size(466, 18)
        Me.pbRegistros.TabIndex = 3
        '
        'lblRegistros
        '
        Me.lblRegistros.Location = New System.Drawing.Point(433, 12)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(45, 13)
        Me.lblRegistros.TabIndex = 4
        Me.lblRegistros.Text = "Registros"
        Me.lblRegistros.Visible = False
        '
        'BackgroundWorker1
        '
        '
        'Recepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 83)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.pbRegistros)
        Me.Controls.Add(Me.pbFicheros)
        Me.Controls.Add(Me.lblFicheros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Recepcion"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Comunicaciones - Recepción"
        CType(Me.pbFicheros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegistros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFicheros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pbFicheros As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents pbRegistros As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents lblRegistros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
