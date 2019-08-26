''' <summary>
''' Rappresenta la classe base da cui derivano tutte le pagine dell'applicazione.
''' Fornisce metodi di infrastruttura che possono essere "ridefiniti" nelle classi
''' discendenti allo scopo di personalizzare ciascuna pagina specifica.
''' </summary>
''' <remarks>
''' Ogni UserControl che costituisce una pagina dell'applicazione dovrà ereditare
''' questa classe. E' possibile definire caratteristiche (proprietà), aggiungere
''' controlli e introdurre nuovi metodi che dovranno essere comuni a tutte le 
''' pagine dell'applicazione (es. livello di accesso, colore, icona, ...).
''' </remarks>
Public Class BasePage

    ''' <summary>
    ''' Restituisce il titolo descrittivo della pagina di riferimento.
    ''' Il titolo verrà acquisito dalla finestra principale dell'applicazione
    ''' e visualizzato in un'apposita etichetta.
    ''' </summary>
    ''' <returns>Il titolo della pagina</returns>
    ''' <remarks>
    ''' Ridefinire questo metodo nelle classi discendenti per restituire
    ''' un titolo differente rispetto a quello predefinito (vuoto).
    ''' </remarks>
    Public Overridable Function GetTitle() As String
        Return System.String.Empty
    End Function

    ''' <summary>
    ''' Restituisce la costante che identifica il tipo di pagina specifico.
    ''' </summary>
    ''' <returns>
    ''' Il valore enumerativo relativo al tipo di pagina.
    ''' </returns>
    ''' <remarks>
    ''' Ridefinire questo metodo nelle classi discendenti per restituire
    ''' un valore differente che identifichi la pagina; se necessario,
    ''' aggiungere un nuovo valore al tipo enumerativo per rappresentare
    ''' nuove pagine aggiunte in seguito.
    ''' </remarks>
    Public Overridable Function GetKind() As PageKind
        Return PageKind.Undefined
    End Function

End Class
