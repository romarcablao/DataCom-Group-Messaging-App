Public Class frmSignup

    Private Sub lnkLogin_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkLogin.LinkClicked
        Me.Hide()
        txtName.Clear()
        txtPass.Clear()
        txtUname.Clear()
        frmLogin.Show()

    End Sub

    Private Sub btnSignup_Click(sender As System.Object, e As System.EventArgs) Handles btnSignup.Click
        If txtName.Text = "Name" Or txtPass.Text = "Password" Or txtUname.Text = "Username" Then
            MessageBox.Show("Please enter valid credentials!", "Signup Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If isValidUsername() = 0 Then
                MessageBox.Show("Username already used!", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUname.Clear()
            Else
                Signup()
            End If

        End If

    End Sub

    Private Sub frmSignup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUname_Leave(sender As System.Object, e As System.EventArgs) Handles txtUname.Leave
        If isValidUsername() = 0 Then
            MessageBox.Show("Username already used!", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUname.Clear()
        End If
    End Sub

    Private Sub txtUname_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUname.TextChanged
        
    End Sub
End Class