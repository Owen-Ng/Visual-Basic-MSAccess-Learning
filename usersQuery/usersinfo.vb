Public Class usersinfo
    Private Access As New DBControl
    Public Property StringPass As String
    Public Property table As DataTable



    Private Sub usersinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label.Text = Form1.username.Text
        'Access.AddParam("@user", "%" & Label.Text & "%")
        'Access.ExecQuery("SELECT username, password FROM users WHERE username LIKE @user")
        'If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        'DataGridView1.DataSource = Access.DBDT
        Label.Text = StringPass
        DataGridView1.DataSource = table
        Dim rows() As DataRow = table.Select()
        If rows.Count > 0 Then
            lbtennis.Text = rows(0).Item("Tennis")
            lbswimming.Text = rows(0).Item("Swimming")

        End If





    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Dim username As String
        Dim password As String
        Dim Tennis As Boolean
        Dim Swimming As Boolean
        Dim Dancing As Boolean
        Dim ID As String

        Dim rows() As DataRow = table.Select()
        If rows.Count > 0 Then
            ID = rows(0).Item("ID")
            username = rows(0).Item("username")
            password = rows(0).Item("password")
            Dancing = rows(0).Item("Dancing")
            Swimming = rows(0).Item("Swimming")
            Tennis = rows(0).Item("Tennis")

            Console.WriteLine(ID)
            Access.AddParam("@id", ID.ToString())
            Access.AddParam("@username", username)
            Access.AddParam("@password", password)

            Access.ExecQuery("Update users set [password] = @password, [username] = @username WHERE ID = 1 ;")
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        End If



    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        Access.ExecQuery("SELECT * FROM users WHERE id = 1")
        DataGridView1.DataSource = Access.DBDT
    End Sub
    'Private Sub getTennis(t As DataTable)


    'End Sub

    'Private Sub getSwimming(t As DataTable)


    'End Sub
End Class