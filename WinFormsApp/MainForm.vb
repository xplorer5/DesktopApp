Imports HotKeySet
Public Class MainForm
    Private Sub ViewSubmissionsButton_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Your existing code for ViewSubmissions button functionality
    End Sub
    Private Sub ViewSubmissionsButton_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Hide MainForm and show ViewSubmissionsForm
        Me.Hide()
        ViewSubmissionsForm.Show()
        ' Load initial data (implementation needed)
        LoadFirstSubmissionData()
    End Sub

    Private Sub CreateNewSubmissionButton_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Hide MainForm and show CreateNewSubmissionForm
        Me.Hide()
        CreateNewSubmissionForm.Show()
        ' Initialize stopwatch (implementation needed)
        Stopwatch = New Stopwatch()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Anmol, Slidely Task 2 - Slidely Form App")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MsgBox("Anmol, Slidely Task 2 - Slidely Form App")
    End Sub

    Private Sub FontDialog1_Apply(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class

