Public Class Form1
    Dim repository As Repository = Repository.getInstance
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        repository.printMe()
    End Sub
End Class
