Public Class Form8

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Label60.Text = "暂停（P）" 
        Form9.TextBox1.Text = Form9.TextBox1.Text + "游戏已继续" + Chr(13) & Chr(10)
        Me.Close()
    End Sub
End Class