<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patrons
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
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(23, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 29)
        Label1.TabIndex = 0
        Label1.Text = "ADD MEMBERSHIP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 1
        Label2.Text = "First Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 15)
        Label3.TabIndex = 2
        Label3.Text = "Middle Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(23, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 15)
        Label4.TabIndex = 3
        Label4.Text = "Last Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(23, 256)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 4
        Label5.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(23, 313)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 15)
        Label6.TabIndex = 5
        Label6.Text = "Contact Number"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(283, 84)
        Label7.Name = "Label7"
        Label7.Size = New Size(171, 15)
        Label7.TabIndex = 6
        Label7.Text = "Valid ID Number (If appilicable)"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(283, 143)
        Label8.Name = "Label8"
        Label8.Size = New Size(159, 15)
        Label8.TabIndex = 7
        Label8.Text = "Valid ID Name (If appilicable)"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(23, 102)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(195, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(23, 161)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(195, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(23, 218)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(195, 23)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(23, 331)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(195, 23)
        TextBox4.TabIndex = 4
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(23, 274)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(195, 23)
        TextBox5.TabIndex = 3
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(283, 161)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(195, 23)
        TextBox6.TabIndex = 6
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(283, 102)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(195, 23)
        TextBox7.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(283, 218)
        Button1.Name = "Button1"
        Button1.Size = New Size(195, 53)
        Button1.TabIndex = 7
        Button1.Text = "Add Member"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(283, 294)
        Button2.Name = "Button2"
        Button2.Size = New Size(195, 53)
        Button2.TabIndex = 16
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Patrons
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(502, 376)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox7)
        Controls.Add(TextBox4)
        Controls.Add(TextBox5)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Patrons"
        Text = "Patrons"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
