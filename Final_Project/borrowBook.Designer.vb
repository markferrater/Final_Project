<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class borrowBook
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
        Label11 = New Label()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(22, 19)
        Label11.Name = "Label11"
        Label11.Size = New Size(108, 21)
        Label11.TabIndex = 11
        Label11.Text = "Borrow Book"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(30, 68)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 12
        ' 
        ' borrowBook
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox1)
        Controls.Add(Label11)
        Name = "borrowBook"
        Text = "borrowBook"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
