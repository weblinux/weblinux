Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton2.Checked = True Then
            WebBrowser1.Navigate("https://www.google.com/#hl=en&output=search&sclient=psy-ab&q=" + TextBox1.Text)
        ElseIf RadioButton3.Checked = True Then
            WebBrowser1.Navigate("http://search.yahoo.com/search;_ylt=AmmNReGYMeDp2RZY8HpeBSybvZx4?p=" + TextBox1.Text)
        Else : WebBrowser1.Navigate("http://www.bing.com/search?q=" + TextBox1.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.GoForward()
    End Sub
End Class
