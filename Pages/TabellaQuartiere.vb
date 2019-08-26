Public Class TabellaQuartiere

    Private Sub TabellaQuartiere_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Tabella_Quartiere'. È possibile spostarla o rimuoverla se necessario.
        Me.Tabella_QuartiereTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Quartiere)

    End Sub

    Private Sub UltraGrid1_AfterRowInsert(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowInsert
        Me.Tabella_QuartiereTableAdapter.Update(Me.ASDDBDataSet.Tabella_Quartiere)
    End Sub

    Private Sub UltraGrid1_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGrid1.AfterRowsDeleted
        Me.Tabella_QuartiereTableAdapter.Update(Me.ASDDBDataSet.Tabella_Quartiere)
    End Sub

    Private Sub UltraGrid1_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowUpdate
        Me.Tabella_QuartiereTableAdapter.Update(Me.ASDDBDataSet.Tabella_Quartiere)
    End Sub
End Class
