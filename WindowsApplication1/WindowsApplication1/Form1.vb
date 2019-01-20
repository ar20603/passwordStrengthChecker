
Public Class Form1

    Dim CW As Integer = Me.Width ' Current Width
    Dim CH As Integer = Me.Height ' Current Height
    Dim IW As Integer = Me.Width ' Initial Width
    Dim IH As Integer = Me.Height ' Initial Height

    Private Sub Form1_Resize(ByVal sender As Object, _
            ByVal e As System.EventArgs) Handles Me.Resize

        Dim RW As Double = (Me.Width - CW) / CW ' Ratio change of width
        Dim RH As Double = (Me.Height - CH) / CH ' Ratio change of height

        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
        Next

        CW = Me.Width
        CH = Me.Height

    End Sub

    Private Sub checkboxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxShowPassword.CheckedChanged
        If checkboxShowPassword.Checked = True Then
            textPassword.PasswordChar = ""
        Else
            textPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles textPassword.TextChanged

        ' Score Calculation
        Dim password As String = textPassword.Text
        Dim len As Integer = textPassword.TextLength
        Dim score As Integer = 0
        Dim message As String

        ' Variables declaration
        Dim uppercase As Integer = 0
        Dim lowercase As Integer = 0
        Dim numbers As Integer = 0
        Dim symbols As Integer = 0
        Dim requirements As Integer = 0
        Dim middleNumOrSym = 0
        Dim isSpace As Boolean = False
        Dim lettersOnly As Boolean = True
        Dim numbersOnly As Boolean = True

        ' Additions
        For Each c In password
            If Char.IsUpper(c) Then
                uppercase += 1
                numbersOnly = False
            ElseIf Char.IsLower(c) Then
                lowercase += 1
                numbersOnly = False
            ElseIf Char.IsNumber(c) Then
                numbers += 1
                lettersOnly = False
            ElseIf c = " " Then
                isSpace = True
            Else
                symbols += 1
                lettersOnly = False
            End If
        Next

        ' requirements
        If uppercase > 0 Then
            requirements += 1
        End If

        If lowercase > 0 Then
            requirements += 1
        End If

        If symbols > 0 Then
            requirements += 1
        End If

        If numbers > 0 Then
            requirements += 1
        End If

        If password.Length >= 8 Then
            requirements += 1
        End If

        ' Middle Numbers Or Symbols
        For i = 1 To password.Length - 2
            If Not Char.IsLetter(password.Chars(i)) Then
                middleNumOrSym += 1
            End If
        Next

        ' Repeat Characters


        ' Score Additions
        score += len * 4
        score += (len - uppercase) * 2
        score += (len - lowercase) * 2
        score += numbers * 4
        score += symbols * 6
        score += middleNumOrSym * 2
        score += requirements * 2

        ' Score Deductions
        If lettersOnly = True Then
            score -= (lowercase + uppercase)
        End If

        If numbersOnly = True Then
            score -= numbers
        End If

        ' Background Change
        If score <= 50 Then
            Me.BackColor = Color.FromArgb(192, 0, 0)
            message = "VERY WEAK"
        ElseIf score <= 100 Then
            Me.BackColor = Color.Red
            message = "WEAK"
        ElseIf score <= 150 Then
            Me.BackColor = Color.FromArgb(192, 64, 0)
            message = "WEAK"
        ElseIf score <= 200 Then
            Me.BackColor = Color.FromArgb(255, 128, 0)
            message = "AVERAGE"
        ElseIf score <= 250 Then
            Me.BackColor = Color.Yellow
            message = "GOOD"
        ElseIf score <= 300 Then
            Me.BackColor = Color.FromArgb(192, 192, 0)
            message = "GOOD"
        ElseIf score <= 350 Then
            Me.BackColor = Color.Lime
            message = "STRONG"
        Else
            Me.BackColor = Color.FromArgb(0, 192, 0)
            message = "VERY STRONG"
        End If

        Dim strength As Decimal = (score / 800.0) * 100.0
        labelMessage.Text = "Your password is " & message & " with " & strength & "% strength!"

    End Sub

End Class

