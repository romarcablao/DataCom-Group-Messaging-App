Imports System
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class diagUserChoices

    Dim conString As String = "server=localhost; user=root; database=datacom;"
    Dim con As MySqlConnection = New MySqlConnection(conString)
    Dim cmd As MySqlCommand
    Dim adp As New MySqlDataAdapter
    Dim rd As MySqlDataReader
    Dim sql As String


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub diagUserChoices_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ViewAddPeopleList()
    End Sub

    Private Sub lvwListPeople_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvwListPeople.DoubleClick
        If lvwListPeople.SelectedItems.Count = 1 Then
            txtSelected.Text = lvwListPeople.SelectedItems(0).SubItems(1).Text
            lblSelectedID.Text = lvwListPeople.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub lvwListPeople_Click(sender As System.Object, e As System.EventArgs) Handles lvwListPeople.Click
        If lvwListPeople.SelectedItems.Count = 1 Then
            txtSelected.Text = lvwListPeople.SelectedItems(0).SubItems(1).Text
            lblSelectedID.Text = lvwListPeople.SelectedItems(0).SubItems(0).Text

            If isNotInGroup() = 0 Then
                MessageBox.Show("Already in the group!", "Group Chat", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSelected.Clear()
            End If


        End If
    End Sub

    Public Sub ViewAddPeopleList()
        Try

            lvwListPeople.Items.Clear()

            con.ConnectionString = conString
            con.Open()
            cmd = New MySqlCommand("SELECT DISTINCT id, name FROM tblUsers", con)
            rd = cmd.ExecuteReader

            Dim ctr = 0

            While (rd.Read)
                Dim lv As New ListViewItem(rd.Item("id").ToString())
                lv.SubItems.Add(rd.Item("name").ToString())
                lvwListPeople.Items.Add(lv)
                ctr += 1
            End While



        Catch ex As Exception
            MessageBox.Show("Please check your network connection", "Connection Lost!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            con.Close()
        End Try


    End Sub

    Public Function isNotInGroup()

        Dim statusReturn = 0
        Dim ctrValidation = 0

        Try

            con.ConnectionString = conString
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM tblUserGroup WHERE userID=@uid and groupID=@gid", con)
            cmd.Parameters.AddWithValue("uid", lblSelectedID.Text)
            cmd.Parameters.AddWithValue("gid", frmMain.lblGroupID.Text)
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

    Private Sub btnReload_Click(sender As System.Object, e As System.EventArgs) Handles btnReload.Click
        ViewAddPeopleList()
    End Sub
End Class
