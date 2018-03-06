<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterAverage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtCourse1 = New System.Windows.Forms.TextBox()
        Me.txtCourse2 = New System.Windows.Forms.TextBox()
        Me.txtCourse4 = New System.Windows.Forms.TextBox()
        Me.txtCourse3 = New System.Windows.Forms.TextBox()
        Me.txtCourse5 = New System.Windows.Forms.TextBox()
        Me.txtCourse6 = New System.Windows.Forms.TextBox()
        Me.lblCourse1 = New System.Windows.Forms.Label()
        Me.lblCourse2 = New System.Windows.Forms.Label()
        Me.lblCourse3 = New System.Windows.Forms.Label()
        Me.lblCourse4 = New System.Windows.Forms.Label()
        Me.lblCourse6 = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblCourse5 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblOverall = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblGr1 = New System.Windows.Forms.Label()
        Me.lblGr2 = New System.Windows.Forms.Label()
        Me.lblGr3 = New System.Windows.Forms.Label()
        Me.lblGr4 = New System.Windows.Forms.Label()
        Me.lblGr5 = New System.Windows.Forms.Label()
        Me.lblGr6 = New System.Windows.Forms.Label()
        Me.lblOverallLetter = New System.Windows.Forms.Label()
        Me.lblOverallNumber = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtCourse1
        '
        Me.txtCourse1.Location = New System.Drawing.Point(119, 22)
        Me.txtCourse1.Name = "txtCourse1"
        Me.txtCourse1.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse1.TabIndex = 1
        Me.txtCourse1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtCourse1, "Number Grade Input")
        '
        'txtCourse2
        '
        Me.txtCourse2.Location = New System.Drawing.Point(119, 74)
        Me.txtCourse2.Name = "txtCourse2"
        Me.txtCourse2.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse2.TabIndex = 2
        Me.txtCourse2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtCourse2, "Number Grade Input")
        '
        'txtCourse4
        '
        Me.txtCourse4.Location = New System.Drawing.Point(119, 178)
        Me.txtCourse4.Name = "txtCourse4"
        Me.txtCourse4.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse4.TabIndex = 4
        Me.txtCourse4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtCourse4, "Number Grade Input")
        '
        'txtCourse3
        '
        Me.txtCourse3.Location = New System.Drawing.Point(119, 126)
        Me.txtCourse3.Name = "txtCourse3"
        Me.txtCourse3.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse3.TabIndex = 3
        Me.txtCourse3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtCourse3, "Number Grade Input")
        '
        'txtCourse5
        '
        Me.txtCourse5.Location = New System.Drawing.Point(119, 230)
        Me.txtCourse5.Name = "txtCourse5"
        Me.txtCourse5.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse5.TabIndex = 5
        Me.txtCourse5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtCourse5, "Number Grade Input")
        '
        'txtCourse6
        '
        Me.txtCourse6.Location = New System.Drawing.Point(119, 282)
        Me.txtCourse6.Name = "txtCourse6"
        Me.txtCourse6.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse6.TabIndex = 6
        Me.txtCourse6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtCourse6, "Number Grade Input")
        '
        'lblCourse1
        '
        Me.lblCourse1.Location = New System.Drawing.Point(52, 22)
        Me.lblCourse1.Name = "lblCourse1"
        Me.lblCourse1.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse1.TabIndex = 0
        Me.lblCourse1.Text = "Course 1:"
        Me.lblCourse1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblCourse1, "Labels")
        '
        'lblCourse2
        '
        Me.lblCourse2.Location = New System.Drawing.Point(52, 74)
        Me.lblCourse2.Name = "lblCourse2"
        Me.lblCourse2.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse2.TabIndex = 0
        Me.lblCourse2.Text = "Course 2:"
        Me.lblCourse2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblCourse2, "Labels")
        '
        'lblCourse3
        '
        Me.lblCourse3.Location = New System.Drawing.Point(52, 126)
        Me.lblCourse3.Name = "lblCourse3"
        Me.lblCourse3.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse3.TabIndex = 0
        Me.lblCourse3.Text = "Course 3:"
        Me.lblCourse3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblCourse3, "Labels")
        '
        'lblCourse4
        '
        Me.lblCourse4.Location = New System.Drawing.Point(52, 178)
        Me.lblCourse4.Name = "lblCourse4"
        Me.lblCourse4.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse4.TabIndex = 0
        Me.lblCourse4.Text = "Course 4:"
        Me.lblCourse4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblCourse4, "Labels")
        '
        'lblCourse6
        '
        Me.lblCourse6.Location = New System.Drawing.Point(52, 282)
        Me.lblCourse6.Name = "lblCourse6"
        Me.lblCourse6.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse6.TabIndex = 0
        Me.lblCourse6.Text = "Course 6:"
        Me.lblCourse6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblCourse6, "Labels")
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Location = New System.Drawing.Point(52, 334)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(54, 13)
        Me.lblSemester.TabIndex = 0
        Me.lblSemester.Text = "Semester:"
        Me.ToolTip1.SetToolTip(Me.lblSemester, "Labels")
        '
        'lblCourse5
        '
        Me.lblCourse5.Location = New System.Drawing.Point(52, 230)
        Me.lblCourse5.Name = "lblCourse5"
        Me.lblCourse5.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse5.TabIndex = 0
        Me.lblCourse5.Text = "Course 5:"
        Me.lblCourse5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblCourse5, "Labels")
        '
        'lblError
        '
        Me.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblError.Location = New System.Drawing.Point(23, 388)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(302, 125)
        Me.lblError.TabIndex = 0
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblError, "Error message box")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(95, 516)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Calculate the average")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(176, 516)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Re&set"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Reset the program")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(257, 516)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exit the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblOverall
        '
        Me.lblOverall.AutoSize = True
        Me.lblOverall.Location = New System.Drawing.Point(254, 334)
        Me.lblOverall.Name = "lblOverall"
        Me.lblOverall.Size = New System.Drawing.Size(39, 13)
        Me.lblOverall.TabIndex = 11
        Me.lblOverall.Text = "Label1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(254, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Label1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Label1"
        '
        'lblGr1
        '
        Me.lblGr1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGr1.Location = New System.Drawing.Point(254, 22)
        Me.lblGr1.Name = "lblGr1"
        Me.lblGr1.Size = New System.Drawing.Size(62, 20)
        Me.lblGr1.TabIndex = 11
        Me.lblGr1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblGr1, "Letter Grade Output")
        '
        'lblGr2
        '
        Me.lblGr2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGr2.Location = New System.Drawing.Point(254, 74)
        Me.lblGr2.Name = "lblGr2"
        Me.lblGr2.Size = New System.Drawing.Size(62, 20)
        Me.lblGr2.TabIndex = 11
        Me.lblGr2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblGr2, "Letter Grade Output")
        '
        'lblGr3
        '
        Me.lblGr3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGr3.Location = New System.Drawing.Point(254, 126)
        Me.lblGr3.Name = "lblGr3"
        Me.lblGr3.Size = New System.Drawing.Size(62, 20)
        Me.lblGr3.TabIndex = 11
        Me.lblGr3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblGr3, "Letter Grade Output")
        '
        'lblGr4
        '
        Me.lblGr4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGr4.Location = New System.Drawing.Point(254, 178)
        Me.lblGr4.Name = "lblGr4"
        Me.lblGr4.Size = New System.Drawing.Size(62, 20)
        Me.lblGr4.TabIndex = 11
        Me.lblGr4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblGr4, "Letter Grade Output")
        '
        'lblGr5
        '
        Me.lblGr5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGr5.Location = New System.Drawing.Point(254, 230)
        Me.lblGr5.Name = "lblGr5"
        Me.lblGr5.Size = New System.Drawing.Size(62, 20)
        Me.lblGr5.TabIndex = 11
        Me.lblGr5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblGr5, "Letter Grade Output")
        '
        'lblGr6
        '
        Me.lblGr6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGr6.Location = New System.Drawing.Point(254, 282)
        Me.lblGr6.Name = "lblGr6"
        Me.lblGr6.Size = New System.Drawing.Size(62, 20)
        Me.lblGr6.TabIndex = 11
        Me.lblGr6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblGr6, "Letter Grade Output")
        '
        'lblOverallLetter
        '
        Me.lblOverallLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOverallLetter.Location = New System.Drawing.Point(254, 326)
        Me.lblOverallLetter.Name = "lblOverallLetter"
        Me.lblOverallLetter.Size = New System.Drawing.Size(62, 21)
        Me.lblOverallLetter.TabIndex = 11
        Me.lblOverallLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblOverallLetter, "Semester Average output")
        '
        'lblOverallNumber
        '
        Me.lblOverallNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOverallNumber.Location = New System.Drawing.Point(119, 326)
        Me.lblOverallNumber.Name = "lblOverallNumber"
        Me.lblOverallNumber.Size = New System.Drawing.Size(100, 21)
        Me.lblOverallNumber.TabIndex = 11
        Me.lblOverallNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblOverallNumber, "Semester Average output")
        '
        'frmSemesterAverage
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(337, 568)
        Me.Controls.Add(Me.lblOverallNumber)
        Me.Controls.Add(Me.lblOverallLetter)
        Me.Controls.Add(Me.lblGr6)
        Me.Controls.Add(Me.lblGr5)
        Me.Controls.Add(Me.lblGr4)
        Me.Controls.Add(Me.lblGr3)
        Me.Controls.Add(Me.lblGr2)
        Me.Controls.Add(Me.lblGr1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblCourse5)
        Me.Controls.Add(Me.lblCourse6)
        Me.Controls.Add(Me.lblCourse4)
        Me.Controls.Add(Me.lblCourse3)
        Me.Controls.Add(Me.lblCourse2)
        Me.Controls.Add(Me.lblCourse1)
        Me.Controls.Add(Me.txtCourse3)
        Me.Controls.Add(Me.txtCourse6)
        Me.Controls.Add(Me.txtCourse5)
        Me.Controls.Add(Me.txtCourse4)
        Me.Controls.Add(Me.txtCourse2)
        Me.Controls.Add(Me.txtCourse1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSemesterAverage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCourse1 As TextBox
    Friend WithEvents txtCourse2 As TextBox
    Friend WithEvents txtCourse4 As TextBox
    Friend WithEvents txtCourse3 As TextBox
    Friend WithEvents txtCourse5 As TextBox
    Friend WithEvents txtCourse6 As TextBox
    Friend WithEvents lblSemester As Label
    Friend WithEvents lblError As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblGrade1 As Label
    Friend WithEvents lblGrade2 As Label
    Friend WithEvents lblGrade3 As Label
    Friend WithEvents lblGrade4 As Label
    Friend WithEvents lblGrade5 As Label
    Friend WithEvents lblGrade6 As Label
    Friend WithEvents lblOverallGrade As Label
    Friend WithEvents lblOverallPercent As Label
    Friend WithEvents lblOverall As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblGr1 As Label
    Friend WithEvents lblGr2 As Label
    Friend WithEvents lblGr3 As Label
    Friend WithEvents lblGr4 As Label
    Friend WithEvents lblGr5 As Label
    Friend WithEvents lblGr6 As Label
    Friend WithEvents lblOverallLetter As Label
    Friend WithEvents lblOverallNumber As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblCourse1 As Label
    Friend WithEvents lblCourse2 As Label
    Friend WithEvents lblCourse3 As Label
    Friend WithEvents lblCourse4 As Label
    Friend WithEvents lblCourse6 As Label
    Friend WithEvents lblCourse5 As Label
End Class
