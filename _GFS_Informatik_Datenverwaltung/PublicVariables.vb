Module PublicVariables

    Public kunden_id_module As Integer          'Wird bei der Anmeldung festgelegt, um zu sehen, welcher Kunde momentan angemeldet ist
    Public bearbeitenFensterSender As String    'Wird als Übergabeparameter an das Bearbeitungs- bzw. Suchfenster weitergegeben
    Public bestellenFensterSender As String     'Wird als Übergabeparameter an das Bestellfenster weitergegeben
    Public artikel_ausgewaehlt As Integer       'Wird als Sender des Items für einen Bestellvorgang benötigt


    'Für die Konsole
    Public Sub ScrollToEnd()
        Konsole.txtBox.SelectionStart = Konsole.txtBox.Text.Length
        Konsole.txtBox.ScrollToCaret()
    End Sub

End Module