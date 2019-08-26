<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportGiornaliero
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
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Me.UltraCalendarInfo1 = New Infragistics.Win.UltraWinSchedule.UltraCalendarInfo(Me.components)
        Me.UltraCalendarLook1 = New Infragistics.Win.UltraWinSchedule.UltraCalendarLook(Me.components)
        Me.UltraGroupBoxData = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraMonthViewSingleData = New Infragistics.Win.UltraWinSchedule.UltraMonthViewSingle()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraNumericEditor1 = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraButtonPDF = New Infragistics.Win.Misc.UltraButton()
        Me.DataGridViewReportGiornaliero = New System.Windows.Forms.DataGridView()
        Me.UltraButtonExcel = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonCrea = New Infragistics.Win.Misc.UltraButton()
        Me.UltraDateTimeEditor1 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraButtonCarica = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBoxReportGiornaliero = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGridReportGiornaliero = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ASDDBDataSet = New ASD2.ASDDBDataSet()
        Me.TableAdapterManager = New ASD2.ASDDBDataSetTableAdapters.TableAdapterManager()
        Me.Tabella_GiroTableAdapter = New ASD2.ASDDBDataSetTableAdapters.Tabella_GiroTableAdapter()
        Me.QRiepilogoGiornalieroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QRiepilogoGiornalieroTableAdapter = New ASD2.ASDDBDataSetTableAdapters.QRiepilogoGiornalieroTableAdapter()
        Me.Tabella_GiroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraGridExcelExporter1 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.UltraGridDocumentExporter1 = New Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter(Me.components)
        Me.UltraGridPrintDocument1 = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
        Me.UltraPrintPreviewDialog1 = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
        CType(Me.UltraGroupBoxData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxData.SuspendLayout()
        CType(Me.UltraMonthViewSingleData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraNumericEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewReportGiornaliero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBoxReportGiornaliero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxReportGiornaliero.SuspendLayout()
        CType(Me.UltraGridReportGiornaliero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASDDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QRiepilogoGiornalieroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabella_GiroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraCalendarInfo1
        '
        Me.UltraCalendarInfo1.DataBindingsForAppointments.BindingContextControl = Me
        Me.UltraCalendarInfo1.DataBindingsForOwners.BindingContextControl = Me
        '
        'UltraCalendarLook1
        '
        Me.UltraCalendarLook1.ViewStyle = Infragistics.Win.UltraWinSchedule.ViewStyle.Office2007
        '
        'UltraGroupBoxData
        '
        Me.UltraGroupBoxData.Controls.Add(Me.UltraMonthViewSingleData)
        Me.UltraGroupBoxData.Location = New System.Drawing.Point(835, 3)
        Me.UltraGroupBoxData.Name = "UltraGroupBoxData"
        Me.UltraGroupBoxData.Size = New System.Drawing.Size(312, 250)
        Me.UltraGroupBoxData.TabIndex = 3
        Me.UltraGroupBoxData.Text = "Selezione data"
        Me.UltraGroupBoxData.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraMonthViewSingleData
        '
        Me.UltraMonthViewSingleData.CalendarLook = Me.UltraCalendarLook1
        Me.UltraMonthViewSingleData.Location = New System.Drawing.Point(3, 16)
        Me.UltraMonthViewSingleData.Name = "UltraMonthViewSingleData"
        Me.UltraMonthViewSingleData.OwnerNavigationStyle = Infragistics.Win.UltraWinSchedule.OwnerNavigationStyle.None
        Me.UltraMonthViewSingleData.Size = New System.Drawing.Size(306, 231)
        Me.UltraMonthViewSingleData.TabIndex = 1
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraNumericEditor1)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButtonPDF)
        Me.UltraGroupBox1.Controls.Add(Me.DataGridViewReportGiornaliero)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButtonExcel)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButtonCrea)
        Me.UltraGroupBox1.Controls.Add(Me.UltraDateTimeEditor1)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButtonCarica)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(828, 261)
        Me.UltraGroupBox1.TabIndex = 4
        Me.UltraGroupBox1.Text = "Report Giornaliero"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraNumericEditor1
        '
        Me.UltraNumericEditor1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraNumericEditor1.Location = New System.Drawing.Point(73, 158)
        Me.UltraNumericEditor1.Name = "UltraNumericEditor1"
        Me.UltraNumericEditor1.Size = New System.Drawing.Size(77, 21)
        Me.UltraNumericEditor1.TabIndex = 13
        Me.UltraNumericEditor1.Value = 1
        '
        'UltraLabel1
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel1.Appearance = Appearance13
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 158)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel1.TabIndex = 12
        Me.UltraLabel1.Text = "Num. copie"
        '
        'UltraButtonPDF
        '
        Me.UltraButtonPDF.Enabled = False
        Me.UltraButtonPDF.Location = New System.Drawing.Point(678, 74)
        Me.UltraButtonPDF.Name = "UltraButtonPDF"
        Me.UltraButtonPDF.Size = New System.Drawing.Size(144, 49)
        Me.UltraButtonPDF.TabIndex = 4
        Me.UltraButtonPDF.Text = "Esporta in pdf"
        '
        'DataGridViewReportGiornaliero
        '
        Me.DataGridViewReportGiornaliero.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewReportGiornaliero.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewReportGiornaliero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewReportGiornaliero.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewReportGiornaliero.Location = New System.Drawing.Point(219, 19)
        Me.DataGridViewReportGiornaliero.Name = "DataGridViewReportGiornaliero"
        Me.DataGridViewReportGiornaliero.ReadOnly = True
        Me.DataGridViewReportGiornaliero.Size = New System.Drawing.Size(118, 104)
        Me.DataGridViewReportGiornaliero.TabIndex = 10
        Me.DataGridViewReportGiornaliero.Visible = False
        '
        'UltraButtonExcel
        '
        Me.UltraButtonExcel.Enabled = False
        Me.UltraButtonExcel.Location = New System.Drawing.Point(678, 19)
        Me.UltraButtonExcel.Name = "UltraButtonExcel"
        Me.UltraButtonExcel.Size = New System.Drawing.Size(144, 49)
        Me.UltraButtonExcel.TabIndex = 3
        Me.UltraButtonExcel.Text = "Esporta in Excel"
        '
        'UltraButtonCrea
        '
        Me.UltraButtonCrea.Enabled = False
        Me.UltraButtonCrea.Location = New System.Drawing.Point(6, 101)
        Me.UltraButtonCrea.Name = "UltraButtonCrea"
        Me.UltraButtonCrea.Size = New System.Drawing.Size(144, 49)
        Me.UltraButtonCrea.TabIndex = 2
        Me.UltraButtonCrea.Text = "Stampare il report"
        '
        'UltraDateTimeEditor1
        '
        Me.UltraDateTimeEditor1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraDateTimeEditor1.FormatProvider = New System.Globalization.CultureInfo("it-IT")
        Me.UltraDateTimeEditor1.Location = New System.Drawing.Point(6, 19)
        Me.UltraDateTimeEditor1.MaskInput = "{date}"
        Me.UltraDateTimeEditor1.Name = "UltraDateTimeEditor1"
        Me.UltraDateTimeEditor1.Size = New System.Drawing.Size(144, 21)
        Me.UltraDateTimeEditor1.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.OnMouseEnter
        Me.UltraDateTimeEditor1.TabIndex = 1
        Me.UltraDateTimeEditor1.Visible = False
        '
        'UltraButtonCarica
        '
        Me.UltraButtonCarica.Location = New System.Drawing.Point(6, 46)
        Me.UltraButtonCarica.Name = "UltraButtonCarica"
        Me.UltraButtonCarica.Size = New System.Drawing.Size(144, 49)
        Me.UltraButtonCarica.TabIndex = 0
        Me.UltraButtonCarica.Text = "Carica le consegne"
        '
        'UltraGroupBoxReportGiornaliero
        '
        Me.UltraGroupBoxReportGiornaliero.Controls.Add(Me.UltraGridReportGiornaliero)
        Me.UltraGroupBoxReportGiornaliero.Location = New System.Drawing.Point(4, 260)
        Me.UltraGroupBoxReportGiornaliero.Name = "UltraGroupBoxReportGiornaliero"
        Me.UltraGroupBoxReportGiornaliero.Size = New System.Drawing.Size(1143, 537)
        Me.UltraGroupBoxReportGiornaliero.TabIndex = 5
        Me.UltraGroupBoxReportGiornaliero.Text = "Report Giornaliero"
        Me.UltraGroupBoxReportGiornaliero.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGridReportGiornaliero
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridReportGiornaliero.DisplayLayout.Appearance = Appearance1
        Me.UltraGridReportGiornaliero.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridReportGiornaliero.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridReportGiornaliero.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridReportGiornaliero.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.UltraGridReportGiornaliero.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridReportGiornaliero.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.UltraGridReportGiornaliero.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridReportGiornaliero.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridReportGiornaliero.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridReportGiornaliero.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.UltraGridReportGiornaliero.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.UltraGridReportGiornaliero.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridReportGiornaliero.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridReportGiornaliero.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridReportGiornaliero.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridReportGiornaliero.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextHAlignAsString = "Center"
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridReportGiornaliero.DisplayLayout.Override.CellAppearance = Appearance8
        Me.UltraGridReportGiornaliero.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridReportGiornaliero.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridReportGiornaliero.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.UltraGridReportGiornaliero.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.UltraGridReportGiornaliero.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridReportGiornaliero.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridReportGiornaliero.DisplayLayout.Override.RowAppearance = Appearance11
        Me.UltraGridReportGiornaliero.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridReportGiornaliero.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.UltraGridReportGiornaliero.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridReportGiornaliero.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridReportGiornaliero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridReportGiornaliero.Location = New System.Drawing.Point(3, 16)
        Me.UltraGridReportGiornaliero.Name = "UltraGridReportGiornaliero"
        Me.UltraGridReportGiornaliero.Size = New System.Drawing.Size(1137, 518)
        Me.UltraGridReportGiornaliero.TabIndex = 11
        Me.UltraGridReportGiornaliero.Text = "UltraGrid1"
        '
        'ASDDBDataSet
        '
        Me.ASDDBDataSet.DataSetName = "ASDDBDataSet"
        Me.ASDDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.PITableAdapter = Nothing
        Me.TableAdapterManager.Tabella_AccettazioneTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_ChiusuraTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_ClasseTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_DispencerTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_DistribuzioniTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_Fascia_d_etàTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_FruizioneTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_GiroTableAdapter = Me.Tabella_GiroTableAdapter
        Me.TableAdapterManager.Tabella_Privilegio_TestataTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_Privilegio_UtenteTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_QualitàTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_QuartiereTableAdapter = Nothing
        Me.TableAdapterManager.Tabella_TipologiaTableAdapter = Nothing
        Me.TableAdapterManager.TestateTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ASD2.ASDDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UtentiTableAdapter = Nothing
        Me.TableAdapterManager.VariazioniTableAdapter = Nothing
        '
        'Tabella_GiroTableAdapter
        '
        Me.Tabella_GiroTableAdapter.ClearBeforeFill = True
        '
        'QRiepilogoGiornalieroBindingSource
        '
        Me.QRiepilogoGiornalieroBindingSource.DataMember = "QRiepilogoGiornaliero"
        Me.QRiepilogoGiornalieroBindingSource.DataSource = Me.ASDDBDataSet
        '
        'QRiepilogoGiornalieroTableAdapter
        '
        Me.QRiepilogoGiornalieroTableAdapter.ClearBeforeFill = True
        '
        'Tabella_GiroBindingSource
        '
        Me.Tabella_GiroBindingSource.DataMember = "Tabella Giro"
        Me.Tabella_GiroBindingSource.DataSource = Me.ASDDBDataSet
        '
        'UltraGridExcelExporter1
        '
        '
        'UltraGridDocumentExporter1
        '
        Me.UltraGridDocumentExporter1.TargetPaperOrientation = Infragistics.Documents.Reports.Report.PageOrientation.Landscape
        Me.UltraGridDocumentExporter1.TargetPaperSize = New Infragistics.Documents.Reports.Report.PageSize(595.0!, 842.0!)
        '
        'UltraGridPrintDocument1
        '
        Me.UltraGridPrintDocument1.DocumentName = "Report Giornaliero"
        Me.UltraGridPrintDocument1.Grid = Me.UltraGridReportGiornaliero
        '
        'UltraPrintPreviewDialog1
        '
        Me.UltraPrintPreviewDialog1.Name = "UltraPrintPreviewDialog1"
        '
        'ReportGiornaliero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.UltraGroupBoxReportGiornaliero)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.UltraGroupBoxData)
        Me.Name = "ReportGiornaliero"
        Me.Size = New System.Drawing.Size(1150, 800)
        CType(Me.UltraGroupBoxData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxData.ResumeLayout(False)
        CType(Me.UltraMonthViewSingleData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.UltraNumericEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewReportGiornaliero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBoxReportGiornaliero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxReportGiornaliero.ResumeLayout(False)
        CType(Me.UltraGridReportGiornaliero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASDDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QRiepilogoGiornalieroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabella_GiroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraCalendarInfo1 As Infragistics.Win.UltraWinSchedule.UltraCalendarInfo
    Friend WithEvents UltraCalendarLook1 As Infragistics.Win.UltraWinSchedule.UltraCalendarLook
    Friend WithEvents UltraGroupBoxData As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraMonthViewSingleData As Infragistics.Win.UltraWinSchedule.UltraMonthViewSingle
    Friend WithEvents UltraGroupBoxReportGiornaliero As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButtonCarica As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraDateTimeEditor1 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ASDDBDataSet As ASD2.ASDDBDataSet
    Friend WithEvents TableAdapterManager As ASD2.ASDDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UltraButtonCrea As Infragistics.Win.Misc.UltraButton
    Friend WithEvents QRiepilogoGiornalieroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QRiepilogoGiornalieroTableAdapter As ASD2.ASDDBDataSetTableAdapters.QRiepilogoGiornalieroTableAdapter
    Friend WithEvents DataGridViewReportGiornaliero As System.Windows.Forms.DataGridView
    Friend WithEvents Tabella_GiroTableAdapter As ASD2.ASDDBDataSetTableAdapters.Tabella_GiroTableAdapter
    Friend WithEvents Tabella_GiroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UltraButtonPDF As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonExcel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGridExcelExporter1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents UltraGridDocumentExporter1 As Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter
    Friend WithEvents UltraGridReportGiornaliero As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridPrintDocument1 As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
    Friend WithEvents UltraPrintPreviewDialog1 As Infragistics.Win.Printing.UltraPrintPreviewDialog
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraNumericEditor1 As Infragistics.Win.UltraWinEditors.UltraNumericEditor

End Class
