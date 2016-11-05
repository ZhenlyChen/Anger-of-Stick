Imports System.IO
Imports System.Data.OleDb

Public Class Form1
    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Dim d As Integer
    Dim f As Integer
    Dim a2 As Integer
    Dim g As Integer
    Dim q As Integer
    Dim m As String
    Dim a1 As String
    Dim a3 As Integer
    Dim ii As Integer
    Dim gongji As Integer
    Dim gongji2 As String
    Dim gongji3 As String
    Dim a5 As String
    Dim i3 As String
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Label60.Text = "暂停（P）" Then
            If e.KeyCode = Keys.U Then
                If Label9.Text - 200 > 0 Then
                    If Label36.Text = "0" Then
                        If Timer2.Enabled = False Then
                            Timer1.Enabled = True
                        Else
                            Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "你现在已处于隐身状态，请按 X 现身！" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                        End If
                    End If
                Else
                    Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "魔力不足！无法施展技能" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                End If
            End If


            If e.KeyCode = Keys.H Then
                If Timer10.Enabled = False Then
                    If Label9.Text - 300 > 0 Then
                        g = Label28.Text / 100
                        Label9.Text = Label9.Text - 300
                        ProgressBar2.Value = Label9.Text
                        Timer10.Enabled = True

                        Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "技能：回血术" + Chr(13) & Chr(10) + "3秒内，生命恢复30%" + Chr(13) & Chr(10) + "消耗魔力：300" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                        m = 10 * g
                        Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "回血中，生命+" + m + "/秒，持续3秒" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                    Else

                        Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "魔力不足！无法施展技能" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                    End If
                End If
            End If



            If e.KeyCode = Keys.I Then
                If Label36.Text = "1" Then
                    If Timer1.Enabled = False Then
                        Timer2.Enabled = True
                    End If
                Else
                    Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "嘎嘎！你还没隐身，何来现身！" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                End If
            End If



            If e.KeyCode = Keys.A Then
                c = PictureBox1.Location.X
                d = PictureBox4.Location.X + 200
                If d < c Then

                    If Label6.Text = "1" Then
                        a = PictureBox1.Location.X - 30
                        b = PictureBox1.Location.Y
                        If a > 2 Then
                            PictureBox1.Location = New System.Drawing.Point(a, b)
                        Else
                            a = PictureBox1.Location.X + 40
                            b = PictureBox1.Location.Y
                            PictureBox1.Location = New System.Drawing.Point(a, b)
                        End If
                    End If
                    If Label6.Text = "0" Then
                        a = PictureBox1.Location.X - 10
                        b = PictureBox1.Location.Y
                        If a > 2 Then
                            PictureBox1.Location = New System.Drawing.Point(a, b)
                        Else
                            a = PictureBox1.Location.X + 20
                            b = PictureBox1.Location.Y
                            PictureBox1.Location = New System.Drawing.Point(a, b)
                        End If
                    End If
                End If
            End If



            If e.KeyCode = Keys.D Then
                If Label6.Text = "0" Then
                    a = PictureBox1.Location.X + 10
                    b = PictureBox1.Location.Y
                    If a < 805 Then
                        PictureBox1.Location = New System.Drawing.Point(a, b)
                    Else
                        a = 804
                        b = PictureBox1.Location.Y
                        PictureBox1.Location = New System.Drawing.Point(a, b)
                    End If
                End If
                If Label6.Text = "1" Then
                    a = PictureBox1.Location.X + 30
                    b = PictureBox1.Location.Y
                    If a < 732 Then
                        PictureBox1.Location = New System.Drawing.Point(a, b)
                    Else
                        a = PictureBox1.Location.X - 40
                        b = PictureBox1.Location.Y
                        PictureBox1.Location = New System.Drawing.Point(a, b)
                    End If
                End If
            End If



            If e.KeyCode = Keys.W Then
                If Timer4.Enabled = False Then
                    Timer3.Enabled = True
                End If
            End If



            If e.KeyCode = Keys.J Then
                If Label36.Text = "0" Then
                    If Timer5.Enabled = False Then
                        PictureBox1.BackgroundImage = PictureBox2.BackgroundImage

                        Timer5.Enabled = True
                        If Label11.Text < 1000 Then
                            If Timer6.Enabled = False Then
                                Label11.Text = Label11.Text + 10
                                ProgressBar3.Value = Label11.Text
                            End If
                        End If
                        c = PictureBox1.Location.X
                        d = PictureBox4.Location.X + 215
                        If d > c Then
                            Dim shuji As Integer = CInt(Int((100 - 0 + 1) * Rnd() + 0))
                            If shuji < Form6.Label9.Text Then
                                gongji = Label34.Text * 1.5
                                Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "爆头一击" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                            Else
                                gongji = Label34.Text
                            End If
                            c = PictureBox4.Location.X + 100
                            d = PictureBox4.Location.Y - Label10.Height
                            Label10.Location = New System.Drawing.Point(c, d)
                            Label10.Visible = True
                            gongji2 = gongji
                            Label10.Text = "-" + gongji2
                            Timer14.Enabled = True
                            If Label16.Text - gongji > 0 Then
                                Label16.Text = Label16.Text - gongji
                                ProgressBar5.Value = Label16.Text

                            Else

                                Timer7.Enabled = False
                                a = -100
                                b = PictureBox4.Location.Y
                                PictureBox4.Location = New System.Drawing.Point(a, b)
                                f = Label21.Text * 100
                                Label13.Text = Label13.Text + f
                                If Label13.Text > ProgressBar4.Maximum Then
                                    Label13.Text = Label13.Text - Label23.Text
                                    Label8.Text = ProgressBar1.Maximum + 300
                                    ProgressBar1.Maximum = ProgressBar1.Maximum + 300
                                    ProgressBar1.Value = Label8.Text
                                    Label28.Text = Label8.Text
                                    Label9.Text = ProgressBar2.Maximum + 100
                                    ProgressBar2.Maximum = ProgressBar2.Maximum + 100
                                    ProgressBar2.Value = Label9.Text
                                    Label29.Text = Label9.Text
                                    Label18.Text = Label18.Text + 1
                                    ProgressBar4.Maximum = ProgressBar4.Maximum + 2000
                                    ProgressBar4.Value = Label13.Text
                                    Label23.Text = ProgressBar4.Maximum
                                    Label34.Text = Label34.Text + 100
                                    Label44.Text = Label44.Text + 100

                                    Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "恭喜你，升级！当前为" + Label18.Text + "级！" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                                End If
                                ProgressBar4.Value = Label13.Text
                                Label16.Text = ProgressBar5.Maximum + 500
                                Label32.Text = Label16.Text
                                ProgressBar5.Maximum = ProgressBar5.Maximum + 500
                                ProgressBar5.Value = Label16.Text
                                Label21.Text = Label21.Text + 1
                                Label38.Text = Label21.Text * 2
                                Label58.Text = Label58.Text + Label21.Text * 100
                                Timer7.Enabled = True
                                If Label9.Text + 200 < ProgressBar2.Maximum Then
                                    Label9.Text = Label9.Text + 200
                                    ProgressBar2.Value = Label9.Text
                                Else
                                    Label9.Text = ProgressBar2.Maximum
                                    ProgressBar2.Value = Label9.Text
                                End If
                                i3 = f
                                Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "怪物已死亡." + Chr(13) & Chr(10) + "获得经验：" + i3 + Chr(13) & Chr(10) + "下一个怪物：" + Label21.Text + "级" + Chr(13) & Chr(10) + Chr(13) & Chr(10)

                                Timer16.Enabled = True

                            End If
                        End If
                    End If
                End If
            End If

            If e.KeyCode = Keys.Y Then

                If Timer3.Enabled = False Then
                    If Timer4.Enabled = False Then

                        If Label11.Text > 900 Then
                            Label6.Text = "1"
                            Timer5.Interval = 100
                            Timer6.Enabled = True
                            Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "技能：超级暴走" + Chr(13) & Chr(10) + "移动速度+200%" + Chr(13) & Chr(10) + "攻击速度+100%" + Chr(13) & Chr(10) + "消耗怒气：1000" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                            Label40.Text = "0.1S"
                        Else
                            Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "提示：怒气不足" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                        End If
                    End If
                End If
            End If

            
          
            If e.KeyCode = Keys.O Then
                Label24_Click(sender, e)
            End If
            If e.KeyCode = Keys.B Then
                Label60.Text = "继续（P）"
                Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "游戏已暂停" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                Form4.Show()
            End If
            If e.KeyCode = Keys.K Then
                If Timer12.Enabled = False Then

                    If Label9.Text - 200 > 0 Then
                        a = PictureBox1.Location.X - 133
                        b = PictureBox1.Location.Y + 100
                        PictureBox7.Location = New System.Drawing.Point(a, b)
                        PictureBox7.Visible = True
                        Timer12.Enabled = True
                        Label9.Text = Label9.Text - 200
                        ProgressBar2.Value = Label9.Text
                        Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "技能：火球术" + Chr(13) & Chr(10) + "伤害：魔力*3" + Chr(13) & Chr(10) + "消耗魔力：200" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                    Else
                        Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "魔力不足！无法施展技能" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                    End If
                End If
            End If

            If e.KeyCode = Keys.L Then
                If Timer13.Enabled = False Then

                    If Label9.Text - 300 > 0 Then
                        a = PictureBox1.Location.X - 133
                        b = PictureBox1.Location.Y + 150
                        PictureBox8.Location = New System.Drawing.Point(a, b)
                        PictureBox8.Visible = True
                        Timer13.Enabled = True
                        Label9.Text = Label9.Text - 300
                        ProgressBar2.Value = Label9.Text
                        Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "技能：召唤术" + Chr(13) & Chr(10) + "召唤超级火柴人" + Chr(13) & Chr(10) + "伤害：魔力*5" + Chr(13) & Chr(10) + "消耗魔力：300" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                    Else
                        Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "魔力不足！无法施展技能" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                    End If
                End If
            End If
        End If
        If e.KeyCode = Keys.P Then
            If Label60.Text = "暂停（P）" Then
                Label60.Text = "继续（P）"
                Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "游戏已暂停" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
            Else
                Label60.Text = "暂停（P）"
                Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "游戏已继续" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            End
        End If
        If e.KeyCode = Keys.F6 Then
            If Me.Visible = True Then
                Me.Visible = False
                Form9.Visible = False
                Form10.Show()
                Label60.Text = "继续（P）"
                Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "游戏已暂停" + Chr(13) & Chr(10) + Chr(13) & Chr(10)

            End If
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer17.Enabled = True
        Form9.Timer1.Enabled = True
        Form9.Show()
        Dim g1 As Integer = Me.Location.X - 100
        Dim g2 As Integer = Me.Location.Y
        Me.Location = New System.Drawing.Point(g1, g2)
        g1 = Me.Location.X + Me.Width
        g2 = Me.Location.Y
        Form9.Location = New System.Drawing.Point(g1, g2)

        Timer7.Enabled = True


        ProgressBar1.Maximum = Label28.Text
        ProgressBar2.Maximum = Label29.Text
        ProgressBar5.Maximum = Label32.Text
        ProgressBar4.Maximum = Label23.Text
        ProgressBar1.Value = Label8.Text
        ProgressBar2.Value = Label9.Text
        ProgressBar3.Value = Label11.Text
        ProgressBar4.Value = Label13.Text
        ProgressBar5.Value = Label16.Text
        a3 = Label7.Text

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
            Form4.Label2.Text = dr(0)
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
            Label46.Text = a1 + "%"
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
        cmd.CommandText = "select 售出价格 from 武器 where ID=" & a3
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            a1 = dr(0)
            Form6.Label20.Text = a1
        End If

        dr.Close()

        con.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label36.Text = "0" Then
            If PictureBox1.Width > 5 Then
                PictureBox1.Width = PictureBox1.Width - 4
            Else
                Timer1.Enabled = False
                Label9.Text = Label9.Text - 500
                ProgressBar2.Value = Label9.Text
                Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "技能：隐身" + Chr(13) & Chr(10) + "隐身时正常恢复魔力" + Chr(13) & Chr(10) + "消耗魔力：500" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                Label36.Text = "1"
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If PictureBox1.Width < 205 Then
            PictureBox1.Width = PictureBox1.Width + 4
        Else
            Timer2.Enabled = False

            Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "技能：现身" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
            Label36.Text = "0"
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If Label4.Text < 10 Then

            a = PictureBox1.Location.X
            b = PictureBox1.Location.Y - 10
            PictureBox1.Location = New System.Drawing.Point(a, b)
            Label4.Text = Label4.Text + 1
        Else
            Timer3.Enabled = False
            Timer4.Enabled = True
        End If


    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        If Label4.Text > 0 Then
            a = PictureBox1.Location.X
            b = PictureBox1.Location.Y + 10
            PictureBox1.Location = New System.Drawing.Point(a, b)
            Label4.Text = Label4.Text - 1
        Else

            Timer4.Enabled = False
        End If

    End Sub



    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        PictureBox1.BackgroundImage = PictureBox3.BackgroundImage
        Timer5.Enabled = False

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        Form2.Show()
    End Sub




    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles Label5.Click
        Timer17.Enabled = False
        TextBox1.Text = Label18.Text + Chr(13) & Chr(10) + Label8.Text + Chr(13) & Chr(10) + Label9.Text + Chr(13) & Chr(10) + Label11.Text + Chr(13) & Chr(10) + Label13.Text + Chr(13) & Chr(10) + Label23.Text + Chr(13) & Chr(10) + Label21.Text + Chr(13) & Chr(10) + Label28.Text + Chr(13) & Chr(10) + Label29.Text + Chr(13) & Chr(10) + Label16.Text + Chr(13) & Chr(10) + Label32.Text + Chr(13) & Chr(10) + Label58.Text + Chr(13) & Chr(10) + Label34.Text + Chr(13) & Chr(10) + Form11.Label2.Text + Chr(13) & Chr(10) + Label7.Text + Chr(13) & Chr(10) + Form4.TextBox1.Text + Chr(13) & Chr(10) + Label44.Text + Chr(13) & Chr(10)
        ' 等级，生命，魔力，怒气,经验，经验上限，怪物等级，生命上限，魔力上限，怪物生命，怪物生命上限,金钱,攻击，魔法攻击
        Dim mytxt, msgtxt As String
        mytxt = TextBox1.Text
        msgtxt = mySHA(mytxt)
        TextBox1.Text = TextBox1.Text + msgtxt
        Dim Sw As StreamWriter = File.CreateText(Application.StartupPath + "\存档LV." + Label18.Text + "(退出时保存).crz")
        'MsgBox(Application.StartupPath + "\存档" + vvv + ".crz")
        '’ Sw.WriteLine("插入一行字符 "
        Sw.Write(TextBox1.Text)
        Sw.Close()


        Form3.Show()
        Form9.Close()
        Me.Close()
    End Sub


    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        If Label60.Text = "暂停（P）" Then
            Label11.Text = Label11.Text - 10
            ProgressBar3.Value = Label11.Text
            If Label11.Text < 10 Then
                Label6.Text = "0"
                Timer5.Interval = 200
                Timer6.Enabled = False
                Label40.Text = "0.2S"
                Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "技能：超级暴走 施展完毕！" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
            End If
        End If

    End Sub




    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Label60.Text = "继续（P）"
        Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "游戏已暂停" + Chr(13) & Chr(10) + Chr(13) & Chr(10)


        Dim mystr() As String = Form4.TextBox1.Text.Split("."c)

        Form4.Label1.Text = CStr((Form4.TextBox1.Text.Split(".").Length - 1))
        If Form4.Label1.Text > 0 Then
            Form4.ListBox1.Items.Clear()
            a2 = Form4.ListBox1.SelectedIndex
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
            c = Form4.Label1.Text
            For Me.ii = 1 To c
                cmd.CommandText = "select 名称 from 武器 where ID=" & mystr(ii)
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    Form4.ListBox1.Items.Add(dr(0))
                End If
                dr.Close()
            Next

            con.Close()
        Else
            Form4.ListBox1.Items.Clear()

        End If
        Form4.Show()
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        If Me.Visible = True Then
            If Label60.Text = "暂停（P）" Then
                If Label36.Text = "0" Then
                    c = PictureBox1.Location.X
                    d = PictureBox4.Location.X + 200

                    If d < c Then
                        a = PictureBox4.Location.X + 5
                        b = PictureBox4.Location.Y
                        PictureBox4.Location = New System.Drawing.Point(a, b)
                    Else
                        a = PictureBox1.Location.X + 5
                        b = PictureBox1.Location.Y
                        PictureBox1.Location = New System.Drawing.Point(a, b)
                        c = PictureBox1.Location.X + 100
                        d = PictureBox1.Location.Y - Label12.Height
                        Label12.Location = New System.Drawing.Point(c, d)
                        Label12.Visible = True
                        gongji3 = Label21.Text * 2
                        Label12.Text = "-" + gongji3
                        Timer15.Enabled = True
                        If Label8.Text - Label21.Text * 2 > 0 Then
                            Label8.Text = Label8.Text - Label21.Text * 2
                            ProgressBar1.Value = Label8.Text
                            PictureBox4.BackgroundImage = PictureBox5.BackgroundImage
                            Timer11.Enabled = True
                        Else
                            Label8.Text = 0
                            ProgressBar1.Value = 0
                            Timer7.Enabled = False
                            Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "你悲哀了！" + Chr(13) & Chr(10) + "你已经死亡了，立刻复活" + Chr(13) & Chr(10) + "复活花费：50%金钱" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                            Label58.Text = Label58.Text / 2
                            Label8.Text = Label28.Text
                            Label9.Text = Label29.Text
                            ProgressBar1.Value = Label8.Text
                            ProgressBar2.Value = Label9.Text
                            Label13.Text = 0
                            ProgressBar4.Value = Label13.Text
                            Label11.Text = 0
                            ProgressBar3.Value = Label11.Text
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

        TextBox1.Text = Label18.Text + Chr(13) & Chr(10) + Label8.Text + Chr(13) & Chr(10) + Label9.Text + Chr(13) & Chr(10) + Label11.Text + Chr(13) & Chr(10) + Label13.Text + Chr(13) & Chr(10) + Label23.Text + Chr(13) & Chr(10) + Label21.Text + Chr(13) & Chr(10) + Label28.Text + Chr(13) & Chr(10) + Label29.Text + Chr(13) & Chr(10) + Label16.Text + Chr(13) & Chr(10) + Label32.Text + Chr(13) & Chr(10) + Label58.Text + Chr(13) & Chr(10) + Label34.Text + Chr(13) & Chr(10) + Form11.Label2.Text + Chr(13) & Chr(10) + Label7.Text + Chr(13) & Chr(10) + Form4.TextBox1.Text + Chr(13) & Chr(10) + Label44.Text + Chr(13) & Chr(10)
        ' 等级，生命，魔力，怒气,经验，经验上限，怪物等级，生命上限，魔力上限，怪物生命，怪物生命上限,金钱,攻击，魔法攻击
        Dim mytxt, msgtxt As String
        mytxt = TextBox1.Text
        msgtxt = mySHA(mytxt)
        TextBox1.Text = TextBox1.Text + msgtxt

        If IO.File.Exists(Application.StartupPath + "\存档LV." + Label18.Text + ".crz") Then
            Dim Sw As StreamWriter = File.CreateText(Application.StartupPath + "\存档LV." + Label18.Text + "(2).crz")
            'MsgBox(Application.StartupPath + "\存档" + vvv + ".crz")
            '’ Sw.WriteLine("插入一行字符 "
            Sw.Write(TextBox1.Text)
            Sw.Close()

            Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "存档成功" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
            Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "存档：" + Chr(13) & Chr(10) + Application.StartupPath + "\存档LV." + Label18.Text + "(2).crz" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
        Else
            Dim Sw As StreamWriter = File.CreateText(Application.StartupPath + "\存档LV." + Label18.Text + ".crz")
            'MsgBox(Application.StartupPath + "\存档" + vvv + ".crz")
            '’ Sw.WriteLine("插入一行字符 "
            Sw.Write(TextBox1.Text)
            Sw.Close()

            Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "存档成功" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
            Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "存档：" + Chr(13) & Chr(10) + Application.StartupPath + "\存档LV." + Label18.Text + ".crz" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
        End If



       
        'SaveFileDialog1.FileName


    End Sub
    Function mySHA(ByVal SourceStr As String) As String 'SHA1加密算法
        Dim SHA As New System.Security.Cryptography.SHA1CryptoServiceProvider 'sha1加密
        'Dim sha As New System.Security.Cryptography.SHA256Managed'sha256加密
        'Dim sha As New System.Security.Cryptography.SHA512Managed 'sha512加密
        Dim bytValue() As Byte '输入
        Dim bytHash() As Byte '输出
        bytValue = System.Text.Encoding.UTF8.GetBytes(SourceStr) '输入字符转为byte
        bytHash = SHA.ComputeHash(bytValue) '加密
        SHA.Clear()
        mySHA = Convert.ToBase64String(bytHash) '转为字符
    End Function



    Private Sub Label39_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        If Label60.Text = "暂停（P）" Then
            If ProgressBar2.Value < ProgressBar2.Maximum Then
                q = Label52.Text
                Label9.Text = Label9.Text + q
                ProgressBar2.Value = Label9.Text
            End If
        End If
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        If Label60.Text = "暂停（P）" Then
            If Label54.Text < 31 Then
                m = 10 * g
                If Label8.Text + g < ProgressBar1.Maximum Then
                    Label8.Text = Label8.Text + g
                    ProgressBar1.Value = Label8.Text
                Else
                    Label8.Text = ProgressBar1.Maximum
                    ProgressBar1.Value = Label8.Text
                End If
                Label54.Text = Label54.Text + 1
            Else
                Timer10.Enabled = False
                Label54.Text = "0"
                Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "回血完毕" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
            End If
        End If
    End Sub

    Private Sub Label60_Click(sender As Object, e As EventArgs) Handles Label60.Click
        If Label60.Text = "暂停（P）" Then
            Label60.Text = "继续（P）"
            Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "游戏已暂停" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
        Else
            Label60.Text = "暂停（P）"
            Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "游戏已继续" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
        End If
    End Sub



    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        PictureBox4.BackgroundImage = PictureBox6.BackgroundImage
        Timer11.Enabled = False
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label60.Text = "继续（P）"
        Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "游戏已暂停" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
        Form8.Show()

    End Sub

    Private Sub Label59_Click(sender As Object, e As EventArgs) Handles Label59.Click
        Label60.Text = "继续（P）"
        Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "游戏已暂停" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
        Form5.Show()
    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click

    End Sub

    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        a = PictureBox7.Location.X - 10
        b = PictureBox7.Location.Y
        PictureBox7.Location = New System.Drawing.Point(a, b)
        If a < PictureBox4.Location.X + PictureBox4.Width Then
            a = PictureBox4.Location.X - 50
            b = PictureBox4.Location.Y
            PictureBox4.Location = New System.Drawing.Point(a, b)
            If Label11.Text < 900 Then
                If Timer6.Enabled = False Then
                    Label11.Text = Label11.Text + 100
                    ProgressBar3.Value = Label11.Text
                End If
            Else
                Label11.Text = 1000
                ProgressBar3.Value = Label11.Text
            End If
            Dim shuji As Integer = CInt(Int((100 - 0 + 1) * Rnd() + 0))
            If shuji < Form6.Label9.Text Then
                gongji = Label44.Text * 1.5 * 3
                Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "爆头一击" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
            Else


                gongji = Label44.Text * 3

            End If
            c = PictureBox4.Location.X + 100
            d = PictureBox4.Location.Y - Label10.Height
            Label10.Location = New System.Drawing.Point(c, d)
            Label10.Visible = True
            gongji2 = gongji
            Label10.Text = "-" + gongji2
            Timer14.Enabled = True
            If Label16.Text - gongji > 0 Then
                Label16.Text = Label16.Text - gongji
                ProgressBar5.Value = Label16.Text

                Timer12.Enabled = False
                PictureBox7.Visible = False
            Else

                Timer7.Enabled = False
                a = -100
                b = PictureBox4.Location.Y
                PictureBox4.Location = New System.Drawing.Point(a, b)
                f = Label21.Text * 100
                Label13.Text = Label13.Text + f
                If Label13.Text > ProgressBar4.Maximum Then
                    Label13.Text = Label13.Text - Label23.Text
                    Label8.Text = ProgressBar1.Maximum + 300
                    ProgressBar1.Maximum = ProgressBar1.Maximum + 300
                    ProgressBar1.Value = Label8.Text
                    Label28.Text = Label8.Text
                    Label9.Text = ProgressBar2.Maximum + 100
                    ProgressBar2.Maximum = ProgressBar2.Maximum + 100
                    ProgressBar2.Value = Label9.Text
                    Label29.Text = Label9.Text
                    Label18.Text = Label18.Text + 1
                    ProgressBar4.Maximum = ProgressBar4.Maximum + 2000
                    ProgressBar4.Value = Label13.Text
                    Label23.Text = ProgressBar4.Maximum
                    Label34.Text = Label34.Text + 100
                    Label44.Text = Label44.Text + 100

                    Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "恭喜你，升级！当前为" + Label18.Text + "级" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                End If
                ProgressBar4.Value = Label13.Text
                Label16.Text = ProgressBar5.Maximum + 500
                Label32.Text = Label16.Text
                ProgressBar5.Maximum = ProgressBar5.Maximum + 500
                ProgressBar5.Value = Label16.Text
                Label21.Text = Label21.Text + 1
                Label38.Text = Label21.Text * 2

                Label58.Text = Label58.Text + Label21.Text * 100
                Timer7.Enabled = True
                If Label9.Text + 200 < ProgressBar2.Maximum Then
                    Label9.Text = Label9.Text + 200
                    ProgressBar2.Value = Label9.Text
                Else
                    Label9.Text = ProgressBar2.Maximum
                    ProgressBar2.Value = Label9.Text
                End If
                i3 = f
                Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "怪物已死亡." + Chr(13) & Chr(10) + "获得经验：" + i3 + Chr(13) & Chr(10) + "下一个怪物：" + Label21.Text + "级" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                Timer12.Enabled = False
                PictureBox7.Visible = False
                Timer16.Enabled = True
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer13_Tick(sender As Object, e As EventArgs) Handles Timer13.Tick
        PictureBox8.Enabled = True
        a = PictureBox8.Location.X - 5
        b = PictureBox8.Location.Y
        PictureBox8.Location = New System.Drawing.Point(a, b)
        If a < PictureBox4.Location.X + PictureBox4.Width Then
            a = PictureBox4.Location.X - 50
            b = PictureBox4.Location.Y
            PictureBox4.Location = New System.Drawing.Point(a, b)
            If Label11.Text < 900 Then
                If Timer6.Enabled = False Then
                    Label11.Text = Label11.Text + 100
                    ProgressBar3.Value = Label11.Text
                End If
            Else
                Label11.Text = 1000
                ProgressBar3.Value = Label11.Text
            End If
            Dim shuji As Integer = CInt(Int((100 - 0 + 1) * Rnd() + 0))
            If shuji < Form6.Label9.Text Then
                gongji = Label44.Text * 1.5 * 5
                Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "爆头一击" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
            Else

                gongji = Label44.Text * 5
            End If
            c = PictureBox4.Location.X + 100
            d = PictureBox4.Location.Y - Label10.Height
            Label10.Location = New System.Drawing.Point(c, d)
            Label10.Visible = True
            gongji2 = gongji
            Label10.Text = "-" + gongji2
            Timer14.Enabled = True
            If Label16.Text - gongji > 0 Then
                Label16.Text = Label16.Text - gongji
                ProgressBar5.Value = Label16.Text

                Timer13.Enabled = False
                PictureBox8.Visible = False
            Else
                Timer7.Enabled = False
                a = -100
                b = PictureBox4.Location.Y
                PictureBox4.Location = New System.Drawing.Point(a, b)
                f = Label21.Text * 100
                Label13.Text = Label13.Text + f
                If Label13.Text > ProgressBar4.Maximum Then
                    Label13.Text = Label13.Text - Label23.Text
                    Label8.Text = ProgressBar1.Maximum + 300
                    ProgressBar1.Maximum = ProgressBar1.Maximum + 300
                    ProgressBar1.Value = Label8.Text
                    Label28.Text = Label8.Text
                    Label9.Text = ProgressBar2.Maximum + 100
                    ProgressBar2.Maximum = ProgressBar2.Maximum + 100
                    ProgressBar2.Value = Label9.Text
                    Label29.Text = Label9.Text
                    Label18.Text = Label18.Text + 1
                    ProgressBar4.Maximum = ProgressBar4.Maximum + 2000
                    ProgressBar4.Value = Label13.Text
                    Label23.Text = ProgressBar4.Maximum
                    Label34.Text = Label34.Text + 100
                    Label44.Text = Label44.Text + 100
                    Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "恭喜你，升级！当前为" + Label18.Text + "级" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                End If
                ProgressBar4.Value = Label13.Text
                Label16.Text = ProgressBar5.Maximum + 500
                Label32.Text = Label16.Text
                ProgressBar5.Maximum = ProgressBar5.Maximum + 500
                ProgressBar5.Value = Label16.Text
                Label21.Text = Label21.Text + 1
                Label38.Text = Label21.Text * 2
                Label58.Text = Label58.Text + Label21.Text * 100
                Timer7.Enabled = True
                If Label9.Text + 200 < ProgressBar2.Maximum Then
                    Label9.Text = Label9.Text + 200
                    ProgressBar2.Value = Label9.Text
                Else
                    Label9.Text = ProgressBar2.Maximum
                    ProgressBar2.Value = Label9.Text
                End If
                i3 = f
                Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "怪物已死亡." + Chr(13) & Chr(10) + "获得经验：" + i3 + Chr(13) & Chr(10) + "下一个怪物：" + Label21.Text + "级" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
            End If
            Timer13.Enabled = False
            PictureBox8.Visible = False
            Timer16.Enabled = True
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Timer14_Tick(sender As Object, e As EventArgs) Handles Timer14.Tick
        If Label14.Text < 10 Then
            a = Label10.Location.X
            b = Label10.Location.Y - 5
            Label10.Location = New System.Drawing.Point(a, b)
            Label14.Text = Label14.Text + 1
        Else
            Label10.Visible = False
            Label14.Text = "0"
            Timer14.Enabled = False

        End If


    End Sub

    Private Sub Timer15_Tick(sender As Object, e As EventArgs) Handles Timer15.Tick
        If Label17.Text < 10 Then
            a = Label12.Location.X
            b = Label12.Location.Y - 5
            Label12.Location = New System.Drawing.Point(a, b)
            Label17.Text = Label17.Text + 1
        Else
            Label12.Visible = False
            Label17.Text = "0"
            Timer15.Enabled = False

        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label7_ContextMenuStripChanged(sender As Object, e As EventArgs) Handles Label7.ContextMenuStripChanged
        a3 = Label7.Text

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
            Form4.Label2.Text = dr(0)
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
            Label46.Text = a1 + "%"
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
        cmd.CommandText = "select 售出价格 from 武器 where ID=" & a3
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            a1 = dr(0)
            Form6.Label20.Text = a1
        End If

        dr.Close()

        con.Close()
    End Sub

   

    Private Sub Timer16_Tick(sender As Object, e As EventArgs) Handles Timer16.Tick
        Dim bao As Integer = CInt(Int((10000 - 0 + 1) * Rnd() + 0))

        If bao > 2210 Then
            Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "嘿嘿！你这次什么都没得到额" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
        Else

            If 2205 < bao Then
                Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "恭喜你！得到了异界刷钱棒" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                Form4.TextBox1.Text = Form4.TextBox1.Text + ".12"
            Else

                If 2200 < bao Then
                    Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "恭喜你！得到了圣·九龙钻石棒" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                    Form4.TextBox1.Text = Form4.TextBox1.Text + ".11"
                Else

                    If 2170 < bao Then
                        Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "恭喜你！得到了真·极道神棍" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                        Form4.TextBox1.Text = Form4.TextBox1.Text + ".10"
                    Else

                        If 2130 < bao Then
                            Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "恭喜你！得到了仙爷开G装B棍" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                            Form4.TextBox1.Text = Form4.TextBox1.Text + ".9"
                        Else

                            If 2100 < bao Then
                                Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "恭喜你！得到了激光明棒" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                                Form4.TextBox1.Text = Form4.TextBox1.Text + ".8"
                            Else

                                If 2050 < bao Then
                                    Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "恭喜你！得到了良佬春棒" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                                    Form4.TextBox1.Text = Form4.TextBox1.Text + ".7"
                                Else

                                    If 1980 < bao Then
                                        Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "恭喜你！得到了坚爷仙狗棒" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                                        Form4.TextBox1.Text = Form4.TextBox1.Text + ".6"
                                    Else

                                        If 1900 < bao Then
                                            Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "恭喜你！得到了镇天魔棒" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                                            Form4.TextBox1.Text = Form4.TextBox1.Text + ".5"
                                        Else


                                            If 1600 < bao Then
                                                Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "恭喜你！得到了辉哥无影棒" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                                                Form4.TextBox1.Text = Form4.TextBox1.Text + ".3"
                                            Else
                                                If 1800 < bao Then
                                                    Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "恭喜你！得到了肥龙巨棒" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                                                    Form4.TextBox1.Text = Form4.TextBox1.Text + ".4"
                                                Else

                                                    If 1000 < bao Then
                                                        Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "恭喜你！得到了莹姐的搞屎棍" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                                                        Form4.TextBox1.Text = Form4.TextBox1.Text + ".2"
                                                    Else

                                                        If -1 < bao Then
                                                            Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "恭喜你！得到了坚爷的木棍" + Chr(13) & Chr(10) + Chr(13) & Chr(10)
                                                            Form4.TextBox1.Text = Form4.TextBox1.Text + ".1"
                                                        End If
                                                    End If
                                                End If

                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Timer16.Enabled = False
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim g1 As Integer = Me.Location.X + Me.Width
        Dim g2 As Integer = Me.Location.Y
        Form9.Location = New System.Drawing.Point(g1, g2)
    End Sub


    Private Sub Timer17_Tick(sender As Object, e As EventArgs) Handles Timer17.Tick
        TextBox1.Text = Label18.Text + Chr(13) & Chr(10) + Label8.Text + Chr(13) & Chr(10) + Label9.Text + Chr(13) & Chr(10) + Label11.Text + Chr(13) & Chr(10) + Label13.Text + Chr(13) & Chr(10) + Label23.Text + Chr(13) & Chr(10) + Label21.Text + Chr(13) & Chr(10) + Label28.Text + Chr(13) & Chr(10) + Label29.Text + Chr(13) & Chr(10) + Label16.Text + Chr(13) & Chr(10) + Label32.Text + Chr(13) & Chr(10) + Label58.Text + Chr(13) & Chr(10) + Label34.Text + Chr(13) & Chr(10) + Form11.Label2.Text + Chr(13) & Chr(10) + Label7.Text + Chr(13) & Chr(10) + Form4.TextBox1.Text + Chr(13) & Chr(10) + Label44.Text + Chr(13) & Chr(10)
        ' 等级，生命，魔力，怒气,经验，经验上限，怪物等级，生命上限，魔力上限，怪物生命，怪物生命上限,金钱,攻击，魔法攻击
        Dim mytxt, msgtxt As String
        mytxt = TextBox1.Text
        msgtxt = mySHA(mytxt)
        TextBox1.Text = TextBox1.Text + msgtxt
        Dim Sw As StreamWriter = File.CreateText(Application.StartupPath + "\存档LV." + Label18.Text + "(自动保存).crz")
        'MsgBox(Application.StartupPath + "\存档" + vvv + ".crz")
        '’ Sw.WriteLine("插入一行字符 "
        Sw.Write(TextBox1.Text)
        Sw.Close()
    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click

    End Sub
End Class
