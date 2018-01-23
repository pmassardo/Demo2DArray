<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemo2DArrays
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
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lbOutput = New System.Windows.Forms.Label()
        Me.tbInput = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbInput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(68, 89)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(51, 23)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lbOutput
        '
        Me.lbOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbOutput.Location = New System.Drawing.Point(11, 31)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(165, 55)
        Me.lbOutput.TabIndex = 2
        '
        'tbInput
        '
        Me.tbInput.Location = New System.Drawing.Point(111, 8)
        Me.tbInput.Name = "tbInput"
        Me.tbInput.Size = New System.Drawing.Size(65, 20)
        Me.tbInput.TabIndex = 1
        Me.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(11, 89)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(51, 23)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(125, 89)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(51, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbInput
        '
        Me.lbInput.Location = New System.Drawing.Point(8, 8)
        Me.lbInput.Name = "lbInput"
        Me.lbInput.Size = New System.Drawing.Size(45, 13)
        Me.lbInput.TabIndex = 0
        Me.lbInput.Text = "Enter #:"
        '
        'frmDemo2DArrays
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(186, 117)
        Me.Controls.Add(Me.lbInput)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lbOutput)
        Me.Controls.Add(Me.tbInput)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmDemo2DArrays"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2D Arrays"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReset As Button
    Friend WithEvents lbOutput As Label
    Friend WithEvents tbInput As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbInput As Label
End Class
