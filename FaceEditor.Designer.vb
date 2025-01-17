<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FaceEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FaceEditor))
        RightPageButton = New Button()
        FaceBox10 = New PictureBox()
        FaceBox9 = New PictureBox()
        FaceBox8 = New PictureBox()
        FaceBox7 = New PictureBox()
        FaceBox6 = New PictureBox()
        FaceBox5 = New PictureBox()
        FaceBox4 = New PictureBox()
        FaceBox3 = New PictureBox()
        FaceBox2 = New PictureBox()
        LeftPageButton = New Button()
        FaceBox1 = New PictureBox()
        SelectedFaceBox = New PictureBox()
        HorizontalScrollBox = New NumericUpDown()
        DayBox = New NumericUpDown()
        RotationBox = New NumericUpDown()
        MonthBox = New NumericUpDown()
        YearBox = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TimesChoosenBox = New NumericUpDown()
        AgeBox = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        GenderBox = New ComboBox()
        VerticalScrollBox = New NumericUpDown()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        VerticalStretchBox = New NumericUpDown()
        HorizontalStretchBox = New NumericUpDown()
        Label11 = New Label()
        SaveFileDialog1 = New SaveFileDialog()
        DeleteFaceButton = New Button()
        ExportFaceButton = New Button()
        ImportFaceButton = New Button()
        CheckBox1 = New CheckBox()
        NewFaceButton = New Button()
        SwapFacesButton = New Button()
        CType(FaceBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(FaceBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(FaceBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(FaceBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(FaceBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(FaceBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(FaceBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(FaceBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(FaceBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(FaceBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(SelectedFaceBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(HorizontalScrollBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(DayBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(RotationBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(MonthBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(YearBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(TimesChoosenBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(VerticalScrollBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(VerticalStretchBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(HorizontalStretchBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RightPageButton
        ' 
        RightPageButton.Location = New Point(752, 111)
        RightPageButton.Name = "RightPageButton"
        RightPageButton.Size = New Size(64, 64)
        RightPageButton.TabIndex = 24
        RightPageButton.Text = "Next"
        RightPageButton.UseVisualStyleBackColor = True
        ' 
        ' FaceBox10
        ' 
        FaceBox10.BorderStyle = BorderStyle.FixedSingle
        FaceBox10.Image = My.Resources.Resources.FaceHole
        FaceBox10.Location = New Point(618, 146)
        FaceBox10.Name = "FaceBox10"
        FaceBox10.Size = New Size(128, 128)
        FaceBox10.TabIndex = 23
        FaceBox10.TabStop = False
        ' 
        ' FaceBox9
        ' 
        FaceBox9.BorderStyle = BorderStyle.FixedSingle
        FaceBox9.Image = My.Resources.Resources.FaceHole
        FaceBox9.Location = New Point(484, 146)
        FaceBox9.Name = "FaceBox9"
        FaceBox9.Size = New Size(128, 128)
        FaceBox9.TabIndex = 22
        FaceBox9.TabStop = False
        ' 
        ' FaceBox8
        ' 
        FaceBox8.BorderStyle = BorderStyle.FixedSingle
        FaceBox8.Image = My.Resources.Resources.FaceHole
        FaceBox8.Location = New Point(350, 146)
        FaceBox8.Name = "FaceBox8"
        FaceBox8.Size = New Size(128, 128)
        FaceBox8.TabIndex = 21
        FaceBox8.TabStop = False
        ' 
        ' FaceBox7
        ' 
        FaceBox7.BorderStyle = BorderStyle.FixedSingle
        FaceBox7.Image = My.Resources.Resources.FaceHole
        FaceBox7.Location = New Point(216, 146)
        FaceBox7.Name = "FaceBox7"
        FaceBox7.Size = New Size(128, 128)
        FaceBox7.TabIndex = 20
        FaceBox7.TabStop = False
        ' 
        ' FaceBox6
        ' 
        FaceBox6.BorderStyle = BorderStyle.FixedSingle
        FaceBox6.Image = My.Resources.Resources.FaceHole
        FaceBox6.Location = New Point(82, 146)
        FaceBox6.Name = "FaceBox6"
        FaceBox6.Size = New Size(128, 128)
        FaceBox6.TabIndex = 19
        FaceBox6.TabStop = False
        ' 
        ' FaceBox5
        ' 
        FaceBox5.BorderStyle = BorderStyle.FixedSingle
        FaceBox5.Image = My.Resources.Resources.FaceHole
        FaceBox5.Location = New Point(618, 12)
        FaceBox5.Name = "FaceBox5"
        FaceBox5.Size = New Size(128, 128)
        FaceBox5.TabIndex = 18
        FaceBox5.TabStop = False
        ' 
        ' FaceBox4
        ' 
        FaceBox4.BorderStyle = BorderStyle.FixedSingle
        FaceBox4.Image = My.Resources.Resources.FaceHole
        FaceBox4.Location = New Point(484, 12)
        FaceBox4.Name = "FaceBox4"
        FaceBox4.Size = New Size(128, 128)
        FaceBox4.TabIndex = 17
        FaceBox4.TabStop = False
        ' 
        ' FaceBox3
        ' 
        FaceBox3.BorderStyle = BorderStyle.FixedSingle
        FaceBox3.Image = My.Resources.Resources.FaceHole
        FaceBox3.Location = New Point(350, 12)
        FaceBox3.Name = "FaceBox3"
        FaceBox3.Size = New Size(128, 128)
        FaceBox3.TabIndex = 16
        FaceBox3.TabStop = False
        ' 
        ' FaceBox2
        ' 
        FaceBox2.BorderStyle = BorderStyle.FixedSingle
        FaceBox2.Image = My.Resources.Resources.FaceHole
        FaceBox2.Location = New Point(216, 12)
        FaceBox2.Name = "FaceBox2"
        FaceBox2.Size = New Size(128, 128)
        FaceBox2.TabIndex = 15
        FaceBox2.TabStop = False
        ' 
        ' LeftPageButton
        ' 
        LeftPageButton.Location = New Point(12, 111)
        LeftPageButton.Name = "LeftPageButton"
        LeftPageButton.Size = New Size(64, 64)
        LeftPageButton.TabIndex = 14
        LeftPageButton.Text = "Previous"
        LeftPageButton.UseVisualStyleBackColor = True
        ' 
        ' FaceBox1
        ' 
        FaceBox1.BorderStyle = BorderStyle.FixedSingle
        FaceBox1.Image = My.Resources.Resources.FaceHole
        FaceBox1.Location = New Point(82, 12)
        FaceBox1.Name = "FaceBox1"
        FaceBox1.Size = New Size(128, 128)
        FaceBox1.TabIndex = 13
        FaceBox1.TabStop = False
        ' 
        ' SelectedFaceBox
        ' 
        SelectedFaceBox.BorderStyle = BorderStyle.FixedSingle
        SelectedFaceBox.Image = My.Resources.Resources.FaceHole
        SelectedFaceBox.Location = New Point(12, 299)
        SelectedFaceBox.Name = "SelectedFaceBox"
        SelectedFaceBox.Size = New Size(128, 128)
        SelectedFaceBox.TabIndex = 25
        SelectedFaceBox.TabStop = False
        ' 
        ' HorizontalScrollBox
        ' 
        HorizontalScrollBox.DecimalPlaces = 3
        HorizontalScrollBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        HorizontalScrollBox.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        HorizontalScrollBox.Location = New Point(343, 298)
        HorizontalScrollBox.Maximum = New Decimal(New Integer() {5, 0, 0, 65536})
        HorizontalScrollBox.Minimum = New Decimal(New Integer() {5, 0, 0, -2147418112})
        HorizontalScrollBox.Name = "HorizontalScrollBox"
        HorizontalScrollBox.Size = New Size(73, 29)
        HorizontalScrollBox.TabIndex = 26
        ' 
        ' DayBox
        ' 
        DayBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DayBox.Location = New Point(146, 298)
        DayBox.Maximum = New Decimal(New Integer() {28, 0, 0, 0})
        DayBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        DayBox.Name = "DayBox"
        DayBox.Size = New Size(54, 29)
        DayBox.TabIndex = 27
        DayBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' RotationBox
        ' 
        RotationBox.DecimalPlaces = 6
        RotationBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RotationBox.Increment = New Decimal(New Integer() {-914125255, -1057868262, 18922899, 1835008})
        RotationBox.Location = New Point(343, 398)
        RotationBox.Maximum = New Decimal(New Integer() {3141593, 0, 0, 393216})
        RotationBox.Minimum = New Decimal(New Integer() {3141593, 0, 0, -2147090432})
        RotationBox.Name = "RotationBox"
        RotationBox.Size = New Size(114, 29)
        RotationBox.TabIndex = 28
        ' 
        ' MonthBox
        ' 
        MonthBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MonthBox.Location = New Point(146, 348)
        MonthBox.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        MonthBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        MonthBox.Name = "MonthBox"
        MonthBox.Size = New Size(54, 29)
        MonthBox.TabIndex = 29
        MonthBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' YearBox
        ' 
        YearBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        YearBox.Location = New Point(146, 398)
        YearBox.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        YearBox.Name = "YearBox"
        YearBox.Size = New Size(64, 29)
        YearBox.TabIndex = 30
        YearBox.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(146, 280)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 31
        Label1.Text = "Day met:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(146, 330)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 32
        Label2.Text = "Month met:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(146, 380)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 33
        Label3.Text = "Year met:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(216, 280)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 15)
        Label4.TabIndex = 34
        Label4.Text = "Times choosen:"
        ' 
        ' TimesChoosenBox
        ' 
        TimesChoosenBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TimesChoosenBox.Location = New Point(216, 298)
        TimesChoosenBox.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        TimesChoosenBox.Name = "TimesChoosenBox"
        TimesChoosenBox.Size = New Size(89, 29)
        TimesChoosenBox.TabIndex = 35
        ' 
        ' AgeBox
        ' 
        AgeBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        AgeBox.FormattingEnabled = True
        AgeBox.Items.AddRange(New Object() {"Baby (up to 3 years)", "Child (4-9 years)", "Young (10-29 years)", "Adult (30-49 years)", "Adult (over 50 years)", "??"})
        AgeBox.Location = New Point(216, 354)
        AgeBox.Name = "AgeBox"
        AgeBox.Size = New Size(121, 23)
        AgeBox.TabIndex = 36
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(216, 330)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 15)
        Label5.TabIndex = 37
        Label5.Text = "Age:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Location = New Point(216, 380)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 15)
        Label6.TabIndex = 39
        Label6.Text = "Gender:"
        ' 
        ' GenderBox
        ' 
        GenderBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        GenderBox.FormattingEnabled = True
        GenderBox.Items.AddRange(New Object() {"Male", "Female", "??"})
        GenderBox.Location = New Point(216, 404)
        GenderBox.Name = "GenderBox"
        GenderBox.Size = New Size(121, 23)
        GenderBox.TabIndex = 38
        ' 
        ' VerticalScrollBox
        ' 
        VerticalScrollBox.DecimalPlaces = 3
        VerticalScrollBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        VerticalScrollBox.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        VerticalScrollBox.Location = New Point(343, 348)
        VerticalScrollBox.Maximum = New Decimal(New Integer() {5, 0, 0, 65536})
        VerticalScrollBox.Minimum = New Decimal(New Integer() {5, 0, 0, -2147418112})
        VerticalScrollBox.Name = "VerticalScrollBox"
        VerticalScrollBox.Size = New Size(73, 29)
        VerticalScrollBox.TabIndex = 40
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(343, 280)
        Label7.Name = "Label7"
        Label7.Size = New Size(45, 15)
        Label7.TabIndex = 41
        Label7.Text = "X scroll"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(343, 330)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 15)
        Label8.TabIndex = 42
        Label8.Text = "Y scroll"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(422, 330)
        Label9.Name = "Label9"
        Label9.Size = New Size(53, 15)
        Label9.TabIndex = 46
        Label9.Text = "Y stretch"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(422, 280)
        Label10.Name = "Label10"
        Label10.Size = New Size(53, 15)
        Label10.TabIndex = 45
        Label10.Text = "X stretch"
        ' 
        ' VerticalStretchBox
        ' 
        VerticalStretchBox.DecimalPlaces = 3
        VerticalStretchBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        VerticalStretchBox.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        VerticalStretchBox.Location = New Point(422, 348)
        VerticalStretchBox.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        VerticalStretchBox.Minimum = New Decimal(New Integer() {25, 0, 0, 131072})
        VerticalStretchBox.Name = "VerticalStretchBox"
        VerticalStretchBox.Size = New Size(73, 29)
        VerticalStretchBox.TabIndex = 44
        VerticalStretchBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' HorizontalStretchBox
        ' 
        HorizontalStretchBox.DecimalPlaces = 3
        HorizontalStretchBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        HorizontalStretchBox.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        HorizontalStretchBox.Location = New Point(422, 298)
        HorizontalStretchBox.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        HorizontalStretchBox.Minimum = New Decimal(New Integer() {25, 0, 0, 131072})
        HorizontalStretchBox.Name = "HorizontalStretchBox"
        HorizontalStretchBox.Size = New Size(73, 29)
        HorizontalStretchBox.TabIndex = 43
        HorizontalStretchBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(343, 380)
        Label11.Name = "Label11"
        Label11.Size = New Size(114, 15)
        Label11.TabIndex = 47
        Label11.Text = "Rotation (in radians)"
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.Filter = "PNG image|*.png|Bitmap image|*.bmp|JPEG image|*.jpg;*.jpeg"
        ' 
        ' DeleteFaceButton
        ' 
        DeleteFaceButton.Enabled = False
        DeleteFaceButton.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        DeleteFaceButton.ForeColor = Color.Red
        DeleteFaceButton.Location = New Point(662, 410)
        DeleteFaceButton.Name = "DeleteFaceButton"
        DeleteFaceButton.Size = New Size(154, 42)
        DeleteFaceButton.TabIndex = 48
        DeleteFaceButton.Text = "Delete face"
        DeleteFaceButton.UseVisualStyleBackColor = True
        ' 
        ' ExportFaceButton
        ' 
        ExportFaceButton.Enabled = False
        ExportFaceButton.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        ExportFaceButton.Location = New Point(662, 280)
        ExportFaceButton.Name = "ExportFaceButton"
        ExportFaceButton.Size = New Size(154, 42)
        ExportFaceButton.TabIndex = 49
        ExportFaceButton.Text = "Export face"
        ExportFaceButton.UseVisualStyleBackColor = True
        ' 
        ' ImportFaceButton
        ' 
        ImportFaceButton.Enabled = False
        ImportFaceButton.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        ImportFaceButton.Location = New Point(501, 280)
        ImportFaceButton.Name = "ImportFaceButton"
        ImportFaceButton.Size = New Size(155, 42)
        ImportFaceButton.TabIndex = 50
        ImportFaceButton.Text = "Import face"
        ImportFaceButton.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(12, 433)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(161, 19)
        CheckBox1.TabIndex = 51
        CheckBox1.Text = "Show face calibrate guide"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' NewFaceButton
        ' 
        NewFaceButton.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        NewFaceButton.Location = New Point(501, 328)
        NewFaceButton.Name = "NewFaceButton"
        NewFaceButton.Size = New Size(155, 42)
        NewFaceButton.TabIndex = 52
        NewFaceButton.Text = "New face"
        NewFaceButton.UseVisualStyleBackColor = True
        ' 
        ' SwapFacesButton
        ' 
        SwapFacesButton.Enabled = False
        SwapFacesButton.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        SwapFacesButton.Location = New Point(662, 328)
        SwapFacesButton.Name = "SwapFacesButton"
        SwapFacesButton.Size = New Size(154, 42)
        SwapFacesButton.TabIndex = 53
        SwapFacesButton.Text = "Swap faces"
        SwapFacesButton.UseVisualStyleBackColor = True
        ' 
        ' FaceEditor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(828, 464)
        Controls.Add(SwapFacesButton)
        Controls.Add(NewFaceButton)
        Controls.Add(CheckBox1)
        Controls.Add(ImportFaceButton)
        Controls.Add(ExportFaceButton)
        Controls.Add(DeleteFaceButton)
        Controls.Add(VerticalStretchBox)
        Controls.Add(HorizontalStretchBox)
        Controls.Add(VerticalScrollBox)
        Controls.Add(GenderBox)
        Controls.Add(AgeBox)
        Controls.Add(TimesChoosenBox)
        Controls.Add(YearBox)
        Controls.Add(MonthBox)
        Controls.Add(RotationBox)
        Controls.Add(DayBox)
        Controls.Add(HorizontalScrollBox)
        Controls.Add(SelectedFaceBox)
        Controls.Add(RightPageButton)
        Controls.Add(FaceBox10)
        Controls.Add(FaceBox9)
        Controls.Add(FaceBox8)
        Controls.Add(FaceBox7)
        Controls.Add(FaceBox6)
        Controls.Add(FaceBox5)
        Controls.Add(FaceBox4)
        Controls.Add(FaceBox3)
        Controls.Add(FaceBox2)
        Controls.Add(LeftPageButton)
        Controls.Add(FaceBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label11)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(Label8)
        Controls.Add(Label7)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "FaceEditor"
        Text = "Face editor"
        CType(FaceBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(FaceBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(FaceBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(FaceBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(FaceBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(FaceBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(FaceBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(FaceBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(FaceBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(FaceBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(SelectedFaceBox, ComponentModel.ISupportInitialize).EndInit()
        CType(HorizontalScrollBox, ComponentModel.ISupportInitialize).EndInit()
        CType(DayBox, ComponentModel.ISupportInitialize).EndInit()
        CType(RotationBox, ComponentModel.ISupportInitialize).EndInit()
        CType(MonthBox, ComponentModel.ISupportInitialize).EndInit()
        CType(YearBox, ComponentModel.ISupportInitialize).EndInit()
        CType(TimesChoosenBox, ComponentModel.ISupportInitialize).EndInit()
        CType(VerticalScrollBox, ComponentModel.ISupportInitialize).EndInit()
        CType(VerticalStretchBox, ComponentModel.ISupportInitialize).EndInit()
        CType(HorizontalStretchBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents RightPageButton As Button
    Friend WithEvents FaceBox10 As PictureBox
    Friend WithEvents FaceBox9 As PictureBox
    Friend WithEvents FaceBox8 As PictureBox
    Friend WithEvents FaceBox7 As PictureBox
    Friend WithEvents FaceBox6 As PictureBox
    Friend WithEvents FaceBox5 As PictureBox
    Friend WithEvents FaceBox4 As PictureBox
    Friend WithEvents FaceBox3 As PictureBox
    Friend WithEvents FaceBox2 As PictureBox
    Friend WithEvents LeftPageButton As Button
    Friend WithEvents FaceBox1 As PictureBox
    Friend WithEvents SelectedFaceBox As PictureBox
    Friend WithEvents HorizontalScrollBox As NumericUpDown
    Friend WithEvents DayBox As NumericUpDown
    Friend WithEvents RotationBox As NumericUpDown
    Friend WithEvents MonthBox As NumericUpDown
    Friend WithEvents YearBox As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TimesChoosenBox As NumericUpDown
    Friend WithEvents AgeBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GenderBox As ComboBox
    Friend WithEvents VerticalScrollBox As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents VerticalStretchBox As NumericUpDown
    Friend WithEvents HorizontalStretchBox As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents DeleteFaceButton As Button
    Friend WithEvents ExportFaceButton As Button
    Friend WithEvents ImportFaceButton As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents NewFaceButton As Button
    Friend WithEvents SwapFacesButton As Button
End Class
