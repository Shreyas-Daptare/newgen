Imports System.IO
Imports System.Security.Cryptography
Public Class hashcalc
    Dim hashAlgorithm As HashAlgorithm
    Private Sub hashcalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imagePath As String = Application.StartupPath & "\background_tools.jpg"
        If File.Exists(imagePath) Then
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Me.BackgroundImage = Image.FromFile(imagePath)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hashAlgorithm = MD5.Create()
        Dim inputBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(TextBox2.Text)
        Dim hashBytes As Byte() = hashAlgorithm.ComputeHash(inputBytes)
        Dim hashString As String = BitConverter.ToString(hashBytes).Replace("-", "")

        MessageBox.Show(hashString, "Hashed String", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        hashAlgorithm = SHA1.Create()
        Dim inputBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(TextBox2.Text)
        Dim hashBytes As Byte() = hashAlgorithm.ComputeHash(inputBytes)
        Dim hashString As String = BitConverter.ToString(hashBytes).Replace("-", "")

        MessageBox.Show(hashString, "Hashed String", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        hashAlgorithm = SHA256.Create()
        Dim inputBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(TextBox2.Text)
        Dim hashBytes As Byte() = hashAlgorithm.ComputeHash(inputBytes)
        Dim hashString As String = BitConverter.ToString(hashBytes).Replace("-", "")

        MessageBox.Show(hashString, "Hashed String", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        hashAlgorithm = SHA512.Create()
        Dim inputBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(TextBox2.Text)
        Dim hashBytes As Byte() = hashAlgorithm.ComputeHash(inputBytes)
        Dim hashString As String = BitConverter.ToString(hashBytes).Replace("-", "")

        MessageBox.Show(hashString, "Hashed String", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class