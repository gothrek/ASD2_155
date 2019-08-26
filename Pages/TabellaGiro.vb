Public Class TabellaGiro

    Private Sub TabellaGiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Tabella_Giro'. È possibile spostarla o rimuoverla se necessario.
        Me.Tabella_GiroTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Giro)

    End Sub

    Private Sub UltraGrid1_AfterRowInsert(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowInsert
        Me.Tabella_GiroTableAdapter.Update(Me.ASDDBDataSet.Tabella_Giro)
    End Sub

    Private Sub UltraGrid1_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGrid1.AfterRowsDeleted
        Me.Tabella_GiroTableAdapter.Update(Me.ASDDBDataSet.Tabella_Giro)
    End Sub

    Private Sub UltraGrid1_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowUpdate
        Me.Tabella_GiroTableAdapter.Update(Me.ASDDBDataSet.Tabella_Giro)
    End Sub

    Private Sub Tabella_GiroBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Tabella_GiroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)

    End Sub
End Class
