Public Class fListadoExterno

    Dim _VistaPrevia As Boolean
    Dim _Definir As Boolean
    Dim _Impresora As String
    Dim _DirectorioFichero As String
    Dim _Copias As Integer

#Region "Propiedades"
    Property VistaPrevia
        Get
            Return Me._VistaPrevia
        End Get
        Set(value)
            Me._VistaPrevia = value
        End Set
    End Property

    Property Definir
        Get
            Return Me._Definir
        End Get
        Set(value)
            Me._Definir = value
        End Set
    End Property

    Property Impresora
        Get
            Return Me._Impresora
        End Get
        Set(value)
            Me._Impresora = value
        End Set
    End Property

    Property DirectorioFichero
        Get
            Return Me._DirectorioFichero
        End Get
        Set(value)
            Me._DirectorioFichero = value
        End Set
    End Property

    Property Copias
        Get
            Return Me._Copias
        End Get
        Set(value)
            Me._Copias = value
        End Set
    End Property

#End Region

#Region "Eventos formulario"
    Private Sub fListadoExterno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.bttDefinir.Visible = (My.Settings.Usuario = "SA")

            Me.txtCopias.EditValue = Me.Copias

            'Listados definidos
            If IO.Directory.Exists(Me.DirectorioFichero) Then
                Dim folder As New IO.DirectoryInfo(Me.DirectorioFichero)
                For Each file As IO.FileInfo In folder.GetFiles()
                    If file.Extension = ".repx" Then
                        Me.cmbListados.Properties.Items.Add(Mid(file.Name, 1, file.Name.Length - 5))
                    End If
                Next
            End If

            'Impresoras
            Dim impresoras As New System.Drawing.Printing.PrinterSettings
            For i As Integer = 0 To System.Drawing.Printing.PrinterSettings.InstalledPrinters.Count - 1
                Me.cmbImpresoras.Properties.Items.Add(System.Drawing.Printing.PrinterSettings.InstalledPrinters(i))
            Next

            If Me.cmbListados.Properties.Items.Count > 0 Then Me.cmbListados.SelectedIndex = 0
            Me.cmbImpresoras.EditValue = IIf(Me.Impresora <> String.Empty, Me.Impresora, impresoras.PrinterName)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

#End Region

#Region "Opciones"
    Private Sub bttDefinir_Click(sender As Object, e As EventArgs) Handles bttDefinir.Click
        Me.Definir = True
        If Not Me.cmbListados.EditValue Is Nothing Then Me.DirectorioFichero &= "\" & Me.cmbListados.EditValue & ".repx"
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub bttImprimir_Click(sender As Object, e As EventArgs) Handles bttImprimir.Click
        Me.Definir = False
        Me.Copias = Me.txtCopias.EditValue
        Me.VistaPrevia = Me.checkVistaPrevia.Checked
        If Not Me.cmbImpresoras.EditValue Is Nothing Then Me.Impresora = Me.cmbImpresoras.EditValue
        If Not Me.cmbListados.EditValue Is Nothing Then Me.DirectorioFichero &= "\" & Me.cmbListados.EditValue & ".repx"
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

#End Region

End Class