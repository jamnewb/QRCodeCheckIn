<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQRCodeCheckIn
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
        Me.lblWaiting = New System.Windows.Forms.Label()
        Me.btnSubmitImage = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tmrDateAndTime = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.picTick = New System.Windows.Forms.PictureBox()
        Me.picTrueQrCode = New System.Windows.Forms.PictureBox()
        Me.picCross = New System.Windows.Forms.PictureBox()
        Me.picPictureBoxOutline = New System.Windows.Forms.PictureBox()
        Me.picSubmittedImage = New System.Windows.Forms.PictureBox()
        CType(Me.picTick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTrueQrCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCross, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPictureBoxOutline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSubmittedImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWaiting
        '
        Me.lblWaiting.AutoSize = True
        Me.lblWaiting.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaiting.Location = New System.Drawing.Point(161, 237)
        Me.lblWaiting.Name = "lblWaiting"
        Me.lblWaiting.Size = New System.Drawing.Size(90, 54)
        Me.lblWaiting.TabIndex = 35
        Me.lblWaiting.Text = "Waiting for " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "image to be " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "submitted..."
        Me.lblWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSubmitImage
        '
        Me.btnSubmitImage.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitImage.ForeColor = System.Drawing.Color.Black
        Me.btnSubmitImage.Location = New System.Drawing.Point(306, 101)
        Me.btnSubmitImage.Name = "btnSubmitImage"
        Me.btnSubmitImage.Size = New System.Drawing.Size(83, 44)
        Me.btnSubmitImage.TabIndex = 31
        Me.btnSubmitImage.Text = "Submit image"
        Me.btnSubmitImage.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.Location = New System.Drawing.Point(31, 280)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(83, 44)
        Me.btnLogout.TabIndex = 30
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTitle.Font = New System.Drawing.Font("Bahnschrift", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(119, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(173, 24)
        Me.lblTitle.TabIndex = 29
        Me.lblTitle.Text = "QR-Code Check In"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrDateAndTime
        '
        Me.tmrDateAndTime.Enabled = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'picTick
        '
        Me.picTick.Image = Global.QRCodeCheckIn.My.Resources.Resources.Tick
        Me.picTick.Location = New System.Drawing.Point(146, 205)
        Me.picTick.Name = "picTick"
        Me.picTick.Size = New System.Drawing.Size(119, 119)
        Me.picTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTick.TabIndex = 33
        Me.picTick.TabStop = False
        Me.picTick.Visible = False
        '
        'picTrueQrCode
        '
        Me.picTrueQrCode.Image = Global.QRCodeCheckIn.My.Resources.Resources.QR_Code_Image
        Me.picTrueQrCode.Location = New System.Drawing.Point(284, 196)
        Me.picTrueQrCode.Name = "picTrueQrCode"
        Me.picTrueQrCode.Size = New System.Drawing.Size(189, 132)
        Me.picTrueQrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTrueQrCode.TabIndex = 32
        Me.picTrueQrCode.TabStop = False
        Me.picTrueQrCode.Visible = False
        '
        'picCross
        '
        Me.picCross.Image = Global.QRCodeCheckIn.My.Resources.Resources.Cross
        Me.picCross.Location = New System.Drawing.Point(146, 205)
        Me.picCross.Name = "picCross"
        Me.picCross.Size = New System.Drawing.Size(119, 119)
        Me.picCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCross.TabIndex = 37
        Me.picCross.TabStop = False
        Me.picCross.Visible = False
        '
        'picPictureBoxOutline
        '
        Me.picPictureBoxOutline.Image = Global.QRCodeCheckIn.My.Resources.Resources.Picture_Box_Outline
        Me.picPictureBoxOutline.Location = New System.Drawing.Point(111, 58)
        Me.picPictureBoxOutline.Name = "picPictureBoxOutline"
        Me.picPictureBoxOutline.Size = New System.Drawing.Size(189, 132)
        Me.picPictureBoxOutline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPictureBoxOutline.TabIndex = 34
        Me.picPictureBoxOutline.TabStop = False
        '
        'picSubmittedImage
        '
        Me.picSubmittedImage.Location = New System.Drawing.Point(111, 58)
        Me.picSubmittedImage.Name = "picSubmittedImage"
        Me.picSubmittedImage.Size = New System.Drawing.Size(189, 132)
        Me.picSubmittedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSubmittedImage.TabIndex = 36
        Me.picSubmittedImage.TabStop = False
        '
        'frmQRCodeCheckIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(413, 349)
        Me.Controls.Add(Me.lblWaiting)
        Me.Controls.Add(Me.picTick)
        Me.Controls.Add(Me.picTrueQrCode)
        Me.Controls.Add(Me.btnSubmitImage)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picCross)
        Me.Controls.Add(Me.picPictureBoxOutline)
        Me.Controls.Add(Me.picSubmittedImage)
        Me.Name = "frmQRCodeCheckIn"
        Me.Text = "QR-Code Check in"
        CType(Me.picTick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTrueQrCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCross, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPictureBoxOutline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSubmittedImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWaiting As Label
    Friend WithEvents picTick As PictureBox
    Friend WithEvents picTrueQrCode As PictureBox
    Friend WithEvents btnSubmitImage As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents picPictureBoxOutline As PictureBox
    Friend WithEvents picSubmittedImage As PictureBox
    Friend WithEvents picCross As PictureBox
    Friend WithEvents tmrDateAndTime As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
