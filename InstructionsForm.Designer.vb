<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructionsForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstructionsForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrevButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.HelpLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.KbbEdit.My.Resources.Resources.Ins0
        Me.PictureBox1.Location = New System.Drawing.Point(12, 143)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 240)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PrevButton
        '
        Me.PrevButton.Enabled = False
        Me.PrevButton.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PrevButton.Location = New System.Drawing.Point(12, 389)
        Me.PrevButton.Name = "PrevButton"
        Me.PrevButton.Size = New System.Drawing.Size(157, 49)
        Me.PrevButton.TabIndex = 1
        Me.PrevButton.Text = "Previous"
        Me.PrevButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NextButton.Location = New System.Drawing.Point(175, 389)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(157, 49)
        Me.NextButton.TabIndex = 2
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'HelpLabel
        '
        Me.HelpLabel.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HelpLabel.Location = New System.Drawing.Point(12, 9)
        Me.HelpLabel.Name = "HelpLabel"
        Me.HelpLabel.Size = New System.Drawing.Size(320, 131)
        Me.HelpLabel.TabIndex = 3
        Me.HelpLabel.Text = "Sample text"
        Me.HelpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InstructionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 450)
        Me.Controls.Add(Me.HelpLabel)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PrevButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "InstructionsForm"
        Me.Text = "Help"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PrevButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents HelpLabel As Label
End Class
