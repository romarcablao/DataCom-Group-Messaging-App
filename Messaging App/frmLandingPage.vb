Public Class frmLandingPage

    Private Sub frmLandingPage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tmrReload.Start()
    End Sub


    Private Sub tmrReload_Tick(sender As System.Object, e As System.EventArgs) Handles tmrReload.Tick
        ViewGroups()
    End Sub

    Private Sub frmLandingPage_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        Me.Hide()
        tmrReload.Stop()

        frmLogin.Show()
    End Sub

    Private Sub lvwMyGroups_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvwMyGroups.DoubleClick
        If lvwMyGroups.SelectedItems.Count = 1 Then
            openGroupConversation(lvwMyGroups.SelectedItems(0).SubItems(0).Text.ToString)
        End If
    End Sub

    Public Sub openGroupConversation(ByVal groupID As String)
        frmMain.Text = Text + "       [ " + lvwMyGroups.SelectedItems(0).SubItems(1).Text.ToUpper + "]"
        frmMain.lblID.Text = lblUserID.Text
        frmMain.lblGroupID.Text = groupID
        frmMain.Show()
        tmrReload.Stop()
        Me.Hide()
    End Sub

    Private Sub btnCreateGroup_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateGroup.Click
        If Not txtGroupName.Text = "" Then
            createGroup()
        End If

    End Sub

    Private Sub txtGroupName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtGroupName.TextChanged
        If isValidGroupName() = 0 And Not txtGroupName.Text = "" Then
            MessageBox.Show("Group name already exist!", "Group Chat", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGroupName.Clear()
        End If
    End Sub
End Class