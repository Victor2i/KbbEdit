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
        PictureBox1 = New PictureBox()
        PrevButton = New Button()
        NextButton = New Button()
        HelpLabel = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Ins0
        PictureBox1.Location = New Point(12, 143)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(320, 240)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PrevButton
        ' 
        PrevButton.Enabled = False
        PrevButton.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        PrevButton.Location = New Point(12, 389)
        PrevButton.Name = "PrevButton"
        PrevButton.Size = New Size(157, 49)
        PrevButton.TabIndex = 1
        PrevButton.Text = "Previous"
        PrevButton.UseVisualStyleBackColor = True
        ' 
        ' NextButton
        ' 
        NextButton.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        NextButton.Location = New Point(175, 389)
        NextButton.Name = "NextButton"
        NextButton.Size = New Size(157, 49)
        NextButton.TabIndex = 2
        NextButton.Text = "Next"
        NextButton.UseVisualStyleBackColor = True
        ' 
        ' HelpLabel
        ' 
        HelpLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        HelpLabel.Location = New Point(12, 9)
        HelpLabel.Name = "HelpLabel"
        HelpLabel.Size = New Size(320, 131)
        HelpLabel.TabIndex = 3
        HelpLabel.Text = "Sample text"
        HelpLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' InstructionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(344, 450)
        Controls.Add(HelpLabel)
        Controls.Add(NextButton)
        Controls.Add(PrevButton)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "InstructionsForm"
        Text = "Help"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PrevButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents HelpLabel As Label
End Class
