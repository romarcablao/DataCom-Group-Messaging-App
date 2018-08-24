<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class diagUserChoices
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.lvwListPeople = New System.Windows.Forms.ListView()
        Me.whoID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.whoName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtSelected = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSelectedID = New System.Windows.Forms.Label()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(382, 333)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(219, 45)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 5)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(100, 35)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "ADD"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(114, 5)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 35)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "CANCEL"
        '
        'lvwListPeople
        '
        Me.lvwListPeople.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwListPeople.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.whoID, Me.whoName})
        Me.lvwListPeople.FullRowSelect = True
        Me.lvwListPeople.GridLines = True
        Me.lvwListPeople.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwListPeople.HideSelection = False
        Me.lvwListPeople.HotTracking = True
        Me.lvwListPeople.HoverSelection = True
        Me.lvwListPeople.Location = New System.Drawing.Point(9, 10)
        Me.lvwListPeople.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lvwListPeople.MultiSelect = False
        Me.lvwListPeople.Name = "lvwListPeople"
        Me.lvwListPeople.Size = New System.Drawing.Size(587, 231)
        Me.lvwListPeople.TabIndex = 11
        Me.lvwListPeople.UseCompatibleStateImageBehavior = False
        Me.lvwListPeople.View = System.Windows.Forms.View.Details
        '
        'whoID
        '
        Me.whoID.Text = "ID"
        Me.whoID.Width = 0
        '
        'whoName
        '
        Me.whoName.Text = "LIST"
        Me.whoName.Width = 1000
        '
        'txtSelected
        '
        Me.txtSelected.Location = New System.Drawing.Point(97, 279)
        Me.txtSelected.Name = "txtSelected"
        Me.txtSelected.ReadOnly = True
        Me.txtSelected.Size = New System.Drawing.Size(499, 26)
        Me.txtSelected.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "SELECTED:"
        '
        'lblSelectedID
        '
        Me.lblSelectedID.AutoSize = True
        Me.lblSelectedID.Location = New System.Drawing.Point(579, 256)
        Me.lblSelectedID.Name = "lblSelectedID"
        Me.lblSelectedID.Size = New System.Drawing.Size(17, 20)
        Me.lblSelectedID.TabIndex = 17
        Me.lblSelectedID.Text = "0"
        '
        'btnReload
        '
        Me.btnReload.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReload.Location = New System.Drawing.Point(16, 343)
        Me.btnReload.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(100, 35)
        Me.btnReload.TabIndex = 18
        Me.btnReload.Text = "RELOAD"
        '
        'diagUserChoices
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(619, 397)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.lblSelectedID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSelected)
        Me.Controls.Add(Me.lvwListPeople)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "diagUserChoices"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ADD PEOPLE"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lvwListPeople As System.Windows.Forms.ListView
    Friend WithEvents whoID As System.Windows.Forms.ColumnHeader
    Friend WithEvents whoName As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtSelected As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSelectedID As System.Windows.Forms.Label
    Friend WithEvents btnReload As System.Windows.Forms.Button

End Class
