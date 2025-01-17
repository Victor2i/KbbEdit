<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UFOEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UFOEditor))
        FaceBox10 = New PictureBox()
        FaceBox9 = New PictureBox()
        FaceBox8 = New PictureBox()
        FaceBox7 = New PictureBox()
        FaceBox6 = New PictureBox()
        FaceBox5 = New PictureBox()
        FaceBox4 = New PictureBox()
        FaceBox3 = New PictureBox()
        FaceBox2 = New PictureBox()
        FaceBox1 = New PictureBox()
        SelectedFaceBox = New PictureBox()
        SwapFacesButton = New Button()
        NewFaceButton = New Button()
        CheckBox1 = New CheckBox()
        ImportFaceButton = New Button()
        ExportFaceButton = New Button()
        DeleteFaceButton = New Button()
        NewFaceCB = New CheckBox()
        SaveFileDialog1 = New SaveFileDialog()
        GenderBox = New ComboBox()
        AgeBox = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label1 = New Label()
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
        SuspendLayout()
        ' 
        ' FaceBox10
        ' 
        FaceBox10.BorderStyle = BorderStyle.FixedSingle
        FaceBox10.Location = New Point(548, 146)
        FaceBox10.Name = "FaceBox10"
        FaceBox10.Size = New Size(128, 128)
        FaceBox10.TabIndex = 33
        FaceBox10.TabStop = False
        ' 
        ' FaceBox9
        ' 
        FaceBox9.BorderStyle = BorderStyle.FixedSingle
        FaceBox9.Location = New Point(414, 146)
        FaceBox9.Name = "FaceBox9"
        FaceBox9.Size = New Size(128, 128)
        FaceBox9.TabIndex = 32
        FaceBox9.TabStop = False
        ' 
        ' FaceBox8
        ' 
        FaceBox8.BorderStyle = BorderStyle.FixedSingle
        FaceBox8.Location = New Point(280, 146)
        FaceBox8.Name = "FaceBox8"
        FaceBox8.Size = New Size(128, 128)
        FaceBox8.TabIndex = 31
        FaceBox8.TabStop = False
        ' 
        ' FaceBox7
        ' 
        FaceBox7.BorderStyle = BorderStyle.FixedSingle
        FaceBox7.Location = New Point(146, 146)
        FaceBox7.Name = "FaceBox7"
        FaceBox7.Size = New Size(128, 128)
        FaceBox7.TabIndex = 30
        FaceBox7.TabStop = False
        ' 
        ' FaceBox6
        ' 
        FaceBox6.BorderStyle = BorderStyle.FixedSingle
        FaceBox6.Location = New Point(12, 146)
        FaceBox6.Name = "FaceBox6"
        FaceBox6.Size = New Size(128, 128)
        FaceBox6.TabIndex = 29
        FaceBox6.TabStop = False
        ' 
        ' FaceBox5
        ' 
        FaceBox5.BorderStyle = BorderStyle.FixedSingle
        FaceBox5.Location = New Point(548, 12)
        FaceBox5.Name = "FaceBox5"
        FaceBox5.Size = New Size(128, 128)
        FaceBox5.TabIndex = 28
        FaceBox5.TabStop = False
        ' 
        ' FaceBox4
        ' 
        FaceBox4.BorderStyle = BorderStyle.FixedSingle
        FaceBox4.Location = New Point(414, 12)
        FaceBox4.Name = "FaceBox4"
        FaceBox4.Size = New Size(128, 128)
        FaceBox4.TabIndex = 27
        FaceBox4.TabStop = False
        ' 
        ' FaceBox3
        ' 
        FaceBox3.BorderStyle = BorderStyle.FixedSingle
        FaceBox3.Location = New Point(280, 12)
        FaceBox3.Name = "FaceBox3"
        FaceBox3.Size = New Size(128, 128)
        FaceBox3.TabIndex = 26
        FaceBox3.TabStop = False
        ' 
        ' FaceBox2
        ' 
        FaceBox2.BorderStyle = BorderStyle.FixedSingle
        FaceBox2.Location = New Point(146, 12)
        FaceBox2.Name = "FaceBox2"
        FaceBox2.Size = New Size(128, 128)
        FaceBox2.TabIndex = 25
        FaceBox2.TabStop = False
        ' 
        ' FaceBox1
        ' 
        FaceBox1.BorderStyle = BorderStyle.FixedSingle
        FaceBox1.Location = New Point(12, 12)
        FaceBox1.Name = "FaceBox1"
        FaceBox1.Size = New Size(128, 128)
        FaceBox1.TabIndex = 24
        FaceBox1.TabStop = False
        ' 
        ' SelectedFaceBox
        ' 
        SelectedFaceBox.BorderStyle = BorderStyle.FixedSingle
        SelectedFaceBox.Location = New Point(12, 285)
        SelectedFaceBox.Name = "SelectedFaceBox"
        SelectedFaceBox.Size = New Size(128, 128)
        SelectedFaceBox.TabIndex = 34
        SelectedFaceBox.TabStop = False
        ' 
        ' SwapFacesButton
        ' 
        SwapFacesButton.Enabled = False
        SwapFacesButton.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        SwapFacesButton.Location = New Point(522, 328)
        SwapFacesButton.Name = "SwapFacesButton"
        SwapFacesButton.Size = New Size(154, 42)
        SwapFacesButton.TabIndex = 59
        SwapFacesButton.Text = "Swap faces"
        SwapFacesButton.UseVisualStyleBackColor = True
        ' 
        ' NewFaceButton
        ' 
        NewFaceButton.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        NewFaceButton.Location = New Point(361, 328)
        NewFaceButton.Name = "NewFaceButton"
        NewFaceButton.Size = New Size(155, 42)
        NewFaceButton.TabIndex = 58
        NewFaceButton.Text = "New face"
        NewFaceButton.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(12, 419)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(161, 19)
        CheckBox1.TabIndex = 57
        CheckBox1.Text = "Show face calibrate guide"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' ImportFaceButton
        ' 
        ImportFaceButton.Enabled = False
        ImportFaceButton.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        ImportFaceButton.Location = New Point(361, 280)
        ImportFaceButton.Name = "ImportFaceButton"
        ImportFaceButton.Size = New Size(155, 42)
        ImportFaceButton.TabIndex = 56
        ImportFaceButton.Text = "Import face"
        ImportFaceButton.UseVisualStyleBackColor = True
        ' 
        ' ExportFaceButton
        ' 
        ExportFaceButton.Enabled = False
        ExportFaceButton.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        ExportFaceButton.Location = New Point(522, 280)
        ExportFaceButton.Name = "ExportFaceButton"
        ExportFaceButton.Size = New Size(154, 42)
        ExportFaceButton.TabIndex = 55
        ExportFaceButton.Text = "Export face"
        ExportFaceButton.UseVisualStyleBackColor = True
        ' 
        ' DeleteFaceButton
        ' 
        DeleteFaceButton.Enabled = False
        DeleteFaceButton.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        DeleteFaceButton.ForeColor = Color.Red
        DeleteFaceButton.Location = New Point(522, 396)
        DeleteFaceButton.Name = "DeleteFaceButton"
        DeleteFaceButton.Size = New Size(154, 42)
        DeleteFaceButton.TabIndex = 54
        DeleteFaceButton.Text = "Delete face"
        DeleteFaceButton.UseVisualStyleBackColor = True
        ' 
        ' NewFaceCB
        ' 
        NewFaceCB.AutoSize = True
        NewFaceCB.Location = New Point(179, 419)
        NewFaceCB.Name = "NewFaceCB"
        NewFaceCB.Size = New Size(80, 19)
        NewFaceCB.TabIndex = 60
        NewFaceCB.Text = "New face?"
        NewFaceCB.UseVisualStyleBackColor = True
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.Filter = "Bitmap image|*.bmp|JPEG image|*.jpg;*.jpeg|PNG image|*.png"
        ' 
        ' GenderBox
        ' 
        GenderBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        GenderBox.FormattingEnabled = True
        GenderBox.Items.AddRange(New Object() {"Male", "Female", "??"})
        GenderBox.Location = New Point(146, 346)
        GenderBox.Name = "GenderBox"
        GenderBox.Size = New Size(121, 23)
        GenderBox.TabIndex = 63
        ' 
        ' AgeBox
        ' 
        AgeBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        AgeBox.FormattingEnabled = True
        AgeBox.Items.AddRange(New Object() {"Baby (up to 3 years)", "Child (4-9 years)", "Young (10-29 years)", "Adult (30-49 years)", "Adult (over 50 years)", "??"})
        AgeBox.Location = New Point(146, 301)
        AgeBox.Name = "AgeBox"
        AgeBox.Size = New Size(121, 23)
        AgeBox.TabIndex = 61
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(146, 283)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 15)
        Label5.TabIndex = 62
        Label5.Text = "Age:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Location = New Point(146, 328)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 15)
        Label6.TabIndex = 64
        Label6.Text = "Gender:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(146, 390)
        DateTimePicker1.MaxDate = New Date(2292, 4, 10, 23, 47, 16, 0)
        DateTimePicker1.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(157, 23)
        DateTimePicker1.TabIndex = 65
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(146, 372)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 15)
        Label1.TabIndex = 66
        Label1.Text = "Capture date:"
        ' 
        ' UFOEditor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(688, 450)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label1)
        Controls.Add(GenderBox)
        Controls.Add(AgeBox)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(NewFaceCB)
        Controls.Add(SwapFacesButton)
        Controls.Add(NewFaceButton)
        Controls.Add(CheckBox1)
        Controls.Add(ImportFaceButton)
        Controls.Add(ExportFaceButton)
        Controls.Add(DeleteFaceButton)
        Controls.Add(SelectedFaceBox)
        Controls.Add(FaceBox10)
        Controls.Add(FaceBox9)
        Controls.Add(FaceBox8)
        Controls.Add(FaceBox7)
        Controls.Add(FaceBox6)
        Controls.Add(FaceBox5)
        Controls.Add(FaceBox4)
        Controls.Add(FaceBox3)
        Controls.Add(FaceBox2)
        Controls.Add(FaceBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "UFOEditor"
        Text = "UFO Crew"
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
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents FaceBox10 As PictureBox
    Friend WithEvents FaceBox9 As PictureBox
    Friend WithEvents FaceBox8 As PictureBox
    Friend WithEvents FaceBox7 As PictureBox
    Friend WithEvents FaceBox6 As PictureBox
    Friend WithEvents FaceBox5 As PictureBox
    Friend WithEvents FaceBox4 As PictureBox
    Friend WithEvents FaceBox3 As PictureBox
    Friend WithEvents FaceBox2 As PictureBox
    Friend WithEvents FaceBox1 As PictureBox
    Friend WithEvents SelectedFaceBox As PictureBox
    Friend WithEvents SwapFacesButton As Button
    Friend WithEvents NewFaceButton As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ImportFaceButton As Button
    Friend WithEvents ExportFaceButton As Button
    Friend WithEvents DeleteFaceButton As Button
    Friend WithEvents NewFaceCB As CheckBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents GenderBox As ComboBox
    Friend WithEvents AgeBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
