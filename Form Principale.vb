Public Class Form1
    Public dvimpostazioni As DataView = New DataView '(Me.ASDDBDataSet.Impostazioni)
    Private FCurrentPage As BasePage

    ''' <summary>
    ''' Crea un'istanza della pagina in base al tipo specificato
    ''' e la visualizza nell'apposita area dedicata.
    ''' </summary>
    ''' <param name="Kind">La costante corrispondente al tipo di pagina.</param>
    Public Sub ShowPage(ByVal Kind As PageKind)

        ' Verifica che il tipo di pagina richiesto non corrisponda
        ' alla pagina attualmente visualizzata e, in caso affermativo,
        ' interrompe il processo di creazione di una nuova pagina.
        If Not (FCurrentPage Is Nothing) Then
            If FCurrentPage.GetKind = Kind Then
                Exit Sub
            End If
        End If

        ' Sospende le operazione legate all'organizzazione del 
        ' layout del pannello che ospiterà la nuova pagina
        PagePanel.SuspendLayout()

        Try

            ' Verifica se esiste una pagina già visualizzata
            If Not (FCurrentPage Is Nothing) Then

                ' Rimuove la pagina dall'insieme dei controlli
                ' ospitati all'interno del pannello contenitore
                PagePanel.Controls.Remove(FCurrentPage)

                ' Rilascia la memoria e le risorse eventualmente
                ' allocate per la pagina corrente
                FCurrentPage.Dispose()

                ' Rimuove il riferimento alla pagina corrente consentendo
                ' la distruzione dell'oggetto in caso di fallimento nella
                ' creazione della nuova pagina da visualizzare
                FCurrentPage = Nothing

                ' Invoca il Garbage Collector per coadiuvare la rimozione
                ' dalla memoria degli oggetti creati dalla pagina precedente,
                ' liberando quante più risorse possibili
                GC.Collect()

            End If

            ' Crea una nuova istanza della pagina richiesta
            FCurrentPage = PageFactory.CreateNew(Kind)

            ' Verifica che sia stata creata e restituita una nuova pagina
            If Not (FCurrentPage Is Nothing) Then

                ' Assegna alla pagina il controllo contenitore
                FCurrentPage.Parent = PagePanel

                ' Imposta lo stile di ancoraggio da utilizzare
                ' (la pagina si dimensiona automaticamente al contenitore)
                FCurrentPage.Dock = DockStyle.Fill

                ' Forza la visualizzazione del controllo della pagina
                FCurrentPage.Show()

                ' Acquisisce il titolo della pagina e 
                ' lo visualizza nell'apposita etichetta
                'ELIMINATO TitleLabel.Text = FCurrentPage.GetTitle()

            End If

        Finally

            ' Ripristina le operazioni sul layout del pannello contenitore
            PagePanel.ResumeLayout()

        End Try
    End Sub

    Private Sub UltraToolbarsManager1_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        Select Case e.Tool.Key
            Case "Accettazione"
                ShowPage(PageKind.TabellaAccettazione)

            Case "Classe"
                ShowPage(PageKind.TabellaClasse)

            Case "Dispencer"
                ShowPage(PageKind.TabellaDispencer)

            Case "Fascia d'età"
                ShowPage(PageKind.TabellaFasciadeta)

            Case "Fruizione fascia A"
                ShowPage(PageKind.TabellaFruizionefasciaa)

            Case "Giro"
                ShowPage(PageKind.TabellaGiro)

            Case "Quartiere"
                ShowPage(PageKind.TabellaQuartiere)

            Case "Tipologia PI"
                ShowPage(PageKind.TabellaTipologiapi)

            Case "Testate"
                ShowPage(PageKind.TabellaTestata)

                'Case "Pagamenti"
                '    ShowPage(PageKind.TabellaPagamenti)
            Case "Corrispettivi"
                ShowPage(PageKind.TabellaCorrispettivi)

            Case "Pagamenti extra"
                ShowPage(PageKind.TabellaPagamentiExtra)

            Case "Sigle corrispettivi"
                ShowPage(PageKind.TabellaSigleCorrispettivi)

            Case "Trasportatore x giro"
                ShowPage(PageKind.TrasportatoriPerGiro)

            Case "Trasportatori"
                ShowPage(PageKind.TabellaTrasportatori)

            Case "Impostazioni"
                ShowPage(PageKind.Impostazioni)

            Case "PI"
                ShowPage(PageKind.GestionePI)
                'Form_Gestione_PI.ShowDialog()

            Case "Codici Alternativi"
                ShowPage(PageKind.CodiciAlternativi)

            Case "Chiusure Extra"
                ShowPage(PageKind.ChiusureExtra)

            Case "Distribuzione Testata"
                'FormDistribuzione_Testata.ShowDialog()
                ShowPage(PageKind.DistribuzioneTestata)

            Case "Report Portatori"
                ShowPage(PageKind.ReportPortatori)

            Case "Report Giornaliero"
                ShowPage(PageKind.ReportGiornaliero)

            Case "Report Distributore"
                ShowPage(PageKind.ReportDistributore)

            Case "Stampa Editore"
                ShowPage(PageKind.StampaEditore)

            Case "Previsione Tiratura"
                ShowPage(PageKind.PrevisioneTiratura)

            Case "Dettaglio Giornaliero"
                ShowPage(PageKind.DettaglioGiornaliero)

            Case "Riepilogo Mensile"
                ShowPage(PageKind.RiepilogoMensile)

            Case "Consegne Giornaliere"
                ShowPage(PageKind.ConsegneGiornaliere)

            Case "Prefatture"
                ShowPage(PageKind.PreFatture)

            Case "Riepilogo Generale"
                ShowPage(PageKind.RiepilogoGenerale)

            Case "Test" 'test
                ShowPage(PageKind.UserControl1)

            Case "Distribuzione"
                ShowPage(PageKind.ControlloDistribuzione)
        End Select

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'ASDDBDataSet.Impostazioni'. È possibile spostarla o rimuoverla se necessario.
        Me.ImpostazioniTableAdapter.Fill(Me.ASDDBDataSet.Impostazioni)
        Me.Text = "ASD " & ASD2.My.Application.Info.Version.Major.ToString & "." & ASD2.My.Application.Info.Version.Minor.ToString & "." & ASD2.My.Application.Info.Version.Build.ToString & " (c) Northia Multimedia Solution 2007-" & Today.Year.ToString
        dvimpostazioni.Table = Me.ASDDBDataSet.Impostazioni
        'MsgBox("giorni in cui vengono evidenziati i nuovi PI " & dvimpostazioni.Item(0).Item(0))
        'MsgBox("totale delle consegne sull'intestazione " & dvimpostazioni.Item(0).Item(1))
        'MsgBox("stampa delle edicole " & dvimpostazioni.Item(0).Item(2))
        'MsgBox("colore delle righe dei nuovi PI " & dvimpostazioni.Item(0).Item(3))
        'MsgBox("stile " & dvimpostazioni.Item(0).Item(4))
        'MsgBox("numero seriale " & dvimpostazioni.Item(0).Item(5))
        'MsgBox("data scadenza " & dvimpostazioni.Item(0).Item(6))
        'MsgBox("numero licenze " & dvimpostazioni.Item(0).Item(7))

        ' Seleziona la pagina iniziale dell'applicazione
        ShowPage(PageKind.Startup)
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim chiusura As MsgBoxResult = MsgBox("Sei sicuro di voler uscire dal programma?", MsgBoxStyle.YesNo)
        If chiusura = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub PagePanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PagePanel.Paint

    End Sub
End Class
