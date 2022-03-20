Public Class NotePadPlus
    Private Sub SaveFileMenu_Click(sender As Object, e As EventArgs) Handles SaveFileMenu.Click
        SaveFileDialog.ShowDialog()
    End Sub

    Private Sub SaveFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog.FileOk
        If My.Computer.FileSystem.DirectoryExists(SaveFileDialog.FileName) Then
            My.Computer.FileSystem.DeleteFile(SaveFileDialog.FileName)
        End If
        Text = "NotePad Plus ++"
        My.Computer.FileSystem.WriteAllText(SaveFileDialog.FileName, Note.Text, True)
    End Sub

    Private Sub NewFileMenu_Click(sender As Object, e As EventArgs) Handles NewFileMenu.Click
        NewFileDialog.ShowDialog()
        Note.Clear()
    End Sub

    Private Sub ExitProgramMenu_Click(sender As Object, e As EventArgs) Handles ExitProgramMenu.Click
        Close()
    End Sub

    Private Sub FileMenu_Click(sender As Object, e As EventArgs) Handles FileMenu.Click

    End Sub

    Private Sub UndoOrRedoMenu_Click(sender As Object, e As EventArgs) Handles UndoOrRedoMenu.Click
        Note.Undo()
    End Sub

    Private Sub CutTextMenu_Click(sender As Object, e As EventArgs) Handles CutTextMenu.Click
        Note.Cut()
    End Sub

    Private Sub CopyTextMenu_Click(sender As Object, e As EventArgs) Handles CopyTextMenu.Click
        Note.Copy()
    End Sub

    Private Sub PasteTextMenu_Click(sender As Object, e As EventArgs) Handles PasteTextMenu.Click
        Note.Paste()
    End Sub

    Private Sub Note_Enter(sender As Object, e As EventArgs) Handles Note.Enter
        StatusBarLabel.Text = "笔记本区：编辑文本"
    End Sub

    Private Sub Note_Leave(sender As Object, e As EventArgs) Handles Note.Leave
        StatusBarLabel.Text = ""
    End Sub

    Private Sub StatusBar_Enter(sender As Object, e As EventArgs) Handles StatusBar.Enter
        StatusBarLabel.Text = "状态栏：显示状态事件"
    End Sub

    Private Sub StatusBar_Leave(sender As Object, e As EventArgs) Handles StatusBar.Leave
        StatusBarLabel.Text = ""
    End Sub

    Private Sub PreferencesMenu_Click(sender As Object, e As EventArgs) Handles PreferencesMenu.Click
        PreferencesDialog.Show()
    End Sub

    Private Sub OpenFileMenu_Click(sender As Object, e As EventArgs) Handles OpenFileMenu.Click
        OpenFileDialog.ShowDialog()
    End Sub

    Private Sub OpenFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText(OpenFileDialog.FileName, System.Text.Encoding.UTF8)
        Text = "NotePad Plus ++"
        Note.Text = fileReader

    End Sub

    Private Sub NewFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NewFileDialog.FileOk
        If My.Computer.FileSystem.DirectoryExists(NewFileDialog.FileName) Then
            My.Computer.FileSystem.DeleteFile(NewFileDialog.FileName)
        End If
        Text = "NotePad Plus ++"
        My.Computer.FileSystem.WriteAllText(NewFileDialog.FileName, "", True)
    End Sub

    Private Sub NotePadPlus_Load(sender As Object, e As EventArgs) Handles Note.TextChanged
        Text = "*NotePad Plus ++"
    End Sub

    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub 全选ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 全选ToolStripMenuItem.Click
        Note.SelectAll()
    End Sub
End Class