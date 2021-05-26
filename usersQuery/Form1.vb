Public Class Form1
    Private Access As New DBControl
    Dim usersTable As DataTable
    Dim hobbyTable As DataTable
    Dim index As Integer = 0
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        update_TableHobby()
        update_Table()

        Update(index)


    End Sub
    Private Sub update_Table()
        Access.ExecQuery("SELECT * FROM users ORDER BY username")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        DataGridView1.DataSource = Access.DBDT
        usersTable = Access.DBDT
    End Sub

    Private Sub update_TableHobby()
        Access.ExecQuery("SELECT * FROM Hobbies")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        DataGridView2.DataSource = Access.DBDT
        hobbyTable = Access.DBDT
    End Sub

    Private Sub Update(i As Integer)
        Dim rows() As DataRow = usersTable.Select()
        If rows.Count > 0 Then
            lbID.Text = rows(index).Item("ID")
            lbname.Text = rows(index).Item("username")
            lbpassword.Text = rows(index).Item("password")
        End If
    End Sub
    Private Sub SearchMember(Name As String)
        Access.AddParam("@user", "%" & Name & "%")
        Access.ExecQuery("SELECT ID, username, password FROM users WHERE username LIKE @user ORDER BY username")

        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        DataGridView1.DataSource = Access.DBDT

    End Sub

    Private Sub viewInfo_Click(sender As Object, e As EventArgs) Handles viewInfo.Click
        Access.AddParam("@user", "%" & username.Text & "%")
        Access.ExecQuery("SELECT id,username, password, Tennis, Swimming, Dancing FROM users, Hobbies  WHERE username LIKE @user AND ID = CustomerID")

        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        Dim obj As New usersinfo
        obj.StringPass = username.Text
        obj.table = Access.DBDT
        obj.Show()


    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        SearchMember(username.Text)
    End Sub

    Private Sub leftarrow_Click(sender As Object, e As EventArgs) Handles leftarrow.Click
        index -= 1
        If index < 0 Then
            index = 0
        End If
        Console.WriteLine(index)
        Update(index)
    End Sub

    Private Sub rightarrow_Click(sender As Object, e As EventArgs) Handles rightarrow.Click
        index += 1
        If index > usersTable.Rows.Count - 1 Then
            index = usersTable.Rows.Count - 1
        End If
        Console.WriteLine(index)
        Update(index)
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim n As String = addname.Text
        Dim p As String = addpassword.Text
        If String.IsNullOrEmpty(n) Or String.IsNullOrEmpty(p) Then
            MsgBox("Error") : Exit Sub
        End If
        Access.AddParam("@name", n)
        Access.AddParam("@password", p)
        Access.ExecQuery("INSERT INTO users ([username], [password]) VALUES (@name, @password)")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        update_Table()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = IDbox.Text
        If String.IsNullOrEmpty(str) Then
            MsgBox("Error") : Exit Sub
        End If

        Access.AddParam("@ID", str)
        Access.ExecQuery("DELETE FROM users where ID = @ID")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        update_Table()
        update_TableHobby()
    End Sub
End Class
