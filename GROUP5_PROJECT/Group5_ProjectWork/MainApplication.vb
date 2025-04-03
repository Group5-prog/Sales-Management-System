Public Class MainApplication

    Private Sub LoadUserControl(userControl As UserControl)
        PanelContainer.Controls.Clear()
        userControl.Dock = DockStyle.Fill
        PanelContainer.Controls.Add(userControl)
    End Sub
    Private Sub MainApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim salesRecordInstance As New SalesRecord()
        AddHandler salesRecordInstance.SalesUpdated, AddressOf UpdateSalesSummary
        LoadUserControl(New SalesSummary())
    End Sub

    Private Sub UpdateSalesSummary()
        Dim salesSummaryInstance As New SalesSummary
        salesSummaryInstance.LoadSummaryData()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadUserControl(New SalesSummary())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadUserControl(New SalesRecord())
    End Sub


End Class