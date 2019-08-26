Public Class ChiusureExtra

    Private Sub ChiusureExtra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.QTabella_Distribuzioni'. È possibile spostarla o rimuoverla se necessario.
        Me.ChiusureTableAdapter.Fill(Me.ASDDBDataSet.Chiusure)
        Me.PITableAdapter.Fill(Me.ASDDBDataSet.PI)
        Form1.UltraStatusBar1.Panels(0).Text = "Per eliminare le chiusure selezionare i punti in basso a destra e premere il tasto CANC."
        Form1.UltraStatusBar1.Refresh()
    End Sub


    Private Sub ChiusureExtra_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        Me.ChiusureTableAdapter.Update(Me.ASDDBDataSet.Chiusure)
        Me.Validate()
        Me.ChiusureBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)
    End Sub

    Private Sub UltraGridPI_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)

    End Sub

    Private Sub UltraButtonAggiungi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAggiungi.Click
        Dim j As Integer = 0
        Dim esci As Boolean = False
        Form1.UltraStatusBar1.Panels(1).Visible = True
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Maximum = UltraMonthViewSingleData.CalendarInfo.SelectedDateRanges.Count * UltraGridPI.Selected.Rows.Count
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = 0
        Form1.UltraStatusBar1.Refresh()
        If (UltraGridPI.Selected.Rows.Count = 0) Or (UltraMonthViewSingleData.CalendarInfo.SelectedDateRanges.SelectedDaysCount = 0) Then
            MsgBox("Devi selezionare almeno un punto e almeno un giorno dal calendario!!", MsgBoxStyle.Exclamation)
        End If
        For i As Integer = 0 To UltraGridPI.Selected.Rows.Count - 1
            For k As Integer = 0 To UltraMonthViewSingleData.CalendarInfo.SelectedDateRanges.Count - 1
                Do
                    Try
                        Me.ChiusureTableAdapter.Insert(UltraGridPI.Selected.Rows(i).Cells("PI").Value, UltraMonthViewSingleData.CalendarInfo.SelectedDateRanges.Item(k).Days.Item(j).Date)
                        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value + 1
                        Form1.UltraStatusBar1.Refresh()
                    Catch ex As Exception

                    End Try
                    'MsgBox("Aggiungo " & UltraGridPI.Selected.Rows(i).Cells("PI").Value & " in data " & UltraMonthViewSingleData.CalendarInfo.SelectedDateRanges.Item(k).Days.Item(j).Date)
                    j = j + 1
                    If j = UltraMonthViewSingleData.CalendarInfo.SelectedDateRanges.Item(k).Days.Count Then
                        esci = True
                        j = 0
                    End If
                Loop Until esci
                esci = False
            Next
        Next
        Form1.UltraStatusBar1.Panels(1).Visible = False
        Form1.UltraStatusBar1.Panels(2).Text = "Aggiornamento e scrittura dei dati in corso, attendere!"
        Form1.UltraStatusBar1.Refresh()
        Me.ChiusureTableAdapter.Update(Me.ASDDBDataSet.Chiusure)
        Me.Validate()
        Me.ChiusureBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)
        Me.ChiusureTableAdapter.Fill(Me.ASDDBDataSet.Chiusure)
        ChiusureDataGridView.Refresh()
        Form1.UltraStatusBar1.Panels(2).Text = ""
        Form1.UltraStatusBar1.Refresh()
        MsgBox("Le chiusure extra sono state aggiunte correttamente.")
        
    End Sub

End Class
