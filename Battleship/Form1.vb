Public Class Form1
    'Author: James Fehr 2023-03-09
    'Battleship Project
    '-----------------------------------------------------------------------------------
    Dim GBA(,) As String ' = {{"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}, {"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}, {"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}, {"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}, {"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}} 'array of Os
    Sub PrintBoard()
        Output1.Clear()
        For Index = 0 To GBA.GetUpperBound(0)                       'starting for loop
            For innerIndex = 0 To GBA.GetUpperBound(1)           'run loop from zero => length of array
                Output1.Text += GBA(Index, innerIndex)              'output array value
                ' Output1.Text += vbCrLf
            Next
            Output1.Text += vbCrLf                                  'add a line return to output 
        Next

    End Sub

    Private Sub Ex1_Click(sender As Object, e As EventArgs) Handles Ex1.Click
        'Initialize Gameboard


        GBA = New String(4, 4) {{"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}, {"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}, {"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}, {"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}, {"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}} 'array of Os
        PrintBoard()
        MessageBox.Show("Battleship Initialized")                              'Message the output value for user

    End Sub
    Private Sub Fire_Click(sender As Object, e As EventArgs) Handles Fire.Click
        Dim Xval As Integer
        Xval = (Convert.ToInt32(Xv.Text))       'gets and converts values to integers
        Dim Yval As Integer
        Yval = (Convert.ToInt32(Yv.Text))       'gets and converts values to integers
        If (Xval = 0 And Yval = 0) Then  'checks to see if x,y coordinates are in bounds
            GBA(Yval, Xval) = "Ⓧ"       'if in bounds changes item in array to hit
        ElseIf (Xval = 0 Or Xval <= 4) And (Yval = 0 Or Yval <= 4) Then
            GBA(Yval, Xval) = "Ⓧ"       'if in bounds changes item in array to hit
        ElseIf (Xval > 4) Then     'checks if out of bounds
            MessageBox.Show("Out of bounds")
            Xv.Text = ""                        'resets Xv coordinate
            'Yv.Text = ""                        'resets Yv coodinate
        ElseIf (Yval > 4) Then     'checks if out of bounds
            MessageBox.Show("Out of bounds")
            'Xv.Text = ""                        'resets Xv coordinate
            Yv.Text = ""                        'resets Yv coodinate
        End If
        PrintBoard()
    End Sub


End Class
