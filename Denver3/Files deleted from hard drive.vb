Public Class Files_deleted_from_hard_drive
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            ListBox1.SelectedIndex = -1
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Files_deleted_from_hard_drive_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub
End Class