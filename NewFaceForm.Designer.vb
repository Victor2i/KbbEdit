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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewFaceForm))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FinishButton = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrPwr = New System.Windows.Forms.NumericUpDown()
        Me.ZoomPwr = New System.Windows.Forms.NumericUpDown()
        Me.ResetImageTransformButton = New System.Windows.Forms.Button()
        Me.SelectImageButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GenderBox = New System.Windows.Forms.ComboBox()
        Me.AgeBox = New System.Windows.Forms.ComboBox()
        Me.TimesChoosenBox = New System.Windows.Forms.NumericUpDown()
        Me.YearBox = New System.Windows.Forms.NumericUpDown()
        Me.MonthBox = New System.Windows.Forms.NumericUpDown()
        Me.DayBox = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.HorizontalScrollBox = New System.Windows.Forms.NumericUpDown()
        Me.RotationBox = New System.Windows.Forms.NumericUpDown()
        Me.VerticalScrollBox = New System.Windows.Forms.NumericUpDown()
        Me.HorizontalStretchBox = New System.Windows.Forms.NumericUpDown()
        Me.VerticalStretchBox = New System.Windows.Forms.NumericUpDown()
        CType(Me.TrPwr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZoomPwr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimesChoosenBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YearBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonthBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DayBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorizontalScrollBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RotationBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerticalScrollBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorizontalStretchBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerticalStretchBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Default", "Low", "High", "Bilinear", "Bicubic", "Nearest Neighbor", "High Quality Bilinear", "High Quality Bicubic"})
        Me.ComboBox1.Location = New System.Drawing.Point(150, 408)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(120, 23)
        Me.ComboBox1.TabIndex = 21
        Me.ComboBox1.Text = "Default"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.Location = New System.Drawing.Point(12, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 23)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Interpolation"
        '
        'FinishButton
        '
        Me.FinishButton.Enabled = False
        Me.FinishButton.Location = New System.Drawing.Point(195, 437)
        Me.FinishButton.Name = "FinishButton"
        Me.FinishButton.Size = New System.Drawing.Size(75, 23)
        Me.FinishButton.TabIndex = 19
        Me.FinishButton.Text = "Finish"
        Me.FinishButton.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 440)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(161, 19)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Show face calibrate guide"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.Location = New System.Drawing.Point(12, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 23)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Translate Power"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.Location = New System.Drawing.Point(12, 350)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Zoom Power"
        '
        'TrPwr
        '
        Me.TrPwr.DecimalPlaces = 2
        Me.TrPwr.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.TrPwr.Location = New System.Drawing.Point(150, 379)
        Me.TrPwr.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.TrPwr.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.TrPwr.Name = "TrPwr"
        Me.TrPwr.Size = New System.Drawing.Size(120, 23)
        Me.TrPwr.TabIndex = 15
        Me.TrPwr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TrPwr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ZoomPwr
        '
        Me.ZoomPwr.DecimalPlaces = 2
        Me.ZoomPwr.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ZoomPwr.Location = New System.Drawing.Point(150, 350)
        Me.ZoomPwr.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.ZoomPwr.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.ZoomPwr.Name = "ZoomPwr"
        Me.ZoomPwr.Size = New System.Drawing.Size(120, 23)
        Me.ZoomPwr.TabIndex = 14
        Me.ZoomPwr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ZoomPwr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ResetImageTransformButton
        '
        Me.ResetImageTransformButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResetImageTransformButton.Location = New System.Drawing.Point(12, 313)
        Me.ResetImageTransformButton.Name = "ResetImageTransformButton"
        Me.ResetImageTransformButton.Size = New System.Drawing.Size(258, 31)
        Me.ResetImageTransformButton.TabIndex = 13
        Me.ResetImageTransformButton.Text = "Reset image transform"
        Me.ResetImageTransformButton.UseVisualStyleBackColor = True
        '
        'SelectImageButton
        '
        Me.SelectImageButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SelectImageButton.Location = New System.Drawing.Point(12, 276)
        Me.SelectImageButton.Name = "SelectImageButton"
        Me.SelectImageButton.Size = New System.Drawing.Size(258, 31)
        Me.SelectImageButton.TabIndex = 12
        Me.SelectImageButton.Text = "Select image..."
        Me.SelectImageButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 258)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Bitmap image|*.bmp|JPEG image|*.jpg;*.jpeg|PNG image|*.png"
        '
        'GenderBox
        '
        Me.GenderBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GenderBox.FormattingEnabled = True
        Me.GenderBox.Items.AddRange(New Object() {"Male", "Female", "??"})
        Me.GenderBox.Location = New System.Drawing.Point(276, 286)
        Me.GenderBox.Name = "GenderBox"
        Me.GenderBox.Size = New System.Drawing.Size(121, 23)
        Me.GenderBox.TabIndex = 60
        '
        'AgeBox
        '
        Me.AgeBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AgeBox.FormattingEnabled = True
        Me.AgeBox.Items.AddRange(New Object() {"Baby (up to 3 years)", "Child (4-9 years)", "Young (10-29 years)", "Adult (30-49 years)", "Adult (over 50 years)", "??"})
        Me.AgeBox.Location = New System.Drawing.Point(276, 236)
        Me.AgeBox.Name = "AgeBox"
        Me.AgeBox.Size = New System.Drawing.Size(121, 23)
        Me.AgeBox.TabIndex = 58
        '
        'TimesChoosenBox
        '
        Me.TimesChoosenBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TimesChoosenBox.Location = New System.Drawing.Point(276, 180)
        Me.TimesChoosenBox.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.TimesChoosenBox.Name = "TimesChoosenBox"
        Me.TimesChoosenBox.Size = New System.Drawing.Size(89, 29)
        Me.TimesChoosenBox.TabIndex = 57
        '
        'YearBox
        '
        Me.YearBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.YearBox.Location = New System.Drawing.Point(276, 130)
        Me.YearBox.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.YearBox.Name = "YearBox"
        Me.YearBox.Size = New System.Drawing.Size(64, 29)
        Me.YearBox.TabIndex = 52
        Me.YearBox.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'MonthBox
        '
        Me.MonthBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MonthBox.Location = New System.Drawing.Point(276, 80)
        Me.MonthBox.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.MonthBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MonthBox.Name = "MonthBox"
        Me.MonthBox.Size = New System.Drawing.Size(54, 29)
        Me.MonthBox.TabIndex = 51
        Me.MonthBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DayBox
        '
        Me.DayBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DayBox.Location = New System.Drawing.Point(276, 30)
        Me.DayBox.Maximum = New Decimal(New Integer() {28, 0, 0, 0})
        Me.DayBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DayBox.Name = "DayBox"
        Me.DayBox.Size = New System.Drawing.Size(54, 29)
        Me.DayBox.TabIndex = 49
        Me.DayBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(276, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Month met:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(276, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Day met:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(276, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Year met:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(276, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 15)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Times choosen:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(276, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 15)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Age:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(276, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 15)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Gender:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(276, 312)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 15)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "X scroll"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(276, 362)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 15)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Y scroll"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(355, 312)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 15)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "X stretch"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(355, 362)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 15)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "Y stretch"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(276, 412)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 15)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Rotation (in radians)"
        '
        'HorizontalScrollBox
        '
        Me.HorizontalScrollBox.DecimalPlaces = 3
        Me.HorizontalScrollBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HorizontalScrollBox.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.HorizontalScrollBox.Location = New System.Drawing.Point(276, 330)
        Me.HorizontalScrollBox.Maximum = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.HorizontalScrollBox.Minimum = New Decimal(New Integer() {5, 0, 0, -2147418112})
        Me.HorizontalScrollBox.Name = "HorizontalScrollBox"
        Me.HorizontalScrollBox.Size = New System.Drawing.Size(73, 29)
        Me.HorizontalScrollBox.TabIndex = 48
        '
        'RotationBox
        '
        Me.RotationBox.DecimalPlaces = 6
        Me.RotationBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RotationBox.Increment = New Decimal(New Integer() {-914125255, -1057868262, 18922899, 1835008})
        Me.RotationBox.Location = New System.Drawing.Point(276, 430)
        Me.RotationBox.Maximum = New Decimal(New Integer() {3141593, 0, 0, 393216})
        Me.RotationBox.Minimum = New Decimal(New Integer() {3141593, 0, 0, -2147090432})
        Me.RotationBox.Name = "RotationBox"
        Me.RotationBox.Size = New System.Drawing.Size(114, 29)
        Me.RotationBox.TabIndex = 50
        '
        'VerticalScrollBox
        '
        Me.VerticalScrollBox.DecimalPlaces = 3
        Me.VerticalScrollBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.VerticalScrollBox.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.VerticalScrollBox.Location = New System.Drawing.Point(276, 380)
        Me.VerticalScrollBox.Maximum = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.VerticalScrollBox.Minimum = New Decimal(New Integer() {5, 0, 0, -2147418112})
        Me.VerticalScrollBox.Name = "VerticalScrollBox"
        Me.VerticalScrollBox.Size = New System.Drawing.Size(73, 29)
        Me.VerticalScrollBox.TabIndex = 62
        '
        'HorizontalStretchBox
        '
        Me.HorizontalStretchBox.DecimalPlaces = 3
        Me.HorizontalStretchBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HorizontalStretchBox.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.HorizontalStretchBox.Location = New System.Drawing.Point(355, 330)
        Me.HorizontalStretchBox.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.HorizontalStretchBox.Minimum = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.HorizontalStretchBox.Name = "HorizontalStretchBox"
        Me.HorizontalStretchBox.Size = New System.Drawing.Size(73, 29)
        Me.HorizontalStretchBox.TabIndex = 65
        Me.HorizontalStretchBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'VerticalStretchBox
        '
        Me.VerticalStretchBox.DecimalPlaces = 3
        Me.VerticalStretchBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.VerticalStretchBox.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.VerticalStretchBox.Location = New System.Drawing.Point(355, 380)
        Me.VerticalStretchBox.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.VerticalStretchBox.Minimum = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.VerticalStretchBox.Name = "VerticalStretchBox"
        Me.VerticalStretchBox.Size = New System.Drawing.Size(73, 29)
        Me.VerticalStretchBox.TabIndex = 66
        Me.VerticalStretchBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NewFaceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 472)
        Me.Controls.Add(Me.VerticalStretchBox)
        Me.Controls.Add(Me.HorizontalStretchBox)
        Me.Controls.Add(Me.VerticalScrollBox)
        Me.Controls.Add(Me.GenderBox)
        Me.Controls.Add(Me.AgeBox)
        Me.Controls.Add(Me.TimesChoosenBox)
        Me.Controls.Add(Me.YearBox)
        Me.Controls.Add(Me.MonthBox)
        Me.Controls.Add(Me.RotationBox)
        Me.Controls.Add(Me.DayBox)
        Me.Controls.Add(Me.HorizontalScrollBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FinishButton)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrPwr)
        Me.Controls.Add(Me.ZoomPwr)
        Me.Controls.Add(Me.ResetImageTransformButton)
        Me.Controls.Add(Me.SelectImageButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewFaceForm"
        Me.Text = "New face"
        CType(Me.TrPwr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZoomPwr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimesChoosenBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YearBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonthBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DayBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorizontalScrollBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RotationBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerticalScrollBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorizontalStretchBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerticalStretchBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
