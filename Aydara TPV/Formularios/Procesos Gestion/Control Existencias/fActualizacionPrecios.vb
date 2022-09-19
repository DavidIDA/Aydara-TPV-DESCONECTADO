Public Class fActualizacionPrecios

    Dim CodigoProveedor As Integer, CodigoArticulo As String, Precio As Decimal

    Public Sub New(ByVal CodigoProveedor As Integer, ByVal CodigoArticulo As String, ByVal Precio As Decimal)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.CodigoProveedor = CodigoProveedor
        Me.CodigoArticulo = CodigoArticulo
        Me.Precio = Precio

        Me.txtPrecioLinea.EditValue = Me.Precio
        Me.txtPrecioLinea2.EditValue = Me.Precio

    End Sub

    Private Sub fActualizacionPrecios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.DsActualizacionPrecios.Cargar(Me.CodigoProveedor, Me.CodigoArticulo, Me.Precio)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub bttGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttGuardar.Click
        Try
            Me.ARTICULOSBindingSource.EndEdit()
            Me.REFERENCIASPROVEEDORESBindingSource.EndEdit()

            Me.DsActualizacionPrecios.Guardar()

            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub txtPrecioCoste_Articulo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrecioCoste_Articulo.KeyUp, txtPrecioCoste_Proveedor.KeyUp
        If e.KeyCode = Keys.A Then
            sender.editvalue = Me.Precio
        End If
    End Sub
End Class