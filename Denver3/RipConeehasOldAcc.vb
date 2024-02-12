Public Class RipConeehasOldAcc
    Dim Close1 As Boolean = False
    Private Sub RipConeehasOldAcc_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Close1 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "RIP CONEEHA OLD ACC" Then
            MsgBox("Thanks.", 0 + 64, "Denver3 Virus")
            Close1 = True
            Me.Close()
        End If
    End Sub

    Private Sub RipConeehasOldAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.TopMost = True
    End Sub
End Class