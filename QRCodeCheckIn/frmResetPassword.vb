Public Class frmResetPassword
    'Name: James Newbegin
    'Description: Allows individuals to 'check into' the hospital through the usage of the solution,
    'and hospital staff to view the data collected from the solution which can be sorted through
    'and added, edited or deleted from if they are a hospital administrator.
    'Date started: 09/06/2022
    'Last updated: 07/24/2022

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        If Len(txtPassword.Text) > 8 Then ''Checks if the password is more than 8 characters long
            If InStr(txtPassword.Text, "1") Or InStr(txtPassword.Text, "2") Or InStr(txtPassword.Text, "3") Or InStr(txtPassword.Text, "4") Or InStr(txtPassword.Text, "5") Or InStr(txtPassword.Text, "6") Or InStr(txtPassword.Text, "7") Or InStr(txtPassword.Text, "8") Or InStr(txtPassword.Text, "9") Or InStr(txtPassword.Text, "0") Then 'Checks for if the password contains a number
                If InStr(txtPassword.Text, "!") Or InStr(txtPassword.Text, "@") Or InStr(txtPassword.Text, "#") Or InStr(txtPassword.Text, "$") Or InStr(txtPassword.Text, "%") Or InStr(txtPassword.Text, "^") Or InStr(txtPassword.Text, "&") Or InStr(txtPassword.Text, "*") Or InStr(txtPassword.Text, "(") Or InStr(txtPassword.Text, ")") Or InStr(txtPassword.Text, "-") Or InStr(txtPassword.Text, "+") Or InStr(txtPassword.Text, "_") Or InStr(txtPassword.Text, "=") Or InStr(txtPassword.Text, "[") Or InStr(txtPassword.Text, "]") Or InStr(txtPassword.Text, "{") Or InStr(txtPassword.Text, "}") Or InStr(txtPassword.Text, "\") Or InStr(txtPassword.Text, "|") Or InStr(txtPassword.Text, ":") Or InStr(txtPassword.Text, ";") Or InStr(txtPassword.Text, "'") Or InStr(txtPassword.Text, ",") Or InStr(txtPassword.Text, "<") Or InStr(txtPassword.Text, ">") Or InStr(txtPassword.Text, ".") Or InStr(txtPassword.Text, "?") Or InStr(txtPassword.Text, "/") Then 'Checks for if the password contains a symbol
                    If txtPassword.Text = txtConfirmPassword.Text Then 'Checks if the password typed into the 'Confirm password' textbox is the same as the password typed into the 'Password' textbox
                        Dim lines = System.IO.File.ReadAllLines("Data.txt") 'Gets the amount of lines in the text file
                        For i = 0 To lines.Length - 1
                            If lines(i) = DimUsername Then 'Checks for where the user's stored username is in the text file
                                lines(i + 1) = txtPassword.Text 'Overwrites the old password of that account with the newly submitted password
                                IO.File.WriteAllLines("Data.txt", lines) 'Writes the new contents back to the text file
                            End If
                        Next

                        txtPassword.Text = "" 'Resets all the textboxes so if this form is opened again after being hidden, then the previously entered details will not be shown
                        txtConfirmPassword.Text = ""

                        Me.Hide() 'Hides the current form and shows the 'Login' form
                        frmLogin.Show()
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

    Private Sub txtConfirmPassword_LostFocus(sender As Object, e As EventArgs) Handles txtConfirmPassword.LostFocus
        If txtConfirmPassword.Text = "" Then
            txtConfirmPassword.Text = "Confirm password here"
            txtConfirmPassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged
        If txtConfirmPassword.Text <> "" Then
            txtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

End Class