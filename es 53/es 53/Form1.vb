Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pezzi, prezzo, sconto, totale As Double
        prezzo = InputBox("Inserisci prezzo del prodotto")
        pezzi = InputBox("Inserisci numero dei pezzi")
        If (pezzi = 1) Then
            sconto = (prezzo * 10) / 100
            totale = prezzo - sconto
        ElseIf (pezzi = 3) Then
            sconto = (prezzo * 20) / 100
            totale = prezzo - sconto
        ElseIf (pezzi = 5) Then
            sconto = (prezzo * 30) / 100
            totale = prezzo - sconto
        ElseIf (pezzi = 10) Then
            sconto = (prezzo * 35) / 100
            totale = prezzo - sconto
        ElseIf (pezzi > 10) Then
            sconto = (prezzo * 40) / 100
            totale = prezzo - sconto
        Else
            MsgBox("Il totale è " & prezzo & "€")
            Close()
        End If
        MsgBox("Il totale è " & totale & "€")
        Close()
    End Sub
End Class
