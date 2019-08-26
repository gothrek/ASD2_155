<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DettaglioGiornaliero
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("QFattureGiroGiorno", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Testata")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotaleCopie")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotaleConsegnati")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroConsegne")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipologia")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GiornoN")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mese")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Anno")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Giro", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Spezzatura", 0)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotPacchi", 1)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Totale", 2)
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "Totale", 2, False, "QFattureGiroGiorno", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Totale", 2, False)
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "TotaleConsegnati", 2, True, "QFattureGiroGiorno", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "TotaleConsegnati", 2, True)
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings3 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "TotaleCopie", 1, True, "QFattureGiroGiorno", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "TotaleCopie", 1, True)
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings4 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "NumeroConsegne", 3, True, "QFattureGiroGiorno", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "NumeroConsegne", 3, True)
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
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Testate", -1)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nome")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codice")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lunedì")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Martedì")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mercoledì")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Giovedì")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Venerdì")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sabato")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Domenica")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Attiva")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pacchi")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TestateTabella Distribuzioni")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("TestateTabella Distribuzioni", -1)
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Testata")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Distribuzione")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Attiva")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data ultimo utilizzo")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data ultima modifica")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data creazione")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Note")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tabella DistribuzioniDistribuzione")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tabella DistribuzioniDistribuzione", -1)
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Testata")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Distribuzione")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PI")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copie")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraCalendarLook1 = New Infragistics.Win.UltraWinSchedule.UltraCalendarLook(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGridDettaglioGiornaliero = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.QFattureGiroGiornoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASDDBDataSet = New ASD2.ASDDBDataSet()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraButtonPDF = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonExcel = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonCrea = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraDateTimeEditor1 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraComboTestata = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.QFatturatoMeseAnnoGiro2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsegneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsegneTableAdapter = New ASD2.ASDDBDataSetTableAdapters.ConsegneTableAdapter()
        Me.QFatturatoMeseAnnoGiro2TableAdapter = New ASD2.ASDDBDataSetTableAdapters.QFatturatoMeseAnnoGiro2TableAdapter()
        Me.QFattureGiroGiornoTableAdapter = New ASD2.ASDDBDataSetTableAdapters.QFattureGiroGiornoTableAdapter()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGridDettaglioGiornaliero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QFattureGiroGiornoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASDDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraComboTestata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QFatturatoMeseAnnoGiro2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsegneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraCalendarLook1
        '
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UltraCalendarLook1.ActiveDayAppearance = Appearance1
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UltraCalendarLook1.AllDayEventAppearance = Appearance2
        Me.UltraCalendarLook1.ViewStyle = Infragistics.Win.UltraWinSchedule.ViewStyle.Office2007
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraGridDettaglioGiornaliero)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(4, 86)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(993, 511)
        Me.UltraGroupBox1.TabIndex = 4
        Me.UltraGroupBox1.Text = "Dettaglio Giornaliero"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGridDettaglioGiornaliero
        '
        Me.UltraGridDettaglioGiornaliero.DataSource = Me.QFattureGiroGiornoBindingSource
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Appearance = Appearance3
        UltraGridColumn1.Header.VisiblePosition = 3
        UltraGridColumn2.Header.VisiblePosition = 7
        UltraGridColumn3.Header.VisiblePosition = 9
        UltraGridColumn4.Header.VisiblePosition = 5
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 2
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 1
        UltraGridColumn9.Width = 33
        UltraGridColumn12.Header.VisiblePosition = 10
        UltraGridColumn12.Width = 83
        UltraGridColumn13.Header.VisiblePosition = 8
        UltraGridColumn13.Width = 74
        UltraGridColumn14.DataType = GetType(Decimal)
        UltraGridColumn14.Header.VisiblePosition = 11
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
        SummarySettings1.GroupBySummaryValueAppearance = Appearance4
        SummarySettings2.GroupBySummaryValueAppearance = Appearance5
        SummarySettings3.GroupBySummaryValueAppearance = Appearance6
        SummarySettings4.GroupBySummaryValueAppearance = Appearance7
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1, SummarySettings2, SummarySettings3, SummarySettings4})
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance8.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance8.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.GroupByBox.Appearance = Appearance8
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance9
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance10.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance10.BackColor2 = System.Drawing.SystemColors.Control
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance10.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.GroupByBox.PromptAppearance = Appearance10
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.InterBandSpacing = 10
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.MaxRowScrollRegions = 1
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.ActiveCellAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.SystemColors.Highlight
        Appearance12.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.ActiveRowAppearance = Appearance12
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.SingleSummaryBasedOnDataType
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.CardAreaAppearance = Appearance13
        Appearance14.BorderColor = System.Drawing.Color.Silver
        Appearance14.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.CellAppearance = Appearance14
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.CellPadding = 0
        Appearance15.BackColor = System.Drawing.SystemColors.Control
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.GroupByRowAppearance = Appearance15
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance16.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance16.ForeColor = System.Drawing.Color.White
        Appearance16.TextHAlignAsString = "Left"
        Appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.HeaderAppearance = Appearance16
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance17.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.RowAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance18.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.RowSelectorAppearance = Appearance18
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.RowSelectorWidth = 12
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Appearance19.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer))
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance19.ForeColor = System.Drawing.Color.Black
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.SelectedRowAppearance = Appearance19
        Appearance20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.Override.TemplateAddRowAppearance = Appearance20
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridDettaglioGiornaliero.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraGridDettaglioGiornaliero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridDettaglioGiornaliero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridDettaglioGiornaliero.Location = New System.Drawing.Point(3, 16)
        Me.UltraGridDettaglioGiornaliero.Name = "UltraGridDettaglioGiornaliero"
        Me.UltraGridDettaglioGiornaliero.Size = New System.Drawing.Size(987, 492)
        Me.UltraGridDettaglioGiornaliero.TabIndex = 1
        Me.UltraGridDettaglioGiornaliero.Text = "UltraGrid1"
        '
        'QFattureGiroGiornoBindingSource
        '
        Me.QFattureGiroGiornoBindingSource.DataMember = "QFattureGiroGiorno"
        Me.QFattureGiroGiornoBindingSource.DataSource = Me.ASDDBDataSet
        '
        'ASDDBDataSet
        '
        Me.ASDDBDataSet.DataSetName = "ASDDBDataSet"
        Me.ASDDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.UltraButtonPDF)
        Me.UltraGroupBox3.Controls.Add(Me.UltraButtonExcel)
        Me.UltraGroupBox3.Controls.Add(Me.UltraButtonCrea)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(458, 4)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(539, 76)
        Me.UltraGroupBox3.TabIndex = 7
        Me.UltraGroupBox3.Text = "Stampa ed esporta"
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraButtonPDF
        '
        Me.UltraButtonPDF.Enabled = False
        Me.UltraButtonPDF.Location = New System.Drawing.Point(389, 21)
        Me.UltraButtonPDF.Name = "UltraButtonPDF"
        Me.UltraButtonPDF.Size = New System.Drawing.Size(144, 49)
        Me.UltraButtonPDF.TabIndex = 7
        Me.UltraButtonPDF.Text = "Esporta in pdf"
        '
        'UltraButtonExcel
        '
        Me.UltraButtonExcel.Enabled = False
        Me.UltraButtonExcel.Location = New System.Drawing.Point(239, 21)
        Me.UltraButtonExcel.Name = "UltraButtonExcel"
        Me.UltraButtonExcel.Size = New System.Drawing.Size(144, 49)
        Me.UltraButtonExcel.TabIndex = 6
        Me.UltraButtonExcel.Text = "Esporta in Excel"
        '
        'UltraButtonCrea
        '
        Me.UltraButtonCrea.Enabled = False
        Me.UltraButtonCrea.Location = New System.Drawing.Point(6, 21)
        Me.UltraButtonCrea.Name = "UltraButtonCrea"
        Me.UltraButtonCrea.Size = New System.Drawing.Size(144, 49)
        Me.UltraButtonCrea.TabIndex = 5
        Me.UltraButtonCrea.Text = "Stampare il report"
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.UltraButton1)
        Me.UltraGroupBox4.Controls.Add(Me.UltraDateTimeEditor1)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox4.Controls.Add(Me.UltraComboTestata)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(448, 77)
        Me.UltraGroupBox4.TabIndex = 6
        Me.UltraGroupBox4.Text = "Seleziona la testata e la data"
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(298, 22)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(144, 49)
        Me.UltraButton1.TabIndex = 19
        Me.UltraButton1.Text = "Carica le consegne"
        '
        'UltraDateTimeEditor1
        '
        Me.UltraDateTimeEditor1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraDateTimeEditor1.FormatProvider = New System.Globalization.CultureInfo("it-IT")
        Me.UltraDateTimeEditor1.Location = New System.Drawing.Point(160, 39)
        Me.UltraDateTimeEditor1.MaskInput = "{date}"
        Me.UltraDateTimeEditor1.Name = "UltraDateTimeEditor1"
        Me.UltraDateTimeEditor1.Size = New System.Drawing.Size(118, 21)
        Me.UltraDateTimeEditor1.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.OnMouseEnter
        Me.UltraDateTimeEditor1.TabIndex = 18
        '
        'UltraLabel2
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel2.Appearance = Appearance21
        Me.UltraLabel2.Location = New System.Drawing.Point(160, 19)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(134, 13)
        Me.UltraLabel2.TabIndex = 17
        Me.UltraLabel2.Text = "Seleziona la data"
        '
        'UltraComboTestata
        '
        Me.UltraComboTestata.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None
        Appearance22.BackColor = System.Drawing.Color.White
        Appearance22.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.UltraComboTestata.DisplayLayout.Appearance = Appearance22
        UltraGridColumn15.Header.VisiblePosition = 0
        UltraGridColumn16.Header.VisiblePosition = 1
        UltraGridColumn17.Header.VisiblePosition = 2
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 3
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 4
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 5
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 6
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 7
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 8
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 9
        UltraGridColumn25.Header.VisiblePosition = 10
        UltraGridColumn26.Header.VisiblePosition = 11
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26})
        UltraGridColumn27.Header.VisiblePosition = 0
        UltraGridColumn28.Header.VisiblePosition = 1
        UltraGridColumn29.Header.VisiblePosition = 2
        UltraGridColumn30.Header.VisiblePosition = 3
        UltraGridColumn31.Header.VisiblePosition = 4
        UltraGridColumn32.Header.VisiblePosition = 5
        UltraGridColumn33.Header.VisiblePosition = 6
        UltraGridColumn34.Header.VisiblePosition = 7
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34})
        UltraGridColumn35.Header.VisiblePosition = 0
        UltraGridColumn36.Header.VisiblePosition = 1
        UltraGridColumn37.Header.VisiblePosition = 2
        UltraGridColumn38.Header.VisiblePosition = 3
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38})
        Me.UltraComboTestata.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraComboTestata.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.UltraComboTestata.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.UltraComboTestata.DisplayLayout.InterBandSpacing = 10
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Me.UltraComboTestata.DisplayLayout.Override.CardAreaAppearance = Appearance23
        Appearance24.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance24.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance24.ForeColor = System.Drawing.Color.White
        Appearance24.TextHAlignAsString = "Left"
        Appearance24.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraComboTestata.DisplayLayout.Override.HeaderAppearance = Appearance24
        Appearance25.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraComboTestata.DisplayLayout.Override.RowAppearance = Appearance25
        Appearance26.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance26.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.UltraComboTestata.DisplayLayout.Override.RowSelectorAppearance = Appearance26
        Me.UltraComboTestata.DisplayLayout.Override.RowSelectorWidth = 12
        Me.UltraComboTestata.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance27.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Appearance27.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer))
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance27.ForeColor = System.Drawing.Color.Black
        Me.UltraComboTestata.DisplayLayout.Override.SelectedRowAppearance = Appearance27
        Me.UltraComboTestata.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraComboTestata.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.UltraComboTestata.DisplayMember = "Nome"
        Me.UltraComboTestata.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraComboTestata.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.UltraComboTestata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraComboTestata.LimitToList = True
        Me.UltraComboTestata.Location = New System.Drawing.Point(6, 38)
        Me.UltraComboTestata.Name = "UltraComboTestata"
        Me.UltraComboTestata.Size = New System.Drawing.Size(148, 22)
        Me.UltraComboTestata.TabIndex = 13
        Me.UltraComboTestata.ValueMember = "Codice"
        Me.UltraComboTestata.Visible = False
        '
        'UltraLabel1
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel1.Appearance = Appearance28
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 19)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(103, 13)
        Me.UltraLabel1.TabIndex = 16
        Me.UltraLabel1.Text = "Seleziona la testata"
        Me.UltraLabel1.Visible = False
        '
        'QFatturatoMeseAnnoGiro2BindingSource
        '
        Me.QFatturatoMeseAnnoGiro2BindingSource.DataMember = "QFatturatoMeseAnnoGiro2"
        Me.QFatturatoMeseAnnoGiro2BindingSource.DataSource = Me.ASDDBDataSet
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
        'QFatturatoMeseAnnoGiro2TableAdapter
        '
        Me.QFatturatoMeseAnnoGiro2TableAdapter.ClearBeforeFill = True
        '
        'QFattureGiroGiornoTableAdapter
        '
        Me.QFattureGiroGiornoTableAdapter.ClearBeforeFill = True
        '
        'DettaglioGiornaliero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.UltraGroupBox3)
        Me.Controls.Add(Me.UltraGroupBox4)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Name = "DettaglioGiornaliero"
        Me.Size = New System.Drawing.Size(1000, 600)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.UltraGridDettaglioGiornaliero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QFattureGiroGiornoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASDDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraComboTestata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QFatturatoMeseAnnoGiro2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsegneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ConsegneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASDDBDataSet As ASD2.ASDDBDataSet
    Friend WithEvents ConsegneTableAdapter As ASD2.ASDDBDataSetTableAdapters.ConsegneTableAdapter
    Friend WithEvents QFatturatoMeseAnnoGiro2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QFatturatoMeseAnnoGiro2TableAdapter As ASD2.ASDDBDataSetTableAdapters.QFatturatoMeseAnnoGiro2TableAdapter
    Friend WithEvents QFattureGiroGiornoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QFattureGiroGiornoTableAdapter As ASD2.ASDDBDataSetTableAdapters.QFattureGiroGiornoTableAdapter
    Friend WithEvents UltraCalendarLook1 As Infragistics.Win.UltraWinSchedule.UltraCalendarLook
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButtonPDF As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonExcel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonCrea As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraDateTimeEditor1 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraComboTestata As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGridDettaglioGiornaliero As Infragistics.Win.UltraWinGrid.UltraGrid

End Class
