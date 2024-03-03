Imports Microsoft.VisualBasic.PowerPacks
Imports System.Windows.Forms ' Required for MessageBox
Imports System.Threading

Public Class Form1

    'Iniitialising the arrays
    Dim input1() As Integer = {0, 0, 0, 0, 0, 0, 0, 0}
    Dim input2() As Integer = {0, 0, 0, 0, 0, 0, 0, 0}
    Dim result() As Integer = {0, 0, 0, 0, 0, 0, 0, 0}

    Dim shapeContainer As New ShapeContainer()

    Dim Abacus_input1(8, 5) As Abacus_Bead
    Dim Abacus_input2(8, 5) As Abacus_Bead
    Dim Abacus_result(8, 5) As Abacus_Bead

    Dim addTimer As New System.Windows.Forms.Timer()

    Dim WithEvents subtrTimer As New System.Windows.Forms.Timer()



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AutoScroll() = True
        Me.SuspendLayout()

        Dim locx As Integer = 50
        Dim locy As Integer = 227

        subtrTimer.Interval = 500

        addTimer.Interval = 500

        ' Enable the timer
        addTimer.Enabled = True
        subtrTimer.Enabled = False


        For i As Integer = 0 To 7
            For j As Integer = 0 To 3
                Abacus_input1(i, j) = New Abacus_Bead()

                Abacus_input1(i, j).Name = String.Format("Input{0}{1}{2}", 1, i, j)
                Abacus_input1(i, j).Location = New System.Drawing.Point(locx, locy)
                Abacus_input1(i, j).Size = New System.Drawing.Size(48, 23)
                Abacus_input1(i, j).FillColor = Color.Maroon

                Me.ShapeContainer1.Shapes.Add(Abacus_input1(i, j))


                locy -= 25
            Next
            locy = 227
            locx += 50
        Next
        locx = 50
        locy = 84
        For i As Integer = 0 To 7
            For j As Integer = 4 To 4
                Abacus_input1(i, j) = New Abacus_Bead()

                Abacus_input1(i, j).Name = String.Format("Input{0}{1}{2}", 1, i, j)
                Abacus_input1(i, j).Location = New System.Drawing.Point(locx, locy)
                Abacus_input1(i, j).Size = New System.Drawing.Size(48, 23)
                Abacus_input1(i, j).FillColor = Color.Maroon

                Me.ShapeContainer1.Shapes.Add(Abacus_input1(i, j))
            Next
            locy = 84
            locx += 50
        Next

        locx = 50
        locy = 457

        For i As Integer = 0 To 7
            For j As Integer = 0 To 3
                Abacus_input2(i, j) = New Abacus_Bead()

                Abacus_input2(i, j).Name = String.Format("Input{0}{1}{2}", 2, i, j)
                Abacus_input2(i, j).Location = New System.Drawing.Point(locx, locy)
                Abacus_input2(i, j).Size = New System.Drawing.Size(48, 23)
                Abacus_input2(i, j).FillColor = Color.Maroon

                Me.ShapeContainer1.Shapes.Add(Abacus_input2(i, j))


                locy -= 25
            Next
            locy = 457
            locx += 50
        Next
        locx = 50
        locy = 314
        For i As Integer = 0 To 7
            For j As Integer = 4 To 4
                Abacus_input2(i, j) = New Abacus_Bead()

                Abacus_input2(i, j).Name = String.Format("Input{0}{1}{2}", 2, i, j)
                Abacus_input2(i, j).Location = New System.Drawing.Point(locx, locy)
                Abacus_input2(i, j).Size = New System.Drawing.Size(48, 23)
                Abacus_input2(i, j).FillColor = Color.Maroon

                Me.ShapeContainer1.Shapes.Add(Abacus_input2(i, j))




            Next
            locy = 314
            locx += 50
        Next

        '67,591,734
        locx = 67
        locy = 734

        For i As Integer = 0 To 7
            For j As Integer = 0 To 3
                Abacus_result(i, j) = New Abacus_Bead()

                Abacus_result(i, j).Name = String.Format("result{0}{1}", i, j)
                Abacus_result(i, j).Location = New System.Drawing.Point(locx, locy)
                Abacus_result(i, j).Size = New System.Drawing.Size(48, 23)
                Abacus_result(i, j).FillColor = Color.Maroon

                Me.ShapeContainer1.Shapes.Add(Abacus_result(i, j))


                locy -= 25
            Next
            locy = 734
            locx += 50
        Next
        locx = 67
        locy = 591
        For i As Integer = 0 To 7
            For j As Integer = 4 To 4
                Abacus_result(i, j) = New Abacus_Bead()

                Abacus_result(i, j).Name = String.Format("result{0}{1}", i, j)
                Abacus_result(i, j).Location = New System.Drawing.Point(locx, locy)
                Abacus_result(i, j).Size = New System.Drawing.Size(48, 23)
                Abacus_result(i, j).FillColor = Color.Maroon

                Me.ShapeContainer1.Shapes.Add(Abacus_result(i, j))


            Next
            locy = 591
            locx += 50
        Next

        Me.ResumeLayout(False)
    End Sub

    Private Sub BeadHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim clicked_bead As Abacus_Bead = DirectCast(sender, Abacus_Bead)


    End Sub
    Private Sub MoveBeadUp(ByVal col As Integer, ByVal row As Integer, ByVal name As String)
        If name = "Input1" Then
            Abacus_input1(col, row).Top() -= 25

        ElseIf name = "Input2" Then
            Abacus_input2(col, row).Top() -= 25

        ElseIf name = "result" Then
            Abacus_result(col, row).Top() -= 25

        End If

    End Sub
    Private Sub MoveBeadDown(ByVal col As Integer, ByVal row As Integer, ByVal name As String)
        If name = "Input1" Then
            Abacus_input1(col, row).Top() += 25

        ElseIf name = "Input2" Then
            Abacus_input2(col, row).Top() += 25

        ElseIf name = "result" Then
            Abacus_result(col, row).Top() += 25

        End If

    End Sub

    Public Sub UpdateCol(ByVal col As Integer, ByVal name As String, ByVal value As Integer)
        If name = "Input1" Then
            Dim locx As Integer = 50 + col * 50
            Dim locy As Integer = 227
            For j As Integer = 0 To 3
                Abacus_input1(col, j).Location = New System.Drawing.Point(locx, locy)
                locy -= 25
            Next
            locy = 84
            Abacus_input1(col, 4).Location = New System.Drawing.Point(locx, locy)
        ElseIf name = "Input2" Then
            Dim locx As Integer = 50 + col * 50
            Dim locy As Integer = 457
            For j As Integer = 0 To 3
                Abacus_input2(col, j).Location = New System.Drawing.Point(locx, locy)
                locy -= 25
            Next
            locy = 314
            Abacus_input2(col, 4).Location = New System.Drawing.Point(locx, locy)
        ElseIf name = "result" Then
            Dim locx As Integer = 67 + col * 50
            Dim locy As Integer = 734
            For j As Integer = 0 To 3
                Abacus_result(col, j).Location = New System.Drawing.Point(locx, locy)
                locy -= 25
            Next
            locy = 591
            Abacus_result(col, 4).Location = New System.Drawing.Point(locx, locy)
        End If
        If value = 1 Then
            MoveBeadUp(col, 3, name)
        ElseIf value = 2 Then
            MoveBeadUp(col, 3, name)
            MoveBeadUp(col, 2, name)
        ElseIf value = 3 Then
            MoveBeadUp(col, 3, name)
            MoveBeadUp(col, 2, name)
            MoveBeadUp(col, 1, name)
        ElseIf value = 4 Then
            MoveBeadUp(col, 3, name)
            MoveBeadUp(col, 2, name)
            MoveBeadUp(col, 1, name)
            MoveBeadUp(col, 0, name)
        ElseIf value = 5 Then

            MoveBeadDown(col, 4, name)
        ElseIf value = 6 Then
            MoveBeadDown(col, 4, name)
            MoveBeadUp(col, 3, name)
        ElseIf value = 7 Then
            MoveBeadDown(col, 4, name)
            MoveBeadUp(col, 3, name)
            MoveBeadUp(col, 2, name)
        ElseIf value = 8 Then
            MoveBeadDown(col, 4, name)
            MoveBeadUp(col, 3, name)
            MoveBeadUp(col, 2, name)
            MoveBeadUp(col, 1, name)
        ElseIf value = 9 Then
            MoveBeadDown(col, 4, name)
            MoveBeadUp(col, 3, name)
            MoveBeadUp(col, 2, name)
            MoveBeadUp(col, 1, name)
            MoveBeadUp(col, 0, name)

        End If

    End Sub
    Private Sub AddArrays(ByVal array1 As Integer(), ByVal array2 As Integer(), ByRef resultArray As Integer())
        ' Check if the arrays have the same length
        If array1.Length <> array2.Length OrElse resultArray.Length <> 8 Then
            Throw New ArgumentException("Arrays must have the same length, and resultArray must be of size 8.")
        End If

        ' Perform array addition with carry
        Dim carry As Integer = 0

        ' Counter for the array elements
        Dim i As Integer = array1.Length - 1


        ' Handle the Tick event
        AddHandler addTimer.Tick,
            Sub(sender As Object, e As EventArgs)
                ' Perform the addition for the current element
                Dim sum As Integer = array1(i) + array2(i) + carry
                result(i) = sum Mod 10
                carry = sum \ 10

                ' Handle carry
                If carry > 0 Then
                    ' Update the adjacent column to the left
                    If i > 0 Then
                        result(i - 1) += carry
                    Else
                        ' If there is no adjacent column, display a message
                        MessageBox.Show("Carry generated in the leftmost column.")
                    End If
                End If

                ' Update the UI
                UpdateCol(i, "result", result(i))

                ' Move to the previous element
                i -= 1

                ' Check if we have processed all elements
                If i < 0 Then
                    ' Stop the timer when all elements are processed
                    addTimer.Stop()
                End If
            End Sub

        ' Start the timer
        addTimer.Start()
    End Sub
    'Private Sub SubtractArrays(ByVal array1 As Integer(), ByVal array2 As Integer(), ByRef resultArray As Integer())
    '    ' Check if the first input is greater than or equal to the second input
    '    If Not IsGreaterOrEqual(array1, array2) Then
    '        ' Display a message box and enable buttons
    '        MessageBox.Show("Input1 must be greater than or equal to Input2.")
    '        enableButtons()
    '        TextBox1.ReadOnly = False
    '        TextBox2.ReadOnly = False
    '        Exit Sub
    '    End If

    '    ' Determine the actual number of digits in array1
    '    Dim actualLength As Integer = array1.Length
    '    While actualLength > 1 AndAlso array1(actualLength - 1) = 0
    '        actualLength -= 1
    '    End While

    '    ' Perform array subtraction with borrow
    '    Dim borrow As Integer = 0

    '    ' Event handler for the subtraction timer tick
    '    AddHandler subtrTimer.Tick, Sub(sender As Object, e As EventArgs)
    '                                    ' Stop the timer after the tick event
    '                                    subtrTimer.Stop()
    '                                End Sub

    '    ' Iterate from rightmost digit to thousands place
    '    For i As Integer = actualLength - 1 To Math.Max(actualLength - 4, 0) Step -1
    '        Dim diff As Integer = array1(i) - array2(i) - borrow

    '        ' Adjust for borrow
    '        If diff < 0 Then
    '            ' Determine if it's necessary to borrow from the next higher digit
    '            Dim borrowIndex As Integer = i - 1

    '            borrow = 1
    '            ' Update the Abacus_result for borrow
    '            For j As Integer = borrowIndex To Math.Max(actualLength - 4, 0) Step -1
    '                UpdateCol(j, "result", 1)
    '            Next

    '            ' Start the timer
    '            subtrTimer.Start()
    '            ' Wait for the timer to stop (non-blocking)
    '            Do While subtrTimer.Enabled
    '                Application.DoEvents()
    '            Loop

    '            diff += 10
    '        Else
    '            ' No borrow needed
    '            borrow = 0
    '        End If

    '        resultArray(i) = diff

    '        ' Update the Abacus_result
    '        UpdateCol(i, "result", resultArray(i))

    '        ' Start the timer
    '        subtrTimer.Start()
    '        ' Wait for the timer to stop (non-blocking)
    '        Do While subtrTimer.Enabled
    '            Application.DoEvents()
    '        Loop
    '    Next

    '    ' Enable buttons and set ReadOnly to False for input fields
    '    enableButtons()
    '    TextBox1.ReadOnly = False
    '    TextBox2.ReadOnly = False
    'End Sub


    '' Function to determine the index to borrow from
    'Private Function GetBorrowIndex(ByVal array1 As Integer(), ByVal array2 As Integer(), ByVal currentIndex As Integer) As Integer
    '    For i As Integer = currentIndex - 1 To 0 Step -1
    '        If array1(i) > array2(i) Then
    '            Return i
    '        ElseIf array1(i) < array2(i) Then
    '            Return -1 ' No need to borrow
    '        End If
    '    Next

    '    Return -1 ' No need to borrow
    'End Function

    Private Sub SubtractArrays(ByVal array1 As Integer(), ByVal array2 As Integer(), ByRef resultArray As Integer())
        ' Check if the first input is greater than or equal to the second input
        If Not IsGreaterOrEqual(array1, array2) Then
            ' Display a message box and enable buttons
            MessageBox.Show("Input1 must be greater than or equal to Input2.")
            enableButtons()
            TextBox1.ReadOnly = False
            TextBox2.ReadOnly = False
            Exit Sub
        End If

        ' Determine the actual number of digits in array1
        Dim actualLength As Integer = array1.Length
        While actualLength > 1 AndAlso array1(actualLength - 1) = 0
            actualLength -= 1
        End While

        ' Perform array subtraction with borrow
        Dim borrow As Integer = 0
   

        ' Event handler for the subtraction timer tick
        AddHandler subtrTimer.Tick, Sub(sender As Object, e As EventArgs)
                                        ' Stop the timer after the tick event
                                        subtrTimer.Stop()
                                    End Sub

        ' Iterate from rightmost digit to the end of the array
        For i As Integer = actualLength - 1 To 0 Step -1
            Dim diff As Integer = array1(i) - array2(i) - borrow

            ' Adjust for borrow
            If diff < 0 Then
                ' Determine if it's necessary to borrow from the next higher digit
                Dim borrowIndex As Integer = i - 1

                borrow = 1

                ' Start the timer
                subtrTimer.Start()
                ' Wait for the timer to stop (non-blocking)
                Do While subtrTimer.Enabled
                    Application.DoEvents()
                Loop

                diff += 10
            Else
                ' No borrow needed
                borrow = 0
            End If

            resultArray(i) = diff

            ' Update the Abacus_result
            UpdateCol(i, "result", resultArray(i))

            ' Start the timer
            subtrTimer.Start()
            ' Wait for the timer to stop (non-blocking)
            Do While subtrTimer.Enabled
                Application.DoEvents()
            Loop
        Next

        ' Enable buttons and set ReadOnly to False for input fields
        enableButtons()
        TextBox1.ReadOnly = False
        TextBox2.ReadOnly = False
    End Sub

  

    ' Function to enable buttons
    Private Sub enableButtons()
        enterbtn1.Enabled = True
        clearbtn1.Enabled = True
        enterbtn2.Enabled = True
        clrbtn2.Enabled = True
        addnbtn.Enabled = True
        subtrctnbtn.Enabled = True
        resetbtn.Enabled = True
    End Sub






    ' Helper function to check if array1 is greater than or equal to array2
    Private Function IsGreaterOrEqual(ByVal array1 As Integer(), ByVal array2 As Integer()) As Boolean
        For i As Integer = 0 To array1.Length - 1
            If array1(i) < array2(i) Then
                Return False
            ElseIf array1(i) > array2(i) Then
                Return True
            End If
        Next
        Return True
    End Function



    Private Sub UpdateInputArray(ByVal name As String)
        ' Get the text from the TextBox
        If name = "Input1" Then
            Dim inputText As String = TextBox1.Text

            ' Validate the input string
            If IsValidInput(inputText) Then
                ' Convert the string to an integer
                Dim intValue As Integer = Integer.Parse(inputText)

                ' Convert the integer to an 8-digit array
                input1 = ConvertTo8DigitArray(intValue)
            Else
                ' Display a message if the input is not valid
                MessageBox.Show("Please enter a non-negative integer with at most 8 digits.")
            End If
        ElseIf name = "Input2" Then
            Dim inputText As String = TextBox2.Text

            ' Validate the input string
            If IsValidInput(inputText) Then
                ' Convert the string to an integer
                Dim intValue As Integer = Integer.Parse(inputText)

                ' Convert the integer to an 8-digit array
                input2 = ConvertTo8DigitArray(intValue)

            Else
                ' Display a message if the input is not valid
                MessageBox.Show("Please enter a non-negative integer with at most 8 digits.")
            End If
        End If


    End Sub

    ' Function to validate the input string
    Private Function IsValidInput(ByVal inputText As String) As Boolean
        Dim intValue As Integer

        ' Check if the string is not empty, non-negative, and has at most 8 digits
        If Not String.IsNullOrEmpty(inputText) AndAlso
           Integer.TryParse(inputText, intValue) AndAlso
           intValue >= 0 AndAlso
           inputText.Length <= 8 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function ConvertTo8DigitArray(ByVal value As Integer) As Integer()
        ' Convert the integer to a string and pad with leading zeros
        Dim stringValue As String = value.ToString().PadLeft(8, "0"c)

        ' Convert each character to an integer and create an array
        Return stringValue.Select(Function(c) CInt(c.ToString())).ToArray()
    End Function

    Private Sub enterbtn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterbtn1.Click
        'Dim name As String = "Input103"

        'Abacus_input1(0, 3).Top() -= 25

        'Dim input_txt As String = TextBox1.Text
        clearbtn1.Enabled = False
        TextBox1.ReadOnly = True
        UpdateInputArray("Input1")
        For i As Integer = 0 To 7
            UpdateCol(i, "Input1", input1(i))
        Next

        clearbtn1.Enabled = True
        TextBox1.ReadOnly = False






    End Sub

    Private Sub enterbtn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterbtn2.Click
        clrbtn2.Enabled = False
        TextBox2.ReadOnly = True
        UpdateInputArray("Input2")
        For i As Integer = 0 To 7
            UpdateCol(i, "Input2", input2(i))
        Next

        clrbtn2.Enabled = True
        TextBox2.ReadOnly = False

    End Sub

    Private Sub clearbtn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbtn1.Click
        TextBox1.Text = ""
        input1 = {0, 0, 0, 0, 0, 0, 0, 0}


        For i As Integer = 0 To 7
            UpdateCol(i, "Input1", input1(i))
        Next

    End Sub

    Private Sub clrbtn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clrbtn2.Click
        TextBox2.Text = ""
        input2 = {0, 0, 0, 0, 0, 0, 0, 0}

        For i As Integer = 0 To 7
            UpdateCol(i, "Input2", input2(i))
        Next
    End Sub

    Private Sub addnbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addnbtn.Click
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        clearbtn1.Enabled = False
        clrbtn2.Enabled = False
        enterbtn1.Enabled = False
        enterbtn2.Enabled = False
        subtrctnbtn.Enabled = False
        addnbtn.Enabled = False
        resetbtn.Enabled = False
        AddArrays(input1, input2, result)
        resetbtn.Enabled = True




    End Sub

    Private Sub subtrctnbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subtrctnbtn.Click
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        clearbtn1.Enabled = False
        clrbtn2.Enabled = False
        enterbtn1.Enabled = False
        enterbtn2.Enabled = False
        subtrctnbtn.Enabled = False
        addnbtn.Enabled = False
        resetbtn.Enabled = False
        SubtractArrays(input1, input2, result)
        resetbtn.Enabled = True
    End Sub

    Private Sub resetbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetbtn.Click

        clearbtn1.Enabled = True
        clrbtn2.Enabled = True
        clearbtn1.PerformClick()
        clrbtn2.PerformClick()

        result = {0, 0, 0, 0, 0, 0, 0, 0}
        For i As Integer = 0 To 7
            UpdateCol(i, "result", result(i))
        Next
        enterbtn1.Enabled = True
        enterbtn2.Enabled = True

        TextBox1.ReadOnly = False
        TextBox2.ReadOnly = False

        addnbtn.Enabled = True
        subtrctnbtn.Enabled = True
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub
End Class
Public Class Abacus_Bead
    Inherits Microsoft.VisualBasic.PowerPacks.OvalShape

    Private _state As Integer
    Public Sub New()
        ' Set the default properties
        Me.Size = New System.Drawing.Size(48, 23)
        Me.FillColor = Color.Maroon
        Me.BorderColor = Color.Black
        Me.BackColor = Color.DarkRed
        Me.BackStyle = PowerPacks.BackStyle.Transparent
        Me.BorderStyle = Drawing2D.DashStyle.Dash
        Me.FillGradientColor = Color.Maroon
        Me.FillStyle = PowerPacks.FillStyle.Solid




    End Sub
    Private Active As System.Drawing.Point
    Private DeActive As System.Drawing.Point

    Public Property State As Integer
        Get
            Return _state
        End Get
        Set(ByVal value As Integer)
            _state = value
        End Set
    End Property
End Class
