Public Class CETAK

    Private Sub CETAK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TblprogramDataSet.PROGRAM' table. You can move, or remove it, as needed.
        Me.PROGRAMTableAdapter.Fill(Me.TblprogramDataSet.PROGRAM)
        'TODO: This line of code loads data into the 'TblprogramDataSet.PROGRAM' table. You can move, or remove it, as needed.
        Me.PROGRAMTableAdapter.Fill(Me.TblprogramDataSet.PROGRAM)

    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim search As String = cmCari.Text

        Me.PROGRAMTableAdapter.FillBySearchName(Me.TblprogramDataSet.PROGRAM, search, search)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        Me.PROGRAMBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        MENU_UTAMA.Show()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim response As MsgBoxResult
        response = MsgBox("Keluar dari sistem?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "KELUAR")
        If response = MsgBoxResult.Yes Then
            Application.Exit()
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
End Class