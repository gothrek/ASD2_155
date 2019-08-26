Public Class TrasportatoriPerGiro

    Dim dtTrasportatoriPergiro As New DataTable("Trasportatori per giro")
    Dim dvTrasportatoriPerGiro As New DataView
    Dim dtGiri As New DataTable("Giri")
    Dim dvGiri As DataView = New DataView
    Dim trasportatorePrecedente As String = ""

    Private Sub TrasportatoriPerGiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tabella_TrasportatoriTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Trasportatori)
        Me.Trasportatori_presenzeTableAdapter.Fill(Me.ASDDBDataSet.Trasportatori_presenze)
        Me.Tabella_GiroTableAdapter.Fill(Me.ASDDBDataSet.Tabella_Giro)

        dtGiri = Me.Tabella_GiroTableAdapter.GetData()
        dvGiri.Table = dtGiri

        UltraDateTimeEditorMeseAnno.Value = Today

        CaricaDati()
    End Sub

    Private Sub UltraDateTimeEditorMeseAnno_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraDateTimeEditorMeseAnno.ValueChanged
        CaricaDati()
    End Sub

    Private Sub CaricaDati()
        Dim data As Date = UltraDateTimeEditorMeseAnno.Value
        Dim riga As DataRow = dtTrasportatoriPergiro.NewRow
        Dim posizioneGiroTrasportatore As Integer = 0

        Dim trovato As Boolean = False

        'Dim primoGiorno As Date = "#01/" & data.Month & "/" & data.Year & "#"
        'Dim ultimoGiorno As Date = "#" & Date.DaysInMonth(data.Year, data.Month) & "/" & data.Month & "/" & data.Year & "#"

        dtTrasportatoriPergiro = Me.Trasportatori_presenzeTableAdapter.GetDataByGiorno(UltraDateTimeEditorMeseAnno.Value)
        dvTrasportatoriPerGiro.Table = dtTrasportatoriPergiro
        dvTrasportatoriPerGiro.Sort = "Giro ASC"
        'dtTrasportatoriPergiro.Columns.Clear()
        'dtTrasportatoriPergiro.Columns.Add("Giro", Type.GetType("System.String"))

        'For i As Integer = 1 To ultimoGiorno.Day
        'dtTrasportatoriPergiro.Columns.Add(i, Type.GetType("System.String"))
        If dtTrasportatoriPergiro.Rows.Count = 0 Then
            For j As Integer = 0 To dtGiri.Rows.Count - 1
                trovato = False
                posizioneGiroTrasportatore = 0

                Do
                    If UltraDropDownTrasportatore.Rows(posizioneGiroTrasportatore).Cells("Giro predefinito").Value = dtGiri.Rows(j).Item("Giro") Then
                        riga = dtTrasportatoriPergiro.NewRow

                        riga.Item(0) = UltraDropDownTrasportatore.Rows(posizioneGiroTrasportatore).Cells("Trasportatore").Value
                        riga.Item(1) = dtGiri.Rows(j).Item("Giro")
                        riga.Item(2) = UltraDateTimeEditorMeseAnno.Value
                        riga.Item(3) = ""
                        riga.Item(4) = ""
                        riga.Item(5) = ""
                        riga.Item(6) = 0
                        riga.Item(7) = 0
                        riga.Item(8) = 0
                        riga.Item(9) = 0
                        riga.Item(10) = 0
                        riga.Item(11) = False
                        riga.Item(12) = Today
                        dtTrasportatoriPergiro.Rows.Add(riga)
                        trovato = True
                    Else
                        posizioneGiroTrasportatore = posizioneGiroTrasportatore + 1
                    End If
                Loop Until (posizioneGiroTrasportatore = UltraDropDownTrasportatore.Rows.Count) Or trovato
                UltraLabelAvviso.Appearance.ForeColor = Color.Green
                UltraLabelAvviso.Text = "Dati non presenti!!"

            Next
            'Next
        Else
            UltraLabelAvviso.Appearance.ForeColor = Color.Red
            UltraLabelAvviso.Text = "ATTENZIONE!! Dati pre-esistenti!!"
        End If

        UltraGridTrasportatoriPerGiro.DataSource = dvTrasportatoriPerGiro


    End Sub

    Private Sub UltraGridTrasportatoriPerGiro_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridTrasportatoriPerGiro.InitializeLayout
        'Try
        '    For i As Integer = 1 To 31
        '        e.Layout.Bands(0).Columns(i).ValueList = UltraDropDownTrasportatore
        '    Next
        'Catch ex As Exception

        'End Try
        Try
            e.Layout.Bands(0).Columns("Trasportatore").ValueList = UltraDropDownTrasportatore
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UltraButtonSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSalva.Click
        Dim contaInserimenti As Integer = 0
        Dim contaAggiornamenti As Integer = 0

        If MsgBox("ATTENZIONE!!Tutti i precedenti dati relativamente al " & UltraDateTimeEditorMeseAnno.Value & " verranno cancellati! Continuare?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Trasportatori_presenzeTableAdapter.DeleteQueryGiorno(UltraDateTimeEditorMeseAnno.Value)

            For i As Integer = 0 To dtTrasportatoriPergiro.Rows.Count - 1
                Try
                    Me.Trasportatori_presenzeTableAdapter.Insert(dtTrasportatoriPergiro.Rows(i).Item("Trasportatore"), dtTrasportatoriPergiro.Rows(i).Item("Giro"), dtTrasportatoriPergiro.Rows(i).Item("Giorno"),
                                                                 dtTrasportatoriPergiro.Rows(i).Item("Note"), dtTrasportatoriPergiro.Rows(i).Item("Campo aggiuntivo1"), dtTrasportatoriPergiro.Rows(i).Item("Campo aggiuntivo2"),
                                                                 dtTrasportatoriPergiro.Rows(i).Item("Campo aggiuntivo3"), dtTrasportatoriPergiro.Rows(i).Item("Campo aggiuntivo4"), dtTrasportatoriPergiro.Rows(i).Item("Campo aggiuntivo5"),
                                                                 dtTrasportatoriPergiro.Rows(i).Item("Campo aggiuntivo6"), dtTrasportatoriPergiro.Rows(i).Item("Campo aggiuntivo7"), dtTrasportatoriPergiro.Rows(i).Item("Campo aggiuntivo8"),
                                                                 dtTrasportatoriPergiro.Rows(i).Item("Campo aggiuntivo9"))
                    contaInserimenti = contaInserimenti + 1
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
            MsgBox("Dati salvati correttamente!!!", MsgBoxStyle.Information)
        Else


        End If
    End Sub

    Private Sub TrasportatoriPerGiro_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        Me.Validate()
        Me.Trasportatori_presenzeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)
    End Sub
End Class
