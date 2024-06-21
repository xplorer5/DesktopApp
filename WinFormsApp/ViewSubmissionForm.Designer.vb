<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionForm
    Inherits System.Windows.Forms.Form
    Private currentSubmissionIndex As Integer = 0  ' Keeps track of current submission

    Private Sub LoadSubmissionData(index As Integer)
        ' Fetch data from backend based on index (implementation needed)
        ' Update textboxes with retrieved data
        Label2.Text = submissionData(index).Name
        Label3.Text = SubmissionData(index).Email
        Label4.Text = submissionData(index).PhoneNum
        Label5.Text = submissionData(index).GithubLinkForTask - 2

        ' ... (similarly update other textboxes)
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        If currentSubmissionIndex > 0 Then
            currentSubmissionIndex -= 1
            LoadSubmissionData(currentSubmissionIndex)
        End If
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        ' ... (similar logic to load next submission data)
    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button1.Location = New Point(119, 356)
        Button1.Name = "Button1"
        Button1.Size = New Size(198, 29)
        Button1.TabIndex = 0
        Button1.Text = "PREVIOUS(CTRL+P)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Button2.Location = New Point(480, 356)
        Button2.Name = "Button2"
        Button2.Size = New Size(181, 29)
        Button2.TabIndex = 1
        Button2.Text = "NEXT(CTRL+N)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(362, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 20)
        Label1.TabIndex = 2
        Label1.Text = "Anmol, Slidely Task-2 - View Submissions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(119, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 3
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(119, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 4
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(119, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 5
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(119, 253)
        Label5.Name = "Label5"
        Label5.Size = New Size(151, 20)
        Label5.TabIndex = 6
        Label5.Text = "Github Link For Task 2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(119, 304)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 20)
        Label6.TabIndex = 7
        Label6.Text = "Stopwatch time"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(462, 86)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(235, 27)
        TextBox1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(462, 137)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(235, 27)
        TextBox2.TabIndex = 9
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(462, 194)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(235, 27)
        TextBox3.TabIndex = 10
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(462, 246)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(235, 27)
        TextBox4.TabIndex = 11
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(462, 301)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(235, 27)
        TextBox5.TabIndex = 12
        ' 
        ' ViewSubmission
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "ViewSubmission"
        Text = "ViewSubmission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
End Class
