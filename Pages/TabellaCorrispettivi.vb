Public Class TabellaCorrispettivi

    Dim nuovo As Boolean = True

    Dim sigla As Boolean = False
    Dim testata As Boolean = False
    Dim giorno As Boolean = False
    Dim tipologia As Boolean = False

    Dim originaleSigla As String = ""
    Dim originaleTestata As String = ""
    Dim originaleGiorno As String = ""
    Dim originaleTipologia As String = ""
    Dim originaleImporto As Double = 0
    Dim originaleDataValiditaIniziale As Date = Today
    Dim originaleDataValiditaFinale As Date = Today
    Dim originaleNota As String = ""

    Private Sub TabellaCorrispettivi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tabella_CorrispettiviTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Corrispettivi)
        Me.Tabella_Sigle_CorrispettiviTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Sigle_Corrispettivi)
        Me.TestateTableAdapter.Fill(Me.ASDDBDataSet.Testate)
        Me.Tabella_GiorniTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Giorni)
        Me.Tabella_TipologiaTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Tipologia)
        sigla = False
        testata = False
        giorno = False
        tipologia = False
    End Sub

    Private Sub UltraGridCorrispettivi_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGridCorrispettivi.AfterRowActivate

    End Sub

    Private Sub UltraButtonSalvaAggiornaCorrispettivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSalvaAggiornaCorrispettivo.Click
        Dim errore As Boolean = False
        Dim inizioGiorno, fineGiorno, inizioTestata, fineTestata, inizioTipologia, fineTipologia As Integer
        Dim numeroInserimenti As Integer = 0

        If nuovo Then
            'insert
            Try
                If sigla And (testata Or UltraCheckEditorTuttiTestate.Checked) And (giorno Or UltraCheckEditorTuttiGiorni.Checked) And (tipologia Or UltraCheckEditorTuttiTipologie.Checked) Then

                    If UltraCheckEditorTuttiGiorni.Checked Then
                        inizioGiorno = 0
                        fineGiorno = UltraComboGiorno.Rows.Count - 1
                    Else
                        inizioGiorno = UltraComboGiorno.SelectedRow.Index
                        fineGiorno = UltraComboGiorno.SelectedRow.Index
                    End If
                    If UltraCheckEditorTuttiTestate.Checked Then
                        inizioTestata = 0
                        fineTestata = UltraComboTestata.Rows.Count - 1
                    Else
                        inizioTestata = UltraComboTestata.SelectedRow.Index
                        fineTestata = UltraComboTestata.SelectedRow.Index
                    End If
                    If UltraCheckEditorTuttiTipologie.Checked Then
                        inizioTipologia = 0
                        fineTipologia = UltraComboTipologia.Rows.Count - 1
                    Else
                        inizioTipologia = UltraComboTipologia.SelectedRow.Index
                        fineTipologia = UltraComboTipologia.SelectedRow.Index
                    End If

                    For i As Integer = inizioGiorno To fineGiorno
                        For j As Integer = inizioTestata To fineTestata
                            For k As Integer = inizioTipologia To fineTipologia
                                Try
                                    Me.Tabella_CorrispettiviTableAdapter.Insert(UltraComboSiglaCorrispettivo.Value, UltraComboTestata.Rows(j).Cells("Codice").Value, UltraComboGiorno.Rows(i).Cells("Giorno").Value,
                                                                            UltraComboTipologia.Rows(k).Cells("Tipologia").Value, UltraCurrencyEditorImporto.Value, UltraDateTimeEditorDataValiditaIniziale.Value,
                                                                            UltraDateTimeEditorDataValiditaFinale.Value, UltraTextEditorNote.Text, "vuoto", "vuoto", 0, 0, UltraComboGiorno.Rows(i).Cells("Codice").Value, 0, 0, False, Today)
                                    Me.Validate()
                                    Me.Tabella_CorrispettiviBindingSource.EndEdit()
                                    Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)
                                    numeroInserimenti = numeroInserimenti + 1
                                Catch ex As Exception

                                End Try
                            Next
                        Next
                    Next
                    MsgBox("N." & numeroInserimenti & " inserimenti su " & (fineGiorno - inizioGiorno + 1) * (fineTestata - inizioTestata + 1) * (fineTipologia - inizioTipologia + 1) & " riusciti!!", MsgBoxStyle.Information)

                    'Me.Tabella_CorrispettiviTableAdapter.Insert(UltraComboSiglaCorrispettivo.Value, UltraComboTestata.Value, UltraComboGiorno.Value, UltraComboTipologia.Value, UltraCurrencyEditorImporto.Value, UltraDateTimeEditorDataValiditaIniziale.Value, UltraDateTimeEditorDataValiditaFinale.Value, UltraTextEditorNote.Text, "vuoto", "vuoto", 0, 0, 0, 0, 0, False, Today)
                    Me.Validate()
                    Me.Tabella_CorrispettiviBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)

                    Me.Tabella_CorrispettiviTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Corrispettivi)
                    UltraGridCorrispettivi.Refresh()
                Else
                    errore = True
                End If
            Catch ex As Exception
                errore = True
                MsgBox("Errore durante l'inserimento!!Verificare i dati.", MsgBoxStyle.Critical)
            End Try
        Else
            'update
            Try
                If sigla And testata And giorno And tipologia Then
                    'Me.Tabella_CorrispettiviTableAdapter.UpdateQueryBase(UltraGridCorrispettivi.Selected.Rows(0).Cells("Sigla corrispettivo").Value, UltraGridCorrispettivi.Selected.Rows(0).Cells("Testata").Value, UltraGridCorrispettivi.Selected.Rows(0).Cells("Giorno").Value, UltraGridCorrispettivi.Selected.Rows(0).Cells("Tipologia").Value, UltraGridCorrispettivi.Selected.Rows(0).Cells("Importo").Value, UltraGridCorrispettivi.Selected.Rows(0).Cells("Data inizio validità").Value, UltraGridCorrispettivi.Selected.Rows(0).Cells("Data fine validità").Value, UltraGridCorrispettivi.Selected.Rows(0).Cells("Note").Value, UltraComboSiglaCorrispettivo.Value, UltraComboTestata.Value, UltraComboGiorno.Value, UltraComboTipologia.Value, UltraCurrencyEditorImporto.Value, UltraDateTimeEditorDataValiditaIniziale.Value, UltraDateTimeEditorDataValiditaFinale.Value, UltraTextEditorNote.Text)
                    Me.Tabella_CorrispettiviTableAdapter.UpdateQueryBase(UltraComboSiglaCorrispettivo.Value, UltraComboTestata.Value, UltraComboGiorno.Text, UltraComboTipologia.Value, UltraCurrencyEditorImporto.Value, UltraDateTimeEditorDataValiditaIniziale.Value, UltraDateTimeEditorDataValiditaFinale.Value, UltraTextEditorNote.Text, UltraComboGiorno.Value, originaleSigla, originaleTestata, originaleGiorno, originaleTipologia, originaleImporto, originaleDataValiditaIniziale, originaleDataValiditaFinale, originaleNota)
                    Me.Validate()
                    Me.Tabella_CorrispettiviBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)
                    Me.Tabella_CorrispettiviTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Corrispettivi)
                    UltraGridCorrispettivi.Refresh()
                Else
                    errore = True
                End If
            Catch ex As Exception
                errore = True
                MsgBox("Errore durante l'aggiornamento!!Verificare i dati.", MsgBoxStyle.Critical)
            End Try
        End If
        If Not errore Then
            MsgBox("Inserimento/Aggiornamento effettuato con successo!!", MsgBoxStyle.Exclamation)
        Else
            MsgBox("Sono mancanti alcuni dati essenziali al fine di definire il corrispettivo!! Verificare!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub UltraButtonNuovoCorrispettivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonNuovoCorrispettivo.Click
        nuovo = True
        UltraComboSiglaCorrispettivo.Text = "Seleziona una sigla"
        sigla = False
        UltraComboTestata.Text = "Seleziona una testata"
        testata = False
        UltraComboGiorno.Text = "Seleziona un giorno"
        giorno = False
        UltraComboTipologia.Text = "Seleziona una tipologia"
        tipologia = False
        UltraCurrencyEditorImporto.Value = 0
        UltraDateTimeEditorDataValiditaIniziale.Value = Today
        UltraDateTimeEditorDataValiditaFinale.Value = Today
        UltraTextEditorNote.Text = ""
        UltraCheckEditorTuttiTestate.Checked = False
        UltraCheckEditorTuttiGiorni.Checked = False
        UltraCheckEditorTuttiTipologie.Checked = False

    End Sub

    Private Sub UltraComboSiglaCorrispettivo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraComboSiglaCorrispettivo.ValueChanged
        sigla = True
    End Sub

    Private Sub UltraComboTestata_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraComboTestata.ValueChanged
        testata = True
    End Sub

    Private Sub UltraComboGiorno_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraComboGiorno.ValueChanged
        giorno = True
    End Sub

    Private Sub UltraComboTipologia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraComboTipologia.ValueChanged
        tipologia = True
    End Sub

    Private Sub UltraGridCorrispettivi_AfterSelectChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles UltraGridCorrispettivi.AfterSelectChange
        nuovo = False
        Try
            UltraComboSiglaCorrispettivo.Value = UltraGridCorrispettivi.Selected.Rows(0).Cells("Sigla corrispettivo").Value
            originaleSigla = UltraGridCorrispettivi.Selected.Rows(0).Cells("Sigla corrispettivo").Value
            sigla = True
        Catch ex As Exception
            sigla = False
        End Try
        Try
            UltraComboTestata.Value = UltraGridCorrispettivi.Selected.Rows(0).Cells("Testata").Value
            originaleTestata = UltraGridCorrispettivi.Selected.Rows(0).Cells("Testata").Value
            testata = True
        Catch ex As Exception
            testata = False
        End Try
        Try
            UltraComboGiorno.Value = UltraGridCorrispettivi.Selected.Rows(0).Cells("Giorno").Value
            originaleGiorno = UltraGridCorrispettivi.Selected.Rows(0).Cells("Giorno").Value
            giorno = True
        Catch ex As Exception
            giorno = False
        End Try
        Try
            UltraComboTipologia.Value = UltraGridCorrispettivi.Selected.Rows(0).Cells("Tipologia").Value
            originaleTipologia = UltraGridCorrispettivi.Selected.Rows(0).Cells("Tipologia").Value
            tipologia = True
        Catch ex As Exception
            tipologia = False
        End Try
        Try
            UltraCurrencyEditorImporto.Value = UltraGridCorrispettivi.Selected.Rows(0).Cells("Importo").Value
            originaleImporto = UltraGridCorrispettivi.Selected.Rows(0).Cells("Importo").Value
        Catch ex As Exception
            UltraCurrencyEditorImporto.Value = 0
        End Try
        Try
            UltraDateTimeEditorDataValiditaIniziale.Value = UltraGridCorrispettivi.Selected.Rows(0).Cells("Data inizio validità").Value
            originaleDataValiditaIniziale = UltraGridCorrispettivi.Selected.Rows(0).Cells("Data inizio validità").Value
        Catch ex As Exception
            UltraDateTimeEditorDataValiditaIniziale.Value = Today
        End Try
        Try
            UltraDateTimeEditorDataValiditaFinale.Value = UltraGridCorrispettivi.Selected.Rows(0).Cells("Data fine validità").Value
            originaleDataValiditaFinale = UltraGridCorrispettivi.Selected.Rows(0).Cells("Data fine validità").Value
        Catch ex As Exception
            UltraDateTimeEditorDataValiditaFinale.Value = Today
        End Try
        Try
            UltraTextEditorNote.Text = UltraGridCorrispettivi.Selected.Rows(0).Cells("Note").Value
            originaleNota = UltraGridCorrispettivi.Selected.Rows(0).Cells("Note").Value
        Catch ex As Exception
            UltraTextEditorNote.Text = ""
        End Try
    End Sub

    Private Sub UltraButtonElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonElimina.Click
        'UltraGridCorrispettivi.DeleteSelectedRows()
        Try
            If UltraGridCorrispettivi.Selected.Rows.Count > 0 Then
                For i As Integer = 0 To UltraGridCorrispettivi.Selected.Rows.Count - 1
                    Me.Tabella_CorrispettiviTableAdapter.DeleteQueryManuale(UltraGridCorrispettivi.Selected.Rows(i).Cells("Sigla corrispettivo").Value, UltraGridCorrispettivi.Selected.Rows(i).Cells("Testata").Value,
                                                                              UltraGridCorrispettivi.Selected.Rows(i).Cells("Giorno").Value, UltraGridCorrispettivi.Selected.Rows(i).Cells("Tipologia").Value)
                    Me.Validate()
                    Me.Tabella_CorrispettiviBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)
                Next
                Me.Tabella_CorrispettiviTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Corrispettivi)
                UltraGridCorrispettivi.Refresh()
                MsgBox("Elementi eliminati con successo!!", MsgBoxStyle.Information)
            Else
                MsgBox("Attenzione!!Nessun elemento selezionato!", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
