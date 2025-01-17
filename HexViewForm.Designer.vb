<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HexViewForm
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
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        VScrollBar1 = New VScrollBar()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ToolStripComboBox1 = New ToolStripComboBox()
        SaveFileToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        CloseToolStripMenuItem = New ToolStripMenuItem()
        ColorDialog1 = New ColorDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Location = New Point(0, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(859, 465)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        VScrollBar1.Enabled = False
        VScrollBar1.Location = New Point(862, 24)
        VScrollBar1.Maximum = 10
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.Size = New Size(17, 465)
        VScrollBar1.TabIndex = 1
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(879, 24)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToolStripComboBox1, SaveFileToolStripMenuItem, ToolStripSeparator1, CloseToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ToolStripComboBox1
        ' 
        ToolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ToolStripComboBox1.Items.AddRange(New Object() {"Kbb.dat", "PhotoF00.dat", "PhotoF01.dat", "PhotoF02.dat", "PhotoF03.dat", "PhotoF04.dat", "PhotoF05.dat", "PhotoF06.dat", "PhotoF07.dat", "PhotoF08.dat", "PhotoF09.dat", "PhotoF10.dat", "PhotoF11.dat", "PhotoF12.dat", "PhotoF13.dat", "PhotoF14.dat", "PhotoF15.dat", "PhotoF16.dat", "PhotoF17.dat", "PhotoF18.dat", "PhotoF19.dat", "PhotoF20.dat", "PhotoF21.dat", "PhotoF22.dat", "PhotoF23.dat", "PhotoF24.dat", "PhotoF25.dat", "PhotoF26.dat", "PhotoF27.dat", "PhotoF28.dat", "PhotoF29.dat", "PhotoF30.dat", "PhotoF31.dat", "PhotoF32.dat", "PhotoF33.dat", "PhotoF34.dat", "PhotoF35.dat", "PhotoF36.dat", "PhotoF37.dat", "PhotoF38.dat", "PhotoF39.dat", "PhotoF40.dat", "PhotoF41.dat", "PhotoF42.dat", "PhotoF43.dat", "PhotoF44.dat", "PhotoF45.dat", "PhotoF46.dat", "PhotoF47.dat", "PhotoF48.dat", "PhotoP00.dat", "PhotoP01.dat", "PhotoP02.dat", "PhotoP03.dat", "PhotoP04.dat", "PhotoP05.dat", "PhotoP06.dat", "PhotoP07.dat", "PhotoP08.dat", "PhotoP09.dat"})
        ToolStripComboBox1.Name = "ToolStripComboBox1"
        ToolStripComboBox1.Size = New Size(121, 23)
        ToolStripComboBox1.ToolTipText = "Open file"
        ' 
        ' SaveFileToolStripMenuItem
        ' 
        SaveFileToolStripMenuItem.Image = My.Resources.Resources.Save_16x
        SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem"
        SaveFileToolStripMenuItem.Size = New Size(181, 22)
        SaveFileToolStripMenuItem.Text = "Save file"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(178, 6)
        ' 
        ' CloseToolStripMenuItem
        ' 
        CloseToolStripMenuItem.Image = My.Resources.Resources.Close_red_16x
        CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        CloseToolStripMenuItem.Size = New Size(181, 22)
        CloseToolStripMenuItem.Text = "Close"
        ' 
        ' ColorDialog1
        ' 
        ColorDialog1.FullOpen = True
        ' 
        ' HexViewForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(879, 532)
        Controls.Add(VScrollBar1)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "HexViewForm"
        Text = "HexViewForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents SaveFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
