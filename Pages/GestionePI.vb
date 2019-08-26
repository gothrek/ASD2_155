Imports System.IO

Public Class GestionePI

    Private Sub GestionePI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Form1.UltraStatusBar1.Panels(0).Text = "Righe selezionate: 0"
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
        Form1.UltraStatusBar1.Panels(0).Text = "Righe selezionate: " & UltraGridPI.Selected.Rows.Count
    End Sub

    Private Sub UltraButtonEsportaExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonEsportaExcel.Click
        Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString & "PI"
        Dim nomefile As String = "PI" & "-" & Today.Year & "-" & Today.Month & "-" & Today.Day & ".xls"
        Try
            System.IO.Directory.CreateDirectory(percorso)
        Catch ex As Exception
            'la directory già esiste
        End Try
        UltraGridExcelExporter1.Export(UltraGridPI, percorso & "\" & nomefile)
    End Sub

    Private Sub UltraGridDocumentExporter1_RowExporting(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DocumentExport.RowExportingEventArgs) Handles UltraGridDocumentExporter1.RowExporting
        Form1.UltraStatusBar1.Panels(0).Text = "Sto esportando la riga: " & e.GridRow.Index & " di " & UltraGridPI.Rows.Count
        Form1.UltraStatusBar1.Refresh()
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonEsportaPDF.Click
        Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString & "PI"
        Dim nomefile As String = "PI" & "-" & Today.Year & "-" & Today.Month & "-" & Today.Day & ".pdf"
        Try
            System.IO.Directory.CreateDirectory(percorso)
        Catch ex As Exception
            'la directory già esiste
        End Try
        If MsgBox("ATTENZIONE!! Il processo potrebbe richiedere diversi minuti, si è sicuri di voler procedere?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            UltraGridDocumentExporter1.Export(UltraGridPI, percorso & "\" & nomefile, Infragistics.Win.UltraWinGrid.DocumentExport.GridExportFileFormat.PDF)
        End If
    End Sub

    Private Sub UltraGridExcelExporter1_RowExporting(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.ExcelExport.RowExportingEventArgs) Handles UltraGridExcelExporter1.RowExporting
        Form1.UltraStatusBar1.Panels(0).Text = "Sto esportando la riga: " & e.GridRow.Index & " di " & UltraGridPI.Rows.Count
        Form1.UltraStatusBar1.Refresh()
    End Sub

    Private Sub UltraGridPI_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridPI.AfterCellUpdate
        Me.PITableAdapter.Update(Me.ASDDBDataSet.PI)
    End Sub

    Private Sub UltraButtonImporta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonImporta.Click
        Form1.UltraStatusBar1.Panels(0).Text = "Sto caricando i dati dei PI da Excel."
        Form1.UltraStatusBar1.Refresh()
        For i As Integer = UltraGridExcel.Rows.Count - 1 To 0 Step -1
            UltraGridExcel.Rows(i).Delete(False)
        Next
        Try
            'Read the copied data from the Clipboard
            Dim objPresumablyExcel As IDataObject = Clipboard.GetDataObject()

            'Proceed if some copied data is present
            If Not objPresumablyExcel Is Nothing Then

                'Next proceed only of the copied data is in the CSV format indicating Excel content
                If (objPresumablyExcel.GetDataPresent(DataFormats.CommaSeparatedValue)) Then

                    'Cast the copied data in the CommaSeparatedValue format & hold in a StreamReader Object
                    Dim srReadExcel As New StreamReader(CType(objPresumablyExcel.GetData(DataFormats.CommaSeparatedValue), Stream))
                    Dim sFormattedData As String

                    'Set the delimiter character for use in splitting the copied data
                    Dim charDelimiterArray() As Char = {";"}

                    'Define a DataTable to hold the copied data for binding to the DataGrid
                    Dim tblExcel2WinData As New DataTable

                    'Loop till no further data is available
                    While (srReadExcel.Peek() > 0)
                        'Array to hold the split data for each row
                        Dim arrSplitData As Array

                        'Multipurpose Loop Counter
                        Dim iLoopCounter As Integer = 0

                        'Read a line of data from the StreamReader object
                        sFormattedData = srReadExcel.ReadLine()

                        'Split the string contents into an array
                        arrSplitData = sFormattedData.Split(charDelimiterArray)

                        If tblExcel2WinData.Columns.Count <= 0 Then
                            For iLoopCounter = 0 To arrSplitData.GetUpperBound(0)
                                tblExcel2WinData.Columns.Add()
                            Next
                            iLoopCounter = 0
                        End If

                        'Row to hold a single row of the Excel Data
                        Dim rowNew As DataRow
                        rowNew = tblExcel2WinData.NewRow()


                        For iLoopCounter = 0 To arrSplitData.GetUpperBound(0)
                            rowNew(iLoopCounter) = arrSplitData.GetValue(iLoopCounter)
                        Next
                        iLoopCounter = 0

                        'Add the row back to the DataTable
                        tblExcel2WinData.Rows.Add(rowNew)

                        rowNew = Nothing
                    End While

                    'Close the StreamReader object
                    srReadExcel.Close()

                    For i As Integer = 0 To tblExcel2WinData.Rows.Count - 1
                        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int((i + 1) / (tblExcel2WinData.Rows.Count) * 100)
                        Form1.UltraStatusBar1.Refresh()
                        UltraGridExcel.DisplayLayout.Bands(0).AddNew()
                        UltraGridExcel.Rows(i).Cells("Stato").Value = "Importata"
                        UltraGridExcel.Rows(i).Cells("Tipologia").Value = tblExcel2WinData.Rows(i).Item(0)
                        UltraGridExcel.Rows(i).Cells("Classe").Value = tblExcel2WinData.Rows(i).Item(1)
                        UltraGridExcel.Rows(i).Cells("RagioneSociale").Value = tblExcel2WinData.Rows(i).Item(2)
                        UltraGridExcel.Rows(i).Cells("Indirizzo").Value = tblExcel2WinData.Rows(i).Item(3)
                        UltraGridExcel.Rows(i).Cells("NumeroCivico").Value = tblExcel2WinData.Rows(i).Item(4)
                        UltraGridExcel.Rows(i).Cells("CAP").Value = tblExcel2WinData.Rows(i).Item(5)
                        UltraGridExcel.Rows(i).Cells("Quartiere").Value = tblExcel2WinData.Rows(i).Item(6)
                        UltraGridExcel.Rows(i).Cells("Telefono").Value = tblExcel2WinData.Rows(i).Item(7)
                        UltraGridExcel.Rows(i).Cells("Referente").Value = tblExcel2WinData.Rows(i).Item(8)
                        UltraGridExcel.Rows(i).Cells("Giro").Value = tblExcel2WinData.Rows(i).Item(9)
                        UltraGridExcel.Rows(i).Cells("Percorrenza").Value = tblExcel2WinData.Rows(i).Item(10)
                        UltraGridExcel.Rows(i).Cells("GiroAlternativo").Value = tblExcel2WinData.Rows(i).Item(11)
                        UltraGridExcel.Rows(i).Cells("Percorrenza Alternativa").Value = tblExcel2WinData.Rows(i).Item(12)
                        UltraGridExcel.Rows(i).Cells("ChiusuraLu").Value = tblExcel2WinData.Rows(i).Item(13)
                        UltraGridExcel.Rows(i).Cells("ChiusuraMa").Value = tblExcel2WinData.Rows(i).Item(14)
                        UltraGridExcel.Rows(i).Cells("ChiusuraMe").Value = tblExcel2WinData.Rows(i).Item(15)
                        UltraGridExcel.Rows(i).Cells("ChiusuraGi").Value = tblExcel2WinData.Rows(i).Item(16)
                        UltraGridExcel.Rows(i).Cells("ChiusuraVe").Value = tblExcel2WinData.Rows(i).Item(17)
                        UltraGridExcel.Rows(i).Cells("ChiusuraSa").Value = tblExcel2WinData.Rows(i).Item(18)
                        UltraGridExcel.Rows(i).Cells("ChiusuraDo").Value = tblExcel2WinData.Rows(i).Item(19)
                        UltraGridExcel.Rows(i).Cells("Età").Value = tblExcel2WinData.Rows(i).Item(20)
                        UltraGridExcel.Rows(i).Cells("Fruizione").Value = tblExcel2WinData.Rows(i).Item(21)
                        UltraGridExcel.Rows(i).Cells("Dispencer").Value = tblExcel2WinData.Rows(i).Item(22)
                        UltraGridExcel.Rows(i).Cells("Accettazione").Value = tblExcel2WinData.Rows(i).Item(23)
                        UltraGridExcel.Rows(i).Cells("Note").Value = tblExcel2WinData.Rows(i).Item(24)
                    Next

                    Dim k As Integer = 0
                    Dim trovato As Boolean = False
                    Dim errori As Boolean = False
                    'VEFIRICA SE I PI GIA' ESISTONO todo
                    
                    UltraGridExcel.Visible = True
                    If errori Then
                        Form1.UltraStatusBar1.Panels(0).Text = "Importazione fallita!!"
                        Form1.UltraStatusBar1.Refresh()
                        MsgBox("Impossibile importare uno o più PI, verificare i dati e riprovare!!", MsgBoxStyle.Critical)
                    Else
                        trovato = False
                        k = 0
                        Form1.UltraStatusBar1.Panels(0).Text = "Dati della distribuzione importati correttamente."
                        Form1.UltraStatusBar1.Refresh()
                        Dim sino As Integer = MsgBox("Dati della distribuzione importati correttamente. Confermi l'inserimento nella tabella dei PI? (l'operazione sarà irreversibile)", MsgBoxStyle.YesNo)
                        If sino = MsgBoxResult.Yes Then
                            For i As Integer = 0 To UltraGridExcel.Rows.Count - 1
                                Try
                                    PITableAdapter.Insert(UltraGridExcel.Rows(i).Cells("Tipologia").Value, UltraGridExcel.Rows(i).Cells("Classe").Value, UltraGridExcel.Rows(i).Cells("RagioneSociale").Value, UltraGridExcel.Rows(i).Cells("Indirizzo").Value, UltraGridExcel.Rows(i).Cells("NumeroCivico").Value, UltraGridExcel.Rows(i).Cells("CAP").Value, UltraGridExcel.Rows(i).Cells("Quartiere").Value, UltraGridExcel.Rows(i).Cells("Telefono").Value, UltraGridExcel.Rows(i).Cells("Referente").Value, UltraGridExcel.Rows(i).Cells("Giro").Value, UltraGridExcel.Rows(i).Cells("Percorrenza").Value, "MAI", UltraGridExcel.Rows(i).Cells("Dispencer").Value, UltraGridExcel.Rows(i).Cells("Accettazione").Value, UltraGridExcel.Rows(i).Cells("Note").Value, Today, Today, "True", UltraGridExcel.Rows(i).Cells("ChiusuraDo").Value, UltraGridExcel.Rows(i).Cells("ChiusuraGi").Value, UltraGridExcel.Rows(i).Cells("ChiusuraLu").Value, UltraGridExcel.Rows(i).Cells("ChiusuraMa").Value, UltraGridExcel.Rows(i).Cells("ChiusuraMe").Value, UltraGridExcel.Rows(i).Cells("ChiusuraSa").Value, UltraGridExcel.Rows(i).Cells("ChiusuraVe").Value, UltraGridExcel.Rows(i).Cells("Età").Value, UltraGridExcel.Rows(i).Cells("Fruizione").Value, UltraGridExcel.Rows(i).Cells("GiroAlternativo").Value, UltraGridExcel.Rows(i).Cells("Percorrenza Alternativa").Value)
                                    Me.ASDDBDataSet.PI.AcceptChanges()
                                    UltraGridPI.Refresh()
                                    Me.PITableAdapter.Update(Me.ASDDBDataSet.PI)
                                    Me.PITableAdapter.Fill(Me.ASDDBDataSet.PI)
                                    UltraGridPI.Refresh()
                                    UltraGridExcel.Rows(i).Cells("Stato").Value = "Ok"
                                Catch ex As Exception
                                    UltraGridExcel.Rows(i).Cells("Stato").Value = "Errore"
                                End Try
                            Next
                            MsgBox("Importazione completata con successo!!")
                        End If
                    End If
                Else
                    Form1.UltraStatusBar1.Panels(0).Text = "Importazione fallita!!"
                    Form1.UltraStatusBar1.Refresh()
                    MsgBox("I dati copiati non sono di Excel, verifica!", MsgBoxStyle.Critical)
                End If
            Else
                Form1.UltraStatusBar1.Panels(0).Text = "Importazione fallita!!"
                Form1.UltraStatusBar1.Refresh()
                MsgBox("Non c'è nulla di copiato, verifica!", MsgBoxStyle.Information)
            End If
        Catch exp As Exception
            MsgBox(exp.Message)
        End Try
    End Sub

    Private Sub GestionePI_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        Me.PITableAdapter.Update(Me.ASDDBDataSet.PI)
        Me.Validate()
        Me.PIBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)
    End Sub

    Private Sub UltraGridExcelExporter1_ExportEnded(sender As System.Object, e As Infragistics.Win.UltraWinGrid.ExcelExport.ExportEndedEventArgs) Handles UltraGridExcelExporter1.ExportEnded
        Form1.UltraStatusBar1.Panels(0).Text = "File esportato con successo."
        Form1.UltraStatusBar1.Refresh()
    End Sub

    Private Sub UltraGridDocumentExporter1_ExportEnded(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DocumentExport.ExportEndedEventArgs) Handles UltraGridDocumentExporter1.ExportEnded
        Form1.UltraStatusBar1.Panels(0).Text = "File esportato con successo."
        Form1.UltraStatusBar1.Refresh()
    End Sub
End Class
