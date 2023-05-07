Imports System.IO
Imports QRCoder

Public Class QRCodeGen
    Private Sub QRCodeGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imagePath As String = Application.StartupPath & "\background_tools.jpg"
        If File.Exists(imagePath) Then
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Me.BackgroundImage = Image.FromFile(imagePath)
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = True
        Dim url As String = TextBox1.Text
        Dim qrGenerator As New QRCodeGenerator()
        Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q)
        Dim qrCode As New QRCode(qrCodeData)
        Dim bmp As Bitmap = qrCode.GetGraphic(5)
        PictureBox1.Image = bmp
    End Sub
End Class