Public Class Form2
    Public dictSavedPasswords As New Dictionary(Of String, String)
    Public Property username As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dictSavedPasswords.ContainsKey(username) Then
            lblSaved.Text = dictSavedPasswords(username)
        Else
            lblSaved.Text = "No saved password"
        End If

    End Sub
End Class