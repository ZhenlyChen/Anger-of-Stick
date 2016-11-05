Public Class Form9

   
   
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

  
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.SelectionLength = 0
        TextBox1.SelectionStart = TextBox1.Text.Length
        TextBox1.ScrollToCaret()
    End Sub
End Class