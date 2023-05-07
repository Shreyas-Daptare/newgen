Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class NsLookup
    Private Sub NsLookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imagePath As String = Application.StartupPath & "\background_tools.jpg"
        If File.Exists(imagePath) Then
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Me.BackgroundImage = Image.FromFile(imagePath)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hostname As String = TextBox1.Text

        ' Try to resolve the hostname
        Try
            Dim addresses As IPAddress() = Dns.GetHostAddresses(hostname)

            ' Display the IP addresses
            Dim sb As New StringBuilder()
            For Each address As IPAddress In addresses
                sb.AppendLine(address.ToString())
            Next

            MessageBox.Show("NSLookup successful. IP addresses: " & vbCrLf & sb.ToString(), "NSLookup Report")
        Catch ex As SocketException
            MessageBox.Show("No such host is known: ", "NSLookup Report")
        Catch ex As Exception
            MessageBox.Show("An unexpected exception occurred: " & ex.Message, "NSLookup Report")
        End Try
    End Sub
End Class