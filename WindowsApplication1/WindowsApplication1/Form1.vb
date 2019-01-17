Public Class Form1

    Private Sub checkboxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxShowPassword.CheckedChanged
        If checkboxShowPassword.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub
    
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

        Dim boolLowercase As Boolean = False
        Dim boolUppercase As Boolean = False
        Dim boolNumbers As Boolean = False
        Dim boolSymbols As Boolean = False
        Dim boolSpace As Boolean = False
        Dim strength As Integer = 0

        For Each c As Char In txtPassword.Text
            If Char.IsLower(c) Then
                boolLowercase = True
                Console.WriteLine(boolLowercase)
            ElseIf Char.IsUpper(c) Then
                boolUppercase = True
            ElseIf Char.IsNumber(c) Then
                boolNumbers = True
            ElseIf c = " " Then
                boolSpace = True
            Else
                boolSymbols = True
            End If
        Next

        If boolLowercase = True Then
            lblLowercase.Image = My.Resources.tick
            strength = strength + 10
        Else
            lblLowercase.Image = My.Resources.cross
        End If

        If boolUppercase = True Then
            lblUppercase.Image = My.Resources.tick
            strength = strength + 10
        Else
            lblUppercase.Image = My.Resources.cross
        End If

        If boolNumbers = True Then
            lblNumbers.Image = My.Resources.tick
            strength = strength + 10
        Else
            lblNumbers.Image = My.Resources.cross
        End If

        If boolSymbols = True Then
            lblSymbols.Image = My.Resources.tick
            strength = strength + 10
        Else
            lblSymbols.Image = My.Resources.cross
        End If

        If strength = 0 Then
            Me.BackColor = Color.Red
        ElseIf strength = 10 Then
            Me.BackColor = Color.OrangeRed
        ElseIf strength = 20 Then
            Me.BackColor = Color.Yellow
        ElseIf strength = 30 Then
            Me.BackColor = Color.YellowGreen
        ElseIf strength = 40 Then
            Me.BackColor = Color.Green
        End If

    End Sub
End Class
