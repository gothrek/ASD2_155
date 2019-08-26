<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Impostazioni
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
        Me.components = New System.ComponentModel.Container
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Impostazioni", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GiorniXPINuovi")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotaleConsegneinTestata")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StampaEdicole")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ColoreRighePINuovi")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stile")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seriale")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DataScadenza")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Licenze")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RitardoDiStampa")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DirectoryDiLavoro")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impostazioni1")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impostazioni2")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impostazioni3")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impostazioni4")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impostazioni5")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.ASDDBDataSet = New ASD2.ASDDBDataSet
        Me.ImpostazioniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImpostazioniTableAdapter = New ASD2.ASDDBDataSetTableAdapters.ImpostazioniTableAdapter
        Me.TableAdapterManager = New ASD2.ASDDBDataSetTableAdapters.TableAdapterManager
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        CType(Me.ASDDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImpostazioniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ASDDBDataSet
        '
        Me.ASDDBDataSet.DataSetName = "ASDDBDataSet"
        Me.ASDDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImpostazioniBindingSource
        '
        Me.ImpostazioniBindingSource.DataMember = "Impostazioni"
        Me.ImpostazioniBindingSource.DataSource = Me.ASDDBDataSet
        '
        'ImpostazioniTableAdapter
        '
        Me.ImpostazioniTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ImpostazioniTableAdapter = Me.ImpostazioniTableAdapter
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
        Me.TableAdapterManager.Tabella_GiroTableAdapter = Nothing
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
        'UltraGrid1
        '
        Me.UltraGrid1.DataSource = Me.ImpostazioniBindingSource
        Appearance13.BackColor = System.Drawing.Color.White
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.UltraGrid1.DisplayLayout.Appearance = Appearance13
        UltraGridBand1.CardView = True
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        Me.UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGrid1.DisplayLayout.InterBandSpacing = 10
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Me.UltraGrid1.DisplayLayout.Override.CardAreaAppearance = Appearance14
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance15.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.ForeColor = System.Drawing.Color.White
        Appearance15.TextHAlignAsString = "Left"
        Appearance15.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraGrid1.DisplayLayout.Override.HeaderAppearance = Appearance15
        Appearance16.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraGrid1.DisplayLayout.Override.RowAppearance = Appearance16
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance17.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.UltraGrid1.DisplayLayout.Override.RowSelectorAppearance = Appearance17
        Me.UltraGrid1.DisplayLayout.Override.RowSelectorWidth = 12
        Me.UltraGrid1.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance18.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Appearance18.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer))
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance18.ForeColor = System.Drawing.Color.Black
        Me.UltraGrid1.DisplayLayout.Override.SelectedRowAppearance = Appearance18
        Me.UltraGrid1.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UltraGrid1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(773, 482)
        Me.UltraGrid1.TabIndex = 2
        Me.UltraGrid1.Text = "Impostazioni"
        '
        'Impostazioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.UltraGrid1)
        Me.Name = "Impostazioni"
        CType(Me.ASDDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImpostazioniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ASDDBDataSet As ASD2.ASDDBDataSet
    Friend WithEvents ImpostazioniBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImpostazioniTableAdapter As ASD2.ASDDBDataSetTableAdapters.ImpostazioniTableAdapter
    Friend WithEvents TableAdapterManager As ASD2.ASDDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid

End Class
