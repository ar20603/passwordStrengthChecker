<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.checkboxShowPassword = New System.Windows.Forms.CheckBox()
        Me.lblLowercase = New System.Windows.Forms.Label()
        Me.lblUppercase = New System.Windows.Forms.Label()
        Me.lblNumbers = New System.Windows.Forms.Label()
        Me.lblSymbols = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.txtPassword.Location = New System.Drawing.Point(-4, 199)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(961, 41)
        Me.txtPassword.TabIndex = 0
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'checkboxShowPassword
        '
        Me.checkboxShowPassword.AutoSize = True
        Me.checkboxShowPassword.Location = New System.Drawing.Point(796, 265)
        Me.checkboxShowPassword.Name = "checkboxShowPassword"
        Me.checkboxShowPassword.Size = New System.Drawing.Size(129, 21)
        Me.checkboxShowPassword.TabIndex = 1
        Me.checkboxShowPassword.Text = "Show Password"
        Me.checkboxShowPassword.UseVisualStyleBackColor = True
        '
        'lblLowercase
        '
        Me.lblLowercase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblLowercase.Image = CType(resources.GetObject("lblLowercase.Image"), System.Drawing.Image)
        Me.lblLowercase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLowercase.Location = New System.Drawing.Point(50, 308)
        Me.lblLowercase.Name = "lblLowercase"
        Me.lblLowercase.Size = New System.Drawing.Size(130, 35)
        Me.lblLowercase.TabIndex = 4
        Me.lblLowercase.Text = "Lower case"
        Me.lblLowercase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUppercase
        '
        Me.lblUppercase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblUppercase.Image = CType(resources.GetObject("lblUppercase.Image"), System.Drawing.Image)
        Me.lblUppercase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUppercase.Location = New System.Drawing.Point(237, 308)
        Me.lblUppercase.Name = "lblUppercase"
        Me.lblUppercase.Size = New System.Drawing.Size(130, 35)
        Me.lblUppercase.TabIndex = 5
        Me.lblUppercase.Text = "Upper case"
        Me.lblUppercase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumbers
        '
        Me.lblNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblNumbers.Image = CType(resources.GetObject("lblNumbers.Image"), System.Drawing.Image)
        Me.lblNumbers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNumbers.Location = New System.Drawing.Point(440, 308)
        Me.lblNumbers.Name = "lblNumbers"
        Me.lblNumbers.Size = New System.Drawing.Size(147, 35)
        Me.lblNumbers.TabIndex = 6
        Me.lblNumbers.Text = "Numbers"
        Me.lblNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSymbols
        '
        Me.lblSymbols.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblSymbols.Image = CType(resources.GetObject("lblSymbols.Image"), System.Drawing.Image)
        Me.lblSymbols.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSymbols.Location = New System.Drawing.Point(629, 308)
        Me.lblSymbols.Name = "lblSymbols"
        Me.lblSymbols.Size = New System.Drawing.Size(146, 35)
        Me.lblSymbols.TabIndex = 7
        Me.lblSymbols.Text = "Symbols"
        Me.lblSymbols.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(957, 516)
        Me.Controls.Add(Me.lblSymbols)
        Me.Controls.Add(Me.lblNumbers)
        Me.Controls.Add(Me.lblUppercase)
        Me.Controls.Add(Me.lblLowercase)
        Me.Controls.Add(Me.checkboxShowPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents checkboxShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents lblLowercase As System.Windows.Forms.Label
    Friend WithEvents lblUppercase As System.Windows.Forms.Label
    Friend WithEvents lblNumbers As System.Windows.Forms.Label
    Friend WithEvents lblSymbols As System.Windows.Forms.Label

End Class
