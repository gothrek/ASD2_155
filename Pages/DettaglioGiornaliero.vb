Public Class DettaglioGiornaliero
    Dim giorno As Short
    Dim mese As Short
    Dim anno As Short

    Private Sub DettaglioGiornaliero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.QFattureGiroGiornoTableAdapter.Fill(Me.ASDDBDataSet.QFattureGiroGiorno)
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim trovato As Boolean = False
        Try
            giorno = UltraDateTimeEditor1.DateTime.Day
            mese = UltraDateTimeEditor1.DateTime.Month
            anno = UltraDateTimeEditor1.DateTime.Year
        Catch ex As Exception
            giorno = Today.Day
            mese = Today.Month
            anno = Today.Year
        End Try
        Try
            Me.QFattureGiroGiornoTableAdapter.FillByData(Me.ASDDBDataSet.QFattureGiroGiorno, giorno, mese, anno)
            trovato = True
        Catch ex As Exception
            MsgBox("Nessun elemento trovato alla data specificata!!", MsgBoxStyle.Exclamation)
            trovato = False
        End Try
        If trovato Then
            For i As Integer = 0 To UltraGridDettaglioGiornaliero.Rows.Count - 1
                Try
                    UltraGridDettaglioGiornaliero.Rows(i).Cells("Totale").Value = UltraGridDettaglioGiornaliero.Rows(i).Cells("NumeroConsegne").Value * UltraGridDettaglioGiornaliero.Rows(i).Cells("Importo").Value
                Catch ex As Exception
                    UltraGridDettaglioGiornaliero.Rows(i).Cells("Totale").Value = 0
                End Try
            Next
            MsgBox("Dati caricati correttamente!!", MsgBoxStyle.OkOnly)
            UltraGridDettaglioGiornaliero.Refresh()
        End If
        'Me.QFattureGiroGiornoTableAdapter.Fill(Me.ASDDBDataSet.QFattureGiroGiorno)
    End Sub
End Class
