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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FaceEditor))
        Me.RightPageButton = New System.Windows.Forms.Button()
        Me.FaceBox10 = New System.Windows.Forms.PictureBox()
        Me.FaceBox9 = New System.Windows.Forms.PictureBox()
        Me.FaceBox8 = New System.Windows.Forms.PictureBox()
        Me.FaceBox7 = New System.Windows.Forms.PictureBox()
        Me.FaceBox6 = New System.Windows.Forms.PictureBox()
        Me.FaceBox5 = New System.Windows.Forms.PictureBox()
        Me.FaceBox4 = New System.Windows.Forms.PictureBox()
        Me.FaceBox3 = New System.Windows.Forms.PictureBox()
        Me.FaceBox2 = New System.Windows.Forms.PictureBox()
        Me.LeftPageButton = New System.Windows.Forms.Button()
        Me.FaceBox1 = New System.Windows.Forms.PictureBox()
        Me.SelectedFaceBox = New System.Windows.Forms.PictureBox()
        Me.HorizontalScrollBox = New System.Windows.Forms.NumericUpDown()
        Me.DayBox = New System.Windows.Forms.NumericUpDown()
        Me.RotationBox = New System.Windows.Forms.NumericUpDown()
        Me.MonthBox = New System.Windows.Forms.NumericUpDown()
        Me.YearBox = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TimesChoosenBox = New System.Windows.Forms.NumericUpDown()
        Me.AgeBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GenderBox = New System.Windows.Forms.ComboBox()
        Me.VerticalScrollBox = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.VerticalStretchBox = New System.Windows.Forms.NumericUpDown()
        Me.HorizontalStretchBox = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.UpdateImageBuffer = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.DeleteFaceButton = New System.Windows.Forms.Button()
        Me.ExportFaceButton = New System.Windows.Forms.Button()
        Me.ImportFaceButton = New System.Windows.Forms.Button()
        CType(Me.FaceBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaceBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaceBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaceBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaceBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaceBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaceBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaceBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaceBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaceBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectedFaceBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorizontalScrollBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DayBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RotationBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonthBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YearBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimesChoosenBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerticalScrollBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerticalStretchBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorizontalStretchBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RightPageButton
        '
        Me.RightPageButton.Location = New System.Drawing.Point(752, 111)
        Me.RightPageButton.Name = "RightPageButton"
        Me.RightPageButton.Size = New System.Drawing.Size(64, 64)
        Me.RightPageButton.TabIndex = 24
        Me.RightPageButton.Text = "Next"
        Me.RightPageButton.UseVisualStyleBackColor = True
        '
        'FaceBox10
        '
        Me.FaceBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FaceBox10.Image = Global.KbbEdit.My.Resources.Resources.FaceHole
        Me.FaceBox10.Location = New System.Drawing.Point(618, 146)
        Me.FaceBox10.Name = "FaceBox10"
        Me.FaceBox10.Size = New System.Drawing.Size(128, 128)
        Me.FaceBox10.TabIndex = 23
        Me.FaceBox10.TabStop = False
        '
        'FaceBox9
        '
        Me.FaceBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FaceBox9.Image = Global.KbbEdit.My.Resources.Resources.FaceHole
        Me.FaceBox9.Location = New System.Drawing.Point(484, 146)
        Me.FaceBox9.Name = "FaceBox9"
        Me.FaceBox9.Size = New System.Drawing.Size(128, 128)
        Me.FaceBox9.TabIndex = 22
        Me.FaceBox9.TabStop = False
        '
        'FaceBox8
        '
        Me.FaceBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FaceBox8.Image = Global.KbbEdit.My.Resources.Resources.FaceHole
        Me.FaceBox8.Location = New System.Drawing.Point(350, 146)
        Me.FaceBox8.Name = "FaceBox8"
        Me.FaceBox8.Size = New System.Drawing.Size(128, 128)
        Me.FaceBox8.TabIndex = 21
        Me.FaceBox8.TabStop = False
        '
        'FaceBox7
        '
        Me.FaceBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FaceBox7.Image = Global.KbbEdit.My.Resources.Resources.FaceHole
        Me.FaceBox7.Location = New System.Drawing.Point(216, 146)
        Me.FaceBox7.Name = "FaceBox7"
        Me.FaceBox7.Size = New System.Drawing.Size(128, 128)
        Me.FaceBox7.TabIndex = 20
        Me.FaceBox7.TabStop = False
        '
        'FaceBox6
        '
        Me.FaceBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FaceBox6.Image = Global.KbbEdit.My.Resources.Resources.FaceHole
        Me.FaceBox6.Location = New System.Drawing.Point(82, 146)
        Me.FaceBox6.Name = "FaceBox6"
        Me.FaceBox6.Size = New System.Drawing.Size(128, 128)
        Me.FaceBox6.TabIndex = 19
        Me.FaceBox6.TabStop = False
        '
        'FaceBox5
        '
        Me.FaceBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FaceBox5.Image = Global.KbbEdit.My.Resources.Resources.FaceHole
        Me.FaceBox5.Location = New System.Drawing.Point(618, 12)
        Me.FaceBox5.Name = "FaceBox5"
        Me.FaceBox5.Size = New System.Drawing.Size(128, 128)
        Me.FaceBox5.TabIndex = 18
        Me.FaceBox5.TabStop = False
        '
        'FaceBox4
        '
        Me.FaceBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FaceBox4.Image = Global.KbbEdit.My.Resources.Resources.FaceHole
        Me.FaceBox4.Location = New System.Drawing.Point(484, 12)
        Me.FaceBox4.Name = "FaceBox4"
        Me.FaceBox4.Size = New System.Drawing.Size(128, 128)
        Me.FaceBox4.TabIndex = 17
        Me.FaceBox4.TabStop = False
        '
        'FaceBox3
        '
        Me.FaceBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FaceBox3.Image = Global.KbbEdit.My.Resources.Resources.FaceHole
        Me.FaceBox3.Location = New System.Drawing.Point(350, 12)
        Me.FaceBox3.Name = "FaceBox3"
        Me.FaceBox3.Size = New System.Drawing.Size(128, 128)
        Me.FaceBox3.TabIndex = 16
        Me.FaceBox3.TabStop = False
        '
        'FaceBox2
        '
        Me.FaceBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FaceBox2.Image = Global.KbbEdit.My.Resources.Resources.FaceHole
        Me.FaceBox2.Location = New System.Drawing.Point(216, 12)
        Me.FaceBox2.Name = "FaceBox2"
        Me.FaceBox2.Size = New System.Drawing.Size(128, 128)
        Me.FaceBox2.TabIndex = 15
        Me.FaceBox2.TabStop = False
        '
        'LeftPageButton
        '
        Me.LeftPageButton.Location = New System.Drawing.Point(12, 111)
        Me.LeftPageButton.Name = "LeftPageButton"
        Me.LeftPageButton.Size = New System.Drawing.Size(64, 64)
        Me.LeftPageButton.TabIndex = 14
        Me.LeftPageButton.Text = "Previous"
        Me.LeftPageButton.UseVisualStyleBackColor = True
        '
        'FaceBox1
        '
        Me.FaceBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FaceBox1.Image = Global.KbbEdit.My.Resources.Resources.FaceHole
        Me.FaceBox1.Location = New System.Drawing.Point(82, 12)
        Me.FaceBox1.Name = "FaceBox1"
        Me.FaceBox1.Size = New System.Drawing.Size(128, 128)
        Me.FaceBox1.TabIndex = 13
        Me.FaceBox1.TabStop = False
        '
        'SelectedFaceBox
        '
        Me.SelectedFaceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SelectedFaceBox.Image = Global.KbbEdit.My.Resources.Resources.FaceHole
        Me.SelectedFaceBox.Location = New System.Drawing.Point(12, 299)
        Me.SelectedFaceBox.Name = "SelectedFaceBox"
        Me.SelectedFaceBox.Size = New System.Drawing.Size(128, 128)
        Me.SelectedFaceBox.TabIndex = 25
        Me.SelectedFaceBox.TabStop = False
        '
        'HorizontalScrollBox
        '
        Me.HorizontalScrollBox.DecimalPlaces = 3
        Me.HorizontalScrollBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HorizontalScrollBox.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.HorizontalScrollBox.Location = New System.Drawing.Point(343, 298)
        Me.HorizontalScrollBox.Maximum = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.HorizontalScrollBox.Minimum = New Decimal(New Integer() {5, 0, 0, -2147418112})
        Me.HorizontalScrollBox.Name = "HorizontalScrollBox"
        Me.HorizontalScrollBox.Size = New System.Drawing.Size(73, 29)
        Me.HorizontalScrollBox.TabIndex = 26
        '
        'DayBox
        '
        Me.DayBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DayBox.Location = New System.Drawing.Point(146, 298)
        Me.DayBox.Maximum = New Decimal(New Integer() {28, 0, 0, 0})
        Me.DayBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DayBox.Name = "DayBox"
        Me.DayBox.Size = New System.Drawing.Size(54, 29)
        Me.DayBox.TabIndex = 27
        Me.DayBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'RotationBox
        '
        Me.RotationBox.DecimalPlaces = 6
        Me.RotationBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RotationBox.Increment = New Decimal(New Integer() {-914125255, -1057868262, 18922899, 1835008})
        Me.RotationBox.Location = New System.Drawing.Point(343, 398)
        Me.RotationBox.Maximum = New Decimal(New Integer() {3141593, 0, 0, 393216})
        Me.RotationBox.Minimum = New Decimal(New Integer() {3141593, 0, 0, -2147090432})
        Me.RotationBox.Name = "RotationBox"
        Me.RotationBox.Size = New System.Drawing.Size(114, 29)
        Me.RotationBox.TabIndex = 28
        '
        'MonthBox
        '
        Me.MonthBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MonthBox.Location = New System.Drawing.Point(146, 348)
        Me.MonthBox.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.MonthBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MonthBox.Name = "MonthBox"
        Me.MonthBox.Size = New System.Drawing.Size(54, 29)
        Me.MonthBox.TabIndex = 29
        Me.MonthBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'YearBox
        '
        Me.YearBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.YearBox.Location = New System.Drawing.Point(146, 398)
        Me.YearBox.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.YearBox.Name = "YearBox"
        Me.YearBox.Size = New System.Drawing.Size(64, 29)
        Me.YearBox.TabIndex = 30
        Me.YearBox.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(146, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Day met:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(146, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Month met:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(146, 380)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Year met:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Times choosen:"
        '
        'TimesChoosenBox
        '
        Me.TimesChoosenBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TimesChoosenBox.Location = New System.Drawing.Point(216, 298)
        Me.TimesChoosenBox.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.TimesChoosenBox.Name = "TimesChoosenBox"
        Me.TimesChoosenBox.Size = New System.Drawing.Size(89, 29)
        Me.TimesChoosenBox.TabIndex = 35
        '
        'AgeBox
        '
        Me.AgeBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AgeBox.FormattingEnabled = True
        Me.AgeBox.Items.AddRange(New Object() {"Baby (up to 3 years)", "Child (4-9 years)", "Young (10-29 years)", "Adult (30-49 years)", "Adult (over 50 years)", "??"})
        Me.AgeBox.Location = New System.Drawing.Point(216, 354)
        Me.AgeBox.Name = "AgeBox"
        Me.AgeBox.Size = New System.Drawing.Size(121, 23)
        Me.AgeBox.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(216, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Age:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(216, 380)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Gender:"
        '
        'GenderBox
        '
        Me.GenderBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GenderBox.FormattingEnabled = True
        Me.GenderBox.Items.AddRange(New Object() {"Male", "Female", "??"})
        Me.GenderBox.Location = New System.Drawing.Point(216, 404)
        Me.GenderBox.Name = "GenderBox"
        Me.GenderBox.Size = New System.Drawing.Size(121, 23)
        Me.GenderBox.TabIndex = 38
        '
        'VerticalScrollBox
        '
        Me.VerticalScrollBox.DecimalPlaces = 3
        Me.VerticalScrollBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.VerticalScrollBox.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.VerticalScrollBox.Location = New System.Drawing.Point(343, 348)
        Me.VerticalScrollBox.Maximum = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.VerticalScrollBox.Minimum = New Decimal(New Integer() {5, 0, 0, -2147418112})
        Me.VerticalScrollBox.Name = "VerticalScrollBox"
        Me.VerticalScrollBox.Size = New System.Drawing.Size(73, 29)
        Me.VerticalScrollBox.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(343, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "X scroll"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(343, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 15)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Y scroll"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(422, 330)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 15)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Y stretch"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(422, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 15)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "X stretch"
        '
        'VerticalStretchBox
        '
        Me.VerticalStretchBox.DecimalPlaces = 3
        Me.VerticalStretchBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.VerticalStretchBox.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.VerticalStretchBox.Location = New System.Drawing.Point(422, 348)
        Me.VerticalStretchBox.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.VerticalStretchBox.Minimum = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.VerticalStretchBox.Name = "VerticalStretchBox"
        Me.VerticalStretchBox.Size = New System.Drawing.Size(73, 29)
        Me.VerticalStretchBox.TabIndex = 44
        Me.VerticalStretchBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'HorizontalStretchBox
        '
        Me.HorizontalStretchBox.DecimalPlaces = 3
        Me.HorizontalStretchBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HorizontalStretchBox.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.HorizontalStretchBox.Location = New System.Drawing.Point(422, 298)
        Me.HorizontalStretchBox.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.HorizontalStretchBox.Minimum = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.HorizontalStretchBox.Name = "HorizontalStretchBox"
        Me.HorizontalStretchBox.Size = New System.Drawing.Size(73, 29)
        Me.HorizontalStretchBox.TabIndex = 43
        Me.HorizontalStretchBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(343, 380)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 15)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Rotation (in radians)"
        '
        'UpdateImageBuffer
        '
        Me.UpdateImageBuffer.Interval = 1
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Bitmap image|*.bmp|JPEG image|*.jpg;*.jpeg|PNG image|*.png"
        '
        'DeleteFaceButton
        '
        Me.DeleteFaceButton.Enabled = False
        Me.DeleteFaceButton.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeleteFaceButton.ForeColor = System.Drawing.Color.Red
        Me.DeleteFaceButton.Location = New System.Drawing.Point(602, 385)
        Me.DeleteFaceButton.Name = "DeleteFaceButton"
        Me.DeleteFaceButton.Size = New System.Drawing.Size(214, 42)
        Me.DeleteFaceButton.TabIndex = 48
        Me.DeleteFaceButton.Text = "Delete face"
        Me.DeleteFaceButton.UseVisualStyleBackColor = True
        '
        'ExportFaceButton
        '
        Me.ExportFaceButton.Enabled = False
        Me.ExportFaceButton.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExportFaceButton.Location = New System.Drawing.Point(602, 328)
        Me.ExportFaceButton.Name = "ExportFaceButton"
        Me.ExportFaceButton.Size = New System.Drawing.Size(214, 42)
        Me.ExportFaceButton.TabIndex = 49
        Me.ExportFaceButton.Text = "Export face"
        Me.ExportFaceButton.UseVisualStyleBackColor = True
        '
        'ImportFaceButton
        '
        Me.ImportFaceButton.Enabled = False
        Me.ImportFaceButton.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ImportFaceButton.Location = New System.Drawing.Point(602, 280)
        Me.ImportFaceButton.Name = "ImportFaceButton"
        Me.ImportFaceButton.Size = New System.Drawing.Size(214, 42)
        Me.ImportFaceButton.TabIndex = 50
        Me.ImportFaceButton.Text = "Import face"
        Me.ImportFaceButton.UseVisualStyleBackColor = True
        '
        'FaceEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 439)
        Me.Controls.Add(Me.ImportFaceButton)
        Me.Controls.Add(Me.ExportFaceButton)
        Me.Controls.Add(Me.DeleteFaceButton)
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
        Me.Controls.Add(Me.SelectedFaceBox)
        Me.Controls.Add(Me.RightPageButton)
        Me.Controls.Add(Me.FaceBox10)
        Me.Controls.Add(Me.FaceBox9)
        Me.Controls.Add(Me.FaceBox8)
        Me.Controls.Add(Me.FaceBox7)
        Me.Controls.Add(Me.FaceBox6)
        Me.Controls.Add(Me.FaceBox5)
        Me.Controls.Add(Me.FaceBox4)
        Me.Controls.Add(Me.FaceBox3)
        Me.Controls.Add(Me.FaceBox2)
        Me.Controls.Add(Me.LeftPageButton)
        Me.Controls.Add(Me.FaceBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FaceEditor"
        Me.Text = "Face editor"
        CType(Me.FaceBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaceBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaceBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaceBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaceBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaceBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaceBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaceBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaceBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaceBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectedFaceBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorizontalScrollBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DayBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RotationBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonthBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YearBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimesChoosenBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerticalScrollBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerticalStretchBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorizontalStretchBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents UpdateImageBuffer As Timer
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents DeleteFaceButton As Button
    Friend WithEvents ExportFaceButton As Button
    Friend WithEvents ImportFaceButton As Button
End Class
