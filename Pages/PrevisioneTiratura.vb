Public Class PrevisioneTiratura
    Dim dt As DataTable = New DataTable("Tiratura")
    Dim totalecopie As Integer = 0
    Dim totaleconsegne As Integer = 0

    Private Sub PrevisioneTiratura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.QTabella_Distribuzioni'. È possibile spostarla o rimuoverla se necessario.
        Me.TestateTableAdapter.Fill(Me.ASDDBDataSet.Testate)
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.PI'. È possibile spostarla o rimuoverla se necessario.
        Me.PITableAdapter.Fill(Me.ASDDBDataSet.PI)
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Tabella_Distribuzioni'. È possibile spostarla o rimuoverla se necessario.
        Me.Tabella_DistribuzioniTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Distribuzioni)
        dt.Columns.Add("Giorno", GetType(System.DateTime))
        dt.Columns.Add("Distribuzione", GetType(System.String))
        dt.Columns.Add("Consegne", GetType(System.Int32))
        dt.Columns.Add("Copie", GetType(System.Int32))
    End Sub

    Private Sub UltraButtonPrevisione_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonPrevisione.Click
        Dim differenzagiorni As TimeSpan = UltraCalendarComboDataFinale.Value - UltraCalendarComboDataIniziale.Value
        Dim usogiorno As DateTime = UltraCalendarComboDataIniziale.CalendarInfo.ActiveDay.Date
        Dim dttestate As New DataTable
        Dim dvtestate As New DataView
        Dim dvdistribuzioni As New DataView
        Dim elencodistribuzioni As New Infragistics.Win.ValueList
        Dim distrononattive As Boolean = False

        If UltraCalendarComboDataFinale.CalendarInfo.ActiveDay.Date < UltraCalendarComboDataIniziale.CalendarInfo.ActiveDay.Date Then
            MsgBox("La data finale deve essere maggiore o uguale alla data iniziale!", MsgBoxStyle.Critical)
        Else
            dt.Clear()
            MsgBox(differenzagiorni.Days)
            For i As Integer = 0 To differenzagiorni.Days
                dt.Rows.Add()
                dt.AcceptChanges()
                dt.Rows(dt.Rows.Count - 1).Item(0) = usogiorno.AddDays(i).Date
                dt.Rows(dt.Rows.Count - 1).Item(1) = "00-Standard"
                dt.Rows(dt.Rows.Count - 1).Item(2) = 0
                dt.Rows(dt.Rows.Count - 1).Item(3) = 0
            Next
        End If
        UltraGrid1.DataSource = dt
        dttestate.Clear()
        dvdistribuzioni.Table = Me.ASDDBDataSet.Tabella_Distribuzioni
        dvdistribuzioni.Sort = "Testata"
        dvtestate.Table = Me.ASDDBDataSet.Testate
        dvdistribuzioni.RowFilter = "Testata = '" & UltraComboTestata.Value & "'"
        For k As Integer = 0 To dvdistribuzioni.Count - 1
            If dvdistribuzioni.Item(k).Item(2) Then 'verifica se la distro è attiva
                elencodistribuzioni.ValueListItems.Add(dvdistribuzioni.Item(k).Item(1))
            Else
                distrononattive = True
            End If
        Next
        For i As Integer = 0 To differenzagiorni.Days
            UltraGrid1.Rows(i).Cells("Distribuzione").ValueList = elencodistribuzioni
        Next
        UltraGrid1.Refresh()
        UltraButtonCalcola.Enabled = True
        If distrononattive Then
            MsgBox("Attenzione, sono presenti distribuzioni non attive. Non appariranno come scelte possibili.", MsgBoxStyle.Critical)
            distrononattive = False
        End If
    End Sub

    Private Sub UltraComboTestata_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraComboTestata.TextChanged
        UltraButtonPrevisione.Enabled = True
    End Sub

    Private Sub UltraButtonCalcola_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonCalcola.Click
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Esclusioni'. È possibile spostarla o rimuoverla se necessario.
        Me.EsclusioniTableAdapter.FillByTestata(Me.ASDDBDataSet.Esclusioni, UltraComboTestata.Text)
        Dim dvappoggio As DataView = New DataView(Me.EsclusioniTableAdapter.GetDataByTestata(UltraComboTestata.Value))
        Me.PITableAdapter.Fill(Me.ASDDBDataSet.PI)
        Dim dvpi As DataView = New DataView(Me.PITableAdapter.GetData)
        Dim giorno As Integer
        Dim usogiorno As DateTime = UltraCalendarComboDataIniziale.CalendarInfo.ActiveDay.Date
        Dim copieappoggio As Integer = 0
        Dim consegneappoggio As Integer = 0
        Dim usocancellazione As New ArrayList(10000)
        Dim usotrovato As Integer = -1
        Dim chiuso As Boolean = False

        totalecopie = 0
        totaleconsegne = 0
        If UltraComboTestata.SelectedRow.Cells("Attiva").Value Then
            dvpi.Sort = "PI"
            For i As Integer = 0 To UltraGrid1.Rows.Count - 1
                usogiorno = UltraGrid1.Rows(i).Cells(0).Text
                giorno = usogiorno.DayOfWeek
                If giorno = 0 Then
                    giorno = 7
                End If
                Form1.UltraStatusBar1.Panels(0).Text = "Calcolando la distribuzione del " & UltraGrid1.Rows(i).Cells(0).Text
                Try
                    Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(i / (UltraGrid1.Rows.Count - 1) * 100)
                Catch ex As Exception
                    Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = 0
                End Try

                Form1.UltraStatusBar1.Panels(2).Text = "Analisi dei PI della distribuzione in corso."
                Form1.UltraStatusBar1.Refresh()
                If UltraComboTestata.SelectedRow.Cells(giorno + 1).Value Then
                    Dim dvdistro As DataView = New DataView()

                    'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Distribuzione'. È possibile spostarla o rimuoverla se necessario.
                    Me.DistribuzioneTableAdapter.FillByDistro(Me.ASDDBDataSet.Distribuzione, UltraComboTestata.Value, UltraGrid1.Rows(i).Cells(1).Text)
                    dvdistro.Table = Me.DistribuzioneTableAdapter.GetDataByDistro(UltraComboTestata.Value, UltraGrid1.Rows(i).Cells(1).Text)
                    dvdistro.Sort = "PI"
                    For k As Integer = 0 To dvdistro.Count - 1
                        usotrovato = dvpi.Find(dvdistro.Item(k).Item(2))
                        chiuso = dvpi.Item(usotrovato).Item(20 + giorno)
                        If Not chiuso Then
                            copieappoggio = copieappoggio + dvdistro.Item(k).Item("Copie")
                            consegneappoggio = consegneappoggio + 1
                        Else
                            usocancellazione.Add(k)
                        End If
                    Next
                    For k As Integer = usocancellazione.Count - 1 To 0 Step -1
                        dvdistro.Delete(usocancellazione(k))
                    Next
                    usotrovato = False
                    usocancellazione.Clear()

                    'verifica delle esclusioni
                    Form1.UltraStatusBar1.Panels(2).Text = "Analisi delle esclusioni in corso."
                    Form1.UltraStatusBar1.Refresh()
                    For k As Integer = 0 To dvappoggio.Count - 1
                        usotrovato = dvdistro.Find(dvappoggio.Item(k).Item(0))
                        If usotrovato >= 0 Then
                            usocancellazione.Add(usotrovato)
                            copieappoggio = copieappoggio - dvdistro.Item(usotrovato).Item("Copie")
                            consegneappoggio = consegneappoggio - 1
                        End If
                    Next
                    For k As Integer = usocancellazione.Count - 1 To 0 Step -1
                        dvdistro.Delete(usocancellazione(k))
                    Next
                    Form1.UltraStatusBar1.Panels(2).Text = "Analisi dei PI chiusi."
                    Form1.UltraStatusBar1.Refresh()

                    'verifica dei pi chiusi
                    Dim dvchiusure As DataView = New DataView()

                    usocancellazione.Clear()
                    Me.ChiusureTableAdapter.FillByGiorno(Me.ASDDBDataSet.Chiusure, UltraGrid1.Rows(i).Cells(0).Text)
                    dvchiusure.Table = Me.ChiusureTableAdapter.GetDataByGiorno(UltraGrid1.Rows(i).Cells(0).Text)
                    dvchiusure.Sort = "PI"
                    For k As Integer = 0 To dvchiusure.Count - 1
                        usotrovato = dvdistro.Find(dvchiusure.Item(k).Item(0))
                        If usotrovato >= 0 Then
                            usocancellazione.Add(usotrovato)
                            copieappoggio = copieappoggio - dvdistro.Item(usotrovato).Item("Copie")
                            consegneappoggio = consegneappoggio - 1
                        End If
                    Next
                    For k As Integer = usocancellazione.Count - 1 To 0 Step -1
                        dvdistro.Delete(usocancellazione(k))
                    Next

                    totalecopie = totalecopie + copieappoggio
                    totaleconsegne = totaleconsegne + consegneappoggio
                    UltraGrid1.Rows(i).Cells(2).Value = consegneappoggio
                    UltraGrid1.Rows(i).Cells(3).Value = copieappoggio
                    copieappoggio = 0
                    consegneappoggio = 0
                End If
            Next
            MsgBox("Previsione sulla turatura terminata con successo.")
            Form1.UltraStatusBar1.Panels(0).Text = ""
            Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = 0
            Form1.UltraStatusBar1.Panels(2).Text = ""
            Form1.UltraStatusBar1.Refresh()
            UltraLabelRisultato.Text = "Copie= " & totalecopie & " Consegne= " & totaleconsegne
        Else
            MsgBox("La testata non è attiva.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub UltraButtonPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonPDF.Click
        Form1.UltraStatusBar1.Panels(1).Visible = True
        Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString & "PrevisioneTiratura"
        Dim data As Date = UltraCalendarComboDataIniziale.Value
        Dim data2 As Date = UltraCalendarComboDataFinale.Value
        Dim nomefile As String = "PrevisioneTiratura" & UltraComboTestata.Text & "-dal-" & data.Year & "-" & data.Month & "-" & data.Day & "-al-" & data2.Year & "-" & data2.Month & "-" & data2.Day & ".pdf"
        Try
            System.IO.Directory.CreateDirectory(percorso)
        Catch ex As Exception
            'la directory già esiste
        End Try
        UltraGridDocumentExporter1.Export(UltraGrid1, percorso & "\" & nomefile, Infragistics.Win.UltraWinGrid.DocumentExport.GridExportFileFormat.PDF)
    End Sub

    Private Sub UltraGridExcelExporter1_RowExporting(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.ExcelExport.RowExportingEventArgs) Handles UltraGridExcelExporter1.RowExporting
        Form1.UltraStatusBar1.Panels(0).Text = "Sto esportando la riga: " & e.GridRow.Index & " di " & UltraGrid1.Rows.Count
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int((e.CurrentRowIndex - 1) / (UltraGrid1.Rows.Count - 1) * 100)
    End Sub

    Private Sub UltraButtonExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonExcel.Click
        Form1.UltraStatusBar1.Panels(1).Visible = True
        Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString & "PrevisioneTiratura"
        Dim data As Date = UltraCalendarComboDataIniziale.Value
        Dim data2 As Date = UltraCalendarComboDataFinale.Value
        Dim nomefile As String = "PrevisioneTiratura" & UltraComboTestata.Text & "-dal-" & data.Year & "-" & data.Month & "-" & data.Day & "-al-" & data2.Year & "-" & data2.Month & "-" & data2.Day & ".xls"
        Try
            System.IO.Directory.CreateDirectory(percorso)
        Catch ex As Exception
            'la directory già esiste
        End Try
        UltraGridExcelExporter1.Export(UltraGrid1, percorso & "\" & nomefile)
    End Sub

    Private Sub UltraGridDocumentExporter1_RowExporting(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DocumentExport.RowExportingEventArgs) Handles UltraGridDocumentExporter1.RowExporting
        Form1.UltraStatusBar1.Panels(0).Text = "Sto esportando la riga: " & e.GridRow.Index & " di " & UltraGrid1.Rows.Count
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(e.GridRow.Index / (UltraGrid1.Rows.Count - 1) * 100)
    End Sub

    Private Sub UltraGridExcelExporter1_ExportEnded(sender As System.Object, e As Infragistics.Win.UltraWinGrid.ExcelExport.ExportEndedEventArgs) Handles UltraGridExcelExporter1.ExportEnded
        Form1.UltraStatusBar1.Panels(0).Text = "Esportazione completata con successo."
        Form1.UltraStatusBar1.Panels(1).Visible = False
        Form1.UltraStatusBar1.Refresh()
    End Sub

    Private Sub UltraGridDocumentExporter1_ExportEnded(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DocumentExport.ExportEndedEventArgs) Handles UltraGridDocumentExporter1.ExportEnded
        Form1.UltraStatusBar1.Panels(0).Text = "Esportazione completata con successo."
        Form1.UltraStatusBar1.Panels(1).Visible = False
        Form1.UltraStatusBar1.Refresh()
    End Sub
End Class
