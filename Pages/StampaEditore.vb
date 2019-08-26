﻿Public Class StampaEditore


    Private Sub StampaEditore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.PI'. È possibile spostarla o rimuoverla se necessario.
        Me.TestateTableAdapter.Fill(Me.ASDDBDataSet.Testate)
    End Sub


    Private Sub UltraButtonCarica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonCarica.Click
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.QTabella_Distribuzioni'. È possibile spostarla o rimuoverla se necessario.
        Me.QControlloriTableAdapter.FillByTestataData(Me.ASDDBDataSet.QControllori, UltraDateTimeEditor1.Value, UltraComboTestata.Value.ToString)
        Dim dvpi As DataView = New DataView
        dvpi.Table = Me.QControlloriTableAdapter.GetDataByTestataData(UltraDateTimeEditor1.Value, UltraComboTestata.Value.ToString)
        UltraGridPI.DataSource = dvpi.Table
        UltraGridPI.Refresh()
        UltraButtonExcel.Enabled = True
        UltraButtonPDF.Enabled = True
        UltraButtonCrea.Enabled = True
    End Sub

    Private Sub UltraButtonCrea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonCrea.Click
        UltraGridPrintDocument1.DefaultPageSettings.Landscape = True
        UltraGridPrintDocument1.DefaultPageSettings.Margins.Bottom = 10
        UltraGridPrintDocument1.DefaultPageSettings.Margins.Left = 10
        UltraGridPrintDocument1.DefaultPageSettings.Margins.Right = 10
        UltraGridPrintDocument1.DefaultPageSettings.Margins.Top = 10
        UltraPrintPreviewDialog1.Document = UltraGridPrintDocument1
        UltraPrintPreviewDialog1.Document.DocumentName = "StampaEditore" & UltraComboTestata.Text & UltraDateTimeEditor1.Value
        UltraGridPrintDocument1.Header.Appearance.FontData.SizeInPoints = 16
        UltraGridPrintDocument1.Footer.Appearance.FontData.SizeInPoints = 12
        UltraGridPrintDocument1.Header.TextLeft = "Stampa Editore della testata " & UltraComboTestata.Text & " del " & UltraDateTimeEditor1.Value
        UltraPrintPreviewDialog1.ShowDialog()
        'UltraGridPrintDocument1.Print()
        Form1.UltraStatusBar1.Panels(0).Text = "La stampa editore del " & UltraDateTimeEditor1.Value & " relativamente alla testata " & UltraComboTestata.Text & " è stata stampata con successo."
        Form1.UltraStatusBar1.Refresh()
        MsgBox("La stampa editore del " & UltraDateTimeEditor1.Value & " relativamente alla testata " & UltraComboTestata.Text & " è stata stampata con successo.")
    End Sub

    Private Sub UltraButtonExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonExcel.Click
        Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString & "StampaEditore"
        Dim data As Date = UltraDateTimeEditor1.Value
        Dim nomefile As String = "StampaEditore" & UltraComboTestata.Text & "-" & data.Year & "-" & data.Month & "-" & data.Day & ".xls"
        Try
            System.IO.Directory.CreateDirectory(percorso)
        Catch ex As Exception
            'la directory già esiste
        End Try
        UltraGridExcelExporter1.Export(UltraGridPI, percorso & "\" & nomefile)
    End Sub

    Private Sub UltraGridExcelExporter1_RowExporting(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.ExcelExport.RowExportingEventArgs) Handles UltraGridExcelExporter1.RowExporting
        Form1.UltraStatusBar1.Panels(0).Text = "Sto esportando la riga: " & e.GridRow.Index & " di " & (UltraGridPI.Rows.Count - 1)
        Form1.UltraStatusBar1.Refresh()
    End Sub

    Private Sub UltraButtonPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonPDF.Click
        Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString & "StampaEditore"
        Dim data As Date = UltraDateTimeEditor1.Value
        Dim nomefile As String = "StampaEditore" & UltraComboTestata.Text & "-" & data.Year & "-" & data.Month & "-" & data.Day & ".pdf"
        Try
            System.IO.Directory.CreateDirectory(percorso)
        Catch ex As Exception
            'la directory già esiste
        End Try
        UltraGridDocumentExporter1.Export(UltraGridPI, percorso & "\" & nomefile, Infragistics.Win.UltraWinGrid.DocumentExport.GridExportFileFormat.PDF)
    End Sub

    Private Sub UltraGridDocumentExporter1_RowExporting(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DocumentExport.RowExportingEventArgs) Handles UltraGridDocumentExporter1.RowExporting
        Form1.UltraStatusBar1.Panels(0).Text = "Sto esportando la riga: " & e.GridRow.Index & " di " & (UltraGridPI.Rows.Count - 1)
        Form1.UltraStatusBar1.Refresh()
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
