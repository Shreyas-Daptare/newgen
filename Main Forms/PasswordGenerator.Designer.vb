<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordGenerator
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.CopyToClipboardButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aquamarine
        Me.Button1.Location = New System.Drawing.Point(37, 95)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 34)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Generate Password"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.AccessibleName = ""
        Me.PasswordTextBox.Location = New System.Drawing.Point(221, 102)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(170, 23)
        Me.PasswordTextBox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(66, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 45)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Password Generator"
        '
        'CopyToClipboardButton
        '
        Me.CopyToClipboardButton.BackColor = System.Drawing.Color.Aquamarine
        Me.CopyToClipboardButton.Location = New System.Drawing.Point(257, 130)
        Me.CopyToClipboardButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CopyToClipboardButton.Name = "CopyToClipboardButton"
        Me.CopyToClipboardButton.Size = New System.Drawing.Size(86, 34)
        Me.CopyToClipboardButton.TabIndex = 10
        Me.CopyToClipboardButton.Text = "Copy"
        Me.CopyToClipboardButton.UseVisualStyleBackColor = False
        '
        'PasswordGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 178)
        Me.Controls.Add(Me.CopyToClipboardButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Name = "PasswordGenerator"
        Me.Text = "PasswordGenerator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents CopyToClipboardButton As Button
End Class
