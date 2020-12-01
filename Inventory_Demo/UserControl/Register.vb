Imports System.ComponentModel
Namespace UIForm
    ' Build Action Embedded Resource
    <ToolboxBitmap(GetType(Register), "Register.ico"), ToolboxItem(False)>
    Public Class Register
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
        Friend WithEvents Btn_Make_Id As Button
        Friend WithEvents Btn_Exit As Button
        Friend WithEvents Pic_Login As PictureBox
        Friend WithEvents Lbl_Notice As Label
        Friend WithEvents Lbl_Name As Label
        Friend WithEvents Txt_Name As TextBox
        Friend WithEvents Lbl_Phone As Label
        Friend WithEvents Txt_Phone As TextBox
        Friend WithEvents Lbl_Email As Label
        Friend WithEvents Txt_Email As TextBox
        Friend WithEvents Lbl_Start1 As Label
        Friend WithEvents Lbl_Start2 As Label
        Friend WithEvents Lbl_Start3 As Label
        Friend WithEvents Lbl_Start_Info As Label
        Friend WithEvents Lbl_Contact As Label
        'Required by the Control Designer
        Private components As IContainer
        ' NOTE: The following procedure is required by the Component Designer
        ' It can be modified using the Component Designer.Do not modify it
        ' using the code editor.
        <DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
            Me.Pnl_Top = New System.Windows.Forms.Panel()
            Me.Lbl_Header = New System.Windows.Forms.Label()
            Me.Pnl_Bottom = New System.Windows.Forms.Panel()
            Me.Lbl_Contact = New System.Windows.Forms.Label()
            Me.Btn_Make_Id = New System.Windows.Forms.Button()
            Me.Btn_Exit = New System.Windows.Forms.Button()
            Me.Pic_Login = New System.Windows.Forms.PictureBox()
            Me.Lbl_Notice = New System.Windows.Forms.Label()
            Me.Lbl_Name = New System.Windows.Forms.Label()
            Me.Txt_Name = New System.Windows.Forms.TextBox()
            Me.Lbl_Phone = New System.Windows.Forms.Label()
            Me.Txt_Phone = New System.Windows.Forms.TextBox()
            Me.Lbl_Email = New System.Windows.Forms.Label()
            Me.Txt_Email = New System.Windows.Forms.TextBox()
            Me.Lbl_Start1 = New System.Windows.Forms.Label()
            Me.Lbl_Start2 = New System.Windows.Forms.Label()
            Me.Lbl_Start3 = New System.Windows.Forms.Label()
            Me.Lbl_Start_Info = New System.Windows.Forms.Label()
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
            Me.Lbl_Header.Text = "       Register !!!"
            Me.Lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Pnl_Bottom
            '
            Me.Pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.Pnl_Bottom.BackgroundImage = CType(resources.GetObject("Pnl_Bottom.BackgroundImage"), System.Drawing.Image)
            Me.Pnl_Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Pnl_Bottom.Controls.Add(Me.Lbl_Contact)
            Me.Pnl_Bottom.Controls.Add(Me.Btn_Make_Id)
            Me.Pnl_Bottom.Controls.Add(Me.Btn_Exit)
            Me.Pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Pnl_Bottom.Location = New System.Drawing.Point(0, 285)
            Me.Pnl_Bottom.Name = "Pnl_Bottom"
            Me.Pnl_Bottom.Size = New System.Drawing.Size(663, 48)
            Me.Pnl_Bottom.TabIndex = 75
            '
            'Lbl_Contact
            '
            Me.Lbl_Contact.AutoSize = True
            Me.Lbl_Contact.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Contact.Location = New System.Drawing.Point(16, 17)
            Me.Lbl_Contact.Name = "Lbl_Contact"
            Me.Lbl_Contact.Size = New System.Drawing.Size(397, 14)
            Me.Lbl_Contact.TabIndex = 7
            Me.Lbl_Contact.Text = "For more details contact to this email pro99der@gmail.com"
            '
            'Btn_Make_Id
            '
            Me.Btn_Make_Id.BackgroundImage = CType(resources.GetObject("Btn_Make_Id.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Make_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Make_Id.Dock = System.Windows.Forms.DockStyle.Right
            Me.Btn_Make_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Make_Id.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Make_Id.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Make_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Make_Id.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Make_Id.ForeColor = System.Drawing.Color.White
            Me.Btn_Make_Id.Image = CType(resources.GetObject("Btn_Make_Id.Image"), System.Drawing.Image)
            Me.Btn_Make_Id.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Make_Id.Location = New System.Drawing.Point(472, 0)
            Me.Btn_Make_Id.Name = "Btn_Make_Id"
            Me.Btn_Make_Id.Size = New System.Drawing.Size(101, 48)
            Me.Btn_Make_Id.TabIndex = 5
            Me.Btn_Make_Id.Text = "    MAKE ID"
            Me.Btn_Make_Id.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Btn_Make_Id.UseVisualStyleBackColor = True
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
            Me.Pic_Login.Dock = System.Windows.Forms.DockStyle.Left
            Me.Pic_Login.Image = CType(resources.GetObject("Pic_Login.Image"), System.Drawing.Image)
            Me.Pic_Login.Location = New System.Drawing.Point(0, 48)
            Me.Pic_Login.Name = "Pic_Login"
            Me.Pic_Login.Size = New System.Drawing.Size(176, 237)
            Me.Pic_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.Pic_Login.TabIndex = 77
            Me.Pic_Login.TabStop = False
            '
            'Lbl_Notice
            '
            Me.Lbl_Notice.Dock = System.Windows.Forms.DockStyle.Top
            Me.Lbl_Notice.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Notice.Location = New System.Drawing.Point(176, 48)
            Me.Lbl_Notice.Name = "Lbl_Notice"
            Me.Lbl_Notice.Size = New System.Drawing.Size(487, 72)
            Me.Lbl_Notice.TabIndex = 78
            Me.Lbl_Notice.Text = "Input the information for register software" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Keyfile will be send through email (" &
    "Keyfile" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(appkey.softkey))"
            Me.Lbl_Notice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Lbl_Name
            '
            Me.Lbl_Name.AutoSize = True
            Me.Lbl_Name.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Name.ForeColor = System.Drawing.Color.White
            Me.Lbl_Name.Location = New System.Drawing.Point(216, 137)
            Me.Lbl_Name.Name = "Lbl_Name"
            Me.Lbl_Name.Size = New System.Drawing.Size(50, 14)
            Me.Lbl_Name.TabIndex = 79
            Me.Lbl_Name.Text = "Name:"
            '
            'Txt_Name
            '
            Me.Txt_Name.BackColor = System.Drawing.Color.White
            Me.Txt_Name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Name.ForeColor = System.Drawing.Color.Black
            Me.Txt_Name.Location = New System.Drawing.Point(286, 134)
            Me.Txt_Name.Name = "Txt_Name"
            Me.Txt_Name.Size = New System.Drawing.Size(336, 22)
            Me.Txt_Name.TabIndex = 80
            '
            'Lbl_Phone
            '
            Me.Lbl_Phone.AutoSize = True
            Me.Lbl_Phone.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Phone.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Phone.ForeColor = System.Drawing.Color.White
            Me.Lbl_Phone.Location = New System.Drawing.Point(216, 167)
            Me.Lbl_Phone.Name = "Lbl_Phone"
            Me.Lbl_Phone.Size = New System.Drawing.Size(53, 14)
            Me.Lbl_Phone.TabIndex = 81
            Me.Lbl_Phone.Text = "Phone:"
            '
            'Txt_Phone
            '
            Me.Txt_Phone.BackColor = System.Drawing.Color.White
            Me.Txt_Phone.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Phone.ForeColor = System.Drawing.Color.Black
            Me.Txt_Phone.Location = New System.Drawing.Point(286, 164)
            Me.Txt_Phone.Name = "Txt_Phone"
            Me.Txt_Phone.Size = New System.Drawing.Size(336, 22)
            Me.Txt_Phone.TabIndex = 82
            '
            'Lbl_Email
            '
            Me.Lbl_Email.AutoSize = True
            Me.Lbl_Email.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Email.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Email.ForeColor = System.Drawing.Color.White
            Me.Lbl_Email.Location = New System.Drawing.Point(216, 196)
            Me.Lbl_Email.Name = "Lbl_Email"
            Me.Lbl_Email.Size = New System.Drawing.Size(48, 14)
            Me.Lbl_Email.TabIndex = 83
            Me.Lbl_Email.Text = "Email:"
            '
            'Txt_Email
            '
            Me.Txt_Email.BackColor = System.Drawing.Color.White
            Me.Txt_Email.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Email.ForeColor = System.Drawing.Color.Black
            Me.Txt_Email.Location = New System.Drawing.Point(286, 193)
            Me.Txt_Email.Name = "Txt_Email"
            Me.Txt_Email.Size = New System.Drawing.Size(336, 22)
            Me.Txt_Email.TabIndex = 84
            '
            'Lbl_Start1
            '
            Me.Lbl_Start1.AutoSize = True
            Me.Lbl_Start1.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Start1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Start1.ForeColor = System.Drawing.Color.White
            Me.Lbl_Start1.Location = New System.Drawing.Point(628, 137)
            Me.Lbl_Start1.Name = "Lbl_Start1"
            Me.Lbl_Start1.Size = New System.Drawing.Size(16, 14)
            Me.Lbl_Start1.TabIndex = 85
            Me.Lbl_Start1.Text = "*"
            '
            'Lbl_Start2
            '
            Me.Lbl_Start2.AutoSize = True
            Me.Lbl_Start2.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Start2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Start2.ForeColor = System.Drawing.Color.White
            Me.Lbl_Start2.Location = New System.Drawing.Point(628, 167)
            Me.Lbl_Start2.Name = "Lbl_Start2"
            Me.Lbl_Start2.Size = New System.Drawing.Size(16, 14)
            Me.Lbl_Start2.TabIndex = 86
            Me.Lbl_Start2.Text = "*"
            '
            'Lbl_Start3
            '
            Me.Lbl_Start3.AutoSize = True
            Me.Lbl_Start3.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Start3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Start3.ForeColor = System.Drawing.Color.White
            Me.Lbl_Start3.Location = New System.Drawing.Point(628, 196)
            Me.Lbl_Start3.Name = "Lbl_Start3"
            Me.Lbl_Start3.Size = New System.Drawing.Size(16, 14)
            Me.Lbl_Start3.TabIndex = 87
            Me.Lbl_Start3.Text = "*"
            '
            'Lbl_Start_Info
            '
            Me.Lbl_Start_Info.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Start_Info.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Lbl_Start_Info.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Start_Info.ForeColor = System.Drawing.Color.White
            Me.Lbl_Start_Info.Location = New System.Drawing.Point(176, 228)
            Me.Lbl_Start_Info.Name = "Lbl_Start_Info"
            Me.Lbl_Start_Info.Size = New System.Drawing.Size(487, 57)
            Me.Lbl_Start_Info.TabIndex = 88
            Me.Lbl_Start_Info.Text = "* You must input all information and click to MAKE ID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "after that send (appmkey.s" &
    "oftkey) to pro99der@gmail.com"
            Me.Lbl_Start_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Register
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.Controls.Add(Me.Lbl_Start_Info)
            Me.Controls.Add(Me.Lbl_Start3)
            Me.Controls.Add(Me.Lbl_Start2)
            Me.Controls.Add(Me.Lbl_Start1)
            Me.Controls.Add(Me.Lbl_Email)
            Me.Controls.Add(Me.Txt_Email)
            Me.Controls.Add(Me.Lbl_Phone)
            Me.Controls.Add(Me.Txt_Phone)
            Me.Controls.Add(Me.Lbl_Name)
            Me.Controls.Add(Me.Txt_Name)
            Me.Controls.Add(Me.Lbl_Notice)
            Me.Controls.Add(Me.Pic_Login)
            Me.Controls.Add(Me.Pnl_Bottom)
            Me.Controls.Add(Me.Pnl_Top)
            Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.White
            Me.Name = "Register"
            Me.Size = New System.Drawing.Size(663, 333)
            Me.Pnl_Top.ResumeLayout(False)
            Me.Pnl_Bottom.ResumeLayout(False)
            Me.Pnl_Bottom.PerformLayout()
            CType(Me.Pic_Login, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region
        <DefaultValue(False)>
        Public Property SizeLock As Boolean
        Public Property FormTitle As String
        Protected Overrides Sub SetBoundsCore(ByVal x As Integer, ByVal y As Integer, ByVal [width] As Integer, ByVal height As Integer, ByVal specified As System.Windows.Forms.BoundsSpecified)
            MyBase.SetBoundsCore(x, y, 663, 333, specified)
        End Sub
        Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            FormTitle = "Register"
            clsFeature.SizeLock(SizeLock, ParentForm, FormTitle, Me)
        End Sub
        Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
            Me.ParentForm.Close()
        End Sub
        Private Sub Register_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
            ucRegister = Nothing
            frmRegister = Nothing
        End Sub
        Private Sub Btn_Make_Id_Click(sender As Object, e As EventArgs) Handles Btn_Make_Id.Click
            If String.IsNullOrWhiteSpace(Txt_Name.Text) Then
                MessageBox.Show("Please enter user name?", "Invalided", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf String.IsNullOrWhiteSpace(Txt_Phone.Text) Then
                MessageBox.Show("Please enter user phone number?", "Invalided", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf String.IsNullOrWhiteSpace(Txt_Email.Text) Then
                MessageBox.Show("Please enter email address?", "Invalided", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim _AppMKey As String = String.Empty
                Dim _UserDetails As String = String.Empty
                _AppMKey = Application.StartupPath & "\AppMKey.softkey"
                _UserDetails = Txt_Name.Text & vbNewLine & Txt_Phone.Text & vbNewLine & Txt_Email.Text & vbNewLine & clsRegistration.CPUSerialNumber()
                My.Computer.FileSystem.WriteAllText(_AppMKey, clsRegistration.Encrypt(_UserDetails), False)
                _AppMKey = String.Empty
                _UserDetails = String.Empty
                MessageBox.Show("Successfully generate application close now.", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.ParentForm.Close()
            End If
        End Sub
    End Class
End Namespace