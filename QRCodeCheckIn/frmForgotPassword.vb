Public Class frmForgotPassword
    'Name: James Newbegin
    'Description: Allows individuals to 'check into' the hospital through the usage of the solution,
    'and hospital staff to view the data collected from the solution which can be sorted through
    'and added, edited or deleted from if they are a hospital administrator.
    'Date started: 09/06/2022
    'Last updated: 07/24/2022

    Dim AnswerToQuestion As String 'Stores the answer to the security question the user gave when creating their account

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim FileNum As Integer = FreeFile() 'Checks for where the end of the text file is
        Dim Username, Password, Name, Email, PhoneNumber, HomeAddress, SecurityQuestion, QuestionResponse, TimeOfCheckIn As String 'Defines what the lines of the text files may consist of
        FileOpen(FileNum, "Data.txt", OpenMode.Input) 'Opens the text file
        Do Until EOF(FileNum) 'Completes the code within the do until loop, until the end of the file has been reached. (EOF - End of file)
            Username = LineInput(FileNum) 'Reads every 9 lines of the file as the username, password, name, email, phone number, home address, security question, question response and time of check in
            Password = LineInput(FileNum)
            Name = LineInput(FileNum)
            Email = LineInput(FileNum)
            PhoneNumber = LineInput(FileNum)
            HomeAddress = LineInput(FileNum)
            SecurityQuestion = LineInput(FileNum)
            QuestionResponse = LineInput(FileNum)
            TimeOfCheckIn = LineInput(FileNum)

            If txtUsername.Text = Username Then 'Checks for if the submitted username matches any pre-existing usernames
                lblQuestionSelected.Text = SecurityQuestion 'If the username submitted matches any pre-existing usernames, then it will display that account's security question
                AnswerToQuestion = QuestionResponse 'Stores that account's answer to the security question the user gave when creating their account
            End If
        Loop
        FileClose(FileNum) 'Closes the text file.
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        If txtQuestionAnswer.Text = AnswerToQuestion Then 'If the user correctly answers their security question then the following is executed
            DimUsername = txtUsername.Text 'Stores the user's username

            txtUsername.Text = "" 'Resets all the textboxes and labels so if this form is opened again after being hidden, then the previously entered details will not be shown
            txtQuestionAnswer.Text = ""
            lblQuestionSelected.Text = "Awaiting username submission..."
            AnswerToQuestion = ""

            Me.Hide() 'Hides the form and shows the 'Reset password' form
            frmResetPassword.Show()
        Else
            MessageBox.Show("Question response is incorrect", "Invalid question response", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'If the user incorrectly answers their security question then an error message is displayed
        End If
    End Sub

    Private Sub txtQuestionAnswer_LostFocus(sender As Object, e As EventArgs) Handles txtQuestionAnswer.LostFocus
        If txtQuestionAnswer.Text = "" Then
            txtQuestionAnswer.Text = "Type question answer here"
        End If
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = "Type username here"
        End If
    End Sub

End Class