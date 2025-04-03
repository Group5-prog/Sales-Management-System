Imports System.Data.SqlClient

Public Class SalesSummary
    Dim sqlCon As New SqlConnection("Data Source=SILENCER\SQLEXPRESS;Initial Catalog=Semester_Group_Project;Integrated Security=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Public Sub LoadSummaryData()
        ' Recalculate total quantity, total sales, total cost, and profit
        Dim totalQuantity As Integer = GetTotalQuantity()
        Dim totalSales As Decimal = GetTotalSales()
        Dim totalCost As Decimal = GetTotalCost()
        Dim totalProfit As Decimal = totalSales - totalCost ' Profit = Total Sales - Total Cost

        ' Update labels or UI elements
        Label3.Text = totalQuantity.ToString("N0")
        Label4.Text = totalSales.ToString("C")
        Label8.Text = totalCost.ToString("C")
        Label9.Text = totalProfit.ToString("C")
    End Sub

    ' Function to fetch total quantity from the database
    Private Function GetTotalQuantity() As Integer
        Dim totalQty As Integer = 0
        Try
            sqlCon.Open()
            Dim query As String = "SELECT SUM(Quantity) FROM Sales_Records"
            Dim cmd As New SqlCommand(query, sqlCon)
            Dim result = cmd.ExecuteScalar()
            If result IsNot DBNull.Value Then
                totalQty = Convert.ToInt32(result)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading total quantity: " & ex.Message)
        Finally
            sqlCon.Close()
        End Try
        Return totalQty
    End Function

    ' Function to fetch total sales (TotalAmount) from the database
    Private Function GetTotalSales() As Decimal
        Dim total As Decimal = 0
        Try
            sqlCon.Open()
            Dim query As String = "SELECT SUM(TotalAmount) FROM Sales_Records"
            Dim cmd As New SqlCommand(query, sqlCon)
            Dim result = cmd.ExecuteScalar()
            If result IsNot DBNull.Value Then
                total = Convert.ToDecimal(result)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading total sales: " & ex.Message)
        Finally
            sqlCon.Close()
        End Try
        Return total
    End Function

    ' Function to fetch total cost from the database
    Private Function GetTotalCost() As Decimal
        Dim totalCost As Decimal = 0
        Try
            sqlCon.Open()
            Dim query As String = "SELECT SUM(CostPrice * Quantity) FROM Sales_Records"
            Dim cmd As New SqlCommand(query, sqlCon)
            Dim result = cmd.ExecuteScalar()
            If result IsNot DBNull.Value Then
                totalCost = Convert.ToDecimal(result)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading total cost: " & ex.Message)
        Finally
            sqlCon.Close()
        End Try
        Return totalCost
    End Function

    Private Sub SalesSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("All")
        ComboBox1.Items.Add("Day")
        ComboBox1.Items.Add("Week")
        ComboBox1.Items.Add("Month")

        ComboBox1.SelectedItem = "All"

        ' Load all sales data initially
        LoadSummaryData()

        'LoadSummaryData()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedFilter As String = ComboBox1.SelectedItem.ToString()
        'LoadSummaryData(selectedFilter)
    End Sub
End Class
