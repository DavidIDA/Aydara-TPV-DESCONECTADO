Public Class fPopupMenu

    Dim _EsCompras As Boolean
    Dim _CODIGO As String
    Dim _CODART As String

    Public Event Seleccionar(CODIGO As String)
    Public Event BeforePopup()

    Enum TipoMenu
        Cliente
        Proveedor
        Articulo
    End Enum

    Public Sub New(TipoMenu As TipoMenu, Parent As Form, Optional Elemento As Object = Nothing)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.BarManagerCliente.Form = Parent
        Me.BarManagerProveedor.Form = Parent
        Me.BarManagerArticulo.Form = Parent

        If Not Elemento Is Nothing Then
            Select Case TipoMenu
                Case fPopupMenu.TipoMenu.Cliente
                    Me.BarManagerCliente.SetPopupContextMenu(Elemento, Me.PopupMenuCliente)
                Case fPopupMenu.TipoMenu.Proveedor
                    Me.BarManagerProveedor.SetPopupContextMenu(Elemento, Me.PopupMenuProveedor)
                Case fPopupMenu.TipoMenu.Articulo
                    Me.BarManagerArticulo.SetPopupContextMenu(Elemento, Me.PopupMenuArticulo)
            End Select
        End If

    End Sub

#Region "Propiedades"
    Property EsCompras
        Get
            Return Me._EsCompras
        End Get
        Set(value)
            Me._EsCompras = value
        End Set
    End Property

    Property CODIGO
        Get
            Return Me._CODIGO
        End Get
        Set(value)
            Me._CODIGO = value
        End Set
    End Property

    Property CODART
        Get
            Return Me._CODART
        End Get
        Set(value)
            Me._CODART = value
        End Set
    End Property

#End Region

#Region "PopupMenuCliente"
    Private Sub bttClienteNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttClienteNuevo.ItemClick

        Dim Cliente As New dsClientes

        Try
            Cliente.Nuevo()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Sub

    Private Sub bttClienteEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttClienteEditar.ItemClick

        Dim Cliente As New dsClientes

        Try
            Cliente.Editar(Me.CODIGO)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Sub

    Private Sub bttClienteTodos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttClienteTodos.ItemClick

        Dim Cliente As New dsClientes

        Try
            Cliente.Mantenimiento()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttClienteBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttClienteBuscar.ItemClick

        Dim Cliente As New dsClientes

        Try
            RaiseEvent Seleccionar(Cliente.Seleccionar)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "PopupMenuProveedor"
    Private Sub bttProveedorNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttProveedorNuevo.ItemClick

        Dim Proveedor As New dsProveedores

        Try
            Proveedor.Nuevo()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Sub

    Private Sub bttProveedorEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttProveedorEditar.ItemClick

        Dim Proveedor As New dsProveedores

        Try
            Proveedor.Editar(Me.CODIGO)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Sub

    Private Sub bttProveedorTodos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttProveedorTodos.ItemClick

        Dim Proveedor As New dsProveedores

        Try
            Proveedor.Mantenimiento()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttProveedorBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttProveedorBuscar.ItemClick

        Dim Proveedor As New dsProveedores

        Try
            RaiseEvent Seleccionar(Proveedor.Seleccionar)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "PopupMenuArticulo"
    Private Sub bttArticuloNuevo_Click(sender As Object, e As EventArgs) Handles bttArticuloNuevo.ItemClick

        Dim Articulo As New dsArticulos

        Try
            Articulo.Nuevo()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Sub

    Private Sub bttArticuloEditar_Click(sender As Object, e As EventArgs) Handles bttArticuloEditar.ItemClick

        Dim Articulo As New dsArticulos

        Try
            Articulo.Editar(Me.CODART)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Sub

    Private Sub bttArticuloTodos_Click(sender As Object, e As EventArgs) Handles bttArticuloTodos.ItemClick

        Dim Articulo As New dsArticulos

        Try
            Articulo.Mantenimiento()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Sub

    Private Sub bttArticuloBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttArticuloBuscar.ItemClick

        Dim Articulo As New dsArticulos

        Try
            RaiseEvent Seleccionar(Articulo.Seleccionar())

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Sub

#End Region

#Region "PopupMenu_BeforePopup"
    Private Sub PopupMenu_BeforePopup(sender As Object, e As EventArgs) Handles PopupMenuProveedor.BeforePopup, PopupMenuCliente.BeforePopup, PopupMenuArticulo.BeforePopup
        RaiseEvent BeforePopup()
        Me.bttProveedorEditar.Enabled = (Me.CODIGO <> String.Empty)
        Me.bttClienteEditar.Enabled = (Me.CODIGO <> String.Empty)
        Me.bttArticuloEditar.Enabled = (Me.CODART <> String.Empty)
        Me.bttHistorico.Visibility = (IIf(Me.CODIGO <> String.Empty, DevExpress.XtraBars.BarItemVisibility.Always, DevExpress.XtraBars.BarItemVisibility.Never))
    End Sub
#End Region

End Class