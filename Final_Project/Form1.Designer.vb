<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 9.75F)
        Label1.Location = New Point(21, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 16)
        Label1.TabIndex = 5
        Label1.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 9.75F)
        Label2.Location = New Point(21, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 16)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(104, 89)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(269, 23)
        txtEmail.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(104, 122)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(269, 23)
        txtPassword.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(21, 166)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(352, 50)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.MenuHighlight
        Label3.Location = New Point(21, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(352, 22)
        Label3.TabIndex = 0
        Label3.Text = "Welcome To Library Booking System"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(395, 239)
        Controls.Add(Label3)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label

End Class
