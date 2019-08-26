Public Class ConsegneGiornaliere
    Dim primoGiorno As Date = Today
    Dim ultimoGiorno As Date = Today

    Private Sub ConsegneGiornaliere_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Tabella_CorrispettiviTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Corrispettivi)
        'Me.ConsegneTableAdapter.Fill(Me.ASDDBDataSet.Consegne)
        'Me.PITableAdapter.Fill(Me.ASDDBDataSet.PI)
        'Me.Trasportatori_presenzeTableAdapter.Fill(Me.ASDDBDataSet.Trasportatori_presenze)
        Me.Tabella_TrasportatoriTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Trasportatori)
        'Me.QConsegneGiornaliereTableAdapter.Fill(Me.ASDDBDataSet.QConsegneGiornaliere)
        Me.Tabella_Pagamenti_ExtraTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Pagamenti_Extra)

    End Sub

    Private Sub UltraButtonCarica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonCarica.Click

        primoGiorno = "#1/" & Month(UltraDateTimeEditorMeseAnno.Value) & "/" & Year(UltraDateTimeEditorMeseAnno.Value) & "#"
        ultimoGiorno = "#" & Date.DaysInMonth(Year(UltraDateTimeEditorMeseAnno.Value), Month(UltraDateTimeEditorMeseAnno.Value)) & "/" & Month(UltraDateTimeEditorMeseAnno.Value) & "/" & Year(UltraDateTimeEditorMeseAnno.Value) & "#"

        If MsgBox("Il processo impiegherà diversi minuti, continuare ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.DataTableConsegneGiornaliereTableAdapter.Fill(Me.ASDDBDataSet.DataTableConsegneGiornaliere)

            UltraGrid1.DataSource = Me.DataTableConsegneGiornaliereTableAdapter.GetDataByTrasportatoreMeseAnno(UltraComboTrasportatore.Value, primoGiorno, ultimoGiorno)

            MsgBox("Dati caricati con successo!!Procedo al caricamento degli extra.", MsgBoxStyle.Information)
            UltraGroupBoxExtra.Enabled = True
            UltraDateTimeEditorData.Value = Today
            UltraComboExtra.ResetText()
            UltraNumericEditorQuantita.Value = 1
            UltraButtonAggiungi.Enabled = False
            UltraGridExtra.DataSource = Me.Trasportatori_pagamenti_extraTableAdapter.GetDataByTrasportatoreData(UltraComboTrasportatore.Value, primoGiorno, ultimoGiorno)
            MsgBox("Dati extra caricati con successo!!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub UltraComboTrasportatore_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraComboTrasportatore.ValueChanged
        UltraGroupBoxExtra.Enabled = False
    End Sub

    Private Sub UltraComboExtra_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraComboExtra.ValueChanged
        UltraButtonAggiungi.Enabled = True
        UltraNumericEditorQuantita.Value = 1
    End Sub

    Private Sub UltraDateTimeEditorData_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraDateTimeEditorData.ValueChanged
        UltraComboExtra.ResetText()
        UltraNumericEditorQuantita.Value = 1
        UltraButtonAggiungi.Enabled = False
    End Sub

    Private Sub UltraButtonAggiungi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAggiungi.Click
        Me.Trasportatori_pagamenti_extraTableAdapter.Insert(UltraComboTrasportatore.Value, UltraDateTimeEditorData.Value, UltraComboExtra.SelectedRow.Cells("Sigla corrispettivo").Value,
                                                             UltraComboExtra.SelectedRow.Cells("Descrizione").Value, UltraComboExtra.SelectedRow.Cells("Importo").Value,
                                                             UltraNumericEditorQuantita.Value, " ", " ", " ", 0, 0, 0, 0, 0, True, Today)
        Me.Validate()
        Me.Trasportatori_pagamenti_extraBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)
        UltraGridExtra.DataSource = Me.Trasportatori_pagamenti_extraTableAdapter.GetDataByTrasportatoreData(UltraComboTrasportatore.Value, primoGiorno, ultimoGiorno)
        UltraGridExtra.Refresh()
    End Sub

    Private Sub UltraButtonElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonElimina.Click
        Try
            If UltraGridExtra.Selected.Rows.Count > 0 Then
                For i As Integer = 0 To UltraGridExtra.Selected.Rows.Count - 1
                    Me.Trasportatori_pagamenti_extraTableAdapter.DeleteQueryManuale(UltraComboTrasportatore.Value, UltraGridExtra.Selected.Rows(i).Cells("Data").Value,
                                                                                    UltraGridExtra.Selected.Rows(i).Cells("Descrizione corrispettivo").Value,
                                                                                    UltraGridExtra.Selected.Rows(i).Cells("Quantità").Value)
                    Me.Validate()
                    Me.Trasportatori_pagamenti_extraBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)
                Next
                UltraGridExtra.DataSource = Me.Trasportatori_pagamenti_extraTableAdapter.GetDataByTrasportatoreData(UltraComboTrasportatore.Value, primoGiorno, ultimoGiorno)
                UltraGridExtra.Refresh()
                MsgBox("Elementi eliminati con successo!!", MsgBoxStyle.Information)
            Else
                MsgBox("Attenzione!!Nessun elemento selezionato!", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UltraDateTimeEditorMeseAnno_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraDateTimeEditorMeseAnno.ValueChanged
        UltraButtonCarica.Enabled = True
    End Sub
End Class
