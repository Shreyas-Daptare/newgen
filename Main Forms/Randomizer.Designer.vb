<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Randomizer
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
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(161, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(189, 45)
        Label1.TabIndex = 4
        Label1.Text = "Randomizer"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(236, 188)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(207, 23)
        ComboBox1.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(41, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 30)
        Label3.TabIndex = 10
        Label3.Text = "Current List"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(41, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 30)
        Label2.TabIndex = 11
        Label2.Text = "Add Item"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(161, 145)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(207, 23)
        TextBox2.TabIndex = 12
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Aquamarine
        Button1.Location = New Point(78, 264)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 34)
        Button1.TabIndex = 13
        Button1.Text = "Randomize"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Aquamarine
        Button2.Location = New Point(383, 145)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(89, 24)
        Button2.TabIndex = 14
        Button2.Text = "Add to List"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Randomizer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(518, 337)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Name = "Randomizer"
        Text = "Randomizer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
