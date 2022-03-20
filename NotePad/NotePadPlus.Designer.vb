<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NotePadPlus
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotePadPlus))
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitProgramMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoOrRedoMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutTextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyTextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteTextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.StatusBarLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NotePanel = New System.Windows.Forms.Panel()
        Me.Note = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.NewFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.全选ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuBar.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        Me.NotePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuBar
        '
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.SettingMenu})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuBar.Size = New System.Drawing.Size(542, 30)
        Me.MenuBar.TabIndex = 1
        Me.MenuBar.Text = "MenuStrip1"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewFileMenu, Me.OpenFileMenu, Me.SaveFileMenu, Me.ToolStripMenuItem1, Me.ExitProgramMenu})
        Me.FileMenu.Font = New System.Drawing.Font("微软雅黑", 7.8!)
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(49, 24)
        Me.FileMenu.Text = "文件"
        '
        'NewFileMenu
        '
        Me.NewFileMenu.Name = "NewFileMenu"
        Me.NewFileMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewFileMenu.Size = New System.Drawing.Size(224, 26)
        Me.NewFileMenu.Text = "新建"
        Me.NewFileMenu.ToolTipText = "新建文本文件"
        '
        'OpenFileMenu
        '
        Me.OpenFileMenu.Name = "OpenFileMenu"
        Me.OpenFileMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenFileMenu.Size = New System.Drawing.Size(224, 26)
        Me.OpenFileMenu.Text = "打开"
        Me.OpenFileMenu.ToolTipText = "打开文本文件"
        '
        'SaveFileMenu
        '
        Me.SaveFileMenu.Name = "SaveFileMenu"
        Me.SaveFileMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveFileMenu.Size = New System.Drawing.Size(224, 26)
        Me.SaveFileMenu.Text = "保存"
        Me.SaveFileMenu.ToolTipText = "保存文本文件"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(221, 6)
        '
        'ExitProgramMenu
        '
        Me.ExitProgramMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ExitProgramMenu.Name = "ExitProgramMenu"
        Me.ExitProgramMenu.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ExitProgramMenu.Size = New System.Drawing.Size(224, 26)
        Me.ExitProgramMenu.Text = "退出"
        Me.ExitProgramMenu.ToolTipText = "关闭应用程序"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoOrRedoMenu, Me.CutTextMenu, Me.CopyTextMenu, Me.PasteTextMenu, Me.ToolStripMenuItem2, Me.全选ToolStripMenuItem})
        Me.EditMenu.Font = New System.Drawing.Font("微软雅黑", 7.8!)
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(49, 24)
        Me.EditMenu.Text = "编辑"
        '
        'UndoOrRedoMenu
        '
        Me.UndoOrRedoMenu.Name = "UndoOrRedoMenu"
        Me.UndoOrRedoMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoOrRedoMenu.Size = New System.Drawing.Size(224, 26)
        Me.UndoOrRedoMenu.Text = "撤销"
        Me.UndoOrRedoMenu.ToolTipText = "撤销文本框的文字"
        '
        'CutTextMenu
        '
        Me.CutTextMenu.Name = "CutTextMenu"
        Me.CutTextMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutTextMenu.Size = New System.Drawing.Size(224, 26)
        Me.CutTextMenu.Text = "剪切"
        Me.CutTextMenu.ToolTipText = "剪切文本框上的文字"
        '
        'CopyTextMenu
        '
        Me.CopyTextMenu.Name = "CopyTextMenu"
        Me.CopyTextMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyTextMenu.Size = New System.Drawing.Size(224, 26)
        Me.CopyTextMenu.Text = "复制"
        Me.CopyTextMenu.ToolTipText = "复制文本框上的文字"
        '
        'PasteTextMenu
        '
        Me.PasteTextMenu.Name = "PasteTextMenu"
        Me.PasteTextMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteTextMenu.Size = New System.Drawing.Size(224, 26)
        Me.PasteTextMenu.Text = "粘贴"
        Me.PasteTextMenu.ToolTipText = "粘贴文本框上的文字"
        '
        'SettingMenu
        '
        Me.SettingMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferencesMenu, Me.关于ToolStripMenuItem})
        Me.SettingMenu.Font = New System.Drawing.Font("微软雅黑", 7.8!)
        Me.SettingMenu.Name = "SettingMenu"
        Me.SettingMenu.Size = New System.Drawing.Size(49, 24)
        Me.SettingMenu.Text = "设置"
        '
        'PreferencesMenu
        '
        Me.PreferencesMenu.Name = "PreferencesMenu"
        Me.PreferencesMenu.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PreferencesMenu.Size = New System.Drawing.Size(224, 26)
        Me.PreferencesMenu.Text = "首选项"
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.DefaultExt = "txt"
        Me.SaveFileDialog.FileName = "新建文件"
        Me.SaveFileDialog.Filter = "文本文件|*.txt|所有文件|*.*"
        Me.SaveFileDialog.Title = "保存文件"
        '
        'StatusBar
        '
        Me.StatusBar.Font = New System.Drawing.Font("微软雅黑", 7.8!)
        Me.StatusBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBarLabel})
        Me.StatusBar.Location = New System.Drawing.Point(0, 778)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(542, 25)
        Me.StatusBar.TabIndex = 2
        Me.StatusBar.Text = "StatusStrip1"
        '
        'StatusBarLabel
        '
        Me.StatusBarLabel.Name = "StatusBarLabel"
        Me.StatusBarLabel.Size = New System.Drawing.Size(68, 19)
        Me.StatusBarLabel.Text = "StatusBar"
        '
        'NotePanel
        '
        Me.NotePanel.AutoScroll = True
        Me.NotePanel.Controls.Add(Me.Note)
        Me.NotePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NotePanel.Location = New System.Drawing.Point(0, 30)
        Me.NotePanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NotePanel.Name = "NotePanel"
        Me.NotePanel.Size = New System.Drawing.Size(542, 748)
        Me.NotePanel.TabIndex = 3
        '
        'Note
        '
        Me.Note.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Note.Location = New System.Drawing.Point(0, 0)
        Me.Note.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Note.Multiline = True
        Me.Note.Name = "Note"
        Me.Note.Size = New System.Drawing.Size(542, 748)
        Me.Note.TabIndex = 1
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'NewFileDialog
        '
        Me.NewFileDialog.DefaultExt = "txt"
        Me.NewFileDialog.FileName = "新建文件"
        Me.NewFileDialog.Filter = "文本文件|*.txt|所有文件|*.*"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(221, 6)
        '
        '全选ToolStripMenuItem
        '
        Me.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem"
        Me.全选ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.全选ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.全选ToolStripMenuItem.Text = "全选"
        '
        'NotePadPlus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 803)
        Me.Controls.Add(Me.NotePanel)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.MenuBar)
        Me.Font = New System.Drawing.Font("微软雅黑", 7.8!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuBar
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NotePadPlus"
        Me.Text = "NotePad Plus ++"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.NotePanel.ResumeLayout(False)
        Me.NotePanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuBar As MenuStrip
    Friend WithEvents FileMenu As ToolStripMenuItem
    Friend WithEvents OpenFileMenu As ToolStripMenuItem
    Friend WithEvents SaveFileMenu As ToolStripMenuItem
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents NewFileMenu As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExitProgramMenu As ToolStripMenuItem
    Friend WithEvents EditMenu As ToolStripMenuItem
    Friend WithEvents UndoOrRedoMenu As ToolStripMenuItem
    Friend WithEvents CutTextMenu As ToolStripMenuItem
    Friend WithEvents CopyTextMenu As ToolStripMenuItem
    Friend WithEvents PasteTextMenu As ToolStripMenuItem
    Friend WithEvents StatusBar As StatusStrip
    Friend WithEvents StatusBarLabel As ToolStripStatusLabel
    Friend WithEvents SettingMenu As ToolStripMenuItem
    Friend WithEvents PreferencesMenu As ToolStripMenuItem
    Friend WithEvents NotePanel As Panel
    Friend WithEvents Note As TextBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents NewFileDialog As SaveFileDialog
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents 全选ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As ToolStripMenuItem
End Class
