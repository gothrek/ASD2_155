Public Class PreFatture
    Dim dtConsegne As DataTable = New DataTable("Consegne")
    Dim dvConsegne As DataView = New DataView(dtConsegne)
    Dim dtExtra As DataTable = New DataTable("Extra")
    Dim dvExtra As DataView = New DataView(dtExtra)
    Dim dtPrefatturaConsegne As DataTable = New DataTable("PreFatturaConsegne")
    Dim dtSigleCorrispetivi As DataTable = New DataTable("SigleCorrispettivi")
    Dim dtPrefatturaExtra As DataTable = New DataTable("PrefatturaExtra")
    Dim cartellaRiepilogo As Infragistics.Documents.Excel.Workbook = New Infragistics.Documents.Excel.Workbook

    Private Sub PreFatture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tabella_TrasportatoriTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Trasportatori)
        Me.Tabella_Pagamenti_ExtraTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Pagamenti_Extra)
        dtSigleCorrispetivi = Me.Tabella_Sigle_CorrispettiviTableAdapter.GetData()

        dtPrefatturaConsegne.Columns.Add("Sigla", Type.GetType("System.String"))
        dtPrefatturaConsegne.Columns.Add("Cons.Originali", Type.GetType("System.Int16"))
        dtPrefatturaConsegne.Columns.Add("Cons.Finali", Type.GetType("System.Int16"))
        dtPrefatturaConsegne.Columns.Add("Costo unitario", Type.GetType("System.Decimal"))
        dtPrefatturaConsegne.Columns.Add("Totale", Type.GetType("System.Decimal"))

        'inizializzazione date di consegna e riconsegna
        Dim usoData As Date = "#08/" & Today.Month & "/" & Today.Year & "#" 'parto dall'8 del mese per cercare il secondo venerdi, nella migliore delle ipotesi è l'8 stesso

        Do While usoData.DayOfWeek <> DayOfWeek.Friday
            usoData = usoData.AddDays(1)
        Loop
        UltraDateTimeEditorDataConsegnato.Value = usoData
        UltraDateTimeEditorDataDaRiconsegnare.Value = usoData.AddDays(3)

        Dim data As Date = UltraDateTimeEditorMeseAnno.Value

        UltraComboTrasportatore.DataSource = Me.ConsegneTotaleTableAdapter.GetDataBySoloNomi(data.Month, data.Year)
    End Sub

    Private Sub UltraDateTimeEditorMeseAnno_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraDateTimeEditorMeseAnno.ValueChanged
        Dim data As Date = UltraDateTimeEditorMeseAnno.Value

        UltraComboTrasportatore.Enabled = True
        UltraButtonSalvaPrefattura.Enabled = False
        UltraGridExtra.Enabled = False
        UltraComboTrasportatore.DataSource = Me.ConsegneTotaleTableAdapter.GetDataBySoloNomi(data.Month, data.Year)
    End Sub

    Private Sub UltraComboTrasportatore_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraComboTrasportatore.ValueChanged
        UltraButtonCarica.Enabled = True
        UltraButtonSalvaPrefattura.Enabled = False
        UltraGridExtra.Enabled = False
    End Sub

    Private Sub UltraButtonCarica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonCarica.Click


        If MsgBox("Il processo impiegherà diversi minuti, continuare ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            caricaTrasportatore()

            UltraGroupBoxExtra.Enabled = True
            UltraButtonSalvaPrefattura.Enabled = True
            UltraButtonCarica.Enabled = False
        End If

    End Sub

    Private Sub caricaTrasportatore()
        Dim data As Date = UltraDateTimeEditorMeseAnno.Value
        Dim riga As DataRow

        dtPrefatturaConsegne.Clear()
        dtExtra.Clear()
        dtExtra = Me.ExtraTotaleTableAdapter.GetDataByData(data.Month, data.Year, UltraComboTrasportatore.Value)
        Try
            UltraLabelGiorniLavorati.Text = "Giorni lavorati: " & Me.ConsegneTotaleTableAdapter.GetDataByContaGiorni(UltraComboTrasportatore.Value, data.Month, data.Year).Rows.Count
        Catch ex As Exception
            UltraLabelGiorniLavorati.Text = "Giorni lavorati: 0"
        End Try

        For i As Integer = 0 To dtSigleCorrispetivi.Rows.Count - 1
            dtPrefatturaConsegne.Rows.Add()
            dtPrefatturaConsegne.Rows(i).Item("Sigla") = dtSigleCorrispetivi.Rows(i).Item("Sigla")
            Try
                riga = Me.ConsegneTotaleTableAdapter.GetDataByData(UltraComboTrasportatore.Value, dtSigleCorrispetivi.Rows(i).Item("Sigla"), Data.Month, Data.Year).Rows(0)
                dtPrefatturaConsegne.Rows(i).Item("Cons.Originali") = riga.Item("Consegne")
                dtPrefatturaConsegne.Rows(i).Item("Cons.Finali") = riga.Item("Consegne")
                dtPrefatturaConsegne.Rows(i).Item("Costo unitario") = riga.Item("Importo")
                dtPrefatturaConsegne.Rows(i).Item("Totale") = riga.Item("Tot")
            Catch ex As Exception
                dtPrefatturaConsegne.Rows(i).Item("Cons.Originali") = 0
                dtPrefatturaConsegne.Rows(i).Item("Cons.Finali") = 0
                dtPrefatturaConsegne.Rows(i).Item("Costo unitario") = 0
                dtPrefatturaConsegne.Rows(i).Item("Totale") = 0
            End Try

            For j As Integer = 0 To dtExtra.Rows.Count - 1
                Try
                    If dtExtra.Rows(j).Item("Sigla corrispettivo") = dtPrefatturaConsegne.Rows(i).Item("Sigla") Then
                        If dtPrefatturaConsegne.Rows(i).Item("Sigla") <> "AD/AC" Then
                            dtPrefatturaConsegne.Rows(i).Item("Cons.Originali") = dtPrefatturaConsegne.Rows(i).Item("Cons.Originali") + dtExtra.Rows(j).Item("Numero")
                            dtPrefatturaConsegne.Rows(i).Item("Cons.Finali") = dtPrefatturaConsegne.Rows(i).Item("Cons.Originali")
                            dtPrefatturaConsegne.Rows(i).Item("Costo unitario") = dtExtra.Rows(j).Item("Importo corrispettivo")
                        End If
                        dtPrefatturaConsegne.Rows(i).Item("Totale") = dtPrefatturaConsegne.Rows(i).Item("Totale") + dtExtra.Rows(j).Item("Totale")
                    End If
                Catch ex As Exception

                End Try
            Next
        Next

        UltraGrid1.DataSource = dtPrefatturaConsegne
        UltraGridExtra.DataSource = dtExtra
    End Sub

    Private Sub UltraGrid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGrid1.InitializeLayout
        UltraGrid1.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGrid1.DisplayLayout.Bands(0).Columns(0).CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        UltraGrid1.DisplayLayout.Bands(0).Columns(1).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGrid1.DisplayLayout.Bands(0).Columns(1).CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        UltraGrid1.DisplayLayout.Bands(0).Columns(2).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGrid1.DisplayLayout.Bands(0).Columns(2).CellActivation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
        UltraGrid1.DisplayLayout.Bands(0).Columns(3).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGrid1.DisplayLayout.Bands(0).Columns(3).CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        UltraGrid1.DisplayLayout.Bands(0).Columns(4).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGrid1.DisplayLayout.Bands(0).Columns(4).CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
    End Sub

    Private Sub UltraGrid1_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGrid1.AfterCellUpdate
        dtPrefatturaConsegne.Rows(e.Cell.Row.Index).Item("Totale") = e.Cell.Value * dtPrefatturaConsegne.Rows(e.Cell.Row.Index).Item("Costo unitario")
        If e.Cell.Value <> dtPrefatturaConsegne.Rows(e.Cell.Row.Index).Item("Cons.Originali") Then
            e.Cell.Appearance.BackColor = Color.Red
        Else
            e.Cell.Appearance.ResetBackColor()
        End If
    End Sub

    Private Sub UltraButtonAggiungiADAC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAggiungiADAC.Click
        For i As Integer = 0 To dtPrefatturaConsegne.Rows.Count - 1
            If dtPrefatturaConsegne.Rows(i).Item("Sigla") = "AD/AC" Then
                dtPrefatturaConsegne.Rows(i).Item("Totale") = dtPrefatturaConsegne.Rows(i).Item("Totale") + UltraCurrencyEditorADAC.Value
            End If
        Next
        dtExtra.Rows.Add()
        dtExtra.Rows(dtExtra.Rows.Count - 1).Item("Sigla corrispettivo") = "AD/AC"
        dtExtra.Rows(dtExtra.Rows.Count - 1).Item("Descrizione corrispettivo") = UltraTextEditorDescrizione.Text
        dtExtra.Rows(dtExtra.Rows.Count - 1).Item("Importo corrispettivo") = 1
        dtExtra.Rows(dtExtra.Rows.Count - 1).Item("Numero") = 1
        dtExtra.Rows(dtExtra.Rows.Count - 1).Item("Totale") = UltraCurrencyEditorADAC.Value

        UltraButtonAggiungiADAC.Enabled = True
        UltraCurrencyEditorADAC.ResetValue()
    End Sub

    Private Sub UltraCurrencyEditorADAC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraCurrencyEditorADAC.ValueChanged
        UltraButtonAggiungiADAC.Enabled = True
    End Sub

    Private Sub UltraButtonElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonElimina.Click
        Dim righe As DataRowCollection = dtExtra.Rows

        Try
            If UltraGridExtra.Selected.Rows.Count > 0 Then

                For i As Integer = 0 To dtPrefatturaConsegne.Rows.Count - 1
                    If dtPrefatturaConsegne.Rows(i).Item("Sigla") = dtExtra.Rows(UltraGridExtra.Selected.Rows(0).Index).Item("Sigla corrispettivo") Then
                        dtPrefatturaConsegne.Rows(i).Item("Totale") = dtPrefatturaConsegne.Rows(i).Item("Totale") - dtExtra.Rows(UltraGridExtra.Selected.Rows(0).Index).Item("Totale")
                        If dtPrefatturaConsegne.Rows(i).Item("Sigla") <> "AD/AC" Then
                            dtPrefatturaConsegne.Rows(i).Item("Cons.Originali") = dtPrefatturaConsegne.Rows(i).Item("Cons.Originali") - dtExtra.Rows(UltraGridExtra.Selected.Rows(0).Index).Item("Numero")
                            dtPrefatturaConsegne.Rows(i).Item("Cons.Finali") = dtPrefatturaConsegne.Rows(i).Item("Cons.Finali") - dtExtra.Rows(UltraGridExtra.Selected.Rows(0).Index).Item("Numero")
                        End If
                    End If
                Next
                'dtExtra.Rows(UltraGridExtra.Selected.Rows(0).Index).Delete()
                righe.RemoveAt(UltraGridExtra.Selected.Rows(0).Index)

                UltraGrid1.DataSource = dtPrefatturaConsegne
                UltraGrid1.Refresh()
                UltraGridExtra.DataSource = dtExtra
                UltraGridExtra.Refresh()
                UltraGridExtra.Selected.Rows.Clear()

                MsgBox("Elementi eliminati con successo!!", MsgBoxStyle.Information)
            Else
                MsgBox("Attenzione!! Nessun elemento selezionato!", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UltraButtonAggiungi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAggiungi.Click

        dtExtra.Rows.Add()
        dtExtra.Rows(dtExtra.Rows.Count - 1).Item("Sigla corrispettivo") = UltraComboExtra.SelectedRow.Cells("Sigla corrispettivo").Value
        dtExtra.Rows(dtExtra.Rows.Count - 1).Item("Descrizione corrispettivo") = UltraComboExtra.SelectedRow.Cells("Descrizione").Value
        dtExtra.Rows(dtExtra.Rows.Count - 1).Item("Importo corrispettivo") = UltraComboExtra.SelectedRow.Cells("Importo").Value
        dtExtra.Rows(dtExtra.Rows.Count - 1).Item("Numero") = UltraNumericEditorQuantita.Value
        dtExtra.Rows(dtExtra.Rows.Count - 1).Item("Totale") = UltraComboExtra.SelectedRow.Cells("Importo").Value * UltraNumericEditorQuantita.Value

        For i As Integer = 0 To dtPrefatturaConsegne.Rows.Count - 1
            If dtPrefatturaConsegne.Rows(i).Item("Sigla") = UltraComboExtra.SelectedRow.Cells("Sigla corrispettivo").Value Then
                dtPrefatturaConsegne.Rows(i).Item("Totale") = dtPrefatturaConsegne.Rows(i).Item("Totale") + dtExtra.Rows(dtExtra.Rows.Count - 1).Item("Totale")
                If dtPrefatturaConsegne.Rows(i).Item("Sigla") <> "AD/AC" Then
                    dtPrefatturaConsegne.Rows(i).Item("Cons.Originali") = dtPrefatturaConsegne.Rows(i).Item("Cons.Originali") + UltraNumericEditorQuantita.Value
                    dtPrefatturaConsegne.Rows(i).Item("Cons.Finali") = dtPrefatturaConsegne.Rows(i).Item("Cons.Finali") + UltraNumericEditorQuantita.Value
                    dtPrefatturaConsegne.Rows(i).Item("Costo unitario") = UltraComboExtra.SelectedRow.Cells("Importo").Value
                End If
            End If
        Next

    End Sub

    Private Sub UltraComboExtra_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraComboExtra.ValueChanged
        UltraButtonAggiungi.Enabled = True
    End Sub

    Private Sub UltraButtonEsportaInExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonEsportaInExcel.Click
        Dim data As Date = UltraDateTimeEditorMeseAnno.Value
        Dim righeDaRipetere As Infragistics.Documents.Excel.RepeatTitleRange = New Infragistics.Documents.Excel.RepeatTitleRange(0, 2)
        cartellaRiepilogo.Worksheets.Clear()

        Try
            If Not IO.File.Exists("Riepilogo" & "_" & Data.Year & "_" & Data.Month & ".xls") Then
                cartellaRiepilogo.Worksheets.Add("Riepilogo generale")
            Else
                If MsgBox("ATTENZIONE!! File esistente, lo carico?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    cartellaRiepilogo = Infragistics.Documents.Excel.Workbook.Load("Riepilogo" & "_" & data.Year & "_" & data.Month & ".xls")
                Else
                    IO.File.Delete("Riepilogo" & "_" & data.Year & "_" & data.Month & ".xls")
                    cartellaRiepilogo.Worksheets.Add("Riepilogo generale")
                    'intestazione
                    cartellaRiepilogo.Worksheets("Riepilogo generale").MergedCellsRegions.Add(0, 0, 0, dtSigleCorrispetivi.Rows.Count + 1) 'merge0
                    cartellaRiepilogo.Worksheets("Riepilogo generale").MergedCellsRegions(0).CellFormat.Font.Bold = Infragistics.Documents.Excel.ExcelDefaultableBoolean.True
                    cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(0).Cells(0).Value = "Riepilogo generale consegne giornaliere " & data.Month & "-" & data.Year
                    cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(0).Cells(0).CellFormat.Font.Height = 240
                    cartellaRiepilogo.Worksheets("Riepilogo generale").MergedCellsRegions(0).CellFormat.Alignment = Infragistics.Documents.Excel.HorizontalCellAlignment.Center
                    'intestazione colonne
                    cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(1).Cells(0).Value = "Trasportatore"
                    For i As Integer = 0 To UltraGrid1.Rows.Count - 1
                        cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(1).Cells(i + 1).Value = UltraGrid1.Rows(i).Cells(0).Value
                        cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 9).Cells(i + 1).Value = UltraGrid1.Rows(i).Cells(0).Value
                    Next
                    cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(1).Cells(dtSigleCorrispetivi.Rows.Count + 1).Value = "Saldo"

                    'totali generali
                    cartellaRiepilogo.Worksheets("Riepilogo generale").MergedCellsRegions.Add((UltraComboTrasportatore.Rows.Count - 1) * 5 + 8, 0, (UltraComboTrasportatore.Rows.Count - 1) * 5 + 8, dtSigleCorrispetivi.Rows.Count + 1) 'merge1
                    cartellaRiepilogo.Worksheets("Riepilogo generale").MergedCellsRegions(1).CellFormat.Font.Bold = Infragistics.Documents.Excel.ExcelDefaultableBoolean.True
                    cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 8).Cells(0).Value = "T O T A L I  G E N E R A L I"
                    'cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 8).Cells(0).CellFormat.Font.Height = 240
                    cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 8).CellFormat.Alignment = Infragistics.Documents.Excel.HorizontalCellAlignment.Center
                    cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 11).CellFormat.FormatString = """€""#,##0.00;[red]""€""#,##0.00""0.00"
                    'saldo finale
                    cartellaRiepilogo.Worksheets("Riepilogo generale").MergedCellsRegions.Add((UltraComboTrasportatore.Rows.Count - 1) * 5 + 12, 0, (UltraComboTrasportatore.Rows.Count - 1) * 5 + 12, dtSigleCorrispetivi.Rows.Count + 1) 'merge2
                    cartellaRiepilogo.Worksheets("Riepilogo generale").MergedCellsRegions(2).CellFormat.Font.Bold = Infragistics.Documents.Excel.ExcelDefaultableBoolean.True
                    'cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 12).Cells(0).CellFormat.Font.Height = 240
                    cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 12).CellFormat.Alignment = Infragistics.Documents.Excel.HorizontalCellAlignment.Center
                    'impostazioni di stampa
                    cartellaRiepilogo.Worksheets("Riepilogo generale").Columns(0).Width = 3000
                    cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.Orientation = Infragistics.Documents.Excel.Orientation.Landscape
                    cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.ScalingType = Infragistics.Documents.Excel.ScalingType.FitToPages
                    cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.MaxPagesHorizontally = 1
                    cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.MaxPagesVertically = 10
                    cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.LeftMargin = 0.5
                    cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.RightMargin = 0.5
                    cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.TopMargin = 0.5
                    cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.BottomMargin = 0.5
                    cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.CenterHorizontally = True
                    cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.RowsToRepeatAtTop = righeDaRipetere
                End If
            End If
            generaExcel()
            For i As Integer = 1 To dtSigleCorrispetivi.Rows.Count + 1
                cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 10).Cells(i).Value = 0
                cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 11).Cells(i).Value = 0
            Next
            For i As Integer = 1 To dtSigleCorrispetivi.Rows.Count + 1
                For j As Integer = 0 To UltraComboTrasportatore.Rows.Count - 1
                    cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 10).Cells(i).Value = cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 10).Cells(i).Value +
                                        cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(j * 5 + 3).Cells(i).Value
                    cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 11).Cells(i).Value = cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 11).Cells(i).Value +
                                        cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(j * 5 + 6).Cells(i).Value
                Next
            Next

            cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 12).Cells(0).Value = "Saldo finale: " & cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 11).Cells(dtSigleCorrispetivi.Rows.Count + 1).Value

            cartellaRiepilogo.Save("Riepilogo" & "_" & data.Year & "_" & data.Month & ".xls")
        Catch ex As Exception
            MsgBox("ATTENZIONE!! Errore nel salvataggio riepilogo generale. Verificare!", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub generaExcel()
        Dim data As Date = UltraDateTimeEditorMeseAnno.Value
        Dim cartella As Infragistics.Documents.Excel.Workbook = New Infragistics.Documents.Excel.Workbook

        cartella.Worksheets.Add("Prefattura")
        cartella.Worksheets("Prefattura").Columns(5).Width = 3000
        'For i As Integer = 1 To 4
        '    cartella.Worksheets("Prefattura").Columns(i).CellFormat.Alignment = Infragistics.Documents.Excel.HorizontalCellAlignment.Center
        'Next

        'trasportatore in alto a sx
        cartella.Worksheets("Prefattura").MergedCellsRegions.Add(0, 0, 0, 3) 'merge0
        cartella.Worksheets("Prefattura").MergedCellsRegions(0).CellFormat.Font.Bold = Infragistics.Documents.Excel.ExcelDefaultableBoolean.True
        cartella.Worksheets("Prefattura").Rows(0).Cells(0).Value = UltraComboTrasportatore.Value
        cartella.Worksheets("Prefattura").Rows(0).Cells(0).CellFormat.Font.Height = 240
        'mese anno in alto a dx
        cartella.Worksheets("Prefattura").Rows(0).Cells(5).Value = data.Month & "-" & data.Year
        cartella.Worksheets("Prefattura").Rows(0).Cells(5).CellFormat.Font.Height = 240
        cartella.Worksheets("Prefattura").Rows(0).Cells(5).CellFormat.Font.Bold = Infragistics.Documents.Excel.ExcelDefaultableBoolean.True
        'intestazioni di consegne
        cartella.Worksheets("Prefattura").Rows(1).Cells(1).Value = "Sigla corrispettivo"
        cartella.Worksheets("Prefattura").Rows(1).Cells(2).Value = "N.Cons."
        cartella.Worksheets("Prefattura").Rows(1).Cells(3).Value = "C.Unit."
        cartella.Worksheets("Prefattura").Rows(1).Cells(4).Value = "Totale"
        'tabella consegne
        For i As Integer = 0 To UltraGrid1.Rows.Count - 1
            'sigla
            cartella.Worksheets("Prefattura").Rows(i + 2).Cells(1).Value = UltraGrid1.Rows(i).Cells(0).Value
            'costo unitario e totale
            For j As Integer = 2 To UltraGrid1.Rows(0).Cells.Count - 1
                cartella.Worksheets("Prefattura").Rows(i + 2).Cells(j).Value = UltraGrid1.Rows(i).Cells(j).Value
            Next
        Next
        'separatore di totale
        cartella.Worksheets("Prefattura").MergedCellsRegions.Add(UltraGrid1.Rows.Count + 2, 0, UltraGrid1.Rows.Count + 2, 5) 'merge1
        cartella.Worksheets("Prefattura").MergedCellsRegions(1).CellFormat.Alignment = Infragistics.Documents.Excel.HorizontalCellAlignment.Center
        cartella.Worksheets("Prefattura").Rows(UltraGrid1.Rows.Count + 2).Cells(0).Value = "---------------------------------------------------------------------------------------"
        'totale
        cartella.Worksheets("Prefattura").Rows(UltraGrid1.Rows.Count + 3).Cells(1).Value = UltraLabelGiorniLavorati.Text
        cartella.Worksheets("Prefattura").Rows(UltraGrid1.Rows.Count + 3).Cells(2).Value = "SALDO:"
        cartella.Worksheets("Prefattura").Rows(UltraGrid1.Rows.Count + 3).Cells(4).Value = UltraGrid1.Rows.SummaryValues.Item(0).Value
        cartella.Worksheets("Prefattura").Rows(UltraGrid1.Rows.Count + 3).Cells(4).CellFormat.Alignment = Infragistics.Documents.Excel.HorizontalCellAlignment.Center
        cartella.Worksheets("Prefattura").Rows(UltraGrid1.Rows.Count + 3).Cells(4).CellFormat.Font.Bold = Infragistics.Documents.Excel.ExcelDefaultableBoolean.True
        'dettaglio AD/AC
        cartella.Worksheets("Prefattura").MergedCellsRegions.Add(25, 0, 25, 5) 'merge2
        cartella.Worksheets("Prefattura").MergedCellsRegions(2).CellFormat.BottomBorderColor = Color.Black
        cartella.Worksheets("Prefattura").MergedCellsRegions(2).CellFormat.TopBorderColor = Color.Black
        'cartella.Worksheets("Prefattura").Rows(25).Cells(0).CellFormat.BottomBorderColor = Color.Black
        'cartella.Worksheets("Prefattura").Rows(25).Cells(0).CellFormat.TopBorderColor = Color.Black
        cartella.Worksheets("Prefattura").Rows(25).Cells(0).CellFormat.FillPatternForegroundColor = Color.LightGray
        cartella.Worksheets("Prefattura").Rows(25).Cells(0).CellFormat.FillPattern = Infragistics.Documents.Excel.FillPatternStyle.Solid
        cartella.Worksheets("Prefattura").Rows(25).Cells(0).CellFormat.Alignment = Infragistics.Documents.Excel.HorizontalCellAlignment.Center
        cartella.Worksheets("Prefattura").Rows(25).Cells(0).Value = "Dettaglio addebiti e accrediti"
        UltraGridExcelExporter1.Export(UltraGridExtra, cartella, 27, 0)
        'riepilogo
        cartella.Worksheets("Prefattura").MergedCellsRegions.Add(UltraGridExtra.Rows.Count + 28, 0, UltraGridExtra.Rows.Count + 28, 5) 'merge3
        cartella.Worksheets("Prefattura").MergedCellsRegions(3).CellFormat.BottomBorderColor = Color.Black
        cartella.Worksheets("Prefattura").MergedCellsRegions(3).CellFormat.TopBorderColor = Color.Black
        'cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 28).Cells(0).CellFormat.BottomBorderColor = Color.Black
        'cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 28).Cells(0).CellFormat.TopBorderColor = Color.Black
        cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 28).Cells(0).CellFormat.FillPatternForegroundColor = Color.LightGray
        cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 28).Cells(0).CellFormat.FillPattern = Infragistics.Documents.Excel.FillPatternStyle.Solid
        cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 28).Cells(0).CellFormat.Alignment = Infragistics.Documents.Excel.HorizontalCellAlignment.Center
        cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 28).Cells(0).Value = "Riepilogo compensi " & data.Month & "-" & data.Year
        cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 29).Cells(0).Value = "Consegnato"
        cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 29).Cells(5).Value = UltraDateTimeEditorDataConsegnato.Value
        cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 30).Cells(0).Value = "Da riconsegnare entro il"
        cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 30).Cells(5).Value = UltraDateTimeEditorDataDaRiconsegnare.Value
        cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 31).Cells(0).Value = "Se non avete note o domande potete tenere questo foglio."
        cartella.Worksheets("Prefattura").MergedCellsRegions.Add(UltraGridExtra.Rows.Count + 32, 0, UltraGridExtra.Rows.Count + 32, 5) 'merge4
        'cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 32).Cells(0).CellFormat.BottomBorderColor = Color.Black
        'cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 32).Cells(0).CellFormat.TopBorderColor = Color.Black
        cartella.Worksheets("Prefattura").MergedCellsRegions(4).CellFormat.BottomBorderColor = Color.Black
        cartella.Worksheets("Prefattura").MergedCellsRegions(4).CellFormat.TopBorderColor = Color.Black
        cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 32).Cells(0).CellFormat.FillPatternForegroundColor = Color.LightGray
        cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 32).Cells(0).CellFormat.FillPattern = Infragistics.Documents.Excel.FillPatternStyle.Solid
        cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 32).Cells(0).CellFormat.Alignment = Infragistics.Documents.Excel.HorizontalCellAlignment.Center
        cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 32).Cells(0).Value = "Fattura"
        cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 33).Cells(0).Value = "Da consegnare entro il"
        cartella.Worksheets("Prefattura").Rows(UltraGridExtra.Rows.Count + 33).Cells(5).Value = UltraDateTimeEditorDataDaRiconsegnare.Value
        'impostazioni di stampa
        'cartella.Worksheets("Prefattura").PrintOptions.BottomMargin = 10
        'cartella.Worksheets("Prefattura").PrintOptions.TopMargin = 5
        'cartella.Worksheets("Prefattura").PrintOptions.LeftMargin = 3
        'cartella.Worksheets("Prefattura").PrintOptions.RightMargin = 1
        cartella.Worksheets("Prefattura").PrintOptions.ScalingType = Infragistics.Documents.Excel.ScalingType.FitToPages
        cartella.Worksheets("Prefattura").PrintOptions.CenterHorizontally = True
        cartella.Worksheets("Prefattura").PrintOptions.MaxPagesHorizontally = 1
        cartella.Worksheets("Prefattura").PrintOptions.MaxPagesVertically = 1
        cartella.Worksheets("Prefattura").Columns(2).CellFormat.FormatString = "0"
        For i As Integer = 3 To 4
            cartella.Worksheets("Prefattura").Columns(i).CellFormat.FormatString = "0.00"
            'cartella.Worksheets("Prefattura").Columns(i - 1).CellFormat.Alignment = Infragistics.Documents.Excel.HorizontalCellAlignment.Right
        Next

        Try
            If Not IO.File.Exists("Prefattura" & "_" & data.Year & "_" & data.Month & "_" & UltraComboTrasportatore.Value & ".xls") Then
                cartella.Save("Prefattura" & "_" & data.Year & "_" & data.Month & "_" & UltraComboTrasportatore.Value & ".xls")
            Else
                If MsgBox("ATTENZIONE!! File esistente, sovrascriverlo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    cartella.Save("Prefattura" & "_" & data.Year & "_" & data.Month & "_" & UltraComboTrasportatore.Value & ".xls")
                End If
            End If
        Catch ex As Exception
            MsgBox("ATTENZIONE!! Errore nel salvataggio prefattura. Verificare!", MsgBoxStyle.Critical)
        End Try

        'riepilogo generale
        'consegne
        cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(UltraComboTrasportatore.SelectedRow.Index * 5 + 3).Cells(0).Value = UltraComboTrasportatore.Value
        For i As Integer = 0 To UltraGrid1.Rows.Count - 1
            cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(UltraComboTrasportatore.SelectedRow.Index * 5 + 3).Cells(i + 1).Value = UltraGrid1.Rows(i).Cells(2).Value
            cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(UltraComboTrasportatore.SelectedRow.Index * 5 + 4).Cells(i + 1).Value = UltraGrid1.Rows(i).Cells(3).Value
            cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(UltraComboTrasportatore.SelectedRow.Index * 5 + 4).CellFormat.FormatString = "0.00"
            cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(UltraComboTrasportatore.SelectedRow.Index * 5 + 6).Cells(i + 1).Value = UltraGrid1.Rows(i).Cells(4).Value
            cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(UltraComboTrasportatore.SelectedRow.Index * 5 + 6).CellFormat.FormatString = "0.00"
        Next
        cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(UltraComboTrasportatore.SelectedRow.Index * 5 + 4).Cells(0).Value = "Costo unit."
        cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(UltraComboTrasportatore.SelectedRow.Index * 5 + 5).Cells(0).Value = "gg. lav." & UltraLabelGiorniLavorati.Text.Substring(16)
        cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(UltraComboTrasportatore.SelectedRow.Index * 5 + 5).Cells(1).Value = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------"
        cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(UltraComboTrasportatore.SelectedRow.Index * 5 + 6).Cells(0).Value = "Totali"
        cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(UltraComboTrasportatore.SelectedRow.Index * 5 + 6).Cells(22).Value = UltraGrid1.Rows.SummaryValues.Item(0).Value
        cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(UltraComboTrasportatore.SelectedRow.Index * 5 + 6).CellFormat.Font.Bold = Infragistics.Documents.Excel.ExcelDefaultableBoolean.True

        MsgBox("Esportazione in Excel terminata!!", MsgBoxStyle.Information)
    End Sub

    Private Sub UltraGridExcelExporter1_ExportEnded(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.ExcelExport.ExportEndedEventArgs) Handles UltraGridExcelExporter1.ExportEnded
        'MsgBox("Esportazione in Excel terminata!!", MsgBoxStyle.Information)
    End Sub

    Private Sub UltraButtonStampa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonStampa.Click
        Dim P As New Process
        Dim data As Date = UltraDateTimeEditorMeseAnno.Value

        Try
            P.StartInfo.Verb = "Print"
            P.StartInfo.FileName = "Prefattura " & "_" & data.Year & "_" & data.Month & "_" & UltraComboTrasportatore.Value & ".xls"
            P.Start()
        Catch ex As Exception
            MsgBox("ATTENZIONE!! File inesistente o errore I/O. Verificare!", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub UltraButtonStampaTutti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonStampaTutti.Click
        Dim P As New Process
        Dim data As Date = UltraDateTimeEditorMeseAnno.Value
        Dim righeDaRipetere As Infragistics.Documents.Excel.RepeatTitleRange = New Infragistics.Documents.Excel.RepeatTitleRange(0, 2)

        If MsgBox("Il processo impiegherà diversi minuti (oltre 10 min.), continuare ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                If Not IO.File.Exists("Riepilogo" & "_" & data.Year & "_" & data.Month & ".xls") Then
                    cartellaRiepilogo.Worksheets.Add("Riepilogo generale")
                Else
                    IO.File.Delete("Riepilogo" & "_" & data.Year & "_" & data.Month & ".xls")
                    cartellaRiepilogo.Worksheets.Add("Riepilogo generale")
                End If
                'intestazione
                cartellaRiepilogo.Worksheets("Riepilogo generale").MergedCellsRegions.Add(0, 0, 0, dtSigleCorrispetivi.Rows.Count + 1) 'merge0
                cartellaRiepilogo.Worksheets("Riepilogo generale").MergedCellsRegions(0).CellFormat.Font.Bold = Infragistics.Documents.Excel.ExcelDefaultableBoolean.True
                cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(0).Cells(0).Value = "Riepilogo generale consegne giornaliere " & data.Month & "-" & data.Year
                cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(0).Cells(0).CellFormat.Font.Height = 240
                cartellaRiepilogo.Worksheets("Riepilogo generale").MergedCellsRegions(0).CellFormat.Alignment = Infragistics.Documents.Excel.HorizontalCellAlignment.Center
                'intestazione colonne
                cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(1).Cells(0).Value = "Trasportatore"
                For i As Integer = 0 To dtSigleCorrispetivi.Rows.Count - 1
                    cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(1).Cells(i + 1).Value = dtSigleCorrispetivi.Rows(i).Item("Sigla")
                    cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 9).Cells(i + 1).Value = dtSigleCorrispetivi.Rows(i).Item("Sigla")
                Next
                cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(1).Cells(22).Value = "Saldo"

            Catch ex As Exception
                MsgBox("ATTENZIONE!! Errore nel salvataggio riepilogo generale. Verificare!", MsgBoxStyle.Critical)
            End Try

            For i As Integer = 0 To UltraComboTrasportatore.Rows.Count - 1
                UltraComboTrasportatore.Value = UltraComboTrasportatore.Rows(i).Cells("Trasportatore").Value
                caricaTrasportatore()
                generaExcel()
                Try
                    P.StartInfo.Verb = "Print"
                    P.StartInfo.FileName = "Prefattura" & "_" & data.Year & "_" & data.Month & "_" & UltraComboTrasportatore.Value & ".xls"
                    P.Start()
                Catch ex As Exception
                    MsgBox("ATTENZIONE!! File inesistente o errore I/O. Verificare!", MsgBoxStyle.Critical)
                End Try
            Next
            'totali generali
            cartellaRiepilogo.Worksheets("Riepilogo generale").MergedCellsRegions.Add((UltraComboTrasportatore.Rows.Count - 1) * 5 + 8, 0, (UltraComboTrasportatore.Rows.Count - 1) * 5 + 8, dtSigleCorrispetivi.Rows.Count + 1) 'merge1
            cartellaRiepilogo.Worksheets("Riepilogo generale").MergedCellsRegions(1).CellFormat.Font.Bold = Infragistics.Documents.Excel.ExcelDefaultableBoolean.True
            cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 8).Cells(0).Value = "T O T A L I  G E N E R A L I"
            'cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 8).Cells(0).CellFormat.Font.Height = 240
            cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 8).CellFormat.Alignment = Infragistics.Documents.Excel.HorizontalCellAlignment.Center
            For i As Integer = 1 To dtSigleCorrispetivi.Rows.Count + 1
                cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 10).Cells(i).Value = 0
                cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 11).Cells(i).Value = 0
            Next
            For i As Integer = 1 To dtSigleCorrispetivi.Rows.Count + 1
                For j As Integer = 0 To UltraComboTrasportatore.Rows.Count - 1
                    cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 10).Cells(i).Value = cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 10).Cells(i).Value +
                                        cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(j * 5 + 3).Cells(i).Value
                    cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 11).Cells(i).Value = cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 11).Cells(i).Value +
                                        cartellaRiepilogo.Worksheets("Riepilogo generale").Rows(j * 5 + 6).Cells(i).Value
                Next
            Next
            cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 11).CellFormat.FormatString = "0.00"
            'saldo finale
            cartellaRiepilogo.Worksheets("Riepilogo generale").MergedCellsRegions.Add((UltraComboTrasportatore.Rows.Count - 1) * 5 + 12, 0, (UltraComboTrasportatore.Rows.Count - 1) * 5 + 12, dtSigleCorrispetivi.Rows.Count + 1) 'merge2
            cartellaRiepilogo.Worksheets("Riepilogo generale").MergedCellsRegions(2).CellFormat.Font.Bold = Infragistics.Documents.Excel.ExcelDefaultableBoolean.True
            cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 12).Cells(0).Value = "Saldo finale: " & cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 11).Cells(dtSigleCorrispetivi.Rows.Count + 1).Value
            'cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 12).Cells(0).CellFormat.Font.Height = 240
            cartellaRiepilogo.Worksheets("Riepilogo generale").Rows((UltraComboTrasportatore.Rows.Count - 1) * 5 + 12).CellFormat.Alignment = Infragistics.Documents.Excel.HorizontalCellAlignment.Center
            'impostazioni di stampa
            cartellaRiepilogo.Worksheets("Riepilogo generale").Columns(0).Width = 3000
            cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.Orientation = Infragistics.Documents.Excel.Orientation.Landscape
            cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.ScalingType = Infragistics.Documents.Excel.ScalingType.FitToPages
            cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.MaxPagesHorizontally = 1
            cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.MaxPagesVertically = 10
            cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.LeftMargin = 0.5
            cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.RightMargin = 0.5
            cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.TopMargin = 0.5
            cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.BottomMargin = 0.5
            cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.CenterHorizontally = True
            cartellaRiepilogo.Worksheets("Riepilogo generale").PrintOptions.RowsToRepeatAtTop = righeDaRipetere

            cartellaRiepilogo.Save("Riepilogo" & "_" & data.Year & "_" & data.Month & ".xls")

            MsgBox("Processo terminato con successo!!!", MsgBoxStyle.Information)
        End If
    End Sub

End Class
