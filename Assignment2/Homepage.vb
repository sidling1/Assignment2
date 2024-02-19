Public Class Homepage

    
    Private Sub Abacus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Abacus.Click
        Dim abacus As New Abacus()
        abacus.Show()
        Me.Hide()

        AddHandler abacus.FormClosed, Sub(senderObj As System.Object, eArgs As EventArgs)
                                          Me.Show()
                                      End Sub
    End Sub

    Private Sub Basicmath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Basicmath.Click
        Dim basicmath As New BasicMath()
        basicmath.Show()
        Me.Hide()

        AddHandler basicmath.FormClosed, Sub(senderObj As System.Object, eArgs As EventArgs)
                                             Me.Show()
                                         End Sub
    End Sub

    Private Sub Videos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Videos.Click
        Dim video As New Video()
        video.Show()
        Me.Hide()

        AddHandler video.FormClosed, Sub(senderObj As System.Object, eArgs As EventArgs)
                                             Me.Show()
                                         End Sub
    End Sub

    Private Sub Puzzlequiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Puzzlequiz.Click
        Dim pzqz As New PzlQzHome()
        pzqz.Show()
        Me.Hide()

        AddHandler pzqz.FormClosed, Sub(senderObj As System.Object, eArgs As EventArgs)
                                        Me.Show()
                                    End Sub
    End Sub

End Class