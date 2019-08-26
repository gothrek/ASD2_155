Public Class Impostazioni

    Private Sub Impostazioni_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ImpostazioniTableAdapter.Fill(Me.ASDDBDataSet.Impostazioni)
    End Sub

    Private Sub UltraGrid1_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs)
        Me.ImpostazioniTableAdapter.Update(Me.ASDDBDataSet.Impostazioni)
    End Sub

    Private Sub ImpostazioniDataGridView_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ImpostazioniBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)
    End Sub

    Private Sub UltraGrid1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGrid1.Leave
        Me.Validate()
        Me.ImpostazioniBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)
    End Sub
End Class
