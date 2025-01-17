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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScoreEditor))
        Stage1Button = New Button()
        Panel1 = New Panel()
        LevelWinCheckBox = New CheckBox()
        LevelAnimCheckBox = New CheckBox()
        Label3 = New Label()
        MaxComboBox = New NumericUpDown()
        ScoreBox5 = New NumericUpDown()
        ScoreBox4 = New NumericUpDown()
        ScoreBox3 = New NumericUpDown()
        ScoreBox2 = New NumericUpDown()
        ScoreBox1 = New NumericUpDown()
        LevelLockCheckBox = New CheckBox()
        FacePicture5 = New PictureBox()
        FacePicture4 = New PictureBox()
        FacePicture3 = New PictureBox()
        FacePicture2 = New PictureBox()
        FacePicture1 = New PictureBox()
        Panel2 = New Panel()
        Button1 = New Button()
        SAFStage2Button = New Button()
        SAFBonusStageButton = New Button()
        SAFStage1Button = New Button()
        Label2 = New Label()
        ExtraStageButton = New Button()
        BonusStageButton = New Button()
        Stage4Button = New Button()
        Stage3Button = New Button()
        Stage2Button = New Button()
        Label1 = New Label()
        ToolTip1 = New ToolTip(components)
        Panel1.SuspendLayout()
        CType(MaxComboBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(ScoreBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(ScoreBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(ScoreBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(ScoreBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ScoreBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(FacePicture5, ComponentModel.ISupportInitialize).BeginInit()
        CType(FacePicture4, ComponentModel.ISupportInitialize).BeginInit()
        CType(FacePicture3, ComponentModel.ISupportInitialize).BeginInit()
        CType(FacePicture2, ComponentModel.ISupportInitialize).BeginInit()
        CType(FacePicture1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Stage1Button
        ' 
        Stage1Button.BackgroundImage = My.Resources.Resources.Stage1
        Stage1Button.FlatAppearance.BorderSize = 0
        Stage1Button.FlatStyle = FlatStyle.Flat
        Stage1Button.Location = New Point(3, 51)
        Stage1Button.Name = "Stage1Button"
        Stage1Button.Size = New Size(96, 80)
        Stage1Button.TabIndex = 2
        Stage1Button.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LevelWinCheckBox)
        Panel1.Controls.Add(LevelAnimCheckBox)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(MaxComboBox)
        Panel1.Controls.Add(ScoreBox5)
        Panel1.Controls.Add(ScoreBox4)
        Panel1.Controls.Add(ScoreBox3)
        Panel1.Controls.Add(ScoreBox2)
        Panel1.Controls.Add(ScoreBox1)
        Panel1.Controls.Add(LevelLockCheckBox)
        Panel1.Controls.Add(FacePicture5)
        Panel1.Controls.Add(FacePicture4)
        Panel1.Controls.Add(FacePicture3)
        Panel1.Controls.Add(FacePicture2)
        Panel1.Controls.Add(FacePicture1)
        Panel1.Location = New Point(324, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(188, 432)
        Panel1.TabIndex = 3
        ' 
        ' LevelWinCheckBox
        ' 
        LevelWinCheckBox.CheckAlign = ContentAlignment.MiddleRight
        LevelWinCheckBox.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Regular, GraphicsUnit.Point)
        LevelWinCheckBox.Location = New Point(3, 318)
        LevelWinCheckBox.Name = "LevelWinCheckBox"
        LevelWinCheckBox.Size = New Size(182, 32)
        LevelWinCheckBox.TabIndex = 23
        LevelWinCheckBox.Text = "Level beaten?"
        LevelWinCheckBox.UseVisualStyleBackColor = True
        ' 
        ' LevelAnimCheckBox
        ' 
        LevelAnimCheckBox.CheckAlign = ContentAlignment.MiddleRight
        LevelAnimCheckBox.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Regular, GraphicsUnit.Point)
        LevelAnimCheckBox.Location = New Point(3, 394)
        LevelAnimCheckBox.Name = "LevelAnimCheckBox"
        LevelAnimCheckBox.Size = New Size(182, 32)
        LevelAnimCheckBox.TabIndex = 22
        LevelAnimCheckBox.Text = "Unlock anim"
        LevelAnimCheckBox.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(3, 279)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 28)
        Label3.TabIndex = 13
        Label3.Text = "Max combo:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' MaxComboBox
        ' 
        MaxComboBox.Font = New Font("Segoe UI Variable Display Semib", 20F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaxComboBox.Location = New Point(137, 278)
        MaxComboBox.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        MaxComboBox.Name = "MaxComboBox"
        MaxComboBox.Size = New Size(48, 34)
        MaxComboBox.TabIndex = 21
        MaxComboBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' ScoreBox5
        ' 
        ScoreBox5.Font = New Font("Segoe UI Variable Display Semib", 30.5F, FontStyle.Regular, GraphicsUnit.Pixel)
        ScoreBox5.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        ScoreBox5.Location = New Point(57, 219)
        ScoreBox5.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        ScoreBox5.Name = "ScoreBox5"
        ScoreBox5.Size = New Size(128, 48)
        ScoreBox5.TabIndex = 20
        ScoreBox5.TextAlign = HorizontalAlignment.Right
        ' 
        ' ScoreBox4
        ' 
        ScoreBox4.Font = New Font("Segoe UI Variable Display Semib", 30.5F, FontStyle.Regular, GraphicsUnit.Pixel)
        ScoreBox4.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        ScoreBox4.Location = New Point(57, 165)
        ScoreBox4.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        ScoreBox4.Name = "ScoreBox4"
        ScoreBox4.Size = New Size(128, 48)
        ScoreBox4.TabIndex = 19
        ScoreBox4.TextAlign = HorizontalAlignment.Right
        ' 
        ' ScoreBox3
        ' 
        ScoreBox3.Font = New Font("Segoe UI Variable Display Semib", 30.5F, FontStyle.Regular, GraphicsUnit.Pixel)
        ScoreBox3.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        ScoreBox3.Location = New Point(57, 111)
        ScoreBox3.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        ScoreBox3.Name = "ScoreBox3"
        ScoreBox3.Size = New Size(128, 48)
        ScoreBox3.TabIndex = 18
        ScoreBox3.TextAlign = HorizontalAlignment.Right
        ' 
        ' ScoreBox2
        ' 
        ScoreBox2.Font = New Font("Segoe UI Variable Display Semib", 30.5F, FontStyle.Regular, GraphicsUnit.Pixel)
        ScoreBox2.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        ScoreBox2.Location = New Point(57, 57)
        ScoreBox2.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        ScoreBox2.Name = "ScoreBox2"
        ScoreBox2.Size = New Size(128, 48)
        ScoreBox2.TabIndex = 17
        ScoreBox2.TextAlign = HorizontalAlignment.Right
        ' 
        ' ScoreBox1
        ' 
        ScoreBox1.Font = New Font("Segoe UI Variable Display Semib", 30.5F, FontStyle.Regular, GraphicsUnit.Pixel)
        ScoreBox1.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        ScoreBox1.Location = New Point(57, 3)
        ScoreBox1.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        ScoreBox1.Name = "ScoreBox1"
        ScoreBox1.Size = New Size(128, 48)
        ScoreBox1.TabIndex = 16
        ScoreBox1.TextAlign = HorizontalAlignment.Right
        ' 
        ' LevelLockCheckBox
        ' 
        LevelLockCheckBox.CheckAlign = ContentAlignment.MiddleRight
        LevelLockCheckBox.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Regular, GraphicsUnit.Point)
        LevelLockCheckBox.Location = New Point(3, 356)
        LevelLockCheckBox.Name = "LevelLockCheckBox"
        LevelLockCheckBox.Size = New Size(182, 32)
        LevelLockCheckBox.TabIndex = 15
        LevelLockCheckBox.Text = "Level unlocked?"
        LevelLockCheckBox.UseVisualStyleBackColor = True
        ' 
        ' FacePicture5
        ' 
        FacePicture5.BackgroundImage = My.Resources.Resources.DummyFace
        FacePicture5.BackgroundImageLayout = ImageLayout.Stretch
        FacePicture5.Image = My.Resources.Resources.FaceHole
        FacePicture5.Location = New Point(3, 219)
        FacePicture5.Name = "FacePicture5"
        FacePicture5.Size = New Size(48, 48)
        FacePicture5.SizeMode = PictureBoxSizeMode.StretchImage
        FacePicture5.TabIndex = 14
        FacePicture5.TabStop = False
        ' 
        ' FacePicture4
        ' 
        FacePicture4.BackgroundImage = My.Resources.Resources.DummyFace
        FacePicture4.BackgroundImageLayout = ImageLayout.Stretch
        FacePicture4.Image = My.Resources.Resources.FaceHole
        FacePicture4.Location = New Point(3, 165)
        FacePicture4.Name = "FacePicture4"
        FacePicture4.Size = New Size(48, 48)
        FacePicture4.SizeMode = PictureBoxSizeMode.StretchImage
        FacePicture4.TabIndex = 13
        FacePicture4.TabStop = False
        ' 
        ' FacePicture3
        ' 
        FacePicture3.BackgroundImage = My.Resources.Resources.DummyFace
        FacePicture3.BackgroundImageLayout = ImageLayout.Stretch
        FacePicture3.Image = My.Resources.Resources.FaceHole
        FacePicture3.Location = New Point(3, 111)
        FacePicture3.Name = "FacePicture3"
        FacePicture3.Size = New Size(48, 48)
        FacePicture3.SizeMode = PictureBoxSizeMode.StretchImage
        FacePicture3.TabIndex = 12
        FacePicture3.TabStop = False
        ' 
        ' FacePicture2
        ' 
        FacePicture2.BackgroundImage = My.Resources.Resources.DummyFace
        FacePicture2.BackgroundImageLayout = ImageLayout.Stretch
        FacePicture2.Image = My.Resources.Resources.FaceHole
        FacePicture2.Location = New Point(3, 57)
        FacePicture2.Name = "FacePicture2"
        FacePicture2.Size = New Size(48, 48)
        FacePicture2.SizeMode = PictureBoxSizeMode.StretchImage
        FacePicture2.TabIndex = 11
        FacePicture2.TabStop = False
        ' 
        ' FacePicture1
        ' 
        FacePicture1.BackgroundImage = My.Resources.Resources.DummyFace
        FacePicture1.BackgroundImageLayout = ImageLayout.Stretch
        FacePicture1.Image = My.Resources.Resources.FaceHole
        FacePicture1.Location = New Point(3, 3)
        FacePicture1.Name = "FacePicture1"
        FacePicture1.Size = New Size(48, 48)
        FacePicture1.SizeMode = PictureBoxSizeMode.StretchImage
        FacePicture1.TabIndex = 5
        FacePicture1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(SAFStage2Button)
        Panel2.Controls.Add(SAFBonusStageButton)
        Panel2.Controls.Add(SAFStage1Button)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(ExtraStageButton)
        Panel2.Controls.Add(BonusStageButton)
        Panel2.Controls.Add(Stage4Button)
        Panel2.Controls.Add(Stage3Button)
        Panel2.Controls.Add(Stage2Button)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Stage1Button)
        Panel2.Location = New Point(12, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(306, 432)
        Panel2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(105, 394)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 32)
        Button1.TabIndex = 13
        Button1.Text = "Tutorial Stage"
        ToolTip1.SetToolTip(Button1, "This is a secret level which is a copy of SAF Stage 1." & vbCrLf & "You only get to play it once, that is when it is your first time ever playing the game." & vbCrLf & "You can view your score when you had beaten this stage.")
        Button1.UseVisualStyleBackColor = True
        ' 
        ' SAFStage2Button
        ' 
        SAFStage2Button.BackgroundImage = My.Resources.Resources.OtherStage
        SAFStage2Button.FlatAppearance.BorderSize = 0
        SAFStage2Button.FlatStyle = FlatStyle.Flat
        SAFStage2Button.Location = New Point(207, 271)
        SAFStage2Button.Name = "SAFStage2Button"
        SAFStage2Button.Size = New Size(96, 80)
        SAFStage2Button.TabIndex = 12
        SAFStage2Button.UseVisualStyleBackColor = True
        ' 
        ' SAFBonusStageButton
        ' 
        SAFBonusStageButton.BackgroundImage = My.Resources.Resources.BonusStage
        SAFBonusStageButton.FlatAppearance.BorderSize = 0
        SAFBonusStageButton.FlatStyle = FlatStyle.Flat
        SAFBonusStageButton.Location = New Point(105, 271)
        SAFBonusStageButton.Name = "SAFBonusStageButton"
        SAFBonusStageButton.Size = New Size(96, 80)
        SAFBonusStageButton.TabIndex = 11
        SAFBonusStageButton.UseVisualStyleBackColor = True
        ' 
        ' SAFStage1Button
        ' 
        SAFStage1Button.BackgroundImage = My.Resources.Resources.Stage1
        SAFStage1Button.FlatAppearance.BorderSize = 0
        SAFStage1Button.FlatStyle = FlatStyle.Flat
        SAFStage1Button.Location = New Point(3, 271)
        SAFStage1Button.Name = "SAFStage1Button"
        SAFStage1Button.Size = New Size(96, 80)
        SAFStage1Button.TabIndex = 10
        SAFStage1Button.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(3, 220)
        Label2.Name = "Label2"
        Label2.Size = New Size(300, 48)
        Label2.TabIndex = 9
        Label2.Text = """Show a Friend"" stages"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ExtraStageButton
        ' 
        ExtraStageButton.BackgroundImage = My.Resources.Resources.ExtraStage
        ExtraStageButton.FlatAppearance.BorderSize = 0
        ExtraStageButton.FlatStyle = FlatStyle.Flat
        ExtraStageButton.Location = New Point(207, 137)
        ExtraStageButton.Name = "ExtraStageButton"
        ExtraStageButton.Size = New Size(96, 80)
        ExtraStageButton.TabIndex = 8
        ExtraStageButton.UseVisualStyleBackColor = True
        ' 
        ' BonusStageButton
        ' 
        BonusStageButton.BackgroundImage = My.Resources.Resources.BonusStage
        BonusStageButton.FlatAppearance.BorderSize = 0
        BonusStageButton.FlatStyle = FlatStyle.Flat
        BonusStageButton.Location = New Point(105, 137)
        BonusStageButton.Name = "BonusStageButton"
        BonusStageButton.Size = New Size(96, 80)
        BonusStageButton.TabIndex = 7
        BonusStageButton.UseVisualStyleBackColor = True
        ' 
        ' Stage4Button
        ' 
        Stage4Button.BackgroundImage = My.Resources.Resources.Stage4
        Stage4Button.FlatAppearance.BorderSize = 0
        Stage4Button.FlatStyle = FlatStyle.Flat
        Stage4Button.Location = New Point(3, 137)
        Stage4Button.Name = "Stage4Button"
        Stage4Button.Size = New Size(96, 80)
        Stage4Button.TabIndex = 6
        Stage4Button.UseVisualStyleBackColor = True
        ' 
        ' Stage3Button
        ' 
        Stage3Button.BackgroundImage = My.Resources.Resources.Stage3
        Stage3Button.FlatAppearance.BorderSize = 0
        Stage3Button.FlatStyle = FlatStyle.Flat
        Stage3Button.Location = New Point(207, 51)
        Stage3Button.Name = "Stage3Button"
        Stage3Button.Size = New Size(96, 80)
        Stage3Button.TabIndex = 5
        Stage3Button.UseVisualStyleBackColor = True
        ' 
        ' Stage2Button
        ' 
        Stage2Button.BackgroundImage = My.Resources.Resources.Stage2
        Stage2Button.FlatAppearance.BorderSize = 0
        Stage2Button.FlatStyle = FlatStyle.Flat
        Stage2Button.Location = New Point(105, 51)
        Stage2Button.Name = "Stage2Button"
        Stage2Button.Size = New Size(96, 80)
        Stage2Button.TabIndex = 4
        Stage2Button.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(300, 48)
        Label1.TabIndex = 3
        Label1.Text = "Main stages"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ScoreEditor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(524, 456)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "ScoreEditor"
        Text = "Score editor"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(MaxComboBox, ComponentModel.ISupportInitialize).EndInit()
        CType(ScoreBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(ScoreBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(ScoreBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(ScoreBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(ScoreBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(FacePicture5, ComponentModel.ISupportInitialize).EndInit()
        CType(FacePicture4, ComponentModel.ISupportInitialize).EndInit()
        CType(FacePicture3, ComponentModel.ISupportInitialize).EndInit()
        CType(FacePicture2, ComponentModel.ISupportInitialize).EndInit()
        CType(FacePicture1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)

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
    Friend WithEvents Label3 As Label
    Friend WithEvents MaxComboBox As NumericUpDown
    Friend WithEvents LevelWinCheckBox As CheckBox
    Friend WithEvents LevelAnimCheckBox As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
