<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.ApplicationS.SuspendLayout()
        CType(Me.KryptonComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ApplicationS
        '
        Me.ApplicationS.Controls.Add(Me.KryptonComboBox1)
        Me.ApplicationS.Controls.Add(Me.KryptonLabel1)
        Me.ApplicationS.ForeColor = System.Drawing.Color.Navy
        Me.ApplicationS.Location = New System.Drawing.Point(178, 17)
        Me.ApplicationS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ApplicationS.Name = "ApplicationS"
        Me.ApplicationS.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ApplicationS.Size = New System.Drawing.Size(303, 578)
        Me.ApplicationS.TabIndex = 1
        Me.ApplicationS.TabStop = False
        Me.ApplicationS.Text = "Application"
        '
        'KryptonComboBox1
        '
        Me.KryptonComboBox1.DropDownWidth = 172
        Me.KryptonComboBox1.IntegralHeight = False
        Me.KryptonComboBox1.Location = New System.Drawing.Point(82, 27)
        Me.KryptonComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.KryptonComboBox1.Name = "KryptonComboBox1"
        Me.KryptonComboBox1.Size = New System.Drawing.Size(129, 21)
        Me.KryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.KryptonComboBox1.TabIndex = 1
        Me.KryptonComboBox1.Text = "  "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(13, 27)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(70, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Language :"
        '
        'KryptonTreeView1
        '
        Me.KryptonTreeView1.Location = New System.Drawing.Point(4, 10)
        Me.KryptonTreeView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.KryptonTreeView1.Name = "KryptonTreeView1"
        TreeNode1.Name = "languageN"
        TreeNode1.Tag = "1"
        TreeNode1.Text = "language"
        TreeNode2.Name = "OtherN"
        TreeNode2.Tag = "2"
        TreeNode2.Text = "Other"
        Me.KryptonTreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Me.KryptonTreeView1.Size = New System.Drawing.Size(170, 252)
        Me.KryptonTreeView1.TabIndex = 3
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(483, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(22, 270)
        Me.VScrollBar1.TabIndex = 24
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CancelB)
        Me.Panel1.Controls.Add(Me.SaveB)
        Me.Panel1.Location = New System.Drawing.Point(-1, 266)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 40)
        Me.Panel1.TabIndex = 2
        '
        'CancelB
        '
        Me.CancelB.BackColor = System.Drawing.Color.White
        Me.CancelB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelB.ForeColor = System.Drawing.Color.Navy
        Me.CancelB.Location = New System.Drawing.Point(274, 5)
        Me.CancelB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CancelB.Name = "CancelB"
        Me.CancelB.Size = New System.Drawing.Size(99, 28)
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
        Me.SaveB.Location = New System.Drawing.Point(378, 5)
        Me.SaveB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SaveB.Name = "SaveB"
        Me.SaveB.Size = New System.Drawing.Size(99, 28)
        Me.SaveB.TabIndex = 0
        Me.SaveB.Text = "Apply"
        Me.SaveB.UseVisualStyleBackColor = False
        '
        'Other
        '
        Me.Other.Location = New System.Drawing.Point(178, 17)
        Me.Other.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Other.Name = "Other"
        Me.Other.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Other.Size = New System.Drawing.Size(303, 578)
        Me.Other.TabIndex = 2
        Me.Other.TabStop = False
        Me.Other.Text = "Other"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 305)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.KryptonTreeView1)
        Me.Controls.Add(Me.ApplicationS)
        Me.Controls.Add(Me.Other)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ApplicationS.ResumeLayout(False)
        Me.ApplicationS.PerformLayout()
        CType(Me.KryptonComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
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
End Class
