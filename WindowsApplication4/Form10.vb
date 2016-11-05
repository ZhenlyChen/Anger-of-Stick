Public Class Form10

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "jiefenghuochairen" Then
            Form1.Show()
            Form9.Show()
            Me.Close()
            Form1.Label60.Text = "暂停（P）"
            Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "游戏已继续" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
        Else
            MsgBox("Code word error")
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Form10_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If TextBox1.Text = "jiefenghuochairen" Then
            Form1.Show()
            Form9.Show()
            Me.Close()
            Form1.Label60.Text = "暂停（P）"
            Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "游戏已继续" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
        Else
            MsgBox("Code word error")
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class