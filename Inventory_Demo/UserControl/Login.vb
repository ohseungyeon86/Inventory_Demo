Imports System.ComponentModel
Namespace UIForm
    ' Build Action Embedded Resource
    <ToolboxBitmap(GetType(Login), "Login.ico"), ToolboxItem(False)>
    Public Class Login
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
        Friend WithEvents Lbl_Login_Id As Label
        Friend WithEvents Cbo_Login_Id As ComboBox
        Friend WithEvents Txt_Login_Id As TextBox
        Friend WithEvents Btn_Add_Login_Id As Button
        Friend WithEvents Btn_Edit_Login_Id As Button
        Friend WithEvents Btn_Del_Login_Id As Button
        Friend WithEvents Lbl_Login_Name As Label
        Friend WithEvents Txt_Login_Name As TextBox
        Friend WithEvents Lbl_Login_Password As Label
        Friend WithEvents Txt_Login_Password As TextBox
        Friend WithEvents Lbl_Login_Phone As Label
        Friend WithEvents Txt_Login_Phone As TextBox
        Friend WithEvents Lbl_Login_Mail As Label
        Friend WithEvents Txt_Login_Mail As TextBox
        Friend WithEvents Lbl_Login_Permission As Label
        Friend WithEvents Txt_Login_Permission As TextBox
        Friend WithEvents Lbl_Header As Label
        Friend WithEvents UIFormTips As ToolTip
        Friend WithEvents Pnl_Top As Panel
        Friend WithEvents Pnl_Bottom As Panel
        Friend WithEvents Btn_Exit As Button
        Friend WithEvents Btn_Save As Button
        Friend WithEvents Btn_New As Button
        'Required by the Control Designer
        Private components As IContainer
        ' NOTE: The following procedure is required by the Component Designer
        ' It can be modified using the Component Designer.Do not modify it
        ' using the code editor.
        <DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
            Me.Lbl_Login_Id = New System.Windows.Forms.Label()
            Me.Cbo_Login_Id = New System.Windows.Forms.ComboBox()
            Me.Txt_Login_Id = New System.Windows.Forms.TextBox()
            Me.Btn_Add_Login_Id = New System.Windows.Forms.Button()
            Me.Btn_Edit_Login_Id = New System.Windows.Forms.Button()
            Me.Btn_Del_Login_Id = New System.Windows.Forms.Button()
            Me.Lbl_Login_Name = New System.Windows.Forms.Label()
            Me.Txt_Login_Name = New System.Windows.Forms.TextBox()
            Me.Lbl_Login_Password = New System.Windows.Forms.Label()
            Me.Txt_Login_Password = New System.Windows.Forms.TextBox()
            Me.Lbl_Login_Phone = New System.Windows.Forms.Label()
            Me.Txt_Login_Phone = New System.Windows.Forms.TextBox()
            Me.Lbl_Login_Mail = New System.Windows.Forms.Label()
            Me.Txt_Login_Mail = New System.Windows.Forms.TextBox()
            Me.Lbl_Login_Permission = New System.Windows.Forms.Label()
            Me.Txt_Login_Permission = New System.Windows.Forms.TextBox()
            Me.Lbl_Header = New System.Windows.Forms.Label()
            Me.UIFormTips = New System.Windows.Forms.ToolTip(Me.components)
            Me.Btn_Exit = New System.Windows.Forms.Button()
            Me.Btn_Save = New System.Windows.Forms.Button()
            Me.Btn_New = New System.Windows.Forms.Button()
            Me.Pnl_Top = New System.Windows.Forms.Panel()
            Me.Pnl_Bottom = New System.Windows.Forms.Panel()
            Me.Pnl_Top.SuspendLayout()
            Me.Pnl_Bottom.SuspendLayout()
            Me.SuspendLayout()
            '
            'Lbl_Login_Id
            '
            Me.Lbl_Login_Id.AutoSize = True
            Me.Lbl_Login_Id.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Login_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Login_Id.ForeColor = System.Drawing.Color.White
            Me.Lbl_Login_Id.Location = New System.Drawing.Point(18, 62)
            Me.Lbl_Login_Id.Name = "Lbl_Login_Id"
            Me.Lbl_Login_Id.Size = New System.Drawing.Size(26, 14)
            Me.Lbl_Login_Id.TabIndex = 0
            Me.Lbl_Login_Id.Text = "Id:"
            '
            'Cbo_Login_Id
            '
            Me.Cbo_Login_Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.Cbo_Login_Id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.Cbo_Login_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cbo_Login_Id.FormattingEnabled = True
            Me.Cbo_Login_Id.Location = New System.Drawing.Point(109, 59)
            Me.Cbo_Login_Id.Name = "Cbo_Login_Id"
            Me.Cbo_Login_Id.Size = New System.Drawing.Size(200, 22)
            Me.Cbo_Login_Id.TabIndex = 0
            '
            'Txt_Login_Id
            '
            Me.Txt_Login_Id.BackColor = System.Drawing.SystemColors.Window
            Me.Txt_Login_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Login_Id.ForeColor = System.Drawing.Color.Black
            Me.Txt_Login_Id.Location = New System.Drawing.Point(317, 59)
            Me.Txt_Login_Id.Name = "Txt_Login_Id"
            Me.Txt_Login_Id.ReadOnly = True
            Me.Txt_Login_Id.Size = New System.Drawing.Size(40, 22)
            Me.Txt_Login_Id.TabIndex = 0
            Me.Txt_Login_Id.TabStop = False
            Me.Txt_Login_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Btn_Add_Login_Id
            '
            Me.Btn_Add_Login_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Add_Login_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Add_Login_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Add_Login_Id.Image = CType(resources.GetObject("Btn_Add_Login_Id.Image"), System.Drawing.Image)
            Me.Btn_Add_Login_Id.Location = New System.Drawing.Point(365, 56)
            Me.Btn_Add_Login_Id.Name = "Btn_Add_Login_Id"
            Me.Btn_Add_Login_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Add_Login_Id.TabIndex = 0
            Me.Btn_Add_Login_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Add_Login_Id, "Add")
            Me.Btn_Add_Login_Id.UseVisualStyleBackColor = True
            '
            'Btn_Edit_Login_Id
            '
            Me.Btn_Edit_Login_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Edit_Login_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Edit_Login_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Edit_Login_Id.Image = CType(resources.GetObject("Btn_Edit_Login_Id.Image"), System.Drawing.Image)
            Me.Btn_Edit_Login_Id.Location = New System.Drawing.Point(401, 56)
            Me.Btn_Edit_Login_Id.Name = "Btn_Edit_Login_Id"
            Me.Btn_Edit_Login_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Edit_Login_Id.TabIndex = 0
            Me.Btn_Edit_Login_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Edit_Login_Id, "Edit")
            Me.Btn_Edit_Login_Id.UseVisualStyleBackColor = True
            '
            'Btn_Del_Login_Id
            '
            Me.Btn_Del_Login_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Del_Login_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Del_Login_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Del_Login_Id.Image = CType(resources.GetObject("Btn_Del_Login_Id.Image"), System.Drawing.Image)
            Me.Btn_Del_Login_Id.Location = New System.Drawing.Point(437, 56)
            Me.Btn_Del_Login_Id.Name = "Btn_Del_Login_Id"
            Me.Btn_Del_Login_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Del_Login_Id.TabIndex = 0
            Me.Btn_Del_Login_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Del_Login_Id, "Delete")
            Me.Btn_Del_Login_Id.UseVisualStyleBackColor = True
            '
            'Lbl_Login_Name
            '
            Me.Lbl_Login_Name.AutoSize = True
            Me.Lbl_Login_Name.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Login_Name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Login_Name.ForeColor = System.Drawing.Color.White
            Me.Lbl_Login_Name.Location = New System.Drawing.Point(18, 88)
            Me.Lbl_Login_Name.Name = "Lbl_Login_Name"
            Me.Lbl_Login_Name.Size = New System.Drawing.Size(50, 14)
            Me.Lbl_Login_Name.TabIndex = 1
            Me.Lbl_Login_Name.Text = "Name:"
            '
            'Txt_Login_Name
            '
            Me.Txt_Login_Name.BackColor = System.Drawing.Color.White
            Me.Txt_Login_Name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Login_Name.ForeColor = System.Drawing.Color.Black
            Me.Txt_Login_Name.Location = New System.Drawing.Point(109, 85)
            Me.Txt_Login_Name.Name = "Txt_Login_Name"
            Me.Txt_Login_Name.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Login_Name.TabIndex = 1
            '
            'Lbl_Login_Password
            '
            Me.Lbl_Login_Password.AutoSize = True
            Me.Lbl_Login_Password.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Login_Password.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Login_Password.ForeColor = System.Drawing.Color.White
            Me.Lbl_Login_Password.Location = New System.Drawing.Point(18, 114)
            Me.Lbl_Login_Password.Name = "Lbl_Login_Password"
            Me.Lbl_Login_Password.Size = New System.Drawing.Size(77, 14)
            Me.Lbl_Login_Password.TabIndex = 2
            Me.Lbl_Login_Password.Text = "Password:"
            '
            'Txt_Login_Password
            '
            Me.Txt_Login_Password.BackColor = System.Drawing.Color.White
            Me.Txt_Login_Password.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Login_Password.ForeColor = System.Drawing.Color.Black
            Me.Txt_Login_Password.Location = New System.Drawing.Point(109, 111)
            Me.Txt_Login_Password.Name = "Txt_Login_Password"
            Me.Txt_Login_Password.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Login_Password.TabIndex = 2
            '
            'Lbl_Login_Phone
            '
            Me.Lbl_Login_Phone.AutoSize = True
            Me.Lbl_Login_Phone.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Login_Phone.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Login_Phone.ForeColor = System.Drawing.Color.White
            Me.Lbl_Login_Phone.Location = New System.Drawing.Point(18, 140)
            Me.Lbl_Login_Phone.Name = "Lbl_Login_Phone"
            Me.Lbl_Login_Phone.Size = New System.Drawing.Size(53, 14)
            Me.Lbl_Login_Phone.TabIndex = 3
            Me.Lbl_Login_Phone.Text = "Phone:"
            '
            'Txt_Login_Phone
            '
            Me.Txt_Login_Phone.BackColor = System.Drawing.Color.White
            Me.Txt_Login_Phone.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Login_Phone.ForeColor = System.Drawing.Color.Black
            Me.Txt_Login_Phone.Location = New System.Drawing.Point(109, 137)
            Me.Txt_Login_Phone.Name = "Txt_Login_Phone"
            Me.Txt_Login_Phone.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Login_Phone.TabIndex = 3
            '
            'Lbl_Login_Mail
            '
            Me.Lbl_Login_Mail.AutoSize = True
            Me.Lbl_Login_Mail.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Login_Mail.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Login_Mail.ForeColor = System.Drawing.Color.White
            Me.Lbl_Login_Mail.Location = New System.Drawing.Point(18, 166)
            Me.Lbl_Login_Mail.Name = "Lbl_Login_Mail"
            Me.Lbl_Login_Mail.Size = New System.Drawing.Size(39, 14)
            Me.Lbl_Login_Mail.TabIndex = 4
            Me.Lbl_Login_Mail.Text = "Mail:"
            '
            'Txt_Login_Mail
            '
            Me.Txt_Login_Mail.BackColor = System.Drawing.Color.White
            Me.Txt_Login_Mail.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Login_Mail.ForeColor = System.Drawing.Color.Black
            Me.Txt_Login_Mail.Location = New System.Drawing.Point(109, 163)
            Me.Txt_Login_Mail.Name = "Txt_Login_Mail"
            Me.Txt_Login_Mail.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Login_Mail.TabIndex = 4
            '
            'Lbl_Login_Permission
            '
            Me.Lbl_Login_Permission.AutoSize = True
            Me.Lbl_Login_Permission.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Login_Permission.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Login_Permission.ForeColor = System.Drawing.Color.White
            Me.Lbl_Login_Permission.Location = New System.Drawing.Point(18, 192)
            Me.Lbl_Login_Permission.Name = "Lbl_Login_Permission"
            Me.Lbl_Login_Permission.Size = New System.Drawing.Size(85, 14)
            Me.Lbl_Login_Permission.TabIndex = 5
            Me.Lbl_Login_Permission.Text = "Permission:"
            '
            'Txt_Login_Permission
            '
            Me.Txt_Login_Permission.BackColor = System.Drawing.Color.White
            Me.Txt_Login_Permission.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Login_Permission.ForeColor = System.Drawing.Color.Black
            Me.Txt_Login_Permission.Location = New System.Drawing.Point(109, 189)
            Me.Txt_Login_Permission.Name = "Txt_Login_Permission"
            Me.Txt_Login_Permission.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Login_Permission.TabIndex = 5
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
            Me.Lbl_Header.Size = New System.Drawing.Size(485, 48)
            Me.Lbl_Header.TabIndex = 28
            Me.Lbl_Header.Text = "       Add Login Here !!!"
            Me.Lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
            Me.Btn_Exit.Location = New System.Drawing.Point(395, 0)
            Me.Btn_Exit.Name = "Btn_Exit"
            Me.Btn_Exit.Size = New System.Drawing.Size(90, 48)
            Me.Btn_Exit.TabIndex = 6
            Me.Btn_Exit.Text = "EXIT"
            Me.Btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.UIFormTips.SetToolTip(Me.Btn_Exit, "Exit")
            Me.Btn_Exit.UseVisualStyleBackColor = True
            '
            'Btn_Save
            '
            Me.Btn_Save.BackgroundImage = CType(resources.GetObject("Btn_Save.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Save.Dock = System.Windows.Forms.DockStyle.Right
            Me.Btn_Save.FlatAppearance.BorderSize = 0
            Me.Btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Save.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Save.ForeColor = System.Drawing.Color.White
            Me.Btn_Save.Image = CType(resources.GetObject("Btn_Save.Image"), System.Drawing.Image)
            Me.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Save.Location = New System.Drawing.Point(305, 0)
            Me.Btn_Save.Name = "Btn_Save"
            Me.Btn_Save.Size = New System.Drawing.Size(90, 48)
            Me.Btn_Save.TabIndex = 5
            Me.Btn_Save.Text = "SAVE"
            Me.Btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.UIFormTips.SetToolTip(Me.Btn_Save, "Save")
            Me.Btn_Save.UseVisualStyleBackColor = True
            '
            'Btn_New
            '
            Me.Btn_New.BackgroundImage = CType(resources.GetObject("Btn_New.BackgroundImage"), System.Drawing.Image)
            Me.Btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_New.Dock = System.Windows.Forms.DockStyle.Right
            Me.Btn_New.FlatAppearance.BorderSize = 0
            Me.Btn_New.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_New.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_New.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_New.ForeColor = System.Drawing.Color.White
            Me.Btn_New.Image = CType(resources.GetObject("Btn_New.Image"), System.Drawing.Image)
            Me.Btn_New.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_New.Location = New System.Drawing.Point(215, 0)
            Me.Btn_New.Name = "Btn_New"
            Me.Btn_New.Size = New System.Drawing.Size(90, 48)
            Me.Btn_New.TabIndex = 4
            Me.Btn_New.Text = "NEW"
            Me.Btn_New.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.UIFormTips.SetToolTip(Me.Btn_New, "New")
            Me.Btn_New.UseVisualStyleBackColor = True
            '
            'Pnl_Top
            '
            Me.Pnl_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.Pnl_Top.BackgroundImage = CType(resources.GetObject("Pnl_Top.BackgroundImage"), System.Drawing.Image)
            Me.Pnl_Top.Controls.Add(Me.Lbl_Header)
            Me.Pnl_Top.Dock = System.Windows.Forms.DockStyle.Top
            Me.Pnl_Top.Location = New System.Drawing.Point(0, 0)
            Me.Pnl_Top.Name = "Pnl_Top"
            Me.Pnl_Top.Size = New System.Drawing.Size(485, 48)
            Me.Pnl_Top.TabIndex = 61
            '
            'Pnl_Bottom
            '
            Me.Pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.Pnl_Bottom.BackgroundImage = CType(resources.GetObject("Pnl_Bottom.BackgroundImage"), System.Drawing.Image)
            Me.Pnl_Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Pnl_Bottom.Controls.Add(Me.Btn_New)
            Me.Pnl_Bottom.Controls.Add(Me.Btn_Save)
            Me.Pnl_Bottom.Controls.Add(Me.Btn_Exit)
            Me.Pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Pnl_Bottom.Location = New System.Drawing.Point(0, 222)
            Me.Pnl_Bottom.Name = "Pnl_Bottom"
            Me.Pnl_Bottom.Size = New System.Drawing.Size(485, 48)
            Me.Pnl_Bottom.TabIndex = 74
            '
            'Login
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.Controls.Add(Me.Lbl_Login_Id)
            Me.Controls.Add(Me.Cbo_Login_Id)
            Me.Controls.Add(Me.Txt_Login_Id)
            Me.Controls.Add(Me.Btn_Add_Login_Id)
            Me.Controls.Add(Me.Btn_Edit_Login_Id)
            Me.Controls.Add(Me.Btn_Del_Login_Id)
            Me.Controls.Add(Me.Lbl_Login_Name)
            Me.Controls.Add(Me.Txt_Login_Name)
            Me.Controls.Add(Me.Lbl_Login_Password)
            Me.Controls.Add(Me.Txt_Login_Password)
            Me.Controls.Add(Me.Lbl_Login_Phone)
            Me.Controls.Add(Me.Txt_Login_Phone)
            Me.Controls.Add(Me.Lbl_Login_Mail)
            Me.Controls.Add(Me.Txt_Login_Mail)
            Me.Controls.Add(Me.Lbl_Login_Permission)
            Me.Controls.Add(Me.Txt_Login_Permission)
            Me.Controls.Add(Me.Pnl_Bottom)
            Me.Controls.Add(Me.Pnl_Top)
            Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.Black
            Me.Name = "Login"
            Me.Size = New System.Drawing.Size(485, 270)
            Me.Pnl_Top.ResumeLayout(False)
            Me.Pnl_Bottom.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region
#Region " Component Events "
        <DefaultValue(False)>
        Public Property SizeLock As Boolean
        Public Property FormTitle As String
        Private Property ComboBoxUpdate As Boolean
        Private m_AddEdit As String = String.Empty
        Public Property AddEdit As String
            Get
                Return m_AddEdit
            End Get
            Set(value As String)
                m_AddEdit = value
                If m_AddEdit = "Add" Then
                    Lbl_Header.Text = Lbl_Header.Text.Replace("Edit", "Add")
                ElseIf m_AddEdit = "Edit" Then
                    Lbl_Header.Text = Lbl_Header.Text.Replace("Add", "Edit")
                End If
            End Set
        End Property
        Protected Overrides Sub SetBoundsCore(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal specified As System.Windows.Forms.BoundsSpecified)
            MyBase.SetBoundsCore(x, y, 485, 270, specified)
        End Sub
        Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            FormTitle = "Login"
            clsFeature.SizeLock(SizeLock, ParentForm, FormTitle, Me)
            Cbo_Login_Id.SelectedIndex = -1
            AddEdit = "Add"
        End Sub
        Private Sub Login_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
            clsLogin.BoundComboBox(Cbo_Login_Id)
        End Sub
        Private Sub Login_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
            ucLogin = Nothing
            frmLogin = Nothing
        End Sub
        Private Sub Btn_Add_Login_Id_Click(sender As Object, e As EventArgs) Handles Btn_Add_Login_Id.Click
            Btn_New.PerformClick()
        End Sub
        Private Sub Btn_Edit_Login_Id_Click(sender As Object, e As EventArgs) Handles Btn_Edit_Login_Id.Click
            clsLogin.Load(Txt_Login_Id, Txt_Login_Name, Txt_Login_Password, Txt_Login_Phone, Txt_Login_Mail, Txt_Login_Permission)
            If Not String.IsNullOrWhiteSpace(Txt_Login_Id.Text) Then AddEdit = "Edit"
            If Not String.IsNullOrWhiteSpace(Txt_Login_Id.Text) Then Cbo_Login_Id.SelectedValue = Txt_Login_Id.Text
        End Sub
        Private Sub Btn_Del_Login_Id_Click(sender As Object, e As EventArgs) Handles Btn_Del_Login_Id.Click
            clsLogin.Delete(Txt_Login_Id, Txt_Login_Name, Txt_Login_Password, Txt_Login_Phone, Txt_Login_Mail, Txt_Login_Permission)
            clsLogin.BoundComboBox(Cbo_Login_Id)
        End Sub
        Private Sub Cbo_Login_Id_GotFocus(sender As Object, e As EventArgs) Handles Cbo_Login_Id.GotFocus
            If Cbo_Login_Id.SelectedIndex = -1 Then ComboBoxUpdate = True
        End Sub
        Private Sub Cbo_Login_Id_DropDown(sender As Object, e As EventArgs) Handles Cbo_Login_Id.DropDown
            clsLogin.BoundComboBox(Cbo_Login_Id)
        End Sub
        Private Sub Cbo_Login_Id_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Cbo_Login_Id.PreviewKeyDown
            If ComboBoxUpdate = True Then
                clsLogin.BoundComboBox(Cbo_Login_Id)
                ComboBoxUpdate = False
            End If
        End Sub
        Private Sub Cbo_Login_Id_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cbo_Login_Id.SelectionChangeCommitted
            If Not Cbo_Login_Id.SelectedIndex = -1 Then Txt_Login_Id.Text = Cbo_Login_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_Login_Id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Login_Id.SelectedIndexChanged
            If Not Cbo_Login_Id.SelectedIndex = -1 Then Txt_Login_Id.Text = Cbo_Login_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_Login_Id_LostFocus(sender As Object, e As EventArgs) Handles Cbo_Login_Id.LostFocus
            If Cbo_Login_Id.SelectedIndex = -1 Then
                Cbo_Login_Id.Text = String.Empty
                Txt_Login_Id.Clear()
            End If
        End Sub
        Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
            clsLogin.Clear(Txt_Login_Id, Txt_Login_Name, Txt_Login_Password, Txt_Login_Phone, Txt_Login_Mail, Txt_Login_Permission)
            AddEdit = "Add"
        End Sub
        Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
            clsLogin.Auto(True, AddEdit, Txt_Login_Id, Txt_Login_Name, Txt_Login_Password, Txt_Login_Phone, Txt_Login_Mail, Txt_Login_Permission)
            Cbo_Login_Id.SelectedIndex = -1
            AddEdit = "Add"
        End Sub
        Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
            Me.ParentForm.Close()
        End Sub
#End Region
    End Class
End Namespace