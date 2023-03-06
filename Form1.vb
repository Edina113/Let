Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim zahtjev As String
        zahtjev = "Destinacija je: " + lstGrad.Text + vbCr
        zahtjev = zahtjev + "Mjesto sjedenja je: " + cmbSjediste.Text + vbCr
        MsgBox(zahtjev, vbOKOnly + vbInformation, "Vaš izbor je: ")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstGrad.Items.Add("Sarajevo")
        lstGrad.Items.Add("Istanbul")
        lstGrad.Items.Add("Zagreb")
        lstGrad.Items.Add("Rim")
        lstGrad.Items.Add("Melburn")

        cmbSjediste.Items.Add("Na početku")
        cmbSjediste.Items.Add("Na sredini")
        cmbSjediste.Items.Add("Na kraju")

    End Sub
End Class
