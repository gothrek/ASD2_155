Public Class FormTabella_Classe

    Private Sub FormTabella_Classe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Tabella_Classe'. È possibile spostarla o rimuoverla se necessario.
        Me.Tabella_ClasseTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Classe)

    End Sub

    Private Sub UltraGrid1_AfterRowInsert(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowInsert
        Me.Tabella_ClasseTableAdapter.Update(Me.ASDDBDataSet.Tabella_Classe)
    End Sub

    Private Sub UltraGrid1_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGrid1.AfterRowsDeleted
        Me.Tabella_ClasseTableAdapter.Update(Me.ASDDBDataSet.Tabella_Classe)
    End Sub

    Private Sub UltraGrid1_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowUpdate
        Me.Tabella_ClasseTableAdapter.Update(Me.ASDDBDataSet.Tabella_Classe)
    End Sub
End Class