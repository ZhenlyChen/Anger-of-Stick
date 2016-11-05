Imports System.Net
Imports System.IO


Public Class Form3



    Private Property b As Integer

    Private Property a As Integer

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        End
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form2.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        On Error GoTo Answer
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName <> "" Then
            Dim txt As IO.StreamReader = New IO.StreamReader(OpenFileDialog1.FileName, System.Text.Encoding.Default)
            Dim a() As String, n As Integer = 0
            Do Until txt.EndOfStream
                n = n + 1
                ReDim Preserve a(n) '数组从1开始
                a(n) = txt.ReadLine()
            Loop
            txt.Close()
            TextBox1.Text = a(1) + Chr(13) & Chr(10) + a(2) + Chr(13) & Chr(10) + a(3) + Chr(13) & Chr(10) + a(4) + Chr(13) & Chr(10) + a(5) + Chr(13) & Chr(10) + a(6) + Chr(13) & Chr(10) + a(7) + Chr(13) & Chr(10) + a(8) + Chr(13) & Chr(10) + a(9) + Chr(13) & Chr(10) + a(10) + Chr(13) & Chr(10) + a(11) + Chr(13) & Chr(10) + a(12) + Chr(13) & Chr(10) + a(13) + Chr(13) & Chr(10) + a(14) + Chr(13) & Chr(10) + a(15) + Chr(13) & Chr(10) + a(16) + Chr(13) & Chr(10) + a(17) + Chr(13) & Chr(10)
            Dim mytxt, msgtxt As String
            mytxt = TextBox1.Text
            msgtxt = mySHA(mytxt)
            If a(18) <> msgtxt Then
                MsgBox("存档完整验证失败，请检查存档是否原版")
            Else
                If a(14) = Form11.Label2.Text Then
                    Form1.Label18.Text = a(1)
                    Form1.Label8.Text = a(2)
                    Form1.Label9.Text = a(3)
                    Form1.Label11.Text = a(4)
                    Form1.Label13.Text = a(5)
                    Form1.Label23.Text = a(6)
                    Form1.Label21.Text = a(7)
                    Form1.Label28.Text = a(8)
                    Form1.Label29.Text = a(9)
                    Form1.Label16.Text = a(10)
                    Form1.Label32.Text = a(11)
                    Form1.Label58.Text = a(12)
                    Form1.Label34.Text = a(13)
                    Form1.Label7.Text = a(15)
                    Form4.TextBox1.Text = a(16)
                    Form1.Label44.Text = a(17)
                    Form1.Show()
                    Me.Visible = False
                Else
                    MsgBox("存档完整验证失败，请检查存档是否匹配版本:" + Form11.Label2.Text)
                    If MessageBox.Show("你需要使用存档管理器升级存档版本吗？", "提示", MessageBoxButtons.YesNo) = vbYes Then
                        If IO.File.Exists(Application.StartupPath + "\存档管理器.exe") Then
                            Shell(Application.StartupPath + "\存档管理器.exe")
                        Else

                            ' DownFile("http://s.yunio.com/public/download/token/1FgiUn", Application.StartupPath + "\存档管理器.exe", Form11.ProgressBar4)
                            ' Form11.ProgressBar4.Value = 0
                            MsgBox("由于服务器故障，暂不开放")
                        End If
                    End If
                End If
            End If
        End If
        Exit Sub
Answer:
        MsgBox("存档完整验证失败，请检查存档的完整性和是否匹配版本:" + Form11.Label2.Text)


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
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click



        Form1.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        a = PictureBox1.Location.X
        b = 232
        PictureBox1.Location = New System.Drawing.Point(a, b)
    End Sub
    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        a = PictureBox2.Location.X
        b = 292
        PictureBox2.Location = New System.Drawing.Point(a, b)
    End Sub
    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove
        a = PictureBox3.Location.X
        b = 352
        PictureBox3.Location = New System.Drawing.Point(a, b)
    End Sub
    Private Sub PictureBox4_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseMove
        a = PictureBox4.Location.X
        b = 412
        PictureBox4.Location = New System.Drawing.Point(a, b)
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Form1.Show()
            Me.Visible = False
        End If
        If e.KeyCode = Keys.Escape Then
            End
        End If
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If IO.File.Exists(Application.StartupPath + "\武器数据.mdb") Then
        Else
            If MessageBox.Show("系统检测不到程序运行必须文件'武器数据.mdb'，请问是否从服务器下载？", "提示", MessageBoxButtons.YesNo) = vbNo Then
                If MessageBox.Show("请问是否退出本系统？", "提示", MessageBoxButtons.YesNo) = vbNo Then
                Else
                    End
                End If
            Else
                MsgBox（“由于服务器故障，暂不提供下载”， "万分抱歉"）
                ' Dim Obj_Lob As New System.Net.WebClient()
                'Obj_Lob.DownloadFile("http://s.yunio.com/public/download/token/jCkWfs", Application.StartupPath + "\武器数据.mdb")
                'MsgBox("下载完毕！现在你可以运行本系统了！")
            End If
        End If
        Form11.Show()
        Form11.Visible = False
    End Sub

    Private Sub Form3_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        a = PictureBox1.Location.X
        b = 242
        PictureBox1.Location = New System.Drawing.Point(a, b)
        a = PictureBox2.Location.X
        b = 302
        PictureBox2.Location = New System.Drawing.Point(a, b)
        a = PictureBox3.Location.X
        b = 362
        PictureBox3.Location = New System.Drawing.Point(a, b)
        a = PictureBox4.Location.X
        b = 422
        PictureBox4.Location = New System.Drawing.Point(a, b)
    End Sub
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
    End Sub
    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        PictureBox1.BorderStyle = BorderStyle.None
    End Sub
    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        PictureBox2.BorderStyle = BorderStyle.Fixed3D
    End Sub
    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        PictureBox2.BorderStyle = BorderStyle.None
    End Sub
    Private Sub PictureBox3_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseDown
        PictureBox3.BorderStyle = BorderStyle.Fixed3D
    End Sub
    Private Sub PictureBox3_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseUp
        PictureBox3.BorderStyle = BorderStyle.None
    End Sub
    Private Sub PictureBox4_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseDown
        PictureBox4.BorderStyle = BorderStyle.Fixed3D
    End Sub
    Private Sub PictureBox4_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseUp
        PictureBox4.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form4.Show()
    End Sub
    Function mySHA(ByVal SourceStr As String) As String 'SHA1加密算法
        Dim SHA As New System.Security.Cryptography.SHA1CryptoServiceProvider 'sha1加密
        'Dim sha As New System.Security.Cryptography.SHA256Managed’sha256加密
        'Dim sha As New System.Security.Cryptography.SHA512Managed ‘sha512加密
        Dim bytValue() As Byte '输入
        Dim bytHash() As Byte '输出
        bytValue = System.Text.Encoding.UTF8.GetBytes(SourceStr) '输入字符转为byte
        bytHash = SHA.ComputeHash(bytValue) '加密
        SHA.Clear()
        mySHA = Convert.ToBase64String(bytHash) '转为字符
    End Function
End Class

