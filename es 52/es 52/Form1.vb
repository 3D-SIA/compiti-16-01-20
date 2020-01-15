Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim scaglione As String
        Dim trattenuta, stipendio As Double
        stipendio = InputBox("Inserisci lo stipendio")
        scaglione = InputBox("Inserisci numero scaglione")
        If (scaglione = "1") Then
            trattenuta = (stipendio * 5) / 100
        Else
            If (scaglione = "2") Then
                trattenuta = (stipendio * 10) / 100
            Else
                If (scaglione = "3") Then
                    trattenuta = (stipendio * 15) / 100
                Else
                    If (scaglione = "4") Then
                        trattenuta = (stipendio * 25) / 100
                    Else
                        If (scaglione = "5") Then
                            trattenuta = (stipendio * 35) / 100
                        Else
                            Return
                        End If
                    End If
                End If
            End If
        End If
        MsgBox("La trattenuta da versare è di " & trattenuta & "€")
    End Sub
End Class
