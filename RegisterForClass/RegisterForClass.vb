Public Class frmRegisterForClass


    Private Sub btnCalculateCosts_Click(sender As Object, e As EventArgs) Handles btnCalculateCosts.Click
        Dim objStudent As Student
        Dim objOnCampusStudent As OnCampusStudent
        Dim InputError As Boolean = False

        'Is the student ID entered properly?
        If mskStudentID.MaskFull = False Then
            MsgBox("Please enter your student ID!", , "Entry Error")
            mskStudentID.Clear()
            mskStudentID.Focus()
            InputError = True

            'Is the student name entered properly?
        ElseIf txtStudentName.TextLength < 1 Or txtStudentName.Text < "A" Then
            MsgBox("Please enter your name!", , "Entry Error")
            txtStudentName.Clear()
            txtStudentName.Focus()
            InputError = True

            'Is the Number of units a numeric value?
        ElseIf Not IsNumeric(txtNumberOfUnits.Text) Then
            MsgBox("Please enter the number of Units!", , "Entry Error")
            txtNumberOfUnits.Clear()
            txtNumberOfUnits.Focus()
            InputError = True

            'Has 1-24 been entered?
        ElseIf Convert.ToInt32(txtNumberOfUnits.Text) < 1 Or Convert.ToInt32(txtNumberOfUnits.Text) > 24 Then
            MsgBox("Units must be a number between 1 and 24!", , "Entry Error")
            txtNumberOfUnits.Clear()
            txtNumberOfUnits.Focus()
            InputError = True

            'Has a major been selected?
        ElseIf ddpMajor.SelectedIndex < 0 Then
            MsgBox("Please select a major", , "Entry Error")
            ddpMajor.Focus()
            ddpMajor.SelectedIndex = -1
            InputError = True
        End If

        'If there are no errors, process registration cost
        If Not InputError Then
            If radOffCampus.Checked Then
                objStudent = New Student(mskStudentID.Text, txtStudentName.Text, txtNumberOfUnits.Text, Convert.ToString(ddpMajor.SelectedItem))
                lblCalculation.Visible = True
                lblCalculation.Text = "Total semester cost: " & (objStudent.ComputeCosts()).ToString("C2")

            Else
                'the student is on campus
                objOnCampusStudent = New OnCampusStudent(mskStudentID.Text, txtStudentName.Text, txtNumberOfUnits.Text, Convert.ToString(ddpMajor.SelectedItem), radCooperDorm.Checked, radPercyHall.Checked, radJulianSuites.Checked)
                lblCalculation.Visible = True
                lblCalculation.Text = "Total semester cost: " & (objOnCampusStudent.ComputeCosts()).ToString("C2")

            End If
        End If

    End Sub
   

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        mskStudentID.Clear()
        txtStudentName.Clear()
        txtNumberOfUnits.Clear()
        ddpMajor.SelectedIndex = -1
        lblCalculation.Visible = False
    End Sub

    Private Sub radOffCampus_CheckedChanged(sender As Object, e As EventArgs) Handles radOffCampus.CheckedChanged
        gboHousing.Visible = False
    End Sub
End Class