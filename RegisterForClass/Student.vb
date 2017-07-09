Public Class Student
    'base class
    'class variables 
    Protected _strStudentID As String
    Protected _strStudentName As String
    Protected _strMajor As String
    Protected _intUnits As Integer
    Protected _decCosts As Decimal
    Protected _decCostPerUnit As Decimal = 450D
    Dim objStudentCostsFile As StudentCostFile

    Sub New(ByVal strStudentID As String, ByVal strStudentName As String, ByVal intUnits As String, ByVal strMajor As String)

        'data received from form class
        _strStudentID = strStudentID
        _strStudentName = strStudentName
        _strMajor = strMajor
        _intUnits = Convert.ToInt32(intUnits)

    End Sub

    Overridable Function ComputeCosts() As Decimal
        'computes the registratoin costs, writes a record in the student costs files, and returns registration costs

        'calculate cost
        _decCosts = _intUnits * _decCostPerUnit

        'write student record
        objStudentCostsFile = New StudentCostFile(_strStudentID, _strStudentName, _strMajor, _decCosts)
        objStudentCostsFile.WriteRecord()

        Return _decCosts

    End Function
End Class
