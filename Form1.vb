Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IO.File.Exists(TextBox2.Text) And TextBox1.Text <> "" And TextBox3.Text <> "" Then
            Process.Start("rc4.exe", TextBox1.Text & " " & TextBox2.Text & " " & TextBox3.Text)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TXTlog.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenF.FileName = Nothing
        OpenF.ShowDialog()
        If OpenF.FileName.IndexOf(" ") > -1 Then
            MsgBox("你所選擇的路徑或者檔案名稱出現空格,可能會導致命令行程式無法正常執行")
        End If
        TextBox2.Text = OpenF.FileName
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveF.FileName = Nothing
        SaveF.ShowDialog()
        If SaveF.FileName.IndexOf(" ") > -1 Then
            MsgBox("你所選擇的路徑或者檔案名稱出現空格,可能會導致命令行程式無法正常執行")
        End If
        TextBox3.Text = SaveF.FileName
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Command.ToString <> "" And IO.File.Exists(Command.ToString) Then
            TextBox2.Text = Command.ToString
        End If
        If IO.File.Exists("rc4.exe") = False Then
            MsgBox("找不到'rc4.exe'遺失.請重新下載")
            Close()
        End If
    End Sub
End Class
