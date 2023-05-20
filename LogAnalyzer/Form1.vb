Imports System.String
Imports System.IO
Imports System.IO.Compression
Imports System.DirectoryServices

Public Class Form1

    Dim logFile As String = String.Empty

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim selectedFile As String = String.Empty
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            selectedFile = OpenFileDialog1.FileName
            SelectedPath.Text = selectedFile
        Else
            Exit Sub
        End If

    End Sub

    Private Sub timeRangeEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles timeRangeEnabled.CheckedChanged

        If timeRangeEnabled.Checked Then
            fromTimePicker.Enabled = True
            toTimePicker.Enabled = True
        Else
            fromTimePicker.Enabled = False
            toTimePicker.Enabled = False
        End If

    End Sub

    Private Sub SelectedPath_TextChanged(sender As Object, e As EventArgs) Handles SelectedPath.TextChanged

        If IsValidFileNameOrPath(SelectedPath.Text) Then
            analyzeButton.Enabled = True
        Else
            analyzeButton.Enabled = False
        End If
    End Sub

    Function IsValidFileNameOrPath(ByVal name As String) As Boolean

        Dim isValid As Boolean = False

        If name Is Nothing Then
            isValid = False
        End If

        If File.Exists(name) AndAlso name.EndsWith(".zip") Or name.StartsWith("log.txt.") Then

            isValid = True
            logFile = name
        End If

        Return isValid

    End Function

    Private Sub analyzeButton_Click(sender As Object, e As EventArgs) Handles analyzeButton.Click

        Dim extractPath As String = "C:\Users\pc\Desktop\logAnalysis\unzipped"

        If logFile.EndsWith(".zip") Then

            Dim zippedLogFile As String = String.Empty

            Using archive As ZipArchive = ZipFile.OpenRead(logFile)
                For Each entry As ZipArchiveEntry In archive.Entries
                    If entry.FullName.StartsWith("log.txt.") Then
                        zippedLogFile = entry.FullName
                    End If
                Next
            End Using

            If Not String.IsNullOrEmpty(zippedLogFile) Then
                Dim zip As ZipArchive = ZipFile.Open(logFile, ZipArchiveMode.Read)
                Dim file As ZipArchiveEntry = zip.Entries.Where(Function(x) x.Name = zippedLogFile)
                If file IsNot Nothing Then
                    file.ExtractToFile(extractPath + zippedLogFile)
                End If
            Else
                MessageBox.Show("Nessun file di log trovato all'interno dell'archivio", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If


        'ZipFile.ExtractToDirectory(logFile, extractPath)

        'For Each file As String In IO.Directory.GetFiles(extractPath)
        '    If Not file.StartsWith("log.txt.") Then
        '        IO.File.Delete(file)
        '    End If
        'Next

    End Sub
End Class
