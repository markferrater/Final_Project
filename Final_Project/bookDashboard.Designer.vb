<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookDashboard
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
        dgvBooks = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lblSB = New Label()
        ComboBox1 = New ComboBox()
        CType(dgvBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(21, 17)
        Label11.Name = "Label11"
        Label11.Size = New Size(99, 21)
        Label11.TabIndex = 11
        Label11.Text = "Book Shelfs"
        ' 
        ' dgvBooks
        ' 
        dgvBooks.AllowUserToAddRows = False
        dgvBooks.AllowUserToDeleteRows = False
        dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBooks.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgvBooks.Location = New Point(21, 73)
        dgvBooks.Name = "dgvBooks"
        dgvBooks.ReadOnly = True
        dgvBooks.Size = New Size(525, 183)
        dgvBooks.TabIndex = 12
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "BookID"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Book Title"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Category"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Status"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "ISBN"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(21, 262)
        Button1.Name = "Button1"
        Button1.Size = New Size(119, 34)
        Button1.TabIndex = 13
        Button1.Text = "Full Details"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(157, 262)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 34)
        Button2.TabIndex = 14
        Button2.Text = "Add Books"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(292, 262)
        Button3.Name = "Button3"
        Button3.Size = New Size(119, 34)
        Button3.TabIndex = 15
        Button3.Text = "Edit Books"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(427, 262)
        Button4.Name = "Button4"
        Button4.Size = New Size(119, 34)
        Button4.TabIndex = 16
        Button4.Text = "Delete Books"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(394, 44)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(152, 23)
        TextBox1.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(280, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 15)
        Label1.TabIndex = 18
        Label1.Text = "Search by:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 20
        Label2.Text = "Filter By:"
        ' 
        ' lblSB
        ' 
        lblSB.AutoSize = True
        lblSB.Location = New Point(338, 47)
        lblSB.Name = "lblSB"
        lblSB.Size = New Size(33, 15)
        lblSB.TabIndex = 21
        lblSB.Text = "Tittle"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AllowDrop = True
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"ID", "Name", "Category"})
        ComboBox1.Location = New Point(79, 44)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 22
        ' 
        ' bookDashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(568, 317)
        Controls.Add(ComboBox1)
        Controls.Add(lblSB)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(dgvBooks)
        Controls.Add(Label11)
        Name = "bookDashboard"
        Text = "bookDashboard"
        CType(dgvBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblSB As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
