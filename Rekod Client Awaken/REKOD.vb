
Public Class REKOD

    Private Sub btnKosong_Click(sender As Object, e As EventArgs) Handles btnKosong.Click
        txtClient.Text = ""
        txtHarga.Text = ""
        txtInvois.Text = ""
        txtPIC.Text = ""
        txtProgram.Text = ""
        txtTrainer.Text = ""
        txtTempat.Text = ""
        txtTrainer.Text = ""
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        MENU_UTAMA.Show()
    End Sub

    Private Sub REKOD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TblprogramDataSet.PROGRAM' table. You can move, or remove it, as needed.
        Me.PROGRAMTableAdapter.Fill(Me.TblprogramDataSet.PROGRAM)

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            PROGRAMBindingSource.EndEdit()
            PROGRAMTableAdapter.Update(TblprogramDataSet.PROGRAM)
            MessageBox.Show("Data disimpan")
        Catch ex As Exception
            MessageBox.Show("Terdapat masalah untuk proses menyimpan")
        End Try
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

    Private Sub SaveButton_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PROGRAMBindingSource.EndEdit()
        Me.PROGRAMTableAdapterManager.UpdateAll(Me.TblprogramDataSet)
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs)
        Me.PROGRAMBindingSource.MoveFirst()
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs)
        Me.PROGRAMBindingSource.MovePrevious()
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs)
        Me.PROGRAMBindingSource.MoveNext()
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs)
        Me.PROGRAMBindingSource.MoveLast()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Me.PROGRAMBindingSource.AddNew()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)
        Me.PROGRAMBindingSource.AddNew()
    End Sub

    Private Sub btnBuang_Click(sender As Object, e As EventArgs) Handles btnBuang.Click
        Me.PROGRAMBindingSource.RemoveCurrent()
    End Sub
End Class
