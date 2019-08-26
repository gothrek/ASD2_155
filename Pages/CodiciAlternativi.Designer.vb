<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodiciAlternativi
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
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Codici Alternativi", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PI")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Alternativo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipologia")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PI", 0)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodiceAlternativo", 1)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipologia", 2)
        Dim ColScrollRegion1 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(346)
        Dim ColScrollRegion2 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(-7)
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.CodiciAlternativiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASDDBDataSet = New ASD2.ASDDBDataSet
        Me.Codici_AlternativiTableAdapter = New ASD2.ASDDBDataSetTableAdapters.Codici_AlternativiTableAdapter
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraGridExcel = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBoxCodiciAlternativi = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraButtonPrint = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonEsporta = New Infragistics.Win.Misc.UltraButton
        Me.UltraPrintPreviewDialogDistribuzione = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
        Me.UltraGridPrintDocumentDistribuzione = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
        Me.UltraGridExcelExporter1 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.UltraGridDocumentExporter1 = New Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter(Me.components)
        CType(Me.CodiciAlternativiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASDDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.UltraGridExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBoxCodiciAlternativi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxCodiciAlternativi.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodiciAlternativiBindingSource
        '
        Me.CodiciAlternativiBindingSource.DataMember = "Codici Alternativi"
        Me.CodiciAlternativiBindingSource.DataSource = Me.ASDDBDataSet
        '
        'ASDDBDataSet
        '
        Me.ASDDBDataSet.DataSetName = "ASDDBDataSet"
        Me.ASDDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Codici_AlternativiTableAdapter
        '
        Me.Codici_AlternativiTableAdapter.ClearBeforeFill = True
        '
        'UltraGrid1
        '
        Me.UltraGrid1.DataSource = Me.CodiciAlternativiBindingSource
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.UltraGrid1.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 86
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 137
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 280
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGrid1.DisplayLayout.InterBandSpacing = 10
        Me.UltraGrid1.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGrid1.DisplayLayout.MaxRowScrollRegions = 1
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
        Me.UltraGrid1.Location = New System.Drawing.Point(3, 16)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(544, 457)
        Me.UltraGrid1.TabIndex = 0
        Me.UltraGrid1.Text = "Codici PI Alternativi"
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(697, 450)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(75, 23)
        Me.UltraButton1.TabIndex = 1
        Me.UltraButton1.Text = "Importa"
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.UltraGridExcel)
        Me.UltraGroupBox5.Location = New System.Drawing.Point(556, 3)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(354, 441)
        Me.UltraGroupBox5.TabIndex = 23
        Me.UltraGroupBox5.Text = "Importazione da Excel"
        Me.UltraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGridExcel
        '
        Me.UltraGridExcel.DataSource = Me.UltraDataSource1
        Appearance13.BackColor = System.Drawing.Color.White
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.UltraGridExcel.DisplayLayout.Appearance = Appearance13
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridColumn4.Width = 69
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.UltraGridExcel.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraGridExcel.DisplayLayout.ColScrollRegions.Add(ColScrollRegion1)
        Me.UltraGridExcel.DisplayLayout.ColScrollRegions.Add(ColScrollRegion2)
        Me.UltraGridExcel.DisplayLayout.InterBandSpacing = 10
        Me.UltraGridExcel.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridExcel.DisplayLayout.MaxRowScrollRegions = 1
        Me.UltraGridExcel.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.Yes
        Me.UltraGridExcel.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridExcel.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Me.UltraGridExcel.DisplayLayout.Override.CardAreaAppearance = Appearance14
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance15.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.ForeColor = System.Drawing.Color.White
        Appearance15.TextHAlignAsString = "Left"
        Appearance15.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraGridExcel.DisplayLayout.Override.HeaderAppearance = Appearance15
        Appearance16.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraGridExcel.DisplayLayout.Override.RowAppearance = Appearance16
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance17.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.UltraGridExcel.DisplayLayout.Override.RowSelectorAppearance = Appearance17
        Me.UltraGridExcel.DisplayLayout.Override.RowSelectorWidth = 12
        Me.UltraGridExcel.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.UltraGridExcel.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance18.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Appearance18.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer))
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance18.ForeColor = System.Drawing.Color.Black
        Me.UltraGridExcel.DisplayLayout.Override.SelectedRowAppearance = Appearance18
        Me.UltraGridExcel.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraGridExcel.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.UltraGridExcel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridExcel.Location = New System.Drawing.Point(3, 16)
        Me.UltraGridExcel.Name = "UltraGridExcel"
        Me.UltraGridExcel.Size = New System.Drawing.Size(348, 422)
        Me.UltraGridExcel.TabIndex = 0
        Me.UltraGridExcel.Text = "Codici alternativi importati"
        '
        'UltraGroupBoxCodiciAlternativi
        '
        Me.UltraGroupBoxCodiciAlternativi.Controls.Add(Me.UltraGrid1)
        Me.UltraGroupBoxCodiciAlternativi.Location = New System.Drawing.Point(3, 3)
        Me.UltraGroupBoxCodiciAlternativi.Name = "UltraGroupBoxCodiciAlternativi"
        Me.UltraGroupBoxCodiciAlternativi.Size = New System.Drawing.Size(550, 476)
        Me.UltraGroupBoxCodiciAlternativi.TabIndex = 24
        Me.UltraGroupBoxCodiciAlternativi.Text = "Tabella Codici Alternativi"
        Me.UltraGroupBoxCodiciAlternativi.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraButtonPrint
        '
        Me.UltraButtonPrint.Location = New System.Drawing.Point(556, 450)
        Me.UltraButtonPrint.Name = "UltraButtonPrint"
        Me.UltraButtonPrint.Size = New System.Drawing.Size(75, 23)
        Me.UltraButtonPrint.TabIndex = 25
        Me.UltraButtonPrint.Text = "Stampa"
        '
        'UltraButtonEsporta
        '
        Me.UltraButtonEsporta.Location = New System.Drawing.Point(778, 450)
        Me.UltraButtonEsporta.Name = "UltraButtonEsporta"
        Me.UltraButtonEsporta.Size = New System.Drawing.Size(129, 23)
        Me.UltraButtonEsporta.TabIndex = 26
        Me.UltraButtonEsporta.Text = "Esporta in Excel"
        '
        'UltraPrintPreviewDialogDistribuzione
        '
        Me.UltraPrintPreviewDialogDistribuzione.AutoSize = True
        Me.UltraPrintPreviewDialogDistribuzione.Document = Me.UltraGridPrintDocumentDistribuzione
        Me.UltraPrintPreviewDialogDistribuzione.Name = "UltraPrintPreviewDialogDistribuzione"
        Me.UltraPrintPreviewDialogDistribuzione.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        '
        'UltraGridPrintDocumentDistribuzione
        '
        Me.UltraGridPrintDocumentDistribuzione.DocumentName = "Codici PI Alternativi"
        Me.UltraGridPrintDocumentDistribuzione.Grid = Me.UltraGrid1
        '
        'UltraGridDocumentExporter1
        '
        Me.UltraGridDocumentExporter1.TargetPaperSize = New Infragistics.Documents.Reports.Report.PageSize(595.0!, 842.0!)
        '
        'CodiciAlternativi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.UltraButtonEsporta)
        Me.Controls.Add(Me.UltraButtonPrint)
        Me.Controls.Add(Me.UltraGroupBoxCodiciAlternativi)
        Me.Controls.Add(Me.UltraGroupBox5)
        Me.Controls.Add(Me.UltraButton1)
        Me.Name = "CodiciAlternativi"
        Me.Size = New System.Drawing.Size(913, 482)
        CType(Me.CodiciAlternativiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASDDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        CType(Me.UltraGridExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBoxCodiciAlternativi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxCodiciAlternativi.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CodiciAlternativiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASDDBDataSet As ASD2.ASDDBDataSet
    Friend WithEvents Codici_AlternativiTableAdapter As ASD2.ASDDBDataSetTableAdapters.Codici_AlternativiTableAdapter
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGridExcel As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBoxCodiciAlternativi As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButtonPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonEsporta As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraPrintPreviewDialogDistribuzione As Infragistics.Win.Printing.UltraPrintPreviewDialog
    Friend WithEvents UltraGridPrintDocumentDistribuzione As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
    Friend WithEvents UltraGridExcelExporter1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents UltraGridDocumentExporter1 As Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource

End Class
