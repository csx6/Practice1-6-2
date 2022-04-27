Public Class Form1
    Dim intNum As Integer
    Dim strTemp As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Button1.Text = "モグラ" Then
            If intNum = 2 Then
                strTemp = Button1.Text
                Button1.Text = Button3.Text
                Button3.Text = strTemp
            Else
                strTemp = Button1.Text
                Button1.Text = Button2.Text
                Button2.Text = strTemp
            End If
        End If
        intNum = 1
        'Button4.Text = "前回押したボタンは" & intNum
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "モグラ" Then
            If intNum = 1 Then
                strTemp = Button2.Text
                Button2.Text = Button3.Text
                Button3.Text = strTemp
            Else
                strTemp = Button1.Text
                Button1.Text = Button2.Text
                Button2.Text = strTemp
            End If
        End If
        intNum = 2
        'Button4.Text = "前回押したボタンは" & intNum
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "モグラ" Then
            If intNum = 1 Then
                strTemp = Button2.Text
                Button2.Text = Button3.Text
                Button3.Text = strTemp
            Else
                strTemp = Button1.Text
                Button1.Text = Button3.Text
                Button3.Text = strTemp
            End If
        End If
        intNum = 3
        'Button4.Text = "前回押したボタンは" & intNum
    End Sub


End Class
