<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartupPage
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraFormattedLinkLabel1 = New Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel()
        Me.UltraFormattedLinkLabel2 = New Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel()
        Me.UltraFormattedTextEditorPassword = New Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor()
        Me.UltraButtonPassword = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabelPassword = New Infragistics.Win.Misc.UltraLabel()
        Me.SuspendLayout()
        '
        'UltraFormattedLinkLabel1
        '
        Appearance1.FontData.SizeInPoints = 24.0!
        Appearance1.TextHAlignAsString = "Center"
        Appearance1.TextVAlignAsString = "Middle"
        Me.UltraFormattedLinkLabel1.Appearance = Appearance1
        Me.UltraFormattedLinkLabel1.AutoSize = True
        Me.UltraFormattedLinkLabel1.Location = New System.Drawing.Point(67, 427)
        Me.UltraFormattedLinkLabel1.Name = "UltraFormattedLinkLabel1"
        Me.UltraFormattedLinkLabel1.Size = New System.Drawing.Size(603, 38)
        Me.UltraFormattedLinkLabel1.TabIndex = 1
        Me.UltraFormattedLinkLabel1.TabStop = True
        Me.UltraFormattedLinkLabel1.Value = "(c) 2007-" & Today.Year.ToString & " Northia Multimedia Solution"
        '
        'UltraFormattedLinkLabel2
        '
        Appearance2.FontData.SizeInPoints = 96.0!
        Appearance2.TextHAlignAsString = "Center"
        Appearance2.TextVAlignAsString = "Middle"
        Me.UltraFormattedLinkLabel2.Appearance = Appearance2
        Me.UltraFormattedLinkLabel2.AutoSize = True
        Me.UltraFormattedLinkLabel2.Location = New System.Drawing.Point(183, 58)
        Me.UltraFormattedLinkLabel2.Name = "UltraFormattedLinkLabel2"
        Me.UltraFormattedLinkLabel2.Size = New System.Drawing.Size(374, 146)
        Me.UltraFormattedLinkLabel2.TabIndex = 2
        Me.UltraFormattedLinkLabel2.TabStop = True
        Me.UltraFormattedLinkLabel2.Value = "A.S.D."
        '
        'UltraFormattedTextEditorPassword
        '
        Me.UltraFormattedTextEditorPassword.Location = New System.Drawing.Point(515, 343)
        Me.UltraFormattedTextEditorPassword.Name = "UltraFormattedTextEditorPassword"
        Me.UltraFormattedTextEditorPassword.Size = New System.Drawing.Size(155, 23)
        Me.UltraFormattedTextEditorPassword.TabIndex = 3
        Me.UltraFormattedTextEditorPassword.Value = ""
        '
        'UltraButtonPassword
        '
        Me.UltraButtonPassword.Location = New System.Drawing.Point(677, 343)
        Me.UltraButtonPassword.Name = "UltraButtonPassword"
        Me.UltraButtonPassword.Size = New System.Drawing.Size(75, 23)
        Me.UltraButtonPassword.TabIndex = 4
        Me.UltraButtonPassword.Text = "Accedi"
        '
        'UltraLabelPassword
        '
        Appearance3.TextHAlignAsString = "Center"
        Me.UltraLabelPassword.Appearance = Appearance3
        Me.UltraLabelPassword.Location = New System.Drawing.Point(515, 307)
        Me.UltraLabelPassword.Name = "UltraLabelPassword"
        Me.UltraLabelPassword.Size = New System.Drawing.Size(155, 30)
        Me.UltraLabelPassword.TabIndex = 5
        Me.UltraLabelPassword.Text = "Inserire la password per accedere al programma"
        '
        'StartupPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.UltraLabelPassword)
        Me.Controls.Add(Me.UltraButtonPassword)
        Me.Controls.Add(Me.UltraFormattedTextEditorPassword)
        Me.Controls.Add(Me.UltraFormattedLinkLabel2)
        Me.Controls.Add(Me.UltraFormattedLinkLabel1)
        Me.Name = "StartupPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraFormattedLinkLabel1 As Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel
    Friend WithEvents UltraFormattedLinkLabel2 As Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel
    Friend WithEvents UltraFormattedTextEditorPassword As Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor
    Friend WithEvents UltraButtonPassword As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabelPassword As Infragistics.Win.Misc.UltraLabel

End Class
