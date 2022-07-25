Imports System.IO
Public Class ImportCSV
   Private Sub CSV()
      Dim sr As StreamReader = New StreamReader("Filepath")
      Dim dictionary As New Dictionary(Of String, String)
      Do While sr.Peek <> -1
         Dim lineArray As String() = sr.ReadLine().Split(",")
         If lineArray.Length = 2 Then
            dictionary.Add(lineArray(0), lineArray(1))
         End If
      Loop

      If dictionary.TryGetValue(value1, value2) Then
         'Continue
      Else
         'Break
   End Sub
End Class