''' <summary>
''' Elenca le costanti che rappresentano le singole pagine dell'applicazione;
''' esse vengono utilizzate per identificare una determinata pagina.
''' </summary>
''' <remarks>
''' Aggiungere e rimuovere costanti numeriche a piacimento quando si 
''' inseriscono o si cancellano pagine dal progetto dell'applicazione.
''' </remarks>
Public Enum PageKind

    ' TODO: 
    ' aggiungere/rimuovere istruzioni di creazione quando 
    ' nuove pagine vengono inserite/cancellate dal progetto!

    ' (nessuna pagina / pagina indefinita)
    Undefined = 0

    ' Pagina iniziale
    Startup = 1

    ' Tabella Accettazione
    TabellaAccettazione = 110

    ' Tabella Classe
    TabellaClasse = 111

    ' Tabella Dispencer
    TabellaDispencer = 112

    ' Tabella Fascia d'età
    TabellaFasciadeta = 113

    ' Tabella Fruizione Fascia A
    TabellaFruizionefasciaa = 114

    ' Tabella Giro
    TabellaGiro = 115

    ' Tabella Giro
    TabellaQuartiere = 116

    ' Tabella Giro
    TabellaTipologiapi = 117

    ' Tabella Testate
    TabellaTestata = 120

    ' Tabella Corrispettivi
    TabellaCorrispettivi = 121

    'Tabella Pagamenti Extra
    TabellaPagamentiExtra = 122

    ' Tabella Testate
    'TabellaPagamenti = 122

    ' Tabella Sigle Corrispettivi
    TabellaSigleCorrispettivi = 123

    ' Trasportatori x giro
    TrasportatoriPerGiro = 124

    ' Tabella Trasportatori
    TabellaTrasportatori = 125

    ' Impostazioni
    Impostazioni = 130

    ' Gestione PI
    GestionePI = 210

    ' Codici Alternativi
    CodiciAlternativi = 212

    ' Chiusure Extra
    ChiusureExtra = 213

    ' Distribuzione Testata
    DistribuzioneTestata = 310

    ' Report Portatori
    ReportPortatori = 311

    ' Report Portatori
    ReportGiornaliero = 312

    ' Report Distributore
    ReportDistributore = 313

    ' Stampa Editore
    StampaEditore = 322

    ' Previsione Tiratura
    PrevisioneTiratura = 330

    ' Dettaglio Giornaliero
    DettaglioGiornaliero = 410

    ' Riepilogo Mensile
    RiepilogoMensile = 412

    ' Consegne Giornaliere
    ConsegneGiornaliere = 420

    ' Pre fatture
    PreFatture = 421

    ' Ripilogo Generale
    RiepilogoGenerale = 422

    ' Controllo Distribuzione
    ControlloDistribuzione = 510

    ' Test
    UserControl1 = 999

End Enum

''' <summary>
''' Consente di creare nuove pagine da visualizzare nell'applicazione.
''' </summary>
''' <remarks>
''' La classe non può essere ereditata.
''' </remarks>
Public NotInheritable Class PageFactory

    ''' <summary>
    ''' Crea una nuova pagina selezionando la classe in base al
    ''' tipo di pagina specificato come parametro.
    ''' </summary>
    ''' <param name="Kind">
    ''' Indica il tipo di pagina da creare.
    ''' </param>
    ''' <returns>
    ''' L'istanza della classe corrispondente alla pagina richiesta
    ''' </returns>
    ''' <remarks>
    ''' Aggiungere le istruzioni necessarie alla creazione delle pagine
    ''' richieste nell'applicazione e aggiornare il metodo ogni volta
    ''' che si aggiungono o si rimuovono pagine dal progetto.
    ''' </remarks>
    Public Shared Function CreateNew(ByVal Kind As PageKind) As BasePage

        ' TODO: 
        ' aggiungere/rimuovere istruzioni di creazione quando 
        ' nuove pagine vengono inserite/cancellate dal progetto!

        Select Case Kind
            Case PageKind.Startup
                Return New StartupPage()
            Case PageKind.TabellaAccettazione
                Return New TabellaAccettazione()
            Case PageKind.TabellaClasse
                Return New TabellaClasse()
            Case PageKind.TabellaDispencer
                Return New TabellaDispencer()
            Case PageKind.TabellaFasciadeta
                Return New TabellaFasciadeta()
            Case PageKind.TabellaFruizionefasciaa
                Return New TabellaFruizionefasciaa()
            Case PageKind.TabellaGiro
                Return New TabellaGiro()
            Case PageKind.TabellaQuartiere
                Return New TabellaQuartiere()
            Case PageKind.TabellaTipologiapi
                Return New TabellaTipologiapi()
            Case PageKind.TabellaTestata
                Return New TabellaTestata()
            Case PageKind.TabellaCorrispettivi
                Return New TabellaCorrispettivi()
            Case PageKind.TabellaPagamentiExtra
                Return New TabellaPagamentiExtra()
                'Case PageKind.TabellaPagamenti
                '    Return New TabellaPagamenti()
            Case PageKind.TabellaSigleCorrispettivi
                Return New TabellaSigleCorrispettivi()
            Case PageKind.TrasportatoriPerGiro
                Return New TrasportatoriPerGiro()
            Case PageKind.TabellaTrasportatori
                Return New TabellaTrasportatori()
            Case PageKind.Impostazioni
                Return New Impostazioni()
            Case PageKind.GestionePI
                Return New GestionePI()
            Case PageKind.CodiciAlternativi
                Return New CodiciAlternativi()
            Case PageKind.ChiusureExtra
                Return New ChiusureExtra
            Case PageKind.DistribuzioneTestata
                Return New DistribuzioneTestata
            Case PageKind.ReportPortatori
                Return New ReportPortatori()
            Case PageKind.ReportGiornaliero
                Return New ReportGiornaliero()
            Case PageKind.ReportDistributore
                Return New ReportDistributore()
            Case PageKind.StampaEditore
                Return New StampaEditore()
            Case PageKind.PrevisioneTiratura
                Return New PrevisioneTiratura()
            Case PageKind.DettaglioGiornaliero
                Return New DettaglioGiornaliero()
            Case PageKind.RiepilogoMensile
                Return New RiepilogoMensile()
            Case PageKind.ConsegneGiornaliere
                Return New ConsegneGiornaliere()
            Case PageKind.PreFatture
                Return New PreFatture()
            Case PageKind.RiepilogoGenerale
                Return New RiepilogoGenerale()
            Case PageKind.UserControl1
                Return New UserControl1()
            Case PageKind.ControlloDistribuzione
                Return New ControlloDistribuzione()
            Case PageKind.Undefined
                Return Nothing
            Case Else
                Return Nothing
        End Select

    End Function

End Class
