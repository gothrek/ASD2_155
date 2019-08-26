Public Class TabellaTestata
    Dim nuovo As Boolean = False
    Dim riga As Integer = -1

    Private Sub UltraGrid1_AfterRowInsert(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowInsert
        riga = e.Row.Index
        Me.TestateTableAdapter.Update(Me.ASDDBDataSet.Testate)
        nuovo = True
    End Sub

    Private Sub UltraGrid1_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowUpdate
        Me.TestateTableAdapter.Update(Me.ASDDBDataSet.Testate)
        Me.Validate()
        Me.TestateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)
    End Sub

    Private Sub TabellaTestata_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TestateTableAdapter.Fill(Me.ASDDBDataSet.Testate)
        Me.Tabella_DistribuzioniTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Distribuzioni)
    End Sub

    Private Sub UltraGrid1_AfterCellActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGrid1.AfterCellActivate
        Dim riga2 As Integer = -1
        Try
            riga2 = UltraGrid1.ActiveRow.Index
        Catch ex As Exception
            riga2 = riga
        End Try
        If nuovo And (riga2 <> riga) Then
            Me.Tabella_DistribuzioniTableAdapter.Insert(UltraGrid1.Rows(riga).Cells(1).Text, "00-Standard", True, Today, Today, Today, " ")
            nuovo = False
            riga = riga2
            Me.Validate()
            Me.TestateBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)
            Me.TestateTableAdapter.Fill(Me.ASDDBDataSet.Testate)
            Me.Tabella_DistribuzioniTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Distribuzioni)
        End If
    End Sub

    Private Sub UltraGrid1_BeforeEnterEditMode(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles UltraGrid1.BeforeEnterEditMode
        If (Not nuovo) And (UltraGrid1.ActiveCell.Column.Index < 2) Then
            MsgBox("Non puoi modificare questo valore")
            e.Cancel = True
        End If
    End Sub

    Private Sub TabellaTestata_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        UltraGrid1.Rows(0).Cells(0).Activate()
        Me.TestateTableAdapter.Update(Me.ASDDBDataSet.Testate)
        Me.Validate()
        Me.TestateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)
    End Sub
End Class
