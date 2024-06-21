Imports HotKeySet
Public Class ViewSubmissionForm
Private Sub ViewSubmissionsButton_Click(sender As Object, e As EventArgs) Handles ViewSubmissionsButton.Click
    ' Simulate data retrieval (replace with your actual data source logic)
    Dim name As String = "John Doe"
    Dim email As String = "johndoe@gmail.com"
    Dim phoneNumber As String = "1234567890"
    Dim gitHubLink As String = "https://github.com/john_doe/my_slidely_t"

    ' Set the retrieved data to the TextBoxes
    nameTextBox.Text = name
    emailTextBox.Text = email
    phoneNumberTextBox.Text = phoneNumber
    gitHubLinkTextBox.Text = gitHubLink
End Sub

Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' Register keyboard shortcut for View Submissions button (Ctrl + V)
    HotKeySet.RegisterHotKey(Me, 1, HotKeyModifiers.Control, Keys.V)
End Sub

End Class
