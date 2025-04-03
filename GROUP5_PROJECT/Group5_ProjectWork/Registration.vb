Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Registration
    Dim sqlCon As New SqlConnection("Data Source=SILENCER\SQLEXPRESS;Initial Catalog=Semester_Group_Project;Integrated Security=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboGender.Items.Add("MALE")
        cboGender.Items.Add("FEMALE")
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim firstName As String = txtFirstName.Text.Trim()
        Dim lastName As String = txtSecondName.Text.Trim()
        Dim email As String = TextBox4.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()
        Dim gender As String = cboGender.Text.ToString()
        Dim dob As String = dtpDOB.Value.ToString("yyyy-MM-dd")


        If firstName = "" Or lastName = "" Or email = "" Or password = "" Or gender = "" Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

        ' Hash Password
        Dim hashedPassword As String = HashPassword(password)

        Try
            sqlCon.Open()

            Dim sqlquery As String = "INSERT INTO Users (FirstName, LastName, Email, Password, Gender, DateOfBirth) VALUES (@FirstName, @LastName, @Email, @Password, @Gender, @DateOfBirth)"
            Dim sqlCmd As New SqlCommand(sqlquery, sqlCon)

            sqlCmd.Parameters.AddWithValue("@FirstName", firstName)
            sqlCmd.Parameters.AddWithValue("@LastName", lastName)
            sqlCmd.Parameters.AddWithValue("@Email", email)
            sqlCmd.Parameters.AddWithValue("@Password", hashedPassword)
            sqlCmd.Parameters.AddWithValue("@Gender", gender)
            sqlCmd.Parameters.AddWithValue("@DateOfBirth", dob)

            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sqlCon.Close()
            Login.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function HashPassword(password As String) As String
        Dim sha256 As SHA256 = sha256.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Return Convert.ToBase64String(hash)
    End Function

End Class