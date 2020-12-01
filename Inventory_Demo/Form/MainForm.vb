Imports System.ComponentModel
Namespace UIForm
    Public Class MainForm
        Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "
        Public Sub New()
            MyBase.New()
            'This call is required by the Windows Form Designer.
            InitializeComponent()
            'Add any initialization after the InitializeComponent() call
        End Sub
        'Form overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.SuspendLayout()
            '
            'MainForm
            '
            Me.ClientSize = New System.Drawing.Size(292, 266)
            Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MainForm"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.ResumeLayout(False)

        End Sub
#End Region
        Private Sub SaveConfigaration()
            Dim _SaveText As String = String.Empty
            ' Save Into Exe

            My.Settings.InstallDate = DateTime.Today
            My.Settings.ExpaireDate = clsFeature.ExpaireDate(My.Settings.InstallDate, 7)
            My.Settings.LastDate = DateTime.Now
            My.Settings.CPUSerialNumber = clsRegistration.CPUSerialNumber
            My.Settings.Save()

            'Save Into WinReg
            _SaveText = clsRegistration.Encrypt(My.Settings.InstallDate & vbNewLine & My.Settings.ExpaireDate & vbNewLine & My.Settings.LastDate &
            vbNewLine & My.Settings.CPUSerialNumber & vbNewLine & My.Settings.InstallKey & vbNewLine & My.Settings.RegUsername & vbNewLine & My.Settings.RegPhone &
            vbNewLine & My.Settings.RegEmail)
            clsRegistration.InventoryRegistryValue = _SaveText
            _SaveText = String.Empty
        End Sub
        Private Sub RunTrails()
            ' Registry Values
            Dim _AppKeyPath As String = Application.StartupPath & "\AppKey.softkey"
            Dim _SaveText As String = String.Empty
            Dim _Vales As String() = Nothing

            If My.Settings.InstallKey = "Registered Version" Then
                ' If Register skip trails
                If ucMenuStyle Is Nothing Then ucMenuStyle = New UIForm.MenuStyle With {.Dock = DockStyle.Fill}
                ucMenuStyle.TStrpMItm_Access.PerformClick()
                Me.Controls.Add(ucMenuStyle)
            Else
                ' Get the value from registry
                If String.IsNullOrWhiteSpace(clsRegistration.InventoryRegistryValue) AndAlso String.IsNullOrWhiteSpace(My.Settings.CPUSerialNumber) Then
                    ' Insert Trails Setup

                    SaveConfigaration()
                    Application.Restart()
                ElseIf Not String.IsNullOrWhiteSpace(clsRegistration.InventoryRegistryValue) AndAlso String.IsNullOrWhiteSpace(My.Settings.CPUSerialNumber) Then
                    ' Get And Set Vales

                    ' Overwrite all
                    ' Exe empty fill vales
                    ' Restore Values (Registry to exe)

                    _Vales = clsRegistration.Decrypt(clsRegistration.InventoryRegistryValue).Split(vbNewLine)
                    Dim _Enter As String = String.Empty
                    _Enter = _Vales(1).Substring(0, 1)
                    My.Settings.InstallDate = _Vales(0).Replace(_Enter, "")
                    My.Settings.ExpaireDate = _Vales(1).Replace(_Enter, "")
                    My.Settings.LastDate = _Vales(2).Replace(_Enter, "")
                    My.Settings.CPUSerialNumber = _Vales(3).Replace(_Enter, "")
                    My.Settings.InstallKey = _Vales(4).Replace(_Enter, "")
                    My.Settings.Save()
                    Application.Restart()
                ElseIf String.IsNullOrWhiteSpace(clsRegistration.InventoryRegistryValue) AndAlso Not String.IsNullOrWhiteSpace(My.Settings.CPUSerialNumber) Then
                    ' Overwrite all
                    ' Registry empty fill vales
                    ' Restore Values (Exe to registry)

                    'Save Into WinReg
                    _SaveText = clsRegistration.Encrypt(My.Settings.InstallDate & vbNewLine & My.Settings.ExpaireDate & vbNewLine & My.Settings.LastDate &
                    vbNewLine & My.Settings.CPUSerialNumber & vbNewLine & My.Settings.InstallKey & vbNewLine & My.Settings.RegUsername & vbNewLine & My.Settings.RegPhone &
                    vbNewLine & My.Settings.RegEmail)
                    clsRegistration.InventoryRegistryValue = _SaveText
                    Application.Restart()
                Else

                    ' Register and run trails
                    If My.Computer.FileSystem.FileExists(_AppKeyPath) Then
                        _Vales = clsRegistration.Decrypt(My.Computer.FileSystem.ReadAllText(_AppKeyPath)).Split(vbNewLine)
                        Dim _Enter As String = String.Empty
                        _Enter = _Vales(1).Substring(0, 1)
                        If Val(My.Settings.CPUSerialNumber) = Val(_Vales(3)) Then
                            My.Settings.InstallKey = "Registered Version"
                            My.Settings.RegUsername = _Vales(0).Replace(_Enter, "")
                            My.Settings.RegPhone = _Vales(1).Replace(_Enter, "")
                            My.Settings.RegEmail = _Vales(2).Replace(_Enter, "")
                            My.Settings.Save()
                            SaveConfigaration()
                            _Enter = String.Empty
                            Application.Restart()
                        End If
                    Else
                        If DateTime.Now >= My.Settings.LastDate Then

                            ' Run Trails
                            ' Before run trails save dateandtime every time
                            My.Settings.LastDate = DateTime.Now
                            My.Settings.Save()

                            If clsFeature.TrailDaysLeft(DateTime.Today, My.Settings.ExpaireDate).Days <= 7 AndAlso clsFeature.TrailDaysLeft(DateTime.Today, My.Settings.ExpaireDate).Days >= 1 Then
                                If ucMenuStyle Is Nothing Then ucMenuStyle = New UIForm.MenuStyle With {.Dock = DockStyle.Fill}
                                ucMenuStyle.TStrpMItm_Access.PerformClick()
                                Me.Controls.Add(ucMenuStyle)
                            Else
                                If ucMenuStyle Is Nothing Then ucMenuStyle = New UIForm.MenuStyle With {.Dock = DockStyle.Fill}
                                ucMenuStyle.TStrpMItm_Register.PerformClick()
                                Me.Controls.Add(ucMenuStyle)
                            End If
                        Else
                            If ucMenuStyle Is Nothing Then ucMenuStyle = New UIForm.MenuStyle With {.Dock = DockStyle.Fill}
                            ucMenuStyle.TStrpMItm_Register.PerformClick()
                            Me.Controls.Add(ucMenuStyle)
                        End If
                    End If
                End If
            End If
            _SaveText = String.Empty
            _Vales = Nothing
        End Sub
        Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
            Application.Exit()
        End Sub
        Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            '> RunTrails

            RunTrails()

            '> RunTrails
            '> Reset

            'My.Settings.CPUSerialNumber = ""
            'My.Settings.InstallKey = ""
            'My.Settings.RegUsername = ""
            'My.Settings.RegPhone = ""
            'My.Settings.RegEmail = ""
            'My.Settings.Save()
            'clsRegistration.DeleteInventoryRegistryValue()

            '> Reset
        End Sub
    End Class
End Namespace