<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.tlpmain = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lvwDataView = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Message = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGroupID = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lvwPeople = New System.Windows.Forms.ListView()
        Me.peopleID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.peopleName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAddPeople = New System.Windows.Forms.Button()
        Me.tlpmain.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrReload
        '
        Me.tmrReload.Interval = 1000
        '
        'tlpmain
        '
        Me.tlpmain.ColumnCount = 2
        Me.tlpmain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.tlpmain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpmain.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.tlpmain.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.tlpmain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpmain.Location = New System.Drawing.Point(0, 0)
        Me.tlpmain.Name = "tlpmain"
        Me.tlpmain.RowCount = 1
        Me.tlpmain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpmain.Size = New System.Drawing.Size(894, 465)
        Me.tlpmain.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lvwDataView, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(664, 459)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'lvwDataView
        '
        Me.lvwDataView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwDataView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Username, Me.Message})
        Me.lvwDataView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwDataView.FullRowSelect = True
        Me.lvwDataView.GridLines = True
        Me.lvwDataView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwDataView.HideSelection = False
        Me.lvwDataView.HotTracking = True
        Me.lvwDataView.HoverSelection = True
        Me.lvwDataView.Location = New System.Drawing.Point(3, 3)
        Me.lvwDataView.MultiSelect = False
        Me.lvwDataView.Name = "lvwDataView"
        Me.lvwDataView.Size = New System.Drawing.Size(658, 361)
        Me.lvwDataView.TabIndex = 7
        Me.lvwDataView.UseCompatibleStateImageBehavior = False
        Me.lvwDataView.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Width = 0
        '
        'Username
        '
        Me.Username.Text = "SENDER"
        Me.Username.Width = 200
        '
        'Message
        '
        Me.Message.Text = "GROUP CHAT"
        Me.Message.Width = 900
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblGroupID)
        Me.Panel1.Controls.Add(Me.lblID)
        Me.Panel1.Controls.Add(Me.txtMessage)
        Me.Panel1.Controls.Add(Me.btnSend)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 370)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(658, 86)
        Me.Panel1.TabIndex = 8
        '
        'lblGroupID
        '
        Me.lblGroupID.AutoSize = True
        Me.lblGroupID.Location = New System.Drawing.Point(623, 58)
        Me.lblGroupID.Name = "lblGroupID"
        Me.lblGroupID.Size = New System.Drawing.Size(17, 20)
        Me.lblGroupID.TabIndex = 21
        Me.lblGroupID.Text = "1"
        Me.lblGroupID.Visible = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(623, 13)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(17, 20)
        Me.lblID.TabIndex = 20
        Me.lblID.Text = "1"
        Me.lblID.Visible = False
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(20, 10)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(473, 68)
        Me.txtMessage.TabIndex = 16
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.Location = New System.Drawing.Point(499, 10)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(118, 68)
        Me.btnSend.TabIndex = 17
        Me.btnSend.Text = "SEND"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lvwPeople, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(673, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.5207!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.4793!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(218, 459)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'lvwPeople
        '
        Me.lvwPeople.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwPeople.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.peopleID, Me.peopleName})
        Me.lvwPeople.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwPeople.FullRowSelect = True
        Me.lvwPeople.GridLines = True
        Me.lvwPeople.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwPeople.HideSelection = False
        Me.lvwPeople.HotTracking = True
        Me.lvwPeople.HoverSelection = True
        Me.lvwPeople.Location = New System.Drawing.Point(3, 3)
        Me.lvwPeople.MultiSelect = False
        Me.lvwPeople.Name = "lvwPeople"
        Me.lvwPeople.Size = New System.Drawing.Size(212, 359)
        Me.lvwPeople.TabIndex = 10
        Me.lvwPeople.UseCompatibleStateImageBehavior = False
        Me.lvwPeople.View = System.Windows.Forms.View.Details
        '
        'peopleID
        '
        Me.peopleID.Text = "ID"
        Me.peopleID.Width = 0
        '
        'peopleName
        '
        Me.peopleName.Text = "WHO'S IN THE GROUP"
        Me.peopleName.Width = 1000
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnAddPeople)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 368)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(212, 88)
        Me.Panel2.TabIndex = 0
        '
        'btnAddPeople
        '
        Me.btnAddPeople.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAddPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPeople.ForeColor = System.Drawing.Color.White
        Me.btnAddPeople.Location = New System.Drawing.Point(13, 12)
        Me.btnAddPeople.Name = "btnAddPeople"
        Me.btnAddPeople.Size = New System.Drawing.Size(193, 68)
        Me.btnAddPeople.TabIndex = 18
        Me.btnAddPeople.Text = "ADD PEOPLE"
        Me.btnAddPeople.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 465)
        Me.Controls.Add(Me.tlpmain)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GROUP CHAT"
        Me.tlpmain.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrReload As System.Windows.Forms.Timer
    Friend WithEvents tlpmain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvwDataView As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Username As System.Windows.Forms.ColumnHeader
    Friend WithEvents Message As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblGroupID As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAddPeople As System.Windows.Forms.Button
    Friend WithEvents lvwPeople As System.Windows.Forms.ListView
    Friend WithEvents peopleID As System.Windows.Forms.ColumnHeader
    Friend WithEvents peopleName As System.Windows.Forms.ColumnHeader
End Class
