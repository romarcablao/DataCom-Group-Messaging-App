Public Class frmLogin

    Private Sub lnkSignup_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkSignup.LinkClicked
        Me.Hide()
        txtPass.Clear()
        txtUname.Clear()
        frmSignup.Show()
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        If txtPass.Text = "" Or txtUname.Text = "" Then
            MessageBox.Show("Please enter valid credentials!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            userLogin()
        End If

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
