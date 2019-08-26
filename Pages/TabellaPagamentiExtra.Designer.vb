<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TabellaPagamentiExtra
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tabella Pagamenti Extra", -1)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descrizione")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importo")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Note")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo1")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo2")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo3")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo4")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo5")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo6")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo7")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo8")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo aggiuntivo9")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sigla corrispettivo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tabella Sigle Corrispettivi", -1)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sigla")
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
        Me.ASDDBDataSet = New ASD2.ASDDBDataSet()
        Me.Tabella_Pagamenti_ExtraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tabella_Pagamenti_ExtraTableAdapter = New ASD2.ASDDBDataSetTableAdapters.Tabella_Pagamenti_ExtraTableAdapter()
        Me.TableAdapterManager = New ASD2.ASDDBDataSetTableAdapters.TableAdapterManager()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraDropDownSiglaCorrispettivo = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me.Tabella_Sigle_CorrispettiviBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tabella_Sigle_CorrispettiviTableAdapter = New ASD2.ASDDBDataSetTableAdapters.Tabella_Sigle_CorrispettiviTableAdapter()
        CType(Me.ASDDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabella_Pagamenti_ExtraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownSiglaCorrispettivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabella_Sigle_CorrispettiviBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ASDDBDataSet
        '
        Me.ASDDBDataSet.DataSetName = "ASDDBDataSet"
        Me.ASDDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tabella_Pagamenti_ExtraBindingSource
        '
        Me.Tabella_Pagamenti_ExtraBindingSource.DataMember = "Tabella Pagamenti Extra"
        Me.Tabella_Pagamenti_ExtraBindingSource.DataSource = Me.ASDDBDataSet
        '
        'Tabella_Pagamenti_ExtraTableAdapter
        '
        Me.Tabella_Pagamenti_ExtraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlternativiTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChiusureTableAdapter = Nothing
        Me.TableAdapterManager.Codici_AlternativiTableAdapter = Nothing
        Me.TableAdapterManager.ConsegneTableAdapter = Nothing
        Me.TableAdapterManager.CorrispettiviTableAdapter = Nothing
        Me.TableAdapterManager.DateTableAdapter = Nothing
        Me.TableAdapterManager.DistribuzioneTableAdapter = Nothing
        Me.TableAdapterManager.EsclusioniTableAdapter = Nothing
        Me.TableAdapterManager.ImpostazioniTableAdapter = Nothing
        Me.TableAdapterManager.Note_PagamentiTableAdapter = Nothing
        Me.TableAdapterManager.PagamentiTableAdapter = Nothing
        Me.TableAdapterManager.PI_Altri_DatiTableAdapter = Nothing
        Me.TableAdapterManager.PITableAdapter = Nothing
        Me.TableAdapterManager.Prefattura_consegneTableAdapter = Nothing
        Me.TableAdapterManager.Prefattura_extraTableAdapter = Nothing
        Me.TableAdapterManager.Prefattura_testataTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_AccettazioneTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_ChiusuraTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_ClasseTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_CorrispettiviTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_DispencerTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_DistribuzioniTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_Fascia_d_etàTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_FruizioneTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_GiorniTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_GiroTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_Pagamenti_ExtraTableAdapter = Me.Tabella_Pagamenti_ExtraTableAdapter
        Me.TableAdapterManager.Tabella_Privilegio_TestataTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_Privilegio_UtenteTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_QualitàTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_QuartiereTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_Sigle_CorrispettiviTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_TipologiaTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_TrasportatoriTableAdapter = Nothing
        Me.TableAdapterManager.TestateTableAdapter = Nothing
        Me.TableAdapterManager.Trasportatori_pagamenti_extraTableAdapter = Nothing
        Me.TableAdapterManager.Trasportatori_presenzeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ASD2.ASDDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UtentiTableAdapter = Nothing
        Me.TableAdapterManager.VariazioniTableAdapter = Nothing
        '
        'UltraGrid1
        '
        Me.UltraGrid1.DataSource = Me.Tabella_Pagamenti_ExtraBindingSource
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.UltraGrid1.DisplayLayout.Appearance = Appearance1
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 209
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 331
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn1})
        Me.UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGrid1.DisplayLayout.InterBandSpacing = 10
        Me.UltraGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.FixedAddRowOnBottom
        Me.UltraGrid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGrid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.UltraGrid1.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.White
        Appearance3.TextHAlignAsString = "Left"
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraGrid1.DisplayLayout.Override.HeaderAppearance = Appearance3
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraGrid1.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.UltraGrid1.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Me.UltraGrid1.DisplayLayout.Override.RowSelectorWidth = 12
        Me.UltraGrid1.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.UltraGrid1.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.UltraGrid1.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraGrid1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(773, 502)
        Me.UltraGrid1.TabIndex = 2
        Me.UltraGrid1.Text = "Tabella Pagamenti extra"
        '
        'UltraDropDownSiglaCorrispettivo
        '
        Me.UltraDropDownSiglaCorrispettivo.DataSource = Me.Tabella_Sigle_CorrispettiviBindingSource
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Appearance7.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.Appearance = Appearance7
        UltraGridColumn14.Header.VisiblePosition = 0
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 1
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn14, UltraGridColumn15})
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance8.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance8.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.GroupByBox.Appearance = Appearance8
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance9
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance10.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance10.BackColor2 = System.Drawing.SystemColors.Control
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance10.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.GroupByBox.PromptAppearance = Appearance10
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.MaxRowScrollRegions = 1
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.Override.ActiveCellAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.SystemColors.Highlight
        Appearance12.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.Override.ActiveRowAppearance = Appearance12
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.Override.CardAreaAppearance = Appearance13
        Appearance14.BorderColor = System.Drawing.Color.Silver
        Appearance14.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.Override.CellAppearance = Appearance14
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.Override.CellPadding = 0
        Appearance15.BackColor = System.Drawing.SystemColors.Control
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.Override.GroupByRowAppearance = Appearance15
        Appearance16.TextHAlignAsString = "Left"
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.Override.HeaderAppearance = Appearance16
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.BorderColor = System.Drawing.Color.Silver
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.Override.RowAppearance = Appearance17
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.Override.TemplateAddRowAppearance = Appearance18
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraDropDownSiglaCorrispettivo.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraDropDownSiglaCorrispettivo.DisplayMember = "Sigla"
        Me.UltraDropDownSiglaCorrispettivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownSiglaCorrispettivo.Location = New System.Drawing.Point(60, 3)
        Me.UltraDropDownSiglaCorrispettivo.Name = "UltraDropDownSiglaCorrispettivo"
        Me.UltraDropDownSiglaCorrispettivo.Size = New System.Drawing.Size(99, 22)
        Me.UltraDropDownSiglaCorrispettivo.TabIndex = 5
        Me.UltraDropDownSiglaCorrispettivo.Text = "UltraDropDown1"
        Me.UltraDropDownSiglaCorrispettivo.ValueMember = "Sigla"
        Me.UltraDropDownSiglaCorrispettivo.Visible = False
        '
        'Tabella_Sigle_CorrispettiviBindingSource
        '
        Me.Tabella_Sigle_CorrispettiviBindingSource.DataMember = "Tabella Sigle Corrispettivi"
        Me.Tabella_Sigle_CorrispettiviBindingSource.DataSource = Me.ASDDBDataSet
        '
        'Tabella_Sigle_CorrispettiviTableAdapter
        '
        Me.Tabella_Sigle_CorrispettiviTableAdapter.ClearBeforeFill = True
        '
        'TabellaPagamentiExtra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.UltraDropDownSiglaCorrispettivo)
        Me.Controls.Add(Me.UltraGrid1)
        Me.Name = "TabellaPagamentiExtra"
        Me.Size = New System.Drawing.Size(773, 502)
        CType(Me.ASDDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabella_Pagamenti_ExtraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownSiglaCorrispettivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabella_Sigle_CorrispettiviBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ASDDBDataSet As ASD2.ASDDBDataSet
    Friend WithEvents Tabella_Pagamenti_ExtraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tabella_Pagamenti_ExtraTableAdapter As ASD2.ASDDBDataSetTableAdapters.Tabella_Pagamenti_ExtraTableAdapter
    Friend WithEvents TableAdapterManager As ASD2.ASDDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraDropDownSiglaCorrispettivo As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents Tabella_Sigle_CorrispettiviBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tabella_Sigle_CorrispettiviTableAdapter As ASD2.ASDDBDataSetTableAdapters.Tabella_Sigle_CorrispettiviTableAdapter

End Class
