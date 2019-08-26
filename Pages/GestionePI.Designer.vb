<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionePI
    Inherits ASD2.BasePage

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("PI", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipologia")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Classe")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RagioneSociale")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indirizzo")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCivico")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CAP")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Quartiere")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Telefono")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referente")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Giro")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percorrenza")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GiroAlternativo")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percorrenza Alternativa")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraLu")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraMa")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraMe")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraGi")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraVe")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraSa")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraDo")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Età")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fruizione")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dispencer")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Accettazione")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Note")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stato", 0)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ConditionValueAppearance1 As Infragistics.Win.ConditionValueAppearance = New Infragistics.Win.ConditionValueAppearance(New Infragistics.Win.ICondition() {CType(New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Equals, "Ok", True, GetType(String)), Infragistics.Win.ICondition), CType(New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Equals, "Errore", True, GetType(String)), Infragistics.Win.ICondition), CType(New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Equals, "Importata", True, GetType(String)), Infragistics.Win.ICondition)}, New Infragistics.Win.Appearance() {Appearance2, Appearance3, Appearance4})
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipologia")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Classe")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RagioneSociale")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Indirizzo")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NumeroCivico")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CAP")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Quartiere")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Telefono")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referente")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Giro")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percorrenza")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GiroAlternativo")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percorrenza Alternativa")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ChiusuraLu")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ChiusuraMa")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ChiusuraMe")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ChiusuraGi")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ChiusuraVe")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ChiusuraSa")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ChiusuraDo")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Età")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fruizione")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dispencer")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Accettazione")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Note")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tabella Tipologia", -1)
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipologia")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tabella Fruizione", -1)
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fruizione")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tabella Dispencer", -1)
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dispencer")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tabella Classe", -1)
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Classe")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tabella Quartiere", -1)
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Quartiere")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tabella Fascia d'età", -1)
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fascia d'età")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tabella Accettazione", -1)
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Accettazione")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tabella Giro", -1)
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Giro")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Note")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percorrenza")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("PI", -1)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PI", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipologia")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Classe")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RagioneSociale")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indirizzo")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCivico")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CAP")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Quartiere")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Telefono")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referente")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Giro")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percorrenza")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chiusura")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dispencer")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Accettazione")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Note")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DataInserimento")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DataModifica")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Attivo")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fruizione")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Età")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraLu")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraMa")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraMe")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraGi")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraVe")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraSa")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraDo")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GiroAlternativo")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percorrenza Alternativa")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PIPI Altri Dati")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PIDistribuzione")
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("PIPI Altri Dati", 0)
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PI")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sito")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Immagine")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Web_Mappa")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Web_X")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Web_Y")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SMS")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Extra")
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("PIDistribuzione", 0)
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Testata")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Distribuzione")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PI")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copie")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand13 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("PI", -1)
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PI")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipologia")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Classe")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RagioneSociale")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indirizzo")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCivico")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CAP")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Quartiere")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Telefono")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referente")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Giro")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percorrenza")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chiusura")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dispencer")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Accettazione")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Note")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DataInserimento")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DataModifica")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Attivo")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fruizione")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Età")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraLu")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraMa")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraMe")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraGi")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraVe")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraSa")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ChiusuraDo")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GiroAlternativo")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percorrenza Alternativa")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PIPI Altri Dati")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PIDistribuzione")
        Dim UltraGridBand14 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("PIPI Altri Dati", 0)
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PI")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sito")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Immagine")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Web_Mappa")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Web_X")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Web_Y")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SMS")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Extra")
        Dim UltraGridBand15 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("PIDistribuzione", 0)
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Testata")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Distribuzione")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PI")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copie")
        Dim ColScrollRegion1 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(1266)
        Dim ColScrollRegion2 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(-31)
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim RowScrollRegion1 As Infragistics.Win.UltraWinGrid.RowScrollRegion = New Infragistics.Win.UltraWinGrid.RowScrollRegion(0)
        Dim RowScrollRegion2 As Infragistics.Win.UltraWinGrid.RowScrollRegion = New Infragistics.Win.UltraWinGrid.RowScrollRegion(0)
        Dim RowScrollRegion3 As Infragistics.Win.UltraWinGrid.RowScrollRegion = New Infragistics.Win.UltraWinGrid.RowScrollRegion(0)
        Dim RowScrollRegion4 As Infragistics.Win.UltraWinGrid.RowScrollRegion = New Infragistics.Win.UltraWinGrid.RowScrollRegion(603)
        Dim RowScrollRegion5 As Infragistics.Win.UltraWinGrid.RowScrollRegion = New Infragistics.Win.UltraWinGrid.RowScrollRegion(-28)
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridExcel = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraButtonImporta = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonEsportaPDF = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonEsportaExcel = New Infragistics.Win.Misc.UltraButton()
        Me.UltraDropDownTipologia = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me.TabellaTipologiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASDDBDataSet = New ASD2.ASDDBDataSet()
        Me.UltraDropDownFruizione = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me.TabellaFruizioneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraDropDownDispencer = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me.TabellaDispencerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraDropDownClasse = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me.TabellaClasseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraDropDownQuartiere = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me.TabellaQuartiereBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraDropDownEtà = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me.TabellaFasciaDetàBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraDropDownAccettazione = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me.TabellaAccettazioneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraDropDownGiro = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me.TabellaGiroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraComboQuartiere = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraDropDownButton1 = New Infragistics.Win.Misc.UltraDropDownButton()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraFormattedTextEditor1 = New Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor()
        Me.UltraCheckEditor1 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraGridPI = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.PIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.PI = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGridDocumentExporter1 = New Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter(Me.components)
        Me.UltraGridExcelExporter1 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.UltraTabbedMdiManager1 = New Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager(Me.components)
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.PITableAdapter = New ASD2.ASDDBDataSetTableAdapters.PITableAdapter()
        Me.TableAdapterManager = New ASD2.ASDDBDataSetTableAdapters.TableAdapterManager()
        Me.Tabella_AccettazioneTableAdapter = New ASD2.ASDDBDataSetTableAdapters.Tabella_AccettazioneTableAdapter()
        Me.Tabella_ClasseTableAdapter = New ASD2.ASDDBDataSetTableAdapters.Tabella_ClasseTableAdapter()
        Me.Tabella_DispencerTableAdapter = New ASD2.ASDDBDataSetTableAdapters.Tabella_DispencerTableAdapter()
        Me.Tabella_Fascia_d_etàTableAdapter = New ASD2.ASDDBDataSetTableAdapters.Tabella_Fascia_d_etàTableAdapter()
        Me.Tabella_FruizioneTableAdapter = New ASD2.ASDDBDataSetTableAdapters.Tabella_FruizioneTableAdapter()
        Me.Tabella_GiroTableAdapter = New ASD2.ASDDBDataSetTableAdapters.Tabella_GiroTableAdapter()
        Me.Tabella_QuartiereTableAdapter = New ASD2.ASDDBDataSetTableAdapters.Tabella_QuartiereTableAdapter()
        Me.Tabella_TipologiaTableAdapter = New ASD2.ASDDBDataSetTableAdapters.Tabella_TipologiaTableAdapter()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGridExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownTipologia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabellaTipologiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASDDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownFruizione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabellaFruizioneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownDispencer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabellaDispencerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownClasse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabellaClasseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownQuartiere, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabellaQuartiereBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownEtà, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabellaFasciaDetàBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownAccettazione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabellaAccettazioneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownGiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabellaGiroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraComboQuartiere, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCheckEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridPI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.PI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGridExcel)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButtonImporta)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButtonEsportaPDF)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButtonEsportaExcel)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraDropDownTipologia)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraDropDownFruizione)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraDropDownDispencer)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraDropDownClasse)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraDropDownQuartiere)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraDropDownEtà)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraDropDownAccettazione)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraDropDownGiro)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraComboQuartiere)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraDropDownButton1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraFormattedTextEditor1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraCheckEditor1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGridPI)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1250, 701)
        '
        'UltraGridExcel
        '
        Me.UltraGridExcel.DataSource = Me.UltraDataSource1
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.UltraGridExcel.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 1
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn8.Header.VisiblePosition = 8
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn10.Header.VisiblePosition = 10
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn12.Header.VisiblePosition = 12
        UltraGridColumn13.Header.VisiblePosition = 13
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn15.Header.VisiblePosition = 15
        UltraGridColumn16.Header.VisiblePosition = 16
        UltraGridColumn17.Header.VisiblePosition = 17
        UltraGridColumn18.Header.VisiblePosition = 18
        UltraGridColumn19.Header.VisiblePosition = 19
        UltraGridColumn20.Header.VisiblePosition = 20
        UltraGridColumn21.Header.VisiblePosition = 21
        UltraGridColumn22.Header.VisiblePosition = 22
        UltraGridColumn23.Header.VisiblePosition = 23
        UltraGridColumn24.Header.VisiblePosition = 24
        UltraGridColumn25.Header.VisiblePosition = 25
        UltraGridColumn26.Header.VisiblePosition = 0
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        UltraGridColumn26.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26})
        Me.UltraGridExcel.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridExcel.DisplayLayout.InterBandSpacing = 10
        Me.UltraGridExcel.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridExcel.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.UltraGridExcel.DisplayLayout.Override.CardAreaAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.White
        Appearance6.TextHAlignAsString = "Left"
        Appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraGridExcel.DisplayLayout.Override.HeaderAppearance = Appearance6
        Appearance7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraGridExcel.DisplayLayout.Override.RowAppearance = Appearance7
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.UltraGridExcel.DisplayLayout.Override.RowSelectorAppearance = Appearance8
        Me.UltraGridExcel.DisplayLayout.Override.RowSelectorWidth = 12
        Me.UltraGridExcel.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.UltraGridExcel.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.UltraGridExcel.DisplayLayout.Override.SelectedRowAppearance = Appearance9
        Me.UltraGridExcel.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraGridExcel.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.UltraGridExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridExcel.Location = New System.Drawing.Point(3, 442)
        Me.UltraGridExcel.Name = "UltraGridExcel"
        Me.UltraGridExcel.Size = New System.Drawing.Size(1243, 133)
        Me.UltraGridExcel.TabIndex = 20
        Me.UltraGridExcel.Text = "PI Importati"
        Me.UltraGridExcel.Visible = False
        '
        'UltraDataSource1
        '
        UltraDataColumn36.DataType = GetType(Integer)
        UltraDataColumn38.DataType = GetType(Integer)
        UltraDataColumn39.DataType = GetType(Boolean)
        UltraDataColumn40.DataType = GetType(Boolean)
        UltraDataColumn41.DataType = GetType(Boolean)
        UltraDataColumn42.DataType = GetType(Boolean)
        UltraDataColumn43.DataType = GetType(Boolean)
        UltraDataColumn44.DataType = GetType(Boolean)
        UltraDataColumn45.DataType = GetType(Boolean)
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50})
        Me.UltraDataSource1.Band.Key = "PI"
        '
        'UltraButtonImporta
        '
        Me.UltraButtonImporta.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.UltraButtonImporta.Location = New System.Drawing.Point(306, 409)
        Me.UltraButtonImporta.Name = "UltraButtonImporta"
        Me.UltraButtonImporta.Size = New System.Drawing.Size(216, 23)
        Me.UltraButtonImporta.TabIndex = 19
        Me.UltraButtonImporta.Text = "Importa PI"
        '
        'UltraButtonEsportaPDF
        '
        Me.UltraButtonEsportaPDF.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.UltraButtonEsportaPDF.Location = New System.Drawing.Point(662, 666)
        Me.UltraButtonEsportaPDF.Name = "UltraButtonEsportaPDF"
        Me.UltraButtonEsportaPDF.Size = New System.Drawing.Size(215, 23)
        Me.UltraButtonEsportaPDF.TabIndex = 18
        Me.UltraButtonEsportaPDF.Text = "Esporta in PDF"
        '
        'UltraButtonEsportaExcel
        '
        Me.UltraButtonEsportaExcel.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.UltraButtonEsportaExcel.Location = New System.Drawing.Point(383, 666)
        Me.UltraButtonEsportaExcel.Name = "UltraButtonEsportaExcel"
        Me.UltraButtonEsportaExcel.Size = New System.Drawing.Size(216, 23)
        Me.UltraButtonEsportaExcel.TabIndex = 17
        Me.UltraButtonEsportaExcel.Text = "Esporta in Excel"
        '
        'UltraDropDownTipologia
        '
        Me.UltraDropDownTipologia.DataSource = Me.TabellaTipologiaBindingSource
        Appearance10.BackColor = System.Drawing.Color.White
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.UltraDropDownTipologia.DisplayLayout.Appearance = Appearance10
        UltraGridColumn27.Header.VisiblePosition = 0
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn27})
        Me.UltraDropDownTipologia.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraDropDownTipologia.DisplayLayout.InterBandSpacing = 10
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Me.UltraDropDownTipologia.DisplayLayout.Override.CardAreaAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance12.ForeColor = System.Drawing.Color.White
        Appearance12.TextHAlignAsString = "Left"
        Appearance12.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraDropDownTipologia.DisplayLayout.Override.HeaderAppearance = Appearance12
        Appearance13.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraDropDownTipologia.DisplayLayout.Override.RowAppearance = Appearance13
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance14.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.UltraDropDownTipologia.DisplayLayout.Override.RowSelectorAppearance = Appearance14
        Me.UltraDropDownTipologia.DisplayLayout.Override.RowSelectorWidth = 12
        Me.UltraDropDownTipologia.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Appearance15.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer))
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.ForeColor = System.Drawing.Color.Black
        Me.UltraDropDownTipologia.DisplayLayout.Override.SelectedRowAppearance = Appearance15
        Me.UltraDropDownTipologia.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraDropDownTipologia.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.UltraDropDownTipologia.DisplayMember = "Tipologia"
        Me.UltraDropDownTipologia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownTipologia.Location = New System.Drawing.Point(532, 580)
        Me.UltraDropDownTipologia.Name = "UltraDropDownTipologia"
        Me.UltraDropDownTipologia.Size = New System.Drawing.Size(125, 80)
        Me.UltraDropDownTipologia.TabIndex = 15
        Me.UltraDropDownTipologia.Text = "UltraDropDown1"
        Me.UltraDropDownTipologia.ValueMember = "Tipologia"
        Me.UltraDropDownTipologia.Visible = False
        '
        'TabellaTipologiaBindingSource
        '
        Me.TabellaTipologiaBindingSource.DataMember = "Tabella Tipologia"
        Me.TabellaTipologiaBindingSource.DataSource = Me.ASDDBDataSet
        '
        'ASDDBDataSet
        '
        Me.ASDDBDataSet.DataSetName = "ASDDBDataSet"
        Me.ASDDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraDropDownFruizione
        '
        Me.UltraDropDownFruizione.DataSource = Me.TabellaFruizioneBindingSource
        Appearance16.BackColor = System.Drawing.Color.White
        Appearance16.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.UltraDropDownFruizione.DisplayLayout.Appearance = Appearance16
        UltraGridColumn28.Header.VisiblePosition = 0
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn28})
        Me.UltraDropDownFruizione.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.UltraDropDownFruizione.DisplayLayout.InterBandSpacing = 10
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Me.UltraDropDownFruizione.DisplayLayout.Override.CardAreaAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance18.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance18.ForeColor = System.Drawing.Color.White
        Appearance18.TextHAlignAsString = "Left"
        Appearance18.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraDropDownFruizione.DisplayLayout.Override.HeaderAppearance = Appearance18
        Appearance19.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraDropDownFruizione.DisplayLayout.Override.RowAppearance = Appearance19
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance20.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.UltraDropDownFruizione.DisplayLayout.Override.RowSelectorAppearance = Appearance20
        Me.UltraDropDownFruizione.DisplayLayout.Override.RowSelectorWidth = 12
        Me.UltraDropDownFruizione.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance21.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Appearance21.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer))
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance21.ForeColor = System.Drawing.Color.Black
        Me.UltraDropDownFruizione.DisplayLayout.Override.SelectedRowAppearance = Appearance21
        Me.UltraDropDownFruizione.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraDropDownFruizione.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.UltraDropDownFruizione.DisplayMember = "Fruizione"
        Me.UltraDropDownFruizione.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownFruizione.Location = New System.Drawing.Point(663, 580)
        Me.UltraDropDownFruizione.Name = "UltraDropDownFruizione"
        Me.UltraDropDownFruizione.Size = New System.Drawing.Size(125, 80)
        Me.UltraDropDownFruizione.TabIndex = 14
        Me.UltraDropDownFruizione.Text = "UltraDropDown1"
        Me.UltraDropDownFruizione.ValueMember = "Fruizione"
        Me.UltraDropDownFruizione.Visible = False
        '
        'TabellaFruizioneBindingSource
        '
        Me.TabellaFruizioneBindingSource.DataMember = "Tabella Fruizione"
        Me.TabellaFruizioneBindingSource.DataSource = Me.ASDDBDataSet
        '
        'UltraDropDownDispencer
        '
        Me.UltraDropDownDispencer.DataSource = Me.TabellaDispencerBindingSource
        Appearance22.BackColor = System.Drawing.Color.White
        Appearance22.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.UltraDropDownDispencer.DisplayLayout.Appearance = Appearance22
        UltraGridColumn29.Header.VisiblePosition = 0
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn29})
        Me.UltraDropDownDispencer.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.UltraDropDownDispencer.DisplayLayout.InterBandSpacing = 10
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Me.UltraDropDownDispencer.DisplayLayout.Override.CardAreaAppearance = Appearance23
        Appearance24.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance24.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance24.ForeColor = System.Drawing.Color.White
        Appearance24.TextHAlignAsString = "Left"
        Appearance24.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraDropDownDispencer.DisplayLayout.Override.HeaderAppearance = Appearance24
        Appearance25.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraDropDownDispencer.DisplayLayout.Override.RowAppearance = Appearance25
        Appearance26.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance26.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.UltraDropDownDispencer.DisplayLayout.Override.RowSelectorAppearance = Appearance26
        Me.UltraDropDownDispencer.DisplayLayout.Override.RowSelectorWidth = 12
        Me.UltraDropDownDispencer.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance27.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Appearance27.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer))
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance27.ForeColor = System.Drawing.Color.Black
        Me.UltraDropDownDispencer.DisplayLayout.Override.SelectedRowAppearance = Appearance27
        Me.UltraDropDownDispencer.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraDropDownDispencer.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.UltraDropDownDispencer.DisplayMember = "Dispencer"
        Me.UltraDropDownDispencer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownDispencer.Location = New System.Drawing.Point(925, 580)
        Me.UltraDropDownDispencer.Name = "UltraDropDownDispencer"
        Me.UltraDropDownDispencer.Size = New System.Drawing.Size(125, 80)
        Me.UltraDropDownDispencer.TabIndex = 13
        Me.UltraDropDownDispencer.Text = "UltraDropDown1"
        Me.UltraDropDownDispencer.ValueMember = "Dispencer"
        Me.UltraDropDownDispencer.Visible = False
        '
        'TabellaDispencerBindingSource
        '
        Me.TabellaDispencerBindingSource.DataMember = "Tabella Dispencer"
        Me.TabellaDispencerBindingSource.DataSource = Me.ASDDBDataSet
        '
        'UltraDropDownClasse
        '
        Me.UltraDropDownClasse.DataSource = Me.TabellaClasseBindingSource
        Appearance28.BackColor = System.Drawing.Color.White
        Appearance28.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.UltraDropDownClasse.DisplayLayout.Appearance = Appearance28
        UltraGridColumn30.Header.VisiblePosition = 0
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn30})
        Me.UltraDropDownClasse.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.UltraDropDownClasse.DisplayLayout.InterBandSpacing = 10
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Me.UltraDropDownClasse.DisplayLayout.Override.CardAreaAppearance = Appearance29
        Appearance30.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance30.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance30.ForeColor = System.Drawing.Color.White
        Appearance30.TextHAlignAsString = "Left"
        Appearance30.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraDropDownClasse.DisplayLayout.Override.HeaderAppearance = Appearance30
        Appearance31.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraDropDownClasse.DisplayLayout.Override.RowAppearance = Appearance31
        Appearance32.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance32.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.UltraDropDownClasse.DisplayLayout.Override.RowSelectorAppearance = Appearance32
        Me.UltraDropDownClasse.DisplayLayout.Override.RowSelectorWidth = 12
        Me.UltraDropDownClasse.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance33.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Appearance33.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer))
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance33.ForeColor = System.Drawing.Color.Black
        Me.UltraDropDownClasse.DisplayLayout.Override.SelectedRowAppearance = Appearance33
        Me.UltraDropDownClasse.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraDropDownClasse.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.UltraDropDownClasse.DisplayMember = "Classe"
        Me.UltraDropDownClasse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownClasse.Location = New System.Drawing.Point(794, 580)
        Me.UltraDropDownClasse.Name = "UltraDropDownClasse"
        Me.UltraDropDownClasse.Size = New System.Drawing.Size(125, 80)
        Me.UltraDropDownClasse.TabIndex = 11
        Me.UltraDropDownClasse.Text = "UltraDropDown1"
        Me.UltraDropDownClasse.ValueMember = "Classe"
        Me.UltraDropDownClasse.Visible = False
        '
        'TabellaClasseBindingSource
        '
        Me.TabellaClasseBindingSource.DataMember = "Tabella Classe"
        Me.TabellaClasseBindingSource.DataSource = Me.ASDDBDataSet
        '
        'UltraDropDownQuartiere
        '
        Me.UltraDropDownQuartiere.DataSource = Me.TabellaQuartiereBindingSource
        Appearance34.BackColor = System.Drawing.Color.White
        Appearance34.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.UltraDropDownQuartiere.DisplayLayout.Appearance = Appearance34
        UltraGridColumn31.Header.VisiblePosition = 0
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn31})
        Me.UltraDropDownQuartiere.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.UltraDropDownQuartiere.DisplayLayout.InterBandSpacing = 10
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Me.UltraDropDownQuartiere.DisplayLayout.Override.CardAreaAppearance = Appearance35
        Appearance36.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance36.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance36.ForeColor = System.Drawing.Color.White
        Appearance36.TextHAlignAsString = "Left"
        Appearance36.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraDropDownQuartiere.DisplayLayout.Override.HeaderAppearance = Appearance36
        Appearance37.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraDropDownQuartiere.DisplayLayout.Override.RowAppearance = Appearance37
        Appearance38.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance38.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.UltraDropDownQuartiere.DisplayLayout.Override.RowSelectorAppearance = Appearance38
        Me.UltraDropDownQuartiere.DisplayLayout.Override.RowSelectorWidth = 12
        Me.UltraDropDownQuartiere.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance39.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Appearance39.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer))
        Appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance39.ForeColor = System.Drawing.Color.Black
        Me.UltraDropDownQuartiere.DisplayLayout.Override.SelectedRowAppearance = Appearance39
        Me.UltraDropDownQuartiere.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraDropDownQuartiere.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.UltraDropDownQuartiere.DisplayMember = "Quartiere"
        Me.UltraDropDownQuartiere.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownQuartiere.Location = New System.Drawing.Point(270, 580)
        Me.UltraDropDownQuartiere.Name = "UltraDropDownQuartiere"
        Me.UltraDropDownQuartiere.Size = New System.Drawing.Size(125, 80)
        Me.UltraDropDownQuartiere.TabIndex = 10
        Me.UltraDropDownQuartiere.Text = "UltraDropDown4"
        Me.UltraDropDownQuartiere.ValueMember = "Quartiere"
        Me.UltraDropDownQuartiere.Visible = False
        '
        'TabellaQuartiereBindingSource
        '
        Me.TabellaQuartiereBindingSource.DataMember = "Tabella Quartiere"
        Me.TabellaQuartiereBindingSource.DataSource = Me.ASDDBDataSet
        '
        'UltraDropDownEtà
        '
        Me.UltraDropDownEtà.DataSource = Me.TabellaFasciaDetàBindingSource
        Appearance40.BackColor = System.Drawing.Color.White
        Appearance40.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.UltraDropDownEtà.DisplayLayout.Appearance = Appearance40
        UltraGridColumn32.Header.VisiblePosition = 0
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn32})
        Me.UltraDropDownEtà.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.UltraDropDownEtà.DisplayLayout.InterBandSpacing = 10
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Me.UltraDropDownEtà.DisplayLayout.Override.CardAreaAppearance = Appearance41
        Appearance42.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance42.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance42.ForeColor = System.Drawing.Color.White
        Appearance42.TextHAlignAsString = "Left"
        Appearance42.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraDropDownEtà.DisplayLayout.Override.HeaderAppearance = Appearance42
        Appearance43.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraDropDownEtà.DisplayLayout.Override.RowAppearance = Appearance43
        Appearance44.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance44.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.UltraDropDownEtà.DisplayLayout.Override.RowSelectorAppearance = Appearance44
        Me.UltraDropDownEtà.DisplayLayout.Override.RowSelectorWidth = 12
        Me.UltraDropDownEtà.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance45.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Appearance45.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer))
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance45.ForeColor = System.Drawing.Color.Black
        Me.UltraDropDownEtà.DisplayLayout.Override.SelectedRowAppearance = Appearance45
        Me.UltraDropDownEtà.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraDropDownEtà.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.UltraDropDownEtà.DisplayMember = "Fascia d'età"
        Me.UltraDropDownEtà.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownEtà.Location = New System.Drawing.Point(139, 581)
        Me.UltraDropDownEtà.Name = "UltraDropDownEtà"
        Me.UltraDropDownEtà.Size = New System.Drawing.Size(125, 80)
        Me.UltraDropDownEtà.TabIndex = 9
        Me.UltraDropDownEtà.Text = "UltraDropDown3"
        Me.UltraDropDownEtà.ValueMember = "Fascia d'età"
        Me.UltraDropDownEtà.Visible = False
        '
        'TabellaFasciaDetàBindingSource
        '
        Me.TabellaFasciaDetàBindingSource.DataMember = "Tabella Fascia d'età"
        Me.TabellaFasciaDetàBindingSource.DataSource = Me.ASDDBDataSet
        '
        'UltraDropDownAccettazione
        '
        Me.UltraDropDownAccettazione.DataSource = Me.TabellaAccettazioneBindingSource
        Appearance46.BackColor = System.Drawing.Color.White
        Appearance46.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.UltraDropDownAccettazione.DisplayLayout.Appearance = Appearance46
        UltraGridColumn33.Header.VisiblePosition = 0
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn33})
        Me.UltraDropDownAccettazione.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.UltraDropDownAccettazione.DisplayLayout.InterBandSpacing = 10
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Me.UltraDropDownAccettazione.DisplayLayout.Override.CardAreaAppearance = Appearance47
        Appearance48.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance48.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance48.ForeColor = System.Drawing.Color.White
        Appearance48.TextHAlignAsString = "Left"
        Appearance48.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraDropDownAccettazione.DisplayLayout.Override.HeaderAppearance = Appearance48
        Appearance49.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraDropDownAccettazione.DisplayLayout.Override.RowAppearance = Appearance49
        Appearance50.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance50.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.UltraDropDownAccettazione.DisplayLayout.Override.RowSelectorAppearance = Appearance50
        Me.UltraDropDownAccettazione.DisplayLayout.Override.RowSelectorWidth = 12
        Me.UltraDropDownAccettazione.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance51.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Appearance51.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer))
        Appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance51.ForeColor = System.Drawing.Color.Black
        Me.UltraDropDownAccettazione.DisplayLayout.Override.SelectedRowAppearance = Appearance51
        Me.UltraDropDownAccettazione.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraDropDownAccettazione.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.UltraDropDownAccettazione.DisplayMember = "Accettazione"
        Me.UltraDropDownAccettazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownAccettazione.Location = New System.Drawing.Point(8, 581)
        Me.UltraDropDownAccettazione.Name = "UltraDropDownAccettazione"
        Me.UltraDropDownAccettazione.Size = New System.Drawing.Size(125, 80)
        Me.UltraDropDownAccettazione.TabIndex = 8
        Me.UltraDropDownAccettazione.Text = "UltraDropDown2"
        Me.UltraDropDownAccettazione.ValueMember = "Accettazione"
        Me.UltraDropDownAccettazione.Visible = False
        '
        'TabellaAccettazioneBindingSource
        '
        Me.TabellaAccettazioneBindingSource.DataMember = "Tabella Accettazione"
        Me.TabellaAccettazioneBindingSource.DataSource = Me.ASDDBDataSet
        '
        'UltraDropDownGiro
        '
        Me.UltraDropDownGiro.DataSource = Me.TabellaGiroBindingSource
        Appearance52.BackColor = System.Drawing.Color.White
        Appearance52.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.UltraDropDownGiro.DisplayLayout.Appearance = Appearance52
        UltraGridColumn34.Header.VisiblePosition = 0
        UltraGridColumn35.Header.VisiblePosition = 1
        UltraGridColumn36.Header.VisiblePosition = 2
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn34, UltraGridColumn35, UltraGridColumn36})
        Me.UltraDropDownGiro.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.UltraDropDownGiro.DisplayLayout.InterBandSpacing = 10
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Me.UltraDropDownGiro.DisplayLayout.Override.CardAreaAppearance = Appearance53
        Appearance54.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance54.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance54.ForeColor = System.Drawing.Color.White
        Appearance54.TextHAlignAsString = "Left"
        Appearance54.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraDropDownGiro.DisplayLayout.Override.HeaderAppearance = Appearance54
        Appearance55.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraDropDownGiro.DisplayLayout.Override.RowAppearance = Appearance55
        Appearance56.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance56.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.UltraDropDownGiro.DisplayLayout.Override.RowSelectorAppearance = Appearance56
        Me.UltraDropDownGiro.DisplayLayout.Override.RowSelectorWidth = 12
        Me.UltraDropDownGiro.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance57.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Appearance57.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer))
        Appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance57.ForeColor = System.Drawing.Color.Black
        Me.UltraDropDownGiro.DisplayLayout.Override.SelectedRowAppearance = Appearance57
        Me.UltraDropDownGiro.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraDropDownGiro.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.UltraDropDownGiro.DisplayMember = "Giro"
        Me.UltraDropDownGiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownGiro.Location = New System.Drawing.Point(401, 580)
        Me.UltraDropDownGiro.Name = "UltraDropDownGiro"
        Me.UltraDropDownGiro.Size = New System.Drawing.Size(125, 80)
        Me.UltraDropDownGiro.TabIndex = 7
        Me.UltraDropDownGiro.Text = "UltraDropDown1"
        Me.UltraDropDownGiro.ValueMember = "Giro"
        Me.UltraDropDownGiro.Visible = False
        '
        'TabellaGiroBindingSource
        '
        Me.TabellaGiroBindingSource.DataMember = "Tabella Giro"
        Me.TabellaGiroBindingSource.DataSource = Me.ASDDBDataSet
        '
        'UltraComboQuartiere
        '
        Me.UltraComboQuartiere.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.UltraComboQuartiere.DataSource = Me.TabellaQuartiereBindingSource
        Me.UltraComboQuartiere.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraComboQuartiere.Location = New System.Drawing.Point(152, 666)
        Me.UltraComboQuartiere.Name = "UltraComboQuartiere"
        Me.UltraComboQuartiere.Size = New System.Drawing.Size(144, 21)
        Me.UltraComboQuartiere.TabIndex = 6
        Me.UltraComboQuartiere.Text = "UltraComboEditor1"
        Me.UltraComboQuartiere.Visible = False
        '
        'UltraDropDownButton1
        '
        Me.UltraDropDownButton1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2007ScrollbarButton
        Me.UltraDropDownButton1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabellaGiroBindingSource, "Giro", True))
        Me.UltraDropDownButton1.Location = New System.Drawing.Point(2, 667)
        Me.UltraDropDownButton1.Name = "UltraDropDownButton1"
        Me.UltraDropDownButton1.Size = New System.Drawing.Size(144, 28)
        Me.UltraDropDownButton1.Style = Infragistics.Win.Misc.SplitButtonDisplayStyle.DropDownButtonOnly
        Me.UltraDropDownButton1.TabIndex = 5
        Me.UltraDropDownButton1.Text = "UltraDropDownButton1"
        Me.UltraDropDownButton1.Visible = False
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(80, 414)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(53, 23)
        Me.UltraLabel1.TabIndex = 4
        Me.UltraLabel1.Text = "Tipologia"
        Me.UltraLabel1.Visible = False
        '
        'UltraFormattedTextEditor1
        '
        Me.UltraFormattedTextEditor1.Location = New System.Drawing.Point(139, 411)
        Me.UltraFormattedTextEditor1.Name = "UltraFormattedTextEditor1"
        Me.UltraFormattedTextEditor1.Size = New System.Drawing.Size(161, 25)
        Me.UltraFormattedTextEditor1.TabIndex = 3
        Me.UltraFormattedTextEditor1.Value = "UltraFormattedTextEditor1"
        Me.UltraFormattedTextEditor1.Visible = False
        '
        'UltraCheckEditor1
        '
        Me.UltraCheckEditor1.Location = New System.Drawing.Point(3, 411)
        Me.UltraCheckEditor1.Name = "UltraCheckEditor1"
        Me.UltraCheckEditor1.Size = New System.Drawing.Size(71, 20)
        Me.UltraCheckEditor1.TabIndex = 2
        Me.UltraCheckEditor1.Text = "Attivo"
        Me.UltraCheckEditor1.Visible = False
        '
        'UltraGridPI
        '
        Me.UltraGridPI.DataSource = Me.PIBindingSource
        Me.UltraGridPI.DisplayLayout.AddNewBox.Hidden = False
        Appearance58.BackColor = System.Drawing.Color.White
        Appearance58.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.UltraGridPI.DisplayLayout.Appearance = Appearance58
        UltraGridBand10.AddButtonCaption = "Nuovo PI"
        UltraGridBand10.AddButtonToolTipText = "Aggiungi un nuovo PI"
        UltraGridColumn37.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        UltraGridColumn37.Header.VisiblePosition = 0
        UltraGridColumn37.LockedWidth = True
        UltraGridColumn37.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn37.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.Width = 41
        UltraGridColumn38.Header.VisiblePosition = 1
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn38.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn39.Header.VisiblePosition = 3
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn39.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn40.Header.VisiblePosition = 4
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn40.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn41.Header.VisiblePosition = 5
        UltraGridColumn41.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn41.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn41.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn41.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn42.Header.VisiblePosition = 6
        UltraGridColumn42.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn42.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn43.Header.VisiblePosition = 7
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn44.Header.VisiblePosition = 8
        UltraGridColumn44.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn44.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn44.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn44.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn44.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn45.Header.VisiblePosition = 9
        UltraGridColumn45.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn45.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn45.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn45.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn46.Header.VisiblePosition = 10
        UltraGridColumn46.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn46.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn46.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn46.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn47.Header.VisiblePosition = 11
        UltraGridColumn47.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn47.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn47.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn47.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn47.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn48.Header.VisiblePosition = 12
        UltraGridColumn48.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn48.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn48.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn48.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn49.Header.VisiblePosition = 13
        UltraGridColumn49.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn49.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn49.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn49.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn50.Header.Caption = "Dispenser"
        UltraGridColumn50.Header.VisiblePosition = 23
        UltraGridColumn50.RowLayoutColumnInfo.OriginX = 50
        UltraGridColumn50.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn50.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn50.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn50.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn51.Header.VisiblePosition = 24
        UltraGridColumn51.RowLayoutColumnInfo.OriginX = 52
        UltraGridColumn51.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn51.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn51.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn51.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn52.Header.VisiblePosition = 25
        UltraGridColumn52.RowLayoutColumnInfo.OriginX = 54
        UltraGridColumn52.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn52.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn52.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn53.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        UltraGridColumn53.Header.VisiblePosition = 26
        UltraGridColumn53.RowLayoutColumnInfo.OriginX = 56
        UltraGridColumn53.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn53.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn53.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn54.CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled
        UltraGridColumn54.Header.VisiblePosition = 27
        UltraGridColumn54.RowLayoutColumnInfo.OriginX = 58
        UltraGridColumn54.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn54.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn54.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn55.Header.VisiblePosition = 2
        UltraGridColumn55.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn55.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn55.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn55.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn56.Header.VisiblePosition = 22
        UltraGridColumn56.RowLayoutColumnInfo.OriginX = 48
        UltraGridColumn56.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn56.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn56.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn56.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn57.Header.VisiblePosition = 21
        UltraGridColumn57.RowLayoutColumnInfo.OriginX = 46
        UltraGridColumn57.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn57.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn57.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn57.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn58.Header.VisiblePosition = 14
        UltraGridColumn58.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn58.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn58.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn58.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn59.Header.VisiblePosition = 15
        UltraGridColumn59.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn59.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn59.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn59.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn60.Header.VisiblePosition = 16
        UltraGridColumn60.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn60.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn60.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn60.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn61.Header.VisiblePosition = 17
        UltraGridColumn61.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn61.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn61.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn61.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn62.Header.VisiblePosition = 18
        UltraGridColumn62.RowLayoutColumnInfo.OriginX = 40
        UltraGridColumn62.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn62.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn62.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn63.Header.VisiblePosition = 19
        UltraGridColumn63.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn63.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn63.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn63.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn64.Header.VisiblePosition = 20
        UltraGridColumn64.RowLayoutColumnInfo.OriginX = 44
        UltraGridColumn64.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn64.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn64.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn65.Header.VisiblePosition = 28
        UltraGridColumn65.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn65.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn65.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn65.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn65.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn66.Header.VisiblePosition = 29
        UltraGridColumn66.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn66.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn66.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn66.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn67.Header.VisiblePosition = 30
        UltraGridColumn68.Header.VisiblePosition = 31
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68})
        UltraGridBand10.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout
        UltraGridColumn69.Header.VisiblePosition = 0
        UltraGridColumn70.Header.VisiblePosition = 1
        UltraGridColumn71.Header.VisiblePosition = 2
        UltraGridColumn72.Header.VisiblePosition = 3
        UltraGridColumn73.Header.VisiblePosition = 4
        UltraGridColumn74.Header.VisiblePosition = 5
        UltraGridColumn75.Header.VisiblePosition = 6
        UltraGridColumn76.Header.VisiblePosition = 7
        UltraGridColumn77.Header.VisiblePosition = 8
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77})
        UltraGridColumn78.Header.VisiblePosition = 0
        UltraGridColumn79.Header.VisiblePosition = 1
        UltraGridColumn80.Header.VisiblePosition = 2
        UltraGridColumn81.Header.VisiblePosition = 3
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81})
        UltraGridBand12.Hidden = True
        Me.UltraGridPI.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.UltraGridPI.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Me.UltraGridPI.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Me.UltraGridPI.DisplayLayout.InterBandSpacing = 10
        Me.UltraGridPI.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridPI.DisplayLayout.MaxRowScrollRegions = 1
        Me.UltraGridPI.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridPI.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Me.UltraGridPI.DisplayLayout.Override.CardAreaAppearance = Appearance59
        Me.UltraGridPI.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridPI.DisplayLayout.Override.FilterEvaluationTrigger = Infragistics.Win.UltraWinGrid.FilterEvaluationTrigger.OnEnterKey
        Me.UltraGridPI.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.UltraGridPI.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance60.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance60.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance60.ForeColor = System.Drawing.Color.White
        Appearance60.TextHAlignAsString = "Left"
        Appearance60.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraGridPI.DisplayLayout.Override.HeaderAppearance = Appearance60
        Me.UltraGridPI.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance61.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraGridPI.DisplayLayout.Override.RowAppearance = Appearance61
        Appearance62.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance62.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance62.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.UltraGridPI.DisplayLayout.Override.RowSelectorAppearance = Appearance62
        Me.UltraGridPI.DisplayLayout.Override.RowSelectorWidth = 12
        Me.UltraGridPI.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance63.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Appearance63.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer))
        Appearance63.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance63.ForeColor = System.Drawing.Color.Black
        Me.UltraGridPI.DisplayLayout.Override.SelectedRowAppearance = Appearance63
        Me.UltraGridPI.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraGridPI.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.UltraGridPI.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridPI.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridPI.Location = New System.Drawing.Point(3, 3)
        Me.UltraGridPI.Name = "UltraGridPI"
        Me.UltraGridPI.Size = New System.Drawing.Size(1243, 402)
        Me.UltraGridPI.TabIndex = 0
        '
        'PIBindingSource
        '
        Me.PIBindingSource.DataMember = "PI"
        Me.PIBindingSource.DataSource = Me.ASDDBDataSet
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.PI)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1250, 701)
        '
        'PI
        '
        Me.PI.DataSource = Me.PIBindingSource
        Appearance64.BackColor = System.Drawing.Color.White
        Appearance64.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.PI.DisplayLayout.Appearance = Appearance64
        UltraGridBand13.CardView = True
        UltraGridColumn82.Header.VisiblePosition = 0
        UltraGridColumn83.Header.VisiblePosition = 2
        UltraGridColumn84.Header.VisiblePosition = 3
        UltraGridColumn85.Header.VisiblePosition = 4
        UltraGridColumn86.Header.VisiblePosition = 5
        UltraGridColumn87.Header.VisiblePosition = 6
        UltraGridColumn88.Header.VisiblePosition = 7
        UltraGridColumn89.Header.VisiblePosition = 8
        UltraGridColumn90.Header.VisiblePosition = 9
        UltraGridColumn91.Header.VisiblePosition = 10
        UltraGridColumn92.Header.VisiblePosition = 11
        UltraGridColumn93.Header.VisiblePosition = 12
        UltraGridColumn94.Header.VisiblePosition = 15
        UltraGridColumn95.Header.VisiblePosition = 25
        UltraGridColumn96.Header.VisiblePosition = 26
        UltraGridColumn97.Header.VisiblePosition = 27
        UltraGridColumn98.Header.VisiblePosition = 28
        UltraGridColumn99.Header.VisiblePosition = 29
        UltraGridColumn100.Header.VisiblePosition = 1
        UltraGridColumn101.Header.VisiblePosition = 24
        UltraGridColumn102.Header.VisiblePosition = 23
        UltraGridColumn103.Header.VisiblePosition = 16
        UltraGridColumn104.Header.VisiblePosition = 17
        UltraGridColumn105.Header.VisiblePosition = 18
        UltraGridColumn106.Header.VisiblePosition = 19
        UltraGridColumn107.Header.VisiblePosition = 20
        UltraGridColumn108.Header.VisiblePosition = 21
        UltraGridColumn109.Header.VisiblePosition = 22
        UltraGridColumn110.Header.VisiblePosition = 13
        UltraGridColumn111.Header.VisiblePosition = 14
        UltraGridColumn112.Header.VisiblePosition = 30
        UltraGridColumn113.Header.VisiblePosition = 31
        UltraGridBand13.Columns.AddRange(New Object() {UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113})
        UltraGridColumn114.Header.VisiblePosition = 0
        UltraGridColumn115.Header.VisiblePosition = 1
        UltraGridColumn116.Header.VisiblePosition = 2
        UltraGridColumn117.Header.VisiblePosition = 3
        UltraGridColumn118.Header.VisiblePosition = 4
        UltraGridColumn119.Header.VisiblePosition = 5
        UltraGridColumn120.Header.VisiblePosition = 6
        UltraGridColumn121.Header.VisiblePosition = 7
        UltraGridColumn122.Header.VisiblePosition = 8
        UltraGridBand14.Columns.AddRange(New Object() {UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122})
        UltraGridColumn123.Header.VisiblePosition = 0
        UltraGridColumn124.Header.VisiblePosition = 1
        UltraGridColumn125.Header.VisiblePosition = 2
        UltraGridColumn126.Header.VisiblePosition = 3
        UltraGridBand15.Columns.AddRange(New Object() {UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126})
        Me.PI.DisplayLayout.BandsSerializer.Add(UltraGridBand13)
        Me.PI.DisplayLayout.BandsSerializer.Add(UltraGridBand14)
        Me.PI.DisplayLayout.BandsSerializer.Add(UltraGridBand15)
        Me.PI.DisplayLayout.ColScrollRegions.Add(ColScrollRegion1)
        Me.PI.DisplayLayout.ColScrollRegions.Add(ColScrollRegion2)
        Me.PI.DisplayLayout.InterBandSpacing = 10
        Me.PI.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Appearance65.BackColor = System.Drawing.Color.Transparent
        Me.PI.DisplayLayout.Override.CardAreaAppearance = Appearance65
        Me.PI.DisplayLayout.Override.FilterEvaluationTrigger = Infragistics.Win.UltraWinGrid.FilterEvaluationTrigger.OnEnterKey
        Me.PI.DisplayLayout.Override.FilterOperandStyle = Infragistics.Win.UltraWinGrid.FilterOperandStyle.Edit
        Me.PI.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Appearance66.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance66.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance66.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance66.ForeColor = System.Drawing.Color.White
        Appearance66.TextHAlignAsString = "Left"
        Appearance66.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.PI.DisplayLayout.Override.HeaderAppearance = Appearance66
        Appearance67.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PI.DisplayLayout.Override.RowAppearance = Appearance67
        Appearance68.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance68.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance68.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.PI.DisplayLayout.Override.RowSelectorAppearance = Appearance68
        Me.PI.DisplayLayout.Override.RowSelectorWidth = 12
        Me.PI.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance69.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Appearance69.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer))
        Appearance69.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance69.ForeColor = System.Drawing.Color.Black
        Me.PI.DisplayLayout.Override.SelectedRowAppearance = Appearance69
        Me.PI.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PI.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        RowScrollRegion1.ScrollPosition = 0
        RowScrollRegion2.ScrollPosition = 0
        RowScrollRegion3.ScrollPosition = 0
        RowScrollRegion4.ScrollPosition = 0
        RowScrollRegion5.ScrollPosition = 0
        Me.PI.DisplayLayout.RowScrollRegions.Add(RowScrollRegion1)
        Me.PI.DisplayLayout.RowScrollRegions.Add(RowScrollRegion2)
        Me.PI.DisplayLayout.RowScrollRegions.Add(RowScrollRegion3)
        Me.PI.DisplayLayout.RowScrollRegions.Add(RowScrollRegion4)
        Me.PI.DisplayLayout.RowScrollRegions.Add(RowScrollRegion5)
        Me.PI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PI.Location = New System.Drawing.Point(3, 3)
        Me.PI.Name = "PI"
        Me.PI.Size = New System.Drawing.Size(1244, 655)
        Me.PI.TabIndex = 0
        Me.PI.Text = "PI Vista card"
        '
        'UltraGridDocumentExporter1
        '
        '
        'UltraGridExcelExporter1
        '
        '
        'UltraTabbedMdiManager1
        '
        Me.UltraTabbedMdiManager1.ViewStyle = Infragistics.Win.UltraWinTabbedMdi.ViewStyle.Office2007
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(1252, 724)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.UltraTabControl1.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Elenco"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Dettagli"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1250, 701)
        '
        'PITableAdapter
        '
        Me.PITableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlternativiTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChiusureTableAdapter = Nothing
        Me.TableAdapterManager.Codici_AlternativiTableAdapter = Nothing
        Me.TableAdapterManager.ConsegneTableAdapter = Nothing
        Me.TableAdapterManager.DateTableAdapter = Nothing
        Me.TableAdapterManager.DistribuzioneTableAdapter = Nothing
        Me.TableAdapterManager.EsclusioniTableAdapter = Nothing
        Me.TableAdapterManager.ImpostazioniTableAdapter = Nothing
        Me.TableAdapterManager.Note_PagamentiTableAdapter = Nothing
        Me.TableAdapterManager.PagamentiTableAdapter = Nothing
        Me.TableAdapterManager.PI_Altri_DatiTableAdapter = Nothing
        Me.TableAdapterManager.PITableAdapter = Me.PITableAdapter
        Me.TableAdapterManager.Tabella_AccettazioneTableAdapter = Me.Tabella_AccettazioneTableAdapter
        Me.TableAdapterManager.Tabella_ChiusuraTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_ClasseTableAdapter = Me.Tabella_ClasseTableAdapter
        Me.TableAdapterManager.Tabella_DispencerTableAdapter = Me.Tabella_DispencerTableAdapter
        Me.TableAdapterManager.Tabella_DistribuzioniTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_Fascia_d_etàTableAdapter = Me.Tabella_Fascia_d_etàTableAdapter
        Me.TableAdapterManager.Tabella_FruizioneTableAdapter = Me.Tabella_FruizioneTableAdapter
        Me.TableAdapterManager.Tabella_GiroTableAdapter = Me.Tabella_GiroTableAdapter
        Me.TableAdapterManager.Tabella_Privilegio_TestataTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_Privilegio_UtenteTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_QualitàTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_QuartiereTableAdapter = Me.Tabella_QuartiereTableAdapter
        Me.TableAdapterManager.Tabella_TipologiaTableAdapter = Me.Tabella_TipologiaTableAdapter
        Me.TableAdapterManager.TestateTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ASD2.ASDDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UtentiTableAdapter = Nothing
        Me.TableAdapterManager.VariazioniTableAdapter = Nothing
        '
        'Tabella_AccettazioneTableAdapter
        '
        Me.Tabella_AccettazioneTableAdapter.ClearBeforeFill = True
        '
        'Tabella_ClasseTableAdapter
        '
        Me.Tabella_ClasseTableAdapter.ClearBeforeFill = True
        '
        'Tabella_DispencerTableAdapter
        '
        Me.Tabella_DispencerTableAdapter.ClearBeforeFill = True
        '
        'Tabella_Fascia_d_etàTableAdapter
        '
        Me.Tabella_Fascia_d_etàTableAdapter.ClearBeforeFill = True
        '
        'Tabella_FruizioneTableAdapter
        '
        Me.Tabella_FruizioneTableAdapter.ClearBeforeFill = True
        '
        'Tabella_GiroTableAdapter
        '
        Me.Tabella_GiroTableAdapter.ClearBeforeFill = True
        '
        'Tabella_QuartiereTableAdapter
        '
        Me.Tabella_QuartiereTableAdapter.ClearBeforeFill = True
        '
        'Tabella_TipologiaTableAdapter
        '
        Me.Tabella_TipologiaTableAdapter.ClearBeforeFill = True
        '
        'GestionePI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Name = "GestionePI"
        Me.Size = New System.Drawing.Size(1252, 724)
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.UltraGridExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownTipologia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabellaTipologiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASDDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownFruizione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabellaFruizioneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownDispencer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabellaDispencerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownClasse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabellaClasseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownQuartiere, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabellaQuartiereBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownEtà, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabellaFasciaDetàBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownAccettazione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabellaAccettazioneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownGiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabellaGiroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraComboQuartiere, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCheckEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridPI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.PI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraButtonEsportaPDF As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonEsportaExcel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraDropDownTipologia As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents TabellaTipologiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASDDBDataSet As ASD2.ASDDBDataSet
    Friend WithEvents UltraDropDownFruizione As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents TabellaFruizioneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UltraDropDownDispencer As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents TabellaDispencerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UltraDropDownClasse As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents TabellaClasseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UltraDropDownQuartiere As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents TabellaQuartiereBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UltraDropDownEtà As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents TabellaFasciaDetàBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UltraDropDownAccettazione As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents TabellaAccettazioneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UltraDropDownGiro As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents TabellaGiroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UltraComboQuartiere As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraDropDownButton1 As Infragistics.Win.Misc.UltraDropDownButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraFormattedTextEditor1 As Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor
    Friend WithEvents UltraCheckEditor1 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraGridPI As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents PIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UltraGridDocumentExporter1 As Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter
    Friend WithEvents PITableAdapter As ASD2.ASDDBDataSetTableAdapters.PITableAdapter
    Friend WithEvents TableAdapterManager As ASD2.ASDDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tabella_AccettazioneTableAdapter As ASD2.ASDDBDataSetTableAdapters.Tabella_AccettazioneTableAdapter
    Friend WithEvents Tabella_ClasseTableAdapter As ASD2.ASDDBDataSetTableAdapters.Tabella_ClasseTableAdapter
    Friend WithEvents Tabella_DispencerTableAdapter As ASD2.ASDDBDataSetTableAdapters.Tabella_DispencerTableAdapter
    Friend WithEvents Tabella_Fascia_d_etàTableAdapter As ASD2.ASDDBDataSetTableAdapters.Tabella_Fascia_d_etàTableAdapter
    Friend WithEvents Tabella_FruizioneTableAdapter As ASD2.ASDDBDataSetTableAdapters.Tabella_FruizioneTableAdapter
    Friend WithEvents Tabella_GiroTableAdapter As ASD2.ASDDBDataSetTableAdapters.Tabella_GiroTableAdapter
    Friend WithEvents Tabella_QuartiereTableAdapter As ASD2.ASDDBDataSetTableAdapters.Tabella_QuartiereTableAdapter
    Friend WithEvents Tabella_TipologiaTableAdapter As ASD2.ASDDBDataSetTableAdapters.Tabella_TipologiaTableAdapter
    Friend WithEvents UltraGridExcelExporter1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents UltraTabbedMdiManager1 As Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents PI As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraButtonImporta As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGridExcel As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource

End Class
