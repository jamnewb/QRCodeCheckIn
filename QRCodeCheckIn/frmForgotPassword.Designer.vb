<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForgotPassword
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblQuestionSelected = New System.Windows.Forms.Label()
        Me.btnResetPassword = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtQuestionAnswer = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnSubmit.Location = New System.Drawing.Point(273, 113)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(83, 44)
        Me.btnSubmit.TabIndex = 26
        Me.btnSubmit.Text = "Submit username" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(21, 127)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(246, 20)
        Me.txtUsername.TabIndex = 25
        Me.txtUsername.Text = "Type username here"
        '
        'lblQuestionSelected
        '
        Me.lblQuestionSelected.AutoSize = True
        Me.lblQuestionSelected.BackColor = System.Drawing.Color.Gainsboro
        Me.lblQuestionSelected.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionSelected.ForeColor = System.Drawing.Color.Black
        Me.lblQuestionSelected.Location = New System.Drawing.Point(18, 177)
        Me.lblQuestionSelected.Name = "lblQuestionSelected"
        Me.lblQuestionSelected.Size = New System.Drawing.Size(228, 18)
        Me.lblQuestionSelected.TabIndex = 24
        Me.lblQuestionSelected.Text = "Awaiting username submission..."
        Me.lblQuestionSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnResetPassword
        '
        Me.btnResetPassword.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetPassword.ForeColor = System.Drawing.Color.Black
        Me.btnResetPassword.Location = New System.Drawing.Point(21, 255)
        Me.btnResetPassword.Name = "btnResetPassword"
        Me.btnResetPassword.Size = New System.Drawing.Size(83, 44)
        Me.btnResetPassword.TabIndex = 23
        Me.btnResetPassword.Text = "Reset Password"
        Me.btnResetPassword.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTitle.Font = New System.Drawing.Font("Bahnschrift", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(74, 26)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(173, 24)
        Me.lblTitle.TabIndex = 22
        Me.lblTitle.Text = "QR-Code Check In"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQuestionAnswer
        '
        Me.txtQuestionAnswer.Location = New System.Drawing.Point(21, 210)
        Me.txtQuestionAnswer.Name = "txtQuestionAnswer"
        Me.txtQuestionAnswer.Size = New System.Drawing.Size(246, 20)
        Me.txtQuestionAnswer.TabIndex = 21
        Me.txtQuestionAnswer.Text = "Type question answer here"
        '
        'frmForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 325)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblQuestionSelected)
        Me.Controls.Add(Me.btnResetPassword)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtQuestionAnswer)
        Me.Name = "frmForgotPassword"
        Me.Text = "Forgot Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblQuestionSelected As Label
    Friend WithEvents btnResetPassword As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtQuestionAnswer As TextBox
End Class
