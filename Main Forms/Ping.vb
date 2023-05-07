Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Text

Public Class Ping
    Private Sub Ping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imagePath As String = Application.StartupPath & "\background_tools.jpg"
        If File.Exists(imagePath) Then
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Me.BackgroundImage = Image.FromFile(imagePath)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get the hostname from the textbox
        Dim hostname As String = TextBox1.Text

        ' Create a new Ping object
        'Dim pingSender As New Ping()
        Dim pingSender As New System.Net.NetworkInformation.Ping()

        ' Set the Ping options
        Dim options As New PingOptions()
        options.DontFragment = True

        ' Create a buffer of 32 bytes of data to be transmitted
        Dim buffer As String = "abcdefghijklmnopqrstuvwxyz123456"
        Dim data As Byte() = Encoding.ASCII.GetBytes(buffer.Substring(0, 32))
        Dim timeout As Integer = 120

        ' Send the Ping request
        Try
            Dim reply As PingReply = pingSender.Send(hostname, timeout, data, options)

            ' Check if the Ping was successful
            If reply.Status = IPStatus.Success Then
                MessageBox.Show("Ping successful. Response time: " & reply.RoundtripTime & "ms", "Ping Report")
            Else
                MessageBox.Show("Ping failed with error: " & reply.Status.ToString(), "Ping Report")
            End If
        Catch ex As PingException
            MessageBox.Show("An exception occurred during the ping request: " & "Invalid IP Address", "Ping Report")
        Catch ex As SocketException
            MessageBox.Show("No such host is known: " & ex.Message, "Ping Report")
        End Try
    End Sub

End Class