Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header

Public Class Randomizer
    Private itemList As New List(Of String)
    Private Sub Randomizer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim imagePath As String = Application.StartupPath & "\background_tools.jpg"
        If File.Exists(imagePath) Then
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Me.BackgroundImage = Image.FromFile(imagePath)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not String.IsNullOrWhiteSpace(TextBox2.Text) Then
            itemList.Add(TextBox2.Text)
            ComboBox1.Items.Add(TextBox2.Text)
            TextBox2.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If itemList.Count > 0 Then
            Dim randomIndex As Integer = New Random().Next(0, itemList.Count)
            Dim selectedItem As String = itemList(randomIndex)
            MessageBox.Show("The randomly selected item is: " & selectedItem)
        End If
    End Sub
End Class