<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsegneGiornaliere
    Inherits ASD2.BasePage

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DataTableConsegneGiornaliere", -1)
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Giorno")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trasportatore")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sigla corrispettivo")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importo")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Totale")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SommaDiConsegne")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Giro", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, True)
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "Totale", 4, True, "DataTableConsegneGiornaliere", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Totale", 4, True)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "SommaDiConsegne", 5, True, "DataTableConsegneGiornaliere", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "SommaDiConsegne", 5, True)
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tabella Trasportatori", -1)
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trasportatore")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Giro predefinito")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominazione")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Partita iva")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indirizzo")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CAP")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Città")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Note")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tabella Pagamenti Extra", -1)
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descrizione")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importo")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Note")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo1")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo2")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo3")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo4")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo5")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo6")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo7")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo8")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo9")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sigla corrispettivo")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Trasportatori pagamenti extra", -1)
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trasportatore")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sigla corrispettivo")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descrizione corrispettivo")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importo corrispettivo")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Quantità")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Note")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo1")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo2")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo3")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo4")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo5")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo6")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo7")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo8")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo9")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.DataTableConsegneGiornaliereBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASDDBDataSet = New ASD2.ASDDBDataSet()
        Me.Tabella_TrasportatoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraGroupBoxSelezione = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabelTrasportatore = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraComboTrasportatore = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabelMeseAnno = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraButtonCarica = New Infragistics.Win.Misc.UltraButton()
        Me.UltraDateTimeEditorMeseAnno = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.ConsegneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsegneTableAdapter = New ASD2.ASDDBDataSetTableAdapters.ConsegneTableAdapter()
        Me.TableAdapterManager = New ASD2.ASDDBDataSetTableAdapters.TableAdapterManager()
        Me.PITableAdapter = New ASD2.ASDDBDataSetTableAdapters.PITableAdapter()
        Me.Tabella_CorrispettiviTableAdapter = New ASD2.ASDDBDataSetTableAdapters.Tabella_CorrispettiviTableAdapter()
        Me.Tabella_TrasportatoriTableAdapter = New ASD2.ASDDBDataSetTableAdapters.Tabella_TrasportatoriTableAdapter()
        Me.Trasportatori_presenzeTableAdapter = New ASD2.ASDDBDataSetTableAdapters.Trasportatori_presenzeTableAdapter()
        Me.PIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tabella_CorrispettiviBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Trasportatori_presenzeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QConsegneGiornaliereBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QConsegneGiornaliereTableAdapter = New ASD2.ASDDBDataSetTableAdapters.QConsegneGiornaliereTableAdapter()
        Me.DataTableConsegneGiornaliereTableAdapter = New ASD2.ASDDBDataSetTableAdapters.DataTableConsegneGiornaliereTableAdapter()
        Me.UltraGroupBoxExtra = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraButtonElimina = New Infragistics.Win.Misc.UltraButton()
        Me.UltraNumericEditorQuantita = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabelQuantita = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabelExtra = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraComboExtra = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Tabella_Pagamenti_ExtraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraLabelData = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraButtonAggiungi = New Infragistics.Win.Misc.UltraButton()
        Me.UltraDateTimeEditorData = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraGridExtra = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Trasportatori_pagamenti_extraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Trasportatori_pagamenti_extraTableAdapter = New ASD2.ASDDBDataSetTableAdapters.Trasportatori_pagamenti_extraTableAdapter()
        Me.Tabella_Pagamenti_ExtraTableAdapter = New ASD2.ASDDBDataSetTableAdapters.Tabella_Pagamenti_ExtraTableAdapter()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTableConsegneGiornaliereBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASDDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabella_TrasportatoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBoxSelezione, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxSelezione.SuspendLayout()
        CType(Me.UltraComboTrasportatore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditorMeseAnno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsegneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabella_CorrispettiviBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trasportatori_presenzeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QConsegneGiornaliereBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBoxExtra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxExtra.SuspendLayout()
        CType(Me.UltraNumericEditorQuantita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraComboExtra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabella_Pagamenti_ExtraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditorData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridExtra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trasportatori_pagamenti_extraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGrid1
        '
        Me.UltraGrid1.DataSource = Me.DataTableConsegneGiornaliereBindingSource
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGrid1.DisplayLayout.Appearance = Appearance1
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn16.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn16.Header.VisiblePosition = 1
        UltraGridColumn16.Hidden = True
        UltraGridColumn71.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn71.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn71.Header.VisiblePosition = 0
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn72.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn72.Header.VisiblePosition = 2
        UltraGridColumn73.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn73.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn73.Header.VisiblePosition = 3
        UltraGridColumn74.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn74.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn74.Header.VisiblePosition = 5
        UltraGridColumn74.Width = 100
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn9.Header.VisiblePosition = 4
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 6
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn16, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn9, UltraGridColumn1})
        SummarySettings1.DisplayFormat = "Somma = {0}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance2
        SummarySettings2.DisplayFormat = "Somma = {0}"
        SummarySettings2.GroupBySummaryValueAppearance = Appearance3
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1, SummarySettings2})
        UltraGridBand1.SummaryFooterCaption = "Totale"
        Me.UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance4.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance4.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGrid1.DisplayLayout.GroupByBox.Appearance = Appearance4
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance5
        Me.UltraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance6.BackColor2 = System.Drawing.SystemColors.Control
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGrid1.DisplayLayout.GroupByBox.PromptAppearance = Appearance6
        Me.UltraGrid1.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGrid1.DisplayLayout.MaxRowScrollRegions = 1
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Appearance7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGrid1.DisplayLayout.Override.ActiveCellAppearance = Appearance7
        Appearance8.BackColor = System.Drawing.SystemColors.Highlight
        Appearance8.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGrid1.DisplayLayout.Override.ActiveRowAppearance = Appearance8
        Me.UltraGrid1.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.SingleSummaryBasedOnDataType
        Me.UltraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance9.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGrid1.DisplayLayout.Override.CardAreaAppearance = Appearance9
        Appearance10.BorderColor = System.Drawing.Color.Silver
        Appearance10.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGrid1.DisplayLayout.Override.CellAppearance = Appearance10
        Me.UltraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGrid1.DisplayLayout.Override.CellPadding = 0
        Appearance11.BackColor = System.Drawing.SystemColors.Control
        Appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance11.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance11.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGrid1.DisplayLayout.Override.GroupByRowAppearance = Appearance11
        Appearance12.TextHAlignAsString = "Left"
        Me.UltraGrid1.DisplayLayout.Override.HeaderAppearance = Appearance12
        Me.UltraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.Color.Silver
        Me.UltraGrid1.DisplayLayout.Override.RowAppearance = Appearance13
        Me.UltraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance14
        Me.UltraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGrid1.Location = New System.Drawing.Point(3, 71)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(468, 408)
        Me.UltraGrid1.TabIndex = 0
        Me.UltraGrid1.Text = "UltraGrid1"
        '
        'DataTableConsegneGiornaliereBindingSource
        '
        Me.DataTableConsegneGiornaliereBindingSource.DataMember = "DataTableConsegneGiornaliere"
        Me.DataTableConsegneGiornaliereBindingSource.DataSource = Me.ASDDBDataSet
        '
        'ASDDBDataSet
        '
        Me.ASDDBDataSet.DataSetName = "ASDDBDataSet"
        Me.ASDDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tabella_TrasportatoriBindingSource
        '
        Me.Tabella_TrasportatoriBindingSource.DataMember = "Tabella Trasportatori"
        Me.Tabella_TrasportatoriBindingSource.DataSource = Me.ASDDBDataSet
        '
        'UltraGroupBoxSelezione
        '
        Me.UltraGroupBoxSelezione.Controls.Add(Me.UltraLabelTrasportatore)
        Me.UltraGroupBoxSelezione.Controls.Add(Me.UltraComboTrasportatore)
        Me.UltraGroupBoxSelezione.Controls.Add(Me.UltraLabelMeseAnno)
        Me.UltraGroupBoxSelezione.Controls.Add(Me.UltraButtonCarica)
        Me.UltraGroupBoxSelezione.Controls.Add(Me.UltraDateTimeEditorMeseAnno)
        Me.UltraGroupBoxSelezione.Location = New System.Drawing.Point(3, 3)
        Me.UltraGroupBoxSelezione.Name = "UltraGroupBoxSelezione"
        Me.UltraGroupBoxSelezione.Size = New System.Drawing.Size(468, 66)
        Me.UltraGroupBoxSelezione.TabIndex = 1
        Me.UltraGroupBoxSelezione.Text = "Selezione"
        Me.UltraGroupBoxSelezione.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabelTrasportatore
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabelTrasportatore.Appearance = Appearance15
        Me.UltraLabelTrasportatore.AutoSize = True
        Me.UltraLabelTrasportatore.Location = New System.Drawing.Point(87, 19)
        Me.UltraLabelTrasportatore.Name = "UltraLabelTrasportatore"
        Me.UltraLabelTrasportatore.Size = New System.Drawing.Size(72, 14)
        Me.UltraLabelTrasportatore.TabIndex = 6
        Me.UltraLabelTrasportatore.Text = "Trasportatore"
        '
        'UltraComboTrasportatore
        '
        Me.UltraComboTrasportatore.DataSource = Me.Tabella_TrasportatoriBindingSource
        Appearance16.BackColor = System.Drawing.SystemColors.Window
        Appearance16.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraComboTrasportatore.DisplayLayout.Appearance = Appearance16
        UltraGridColumn25.Header.VisiblePosition = 0
        UltraGridColumn26.Header.VisiblePosition = 1
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 2
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 3
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 4
        UltraGridColumn29.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 5
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 6
        UltraGridColumn32.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 7
        UltraGridColumn48.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn31, UltraGridColumn32, UltraGridColumn48})
        Me.UltraComboTrasportatore.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraComboTrasportatore.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraComboTrasportatore.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance17.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance17.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance17.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboTrasportatore.DisplayLayout.GroupByBox.Appearance = Appearance17
        Appearance18.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboTrasportatore.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance18
        Me.UltraComboTrasportatore.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance19.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance19.BackColor2 = System.Drawing.SystemColors.Control
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance19.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboTrasportatore.DisplayLayout.GroupByBox.PromptAppearance = Appearance19
        Me.UltraComboTrasportatore.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraComboTrasportatore.DisplayLayout.MaxRowScrollRegions = 1
        Appearance20.BackColor = System.Drawing.SystemColors.Window
        Appearance20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraComboTrasportatore.DisplayLayout.Override.ActiveCellAppearance = Appearance20
        Appearance21.BackColor = System.Drawing.SystemColors.Highlight
        Appearance21.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraComboTrasportatore.DisplayLayout.Override.ActiveRowAppearance = Appearance21
        Me.UltraComboTrasportatore.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraComboTrasportatore.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance22.BackColor = System.Drawing.SystemColors.Window
        Me.UltraComboTrasportatore.DisplayLayout.Override.CardAreaAppearance = Appearance22
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Appearance23.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraComboTrasportatore.DisplayLayout.Override.CellAppearance = Appearance23
        Me.UltraComboTrasportatore.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraComboTrasportatore.DisplayLayout.Override.CellPadding = 0
        Appearance24.BackColor = System.Drawing.SystemColors.Control
        Appearance24.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance24.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance24.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboTrasportatore.DisplayLayout.Override.GroupByRowAppearance = Appearance24
        Appearance25.TextHAlignAsString = "Left"
        Me.UltraComboTrasportatore.DisplayLayout.Override.HeaderAppearance = Appearance25
        Me.UltraComboTrasportatore.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraComboTrasportatore.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance26.BackColor = System.Drawing.SystemColors.Window
        Appearance26.BorderColor = System.Drawing.Color.Silver
        Me.UltraComboTrasportatore.DisplayLayout.Override.RowAppearance = Appearance26
        Me.UltraComboTrasportatore.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance27.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraComboTrasportatore.DisplayLayout.Override.TemplateAddRowAppearance = Appearance27
        Me.UltraComboTrasportatore.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraComboTrasportatore.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraComboTrasportatore.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraComboTrasportatore.DisplayMember = "Trasportatore"
        Me.UltraComboTrasportatore.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraComboTrasportatore.Location = New System.Drawing.Point(87, 39)
        Me.UltraComboTrasportatore.Name = "UltraComboTrasportatore"
        Me.UltraComboTrasportatore.Size = New System.Drawing.Size(226, 22)
        Me.UltraComboTrasportatore.TabIndex = 5
        Me.UltraComboTrasportatore.Text = "Seleziona il trasportatore"
        Me.UltraComboTrasportatore.ValueMember = "Trasportatore"
        '
        'UltraLabelMeseAnno
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabelMeseAnno.Appearance = Appearance28
        Me.UltraLabelMeseAnno.AutoSize = True
        Me.UltraLabelMeseAnno.Location = New System.Drawing.Point(6, 19)
        Me.UltraLabelMeseAnno.Name = "UltraLabelMeseAnno"
        Me.UltraLabelMeseAnno.Size = New System.Drawing.Size(60, 14)
        Me.UltraLabelMeseAnno.TabIndex = 4
        Me.UltraLabelMeseAnno.Text = "mese/anno"
        '
        'UltraButtonCarica
        '
        Me.UltraButtonCarica.Location = New System.Drawing.Point(319, 39)
        Me.UltraButtonCarica.Name = "UltraButtonCarica"
        Me.UltraButtonCarica.Size = New System.Drawing.Size(75, 23)
        Me.UltraButtonCarica.TabIndex = 3
        Me.UltraButtonCarica.Text = "Carica i dati"
        '
        'UltraDateTimeEditorMeseAnno
        '
        Me.UltraDateTimeEditorMeseAnno.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraDateTimeEditorMeseAnno.Location = New System.Drawing.Point(6, 39)
        Me.UltraDateTimeEditorMeseAnno.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.UltraDateTimeEditorMeseAnno.MaskInput = "mm/yyyy"
        Me.UltraDateTimeEditorMeseAnno.Name = "UltraDateTimeEditorMeseAnno"
        Me.UltraDateTimeEditorMeseAnno.Size = New System.Drawing.Size(74, 21)
        Me.UltraDateTimeEditorMeseAnno.TabIndex = 1
        '
        'ConsegneBindingSource
        '
        Me.ConsegneBindingSource.DataMember = "Consegne"
        Me.ConsegneBindingSource.DataSource = Me.ASDDBDataSet
        '
        'ConsegneTableAdapter
        '
        Me.ConsegneTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlternativiTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChiusureTableAdapter = Nothing
        Me.TableAdapterManager.Codici_AlternativiTableAdapter = Nothing
        Me.TableAdapterManager.ConsegneTableAdapter = Me.ConsegneTableAdapter
        Me.TableAdapterManager.CorrispettiviTableAdapter = Nothing
        Me.TableAdapterManager.DateTableAdapter = Nothing
        Me.TableAdapterManager.DistribuzioneTableAdapter = Nothing
        Me.TableAdapterManager.EsclusioniTableAdapter = Nothing
        Me.TableAdapterManager.ImpostazioniTableAdapter = Nothing
        Me.TableAdapterManager.Note_PagamentiTableAdapter = Nothing
        Me.TableAdapterManager.PagamentiTableAdapter = Nothing
        Me.TableAdapterManager.PI_Altri_DatiTableAdapter = Nothing
        Me.TableAdapterManager.PITableAdapter = Me.PITableAdapter
        Me.TableAdapterManager.Prefattura_consegneTableAdapter = Nothing
        Me.TableAdapterManager.Prefattura_extraTableAdapter = Nothing
        Me.TableAdapterManager.Prefattura_testataTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_AccettazioneTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_ChiusuraTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_ClasseTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_CorrispettiviTableAdapter = Me.Tabella_CorrispettiviTableAdapter
        Me.TableAdapterManager.Tabella_DispencerTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_DistribuzioniTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_Fascia_d_etàTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_FruizioneTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_GiorniTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_GiroTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_Pagamenti_ExtraTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_Privilegio_TestataTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_Privilegio_UtenteTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_QualitàTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_QuartiereTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_Sigle_CorrispettiviTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_TipologiaTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_TrasportatoriTableAdapter = Me.Tabella_TrasportatoriTableAdapter
        Me.TableAdapterManager.TestateTableAdapter = Nothing
        Me.TableAdapterManager.Trasportatori_pagamenti_extraTableAdapter = Nothing
        Me.TableAdapterManager.Trasportatori_presenzeTableAdapter = Me.Trasportatori_presenzeTableAdapter
        Me.TableAdapterManager.UpdateOrder = ASD2.ASDDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UtentiTableAdapter = Nothing
        Me.TableAdapterManager.VariazioniTableAdapter = Nothing
        '
        'PITableAdapter
        '
        Me.PITableAdapter.ClearBeforeFill = True
        '
        'Tabella_CorrispettiviTableAdapter
        '
        Me.Tabella_CorrispettiviTableAdapter.ClearBeforeFill = True
        '
        'Tabella_TrasportatoriTableAdapter
        '
        Me.Tabella_TrasportatoriTableAdapter.ClearBeforeFill = True
        '
        'Trasportatori_presenzeTableAdapter
        '
        Me.Trasportatori_presenzeTableAdapter.ClearBeforeFill = True
        '
        'PIBindingSource
        '
        Me.PIBindingSource.DataMember = "PI"
        Me.PIBindingSource.DataSource = Me.ASDDBDataSet
        '
        'Tabella_CorrispettiviBindingSource
        '
        Me.Tabella_CorrispettiviBindingSource.DataMember = "Tabella Corrispettivi"
        Me.Tabella_CorrispettiviBindingSource.DataSource = Me.ASDDBDataSet
        '
        'Trasportatori_presenzeBindingSource
        '
        Me.Trasportatori_presenzeBindingSource.DataMember = "Trasportatori presenze"
        Me.Trasportatori_presenzeBindingSource.DataSource = Me.ASDDBDataSet
        '
        'QConsegneGiornaliereBindingSource
        '
        Me.QConsegneGiornaliereBindingSource.DataMember = "QConsegneGiornaliere"
        Me.QConsegneGiornaliereBindingSource.DataSource = Me.ASDDBDataSet
        '
        'QConsegneGiornaliereTableAdapter
        '
        Me.QConsegneGiornaliereTableAdapter.ClearBeforeFill = True
        '
        'DataTableConsegneGiornaliereTableAdapter
        '
        Me.DataTableConsegneGiornaliereTableAdapter.ClearBeforeFill = True
        '
        'UltraGroupBoxExtra
        '
        Me.UltraGroupBoxExtra.Controls.Add(Me.UltraButtonElimina)
        Me.UltraGroupBoxExtra.Controls.Add(Me.UltraNumericEditorQuantita)
        Me.UltraGroupBoxExtra.Controls.Add(Me.UltraLabelQuantita)
        Me.UltraGroupBoxExtra.Controls.Add(Me.UltraLabelExtra)
        Me.UltraGroupBoxExtra.Controls.Add(Me.UltraComboExtra)
        Me.UltraGroupBoxExtra.Controls.Add(Me.UltraLabelData)
        Me.UltraGroupBoxExtra.Controls.Add(Me.UltraButtonAggiungi)
        Me.UltraGroupBoxExtra.Controls.Add(Me.UltraDateTimeEditorData)
        Me.UltraGroupBoxExtra.Controls.Add(Me.UltraGridExtra)
        Me.UltraGroupBoxExtra.Enabled = False
        Me.UltraGroupBoxExtra.Location = New System.Drawing.Point(478, 4)
        Me.UltraGroupBoxExtra.Name = "UltraGroupBoxExtra"
        Me.UltraGroupBoxExtra.Size = New System.Drawing.Size(366, 475)
        Me.UltraGroupBoxExtra.TabIndex = 2
        Me.UltraGroupBoxExtra.Text = "Extra"
        Me.UltraGroupBoxExtra.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraButtonElimina
        '
        Me.UltraButtonElimina.Location = New System.Drawing.Point(6, 426)
        Me.UltraButtonElimina.Name = "UltraButtonElimina"
        Me.UltraButtonElimina.Size = New System.Drawing.Size(126, 43)
        Me.UltraButtonElimina.TabIndex = 14
        Me.UltraButtonElimina.Text = "Elimina righe selezionate"
        '
        'UltraNumericEditorQuantita
        '
        Me.UltraNumericEditorQuantita.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraNumericEditorQuantita.Location = New System.Drawing.Point(325, 398)
        Me.UltraNumericEditorQuantita.MaskInput = "nnn"
        Me.UltraNumericEditorQuantita.MaxValue = 999
        Me.UltraNumericEditorQuantita.MinValue = 1
        Me.UltraNumericEditorQuantita.Name = "UltraNumericEditorQuantita"
        Me.UltraNumericEditorQuantita.NullText = "1"
        Me.UltraNumericEditorQuantita.Size = New System.Drawing.Size(35, 21)
        Me.UltraNumericEditorQuantita.TabIndex = 13
        Me.UltraNumericEditorQuantita.Value = 1
        '
        'UltraLabelQuantita
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabelQuantita.Appearance = Appearance29
        Me.UltraLabelQuantita.AutoSize = True
        Me.UltraLabelQuantita.Location = New System.Drawing.Point(326, 378)
        Me.UltraLabelQuantita.Name = "UltraLabelQuantita"
        Me.UltraLabelQuantita.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabelQuantita.TabIndex = 12
        Me.UltraLabelQuantita.Text = "Q.tà"
        '
        'UltraLabelExtra
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabelExtra.Appearance = Appearance30
        Me.UltraLabelExtra.AutoSize = True
        Me.UltraLabelExtra.Location = New System.Drawing.Point(6, 378)
        Me.UltraLabelExtra.Name = "UltraLabelExtra"
        Me.UltraLabelExtra.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabelExtra.TabIndex = 11
        Me.UltraLabelExtra.Text = "Tipo extra"
        '
        'UltraComboExtra
        '
        Me.UltraComboExtra.DataSource = Me.Tabella_Pagamenti_ExtraBindingSource
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Appearance31.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraComboExtra.DisplayLayout.Appearance = Appearance31
        Me.UltraComboExtra.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn49.Header.VisiblePosition = 0
        UltraGridColumn50.Header.VisiblePosition = 1
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 6
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 2
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 3
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 4
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 5
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 7
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 8
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 9
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 10
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 11
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.VisiblePosition = 12
        UltraGridColumn61.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61})
        Me.UltraComboExtra.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.UltraComboExtra.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraComboExtra.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance32.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance32.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance32.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboExtra.DisplayLayout.GroupByBox.Appearance = Appearance32
        Appearance33.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboExtra.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance33
        Me.UltraComboExtra.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance34.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance34.BackColor2 = System.Drawing.SystemColors.Control
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance34.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboExtra.DisplayLayout.GroupByBox.PromptAppearance = Appearance34
        Me.UltraComboExtra.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraComboExtra.DisplayLayout.MaxRowScrollRegions = 1
        Appearance35.BackColor = System.Drawing.SystemColors.Window
        Appearance35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraComboExtra.DisplayLayout.Override.ActiveCellAppearance = Appearance35
        Appearance36.BackColor = System.Drawing.SystemColors.Highlight
        Appearance36.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraComboExtra.DisplayLayout.Override.ActiveRowAppearance = Appearance36
        Me.UltraComboExtra.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraComboExtra.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance37.BackColor = System.Drawing.SystemColors.Window
        Me.UltraComboExtra.DisplayLayout.Override.CardAreaAppearance = Appearance37
        Appearance38.BorderColor = System.Drawing.Color.Silver
        Appearance38.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraComboExtra.DisplayLayout.Override.CellAppearance = Appearance38
        Me.UltraComboExtra.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraComboExtra.DisplayLayout.Override.CellPadding = 0
        Appearance39.BackColor = System.Drawing.SystemColors.Control
        Appearance39.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance39.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance39.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboExtra.DisplayLayout.Override.GroupByRowAppearance = Appearance39
        Appearance40.TextHAlignAsString = "Left"
        Me.UltraComboExtra.DisplayLayout.Override.HeaderAppearance = Appearance40
        Me.UltraComboExtra.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraComboExtra.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance41.BackColor = System.Drawing.SystemColors.Window
        Appearance41.BorderColor = System.Drawing.Color.Silver
        Me.UltraComboExtra.DisplayLayout.Override.RowAppearance = Appearance41
        Me.UltraComboExtra.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance42.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraComboExtra.DisplayLayout.Override.TemplateAddRowAppearance = Appearance42
        Me.UltraComboExtra.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraComboExtra.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraComboExtra.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraComboExtra.DisplayMember = "Descrizione"
        Me.UltraComboExtra.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraComboExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraComboExtra.LimitToList = True
        Me.UltraComboExtra.Location = New System.Drawing.Point(6, 398)
        Me.UltraComboExtra.Name = "UltraComboExtra"
        Me.UltraComboExtra.Size = New System.Drawing.Size(313, 22)
        Me.UltraComboExtra.TabIndex = 10
        Me.UltraComboExtra.Text = "Seleziona l'extra"
        Me.UltraComboExtra.ValueMember = "Descrizione"
        '
        'Tabella_Pagamenti_ExtraBindingSource
        '
        Me.Tabella_Pagamenti_ExtraBindingSource.DataMember = "Tabella Pagamenti Extra"
        Me.Tabella_Pagamenti_ExtraBindingSource.DataSource = Me.ASDDBDataSet
        '
        'UltraLabelData
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabelData.Appearance = Appearance43
        Me.UltraLabelData.AutoSize = True
        Me.UltraLabelData.Location = New System.Drawing.Point(6, 331)
        Me.UltraLabelData.Name = "UltraLabelData"
        Me.UltraLabelData.Size = New System.Drawing.Size(28, 14)
        Me.UltraLabelData.TabIndex = 9
        Me.UltraLabelData.Text = "Data"
        '
        'UltraButtonAggiungi
        '
        Me.UltraButtonAggiungi.Enabled = False
        Me.UltraButtonAggiungi.Location = New System.Drawing.Point(227, 331)
        Me.UltraButtonAggiungi.Name = "UltraButtonAggiungi"
        Me.UltraButtonAggiungi.Size = New System.Drawing.Size(133, 41)
        Me.UltraButtonAggiungi.TabIndex = 8
        Me.UltraButtonAggiungi.Text = "Aggiungi"
        '
        'UltraDateTimeEditorData
        '
        Me.UltraDateTimeEditorData.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraDateTimeEditorData.Location = New System.Drawing.Point(6, 351)
        Me.UltraDateTimeEditorData.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.UltraDateTimeEditorData.MaskInput = ""
        Me.UltraDateTimeEditorData.Name = "UltraDateTimeEditorData"
        Me.UltraDateTimeEditorData.Size = New System.Drawing.Size(90, 21)
        Me.UltraDateTimeEditorData.TabIndex = 7
        '
        'UltraGridExtra
        '
        Me.UltraGridExtra.DataSource = Me.Trasportatori_pagamenti_extraBindingSource
        Appearance44.BackColor = System.Drawing.SystemColors.Window
        Appearance44.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridExtra.DisplayLayout.Appearance = Appearance44
        UltraGridColumn30.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn30.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn30.Header.VisiblePosition = 0
        UltraGridColumn30.Hidden = True
        UltraGridColumn30.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
        UltraGridColumn30.Width = 126
        UltraGridColumn43.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn43.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn43.Header.VisiblePosition = 1
        UltraGridColumn43.Width = 68
        UltraGridColumn44.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn44.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn44.Header.VisiblePosition = 2
        UltraGridColumn44.Hidden = True
        UltraGridColumn44.Width = 36
        UltraGridColumn45.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn45.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn45.Header.VisiblePosition = 3
        UltraGridColumn45.Width = 193
        UltraGridColumn46.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn46.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn46.Header.VisiblePosition = 5
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn47.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn47.Header.VisiblePosition = 7
        UltraGridColumn47.Width = 53
        UltraGridColumn33.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn33.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn33.Header.VisiblePosition = 4
        UltraGridColumn33.Hidden = True
        UltraGridColumn33.Width = 444
        UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn34.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn34.Header.VisiblePosition = 6
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn35.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn35.Header.VisiblePosition = 8
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn36.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn36.Header.VisiblePosition = 9
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn37.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn37.Header.VisiblePosition = 10
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn38.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn38.Header.VisiblePosition = 11
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn39.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn39.Header.VisiblePosition = 12
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn40.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn40.Header.VisiblePosition = 13
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn41.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn41.Header.VisiblePosition = 14
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn42.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn42.Header.VisiblePosition = 15
        UltraGridColumn42.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn30, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42})
        Me.UltraGridExtra.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.UltraGridExtra.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridExtra.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance45.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance45.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance45.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridExtra.DisplayLayout.GroupByBox.Appearance = Appearance45
        Appearance46.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridExtra.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance46
        Me.UltraGridExtra.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance47.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance47.BackColor2 = System.Drawing.SystemColors.Control
        Appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance47.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridExtra.DisplayLayout.GroupByBox.PromptAppearance = Appearance47
        Me.UltraGridExtra.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridExtra.DisplayLayout.MaxRowScrollRegions = 1
        Appearance48.BackColor = System.Drawing.SystemColors.Window
        Appearance48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridExtra.DisplayLayout.Override.ActiveCellAppearance = Appearance48
        Appearance49.BackColor = System.Drawing.SystemColors.Highlight
        Appearance49.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridExtra.DisplayLayout.Override.ActiveRowAppearance = Appearance49
        Me.UltraGridExtra.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridExtra.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridExtra.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance50.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridExtra.DisplayLayout.Override.CardAreaAppearance = Appearance50
        Appearance51.BorderColor = System.Drawing.Color.Silver
        Appearance51.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridExtra.DisplayLayout.Override.CellAppearance = Appearance51
        Me.UltraGridExtra.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridExtra.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridExtra.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance52.BackColor = System.Drawing.SystemColors.Control
        Appearance52.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance52.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance52.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridExtra.DisplayLayout.Override.GroupByRowAppearance = Appearance52
        Appearance53.TextHAlignAsString = "Left"
        Me.UltraGridExtra.DisplayLayout.Override.HeaderAppearance = Appearance53
        Me.UltraGridExtra.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridExtra.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance54.BackColor = System.Drawing.SystemColors.Window
        Appearance54.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridExtra.DisplayLayout.Override.RowAppearance = Appearance54
        Me.UltraGridExtra.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridExtra.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Appearance55.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridExtra.DisplayLayout.Override.TemplateAddRowAppearance = Appearance55
        Me.UltraGridExtra.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridExtra.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridExtra.Location = New System.Drawing.Point(6, 19)
        Me.UltraGridExtra.Name = "UltraGridExtra"
        Me.UltraGridExtra.Size = New System.Drawing.Size(354, 306)
        Me.UltraGridExtra.TabIndex = 2
        '
        'Trasportatori_pagamenti_extraBindingSource
        '
        Me.Trasportatori_pagamenti_extraBindingSource.DataMember = "Trasportatori pagamenti extra"
        Me.Trasportatori_pagamenti_extraBindingSource.DataSource = Me.ASDDBDataSet
        '
        'Trasportatori_pagamenti_extraTableAdapter
        '
        Me.Trasportatori_pagamenti_extraTableAdapter.ClearBeforeFill = True
        '
        'Tabella_Pagamenti_ExtraTableAdapter
        '
        Me.Tabella_Pagamenti_ExtraTableAdapter.ClearBeforeFill = True
        '
        'ConsegneGiornaliere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.UltraGroupBoxExtra)
        Me.Controls.Add(Me.UltraGroupBoxSelezione)
        Me.Controls.Add(Me.UltraGrid1)
        Me.Name = "ConsegneGiornaliere"
        Me.Size = New System.Drawing.Size(847, 482)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTableConsegneGiornaliereBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASDDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabella_TrasportatoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBoxSelezione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxSelezione.ResumeLayout(False)
        Me.UltraGroupBoxSelezione.PerformLayout()
        CType(Me.UltraComboTrasportatore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorMeseAnno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsegneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabella_CorrispettiviBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trasportatori_presenzeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QConsegneGiornaliereBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBoxExtra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxExtra.ResumeLayout(False)
        Me.UltraGroupBoxExtra.PerformLayout()
        CType(Me.UltraNumericEditorQuantita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraComboExtra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabella_Pagamenti_ExtraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridExtra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trasportatori_pagamenti_extraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Trasportatori_presenzeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASDDBDataSet As ASD2.ASDDBDataSet
    Friend WithEvents ConsegneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsegneTableAdapter As ASD2.ASDDBDataSetTableAdapters.ConsegneTableAdapter
    Friend WithEvents TableAdapterManager As ASD2.ASDDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PITableAdapter As ASD2.ASDDBDataSetTableAdapters.PITableAdapter
    Friend WithEvents Tabella_CorrispettiviTableAdapter As ASD2.ASDDBDataSetTableAdapters.Tabella_CorrispettiviTableAdapter
    Friend WithEvents Trasportatori_presenzeTableAdapter As ASD2.ASDDBDataSetTableAdapters.Trasportatori_presenzeTableAdapter
    Friend WithEvents PIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tabella_CorrispettiviBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tabella_TrasportatoriBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tabella_TrasportatoriTableAdapter As ASD2.ASDDBDataSetTableAdapters.Tabella_TrasportatoriTableAdapter
    Friend WithEvents UltraGroupBoxSelezione As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabelTrasportatore As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraComboTrasportatore As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabelMeseAnno As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraButtonCarica As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraDateTimeEditorMeseAnno As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents DataTableConsegneGiornaliereBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QConsegneGiornaliereBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QConsegneGiornaliereTableAdapter As ASD2.ASDDBDataSetTableAdapters.QConsegneGiornaliereTableAdapter
    Friend WithEvents DataTableConsegneGiornaliereTableAdapter As ASD2.ASDDBDataSetTableAdapters.DataTableConsegneGiornaliereTableAdapter
    Friend WithEvents UltraGroupBoxExtra As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Trasportatori_pagamenti_extraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Trasportatori_pagamenti_extraTableAdapter As ASD2.ASDDBDataSetTableAdapters.Trasportatori_pagamenti_extraTableAdapter
    Friend WithEvents UltraNumericEditorQuantita As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabelQuantita As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabelExtra As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraComboExtra As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Tabella_Pagamenti_ExtraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UltraLabelData As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraButtonAggiungi As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraDateTimeEditorData As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraGridExtra As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Tabella_Pagamenti_ExtraTableAdapter As ASD2.ASDDBDataSetTableAdapters.Tabella_Pagamenti_ExtraTableAdapter
    Friend WithEvents UltraButtonElimina As Infragistics.Win.Misc.UltraButton

End Class
