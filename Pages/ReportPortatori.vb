Imports System
Imports System.IO

Imports iTextSharp.text
Imports iTextSharp.text.pdf


Public Class ReportPortatori
    Dim dt As New DataTable
    Dim dttestate As New DataTable
    Dim dvtestate As New DataView
    Dim dtgiri As New DataTable
    Dim dvgiri As New DataView
    Dim dvdistribuzioni As New DataView
    Dim dtchiusure As New DataTable
    Dim dvchiusure As New DataView
    Dim dtalternativi As New DataTable
    Dim dvalternativi As New DataView
    Dim dtpi As New DataTable
    Dim dvpi As New DataView
    Dim dtdistribuzione As New DataTable
    Dim dvdistribuzione As New DataView
    Dim dtreportgiornaliero As New DataTable
    Dim dvreportgiornaliero As New DataView
    Dim bottonesinistro As Boolean = False
    Dim riga As Infragistics.Win.UltraWinGrid.UltraGridRow = Nothing

    Private Sub ReportPortatori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tabella e griglia distro delle testate
        Me.Tabella_DistribuzioniTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Distribuzioni)

        'tabella e griglia testate
        Me.TestateTableAdapter.Fill(Me.ASDDBDataSet.Testate)

        dttestate.Columns.Add("Check", System.Type.GetType("System.Boolean"))
        dttestate.Columns.Add("Codice", System.Type.GetType("System.String"))
        dttestate.Columns.Add("Testata", System.Type.GetType("System.String"))
        dttestate.Columns.Add("Distribuzione", System.Type.GetType("System.String"))
        dttestate.Columns.Add("Ultimo utilizzo", System.Type.GetType("System.DateTime"))
        dttestate.Columns.Add("Note", System.Type.GetType("System.String"))
        dttestate.Columns.Add("Importanza", System.Type.GetType("System.Int32"))

        'UltraGridTestate.DataSource = dttestate
        UltraGridTestate.DisplayLayout.Bands(0).Columns("Distribuzione").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList

        'tabella e griglia giri
        Me.Tabella_GiroTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Giro)
        dvgiri.Table = Me.ASDDBDataSet.Tabella_Giro
        dvgiri.Sort = "Giro"
        dtgiri.Columns.Add("Giro", System.Type.GetType("System.String"))
        dtgiri.Columns.Add("Note", System.Type.GetType("System.String"))
        dtgiri.Columns.Add("Percorrenza", System.Type.GetType("System.Boolean"))
        For i As Integer = 0 To dvgiri.Count - 1
            dtgiri.Rows.Add()
            dtgiri.Rows(i).Item("Giro") = dvgiri.Item(i).Item("Giro")
            dtgiri.Rows(i).Item("Note") = dvgiri.Item(i).Item("Note")
            dtgiri.Rows(i).Item("Percorrenza") = dvgiri.Item(i).Item("Percorrenza")
        Next
        UltraGridGiri.DataSource = dtgiri
        'UltraGridGiri.DisplayLayout.Bands(0).Columns(2).ColumnChooserCaption = "Ordine per percorrenza?"

        'tabella consegne
        Me.ConsegneTableAdapter.Fill(Me.ASDDBDataSet.Consegne)

        'tabella e griglia distribuzione
        Me.DistribuzioneTableAdapter.Fill(Me.ASDDBDataSet.Distribuzione)
        dvdistribuzione.Table = Me.ASDDBDataSet.Distribuzione

        inizializzazione()

    End Sub

    Private Sub UltraGridTestate_CellListSelect(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridTestate.CellListSelect
        Dim trovato As Boolean = False
        Dim contatorei As Integer = 0
        If e.Cell.Column.Index = 3 Then
            dvdistribuzioni.RowFilter = "Testata = '" & dvtestate.Item(e.Cell.Row.Index).Item(1) & "'"
            Do
                If (dvdistribuzioni.Item(contatorei).Item(0) = dttestate.Rows(e.Cell.Row.Index).Item(1)) And (dvdistribuzioni.Item(contatorei).Item(1) = dttestate.Rows(e.Cell.Row.Index).Item(3)) Then
                    trovato = True
                    dttestate.Rows(e.Cell.Row.Index).Item(4) = dvdistribuzioni.Item(contatorei).Item(3)
                    dttestate.Rows(e.Cell.Row.Index).Item(5) = dvdistribuzioni.Item(contatorei).Item(6)
                End If
                contatorei = contatorei + 1
            Loop Until trovato
        End If
        UltraGridTestate.Refresh()
    End Sub

    Private Sub UltraButtonCreaDistribuzione_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonCreaDistribuzione.Click
        Dim riporto As Integer = 0
        Dim righe As Integer = 0
        dtreportgiornaliero = New DataTable
        Form1.UltraStatusBar1.Panels(1).Visible = True
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Maximum = 100
        Form1.UltraStatusBar1.Refresh()
        'inizio memorizzazione importanza testate
        For i As Integer = 0 To UltraGridTestate.Rows.Count - 1
            dttestate.Rows(i).Item(6) = i * 10 + 10
            'AGGIORNARE TABELLA TESTATE
        Next
        'fine memorizzazione importanza testate
        'CREAZIONE DELLA DISTRIBUZIONE
        dtreportgiornaliero.TableName = "reportgiornaliero"
        dtreportgiornaliero.Columns.Add("PI", System.Type.GetType("System.String"))
        dtreportgiornaliero.Columns("PI").Unique = True
        dtreportgiornaliero.Columns.Add("Note", System.Type.GetType("System.String"))
        dtreportgiornaliero.Columns.Add("Tipologia", System.Type.GetType("System.String"))
        dtreportgiornaliero.Columns.Add("Classe", System.Type.GetType("System.String"))
        dtreportgiornaliero.Columns.Add("Ragione Sociale", System.Type.GetType("System.String"))
        dtreportgiornaliero.Columns.Add("Indirizzo", System.Type.GetType("System.String"))
        dtreportgiornaliero.Columns.Add("Giro", System.Type.GetType("System.String"))
        dtreportgiornaliero.Columns.Add("Percorrenza", System.Type.GetType("System.Int32"))
        dtreportgiornaliero.Columns.Add("Dispencer", System.Type.GetType("System.String"))
        dtreportgiornaliero.Columns("Dispencer").Caption = "Dispenser"
        dtreportgiornaliero.Columns.Add("Modificato", System.Type.GetType("System.Boolean")) 'gestisce il coloramento di una riga se il punto ha ultime modifiche
        'asssegnazione delle copie ai pi corrispondenti
        For i As Integer = 0 To UltraGridTestate.Rows.Count - 1
            Form1.UltraStatusBar1.Panels(0).Text = "Analisi della testata: " & UltraGridTestate.Rows(i).Cells("Testata").Text
            Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(i / (UltraGridTestate.Rows.Count - 1) * 100)
            Form1.UltraStatusBar1.Refresh()
            If UltraGridTestate.Rows(i).Cells("Check").Value Then
                'dtreportgiornaliero.Columns.Add(dvtestate.Item(i).Item("Codice"), System.Type.GetType("System.Int32"))
                dtreportgiornaliero.Columns.Add(UltraGridTestate.Rows(i).Cells(1).Value, System.Type.GetType("System.Int32"))
                dvdistribuzione.RowFilter = "Testata = '" & UltraGridTestate.Rows(i).Cells("Codice").Value & "' AND Distribuzione = '" & UltraGridTestate.Rows(i).Cells("Distribuzione").Value & "'"
                dvdistribuzione.Sort = "PI"
                'MsgBox(UltraGridTestate.Rows(i).Cells("Codice").Value & " distro " & UltraGridTestate.Rows(i).Cells("Distribuzione").Value & " nelementi: " & dvdistribuzione.Count)
                Form1.UltraStatusBar1.Panels(2).Text = "Assegnazioni delle distribuzioni."
                Form1.UltraStatusBar1.Refresh()
                For k As Integer = 0 To dvdistribuzione.Count - 1
                    Try
                        dtreportgiornaliero.Rows.Add()
                        dtreportgiornaliero.Rows(dtreportgiornaliero.Rows.Count - 1).Item("PI") = dvdistribuzione.Item(k).Item("PI")
                        dtreportgiornaliero.Rows(dtreportgiornaliero.Rows.Count - 1).Item(UltraGridTestate.Rows(i).Cells(1).Text) = dvdistribuzione.Item(k).Item("Copie")
                        righe = righe + 1
                    Catch ex As Exception
                        Dim controlloriga As Integer = dtreportgiornaliero.Rows.Count
                        Dim controllopi As Integer = dvdistribuzione.Item(k).Item("PI")
                        Dim controllocopie As Integer = dvdistribuzione.Item(k).Item("Copie")
                        dtreportgiornaliero.Rows(dtreportgiornaliero.Rows.Count - 1).Delete()
                        dtreportgiornaliero.Rows(dvreportgiornaliero.Find(dvdistribuzione.Item(k).Item("PI"))).Item(UltraGridTestate.Rows(i).Cells(1).Text) = dvdistribuzione.Item(k).Item("Copie")
                    End Try
                    dvreportgiornaliero.Table = dtreportgiornaliero
                    dvreportgiornaliero.Sort = "PI"
                    Dim usodt As New DataTable("usodt")
                    usodt = dvreportgiornaliero.ToTable
                    dtreportgiornaliero.Clear()
                    dtreportgiornaliero = usodt
                    dtreportgiornaliero.Columns("PI").Unique = True
                    dvreportgiornaliero.Table = dtreportgiornaliero
                    dvreportgiornaliero.Sort = "PI"
                Next
                riporto = riporto + righe
                righe = 0
                
            End If
        Next
        'eliminazione dei pi chiusi (chiusure extra)
        Form1.UltraStatusBar1.Panels(2).Text = "Eliminazione dei PI chiusi (chiusure extra)."
        Form1.UltraStatusBar1.Refresh()
        For i As Integer = 0 To dvchiusure.Count - 1
            Try
                Dim usopi As Integer = dtreportgiornaliero.Rows(dvreportgiornaliero.Find(dvchiusure.Item(i).Item("PI"))).Item("PI")
                dtreportgiornaliero.Rows(dvreportgiornaliero.Find(dvchiusure.Item(i).Item("PI"))).Delete()
            Catch ex As Exception
                'MsgBox("Cancello pi " & dvchiusure.Item(i).Item("PI"))
            End Try
        Next
        dtreportgiornaliero.AcceptChanges()
        dvreportgiornaliero.Table = dtreportgiornaliero
        'assegnazione delle info ai pi
        Form1.UltraStatusBar1.Panels(2).Text = "Assegnazione delle info ai PI."
        Form1.UltraStatusBar1.Refresh()
        Dim usoriga As Integer = 0
        Dim usocancellazione As New ArrayList(10000)
        For i As Integer = 0 To dvreportgiornaliero.Count - 1
            Try
                usoriga = dvpi.Find(dvreportgiornaliero.Item(i).Item("PI"))
                dtreportgiornaliero.Rows(i).Item("Note") = dvpi.Item(usoriga).Item("Note")
                dtreportgiornaliero.Rows(i).Item("Tipologia") = dvpi.Item(usoriga).Item("Tipologia")
                dtreportgiornaliero.Rows(i).Item("Classe") = dvpi.Item(usoriga).Item("Classe")
                dtreportgiornaliero.Rows(i).Item("Ragione Sociale") = dvpi.Item(usoriga).Item("RagioneSociale")
                dtreportgiornaliero.Rows(i).Item("Indirizzo") = dvpi.Item(usoriga).Item("Indirizzo") & ", " & dvpi.Item(usoriga).Item("NumeroCivico")
                'verifica del giro alternativo
                If UltraCheckEditorAlternativi.Checked Then
                    dtreportgiornaliero.Rows(i).Item("Giro") = dvpi.Item(usoriga).Item("GiroAlternativo")
                    dtreportgiornaliero.Rows(i).Item("Percorrenza") = dvpi.Item(usoriga).Item("Percorrenza Alternativa")
                Else
                    dtreportgiornaliero.Rows(i).Item("Giro") = dvpi.Item(usoriga).Item("Giro")
                    dtreportgiornaliero.Rows(i).Item("Percorrenza") = dvpi.Item(usoriga).Item("Percorrenza")
                End If
                'fine verifica giro alternativo
                dtreportgiornaliero.Rows(i).Item("Dispencer") = dvpi.Item(usoriga).Item("Dispencer")
                Dim usogiorni As TimeSpan = Today.Subtract(dvpi.Item(usoriga).Item("DataModifica"))
                If usogiorni.Days <= Form1.dvimpostazioni.Item(0).Item(0) Then 'impostato a dalle impostazioni di programma
                    dtreportgiornaliero.Rows(i).Item("Modificato") = True
                Else
                    dtreportgiornaliero.Rows(i).Item("Modificato") = False
                End If
            Catch ex As Exception
                usocancellazione.Add(i)
                'MsgBox("Errore: RG-assegnazione info PI. Messaggio: " & ex.Message)
            End Try
        Next
        For i As Integer = 0 To usocancellazione.Count - 1
            dtreportgiornaliero.Rows(usocancellazione(i)).Delete()
        Next
        dtreportgiornaliero.AcceptChanges()
        'assegnazione dei giri alternativi
        Form1.UltraStatusBar1.Panels(2).Text = "Assegnazione dei giri alternativi."
        Form1.UltraStatusBar1.Refresh()
        Dim usoriga2 As Integer = 0
        For i As Integer = 0 To dvalternativi.Count - 1
            usoriga = dvpi.Find(dvalternativi.Item(i).Item("PI"))
            Try
                usoriga2 = dvreportgiornaliero.Find(dvalternativi.Item(i).Item("PI"))
                dtreportgiornaliero.Rows(usoriga2).Item("Giro") = dvpi.Item(usoriga).Item("GiroAlternativo")
                dtreportgiornaliero.Rows(usoriga2).Item("Percorrenza") = dvpi.Item(usoriga).Item("Percorrenza Alternativa")
            Catch ex As Exception

            End Try
        Next
        DataGridView1.DataSource = dtreportgiornaliero
        dvreportgiornaliero.Table = dtreportgiornaliero '??? serve ripeterlo?
        UltraGrid1.DataSource = dtreportgiornaliero
        UltraGrid1.DisplayLayout.Bands(0).Columns(0).Width = 50
        UltraGrid1.DisplayLayout.Bands(0).Columns(2).Width = 80
        UltraGrid1.DisplayLayout.Bands(0).Columns(3).Width = 50
        Form1.UltraStatusBar1.Panels(2).Text = "Colorazione dei PI modificati."
        Form1.UltraStatusBar1.Refresh()
        For i As Integer = 0 To UltraGrid1.Rows.Count - 1
            If UltraGrid1.Rows(i).Cells("Modificato").Value Then
                'Dim colore As Color '= New color(Form1.dvimpostazioni.Item(0).Item(3)).Color
                'Dim a As Integer
                'Dim b As Integer
                'Dim r As Integer
                'Dim g As Integer
                'Dim colore As String = Form1.dvimpostazioni.Item(0).Item(3).ToString
                'a = Microsoft.VisualBasic.Mid(Form1.dvimpostazioni.Item(0).Item(3).ToString, 10, 3)
                'r = Microsoft.VisualBasic.Mid(Form1.dvimpostazioni.Item(0).Item(3).ToString, 17, 3)
                'g = Microsoft.VisualBasic.Mid(Form1.dvimpostazioni.Item(0).Item(3).ToString, 24, 3)
                'b = Microsoft.VisualBasic.Mid(Form1.dvimpostazioni.Item(0).Item(3).ToString, 31, 3)
                'UltraGrid1.Rows(i).Appearance.BackColor = Color.FromArgb(a, r, g, b)

                UltraGrid1.Rows(i).Appearance.BackColor = Drawing.Color.DarkGray
            End If
        Next
        UltraGridPrintDocument1.Grid = UltraGrid1
        For i As Integer = 0 To UltraGrid1.DisplayLayout.Bands(0).Columns.Count - 1
            UltraGrid1.DisplayLayout.Bands(0).Columns(i).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Next
        'creazione delle consegne
        Form1.UltraStatusBar1.Panels(0).Text = "Creazione delle consegne."
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = 0
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Maximum = dvreportgiornaliero.Count * 2
        Form1.UltraStatusBar1.Panels(2).Text = "Il processo potrebbe richiedere diversi minuti e il sistema potrebbe sembrare fermo, NON INTERROMPERE!"
        Form1.UltraStatusBar1.Refresh()
        Me.ConsegneTableAdapter.DeleteGiorno(UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date())
        For i As Integer = 0 To dvreportgiornaliero.Count - 1
            For k As Integer = 10 To dtreportgiornaliero.Columns.Count - 1
                Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int((i + ((k - 10) * (dtreportgiornaliero.Columns.Count - 9))) / (dvreportgiornaliero.Count * (dtreportgiornaliero.Columns.Count - 9)) * 100)
                Form1.UltraStatusBar1.Refresh()
                Try

                    If dtreportgiornaliero.Rows(i).Item(k) > 0 Then
                        Dim usocopie As Integer = Int(dtreportgiornaliero.Rows(i).Item(k))
                        Dim usocolonna As String = dtreportgiornaliero.Columns(k).ColumnName
                        Dim usopi As Integer = Int(dtreportgiornaliero.Rows(i).Item(0))
                        Dim usogiro As String = dtreportgiornaliero.Rows(i).Item(6)
                        Dim usodata As Date = UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date()
                        'Dim usoordine As Integer = Int(k - 9)
                        Me.ConsegneTableAdapter.Insert(usopi, usocolonna, usodata, usocopie, usocopie, usogiro)  'Me.ConsegneTableAdapter.Insert(dtreportgiornaliero.Rows(i).Item(0), dtreportgiornaliero.Columns(k).ColumnName.ToString, UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date(), dtreportgiornaliero.Rows(i).Item(k), dtreportgiornaliero.Rows(i).Item(k), dtreportgiornaliero.Rows(i).Item(6).ToString, (k - 9))
                    End If
                Catch ex As Exception

                End Try
            Next
        Next
        Form1.UltraStatusBar1.Panels(2).Text = ""
        Form1.UltraStatusBar1.Panels(1).Visible = False
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = 0
        Form1.UltraStatusBar1.Panels(0).Text = "Report giornaliero creato con successo."
        Form1.UltraStatusBar1.Refresh()
        MsgBox("Report giornaliero creato con successo.")
        UltraButtonStampa.Enabled = True
        UltraButtonExcel.Enabled = True
        UltraButtonPDF.Enabled = True
        UltraButtonStampa2.Enabled = True
        'prove di stampa doc word
        'Dim objword As Object 'New Word.ApplicationClass
        'Dim filename As String = "c:\a.pdf"
        'filename = "c:\a.doc"
        'objword = CreateObject("Word.Application")
        'objword = CreateObject("PDF.Application")
        'objword.Visible = True
        'objword.Documents.Open(filename)
        'objword.PrintOut(False)
        'objword.Quit()

        'prove creazione pdf
        'Dim doc As New iTextSharp.text.Document

        'doc.Add(UltraGrid1)
        'doc.Close()
        'objword.Documents.Open(filename)
        'objword.PrintOut(False)
        'objword.Quit()
    End Sub

    Private Sub UltraButtonStampa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonStampa.Click
        Dim totalecopie As Integer = 0
        UltraGridPrintDocument1.DefaultPageSettings.Landscape = True
        UltraGridPrintDocument1.DefaultPageSettings.Margins.Bottom = 10
        UltraGridPrintDocument1.DefaultPageSettings.Margins.Left = 10
        UltraGridPrintDocument1.DefaultPageSettings.Margins.Right = 10
        UltraGridPrintDocument1.DefaultPageSettings.Margins.Top = 10
        UltraGridPrintDocument1.Header.TextRight = "Servizi Diffusionali srl" & vbCrLf & "Diffusione distribuzione promozione stampa"
        'UltraGridPrintDocument1.Footer.TextLeft = "Distribuzione del " & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date
        UltraGridPrintDocument1.Footer.TextRight = "Trasportatore: ________________ Firma__________"
        UltraFormattedTextEditor1.Text = UltraGridPrintDocument1.Footer.TextLeft & "\cr"
        Form1.UltraStatusBar1.Panels(2).Text = ""
        Form1.UltraStatusBar1.Panels(1).Visible = True
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Maximum = 100
        Form1.UltraStatusBar1.Panels(0).Text = "Stampa dei giri in corso."
        Form1.UltraStatusBar1.Refresh()
        For i = 0 To dvgiri.Count - 1
            Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(i / (dvgiri.Count - 1) * 100)
            Form1.UltraStatusBar1.Panels(2).Text = "Stampa del giro " & dvgiri.Item(i).Item(0) & "."
            Form1.UltraStatusBar1.Refresh()
            UltraGridPrintDocument1.Header.TextCenter = ""
            dvreportgiornaliero.RowFilter = "Giro = " & dvgiri.Item(i).Item("Giro")
            'UltraGridPrintDocument1.Footer.TextCenter = UltraGridGiri.Rows(i).Cells("Note").Value.ToString
            UltraGridPrintDocument1.Footer.TextLeft = UltraGridGiri.Rows(i).Cells("Note").Value.ToString
            If dvgiri.Item(i).Item("Percorrenza") Then
                dvreportgiornaliero.Sort = "Percorrenza, Indirizzo ASC"
            Else
                dvreportgiornaliero.Sort = "Indirizzo, Percorrenza, ASC"
            End If
            UltraGrid1.DataSource = dvreportgiornaliero
            UltraGrid1.DisplayLayout.Bands(0).Columns(6).Hidden = True 'colonna giro
            UltraGrid1.DisplayLayout.Bands(0).Columns(7).Hidden = True 'colonna percorrenza
            UltraGrid1.DisplayLayout.Bands(0).Columns(9).Hidden = True 'colonna modificato
            UltraGridPrintDocument1.Header.Appearance.FontData.SizeInPoints = 16
            UltraGridPrintDocument1.Footer.Appearance.FontData.SizeInPoints = 12
            UltraGridPrintDocument1.Header.TextLeft = "Giro n." & dvgiri.Item(i).Item("Giro") & vbCrLf & "Distribuzione del " & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date
            For k As Integer = 10 To UltraGrid1.DisplayLayout.Bands(0).Columns.Count - 1
                totalecopie = 0
                For j As Integer = 0 To UltraGrid1.Rows.Count - 1
                    Try
                        totalecopie = totalecopie + UltraGrid1.Rows(j).Cells(k).Value
                    Catch ex As Exception

                    End Try
                Next
                UltraGridPrintDocument1.Header.Appearance.FontData.SizeInPoints = 14
                UltraGridPrintDocument1.Header.TextCenter = UltraGridPrintDocument1.Header.TextCenter & UltraGrid1.DisplayLayout.Bands(0).Columns(k).Key & "=" & totalecopie & " "
                UltraFormattedTextEditor1.Text = UltraFormattedTextEditor1.Text & UltraGridPrintDocument1.Header.TextLeft & " " & UltraGridPrintDocument1.Header.TextCenter & vbCrLf
            Next
            If UltraCheckEditorStampaAutomatica.Checked Then
                UltraGridPrintDocument1.DocumentName = "Giro" & dvgiri.Item(i).Item("Giro")
                UltraGridPrintDocument1.Print()
                ' STAMPA SECONDA PAGINA CON SOLE EDICOLE
                dvreportgiornaliero.RowFilter = ""
                dvreportgiornaliero.RowFilter = "Giro = " & dvgiri.Item(i).Item("Giro") & " AND Tipologia Like 'EDICOLA ESPO*'"
                Form1.UltraStatusBar1.Panels(2).Text = "Stampa del giro " & dvgiri.Item(i).Item(0) & " edicole."
                Form1.UltraStatusBar1.Refresh()
                UltraGridPrintDocument1.DocumentName = "Giro" & dvgiri.Item(i).Item("Giro") & "Edicole"
                UltraGridPrintDocument1.Print()
                ' STAMPA TERZA PAGINA CON LE SOLE METROPOLITANE
                dvreportgiornaliero.RowFilter = ""
                dvreportgiornaliero.RowFilter = "Giro = " & dvgiri.Item(i).Item("Giro") & " AND Tipologia Like 'METROPOLITAN*'"
                Form1.UltraStatusBar1.Panels(2).Text = "Stampa del giro " & dvgiri.Item(i).Item(0) & " metropolitane."
                Form1.UltraStatusBar1.Refresh()
                UltraGridPrintDocument1.DocumentName = "Giro" & dvgiri.Item(i).Item("Giro") & "Metropolitane"
                UltraGridPrintDocument1.Print()
            Else
                If (UltraPrintPreviewDialog1.ShowDialog() = DialogResult.OK) Then
                    UltraGridPrintDocument1.DocumentName = "Giro" & dvgiri.Item(i).Item("Giro")
                    UltraGridPrintDocument1.Print()
                    ' STAMPA SECONDA PAGINA CON SOLE EDICOLE
                    dvreportgiornaliero.RowFilter = ""
                    dvreportgiornaliero.RowFilter = "Giro = " & dvgiri.Item(i).Item("Giro") & " AND Tipologia Like 'EDICOLA ESPO*'"
                    Form1.UltraStatusBar1.Panels(2).Text = "Stampa del giro " & dvgiri.Item(i).Item(0) & " edicole."
                    Form1.UltraStatusBar1.Refresh()
                    'UltraPrintPreviewDialog1.ShowDialog()
                    UltraGridPrintDocument1.DocumentName = "Giro" & dvgiri.Item(i).Item("Giro") & "Edicole"
                    UltraGridPrintDocument1.Print()
                    ' STAMPA TERZA PAGINA CON LE SOLE METROPOLITANE
                    dvreportgiornaliero.RowFilter = ""
                    dvreportgiornaliero.RowFilter = "Giro = " & dvgiri.Item(i).Item("Giro") & " AND Tipologia Like 'METROPOLITAN*'"
                    Form1.UltraStatusBar1.Panels(2).Text = "Stampa del giro " & dvgiri.Item(i).Item(0) & " metropolitane."
                    Form1.UltraStatusBar1.Refresh()
                    UltraGridPrintDocument1.DocumentName = "Giro" & dvgiri.Item(i).Item("Giro") & "Metropolitane"
                    UltraGridPrintDocument1.Print()
                End If
            End If
        Next
        Form1.UltraStatusBar1.Panels(2).Text = ""
        Form1.UltraStatusBar1.Panels(1).Visible = False
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = 0
        Form1.UltraStatusBar1.Panels(0).Text = "Stampa dei giri terminata correttamente."
        Form1.UltraStatusBar1.Refresh()
        dvreportgiornaliero.RowFilter = ""
        dvreportgiornaliero.Sort = "PI"


    End Sub

    Private Sub UltraButtonExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonExcel.Click
        Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Year & "\" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Month & "\" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Day
        UltraGridExcelExporter1.Export(UltraGrid1, percorso & "\" & "Report portatori del " & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Year & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Month & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Day & ".xls")
    End Sub

    Private Sub UltraButtonPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonPDF.Click
        Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Year & "\" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Month & "\" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Day
        UltraGridDocumentExporter1.Export(UltraGrid1, percorso & "\" & "Report portatori del " & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Year & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Month & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Day & ".pdf", Infragistics.Win.UltraWinGrid.DocumentExport.GridExportFileFormat.PDF)
    End Sub

    Private Sub UltraGridTestate_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles UltraGridTestate.MouseDown
        Dim elemento As Infragistics.Win.UIElement = UltraGridTestate.DisplayLayout.UIElement.ElementFromPoint(e.Location)
        riga = elemento.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridRow))
        If (elemento.GetType Is GetType(Infragistics.Win.UltraWinGrid.RowSelectorUIElement)) Then
            Select Case e.Button
                Case Windows.Forms.MouseButtons.Left
                    bottonesinistro = True
                Case Else
                    bottonesinistro = False
            End Select
        End If
    End Sub

    Private Sub UltraGridTestate_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles UltraGridTestate.MouseUp
        If bottonesinistro Then
            Dim rigaappoggio As Integer = riga.Index
            Dim xmouse As Integer
            Dim ymouse As Integer
            Dim puntatore As Point
            Dim xmousemax = UltraGridTestate.Size.Width
            Dim ymousemax = UltraGridTestate.Size.Height
            Dim rowappoggio As DataRow
            If (e.Location.X < 5) Or (e.Location.X > (xmousemax - 5)) Then
                xmouse = 5
            Else
                xmouse = e.Location.X
            End If
            If e.Location.Y < 25 Then
                ymouse = 30
            Else
                ymouse = e.Location.Y
            End If
            If (e.Location.Y > (UltraGridTestate.Rows.Count * 19 + 25)) Then
                ymouse = UltraGridTestate.Rows.Count * 19 + 20
            End If
            puntatore.X = xmouse
            puntatore.Y = ymouse
            Dim elemento As Infragistics.Win.UIElement = UltraGridTestate.DisplayLayout.UIElement.ElementFromPoint(puntatore)
            rowappoggio = dttestate.NewRow
            riga = elemento.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridRow))
            If bottonesinistro And (rigaappoggio <> riga.Index) Then
                For i As Integer = 0 To dttestate.Rows(0).ItemArray.Count - 1
                    rowappoggio.Item(i) = dttestate.Rows(rigaappoggio).Item(i)
                Next
                dttestate.Rows.RemoveAt(rigaappoggio)
                dttestate.AcceptChanges()
                If riga.Index > rigaappoggio Then
                    dttestate.Rows.InsertAt(rowappoggio, riga.Index + 1)
                Else
                    dttestate.Rows.InsertAt(rowappoggio, riga.Index)
                End If
                UltraGridTestate.Refresh()
                UltraGridTestate.Selected.Rows.Clear()
            End If
            bottonesinistro = False
        End If

    End Sub

    Private Sub UltraMonthViewSingleData_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraMonthViewSingleData.DoubleClick

    End Sub

    Private Sub UltraMonthViewSingleData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraMonthViewSingleData.Click
        inizializzazione()
        'MsgBox(UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date)
    End Sub

    Private Sub inizializzazione()
        Dim giorno As Integer
        Dim giorni As New ArrayList(8)
        giorni.Add("xx")
        giorni.Add("Lu")
        giorni.Add("Ma")
        giorni.Add("Me")
        giorni.Add("Gi")
        giorni.Add("Ve")
        giorni.Add("Sa")
        giorni.Add("Do")
        giorno = UltraMonthViewSingleData.CalendarInfo.ActiveDay.DayOfWeek.DayOfTheWeek
        If giorno = 0 Then
            giorno = 7
        End If
        Form1.UltraStatusBar1.Panels(2).Text = ""
        Form1.UltraStatusBar1.Panels(1).Visible = False
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = 0
        Form1.UltraStatusBar1.Panels(0).Text = "Inizializzazione in corso, attendere..."
        Form1.UltraStatusBar1.Refresh()
        dttestate.Clear()
        UltraButtonStampa.Enabled = False
        UltraButtonExcel.Enabled = False
        UltraButtonPDF.Enabled = False
        UltraButtonStampa2.Enabled = False
        dvdistribuzioni.Table = Me.ASDDBDataSet.Tabella_Distribuzioni
        dvdistribuzioni.Sort = "Testata"
        dvtestate.Table = Me.ASDDBDataSet.Testate
        dvtestate.Sort = "Importanza"
        'IMPORTANZA
        UltraGridTestate.DataSource = dttestate
        For i As Integer = 0 To dvtestate.Count - 1
            Dim elencodistribuzioni As New Infragistics.Win.ValueList
            dttestate.NewRow()
            dttestate.Rows.Add()
            dttestate.Rows(dttestate.Rows.Count - 1).Item(2) = dvtestate.Item(i).Item(0)
            dttestate.Rows(dttestate.Rows.Count - 1).Item(1) = dvtestate.Item(i).Item(1)
            dttestate.Rows(dttestate.Rows.Count - 1).Item(0) = dvtestate.Item(i).Item(giorno + 1)
            dvdistribuzioni.RowFilter = "Testata = '" & dvtestate.Item(i).Item(1) & "'"
            For k As Integer = 0 To dvdistribuzioni.Count - 1
                If dvdistribuzioni.Item(k).Item(2) Then 'verifica se la distro è attiva
                    elencodistribuzioni.ValueListItems.Add(dvdistribuzioni.Item(k).Item(1))
                End If
            Next
            'UltraGridTestate.DataSource = dttestate
            'UltraGridTestate.Refresh()
            UltraGridTestate.Rows(i).Cells("Distribuzione").ValueList = elencodistribuzioni
            dttestate.Rows(dttestate.Rows.Count - 1).Item(3) = UltraGridTestate.Rows(i).Cells("Distribuzione").ValueList.GetValue(0)
            dttestate.Rows(dttestate.Rows.Count - 1).Item(4) = dvdistribuzioni.Item(0).Item(3)
            dttestate.Rows(dttestate.Rows.Count - 1).Item(5) = dvdistribuzioni.Item(0).Item(6)
            If dvtestate.Item(i).Item(9) Then 'verifica se la testata è attiva

            Else
                UltraGridTestate.Rows(i).Cells(0).Value = False
                For k As Integer = 0 To 5
                    UltraGridTestate.Rows(i).Cells(k).Activation = Infragistics.Win.UltraWinGrid.Activation.Disabled
                Next
                Form1.UltraStatusBar1.Panels(0).Text = "Sono presenti testate non attive. Per visualizzarle attivarle dalla relativa tabella."
                Form1.UltraStatusBar1.Refresh()
            End If
        Next
        'tabella e griglia chiusure
        'Me.ChiusureTableAdapter.FillByGiorno(Me.ASDDBDataSet.Chiusure, UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date)
        Me.ChiusureTableAdapter.Fill(Me.ASDDBDataSet.Chiusure)
        dvchiusure.Table = Me.ASDDBDataSet.Chiusure
        dvchiusure.RowFilter = "Giorno = '" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date & "'"
        dvchiusure.Sort = "PI"
        'dtchiusure .Columns .Add ("PI", System.Type.GetType("System.Int32")
        For i As Integer = 0 To dvchiusure.Count - 1
            'UltraMonthViewSingleData.CalendarInfo.ActiveDay.CalendarInfo.Appearances.Insert(BackColor., Color.DeepPink)
            UltraMonthViewSingleData.CalendarInfo.Appointments.Add(UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date, dvchiusure.Item(i).Item("PI") & "-Chiuso")
            'dtchiusure.Rows(i).Item("PI") = dvchiusure.Item(i).Item("PI")
        Next

        'tabella e griglia PI 
        Me.PITableAdapter.Fill(Me.ASDDBDataSet.PI)
        dvpi.Table = Me.ASDDBDataSet.PI
        dvpi.RowFilter = "Chiusura" & giorni(giorno) & " = False" 'verifica e filtra i PI in base alla NON chiusura
        dvpi.Sort = "PI"
        'dtpi .Columns .Add ("PI", System.Type.GetType("System.Int32")
        'Dim indicechiusure As Integer = 0
        'For i As Integer = 0 To dvpi.Count - 1
        '    If dvpi.Item(i).Item(0) < dvchiusure.Item(indicechiusure).Item(0) Then
        '        dtpi()
        '    End If
        'Next

        'gestire giri alternativi
        Me.AlternativiTableAdapter.Fill(Me.ASDDBDataSet.Alternativi)
        dvalternativi.Table = Me.ASDDBDataSet.Alternativi
        dvalternativi.RowFilter = "Giorno = '" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date & "'"
        dvalternativi.Sort = "PI"
        For i As Integer = 0 To dvalternativi.Count - 1
            UltraMonthViewSingleData.CalendarInfo.Appointments.Add(UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date, dvalternativi.Item(i).Item("PI") & "-Alternativo")
        Next
        'protezione da eliminare alla vendita del programma
        'inizio
        'If UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Year > 2008 Then
        '    UltraButtonCreaDistribuzione.Enabled = False
        'End If
        'fine
        Form1.UltraStatusBar1.Panels(2).Text = ""
        Form1.UltraStatusBar1.Panels(1).Visible = False
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = 0
        Form1.UltraStatusBar1.Panels(0).Text = "Inizializzazione terminata correttamente."
        Form1.UltraStatusBar1.Refresh()
    End Sub

    Private ReadOnly Property App_Path() As String
        Get
            App_Path = Environment.GetCommandLineArgs()(0) & "\.."
        End Get
    End Property

    Private Sub stampapdr()
        Dim clPDF As New clsPDFCreator
        Dim strFile As String
        Dim i As Single

        ' Imposta il file di output
        strFile = App_Path & "\Demo.pdf"

        With clPDF
            .Title = "Demo clsPDFCreator"           ' Titolo
            .ScaleMode = clsPDFCreator.pdfScaleMode.pdfCentimeter                 ' Unità di misura
            .PaperSize = clsPDFCreator.pdfPaperSize.pdfA4                     ' Formato pagina
            .Margin = 0                                 ' Margine
            .Orientation = clsPDFCreator.pdfPageOrientation.pdfPortrait               ' Orientamento

            '.EncodeASCII85 = chkASCII85.Checked

            .InitPDFFile(strFile)                    ' inizializza il file

            ' Definisce le risorse relative ai font
            .LoadFont("Fnt1", "Times New Roman")                              ' Tipo TrueType
            .LoadFont("Fnt2", "Arial", clsPDFCreator.pdfFontStyle.pdfItalic)                                ' Tipo TrueType
            .LoadFont("Fnt3", "Courier New")                                      ' Tipo TrueType
            .LoadFontStandard("Fnt4", "Courier New", clsPDFCreator.pdfFontStyle.pdfBoldItalic)      ' Tipo Type1

            ' Definisce le risorse relative alle immagini
            .LoadImgFromBMPFile("Img1", App_Path & "\img\20x20x24.bmp") ', pdfGrayScale
            .LoadImgFromBMPFile("Img2", App_Path & "\img\200x200x24.bmp") ', pdfGrayScale

            ' Definisce una risorsa comune da stampare solo sulle pagine pari
            .StartObject("Item1", clsPDFCreator.pdfObjectType.pdfAllPages)  ' , pdfEvenPages
            .SetColorFill(-240)
            .SetTextHorizontalScaling(120)
            .DrawText(6, 4, "Bozza", "Fnt2", 200, , 60)
            .SetColorFill(0)
            .EndObject()

            '     Inizializza la prima pagina
            .BeginPage()


            .DrawText(19, 1.5, "pag. " & Trim(CStr(.Pages)), "Fnt1", 12, clsPDFCreator.pdfTextAlign.pdfAlignRight)
            .DrawObject("Footers")
            .DrawText(10.5, 27, "Testo", "Fnt1", 48, clsPDFCreator.pdfTextAlign.pdfCenter)

            .SetTextHorizontalScaling(70)
            .DrawText(20, 25, "Allineato a destra", "Fnt2", 24, clsPDFCreator.pdfTextAlign.pdfAlignRight)
            .DrawText(1, 25, "Allineato a sinistra", "Fnt2", 24, clsPDFCreator.pdfTextAlign.pdfAlignLeft)
            .DrawText(10.5, 25, "Allineato al centro", "Fnt2", 24, clsPDFCreator.pdfTextAlign.pdfCenter)
            .SetTextHorizontalScaling(100)

            For i = 0 To 359 Step 20
                .SetColorFill(RGB(CByte(255 * i / 359), CByte(255 * (359 - i) / 359), 128))
                .DrawText(7, 17, "testo ruotato " & CStr(i) & "°", "Fnt2", 20, , i)
            Next

            .SetColorFill(RGB(255, 255, 0))
            .SetColorStroke(RGB(255, 0, 255))
            .SetTextRenderingMode(1)
            .SetTextHorizontalScaling(50)
            .DrawText(20, 19, "Contorno", "Fnt3", 200, clsPDFCreator.pdfTextAlign.pdfAlignRight)
            .SetTextRenderingMode(0)
            .SetTextHorizontalScaling(100)

            .SetColorFill(0)
            .SetColorStroke(0)

            .SetTextHorizontalScaling(50)
            .DrawText(20, 10, "Testo compresso 50%", "Fnt2", 24, clsPDFCreator.pdfTextAlign.pdfAlignRight)

            .SetTextHorizontalScaling(150)
            .DrawText(1, 10, "Testo espanso 150%", "Fnt4", 24, clsPDFCreator.pdfTextAlign.pdfAlignLeft)

            .SetCharSpacing(5)
            .DrawText(1, 8, "Spaziatura caratteri 5", "Fnt3", 16, clsPDFCreator.pdfTextAlign.pdfAlignLeft)
            .SetCharSpacing(0)
            .SetWordSpacing(10)
            .DrawText(20, 7, "Spaziatura fra le parole 10", "Fnt3", 16, clsPDFCreator.pdfTextAlign.pdfAlignRight)

            ' Chiude la prima pagina
            .EndPage()

            '     Inizializza la seconda pagina
            .BeginPage()
            .DrawText(19, 1.5, "pag. " & Trim(CStr(.Pages)), "Fnt1", 12, clsPDFCreator.pdfTextAlign.pdfAlignRight)
            .DrawObject("Footers")
            .DrawText(10.5, 27, "Grafica", "Fnt1", 48, clsPDFCreator.pdfTextAlign.pdfCenter)
            .Rectangle(1, 2, 19, 24.5, clsPDFCreator.pdfPathOptions.Stroked)

            .DrawImg("Img2", 8, 17, 4, 4)
            .DrawImg("Img1", 14, 24, 3, 3)

            .SetDash(0.5, 0.3)
            .MoveTo(9, 2)
            .LineTo(9, 10, clsPDFCreator.pdfPathOptions.Nil)
            .LineTo(1, 10, clsPDFCreator.pdfPathOptions.Stroked)
            .SetDash(0)

            .Rectangle(5, 5, 2.5, 3, , 0.5)
            .SetColorFill(RGB(123, 45, 56))
            .Rectangle(2, 3, 2.5, 3, clsPDFCreator.pdfPathOptions.Filled, 0.5)
            .SetColorFill(0)

            .SetLineWidth(0.05)
            .SetColorStroke(RGB(255, 0, 0))
            .DrawCircle(13, 7, 2, clsPDFCreator.pdfPathOptions.Stroked)
            .SetColorStroke(RGB(0, 255, 0))
            .DrawCircle(15, 7, 2, clsPDFCreator.pdfPathOptions.Stroked)
            .SetColorStroke(RGB(0, 0, 255))
            .DrawCircle(15, 5, 2, clsPDFCreator.pdfPathOptions.Stroked)
            .SetColorStroke(0)
            .DrawCircle(13, 5, 2, clsPDFCreator.pdfPathOptions.Stroked)

            For i = 0 To 90 Step 10
                .SetColorStroke(RGB(255 - i, i, 255 - i))
                .Arc(10, 15, 5, , , 0.5, , i, , clsPDFCreator.pdfPathOptions.Stroked)
            Next

            .SetLineCap(0)
            .SetLineWidth(0.8)
            .SetColorStroke(RGB(255, 0, 0))
            .MoveTo(4, 20)
            .LineTo(4, 25)
            .SetColorStroke(RGB(255, 255, 0))
            .MoveTo(5, 20)
            .LineTo(5, 22)
            .SetColorStroke(RGB(0, 255, 255))
            .SetLineCap(1)
            .MoveTo(6, 20)
            .LineTo(6, 24)
            .SetColorStroke(RGB(130, 127, 80))
            .SetLineCap(2)
            .MoveTo(7, 20)
            .LineTo(7, 21)
            .SetColorStroke(0)
            .SetLineWidth(0)
            .SetLineCap(0)

            .SetDash(0.2, 0.2)
            .MoveTo(7, 21)
            .Curve(6, 24, 5, 22, 4, 25)
            .SetDash(0)

            .MoveTo(8, 20)
            .LineTo(3, 20, clsPDFCreator.pdfPathOptions.Nil)
            .LineTo(3, 25.5)



            ' Chiude la seconda pagina
            .EndPage()


            ' Definisce una risorsa da stampare su tutte le pagine
            .StartObject("Footers", clsPDFCreator.pdfObjectType.pdfAllPages)
            .DrawText(20, 1.5, "di " & Trim(CStr(.Pages)), "Fnt1", 12, clsPDFCreator.pdfTextAlign.pdfAlignRight)
            .EndObject()


            ' Chiude il documento
            .ClosePDFFile()

        End With

    End Sub

    ''' <summary>
    ''' Add and image as the watermark on each page of the source pdf to create a new pdf with watermark
    ''' </summary>
    ''' <param name="sourceFile">the full path to the source pdf</param>
    ''' <param name="outputFile">the full path where the watermarked pdf will be saved to</param>
    ''' <param name="watermarkImage">the full path to the image file to use as the watermark</param>
    ''' <remarks>The watermark image will be align in the center of each page</remarks>
    Public Shared Sub AddWatermarkImage(ByVal sourceFile As String, ByVal outputFile As String, ByVal watermarkImage As String)
        Dim reader As iTextSharp.text.pdf.PdfReader = Nothing
        Dim stamper As iTextSharp.text.pdf.PdfStamper = Nothing
        Dim img As iTextSharp.text.Image = Nothing
        Dim underContent As iTextSharp.text.pdf.PdfContentByte = Nothing
        Dim rect As iTextSharp.text.Rectangle = Nothing
        Dim X, Y As Single
        Dim pageCount As Integer = 0
        Try
            reader = New iTextSharp.text.pdf.PdfReader(sourceFile)
            rect = reader.GetPageSizeWithRotation(1)
            stamper = New iTextSharp.text.pdf.PdfStamper(reader, New System.IO.FileStream(outputFile, IO.FileMode.Create))
            img = iTextSharp.text.Image.GetInstance(watermarkImage)
            If img.Width > rect.Width OrElse img.Height > rect.Height Then
                img.ScaleToFit(rect.Width, rect.Height)
                X = (rect.Width - img.ScaledWidth) / 2
                Y = (rect.Height - img.ScaledHeight) / 2
            Else
                X = (rect.Width - img.Width) / 2
                Y = (rect.Height - img.Height) / 2
            End If
            img.SetAbsolutePosition(X, Y)
            pageCount = reader.NumberOfPages()
            For i As Integer = 1 To pageCount
                underContent = stamper.GetUnderContent(i)
                underContent.AddImage(img)
            Next
            stamper.Close()
            reader.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Add text as the watermark to each page of the source pdf to create a new pdf with text watermark
    ''' </summary>
    ''' <param name="sourceFile">the full path to the source pdf file</param>
    ''' <param name="outputFile">the full path where the watermarked pdf file will be saved to</param>
    ''' <param name="watermarkText">the string array conntaining the text to use as the watermark. Each element is treated as a line in the watermark</param>
    ''' <param name="watermarkFont">the font to use for the watermark. The default font is HELVETICA</param>
    ''' <param name="watermarkFontSize">the size of the font. The default size is 48</param>
    ''' <param name="watermarkFontColor">the color of the watermark. The default color is blue</param>
    ''' <param name="watermarkFontOpacity">the opacity of the watermark. The default opacity is 0.3</param>
    ''' <param name="watermarkRotation">the rotation in degree of the watermark. The default rotation is 45 degree</param>
    ''' <remarks></remarks>
    Public Shared Sub AddWatermarkText(ByVal sourceFile As String, ByVal outputFile As String, ByVal watermarkText() As String, _
                                       Optional ByVal watermarkFont As iTextSharp.text.pdf.BaseFont = Nothing, _
                                       Optional ByVal watermarkFontSize As Single = 48, _
                                       Optional ByVal watermarkFontColor As iTextSharp.text.Color = Nothing, _
                                       Optional ByVal watermarkFontOpacity As Single = 0.3F, _
                                       Optional ByVal watermarkRotation As Single = 45.0F)

        Dim reader As iTextSharp.text.pdf.PdfReader = Nothing
        Dim stamper As iTextSharp.text.pdf.PdfStamper = Nothing
        Dim gstate As iTextSharp.text.pdf.PdfGState = Nothing
        Dim underContent As iTextSharp.text.pdf.PdfContentByte = Nothing
        Dim rect As iTextSharp.text.Rectangle = Nothing
        Dim currentY As Single = 0.0F
        Dim offset As Single = 0.0F
        Dim pageCount As Integer = 0
        Try
            reader = New iTextSharp.text.pdf.PdfReader(sourceFile)
            rect = reader.GetPageSizeWithRotation(1)
            stamper = New iTextSharp.text.pdf.PdfStamper(reader, New System.IO.FileStream(outputFile, IO.FileMode.Create))
            If watermarkFont Is Nothing Then
                watermarkFont = iTextSharp.text.pdf.BaseFont.CreateFont(iTextSharp.text.pdf.BaseFont.HELVETICA, _
                                                              iTextSharp.text.pdf.BaseFont.CP1252, _
                                                              iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED)
            End If
            If watermarkFontColor Is Nothing Then
                watermarkFontColor = iTextSharp.text.Color.BLUE
            End If
            gstate = New iTextSharp.text.pdf.PdfGState()
            gstate.FillOpacity = watermarkFontOpacity
            gstate.StrokeOpacity = watermarkFontOpacity
            pageCount = reader.NumberOfPages()
            For i As Integer = 1 To pageCount
                underContent = stamper.GetOverContent(i)
                With underContent
                    .SaveState()
                    .SetGState(gstate)
                    .SetColorFill(watermarkFontColor)
                    .BeginText()
                    .SetFontAndSize(watermarkFont, watermarkFontSize)
                    .SetTextMatrix(30, 30)
                    If watermarkText.Length > 1 Then
                        currentY = (rect.Height / 2) + ((watermarkFontSize * watermarkText.Length) / 2)
                    Else
                        currentY = (rect.Height / 2)
                    End If
                    For j As Integer = 0 To watermarkText.Length - 1
                        If j > 0 Then
                            offset = (j * watermarkFontSize) + (watermarkFontSize / 4) * j
                        Else
                            offset = 0.0F
                        End If
                        .ShowTextAligned(iTextSharp.text.Element.ALIGN_CENTER, watermarkText(j), rect.Width / 2, currentY - offset, watermarkRotation)
                    Next
                    .EndText()
                    .RestoreState()
                End With
            Next
            stamper.Close()
            reader.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function MakeVerticalText(ByVal oWriter As iTextSharp.text.pdf.PdfWriter, ByVal sText As String, ByVal fGrandezza As Integer, ByVal fNome As String, ByVal gradi As Integer, ByVal grandezza As Integer, ByVal allineamento As Integer) As iTextSharp.text.Image
        Dim oTemplate As iTextSharp.text.pdf.PdfTemplate = oWriter.DirectContent().CreateTemplate(grandezza, grandezza)
        Dim oBF As iTextSharp.text.pdf.BaseFont = iTextSharp.text.pdf.BaseFont.CreateFont(fNome, "winansi", False) '<--Font family 
        Dim fsize As Single = fGrandezza '<--Font size 
        Dim fwidth As Single = oBF.GetWidthPoint(sText, fsize)
        oTemplate.BeginText()
        oTemplate.SetColorFill(iTextSharp.text.Color.LIGHT_GRAY)
        oTemplate.SetFontAndSize(oBF, fsize)
        oTemplate.SetTextMatrix(0, 2)
        oTemplate.ShowText(sText)
        oTemplate.EndText()
        oTemplate.Width = fwidth
        Dim oImg As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(oTemplate)
        oImg.RotationDegrees = gradi '<--Angle of font rotation 
        oImg.Alignment = allineamento
        Return oImg
    End Function

    Private Function disegnagriglia(ByVal oWriter As iTextSharp.text.pdf.PdfWriter, ByVal foglio As iTextSharp.text.Rectangle) As iTextSharp.text.Image
        Dim oTemplate As iTextSharp.text.pdf.PdfTemplate = oWriter.DirectContent().CreateTemplate(foglio.Width, foglio.Height)
        oTemplate.Rectangle(10, 10, foglio.Width - 10, foglio.Height - 10)
        Dim oImg As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(oTemplate)
        Return oImg
    End Function

    Private Sub disattiva(ByVal stato As Boolean)
        'UltraButtonCreaDistribuzione.Enabled = stato
        'UltraButtonExcel.Enabled = stato
        'UltraButtonPDF.Enabled = stato
        'UltraButtonStampa.Enabled = stato
        'UltraButtonStampa2.Enabled = stato
        'UltraGridGiri.Enabled = stato
        'UltraGridTestate.Enabled = stato
        UltraGroupBox2.Enabled = stato
        UltraGroupBoxChiusure.Enabled = stato
        UltraGroupBoxData.Enabled = stato
        UltraGroupBoxGiriAlternativi.Enabled = stato
        UltraGroupBoxTestate.Enabled = stato
    End Sub

    Private Sub UltraButtonStampa2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonStampa2.Click
        Dim img As iTextSharp.text.Image = Nothing
        Dim elenco As New ArrayList
        'Dim stringa As New ArrayList
        Dim evnt As New MyTableEvent
        'stringa.Add("prova")
        Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Year & "\" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Month & "\" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Day
        Try
            System.IO.Directory.CreateDirectory(percorso)
        Catch ex As Exception
            'la directory già esiste
        End Try
        disattiva(False)
        Form1.UltraStatusBar1.Panels(2).Text = ""
        Form1.UltraStatusBar1.Panels(1).Visible = True
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Maximum = 100
        Form1.UltraStatusBar1.Panels(0).Text = "Stampa grafica dei giri in corso..."
        Form1.UltraStatusBar1.Refresh()
        For ii = 0 To dvgiri.Count - 1
            Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(ii / (dvgiri.Count - 1) * 100)
            Form1.UltraStatusBar1.Panels(2).Text = "Stampa del giro " & dvgiri.Item(ii).Item(0) & "."
            Form1.UltraStatusBar1.Refresh()
            dvreportgiornaliero.RowFilter = "Giro = " & dvgiri.Item(ii).Item("Giro")
            If dvreportgiornaliero.Count > 0 Then
                'pagina dei commenti
                Dim documentprimo = New iTextSharp.text.Document(iTextSharp.text.PageSize.A4)
                Dim documentprimowriter As iTextSharp.text.pdf.PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(documentprimo, New IO.FileStream(percorso & "\" & "PrimaPagina" & dvgiri(ii).Item(0) & ".nor", IO.FileMode.Create))
                documentprimo.AddTitle("Prima pagina del giro " & dvgiri.Item(ii).Item("Giro").ToString & " del " & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date)
                documentprimo.AddCreator("Northia Multimedia Service")
                documentprimo.Open()

                'parte grafica della prima pagina commenti
                documentprimo.SetMargins(10, 10, Int(documentprimo.PageSize.Width - 10), documentprimo.PageSize.Height - 10)
                documentprimo.NewPage()
                Dim grxprimo As iTextSharp.text.pdf.PdfContentByte = documentprimowriter.DirectContent
                Dim bfprimo As iTextSharp.text.pdf.BaseFont = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "winansi", False) '<--Font family 
                grxprimo.SetLineWidth(5)
                grxprimo.Rectangle(50, 50, documentprimo.PageSize.Width - 100, documentprimo.PageSize.Height - 100)
                grxprimo.Stroke()
                grxprimo.MoveTo(50, documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 15 / 100))
                grxprimo.LineTo(documentprimo.PageSize.Width - 50, documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 15 / 100))
                grxprimo.Stroke()
                grxprimo.SetLineWidth(3)
                grxprimo.MoveTo(100, documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 50 / 100))
                grxprimo.LineTo(documentprimo.PageSize.Width - 100, documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 50 / 100))
                grxprimo.Stroke()
                grxprimo.BeginText()
                'inizio testo prova
                Dim bf As iTextSharp.text.pdf.BaseFont = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "winansi", False) '<--Font family 
                grxprimo.BeginText()
                grxprimo.SetFontAndSize(bf, 16)
                grxprimo.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Servizi Diffusionali srl", Int(documentprimo.PageSize.Width * 10 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 8 / 100), 0)
                'grxprimo.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "GIRO", Int(documentprimo.PageSize.Width * 88 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 4 / 100), 0)
                grxprimo.EndText()
                'grxprimo.BeginText()
                'grxprimo.SetFontAndSize(bf, 10)
                'grxprimo.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Via Galla Placidia, 184", Int(documentprimo.PageSize.Width * 48 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 8 / 100), 0)
                'grxprimo.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "00159 Roma", Int(documentprimo.PageSize.Width * 48 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 9.5 / 100), 0)
                'grxprimo.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Tel. 06.4381754", Int(documentprimo.PageSize.Width * 48 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 11 / 100), 0)
                'grxprimo.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Fax. 06.43535175", Int(documentprimo.PageSize.Width * 48 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 12.5 / 100), 0)
                'grxprimo.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "E-mail: info@promonew.it", Int(documentprimo.PageSize.Width * 48 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 14 / 100), 0)
                'grxprimo.EndText()
                grxprimo.BeginText()
                grxprimo.SetFontAndSize(bf, 12)
                grxprimo.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "DIFFUSIONE DISTRIBUZIONE", Int(documentprimo.PageSize.Width * 10 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 10 / 100), 0)
                grxprimo.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "PROMOZIONE STAMPA", Int(documentprimo.PageSize.Width * 10 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 12 / 100), 0)
                'grxprimo.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "COMUNICAZIONE:", Int(documentprimo.PageSize.Width * 50 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 93.5 / 100), 0)
                grxprimo.EndText()
                grxprimo.BeginText()
                grxprimo.SetFontAndSize(bf, 10)
                grxprimo.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "TIPOLOGIA", Int(documentprimo.PageSize.Width * 75.3 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 8 / 100), 0)
                grxprimo.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "SERVIZIO", Int(documentprimo.PageSize.Width * 75.3 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 9.5 / 100), 0)
                grxprimo.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "CONSEGNA", Int(documentprimo.PageSize.Width * 75.3 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 11 / 100), 0)
                grxprimo.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "ALLESTIMENTO", Int(documentprimo.PageSize.Width * 75.3 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 12.5 / 100), 0)
                grxprimo.EndText()
                grxprimo.BeginText()
                grxprimo.SetFontAndSize(bf, 8)
                grxprimo.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "SISTEMA OPERATIVO", Int(documentprimo.PageSize.Width * 77 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 98 / 100), 0)
                grxprimo.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "A.S.D.", Int(documentprimo.PageSize.Width * 92 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 98 / 100), 0)
                grxprimo.EndText()
                'fine testo prova
                'grxprimo.SetFontAndSize(bfprimo, 20)
                'grxprimo.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "PROMONEW s.r.l.", Int(documentprimo.PageSize.Width * 10 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 10 / 100), 0)
                'grxprimo.SetFontAndSize(bfprimo, 12)
                'OLD grxprimo.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Northia Multimedia Solution", Int(documentprimo.PageSize.Width * 70 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 90 / 100), 0)
                grxprimo.SetFontAndSize(bfprimo, 16)
                grxprimo.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "COMUNICAZIONE GENERALE", Int(documentprimo.PageSize.Width * 50 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 35 / 100), 0)
                grxprimo.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "COMUNICAZIONE DEL GIRO " & dvgiri.Item(ii).Item("Giro").ToString, Int(documentprimo.PageSize.Width * 50 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 60 / 100), 0)
                grxprimo.SetFontAndSize(bfprimo, 14)
                'grxprimo.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "A.S.D.", Int(documentprimo.PageSize.Width * 50 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 15 / 100), 0)
                grxprimo.ShowTextAligned(PdfContentByte.ALIGN_CENTER, UltraFormattedTextEditorCommentiGenerali.Text, Int(documentprimo.PageSize.Width * 50 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 40 / 100), 0)
                Dim indicenotegiro As Integer = 0
                Dim trovato As Boolean = False
                Do
                    If UltraGridGiri.Rows(indicenotegiro).Cells(0).Value = dvgiri.Item(ii).Item("Giro") Then
                        grxprimo.ShowTextAligned(PdfContentByte.ALIGN_CENTER, UltraGridGiri.Rows(indicenotegiro).Cells(1).Value.ToString, Int(documentprimo.PageSize.Width * 50 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 65 / 100), 0)
                        trovato = True
                    Else
                        indicenotegiro = indicenotegiro + 1
                    End If
                Loop Until trovato Or (indicenotegiro = UltraGridGiri.Rows.Count)
                grxprimo.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Diritti riservati (c) 2007-" & Today.Year.ToString & " - Northia Multimedia Solution", Int(documentprimo.PageSize.Width * 50 / 100), documentprimo.PageSize.Height - Int(documentprimo.PageSize.Height * 93 / 100), 0)
                grxprimo.EndText()
                documentprimo.NewPage()
                documentprimowriter.PageEmpty = False
                documentprimo.Close()


                'pagina delle consegne
                Dim document = New iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate)
                Dim documentwriter As iTextSharp.text.pdf.PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(document, New IO.FileStream(percorso & "\" & "Giro " & dvgiri(ii).Item(0) & ".nor", IO.FileMode.Create))
                'documentwriter.ClearTextWrap()
                document.AddTitle(dvgiri.Item(ii).Item("Giro").ToString & " del " & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date)
                document.AddCreator("Northia Multimedia Service")
                'document.Add(iTextSharp.text.IElement)
                'img = New iTextSharp.text.ImgWMF(Image.getInstance("watermark.jpg"), 200, 420)
                document.Open()

                'parte grafica della pagina report trasportatori

                document.SetMargins(10, 10, Int(document.PageSize.Height * 12 / 100), document.PageSize.Height - Int(document.PageSize.Height * 88.5 / 100))
                document.NewPage()

                'parte testo della pagina
                Dim totalecopie As Integer = 0
                Dim totali As String = ""

                Dim colonneineccesso As Integer = UltraGrid1.DisplayLayout.Bands(0).Columns.Count - 12 'luca 13/8/2019 invece di 12 c'era 10
                Dim tabella As New iTextSharp.text.pdf.PdfPTable(colonneineccesso + 7)


                Dim headerwidths As Single() = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60}
                Dim totalespazio As Integer = 68 + colonneineccesso * 3 'luca 13/8/2019 invece di 68 c'era 58
                Dim iniziocolonna As Integer = 0
                Form1.UltraStatusBar1.Panels(0).Text = "Creazione grafica della pagina in corso..."
                Form1.UltraStatusBar1.Refresh()
                Array.Resize(headerwidths, colonneineccesso + 7)
                headerwidths.SetValue((document.PageSize.Width - 20) * 3 / 100, 0)
                headerwidths.SetValue((document.PageSize.Width - 20) * (100 - totalespazio) / 100, 1)
                headerwidths.SetValue((document.PageSize.Width - 20) * 8 / 100, 2)
                'headerwidths.SetValue((document.PageSize.Width - 20) * 3 / 100, 3) 'luca 13/8/2019 invece di 
                headerwidths.SetValue((document.PageSize.Width - 20) * 17 / 100, 3) 'luca 13/8/2019 invece di 3 c'era 4
                headerwidths.SetValue((document.PageSize.Width - 20) * 22 / 100, 4) 'luca 13/8/2019 invece di 4 c'era 5
                'headerwidths.SetValue((document.PageSize.Width - 20) * 5 / 100, 6) 'luca 13/8/2019 invece di 
                For i As Integer = 0 To 6
                    iniziocolonna = iniziocolonna + headerwidths.GetValue(i)
                Next
                iniziocolonna = iniziocolonna + 10
                Dim grx As iTextSharp.text.pdf.PdfContentByte = documentwriter.DirectContent
                'Dim bf As iTextSharp.text.pdf.BaseFont = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "winansi", False) '<--Font family 
                'parte in basso a dx (totali) linea intermedia
                'MsgBox(iniziocolonna)
                ''grx.SetLineWidth(1)
                ''grx.MoveTo(Int(iniziocolonna - iniziocolonna * 15 / 100), document.PageSize.Height - Int(document.PageSize.Height * 88 / 100))
                ''grx.LineTo(Int(iniziocolonna - iniziocolonna * 15 / 100), document.PageSize.Height - Int(document.PageSize.Height * 92 / 100))
                ''grx.Stroke()
                ''grx.MoveTo(Int(iniziocolonna - iniziocolonna * 15 / 100), document.PageSize.Height - Int(document.PageSize.Height * 90 / 100))
                ''grx.LineTo(Int(document.PageSize.Width - 10), document.PageSize.Height - Int(document.PageSize.Height * 90 / 100))
                ''grx.Stroke()
                ''grx.MoveTo(Int(iniziocolonna), document.PageSize.Height - Int(document.PageSize.Height * 88 / 100))
                ''grx.LineTo(Int(iniziocolonna), document.PageSize.Height - Int(document.PageSize.Height * 92 / 100))
                ''grx.Stroke()
                ''grx.BeginText()
                ''grx.SetFontAndSize(bf, 5) 'luca 13/8/2019 invece di 5 c'era 8
                ''grx.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "SISTEMA OPERATIVO", Int(document.PageSize.Width * 77 / 100), document.PageSize.Height - Int(document.PageSize.Height * 97.9 / 100), 0)
                ''grx.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "A.S.D.", Int(document.PageSize.Width * 92 / 100), document.PageSize.Height - Int(document.PageSize.Height * 97.9 / 100), 0)
                ''grx.EndText()
                'inizio parte rimossa
                'grx.BeginText()
                'grx.SetFontAndSize(bf, 10)
                'grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, " TOTALE COPIE", Int(iniziocolonna - iniziocolonna * 15 / 100), document.PageSize.Height - Int(document.PageSize.Height * 89 / 100), 0)
                'grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, " TOTALE CONSEGNE", Int(iniziocolonna - iniziocolonna * 15 / 100), document.PageSize.Height - Int(document.PageSize.Height * 91 / 100), 0)
                'grx.EndText()
                'fine parte rimossa
                grx.BeginText()
                grx.SetFontAndSize(bf, 16)
                grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, dvgiri.Item(ii).Item("Giro").ToString, Int(document.PageSize.Width * 95 / 100), document.PageSize.Height - Int(document.PageSize.Height * 4.5 / 100), 0)
                'MsgBox(UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date())
                grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date(), Int(document.PageSize.Width * 80 / 100), document.PageSize.Height - Int(document.PageSize.Height * 7.7 / 100), 0)
                grx.EndText()
                Form1.UltraStatusBar1.Panels(0).Text = "Creazione tabella della pagina in corso..."
                Form1.UltraStatusBar1.Refresh()
                'headerwidths.SetValue(2, 0)
                tabella.TotalWidth = document.PageSize.Width - 20
                tabella.WidthPercentage = 100
                'tabella.WriteSelectedRows(0, -1, 10, document.PageSize.Height - Int(document.PageSize.Height * 10 / 100), documentwriter.DirectContent)

                'headerwidths(0) = 2.0F 'pi
                'headerwidths(1) = 19.0F + 100 - totalespazio 'note
                'headerwidths(2) = 5.0F 'tipologia
                'headerwidths(3) = 3.0F 'classe
                'headerwidths(4) = 7.0F 'ragione sociale
                'headerwidths(5) = 10.0F 'indirizzo
                'headerwidths.Add(2) 'giro
                'headerwidths.Add(2) 'percorrenza
                'headerwidths(6) = 4.0F 'dispencer
                For i As Integer = 1 To 7 'colonneineccesso
                    'totalespazio = totalespazio + 2
                    'headerwidths(6 + i) = 2.0F
                    headerwidths.SetValue(Int((document.PageSize.Width - 20) * 3 / 100), 4 + i) 'luca 13/8/2019 invece di 4 c'era 6
                Next
                'headerwidths(1) = headerwidths(1) + 100 - totalespazio
                'Dim usosingle As Single
                'For i As Integer = 0 To headerwidths.Count - 1
                'usosingle = CSng(headerwidths(i))
                'tabella.HeaderRows(usosingle, document.PageSize)
                'Next
                tabella.DefaultCell.BorderWidth = 2
                tabella.DefaultCell.HorizontalAlignment = iTextSharp.text.pdf.PdfPCell.ALIGN_CENTER
                tabella.DefaultCell.VerticalAlignment = iTextSharp.text.pdf.PdfPCell.ALIGN_MIDDLE
                'tabella.DefaultCell.Phrase.Font = iTextSharp.text.FontFactory.GetFont("Arial", 10)
                'tabella.SetWidths = Int((document.PageSize.Width - 20) * 2 / 100)
                tabella.AddCell(New iTextSharp.text.Phrase("PI", iTextSharp.text.FontFactory.GetFont("Arial", 8))) 'luca 13/8/2019 invece di 8 era 10
                'tabella.DefaultCell.Width = Int((document.PageSize.Width - 20) * (19 + 100 - totalespazio) / 100)
                tabella.AddCell(New iTextSharp.text.Phrase("Note", iTextSharp.text.FontFactory.GetFont("Arial", 8))) 'luca 13/8/2019 invece di 8 era 10
                'tabella.DefaultCell.Width = Int((document.PageSize.Width - 20) * 5 / 100)
                tabella.AddCell(New iTextSharp.text.Phrase("Tipologia", iTextSharp.text.FontFactory.GetFont("Arial", 8))) 'luca 13/8/2019 invece di 8 era 10
                'tabella.DefaultCell.Width = Int((document.PageSize.Width - 20) * 3 / 100)
                'tabella.AddCell(New iTextSharp.text.Phrase("Classe", iTextSharp.text.FontFactory.GetFont("Arial", 10))) 'luca 13/8/2019 invece di 
                'tabella.DefaultCell.Width = Int((document.PageSize.Width - 20) * 7 / 100)
                tabella.AddCell(New iTextSharp.text.Phrase("Ragione Sociale", iTextSharp.text.FontFactory.GetFont("Arial", 8))) 'luca 13/8/2019 invece di 8 era 10
                'tabella.DefaultCell.Width = Int((document.PageSize.Width - 20) * 10 / 100)
                tabella.AddCell(New iTextSharp.text.Phrase("Indirizzo", iTextSharp.text.FontFactory.GetFont("Arial", 8))) 'luca 13/8/2019 invece di 8 era 10
                'tabella.AddCell("Giro")
                'tabella.AddCell("Per.")
                'tabella.DefaultCell.Width = Int((document.PageSize.Width - 20) * 2 / 100)
                'tabella.AddCell(New iTextSharp.text.Phrase("Dispencer", iTextSharp.text.FontFactory.GetFont("Arial", 10))) 'luca 13/8/2019 invece di 
                For i As Integer = 10 To UltraGrid1.DisplayLayout.Bands(0).Columns.Count - 1
                    'tabella.DefaultCell.Width = Int((document.PageSize.Width - 20) * 2 / 100)
                    tabella.AddCell(New iTextSharp.text.Phrase(UltraGrid1.DisplayLayout.Bands(0).Columns(i).Header.Caption, iTextSharp.text.FontFactory.GetFont("Arial", 8))) 'luca 13/8/2019 invece di 8 era 10
                    'tabella.AddCell(UltraGrid1.DisplayLayout.Bands(0).Columns(i).Header.Caption)
                Next
                tabella.SetWidths(headerwidths)
                tabella.HeaderRows = 1
                tabella.DefaultCell.BorderWidth = 1


                'UltraGridPrintDocument1.Header.TextCenter = ""

                'UltraGridPrintDocument1.Footer.TextCenter = UltraGridGiri.Rows(i).Cells("Note").Value.ToString
                'UltraGridPrintDocument1.Footer.TextLeft = UltraGridGiri.Rows(i).Cells("Note").Value.ToString
                If dvgiri.Item(ii).Item("Percorrenza") Then
                    dvreportgiornaliero.Sort = "Percorrenza, Indirizzo ASC"
                Else
                    dvreportgiornaliero.Sort = "Indirizzo, Percorrenza ASC"
                End If
                UltraGrid1.DataSource = dvreportgiornaliero

                'UltraGrid1.DisplayLayout.Bands(0).Columns("Giro").Hidden = True 'colonna giro
                'UltraGrid1.DisplayLayout.Bands(0).Columns("Percorrenza").Hidden = True 'colonna percorrenza
                'UltraGrid1.DisplayLayout.Bands(0).Columns("Modificato").Hidden = True 'colonna modificato
                'UltraGridPrintDocument1.Header.Appearance.FontData.SizeInPoints = 18
                'UltraGridPrintDocument1.Footer.Appearance.FontData.SizeInPoints = 12
                'UltraGridPrintDocument1.Header.TextLeft = "Giro n." & dvgiri.Item(i).Item("Giro") & vbCrLf & "Distribuzione del " & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date
                UltraGrid1.Refresh()
                dvtestate.Sort = "Codice ASC"
                For k As Integer = UltraGrid1.DisplayLayout.Bands(0).Columns.Count - colonneineccesso - 1 To UltraGrid1.DisplayLayout.Bands(0).Columns.Count - 1
                    totalecopie = 0
                    For j As Integer = 0 To UltraGrid1.Rows.Count - 1
                        Try
                            totalecopie = totalecopie + UltraGrid1.Rows(j).Cells(k).Value
                        Catch ex As Exception

                        End Try
                    Next
                    If totalecopie > 0 Then
                        'MsgBox(UltraGrid1.DisplayLayout.Bands(0).Columns(k).Key)
                        'MsgBox(dvtestate.Find(UltraGrid1.DisplayLayout.Bands(0).Columns(k).Key))
                        'MsgBox(dvgiri.Item(ii).Item(0))
                        Dim testata5 As String = Microsoft.VisualBasic.Left(dvtestate.Item(dvtestate.Find(UltraGrid1.DisplayLayout.Bands(0).Columns(k).Key)).Item(0).ToString, 6)
                        'Dim testata5 As String = ""
                        totali = totali & testata5 & "(" & UltraGrid1.DisplayLayout.Bands(0).Columns(k).Key & ")" & "=" & totalecopie & " "
                    End If
                    'UltraGridPrintDocument1.Header.TextCenter = UltraGridPrintDocument1.Header.TextCenter & UltraGrid1.DisplayLayout.Bands(0).Columns(k).Key & "=" & totalecopie & " "
                    UltraFormattedTextEditor1.Text = UltraFormattedTextEditor1.Text & UltraGridPrintDocument1.Header.TextLeft & " " & UltraGridPrintDocument1.Header.TextCenter & vbCrLf
                Next
                For y As Integer = 0 To UltraGrid1.DisplayLayout.Rows.Count - 1
                    For x As Integer = 0 To UltraGrid1.DisplayLayout.Bands(0).Columns.Count - 1
                        If UltraGrid1.Rows(y).Cells(9).Value Then
                            tabella.DefaultCell.BackgroundColor = iTextSharp.text.Color.GRAY 'DA CAMBIARE POI CON IL PARAMETRO IMPOSTAZIONI
                        Else
                            tabella.DefaultCell.BackgroundColor = iTextSharp.text.Color.WHITE
                        End If
                        If (x <> 3) And (x <> 6) And (x <> 7) And (x <> 8) And (x <> 9) Then 'luca 13/8/2019 non c'era il 3 e l'8
                            tabella.AddCell(New iTextSharp.text.Phrase(UltraGrid1.Rows(y).Cells(x).Value.ToString, iTextSharp.text.FontFactory.GetFont("Arial", 8))) 'luca 13/8/2019 invece di 8 era 10
                            'tabella.AddCell(UltraGrid1.Rows(y).Cells(x).Value.ToString)
                        End If
                    Next
                Next
                grx.BeginText()
                grx.SetFontAndSize(bf, 14)
                grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, totali, Int(document.PageSize.Width * 2 / 100), document.PageSize.Height - Int(document.PageSize.Height * 95.8 / 100), 0) 'luca 13/8/2019 invece di 95.8 era 96
                grx.EndText()
                totali = ""
                'tabella.WidthPercentage = 100
                'MsgBox(tabella.Rows.Count)
                tabella.TableEvent = evnt
                document.Add(tabella)
                'If (UltraPrintPreviewDialog1.ShowDialog() = DialogResult.OK) Then
                '    UltraGridPrintDocument1.Print()
                '    ' STAMPA SECONDA PAGINA CON SOLE EDICOLE
                '    dvreportgiornaliero.RowFilter = ""
                '    dvreportgiornaliero.RowFilter = "Giro = " & dvgiri.Item(i).Item("Giro") & " AND Tipologia Like 'EDICOLA ESPO*'"
                '    'UltraPrintPreviewDialog1.ShowDialog()
                '    UltraGridPrintDocument1.Print()
                'End If

                'document.Add(New iTextSharp.text.Header("prova1", "prova2"))
                'document.Add(New iTextSharp.text.ImgTemplate(MakeVerticalText(documentwriter, "A.S.D.", 192, "Helvetica", -30, 200, 1)))
                'document.Add(New iTextSharp.text.ImgTemplate(disegnagriglia(documentwriter, iTextSharp.text.PageSize.A4.Rotate)))
                'documentwriter.AddJavaScript("this.print(false);", False)
                'MsgBox(documentwriter.PageNumber)
                'If documentwriter.PageNumber > 1 Then
                'document.Add(New iTextSharp.text.Paragraph("Hello World"))
                dvreportgiornaliero.RowFilter = ""
                dvreportgiornaliero.RowFilter = "Giro = " & dvgiri.Item(ii).Item("Giro") & " AND Tipologia Like 'EDICOLA ESPO*'"
                If dvgiri.Item(ii).Item("Percorrenza") Then
                    dvreportgiornaliero.Sort = "Percorrenza, Indirizzo ASC"
                Else
                    dvreportgiornaliero.Sort = "Indirizzo, Percorrenza ASC"
                End If
                UltraGrid1.DataSource = dvreportgiornaliero
                If dvreportgiornaliero.Count > 0 Then
                    'pagina aggiuntiva se dispari
                    Dim risultato As Integer = documentwriter.PageNumber Mod 2
                    If (risultato > 0) Then
                        document.NewPage()
                        documentwriter.PageEmpty = False
                    End If
                    'pagina edicole
                    Form1.UltraStatusBar1.Panels(0).Text = "Creazione grafica edicole in corso..."
                    Form1.UltraStatusBar1.Refresh()
                    document.NewPage()
                    ''grx.SetLineWidth(1)
                    ''grx.MoveTo(Int(iniziocolonna - iniziocolonna * 15 / 100), document.PageSize.Height - Int(document.PageSize.Height * 88 / 100))
                    ''grx.LineTo(Int(iniziocolonna - iniziocolonna * 15 / 100), document.PageSize.Height - Int(document.PageSize.Height * 92 / 100))
                    ''grx.Stroke()
                    ''grx.MoveTo(Int(iniziocolonna - iniziocolonna * 15 / 100), document.PageSize.Height - Int(document.PageSize.Height * 90 / 100))
                    ''grx.LineTo(Int(document.PageSize.Width - 10), document.PageSize.Height - Int(document.PageSize.Height * 90 / 100))
                    ''grx.Stroke()
                    ''grx.MoveTo(Int(iniziocolonna), document.PageSize.Height - Int(document.PageSize.Height * 88 / 100))
                    ''grx.LineTo(Int(iniziocolonna), document.PageSize.Height - Int(document.PageSize.Height * 92 / 100))
                    ''grx.Stroke()
                    ''grx.BeginText()
                    ''grx.SetFontAndSize(bf, 5) 'luca 13/8/2019 invece di 5 era 8
                    ''grx.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "SISTEMA OPERATIVO", Int(document.PageSize.Width * 77 / 100), document.PageSize.Height - Int(document.PageSize.Height * 98 / 100), 0)
                    ''grx.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "A.S.D.", Int(document.PageSize.Width * 92 / 100), document.PageSize.Height - Int(document.PageSize.Height * 98 / 100), 0)
                    ''grx.EndText()
                    ''grx.BeginText()
                    ''grx.SetFontAndSize(bf, 8) 'luca 13/8/2019 invece di 8 era 10
                    ''grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, " TOTALE COPIE", Int(iniziocolonna - iniziocolonna * 15 / 100), document.PageSize.Height - Int(document.PageSize.Height * 89 / 100), 0)
                    ''grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, " TOTALE CONSEGNE", Int(iniziocolonna - iniziocolonna * 15 / 100), document.PageSize.Height - Int(document.PageSize.Height * 91 / 100), 0)
                    ''grx.EndText()
                    grx.BeginText()
                    grx.SetFontAndSize(bf, 16)
                    grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, dvgiri.Item(ii).Item("Giro").ToString, Int(document.PageSize.Width * 95 / 100), document.PageSize.Height - Int(document.PageSize.Height * 4.5 / 100), 0) 'luca 13/8/2019 invece di 4.5 era 4.3
                    grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date(), Int(document.PageSize.Width * 80 / 100), document.PageSize.Height - Int(document.PageSize.Height * 7.7 / 100), 0) 'luca 13/8/2019 invece di 7.7 era 7.5
                    grx.EndText()



                    'UltraGrid1.DisplayLayout.Bands(0).Columns(6).Hidden = True 'colonna giro
                    'UltraGrid1.DisplayLayout.Bands(0).Columns(7).Hidden = True 'colonna percorrenza
                    'UltraGrid1.DisplayLayout.Bands(0).Columns(9).Hidden = True 'colonna modificato
                    'UltraGridPrintDocument1.Header.Appearance.FontData.SizeInPoints = 18
                    'UltraGridPrintDocument1.Footer.Appearance.FontData.SizeInPoints = 12
                    'UltraGridPrintDocument1.Header.TextLeft = "Giro n." & dvgiri.Item(i).Item("Giro") & vbCrLf & "Distribuzione del " & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date
                    UltraGrid1.Refresh()
                    tabella.DeleteBodyRows()
                    For k As Integer = 8 To UltraGrid1.DisplayLayout.Bands(0).Columns.Count - 1
                        totalecopie = 0
                        For j As Integer = 0 To UltraGrid1.Rows.Count - 1
                            Try
                                totalecopie = totalecopie + UltraGrid1.Rows(j).Cells(k).Value
                            Catch ex As Exception

                            End Try
                        Next
                        If totalecopie > 0 Then
                            totali = totali & UltraGrid1.DisplayLayout.Bands(0).Columns(k).Key & "=" & totalecopie & " "
                        End If
                        'UltraGridPrintDocument1.Header.TextCenter = UltraGridPrintDocument1.Header.TextCenter & UltraGrid1.DisplayLayout.Bands(0).Columns(k).Key & "=" & totalecopie & " "
                        UltraFormattedTextEditor1.Text = UltraFormattedTextEditor1.Text & UltraGridPrintDocument1.Header.TextLeft & " " & UltraGridPrintDocument1.Header.TextCenter & vbCrLf
                    Next
                    For y As Integer = 0 To UltraGrid1.DisplayLayout.Rows.Count - 1
                        For x As Integer = 0 To UltraGrid1.DisplayLayout.Bands(0).Columns.Count - 1
                            If UltraGrid1.Rows(y).Cells(9).Value Then
                                tabella.DefaultCell.BackgroundColor = iTextSharp.text.Color.GRAY 'DA CAMBIARE POI CON IL PARAMETRO IMPOSTAZIONI
                            Else
                                tabella.DefaultCell.BackgroundColor = iTextSharp.text.Color.WHITE
                            End If
                            If (x <> 3) And (x <> 6) And (x <> 7) And (x <> 8) And (x <> 9) Then 'luca 13/8/2019 aggiunti 3 e 8
                                tabella.AddCell(New iTextSharp.text.Phrase(UltraGrid1.Rows(y).Cells(x).Value.ToString, iTextSharp.text.FontFactory.GetFont("Arial", 8))) 'luca 13/8/2019 invece di 8 era 10
                                'tabella.AddCell(UltraGrid1.Rows(y).Cells(x).Value.ToString)
                            End If
                        Next
                    Next

                    grx.BeginText()
                    grx.SetFontAndSize(bf, 12)
                    grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, totali, Int(document.PageSize.Width * 2 / 100), document.PageSize.Height - Int(document.PageSize.Height * 95.8 / 100), 0)
                    grx.EndText()
                    'tabella.WidthPercentage = 100
                    'MsgBox(tabella.Rows.Count)
                    tabella.TableEvent = evnt
                    document.Add(tabella)
                End If

                'inizio stampa metropolitana
                totali = ""
                dvreportgiornaliero.RowFilter = ""
                dvreportgiornaliero.RowFilter = "Giro = " & dvgiri.Item(ii).Item("Giro") & " AND Tipologia Like 'METROPOLITAN*'"
                If dvgiri.Item(ii).Item("Percorrenza") Then
                    dvreportgiornaliero.Sort = "Percorrenza, Indirizzo ASC"
                Else
                    dvreportgiornaliero.Sort = "Indirizzo, Percorrenza ASC"
                End If
                UltraGrid1.DataSource = dvreportgiornaliero
                If dvreportgiornaliero.Count > 0 Then
                    'pagina aggiuntiva se dispari
                    Dim risultato As Integer = documentwriter.PageNumber Mod 2
                    If (risultato > 0) Then
                        document.NewPage()
                        documentwriter.PageEmpty = False
                    End If
                    Form1.UltraStatusBar1.Panels(0).Text = "Creazione grafica metropolitana in corso..."
                    Form1.UltraStatusBar1.Refresh()
                    document.NewPage()
                    ''grx.SetLineWidth(1)
                    ''grx.MoveTo(Int(iniziocolonna - iniziocolonna * 15 / 100), document.PageSize.Height - Int(document.PageSize.Height * 88 / 100))
                    ''grx.LineTo(Int(iniziocolonna - iniziocolonna * 15 / 100), document.PageSize.Height - Int(document.PageSize.Height * 92 / 100))
                    ''grx.Stroke()
                    ''grx.MoveTo(Int(iniziocolonna - iniziocolonna * 15 / 100), document.PageSize.Height - Int(document.PageSize.Height * 90 / 100))
                    ''grx.LineTo(Int(document.PageSize.Width - 10), document.PageSize.Height - Int(document.PageSize.Height * 90 / 100))
                    ''grx.Stroke()
                    ''grx.MoveTo(Int(iniziocolonna), document.PageSize.Height - Int(document.PageSize.Height * 88 / 100))
                    ''grx.LineTo(Int(iniziocolonna), document.PageSize.Height - Int(document.PageSize.Height * 92 / 100))
                    ''grx.Stroke()
                    ''grx.BeginText()
                    ''grx.SetFontAndSize(bf, 5) 'luca 13/8/2019 invece di 5 era 8
                    ''grx.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "SISTEMA OPERATIVO", Int(document.PageSize.Width * 77 / 100), document.PageSize.Height - Int(document.PageSize.Height * 98 / 100), 0)
                    ''grx.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "A.S.D.", Int(document.PageSize.Width * 92 / 100), document.PageSize.Height - Int(document.PageSize.Height * 98 / 100), 0)
                    ''grx.EndText()
                    ''grx.BeginText()
                    ''grx.SetFontAndSize(bf, 8) 'luca 13/8/2019 invece di 8 era 10
                    ''grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, " TOTALE COPIE", Int(iniziocolonna - iniziocolonna * 15 / 100), document.PageSize.Height - Int(document.PageSize.Height * 89 / 100), 0)
                    ''grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, " TOTALE CONSEGNE", Int(iniziocolonna - iniziocolonna * 15 / 100), document.PageSize.Height - Int(document.PageSize.Height * 91 / 100), 0)
                    ''grx.EndText()
                    grx.BeginText()
                    grx.SetFontAndSize(bf, 16)
                    grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, dvgiri.Item(ii).Item("Giro").ToString, Int(document.PageSize.Width * 95 / 100), document.PageSize.Height - Int(document.PageSize.Height * 4.5 / 100), 0)
                    grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date(), Int(document.PageSize.Width * 80 / 100), document.PageSize.Height - Int(document.PageSize.Height * 7.7 / 100), 0)
                    grx.EndText()



                    'UltraGrid1.DisplayLayout.Bands(0).Columns(6).Hidden = True 'colonna giro
                    'UltraGrid1.DisplayLayout.Bands(0).Columns(7).Hidden = True 'colonna percorrenza
                    'UltraGrid1.DisplayLayout.Bands(0).Columns(9).Hidden = True 'colonna modificato
                    'UltraGridPrintDocument1.Header.Appearance.FontData.SizeInPoints = 18
                    'UltraGridPrintDocument1.Footer.Appearance.FontData.SizeInPoints = 12
                    'UltraGridPrintDocument1.Header.TextLeft = "Giro n." & dvgiri.Item(i).Item("Giro") & vbCrLf & "Distribuzione del " & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date
                    UltraGrid1.Refresh()
                    tabella.DeleteBodyRows()
                    For k As Integer = 8 To UltraGrid1.DisplayLayout.Bands(0).Columns.Count - 1
                        totalecopie = 0
                        For j As Integer = 0 To UltraGrid1.Rows.Count - 1
                            Try
                                totalecopie = totalecopie + UltraGrid1.Rows(j).Cells(k).Value
                            Catch ex As Exception

                            End Try
                        Next
                        If totalecopie > 0 Then
                            totali = totali & UltraGrid1.DisplayLayout.Bands(0).Columns(k).Key & "=" & totalecopie & " "
                        End If
                        'UltraGridPrintDocument1.Header.TextCenter = UltraGridPrintDocument1.Header.TextCenter & UltraGrid1.DisplayLayout.Bands(0).Columns(k).Key & "=" & totalecopie & " "
                        UltraFormattedTextEditor1.Text = UltraFormattedTextEditor1.Text & UltraGridPrintDocument1.Header.TextLeft & " " & UltraGridPrintDocument1.Header.TextCenter & vbCrLf
                    Next
                    For y As Integer = 0 To UltraGrid1.DisplayLayout.Rows.Count - 1
                        For x As Integer = 0 To UltraGrid1.DisplayLayout.Bands(0).Columns.Count - 1
                            If UltraGrid1.Rows(y).Cells(9).Value Then
                                tabella.DefaultCell.BackgroundColor = iTextSharp.text.Color.GRAY 'DA CAMBIARE POI CON IL PARAMETRO IMPOSTAZIONI
                            Else
                                tabella.DefaultCell.BackgroundColor = iTextSharp.text.Color.WHITE
                            End If
                            If (x <> 3) And (x <> 6) And (x <> 7) And (x <> 8) And (x <> 9) Then
                                tabella.AddCell(New iTextSharp.text.Phrase(UltraGrid1.Rows(y).Cells(x).Value.ToString, iTextSharp.text.FontFactory.GetFont("Arial", 8))) 'luca 13/8/2019 invece di 8 era 10
                                'tabella.AddCell(UltraGrid1.Rows(y).Cells(x).Value.ToString)
                            End If
                        Next
                    Next

                    grx.BeginText()
                    grx.SetFontAndSize(bf, 12)
                    grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, totali, Int(document.PageSize.Width * 2 / 100), document.PageSize.Height - Int(document.PageSize.Height * 95.8 / 100), 0)
                    grx.EndText()
                    'tabella.WidthPercentage = 100
                    'MsgBox(tabella.Rows.Count)
                    tabella.TableEvent = evnt
                    document.Add(tabella)
                End If
                'fine metropolitana

                'document.Add(New iTextSharp.text.ImgTemplate(MakeVerticalText(documentwriter, "Pagina edicole", 96, "Helvetica", -30, 200, 1)))
                document.Close()
                elenco.Clear()
                'elenco.Add("primo.pdf")
                'elenco.Add(percorso & "\PrimaPagina" & dvgiri.Item(ii).Item("Giro").ToString & ".nor")
                elenco.Add("FAX.pdf")
                elenco.Add("fax2.pdf")
                elenco.Add(percorso & "\" & "Giro " & dvgiri.Item(ii).Item("Giro").ToString & ".nor")
                Utils.ConcatPdfFile(elenco, percorso & "\" & "GiroFinito" & dvgiri.Item(ii).Item("Giro").ToString & ".pdf")


            End If
        Next
        For ii = 0 To dvgiri.Count - 1
            'cancellazione file temporanei
            System.IO.File.Delete(percorso & "\Giro " & dvgiri.Item(ii).Item("Giro").ToString & ".nor")
            System.IO.File.Delete(percorso & "\PrimaPagina" & dvgiri.Item(ii).Item("Giro").ToString & ".nor")
            'stampa del pdf su stampante predefinita
            If UltraCheckEditorStampaAutomatica.Checked Then
                Dim PrcProcesso As New Process()
                'imposto il nome del documento pdf da aprire 
                PrcProcesso.StartInfo.FileName = percorso & "\" & "GiroFinito" & dvgiri.Item(ii).Item("Giro").ToString & ".pdf"
                'imposto l'operazione da eseguire 
                PrcProcesso.StartInfo.Verb = "Print"
                'avvio il processo. 
                Try
                    PrcProcesso.Start()
                Catch ex As Exception

                End Try
                For k As Integer = 0 To 1000
                    For i As Long = 0 To Form1.dvimpostazioni.Item(0).Item(8)
                        Dim kkk As Long = 1 + i
                    Next
                Next
            End If
        Next
        Form1.UltraStatusBar1.Panels(2).Text = ""
        Form1.UltraStatusBar1.Panels(1).Visible = False
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = 0
        Form1.UltraStatusBar1.Panels(0).Text = "Stampa dei giri terminata correttamente."
        Form1.UltraStatusBar1.Refresh()
        disattiva(True)
        dvreportgiornaliero.RowFilter = ""
        dvreportgiornaliero.Sort = "PI"
    End Sub

    Private Sub UltraCheckEditorAlternativi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraCheckEditorAlternativi.CheckedChanged
        'For i As Integer = 0 To UltraGridGiri.Rows.Count - 1
        'UltraGridGiri.Rows(i).Cells(2).Value = UltraCheckEditorAlternativi.Checked
        'Next
    End Sub

    Private Sub UltraGridTestate_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridTestate.AfterCellUpdate

    End Sub

    Private Sub UltraGridTestate_AfterCellListCloseUp(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridTestate.AfterCellListCloseUp
        'verificare il primo caricamento.
        If e.Cell.Column.Index = 3 Then
            'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.QConteggioTestateTipologia'. È possibile spostarla o rimuoverla se necessario.
            Me.QConteggioTestateTipologiaTableAdapter.FillByDistribuzione(Me.ASDDBDataSet.QConteggioTestateTipologia, UltraGridTestate.Rows(e.Cell.Row.Index).Cells(2).Value, e.Cell.Value) ' UltraComboTestata.Text, UltraComboDistribuzione.Text)
            Dim info As New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo
            Dim testo As String = ""
            Dim riga As DataRowView
            For i As Integer = 0 To QConteggioTestateTipologiaBindingSource.Count - 1
                riga = QConteggioTestateTipologiaBindingSource.Item(i)
                testo = testo & riga(2) & " " & riga(3) & vbCrLf
            Next
            info.ToolTipText = info.ToolTipText + testo
            UltraToolTipManagerStat.SetUltraToolTip(UltraGridTestate, info)
            UltraToolTipManagerStat.ShowToolTip(UltraGridTestate)
        End If
    End Sub
End Class

Class MyTableEvent
    Implements iTextSharp.text.pdf.IPdfPTableEvent

    Public Sub tableLayout(ByVal table As PdfPTable, ByVal width As Single()(), ByVal heights As Single(), ByVal headerRows As Integer, ByVal rowStart As Integer, ByVal canvases As PdfContentByte()) Implements IPdfPTableEvent.TableLayout
        Dim altezza As Integer = iTextSharp.text.PageSize.A4.Rotate.Height
        Dim larghezza As Integer = iTextSharp.text.PageSize.A4.Rotate.Width
        Dim widths As Single() = width(0)
        Dim grx As PdfContentByte = canvases(PdfPTable.TEXTCANVAS)
        grx.SaveState()
        grx.RestoreState()
        grx = canvases(PdfPTable.BASECANVAS)
        grx.SaveState()
        grx.SetColorStroke(iTextSharp.text.Color.BLACK)
        'rettangolo di pagina
        grx.SetLineWidth(5)
        grx.Rectangle(10, 10, larghezza - 20, altezza - 20)
        grx.Stroke()
        'parte in alto a sx (promonew e diffusione)
        grx.SetLineWidth(1.5)
        grx.MoveTo(10, altezza - Int(altezza * 5 / 100))
        grx.LineTo(Int(larghezza / 3), altezza - Int(altezza * 5 / 100))
        grx.Stroke()
        grx.MoveTo(Int(larghezza / 3), altezza - 10)
        grx.LineTo(Int(larghezza / 3), altezza - Int(altezza * 10 / 100))
        grx.Stroke()
        'parte in alto al centro (via e tipologia e consegna)
        grx.MoveTo(Int(larghezza * 45 / 100), altezza - 10)
        grx.LineTo(Int(larghezza * 45 / 100), altezza - Int(altezza * 10 / 100))
        grx.Stroke()
        grx.MoveTo(Int(larghezza * 45 / 100), altezza - Int(altezza * 5 / 100))
        grx.LineTo(Int(larghezza * 51 / 100), altezza - Int(altezza * 5 / 100))
        grx.Stroke()
        grx.MoveTo(Int(larghezza * 51 / 100), altezza - 10)
        grx.LineTo(Int(larghezza * 51 / 100), altezza - Int(altezza * 5 / 100))
        grx.Stroke()
        grx.MoveTo(Int(larghezza * 53 / 100), altezza - 10)
        grx.LineTo(Int(larghezza * 53 / 100), altezza - Int(altezza * 10 / 100))
        grx.Stroke()
        'parte in alto a dx (giro e distribuzione)
        grx.MoveTo(Int(larghezza * 87.5 / 100), altezza - 10)
        grx.LineTo(Int(larghezza * 87.5 / 100), altezza - Int(altezza * 5 / 100))
        grx.Stroke()
        grx.MoveTo(Int(larghezza * 87.5 / 100), altezza - Int(altezza * 5 / 100))
        grx.LineTo(Int(larghezza - 10), altezza - Int(altezza * 5 / 100))
        grx.Stroke()
        grx.MoveTo(Int(larghezza * 93 / 100), altezza - 10)
        grx.LineTo(Int(larghezza * 93 / 100), altezza - Int(altezza * 5 / 100))
        grx.Stroke()
        grx.MoveTo(Int(larghezza * 80 / 100), altezza - Int(altezza * 8 / 100))
        grx.LineTo(Int(larghezza - 10), altezza - Int(altezza * 8 / 100))
        grx.Stroke()
        'ulteriore linea prima e dopo la tabella
        grx.MoveTo(10, altezza - Int(altezza * 10 / 100))
        grx.LineTo(Int(larghezza - 10), altezza - Int(altezza * 10 / 100))
        grx.Stroke()
        grx.MoveTo(10, altezza - Int(altezza * 88 / 100))
        grx.LineTo(Int(larghezza - 10), altezza - Int(altezza * 88 / 100))
        grx.Stroke()
        'parte in basso a dx (totali)
        grx.MoveTo(10, altezza - Int(altezza * 92 / 100))
        grx.LineTo(Int(larghezza - 10), altezza - Int(altezza * 92 / 100))
        grx.Stroke()
        'parte in basso a dx (griglia totali)
        grx.MoveTo(Int(larghezza * 56.5 / 100), altezza - Int(altezza * 92 / 100))
        grx.LineTo(Int(larghezza * 56.5 / 100), altezza - Int(altezza * 88 / 100))
        grx.Stroke() 'prima verticale
        grx.MoveTo(Int(larghezza * 67 / 100), altezza - Int(altezza * 92 / 100))
        grx.LineTo(Int(larghezza * 67 / 100), altezza - Int(altezza * 88 / 100))
        grx.Stroke() 'seconda verticale
        grx.MoveTo(Int(larghezza * 56.5 / 100), altezza - Int(altezza * 90 / 100))
        grx.LineTo(Int(larghezza - 10), altezza - Int(altezza * 90 / 100))
        grx.Stroke() 'orizzontale
        'parte in basso ultima riga (sistema operativo)
        grx.MoveTo(Int(larghezza * 70 / 100), altezza - Int(altezza * 96.8 / 100))
        grx.LineTo(Int(larghezza * 70 / 100), 10)
        grx.Stroke()
        grx.MoveTo(10, altezza - Int(altezza * 96.8 / 100))
        grx.LineTo(Int(larghezza - 10), altezza - Int(altezza * 96.8 / 100))
        grx.Stroke()
        grx.MoveTo(Int(larghezza * 85 / 100), altezza - Int(altezza * 96.8 / 100))
        grx.LineTo(Int(larghezza * 85 / 100), 10)
        grx.Stroke()

        'inizio testo
        Dim bf As iTextSharp.text.pdf.BaseFont = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "winansi", False) '<--Font family 
        grx.BeginText()
        grx.SetFontAndSize(bf, 16)
        grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Servizi Diffusionali srl", Int(larghezza * 9 / 100), altezza - Int(altezza * 4.5 / 100), 0) '13
        grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "GIRO", Int(larghezza * 88 / 100), altezza - Int(altezza * 4.5 / 100), 0) '4
        grx.EndText()
        'grx.BeginText()
        'grx.SetFontAndSize(bf, 10)
        'grx.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Via Galla Placidia, 184", Int(larghezza * 39 / 100), altezza - Int(altezza * 3 / 100), 0)
        'grx.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "00159 Roma", Int(larghezza * 39 / 100), altezza - Int(altezza * 4.5 / 100), 0)
        'grx.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Tel. 06.4381754", Int(larghezza * 39 / 100), altezza - Int(altezza * 6 / 100), 0)
        'grx.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Fax. 06.43535175", Int(larghezza * 39 / 100), altezza - Int(altezza * 7.5 / 100), 0)
        'grx.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "E-mail: info@promonew.it", Int(larghezza * 39 / 100), altezza - Int(altezza * 9 / 100), 0)
        'grx.EndText()
        grx.BeginText()
        grx.SetFontAndSize(bf, 10) 'luca 13/8/2019 invece di 10 era 12
        grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "DIFFUSIONE DISTRIBUZIONE PROMOZIONE STAMPA", Int(larghezza * 2 / 100), altezza - Int(altezza * 8 / 100), 0)
        grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "DISTRIBUZIONE DEL", Int(larghezza * 67 / 100), altezza - Int(altezza * 8 / 100), 0)
        grx.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "CARICO:", Int(larghezza * 50 / 100), altezza - Int(altezza * 93.5 / 100), 0)
        grx.EndText()
        grx.BeginText()
        grx.SetFontAndSize(bf, 8) 'luca 13/8/2019 invece di 8 era 10
        grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "TIPOLOGIA", Int(larghezza * 45.3 / 100), altezza - Int(altezza * 3.4 / 100), 0)
        grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "SERVIZIO", Int(larghezza * 45.3 / 100), altezza - Int(altezza * 4.6 / 100), 0)
        grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "CONSEGNA", Int(larghezza * 45.3 / 100), altezza - Int(altezza * 7.5 / 100), 0)
        grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "ALLESTIMENTO", Int(larghezza * 45.3 / 100), altezza - Int(altezza * 9 / 100), 0)
        grx.EndText()

        grx.BeginText()
        grx.SetFontAndSize(bf, 5)
        grx.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "SISTEMA OPERATIVO", Int(larghezza * 77 / 100), altezza - Int(altezza * 97.8 / 100), 0)
        grx.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "A.S.D.", Int(larghezza * 92 / 100), altezza - Int(altezza * 97.8 / 100), 0)
        grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Diritti riservati (c) 2007-" & Today.Year.ToString & " - Northia Multimedia Solution", Int(larghezza * 3 / 100), altezza - Int(altezza * 97.8 / 100), 0)
        grx.EndText()
        grx.BeginText()
        grx.SetFontAndSize(bf, 8) 'luca 13/8/2019 invece di 8 era 10
        grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "TOTALE COPIE", Int(larghezza * 57 / 100), altezza - Int(altezza * 89.6 / 100), 0)
        grx.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "TOTALE CONSEGNE", Int(larghezza * 57 / 100), altezza - Int(altezza * 91.6 / 100), 0)
        grx.EndText()


        'cb.SetLineWidth(0.5)
        'Dim r As New Random()
        'For line As Integer = 0 To heights.Length - 2
        '    widths = width(line)
        '    For col As Integer = 0 To widths.Length - 2
        '        If line = 0 AndAlso col = 0 Then
        '            cb.SetAction(New PdfAction("http://www.geocities.com/itextpdf"), widths(col), heights(line + 1), widths(col + 1), heights(line))
        '        End If
        '        cb.SetRGBColorStrokeF(CSng(r.NextDouble()), CSng(r.NextDouble()), CSng(r.NextDouble()))
        '        cb.MoveTo(widths(col), heights(line))
        'cb.MoveTo(100, 100)
        'cb.LineTo(400, 400)
        'cb.Stroke()
        '        cb.LineTo(widths(col + 1), heights(line))
        '        cb.Stroke()
        '        cb.SetRGBColorStrokeF(CSng(r.NextDouble()), CSng(r.NextDouble()), CSng(r.NextDouble()))
        '        cb.MoveTo(widths(col), heights(line))
        '        cb.LineTo(widths(col), heights(line + 1))
        '        cb.Stroke()
        '    Next
        'Next
        grx.RestoreState()
    End Sub
End Class

Public Class Utils
    Public Shared Sub ConcatPdfFile(ByVal pdfs As ArrayList, ByVal filename As String)
        Dim document As New Document()
        Dim writer As PdfWriter = PdfWriter.GetInstance(document, New FileStream(filename, FileMode.Create))
        document.Open()
        Dim cb As PdfContentByte = writer.DirectContent

        Dim numPdf As Integer = pdfs.Count
        For i As Integer = 0 To numPdf - 1
            Dim reader As New PdfReader(DirectCast(pdfs(i), String))
            Dim pages As Integer = reader.NumberOfPages
            For j As Integer = 0 To pages - 1
                document.SetPageSize(reader.GetPageSizeWithRotation(j + 1))
                Dim rotazione As Integer = reader.GetPageRotation(j + 1)
                'If i > 1 Then
                '    document.SetPageSize(New Rectangle(reader.GetPageSizeWithRotation(j + 1).Height(), reader.GetPageSizeWithRotation(j + 1).Width()))
                'Else
                '    document.SetPageSize(New Rectangle(reader.GetPageSizeWithRotation(j + 1).Width(), reader.GetPageSizeWithRotation(j + 1).Height()))
                'End If
                'document.SetPageSize(New Rectangle(reader.GetPageSize(j + 1).Width(), reader.GetPageSize(j + 1).Height()))
                document.NewPage()
                If (rotazione = 90) Or (rotazione = 270) Then
                    cb.AddTemplate(writer.GetImportedPage(reader, j + 1), 0, -1.0F, 1.0F, 0, 0, reader.GetPageSize(j + 1).Width)
                Else
                    cb.AddTemplate(writer.GetImportedPage(reader, j + 1), 0, 0)
                End If
            Next
        Next
        document.Close()

    End Sub
End Class
