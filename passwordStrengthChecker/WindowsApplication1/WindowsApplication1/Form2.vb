Public Class Form2

    Public dictSavedPasswords As New Dictionary(Of String, String)

    Public Property username As String

    Dim CW As Integer = Me.Width    ' Current Width of Form2
    Dim CH As Integer = Me.Height   ' Current Height of Form2
    Dim IW As Integer = Me.Width    ' Initial Width  of Form2
    Dim IH As Integer = Me.Height   ' Initial Height of Form2


    ' Function to resize the components in Form1 with respect to change in size of Form1

    Private Sub Form2_Resize(ByVal sender As Object, _
            ByVal e As System.EventArgs) Handles Me.Resize


        Dim RW As Double = (Me.Width - CW) / CW     ' Ratio change of width
        Dim RH As Double = (Me.Height - CH) / CH    ' Ratio change of height

        ' Operations to resize the width and height

        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
        Next

        CW = Me.Width
        CH = Me.Height

    End Sub


    ' Function to load username and checking his/her last saved password saved in the dictionary "dictSavedPasswords"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = username

        ' Checking condition if there is any last password saved for the username and changing the outout mrssage according to it

        If dictSavedPasswords.ContainsKey(username) Then
            lblSaved.Text = dictSavedPasswords(username)
        Else
            lblSaved.Text = "No saved password"
        End If

    End Sub

End Class