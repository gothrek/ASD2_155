Partial Class ASDDBDataSet
    Partial Class Trasportatori_presenzeDataTable

        Private Sub Trasportatori_presenzeDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.TrasportatoreColumn.ColumnName) Then
                'Aggiungere qui il codice utente
            End If

        End Sub

    End Class

    Partial Class QDistributoreSempliceDataTable

        Private Sub QDistributoreSempliceDataTable_QDistributoreSempliceRowChanging(ByVal sender As System.Object, ByVal e As QDistributoreSempliceRowChangeEvent) Handles Me.QDistributoreSempliceRowChanging

        End Sub

    End Class

    Partial Class ConsegneDataTable

        Private Sub ConsegneDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PIColumn.ColumnName) Then
                'Aggiungere qui il codice utente
            End If

        End Sub

    End Class

    Partial Class ImpostazioniDataTable

    End Class

End Class

Namespace ASDDBDataSetTableAdapters
    
    Partial Class QDistributoreTableAdapter

    End Class

    Partial Class QFattureGiroGiornoTableAdapter

    End Class

    Partial Class QControlloriTableAdapter

    End Class

    Partial Public Class ImpostazioniTableAdapter
    End Class
End Namespace
