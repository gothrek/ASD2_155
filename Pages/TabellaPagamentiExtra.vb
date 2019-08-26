Public Class TabellaPagamentiExtra

    Private Sub TabellaPagamentiExtra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tabella_Pagamenti_ExtraTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Pagamenti_Extra)
        Me.Tabella_Sigle_CorrispettiviTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Sigle_Corrispettivi)
    End Sub

    Private Sub UltraGrid1_AfterRowInsert(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowInsert
        Me.Tabella_Pagamenti_ExtraTableAdapter.Update(Me.ASDDBDataSet.Tabella_Pagamenti_Extra)
    End Sub

    Private Sub UltraGrid1_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGrid1.AfterRowsDeleted
        Me.Tabella_Pagamenti_ExtraTableAdapter.Update(Me.ASDDBDataSet.Tabella_Pagamenti_Extra)
    End Sub

    Private Sub UltraGrid1_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowUpdate
        Me.Tabella_Pagamenti_ExtraTableAdapter.Update(Me.ASDDBDataSet.Tabella_Pagamenti_Extra)
    End Sub

    Private Sub Tabella_Pagamenti_ExtraBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Tabella_Pagamenti_ExtraBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)

    End Sub

    Private Sub UltraGrid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGrid1.InitializeLayout
        Try
            e.Layout.Bands(0).Columns("Sigla corrispettivo").ValueList = UltraDropDownSiglaCorrispettivo
        Catch ex As Exception

        End Try
    End Sub
End Class
