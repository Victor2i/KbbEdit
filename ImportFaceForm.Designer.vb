﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportFaceForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SelectImageButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ResetImageTransformButton = New System.Windows.Forms.Button()
        Me.ZoomPwr = New System.Windows.Forms.NumericUpDown()
        Me.TrPwr = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.FinishButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AbortButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZoomPwr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrPwr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 258)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'SelectImageButton
        '
        Me.SelectImageButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SelectImageButton.Location = New System.Drawing.Point(12, 276)
        Me.SelectImageButton.Name = "SelectImageButton"
        Me.SelectImageButton.Size = New System.Drawing.Size(258, 31)
        Me.SelectImageButton.TabIndex = 1
        Me.SelectImageButton.Text = "Select image..."
        Me.SelectImageButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Bitmap image|*.bmp|JPEG image|*.jpg;*.jpeg|PNG image|*.png"
        '
        'ResetImageTransformButton
        '
        Me.ResetImageTransformButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResetImageTransformButton.Location = New System.Drawing.Point(12, 313)
        Me.ResetImageTransformButton.Name = "ResetImageTransformButton"
        Me.ResetImageTransformButton.Size = New System.Drawing.Size(258, 31)
        Me.ResetImageTransformButton.TabIndex = 2
        Me.ResetImageTransformButton.Text = "Reset image transform"
        Me.ResetImageTransformButton.UseVisualStyleBackColor = True
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
        Me.ZoomPwr.TabIndex = 3
        Me.ZoomPwr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ZoomPwr.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        Me.TrPwr.TabIndex = 4
        Me.TrPwr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TrPwr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.Location = New System.Drawing.Point(12, 350)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Zoom Power"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.Location = New System.Drawing.Point(12, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Translate Power"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 440)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(161, 19)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Show face calibrate guide"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FinishButton
        '
        Me.FinishButton.Enabled = False
        Me.FinishButton.Location = New System.Drawing.Point(195, 437)
        Me.FinishButton.Name = "FinishButton"
        Me.FinishButton.Size = New System.Drawing.Size(75, 23)
        Me.FinishButton.TabIndex = 8
        Me.FinishButton.Text = "Finish"
        Me.FinishButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.Location = New System.Drawing.Point(12, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Interpolation"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Default", "Low", "High", "Bilinear", "Bicubic", "Nearest Neighbor", "High Quality Bilinear", "High Quality Bicubic"})
        Me.ComboBox1.Location = New System.Drawing.Point(150, 408)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(120, 23)
        Me.ComboBox1.TabIndex = 10
        Me.ComboBox1.Text = "Default"
        '
        'AbortButton
        '
        Me.AbortButton.Location = New System.Drawing.Point(195, 466)
        Me.AbortButton.Name = "AbortButton"
        Me.AbortButton.Size = New System.Drawing.Size(75, 23)
        Me.AbortButton.TabIndex = 11
        Me.AbortButton.Text = "Abort"
        Me.AbortButton.UseVisualStyleBackColor = True
        '
        'ImportFaceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 501)
        Me.ControlBox = False
        Me.Controls.Add(Me.AbortButton)
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
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ImportFaceForm"
        Me.Text = "Import face"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZoomPwr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrPwr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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