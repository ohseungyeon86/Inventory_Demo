Option Explicit On
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace UIForm
    ' Build Action Embedded Resource
    <ToolboxBitmap(GetType(SQLSetting), "SQLSetting.ico"), ToolboxItem(False)>
    Public Class SQLSetting
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
            _Servers = SqlDataSourceEnumerator.Instance
            _TableServers = New DataTable()
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
        Friend WithEvents Pnl_Buttom As Panel
        Friend WithEvents Btn_Close As Button
        Friend WithEvents Btn_Save As Button
        Friend WithEvents Btn_Clear As Button
        Friend WithEvents Pic_Setting As PictureBox
        Friend WithEvents Lbl_Password As Label
        Friend WithEvents Lbl_Username As Label
        Friend WithEvents Lbl_Database_Name As Label
        Friend WithEvents Lbl_Server_Name As Label
        Friend WithEvents Lbl_Ip_Address As Label
        Friend WithEvents Lbl_Connection_Tyepe As Label
        Friend WithEvents Txt_Password As TextBox
        Friend WithEvents Txt_Username As TextBox
        Friend WithEvents Txt_IP_Address As TextBox
        Friend WithEvents Cbo_Databse_Name As ComboBox
        Friend WithEvents Cbo_Server_Name As ComboBox
        Friend WithEvents Cbo_Connection_Type As ComboBox
        Friend WithEvents Btn_Refresh As Button
        Friend WithEvents Trm_Loading As Timer
        Friend WithEvents UIFormTips As ToolTip
        'Required by the Control Designer
        Private components As System.ComponentModel.IContainer
        ' NOTE: The following procedure is required by the Component Designer
        ' It can be modified using the Component Designer.Do not modify it
        ' using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SQLSetting))
            Me.Pnl_Top = New System.Windows.Forms.Panel()
            Me.Lbl_Header = New System.Windows.Forms.Label()
            Me.Pnl_Buttom = New System.Windows.Forms.Panel()
            Me.Btn_Clear = New System.Windows.Forms.Button()
            Me.Btn_Save = New System.Windows.Forms.Button()
            Me.Btn_Close = New System.Windows.Forms.Button()
            Me.Pic_Setting = New System.Windows.Forms.PictureBox()
            Me.Lbl_Password = New System.Windows.Forms.Label()
            Me.Lbl_Username = New System.Windows.Forms.Label()
            Me.Lbl_Database_Name = New System.Windows.Forms.Label()
            Me.Lbl_Server_Name = New System.Windows.Forms.Label()
            Me.Lbl_Ip_Address = New System.Windows.Forms.Label()
            Me.Lbl_Connection_Tyepe = New System.Windows.Forms.Label()
            Me.Txt_Password = New System.Windows.Forms.TextBox()
            Me.Txt_Username = New System.Windows.Forms.TextBox()
            Me.Txt_IP_Address = New System.Windows.Forms.TextBox()
            Me.Cbo_Databse_Name = New System.Windows.Forms.ComboBox()
            Me.Cbo_Server_Name = New System.Windows.Forms.ComboBox()
            Me.Cbo_Connection_Type = New System.Windows.Forms.ComboBox()
            Me.Btn_Refresh = New System.Windows.Forms.Button()
            Me.Trm_Loading = New System.Windows.Forms.Timer(Me.components)
            Me.UIFormTips = New System.Windows.Forms.ToolTip(Me.components)
            Me.Pnl_Top.SuspendLayout()
            Me.Pnl_Buttom.SuspendLayout()
            CType(Me.Pic_Setting, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.Pnl_Top.Size = New System.Drawing.Size(639, 48)
            Me.Pnl_Top.TabIndex = 11
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
            Me.Lbl_Header.Size = New System.Drawing.Size(639, 48)
            Me.Lbl_Header.TabIndex = 10
            Me.Lbl_Header.Text = "       SQL Server Setting"
            Me.Lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Lbl_Header.UseCompatibleTextRendering = True
            '
            'Pnl_Buttom
            '
            Me.Pnl_Buttom.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.Pnl_Buttom.BackgroundImage = CType(resources.GetObject("Pnl_Buttom.BackgroundImage"), System.Drawing.Image)
            Me.Pnl_Buttom.Controls.Add(Me.Btn_Clear)
            Me.Pnl_Buttom.Controls.Add(Me.Btn_Save)
            Me.Pnl_Buttom.Controls.Add(Me.Btn_Close)
            Me.Pnl_Buttom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Pnl_Buttom.Location = New System.Drawing.Point(0, 238)
            Me.Pnl_Buttom.Name = "Pnl_Buttom"
            Me.Pnl_Buttom.Size = New System.Drawing.Size(639, 48)
            Me.Pnl_Buttom.TabIndex = 12
            '
            'Btn_Clear
            '
            Me.Btn_Clear.BackgroundImage = CType(resources.GetObject("Btn_Clear.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Clear.Dock = System.Windows.Forms.DockStyle.Right
            Me.Btn_Clear.FlatAppearance.BorderSize = 0
            Me.Btn_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Clear.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Clear.ForeColor = System.Drawing.Color.White
            Me.Btn_Clear.Image = CType(resources.GetObject("Btn_Clear.Image"), System.Drawing.Image)
            Me.Btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Clear.Location = New System.Drawing.Point(369, 0)
            Me.Btn_Clear.Name = "Btn_Clear"
            Me.Btn_Clear.Size = New System.Drawing.Size(90, 48)
            Me.Btn_Clear.TabIndex = 7
            Me.Btn_Clear.Text = "      CLEAR"
            Me.Btn_Clear.UseVisualStyleBackColor = True
            '
            'Btn_Save
            '
            Me.Btn_Save.BackgroundImage = CType(resources.GetObject("Btn_Save.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Save.Dock = System.Windows.Forms.DockStyle.Right
            Me.Btn_Save.FlatAppearance.BorderSize = 0
            Me.Btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Save.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Save.ForeColor = System.Drawing.Color.White
            Me.Btn_Save.Image = CType(resources.GetObject("Btn_Save.Image"), System.Drawing.Image)
            Me.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Save.Location = New System.Drawing.Point(459, 0)
            Me.Btn_Save.Name = "Btn_Save"
            Me.Btn_Save.Size = New System.Drawing.Size(90, 48)
            Me.Btn_Save.TabIndex = 8
            Me.Btn_Save.Text = "    SAVE"
            Me.Btn_Save.UseVisualStyleBackColor = True
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
            Me.Btn_Close.Location = New System.Drawing.Point(549, 0)
            Me.Btn_Close.Name = "Btn_Close"
            Me.Btn_Close.Size = New System.Drawing.Size(90, 48)
            Me.Btn_Close.TabIndex = 9
            Me.Btn_Close.Text = "      CLOSE"
            Me.Btn_Close.UseVisualStyleBackColor = True
            '
            'Pic_Setting
            '
            Me.Pic_Setting.BackColor = System.Drawing.Color.Transparent
            Me.Pic_Setting.Dock = System.Windows.Forms.DockStyle.Left
            Me.Pic_Setting.Image = CType(resources.GetObject("Pic_Setting.Image"), System.Drawing.Image)
            Me.Pic_Setting.Location = New System.Drawing.Point(0, 48)
            Me.Pic_Setting.Name = "Pic_Setting"
            Me.Pic_Setting.Size = New System.Drawing.Size(176, 190)
            Me.Pic_Setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.Pic_Setting.TabIndex = 6
            Me.Pic_Setting.TabStop = False
            '
            'Lbl_Password
            '
            Me.Lbl_Password.AutoSize = True
            Me.Lbl_Password.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Password.Location = New System.Drawing.Point(198, 206)
            Me.Lbl_Password.Name = "Lbl_Password"
            Me.Lbl_Password.Size = New System.Drawing.Size(85, 20)
            Me.Lbl_Password.TabIndex = 27
            Me.Lbl_Password.Text = "PASSWORD"
            Me.Lbl_Password.UseCompatibleTextRendering = True
            '
            'Lbl_Username
            '
            Me.Lbl_Username.AutoSize = True
            Me.Lbl_Username.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Username.Location = New System.Drawing.Point(198, 178)
            Me.Lbl_Username.Name = "Lbl_Username"
            Me.Lbl_Username.Size = New System.Drawing.Size(86, 20)
            Me.Lbl_Username.TabIndex = 26
            Me.Lbl_Username.Text = "USER NAME"
            Me.Lbl_Username.UseCompatibleTextRendering = True
            '
            'Lbl_Database_Name
            '
            Me.Lbl_Database_Name.AutoSize = True
            Me.Lbl_Database_Name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Database_Name.Location = New System.Drawing.Point(198, 150)
            Me.Lbl_Database_Name.Name = "Lbl_Database_Name"
            Me.Lbl_Database_Name.Size = New System.Drawing.Size(113, 20)
            Me.Lbl_Database_Name.TabIndex = 25
            Me.Lbl_Database_Name.Text = "DATABSE NAME"
            Me.Lbl_Database_Name.UseCompatibleTextRendering = True
            '
            'Lbl_Server_Name
            '
            Me.Lbl_Server_Name.AutoSize = True
            Me.Lbl_Server_Name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Server_Name.Location = New System.Drawing.Point(198, 122)
            Me.Lbl_Server_Name.Name = "Lbl_Server_Name"
            Me.Lbl_Server_Name.Size = New System.Drawing.Size(103, 20)
            Me.Lbl_Server_Name.TabIndex = 24
            Me.Lbl_Server_Name.Text = "SERVER NAME"
            Me.Lbl_Server_Name.UseCompatibleTextRendering = True
            '
            'Lbl_Ip_Address
            '
            Me.Lbl_Ip_Address.AutoSize = True
            Me.Lbl_Ip_Address.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Ip_Address.Location = New System.Drawing.Point(198, 94)
            Me.Lbl_Ip_Address.Name = "Lbl_Ip_Address"
            Me.Lbl_Ip_Address.Size = New System.Drawing.Size(90, 20)
            Me.Lbl_Ip_Address.TabIndex = 23
            Me.Lbl_Ip_Address.Text = "IP ADDRESS"
            Me.Lbl_Ip_Address.UseCompatibleTextRendering = True
            '
            'Lbl_Connection_Tyepe
            '
            Me.Lbl_Connection_Tyepe.AutoSize = True
            Me.Lbl_Connection_Tyepe.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Connection_Tyepe.Location = New System.Drawing.Point(198, 66)
            Me.Lbl_Connection_Tyepe.Name = "Lbl_Connection_Tyepe"
            Me.Lbl_Connection_Tyepe.Size = New System.Drawing.Size(138, 20)
            Me.Lbl_Connection_Tyepe.TabIndex = 22
            Me.Lbl_Connection_Tyepe.Text = "CONNECTION TYPE"
            Me.Lbl_Connection_Tyepe.UseCompatibleTextRendering = True
            '
            'Txt_Password
            '
            Me.Txt_Password.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Password.Location = New System.Drawing.Point(342, 203)
            Me.Txt_Password.Name = "Txt_Password"
            Me.Txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.Txt_Password.Size = New System.Drawing.Size(238, 22)
            Me.Txt_Password.TabIndex = 6
            Me.Txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Txt_Username
            '
            Me.Txt_Username.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Username.Location = New System.Drawing.Point(342, 175)
            Me.Txt_Username.Name = "Txt_Username"
            Me.Txt_Username.Size = New System.Drawing.Size(238, 22)
            Me.Txt_Username.TabIndex = 5
            Me.Txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Txt_IP_Address
            '
            Me.Txt_IP_Address.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_IP_Address.Location = New System.Drawing.Point(342, 91)
            Me.Txt_IP_Address.Name = "Txt_IP_Address"
            Me.Txt_IP_Address.Size = New System.Drawing.Size(238, 22)
            Me.Txt_IP_Address.TabIndex = 1
            '
            'Cbo_Databse_Name
            '
            Me.Cbo_Databse_Name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cbo_Databse_Name.FormattingEnabled = True
            Me.Cbo_Databse_Name.Location = New System.Drawing.Point(342, 147)
            Me.Cbo_Databse_Name.Name = "Cbo_Databse_Name"
            Me.Cbo_Databse_Name.Size = New System.Drawing.Size(238, 22)
            Me.Cbo_Databse_Name.TabIndex = 4
            '
            'Cbo_Server_Name
            '
            Me.Cbo_Server_Name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cbo_Server_Name.FormattingEnabled = True
            Me.Cbo_Server_Name.Location = New System.Drawing.Point(342, 119)
            Me.Cbo_Server_Name.Name = "Cbo_Server_Name"
            Me.Cbo_Server_Name.Size = New System.Drawing.Size(238, 22)
            Me.Cbo_Server_Name.TabIndex = 3
            '
            'Cbo_Connection_Type
            '
            Me.Cbo_Connection_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.Cbo_Connection_Type.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cbo_Connection_Type.FormattingEnabled = True
            Me.Cbo_Connection_Type.Items.AddRange(New Object() {"LAN BASE CONNECTION", "STANDALONE CONNECTION"})
            Me.Cbo_Connection_Type.Location = New System.Drawing.Point(342, 63)
            Me.Cbo_Connection_Type.Name = "Cbo_Connection_Type"
            Me.Cbo_Connection_Type.Size = New System.Drawing.Size(238, 22)
            Me.Cbo_Connection_Type.Sorted = True
            Me.Cbo_Connection_Type.TabIndex = 0
            '
            'Btn_Refresh
            '
            Me.Btn_Refresh.BackColor = System.Drawing.Color.Transparent
            Me.Btn_Refresh.FlatAppearance.BorderSize = 0
            Me.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Refresh.Image = CType(resources.GetObject("Btn_Refresh.Image"), System.Drawing.Image)
            Me.Btn_Refresh.Location = New System.Drawing.Point(586, 113)
            Me.Btn_Refresh.Name = "Btn_Refresh"
            Me.Btn_Refresh.Size = New System.Drawing.Size(32, 32)
            Me.Btn_Refresh.TabIndex = 2
            Me.UIFormTips.SetToolTip(Me.Btn_Refresh, "Refresh to get MS SQL Server")
            Me.Btn_Refresh.UseVisualStyleBackColor = False
            '
            'Trm_Loading
            '
            Me.Trm_Loading.Enabled = True
            Me.Trm_Loading.Interval = 1000
            '
            'SQLSetting
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.Controls.Add(Me.Btn_Refresh)
            Me.Controls.Add(Me.Lbl_Password)
            Me.Controls.Add(Me.Lbl_Username)
            Me.Controls.Add(Me.Lbl_Database_Name)
            Me.Controls.Add(Me.Lbl_Server_Name)
            Me.Controls.Add(Me.Lbl_Ip_Address)
            Me.Controls.Add(Me.Lbl_Connection_Tyepe)
            Me.Controls.Add(Me.Txt_Password)
            Me.Controls.Add(Me.Txt_Username)
            Me.Controls.Add(Me.Txt_IP_Address)
            Me.Controls.Add(Me.Cbo_Databse_Name)
            Me.Controls.Add(Me.Cbo_Server_Name)
            Me.Controls.Add(Me.Cbo_Connection_Type)
            Me.Controls.Add(Me.Pic_Setting)
            Me.Controls.Add(Me.Pnl_Buttom)
            Me.Controls.Add(Me.Pnl_Top)
            Me.ForeColor = System.Drawing.Color.White
            Me.Name = "SQLSetting"
            Me.Size = New System.Drawing.Size(639, 286)
            Me.Pnl_Top.ResumeLayout(False)
            Me.Pnl_Buttom.ResumeLayout(False)
            CType(Me.Pic_Setting, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region
        Private _Servers As SqlDataSourceEnumerator
        Private _TableServers As DataTable
        Private _Server As String
        Private _LunchLoding As Long
        <DefaultValue(False)>
        Public Property SizeLock As Boolean
        Public Property FormTitle As String
        Private ReadOnly _Setting As String = Application.StartupPath & "\SQL_DB_Setting.sql_setting"
        Protected Overrides Sub SetBoundsCore(ByVal x As Integer, ByVal y As Integer, ByVal [width] As Integer, ByVal height As Integer, ByVal specified As System.Windows.Forms.BoundsSpecified)
            MyBase.SetBoundsCore(x, y, 639, 286, specified)
        End Sub
        Private Sub SQLSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            FormTitle = "MS SQL Server Setting"
            clsFeature.SizeLock(SizeLock, ParentForm, FormTitle, Me)
            Cbo_Connection_Type.SelectedIndex = 1
        End Sub
        Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
            Me.ParentForm.Close()
        End Sub
        Private Sub Btn_Refresh_Click(sender As Object, e As EventArgs) Handles Btn_Refresh.Click
            If _TableServers.Rows.Count = 0 Then
                _TableServers = _Servers.GetDataSources()
                Dim listServers As List(Of String) = New List(Of String)
                For Each rowServer As DataRow In _TableServers.Rows
                    If String.IsNullOrEmpty(rowServer("InstanceName").ToString()) Then
                        listServers.Add(rowServer("ServerName").ToString())
                    Else
                        listServers.Add(rowServer("ServerName") & "\" & rowServer("InstanceName"))
                    End If
                Next
                Me.Cbo_Server_Name.DataSource = listServers
            End If
        End Sub
        Private Sub Cbo_Databse_Name_Click(sender As Object, e As EventArgs) Handles Cbo_Databse_Name.Click
            Dim listDataBases As List(Of String) = New List(Of String)
            Dim connectString As String
            Dim selectSQL As String
            If String.IsNullOrWhiteSpace(Me.Cbo_Server_Name.Text) Then
                MessageBox.Show("Must select a server to connect database...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            _Server = Me.Cbo_Server_Name.Text
            connectString = "Data Source=" & _Server & " ;Integrated Security=True;Initial Catalog=master"
            Try
                Using con As New SqlConnection(connectString)
                    con.Open()
                    selectSQL = "select name from sys.databases;"
                    Dim com As SqlCommand = New SqlCommand(selectSQL, con)
                    Dim dr As SqlDataReader = com.ExecuteReader()
                    While (dr.Read())
                        listDataBases.Add(dr(0).ToString())
                    End While
                    Me.Cbo_Databse_Name.DataSource = listDataBases
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub ClearInput()
            Cbo_Server_Name.Text = String.Empty
            Cbo_Databse_Name.Text = String.Empty
            Txt_Username.Clear()
            Txt_Password.Clear()
            Txt_IP_Address.Clear()
        End Sub
        Public Sub SettingFile(ByVal Action As String)
            Select Case Action
                Case "Save"
                    Dim _Values As String = Cbo_Connection_Type.Text & "©" & Txt_IP_Address.Text & "©" &
                    Cbo_Server_Name.Text & "©" & Cbo_Databse_Name.Text & "©" & Txt_Username.Text & "©" &
                    Txt_Password.Text
                    _Values = clsEncryptDecrypt.Encrypt(_Values)
                    My.Computer.FileSystem.WriteAllText(_Setting, _Values, False)
                Case "Load"
                    If My.Computer.FileSystem.FileExists(_Setting) Then
                        Dim _Security As String = My.Computer.FileSystem.ReadAllText(_Setting)
                        If Not String.IsNullOrWhiteSpace(_Security) Then
                            _Security = clsEncryptDecrypt.Decrypt(_Security)
                            Dim _Values As String() = _Security.Split("©")
                            Cbo_Connection_Type.Text = _Values(0)
                            Select Case Cbo_Connection_Type.Text
                                Case "LAN BASE CONNECTION"
                                    Txt_IP_Address.Text = _Values(1)
                                    Cbo_Server_Name.Text = _Values(2)
                                    Cbo_Databse_Name.Text = _Values(3)
                                    Txt_Username.Text = _Values(4)
                                    Txt_Password.Text = _Values(5)
                                Case "STANDALONE CONNECTION"
                                    Cbo_Server_Name.Text = _Values(2)
                                    Cbo_Databse_Name.Text = _Values(3)
                            End Select
                            ServerConnection()
                        End If
                    End If
            End Select
        End Sub
        Public Function ServerConnection() As Boolean
            Try
                Select Case Cbo_Connection_Type.Text
                    Case "LAN BASE CONNECTION"
                        ' MS SQL Sevrer network
                        UICode.Database.ConnectionString.sqlConnectionString = "Provider=SQLOLEDB;" &
                         "Data Source=" & Txt_IP_Address.Text &
                         ";Network=" & Cbo_Server_Name.Text &
                         ";Server=" & Cbo_Server_Name.Text &
                         ";Initial Catalog=" & Cbo_Databse_Name.Text &
                         ";User Id=" & Txt_Username.Text &
                         ";Password=" & Txt_Password.Text
                    Case "STANDALONE CONNECTION"
                        ' MS SQL Sevrer local
                        UICode.Database.ConnectionString.sqlConnectionString = "Provider=SQLOLEDB;Server=" & Cbo_Server_Name.Text &
                        ";Database=" & Cbo_Databse_Name.Text & "; Trusted_Connection=yes;"
                End Select
                Dim sqlConnectionStringTest As New OleDbConnection With {
                .ConnectionString = UICode.Database.ConnectionString.sqlConnectionString
                }
                sqlConnectionStringTest.Open()
                ServerConnection = True
                sqlConnectionStringTest.Close()
            Catch ex As Exception
                If Err.Number = 5 Then
                    If Not String.IsNullOrWhiteSpace(Cbo_Connection_Type.Text) Then MessageBox.Show("Database or SQL sever setting was invalid!", "SQL Sever Setting Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                ServerConnection = False
            End Try
        End Function
        Private Sub Cbo_Connection_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Connection_Type.SelectedIndexChanged
            ClearInput()
            Select Case Cbo_Connection_Type.Text
                Case "LAN BASE CONNECTION"
                    Txt_IP_Address.Enabled = True
                    Txt_Password.Enabled = True
                    Cbo_Server_Name.Enabled = True
                    Txt_Username.Enabled = True
                    Txt_IP_Address.Focus()
                Case "STANDALONE CONNECTION"
                    Txt_IP_Address.Enabled = False
                    Txt_Password.Enabled = False
                    Txt_Username.Enabled = False
                    Cbo_Server_Name.Focus()
            End Select
        End Sub
        Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
            ClearInput()
        End Sub
        Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
            SettingFile("Save")
            If ServerConnection() = False Then Exit Sub
            MessageBox.Show("Sucessfully Connected", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ParentForm.Close()
        End Sub
        Private Sub Trm_Loading_Tick(sender As Object, e As EventArgs) Handles Trm_Loading.Tick
            _LunchLoding += 1
            If _LunchLoding = 1 Then
                Trm_Loading.Enabled = False
                SettingFile("Load")
            End If
        End Sub
        Private Sub SQLSetting_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
            ucSQLSetting = Nothing
            frmSQLSetting = Nothing
        End Sub
    End Class
End Namespace