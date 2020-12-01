Imports System.ComponentModel
Namespace UIForm
    ' Build Action Embedded Resource
    <ToolboxBitmap(GetType(SQLLogin), "SQLLogin.ico"), ToolboxItem(False)>
    Public Class SQLLogin
        Inherits System.Windows.Forms.UserControl
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
            SetStyle(ControlStyles.DoubleBuffer _
            Or ControlStyles.UserPaint _
            Or ControlStyles.AllPaintingInWmPaint,
            True)
            ' This updates the styles
            UpdateStyles()
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
        Friend WithEvents Pic_Login As PictureBox
        Friend WithEvents Chkb_ShowHide As CheckBox
        Friend WithEvents Chkb_Rember As CheckBox
        Friend WithEvents Txt_Password As TextBox
        Friend WithEvents Txt_Username As TextBox
        Friend WithEvents Lbl_Password As Label
        Friend WithEvents Lbl_Username As Label
        Friend WithEvents Pnl_Bottom As Panel
        Friend WithEvents Btn_Setting As Button
        Friend WithEvents Btn_Login As Button
        Friend WithEvents Btn_MSSQL_Login As Button
        Friend WithEvents Btn_Close As Button
        'Required by the Control Designer
        Private components As System.ComponentModel.IContainer
        ' NOTE: The following procedure is required by the Component Designer
        ' It can be modified using the Component Designer.Do not modify it
        ' using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SQLLogin))
            Me.Pnl_Top = New System.Windows.Forms.Panel()
            Me.Lbl_Header = New System.Windows.Forms.Label()
            Me.Pic_Login = New System.Windows.Forms.PictureBox()
            Me.Chkb_ShowHide = New System.Windows.Forms.CheckBox()
            Me.Chkb_Rember = New System.Windows.Forms.CheckBox()
            Me.Txt_Password = New System.Windows.Forms.TextBox()
            Me.Txt_Username = New System.Windows.Forms.TextBox()
            Me.Lbl_Password = New System.Windows.Forms.Label()
            Me.Lbl_Username = New System.Windows.Forms.Label()
            Me.Pnl_Bottom = New System.Windows.Forms.Panel()
            Me.Btn_Setting = New System.Windows.Forms.Button()
            Me.Btn_Login = New System.Windows.Forms.Button()
            Me.Btn_MSSQL_Login = New System.Windows.Forms.Button()
            Me.Btn_Close = New System.Windows.Forms.Button()
            Me.Pnl_Top.SuspendLayout()
            CType(Me.Pic_Login, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Pnl_Bottom.SuspendLayout()
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
            Me.Pnl_Top.Size = New System.Drawing.Size(573, 48)
            Me.Pnl_Top.TabIndex = 1
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
            Me.Lbl_Header.Size = New System.Drawing.Size(573, 48)
            Me.Lbl_Header.TabIndex = 0
            Me.Lbl_Header.Text = "       MS SQL Login"
            Me.Lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Lbl_Header.UseCompatibleTextRendering = True
            '
            'Pic_Login
            '
            Me.Pic_Login.BackColor = System.Drawing.Color.Transparent
            Me.Pic_Login.Dock = System.Windows.Forms.DockStyle.Left
            Me.Pic_Login.Image = CType(resources.GetObject("Pic_Login.Image"), System.Drawing.Image)
            Me.Pic_Login.Location = New System.Drawing.Point(0, 48)
            Me.Pic_Login.Name = "Pic_Login"
            Me.Pic_Login.Size = New System.Drawing.Size(176, 147)
            Me.Pic_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.Pic_Login.TabIndex = 5
            Me.Pic_Login.TabStop = False
            '
            'Chkb_ShowHide
            '
            Me.Chkb_ShowHide.AutoSize = True
            Me.Chkb_ShowHide.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Chkb_ShowHide.Location = New System.Drawing.Point(191, 156)
            Me.Chkb_ShowHide.Name = "Chkb_ShowHide"
            Me.Chkb_ShowHide.Size = New System.Drawing.Size(152, 21)
            Me.Chkb_ShowHide.TabIndex = 32
            Me.Chkb_ShowHide.Text = "SHOW PASSWORD"
            Me.Chkb_ShowHide.UseCompatibleTextRendering = True
            Me.Chkb_ShowHide.UseVisualStyleBackColor = True
            '
            'Chkb_Rember
            '
            Me.Chkb_Rember.AutoSize = True
            Me.Chkb_Rember.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Chkb_Rember.Location = New System.Drawing.Point(349, 156)
            Me.Chkb_Rember.Name = "Chkb_Rember"
            Me.Chkb_Rember.Size = New System.Drawing.Size(210, 21)
            Me.Chkb_Rember.TabIndex = 33
            Me.Chkb_Rember.Text = "REMENBER MY PASSWORD"
            Me.Chkb_Rember.UseCompatibleTextRendering = True
            Me.Chkb_Rember.UseVisualStyleBackColor = True
            '
            'Txt_Password
            '
            Me.Txt_Password.BackColor = System.Drawing.SystemColors.Window
            Me.Txt_Password.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Password.Location = New System.Drawing.Point(301, 111)
            Me.Txt_Password.Name = "Txt_Password"
            Me.Txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.Txt_Password.Size = New System.Drawing.Size(222, 27)
            Me.Txt_Password.TabIndex = 31
            Me.Txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Txt_Username
            '
            Me.Txt_Username.BackColor = System.Drawing.SystemColors.Window
            Me.Txt_Username.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Username.Location = New System.Drawing.Point(301, 75)
            Me.Txt_Username.Name = "Txt_Username"
            Me.Txt_Username.Size = New System.Drawing.Size(222, 27)
            Me.Txt_Username.TabIndex = 30
            Me.Txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Lbl_Password
            '
            Me.Lbl_Password.AutoSize = True
            Me.Lbl_Password.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Password.Location = New System.Drawing.Point(191, 117)
            Me.Lbl_Password.Name = "Lbl_Password"
            Me.Lbl_Password.Size = New System.Drawing.Size(85, 20)
            Me.Lbl_Password.TabIndex = 35
            Me.Lbl_Password.Text = "PASSWORD"
            Me.Lbl_Password.UseCompatibleTextRendering = True
            '
            'Lbl_Username
            '
            Me.Lbl_Username.AutoSize = True
            Me.Lbl_Username.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Username.Location = New System.Drawing.Point(191, 81)
            Me.Lbl_Username.Name = "Lbl_Username"
            Me.Lbl_Username.Size = New System.Drawing.Size(82, 20)
            Me.Lbl_Username.TabIndex = 34
            Me.Lbl_Username.Text = "USERNAME"
            Me.Lbl_Username.UseCompatibleTextRendering = True
            '
            'Pnl_Bottom
            '
            Me.Pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.Pnl_Bottom.BackgroundImage = CType(resources.GetObject("Pnl_Bottom.BackgroundImage"), System.Drawing.Image)
            Me.Pnl_Bottom.Controls.Add(Me.Btn_Setting)
            Me.Pnl_Bottom.Controls.Add(Me.Btn_Login)
            Me.Pnl_Bottom.Controls.Add(Me.Btn_MSSQL_Login)
            Me.Pnl_Bottom.Controls.Add(Me.Btn_Close)
            Me.Pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Pnl_Bottom.Location = New System.Drawing.Point(0, 195)
            Me.Pnl_Bottom.Name = "Pnl_Bottom"
            Me.Pnl_Bottom.Size = New System.Drawing.Size(573, 48)
            Me.Pnl_Bottom.TabIndex = 36
            '
            'Btn_Setting
            '
            Me.Btn_Setting.BackgroundImage = CType(resources.GetObject("Btn_Setting.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Setting.Dock = System.Windows.Forms.DockStyle.Right
            Me.Btn_Setting.FlatAppearance.BorderSize = 0
            Me.Btn_Setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Setting.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Setting.ForeColor = System.Drawing.Color.White
            Me.Btn_Setting.Image = CType(resources.GetObject("Btn_Setting.Image"), System.Drawing.Image)
            Me.Btn_Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Setting.Location = New System.Drawing.Point(283, 0)
            Me.Btn_Setting.Name = "Btn_Setting"
            Me.Btn_Setting.Size = New System.Drawing.Size(110, 48)
            Me.Btn_Setting.TabIndex = 0
            Me.Btn_Setting.Text = "     SETTING"
            Me.Btn_Setting.UseVisualStyleBackColor = True
            '
            'Btn_Login
            '
            Me.Btn_Login.BackgroundImage = CType(resources.GetObject("Btn_Login.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Login.Dock = System.Windows.Forms.DockStyle.Right
            Me.Btn_Login.FlatAppearance.BorderSize = 0
            Me.Btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Login.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Login.ForeColor = System.Drawing.Color.White
            Me.Btn_Login.Image = CType(resources.GetObject("Btn_Login.Image"), System.Drawing.Image)
            Me.Btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Login.Location = New System.Drawing.Point(393, 0)
            Me.Btn_Login.Name = "Btn_Login"
            Me.Btn_Login.Size = New System.Drawing.Size(90, 48)
            Me.Btn_Login.TabIndex = 1
            Me.Btn_Login.Text = "      LOGIN"
            Me.Btn_Login.UseVisualStyleBackColor = True
            '
            'Btn_MSSQL_Login
            '
            Me.Btn_MSSQL_Login.BackgroundImage = CType(resources.GetObject("Btn_MSSQL_Login.BackgroundImage"), System.Drawing.Image)
            Me.Btn_MSSQL_Login.Dock = System.Windows.Forms.DockStyle.Left
            Me.Btn_MSSQL_Login.FlatAppearance.BorderSize = 0
            Me.Btn_MSSQL_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_MSSQL_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_MSSQL_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_MSSQL_Login.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_MSSQL_Login.Image = CType(resources.GetObject("Btn_MSSQL_Login.Image"), System.Drawing.Image)
            Me.Btn_MSSQL_Login.Location = New System.Drawing.Point(0, 0)
            Me.Btn_MSSQL_Login.Name = "Btn_MSSQL_Login"
            Me.Btn_MSSQL_Login.Size = New System.Drawing.Size(44, 48)
            Me.Btn_MSSQL_Login.TabIndex = 3
            Me.Btn_MSSQL_Login.UseVisualStyleBackColor = True
            '
            'Btn_Close
            '
            Me.Btn_Close.BackgroundImage = CType(resources.GetObject("Btn_Close.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Close.Dock = System.Windows.Forms.DockStyle.Right
            Me.Btn_Close.FlatAppearance.BorderSize = 0
            Me.Btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Close.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Close.ForeColor = System.Drawing.Color.White
            Me.Btn_Close.Image = CType(resources.GetObject("Btn_Close.Image"), System.Drawing.Image)
            Me.Btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Close.Location = New System.Drawing.Point(483, 0)
            Me.Btn_Close.Name = "Btn_Close"
            Me.Btn_Close.Size = New System.Drawing.Size(90, 48)
            Me.Btn_Close.TabIndex = 2
            Me.Btn_Close.Text = "     CLOSE"
            Me.Btn_Close.UseCompatibleTextRendering = True
            Me.Btn_Close.UseVisualStyleBackColor = True
            '
            'SQLLogin
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.Controls.Add(Me.Pic_Login)
            Me.Controls.Add(Me.Chkb_ShowHide)
            Me.Controls.Add(Me.Chkb_Rember)
            Me.Controls.Add(Me.Txt_Password)
            Me.Controls.Add(Me.Txt_Username)
            Me.Controls.Add(Me.Lbl_Password)
            Me.Controls.Add(Me.Lbl_Username)
            Me.Controls.Add(Me.Pnl_Top)
            Me.Controls.Add(Me.Pnl_Bottom)
            Me.ForeColor = System.Drawing.Color.White
            Me.Name = "SQLLogin"
            Me.Size = New System.Drawing.Size(573, 243)
            Me.Pnl_Top.ResumeLayout(False)
            CType(Me.Pic_Login, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Pnl_Bottom.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region
        <DefaultValue(False)>
        Public Property SizeLock As Boolean
        Public Property FormTitle As String
        Protected Overrides Sub SetBoundsCore(ByVal x As Integer, ByVal y As Integer, ByVal [width] As Integer, ByVal height As Integer, ByVal specified As System.Windows.Forms.BoundsSpecified)
            MyBase.SetBoundsCore(x, y, 573, 243, specified)
        End Sub
        Private Sub SQLLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            FormTitle = "MS SQL Login"
            clsFeature.SizeLock(SizeLock, ParentForm, FormTitle, Me)
        End Sub
        Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
            Try
                If String.IsNullOrWhiteSpace(UICode.Database.ConnectionString.sqlConnectionString) Then
                    MessageBox.Show("Database not connect yeat click setting to connect database.", "Database not setup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                clsConnectionString.sqlString = "SELECT * FROM Login WHERE Login_Name='" & Txt_Username.Text & "' AND Login_Password ='" & Txt_Password.Text & "'"
                clsConnectionString.SQLQueryCommand(clsConnectionString.sqlString)
                If clsConnectionString.sqlDataTable.Rows.Count > 0 Then
                    For i = 0 To clsConnectionString.sqlDataTable.Rows.Count - 1
                        If clsConnectionString.sqlDataTable.Rows(i)("Login_Name").ToString <> Txt_Username.Text Or clsConnectionString.sqlDataTable.Rows(i)("Login_Password").ToString <> Txt_Password.Text Then
                            MessageBox.Show("Access denied username and password are case sensitive!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    Next
                    MessageBox.Show("Sucessfully login", "Login accept", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ucMenuStyle.MStrp_Inventory_Menu.Enabled = True
                    If Chkb_Rember.Checked = True Then
                        My.Settings.Txt_Username = Txt_Username.Text
                        My.Settings.Txt_Password = Txt_Password.Text
                        My.Settings.Chkb_Rember = Chkb_Rember.Checked
                        My.Settings.Save()
                    End If
                Else
                    MessageBox.Show("Username and password not match..." & vbNewLine & "Pleace check the user and password then try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub Btn_Setting_Click(sender As Object, e As EventArgs) Handles Btn_Setting.Click
            If ucSQLSetting Is Nothing Then ucSQLSetting = New UIForm.SQLSetting
            If frmSQLSetting Is Nothing Then
                frmSQLSetting = New UIForm.DialogBox
                ucSQLSetting.SizeLock = True
                frmSQLSetting.Controls.Add(ucSQLSetting)
                frmSQLSetting.Show()
            Else
                frmSQLSetting.BringToFront()
            End If
        End Sub
        Private Sub Chkb_ShowHide_CheckedChanged(sender As Object, e As EventArgs) Handles Chkb_ShowHide.CheckedChanged
            If Chkb_ShowHide.Checked = True Then
                Txt_Password.PasswordChar = ""
            Else
                Txt_Password.PasswordChar = "*"
            End If
        End Sub
        Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
            Application.Exit()
        End Sub
        Private Sub SQLLogin_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
            ucSQLLogin = Nothing
            frmSQLLogin = Nothing
        End Sub

        Private Sub Btn_MSSQL_Login_Click(sender As Object, e As EventArgs) Handles Btn_MSSQL_Login.Click
            ucMenuStyle.TStrpMItm_Access.PerformClick()
        End Sub
    End Class
End Namespace