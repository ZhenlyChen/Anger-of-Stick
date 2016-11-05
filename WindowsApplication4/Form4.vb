Imports System.Data.OleDb

Public Class Form4
    Dim a As Integer
    Dim a1 As String
    Dim a9 As Integer
    Dim a3 As Integer
    Dim a2 As Integer
    Dim a4 As String
    Dim b As Integer
    Dim c As Integer
    Dim ii As Integer
    Dim b1 As Integer
    Dim c1 As Integer
    Dim c2 As Integer
    Dim a5 As String
    Dim a8 As String
    Dim d1 As Integer
    Dim d2 As Integer
    Dim d3 As Integer
    Dim d4 As Integer
    Dim d5 As String
    Dim d6 As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Form1.Label60.Text = "暂停（P）"
        Form9.TextBox1.Text = Form9.TextBox1.Text + "游戏已继续" + Chr(13) & Chr(10)
        Me.Visible = False
        Form7.Close()
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        
        Dim mystr() As String = TextBox1.Text.Split("."c)
        Label1.Text = CStr((TextBox1.Text.Split(".").Length - 1))
        If Label1.Text > 0 Then
            ListBox1.Items.Clear()
            a2 = ListBox1.SelectedIndex
            a2 = a2 + 1
            '定义一个OLEDB连接并实例化它
            Dim con As New OleDbConnection
            '定义一个OLEDB命令并实例化他
            Dim cmd As New OleDbCommand
            '定义一个OLEDBReader方法来读取数据库
            Dim dr As OleDbDataReader
            '初始化con的连接属性，使用OLEDB模式，数据源为：你指定下路径，我的是在D盘
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\武器数据.mdb;Jet OLEDB:Database Password=NIshiSHAb,.,.,,."
            '打开OLEDB数据连接
            con.Open()
            cmd.Connection = con
            c = Label1.Text
            For Me.ii = 1 To c
                cmd.CommandText = "select 名称 from 武器 where ID=" & mystr(ii)
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    ListBox1.Items.Add(dr(0))
                End If
                dr.Close()
            Next

            con.Close()
        Else
            ListBox1.Items.Clear()

        End If

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)
        Me.Visible = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove
        a3 = Me.Location.X + Label2.Location.X + Label2.Width
        b = Me.Location.Y + Label2.Location.Y + Label2.Height
        Form6.Location = New System.Drawing.Point(a3, b)
        Form6.Show()

    End Sub



    Private Sub Form4_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Form6.Visible = False
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Form1.Label60.Text = "暂停（P）"
        Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "游戏已继续" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
        Me.Visible = False
        Form7.Close()
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        On Error GoTo Answer
        If ListBox1.SelectedIndex <> -1 Then
            Form7.ListBox2.Items.Clear()
            a = ListBox1.SelectedIndex
            a = a + 1
            Dim mystrs() As String = TextBox1.Text.Split("."c)
            a = mystrs(a)
            '定义一个OLEDB连接并实例化它
            Dim con As New OleDbConnection
            '定义一个OLEDB命令并实例化他
            Dim cmd As New OleDbCommand
            '定义一个OLEDBReader方法来读取数据库
            Dim dr As OleDbDataReader
            '初始化con的连接属性，使用OLEDB模式，数据源为：你指定下路径，我的是在D盘
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\武器数据.mdb;Jet OLEDB:Database Password=NIshiSHAb,.,.,,."
            '打开OLEDB数据连接
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select 名称 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a4 = dr(0)
                Form7.ListBox2.Items.Add(dr(0))
            End If
            dr.Close()
            cmd.CommandText = "select 品质 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Form7.ListBox2.Items.Add(dr(0))
            End If
            dr.Close()
            cmd.CommandText = "select 攻击频率 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Form7.ListBox2.Items.Add("攻击频率：" + dr(0))
            End If
            dr.Close()
            cmd.CommandText = "select 攻击力 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                Form7.ListBox2.Items.Add("攻击力：" + a1)
            End If
            dr.Close()

            cmd.CommandText = "select 魔力 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                Form7.ListBox2.Items.Add("魔力：" + a1)
            End If
            dr.Close()

            cmd.CommandText = "select 暴击 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                Form7.ListBox2.Items.Add("暴击率：" + a1 + "%")
            End If
            dr.Close()

            cmd.CommandText = "select 耐久上限 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                Form7.ListBox2.Items.Add("耐久：" + a1 + "/" + a1)
            End If
            dr.Close()

            cmd.CommandText = "select 效果 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Form7.TextBox1.Text = dr(0)
            End If
            dr.Close()

            cmd.CommandText = "select 等级 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                Form7.ListBox2.Items.Add("等级：" + a1)
                Label5.Text = a1
            End If
            dr.Close()
            cmd.CommandText = "select 价格 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                If a1 = "0" Then
                    Form7.ListBox2.Items.Add("这东东太厉害了，冇得卖")
                Else
                    Form7.ListBox2.Items.Add("价格：" + a1)
                End If

            End If
            dr.Close()
            cmd.CommandText = "select 售出价格 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then

                Label4.Text = dr(0)

            End If
            dr.Close()


            dr.Close()
            con.Close()

            b1 = Me.Location.X + Me.Width
            c1 = Me.Location.Y
            Form7.Show()
            Form7.Location = New System.Drawing.Point(b1, c1)
        End If
        Exit Sub
