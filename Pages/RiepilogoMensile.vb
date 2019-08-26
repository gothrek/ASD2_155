Public Class RiepilogoMensile

    Private Sub RiepilogoMensile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.QFatturatoMeseAnnoGiroTableAdapter.Fill(Me.ASDDBDataSet.QFatturatoMeseAnnoGiro)
    End Sub
End Class
