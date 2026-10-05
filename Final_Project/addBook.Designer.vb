<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addBook
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
        txtbID = New TextBox()
        txtISBN = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        txtAuthor = New TextBox()
        Label6 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        txtbCategory = New ComboBox()
        txtbTitle = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 29)
        Label1.TabIndex = 1
        Label1.Text = "ADD BOOK"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 15)
        Label2.TabIndex = 2
        Label2.Text = "Book ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 15)
        Label3.TabIndex = 3
        Label3.Text = "Book ISBN"
        ' 
        ' txtbID
        ' 
        txtbID.Location = New Point(22, 78)
        txtbID.Name = "txtbID"
        txtbID.Size = New Size(201, 23)
        txtbID.TabIndex = 0
        ' 
        ' txtISBN
        ' 
        txtISBN.Location = New Point(22, 135)
        txtISBN.Name = "txtISBN"
        txtISBN.Size = New Size(201, 23)
        txtISBN.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 15)
        Label4.TabIndex = 7
        Label4.Text = "Book Category"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 176)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 15)
        Label5.TabIndex = 6
        Label5.Text = "Book Title"
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(22, 313)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(201, 23)
        txtAuthor.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(22, 295)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 15)
        Label6.TabIndex = 10
        Label6.Text = "Book Author"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(22, 365)
        Button1.Name = "Button1"
        Button1.Size = New Size(201, 54)
        Button1.TabIndex = 5
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(22, 430)
        Button2.Name = "Button2"
        Button2.Size = New Size(201, 54)
        Button2.TabIndex = 13
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txtbCategory
        ' 
        txtbCategory.FormattingEnabled = True
        txtbCategory.Location = New Point(22, 251)
        txtbCategory.Name = "txtbCategory"
        txtbCategory.Size = New Size(201, 23)
        txtbCategory.TabIndex = 14
        ' 
        ' txtbTitle
        ' 
        txtbTitle.Location = New Point(22, 194)
        txtbTitle.Name = "txtbTitle"
        txtbTitle.Size = New Size(201, 23)
        txtbTitle.TabIndex = 2
        ' 
        ' addBook
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(244, 496)
        Controls.Add(txtbCategory)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtAuthor)
        Controls.Add(Label6)
        Controls.Add(txtbTitle)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(txtISBN)
        Controls.Add(txtbID)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "addBook"
        Text = "addBook"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbID As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtbCategory As ComboBox
    Friend WithEvents txtbTitle As TextBox
End Class
