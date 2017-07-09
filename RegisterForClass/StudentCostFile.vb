Public Class StudentCostFile
    'purpose:  write record procedure

    Private _strStudentID As String
    Private _strStudentName As String
    Private _strMajor As String
    Private _decStudentCosts As Decimal

    Sub New(ByVal StudentID As String, ByVal StudentName As String, ByVal Major As String, ByVal Costs As Decimal)

        _strStudentID = StudentID
        _strStudentName = StudentName
        _strMajor = Major
        _decStudentCosts = Costs

    End Sub

    Sub WriteRecord()
        'Sub procedure opens the student cost output text file and the writes a record in the file

        Dim strNameAndLocationOfFile As String = "C:\Users\LisaKilker\Documents\Visual Studio 2012\Projects\RegisterForClass\studentcosts.txt"

        Try
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(strNameAndLocationOfFile)
            objWriter.Write(_strStudentID & ",")
            objWriter.Write(_strStudentName & ",")
            objWriter.Write(_strMajor & ",")
            objWriter.WriteLine(_decStudentCosts)
            objWriter.Close()

        Catch ex As Exception

            MsgBox("File isn't available.", , "Entry Error")
            Application.Exit()


        End Try
    End Sub

End Class
