<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("language")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Other")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.ApplicationS = New System.Windows.Forms.GroupBox()
        Me.KryptonComboBox1 = New Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.KryptonTreeView1 = New Krypton.Toolkit.KryptonTreeView()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CancelB = New System.Windows.Forms.Button()
        Me.SaveB = New System.Windows.Forms.Button()
        Me.Other = New System.Windows.Forms.GroupBox()
        Me.KryptonComboBox2 = New Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        Me.KryptonComboBox3 = New Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        Me.ApplicationS.SuspendLayout()
        CType(Me.KryptonComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.KryptonComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplicationS
        '
        Me.ApplicationS.Controls.Add(Me.KryptonComboBox3)
        Me.ApplicationS.Controls.Add(Me.KryptonLabel3)
        Me.ApplicationS.Controls.Add(Me.KryptonComboBox2)
        Me.ApplicationS.Controls.Add(Me.KryptonLabel2)
        Me.ApplicationS.Controls.Add(Me.KryptonComboBox1)
        Me.ApplicationS.Controls.Add(Me.KryptonLabel1)
        Me.ApplicationS.ForeColor = System.Drawing.Color.Navy
        Me.ApplicationS.Location = New System.Drawing.Point(237, 21)
        Me.ApplicationS.Name = "ApplicationS"
        Me.ApplicationS.Size = New System.Drawing.Size(404, 711)
        Me.ApplicationS.TabIndex = 1
        Me.ApplicationS.TabStop = False
        Me.ApplicationS.Text = "Application"
        '
        'KryptonComboBox1
        '
        Me.KryptonComboBox1.DropDownWidth = 172
        Me.KryptonComboBox1.IntegralHeight = False
        Me.KryptonComboBox1.Location = New System.Drawing.Point(109, 33)
        Me.KryptonComboBox1.Name = "KryptonComboBox1"
        Me.KryptonComboBox1.Size = New System.Drawing.Size(172, 25)
        Me.KryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.KryptonComboBox1.TabIndex = 1
        Me.KryptonComboBox1.Text = "  "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(17, 33)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(86, 24)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Language :"
        '
        'KryptonTreeView1
        '
        Me.KryptonTreeView1.Location = New System.Drawing.Point(5, 12)
        Me.KryptonTreeView1.Name = "KryptonTreeView1"
        TreeNode1.Name = "languageN"
        TreeNode1.Tag = "1"
        TreeNode1.Text = "language"
        TreeNode2.Name = "OtherN"
        TreeNode2.Tag = "2"
        TreeNode2.Text = "Other"
        Me.KryptonTreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Me.KryptonTreeView1.Size = New System.Drawing.Size(226, 310)
        Me.KryptonTreeView1.TabIndex = 3
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(644, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(22, 332)
        Me.VScrollBar1.TabIndex = 24
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CancelB)
        Me.Panel1.Controls.Add(Me.SaveB)
        Me.Panel1.Location = New System.Drawing.Point(-1, 328)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(667, 49)
        Me.Panel1.TabIndex = 2
        '
        'CancelB
        '
        Me.CancelB.BackColor = System.Drawing.Color.White
        Me.CancelB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelB.ForeColor = System.Drawing.Color.Navy
        Me.CancelB.Location = New System.Drawing.Point(366, 6)
        Me.CancelB.Name = "CancelB"
        Me.CancelB.Size = New System.Drawing.Size(132, 35)
        Me.CancelB.TabIndex = 1
        Me.CancelB.Text = "Cancel"
        Me.CancelB.UseVisualStyleBackColor = False
        '
        'SaveB
        '
        Me.SaveB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SaveB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SaveB.Cursor = System.Windows.Forms.Cursors.Default
        Me.SaveB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveB.ForeColor = System.Drawing.Color.Navy
        Me.SaveB.Location = New System.Drawing.Point(504, 6)
        Me.SaveB.Name = "SaveB"
        Me.SaveB.Size = New System.Drawing.Size(132, 35)
        Me.SaveB.TabIndex = 0
        Me.SaveB.Text = "Apply"
        Me.SaveB.UseVisualStyleBackColor = False
        '
        'Other
        '
        Me.Other.Location = New System.Drawing.Point(237, 21)
        Me.Other.Name = "Other"
        Me.Other.Size = New System.Drawing.Size(404, 711)
        Me.Other.TabIndex = 2
        Me.Other.TabStop = False
        Me.Other.Text = "Other"
        '
        'KryptonComboBox2
        '
        Me.KryptonComboBox2.DropDownWidth = 172
        Me.KryptonComboBox2.IntegralHeight = False
        Me.KryptonComboBox2.Location = New System.Drawing.Point(109, 88)
        Me.KryptonComboBox2.Name = "KryptonComboBox2"
        Me.KryptonComboBox2.Size = New System.Drawing.Size(172, 25)
        Me.KryptonComboBox2.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.KryptonComboBox2.TabIndex = 3
        Me.KryptonComboBox2.Text = "  "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(17, 88)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(86, 24)
        Me.KryptonLabel2.TabIndex = 2
        Me.KryptonLabel2.Values.Text = "Language :"
        '
        'KryptonComboBox3
        '
        Me.KryptonComboBox3.DropDownWidth = 172
        Me.KryptonComboBox3.IntegralHeight = False
        Me.KryptonComboBox3.Location = New System.Drawing.Point(109, 150)
        Me.KryptonComboBox3.Name = "KryptonComboBox3"
        Me.KryptonComboBox3.Size = New System.Drawing.Size(172, 25)
        Me.KryptonComboBox3.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.KryptonComboBox3.TabIndex = 5
        Me.KryptonComboBox3.Text = "  "
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(17, 150)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(86, 24)
        Me.KryptonLabel3.TabIndex = 4
        Me.KryptonLabel3.Values.Text = "Language :"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 375)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.KryptonTreeView1)
        Me.Controls.Add(Me.ApplicationS)
        Me.Controls.Add(Me.Other)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ApplicationS.ResumeLayout(False)
        Me.ApplicationS.PerformLayout()
        CType(Me.KryptonComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.KryptonComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ApplicationS As GroupBox
    Friend WithEvents KryptonComboBox1 As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonTreeView1 As Krypton.Toolkit.KryptonTreeView
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CancelB As Button
    Friend WithEvents SaveB As Button
    Friend WithEvents Other As GroupBox
    Friend WithEvents KryptonComboBox3 As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonComboBox2 As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
End Class
