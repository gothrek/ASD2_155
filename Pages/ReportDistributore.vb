Public Class ReportDistributore
    Dim dvdistributore As New DataView
    Dim dvdistributoresemplice As New DataView
    Dim dvgiro As New DataView
    Dim dvtestate As New DataView
    Dim usospezzatura As String = ""

    Private Sub ReportDistributore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tabella_GiroTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Giro)
        Me.ImpostazioniTableAdapter.Fill(Me.ASDDBDataSet.Impostazioni)
        dvgiro.Table = Me.Tabella_GiroTableAdapter.GetData()
        dvgiro.Sort = "Giro"
        Me.TestateTableAdapter.Fill(Me.ASDDBDataSet.Testate)
        dvtestate.Table = Me.TestateTableAdapter.GetData()
        dvtestate.Sort = "Nome"
        Dim dtusotestate As New DataTable("usotestate", "usotestate")
        dtusotestate.Columns.Add("Selezione", System.Type.GetType("System.Boolean"))
        dtusotestate.Columns.Add("Testata", System.Type.GetType("System.String"))
        dtusotestate.Columns.Add("Codice", System.Type.GetType("System.String"))
        For i As Integer = 0 To dvtestate.Count - 1
            dtusotestate.Rows.Add()
            dtusotestate.Rows(i).Item(0) = False
            dtusotestate.Rows(i).Item(1) = dvtestate.Item(i).Item("Nome")
            dtusotestate.Rows(i).Item(2) = dvtestate.Item(i).Item("Codice")
        Next
        Try
            Dim impostazioni As String = Me.ASDDBDataSet.Impostazioni.Rows(0).Item("Impostazioni1").ToString
            Dim contatore As Integer = 0
            Dim trovato As Boolean = False

            For i As Integer = 1 To (impostazioni.Length / 2)
                Do
                    If Microsoft.VisualBasic.Mid(impostazioni, i * 2 - 1, 2) = dtusotestate.Rows(contatore).Item(2) Then
                        dtusotestate.Rows(contatore).Item(0) = True
                        trovato = True
                    Else
                        contatore = contatore + 1
                    End If
                Loop Until trovato Or (contatore = dvtestate.Count)
                trovato = False
                contatore = 0
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        UltraGridTestate.DataSource = dtusotestate
        UltraGridTestate.Refresh()
    End Sub

    Private Sub UltraButtonCarica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonCarica.Click
        Me.QDistributoreTableAdapter.FillByGiorno(Me.ASDDBDataSet.QDistributore, UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date())
        Me.QDistributoreSempliceTableAdapter.FillByGiorno(Me.ASDDBDataSet.QDistributoreSemplice, UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date())
        dvdistributore.Table = Me.QDistributoreTableAdapter.GetDataByGiorno(UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date())
        dvdistributoresemplice.Table = Me.QDistributoreSempliceTableAdapter.GetDataByGiorno(UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date())
        For i As Integer = 0 To UltraGrid1.Rows.Count - 1
            usospezzatura = Int(UltraGrid1.Rows(i).Cells("SommaDiCopie").Value / UltraGrid1.Rows(i).Cells("Pacchi").Value) & " + " & UltraGrid1.Rows(i).Cells("SommaDiCopie").Value Mod UltraGrid1.Rows(i).Cells("Pacchi").Value
            UltraGrid1.Rows(i).Cells("TotPacchi").Value = Int(UltraGrid1.Rows(i).Cells("SommaDiCopie").Value / UltraGrid1.Rows(i).Cells("Pacchi").Value)
            UltraGrid1.Rows(i).Cells("Spezzatura").Value = usospezzatura
        Next
        UltraGrid1.Refresh()
        UltraButton1.Enabled = True
        UltraButtonExcel.Enabled = True
        UltraButtonPDF.Enabled = True
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim righe As Integer = 0
        Dim copie As Integer = 0
        Dim pacchi As Integer = 0
        Dim spezzatura As Integer = 0
        Dim piedipagina As String = ""
        'UltraGridPrintDocument1.DefaultPageSettings.Landscape = False
        'UltraGridPrintDocument1.DefaultPageSettings.PaperSize = UltraGridPrintDocument1.PrinterSettings.PaperSizes.Item(System.Drawing.Printing.PaperKind.A4)
        dvdistributore.Sort = "Giro"
        'For i As Integer = 0 To dvgiro.Count - 1
        UltraPrintPreviewDialog1.ShowDialog()
        For i As Integer = 0 To dvtestate.Count - 1
            If Not UltraGridTestate.Rows(i).Cells(0).Value Then 'verifica stampa semplice
                'MsgBox("La testata " & UltraGridTestate.Rows(i).Cells(1).Value & " non vuole i dettagli.")
                dvdistributoresemplice.RowFilter = "Nome = '" & dvtestate.Item(i).Item(0) & "'"
                dvdistributoresemplice.Sort = "GIRO ASC"
                righe = dvdistributoresemplice.Count
                If (righe > 0) Then
                    UltraGrid1.DataSource = dvdistributoresemplice
                    UltraGrid1.Refresh()
                    For k As Integer = 0 To UltraGrid1.Rows.Count - 1
                        usospezzatura = Int(UltraGrid1.Rows(k).Cells("SommaDiCopie").Value / UltraGrid1.Rows(k).Cells("Pacchi").Value) & " + " & UltraGrid1.Rows(k).Cells("SommaDiCopie").Value Mod UltraGrid1.Rows(k).Cells("Pacchi").Value
                        UltraGrid1.Rows(k).Cells("TotPacchi").Value = Int(UltraGrid1.Rows(k).Cells("SommaDiCopie").Value / UltraGrid1.Rows(k).Cells("Pacchi").Value)
                        UltraGrid1.Rows(k).Cells("Spezzatura").Value = usospezzatura
                    Next
                    UltraGrid1.Refresh()
                    Dim giro As Integer = 0
                    For k As Integer = 0 To righe - 1
                        Dim esci As Boolean = False
                        Do
                            If UltraGridGiri.Rows(giro).Cells("Giro").Value = UltraGrid1.Rows(k).Cells("Giro").Value Then
                                If UltraGridGiri.Rows(giro).Cells("Selezione").Value Then
                                    UltraGrid1.Rows(k).Appearance.BackColor = Color.DarkGray
                                End If
                                esci = True
                            Else
                                giro = giro + 1
                            End If
                        Loop Until esci Or (giro = UltraGridGiri.Rows.Count)
                        copie = copie + UltraGrid1.Rows(k).Cells("SommaDiCopie").Value
                        spezzatura = spezzatura + UltraGrid1.Rows(k).Cells("SommaDiCopie").Value Mod UltraGrid1.Rows(k).Cells("Pacchi").Value
                        pacchi = pacchi + UltraGrid1.Rows(k).Cells("TotPacchi").Value
                    Next
                    pacchi = pacchi + Int(spezzatura / UltraGrid1.Rows(0).Cells("Pacchi").Value)
                    spezzatura = spezzatura Mod UltraGrid1.Rows(0).Cells("Pacchi").Value
                    piedipagina = "Totale copie = " & copie & " Totale pacchi = " & pacchi & " Totale spezzatura = " & pacchi & " + " & spezzatura
                    UltraGridPrintDocument1.Header.TextCenter = dvtestate.Item(i).Item(0)
                    UltraGridPrintDocument1.Footer.TextCenter = piedipagina
                    'UltraPrintPreviewDialog1.ShowDialog()
                    UltraGridPrintDocument1.Print()

                    'MsgBox("Stampa testata " & dvtestate.Item(i).Item(0) & " righe: " & righe)
                    For k As Integer = 0 To UltraGrid1.Rows.Count - 1
                        UltraGrid1.Rows(k).Appearance.BackColor = Color.White
                    Next
                    pacchi = 0
                    copie = 0
                    spezzatura = 0
                End If
            Else
                'dvdistributore.RowFilter = "Giro = '" & dvgiro.Item(i).Item(0) & "'"
                dvdistributore.RowFilter = "Nome = '" & dvtestate.Item(i).Item(0) & "'"
                dvdistributore.Sort = "GIRO ASC"
                righe = dvdistributore.Count
                If (righe > 0) Then
                    UltraGrid1.DataSource = dvdistributore
                    UltraGrid1.Refresh()
                    For k As Integer = 0 To UltraGrid1.Rows.Count - 1
                        usospezzatura = Int(UltraGrid1.Rows(k).Cells("SommaDiCopie").Value / UltraGrid1.Rows(k).Cells("Pacchi").Value) & " + " & UltraGrid1.Rows(k).Cells("SommaDiCopie").Value Mod UltraGrid1.Rows(k).Cells("Pacchi").Value
                        UltraGrid1.Rows(k).Cells("TotPacchi").Value = Int(UltraGrid1.Rows(k).Cells("SommaDiCopie").Value / UltraGrid1.Rows(k).Cells("Pacchi").Value)
                        UltraGrid1.Rows(k).Cells("Spezzatura").Value = usospezzatura
                    Next
                    UltraGrid1.Refresh()
                    Dim giro As Integer = 0
                    For k As Integer = 0 To righe - 1
                        Dim esci As Boolean = False
                        Do
                            If UltraGridGiri.Rows(giro).Cells("Giro").Value = UltraGrid1.Rows(k).Cells("Giro").Value Then
                                If UltraGridGiri.Rows(giro).Cells("Selezione").Value Then
                                    UltraGrid1.Rows(k).Appearance.BackColor = Color.DarkGray
                                End If
                                esci = True
                            Else
                                giro = giro + 1
                            End If
                        Loop Until esci Or (giro = UltraGridGiri.Rows.Count)
                        copie = copie + UltraGrid1.Rows(k).Cells("SommaDiCopie").Value
                        spezzatura = spezzatura + UltraGrid1.Rows(k).Cells("SommaDiCopie").Value Mod UltraGrid1.Rows(k).Cells("Pacchi").Value
                        pacchi = pacchi + UltraGrid1.Rows(k).Cells("TotPacchi").Value
                    Next
                    pacchi = pacchi + Int(spezzatura / UltraGrid1.Rows(0).Cells("Pacchi").Value)
                    spezzatura = spezzatura Mod UltraGrid1.Rows(0).Cells("Pacchi").Value
                    piedipagina = "Totale copie = " & copie & " Totale pacchi = " & pacchi & " Totale spezzatura = " & pacchi & " + " & spezzatura
                    UltraGridPrintDocument1.Header.TextCenter = dvtestate.Item(i).Item(0)
                    UltraGridPrintDocument1.Footer.TextCenter = piedipagina
                    'UltraPrintPreviewDialog1.ShowDialog()
                    UltraGridPrintDocument1.Print()

                    'MsgBox("Stampa testata " & dvtestate.Item(i).Item(0) & " righe: " & righe)
                    For k As Integer = 0 To UltraGrid1.Rows.Count - 1
                        UltraGrid1.Rows(k).Appearance.BackColor = Color.White
                    Next
                    pacchi = 0
                    copie = 0
                    spezzatura = 0
                End If
            End If
        Next
        dvdistributore.RowFilter = ""
        UltraGrid1.DataSource = dvdistributore
        For i As Integer = 0 To UltraGrid1.Rows.Count - 1
            usospezzatura = Int(UltraGrid1.Rows(i).Cells("SommaDiCopie").Value / UltraGrid1.Rows(i).Cells("Pacchi").Value) & " + " & UltraGrid1.Rows(i).Cells("SommaDiCopie").Value Mod UltraGrid1.Rows(i).Cells("Pacchi").Value
            UltraGrid1.Rows(i).Cells("TotPacchi").Value = Int(UltraGrid1.Rows(i).Cells("SommaDiCopie").Value / UltraGrid1.Rows(i).Cells("Pacchi").Value)
            UltraGrid1.Rows(i).Cells("Spezzatura").Value = usospezzatura
        Next
        UltraGrid1.Refresh()

        'inizio salvataggio impostazioni testate
        Dim impostazionitestate As String = ""

        For i As Integer = 0 To UltraGridTestate.Rows.Count - 1
            If UltraGridTestate.Rows(i).Cells(0).Value Then
                impostazionitestate = impostazionitestate & UltraGridTestate.Rows(i).Cells(2).Value.ToString
            End If
        Next
        Me.ASDDBDataSet.Impostazioni.Rows(0).Item("Impostazioni1") = impostazionitestate
        Me.ASDDBDataSet.Impostazioni.AcceptChanges()
        'Me.ImpostazioniTableAdapter.Update(Me.ASDDBDataSet)
        'Me.Validate()
        'Me.ImpostazioniBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)
        'fine salvataggio impostazioni testate
    End Sub

    Private Sub UltraButtonExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonExcel.Click
        Form1.UltraStatusBar1.Panels(1).Visible = True
        Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Year & "\" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Month & "\" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Day
        'Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString & "Distribuzioni"
        Try
            System.IO.Directory.CreateDirectory(percorso)
        Catch ex As Exception
            'la directory già esiste
        End Try
        Dim nomefile As String = "ReportDistributore" & "-" & Today.Year & "-" & Today.Month & "-" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Day & ".xls"
        UltraGridExcelExporter1.Export(UltraGrid1, percorso & "\" & nomefile)
    End Sub

    Private Sub UltraGridExcelExporter1_RowExporting(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.ExcelExport.RowExportingEventArgs) Handles UltraGridExcelExporter1.RowExporting
        Form1.UltraStatusBar1.Panels(0).Text = "Sto esportando la riga: " & e.GridRow.Index & " di " & UltraGrid1.Rows.Count
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(e.CurrentRowIndex / (UltraGrid1.Rows.Count - 1) * 100)
    End Sub

    Private Sub UltraButtonPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonPDF.Click
        Dim nomefile As String = "ReportDistributore" & "-" & Today.Year & "-" & Today.Month & "-" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Day & ".pdf"
        Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Year & "\" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Month & "\" & UltraMonthViewSingleData.CalendarInfo.ActiveDay.Date.Day
        'Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString & "Distribuzioni"
        Try
            System.IO.Directory.CreateDirectory(percorso)
        Catch ex As Exception
            'la directory già esiste
        End Try
        If MsgBox("ATTENZIONE!! Il processo potrebbe durare un paio di minuti, si è sicuri di voler procedere?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Form1.UltraStatusBar1.Panels(1).Visible = True
            UltraGridDocumentExporter1.Export(UltraGrid1, percorso & "\" & nomefile, Infragistics.Win.UltraWinGrid.DocumentExport.GridExportFileFormat.PDF)
        End If
    End Sub

    Private Sub UltraGridDocumentExporter1_RowExporting(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DocumentExport.RowExportingEventArgs) Handles UltraGridDocumentExporter1.RowExporting
        Form1.UltraStatusBar1.Panels(0).Text = "Sto esportando la riga: " & e.GridRow.Index & " di " & (UltraGrid1.Rows.Count - 1)
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(e.GridRow.Index / (UltraGrid1.Rows.Count - 1) * 100)
        Form1.UltraStatusBar1.Refresh()
    End Sub

    Private Sub UltraGridExcelExporter1_ExportEnded(sender As System.Object, e As Infragistics.Win.UltraWinGrid.ExcelExport.ExportEndedEventArgs) Handles UltraGridExcelExporter1.ExportEnded
        Form1.UltraStatusBar1.Panels(0).Text = "File esportato con successo."
        Form1.UltraStatusBar1.Panels(1).Visible = False
        Form1.UltraStatusBar1.Refresh()
    End Sub

    Private Sub UltraGridDocumentExporter1_ExportEnded(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DocumentExport.ExportEndedEventArgs) Handles UltraGridDocumentExporter1.ExportEnded
        Form1.UltraStatusBar1.Panels(0).Text = "File esportato con successo."
        Form1.UltraStatusBar1.Panels(1).Visible = False
        Form1.UltraStatusBar1.Refresh()
    End Sub
End Class
