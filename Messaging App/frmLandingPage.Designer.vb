<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLandingPage
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
        Me.tmrReload = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lvwMyGroups = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Groupname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblGroupCreate = New System.Windows.Forms.Label()
        Me.txtGroupName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCreateGroup = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrReload
        '
        Me.tmrReload.Interval = 1000
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lvwMyGroups, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(794, 465)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'lvwMyGroups
        '
        Me.lvwMyGroups.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwMyGroups.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Groupname})
        Me.lvwMyGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwMyGroups.FullRowSelect = True
        Me.lvwMyGroups.GridLines = True
        Me.lvwMyGroups.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwMyGroups.HideSelection = False
        Me.lvwMyGroups.HotTracking = True
        Me.lvwMyGroups.HoverSelection = True
        Me.lvwMyGroups.Location = New System.Drawing.Point(3, 3)
        Me.lvwMyGroups.MultiSelect = False
        Me.lvwMyGroups.Name = "lvwMyGroups"
        Me.lvwMyGroups.Size = New System.Drawing.Size(788, 366)
        Me.lvwMyGroups.TabIndex = 9
        Me.lvwMyGroups.UseCompatibleStateImageBehavior = False
        Me.lvwMyGroups.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Width = 0
        '
        'Groupname
        '
        Me.Groupname.Text = "MY GROUP/S"
        Me.Groupname.Width = 1000
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblUserID)
        Me.Panel1.Controls.Add(Me.lblGroupCreate)
        Me.Panel1.Controls.Add(Me.txtGroupName)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnCreateGroup)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 375)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(788, 87)
        Me.Panel1.TabIndex = 8
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Location = New System.Drawing.Point(493, 10)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(17, 20)
        Me.lblUserID.TabIndex = 20
        Me.lblUserID.Text = "1"
        Me.lblUserID.Visible = False
        '
        'lblGroupCreate
        '
        Me.lblGroupCreate.AutoSize = True
        Me.lblGroupCreate.Location = New System.Drawing.Point(87, 10)
        Me.lblGroupCreate.Name = "lblGroupCreate"
        Me.lblGroupCreate.Size = New System.Drawing.Size(113, 20)
        Me.lblGroupCreate.TabIndex = 19
        Me.lblGroupCreate.Text = "GROUP NAME"
        '
        'txtGroupName
        '
        Me.txtGroupName.Location = New System.Drawing.Point(86, 33)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Size = New System.Drawing.Size(394, 26)
        Me.txtGroupName.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(9, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'btnCreateGroup
        '
        Me.btnCreateGroup.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCreateGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateGroup.ForeColor = System.Drawing.Color.White
        Me.btnCreateGroup.Location = New System.Drawing.Point(486, 33)
        Me.btnCreateGroup.Name = "btnCreateGroup"
        Me.btnCreateGroup.Size = New System.Drawing.Size(293, 26)
        Me.btnCreateGroup.TabIndex = 17
        Me.btnCreateGroup.Text = "CREATE GROUP"
        Me.btnCreateGroup.UseVisualStyleBackColor = False
        '
        'frmLandingPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(794, 465)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmLandingPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GROUP CHAT"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrReload As System.Windows.Forms.Timer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblGroupCreate As System.Windows.Forms.Label
    Friend WithEvents txtGroupName As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCreateGroup As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lvwMyGroups As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Groupname As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblUserID As System.Windows.Forms.Label
End Class
