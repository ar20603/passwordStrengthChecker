﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.textPassword = New System.Windows.Forms.TextBox()
        Me.lblLowercase = New System.Windows.Forms.Label()
        Me.lblUppercase = New System.Windows.Forms.Label()
        Me.lblNumbers = New System.Windows.Forms.Label()
        Me.lblSymbols = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSavePassword = New System.Windows.Forms.Button()
        Me.labelMessage = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnMySavedPassword = New System.Windows.Forms.Button()
        Me.btnSuggest = New System.Windows.Forms.Button()
        Me.lblSuggested = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.checkboxShowPassword = New System.Windows.Forms.CheckBox()
        Me.btnUseThis = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textPassword
        '
        Me.textPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textPassword.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textPassword.ForeColor = System.Drawing.Color.Navy
        Me.textPassword.Location = New System.Drawing.Point(128, 203)
        Me.textPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.textPassword.MaxLength = 50
        Me.textPassword.Name = "textPassword"
        Me.textPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textPassword.Size = New System.Drawing.Size(470, 28)
        Me.textPassword.TabIndex = 0
        Me.textPassword.TabStop = False
        Me.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLowercase
        '
        Me.lblLowercase.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowercase.ForeColor = System.Drawing.Color.Navy
        Me.lblLowercase.Image = CType(resources.GetObject("lblLowercase.Image"), System.Drawing.Image)
        Me.lblLowercase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLowercase.Location = New System.Drawing.Point(128, 311)
        Me.lblLowercase.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLowercase.Name = "lblLowercase"
        Me.lblLowercase.Size = New System.Drawing.Size(117, 28)
        Me.lblLowercase.TabIndex = 4
        Me.lblLowercase.Text = "Lower case"
        Me.lblLowercase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUppercase
        '
        Me.lblUppercase.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUppercase.ForeColor = System.Drawing.Color.Navy
        Me.lblUppercase.Image = CType(resources.GetObject("lblUppercase.Image"), System.Drawing.Image)
        Me.lblUppercase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUppercase.Location = New System.Drawing.Point(264, 309)
        Me.lblUppercase.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUppercase.Name = "lblUppercase"
        Me.lblUppercase.Size = New System.Drawing.Size(118, 28)
        Me.lblUppercase.TabIndex = 5
        Me.lblUppercase.Text = "Upper case"
        Me.lblUppercase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumbers
        '
        Me.lblNumbers.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumbers.ForeColor = System.Drawing.Color.Navy
        Me.lblNumbers.Image = CType(resources.GetObject("lblNumbers.Image"), System.Drawing.Image)
        Me.lblNumbers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNumbers.Location = New System.Drawing.Point(406, 309)
        Me.lblNumbers.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumbers.Name = "lblNumbers"
        Me.lblNumbers.Size = New System.Drawing.Size(102, 28)
        Me.lblNumbers.TabIndex = 6
        Me.lblNumbers.Text = "Numbers"
        Me.lblNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSymbols
        '
        Me.lblSymbols.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSymbols.ForeColor = System.Drawing.Color.Navy
        Me.lblSymbols.Image = CType(resources.GetObject("lblSymbols.Image"), System.Drawing.Image)
        Me.lblSymbols.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSymbols.Location = New System.Drawing.Point(524, 308)
        Me.lblSymbols.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSymbols.Name = "lblSymbols"
        Me.lblSymbols.Size = New System.Drawing.Size(97, 28)
        Me.lblSymbols.TabIndex = 7
        Me.lblSymbols.Text = "Symbols"
        Me.lblSymbols.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Buxton Sketch", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(185, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 42)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Password Strength Checker"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(22, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(677, 47)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "This program checks the strength of your password and gives you valuable suggesti" & _
    "ons to improve it. Type your username and password in the text box to trigger th" & _
    "e program."
        '
        'btnSavePassword
        '
        Me.btnSavePassword.BackColor = System.Drawing.Color.Navy
        Me.btnSavePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSavePassword.Font = New System.Drawing.Font("Buxton Sketch", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePassword.ForeColor = System.Drawing.Color.White
        Me.btnSavePassword.Location = New System.Drawing.Point(604, 203)
        Me.btnSavePassword.Name = "btnSavePassword"
        Me.btnSavePassword.Size = New System.Drawing.Size(95, 28)
        Me.btnSavePassword.TabIndex = 10
        Me.btnSavePassword.Text = "Save"
        Me.btnSavePassword.UseVisualStyleBackColor = False
        '
        'labelMessage
        '
        Me.labelMessage.Enabled = False
        Me.labelMessage.Font = New System.Drawing.Font("Buxton Sketch", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMessage.ForeColor = System.Drawing.Color.Navy
        Me.labelMessage.Location = New System.Drawing.Point(75, 265)
        Me.labelMessage.Name = "labelMessage"
        Me.labelMessage.Size = New System.Drawing.Size(614, 23)
        Me.labelMessage.TabIndex = 11
        Me.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Navy
        Me.txtUsername.Location = New System.Drawing.Point(128, 130)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(470, 28)
        Me.txtUsername.TabIndex = 12
        Me.txtUsername.Tag = ""
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMySavedPassword
        '
        Me.btnMySavedPassword.BackColor = System.Drawing.Color.Navy
        Me.btnMySavedPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMySavedPassword.Font = New System.Drawing.Font("Buxton Sketch", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMySavedPassword.ForeColor = System.Drawing.Color.White
        Me.btnMySavedPassword.Location = New System.Drawing.Point(604, 130)
        Me.btnMySavedPassword.Name = "btnMySavedPassword"
        Me.btnMySavedPassword.Size = New System.Drawing.Size(95, 28)
        Me.btnMySavedPassword.TabIndex = 13
        Me.btnMySavedPassword.Text = "Show saved"
        Me.btnMySavedPassword.UseVisualStyleBackColor = False
        '
        'btnSuggest
        '
        Me.btnSuggest.BackColor = System.Drawing.Color.Navy
        Me.btnSuggest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSuggest.Font = New System.Drawing.Font("Buxton Sketch", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuggest.ForeColor = System.Drawing.Color.White
        Me.btnSuggest.Location = New System.Drawing.Point(26, 388)
        Me.btnSuggest.Name = "btnSuggest"
        Me.btnSuggest.Size = New System.Drawing.Size(146, 32)
        Me.btnSuggest.TabIndex = 14
        Me.btnSuggest.Text = "Suggest Password"
        Me.btnSuggest.UseVisualStyleBackColor = False
        '
        'lblSuggested
        '
        Me.lblSuggested.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuggested.ForeColor = System.Drawing.Color.Navy
        Me.lblSuggested.Location = New System.Drawing.Point(187, 387)
        Me.lblSuggested.Name = "lblSuggested"
        Me.lblSuggested.Size = New System.Drawing.Size(411, 32)
        Me.lblSuggested.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(36, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(36, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 23)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Password"
        '
        'checkboxShowPassword
        '
        Me.checkboxShowPassword.AutoSize = True
        Me.checkboxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkboxShowPassword.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkboxShowPassword.ForeColor = System.Drawing.Color.Navy
        Me.checkboxShowPassword.Location = New System.Drawing.Point(487, 179)
        Me.checkboxShowPassword.Name = "checkboxShowPassword"
        Me.checkboxShowPassword.Size = New System.Drawing.Size(106, 21)
        Me.checkboxShowPassword.TabIndex = 18
        Me.checkboxShowPassword.Text = "Show password"
        Me.checkboxShowPassword.UseVisualStyleBackColor = True
        '
        'btnUseThis
        '
        Me.btnUseThis.BackColor = System.Drawing.Color.Navy
        Me.btnUseThis.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUseThis.Font = New System.Drawing.Font("Buxton Sketch", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUseThis.ForeColor = System.Drawing.Color.White
        Me.btnUseThis.Location = New System.Drawing.Point(604, 387)
        Me.btnUseThis.Name = "btnUseThis"
        Me.btnUseThis.Size = New System.Drawing.Size(75, 33)
        Me.btnUseThis.TabIndex = 19
        Me.btnUseThis.Text = "Use This"
        Me.btnUseThis.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(716, 461)
        Me.Controls.Add(Me.btnUseThis)
        Me.Controls.Add(Me.checkboxShowPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSuggested)
        Me.Controls.Add(Me.btnSuggest)
        Me.Controls.Add(Me.btnMySavedPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.labelMessage)
        Me.Controls.Add(Me.btnSavePassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSymbols)
        Me.Controls.Add(Me.lblNumbers)
        Me.Controls.Add(Me.lblUppercase)
        Me.Controls.Add(Me.lblLowercase)
        Me.Controls.Add(Me.textPassword)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(700, 500)
        Me.Name = "Form1"
        Me.Text = "a"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblLowercase As System.Windows.Forms.Label
    Friend WithEvents lblUppercase As System.Windows.Forms.Label
    Friend WithEvents lblNumbers As System.Windows.Forms.Label
    Friend WithEvents lblSymbols As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSavePassword As System.Windows.Forms.Button
    Friend WithEvents labelMessage As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents btnMySavedPassword As System.Windows.Forms.Button
    Friend WithEvents btnSuggest As System.Windows.Forms.Button
    Friend WithEvents lblSuggested As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents checkboxShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents btnUseThis As System.Windows.Forms.Button

End Class
