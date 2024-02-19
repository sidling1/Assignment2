<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepage
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
        Me.Abacus = New System.Windows.Forms.Button()
        Me.Basicmath = New System.Windows.Forms.Button()
        Me.Videos = New System.Windows.Forms.Button()
        Me.Puzzlequiz = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Abacus
        '
        Me.Abacus.Location = New System.Drawing.Point(85, 105)
        Me.Abacus.Name = "Abacus"
        Me.Abacus.Size = New System.Drawing.Size(139, 53)
        Me.Abacus.TabIndex = 0
        Me.Abacus.Text = "Abacus"
        Me.Abacus.UseVisualStyleBackColor = True
        '
        'Basicmath
        '
        Me.Basicmath.Location = New System.Drawing.Point(347, 105)
        Me.Basicmath.Name = "Basicmath"
        Me.Basicmath.Size = New System.Drawing.Size(139, 53)
        Me.Basicmath.TabIndex = 1
        Me.Basicmath.Text = "Basic Math"
        Me.Basicmath.UseVisualStyleBackColor = True
        '
        'Videos
        '
        Me.Videos.Location = New System.Drawing.Point(85, 237)
        Me.Videos.Name = "Videos"
        Me.Videos.Size = New System.Drawing.Size(139, 53)
        Me.Videos.TabIndex = 2
        Me.Videos.Text = "Videos"
        Me.Videos.UseVisualStyleBackColor = True
        '
        'Puzzlequiz
        '
        Me.Puzzlequiz.Location = New System.Drawing.Point(347, 237)
        Me.Puzzlequiz.Name = "Puzzlequiz"
        Me.Puzzlequiz.Size = New System.Drawing.Size(139, 53)
        Me.Puzzlequiz.TabIndex = 3
        Me.Puzzlequiz.Text = "Puzzles and Quizes"
        Me.Puzzlequiz.UseVisualStyleBackColor = True
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 478)
        Me.Controls.Add(Me.Puzzlequiz)
        Me.Controls.Add(Me.Videos)
        Me.Controls.Add(Me.Basicmath)
        Me.Controls.Add(Me.Abacus)
        Me.Name = "Homepage"
        Me.Text = "Homepage"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Abacus As System.Windows.Forms.Button
    Friend WithEvents Basicmath As System.Windows.Forms.Button
    Friend WithEvents Videos As System.Windows.Forms.Button
    Friend WithEvents Puzzlequiz As System.Windows.Forms.Button
End Class
