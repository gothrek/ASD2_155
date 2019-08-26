Public Class StartupPage

    Dim password As String = ""
    Dim posizione As Integer = 0
    Private Sub StartupPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UltraFormattedLinkLabel1.Value = "(c) 2007-" & Today.Year.ToString & " Northia Multimedia Solution"
    End Sub

    Private Sub UltraButtonPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonPassword.Click
        ControllaPassword()
    End Sub

    Private Sub ControllaPassword()
        If password = "admin" Then
            Form1.UltraToolbarsManager1.Ribbon.Tabs.Item(0).Visible = True
            Form1.UltraToolbarsManager1.Ribbon.Tabs.Item(1).Visible = True
            Form1.UltraToolbarsManager1.Ribbon.Tabs.Item(2).Visible = True
            Form1.UltraToolbarsManager1.Ribbon.Tabs.Item(3).Visible = True
            UltraLabelPassword.Visible = False
            UltraFormattedTextEditorPassword.Visible = False
            UltraButtonPassword.Visible = False
        Else
            If UltraFormattedTextEditorPassword.Text = "cambiapassword" Then

            End If
            MsgBox("Password errata!!!", MsgBoxStyle.Critical)
        End If
        password = ""
        posizione = 0
        UltraFormattedTextEditorPassword.Text = ""
        UltraFormattedTextEditorPassword.Focus()
    End Sub

    Private Sub UltraFormattedTextEditorPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UltraFormattedTextEditorPassword.KeyPress
        Dim appoggio As String = ""
        Dim memorizza As Boolean = True
        Try
            If Asc(e.KeyChar) = Keys.Back Then
                password = Microsoft.VisualBasic.Left(password, password.Length - 1)
                posizione = posizione - 1
                For i As Integer = 0 To (posizione - 1)
                    appoggio = appoggio & "*"
                Next
                memorizza = False
            End If

            If Asc(e.KeyChar) = Keys.Enter Then
                ControllaPassword()
                memorizza = False
            End If

            If memorizza Then
                password = password & e.KeyChar
                For i As Integer = 0 To (posizione - 1)
                    appoggio = appoggio & "*"
                Next
                'appoggio = appoggio & e.KeyChar
                posizione = posizione + 1
            End If
            UltraFormattedTextEditorPassword.Text = appoggio
            UltraButtonPassword.Refresh()
        Catch ex As Exception
            MsgBox("Errore nell'inserimento della password!!", MsgBoxStyle.Critical)
        End Try

    End Sub

End Class
