Public Class Form_Gestione_PI

    Private Sub PIBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PIBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)
        UltraStatusBar.Panels(0).Text = "Righe selezionate: 0"
        'UltraGridPI .DisplayLayout .Bands (0).Columns ("Giro").ValueList.
        'ValueListQuartiere()
    End Sub

    Private Sub Form_Gestione_PI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Tabella_Dispencer'. È possibile spostarla o rimuoverla se necessario.
        Me.Tabella_DispencerTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Dispencer)
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Tabella_Fruizione'. È possibile spostarla o rimuoverla se necessario.
        Me.Tabella_FruizioneTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Fruizione)
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Tabella_Classe'. È possibile spostarla o rimuoverla se necessario.
        Me.Tabella_ClasseTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Classe)
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Tabella_Tipologia'. È possibile spostarla o rimuoverla se necessario.
        Me.Tabella_TipologiaTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Tipologia)
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Tabella_Accettazione'. È possibile spostarla o rimuoverla se necessario.
        Me.Tabella_AccettazioneTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Accettazione)
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet._Tabella_Fascia_d_età'. È possibile spostarla o rimuoverla se necessario.
        Me.Tabella_Fascia_d_etàTableAdapter.Fill(Me.ASDDBDataSet._Tabella_Fascia_d_età)
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Tabella_Giro'. È possibile spostarla o rimuoverla se necessario.
        Me.Tabella_GiroTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Giro)
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Tabella_Quartiere'. È possibile spostarla o rimuoverla se necessario.
        Me.Tabella_QuartiereTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Quartiere)
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.PI'. È possibile spostarla o rimuoverla se necessario.
        Me.PITableAdapter.Fill(Me.ASDDBDataSet.PI)

    End Sub

    Private Sub UltraGridPI_BeforeRowInsert(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowInsertEventArgs) Handles UltraGridPI.BeforeRowInsert
        If MsgBox("sei sicuro di aggiungere una nuova riga?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
            e.Cancel = True
        End If
    End Sub

    Private Sub UltraGridPI_BeforeRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelableRowEventArgs) Handles UltraGridPI.BeforeRowUpdate
        MsgBox("Devo verificare i dati aggiornati, se e solo se l'opzione di verifica è attiva")
    End Sub

    Private Sub UltraGridPI_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridPI.InitializeLayout
        e.Layout.Bands(0).Columns("Tipologia").ValueList = UltraDropDownTipologia
        e.Layout.Bands(0).Columns("Classe").ValueList = UltraDropDownClasse
        e.Layout.Bands(0).Columns("Quartiere").ValueList = UltraDropDownQuartiere
        e.Layout.Bands(0).Columns("Giro").ValueList = UltraDropDownGiro
        e.Layout.Bands(0).Columns("GiroAlternativo").ValueList = UltraDropDownGiro
        e.Layout.Bands(0).Columns("Età").ValueList = UltraDropDownEtà
        e.Layout.Bands(0).Columns("Fruizione").ValueList = UltraDropDownFruizione
        e.Layout.Bands(0).Columns("Dispencer").ValueList = UltraDropDownDispencer
        e.Layout.Bands(0).Columns("Accettazione").ValueList = UltraDropDownAccettazione
        'e.Layout.Bands(0).Columns("Giro").ValueList = UltraDropDownGiro
    End Sub

    Private Sub UltraGridPI_AfterSelectChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles UltraGridPI.AfterSelectChange
        UltraStatusBar.Panels(0).Text = "Righe selezionate: " & UltraGridPI.Selected.Rows.Count
    End Sub

    Private Sub UltraButtonEsportaExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonEsportaExcel.Click
        UltraGridExcelExporter1.Export(UltraGridPI, "PI.xls")
    End Sub

    Private Sub UltraGridDocumentExporter1_RowExporting(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DocumentExport.RowExportingEventArgs) Handles UltraGridDocumentExporter1.RowExporting
        UltraStatusBar.Panels(0).Text = "Sto esportando la riga: " & e.GridRow.Index & " di " & UltraGridPI.Rows.Count
        UltraStatusBar.Refresh()
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonEsportaPDF.Click
        UltraGridDocumentExporter1.Export(UltraGridPI, "PI.pdf", Infragistics.Win.UltraWinGrid.DocumentExport.GridExportFileFormat.PDF)
    End Sub

    Private Sub UltraGridExcelExporter1_RowExporting(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.ExcelExport.RowExportingEventArgs) Handles UltraGridExcelExporter1.RowExporting
        UltraStatusBar.Panels(0).Text = "Sto esportando la riga: " & e.GridRow.Index & " di " & UltraGridPI.Rows.Count
        UltraStatusBar.Refresh()
    End Sub

    Private Sub UltraGridPI_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridPI.AfterCellUpdate
        Me.PITableAdapter.Update(Me.ASDDBDataSet.PI)
    End Sub

    Private Sub Form_Gestione_PI_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.PITableAdapter.Update(Me.ASDDBDataSet.PI)
    End Sub
End Class