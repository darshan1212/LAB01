Public Class Form1
    Dim listUnits As New List(Of String)
    Dim averageUnits As Integer = 0


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Const DaysInWeek As Short = 7

        Dim enteredNumber As Integer

        If Integer.TryParse(txtInput.Text, enteredNumber) Then
            ' text is convertible to Double, and value contains the Double value now
            listUnits.Add(txtInput.Text)
            richTxtBox.Lines = listUnits.ToArray()
            averageUnits = averageUnits + enteredNumber
            lblDay.Text = "Day " & listUnits.Count & " :"
        Else
            ' Cannot convert text to Double
            MessageBox.Show("Enter valid input. Input must be an integer")
            ' reset code goes over here
            txtInput.SelectionStart = 0
            txtInput.DeselectAll()
            txtInput.SelectAll()

        End If

        If (listUnits.Count = DaysInWeek) Then
            averageUnits = averageUnits / DaysInWeek
            lblAverage.Text = "Average Units Shipped:" + averageUnits.ToString
            listUnits.Clear()
            averageUnits = 0
            txtInput.Clear()
            btnEnter.Enabled = False
            txtInput.Enabled = False
        End If


    End Sub

    Private Sub richTxtBox_TextChanged(sender As Object, e As EventArgs) Handles richTxtBox.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        listUnits.Clear()
        averageUnits = 0
        txtInput.Clear()
        richTxtBox.Clear()
        lblAverage.Text = ""
        lblDay.Text = "Day 1:"
        btnEnter.Enabled = True
        txtInput.Enabled = True
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub
End Class
