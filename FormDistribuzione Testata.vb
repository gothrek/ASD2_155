Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports System.IO

Public Class FormDistribuzione_Testata
    Dim caricato As Boolean = False
    Dim salvaechiudi As Boolean = False
    Dim indicecolonna As Integer = 100
    Dim contatorenuovo As Integer = 0
    Dim contatoremodificato As Integer = 0
    Dim contatoreeliminato As Integer = 0

    Private Sub FormDistribuzione_Testata_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.QTabella_Distribuzioni'. È possibile spostarla o rimuoverla se necessario.
        Me.QTabella_DistribuzioniTableAdapter.Fill(Me.ASDDBDataSet.QTabella_Distribuzioni)
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.PI'. È possibile spostarla o rimuoverla se necessario.
        Me.PITableAdapter.Fill(Me.ASDDBDataSet.PI)
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Tabella_Distribuzioni'. È possibile spostarla o rimuoverla se necessario.
        Me.Tabella_DistribuzioniTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Distribuzioni)
        Form1.UltraStatusBar1.Panels(0).Text = "Hai selezionato 0 righe."
    End Sub

    Private Sub UltraCombo1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraComboTestata.TextChanged
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
        Form1.UltraStatusBar1.Refresh()
        UltraFormattedTextEditorSalva.Text = UltraComboDistribuzione.Text
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Esclusioni'. È possibile spostarla o rimuoverla se necessario.
        Me.EsclusioniTableAdapter.FillByTestata(Me.ASDDBDataSet.Esclusioni, UltraComboTestata.Text)
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Distribuzione'. È possibile spostarla o rimuoverla se necessario.
        Me.DistribuzioneTableAdapter.FillByDistro(Me.ASDDBDataSet.Distribuzione, UltraComboTestata.Text, UltraComboDistribuzione.Text)
        Do
            Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(i / (UltraGridPI.Rows.Count - 1) * 100)
            Form1.UltraStatusBar1.Refresh()
            If UltraGridPI.Rows(i).Cells("PI").Value = UltraGridDistribuzione.Rows(indice).Cells("PI").Value Then
                UltraGridPI.Rows(i).Cells("Copie").Value = UltraGridDistribuzione.Rows(indice).Cells("Copie").Value
                indice = indice + 1
            Else
                UltraGridPI.Rows(i).Cells("Copie").Value = 0
            End If
            i = i + 1
        Loop Until indice = UltraGridDistribuzione.Rows.Count
        For k As Integer = i To UltraGridPI.Rows.Count - 1
            Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(k / (UltraGridPI.Rows.Count - 1) * 100)
            UltraGridPI.Rows(k).Cells("Copie").Value = 0
        Next
        caricato = True
        contatorenuovo = 0
        contatoremodificato = 0
        contatoreeliminato = 0
        Form1.UltraStatusBar1.Panels(0).Text = "Dati della distribuzione caricati correttamente."
        Form1.UltraStatusBar1.Refresh()
        UltraGridPI.Rows(0).Cells("Copie").Value = UltraGridPI.Rows(0).Cells("Copie").Value
    End Sub

    Private Sub UltraGridDistribuzione_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ' Declare and retrieve a reference to the UIElement
        'Dim aUIElement As UIElement = Me.UltraGridDistribuzione.DisplayLayout.UIElement.ElementFromPoint(New Point(e.X, e.Y))

        ' Declare and retrieve a reference to the Row
        'Dim aRow As UltraGridRow = aUIElement.GetContext(GetType(UltraGridRow))

        ' If a row was found display the band and row index
        'If Not aRow Is Nothing Then

        'MsgBox(Me.ASDDBDataSet.PI.FindByPI(UltraGridDistribuzione.Rows(aRow.Index).Cells(2).Value).RagioneSociale)
        'MsgBox(UltraGridPI.Rows(aRow.Index).Cells(0).Value)
        'End If
    End Sub

    Private Sub UltraButtonMultiassegnazione_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonMultiassegnazione.Click
        If UltraGridPI.Selected.Rows.Count > 1 Then
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
            MsgBox("Per usare la multiassegnazione bisogna selezionare almeno 2 righe.", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub UltraGridPI_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridPI.InitializeLayout

    End Sub

    'DA VALUTARE SE ELIMINARE
    Private Sub UltraGridDistribuzione_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridDistribuzione.CellChange
        'UltraGridDistribuzione.UpdateData()
        'Me.Tabella_DistribuzioniTableAdapter.Update(Me.ASDDBDataSet.Tabella_Distribuzioni)
    End Sub

    Private Sub UltraGridPI_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridPI.AfterCellUpdate
        Dim trovato As Boolean = False
        Dim i As Integer = 0
        If caricato Then
            Try
                Do
                    If UltraGridDistribuzione.Rows(i).Cells("PI").Value = e.Cell.Row.Cells("PI").Value Then
                        UltraGridDistribuzione.Rows(i).Cells("Copie").Value = e.Cell.Value
                        Select Case UltraGridDistribuzione.Rows(i).Cells("Stato").Value
                            Case "Nuovo"
                                contatorenuovo = contatorenuovo - 1
                            Case "Modificato"
                                contatoremodificato = contatoremodificato - 1
                            Case "Eliminato"
                                contatoreeliminato = contatoreeliminato - 1
                        End Select
                        If e.Cell.Value = 0 Then
                            UltraGridDistribuzione.Rows(i).Cells("Stato").Value = "Eliminato"
                            contatoreeliminato = contatoreeliminato + 1
                        Else
                            If UltraGridDistribuzione.Rows(i).Cells("Stato").Value <> "Nuovo" Then
                                UltraGridDistribuzione.Rows(i).Cells("Stato").Value = "Modificato"
                                contatoremodificato = contatoremodificato + 1
                            End If
                        End If
                        trovato = True
                    End If
                    i = i + 1
                Loop Until trovato Or (i = UltraGridDistribuzione.Rows.Count)

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
    End Sub

    Private Sub FormDistribuzione_Testata_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not salvaechiudi Then 'controlla se la distribuzione è già stata salvata
            Dim salvataggio As Integer = MsgBox("Vuoi salvare le modifiche apportate a " & " punti?", MsgBoxStyle.YesNoCancel)
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
                    e.Cancel = True
                Case Else
                    'Salvataggio annullato dall'utente
            End Select
        End If
    End Sub

    Private Sub UltraGridPI_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UltraGridPI.KeyPress

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
    End Sub

    Private Sub UltraButtonImporta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonImporta.Click
        Form1.UltraStatusBar1.Panels(0).Text = "Sto caricando i dati della distribuzione da Excel."
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
                    For i As Integer = 0 To tblExcel2WinData.Rows.Count - 1
                        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(i / (tblExcel2WinData.Rows.Count - 1) * 100)
                        Form1.UltraStatusBar1.Refresh()
                        UltraGridExcel.DisplayLayout.Bands(0).AddNew()
                        UltraGridExcel.Rows(i).Cells("Stato").Value = " - "
                        UltraGridExcel.Rows(i).Cells("PI").Value = tblExcel2WinData.Rows(i).Item(0)
                        UltraGridExcel.Rows(i).Cells("Copie").Value = tblExcel2WinData.Rows(i).Item(1)
                    Next
                    Dim k As Integer = 0
                    Dim trovato As Boolean = False
                    Dim errori As Boolean = False
                    For i As Integer = 0 To UltraGridExcel.Rows.Count - 1
                        Do
                            If UltraGridPI.Rows(k).Cells("PI").Value = UltraGridExcel.Rows(i).Cells("PI").Value Then
                                Try
                                    UltraGridExcel.Rows(i).Cells("Copie").Value = Int(UltraGridExcel.Rows(i).Cells("Copie").Value)
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
                        Dim risultato As Integer = MsgBox("I dati importati devono essere uniti agli attuali? (se si sceglie NO verranno eliminati i dati presenti e sostituiti con i nuovi)", MsgBoxStyle.YesNoCancel)
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
                                For i As Integer = 0 To UltraGridDistribuzione.Rows.Count - 1
                                    Do
                                        If UltraGridDistribuzione.Rows(i).Cells("PI").Value = UltraGridPI.Rows(k).Cells("PI").Value Then
                                            UltraGridPI.Rows(k).Cells("Copie").Value = 0
                                            trovato = True
                                        End If
                                        k = k + 1
                                    Loop Until trovato
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
                            Case Else
                                'Importazione annullata dall'utente
                        End Select
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
        If UltraFormattedTextEditorSalva.Text = UltraComboDistribuzione.Text Then
            Me.Tabella_DistribuzioniTableAdapter.Update(Me.ASDDBDataSet.Tabella_Distribuzioni)
        Else
            modifica = MsgBox("Confermi la creazione di una nuova distribuzione? (l'operazione potrebbe richiedere diverso tempo)", MsgBoxStyle.YesNoCancel, "Salvataggio della distribuzione")
            'FUTURA VERSIONE modifica = MsgBox("Nuova distribuzione? (no per rinominare quella corrente)", MsgBoxStyle.YesNoCancel, "Salvataggio della distribuzione")
            Select Case modifica
                Case MsgBoxResult.Yes
                    Tabella_DistribuzioniTableAdapter.Insert(UltraComboTestata.Text, UltraFormattedTextEditorSalva.Text, True, "01/01/2008", Today, Today, "Nessuna")
                    salvaechiudi = True
                    For i As Integer = 0 To UltraGridDistribuzione.Rows.Count - 1
                        If UltraGridDistribuzione.Rows(i).Cells("Stato").Value <> "Eliminato" Then
                            Me.DistribuzioneTableAdapter.Insert(UltraGridDistribuzione.Rows(i).Cells("Testata").Value, UltraFormattedTextEditorSalva.Text, UltraGridDistribuzione.Rows(i).Cells("PI").Value, UltraGridDistribuzione.Rows(i).Cells("Copie").Value)
                        End If
                    Next
                    MsgBox("La schermata verrà chiusa per aggiornare i dati.", MsgBoxStyle.OkOnly)
                    Me.Close()
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
    End Sub

    Private Sub UltraGridPI_AfterSelectChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles UltraGridPI.AfterSelectChange
        Form1.UltraStatusBar1.Panels(0).Text = "Hai selezionato " & UltraGridPI.Selected.Rows.Count & " righe."
        Form1.UltraStatusBar1.Refresh()
    End Sub

    Private Sub UltraGridDistribuzione_AfterSelectChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles UltraGridDistribuzione.AfterSelectChange
        Try
            MsgBox(Me.ASDDBDataSet.PI.FindByPI(UltraGridDistribuzione.Selected.Rows(0).Cells("PI").Value).RagioneSociale)
            UltraGridDistribuzione.Selected.Rows.Clear()
        Catch

        End Try
    End Sub

    Private Sub UltraButtonEsporta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonEsporta.Click
        caricato = False
        Dim nomefileexcel As String = "Distribuzione" & UltraComboTestata.Text & UltraComboDistribuzione.Text & ".xls"
        UltraGridExcelExporter1.Export(UltraGridPI, nomefileexcel)
        caricato = True
    End Sub

    Private Sub UltraGridExcelExporter1_RowExporting(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.ExcelExport.RowExportingEventArgs) Handles UltraGridExcelExporter1.RowExporting
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
        'MsgBox(e.KeyCode)
        Select Case e.KeyCode
            Case 96 To 105
            Case 48 To 57
            Case 13
                UltraButtonMultiassegnazione.Focus()
                e.SuppressKeyPress = True
            Case Keys.Delete
            Case Keys.Tab
            Case Keys.Back
            Case Keys.Escape
            Case Else
                MsgBox("Carattere non valido!!", MsgBoxStyle.Exclamation)
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub UltraButtonAzzeraTutto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAzzeraTutto.Click
        For i As Integer = 0 To UltraGridPI.Rows.Count - 1
            UltraGridPI.Rows(i).Cells("Copie").Value = 0
        Next
    End Sub

    Private Sub UltraButtonEsportaPIEliminati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonEsportaPIEliminati.Click
        Dim nomefileexcel As String = "PIEliminati" & UltraComboTestata.Text & ".xls"
        UltraGridExcelExporter1.Export(UltraGridPIEliminati, nomefileexcel)
    End Sub

    Private Sub UltraButtonStampaPIEliminati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonStampaPIEliminati.Click
        UltraGridPrintDocumentDistribuzione.Grid = UltraGridPIEliminati
        UltraGridPrintDocumentDistribuzione.DocumentName = "Distribuzione " & UltraComboTestata.Text & " - " & UltraComboDistribuzione.Text
        UltraPrintPreviewDialogDistribuzione.ShowDialog()
    End Sub

    Private Sub UltraGridPI_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UltraGridPI.KeyDown
        Select Case e.KeyValue

            Case Keys.Up
                UltraGridPI.PerformAction(UltraGridAction.ExitEditMode, False, False)
                UltraGridPI.PerformAction(UltraGridAction.AboveCell, False, False)
                e.Handled = True
                UltraGridPI.PerformAction(UltraGridAction.EnterEditMode, False, False)

            Case Keys.Down

                UltraGridPI.PerformAction(UltraGridAction.ExitEditMode, False, False)
                UltraGridPI.PerformAction(UltraGridAction.BelowCell, False, False)
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

    Private Sub UltraPrintPreviewDialogDistribuzione_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles UltraPrintPreviewDialogDistribuzione.FormClosed
        If Not caricato Then
            UltraGridPI.DisplayLayout.Bands(0).ColumnFilters("Copie").ClearFilterConditions()
            caricato = True
        End If
    End Sub

    Private Sub UltraPrintPreviewDialogDistribuzione_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles UltraPrintPreviewDialogDistribuzione.FormClosing

    End Sub

    Private Sub FillByTestataToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByTestataToolStripButton.Click
        Try
            Me.Tabella_DistribuzioniTableAdapter.FillByTestata(Me.ASDDBDataSet.Tabella_Distribuzioni, TestataToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub UltraGridExcelExporter1_ExportEnded(sender As System.Object, e As Infragistics.Win.UltraWinGrid.ExcelExport.ExportEndedEventArgs) Handles UltraGridExcelExporter1.ExportEnded
        Form1.UltraStatusBar1.Panels(0).Text = "Esportazione completata con successo."
        Form1.UltraStatusBar1.Refresh()
    End Sub
End Class