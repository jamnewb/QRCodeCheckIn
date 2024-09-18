Public Class frmQRCodeCheckIn
    'Name: James Newbegin
    'Description: Allows individuals to 'check into' the hospital through the usage of the solution,
    'and hospital staff to view the data collected from the solution which can be sorted through
    'and added, edited or deleted from if they are a hospital administrator.
    'Date started: 09/06/2022
    'Last updated: 07/24/2022

    Dim IsPictureSubmitted As Boolean = False 'Checks if the picture is submitted
    Dim IsPictureCheckDone As Boolean = False 'Checks if the picture has been processed
    Dim TimeOfCheckIn As String 'Stores the date and time

    Private Sub btnSubmitImage_Click(sender As Object, e As EventArgs) Handles btnSubmitImage.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then 'If the 'Submit image' button is pressed, then the user is taken to their file manager where they can select an image to be submitted
            picSubmittedImage.Image = Image.FromFile(OpenFileDialog1.FileName) 'Makes the 'picSubmittedImage' picture box store the submitted image
            IsPictureSubmitted = True 'Stores the fact that an image has been submitted

            lblWaiting.Visible = False 'Makes the label that says "Waiting for Image to be submitted..." invisible as a picture has been submitted
        End If

        If IsPictureSubmitted = True Then 'If a picture has been submitted the following is executed
            Dim BMP1 As New Bitmap(picSubmittedImage.Image) 'Allows a bitmap to be created of the submitted image
            Dim BMP2 As New Bitmap(picTrueQrCode.Image) 'Allows a bitmap to be created of the image of the correct QR-code
            Dim total_checked As Integer
            Dim total As Integer
            total = 132 * 189 'Width and height
            For x As Integer = 0 To (189) - 1 'Width of picturebox is 189
                For y As Integer = 0 To (132) - 1 'Height of picturebox is 132
                    If BMP1.GetPixel(x, y).Equals(BMP2.GetPixel(x, y)) Then
                        total_checked = total_checked + 1
                        If total_checked = total Then
                            picTick.Visible = True 'If the submitted image is the correct QR-code then a tick will be displayed below the submitted image
                            picCross.Visible = False
                            picPictureBoxOutline.Visible = False 'Makes the image of the outline of the picture box invisible as an image has been submitted
                            Dim lines = System.IO.File.ReadAllLines("Data.txt") 'Checks for where the end of the textfile is
                            For i = 0 To lines.Length - 1
                                If lines(i) = LoginUsername Then 'Checks for where the user's username is in the textfile
                                    lines(i + 8) = TimeOfCheckIn 'Overwrites the user's previous time of check in in the textfile, with the date and time of when they submitted their image
                                    IO.File.WriteAllLines("Data.txt", lines) 'Writes the new contents of the text file to the text file
                                End If
                            Next
                            IsPictureCheckDone = True 'Stores the fact that the picture has been processed
                        End If
                    Else
                        picTick.Visible = False 'If the submitted image is an incorrect QR-code then a cross will be displayed below the submitted image, and no new time of check in will be overwritten in the text file
                        picCross.Visible = True
                        picPictureBoxOutline.Visible = False
                        IsPictureCheckDone = True 'Stores the fact that the picture has been processed
                    End If
                Next
            Next
            If IsPictureCheckDone = True Then
                IsPictureSubmitted = False 'Resets the variables to ensure no errors occur
                IsPictureCheckDone = False
            End If
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide() 'Hides the current form and shows the 'Login' form
        frmLogin.Show()

        picCross.Visible = False 'Resets the picture boxes and labels so if the form is opened again after being hidden, then no previously entered details will be displayed
        picTick.Visible = False
        lblWaiting.Visible = True
        picPictureBoxOutline.Visible = True
    End Sub

    Private Sub tmrDateAndTime_Tick(sender As Object, e As EventArgs) Handles tmrDateAndTime.Tick
        TimeOfCheckIn = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt") 'Gets the date and time of the user
    End Sub

End Class