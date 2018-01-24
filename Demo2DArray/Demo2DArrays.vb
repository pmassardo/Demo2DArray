''' <summary>
''' Author:         Alfred Massardo
''' Project Name:   Demo2DArrays
''' Date:           23-Jan-2018
''' Description:    Simple program to demonstrate creating, loading, looping, and display the content of a 2 dimensional array.
''' </summary>
Public Class frmDemo2DArrays

    ' Class Level Constants
    Private Const lastRowIndex As Integer = 2     ' what is the last row index for the 2d array
    Private Const lastColumnIndex As Integer = 1  ' what is the last column index for the 2d array

    ' Class Level Variabl3
    ' 2 dimensional array
    ' 2 columns = 1
    ' 3 rows = 2
    Private numberArray(lastRowIndex, lastColumnIndex) As Double

    '    C   C
    ' R  1 - 2
    ' R  3 - 4
    ' R  5 - 6
    ' Row Length - 3
    ' Row Last Index - 2 (0,1,2)
    ' Column Length - 2
    ' Column Last Index - 1 (0,1)

    Private currentRowIndex As Integer = 0     ' used to maintain the current row index
    Private currentColumnIndex As Integer = 0  ' used to maintain the current column index

    ''' <summary>
    ''' btnEnter_Click - enters the number into the 2D array. The location is depends upon the number of times the user has entered
    '''                  entered a number, until the array is full. Once the 2D array is full a separate sub is called to display 
    '''                  the array contents in the output label.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' input the number entered into the array
        ' no validation to simplify the code
        numberArray(currentRowIndex, currentColumnIndex) = Convert.ToDouble(tbInput.Text)

        ' if the row lindex is less than the last index
        ' and the column counter is the last column
        ' move to the next row and reset the column to the start
        ' 1   (0,0)          2 (0,1)
        ' 3   (1,0)          4 (1,1)
        ' 5   (2,0)          6 (2,1)
        If currentRowIndex < lastRowIndex And currentColumnIndex = lastColumnIndex Then

            'move to the next row
            currentRowIndex += 1

            'reset to the first column index
            currentColumnIndex = 0

            '' add carriage return line feed 
            '' to move to the next row
            'lbOutput.Text += vbCrLf

        ElseIf currentRowIndex = lastRowIndex And currentColumnIndex = lastColumnIndex Then
            ' if this is the last row and last index

            ' disable the control so the user
            ' cannot enter any more numbers
            btnEnter.Enabled = False
            tbInput.Enabled = False

        Else

            ' increment the column counter
            currentColumnIndex += 1

        End If

        ' clear the input text box
        tbInput.Text = String.Empty

        ' sub to display the content of the array
        ' in the output label
        DisplayArrayContents(numberArray)

    End Sub
    ''' <summary>
    ''' DisplayArrayContents - sub to display the content of the array passed to it.
    ''' </summary>
    ''' <param name="arrayParameter"></param>
    Private Sub DisplayArrayContents(arrayParameter(,) As Double)

        ' clear the output box 
        ' to display the new values
        lbOutput.Text = String.Empty

        'arrayParameter(0, 0) = 50

        ' loop through all the rows
        For rowIndex As Integer = 0 To arrayParameter.GetLength(0) - 1 ' this looks at the length of the 1st dimension or the row index

            ' And for each row loops through all the columns in that row
            For columnIndex As Integer = 0 To arrayParameter.GetLength(1) - 1 ' this looks at the length of the 2nd dimension or the column index

                ' get the value at the interection of the specific row and column
                ' and append a space to the end to create a separation between
                ' entries
                lbOutput.Text += arrayParameter(rowIndex, columnIndex).ToString() & " "

            Next columnIndex ' next column index

            lbOutput.Text += vbCrLf ' between rows append a carriage return line feed 

        Next rowIndex ' next row index

        ' 2 4
        ' 6 8
        ' 10 12

    End Sub

    ''' <summary>
    ''' ResetForm sub that clears/resets the form
    ''' </summary>
    ''' <param name="arrayParameter"></param>
    Private Sub ResetForm(arrayParameter(,) As Double)

        ' loop through each row
        For rowIndex As Integer = 0 To arrayParameter.GetLength(0) - 1

            ' loop through each column
            For columnIndex As Integer = 0 To arrayParameter.GetLength(1) - 1

                ' set the value to zero
                arrayParameter(rowIndex, columnIndex) = 0

            Next columnIndex ' next column

        Next rowIndex ' next row

        ' reset form/class level variables
        currentColumnIndex = 0   ' reset the input column counter
        currentRowIndex = 0      ' reset the input row counter

        lbOutput.Text = String.Empty    ' clear the output label

        ' enable the enter button
        btnEnter.Enabled = True ' endble the enter button 
        tbInput.Enabled = True  ' endble the input text box 
        tbInput.Focus()         ' set the focus to the input text box


    End Sub

    ''' <summary>
    ''' btnReset_Click - event that resets the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' Call the reset form sub
        ResetForm(numberArray)

    End Sub
End Class
