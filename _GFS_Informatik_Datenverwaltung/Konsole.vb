Imports System.IO

Public Class Konsole

Private Sub cmdKonsoleLeeren_Click(sender As Object, e As EventArgs) Handles cmdKonsoleLeeren.Click
    txtBox.Text = Nothing
End Sub

Private Sub cmdSpeichern_Click(sender As Object, e As EventArgs) Handles cmdSpeichern.Click
    Dim saveFileDialog As New SaveFileDialog
    saveFileDialog.Filter = "Text-Datei (*.txt)|*.txt"

    If saveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
        System.IO.File.WriteAllText(saveFileDialog.FileName, txtBox.Text)
    End If
End Sub

End Class