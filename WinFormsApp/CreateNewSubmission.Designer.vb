﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewSubmission
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
        components = New ComponentModel.Container()
        Button1 = New Button()
        Timer1 = New Timer(components)
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Button1.Location = New Point(171, 396)
        Button1.Name = "Button1"
        Button1.Size = New Size(294, 29)
        Button1.TabIndex = 0
        Button1.Text = "SUBMIT(CTRL+S)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button2.Location = New Point(62, 331)
        Button2.Name = "Button2"
        Button2.Size = New Size(219, 29)
        Button2.TabIndex = 1
        Button2.Text = "TOGGLE STOPWATCH(CTRL+T)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(276, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 20)
        Label1.TabIndex = 2
        Label1.Text = "Anmol, Slidely Task-2 - View Submissions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(62, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 3
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(62, 138)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 4
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(62, 199)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 5
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(62, 255)
        Label5.Name = "Label5"
        Label5.Size = New Size(151, 20)
        Label5.TabIndex = 6
        Label5.Text = "Github Link For Task 2"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(352, 78)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(196, 27)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(352, 131)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(196, 27)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(352, 192)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(196, 27)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(352, 248)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(196, 27)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(423, 331)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 11
        ' 
        ' CreateNewSubmission
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "CreateNewSubmission"
        Text = "CreateNewSubmission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
End Class
