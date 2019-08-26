Public Class FormTabella_Fascia_d_età

    Private Sub FormTabella_Fascia_d_età_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet._Tabella_Fascia_d_età'. È possibile spostarla o rimuoverla se necessario.
        Me.Tabella_Fascia_d_etàTableAdapter.Fill(Me.ASDDBDataSet._Tabella_Fascia_d_età)

    End Sub

    Private Sub UltraGrid1_AfterRowInsert(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowInsert
        Me.Tabella_Fascia_d_etàTableAdapter.Update(Me.ASDDBDataSet._Tabella_Fascia_d_età)
    End Sub

    Private Sub UltraGrid1_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGrid1.AfterRowsDeleted
        Me.Tabella_Fascia_d_etàTableAdapter.Update(Me.ASDDBDataSet._Tabella_Fascia_d_età)
    End Sub

    Private Sub UltraGrid1_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowUpdate
        Me.Tabella_Fascia_d_etàTableAdapter.Update(Me.ASDDBDataSet._Tabella_Fascia_d_età)
    End Sub
End Class