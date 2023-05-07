Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports Zen.Barcode
Imports Zen

Public Class BarCodeGen
    Private Sub BarCodeGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imagePath As String = Application.StartupPath & "\background_tools.jpg"
        If File.Exists(imagePath) Then
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Me.BackgroundImage = Image.FromFile(imagePath)
        End If
        PictureBox1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = True
        Dim Barcode As Zen.Barcode.Code128BarcodeDraw = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum
        PictureBox1.Image = Barcode.Draw(TextBox2.Text, 150, 3)
    End Sub
End Class