Public Class TabellaSigleCorrispettivi

    Private Sub TabellaSigleCorrispettivi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tabella_Sigle_CorrispettiviTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Sigle_Corrispettivi)
    End Sub

    Private Sub UltraGrid1_AfterRowInsert(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowInsert
        Me.Tabella_Sigle_CorrispettiviTableAdapter.Update(Me.ASDDBDataSet.Tabella_Sigle_Corrispettivi)
    End Sub

    Private Sub UltraGrid1_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGrid1.AfterRowsDeleted
        Me.Tabella_Sigle_CorrispettiviTableAdapter.Update(Me.ASDDBDataSet.Tabella_Sigle_Corrispettivi)
    End Sub

    Private Sub UltraGrid1_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowUpdate
        Me.Tabella_Sigle_CorrispettiviTableAdapter.Update(Me.ASDDBDataSet.Tabella_Sigle_Corrispettivi)
    End Sub
End Class
