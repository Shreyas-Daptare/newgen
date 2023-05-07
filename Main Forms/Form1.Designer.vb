<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button10 = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 42F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(263, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 74)
        Label1.TabIndex = 0
        Label1.Text = "NewGen"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(287, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(194, 21)
        Label2.TabIndex = 1
        Label2.Text = "A Suite of Essential Utilities"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Cyan
        Button1.Location = New Point(421, 202)
        Button1.Name = "Button1"
        Button1.Size = New Size(130, 45)
        Button1.TabIndex = 2
        Button1.Text = "BarCode Generator"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Cyan
        Button2.Location = New Point(421, 304)
        Button2.Name = "Button2"
        Button2.Size = New Size(130, 45)
        Button2.TabIndex = 3
        Button2.Text = "Randomizer"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Cyan
        Button3.Location = New Point(218, 304)
        Button3.Name = "Button3"
        Button3.Size = New Size(130, 45)
        Button3.TabIndex = 4
        Button3.Text = "Password Generator"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Cyan
        Button4.Location = New Point(611, 304)
        Button4.Name = "Button4"
        Button4.Size = New Size(130, 45)
        Button4.TabIndex = 5
        Button4.Text = "About"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Cyan
        Button6.ForeColor = Color.Black
        Button6.Location = New Point(218, 202)
        Button6.Name = "Button6"
        Button6.Size = New Size(130, 45)
        Button6.TabIndex = 7
        Button6.Text = "QR Code Generator"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Cyan
        Button7.ForeColor = Color.Black
        Button7.Location = New Point(12, 202)
        Button7.Name = "Button7"
        Button7.Size = New Size(130, 45)
        Button7.TabIndex = 8
        Button7.Text = "Ping"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Cyan
        Button8.ForeColor = Color.Black
        Button8.Location = New Point(12, 304)
        Button8.Name = "Button8"
        Button8.Size = New Size(130, 45)
        Button8.TabIndex = 9
        Button8.Text = "NsLookup"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Cyan
        Button10.ForeColor = Color.Black
        Button10.Location = New Point(611, 202)
        Button10.Name = "Button10"
        Button10.Size = New Size(130, 45)
        Button10.TabIndex = 11
        Button10.Text = "Hash Calculator"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(698, 304)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(756, 384)
        Controls.Add(Label3)
        Controls.Add(Button10)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "NewGen"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Label3 As Label
End Class
