Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Public Class RipZ3CK100
    Dim Close1 = False
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RipZ3CK100_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "RIP Z3CK100 OLD ACC" Then
            MsgBox("Thanks.", 0 + 64, "Denver3 Virus")
            Close1 = True
            Me.Close()
        End If
    End Sub

    Private Sub RipZ3CK100_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Close1 Then
            e.Cancel = True
        End If
    End Sub
End Class