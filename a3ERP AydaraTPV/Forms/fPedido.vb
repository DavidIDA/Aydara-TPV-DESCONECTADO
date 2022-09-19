Public Class fPedido

    Dim IDPED As Integer
    Dim DeCompra As Boolean

    Public Sub New(_IDPED As Integer, _DeCompra As Boolean)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.IDPED = _IDPED
        Me.DeCompra = _DeCompra

    End Sub

    Private Sub fPedido_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.DsPedidos.Cargar(Me.IDPED, Me.DeCompra)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttTraspaso_Click(sender As Object, e As EventArgs) Handles bttTraspaso.Click
        Try
            Me.dgLineas.FocusedView.CloseEditor()
            Me.dgLineas.FocusedView.UpdateCurrentRow()

            If MsgBox("¿Seguro que desea generar el traspaso entre almacenes?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then Exit Try

            Dim IDTRAS As Integer = Me.DsPedidos.Traspaso

            If IDTRAS > 0 Then
                Me.DsPedidos.AnulaPedido(Me.IDPED, Me.DeCompra)
                MsgBox("Traspaso generado correctamente", MsgBoxStyle.Information, Me.Text)
                Aydara.VerOpcion("manTraspaso", {"Accion", "Edicion", "idDocu", IDTRAS})
            Else
                MsgBox("No se ha generado ningún traspaso", MsgBoxStyle.Exclamation, Me.Text)
            End If

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub btnEliminarLineasSinStock_Click(sender As Object, e As EventArgs) Handles btnEliminarLineasSinStock.Click
        Dim i As Integer = 0

        Try

            'For i = 0 To Me.gvLineas.RowCount - 1
            '    With Me.gvLineas.GetDataRow(i)
            '        If Not IsNothing(Me.gvLineas.GetDataRow(i)) Then
            '            If Not IsDBNull(.Item("CODART")) Then
            '                If IsDBNull(.Item("STOCK")) Then
            '                    .Delete()
            '                    i = i - 1
            '                ElseIf .Item("STOCK") = 0 Then
            '                    .Delete()
            '                    i = i - 1
            '                End If
            '            End If
            '        End If
            '    End With
            'Next

            Me.LINEPEDIBindingSource.Filter = "STOCK > 0"



        Catch ex As Exception
            MsgBox(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnRellenarCantServir_Click(sender As Object, e As EventArgs) Handles btnRellenarCantServir.Click
        Try
            Dim i As Integer
            For i = 0 To Me.gvLineas.RowCount - 1
                If Not IsNothing(Me.gvLineas.GetDataRow(i)) Then
                    With Me.gvLineas.GetDataRow(i)
                        If Not IsDBNull((.Item("CODART"))) And Not IsDBNull((.Item("UNISERVIDA"))) And Not IsDBNull((.Item("STOCK"))) And Not IsDBNull((.Item("UNIDADES"))) Then
                            If .Item("Stock") > 0 And .Item("UNIDADES") > 0 Then
                                If .Item("Stock") >= .Item("UNIDADES") Then
                                    .Item("UNISERVIDA") = .Item("UNIDADES")
                                Else
                                    .Item("UNISERVIDA") = .Item("Stock")
                                End If
                            End If
                        End If
                    End With
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, Me.Text)
        End Try
    End Sub
End Class