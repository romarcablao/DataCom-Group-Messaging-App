Imports System
Imports MySql.Data
Imports MySql.Data.MySqlClient

Module modConnection

    Dim conString As String = "server=localhost; user=root; database=datacom;"
    Dim con As MySqlConnection = New MySqlConnection(conString)
    Dim cmd As MySqlCommand
    Dim adp As New MySqlDataAdapter
    Dim rd As MySqlDataReader
    Dim sql As String

    Public idChosen As String

    Public Sub DBConnect()
        Try
            con.Open()
            ' MessageBox.Show("Connected")
        Catch ex As Exception
            MessageBox.Show("Database Not Ready!")
            End
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub Signup()
        Try
            con.ConnectionString = conString
            con.Open()
            cmd = New MySqlCommand("INSERT INTO tblusers (name, username, userpassword) VALUES (@name,@uname,@pass)", con)
            cmd.Parameters.AddWithValue("name", frmSignup.txtName.Text)
            cmd.Parameters.AddWithValue("uname", frmSignup.txtUname.Text)
            cmd.Parameters.AddWithValue("pass", frmSignup.txtPass.Text)
            rd = cmd.ExecuteReader

            frmSignup.txtName.Text = "Name"
            frmSignup.txtUname.Text = "Username"
            frmSignup.txtPass.Text = "Password"
            frmSignup.Hide()
            frmLogin.Show()

        Catch ex As Exception
            MessageBox.Show("Please enter valid credentials!", "Signup Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function isValidUsername()

        Dim statusReturn = 0
        Dim ctrValidation = 0

        Try

            con.ConnectionString = conString
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM tblUsers WHERE username=@uname", con)
            cmd.Parameters.AddWithValue("uname", frmSignup.txtUname.Text)
            rd = cmd.ExecuteReader


            While (rd.Read)
                ctrValidation += 1
            End While

            If ctrValidation = 0 Then
                statusReturn = 1
            Else
                statusReturn = 0
            End If

        Catch ex As Exception
            'MessageBox.Show("Please check your network connection", "Connection Lost!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        Return statusReturn

    End Function

    Public Function isValidGroupName()

        Dim statusReturn = 0
        Dim ctrValidation = 0

        Try

            con.ConnectionString = conString
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM tblGroups WHERE name=@name", con)
            cmd.Parameters.AddWithValue("name", frmLandingPage.txtGroupName.Text)
            rd = cmd.ExecuteReader


            While (rd.Read)
                ctrValidation += 1
            End While

            If ctrValidation = 0 Then
                statusReturn = 1
            Else
                statusReturn = 0
            End If

        Catch ex As Exception
            'MessageBox.Show("4Please check your network connection", "Connection Lost!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        Return statusReturn

    End Function


    Public Sub userLogin()
        Try
            frmMain.lvwDataView.Items.Clear()

            con.ConnectionString = conString
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM tblUsers WHERE username=@uname and userpassword=@pw", con)
            cmd.Parameters.AddWithValue("uname", frmLogin.txtUname.Text)
            cmd.Parameters.AddWithValue("pw", frmLogin.txtPass.Text)
            rd = cmd.ExecuteReader

            Dim ctrValidation = 0
            Dim a, b, c As String


            While (rd.Read)
                a = rd.Item("id").ToString()
                b = rd.Item("username").ToString()
                c = rd.Item("name").ToString()
                ctrValidation += 1
            End While

            If ctrValidation = 1 Then
                'frmMain.lblID.Text = a
                'frmMain.lblUser.Text = b
                frmLogin.Hide()
                frmLogin.txtPass.Clear()
                'frmMain.Show()
                frmLandingPage.lblUserID.Text = a
                frmLandingPage.Text = "MY ACCOUNT: " + c.ToUpper
                frmLandingPage.Show()


            Else
                MessageBox.Show("Please enter valid credentials!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Please enter valid credentials!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub ViewGroups()
        Try
            frmLandingPage.lvwMyGroups.Items.Clear()

            con.ConnectionString = conString
            con.Open()
            cmd = New MySqlCommand("SELECT C.id, c.name FROM tblUserGroup A INNER JOIN tblUsers B ON A.userID=B.id INNER JOIN tblGroups C ON A.groupID=C.id WHERE B.id=@uid", con)
            cmd.Parameters.AddWithValue("uid", frmLandingPage.lblUserID.Text)
            rd = cmd.ExecuteReader

            Dim ctr = 0

            While (rd.Read)
                Dim lv As New ListViewItem(rd.Item("id").ToString())
                lv.SubItems.Add(rd.Item("name").ToString())
                frmLandingPage.lvwMyGroups.Items.Add(lv)
                ctr += 1
            End While

            If ctr > 2 Then
                frmLandingPage.lvwMyGroups.EnsureVisible(frmLandingPage.lvwMyGroups.Items.Count - 1)
            End If

        Catch ex As Exception
            frmLandingPage.tmrReload.Stop()
            MessageBox.Show("3Please check your network connection", "Connection Lost!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            If MsgBoxResult.Ok = MsgBoxResult.Ok Then
                frmLandingPage.tmrReload.Start()
            End If

        Finally
            con.Close()
        End Try


    End Sub

    Public Sub createGroup()
        Try
            frmLandingPage.tmrReload.Stop()

            con.ConnectionString = conString
            con.Open()
            cmd = New MySqlCommand("INSERT INTO tblGroups (name, status) VALUES (@name,@status)", con)
            cmd.Parameters.AddWithValue("name", frmLandingPage.txtGroupName.Text)
            cmd.Parameters.AddWithValue("status", "active")
            rd = cmd.ExecuteReader



            MessageBox.Show("Add more person to the group!", "Group Created!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("1Please check network connection and retry!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        autoAddCreator()

    End Sub

    Public Sub autoAddCreator()
        Try

            con.ConnectionString = conString
            con.Open()
            cmd = New MySqlCommand("INSERT INTO tblUserGroup (userid, groupID) VALUES (@uid,(SELECT id from tblGroups WHERE name=@gname))", con)
            cmd.Parameters.AddWithValue("uid", frmLandingPage.lblUserID.Text)
            cmd.Parameters.AddWithValue("gname", frmLandingPage.txtGroupName.Text)
            rd = cmd.ExecuteReader

            frmLandingPage.txtGroupName.Clear()

        Catch ex As Exception
            MessageBox.Show("2Please check network connection and retry!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
            frmLandingPage.tmrReload.Start()
        End Try
    End Sub


    Public Sub SendMessage()
        Try
            con.ConnectionString = conString
            con.Open()
            cmd = New MySqlCommand("INSERT INTO tblMessage (userIDSource, message, status, groupID) VALUES (@uid,@message,@stat,@gid)", con)
            cmd.Parameters.AddWithValue("uid", frmMain.lblID.Text)
            cmd.Parameters.AddWithValue("message", frmMain.txtMessage.Text)
            cmd.Parameters.AddWithValue("stat", "Sent")
            cmd.Parameters.AddWithValue("gid", frmMain.lblGroupID.Text)
            rd = cmd.ExecuteReader

            frmMain.txtMessage.Clear()


        Catch ex As Exception
            MessageBox.Show("1Please check your network connection", "Sending Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub ViewMessages()
        Try
            frmMain.lvwDataView.Items.Clear()

            con.ConnectionString = conString
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM tblMessage A INNER JOIN tblUsers B ON A.userIDSource=B.id WHERE groupID=@gid", con)
            cmd.Parameters.AddWithValue("gid", frmMain.lblGroupID.Text)
            rd = cmd.ExecuteReader

            Dim ctr = 0

            While (rd.Read)
                Dim lv As New ListViewItem(rd.Item("id").ToString())
                lv.SubItems.Add(rd.Item("username").ToString())
                lv.SubItems.Add(rd.Item("message").ToString())
                frmMain.lvwDataView.Items.Add(lv)
                ctr += 1
            End While

            If ctr > 1 Then
                frmMain.lvwDataView.EnsureVisible(frmMain.lvwDataView.Items.Count - 1)
            End If

        Catch ex As Exception
            frmMain.tmrReload.Stop()
            MessageBox.Show("Please check your network connection", "Connection Lost!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            If MsgBoxResult.Ok = MsgBoxResult.Ok Then
                frmMain.tmrReload.Start()
            End If

        Finally
            con.Close()
        End Try
    End Sub

    Public Sub ViewWhosInTheGroup()
        Try
            frmMain.lvwPeople.Items.Clear()

            con.ConnectionString = conString
            con.Open()
            cmd = New MySqlCommand("SELECT B.id, B.name FROM tblUserGroup A INNER JOIN tblUsers B ON A.userID=B.id WHERE A.groupID =@gid", con)
            cmd.Parameters.AddWithValue("gid", frmMain.lblGroupID.Text)
            rd = cmd.ExecuteReader

            Dim ctr = 0

            While (rd.Read)
                Dim lv As New ListViewItem(rd.Item("id").ToString())
                lv.SubItems.Add(rd.Item("name").ToString())
                frmMain.lvwPeople.Items.Add(lv)
                ctr += 1
            End While

            If ctr > 1 Then
                frmMain.lvwPeople.EnsureVisible(frmMain.lvwPeople.Items.Count - 1)
            End If

        Catch ex As Exception
            frmMain.tmrReload.Stop()
            MessageBox.Show("Please check your network connection", "Connection Lost!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            If MsgBoxResult.Ok = MsgBoxResult.Ok Then
                frmMain.tmrReload.Start()
            End If

        Finally
            con.Close()
        End Try
    End Sub

    Public Sub addThisPerson(ByVal uid As String, ByVal gid As String)
        Try

            con.ConnectionString = conString
            con.Open()
            cmd = New MySqlCommand("INSERT INTO tblUserGroup (userid, groupID) VALUES (@uid,@gid)", con)
            cmd.Parameters.AddWithValue("uid", uid)
            cmd.Parameters.AddWithValue("gid", gid)
            rd = cmd.ExecuteReader

            frmLandingPage.txtGroupName.Clear()

        Catch ex As Exception
            MessageBox.Show("Please check network connection and retry!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub ViewAddPeopleLists()
        Try
            diagUserChoices.lvwListPeople.Items.Clear()

            con.ConnectionString = conString
            con.Open()
            cmd = New MySqlCommand("SELECT DISTINCT B.id, B.name FROM tblUserGroup A INNER JOIN tblUsers B ON A.userID=B.id WHERE A.groupID != @gid", con)
            cmd.Parameters.AddWithValue("gid", frmMain.lblGroupID.Text)
            rd = cmd.ExecuteReader

            Dim ctr = 0

            While (rd.Read)
                Dim lv As New ListViewItem(rd.Item("id").ToString())
                lv.SubItems.Add(rd.Item("name").ToString())
                diagUserChoices.lvwListPeople.Items.Add(lv)
                ctr += 1
            End While



        Catch ex As Exception
            MessageBox.Show("Please check your network connection", "Connection Lost!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            con.Close()
        End Try
    End Sub

    Public Sub DeleteMessage(ByVal getID As String)
        Try
            frmMain.tmrReload.Stop()

            con.ConnectionString = conString
            con.Open()
            cmd = New MySqlCommand("DELETE FROM tblMessage WHERE id=@mid", con)
            cmd.Parameters.AddWithValue("mid", getID)
            rd = cmd.ExecuteReader
            MessageBox.Show("Message Deleted!", "Group Chat", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If MsgBoxResult.Ok = MsgBoxResult.Ok Then
                frmMain.tmrReload.Start()
            End If

        Catch ex As Exception
            MessageBox.Show("Please check your network connection", "Deleting Message Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

End Module
