<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        OpenFileDialog1 = New OpenFileDialog()
        Search = New Button()
        SelectedPath = New TextBox()
        analyzeButton = New Button()
        timeRangeEnabled = New CheckBox()
        fromLabel = New Label()
        toLabel = New Label()
        fromTimePicker = New DateTimePicker()
        toTimePicker = New DateTimePicker()
        SuspendLayout()
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.DefaultExt = "C:\"
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.ShowReadOnly = True
        OpenFileDialog1.Title = "Pick source files"
        ' 
        ' Search
        ' 
        Search.Location = New Point(108, 109)
        Search.Name = "Search"
        Search.Size = New Size(75, 23)
        Search.TabIndex = 0
        Search.Text = "Select files"
        Search.UseVisualStyleBackColor = True
        ' 
        ' SelectedPath
        ' 
        SelectedPath.Location = New Point(189, 109)
        SelectedPath.Name = "SelectedPath"
        SelectedPath.PlaceholderText = "C:\Users\pc\Desktop\logAnalysis"
        SelectedPath.Size = New Size(359, 23)
        SelectedPath.TabIndex = 1
        ' 
        ' analyzeButton
        ' 
        analyzeButton.BackColor = SystemColors.Control
        analyzeButton.Enabled = False
        analyzeButton.Location = New Point(584, 109)
        analyzeButton.Name = "analyzeButton"
        analyzeButton.Size = New Size(75, 23)
        analyzeButton.TabIndex = 2
        analyzeButton.Text = "Analyze"
        analyzeButton.UseVisualStyleBackColor = False
        ' 
        ' timeRangeEnabled
        ' 
        timeRangeEnabled.AutoSize = True
        timeRangeEnabled.Location = New Point(108, 174)
        timeRangeEnabled.Name = "timeRangeEnabled"
        timeRangeEnabled.Size = New Size(117, 19)
        timeRangeEnabled.TabIndex = 3
        timeRangeEnabled.Text = "Select time range"
        timeRangeEnabled.UseVisualStyleBackColor = True
        ' 
        ' fromLabel
        ' 
        fromLabel.AutoSize = True
        fromLabel.Location = New Point(108, 206)
        fromLabel.Name = "fromLabel"
        fromLabel.Size = New Size(35, 15)
        fromLabel.TabIndex = 4
        fromLabel.Text = "From"
        ' 
        ' toLabel
        ' 
        toLabel.AutoSize = True
        toLabel.Location = New Point(255, 206)
        toLabel.Name = "toLabel"
        toLabel.Size = New Size(19, 15)
        toLabel.TabIndex = 5
        toLabel.Text = "To"
        ' 
        ' fromTimePicker
        ' 
        fromTimePicker.CustomFormat = "HH:MM"
        fromTimePicker.Enabled = False
        fromTimePicker.Format = DateTimePickerFormat.Time
        fromTimePicker.Location = New Point(108, 224)
        fromTimePicker.Name = "fromTimePicker"
        fromTimePicker.ShowUpDown = True
        fromTimePicker.Size = New Size(75, 23)
        fromTimePicker.TabIndex = 6
        ' 
        ' toTimePicker
        ' 
        toTimePicker.AllowDrop = True
        toTimePicker.CustomFormat = "HH:MM"
        toTimePicker.Enabled = False
        toTimePicker.Format = DateTimePickerFormat.Time
        toTimePicker.Location = New Point(255, 224)
        toTimePicker.Name = "toTimePicker"
        toTimePicker.ShowUpDown = True
        toTimePicker.Size = New Size(75, 23)
        toTimePicker.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(toTimePicker)
        Controls.Add(fromTimePicker)
        Controls.Add(toLabel)
        Controls.Add(fromLabel)
        Controls.Add(timeRangeEnabled)
        Controls.Add(analyzeButton)
        Controls.Add(SelectedPath)
        Controls.Add(Search)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Search As Button
    Friend WithEvents SelectedPath As TextBox
    Friend WithEvents analyzeButton As Button
    Friend WithEvents timeRangeEnabled As CheckBox
    Friend WithEvents fromLabel As Label
    Friend WithEvents toLabel As Label
    Friend WithEvents fromTimePicker As DateTimePicker
    Friend WithEvents toTimePicker As DateTimePicker
End Class
