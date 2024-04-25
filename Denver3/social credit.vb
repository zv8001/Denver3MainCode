Public Class social_credit
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub social_credit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MsgBox("-9999社会信用", 0 + 16, "-9999社会信用")
        badsocial_credit.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        badsocial_credit.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        badsocial_credit.Show()
    End Sub
End Class