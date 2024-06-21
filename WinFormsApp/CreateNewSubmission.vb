Imports HotKeySet
Public Class CreateNewSubmission
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Clear any existing data in view TextBoxes (if applicable)
    nameTextBox.Text = ""
    emailTextBox.Text = ""
    phoneNumberTextBox.Text = ""
    gitHubLinkTextBox.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
         ' Register keyboard shortcut for Create New Submission button (Ctrl + N)
    HotKeySet.RegisterHotKey(Me, 2, HotKeyModifiers.Control, Keys.N)
    End Sub
End Class
