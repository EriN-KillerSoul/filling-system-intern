Public Class MENU_UTAMA
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Me.Hide()
        REKOD.Show()
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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Me.Hide()
        CETAK.Show()
    End Sub
End Class