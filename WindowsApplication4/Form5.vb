Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Form5
    Dim a As Integer
    Dim a1 As String
    Dim a2 As String
    Dim a3 As String
    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        If ListBox1.SelectedIndex <> -1 Then
            ListBox2.Items.Clear()
            a = ListBox1.SelectedIndex
            a = a + 1
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
                a2 = dr(0)
                ListBox2.Items.Add(dr(0))
            End If
            dr.Close()
            cmd.CommandText = "select 品质 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                ListBox2.Items.Add(dr(0))
            End If
            dr.Close()
            cmd.CommandText = "select 攻击频率 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                ListBox2.Items.Add("攻击频率：" + dr(0))
            End If
            dr.Close()
            cmd.CommandText = "select 攻击力 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                ListBox2.Items.Add("攻击力：" + a1)
            End If
            dr.Close()

            cmd.CommandText = "select 魔力 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                ListBox2.Items.Add("魔力：" + a1)
            End If
            dr.Close()

            cmd.CommandText = "select 暴击 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                ListBox2.Items.Add("暴击率：" + a1 + "%")
            End If
            dr.Close()

            cmd.CommandText = "select 耐久上限 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                ListBox2.Items.Add("耐久：" + a1 + "/" + a1)
            End If
            dr.Close()

            cmd.CommandText = "select 效果 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                TextBox1.Text = dr(0)
            End If
            dr.Close()

            cmd.CommandText = "select 等级 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                ListBox2.Items.Add("等级：" + a1)
            End If
            dr.Close()
            cmd.CommandText = "select 价格 from 武器 where ID=" & a
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a1 = dr(0)
                If a1 = "0" Then
                    ListBox2.Items.Add("这东东太厉害了，冇得卖")
                Else
                    ListBox2.Items.Add("价格：" + a1)
                End If

            End If
            dr.Close()
            con.Close()
        End If
        
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Label60.Text = "暂停（P）"
        Form9.TextBox1.Text = Form9.TextBox1.Text + Form9.Label1.Text + Chr(13) & Chr(10) + "游戏已继续" + Chr(13) & Chr(10) + Chr(13) & Chr(10)

        Me.Close()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            If a1 <> "0" Then
            If Form1.Label58.Text - a1 > -1 Then
                If MessageBox.Show("你确定要购买" + a2 + "吗？这会花费你" + a1 + "金币", "提示", MessageBoxButtons.YesNo) = vbNo Then
                    Label1.Text = "你已经取消交易"
                Else
                    MsgBox("购买成功！")
                    Form1.Label58.Text = Form1.Label58.Text - a1
                    a3 = a
                    Form4.TextBox1.Text = Form4.TextBox1.Text + "." + a3
                End If
            Else
                MsgBox("嘿嘿！兄弟，貌似你不够钱额，叫陈荣真帮你充几块真币吧！")
            End If
                Else
            MsgBox("都说没得卖额，自己好好努力打怪兽吧，争取早日爆出来哦")
                End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class