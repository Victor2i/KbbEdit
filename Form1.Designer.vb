<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewSaveToolStripMenuItem = New ToolStripMenuItem()
        OpenFileToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        QuitToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        LinksToolStripMenuItem = New ToolStripMenuItem()
        HexViewToolStripMenuItem = New ToolStripMenuItem()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, AboutToolStripMenuItem, HexViewToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(238, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewSaveToolStripMenuItem, OpenFileToolStripMenuItem, SaveToolStripMenuItem, QuitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewSaveToolStripMenuItem
        ' 
        NewSaveToolStripMenuItem.Image = My.Resources.Resources.NewFile_16x
        NewSaveToolStripMenuItem.Name = "NewSaveToolStripMenuItem"
        NewSaveToolStripMenuItem.Size = New Size(129, 22)
        NewSaveToolStripMenuItem.Text = "New save"
        ' 
        ' OpenFileToolStripMenuItem
        ' 
        OpenFileToolStripMenuItem.Image = My.Resources.Resources.OpenFolder_16x
        OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        OpenFileToolStripMenuItem.Size = New Size(129, 22)
        OpenFileToolStripMenuItem.Text = "Open save"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Image = My.Resources.Resources.Save_16x
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(129, 22)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' QuitToolStripMenuItem
        ' 
        QuitToolStripMenuItem.Image = My.Resources.Resources.Close_red_16x
        QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        QuitToolStripMenuItem.Size = New Size(129, 22)
        QuitToolStripMenuItem.Text = "Quit"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem, LinksToolStripMenuItem})
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(52, 20)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.Image = My.Resources.Resources.Question_16x
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(101, 22)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' LinksToolStripMenuItem
        ' 
        LinksToolStripMenuItem.Image = My.Resources.Resources.LinkVertical_16x
        LinksToolStripMenuItem.Name = "LinksToolStripMenuItem"
        LinksToolStripMenuItem.Size = New Size(101, 22)
        LinksToolStripMenuItem.Text = "Links"
        ' 
        ' HexViewToolStripMenuItem
        ' 
        HexViewToolStripMenuItem.Name = "HexViewToolStripMenuItem"
        HexViewToolStripMenuItem.Size = New Size(67, 20)
        HexViewToolStripMenuItem.Text = "Hex view"
        ' 
        ' Button1
        ' 
        Button1.Enabled = False
        Button1.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(12, 27)
        Button1.Name = "Button1"
        Button1.Size = New Size(214, 52)
        Button1.TabIndex = 1
        Button1.Text = "Score editor"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Enabled = False
        Button2.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(12, 85)
        Button2.Name = "Button2"
        Button2.Size = New Size(214, 52)
        Button2.TabIndex = 2
        Button2.Text = "Face editor"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Enabled = False
        Button3.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(12, 143)
        Button3.Name = "Button3"
        Button3.Size = New Size(214, 52)
        Button3.TabIndex = 3
        Button3.Text = "Other"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' FolderBrowserDialog1
        ' 
        FolderBrowserDialog1.Description = "Select the folder where you placed your Kbb.dat file."
        FolderBrowserDialog1.ShowNewFolderButton = False
        FolderBrowserDialog1.UseDescriptionForTitle = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(238, 207)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form1"
        Text = "KbbEdit"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents LinksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HexViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewSaveToolStripMenuItem As ToolStripMenuItem
End Class
