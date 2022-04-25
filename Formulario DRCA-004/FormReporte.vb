Public Class FormReporte
    Private Sub FormReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Form1.tbnombrecomercial.Text
        Label2.Text = Form1.tbNIT.text
    End Sub
End Class