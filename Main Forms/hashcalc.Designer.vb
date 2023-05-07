<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hashcalc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(122, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 45)
        Label1.TabIndex = 5
        Label1.Text = "Hash Calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(58, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 30)
        Label2.TabIndex = 12
        Label2.Text = "Enter String"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(212, 130)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(207, 23)
        TextBox2.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(73, 214)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 40)
        Button1.TabIndex = 14
        Button1.Text = "MD5"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(285, 214)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 40)
        Button2.TabIndex = 15
        Button2.Text = "SHA1"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(73, 260)
        Button3.Name = "Button3"
        Button3.Size = New Size(110, 36)
        Button3.TabIndex = 16
        Button3.Text = "SHA256"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(285, 260)
        Button4.Name = "Button4"
        Button4.Size = New Size(119, 36)
        Button4.TabIndex = 17
        Button4.Text = "SHA512"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' hashcalc
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(487, 318)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "hashcalc"
        Text = "hashcalc"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
