
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
        Dim lines = IO.File.ReadAllLines("G:\passwordStrengthChecker\WindowsApplication1\Media\dictionary.txt")

        For i = 0 To lines.Length - 1
            wordDict.Add(lines(i), 1)
        Next

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
        Dim isCommon As Boolean = False

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
        'Dim charDict As New Dictionary(Of Char, Integer)
        'For i = 0 To password.Length - 1
        '    If Char.IsLetter(password.Chars(i)) Then
        '        If charDict.ContainsKey(Char.ToLower(password.Chars(i))) Then
        '            charDict(Char.ToLower(password.Chars(i))) += 1
        '        Else
        '            charDict.Add(Char.ToLower(password.Chars(i)), 1)
        '        End If
        '    Else
        '        If charDict.ContainsKey(password.Chars(i)) Then
        '            charDict(password.Chars(i)) += 1
        '        Else
        '            Console.WriteLine(password.Chars(i))
        '            charDict.Add(password.Chars(i), 1)
        '        End If
        '    End If
        'Next

        'For Each pair In charDict
        '    If pair.Value > 1 Then
        '        repeatChars += pair.Value
        '    End If
        'Next

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
            If num > 0 Then
                consecChars += (num + 1)
            End If
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
            If num > 0 Then
                seqChars += (num + 1)
            End If
        End While

        ' Score Additions
        score += len * 4
        Console.Write(score & " ")

        If uppercase > 0 Then
            lblUppercase.Image = My.Resources.tick
            score += (len - uppercase) * 2
        Else
            lblUppercase.Image = My.Resources.cross
        End If
        Console.Write(score & " ")

        If lowercase > 0 Then
            lblLowercase.Image = My.Resources.tick
            score += (len - lowercase) * 2
        Else
            lblLowercase.Image = My.Resources.cross
        End If
        Console.Write(score & " ")

        If numbers > 0 Then
            lblNumbers.Image = My.Resources.tick
        Else
            lblNumbers.Image = My.Resources.cross
        End If

        If symbols > 0 Then
            lblSymbols.Image = My.Resources.tick
        Else
            lblSymbols.Image = My.Resources.cross
        End If

        If lowercase > 0 Or uppercase > 0 Or symbols > 0 Then
            score += numbers * 2
        End If
        Console.Write(score & " ")

        score += symbols * 4
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

        'score -= repeatChars
        'Console.Write(score & " ")

        score -= consecChars
        Console.Write(score & " ")

        If seqChars >= 3 Then
            score -= (seqChars - 2) * 2
        End If
        Console.WriteLine(score, " ")
        Console.WriteLine(seqChars)

        For j = 0 To password.Length - 1
            For k = 1 To password.Length - j
                If wordDict.ContainsKey(password.Substring(j, k)) Then
                    isCommon = True
                End If
            Next
        Next

        ' Score Normalization
        score = Math.Max(0, score)

        ' Background Change
        If isSpace Then
            labelMessage.Text = "Invalid Password! Please don't use spaces."
            score = 0
        End If

        If wordDict.ContainsKey(password) Then
            score = 0
            labelMessage.Text = "Don't use common words as password! This will make your password weaker."
        ElseIf isCommon = True Then
            score /= 2
            labelMessage.Text = "Don't use common words in your password! This will make your password weaker."
        End If

        If score <= 20 Then
            Me.BackColor = Color.FromArgb(192, 0, 0)
            message = "VERY WEAK"
        ElseIf score <= 40 Then
            Me.BackColor = Color.Red
            message = "WEAK"
        ElseIf score <= 60 Then
            Me.BackColor = Color.FromArgb(192, 64, 0)
            message = "AVERAGE"
        ElseIf score <= 80 Then
            Me.BackColor = Color.Yellow
            message = "GOOD"
        ElseIf score <= 100 Then
            Me.BackColor = Color.Lime
            message = "STRONG"
        Else
            Me.BackColor = Color.FromArgb(0, 192, 0)
            message = "VERY STRONG"
        End If

        Dim strength As Decimal = Math.Min((score / 120) * 100.0, 100.0)

        Console.WriteLine(isCommon)
        If Not isSpace And Not isCommon And Not wordDict.ContainsKey(password) Then
            labelMessage.Text = "Your password is " & message & " with " & strength & "% strength!"
        End If
    End Sub

    Private Sub btnSavePassword_Click(sender As Object, e As EventArgs) Handles btnSavePassword.Click
        If textPassword.Text = "" Then
            Console.WriteLine("no text")
        Else
            If dictSavedPasswords.ContainsKey(txtUsername.Text) Then
                dictSavedPasswords(txtUsername.Text) = textPassword.Text
            Else
                dictSavedPasswords.Add(txtUsername.Text, textPassword.Text)
            End If

        End If

    End Sub

    Private Sub btnMySavedPassword_Click(sender As Object, e As EventArgs) Handles btnMySavedPassword.Click
        Dim OBJ As New Form2
        OBJ.dictSavedPasswords = dictSavedPasswords
        OBJ.username = txtUsername.Text
        OBJ.Show()
    End Sub

    Private Sub btnSuggest_Click(sender As Object, e As EventArgs) Handles btnSuggest.Click
        Dim suggestedPassword As String = ""
        Dim Ch As Integer
        Dim UsableSymbols() As String
        Dim Symbols = "`,~,!,@,#,$,%,^,&,*,(,),_,-,=,+,[,{,],},\,|,;,:,',?,/,.,>,<"
        UsableSymbols = Split(Symbols, ",")
        Dim Sym As Char

        Randomize()

        For i = 1 To 3
            Ch = Int((Asc("Z") - Asc("A") + 1) * Rnd() + Asc("A"))
            suggestedPassword = suggestedPassword & Chr(Ch)
            Ch = Int((Asc("z") - Asc("a") + 1) * Rnd() + Asc("a"))
            suggestedPassword = suggestedPassword & Chr(Ch)
            Ch = Int((Asc("9") - Asc("0") + 1) * Rnd() + Asc("0"))
            suggestedPassword = suggestedPassword & Chr(Ch)

            Sym = UsableSymbols((29 * Rnd()))
            suggestedPassword = suggestedPassword & Sym
        Next

        lblSuggested.Text = suggestedPassword
    End Sub

End Class

