Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Login

    Dim sqlCon As New SqlConnection("Data Source=SILENCER\SQLEXPRESS;Initial Catalog=Semester_Group_Project;Integrated Security=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim email As String = TextBox4.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        If email = "" Or password = "" Then
            MessageBox.Show("Please enter both email and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hashedPassword As String = HashPassword(password)

        Try
            sqlCon.Open()
            Dim sqlquery As String = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password"
            Dim sqlCmd As New SqlCommand(sqlquery, sqlCon)

            sqlCmd.Parameters.AddWithValue("@Email", email)
            sqlCmd.Parameters.AddWithValue("@Password", hashedPassword)

            Dim reader As SqlDataReader = sqlCmd.ExecuteReader()

            If reader.HasRows Then
                ' Login successful
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                sqlCon.Close()
                MainApplication.Show()
                Me.Hide()
            Else
                ' Invalid credentials
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlCon.Close()
        End Try

    End Sub

    Private Function HashPassword(password As String) As String
        Dim sha256 As SHA256 = SHA256.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Return Convert.ToBase64String(hash)
    End Function
End Class