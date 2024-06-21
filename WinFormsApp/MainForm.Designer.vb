<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>_
Partial Class MainForm
    Inherits System.Windows.Forms.Form
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        MsgBox("Anmol, Slidely Task 2 - Slidely Form App")
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
        ColorDialog1 = New ColorDialog()
        ColorDialog2 = New ColorDialog()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Button1.Location = New Point(226, 135)
        Button1.Name = "Button1"
        Button1.Size = New Size(285, 49)
        Button1.TabIndex = 0
        Button1.Text = "VIEW SUBMISSION(CTRL+V)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Button2.Location = New Point(226, 245)
        Button2.Name = "Button2"
        Button2.Size = New Size(285, 55)
        Button2.TabIndex = 1
        Button2.Text = "CREATE NEW SUBMISSION(CTRL+N)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ColorDialog1
        ' 
        ColorDialog1.Color = Color.BlanchedAlmond
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(226, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(275, 20)
        Label1.TabIndex = 2
        Label1.Text = "Anmol, Slidely Task 2 - Slidely Form App"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "MainForm"
        Text = "MainForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ColorDialog2 As ColorDialog
    Friend WithEvents Label1 As Label
End Class
