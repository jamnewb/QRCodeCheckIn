Public Class frmCreateAccount
    'Name: James Newbegin
    'Description: Allows individuals to 'check into' the hospital through the usage of the solution,
    'and hospital staff to view the data collected from the solution which can be sorted through
    'and added, edited or deleted from if they are a hospital administrator.
    'Date started: 09/06/2022
    'Last updated: 07/24/2022

    Dim FirstName, LastName, Email, HomeAddress, PhoneNumber, Password, ConfirmPassword, Username, QuestionResponse As Boolean 'Allows the textboxes to display their respective "Type message here" message when user has not typed anything into the textboxes
    Dim j, a As Integer 'The j variable checks for when the text file is completely read, and the a variable checks if the username submitted by the user is available

    Private Sub frmCreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSelectedArea.SelectedItem = "Name" 'This is to ensure that the user cannot submit nothing as their selected area so as to avoid errors
        cmbSecurityQuestion.SelectedItem = "In what city were you born?" 'This is to ensure that the user cannot submit nothing as their security question so as to avoid errors
    End Sub

    Private Sub cmbSelectedArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectedArea.SelectedIndexChanged
        Select Case cmbSelectedArea.SelectedItem 'Checks for what area the user has selected
            Case "Name"
                txtFirstName.Visible = True 'Makes only the textboxes and comboboxes associated with that area visible
                txtEmail.Visible = False
                txtHomeAddress.Visible = False
                txtPhoneNumber.Visible = False
                txtPassword.Visible = False
                txtUsername.Visible = False
                txtConfirmPassword.Visible = False
                lblPasswordDetails.Visible = False
                txtLastName.Visible = True
                txtQuestionResponse.Visible = False
                cmbSecurityQuestion.Visible = False

                If txtFirstName.Text = "" Then 'If the textbox has not been written in, "Type [selected area details] here" is added to it
                    txtFirstName.Text = "Type first name here"
                End If

                If txtLastName.Text = "" Then
                    txtLastName.Text = "Type last name here"
                End If
            Case "Email"
                txtFirstName.Visible = False
                txtEmail.Visible = True
                txtHomeAddress.Visible = False
                txtPhoneNumber.Visible = False
                txtPassword.Visible = False
                txtUsername.Visible = False
                txtConfirmPassword.Visible = False
                lblPasswordDetails.Visible = False
                txtLastName.Visible = False
                txtQuestionResponse.Visible = False
                cmbSecurityQuestion.Visible = False

                If txtEmail.Text = "" Then
                    txtEmail.Text = "Type email here"
                End If
            Case "Home Address"
                txtFirstName.Visible = False
                txtEmail.Visible = False
                txtHomeAddress.Visible = True
                txtPhoneNumber.Visible = False
                txtPassword.Visible = False
                txtUsername.Visible = False
                txtConfirmPassword.Visible = False
                lblPasswordDetails.Visible = False
                txtLastName.Visible = False
                txtQuestionResponse.Visible = False
                cmbSecurityQuestion.Visible = False

                If txtHomeAddress.Text = "" Then
                    txtHomeAddress.Text = "Type home address here"
                End If
            Case "Phone Number"
                txtFirstName.Visible = False
                txtEmail.Visible = False
                txtHomeAddress.Visible = False
                txtPhoneNumber.Visible = True
                txtPassword.Visible = False
                txtUsername.Visible = False
                txtConfirmPassword.Visible = False
                lblPasswordDetails.Visible = False
                txtLastName.Visible = False
                txtQuestionResponse.Visible = False
                cmbSecurityQuestion.Visible = False

                If txtPhoneNumber.Text = "" Then
                    txtPhoneNumber.Text = "Type phone number here"
                End If
            Case "Password"
                txtFirstName.Visible = False
                txtEmail.Visible = False
                txtHomeAddress.Visible = False
                txtPhoneNumber.Visible = False
                txtPassword.Visible = True
                txtUsername.Visible = False
                txtConfirmPassword.Visible = True
                lblPasswordDetails.Visible = True
                txtLastName.Visible = False
                txtQuestionResponse.Visible = False
                cmbSecurityQuestion.Visible = False

                If txtPassword.Text = "" Then 'If the textbox has not been written in it turns off the system password char so "Type [selected area details] here" can be properly displayed
                    Password = True
                    If Password = True Then
                        txtPassword.UseSystemPasswordChar = False
                        txtPassword.Text = "Type password here"
                    End If
                End If

                If txtConfirmPassword.Text = "" Then
                    ConfirmPassword = True
                    If ConfirmPassword = True Then
                        txtConfirmPassword.UseSystemPasswordChar = False
                        txtConfirmPassword.Text = "Confirm password here"
                    End If
                End If
            Case "Username"
                txtFirstName.Visible = False
                txtEmail.Visible = False
                txtHomeAddress.Visible = False
                txtPhoneNumber.Visible = False
                txtPassword.Visible = False
                txtUsername.Visible = True
                txtConfirmPassword.Visible = False
                lblPasswordDetails.Visible = False
                txtLastName.Visible = False
                txtQuestionResponse.Visible = False
                cmbSecurityQuestion.Visible = False

                If txtUsername.Text = "" Then
                    txtUsername.Text = "Type username here"
                End If
            Case "Security Question"
                txtFirstName.Visible = False
                txtEmail.Visible = False
                txtHomeAddress.Visible = False
                txtPhoneNumber.Visible = False
                txtPassword.Visible = False
                txtUsername.Visible = False
                txtConfirmPassword.Visible = False
                lblPasswordDetails.Visible = False
                txtLastName.Visible = False
                txtQuestionResponse.Visible = True
                cmbSecurityQuestion.Visible = True

                If txtQuestionResponse.Text = "" Then
                    txtQuestionResponse.Text = "Type question response here"
                End If
        End Select
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        If txtFirstName.Text <> "Type first name here" And txtFirstName.Text <> "" And txtLastName.Text <> "Type last name here" And txtLastName.Text <> "" And txtEmail.Text <> "Type email here" And txtEmail.Text <> "" And txtPhoneNumber.Text <> "Type phone number here" And txtPhoneNumber.Text <> "" And txtHomeAddress.Text <> "Type home address here" And txtHomeAddress.Text <> "" And txtPassword.Text <> "Type password here" And txtPassword.Text <> "" And txtConfirmPassword.Text <> "Confirm password here" And txtConfirmPassword.Text <> "" And txtUsername.Text <> "Type username here" And txtUsername.Text <> "" And txtQuestionResponse.Text <> "Type question response here" And txtQuestionResponse.Text <> "" Then 'Checks if all the textboxes for all the areas have been written in
            If IsNumeric(txtFirstName.Text) = False And IsNumeric(txtLastName.Text) = False Then 'Checks if the name textboxes contain numbers
                If InStr(txtEmail.Text, "@") Then 'Checks if there is an at symbol in the email text box
                    If InStr(txtEmail.Text, ".") Then 'Checks if there is a period in the email text box
                        If InStr(txtEmail.Text, " ") = False Then 'Checks if there are no spaces in the email text box
                            If IsNumeric(txtPhoneNumber.Text) Then 'Checks if the mobile number has only numbers in it
                                If Len(txtPhoneNumber.Text) = 10 Then 'Checks if the mobile number is 10 characters long
                                    If Mid(txtPhoneNumber.Text, 1, 1) = 0 Then 'Checks if there is a 0 at the beginning of the mobile number
                                        If Len(txtPassword.Text) > 8 Then 'Checks if the password is more than 8 characters long
                                            If InStr(txtPassword.Text, "1") Or InStr(txtPassword.Text, "2") Or InStr(txtPassword.Text, "3") Or InStr(txtPassword.Text, "4") Or InStr(txtPassword.Text, "5") Or InStr(txtPassword.Text, "6") Or InStr(txtPassword.Text, "7") Or InStr(txtPassword.Text, "8") Or InStr(txtPassword.Text, "9") Or InStr(txtPassword.Text, "0") Then 'Checks if the password has a number in it
                                                If InStr(txtPassword.Text, "!") Or InStr(txtPassword.Text, "@") Or InStr(txtPassword.Text, "#") Or InStr(txtPassword.Text, "$") Or InStr(txtPassword.Text, "%") Or InStr(txtPassword.Text, "^") Or InStr(txtPassword.Text, "&") Or InStr(txtPassword.Text, "*") Or InStr(txtPassword.Text, "(") Or InStr(txtPassword.Text, ")") Or InStr(txtPassword.Text, "-") Or InStr(txtPassword.Text, "+") Or InStr(txtPassword.Text, "_") Or InStr(txtPassword.Text, "=") Or InStr(txtPassword.Text, "[") Or InStr(txtPassword.Text, "]") Or InStr(txtPassword.Text, "{") Or InStr(txtPassword.Text, "}") Or InStr(txtPassword.Text, "\") Or InStr(txtPassword.Text, "|") Or InStr(txtPassword.Text, ":") Or InStr(txtPassword.Text, ";") Or InStr(txtPassword.Text, "'") Or InStr(txtPassword.Text, ",") Or InStr(txtPassword.Text, "<") Or InStr(txtPassword.Text, ">") Or InStr(txtPassword.Text, ".") Or InStr(txtPassword.Text, "?") Or InStr(txtPassword.Text, "/") Then 'Checks if the password has a symbol in it
                                                    If txtPassword.Text = txtConfirmPassword.Text Then 'Checks if the password typed into the 'Confirm password' textbox is the same as the password typed into the 'Password' textbox
                                                        j = 0
                                                        a = 0

                                                        Dim lines = System.IO.File.ReadAllLines("Data.txt") 'Reads the amount of lines in the text file
                                                        For i = 0 To lines.Length - 1 'For every line in the text file
                                                            If lines(i) = txtUsername.Text Then
                                                                a = a + 1 'If the username submitted is already taken, then for each time the username matches a pre-existing username, 1 is added to the variable a
                                                                j = j + 1
                                                            Else
                                                                j = j + 1 '1 is added to the variable j every time a line is read in the textfile, so if all lines are read, j will equal that amount of lines
                                                            End If
                                                        Next

                                                        If j = lines.Length Then 'If j equals the amount of lines in the text file, it means all lines have been read, allowing this to occur
                                                            If a <= 0 Then 'If the username submitted matches any pre-existing usernames, the variable a will be greater than 0, disallowing the account details from being written to the textfile
                                                                Dim objWriter As New System.IO.StreamWriter("Data.txt", True) 'This means that the below information is written to this specific text file
                                                                Dim i As Integer
                                                                Dim text(8) As String
                                                                text(0) = txtUsername.Text 'The first line and every 9 lines following it will contain a user's username
                                                                text(1) = txtPassword.Text 'The second line and every 9 lines following it will contain a user's password
                                                                text(2) = txtFirstName.Text + txtLastName.Text 'The third line and every 9 lines following it will contain a user's name
                                                                text(3) = txtEmail.Text 'The fourth line and every 9 lines following it will contain a user's email
                                                                text(4) = txtPhoneNumber.Text 'The fifth line and every 9 lines following it will contain a user's phone number
                                                                text(5) = txtHomeAddress.Text 'The sixth line and every 9 lines following it will contain a user's home address
                                                                text(6) = cmbSecurityQuestion.SelectedItem 'The seventh line and every 9 lines following it will contain a user's security question
                                                                text(7) = txtQuestionResponse.Text 'The eighth line and every 9 lines following it will contain a user's security question answer
                                                                text(8) = "99/99/9999 99:99:99 MM" 'The ninth line and every 9 lines following it will contain a user's time of check in, if no time of check in has been recorded, it will display 99/99/9999 99:99:99 MM in the listview and text file

                                                                For i = 0 To 8
                                                                    objWriter.WriteLine(text(i)) 'Writes above information to the textfile
                                                                Next
                                                                objWriter.Close()

                                                                j = 0
                                                                a = 0

                                                                cmbSelectedArea.SelectedItem = "Name" 'Resets all the textboxes, so if the form is opened again it will not display the information that was previously entered
                                                                cmbSecurityQuestion.SelectedItem = "In what city were you born?"

                                                                txtFirstName.Text = "Type first name here"
                                                                txtLastName.Text = "Type last name here"
                                                                txtEmail.Text = ""
                                                                txtHomeAddress.Text = ""
                                                                txtPhoneNumber.Text = ""
                                                                txtPassword.Text = ""
                                                                txtUsername.Text = ""
                                                                txtConfirmPassword.Text = ""
                                                                txtQuestionResponse.Text = ""

                                                                Me.Hide() 'If all checks pass correctly then the user is taken back to the login screen
                                                                frmLogin.Show()
                                                            Else
                                                                MessageBox.Show("Username already taken", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'If the username is taken then an error message will be displayed
                                                                j = 0
                                                                a = 0
                                                            End If
                                                        End If
                                                    Else
                                                        MessageBox.Show("Passwords do not match", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'If the password typed into the 'Confirm password' textbox is not the same as the password typed into the 'Password' textbox then an error message will be displayed
                                                    End If
                                                Else
                                                    MessageBox.Show("Password must contain at least one symbol", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'If the password does not contain any symbols then an error message will be displayed
                                                End If
                                            Else
                                                MessageBox.Show("Password must contain at least one number", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'If the password does not contain any numbers then an error message will be displayed
                                            End If
                                        Else
                                            MessageBox.Show("Password must be longer than 8 characters", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'If the password is 8 characters or shorter in length then an error message will be displayed
                                        End If
                                    Else
                                        MessageBox.Show("Phone number number must start with a '0'", "Invalid phone number", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'If the phone number does not start with a 0 then an error message will be displayed
                                    End If
                                Else
                                    MessageBox.Show("Phone number number must consist of 10 numbers without spaces", "Invalid phone number", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'If the phone number is not 10 characters long then an error message will be displayed
                                End If
                            Else
                                MessageBox.Show("Phone number number must only consist of numbers", "Invalid phone number", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'If the phone number contains letters or symbols then an error message will be displayed
                            End If
                        Else
                            MessageBox.Show("Email must not contain a space", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'If the email contains a space then an error message will be displayed
                        End If
                    Else
                        MessageBox.Show("Email must contain a period", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'If the email contains a period then an error message will be displayed
                    End If
                Else
                    MessageBox.Show("Email must contain an at sign", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'If the email contains an at sign then an error message will be displayed
                End If
            Else
                MessageBox.Show("First and last name must not contain numbers", "Invalid ", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'If either the first or last name contain any numbers then an error message will be displayed
            End If
        Else
            lblAreaNotFilled.Visible = True 'If any areas are left blank and the user attempts to create an account with these blank areas, then a label is displayed letting the user know of this issue
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtSecondTextbox_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged

    End Sub

End Class