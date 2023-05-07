Imports System.IO

Public Class PasswordGenerator
    Private Sub PasswordGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imagePath As String = Application.StartupPath & "\background_tools.jpg"
        If File.Exists(imagePath) Then
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Me.BackgroundImage = Image.FromFile(imagePath)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CopyToClipboardButton.Text = "Copy"
        Dim passwordLength As Integer = 16
        Dim includeUppercase As Boolean = True
        Dim includeNumbers As Boolean = True
        Dim includeSpecialChars As Boolean = True

        Dim passwordChars As String = "abcdefghijklmnopqrstuvwxyz"
        If includeUppercase Then
            passwordChars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        End If
        If includeNumbers Then
            passwordChars += "0123456789"
        End If
        If includeSpecialChars Then
            passwordChars += "!@#$%^&*()_+-={}[]|\:;""<>,.?/~`"
        End If

        Dim password As String = ""
        Dim random As New Random()
        For i As Integer = 0 To passwordLength - 1
            password += passwordChars(random.Next(0, passwordChars.Length))
        Next

        PasswordTextBox.Text = password
    End Sub

    Private Sub CopyToClipboardButton_Click(sender As Object, e As EventArgs) Handles CopyToClipboardButton.Click
        Clipboard.SetText(PasswordTextBox.Text)
        CopyToClipboardButton.Text = "Copied"
    End Sub
End Class