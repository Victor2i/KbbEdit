<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScoreEditor
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScoreEditor))
        Me.Stage1Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ScoreBox1 = New System.Windows.Forms.NumericUpDown()
        Me.LevelLockCheckBox = New System.Windows.Forms.CheckBox()
        Me.FacePicture5 = New System.Windows.Forms.PictureBox()
        Me.FacePicture4 = New System.Windows.Forms.PictureBox()
        Me.FacePicture3 = New System.Windows.Forms.PictureBox()
        Me.FacePicture2 = New System.Windows.Forms.PictureBox()
        Me.FacePicture1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SAFStage2Button = New System.Windows.Forms.Button()
        Me.SAFBonusStageButton = New System.Windows.Forms.Button()
        Me.SAFStage1Button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExtraStageButton = New System.Windows.Forms.Button()
        Me.BonusStageButton = New System.Windows.Forms.Button()
        Me.Stage4Button = New System.Windows.Forms.Button()
        Me.Stage3Button = New System.Windows.Forms.Button()
        Me.Stage2Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ScoreBox2 = New System.Windows.Forms.NumericUpDown()
        Me.ScoreBox3 = New System.Windows.Forms.NumericUpDown()
        Me.ScoreBox4 = New System.Windows.Forms.NumericUpDown()
        Me.ScoreBox5 = New System.Windows.Forms.NumericUpDown()
        Me.Panel1.SuspendLayout()
        CType(Me.ScoreBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacePicture5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacePicture4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacePicture3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacePicture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacePicture1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ScoreBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScoreBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScoreBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScoreBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Stage1Button
        '
        Me.Stage1Button.BackgroundImage = Global.KbbEdit.My.Resources.Resources.Stage1
        Me.Stage1Button.FlatAppearance.BorderSize = 0
        Me.Stage1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stage1Button.Location = New System.Drawing.Point(3, 51)
        Me.Stage1Button.Name = "Stage1Button"
        Me.Stage1Button.Size = New System.Drawing.Size(96, 80)
        Me.Stage1Button.TabIndex = 2
        Me.Stage1Button.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ScoreBox5)
        Me.Panel1.Controls.Add(Me.ScoreBox4)
        Me.Panel1.Controls.Add(Me.ScoreBox3)
        Me.Panel1.Controls.Add(Me.ScoreBox2)
        Me.Panel1.Controls.Add(Me.ScoreBox1)
        Me.Panel1.Controls.Add(Me.LevelLockCheckBox)
        Me.Panel1.Controls.Add(Me.FacePicture5)
        Me.Panel1.Controls.Add(Me.FacePicture4)
        Me.Panel1.Controls.Add(Me.FacePicture3)
        Me.Panel1.Controls.Add(Me.FacePicture2)
        Me.Panel1.Controls.Add(Me.FacePicture1)
        Me.Panel1.Location = New System.Drawing.Point(324, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(188, 354)
        Me.Panel1.TabIndex = 3
        '
        'ScoreBox1
        '
        Me.ScoreBox1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 30.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ScoreBox1.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.ScoreBox1.Location = New System.Drawing.Point(57, 3)
        Me.ScoreBox1.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.ScoreBox1.Name = "ScoreBox1"
        Me.ScoreBox1.Size = New System.Drawing.Size(128, 48)
        Me.ScoreBox1.TabIndex = 16
        Me.ScoreBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LevelLockCheckBox
        '
        Me.LevelLockCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LevelLockCheckBox.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.LevelLockCheckBox.Location = New System.Drawing.Point(3, 319)
        Me.LevelLockCheckBox.Name = "LevelLockCheckBox"
        Me.LevelLockCheckBox.Size = New System.Drawing.Size(182, 32)
        Me.LevelLockCheckBox.TabIndex = 15
        Me.LevelLockCheckBox.Text = "Level unlocked?"
        Me.LevelLockCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LevelLockCheckBox.UseVisualStyleBackColor = True
        '
        'FacePicture5
        '
        Me.FacePicture5.BackgroundImage = Global.KbbEdit.My.Resources.Resources.DummyFace
        Me.FacePicture5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FacePicture5.Image = Global.KbbEdit.My.Resources.Resources.FaceHole
        Me.FacePicture5.Location = New System.Drawing.Point(3, 219)
        Me.FacePicture5.Name = "FacePicture5"
        Me.FacePicture5.Size = New System.Drawing.Size(48, 48)
        Me.FacePicture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FacePicture5.TabIndex = 14
        Me.FacePicture5.TabStop = False
        '
        'FacePicture4
        '
        Me.FacePicture4.BackgroundImage = Global.KbbEdit.My.Resources.Resources.DummyFace
        Me.FacePicture4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FacePicture4.Image = Global.KbbEdit.My.Resources.Resources.FaceHole
        Me.FacePicture4.Location = New System.Drawing.Point(3, 165)
        Me.FacePicture4.Name = "FacePicture4"
        Me.FacePicture4.Size = New System.Drawing.Size(48, 48)
        Me.FacePicture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FacePicture4.TabIndex = 13
        Me.FacePicture4.TabStop = False
        '
        'FacePicture3
        '
        Me.FacePicture3.BackgroundImage = Global.KbbEdit.My.Resources.Resources.DummyFace
        Me.FacePicture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FacePicture3.Image = Global.KbbEdit.My.Resources.Resources.FaceHole
        Me.FacePicture3.Location = New System.Drawing.Point(3, 111)
        Me.FacePicture3.Name = "FacePicture3"
        Me.FacePicture3.Size = New System.Drawing.Size(48, 48)
        Me.FacePicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FacePicture3.TabIndex = 12
        Me.FacePicture3.TabStop = False
        '
        'FacePicture2
        '
        Me.FacePicture2.BackgroundImage = Global.KbbEdit.My.Resources.Resources.DummyFace
        Me.FacePicture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FacePicture2.Image = Global.KbbEdit.My.Resources.Resources.FaceHole
        Me.FacePicture2.Location = New System.Drawing.Point(3, 57)
        Me.FacePicture2.Name = "FacePicture2"
        Me.FacePicture2.Size = New System.Drawing.Size(48, 48)
        Me.FacePicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FacePicture2.TabIndex = 11
        Me.FacePicture2.TabStop = False
        '
        'FacePicture1
        '
        Me.FacePicture1.BackgroundImage = Global.KbbEdit.My.Resources.Resources.DummyFace
        Me.FacePicture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FacePicture1.Image = Global.KbbEdit.My.Resources.Resources.FaceHole
        Me.FacePicture1.Location = New System.Drawing.Point(3, 3)
        Me.FacePicture1.Name = "FacePicture1"
        Me.FacePicture1.Size = New System.Drawing.Size(48, 48)
        Me.FacePicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FacePicture1.TabIndex = 5
        Me.FacePicture1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SAFStage2Button)
        Me.Panel2.Controls.Add(Me.SAFBonusStageButton)
        Me.Panel2.Controls.Add(Me.SAFStage1Button)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ExtraStageButton)
        Me.Panel2.Controls.Add(Me.BonusStageButton)
        Me.Panel2.Controls.Add(Me.Stage4Button)
        Me.Panel2.Controls.Add(Me.Stage3Button)
        Me.Panel2.Controls.Add(Me.Stage2Button)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Stage1Button)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(306, 354)
        Me.Panel2.TabIndex = 4
        '
        'SAFStage2Button
        '
        Me.SAFStage2Button.BackgroundImage = Global.KbbEdit.My.Resources.Resources.OtherStage
        Me.SAFStage2Button.FlatAppearance.BorderSize = 0
        Me.SAFStage2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SAFStage2Button.Location = New System.Drawing.Point(207, 271)
        Me.SAFStage2Button.Name = "SAFStage2Button"
        Me.SAFStage2Button.Size = New System.Drawing.Size(96, 80)
        Me.SAFStage2Button.TabIndex = 12
        Me.SAFStage2Button.UseVisualStyleBackColor = True
        '
        'SAFBonusStageButton
        '
        Me.SAFBonusStageButton.BackgroundImage = Global.KbbEdit.My.Resources.Resources.BonusStage
        Me.SAFBonusStageButton.FlatAppearance.BorderSize = 0
        Me.SAFBonusStageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SAFBonusStageButton.Location = New System.Drawing.Point(105, 271)
        Me.SAFBonusStageButton.Name = "SAFBonusStageButton"
        Me.SAFBonusStageButton.Size = New System.Drawing.Size(96, 80)
        Me.SAFBonusStageButton.TabIndex = 11
        Me.SAFBonusStageButton.UseVisualStyleBackColor = True
        '
        'SAFStage1Button
        '
        Me.SAFStage1Button.BackgroundImage = Global.KbbEdit.My.Resources.Resources.Stage1
        Me.SAFStage1Button.FlatAppearance.BorderSize = 0
        Me.SAFStage1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SAFStage1Button.Location = New System.Drawing.Point(3, 271)
        Me.SAFStage1Button.Name = "SAFStage1Button"
        Me.SAFStage1Button.Size = New System.Drawing.Size(96, 80)
        Me.SAFStage1Button.TabIndex = 10
        Me.SAFStage1Button.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(3, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 48)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Show a friend"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExtraStageButton
        '
        Me.ExtraStageButton.BackgroundImage = Global.KbbEdit.My.Resources.Resources.ExtraStage
        Me.ExtraStageButton.FlatAppearance.BorderSize = 0
        Me.ExtraStageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExtraStageButton.Location = New System.Drawing.Point(207, 137)
        Me.ExtraStageButton.Name = "ExtraStageButton"
        Me.ExtraStageButton.Size = New System.Drawing.Size(96, 80)
        Me.ExtraStageButton.TabIndex = 8
        Me.ExtraStageButton.UseVisualStyleBackColor = True
        '
        'BonusStageButton
        '
        Me.BonusStageButton.BackgroundImage = Global.KbbEdit.My.Resources.Resources.BonusStage
        Me.BonusStageButton.FlatAppearance.BorderSize = 0
        Me.BonusStageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BonusStageButton.Location = New System.Drawing.Point(105, 137)
        Me.BonusStageButton.Name = "BonusStageButton"
        Me.BonusStageButton.Size = New System.Drawing.Size(96, 80)
        Me.BonusStageButton.TabIndex = 7
        Me.BonusStageButton.UseVisualStyleBackColor = True
        '
        'Stage4Button
        '
        Me.Stage4Button.BackgroundImage = Global.KbbEdit.My.Resources.Resources.Stage4
        Me.Stage4Button.FlatAppearance.BorderSize = 0
        Me.Stage4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stage4Button.Location = New System.Drawing.Point(3, 137)
        Me.Stage4Button.Name = "Stage4Button"
        Me.Stage4Button.Size = New System.Drawing.Size(96, 80)
        Me.Stage4Button.TabIndex = 6
        Me.Stage4Button.UseVisualStyleBackColor = True
        '
        'Stage3Button
        '
        Me.Stage3Button.BackgroundImage = Global.KbbEdit.My.Resources.Resources.Stage3
        Me.Stage3Button.FlatAppearance.BorderSize = 0
        Me.Stage3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stage3Button.Location = New System.Drawing.Point(207, 51)
        Me.Stage3Button.Name = "Stage3Button"
        Me.Stage3Button.Size = New System.Drawing.Size(96, 80)
        Me.Stage3Button.TabIndex = 5
        Me.Stage3Button.UseVisualStyleBackColor = True
        '
        'Stage2Button
        '
        Me.Stage2Button.BackgroundImage = Global.KbbEdit.My.Resources.Resources.Stage2
        Me.Stage2Button.FlatAppearance.BorderSize = 0
        Me.Stage2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stage2Button.Location = New System.Drawing.Point(105, 51)
        Me.Stage2Button.Name = "Stage2Button"
        Me.Stage2Button.Size = New System.Drawing.Size(96, 80)
        Me.Stage2Button.TabIndex = 4
        Me.Stage2Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 48)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Play"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ScoreBox2
        '
        Me.ScoreBox2.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 30.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ScoreBox2.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.ScoreBox2.Location = New System.Drawing.Point(57, 57)
        Me.ScoreBox2.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.ScoreBox2.Name = "ScoreBox2"
        Me.ScoreBox2.Size = New System.Drawing.Size(128, 48)
        Me.ScoreBox2.TabIndex = 17
        Me.ScoreBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ScoreBox3
        '
        Me.ScoreBox3.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 30.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ScoreBox3.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.ScoreBox3.Location = New System.Drawing.Point(57, 111)
        Me.ScoreBox3.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.ScoreBox3.Name = "ScoreBox3"
        Me.ScoreBox3.Size = New System.Drawing.Size(128, 48)
        Me.ScoreBox3.TabIndex = 18
        Me.ScoreBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ScoreBox4
        '
        Me.ScoreBox4.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 30.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ScoreBox4.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.ScoreBox4.Location = New System.Drawing.Point(57, 165)
        Me.ScoreBox4.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.ScoreBox4.Name = "ScoreBox4"
        Me.ScoreBox4.Size = New System.Drawing.Size(128, 48)
        Me.ScoreBox4.TabIndex = 19
        Me.ScoreBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ScoreBox5
        '
        Me.ScoreBox5.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 30.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ScoreBox5.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.ScoreBox5.Location = New System.Drawing.Point(57, 219)
        Me.ScoreBox5.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.ScoreBox5.Name = "ScoreBox5"
        Me.ScoreBox5.Size = New System.Drawing.Size(128, 48)
        Me.ScoreBox5.TabIndex = 20
        Me.ScoreBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ScoreEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 378)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ScoreEditor"
        Me.Text = "Score editor"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ScoreBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacePicture5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacePicture4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacePicture3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacePicture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacePicture1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ScoreBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScoreBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScoreBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScoreBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Stage1Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SAFStage2Button As Button
    Friend WithEvents SAFBonusStageButton As Button
    Friend WithEvents SAFStage1Button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ExtraStageButton As Button
    Friend WithEvents BonusStageButton As Button
    Friend WithEvents Stage4Button As Button
    Friend WithEvents Stage3Button As Button
    Friend WithEvents Stage2Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FacePicture1 As PictureBox
    Friend WithEvents LevelLockCheckBox As CheckBox
    Friend WithEvents FacePicture5 As PictureBox
    Friend WithEvents FacePicture4 As PictureBox
    Friend WithEvents FacePicture3 As PictureBox
    Friend WithEvents FacePicture2 As PictureBox
    Friend WithEvents ScoreBox1 As NumericUpDown
    Friend WithEvents ScoreBox5 As NumericUpDown
    Friend WithEvents ScoreBox4 As NumericUpDown
    Friend WithEvents ScoreBox3 As NumericUpDown
    Friend WithEvents ScoreBox2 As NumericUpDown
End Class
