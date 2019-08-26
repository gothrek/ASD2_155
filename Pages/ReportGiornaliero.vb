Public Class ReportGiornaliero
    Dim dtconsegne As DataTable = New DataTable("Consegne", "Consegne")
    Dim dvconsegne As DataView = New DataView

    Private Sub ReportGiornaliero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.UltraStatusBar1.Panels(2).Text = ""
        Form1.UltraStatusBar1.Panels(1).Visible = False
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = 0
        Form1.UltraStatusBar1.Panels(0).Text = "Non è stato caricato ancora nessun giorno."
        Form1.UltraStatusBar1.Refresh()
    End Sub

    Private Sub UltraMonthViewSingleData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraMonthViewSingleData.Click
        UltraButtonCrea.Enabled = False
        UltraButtonExcel.Enabled = False
        UltraButtonPDF.Enabled = False
    End Sub

    Private Sub UltraMonthViewSingleData_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraMonthViewSingleData.DoubleClick

    End Sub

    Private Sub UltraButtonCarica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonCarica.Click
        Dim dvgiri As DataView = New DataView
        Dim testate(100) As String
        Dim itestate As Integer = 0
        Me.QRiepilogoGiornalieroTableAdapter.FillByData(Me.ASDDBDataSet.QRiepilogoGiornaliero, UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date)
        dvconsegne.Table = Me.QRiepilogoGiornalieroTableAdapter.GetDataByData(UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date)
        dvgiri.Table = Me.Tabella_GiroTableAdapter.GetData()
        'aggiunta delle colonne (testate)
        dtconsegne.Columns.Clear()
        dtconsegne.Columns.Add("Giri", System.Type.GetType("System.String"))
        For i As Integer = 0 To dvconsegne.Count - 1
            Try
                'dtconsegne.Columns.Add(Microsoft.VisualBasic.Left(dvconsegne.Item(i).Item(0).ToString, 6) & "cp", System.Type.GetType("System.String"))
                'dtconsegne.Columns.Add(Microsoft.VisualBasic.Left(dvconsegne.Item(i).Item(0).ToString, 6) & "co", System.Type.GetType("System.String"))
                dtconsegne.Columns.Add(dvconsegne.Item(i).Item(0).ToString & "cp", System.Type.GetType("System.String"))
                dtconsegne.Columns.Add(dvconsegne.Item(i).Item(0).ToString & "co", System.Type.GetType("System.String"))
                testate(itestate) = dvconsegne.Item(i).Item(0).ToString
                itestate = itestate + 1
            Catch ex As Exception
                'MsgBox("Errore")
            End Try
        Next
        dtconsegne.Columns.Add("TotCopie", System.Type.GetType("System.String"))
        dtconsegne.Columns.Add("TotConse", System.Type.GetType("System.String"))
        dtconsegne.Columns.Add("Giro", System.Type.GetType("System.String"))
        'aggiunta delle righe (giri)
        For i As Integer = 0 To dvgiri.Count - 1
            dtconsegne.Rows.Add()
            dtconsegne.Rows(i).Item(0) = dvgiri.Item(i).Item(0)
            dtconsegne.Rows(i).Item(dtconsegne.Columns.Count - 1) = dvgiri.Item(i).Item(0)
        Next

        For i As Integer = 0 To dvconsegne.Count - 1
            Dim kk As Integer = -1
            Do
                kk = kk + 1
            Loop Until dvconsegne.Item(i).Item(3) = dtconsegne.Rows(kk).Item(0)
            Dim k As Integer = 0
            Dim esci As Boolean = False
            Do
                If dvconsegne.Item(i).Item(0) = testate(k) Then
                    dtconsegne.Rows(kk).Item(k * 2 + 1) = dvconsegne.Item(i).Item(1)
                    dtconsegne.Rows(kk).Item(k * 2 + 2) = dvconsegne.Item(i).Item(2)
                    esci = True
                Else
                    k = k + 1
                End If
            Loop Until esci Or (k = itestate)
        Next
        'calcolo totali per riga
        Dim usocancellazione As New ArrayList(100)
        For i As Integer = 0 To dtconsegne.Rows.Count - 1
            Dim totalecopie As Integer = 0
            Dim totaleconsegne As Integer = 0
            For k As Integer = 0 To dtconsegne.Columns.Count - 4 Step 2
                If Not IsDBNull(dtconsegne.Rows(i).Item(k + 1)) Then
                    totalecopie = totalecopie + Int(dtconsegne.Rows(i).Item(k + 1))
                    totaleconsegne = totaleconsegne + Int(dtconsegne.Rows(i).Item(k + 2))
                Else
                    dtconsegne.Rows(i).Item(k + 1) = "0"
                    dtconsegne.Rows(i).Item(k + 2) = "0"
                End If
            Next
            If (totaleconsegne = 0) And (totalecopie = 0) Then
                usocancellazione.Add(i)
            Else
                dtconsegne.Rows(i).Item(dtconsegne.Columns.Count - 3) = totalecopie
                dtconsegne.Rows(i).Item(dtconsegne.Columns.Count - 2) = totaleconsegne
            End If
        Next
        'cancellazione dei giri a 0 copie e 0 consegne
        For i As Integer = usocancellazione.Count - 1 To 0 Step -1
            dtconsegne.Rows(usocancellazione(i)).Delete()
        Next
        'calcolo totali per colonna
        dtconsegne.Rows.Add()
        dtconsegne.Rows.Add()
        dtconsegne.Rows(dtconsegne.Rows.Count - 1).Item(0) = "Totali"
        dtconsegne.Rows(dtconsegne.Rows.Count - 1).Item(dtconsegne.Columns.Count - 1) = "Totali"
        For i As Integer = 1 To dtconsegne.Columns.Count - 2
            Dim totalecolonna As Integer = 0
            For k As Integer = 0 To dtconsegne.Rows.Count - 3
                totalecolonna = totalecolonna + Int(dtconsegne.Rows(k).Item(i))
            Next
            dtconsegne.Rows(dtconsegne.Rows.Count - 1).Item(i) = totalecolonna
        Next
        dtconsegne.Rows.Add()
        dtconsegne.Rows(dtconsegne.Rows.Count - 1).Item(0) = "Report del"
        dtconsegne.Rows.Add()
        dtconsegne.Rows(dtconsegne.Rows.Count - 1).Item(0) = UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Day & "/" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Month & "/" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Year
        DataGridViewReportGiornaliero.DataSource = dtconsegne
        DataGridViewReportGiornaliero.Refresh()
        UltraGridReportGiornaliero.DataSource = dtconsegne
        UltraGridReportGiornaliero.Refresh()
        UltraGridReportGiornaliero.DisplayLayout.Bands(0).Columns(0).Width = 60
        UltraGridReportGiornaliero.DisplayLayout.Bands(0).Columns(UltraGridReportGiornaliero.DisplayLayout.Bands(0).Columns.Count - 1).Width = 40
        For i As Integer = 1 To UltraGridReportGiornaliero.DisplayLayout.Bands(0).Columns.Count - 2
            UltraGridReportGiornaliero.DisplayLayout.Bands(0).Columns(i).Width = 70
        Next
        Form1.UltraStatusBar1.Panels(0).Text = "E' stato caricato il giorno " & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date
        Form1.UltraStatusBar1.Refresh()
        UltraButtonCrea.Enabled = True
        UltraButtonExcel.Enabled = True
        UltraButtonPDF.Enabled = True
    End Sub

    Private Sub UltraButtonCrea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonCrea.Click
        UltraGridReportGiornaliero.Rows(UltraGridReportGiornaliero.Rows.Count - 1).Delete(False)
        UltraGridReportGiornaliero.Rows(UltraGridReportGiornaliero.Rows.Count - 1).Delete(False)
        UltraGridReportGiornaliero.Refresh()
        UltraGridPrintDocument1.DefaultPageSettings.Landscape = True
        UltraGridPrintDocument1.DefaultPageSettings.Margins.Bottom = 10
        UltraGridPrintDocument1.DefaultPageSettings.Margins.Left = 10
        UltraGridPrintDocument1.DefaultPageSettings.Margins.Right = 10
        UltraGridPrintDocument1.DefaultPageSettings.Margins.Top = 10
        UltraPrintPreviewDialog1.Document = UltraGridPrintDocument1
        UltraPrintPreviewDialog1.Document.DocumentName = "ReportGiornaliero" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Day & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Month & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Year
        UltraGridPrintDocument1.Header.Appearance.FontData.SizeInPoints = 16
        UltraGridPrintDocument1.Footer.Appearance.FontData.SizeInPoints = 12
        UltraGridPrintDocument1.Header.TextLeft = "Report Giornaliero del " & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date
        UltraGridPrintDocument1.PrinterSettings.Copies = UltraNumericEditor1.Value
        UltraPrintPreviewDialog1.ShowDialog()
        'UltraGridPrintDocument1.Print()
        Form1.UltraStatusBar1.Panels(0).Text = "Il report del " & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date & " è stato creato con successo."
        Form1.UltraStatusBar1.Refresh()
        dtconsegne.Rows.Add()
        dtconsegne.Rows(dtconsegne.Rows.Count - 1).Item(0) = "Report del"
        dtconsegne.Rows.Add()
        dtconsegne.Rows(dtconsegne.Rows.Count - 1).Item(0) = UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Day & "/" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Month & "/" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Year
        UltraGridReportGiornaliero.DataSource = dtconsegne
        UltraGridReportGiornaliero.Refresh()
        MsgBox("Il report del " & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date & " è stato creato con successo.")
    End Sub

    Private Sub UltraButtonExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonExcel.Click
        Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString & "ReportGiornaliero"
        Dim data As Date = UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date
        Dim nomefile As String = "ReportGiornaliero" & "-" & data.Year & "-" & data.Month & "-" & data.Day & ".xls"
        Try
            System.IO.Directory.CreateDirectory(percorso)
        Catch ex As Exception
            'la directory già esiste
        End Try
        UltraGridExcelExporter1.Export(UltraGridReportGiornaliero, percorso & "\" & nomefile)
    End Sub

    Private Sub UltraGridExcelExporter1_RowExporting(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.ExcelExport.RowExportingEventArgs) Handles UltraGridExcelExporter1.RowExporting
        Form1.UltraStatusBar1.Panels(0).Text = "Sto esportando la riga: " & e.GridRow.Index & " di " & (UltraGridReportGiornaliero.Rows.Count - 1)
        Form1.UltraStatusBar1.Refresh()
    End Sub

    Private Sub UltraButtonPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonPDF.Click
        Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString & "ReportGiornaliero"
        Dim data As Date = UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date
        Dim nomefile As String = "ReportGiornaliero" & "-" & data.Year & "-" & data.Month & "-" & data.Day & ".pdf"
        Try
            System.IO.Directory.CreateDirectory(percorso)
        Catch ex As Exception
            'la directory già esiste
        End Try
        UltraGridDocumentExporter1.Export(UltraGridReportGiornaliero, percorso & "\" & nomefile, Infragistics.Win.UltraWinGrid.DocumentExport.GridExportFileFormat.PDF)
    End Sub

    Private Sub UltraGridDocumentExporter1_RowExporting(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DocumentExport.RowExportingEventArgs) Handles UltraGridDocumentExporter1.RowExporting
        Form1.UltraStatusBar1.Panels(0).Text = "Sto esportando la riga: " & e.GridRow.Index & " di " & (UltraGridReportGiornaliero.Rows.Count - 1)
        Form1.UltraStatusBar1.Refresh()
    End Sub

    Private Sub UltraGridDocumentExporter1_ExportEnded(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DocumentExport.ExportEndedEventArgs) Handles UltraGridDocumentExporter1.ExportEnded
        Form1.UltraStatusBar1.Panels(0).Text = "File esportato con successo."
        Form1.UltraStatusBar1.Refresh()
    End Sub

    Private Sub UltraGridExcelExporter1_ExportEnded(sender As System.Object, e As Infragistics.Win.UltraWinGrid.ExcelExport.ExportEndedEventArgs) Handles UltraGridExcelExporter1.ExportEnded
        Form1.UltraStatusBar1.Panels(0).Text = "File esportato con successo."
        Form1.UltraStatusBar1.Refresh()
    End Sub
End Class
