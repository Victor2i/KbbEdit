<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewFaceForm
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewFaceForm))
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        FinishButton = New Button()
        CheckBox1 = New CheckBox()
        Label2 = New Label()
        Label1 = New Label()
        TrPwr = New NumericUpDown()
        ZoomPwr = New NumericUpDown()
        ResetImageTransformButton = New Button()
        SelectImageButton = New Button()
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        OpenFileDialog1 = New OpenFileDialog()
        GenderBox = New ComboBox()
        AgeBox = New ComboBox()
        TimesChoosenBox = New NumericUpDown()
        YearBox = New NumericUpDown()
        MonthBox = New NumericUpDown()
        DayBox = New NumericUpDown()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        HorizontalScrollBox = New NumericUpDown()
        RotationBox = New NumericUpDown()
        VerticalScrollBox = New NumericUpDown()
        HorizontalStretchBox = New NumericUpDown()
        VerticalStretchBox = New NumericUpDown()
        CType(TrPwr, ComponentModel.ISupportInitialize).BeginInit()
        CType(ZoomPwr, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(TimesChoosenBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(YearBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(MonthBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(DayBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(HorizontalScrollBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(RotationBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(VerticalScrollBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(HorizontalStretchBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(VerticalStretchBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Default", "Low", "High", "Bilinear", "Bicubic", "Nearest Neighbor", "High Quality Bilinear", "High Quality Bicubic"})
        ComboBox1.Location = New Point(150, 408)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(120, 23)
        ComboBox1.TabIndex = 21
        ComboBox1.Text = "Default"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Pixel)
        Label3.Location = New Point(12, 408)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 23)
        Label3.TabIndex = 20
        Label3.Text = "Interpolation"
        ' 
        ' FinishButton
        ' 
        FinishButton.Enabled = False
        FinishButton.Location = New Point(195, 437)
        FinishButton.Name = "FinishButton"
        FinishButton.Size = New Size(75, 23)
        FinishButton.TabIndex = 19
        FinishButton.Text = "Finish"
        FinishButton.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(12, 440)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(161, 19)
        CheckBox1.TabIndex = 18
        CheckBox1.Text = "Show face calibrate guide"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Pixel)
        Label2.Location = New Point(12, 379)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 23)
        Label2.TabIndex = 17
        Label2.Text = "Translate Power"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Pixel)
        Label1.Location = New Point(12, 350)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 23)
        Label1.TabIndex = 16
        Label1.Text = "Zoom Power"
        ' 
        ' TrPwr
        ' 
        TrPwr.DecimalPlaces = 2
        TrPwr.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        TrPwr.Location = New Point(150, 379)
        TrPwr.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        TrPwr.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        TrPwr.Name = "TrPwr"
        TrPwr.Size = New Size(120, 23)
        TrPwr.TabIndex = 15
        TrPwr.TextAlign = HorizontalAlignment.Center
        TrPwr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' ZoomPwr
        ' 
        ZoomPwr.DecimalPlaces = 2
        ZoomPwr.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        ZoomPwr.Location = New Point(150, 350)
        ZoomPwr.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        ZoomPwr.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        ZoomPwr.Name = "ZoomPwr"
        ZoomPwr.Size = New Size(120, 23)
        ZoomPwr.TabIndex = 14
        ZoomPwr.TextAlign = HorizontalAlignment.Center
        ZoomPwr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' ResetImageTransformButton
        ' 
        ResetImageTransformButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ResetImageTransformButton.Location = New Point(12, 313)
        ResetImageTransformButton.Name = "ResetImageTransformButton"
        ResetImageTransformButton.Size = New Size(258, 31)
        ResetImageTransformButton.TabIndex = 13
        ResetImageTransformButton.Text = "Reset image transform"
        ResetImageTransformButton.UseVisualStyleBackColor = True
        ' 
        ' SelectImageButton
        ' 
        SelectImageButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SelectImageButton.Location = New Point(12, 276)
        SelectImageButton.Name = "SelectImageButton"
        SelectImageButton.Size = New Size(258, 31)
        SelectImageButton.TabIndex = 12
        SelectImageButton.Text = "Select image..."
        SelectImageButton.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(258, 258)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.Filter = "PNG image|*.png|Bitmap image|*.bmp|JPEG image|*.jpg;*.jpeg"
        ' 
        ' GenderBox
        ' 
        GenderBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        GenderBox.FormattingEnabled = True
        GenderBox.Items.AddRange(New Object() {"Male", "Female", "??"})
        GenderBox.Location = New Point(276, 286)
        GenderBox.Name = "GenderBox"
        GenderBox.Size = New Size(121, 23)
        GenderBox.TabIndex = 60
        ' 
        ' AgeBox
        ' 
        AgeBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        AgeBox.FormattingEnabled = True
        AgeBox.Items.AddRange(New Object() {"Baby (up to 3 years)", "Child (4-9 years)", "Young (10-29 years)", "Adult (30-49 years)", "Adult (over 50 years)", "??"})
        AgeBox.Location = New Point(276, 236)
        AgeBox.Name = "AgeBox"
        AgeBox.Size = New Size(121, 23)
        AgeBox.TabIndex = 58
        ' 
        ' TimesChoosenBox
        ' 
        TimesChoosenBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TimesChoosenBox.Location = New Point(276, 180)
        TimesChoosenBox.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        TimesChoosenBox.Name = "TimesChoosenBox"
        TimesChoosenBox.Size = New Size(89, 29)
        TimesChoosenBox.TabIndex = 57
        ' 
        ' YearBox
        ' 
        YearBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        YearBox.Location = New Point(276, 130)
        YearBox.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        YearBox.Name = "YearBox"
        YearBox.Size = New Size(64, 29)
        YearBox.TabIndex = 52
        YearBox.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        ' 
        ' MonthBox
        ' 
        MonthBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MonthBox.Location = New Point(276, 80)
        MonthBox.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        MonthBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        MonthBox.Name = "MonthBox"
        MonthBox.Size = New Size(54, 29)
        MonthBox.TabIndex = 51
        MonthBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' DayBox
        ' 
        DayBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DayBox.Location = New Point(276, 30)
        DayBox.Maximum = New Decimal(New Integer() {28, 0, 0, 0})
        DayBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        DayBox.Name = "DayBox"
        DayBox.Size = New Size(54, 29)
        DayBox.TabIndex = 49
        DayBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(276, 62)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 15)
        Label4.TabIndex = 54
        Label4.Text = "Month met:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(276, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 15)
        Label5.TabIndex = 53
        Label5.Text = "Day met:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Location = New Point(276, 112)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 15)
        Label6.TabIndex = 55
        Label6.Text = "Year met:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(276, 162)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 15)
        Label7.TabIndex = 56
        Label7.Text = "Times choosen:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Location = New Point(276, 212)
        Label8.Name = "Label8"
        Label8.Size = New Size(31, 15)
        Label8.TabIndex = 59
        Label8.Text = "Age:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Location = New Point(276, 262)
        Label9.Name = "Label9"
        Label9.Size = New Size(48, 15)
        Label9.TabIndex = 61
        Label9.Text = "Gender:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(276, 312)
        Label14.Name = "Label14"
        Label14.Size = New Size(45, 15)
        Label14.TabIndex = 63
        Label14.Text = "X scroll"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(276, 362)
        Label13.Name = "Label13"
        Label13.Size = New Size(45, 15)
        Label13.TabIndex = 64
        Label13.Text = "Y scroll"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(355, 312)
        Label12.Name = "Label12"
        Label12.Size = New Size(53, 15)
        Label12.TabIndex = 67
        Label12.Text = "X stretch"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(355, 362)
        Label10.Name = "Label10"
        Label10.Size = New Size(53, 15)
        Label10.TabIndex = 68
        Label10.Text = "Y stretch"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(276, 412)
        Label11.Name = "Label11"
        Label11.Size = New Size(114, 15)
        Label11.TabIndex = 69
        Label11.Text = "Rotation (in radians)"
        ' 
        ' HorizontalScrollBox
        ' 
        HorizontalScrollBox.DecimalPlaces = 3
        HorizontalScrollBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        HorizontalScrollBox.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        HorizontalScrollBox.Location = New Point(276, 330)
        HorizontalScrollBox.Maximum = New Decimal(New Integer() {5, 0, 0, 65536})
        HorizontalScrollBox.Minimum = New Decimal(New Integer() {5, 0, 0, -2147418112})
        HorizontalScrollBox.Name = "HorizontalScrollBox"
        HorizontalScrollBox.Size = New Size(73, 29)
        HorizontalScrollBox.TabIndex = 48
        ' 
        ' RotationBox
        ' 
        RotationBox.DecimalPlaces = 6
        RotationBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RotationBox.Increment = New Decimal(New Integer() {-914125255, -1057868262, 18922899, 1835008})
        RotationBox.Location = New Point(276, 430)
        RotationBox.Maximum = New Decimal(New Integer() {3141593, 0, 0, 393216})
        RotationBox.Minimum = New Decimal(New Integer() {3141593, 0, 0, -2147090432})
        RotationBox.Name = "RotationBox"
        RotationBox.Size = New Size(114, 29)
        RotationBox.TabIndex = 50
        ' 
        ' VerticalScrollBox
        ' 
        VerticalScrollBox.DecimalPlaces = 3
        VerticalScrollBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        VerticalScrollBox.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        VerticalScrollBox.Location = New Point(276, 380)
        VerticalScrollBox.Maximum = New Decimal(New Integer() {5, 0, 0, 65536})
        VerticalScrollBox.Minimum = New Decimal(New Integer() {5, 0, 0, -2147418112})
        VerticalScrollBox.Name = "VerticalScrollBox"
        VerticalScrollBox.Size = New Size(73, 29)
        VerticalScrollBox.TabIndex = 62
        ' 
        ' HorizontalStretchBox
        ' 
        HorizontalStretchBox.DecimalPlaces = 3
        HorizontalStretchBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        HorizontalStretchBox.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        HorizontalStretchBox.Location = New Point(355, 330)
        HorizontalStretchBox.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        HorizontalStretchBox.Minimum = New Decimal(New Integer() {25, 0, 0, 131072})
        HorizontalStretchBox.Name = "HorizontalStretchBox"
        HorizontalStretchBox.Size = New Size(73, 29)
        HorizontalStretchBox.TabIndex = 65
        HorizontalStretchBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' VerticalStretchBox
        ' 
        VerticalStretchBox.DecimalPlaces = 3
        VerticalStretchBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        VerticalStretchBox.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        VerticalStretchBox.Location = New Point(355, 380)
        VerticalStretchBox.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        VerticalStretchBox.Minimum = New Decimal(New Integer() {25, 0, 0, 131072})
        VerticalStretchBox.Name = "VerticalStretchBox"
        VerticalStretchBox.Size = New Size(73, 29)
        VerticalStretchBox.TabIndex = 66
        VerticalStretchBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' NewFaceForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(440, 472)
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
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Controls.Add(Label14)
        Controls.Add(PictureBox1)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(FinishButton)
        Controls.Add(CheckBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TrPwr)
        Controls.Add(ZoomPwr)
        Controls.Add(ResetImageTransformButton)
        Controls.Add(SelectImageButton)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "NewFaceForm"
        Text = "New face"
        CType(TrPwr, ComponentModel.ISupportInitialize).EndInit()
        CType(ZoomPwr, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(TimesChoosenBox, ComponentModel.ISupportInitialize).EndInit()
        CType(YearBox, ComponentModel.ISupportInitialize).EndInit()
        CType(MonthBox, ComponentModel.ISupportInitialize).EndInit()
        CType(DayBox, ComponentModel.ISupportInitialize).EndInit()
        CType(HorizontalScrollBox, ComponentModel.ISupportInitialize).EndInit()
        CType(RotationBox, ComponentModel.ISupportInitialize).EndInit()
        CType(VerticalScrollBox, ComponentModel.ISupportInitialize).EndInit()
        CType(HorizontalStretchBox, ComponentModel.ISupportInitialize).EndInit()
        CType(VerticalStretchBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FinishButton As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TrPwr As NumericUpDown
    Friend WithEvents ZoomPwr As NumericUpDown
    Friend WithEvents ResetImageTransformButton As Button
    Friend WithEvents SelectImageButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GenderBox As ComboBox
    Friend WithEvents AgeBox As ComboBox
    Friend WithEvents TimesChoosenBox As NumericUpDown
    Friend WithEvents YearBox As NumericUpDown
    Friend WithEvents MonthBox As NumericUpDown
    Friend WithEvents DayBox As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents HorizontalScrollBox As NumericUpDown
    Friend WithEvents RotationBox As NumericUpDown
    Friend WithEvents VerticalScrollBox As NumericUpDown
    Friend WithEvents HorizontalStretchBox As NumericUpDown
    Friend WithEvents VerticalStretchBox As NumericUpDown
End Class
