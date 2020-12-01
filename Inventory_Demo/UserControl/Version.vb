Imports System.ComponentModel
Namespace UIForm
' Build Action Embedded Resource
<ToolboxBitmap(GetType(Version), "Version.ico"), ToolboxItem(False)>
Public Class Version
Inherits UserControl
#Region " Component Designer generated code "
Public Sub New()
MyBase.New()
' This call is required by the Component Designer.
InitializeComponent()
'Add any initialization after the InitializeComponent() call
' This draws the control whenever it is resized
SetStyle(ControlStyles.ResizeRedraw, True)
' This supports mouse movement such as the mouse wheel
SetStyle(ControlStyles.UserMouse, True)
' This allows the control to be transparent
SetStyle(ControlStyles.SupportsTransparentBackColor, True)
' This helps with drawing the control so that it doesn't flicker
Me.SetStyle(ControlStyles.DoubleBuffer _
Or ControlStyles.UserPaint _
Or ControlStyles.AllPaintingInWmPaint,
True)
' This updates the styles
Me.UpdateStyles()
' Sets the hover time to 30 milliseconds. This is used
' to trigger the control to change the backcolor back to the
' original value due to the mouse no longer being over
' the control. 
'
' The time is used because it's more reliable than using the
' MouseLeave or MouseEnter events, which depending on the speed
' of the mouse, may or may not get fired.
End Sub
'Control overrides dispose to clean up the component list.
Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
If disposing Then
If Not (components Is Nothing) Then
components.Dispose()
End If
End If
MyBase.Dispose(disposing)
End Sub

