Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports System.IO

Public Class CodiciAlternativi

    Private Sub TabellaCodiciAlternativi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Codici_AlternativiTableAdapter.Fill(Me.ASDDBDataSet.Codici_Alternativi)
    End Sub

    Private Sub UltraGrid1_AfterRowInsert(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowInsert
        Me.Codici_AlternativiTableAdapter.Update(Me.ASDDBDataSet.Codici_Alternativi)
    End Sub

    Private Sub UltraGrid1_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGrid1.AfterRowsDeleted
        Me.Codici_AlternativiTableAdapter.Update(Me.ASDDBDataSet.Codici_Alternativi)
        Me.Validate()
        Me.CodiciAlternativiBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.ASDDBDataSet)
    End Sub

    Private Sub UltraGrid1_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowUpdate
        Me.Codici_AlternativiTableAdapter.Update(Me.ASDDBDataSet.Codici_Alternativi)
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Form1.UltraStatusBar1.Panels(0).Text = "Sto caricando i dati dei codici alternativi."
        Form1.UltraStatusBar1.Panels(1).Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.Marquee
        Form1.UltraStatusBar1.Panels(1).Visible = True
        Form1.UltraStatusBar1.Refresh()
        For i As Integer = UltraGridExcel.Rows.Count - 1 To 0 Step -1
            UltraGridExcel.Rows(i).Delete(False)
        Next
        Try
            'Read the copied data from the Clipboard
            Dim objPresumablyExcel As IDataObject = Clipboard.GetDataObject()

            'Proceed if some copied data is present
            If Not objPresumablyExcel Is Nothing Then

                'Next proceed only of the copied data is in the CSV format indicating Excel content
                If (objPresumablyExcel.GetDataPresent(DataFormats.CommaSeparatedValue)) Then

                    'Cast the copied data in the CommaSeparatedValue format & hold in a StreamReader Object
                    Dim srReadExcel As New StreamReader(CType(objPresumablyExcel.GetData(DataFormats.CommaSeparatedValue), Stream))
                    Dim sFormattedData As String

                    'Set the delimiter character for use in splitting the copied data
                    Dim charDelimiterArray() As Char = {";"}

                    'Define a DataTable to hold the copied data for binding to the DataGrid
                    Dim tblExcel2WinData As New DataTable

                    'Loop till no further data is available
                    While (srReadExcel.Peek() > 0)
                        'Array to hold the split data for each row
                        Dim arrSplitData As Array

                        'Multipurpose Loop Counter
                        Dim iLoopCounter As Integer = 0

                        'Read a line of data from the StreamReader object
                        sFormattedData = srReadExcel.ReadLine()

                        'Split the string contents into an array
                        arrSplitData = sFormattedData.Split(charDelimiterArray)

                        If tblExcel2WinData.Columns.Count <= 0 Then
                            For iLoopCounter = 0 To arrSplitData.GetUpperBound(0)
                                tblExcel2WinData.Columns.Add()
                            Next
                            iLoopCounter = 0
                        End If

                        'Row to hold a single row of the Excel Data
                        Dim rowNew As DataRow
                        rowNew = tblExcel2WinData.NewRow()


                        For iLoopCounter = 0 To arrSplitData.GetUpperBound(0)
                            rowNew(iLoopCounter) = arrSplitData.GetValue(iLoopCounter)
                        Next
                        iLoopCounter = 0

                        'Add the row back to the DataTable
                        tblExcel2WinData.Rows.Add(rowNew)

                        rowNew = Nothing
                    End While

                    'Close the StreamReader object
                    srReadExcel.Close()

                    'Bind the data to the DataGrid
                    'DataGridViewExcel.DataSource = tblExcel2WinData.DefaultView()
                    'UltraGridExcel.DataSource = tblExcel2WinData.DefaultView()
                    Form1.UltraStatusBar1.Panels(1).Style = UltraWinStatusBar.PanelStyle.Progress
                    Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Maximum = 100
                    Form1.UltraStatusBar1.Refresh()
                    For i As Integer = 0 To tblExcel2WinData.Rows.Count - 1
                        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(i / (tblExcel2WinData.Rows.Count - 1) * 100)
                        Form1.UltraStatusBar1.Refresh()
                        UltraGridExcel.DisplayLayout.Bands(0).AddNew()
                        UltraGridExcel.Rows(i).Cells("PI").Value = tblExcel2WinData.Rows(i).Item(0)
                        UltraGridExcel.Rows(i).Cells("CodiceAlternativo").Value = tblExcel2WinData.Rows(i).Item(1)
                        UltraGridExcel.Rows(i).Cells("Tipologia").Value = tblExcel2WinData.Rows(i).Item(2)
                        UltraGrid1.DisplayLayout.Bands(0).AddNew()
                        UltraGrid1.Rows(UltraGrid1.Rows.Count - 1).Cells("PI").Value = UltraGridExcel.Rows(i).Cells("PI").Value
                        UltraGrid1.Rows(UltraGrid1.Rows.Count - 1).Cells("Alternativo").Value = UltraGridExcel.Rows(i).Cells("CodiceAlternativo").Value
                        UltraGrid1.Rows(UltraGrid1.Rows.Count - 1).Cells("Tipologia").Value = UltraGridExcel.Rows(i).Cells("Tipologia").Value

                    Next
                    Form1.UltraStatusBar1.Panels(0).Text = "Dati della distribuzione importati correttamente."
                    Form1.UltraStatusBar1.Panels(1).Visible = False
                    Form1.UltraStatusBar1.Refresh()
                    MsgBox("Importazione completata con successo!!")
                Else
                    Form1.UltraStatusBar1.Panels(0).Text = "Importazione fallita!!"
                    Form1.UltraStatusBar1.Panels(1).Visible = False
                    Form1.UltraStatusBar1.Refresh()
                    MsgBox("I dati copiati non sono di Excel, verifica!", MsgBoxStyle.Critical)
                End If
            Else
                Form1.UltraStatusBar1.Panels(0).Text = "Importazione fallita!!"
                Form1.UltraStatusBar1.Panels(1).Visible = False
                Form1.UltraStatusBar1.Refresh()
                MsgBox("Non c'è nulla di copiato, verifica!", MsgBoxStyle.Information)
            End If
        Catch exp As Exception
            MsgBox(exp.Message)
        End Try
        Form1.UltraStatusBar1.Panels(1).Visible = False
        Form1.UltraStatusBar1.Refresh()
    End Sub

    Private Sub UltraButtonPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonPrint.Click
        UltraGridPrintDocumentDistribuzione.DocumentName = "Codici PI alternativi"
        UltraPrintPreviewDialogDistribuzione.ShowDialog()
    End Sub

    Private Sub UltraButtonEsporta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonEsporta.Click
        Form1.UltraStatusBar1.Panels(1).Visible = True
        Dim percorso As String = Form1.dvimpostazioni.Item(0).Item(9).ToString
        Try
            System.IO.Directory.CreateDirectory(percorso)
        Catch ex As Exception
            'la directory già esiste
        End Try
        Dim nomefile As String = "CodiciAlternativi" & "-" & Today.Year & "-" & Today.Month & "-" & Today.Day & ".xls"
        UltraGridExcelExporter1.Export(UltraGrid1, percorso & "\" & nomefile)
    End Sub

    Private Sub UltraGridExcelExporter1_RowExporting(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.ExcelExport.RowExportingEventArgs)
        Form1.UltraStatusBar1.Panels(0).Text = "Sto esportando la riga: " & e.GridRow.Index & " di " & UltraGrid1.Rows.Count
        Form1.UltraStatusBar1.Panels(1).ProgressBarInfo.Value = Int(e.CurrentRowIndex / (UltraGrid1.Rows.Count - 1) * 100)
        Form1.UltraStatusBar1.Refresh()
    End Sub

End Class
