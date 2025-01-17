<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImportFaceForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportFaceForm))
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        SelectImageButton = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        ResetImageTransformButton = New Button()
        ZoomPwr = New NumericUpDown()
        TrPwr = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        CheckBox1 = New CheckBox()
        FinishButton = New Button()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        AbortButton = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ZoomPwr, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrPwr, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(258, 258)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' SelectImageButton
        ' 
        SelectImageButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SelectImageButton.Location = New Point(12, 276)
        SelectImageButton.Name = "SelectImageButton"
        SelectImageButton.Size = New Size(258, 31)
        SelectImageButton.TabIndex = 1
        SelectImageButton.Text = "Select image..."
        SelectImageButton.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.Filter = "PNG image|*.png|Bitmap image|*.bmp|JPEG image|*.jpg;*.jpeg"
        ' 
        ' ResetImageTransformButton
        ' 
        ResetImageTransformButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ResetImageTransformButton.Location = New Point(12, 313)
        ResetImageTransformButton.Name = "ResetImageTransformButton"
        ResetImageTransformButton.Size = New Size(258, 31)
        ResetImageTransformButton.TabIndex = 2
        ResetImageTransformButton.Text = "Reset image transform"
        ResetImageTransformButton.UseVisualStyleBackColor = True
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
        ZoomPwr.TabIndex = 3
        ZoomPwr.TextAlign = HorizontalAlignment.Center
        ZoomPwr.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        TrPwr.TabIndex = 4
        TrPwr.TextAlign = HorizontalAlignment.Center
        TrPwr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Pixel)
        Label1.Location = New Point(12, 350)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 23)
        Label1.TabIndex = 5
        Label1.Text = "Zoom Power"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Pixel)
        Label2.Location = New Point(12, 379)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 23)
        Label2.TabIndex = 6
        Label2.Text = "Translate Power"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(12, 440)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(161, 19)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Show face calibrate guide"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' FinishButton
        ' 
        FinishButton.Enabled = False
        FinishButton.Location = New Point(195, 437)
        FinishButton.Name = "FinishButton"
        FinishButton.Size = New Size(75, 23)
        FinishButton.TabIndex = 8
        FinishButton.Text = "Finish"
        FinishButton.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Pixel)
        Label3.Location = New Point(12, 408)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 23)
        Label3.TabIndex = 9
        Label3.Text = "Interpolation"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Default", "Low", "High", "Bilinear", "Bicubic", "Nearest Neighbor", "High Quality Bilinear", "High Quality Bicubic"})
        ComboBox1.Location = New Point(150, 408)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(120, 23)
        ComboBox1.TabIndex = 10
        ComboBox1.Text = "Default"
        ' 
        ' AbortButton
        ' 
        AbortButton.Location = New Point(195, 466)
        AbortButton.Name = "AbortButton"
        AbortButton.Size = New Size(75, 23)
        AbortButton.TabIndex = 11
        AbortButton.Text = "Abort"
        AbortButton.UseVisualStyleBackColor = True
        ' 
        ' ImportFaceForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(282, 501)
        ControlBox = False
        Controls.Add(AbortButton)
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
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "ImportFaceForm"
        Text = "Import face"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ZoomPwr, ComponentModel.ISupportInitialize).EndInit()
        CType(TrPwr, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SelectImageButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ResetImageTransformButton As Button
    Friend WithEvents ZoomPwr As NumericUpDown
    Friend WithEvents TrPwr As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents FinishButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents AbortButton As Button
End Class
