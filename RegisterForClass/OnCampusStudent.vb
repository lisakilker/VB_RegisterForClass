Public Class OnCampusStudent
    'subclass of student base class

    Inherits Student 'inheriting attributes from the base class of Student
    Private _Cooper As Boolean
    Private _Percy As Boolean
    Private _Julian As Boolean
    Dim objStudentCostsFile As StudentCostFile

    'onCampus class constructor
    Sub New(ByVal StudentID As String, ByVal StudentName As String, ByVal Units As String, ByVal Major As String, ByVal Cooper As Boolean, ByVal Percy As Boolean, ByVal Julian As Boolean)

        MyBase.New(StudentID, StudentName, Units, Major)

        'assigns received arguments to the class variables
        _Cooper = Cooper
        _Percy = Percy
        _Julian = Julian

    End Sub

    Public Overrides Function ComputeCosts() As Decimal
        'computes the registration costs and writes the records in the student cost file and returns the registration costs

        Dim HousingCost As Decimal
        Const cdecCooperHousingCost As Decimal = 2900D
        Const cdecPercyHousingCost As Decimal = 3400D
        Const cdecJulianHousingCost As Decimal = 4000D

        'assigns housing costs to houseingcost variable based on user selection
        If _Cooper Then
            HousingCost = cdecCooperHousingCost

        ElseIf _Percy Then
            HousingCost = cdecPercyHousingCost

        ElseIf _Julian Then
            HousingCost = cdecJulianHousingCost
        End If

        _decCosts = (_intUnits * _decCostPerUnit) + HousingCost
        'writes the student record
        objStudentCostsFile = New StudentCostFile(_strStudentID, _strStudentName, _strMajor, _decCosts)

        objStudentCostsFile.WriteRecord()

        Return _decCosts

    End Function
End Class
