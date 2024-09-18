<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateAccount
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
        Me.components = New System.ComponentModel.Container()
        Me.lblPasswordDetails = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAreaNotFilled = New System.Windows.Forms.Label()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtQuestionResponse = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtHomeAddress = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.cmbSelectedArea = New System.Windows.Forms.ComboBox()
        Me.cmbSecurityQuestion = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblPasswordDetails
        '
        Me.lblPasswordDetails.AutoSize = True
        Me.lblPasswordDetails.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPasswordDetails.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordDetails.ForeColor = System.Drawing.Color.Black
        Me.lblPasswordDetails.Location = New System.Drawing.Point(276, 155)
        Me.lblPasswordDetails.Name = "lblPasswordDetails"
        Me.lblPasswordDetails.Size = New System.Drawing.Size(152, 90)
        Me.lblPasswordDetails.TabIndex = 36
        Me.lblPasswordDetails.Text = "Password must be " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "8 or more characters " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "long with a mix of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "letters, numbers &" &
    " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "symbols"
        Me.lblPasswordDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTitle.Font = New System.Drawing.Font("Bahnschrift", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(124, 31)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(173, 24)
        Me.lblTitle.TabIndex = 34
        Me.lblTitle.Text = "QR-Code Check In"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAreaNotFilled
        '
        Me.lblAreaNotFilled.AutoSize = True
        Me.lblAreaNotFilled.BackColor = System.Drawing.Color.Gainsboro
        Me.lblAreaNotFilled.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaNotFilled.ForeColor = System.Drawing.Color.Red
        Me.lblAreaNotFilled.Location = New System.Drawing.Point(17, 124)
        Me.lblAreaNotFilled.Name = "lblAreaNotFilled"
        Me.lblAreaNotFilled.Size = New System.Drawing.Size(218, 18)
        Me.lblAreaNotFilled.TabIndex = 33
        Me.lblAreaNotFilled.Text = "Area has not been filled out yet."
        Me.lblAreaNotFilled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAreaNotFilled.Visible = False
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAccount.ForeColor = System.Drawing.Color.Black
        Me.btnCreateAccount.Location = New System.Drawing.Point(16, 267)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(121, 44)
        Me.btnCreateAccount.TabIndex = 32
        Me.btnCreateAccount.Text = "Create account"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'txtQuestionResponse
        '
        Me.txtQuestionResponse.Location = New System.Drawing.Point(16, 228)
        Me.txtQuestionResponse.Name = "txtQuestionResponse"
        Me.txtQuestionResponse.Size = New System.Drawing.Size(246, 20)
        Me.txtQuestionResponse.TabIndex = 47
        Me.txtQuestionResponse.Visible = False
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(16, 228)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(246, 20)
        Me.txtLastName.TabIndex = 45
        Me.txtLastName.Visible = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(16, 228)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(246, 20)
        Me.txtConfirmPassword.TabIndex = 44
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        Me.txtConfirmPassword.Visible = False
        '
        'txtHomeAddress
        '
        Me.txtHomeAddress.Location = New System.Drawing.Point(16, 193)
        Me.txtHomeAddress.Name = "txtHomeAddress"
        Me.txtHomeAddress.Size = New System.Drawing.Size(246, 20)
        Me.txtHomeAddress.TabIndex = 41
        Me.txtHomeAddress.Visible = False
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(16, 193)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(246, 20)
        Me.txtPhoneNumber.TabIndex = 40
        Me.txtPhoneNumber.Visible = False
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(16, 193)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(246, 20)
        Me.txtEmail.TabIndex = 39
        Me.txtEmail.Visible = False
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(16, 193)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(246, 20)
        Me.txtFirstName.TabIndex = 37
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(16, 193)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(246, 20)
        Me.txtPassword.TabIndex = 42
        Me.txtPassword.UseSystemPasswordChar = True
        Me.txtPassword.Visible = False
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(16, 193)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(246, 20)
        Me.txtUsername.TabIndex = 43
        Me.txtUsername.Visible = False
        '
        'cmbSelectedArea
        '
        Me.cmbSelectedArea.FormattingEnabled = True
        Me.cmbSelectedArea.Items.AddRange(New Object() {"Name", "Email", "Phone Number", "Home Address", "Password", "Username", "Security Question"})
        Me.cmbSelectedArea.Location = New System.Drawing.Point(16, 158)
        Me.cmbSelectedArea.Name = "cmbSelectedArea"
        Me.cmbSelectedArea.Size = New System.Drawing.Size(246, 21)
        Me.cmbSelectedArea.TabIndex = 38
        '
        'cmbSecurityQuestion
        '
        Me.cmbSecurityQuestion.FormattingEnabled = True
        Me.cmbSecurityQuestion.Items.AddRange(New Object() {"In what city were you born?", "What is your mother's maiden name?", "What was the make of your first car?", "What was your favorite food as a child?", "What was your childhood pet's name?", "What was the name of the primary school you attended?", "What was the name of the secondary school you attended?", "What was the name of the university you attended?", "What was your childhood nickname?", "What is the name of your favorite childhood friend?", "What street did you live on in third grade?", "What is your oldest sibling’s birthday month and year?", "What is your oldest sibling's middle name?", "What was your childhood phone number?", "What is your oldest cousin's first and last name?", "What was the name of your first stuffed animal?", "In what city or town did your mother and father meet?", "What was the last name of your third grade teacher?", "What is your youngest brother’s birthday month and year?", "In what city or town was your first job?"})
        Me.cmbSecurityQuestion.Location = New System.Drawing.Point(16, 192)
        Me.cmbSecurityQuestion.Name = "cmbSecurityQuestion"
        Me.cmbSecurityQuestion.Size = New System.Drawing.Size(246, 21)
        Me.cmbSecurityQuestion.TabIndex = 46
        Me.cmbSecurityQuestion.Visible = False
        '
        'frmCreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 343)
        Me.Controls.Add(Me.txtQuestionResponse)
        Me.Controls.Add(Me.cmbSecurityQuestion)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtHomeAddress)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.cmbSelectedArea)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblPasswordDetails)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblAreaNotFilled)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Name = "frmCreateAccount"
        Me.Text = "Create Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPasswordDetails As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAreaNotFilled As Label
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtQuestionResponse As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtHomeAddress As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents cmbSelectedArea As ComboBox
    Friend WithEvents cmbSecurityQuestion As ComboBox
End Class
