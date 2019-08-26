Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports System.IO

Public Class DistribuzioneTestata
    Dim caricato As Boolean = False
    Dim salvaechiudi As Boolean = False
    Dim indicecolonna As Integer = 100
    Dim contatorenuovo As Integer = 0
    Dim contatoremodificato As Integer = 0
    Dim contatoreeliminato As Integer = 0
    Dim caratteripermessi As Boolean = False

    Private Sub DistribuzioneTestata_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.QTabella_Distribuzioni'. È possibile spostarla o rimuoverla se necessario.
        Me.QTabella_DistribuzioniTableAdapter.Fill(Me.ASDDBDataSet.QTabella_Distribuzioni)
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.PI'. È possibile spostarla o rimuoverla se necessario.
        Me.PITableAdapter.Fill(Me.ASDDBDataSet.PI)
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Tabella_Distribuzioni'. È possibile spostarla o rimuoverla se necessario.
        Me.Tabella_DistribuzioniTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Distribuzioni)
        Me.QCodiciAlternativiTableAdapter.Fill(Me.ASDDBDataSet.QCodiciAlternativi)
        'Try
        '    UltraComboCodiciAlternativi.SetInitialValue(Me.ASDDBDataSet.QCodiciAlternativi.Rows(0).Item(0), Me.ASDDBDataSet.QCodiciAlternativi.Rows(0).Item(0))
        'Catch ex As Exception
        '    UltraComboCodiciAlternativi.SetInitialValue("", "Nessuna combinazione")
        '    UltraComboCodiciAlternativi.Enabled = False
        '    UltraCheckEditorCodiciAlternativi.Enabled = False
        'End Try

        Form1.UltraStatusBar1.Panels(0).Text = "Hai selezionato 0 righe."
    End Sub

    Private Sub UltraComboTestata_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraComboTestata.TextChanged
        caricato = False
        Try
            Me.Tabella_DistribuzioniTableAdapter.FillByTestata(Me.ASDDBDataSet.Tabella_Distribuzioni, UltraComboTestata.Text)
            UltraComboDistribuzione.Enabled = True
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UltraButtonCarica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonCarica.Click
        Dim indice As Integer = 0
        Dim i As Integer = 0
        Form1.UltraStatusBar1.Panels(2).Text = ""
        Form1.UltraStatusBar1.Refresh()
        UltraGridPIEliminati.Enabled = True
        UltraButtonEsportaPIEliminati.Enabled = True
        UltraButtonStampaPIEliminati.Enabled = True
        UltraButtonEliminaSelezionati.Enabled = True
        Form1.UltraStatusBar1.Panels(0).Text = "Sto caricando i dati della distribuzione."
        Form1.UltraStatusBar1.Panels(1).Style = UltraWinStatusBar.PanelStyle.Marquee
        Form1.UltraStatusBar1.Panels(1).Visible = True
        Form1.UltraStatusBar1.Refresh()
        UltraFormattedTextEditorSalva.Text = UltraComboDistribuzione.Text
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Esclusioni'. È possibile spostarla o rimuoverla se necessario.
        Me.EsclusioniTableAdapter.FillByTestata(Me.ASDDBDataSet.Esclusioni, UltraComboTestata.Text)
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Distribuzione'. È possibile spostarla o rimuoverla se necessario.
        Me.DistribuzioneTableAdapter.FillByDistro(Me.ASDDBDataSet.Distribuzione, UltraComboTestata.Text, UltraComboDistribuzione.Text)
        Do
            If UltraGridDistribuzione.Rows.Count > 0 Then
                'Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(i / (UltraGridPI.Rows.Count - 1) * 100)
                'Form1.UltraStatusBar1.Refresh()
                If UltraGridPI.Rows(i).Cells("PI").Value = UltraGridDistribuzione.Rows(indice).Cells("PI").Value Then
                    UltraGridPI.Rows(i).Cells("Copie").Value = UltraGridDistribuzione.Rows(indice).Cells("Copie").Value
                    indice = indice + 1
                Else
                    UltraGridPI.Rows(i).Cells("Copie").Value = 0
                End If
                i = i + 1
            Else
                indice = UltraGridDistribuzione.Rows.Count
            End If
        Loop Until indice = UltraGridDistribuzione.Rows.Count
        For k As Integer = i To UltraGridPI.Rows.Count - 1
            'Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(k / (UltraGridPI.Rows.Count - 1) * 100)
            UltraGridPI.Rows(k).Cells("Copie").Value = 0
        Next
        caricato = True
        contatorenuovo = 0
        contatoremodificato = 0
        contatoreeliminato = 0
        Form1.UltraStatusBar1.Panels(0).Text = "Dati della distribuzione caricati correttamente."
        Form1.UltraStatusBar1.Panels(1).Style = UltraWinStatusBar.PanelStyle.Progress
        Form1.UltraStatusBar1.Panels(1).Visible = False
        Form1.UltraStatusBar1.Refresh()
        UltraGridPI.Rows(0).Cells("Copie").Value = UltraGridPI.Rows(0).Cells("Copie").Value
        UltraButtonCarica.Enabled = False
        MsgBox("Dati della distribuzione caricati correttamente.")
    End Sub

    Private Sub UltraButtonMultiassegnazione_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonMultiassegnazione.Click
        If ((UltraGridPI.Selected.Rows.Count > 1) And (UltraFormattedTextEditorMultiassegnazione.Text.Length > 0)) Then
            Form1.UltraStatusBar1.Panels(0).Text = "Sto assegnando il numero delle copie ai PI selezionati."
            Dim k As Integer = 0
            For Each pi As UltraGridRow In UltraGridPI.Selected.Rows
                Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(k / (UltraGridPI.Selected.Rows.Count - 1) * 100)
                Form1.UltraStatusBar1.Refresh()
                pi.Cells("Copie").Value = UltraFormattedTextEditorMultiassegnazione.Text
                k = k + 1
                'UltraGridPI.Update()
            Next
            Form1.UltraStatusBar1.Panels(0).Text = "Dati assegnati correttamente."
            Form1.UltraStatusBar1.Refresh()
        Else
            MsgBox("Per usare la multiassegnazione bisogna selezionare almeno 2 righe e impostare un valore valido nelle copie.", MsgBoxStyle.Exclamation)
        End If

    End Sub

    'Private Sub FormDistribuzione_Testata_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    '    If Not salvaechiudi Then 'controlla se la distribuzione è già stata salvata
    '        Dim salvataggio As Integer = MsgBox("Vuoi salvare le modifiche apportate a " & " punti?", MsgBoxStyle.YesNoCancel)
    '        Select Case salvataggio
    '            Case MsgBoxResult.Yes
    '                For i As Integer = UltraGridDistribuzione.Rows.Count - 1 To 0 Step -1
    '                    If UltraGridDistribuzione.Rows(i).Cells("Stato").Value = "Eliminato" Then
    '                        UltraGridDistribuzione.Rows(i).Delete(False) 'DA IMPOSTARE LA FINESTRA DI DELETE
    '                    End If
    '                Next
    '                UltraGridDistribuzione.UpdateData()
    '                UltraGridPIEliminati.UpdateData()
    '                Try
    '                    Me.DistribuzioneTableAdapter.Update(Me.ASDDBDataSet.Distribuzione)
    '                    Me.EsclusioniTableAdapter.Update(Me.ASDDBDataSet.Esclusioni)
    '                Catch
    '                End Try
    '            Case MsgBoxResult.Cancel
    '                e.Cancel = True
    '            Case Else
    '                'Salvataggio annullato dall'utente
    '        End Select
    '    End If
    'End Sub

    Private Sub UltraGridPI_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridPI.AfterCellUpdate
        If Not e.Cell.IsFilterRowCell Then
            Dim trovato As Boolean = False
            Dim i As Integer = 0
            If caricato Then
                Try
                    If UltraGridDistribuzione.Rows.Count > 0 Then
                        Do
                            If (UltraGridDistribuzione.Rows(i).Cells("PI").Value = e.Cell.Row.Cells("PI").Value) Then
                                Select Case UltraGridDistribuzione.Rows(i).Cells("Stato").Value
                                    Case "Nuovo"
                                        contatorenuovo = contatorenuovo - 1
                                    Case "Modificato"
                                        contatoremodificato = contatoremodificato - 1
                                    Case "Eliminato"
                                        contatoreeliminato = contatoreeliminato - 1
                                End Select
                                If UltraGridDistribuzione.Rows(i).Cells("Copie").Value <> e.Cell.Value Then
                                    UltraGridDistribuzione.Rows(i).Cells("Copie").Value = e.Cell.Value
                                    If e.Cell.Value > 0 Then
                                        If UltraGridDistribuzione.Rows(i).Cells("Stato").Value <> "Nuovo" Then
                                            UltraGridDistribuzione.Rows(i).Cells("Stato").Value = "Modificato"
                                            contatoremodificato = contatoremodificato + 1
                                        Else
                                            contatorenuovo = contatorenuovo + 1
                                        End If
                                    Else
                                        If UltraGridDistribuzione.Rows(i).Cells("Stato").Value <> "Nuovo" Then
                                            contatoreeliminato = contatoreeliminato + 1
                                        End If
                                        UltraGridDistribuzione.Rows(i).Cells("Stato").Value = "Eliminato"
                                    End If
                                End If
                                trovato = True
                            End If
                            i = i + 1
                        Loop Until trovato Or (i = UltraGridDistribuzione.Rows.Count)
                    End If
                    If (Not trovato) And (e.Cell.Value > 0) Then
                        'And (UltraFormattedTextEditorMultiassegnazione.Text > 0) Then PERCHE lo avevo messo?
                        UltraGridDistribuzione.DisplayLayout.Bands(0).AddNew()
                        'UltraGridDistribuzione.Refresh()
                        UltraGridDistribuzione.Rows(UltraGridDistribuzione.Rows.Count - 1).Cells("Testata").Value = UltraComboTestata.Value
                        UltraGridDistribuzione.Rows(UltraGridDistribuzione.Rows.Count - 1).Cells("Distribuzione").Value = UltraComboDistribuzione.Value
                        UltraGridDistribuzione.Rows(UltraGridDistribuzione.Rows.Count - 1).Cells("PI").Value = e.Cell.Row.Cells(0).Value
                        UltraGridDistribuzione.Rows(UltraGridDistribuzione.Rows.Count - 1).Cells("Copie").Value = e.Cell.Value
                        UltraGridDistribuzione.Rows(UltraGridDistribuzione.Rows.Count - 1).Cells("Stato").Value = "Nuovo"
                        contatorenuovo = contatorenuovo + 1
                    End If
                    UltraGridDistribuzione.DisplayLayout.Bands(0).Columns("PI").SortIndicator = SortIndicator.Ascending
                    Form1.UltraStatusBar1.Panels(2).Text = "PI nuovi:" & contatorenuovo & " - PI modificati:" & contatoremodificato & " - PI cancellati:" & contatoreeliminato
                    Form1.UltraStatusBar1.Refresh()
                Catch
                End Try
            End If
        Else
            'filtro
        End If
    End Sub

    Private Sub UltraGridPI_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UltraGridPI.KeyPress
        If Not caratteripermessi Then
            Select Case e.KeyChar
                Case "0" To "9"
                Case ChrW(Keys.Return)
                Case ChrW(Keys.Delete)
                Case ChrW(Keys.Back)
                Case ChrW(Keys.Escape)
                Case Else
                    MsgBox("Carattere non valido!!", MsgBoxStyle.Exclamation)
                    e.Handled = True
            End Select
        End If
    End Sub

    Private Sub UltraButtonImporta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonImporta.Click
        Form1.UltraStatusBar1.Panels(0).Text = "Sto caricando i dati della distribuzione da Excel."
        Form1.UltraStatusBar1.Panels(1).Style = UltraWinStatusBar.PanelStyle.Marquee
        Form1.UltraStatusBar1.Panels(1).Visible = True
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

                    'Bind the data to the DataGrid
                    'DataGridViewExcel.DataSource = tblExcel2WinData.DefaultView()
                    'UltraGridExcel.DataSource = tblExcel2WinData.DefaultView()
                    Form1.UltraStatusBar1.Panels(1).Style = UltraWinStatusBar.PanelStyle.Progress
                    Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Maximum = 100
                    Form1.UltraStatusBar1.Refresh()
                    For i As Integer = 0 To tblExcel2WinData.Rows.Count - 1
                        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(i / (tblExcel2WinData.Rows.Count - 1) * 100)
                        Form1.UltraStatusBar1.Refresh()
                        UltraGridExcel.DisplayLayout.Bands(0).AddNew()
                        UltraGridExcel.Rows(i).Cells("Stato").Value = " - "
                        UltraGridExcel.Rows(i).Cells("PI").Value = tblExcel2WinData.Rows(i).Item(0)
                        UltraGridExcel.Rows(i).Cells("Copie").Value = tblExcel2WinData.Rows(i).Item(1)
                    Next

                    Dim dtalternativi As New DataTable("Alternativi", "Alternativi")
                    Dim dvalternativi As New DataView
                    Dim j As Integer = 0
                    Dim k As Integer = 0
                    Dim trovato As Boolean = False
                    Dim errori As Boolean = False
                    If UltraCheckEditorCodiciAlternativi.Checked And (UltraComboCodiciAlternativi.Text <> "") Then 'verifica se sono attivi i codici alternativi
                        Me.Codici_AlternativiTableAdapter.FillByTipologia(Me.ASDDBDataSet.Codici_Alternativi, UltraComboCodiciAlternativi.Text)
                        dvalternativi.Table = Me.Codici_AlternativiTableAdapter.GetDataByTipologia(UltraComboCodiciAlternativi.Text)
                        For k = 0 To UltraGridExcel.Rows.Count - 1
                            Do
                                If dvalternativi.Item(j).Item("Alternativo") = UltraGridExcel.Rows(k).Cells("PI").Value Then
                                    trovato = True
                                    UltraGridExcel.Rows(k).Cells("PI").Value = dvalternativi.Item(j).Item("PI")
                                Else
                                    j = j + 1
                                End If
                            Loop Until trovato Or (j = dvalternativi.Count)
                            If Not trovato Then
                                UltraGridExcel.Rows(k).Cells("Stato").Value = "PI Non trovato"
                                errori = True
                            End If
                            j = 0
                            trovato = False
                        Next

                    Else
                        For i As Integer = 0 To UltraGridExcel.Rows.Count - 1
                            Do
                                If UltraGridPI.Rows(k).Cells("PI").Value = UltraGridExcel.Rows(i).Cells("PI").Value Then
                                    Try
                                        If UltraGridExcel.Rows(i).Cells("Copie").Value = "" Then 'a cella vuota in excel corrisponde il valore 0
                                            UltraGridExcel.Rows(i).Cells("Copie").Value = 0
                                        Else
                                            UltraGridExcel.Rows(i).Cells("Copie").Value = Int(UltraGridExcel.Rows(i).Cells("Copie").Value)
                                        End If
                                        UltraGridExcel.Rows(i).Cells("Stato").Value = "Ok"
                                    Catch ex As Exception
                                        UltraGridExcel.Rows(i).Cells("Stato").Value = "Dato errato"
                                        errori = True
                                    End Try
                                    trovato = True
                                End If
                                k = k + 1
                            Loop Until trovato Or (k = UltraGridPI.Rows.Count)
                            If Not trovato Then
                                UltraGridExcel.Rows(i).Cells("Stato").Value = "PI Non trovato"
                                errori = True
                            End If
                            k = 0
                            trovato = False
                        Next

                    End If

                    UltraGridExcel.Visible = True
                    If errori Then
                        Form1.UltraStatusBar1.Panels(0).Text = "Importazione fallita!!"
                        Form1.UltraStatusBar1.Refresh()
                        MsgBox("Impossibile importare uno o più PI, verificare i dati e riprovare!!", MsgBoxStyle.Critical)
                    Else
                        trovato = False
                        k = 0
                        Form1.UltraStatusBar1.Panels(0).Text = "Dati della distribuzione importati correttamente."
                        Form1.UltraStatusBar1.Panels(1).Visible = False
                        Form1.UltraStatusBar1.Refresh()
                        Dim risultato As Integer = MsgBox("I dati importati devono essere uniti agli attuali? (se si sceglie NO verranno eliminati tutti i dati presenti e sostituiti con i nuovi)", MsgBoxStyle.YesNoCancel)
                        Select Case risultato
                            Case MsgBoxResult.Yes 'unione e modifica dei vecchi dati di distribuzione
                                For i As Integer = 0 To UltraGridExcel.Rows.Count - 1
                                    Do
                                        If UltraGridPI.Rows(k).Cells("PI").Value = UltraGridExcel.Rows(i).Cells("PI").Value Then
                                            UltraGridPI.Rows(k).Cells("Copie").Value = UltraGridExcel.Rows(i).Cells("Copie").Value
                                            trovato = True
                                        End If
                                        k = k + 1
                                    Loop Until trovato Or (k = UltraGridPI.Rows.Count)
                                    k = 0
                                    trovato = False
                                Next
                                MsgBox("Importazione completata con successo!!")
                            Case MsgBoxResult.No 'sovrascrittura e eliminazione dei vecchi dati di ditribuzione
                                Dim risultato2 As Integer = MsgBox("ATTENZIONE!! Saranno persi i dati di distribuzione e sostituiti con il flusso in entrata, procedere?", MsgBoxStyle.YesNo)
                                If risultato2 = MsgBoxResult.Yes Then
                                    MsgBox(UltraGridDistribuzione.Rows.Count)
                                    For i As Integer = 0 To UltraGridPI.Rows.Count - 1

                                        'Do
                                        'If UltraGridDistribuzione.Rows(i).Cells("PI").Value = UltraGridPI.Rows(k).Cells("PI").Value Then
                                        'UltraGridPI.Rows(k).Cells("Copie").Value = 0
                                        If UltraGridPI.Rows(i).Cells("Copie").Value > 0 Then
                                            UltraGridPI.Rows(i).Cells("Copie").Value = 0
                                        End If
                                        'trovato = True
                                        'End If
                                        'k = k + 1
                                        'Loop Until trovato
                                    Next
                                    trovato = False
                                    k = 0
                                    For i As Integer = 0 To UltraGridExcel.Rows.Count - 1
                                        Do
                                            If UltraGridPI.Rows(k).Cells("PI").Value = UltraGridExcel.Rows(i).Cells("PI").Value Then
                                                UltraGridPI.Rows(k).Cells("Copie").Value = UltraGridExcel.Rows(i).Cells("Copie").Value
                                                trovato = True
                                            End If
                                            k = k + 1
                                        Loop Until trovato Or (k = UltraGridPI.Rows.Count)
                                        k = 0
                                        trovato = False
                                    Next
                                    MsgBox("Importazione completata con successo!!")
                                End If
                            Case Else
                                'Importazione annullata dall'utente
                        End Select
                    End If
                Else
                    Form1.UltraStatusBar1.Panels(0).Text = "Importazione fallita!!"
                    Form1.UltraStatusBar1.Panels(1).Visible = False
                    Form1.UltraStatusBar1.Refresh()
                    MsgBox("I dati copiati non sono di Excel, verifica!", MsgBoxStyle.Critical)
                End If
            Else
                Form1.UltraStatusBar1.Panels(0).Text = "Importazione fallita!!"
                Form1.UltraStatusBar1.Panels(1).Visible = False
                Form1.UltraStatusBar1.Refresh()
                MsgBox("Non c'è nulla di copiato, verifica!", MsgBoxStyle.Information)
            End If
        Catch exp As Exception
            MsgBox(exp.Message)
        End Try
        Form1.UltraStatusBar1.Panels(1).Visible = False
        Form1.UltraStatusBar1.Refresh()
    End Sub

    Private Sub UltraButtonPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonPrint.Click
        'UltraPrintPreviewDialogDistribuzione.CreateControl()
        caricato = False
        'NOTA
        'MsgBox(UltraGridPI.DisplayLayout.Bands(0).ColumnFilters("Copie").FilterConditions.Item(0).ComparisionOperator)
        UltraGridPI.DisplayLayout.Bands(0).ColumnFilters("Copie").FilterConditions.Add(FilterComparisionOperator.GreaterThan, 0)
        'UltraGridPI.DisplayLayout.Bands(0).ColumnFilters("Copie").FilterConditions.
        'UltraGridPI.DisplayLayout.Bands(0).ColumnFilters("Copie").FilterConditions.Item(0).ComparisionOperator = FilterComparisionOperator.GreaterThan
        'UltraGridPI.DisplayLayout.Bands(0).ColumnFilters("Copie").FilterConditions.Item(0).CompareValue = 0
        'verificare prima se è stato fatto un filtro per maggiore di 0 e chiedere conferma
        UltraGridPrintDocumentDistribuzione.DocumentName = "Distribuzione " & UltraComboTestata.Text & " - " & UltraComboDistribuzione.Text
        UltraPrintPreviewDialogDistribuzione.ShowDialog()
    End Sub

    Private Sub UltraButtonSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSalva.Click
        Dim modifica As Integer
        Dim tuttook As Boolean = False
        Form1.UltraStatusBar1.Panels(0).Text = "Salvataggio in corso!"
        Form1.UltraStatusBar1.Panels(1).Visible = True
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = 0
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Maximum = UltraGridDistribuzione.Rows.Count - 1
        Form1.UltraStatusBar1.Refresh()
        If UltraFormattedTextEditorSalva.Text = UltraComboDistribuzione.Text Then
            Tabella_DistribuzioniTableAdapter.UpdateQuerydatamodifica(UltraComboTestata.Text, UltraComboDistribuzione.Text, Today, UltraComboTestata.Text, UltraComboDistribuzione.Text)
            For i As Integer = UltraGridDistribuzione.Rows.Count - 1 To 0 Step -1
                Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = UltraGridDistribuzione.Rows.Count - 1 - i
                Form1.UltraStatusBar1.Refresh()
                If UltraGridDistribuzione.Rows(i).Cells("Stato").Value = "Eliminato" Then
                    UltraGridDistribuzione.Rows(i).Delete(False) 'DA IMPOSTARE LA FINESTRA DI DELETE
                Else
                    If ((UltraGridDistribuzione.Rows(i).Cells("Stato").Value = "Modificato") Or (UltraGridDistribuzione.Rows(i).Cells("Stato").Value = "Nuovo")) Then
                        PITableAdapter.UpdateQuerydatamodifica(Today, UltraGridDistribuzione.Rows(i).Cells("PI").Value)
                    End If
                End If
            Next
            UltraGridDistribuzione.UpdateData()
            UltraGridPIEliminati.UpdateData()
            Try
                Me.DistribuzioneTableAdapter.Update(Me.ASDDBDataSet.Distribuzione)
                Me.EsclusioniTableAdapter.Update(Me.ASDDBDataSet.Esclusioni)
            Catch
            End Try
            salvaechiudi = True
            tuttook = True
        Else
            modifica = MsgBox("Confermi la creazione di una nuova distribuzione? (l'operazione potrebbe richiedere diverso tempo)", MsgBoxStyle.YesNoCancel, "Salvataggio della distribuzione")
            'FUTURA VERSIONE modifica = MsgBox("Nuova distribuzione? (no per rinominare quella corrente)", MsgBoxStyle.YesNoCancel, "Salvataggio della distribuzione")
            Select Case modifica
                Case MsgBoxResult.Yes
                    Tabella_DistribuzioniTableAdapter.Insert(UltraComboTestata.Text, UltraFormattedTextEditorSalva.Text, True, "01/01/2008", Today, Today, "Nessuna")
                    salvaechiudi = True
                    For i As Integer = 0 To UltraGridDistribuzione.Rows.Count - 1
                        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = i
                        Form1.UltraStatusBar1.Refresh()
                        If UltraGridDistribuzione.Rows(i).Cells("Stato").Value <> "Eliminato" Then
                            Try
                                Me.DistribuzioneTableAdapter.Insert(UltraGridDistribuzione.Rows(i).Cells("Testata").Value, UltraFormattedTextEditorSalva.Text, UltraGridDistribuzione.Rows(i).Cells("PI").Value, UltraGridDistribuzione.Rows(i).Cells("Copie").Value)
                                'MsgBox("Distribuzione creata con successo.")
                                tuttook = True
                            Catch ex As Exception
                                tuttook = False
                                MsgBox("Comunicare il seguente errore: Cod.Err. 'DTcreazionedistro', motivo: " & ex.Message)
                            End Try
                        End If
                    Next
                    'MsgBox("La schermata verrà chiusa per aggiornare i dati.", MsgBoxStyle.OkOnly)
                    'ANDARE ALLO START
                    'Me.Close()
                Case MsgBoxResult.No
                    'FUTURA VERSIONE Dim k As Integer = 0
                    'FUTURA VERSIONE Dim trovato As Boolean = False
                    'FUTURA VERSIONE Do
                    'FUTURA VERSIONE If (ASDDBDataSet.Tabella_Distribuzioni.Rows(k).Item(0) = UltraComboTestata.Text) And (ASDDBDataSet.Tabella_Distribuzioni.Rows(k).Item(1) = UltraComboDistribuzione.Text) Then
                    'FUTURA VERSIONE trovato = True
                    'FUTURA VERSIONE Try
                    'FUTURA VERSIONE ASDDBDataSet.Tabella_Distribuzioni.Rows(k).Item(1) = UltraFormattedTextEditorSalva.Text
                    'FUTURA VERSIONE salvaechiudi = True
                    'FUTURA VERSIONE For i As Integer = UltraGridDistribuzione.Rows.Count - 1 To 0 Step -1
                    'FUTURA VERSIONE UltraGridDistribuzione.Rows(i).Cells("Distribuzione").Value = UltraFormattedTextEditorSalva.Text
                    'FUTURA VERSIONE If UltraGridDistribuzione.Rows(i).Cells("Stato").Value = "Eliminato" Then
                    'FUTURA VERSIONE UltraGridDistribuzione.Rows(i).Delete(False) 'DA IMPOSTARE LA FINESTRA DI DELETE
                    'FUTURA VERSIONE End If
                    'FUTURA VERSIONE Next
                    'FUTURA VERSIONE UltraGridDistribuzione.UpdateData()
                    'FUTURA VERSIONE 
                    'FUTURA VERSIONE Me.DistribuzioneTableAdapter.Update(Me.ASDDBDataSet.Distribuzione)
                    'FUTURA VERSIONE MsgBox("La schermata verrà chiusa  per aggiornare i dati.", MsgBoxStyle.OkOnly)
                    'FUTURA VERSIONE Me.Close()
                    'FUTURA VERSIONE Catch
                    'FUTURA VERSIONE MsgBox("Impossibile completare l'operazione! Distribuzione già esistente o altro errore di scrittura.", MsgBoxStyle.Critical)
                    'FUTURA VERSIONE trovato = True
                    'FUTURA VERSIONE End Try
                    'FUTURA VERSIONE End If
                    'FUTURA VERSIONE Loop Until trovato Or (k = ASDDBDataSet.Tabella_Distribuzioni.Rows.Count)
                Case Else
                    'Salvataggio annullato dall'utente
            End Select
        End If
        If tuttook Then
            MsgBox("Salvataggio effettuato con successo. Il programma tornerà alla pagina principale per aggiornare le tabelle.")
            Form1.UltraStatusBar1.Panels(1).Visible = False
            Form1.UltraStatusBar1.Panels(0).Text = ""
            Form1.UltraStatusBar1.Panels(2).Text = ""
            Form1.UltraStatusBar1.Refresh()
            Form1.ShowPage(PageKind.Startup)
        End If
    End Sub

    Private Sub UltraGridPI_AfterSelectChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs)
        Form1.UltraStatusBar1.Panels(0).Text = "Hai selezionato " & UltraGridPI.Selected.Rows.Count & " righe."
        Form1.UltraStatusBar1.Refresh()
    End Sub

    Private Sub UltraGridDistribuzione_AfterSelectChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs)
        Try
            MsgBox(Me.ASDDBDataSet.PI.FindByPI(UltraGridDistribuzione.Selected.Rows(0).Cells("PI").Value).RagioneSociale)
            UltraGridDistribuzione.Selected.Rows.Clear()
        Catch

        End Try
    End Sub

    Private Sub UltraButtonEsporta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonEsporta.Click
        MsgBox("Per avere la distribuzione dei soli PI con copie applicare prima il filtro e poi esportare.")
        Form1.UltraStatusBar1.Panels(1).Visible = True
        caricato = False
        Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString & "Distribuzioni"
        Try
            System.IO.Directory.CreateDirectory(percorso)
        Catch ex As Exception
            'la directory già esiste
        End Try
        Dim nomefile As String = "Distribuzione" & UltraComboTestata.Text & UltraComboDistribuzione.Text & "-" & Today.Year & "-" & Today.Month & "-" & Today.Day & ".xls"
        UltraGridExcelExporter2.Export(UltraGridPI, percorso & "\" & nomefile)
    End Sub

    Private Sub UltraGridExcelExporter2_RowExporting(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.ExcelExport.RowExportingEventArgs) Handles UltraGridExcelExporter2.RowExporting
        If Not caricato Then
            Form1.UltraStatusBar1.Panels(0).Text = "Sto esportando la riga: " & e.GridRow.Index & " di " & UltraGridPI.Rows.Count
            Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(e.CurrentRowIndex / (UltraGridPI.Rows.Count - 1) * 100)
        Else
            Form1.UltraStatusBar1.Panels(0).Text = "Sto esportando la riga: " & e.GridRow.Index & " di " & UltraGridPIEliminati.Rows.Count
            Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(e.CurrentRowIndex / (UltraGridPIEliminati.Rows.Count - 1) * 100)
        End If
        Form1.UltraStatusBar1.Refresh()
    End Sub

    Private Sub UltraFormattedTextEditorMultiassegnazione_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UltraFormattedTextEditorMultiassegnazione.KeyDown
        '    'MsgBox(e.KeyCode)
            Select e.KeyCode
            '        Case 96 To 105
            '        Case 48 To 57
            Case 13
                UltraButtonMultiassegnazione.Focus()
                e.SuppressKeyPress = True
                '        Case Keys.Delete
                '        Case Keys.Tab
                '        Case Keys.Back
                '        Case Keys.Escape
                '        Case Else
                '            MsgBox("Carattere non valido!!", MsgBoxStyle.Exclamation)
                '            e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub UltraButtonAzzeraTutto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAzzeraTutto.Click
        Dim risposta As MsgBoxResult = MsgBoxResult.Ok

        risposta = MsgBox("Sei sicuro di voler azzerare tutto? l'operazione non è reversibile!", MsgBoxStyle.OkCancel)
        If risposta = MsgBoxResult.Ok Then
            Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Maximum = 100
            Form1.UltraStatusBar1.Panels(1).Visible = True
            Form1.UltraStatusBar1.Refresh()
            For i As Integer = 0 To UltraGridPI.Rows.Count - 1
                UltraGridPI.Rows(i).Cells("Copie").Value = 0
                Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = (i / (UltraGridPI.Rows.Count - 1) * 100)
                Form1.UltraStatusBar1.Refresh()
            Next
            Form1.UltraStatusBar1.Panels(1).Visible = False
            Form1.UltraStatusBar1.Refresh()
            MsgBox("Dati azzerati con successo!!")
        End If
    End Sub

    Private Sub UltraButtonEsportaPIEliminati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonEsportaPIEliminati.Click
        Dim nomefile As String = "PIEsclusi" & UltraComboTestata.Text & "-" & Today.Year & "-" & Today.Month & "-" & Today.Day & ".xls"
        Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString & "PIEsclusi"
        Try
            System.IO.Directory.CreateDirectory(percorso)
        Catch ex As Exception
            'la directory già esiste
        End Try
        UltraGridExcelExporter1.Export(UltraGridPIEliminati, percorso & "\" & nomefile)
    End Sub

    Private Sub UltraButtonStampaPIEliminati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonStampaPIEliminati.Click
        UltraGridPrintDocumentDistribuzione.Grid = UltraGridPIEliminati
        UltraGridPrintDocumentDistribuzione.DocumentName = "PIEsclusi" & UltraComboTestata.Text & "-" & UltraComboDistribuzione.Text
        UltraPrintPreviewDialogDistribuzione.ShowDialog()
    End Sub

    Private Sub UltraGridPI_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UltraGridPI.KeyDown
        Select Case e.KeyValue

            Case Keys.Up
                UltraGridPI.PerformAction(UltraGridAction.ExitEditMode, False, False)
                UltraGridPI.PerformAction(UltraGridAction.AboveRow, False, False)
                e.Handled = True
                UltraGridPI.PerformAction(UltraGridAction.EnterEditMode, False, False)

            Case Keys.Down

                UltraGridPI.PerformAction(UltraGridAction.ExitEditMode, False, False)
                UltraGridPI.PerformAction(UltraGridAction.BelowRow, False, False)
                e.Handled = True
                UltraGridPI.PerformAction(UltraGridAction.EnterEditMode, False, False)

            Case Keys.Right

                UltraGridPI.PerformAction(UltraGridAction.ExitEditMode, False, False)
                UltraGridPI.PerformAction(UltraGridAction.NextCellByTab, False, False)
                e.Handled = True
                UltraGridPI.PerformAction(UltraGridAction.EnterEditMode, False, False)

            Case Keys.Left

                UltraGridPI.PerformAction(UltraGridAction.ExitEditMode, False, False)
                UltraGridPI.PerformAction(UltraGridAction.PrevCellByTab, False, False)
                e.Handled = True
                UltraGridPI.PerformAction(UltraGridAction.EnterEditMode, False, False)

            Case Keys.Enter
                UltraGridPI.PerformAction(UltraGridAction.ExitEditMode, False, False)
                UltraGridPI.PerformAction(UltraGridAction.BelowCell, False, False)
                e.Handled = True
                UltraGridPI.PerformAction(UltraGridAction.EnterEditMode, False, False)

        End Select
    End Sub

    Private Sub UltraComboDistribuzione_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraComboDistribuzione.TextChanged
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.QConteggioTestateTipologia'. È possibile spostarla o rimuoverla se necessario.
        Me.QConteggioTestateTipologiaTableAdapter.FillByDistribuzione(Me.ASDDBDataSet.QConteggioTestateTipologia, UltraComboTestata.Text, UltraComboDistribuzione.Text)
        Dim info As New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo
        Dim testo As String = ""
        Dim riga As DataRowView
        For i As Integer = 0 To QConteggioTestateTipologiaBindingSource.Count - 1
            riga = QConteggioTestateTipologiaBindingSource.Item(i)
            testo = testo & riga(2) & " " & riga(3) & vbCrLf
        Next
        info.ToolTipText = info.ToolTipText + testo
        UltraToolTipManagerStat.SetUltraToolTip(UltraComboDistribuzione, info)
        UltraToolTipManagerStat.ShowToolTip(UltraComboDistribuzione)
    End Sub

    Private Sub UltraButtonEliminaSelezionati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonEliminaSelezionati.Click
        Dim risposta As Integer
        risposta = MsgBox("Elimino con motivazione e azzero le copie di " & UltraGridPI.Selected.Rows.Count & " punti selezionati?", MsgBoxStyle.OkCancel)
        Select Case risposta
            Case MsgBoxResult.Ok
                Form1.UltraStatusBar1.Panels(0).Text = "Sto azzerando le copie ai PI selezionati."
                Dim k As Integer = 0
                For Each pi As UltraGridRow In UltraGridPI.Selected.Rows
                    Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(pi.Index / UltraGridPI.Selected.Rows.Count * 100)
                    Form1.UltraStatusBar1.Refresh()
                    If pi.Cells("Copie").Value > 0 Then
                        pi.Cells("Copie").Value = 0
                    End If
                    k = k + 1
                    UltraGridPIEliminati.DisplayLayout.Bands(0).AddNew()
                    UltraGridPIEliminati.Refresh()
                    UltraGridPIEliminati.Rows(UltraGridPIEliminati.Rows.Count - 1).Cells("PI").Value = pi.Cells(0).Value
                    UltraGridPIEliminati.Rows(UltraGridPIEliminati.Rows.Count - 1).Cells("Testata").Value = UltraComboTestata.Value
                    UltraGridPIEliminati.Rows(UltraGridPIEliminati.Rows.Count - 1).Cells("Motivo").Value = "non specificato"
                    UltraGridPIEliminati.Rows(UltraGridPIEliminati.Rows.Count - 1).Cells("Data").Value = Today
                Next
                UltraGridPIEliminati.DisplayLayout.Bands(0).AddNew()
                UltraGridPIEliminati.Refresh()
                UltraGridPIEliminati.DisplayLayout.Bands(0).Columns("PI").SortIndicator = SortIndicator.Ascending
                Me.EsclusioniTableAdapter.Update(Me.ASDDBDataSet.Esclusioni)
                Form1.UltraStatusBar1.Panels(0).Text = "PI eliminati e azzerati correttamente."
                Form1.UltraStatusBar1.Refresh()
        End Select
    End Sub

    Private Sub UltraGridPI_BeforeCellActivate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelableCellEventArgs) Handles UltraGridPI.BeforeCellActivate
        If e.Cell.Column.Index <> 32 Then 'verifica se la cella attiva fa parte della colonna copie, unica modificabile
            caratteripermessi = True      'possono essere inseriti caratteri alfanumerici
        Else
            caratteripermessi = False     'possono essere inseriti SOLO caratteri numerici
        End If
    End Sub

    Private Sub DistribuzioneTestata_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        If Not caricato Then
            UltraGridPI.DisplayLayout.Bands(0).ColumnFilters("Copie").ClearFilterConditions()
            caricato = True
        End If
        If Not salvaechiudi Then 'controlla se la distribuzione è già stata salvata
            Dim salvataggio As Integer = MsgBox("Sono presenti delle modifiche alla distribuzione. Vuoi salvarle?", MsgBoxStyle.YesNoCancel)
            Select Case salvataggio
                Case MsgBoxResult.Yes
                    For i As Integer = UltraGridDistribuzione.Rows.Count - 1 To 0 Step -1
                        If UltraGridDistribuzione.Rows(i).Cells("Stato").Value = "Eliminato" Then
                            UltraGridDistribuzione.Rows(i).Delete(False) 'DA IMPOSTARE LA FINESTRA DI DELETE
                        End If
                    Next
                    UltraGridDistribuzione.UpdateData()
                    UltraGridPIEliminati.UpdateData()
                    Try
                        Me.DistribuzioneTableAdapter.Update(Me.ASDDBDataSet.Distribuzione)
                        Me.EsclusioniTableAdapter.Update(Me.ASDDBDataSet.Esclusioni)
                    Catch
                    End Try
                Case MsgBoxResult.Cancel
                    'e.Cancel = True ANNULLARE IL CAMBIO MENU
                Case Else
                    'Salvataggio annullato dall'utente
            End Select
        End If
    End Sub

    Private Sub UltraFormattedTextEditorMultiassegnazione_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UltraFormattedTextEditorMultiassegnazione.KeyPress
        Select Case e.KeyChar
            Case "0" To "9"
            Case ChrW(Keys.Return)
                e.Handled = True
            Case ChrW(Keys.Delete)
            Case ChrW(Keys.Back)
            Case ChrW(Keys.Escape)
            Case Else
                MsgBox("Carattere non valido!!", MsgBoxStyle.Exclamation)
                e.Handled = True
        End Select
    End Sub

    Private Sub UltraFormattedTextEditorSalva_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UltraFormattedTextEditorSalva.KeyDown
        Select Case e.KeyCode
            '        Case 96 To 105
            '        Case 48 To 57
            Case 13
                UltraButtonSalva.Focus()
                e.SuppressKeyPress = True
                '        Case Keys.Delete
                '        Case Keys.Tab
                '        Case Keys.Back
                '        Case Keys.Escape
                '        Case Else
                '            MsgBox("Carattere non valido!!", MsgBoxStyle.Exclamation)
                '            e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub UltraButtonPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonPDF.Click
        MsgBox("Per avere la distribuzione dei soli PI con copie applicare prima il filtro e poi esportare.")
        caricato = False
        Dim nomefile As String = "Distribuzione" & UltraComboTestata.Text & UltraComboDistribuzione.Text & "-" & Today.Year & "-" & Today.Month & "-" & Today.Day & ".pdf"
        Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString & "Distribuzioni"
        Try
            System.IO.Directory.CreateDirectory(percorso)
        Catch ex As Exception
            'la directory già esiste
        End Try
        If MsgBox("ATTENZIONE!! Il processo potrebbe durare un paio di minuti, si è sicuri di voler procedere?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Form1.UltraStatusBar1.Panels(1).Visible = True
            UltraGridDocumentExporter1.Export(UltraGridPI, percorso & "\" & nomefile, Infragistics.Win.UltraWinGrid.DocumentExport.GridExportFileFormat.PDF)
        End If
    End Sub

    Private Sub UltraGridDocumentExporter1_RowExporting(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DocumentExport.RowExportingEventArgs) Handles UltraGridDocumentExporter1.RowExporting
        caricato = False
        Form1.UltraStatusBar1.Panels(0).Text = "Sto esportando la riga: " & e.GridRow.Index & " di " & (UltraGridPI.Rows.Count - 1)
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(e.GridRow.Index / (UltraGridPI.Rows.Count - 1) * 100)
        Form1.UltraStatusBar1.Refresh()
    End Sub

    Private Sub UltraCheckEditorCodiciAlternativi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraCheckEditorCodiciAlternativi.CheckedChanged
        If UltraComboCodiciAlternativi.Text = "" Then
            MsgBox("Devo selezionare prima la combinazione dei codici alternativi!!", MsgBoxStyle.Exclamation)
            UltraCheckEditorCodiciAlternativi.Checked = False
        End If
        If Not UltraCheckEditorCodiciAlternativi.Checked Then
            UltraComboCodiciAlternativi.Text = ""
        End If
    End Sub

    Private Sub UltraGridExcelExporter2_ExportEnded(sender As System.Object, e As Infragistics.Win.UltraWinGrid.ExcelExport.ExportEndedEventArgs) Handles UltraGridExcelExporter2.ExportEnded
        Form1.UltraStatusBar1.Panels(0).Text = "Esportazione completata con successo."
        Form1.UltraStatusBar1.Panels(1).Visible = False
        Form1.UltraStatusBar1.Refresh()
        caricato = True
    End Sub

    Private Sub UltraGridDocumentExporter1_ExportEnded(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DocumentExport.ExportEndedEventArgs) Handles UltraGridDocumentExporter1.ExportEnded
        Form1.UltraStatusBar1.Panels(0).Text = "File esportato con successo."
        Form1.UltraStatusBar1.Panels(1).Visible = False
        Form1.UltraStatusBar1.Refresh()
        caricato = True
    End Sub
End Class
