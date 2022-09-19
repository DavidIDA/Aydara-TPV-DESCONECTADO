<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fSeleccion
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
        Me.dgSeleccion = New DevExpress.XtraGrid.GridControl()
        Me.gvSeleccion = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.dgSeleccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSeleccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgSeleccion
        '
        Me.dgSeleccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSeleccion.Location = New System.Drawing.Point(0, 0)
        Me.dgSeleccion.MainView = Me.gvSeleccion
        Me.dgSeleccion.Name = "dgSeleccion"
        Me.dgSeleccion.Size = New System.Drawing.Size(635, 459)
        Me.dgSeleccion.TabIndex = 0
        Me.dgSeleccion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSeleccion})
        '
        'gvSeleccion
        '
        Me.gvSeleccion.GridControl = Me.dgSeleccion
        Me.gvSeleccion.Name = "gvSeleccion"
        Me.gvSeleccion.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvSeleccion.OptionsBehavior.Editable = False
        Me.gvSeleccion.OptionsBehavior.ReadOnly = True
        Me.gvSeleccion.OptionsCustomization.AllowRowSizing = True
        Me.gvSeleccion.OptionsFind.AlwaysVisible = True
        Me.gvSeleccion.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvSeleccion.OptionsView.EnableAppearanceEvenRow = True
        Me.gvSeleccion.OptionsView.EnableAppearanceOddRow = True
        Me.gvSeleccion.OptionsView.ShowAutoFilterRow = True
        '
        'Seleccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 459)
        Me.Controls.Add(Me.dgSeleccion)
        Me.KeyPreview = True
        Me.Name = "Seleccion"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Selección"
        CType(Me.dgSeleccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSeleccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgSeleccion As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSeleccion As DevExpress.XtraGrid.Views.Grid.GridView
End Class
