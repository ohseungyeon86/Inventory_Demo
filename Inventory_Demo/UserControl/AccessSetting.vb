Imports System.ComponentModel
Namespace UIForm
    ' Build Action Embedded Resource
    <ToolboxBitmap(GetType(AccessSetting), "AccessSetting.ico"), ToolboxItem(False)>
    Public Class AccessSetting
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
        Friend WithEvents Btn_Connection_Test As Button
        Friend WithEvents Btn_Close As Button
        Friend WithEvents Txt_Password As TextBox
        Friend WithEvents Lbl_Password As Label
        Friend WithEvents Txt_User_Id As TextBox
        Friend WithEvents Lbl_User_Id As Label
        Friend WithEvents Txt_Access_File As TextBox
        Friend WithEvents Lbl_Database_Path As Label
        Friend WithEvents Pnl_Top As Panel
        Friend WithEvents Lbl_Header As Label
        Friend WithEvents Pnl_Buttom As Panel
        Friend WithEvents Pic_Login As PictureBox
        Friend WithEvents Btn_Open_DB_File As Button
        Friend WithEvents Label1 As Label
        'Required by the Control Designer
        Private components As System.ComponentModel.IContainer
        ' NOTE: The following procedure is required by the Component Designer
        ' It can be modified using the Component Designer.Do not modify it
        ' using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccessSetting))
            Me.Btn_Connection_Test = New System.Windows.Forms.Button()
            Me.Btn_Close = New System.Windows.Forms.Button()
            Me.Txt_Password = New System.Windows.Forms.TextBox()
            Me.Lbl_Password = New System.Windows.Forms.Label()
            Me.Txt_User_Id = New System.Windows.Forms.TextBox()
            Me.Lbl_User_Id = New System.Windows.Forms.Label()
            Me.Txt_Access_File = New System.Windows.Forms.TextBox()
            Me.Lbl_Database_Path = New System.Windows.Forms.Label()
            Me.Pnl_Top = New System.Windows.Forms.Panel()
            Me.Lbl_Header = New System.Windows.Forms.Label()
            Me.Pnl_Buttom = New System.Windows.Forms.Panel()
            Me.Pic_Login = New System.Windows.Forms.PictureBox()
            Me.Btn_Open_DB_File = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Pnl_Top.SuspendLayout()
            Me.Pnl_Buttom.SuspendLayout()
            CType(Me.Pic_Login, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Btn_Connection_Test
            '
            Me.Btn_Connection_Test.BackgroundImage = CType(resources.GetObject("Btn_Connection_Test.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Connection_Test.Dock = System.Windows.Forms.DockStyle.Right
            Me.Btn_Connection_Test.FlatAppearance.BorderSize = 0
            Me.Btn_Connection_Test.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Connection_Test.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Connection_Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Connection_Test.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Connection_Test.Image = CType(resources.GetObject("Btn_Connection_Test.Image"), System.Drawing.Image)
            Me.Btn_Connection_Test.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Connection_Test.Location = New System.Drawing.Point(423, 0)
            Me.Btn_Connection_Test.Name = "Btn_Connection_Test"
            Me.Btn_Connection_Test.Size = New System.Drawing.Size(90, 48)
            Me.Btn_Connection_Test.TabIndex = 38
            Me.Btn_Connection_Test.Text = "   TEST"
            Me.Btn_Connection_Test.UseVisualStyleBackColor = True
            '
            'Btn_Close
            '
            Me.Btn_Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.Btn_Close.BackgroundImage = CType(resources.GetObject("Btn_Close.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Close.Dock = System.Windows.Forms.DockStyle.Right
            Me.Btn_Close.FlatAppearance.BorderSize = 0
            Me.Btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Close.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Close.Image = CType(resources.GetObject("Btn_Close.Image"), System.Drawing.Image)
            Me.Btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Close.Location = New System.Drawing.Point(513, 0)
            Me.Btn_Close.Name = "Btn_Close"
            Me.Btn_Close.Size = New System.Drawing.Size(90, 48)
            Me.Btn_Close.TabIndex = 39
            Me.Btn_Close.Text = "       CLOSE"
            Me.Btn_Close.UseVisualStyleBackColor = True
            '
            'Txt_Password
            '
            Me.Txt_Password.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Password.Location = New System.Drawing.Point(314, 146)
            Me.Txt_Password.Name = "Txt_Password"
            Me.Txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.Txt_Password.Size = New System.Drawing.Size(232, 22)
            Me.Txt_Password.TabIndex = 36
            Me.Txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Lbl_Password
            '
            Me.Lbl_Password.AutoSize = True
            Me.Lbl_Password.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Password.Location = New System.Drawing.Point(187, 149)
            Me.Lbl_Password.Name = "Lbl_Password"
            Me.Lbl_Password.Size = New System.Drawing.Size(85, 20)
            Me.Lbl_Password.TabIndex = 35
            Me.Lbl_Password.Text = "PASSWORD"
            Me.Lbl_Password.UseCompatibleTextRendering = True
            '
            'Txt_User_Id
            '
            Me.Txt_User_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_User_Id.Location = New System.Drawing.Point(314, 118)
            Me.Txt_User_Id.Name = "Txt_User_Id"
            Me.Txt_User_Id.Size = New System.Drawing.Size(232, 22)
            Me.Txt_User_Id.TabIndex = 34
            Me.Txt_User_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Lbl_User_Id
            '
            Me.Lbl_User_Id.AutoSize = True
            Me.Lbl_User_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_User_Id.Location = New System.Drawing.Point(187, 121)
            Me.Lbl_User_Id.Name = "Lbl_User_Id"
            Me.Lbl_User_Id.Size = New System.Drawing.Size(58, 20)
            Me.Lbl_User_Id.TabIndex = 33
            Me.Lbl_User_Id.Text = "USERID"
            Me.Lbl_User_Id.UseCompatibleTextRendering = True
            '
            'Txt_Access_File
            '
            Me.Txt_Access_File.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Access_File.Location = New System.Drawing.Point(314, 90)
            Me.Txt_Access_File.Name = "Txt_Access_File"
            Me.Txt_Access_File.Size = New System.Drawing.Size(232, 22)
            Me.Txt_Access_File.TabIndex = 32
            '
            'Lbl_Database_Path
            '
            Me.Lbl_Database_Path.AutoSize = True
            Me.Lbl_Database_Path.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Database_Path.Location = New System.Drawing.Point(187, 93)
            Me.Lbl_Database_Path.Name = "Lbl_Database_Path"
            Me.Lbl_Database_Path.Size = New System.Drawing.Size(120, 20)
            Me.Lbl_Database_Path.TabIndex = 31
            Me.Lbl_Database_Path.Text = "DATABASE PATH"
            Me.Lbl_Database_Path.UseCompatibleTextRendering = True
            '
            'Pnl_Top
            '
            Me.Pnl_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.Pnl_Top.BackgroundImage = CType(resources.GetObject("Pnl_Top.BackgroundImage"), System.Drawing.Image)
            Me.Pnl_Top.Controls.Add(Me.Lbl_Header)
            Me.Pnl_Top.Dock = System.Windows.Forms.DockStyle.Top
            Me.Pnl_Top.Location = New System.Drawing.Point(0, 0)
            Me.Pnl_Top.Name = "Pnl_Top"
            Me.Pnl_Top.Size = New System.Drawing.Size(603, 48)
            Me.Pnl_Top.TabIndex = 40
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
            Me.Lbl_Header.Size = New System.Drawing.Size(603, 48)
            Me.Lbl_Header.TabIndex = 0
            Me.Lbl_Header.Text = "       MS Access Database"
            Me.Lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Lbl_Header.UseCompatibleTextRendering = True
            '
            'Pnl_Buttom
            '
            Me.Pnl_Buttom.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.Pnl_Buttom.BackgroundImage = CType(resources.GetObject("Pnl_Buttom.BackgroundImage"), System.Drawing.Image)
            Me.Pnl_Buttom.Controls.Add(Me.Label1)
            Me.Pnl_Buttom.Controls.Add(Me.Btn_Connection_Test)
            Me.Pnl_Buttom.Controls.Add(Me.Btn_Close)
            Me.Pnl_Buttom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Pnl_Buttom.Location = New System.Drawing.Point(0, 195)
            Me.Pnl_Buttom.Name = "Pnl_Buttom"
            Me.Pnl_Buttom.Size = New System.Drawing.Size(603, 48)
            Me.Pnl_Buttom.TabIndex = 41
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
            Me.Pic_Login.TabIndex = 42
            Me.Pic_Login.TabStop = False
            '
            'Btn_Open_DB_File
            '
            Me.Btn_Open_DB_File.BackColor = System.Drawing.Color.Transparent
            Me.Btn_Open_DB_File.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Open_DB_File.FlatAppearance.BorderSize = 0
            Me.Btn_Open_DB_File.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Open_DB_File.Image = CType(resources.GetObject("Btn_Open_DB_File.Image"), System.Drawing.Image)
            Me.Btn_Open_DB_File.Location = New System.Drawing.Point(552, 86)
            Me.Btn_Open_DB_File.Name = "Btn_Open_DB_File"
            Me.Btn_Open_DB_File.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Open_DB_File.TabIndex = 43
            Me.Btn_Open_DB_File.TabStop = False
            Me.Btn_Open_DB_File.UseVisualStyleBackColor = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
            Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Label1.Location = New System.Drawing.Point(23, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(312, 16)
            Me.Label1.TabIndex = 40
            Me.Label1.Text = "       Same folder auto detect just click test"
            '
            'AccessSetting
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.Controls.Add(Me.Btn_Open_DB_File)
            Me.Controls.Add(Me.Pic_Login)
            Me.Controls.Add(Me.Pnl_Buttom)
            Me.Controls.Add(Me.Pnl_Top)
            Me.Controls.Add(Me.Txt_Password)
            Me.Controls.Add(Me.Txt_User_Id)
            Me.Controls.Add(Me.Txt_Access_File)
            Me.Controls.Add(Me.Lbl_Password)
            Me.Controls.Add(Me.Lbl_User_Id)
            Me.Controls.Add(Me.Lbl_Database_Path)
            Me.ForeColor = System.Drawing.Color.White
            Me.Name = "AccessSetting"
            Me.Size = New System.Drawing.Size(603, 243)
            Me.Pnl_Top.ResumeLayout(False)
            Me.Pnl_Buttom.ResumeLayout(False)
            Me.Pnl_Buttom.PerformLayout()
            CType(Me.Pic_Login, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region
        <DefaultValue(False)>
        Public Property SizeLock As Boolean
        Public Property FormTitle As String
        Private ReadOnly _Setting As String = Application.StartupPath & "\MDB_DB_Setting.mdb_setting"
        Public Sub SettingFile(ByVal Action As String)
            Select Case Action
                Case "Save"
                    Dim _Values As String = DatabasePath & "©" & UserId & "©" & Password
                    _Values = clsEncryptDecrypt.Encrypt(_Values)
                    My.Computer.FileSystem.WriteAllText(_Setting, _Values, False)
                Case "Load"
                    If My.Computer.FileSystem.FileExists(_Setting) Then
                        Dim _Security As String = My.Computer.FileSystem.ReadAllText(_Setting)
                        If Not String.IsNullOrWhiteSpace(_Security) Then
                            _Security = clsEncryptDecrypt.Decrypt(_Security)
                            Dim _Values As String() = _Security.Split("©")
                            DatabasePath = _Values(0)
                            Password = _Values(2)
                            UserId = _Values(1)
                            UICode.Database.ConnectionString.sqlConnectionString = DatabaseProvider
                        End If
                    Else
                        DatabasePath = DatabasePath
                        UserId = UserId
                        Password = Password
                    End If
            End Select
        End Sub
        Public ReadOnly Property DatabaseExtension As String
            Get
                Dim fileName As String = DatabasePath.Split("\")(DatabasePath.Split("\").GetUpperBound(0))
                If Not String.IsNullOrWhiteSpace(DatabasePath) Then
                    Return fileName.Split(".")(fileName.Split(".").GetUpperBound(0))
                    fileName = Nothing
                Else
                    Return Nothing
                End If
            End Get
        End Property
        Public ReadOnly Property DatabaseProvider As String
            Get
                If DatabaseExtension = "mdb" Then
                    Return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatabasePath & ";Persist Security Info=True;User ID=" & UserId & ";Jet OLEDB:Database Password=" & Password
                ElseIf DatabaseExtension = "accdb" Then
                    Return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & DatabasePath & ";Persist Security Info=True;User ID=" & UserId & ";Jet OLEDB:Database Password=" & Password
                Else
                    Return Nothing
                End If
            End Get
        End Property
        Public Property DatabasePath As String
            Get
                Return Txt_Access_File.Text
            End Get
            Set(value As String)
                Txt_Access_File.Text = value
                If String.IsNullOrWhiteSpace(Txt_Access_File.Text) Then
                    Dim _Access_File As String = String.Empty
                    _Access_File = Application.StartupPath & "\Inventory.mdb"
                    If My.Computer.FileSystem.FileExists(_Access_File) = True Then
                        Txt_Access_File.Text = _Access_File
                        _Access_File = String.Empty
                    Else
                        Txt_Access_File.Text = String.Empty
                    End If
                End If
            End Set
        End Property
        Public Property UserId As String
            Get
                If String.IsNullOrWhiteSpace(Txt_User_Id.Text) Then
                    Return "Admin"
                Else
                    Return Txt_User_Id.Text
                End If
            End Get
            Set(value As String)
                Txt_User_Id.Text = value
            End Set
        End Property
        Public Property Password As String
            Get
                Return Txt_Password.Text
            End Get
            Set(value As String)
                Txt_Password.Text = value
            End Set
        End Property
        Protected Overrides Sub SetBoundsCore(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal specified As System.Windows.Forms.BoundsSpecified)
            MyBase.SetBoundsCore(x, y, 603, 243, specified)
        End Sub
        Private Sub AccessSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            FormTitle = "Access Setting"
            clsFeature.SizeLock(SizeLock, ParentForm, FormTitle, Me)
            SettingFile("Load")
        End Sub
        Private Sub Btn_Open_DB_File_Click(sender As Object, e As EventArgs) Handles Btn_Open_DB_File.Click
            Dim _OpenFileDialog As New OpenFileDialog With {
 .FileName = "Select a ms access database file",
 .DefaultExt = "mdb",
 .Filter = "MS Access Database 97 Files (*.mdb)|*.mdb|MS Access Database 2007 Files (*.accdb)|*.accdb"}
            If _OpenFileDialog.ShowDialog = DialogResult.OK Then
                DatabasePath = _OpenFileDialog.FileName
            End If
        End Sub
        Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
            Me.ParentForm.Close()
        End Sub
        Private Sub Btn_Connection_Test_Click(sender As Object, e As EventArgs) Handles Btn_Connection_Test.Click
            Try
                UICode.Database.ConnectionString.sqlConnectionTest.Open(DatabaseProvider)
                MessageBox.Show("Sucessfully Connected", "Database Connected.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SettingFile("Save")
                UICode.Database.ConnectionString.sqlConnectionTest.Close()
                SettingFile("Load")
                Me.ParentForm.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub AccessSetting_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
            ucAccessSetting = Nothing
            frmAccessSetting = Nothing
        End Sub
    End Class
End Namespace