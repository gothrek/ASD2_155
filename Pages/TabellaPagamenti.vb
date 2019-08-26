Public Class TabellaPagamenti

    Private Sub TabellaPagamenti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PagamentiTableAdapter.Fill(Me.ASDDBDataSet.Pagamenti)
    End Sub

    Private Sub UltraGrid1_AfterRowInsert(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowInsert
        Me.PagamentiTableAdapter.Update(Me.ASDDBDataSet.Pagamenti)
    End Sub

    Private Sub UltraGrid1_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGrid1.AfterRowsDeleted
        Me.PagamentiTableAdapter.Update(Me.ASDDBDataSet.Pagamenti)
    End Sub

    Private Sub UltraGrid1_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowUpdate
        Me.PagamentiTableAdapter.Update(Me.ASDDBDataSet.Pagamenti)
    End Sub
End Class
