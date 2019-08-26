Public Class TabellaTrasportatori

    Private Sub TabellaTrasportatori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tabella_TrasportatoriTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Trasportatori)
    End Sub

    Private Sub TabellaTrasportatori_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        Me.Validate()
        Me.Tabella_TrasportatoriBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)
    End Sub

    Private Sub UltraGrid1_AfterRowInsert(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowInsert
        Me.Tabella_TrasportatoriTableAdapter.Update(Me.ASDDBDataSet.Tabella_Trasportatori)
    End Sub

    Private Sub UltraGrid1_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGrid1.AfterRowsDeleted
        Me.Tabella_TrasportatoriTableAdapter.Update(Me.ASDDBDataSet.Tabella_Trasportatori)
    End Sub

    Private Sub UltraGrid1_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowUpdate
        Me.Tabella_TrasportatoriTableAdapter.Update(Me.ASDDBDataSet.Tabella_Trasportatori)
    End Sub
End Class
