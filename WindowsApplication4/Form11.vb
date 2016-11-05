Imports System.Net
Imports System.IO

Public Class Form11



    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button12_Click(sender, e)
        
        WebBrowser1.ScriptErrorsSuppressed = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        WebBrowser1.Navigate("http://hi.baidu.com/rongzhenspace/item/6b6e01941192ebdb1e427167")
        Timer1.Enabled = True
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next

        If Label5.Text <> "未获取" Then
            WebBrowser1.Navigate("http://hi.baidu.com/rongzhenspace/item/fd433be9fec02f216cabb87f")


            Timer2.Enabled = True
            ProgressBar1.Value = 60
            Timer1.Enabled = False
        Else
            Label5.Text = WebBrowser1.Document.GetElementById("content").InnerHtml
            Label5.Text = Replace_ex(Label5.Text, "</P>", "")
            Label5.Text = Replace_ex(Label5.Text, "<P>", "")
            ProgressBar1.Value = 40
        End If
    End Sub
    Function Replace_ex(ByVal ExPression As String, ByVal Find As String, ByVal Replace_ As String) As String
        Dim i As Integer, j As Integer, s As String, s1 As String
        s = LCase(ExPression) '统一转换为小写，表示不区分大小写
        Find = LCase(Find) '同上
        i = 1
        Do While InStr(i, s, Find, vbBinaryCompare) > 0 '查找
            j = InStr(i, s, Find, vbBinaryCompare)
            s1 = s1 & Mid(ExPression, i, j - i) & Replace_ '替换
            i = j + Len(Find)
        Loop
        If i <= Len(ExPression) Then s1 = s1 + Mid(ExPression, i)
        Replace_ex = s1 '输出
    End Function

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        On Error Resume Next
        If Label9.Text <> "未获取" Then
            TextBox1.Text = Label9.Text
            Button1.Enabled = True
            ProgressBar1.Value = 100
            TextBox3.Text = Label9.Text

            Dim iIndex As Integer = TextBox3.Tag
            If iIndex >= TextBox3.Text.Length - 1 Then iIndex = 0
            TextBox3.Focus()

            iIndex = TextBox3.Text.IndexOf(Label2.Text, iIndex)
            If iIndex > -1 Then
                TextBox3.SelectionStart = iIndex
                TextBox3.SelectionLength = "Label2.Text".Length
                TextBox3.Tag = iIndex + "Label2.Text".Length

            Else
                iIndex = TextBox3.Text.IndexOf("Label2.Text", 0)   '   从头开始查找 
                If iIndex > -1 Then
                    TextBox3.SelectionStart = iIndex
                    TextBox3.SelectionLength = "Label2.Text".Length
                    TextBox3.Tag = iIndex + "Label2.Text".Length
                    TextBox2.Text = "重要性：重要，此次更新会添加新内容或修复BUG和存档格式，请找陈荣真升级存档"
                    Me.Visible = True
                Else
                    If Label5.Text = Label3.Text Then
                        TextBox2.Text = "恭喜你，你使用的是最新版本"
                        Form3.Label1.Text = "恭喜你，你使用的是最新版本"
                    Else

                        TextBox2.Text = "重要性：普通，此次更新会添加新内容或修复BUG，但不会影响存档读取"
                        Me.Visible = True
                    End If

                    
                End If
            End If


            Timer2.Enabled = False


        Else

            ProgressBar1.Value = 80
            Label9.Text = WebBrowser1.Document.GetElementById("content").InnerHtml
            Label9.Text = Replace_ex(Label9.Text, Label8.Text, "")
            Label9.Text = Replace_ex(Label9.Text, "<BR></P>", "")
            Label9.Text = Replace_ex(Label9.Text, "</SPAN>", "")
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Dir(Application.StartupPath + "\" + Label5.Text, vbDirectory) = "" Then
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\" + Label5.Text)
        End If
        DownFile(Label9.Text, Application.StartupPath + "\" + Label5.Text + "\愤怒的火柴人.exe", ProgressBar4)
        If MessageBox.Show("你需要现在就使用新系统吗？", "提示", MessageBoxButtons.YesNo) = vbNo Then
        Else
            Shell(Application.StartupPath + "\" + Label5.Text + "\愤怒的火柴人.exe")
            End
        End If
    End Sub


    Public Shared Sub DownFile(ByVal URL As String, ByVal Filename As String, ByVal Prog As ProgressBar)
        Dim Myrq As HttpWebRequest = HttpWebRequest.Create(URL)
        Dim myrp As HttpWebResponse = Myrq.GetResponse
        Dim totalBytes As Long = myrp.ContentLength
        Prog.Maximum = totalBytes
        Dim st As Stream = myrp.GetResponseStream
        Dim so As Stream = New FileStream(Filename, FileMode.Create)
        Dim totalDownloadedByte As Long = 0
        Dim by(1024) As Byte
        Dim osize As Integer = st.Read(by, 0, by.Length)
        While osize > 0
            totalDownloadedByte = osize + totalDownloadedByte
            Application.DoEvents()
            so.Write(by, 0, osize)
            Prog.Value = totalDownloadedByte
            osize = st.Read(by, 0, by.LongLength)
        End While
        so.Close()
        st.Close()
    End Sub
End Class