Answer:
        ListBox1.Items.Clear()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If ListBox1.SelectedIndex <> -1 Then
            Form7.ListBox2.Items.Clear()
            a = ListBox1.SelectedIndex
            a = a + 1
            Dim mystrs() As String = TextBox1.Text.Split("."c)
            a = mystrs(a)
            '定义一个OLEDB连接并实例化它
            Dim con As New OleDbConnection
            '定义一个OLEDB命令并实例化他
            Dim cmd As New OleDbCommand
            '定义一个OLEDBReader方法来读取数据库
            Dim dr As OleDbDataReader
            '初始化con的连接属性，使用OLEDB模式，数据源为：你指定下路径，我的是在D盘
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\武器数据.mdb;Jet OLEDB:Database Password=NIshiSHAb,.,.,,."
            '打开OLEDB数据连接
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select 名称 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a4 = dr(0)
                Form7.ListBox2.Items.Add(dr(0))
            End If
            dr.Close()
            cmd.CommandText = "select 品质 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Form7.ListBox2.Items.Add(dr(0))
            End If
            dr.Close()
            cmd.CommandText = "select 攻击频率 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Form7.ListBox2.Items.Add("攻击频率：" + dr(0))
            End If
            dr.Close()
            cmd.CommandText = "select 攻击力 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                Form7.ListBox2.Items.Add("攻击力：" + a1)
            End If
            dr.Close()

            cmd.CommandText = "select 魔力 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                Form7.ListBox2.Items.Add("魔力：" + a1)
            End If
            dr.Close()

            cmd.CommandText = "select 暴击 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                Form7.ListBox2.Items.Add("暴击率：" + a1 + "%")
            End If
            dr.Close()

            cmd.CommandText = "select 耐久上限 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                Form7.ListBox2.Items.Add("耐久：" + a1 + "/" + a1)
            End If
            dr.Close()

            cmd.CommandText = "select 效果 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Form7.TextBox1.Text = dr(0)
            End If
            dr.Close()

            cmd.CommandText = "select 等级 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                Form7.ListBox2.Items.Add("等级：" + a1)
            End If
            dr.Close()
            cmd.CommandText = "select 价格 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                If a1 = "0" Then
                    Form7.ListBox2.Items.Add("这东东太厉害了，冇得卖")
                Else
                    Form7.ListBox2.Items.Add("价格：" + a1)
                End If

            End If
            dr.Close()

            cmd.CommandText = "select 售出价格 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a9 = dr(0)
                Label4.Text = a9

            End If
            dr.Close()



            dr.Close()
            con.Close()

            b1 = Me.Location.X + Me.Width
            c1 = Me.Location.Y
            Form7.Show()
            Form7.Location = New System.Drawing.Point(b1, c1)

        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If ListBox1.SelectedIndex <> -1 Then
            If MessageBox.Show("你确定要出售" + a4 + "吗？，价值" + Label4.Text + "金币", "提示", MessageBoxButtons.YesNo) = vbNo Then
                MsgBox("你已经取消交易")
            Else
                MsgBox("出售成功！")
                a9 = Label4.Text
                Dim a10 As Integer = Label1.Text
                a5 = a
                TextBox1.Text = Replace(TextBox1.Text, "." + a5, "")
                Dim mystr() As String = TextBox1.Text.Split("."c)
                Label1.Text = CStr((TextBox1.Text.Split(".").Length - 1))
                Dim a11 As Integer = Label1.Text
                Dim a12 As Integer = a10 - a11
                Dim a55 As Integer
                a55 = Label4.Text
                a12 = a55 * a12
                
                Dim a14 As Integer
                a14 = Form1.Label58.Text
                a14 = a14 + a12
                Dim a13 As String
                a13 = a14
                Form1.Label58.Text = a13

                If Label1.Text > 0 Then
                    ListBox1.Items.Clear()
                    a2 = ListBox1.SelectedIndex
                    a2 = a2 + 1
                    '定义一个OLEDB连接并实例化它
                    Dim con As New OleDbConnection
                    '定义一个OLEDB命令并实例化他
                    Dim cmd As New OleDbCommand
                    '定义一个OLEDBReader方法来读取数据库
                    Dim dr As OleDbDataReader
                    '初始化con的连接属性，使用OLEDB模式，数据源为：你指定下路径，我的是在D盘
                    con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\武器数据.mdb;Jet OLEDB:Database Password=NIshiSHAb,.,.,,."
                    '打开OLEDB数据连接
                    con.Open()
                    cmd.Connection = con
                    c = Label1.Text
                    For Me.ii = 1 To c
                        cmd.CommandText = "select 名称 from 武器 where ID=" & mystr(ii)
                        dr = cmd.ExecuteReader()
                        If dr.Read() Then
                            ListBox1.Items.Add(dr(0))
                        End If
                        dr.Close()
                    Next

                    con.Close()
                Else
                    ListBox1.Items.Clear()

                End If
            End If
        End If

    End Sub
    Dim g1 As Integer
    Dim g2 As Integer
    Dim g3 As Integer
    Dim g4 As Integer
    Dim g5 As String
    Dim g6 As String
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Label5.Text < Form1.Label18.Text + 1 Then
            g1 = Form1.Label34.Text
            g2 = Form6.Label5.Text
            g1 = g1 - g2
            g5 = g1
            Form1.Label34.Text = g5

            g1 = Form1.Label34.Text
            g2 = Form6.Label7.Text
            g1 = g1 - g2
            g5 = g1
            Form1.Label44.Text = g5
            a = ListBox1.SelectedIndex
            a = a + 1
            Dim mystrs() As String = TextBox1.Text.Split("."c)
            a = mystrs(a)
            TextBox1.Text = TextBox1.Text + "." + Form1.Label7.Text
            Form1.Label7.Text = a
            a3 = Form1.Label7.Text

            '定义一个OLEDB连接并实例化它
            Dim con As New OleDbConnection
            '定义一个OLEDB命令并实例化他
            Dim cmd As New OleDbCommand
            '定义一个OLEDBReader方法来读取数据库
            Dim dr As OleDbDataReader
            '初始化con的连接属性，使用OLEDB模式，数据源为：你指定下路径，我的是在D盘
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\武器数据.mdb;Jet OLEDB:Database Password=NIshiSHAb,.,.,,."
            '打开OLEDB数据连接
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select 名称 from 武器 where ID=" & a3
            dr = cmd.ExecuteReader()
            If dr.Read() Then

                Form6.Label1.Text = dr(0)
                Me.Label2.Text = dr(0)
            End If
            dr.Close()
            cmd.CommandText = "select 品质 from 武器 where ID=" & a3
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Form6.Label2.Text = dr(0)
            End If
            dr.Close()
            cmd.CommandText = "select 攻击频率 from 武器 where ID=" & a3
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Form6.Label3.Text = dr(0)
            End If
            dr.Close()
            cmd.CommandText = "select 攻击力 from 武器 where ID=" & a3
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                Form6.Label5.Text = a1
            End If
            dr.Close()

            cmd.CommandText = "select 魔力 from 武器 where ID=" & a3
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                Form6.Label7.Text = a1
            End If
            dr.Close()

            cmd.CommandText = "select 暴击 from 武器 where ID=" & a3
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                Form6.Label9.Text = a1
                Form1.Label46.Text = a1 + "%"
            End If
            dr.Close()

            cmd.CommandText = "select 耐久上限 from 武器 where ID=" & a3
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                Form6.Label12.Text = a1
            End If
            dr.Close()

            cmd.CommandText = "select 效果 from 武器 where ID=" & a3
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Form6.TextBox1.Text = dr(0)
            End If
            dr.Close()

            cmd.CommandText = "select 等级 from 武器 where ID=" & a3
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                Form6.Label16.Text = a1
            End If
            dr.Close()
            cmd.CommandText = "select 价格 from 武器 where ID=" & a3
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                Form6.Label19.Text = a1

            End If
            dr.Close()
            cmd.CommandText = "select 攻击速度 from 武器 where ID=" & a3
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Form1.Timer5.Interval = dr(0)

            End If
            dr.Close()
            cmd.CommandText = "select 售出价格 from 武器 where ID=" & a3
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                Form6.Label20.Text = a1
            End If

            dr.Close()

            con.Close()

            g1 = Form1.Label34.Text
            g2 = Form6.Label5.Text
            g1 = g1 + g2
            g5 = g1



            Form1.Label34.Text = g5

            g1 = Form1.Label44.Text
            g2 = Form6.Label7.Text
            g1 = g1 + g2
            g5 = g1

            Form1.Label44.Text = g5
        Else
            MsgBox("兄弟，你的等级好像不够额")
        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click


        Dim mystr() As String = TextBox1.Text.Split("."c)

        Label1.Text = CStr((TextBox1.Text.Split(".").Length - 1))
        If Label1.Text > 0 Then
            ListBox1.Items.Clear()
            a2 = ListBox1.SelectedIndex
            a2 = a2 + 1
            '定义一个OLEDB连接并实例化它
            Dim con As New OleDbConnection
            '定义一个OLEDB命令并实例化他
            Dim cmd As New OleDbCommand
            '定义一个OLEDBReader方法来读取数据库
            Dim dr As OleDbDataReader
            '初始化con的连接属性，使用OLEDB模式，数据源为：你指定下路径，我的是在D盘
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\武器数据.mdb;Jet OLEDB:Database Password=NIshiSHAb,.,.,,."
            '打开OLEDB数据连接
            con.Open()
            cmd.Connection = con
            c = Label1.Text
            For Me.ii = 1 To c
                cmd.CommandText = "select 名称 from 武器 where ID=" & mystr(ii)
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    ListBox1.Items.Add(dr(0))
                End If
                dr.Close()
            Next

            con.Close()
        Else
            ListBox1.Items.Clear()

        End If

    End Sub
End Class