Friend WithEvents Pnl_Top As Panel
Friend WithEvents Lbl_Header As Label
Friend WithEvents Pnl_Bottom As Panel
Friend WithEvents Btn_Exit As Button
Friend WithEvents Pic_Login As PictureBox
Friend WithEvents Lbl_Info As Label
'Required by the Control Designer
Private components As IContainer
' NOTE: The following procedure is required by the Component Designer
' It can be modified using the Component Designer.Do not modify it
' using the code editor.
<DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Version))
            Me.Pnl_Top = New System.Windows.Forms.Panel()
            Me.Lbl_Header = New System.Windows.Forms.Label()
            Me.Pnl_Bottom = New System.Windows.Forms.Panel()
            Me.Btn_Exit = New System.Windows.Forms.Button()
            Me.Pic_Login = New System.Windows.Forms.PictureBox()
            Me.Lbl_Info = New System.Windows.Forms.Label()
            Me.Pnl_Top.SuspendLayout()
            Me.Pnl_Bottom.SuspendLayout()
            CType(Me.Pic_Login, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Pnl_Top
            '
            Me.Pnl_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.Pnl_Top.BackgroundImage = CType(resources.GetObject("Pnl_Top.BackgroundImage"), System.Drawing.Image)
            Me.Pnl_Top.Controls.Add(Me.Lbl_Header)
            Me.Pnl_Top.Dock = System.Windows.Forms.DockStyle.Top
            Me.Pnl_Top.Location = New System.Drawing.Point(0, 0)
            Me.Pnl_Top.Name = "Pnl_Top"
            Me.Pnl_Top.Size = New System.Drawing.Size(663, 48)
            Me.Pnl_Top.TabIndex = 62
            '
            'Lbl_Header
            '
            Me.Lbl_Header.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Header.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Lbl_Header.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Header.ForeColor = System.Drawing.Color.White
            Me.Lbl_Header.Image = CType(resources.GetObject("Lbl_Header.Image"), System.Drawing.Image)
            Me.Lbl_Header.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Lbl_Header.Location = New System.Drawing.Point(0, 0)
            Me.Lbl_Header.Name = "Lbl_Header"
            Me.Lbl_Header.Size = New System.Drawing.Size(663, 48)
            Me.Lbl_Header.TabIndex = 28
            Me.Lbl_Header.Text = "       Version !!!"
            Me.Lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Pnl_Bottom
            '
            Me.Pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.Pnl_Bottom.BackgroundImage = CType(resources.GetObject("Pnl_Bottom.BackgroundImage"), System.Drawing.Image)
            Me.Pnl_Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Pnl_Bottom.Controls.Add(Me.Btn_Exit)
            Me.Pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Pnl_Bottom.Location = New System.Drawing.Point(0, 285)
            Me.Pnl_Bottom.Name = "Pnl_Bottom"
            Me.Pnl_Bottom.Size = New System.Drawing.Size(663, 48)
            Me.Pnl_Bottom.TabIndex = 75
            '
            'Btn_Exit
            '
            Me.Btn_Exit.BackgroundImage = CType(resources.GetObject("Btn_Exit.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Right
            Me.Btn_Exit.FlatAppearance.BorderSize = 0
            Me.Btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Exit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Exit.ForeColor = System.Drawing.Color.White
            Me.Btn_Exit.Image = CType(resources.GetObject("Btn_Exit.Image"), System.Drawing.Image)
            Me.Btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Exit.Location = New System.Drawing.Point(573, 0)
            Me.Btn_Exit.Name = "Btn_Exit"
            Me.Btn_Exit.Size = New System.Drawing.Size(90, 48)
            Me.Btn_Exit.TabIndex = 6
            Me.Btn_Exit.Text = "EXIT"
            Me.Btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Btn_Exit.UseVisualStyleBackColor = True
            '
            'Pic_Login
            '
            Me.Pic_Login.BackColor = System.Drawing.Color.Transparent
            Me.Pic_Login.Dock = System.Windows.Forms.DockStyle.Left
            Me.Pic_Login.Image = CType(resources.GetObject("Pic_Login.Image"), System.Drawing.Image)
            Me.Pic_Login.Location = New System.Drawing.Point(0, 48)
            Me.Pic_Login.Name = "Pic_Login"
            Me.Pic_Login.Size = New System.Drawing.Size(176, 237)
            Me.Pic_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.Pic_Login.TabIndex = 76
            Me.Pic_Login.TabStop = False
            '
            'Lbl_Info
            '
            Me.Lbl_Info.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Lbl_Info.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Info.Location = New System.Drawing.Point(176, 48)
            Me.Lbl_Info.Name = "Lbl_Info"
            Me.Lbl_Info.Size = New System.Drawing.Size(487, 237)
            Me.Lbl_Info.TabIndex = 77
            Me.Lbl_Info.Text = "Information"
            Me.Lbl_Info.UseCompatibleTextRendering = True
            '
            'Version
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.Controls.Add(Me.Lbl_Info)
            Me.Controls.Add(Me.Pic_Login)
            Me.Controls.Add(Me.Pnl_Bottom)
            Me.Controls.Add(Me.Pnl_Top)
            Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.White
            Me.Name = "Version"
            Me.Size = New System.Drawing.Size(663, 333)
            Me.Pnl_Top.ResumeLayout(False)
            Me.Pnl_Bottom.ResumeLayout(False)
            CType(Me.Pic_Login, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region
        <DefaultValue(False)>
Public Property SizeLock As Boolean
Public Property FormTitle As String
Protected Overrides Sub SetBoundsCore(ByVal x As Integer, ByVal y As Integer, ByVal [width] As Integer, ByVal height As Integer, ByVal specified As System.Windows.Forms.BoundsSpecified)
MyBase.SetBoundsCore(x, y, 663, 333, specified)
End Sub
Private Sub GetVersion()
Dim _Info As String = String.Empty
_Info = "Application Title: {0}" & vbNewLine &
"Product Name: {1}" & vbNewLine &
"Product Version: {2}" & vbNewLine &
"Copyright: {3}" & vbNewLine &
"Company Name : {4}" & vbNewLine &
"Description" & vbNewLine & "{5}"
Dim _AppTitle As String = String.Empty
Dim _TrailsInfo As String = String.Empty
Dim _RegisterInfo As String = String.Empty
Dim _AppInfo As String = String.Empty
If My.Application.Info.Title <> "" Then
_AppTitle = My.Application.Info.Title
Else
_AppTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
End If
_TrailsInfo = "Install Date: {0}" & vbNewLine &
"Expaire Date: {1}" & vbNewLine &
"Trails 7 Days And Remaining {2} Days"
_RegisterInfo = "Application: {0}" & vbNewLine &
"Register Username: {1}" & vbNewLine &
"User Phone Number: {2}" & vbNewLine &
"User Email Address: {3}"
If String.IsNullOrWhiteSpace(My.Settings.InstallKey) Then
_AppInfo = String.Format(_TrailsInfo, My.Settings.InstallDate, My.Settings.ExpaireDate,
clsFeature.TrailDaysLeft(DateTime.Today, My.Settings.ExpaireDate).Days)
Else
_AppInfo = String.Format(_RegisterInfo, My.Settings.InstallKey, My.Settings.RegUsername, My.Settings.RegPhone, My.Settings.RegEmail)
End If
Lbl_Info.Text = String.Format(_Info, _AppTitle, My.Application.Info.ProductName, My.Application.Info.Version.ToString,
My.Application.Info.Copyright, My.Application.Info.CompanyName & vbNewLine & _AppInfo & vbNewLine, My.Application.Info.Description)
End Sub

Private Sub Version_Load(sender As Object, e As EventArgs) Handles MyBase.Load
FormTitle = "Version"
clsFeature.SizeLock(SizeLock, ParentForm, FormTitle, Me)
GetVersion()
End Sub
Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
Me.ParentForm.Close()
End Sub
Private Sub Version_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
ucVersion = Nothing
End Sub
End Class
End Namespace