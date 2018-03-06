Option Strict On
Public Class frmSemesterAverage
    Dim Tbarray(5) As TextBox 'global arrays for the text boxes 
    Dim Lblarray(6) As Label 'global arrays for the labels
    Private Sub frmSemesterAverage_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' set all the arrays upon form load 
        Tbarray(0) = txtCourse1
        Tbarray(1) = txtCourse2
        Tbarray(2) = txtCourse3
        Tbarray(3) = txtCourse4
        Tbarray(4) = txtCourse5
        Tbarray(5) = txtCourse6

        Lblarray(0) = lblGr1
        Lblarray(1) = lblGr2
        Lblarray(2) = lblGr3
        Lblarray(3) = lblGr4
        Lblarray(4) = lblGr5
        Lblarray(5) = lblGr6
        Lblarray(6) = lblOverallLetter
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Static gradeArray(5) As Double 'static grade array
        Static count As Integer = 0 ' static counter for figuring out if all tbs are filled 
        Dim semesterAverage As Double = 0 'to hold the overall semester average 
        lblError.ResetText()
        For i As Integer = 0 To 5 ' error checking 
            If checkValid(Tbarray(i).Text, i + 1) = True Then
                gradeArray(i) = CDbl(Tbarray(i).Text)
                count += 1 'if it returned true then increase the counter 
            Else
                Tbarray(i).Focus() 'if it returned false then foucus on the error and select it 
                Tbarray(i).SelectAll()
                count = 0
            End If
        Next
        If count >= 5 Then
            For x As Integer = 0 To 5
                semesterAverage += gradeArray(x) 'if the counter is 5 or greater then do the maths
            Next
            semesterAverage = semesterAverage / 6
            lblOverallNumber.Text = Math.Round(semesterAverage, 2).ToString
            checkGrade(gradeArray(5).ToString, 6)
            disableForm() 'disable the form
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset() ' if reset button is clicked call the reset subroutine
    End Sub
    Private Sub disableForm() 'a sub to diable the forms buttons 
        btnCalculate.Enabled = False
        For i As Integer = 0 To 5
            Tbarray(i).Enabled = False
        Next
    End Sub
    Private Sub enableForm() 'a sub to enable the forms buttons 
        btnCalculate.Enabled = True
        For i As Integer = 0 To 5
            Tbarray(i).Enabled = True
        Next
    End Sub
    Private Sub Reset() 'reset the forms varables and objects 
        For i As Integer = 0 To 5
            Tbarray(i).ResetText()
            Lblarray(i).ResetText()
        Next
        lblOverallLetter.ResetText()
        lblOverallNumber.ResetText()
        enableForm()
        txtCourse1.Focus()
    End Sub
    Private Sub txtCourse_LostFocus() Handles txtCourse1.LostFocus, txtCourse2.LostFocus, txtCourse3.LostFocus, txtCourse4.LostFocus, txtCourse5.LostFocus, txtCourse6.LostFocus ' if somthing lost focus then call the check grade function
        For i As Integer = 0 To 5
            If checkValid(Tbarray(i).Text, i + 1) = True Then
                checkGrade(Tbarray(i).Text, i)
                lblError.ResetText()
            End If
        Next
    End Sub
    Private Function checkValid(input As String, errorCounter As Integer) As Boolean 'error checking function 
        Dim isNum As Double
        If Double.TryParse(input, isNum) Then 'check if its a number
            If CDbl(input) <= 100 And CDbl(input) >= 0 Then 'check the range 
                Return True 'return true if yes 
            Else
                lblError.Text += "Enter a number between 0 and 100 inclusive for textbox:  " + errorCounter.ToString + Environment.NewLine 'return false and output error if no
                Return False
            End If
            Return False
        Else
            lblError.Text += "Enter a number between 0 and 100 inclusive for textbox:  " + errorCounter.ToString + Environment.NewLine 'return false and output error if no
            Return False
        End If
    End Function
    Private Function checkGrade(input As String, arrayPosition As Integer) As Integer 'check grade funciton 
        If CInt(input) >= 90 Then
            Lblarray(arrayPosition).Text = "A+"
        ElseIf CInt(input) >= 85 Then
            Lblarray(arrayPosition).Text = "A"
        ElseIf CInt(input) >= 80 Then
            Lblarray(arrayPosition).Text = "A-"
        ElseIf CInt(input) >= 77 Then
            Lblarray(arrayPosition).Text = "B+"
        ElseIf CInt(input) >= 73 Then
            Lblarray(arrayPosition).Text = "B"
        ElseIf CInt(input) >= 70 Then
            Lblarray(arrayPosition).Text = "B-"
        ElseIf CInt(input) >= 67 Then
            Lblarray(arrayPosition).Text = "C+"
        ElseIf CInt(input) >= 63 Then
            Lblarray(arrayPosition).Text = "C"
        ElseIf CInt(input) >= 60 Then
            Lblarray(arrayPosition).Text = "C-"
        ElseIf CInt(input) >= 57 Then
            Lblarray(arrayPosition).Text = "D+"
        ElseIf CInt(input) >= 53 Then
            Lblarray(arrayPosition).Text = "D"
        ElseIf CInt(input) >= 50 Then
            Lblarray(arrayPosition).Text = "D-"
        Else
            Lblarray(arrayPosition).Text = "F"
        End If
        Return 0
    End Function
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click 'if user clicks the exit button then exit the program 
        Environment.Exit(1)
    End Sub
End Class
