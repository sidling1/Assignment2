Public Class Form1

    Dim Abacus_input1(8, 5) As Abacus_Bead
    Dim Abacus_input2(8, 5) As Abacus_Bead
    Dim Abacus_result(8, 5) As Abacus_Bead


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SuspendLayout()

        Dim locx As Integer = 30
        Dim locy As Integer = 100

        For i As Integer = 0 To 7
            For j As Integer = 0 To 4
                Abacus_input1(i, j) = New Abacus_Bead()

                Abacus_input1(i, j).Name = String.Format("{0}-{1}-{2}", 1, i, j)
                Abacus_input1(i, j).Location = New System.Drawing.Point(locx, locy)
                Abacus_input1(i, j).Size = New System.Drawing.Size(25, 10)

                Me.ShapeContainer1.Shapes.Add(Abacus_input1(i, j))


                locy += 10
            Next
            locy = 100
            locx += 30
        Next

        Me.ResumeLayout(False)
    End Sub

    Private Sub BeadHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim clicked_bead As Abacus_Bead = DirectCast(sender, Abacus_Bead)


    End Sub
End Class

Public Class Abacus_Bead
    Inherits Microsoft.VisualBasic.PowerPacks.OvalShape

    Private _state As Integer
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