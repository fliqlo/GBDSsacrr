Public Class Form1
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim Pswrd_X As String

        Pswrd_X = "gbds"

        If (PasswordTxt.Text = Pswrd_X) Then
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Password!")
            PasswordTxt.Text = ""
        End If
    End Sub
End Class
