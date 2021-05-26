<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.username = New System.Windows.Forms.TextBox()
        Me.viewInfo = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataSet = New usersQuery.dataDataSet()
        Me.Search = New System.Windows.Forms.Button()
        Me.leftarrow = New System.Windows.Forms.Button()
        Me.rightarrow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbname = New System.Windows.Forms.Label()
        Me.lbpassword = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addname = New System.Windows.Forms.TextBox()
        Me.addpassword = New System.Windows.Forms.TextBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.IDbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(37, 123)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(100, 22)
        Me.username.TabIndex = 0
        '
        'viewInfo
        '
        Me.viewInfo.Location = New System.Drawing.Point(303, 122)
        Me.viewInfo.Name = "viewInfo"
        Me.viewInfo.Size = New System.Drawing.Size(125, 23)
        Me.viewInfo.TabIndex = 1
        Me.viewInfo.Text = "View user's info"
        Me.viewInfo.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 320)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(720, 118)
        Me.DataGridView1.TabIndex = 2
        '
        'DataDataSetBindingSource
        '
        Me.DataDataSetBindingSource.DataSource = Me.DataDataSet
        Me.DataDataSetBindingSource.Position = 0
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "dataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(182, 122)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(75, 23)
        Me.Search.TabIndex = 3
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'leftarrow
        '
        Me.leftarrow.Location = New System.Drawing.Point(37, 12)
        Me.leftarrow.Name = "leftarrow"
        Me.leftarrow.Size = New System.Drawing.Size(75, 23)
        Me.leftarrow.TabIndex = 4
        Me.leftarrow.Text = "<"
        Me.leftarrow.UseVisualStyleBackColor = True
        '
        'rightarrow
        '
        Me.rightarrow.Location = New System.Drawing.Point(182, 12)
        Me.rightarrow.Name = "rightarrow"
        Me.rightarrow.Size = New System.Drawing.Size(75, 23)
        Me.rightarrow.TabIndex = 5
        Me.rightarrow.Text = ">"
        Me.rightarrow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID"
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(119, 50)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(51, 17)
        Me.lbID.TabIndex = 7
        Me.lbID.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "name"
        '
        'lbname
        '
        Me.lbname.AutoSize = True
        Me.lbname.Location = New System.Drawing.Point(300, 50)
        Me.lbname.Name = "lbname"
        Me.lbname.Size = New System.Drawing.Size(51, 17)
        Me.lbname.TabIndex = 9
        Me.lbname.Text = "Label4"
        '
        'lbpassword
        '
        Me.lbpassword.AutoSize = True
        Me.lbpassword.Location = New System.Drawing.Point(528, 50)
        Me.lbpassword.Name = "lbpassword"
        Me.lbpassword.Size = New System.Drawing.Size(51, 17)
        Me.lbpassword.TabIndex = 10
        Me.lbpassword.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(417, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(233, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "password"
        '
        'addname
        '
        Me.addname.Location = New System.Drawing.Point(100, 74)
        Me.addname.Name = "addname"
        Me.addname.Size = New System.Drawing.Size(100, 22)
        Me.addname.TabIndex = 14
        '
        'addpassword
        '
        Me.addpassword.Location = New System.Drawing.Point(312, 74)
        Me.addpassword.Name = "addpassword"
        Me.addpassword.Size = New System.Drawing.Size(100, 22)
        Me.addpassword.TabIndex = 15
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(443, 76)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(75, 23)
        Me.Add.TabIndex = 16
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'IDbox
        '
        Me.IDbox.Location = New System.Drawing.Point(122, 151)
        Me.IDbox.Name = "IDbox"
        Me.IDbox.Size = New System.Drawing.Size(100, 22)
        Me.IDbox.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(254, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "ID"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(24, 194)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(720, 120)
        Me.DataGridView2.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 450)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.IDbox)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.addpassword)
        Me.Controls.Add(Me.addname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbpassword)
        Me.Controls.Add(Me.lbname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rightarrow)
        Me.Controls.Add(Me.leftarrow)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.viewInfo)
        Me.Controls.Add(Me.username)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents username As TextBox
    Friend WithEvents viewInfo As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataDataSetBindingSource As BindingSource
    Friend WithEvents DataDataSet As dataDataSet
    Friend WithEvents Search As Button
    Friend WithEvents leftarrow As Button
    Friend WithEvents rightarrow As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbname As Label
    Friend WithEvents lbpassword As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents addname As TextBox
    Friend WithEvents addpassword As TextBox
    Friend WithEvents Add As Button
    Friend WithEvents IDbox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView2 As DataGridView
End Class
