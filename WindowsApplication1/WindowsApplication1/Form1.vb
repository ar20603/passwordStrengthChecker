
Public Class Form1

    Dim CW As Integer = Me.Width ' Current Width
    Dim CH As Integer = Me.Height ' Current Height
    Dim IW As Integer = Me.Width ' Initial Width
    Dim IH As Integer = Me.Height ' Initial Height
    Dim dictSavedPasswords As New Dictionary(Of String, String)

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

        ' Word dictionary for common words
        Dim wordDict As New Dictionary(Of String, Integer)
        'Dim lines = IO.File.ReadAllLines(My.Resources.dictionary)

        'For i = 0 To lines.Length - 1
        'wordDict.Add(lines(i), 1)
        'Next

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
        Dim repeatChars As Integer = 0
        Dim consecChars As Integer = 0
        Dim seqChars = 0
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
        Dim charDict As New Dictionary(Of String, Integer)
        For Each c In password
            If Char.IsLetter(c) Then
                If charDict.ContainsKey(Char.IsLower(c)) Then
                    charDict(Char.IsLower(c)) += 1
                Else
                    charDict(Char.IsLower(c)) = 1
                End If
            Else
                If charDict.ContainsKey(c) Then
                    charDict(c) += 1
                Else
                    charDict(c) = 1
                End If
            End If
        Next

        For Each pair In charDict
            If pair.Value > 1 Then
                repeatChars += pair.Value
            End If
        Next

        ' Consecutive Letters
        Dim j As Integer = 1
        While j < password.Length
            Dim num As Integer = 0
            While j < password.Length
                If Char.IsLetter(password.Chars(j)) And Char.IsNumber(password.Chars(j)) And password.Chars(j) = password.Chars(j - 1) Then
                    num += 1
                    j += 1
                Else
                    Exit While
                End If
            End While
            j += 1
            consecChars += num + 1
        End While

        ' Sequential Letters
        j = 1
        While j < password.Length
            Dim num As Integer = 0
            While j < password.Length
                If Convert.ToByte(password.Chars(j)) = 1 + Convert.ToByte(password.Chars(j - 1)) Then
                    num += 1
                    j += 1
                Else
                    Exit While
                End If
            End While
            j += 1
            seqChars += num + 1
        End While

        ' Score Additions
        score += len * 4
        Console.Write(score & " ")

        If uppercase > 0 Then
            score += (len - uppercase) * 2
        End If
        Console.Write(score & " ")

        If lowercase > 0 Then
            score += (len - lowercase) * 2
        End If
        Console.Write(score & " ")

        score += numbers * 4
        Console.Write(score & " ")

        score += symbols * 6
        Console.Write(score & " ")

        score += middleNumOrSym * 2
        Console.Write(score & " ")

        If requirements >= 5 Then
            score += requirements * 2
        End If
        Console.Write(score & " ")

        ' Score Deductions
        If lettersOnly Then
            score -= (lowercase + uppercase)
        End If
        Console.Write(score & " ")

        If numbersOnly Then
            score -= numbers
        End If
        Console.Write(score & " ")

        score -= repeatChars
        Console.Write(score & " ")

        score -= consecChars * 2
        Console.Write(score & " ")

        If seqChars >= 3 Then
            score -= seqChars * 3
        End If
        Console.Write(score & " ")

        ' Score Normalization
        score = Math.Max(0, score)

        ' Background Change
        If score <= 40 Then
            Me.BackColor = Color.FromArgb(192, 0, 0)
            message = "VERY WEAK"
        ElseIf score <= 80 Then
            Me.BackColor = Color.Red
            message = "WEAK"
        ElseIf score <= 120 Then
            Me.BackColor = Color.FromArgb(192, 64, 0)
            message = "WEAK"
        ElseIf score <= 160 Then
            Me.BackColor = Color.FromArgb(255, 128, 0)
            message = "AVERAGE"
        ElseIf score <= 200 Then
            Me.BackColor = Color.Yellow
            message = "GOOD"
        ElseIf score <= 240 Then
            Me.BackColor = Color.FromArgb(192, 192, 0)
            message = "GOOD"
        ElseIf score <= 280 Then
            Me.BackColor = Color.Lime
            message = "STRONG"
        Else
            Me.BackColor = Color.FromArgb(0, 192, 0)
            message = "VERY STRONG"
        End If

        Dim strength As Decimal = Math.Min((score / 500) * 100.0, 100.0)
        Console.WriteLine(score)
        labelMessage.Text = "Your password is " & message & " with " & strength & "% strength!"

    End Sub

    Private Sub btnSavePassword_Click(sender As Object, e As EventArgs) Handles btnSavePassword.Click
        If textPassword.Text = "" Then
            Console.WriteLine("no text")
        Else
            If dictSavedPasswords.ContainsKey(txtUsername.Text) Then
                dictSavedPasswords(txtUsername.Text) = textPassword.Text
                Console.WriteLine("123")
            Else
                dictSavedPasswords.Add(txtUsername.Text, textPassword.Text)
                Console.WriteLine("456")
            End If

        End If

    End Sub

    Private Sub btnMySavedPassword_Click(sender As Object, e As EventArgs) Handles btnMySavedPassword.Click
        Dim OBJ As New Form2
        OBJ.dictSavedPasswords = dictSavedPasswords
        OBJ.username = txtUsername.Text
        OBJ.Show()
    End Sub

End Class

