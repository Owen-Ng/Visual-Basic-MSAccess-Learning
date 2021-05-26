<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usersinfo
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbtennis = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbswimming = New System.Windows.Forms.Label()
        Me.Update = New System.Windows.Forms.Button()
        Me.refresh = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(44, 127)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(668, 289)
        Me.DataGridView1.TabIndex = 0
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(90, 44)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(45, 17)
        Me.Label.TabIndex = 1
        Me.Label.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(183, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tennis:"
        '
        'lbtennis
        '
        Me.lbtennis.AutoSize = True
        Me.lbtennis.Location = New System.Drawing.Point(277, 44)
        Me.lbtennis.Name = "lbtennis"
        Me.lbtennis.Size = New System.Drawing.Size(51, 17)
        Me.lbtennis.TabIndex = 3
        Me.lbtennis.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(367, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Swmming:"
        '
        'lbswimming
        '
        Me.lbswimming.AutoSize = True
        Me.lbswimming.Location = New System.Drawing.Point(498, 44)
        Me.lbswimming.Name = "lbswimming"
        Me.lbswimming.Size = New System.Drawing.Size(51, 17)
        Me.lbswimming.TabIndex = 5
        Me.lbswimming.Text = "Label4"
        '
        'Update
        '
        Me.Update.Location = New System.Drawing.Point(280, 89)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(75, 23)
        Me.Update.TabIndex = 6
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'refresh
        '
        Me.refresh.Location = New System.Drawing.Point(418, 89)
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(75, 23)
        Me.refresh.TabIndex = 7
        Me.refresh.Text = "refresh"
        Me.refresh.UseVisualStyleBackColor = True
        '
        'usersinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.refresh)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.lbswimming)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbtennis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "usersinfo"
        Me.Text = "usersinfo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbtennis As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbswimming As Label
    Friend WithEvents Update As Button
    Friend WithEvents refresh As Button
End Class
