Public Class frmLogin
    'Name: James Newbegin
    'Description: Allows individuals to 'check into' the hospital through the usage of the solution,
    'and hospital staff to view the data collected from the solution which can be sorted through
    'and added, edited or deleted from if they are a hospital administrator.
    'Date started: 09/06/2022
    'Last updated: 07/24/2022

    Dim password As Boolean
    Dim IsFormHidden As Boolean 'Checks if the form is hidden
    Dim TextFileText As String 'Stores the textfile text

    'Public Function Decrypt(Decryption As String) As String
    '    Dim decrypttext As String = String.Empty 'Function that decrypts data from the text file
    '    Dim encodedtxt As New UTF8Encoding()
    '    Dim decode As Decoder = encodedtxt.GetDecoder()
    '    Dim code_byte As Byte() = Convert.FromBase64String(Decryption)
    '    Dim charcount As Integer = decode.GetCharCount(code_byte, 0, code_byte.Length)
    '    Dim decode_char As Char() = New Char(charcount - 1) {}
    '    decode.GetChars(code_byte, 0, code_byte.Length, decode_char, 0)
    '    decrypttext = New String(decode_char)
    '    Return decrypttext
    'End Function

    'Public Function Encrypt(Encryption As String) As String
    '    Dim msg As String = String.Empty 'Function that encrypts data from the text file
    '    Dim encode As Byte() = New Byte(Encryption.Length - 1) {}
    '    encode = Encoding.UTF8.GetBytes(Encryption)
    '    msg = Convert.ToBase64String(encode)
    '    Return msg
    'End Function

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Me.Hide() 'Hides the form and shows the 'Create account' form
        frmCreateAccount.Show()

        txtPassword.Text = "" 'Clears the textboxes of their submissions so if the form is displayed again the previously entered details will no longer be there
        txtUsername.Text = ""
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text <> "" And txtPassword.Text <> "" And txtUsername.Text <> "Type username here" And txtPassword.Text <> "Type password here" Then
            Dim FileNum As Integer = FreeFile() 'Checks for where the end of the text file is
            Dim Username, Password, Name, Email, PhoneNumber, HomeAddress, SecurityQuestion, QuestionResponse, TimeOfCheckIn As String 'Defines what the lines of the text files may consist of
            FileOpen(FileNum, "Data.txt", OpenMode.Input) 'Opens the text file for examining
            Do Until EOF(FileNum) 'Completes the code within the do until loop, until the end of the file has been reached. (EOF - End of file)
                Username = LineInput(FileNum) 'Reads every 9 lines of the file as the username, password, name, email, phone number, home address, security question, question response and time of check in
                Password = LineInput(FileNum)
                If txtUsername.Text = Username Then 'Checks if the username submitted matches any pre-existing username
                    If txtPassword.Text = Password Then
                        If txtUsername.Text = "SMI1285" Or txtUsername.Text = "CAM9378" Then
                            Me.Hide() 'If the username matches an admin's username, and the password matches that account's password, then the hospital database form is shown, and the login form is hidden
                            frmHospitalDatabase.Show()

                            IsFormHidden = True
                            If txtUsername.Text = "SMI1285" Then
                                NotAdminUsername = True
                            End If
                        Else
                            Me.Hide() 'If the username matches a regular user's username, and the password matches that account's password, then the QR-Code form is shown, and the login form is hidden
                            frmQRCodeCheckIn.Show()

                            IsFormHidden = True
                            LoginUsername = Username 'Stores the logged in account's username across forms
                        End If
                    End If

                    If IsFormHidden <> True Then 'If the form is not hidden then the following is executed
                        If txtPassword.Text <> Password Then 'If the username matches a regular user's username, but the password does not match that account's password then the following is executed
                            MessageBox.Show("Password is incorrect", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'If the password is incorrect then an error message is displayed
                        End If
                    Else
                        txtPassword.Text = "" 'If the form is hidden, then the textboxes are cleared of their contents, so as to avoid the previously submitted details remaining in the textboxes if the form is shown again
                        txtUsername.Text = ""

                        IsFormHidden = False
                    End If
                End If
                Name = LineInput(FileNum)
                Email = LineInput(FileNum)
                PhoneNumber = LineInput(FileNum)
                HomeAddress = LineInput(FileNum)
                SecurityQuestion = LineInput(FileNum)
                QuestionResponse = LineInput(FileNum)
                TimeOfCheckIn = LineInput(FileNum)
            Loop
            FileClose(FileNum) 'Closes the text file.
        End If
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        Me.Hide() 'Hides the form and shows the 'Forgot password' form
        frmForgotPassword.Show()

        txtPassword.Text = "" 'Clears the textboxes of their submissions so if the form is displayed again the previously entered details will no longer be there
        txtUsername.Text = ""
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = False

        'Dim Filenum As Integer = FreeFile() 'Checks for where the end of the file is
        'FileOpen(Filenum, "Data.txt", OpenMode.Input) 'Opens the text file
        'Do Until EOF(Filenum) 'Completes the code within the do until loop, until the end of the file has been reached. (EOF - End of file)
        '    TextFileText = TextFileText + (Decrypt(LineInput(Filenum)) + vbCrLf) 'Decrypts the contents of the textfile
        'Loop
        'FileClose(Filenum) 'Closes the text file.

        'Dim objWriter As New System.IO.StreamWriter("Data.txt")

        'objWriter.Write(TextFileText) 'Writes the decrypted contents of the textfile to the textfile
        'objWriter.Close()

        'Dim lines As New List(Of String)(IO.File.ReadAllLines("Data.txt"))
        'Dim Read() As String = IO.File.ReadAllLines("Data.txt") 'Gets the amount of lines in the textfile


        'lines.RemoveAt(Read.Length - 1) 'Removes the last line of the text file

        'IO.File.WriteAllLines("Data.txt", lines.ToArray()) 'Writes the contents of the textfile to the textfile, but with the last line removed
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Dim j As String
        'Dim Filenum As Integer = FreeFile() 'Checks for where the end of the text file is
        'FileOpen(Filenum, "Data.txt", OpenMode.Input) 'Opens the text file
        'Do Until EOF(Filenum) 'Completes the code within the do until loop, until the end of the file has been reached. (EOF - End of file)
        '    j = TextFileText + (LineInput(Filenum) + vbCrLf) 'Stores the contents of the decrypted textfile
        'Loop
        'FileClose(Filenum) 'Closes the text file.

        'j = Encrypt(j) 'Encrypts the contents of the textfile

        'Dim objWriter As New System.IO.StreamWriter("Data.txt")

        'objWriter.Write("") 'Clears the textfile
        'objWriter.Write(j) 'Writes the encrypted contents to the text file
        'objWriter.Close()

        Me.Close() 'Closes the solution
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text <> "" Then
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.Text = "Type password here"
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = "Type username here"
        End If
    End Sub

End Class
