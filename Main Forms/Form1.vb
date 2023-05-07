Imports System.IO
Imports System.Windows
Imports System.Diagnostics


Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imagePath As String = Application.StartupPath & "\subbackground.jpg"
        If File.Exists(imagePath) Then
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Me.BackgroundImage = Image.FromFile(imagePath)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim PingForm As New Ping()
        PingForm.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim NsLookupForm As New NsLookup()
        NsLookup.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim QRCodeGenForm As New QRCodeGen()
        QRCodeGen.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim PasswordGeneratorForm As New PasswordGenerator()
        PasswordGenerator.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim BarCodeGen As New BarCodeGen()
        BarCodeGen.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Randomizer As New Randomizer()
        Randomizer.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim Hashcal As New hashcalc()
        Hashcal.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Created by ZINCop on 06-05-2023 [https://www.github.com/Shreyas-Daptare]")
    End Sub


End Class
