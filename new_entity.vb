Imports System.IO
Public Class AddToCSV
   Function writeToFile(ByVal FilePath As String, ByVal fieldOne As String, ByVal fieldTwo As String, ByVal delimiter As String) As Boolean
      Try
         Dim fileWriter As New System.IO.StreamWriter(FilePath, True)

         Dim record As String = fieldOne + delimiter + fieldTwo
         fileWriter.WriteLine(record)
         fileWriter.Close()

         Return True
      Catch ex As Exception
         Return False
      End Try
   End Function
   Private Sub Save()
      Dim newEntity As Boolean = writeToFile("FilePath", value1, value2, ",")
   End Sub
End Class