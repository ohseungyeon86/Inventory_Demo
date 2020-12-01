Imports System.ComponentModel
Namespace UIForm
    ' Build Action Embedded Resource
    <ToolboxBitmap(GetType(Search), "Search.ico"), ToolboxItem(False)>
    Public Class Search
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
        Friend WithEvents Lbl_Fields As Label
        Friend WithEvents Cbo_Fields As ComboBox
        Friend WithEvents Txt_Search As TextBox
        Friend WithEvents Lbl_Txt_To As Label
        Friend WithEvents Btn_Number_Search As Button
        Friend WithEvents Txt_Form As TextBox
        Friend WithEvents Txt_To As TextBox
        Friend WithEvents Lbl_Txt_Form As Label
        Friend WithEvents Dtp_To As DateTimePicker
        Friend WithEvents Dtp_Form As DateTimePicker
        Friend WithEvents Lbl_Dtp_To As Label
        Friend WithEvents Btn_Date_Search As Button
        Friend WithEvents Lbl_Dtp_Form As Label
        Friend WithEvents Pnl_Date_Search As Panel
        Friend WithEvents Pnl_Number_Search As Panel
        Friend WithEvents Pnl_Text_Search As Panel
        Friend WithEvents Pnl_List_Search As Panel
        Friend WithEvents Txt_Records As TextBox
        Friend WithEvents Cbo_Records As ComboBox
        Friend WithEvents Lbl_List_ORecord As Label
        Friend WithEvents Btn_List_Search As Button
        Friend WithEvents Btn_Add_Records As Button
        Friend WithEvents Lbl_Type_TSearch As Label
        Friend WithEvents Lbl_Number_Min As Label
        Friend WithEvents Lbl_Date_Min As Label
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents PictureBox2 As PictureBox
        Friend WithEvents PictureBox3 As PictureBox
        'Required by the Control Designer
        Private components As IContainer
        ' NOTE: The following procedure is required by the Component Designer
        ' It can be modified using the Component Designer.Do not modify it
        ' using the code editor.
        <DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search))
            Me.Pnl_Top = New System.Windows.Forms.Panel()
            Me.Lbl_Header = New System.Windows.Forms.Label()
            Me.Pnl_Bottom = New System.Windows.Forms.Panel()
            Me.Btn_Exit = New System.Windows.Forms.Button()
            Me.Lbl_Fields = New System.Windows.Forms.Label()
            Me.Cbo_Fields = New System.Windows.Forms.ComboBox()
            Me.Txt_Search = New System.Windows.Forms.TextBox()
            Me.Txt_To = New System.Windows.Forms.TextBox()
            Me.Lbl_Txt_Form = New System.Windows.Forms.Label()
            Me.Txt_Form = New System.Windows.Forms.TextBox()
            Me.Btn_Number_Search = New System.Windows.Forms.Button()
            Me.Lbl_Txt_To = New System.Windows.Forms.Label()
            Me.Lbl_Dtp_To = New System.Windows.Forms.Label()
            Me.Btn_Date_Search = New System.Windows.Forms.Button()
            Me.Lbl_Dtp_Form = New System.Windows.Forms.Label()
            Me.Dtp_Form = New System.Windows.Forms.DateTimePicker()
            Me.Dtp_To = New System.Windows.Forms.DateTimePicker()
            Me.Pnl_Date_Search = New System.Windows.Forms.Panel()
            Me.Lbl_Date_Min = New System.Windows.Forms.Label()
            Me.Pnl_Number_Search = New System.Windows.Forms.Panel()
            Me.Lbl_Number_Min = New System.Windows.Forms.Label()
            Me.Pnl_Text_Search = New System.Windows.Forms.Panel()
            Me.Lbl_Type_TSearch = New System.Windows.Forms.Label()
            Me.Pnl_List_Search = New System.Windows.Forms.Panel()
            Me.Btn_List_Search = New System.Windows.Forms.Button()
            Me.Btn_Add_Records = New System.Windows.Forms.Button()
            Me.Cbo_Records = New System.Windows.Forms.ComboBox()
            Me.Lbl_List_ORecord = New System.Windows.Forms.Label()
            Me.Txt_Records = New System.Windows.Forms.TextBox()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.PictureBox2 = New System.Windows.Forms.PictureBox()
            Me.PictureBox3 = New System.Windows.Forms.PictureBox()
            Me.Pnl_Top.SuspendLayout()
            Me.Pnl_Bottom.SuspendLayout()
            Me.Pnl_Date_Search.SuspendLayout()
            Me.Pnl_Number_Search.SuspendLayout()
            Me.Pnl_Text_Search.SuspendLayout()
            Me.Pnl_List_Search.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.Pnl_Top.Size = New System.Drawing.Size(809, 48)
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
            Me.Lbl_Header.Size = New System.Drawing.Size(809, 48)
            Me.Lbl_Header.TabIndex = 28
            Me.Lbl_Header.Text = "       Search !!!"
            Me.Lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Pnl_Bottom
            '
            Me.Pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.Pnl_Bottom.BackgroundImage = CType(resources.GetObject("Pnl_Bottom.BackgroundImage"), System.Drawing.Image)
            Me.Pnl_Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Pnl_Bottom.Controls.Add(Me.Btn_Exit)
            Me.Pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Pnl_Bottom.Location = New System.Drawing.Point(0, 334)
            Me.Pnl_Bottom.Name = "Pnl_Bottom"
            Me.Pnl_Bottom.Size = New System.Drawing.Size(809, 48)
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
            Me.Btn_Exit.Location = New System.Drawing.Point(719, 0)
            Me.Btn_Exit.Name = "Btn_Exit"
            Me.Btn_Exit.Size = New System.Drawing.Size(90, 48)
            Me.Btn_Exit.TabIndex = 6
            Me.Btn_Exit.Text = "EXIT"
            Me.Btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Btn_Exit.UseVisualStyleBackColor = True
            '
            'Lbl_Fields
            '
            Me.Lbl_Fields.AutoSize = True
            Me.Lbl_Fields.Location = New System.Drawing.Point(19, 19)
            Me.Lbl_Fields.Name = "Lbl_Fields"
            Me.Lbl_Fields.Size = New System.Drawing.Size(113, 14)
            Me.Lbl_Fields.TabIndex = 76
            Me.Lbl_Fields.Text = "Select to search"
            '
            'Cbo_Fields
            '
            Me.Cbo_Fields.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.Cbo_Fields.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.Cbo_Fields.FormattingEnabled = True
            Me.Cbo_Fields.Location = New System.Drawing.Point(138, 16)
            Me.Cbo_Fields.Name = "Cbo_Fields"
            Me.Cbo_Fields.Size = New System.Drawing.Size(248, 22)
            Me.Cbo_Fields.TabIndex = 77
            '
            'Txt_Search
            '
            Me.Txt_Search.Location = New System.Drawing.Point(138, 46)
            Me.Txt_Search.Name = "Txt_Search"
            Me.Txt_Search.Size = New System.Drawing.Size(248, 22)
            Me.Txt_Search.TabIndex = 78
            '
            'Txt_To
            '
            Me.Txt_To.Location = New System.Drawing.Point(106, 46)
            Me.Txt_To.Name = "Txt_To"
            Me.Txt_To.Size = New System.Drawing.Size(157, 22)
            Me.Txt_To.TabIndex = 78
            '
            'Lbl_Txt_Form
            '
            Me.Lbl_Txt_Form.AutoSize = True
            Me.Lbl_Txt_Form.Location = New System.Drawing.Point(12, 19)
            Me.Lbl_Txt_Form.Name = "Lbl_Txt_Form"
            Me.Lbl_Txt_Form.Size = New System.Drawing.Size(88, 14)
            Me.Lbl_Txt_Form.TabIndex = 76
            Me.Lbl_Txt_Form.Text = "Search form"
            '
            'Txt_Form
            '
            Me.Txt_Form.Location = New System.Drawing.Point(106, 16)
            Me.Txt_Form.Name = "Txt_Form"
            Me.Txt_Form.Size = New System.Drawing.Size(157, 22)
            Me.Txt_Form.TabIndex = 79
            '
            'Btn_Number_Search
            '
            Me.Btn_Number_Search.BackgroundImage = CType(resources.GetObject("Btn_Number_Search.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Number_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Number_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Number_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Number_Search.Image = CType(resources.GetObject("Btn_Number_Search.Image"), System.Drawing.Image)
            Me.Btn_Number_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Number_Search.Location = New System.Drawing.Point(274, 40)
            Me.Btn_Number_Search.Name = "Btn_Number_Search"
            Me.Btn_Number_Search.Size = New System.Drawing.Size(112, 31)
            Me.Btn_Number_Search.TabIndex = 80
            Me.Btn_Number_Search.Text = "    SEARCH"
            Me.Btn_Number_Search.UseVisualStyleBackColor = True
            '
            'Lbl_Txt_To
            '
            Me.Lbl_Txt_To.AutoSize = True
            Me.Lbl_Txt_To.Location = New System.Drawing.Point(12, 54)
            Me.Lbl_Txt_To.Name = "Lbl_Txt_To"
            Me.Lbl_Txt_To.Size = New System.Drawing.Size(70, 14)
            Me.Lbl_Txt_To.TabIndex = 81
            Me.Lbl_Txt_To.Text = "To (MAX)"
            '
            'Lbl_Dtp_To
            '
            Me.Lbl_Dtp_To.AutoSize = True
            Me.Lbl_Dtp_To.Location = New System.Drawing.Point(10, 49)
            Me.Lbl_Dtp_To.Name = "Lbl_Dtp_To"
            Me.Lbl_Dtp_To.Size = New System.Drawing.Size(70, 14)
            Me.Lbl_Dtp_To.TabIndex = 81
            Me.Lbl_Dtp_To.Text = "To (MAX)"
            '
            'Btn_Date_Search
            '
            Me.Btn_Date_Search.BackgroundImage = CType(resources.GetObject("Btn_Date_Search.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Date_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Date_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Date_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Date_Search.Image = CType(resources.GetObject("Btn_Date_Search.Image"), System.Drawing.Image)
            Me.Btn_Date_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Date_Search.Location = New System.Drawing.Point(274, 41)
            Me.Btn_Date_Search.Name = "Btn_Date_Search"
            Me.Btn_Date_Search.Size = New System.Drawing.Size(112, 31)
            Me.Btn_Date_Search.TabIndex = 80
            Me.Btn_Date_Search.Text = "    SEARCH"
            Me.Btn_Date_Search.UseVisualStyleBackColor = True
            '
            'Lbl_Dtp_Form
            '
            Me.Lbl_Dtp_Form.AutoSize = True
            Me.Lbl_Dtp_Form.Location = New System.Drawing.Point(10, 19)
            Me.Lbl_Dtp_Form.Name = "Lbl_Dtp_Form"
            Me.Lbl_Dtp_Form.Size = New System.Drawing.Size(88, 14)
            Me.Lbl_Dtp_Form.TabIndex = 76
            Me.Lbl_Dtp_Form.Text = "Search form"
            '
            'Dtp_Form
            '
            Me.Dtp_Form.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.Dtp_Form.Location = New System.Drawing.Point(106, 13)
            Me.Dtp_Form.Name = "Dtp_Form"
            Me.Dtp_Form.Size = New System.Drawing.Size(157, 22)
            Me.Dtp_Form.TabIndex = 82
            '
            'Dtp_To
            '
            Me.Dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.Dtp_To.Location = New System.Drawing.Point(106, 43)
            Me.Dtp_To.Name = "Dtp_To"
            Me.Dtp_To.Size = New System.Drawing.Size(157, 22)
            Me.Dtp_To.TabIndex = 83
            '
            'Pnl_Date_Search
            '
            Me.Pnl_Date_Search.Controls.Add(Me.Lbl_Date_Min)
            Me.Pnl_Date_Search.Controls.Add(Me.Dtp_To)
            Me.Pnl_Date_Search.Controls.Add(Me.Lbl_Dtp_Form)
            Me.Pnl_Date_Search.Controls.Add(Me.Dtp_Form)
            Me.Pnl_Date_Search.Controls.Add(Me.Btn_Date_Search)
            Me.Pnl_Date_Search.Controls.Add(Me.Lbl_Dtp_To)
            Me.Pnl_Date_Search.Enabled = False
            Me.Pnl_Date_Search.Location = New System.Drawing.Point(23, 64)
            Me.Pnl_Date_Search.Name = "Pnl_Date_Search"
            Me.Pnl_Date_Search.Size = New System.Drawing.Size(402, 81)
            Me.Pnl_Date_Search.TabIndex = 82
            '
            'Lbl_Date_Min
            '
            Me.Lbl_Date_Min.AutoSize = True
            Me.Lbl_Date_Min.Location = New System.Drawing.Point(271, 19)
            Me.Lbl_Date_Min.Name = "Lbl_Date_Min"
            Me.Lbl_Date_Min.Size = New System.Drawing.Size(48, 14)
            Me.Lbl_Date_Min.TabIndex = 84
            Me.Lbl_Date_Min.Text = "(MIN)"
            '
            'Pnl_Number_Search
            '
            Me.Pnl_Number_Search.Controls.Add(Me.Lbl_Number_Min)
            Me.Pnl_Number_Search.Controls.Add(Me.Lbl_Txt_To)
            Me.Pnl_Number_Search.Controls.Add(Me.Lbl_Txt_Form)
            Me.Pnl_Number_Search.Controls.Add(Me.Btn_Number_Search)
            Me.Pnl_Number_Search.Controls.Add(Me.Txt_To)
            Me.Pnl_Number_Search.Controls.Add(Me.Txt_Form)
            Me.Pnl_Number_Search.Enabled = False
            Me.Pnl_Number_Search.Location = New System.Drawing.Point(23, 151)
            Me.Pnl_Number_Search.Name = "Pnl_Number_Search"
            Me.Pnl_Number_Search.Size = New System.Drawing.Size(402, 81)
            Me.Pnl_Number_Search.TabIndex = 83
            '
            'Lbl_Number_Min
            '
            Me.Lbl_Number_Min.AutoSize = True
            Me.Lbl_Number_Min.Location = New System.Drawing.Point(271, 19)
            Me.Lbl_Number_Min.Name = "Lbl_Number_Min"
            Me.Lbl_Number_Min.Size = New System.Drawing.Size(48, 14)
            Me.Lbl_Number_Min.TabIndex = 82
            Me.Lbl_Number_Min.Text = "(MIN)"
            '
            'Pnl_Text_Search
            '
            Me.Pnl_Text_Search.Controls.Add(Me.Lbl_Type_TSearch)
            Me.Pnl_Text_Search.Controls.Add(Me.Cbo_Fields)
            Me.Pnl_Text_Search.Controls.Add(Me.Lbl_Fields)
            Me.Pnl_Text_Search.Controls.Add(Me.Txt_Search)
            Me.Pnl_Text_Search.Location = New System.Drawing.Point(23, 238)
            Me.Pnl_Text_Search.Name = "Pnl_Text_Search"
            Me.Pnl_Text_Search.Size = New System.Drawing.Size(402, 81)
            Me.Pnl_Text_Search.TabIndex = 84
            '
            'Lbl_Type_TSearch
            '
            Me.Lbl_Type_TSearch.AutoSize = True
            Me.Lbl_Type_TSearch.Location = New System.Drawing.Point(19, 49)
            Me.Lbl_Type_TSearch.Name = "Lbl_Type_TSearch"
            Me.Lbl_Type_TSearch.Size = New System.Drawing.Size(104, 14)
            Me.Lbl_Type_TSearch.TabIndex = 79
            Me.Lbl_Type_TSearch.Text = "Type to search"
            '
            'Pnl_List_Search
            '
            Me.Pnl_List_Search.Controls.Add(Me.Btn_List_Search)
            Me.Pnl_List_Search.Controls.Add(Me.Btn_Add_Records)
            Me.Pnl_List_Search.Controls.Add(Me.Cbo_Records)
            Me.Pnl_List_Search.Controls.Add(Me.Lbl_List_ORecord)
            Me.Pnl_List_Search.Controls.Add(Me.Txt_Records)
            Me.Pnl_List_Search.Location = New System.Drawing.Point(431, 64)
            Me.Pnl_List_Search.Name = "Pnl_List_Search"
            Me.Pnl_List_Search.Size = New System.Drawing.Size(353, 254)
            Me.Pnl_List_Search.TabIndex = 85
            '
            'Btn_List_Search
            '
            Me.Btn_List_Search.BackgroundImage = CType(resources.GetObject("Btn_List_Search.BackgroundImage"), System.Drawing.Image)
            Me.Btn_List_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_List_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_List_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_List_Search.Image = CType(resources.GetObject("Btn_List_Search.Image"), System.Drawing.Image)
            Me.Btn_List_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_List_Search.Location = New System.Drawing.Point(224, 211)
            Me.Btn_List_Search.Name = "Btn_List_Search"
            Me.Btn_List_Search.Size = New System.Drawing.Size(112, 31)
            Me.Btn_List_Search.TabIndex = 82
            Me.Btn_List_Search.Text = "    SEARCH"
            Me.Btn_List_Search.UseVisualStyleBackColor = True
            '
            'Btn_Add_Records
            '
            Me.Btn_Add_Records.BackgroundImage = CType(resources.GetObject("Btn_Add_Records.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Add_Records.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Add_Records.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Add_Records.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Add_Records.Image = CType(resources.GetObject("Btn_Add_Records.Image"), System.Drawing.Image)
            Me.Btn_Add_Records.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Add_Records.Location = New System.Drawing.Point(106, 211)
            Me.Btn_Add_Records.Name = "Btn_Add_Records"
            Me.Btn_Add_Records.Size = New System.Drawing.Size(112, 31)
            Me.Btn_Add_Records.TabIndex = 81
            Me.Btn_Add_Records.Text = "ADD"
            Me.Btn_Add_Records.UseVisualStyleBackColor = True
            '
            'Cbo_Records
            '
            Me.Cbo_Records.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.Cbo_Records.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.Cbo_Records.FormattingEnabled = True
            Me.Cbo_Records.Location = New System.Drawing.Point(12, 177)
            Me.Cbo_Records.Name = "Cbo_Records"
            Me.Cbo_Records.Size = New System.Drawing.Size(324, 22)
            Me.Cbo_Records.TabIndex = 79
            '
            'Lbl_List_ORecord
            '
            Me.Lbl_List_ORecord.AutoSize = True
            Me.Lbl_List_ORecord.Location = New System.Drawing.Point(9, 157)
            Me.Lbl_List_ORecord.Name = "Lbl_List_ORecord"
            Me.Lbl_List_ORecord.Size = New System.Drawing.Size(194, 14)
            Me.Lbl_List_ORecord.TabIndex = 78
            Me.Lbl_List_ORecord.Text = "List of record will be display"
            '
            'Txt_Records
            '
            Me.Txt_Records.Dock = System.Windows.Forms.DockStyle.Top
            Me.Txt_Records.Location = New System.Drawing.Point(0, 0)
            Me.Txt_Records.Multiline = True
            Me.Txt_Records.Name = "Txt_Records"
            Me.Txt_Records.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.Txt_Records.Size = New System.Drawing.Size(353, 150)
            Me.Txt_Records.TabIndex = 0
            Me.Txt_Records.WordWrap = False
            '
            'PictureBox1
            '
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(14, 53)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
            Me.PictureBox1.TabIndex = 86
            Me.PictureBox1.TabStop = False
            '
            'PictureBox2
            '
            Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
            Me.PictureBox2.Location = New System.Drawing.Point(14, 143)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
            Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
            Me.PictureBox2.TabIndex = 87
            Me.PictureBox2.TabStop = False
            '
            'PictureBox3
            '
            Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
            Me.PictureBox3.Location = New System.Drawing.Point(15, 229)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
            Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
            Me.PictureBox3.TabIndex = 88
            Me.PictureBox3.TabStop = False
            '
            'Search
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.Controls.Add(Me.PictureBox3)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Pnl_List_Search)
            Me.Controls.Add(Me.Pnl_Text_Search)
            Me.Controls.Add(Me.Pnl_Number_Search)
            Me.Controls.Add(Me.Pnl_Date_Search)
            Me.Controls.Add(Me.Pnl_Bottom)
            Me.Controls.Add(Me.Pnl_Top)
            Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.White
            Me.Name = "Search"
            Me.Size = New System.Drawing.Size(809, 382)
            Me.Pnl_Top.ResumeLayout(False)
            Me.Pnl_Bottom.ResumeLayout(False)
            Me.Pnl_Date_Search.ResumeLayout(False)
            Me.Pnl_Date_Search.PerformLayout()
            Me.Pnl_Number_Search.ResumeLayout(False)
            Me.Pnl_Number_Search.PerformLayout()
            Me.Pnl_Text_Search.ResumeLayout(False)
            Me.Pnl_Text_Search.PerformLayout()
            Me.Pnl_List_Search.ResumeLayout(False)
            Me.Pnl_List_Search.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region
        <DefaultValue(False)>
        Public Property SizeLock As Boolean
        Public Property FormTitle As String
        Private _TableName As String
        Public Property TableName As String
            Get
                Return _TableName
            End Get
            Set(value As String)
                _TableName = value
                ' Fill combobox
                Select Case _TableName
                    Case "Business"
                        Cbo_Fields.Items.AddRange(New Object() {"ALL", "BUSINESS ID", "BUSINESS NAME", "BUSINESS PHONE", "BUSINESS MAIL", "BUSINESS GST NO", "BUSINESS PAN NO", "BUSINESS CGST", "BUSINESS SGST", "BUSINESS IGST", "BUSINESS TIN", "BUSINESS BANK ACCOUNT", "BUSINESS BILL NO", "BUSINESS ADDRESS"})
                        clsBusiness.BoundComboBox(Cbo_Records)
                    Case "CashBalance"
                        Cbo_Fields.Items.AddRange(New Object() {"ALL", "CASHBALANCE ID", "CASHBALANCE DATE", "PROFILE ID", "CASHBALANCE PAYMENT AMOUNT", "CASHBALANCE RECIVE AMOUNT"})
                        clsCashBalance.BoundComboBox(Cbo_Records)
                    Case "CashMemo"
                        Cbo_Fields.Items.AddRange(New Object() {"ALL", "CASHMEMO ID", "CASHMEMO DATE", "PROFILE ID", "CASHMEMO PAYMENT AMOUNT", "CASHMEMO RECIVE AMOUNT"})
                        clsCashMemo.BoundComboBox(Cbo_Records)
                    Case "Catagores"
                        Cbo_Fields.Items.AddRange(New Object() {"ALL", "CATEGORY ID", "CATEGORY NAME", "CATEGORY NOTE"})
                        clsCatagores.BoundComboBox(Cbo_Records)
                    Case "Login"
                        Cbo_Fields.Items.AddRange(New Object() {"ALL", "LOGIN ID", "LOGIN NAME", "LOGIN PASSWORD", "LOGIN PHONE", "LOGIN MAIL", "LOGIN PERMISSION"})
                        clsLogin.BoundComboBox(Cbo_Records)
                    Case "ProductBarcodes"
                        Cbo_Fields.Items.AddRange(New Object() {"ALL", "PRODUCTBARCODE ID", "PURCHASEDETAIL ID", "PRODUCT ID", "PRODUCTBARCODE BARCODE", "PRODUCTBARCODE STOCK"})
                        clsProductBarcodes.BoundComboBox(Cbo_Records)
                    Case "Products"
                        Cbo_Fields.Items.AddRange(New Object() {"ALL", "PRODUCT ID", "CATEGORY ID", "CATEGORY NAME", "PRODUCT NAME", "UNIT ID", "UNIT NAME", "HSN CODE", "PRODUCT STOCK", "PRODUCT SINGLE AMOUNT", "PRODUCT NOTE"})
                        clsProducts.BoundComboBox(Cbo_Records)
                    Case "Profiles"
                        Cbo_Fields.Items.AddRange(New Object() {"ALL", "PROFILE ID", "PROFILE NAME", "RELETIONSHIP ID", "RELETIONSHIP NAME", "PROFILE PHONE", "PROFILE MAIL", "PROFILE GST NO", "PROFILE PAN NO", "PROFILE BANK ACCOUNT", "PROFILE ADDRESS", "PROFILE REMARK", "PROFILE STATE", "PROFILE NOTE"})
                        clsProfiles.BoundComboBox(Cbo_Records)
                    Case "PurchaseBarcodes"
                        Cbo_Fields.Items.AddRange(New Object() {"ALL", "PURCHASEBARCODE ID", "PURCHASEDETAIL ID", "PRODUCT ID", "PRODUCT BARCODE"})
                        clsPurchaseBarcodes.BoundComboBox(Cbo_Records)
                    Case "PurchaseDetails"
                        Cbo_Fields.Items.AddRange(New Object() {"ALL", "PURCHASEDETAIL ID", "PURCHASE ID", "PRODUCT ID", "PRODUCT NAME", "HSN CODE", "PURCHASE QUANTITY", "UNIT NAME", "PURCHASE RATE AMOUNT", "PURCHASE SUBTOTAL AMOUNT"})
                        clsPurchaseDetails.BoundComboBox(Cbo_Records)
                    Case "Purchases"
                        Cbo_Fields.Items.AddRange(New Object() {"ALL", "PURCHASE ID", "PURCHASE DATE", "PROFILE ID", "PURCHASE CGST AMOUNT", "PURCHASE SGST AMOUNT", "PURCHASE IGST AMOUNT", "PURCHASE GRANDTOTAL AMOUNT", "PURCHASE PAYMENT AMOUNT", "PURCHASE DUE AMOUNT"})
                        clsPurchases.BoundComboBox(Cbo_Records)
                    Case "Reletionships"
                        Cbo_Fields.Items.AddRange(New Object() {"ALL", "RELETIONSHIP ID", "RELETIONSHIP NAME", "RELETIONSHIP NOTE"})
                        clsReletionships.BoundComboBox(Cbo_Records)
                    Case "SaleBarcodes"
                        Cbo_Fields.Items.AddRange(New Object() {"ALL", "SALEBARCODE ID", "SALEDETAIL ID", "PRODUCT ID", "SALEBARCODE BARCODE"})
                        clsSaleBarcodes.BoundComboBox(Cbo_Records)
                    Case "SaleDetails"
                        Cbo_Fields.Items.AddRange(New Object() {"ALL", "SALEDETAIL ID", "SALE ID", "PRODUCT ID", "PRODUCT NAME", "HSN CODE", "SALE QUANTITY", "UNIT NAME", "SALE RATE AMOUNT", "SALE SUBTOTAL AMOUNT"})
                        clsSaleDetails.BoundComboBox(Cbo_Records)
                    Case "Sales"
                        Cbo_Fields.Items.AddRange(New Object() {"ALL", "SALE ID", "SALE DATE", "PROFILE ID", "SALE CGST AMOUNT", "SALE SGST AMOUNT", "SALE IGST AMOUNT", "SALE GRANDTOTAL AMOUNT", "SALE RECIVE AMOUNT", "SALE DUE AMOUNT"})
                        clsSales.BoundComboBox(Cbo_Records)
                    Case "Units"
                        Cbo_Fields.Items.AddRange(New Object() {"ALL", "UNIT ID", "UNIT NAME", "UNIT NOTE"})
                        clsUnits.BoundComboBox(Cbo_Records)
                End Select
            End Set
        End Property
        Private Sub TableSearch(Optional ByVal FieldName As String = "")
            Dim _SearchSyntax As String = String.Empty
            Select Case _TableName
                Case "Business"
                    Select Case Cbo_Fields.Text.ToLower
                        Case "all"
                            ucDataGridView.Txt_Search.Text = Txt_Search.Text
                        Case "business id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Business_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsBusiness.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Business_Id >= {0}  AND Business_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsBusiness.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "business name"
                            _SearchSyntax = String.Format("Business_Name LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsBusiness.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "business phone"
                            _SearchSyntax = String.Format("Business_Phone LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsBusiness.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "business mail"
                            _SearchSyntax = String.Format("Business_Mail LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsBusiness.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "business gst no"
                            _SearchSyntax = String.Format("Business_GST_No LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsBusiness.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "business pan no"
                            _SearchSyntax = String.Format("Business_Pan_No LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsBusiness.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "business cgst"
                            _SearchSyntax = String.Format("Business_CGST LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsBusiness.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "business sgst"
                            _SearchSyntax = String.Format("Business_SGST LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsBusiness.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "business igst"
                            _SearchSyntax = String.Format("Business_IGST LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsBusiness.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "business tin"
                            _SearchSyntax = String.Format("Business_Tin LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsBusiness.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "business bank account"
                            _SearchSyntax = String.Format("Business_Bank_Account LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsBusiness.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "business bill no"
                            _SearchSyntax = String.Format("Business_Bill_No LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsBusiness.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "business address"
                            _SearchSyntax = String.Format("Business_Address LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsBusiness.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                    End Select
                Case "CashBalance"
                    Select Case Cbo_Fields.Text.ToLower
                        Case "all"
                            ucDataGridView.Txt_Search.Text = Txt_Search.Text
                        Case "cashbalance id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("CashBalance_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsCashBalance.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("CashBalance_Id >= {0}  AND CashBalance_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsCashBalance.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "cashbalance date"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("CashBalance_Date LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsCashBalance.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("CashBalance_Date >= #{0}#  AND CashBalance_Date <= #{1}#", Dtp_Form.Value.ToShortDateString, Dtp_To.Value.ToShortDateString)
                                    clsCashBalance.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "profile id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Profile_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsCashBalance.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Profile_Id >= {0}  AND Profile_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsCashBalance.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "cashbalance payment amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("CashBalance_Payment_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsCashBalance.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("CashBalance_Payment_Amount >= {0}  AND CashBalance_Payment_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsCashBalance.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "cashbalance recive amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("CashBalance_Recive_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsCashBalance.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("CashBalance_Recive_Amount >= {0}  AND CashBalance_Recive_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsCashBalance.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                    End Select
                Case "CashMemo"
                    Select Case Cbo_Fields.Text.ToLower
                        Case "all"
                            ucDataGridView.Txt_Search.Text = Txt_Search.Text
                        Case "cashmemo id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("CashMemo_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsCashMemo.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("CashMemo_Id >= {0}  AND CashMemo_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsCashMemo.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "cashmemo date"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("CashMemo_Date LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsCashMemo.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("CashMemo_Date >= #{0}#  AND CashMemo_Date <= #{1}#", Dtp_Form.Value.ToShortDateString, Dtp_To.Value.ToShortDateString)
                                    clsCashMemo.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "profile id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Profile_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsCashMemo.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Profile_Id >= {0}  AND Profile_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsCashMemo.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "cashmemo payment amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("CashMemo_Payment_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsCashMemo.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("CashMemo_Payment_Amount >= {0}  AND CashMemo_Payment_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsCashMemo.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "cashmemo recive amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("CashMemo_Recive_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsCashMemo.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("CashMemo_Recive_Amount >= {0}  AND CashMemo_Recive_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsCashMemo.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                    End Select
                Case "Catagores"
                    Select Case Cbo_Fields.Text.ToLower
                        Case "all"
                            ucDataGridView.Txt_Search.Text = Txt_Search.Text
                        Case "category id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Category_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsCatagores.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Category_Id >= {0}  AND Category_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsCatagores.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "category name"
                            _SearchSyntax = String.Format("Category_Name LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsCatagores.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "category note"
                            _SearchSyntax = String.Format("Category_Note LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsCatagores.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                    End Select
                Case "Login"
                    Select Case Cbo_Fields.Text.ToLower
                        Case "all"
                            ucDataGridView.Txt_Search.Text = Txt_Search.Text
                        Case "login id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Login_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsLogin.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Login_Id >= {0}  AND Login_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsLogin.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "login name"
                            _SearchSyntax = String.Format("Login_Name LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsLogin.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "login password"
                            _SearchSyntax = String.Format("Login_Password LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsLogin.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "login phone"
                            _SearchSyntax = String.Format("Login_Phone LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsLogin.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "login mail"
                            _SearchSyntax = String.Format("Login_Mail LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsLogin.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "login permission"
                            _SearchSyntax = String.Format("Login_Permission LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsLogin.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                    End Select
                Case "ProductBarcodes"
                    Select Case Cbo_Fields.Text.ToLower
                        Case "all"
                            ucDataGridView.Txt_Search.Text = Txt_Search.Text
                        Case "productbarcode id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("ProductBarcode_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsProductBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("ProductBarcode_Id >= {0}  AND ProductBarcode_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsProductBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "purchasedetail id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("PurchaseDetail_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsProductBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("PurchaseDetail_Id >= {0}  AND PurchaseDetail_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsProductBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "product id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Product_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsProductBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Product_Id >= {0}  AND Product_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsProductBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "productbarcode barcode"
                            _SearchSyntax = String.Format("ProductBarcode_Barcode LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsProductBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "productbarcode stock"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("ProductBarcode_Stock LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsProductBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("ProductBarcode_Stock >= {0}  AND ProductBarcode_Stock <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsProductBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                    End Select
                Case "Products"
                    Select Case Cbo_Fields.Text.ToLower
                        Case "all"
                            ucDataGridView.Txt_Search.Text = Txt_Search.Text
                        Case "product id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Product_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsProducts.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Product_Id >= {0}  AND Product_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsProducts.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "category id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Category_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsProducts.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Category_Id >= {0}  AND Category_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsProducts.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "category name"
                            _SearchSyntax = String.Format("Category_Name LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsProducts.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "product name"
                            _SearchSyntax = String.Format("Product_Name LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsProducts.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "unit id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Unit_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsProducts.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Unit_Id >= {0}  AND Unit_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsProducts.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "unit name"
                            _SearchSyntax = String.Format("Unit_Name LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsProducts.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "hsn code"
                            _SearchSyntax = String.Format("HSN_Code LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsProducts.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "product stock"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Product_Stock LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsProducts.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Product_Stock >= {0}  AND Product_Stock <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsProducts.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "product single amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Product_Single_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsProducts.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Product_Single_Amount >= {0}  AND Product_Single_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsProducts.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "product note"
                            _SearchSyntax = String.Format("Product_Note LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsProducts.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                    End Select
                Case "Profiles"
                    Select Case Cbo_Fields.Text.ToLower
                        Case "all"
                            ucDataGridView.Txt_Search.Text = Txt_Search.Text
                        Case "profile id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Profile_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsProfiles.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Profile_Id >= {0}  AND Profile_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsProfiles.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "profile name"
                            _SearchSyntax = String.Format("Profile_Name LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsProfiles.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "reletionship id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Reletionship_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsProfiles.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Reletionship_Id >= {0}  AND Reletionship_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsProfiles.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "reletionship name"
                            _SearchSyntax = String.Format("Reletionship_Name LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsProfiles.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "profile phone"
                            _SearchSyntax = String.Format("Profile_Phone LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsProfiles.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "profile mail"
                            _SearchSyntax = String.Format("Profile_Mail LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsProfiles.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "profile gst no"
                            _SearchSyntax = String.Format("Profile_GST_No LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsProfiles.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "profile pan no"
                            _SearchSyntax = String.Format("Profile_PAN_No LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsProfiles.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "profile bank account"
                            _SearchSyntax = String.Format("Profile_Bank_Account LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsProfiles.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "profile address"
                            _SearchSyntax = String.Format("Profile_Address LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsProfiles.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "profile remark"
                            _SearchSyntax = String.Format("Profile_Remark LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsProfiles.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "profile state"
                            _SearchSyntax = String.Format("Profile_State LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsProfiles.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "profile note"
                            _SearchSyntax = String.Format("Profile_Note LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsProfiles.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                    End Select
                Case "PurchaseBarcodes"
                    Select Case Cbo_Fields.Text.ToLower
                        Case "all"
                            ucDataGridView.Txt_Search.Text = Txt_Search.Text
                        Case "purchasebarcode id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("PurchaseBarcode_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsPurchaseBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("PurchaseBarcode_Id >= {0}  AND PurchaseBarcode_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsPurchaseBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "purchasedetail id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("PurchaseDetail_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsPurchaseBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("PurchaseDetail_Id >= {0}  AND PurchaseDetail_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsPurchaseBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "product id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Product_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsPurchaseBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Product_Id >= {0}  AND Product_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsPurchaseBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "product barcode"
                            _SearchSyntax = String.Format("Product_Barcode LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsPurchaseBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                    End Select
                Case "PurchaseDetails"
                    Select Case Cbo_Fields.Text.ToLower
                        Case "all"
                            ucDataGridView.Txt_Search.Text = Txt_Search.Text
                        Case "purchasedetail id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("PurchaseDetail_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsPurchaseDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("PurchaseDetail_Id >= {0}  AND PurchaseDetail_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsPurchaseDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "purchase id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Purchase_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsPurchaseDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Purchase_Id >= {0}  AND Purchase_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsPurchaseDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "product id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Product_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsPurchaseDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Product_Id >= {0}  AND Product_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsPurchaseDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "product name"
                            _SearchSyntax = String.Format("Product_Name LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsPurchaseDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "hsn code"
                            _SearchSyntax = String.Format("HSN_Code LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsPurchaseDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "purchase quantity"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Purchase_Quantity LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsPurchaseDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Purchase_Quantity >= {0}  AND Purchase_Quantity <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsPurchaseDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "unit name"
                            _SearchSyntax = String.Format("Unit_Name LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsPurchaseDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "purchase rate amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Purchase_Rate_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsPurchaseDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Purchase_Rate_Amount >= {0}  AND Purchase_Rate_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsPurchaseDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "purchase subtotal amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Purchase_Subtotal_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsPurchaseDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Purchase_Subtotal_Amount >= {0}  AND Purchase_Subtotal_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsPurchaseDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                    End Select
                Case "Purchases"
                    Select Case Cbo_Fields.Text.ToLower
                        Case "all"
                            ucDataGridView.Txt_Search.Text = Txt_Search.Text
                        Case "purchase id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Purchase_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Purchase_Id >= {0}  AND Purchase_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "purchase date"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Purchase_Date LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Purchase_Date >= #{0}#  AND Purchase_Date <= #{1}#", Dtp_Form.Value.ToShortDateString, Dtp_To.Value.ToShortDateString)
                                    clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "profile id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Profile_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Profile_Id >= {0}  AND Profile_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "purchase cgst amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Purchase_CGST_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Purchase_CGST_Amount >= {0}  AND Purchase_CGST_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "purchase sgst amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Purchase_SGST_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Purchase_SGST_Amount >= {0}  AND Purchase_SGST_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "purchase igst amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Purchase_IGST_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Purchase_IGST_Amount >= {0}  AND Purchase_IGST_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "purchase grandtotal amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Purchase_Grandtotal_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Purchase_Grandtotal_Amount >= {0}  AND Purchase_Grandtotal_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "purchase payment amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Purchase_Payment_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Purchase_Payment_Amount >= {0}  AND Purchase_Payment_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "purchase due amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Purchase_Due_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Purchase_Due_Amount >= {0}  AND Purchase_Due_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                    End Select
                Case "Reletionships"
                    Select Case Cbo_Fields.Text.ToLower
                        Case "all"
                            ucDataGridView.Txt_Search.Text = Txt_Search.Text
                        Case "reletionship id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Reletionship_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsReletionships.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Reletionship_Id >= {0}  AND Reletionship_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsReletionships.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "reletionship name"
                            _SearchSyntax = String.Format("Reletionship_Name LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsReletionships.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "reletionship note"
                            _SearchSyntax = String.Format("Reletionship_Note LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsReletionships.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                    End Select
                Case "SaleBarcodes"
                    Select Case Cbo_Fields.Text.ToLower
                        Case "all"
                            ucDataGridView.Txt_Search.Text = Txt_Search.Text
                        Case "salebarcode id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("SaleBarcode_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsSaleBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("SaleBarcode_Id >= {0}  AND SaleBarcode_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsSaleBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "saledetail id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("SaleDetail_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsSaleBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("SaleDetail_Id >= {0}  AND SaleDetail_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsSaleBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "product id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Product_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsSaleBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Product_Id >= {0}  AND Product_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsSaleBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "salebarcode barcode"
                            _SearchSyntax = String.Format("SaleBarcode_Barcode LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsSaleBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                    End Select
                Case "SaleDetails"
                    Select Case Cbo_Fields.Text.ToLower
                        Case "all"
                            ucDataGridView.Txt_Search.Text = Txt_Search.Text
                        Case "saledetail id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("SaleDetail_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsSaleDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("SaleDetail_Id >= {0}  AND SaleDetail_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsSaleDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "sale id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Sale_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsSaleDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Sale_Id >= {0}  AND Sale_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsSaleDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "product id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Product_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsSaleDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Product_Id >= {0}  AND Product_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsSaleDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "product name"
                            _SearchSyntax = String.Format("Product_Name LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsSaleDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "hsn code"
                            _SearchSyntax = String.Format("HSN_Code LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsSaleDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "sale quantity"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Sale_Quantity LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsSaleDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Sale_Quantity >= {0}  AND Sale_Quantity <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsSaleDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "unit name"
                            _SearchSyntax = String.Format("Unit_Name LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsSaleDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "sale rate amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Sale_Rate_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsSaleDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Sale_Rate_Amount >= {0}  AND Sale_Rate_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsSaleDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "sale subtotal amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Sale_Subtotal_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsSaleDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Sale_Subtotal_Amount >= {0}  AND Sale_Subtotal_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsSaleDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                    End Select
                Case "Sales"
                    Select Case Cbo_Fields.Text.ToLower
                        Case "all"
                            ucDataGridView.Txt_Search.Text = Txt_Search.Text
                        Case "sale id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Sale_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Sale_Id >= {0}  AND Sale_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "sale date"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Sale_Date LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Sale_Date >= #{0}#  AND Sale_Date <= #{1}#", Dtp_Form.Value.ToShortDateString, Dtp_To.Value.ToShortDateString)
                                    clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "profile id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Profile_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Profile_Id >= {0}  AND Profile_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "sale cgst amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Sale_CGST_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Sale_CGST_Amount >= {0}  AND Sale_CGST_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "sale sgst amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Sale_SGST_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Sale_SGST_Amount >= {0}  AND Sale_SGST_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "sale igst amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Sale_IGST_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Sale_IGST_Amount >= {0}  AND Sale_IGST_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "sale grandtotal amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Sale_Grandtotal_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Sale_Grandtotal_Amount >= {0}  AND Sale_Grandtotal_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "sale recive amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Sale_Recive_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Sale_Recive_Amount >= {0}  AND Sale_Recive_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "sale due amount"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Sale_Due_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Sale_Due_Amount >= {0}  AND Sale_Due_Amount <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                    End Select
                Case "Units"
                    Select Case Cbo_Fields.Text.ToLower
                        Case "all"
                            ucDataGridView.Txt_Search.Text = Txt_Search.Text
                        Case "unit id"
                            If String.IsNullOrWhiteSpace(FieldName) Then
                                _SearchSyntax = String.Format("Unit_Id LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                                clsUnits.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                            Else
                                If Cbo_Fields.Text = FieldName Then
                                    _SearchSyntax = String.Format("Unit_Id >= {0}  AND Unit_Id <= {1}", Txt_Form.Text.Replace("'", "''"), Txt_To.Text.Replace("'", "''"))
                                    clsUnits.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                                End If
                            End If
                        Case "unit name"
                            _SearchSyntax = String.Format("Unit_Name LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsUnits.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                        Case "unit note"
                            _SearchSyntax = String.Format("Unit_Note LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                            clsUnits.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                    End Select
            End Select
        End Sub
        Private Sub Btn_List_Search_Click(sender As Object, e As EventArgs) Handles Btn_List_Search.Click
            If String.IsNullOrWhiteSpace(Txt_Records.Text) Then Exit Sub
            Dim _SearchSyntax As String = String.Empty
            Dim _Records As String = String.Empty
            ' Removed empty line(s) before search
            For i As Integer = 0 To Txt_Records.Lines.Count - 1
                If Not String.IsNullOrWhiteSpace(Txt_Records.Lines(i)) Then
                    If String.IsNullOrWhiteSpace(_Records) Then
                        _Records = Txt_Records.Lines(i)
                    Else
                        _Records += vbNewLine & Txt_Records.Lines(i)
                    End If
                End If
            Next
            Txt_Records.Text = _Records
            Select Case _TableName
                Case "Business"
                    For i As Integer = 0 To Txt_Records.Lines.Count - 1
                        If i = 0 Then
                            _SearchSyntax = String.Format("Business_Name LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        Else
                            _SearchSyntax += String.Format(" OR Business_Name LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        End If
                    Next
                    clsBusiness.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                Case "CashBalance"
                    For i As Integer = 0 To Txt_Records.Lines.Count - 1
                        If i = 0 Then
                            _SearchSyntax = String.Format("CashBalance_Date LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        Else
                            _SearchSyntax += String.Format(" OR CashBalance_Date LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        End If
                    Next
                    clsCashBalance.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                Case "CashMemo"
                    For i As Integer = 0 To Txt_Records.Lines.Count - 1
                        If i = 0 Then
                            _SearchSyntax = String.Format("CashMemo_Date LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        Else
                            _SearchSyntax += String.Format(" OR CashMemo_Date LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        End If
                    Next
                    clsCashMemo.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                Case "Catagores"
                    For i As Integer = 0 To Txt_Records.Lines.Count - 1
                        If i = 0 Then
                            _SearchSyntax = String.Format("Category_Name LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        Else
                            _SearchSyntax += String.Format(" OR Category_Name LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        End If
                    Next
                    clsCatagores.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                Case "Login"
                    For i As Integer = 0 To Txt_Records.Lines.Count - 1
                        If i = 0 Then
                            _SearchSyntax = String.Format("Login_Name LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        Else
                            _SearchSyntax += String.Format(" OR Login_Name LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        End If
                    Next
                    clsLogin.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                Case "ProductBarcodes"
                    For i As Integer = 0 To Txt_Records.Lines.Count - 1
                        If i = 0 Then
                            _SearchSyntax = String.Format("PurchaseDetail_Id LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        Else
                            _SearchSyntax += String.Format(" OR PurchaseDetail_Id LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        End If
                    Next
                    clsProductBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                Case "Products"
                    For i As Integer = 0 To Txt_Records.Lines.Count - 1
                        If i = 0 Then
                            _SearchSyntax = String.Format("Product_Name LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        Else
                            _SearchSyntax += String.Format(" OR Product_Name LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        End If
                    Next
                    clsProducts.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                Case "Profiles"
                    For i As Integer = 0 To Txt_Records.Lines.Count - 1
                        If i = 0 Then
                            _SearchSyntax = String.Format("Profile_Name LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        Else
                            _SearchSyntax += String.Format(" OR Profile_Name LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        End If
                    Next
                    clsProfiles.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                Case "PurchaseBarcodes"
                    For i As Integer = 0 To Txt_Records.Lines.Count - 1
                        If i = 0 Then
                            _SearchSyntax = String.Format("PurchaseDetail_Id LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        Else
                            _SearchSyntax += String.Format(" OR PurchaseDetail_Id LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        End If
                    Next
                    clsPurchaseBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                Case "PurchaseDetails"
                    For i As Integer = 0 To Txt_Records.Lines.Count - 1
                        If i = 0 Then
                            _SearchSyntax = String.Format("Purchase_Id LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        Else
                            _SearchSyntax += String.Format(" OR Purchase_Id LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        End If
                    Next
                    clsPurchaseDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                Case "Purchases"
                    For i As Integer = 0 To Txt_Records.Lines.Count - 1
                        If i = 0 Then
                            _SearchSyntax = String.Format("Purchase_Date LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        Else
                            _SearchSyntax += String.Format(" OR Purchase_Date LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        End If
                    Next
                    clsPurchases.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                Case "Reletionships"
                    For i As Integer = 0 To Txt_Records.Lines.Count - 1
                        If i = 0 Then
                            _SearchSyntax = String.Format("Reletionship_Name LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        Else
                            _SearchSyntax += String.Format(" OR Reletionship_Name LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        End If
                    Next
                    clsReletionships.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                Case "SaleBarcodes"
                    For i As Integer = 0 To Txt_Records.Lines.Count - 1
                        If i = 0 Then
                            _SearchSyntax = String.Format("SaleDetail_Id LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        Else
                            _SearchSyntax += String.Format(" OR SaleDetail_Id LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        End If
                    Next
                    clsSaleBarcodes.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                Case "SaleDetails"
                    For i As Integer = 0 To Txt_Records.Lines.Count - 1
                        If i = 0 Then
                            _SearchSyntax = String.Format("Sale_Id LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        Else
                            _SearchSyntax += String.Format(" OR Sale_Id LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        End If
                    Next
                    clsSaleDetails.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                Case "Sales"
                    For i As Integer = 0 To Txt_Records.Lines.Count - 1
                        If i = 0 Then
                            _SearchSyntax = String.Format("Sale_Date LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        Else
                            _SearchSyntax += String.Format(" OR Sale_Date LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        End If
                    Next
                    clsSales.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
                Case "Units"
                    For i As Integer = 0 To Txt_Records.Lines.Count - 1
                        If i = 0 Then
                            _SearchSyntax = String.Format("Unit_Name LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        Else
                            _SearchSyntax += String.Format(" OR Unit_Name LIKE '%{0}%'", Txt_Records.Lines(i).Replace("'", "''"))
                        End If
                    Next
                    clsUnits.BoundDataGridView(ucDataGridView.DgvInventory, _SearchSyntax)
            End Select
        End Sub
        Protected Overrides Sub SetBoundsCore(ByVal x As Integer, ByVal y As Integer, ByVal [width] As Integer, ByVal height As Integer, ByVal specified As System.Windows.Forms.BoundsSpecified)
            MyBase.SetBoundsCore(x, y, 809, 382, specified)
        End Sub
        Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            FormTitle = "Search"
            clsFeature.SizeLock(SizeLock, ParentForm, FormTitle, Me)
            TableName = ucDataGridView.TableName
        End Sub
        Private Sub Search_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
            ucSearch = Nothing
            frmSearch = Nothing
        End Sub
        Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
            Me.ParentForm.Close()
        End Sub
        Private Sub Btn_Add_Records_Click(sender As Object, e As EventArgs) Handles Btn_Add_Records.Click
            If Not String.IsNullOrWhiteSpace(Cbo_Records.Text) Then
                If String.IsNullOrWhiteSpace(Txt_Records.Text) Then
                    Txt_Records.Text = Cbo_Records.Text
                Else
                    Txt_Records.Text += vbNewLine & Cbo_Records.Text
                End If
            End If
        End Sub
        Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
            TableSearch()
        End Sub
        Private Sub Cbo_Fields_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Fields.SelectedIndexChanged
            Pnl_Number_Search.Enabled = False
            Pnl_Date_Search.Enabled = False
            If Cbo_Fields.Text.ToLower.Contains("id") OrElse
            Cbo_Fields.Text.ToLower.Contains("amount") OrElse
            Cbo_Fields.Text.ToLower.Contains("price") OrElse
            Cbo_Fields.Text.ToLower.Contains("no") OrElse
            Cbo_Fields.Text.ToLower.Contains("num") OrElse
            Cbo_Fields.Text.ToLower.Contains("number") OrElse
            Cbo_Fields.Text.ToLower.Contains("stock") OrElse
            Cbo_Fields.Text.ToLower.Contains("quantity") OrElse
            Cbo_Fields.Text.ToLower.Contains("total") Then
                Pnl_Number_Search.Enabled = True
            ElseIf Cbo_Fields.Text.ToLower.Contains("date") OrElse
            Cbo_Fields.Text.ToLower.Contains("datetime") OrElse
            Cbo_Fields.Text.ToLower.Contains("time") Then
                Pnl_Date_Search.Enabled = True
            End If
        End Sub
        Private Sub Btn_Date_Search_Click(sender As Object, e As EventArgs) Handles Btn_Date_Search.Click
            TableSearch(Cbo_Fields.Text)
        End Sub
        Private Sub Btn_Number_Search_Click(sender As Object, e As EventArgs) Handles Btn_Number_Search.Click
            If String.IsNullOrWhiteSpace(Txt_Form.Text) Then Exit Sub
            If String.IsNullOrWhiteSpace(Txt_To.Text) Then Exit Sub
            TableSearch(Cbo_Fields.Text)
        End Sub
    End Class
End Namespace