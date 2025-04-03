Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SalesRecord
    Dim sqlCon As New SqlConnection("Data Source=SILENCER\SQLEXPRESS;Initial Catalog=Semester_Group_Project;Integrated Security=True")

    Public Event SalesUpdated()

    ' Call this method after adding, updating, or deleting sales records
    Private Sub NotifyDataChange()
        RaiseEvent SalesUpdated()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub


    Private Sub CalculateTotalAmount()
        Dim quantity As Integer
        Dim sellingPrice As Decimal

        ' Ensure valid inputs
        If Integer.TryParse(TextBox2.Text, quantity) AndAlso Decimal.TryParse(TextBox4.Text, sellingPrice) Then
            TextBox6.Text = (quantity * sellingPrice).ToString("N2") ' Format as currency
        Else
            TextBox6.Text = "0.00"
        End If
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        CalculateTotalAmount()
        TextBox6.Enabled = False
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        CalculateTotalAmount()
        TextBox6.Enabled = False
    End Sub

    Private Sub SalesRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSales()
    End Sub


    Private Sub AddActionButtons()
        ' Prevent duplicate buttons by checking if columns already exist
        If DataGridView1.Columns.Contains("Edit") Then Exit Sub
        If DataGridView1.Columns.Contains("Update") Then Exit Sub
        If DataGridView1.Columns.Contains("Delete") Then Exit Sub

        ' Edit Button
        Dim btnEdit As New DataGridViewButtonColumn()
        btnEdit.HeaderText = "Edit"
        btnEdit.Name = "Edit"
        btnEdit.Text = "Edit"
        btnEdit.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(btnEdit)

        ' Update Button
        Dim btnUpdate As New DataGridViewButtonColumn()
        btnUpdate.HeaderText = "Update"
        btnUpdate.Name = "Update"
        btnUpdate.Text = "Update"
        btnUpdate.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(btnUpdate)

        ' Delete Button
        Dim btnDelete As New DataGridViewButtonColumn()
        btnDelete.HeaderText = "Delete"
        btnDelete.Name = "Delete"
        btnDelete.Text = "Delete"
        btnDelete.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(btnDelete)
    End Sub

    Private Sub LoadSales()
        Try
            sqlCon.Open()
            Dim sqlquery As String = "SELECT * FROM Sales_Records"
            Dim sqlCmd As New SqlCommand(sqlquery, sqlCon)
            Dim adapter As New SqlDataAdapter(sqlCmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            DataGridView1.DataSource = dt
            sqlCon.Close()

            DataGridView1.AutoGenerateColumns = False

            AddActionButtons()

        Catch ex As Exception
            MessageBox.Show("Error loading Sales: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlCon.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim productName As String = TextBox1.Text
        Dim quantity As Integer
        Dim costPrice, sellingPrice, totalAmount As Decimal
        Dim salesDate As Date = DateTimePicker1.Value

        ' Validate fields
        If String.IsNullOrWhiteSpace(productName) OrElse String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox3.Text) OrElse String.IsNullOrWhiteSpace(TextBox4.Text) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validate numeric input
        If Not Integer.TryParse(TextBox2.Text, quantity) Then
            MessageBox.Show("Quantity must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not Decimal.TryParse(TextBox3.Text, costPrice) Then
            MessageBox.Show("Cost Price must be a valid decimal number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not Decimal.TryParse(TextBox4.Text, sellingPrice) Then
            MessageBox.Show("Selling Price must be a valid decimal number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Calculate TotalAmount
        totalAmount = quantity * sellingPrice
        TextBox6.Text = totalAmount.ToString("N2") ' Format as currency

        ' Insert into database
        Try
            sqlCon.Open()
            Dim query As String = "INSERT INTO Sales_Records (ProductName, Quantity, CostPrice, SellingPrice, TotalAmount, SaleDate) 
                            VALUES (@ProductName, @Quantity, @CostPrice, @SellingPrice, @TotalAmount, @SaleDate)"
            Dim sqlCmd As New SqlCommand(query, sqlCon)
            sqlCmd.Parameters.AddWithValue("@ProductName", productName)
            sqlCmd.Parameters.AddWithValue("@Quantity", quantity)
            sqlCmd.Parameters.AddWithValue("@CostPrice", costPrice)
            sqlCmd.Parameters.AddWithValue("@SellingPrice", sellingPrice)
            sqlCmd.Parameters.AddWithValue("@TotalAmount", totalAmount)
            sqlCmd.Parameters.AddWithValue("@SaleDate", salesDate)

            sqlCmd.ExecuteNonQuery()
            NotifyDataChange()
            sqlCon.Close()

            ' Refresh DataGridView
            LoadSales()

            ' Clear input fields
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox6.Text = ""

            MessageBox.Show("Sales record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error adding sales record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim salesID As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells(0).Value)

            'Dim ExpenseId As String = DataGridView1.CurrentRow.Cells(0).Value.ToString()

            If DataGridView1.Columns(e.ColumnIndex).Name = "Edit" Then
                TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value
                TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value
                TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value
                TextBox4.Text = DataGridView1.CurrentRow.Cells(4).Value
                TextBox6.Text = DataGridView1.CurrentRow.Cells(5).Value
                Button2.Enabled = False

            ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "Update" Then

                Dim productName As String = TextBox1.Text
                Dim productQnty As Integer
                Dim productCostPrice As Decimal
                Dim productSellingPrice As Decimal
                Dim productTotalAmount As Decimal
                Dim salesDate As Date = DateTimePicker1.Value.ToString("yyyy-MM-dd")

                If String.IsNullOrWhiteSpace(productName) OrElse
                    Not Integer.TryParse(TextBox2.Text, productQnty) OrElse
                    Not Decimal.TryParse(TextBox3.Text, productCostPrice) OrElse
                    Not Decimal.TryParse(TextBox4.Text, productSellingPrice) Then

                    MessageBox.Show("Please enter valid values for all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                productTotalAmount = productQnty * productSellingPrice

                Try
                    sqlCon.Open()
                    Dim query As String = "UPDATE Sales_Records SET ProductName = @ProductName, Quantity = @Quantity, CostPrice = @CostPrice, 
                            SellingPrice = @SellingPrice, TotalAmount = @TotalAmount, SaleDate = @SaleDate WHERE SaleID = @SaleID"

                    Dim sqlCmd As New SqlCommand(query, sqlCon)
                    sqlCmd.Parameters.AddWithValue("@ProductName", productName)
                    sqlCmd.Parameters.AddWithValue("@Quantity", productQnty)
                    sqlCmd.Parameters.AddWithValue("@CostPrice", productCostPrice)
                    sqlCmd.Parameters.AddWithValue("@SellingPrice", productSellingPrice)
                    sqlCmd.Parameters.AddWithValue("@TotalAmount", productTotalAmount)
                    sqlCmd.Parameters.AddWithValue("@SaleDate", salesDate)
                    sqlCmd.Parameters.AddWithValue("@SaleID", salesID)

                    sqlCmd.ExecuteNonQuery()
                    sqlCon.Close()

                    ' Refresh Data
                    LoadSales()
                    Button2.Enabled = True
                    'UpdateSalesSummary()

                    MessageBox.Show("Sales record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Clear fields
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox3.Text = ""
                    TextBox4.Text = ""
                    TextBox6.Text = ""


                Catch ex As Exception
                    MessageBox.Show("Error updating sales record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    sqlCon.Close()
                End Try

            ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "Delete" Then
                'Dim ExpenseId As String = DataGridView1.CurrentRow.Cells(0).Value.ToString()
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    Try
                        sqlCon.Open()
                        Dim query As String = "DELETE FROM Sales_Records WHERE SaleID = @SaleID"
                        Dim sqlCmd As New SqlCommand(query, sqlCon)
                        sqlCmd.Parameters.AddWithValue("@SaleID", salesID)

                        sqlCmd.ExecuteNonQuery()
                        sqlCon.Close()

                        ' Refresh Data
                        LoadSales()
                        'UpdateSalesSummary()

                        MessageBox.Show("Sales record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Catch ex As Exception
                        MessageBox.Show("Error deleting sales record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        sqlCon.Close()
                    End Try
                End If


                'DeleteExpense(selectedID)
            End If
        End If
    End Sub
End Class
