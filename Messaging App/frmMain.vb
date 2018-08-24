Public Class frmMain

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'ViewMessages()
        tmrReload.Start()
    End Sub

    Private Sub tmrReload_Tick(sender As System.Object, e As System.EventArgs) Handles tmrReload.Tick

        ViewMessages()
        ViewWhosInTheGroup()
    End Sub


    Private Sub frmMain_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmLandingPage.Show()
        frmLandingPage.tmrReload.Start()

    End Sub


 
    Private Sub btnSend_Click(sender As System.Object, e As System.EventArgs) Handles btnSend.Click
        If Not txtMessage.Text = "" Then
            SendMessage()
        End If
    End Sub

    Private Sub lvwDataView_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles lvwDataView.KeyDown
        If lvwDataView.SelectedItems.Count = 1 Then
            If e.KeyCode = Keys.Delete Then
                DeleteMessage(lvwDataView.SelectedItems(0).SubItems(0).Text)
            End If
        End If
    End Sub

    Private Sub btnAddPeople_Click(sender As System.Object, e As System.EventArgs) Handles btnAddPeople.Click

        tmrReload.Stop()


        Dim testdialog As New diagUserChoices

        If testdialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            addThisPerson(testdialog.lblSelectedID.Text, lblGroupID.Text)
            tmrReload.Start()

        Else
            'tmrReload.Start()
        End If

    End Sub
End Class