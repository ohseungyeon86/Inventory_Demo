Imports System.ComponentModel
Namespace UIForm
    ' Build Action Embedded Resource
    <ToolboxBitmap(GetType(Cashmemo), "Cashmemo.ico"), ToolboxItem(False)>
    Public Class Cashmemo
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
        Friend WithEvents Lbl_CashMemo_Id As Label
        Friend WithEvents Cbo_CashMemo_Id As ComboBox
        Friend WithEvents Txt_CashMemo_Id As TextBox
        Friend WithEvents Btn_Add_CashMemo_Id As Button
        Friend WithEvents Btn_Edit_CashMemo_Id As Button
        Friend WithEvents Btn_Del_CashMemo_Id As Button
        Friend WithEvents Lbl_CashMemo_Date As Label
        Friend WithEvents Txt_CashMemo_Date As TextBox
        Friend WithEvents Dtp_CashMemo_Date As DateTimePicker
        Friend WithEvents Lbl_Profile_Id As Label
        Friend WithEvents Cbo_Profile_Id As ComboBox
        Friend WithEvents Txt_Profile_Id As TextBox
        Friend WithEvents Btn_Add_Profile_Id As Button
        Friend WithEvents Btn_Edit_Profile_Id As Button
        Friend WithEvents Btn_Del_Profile_Id As Button
        Friend WithEvents Lbl_CashMemo_Payment_Amount As Label
        Friend WithEvents Txt_CashMemo_Payment_Amount As TextBox
        Friend WithEvents Lbl_CashMemo_Recive_Amount As Label
        Friend WithEvents Txt_CashMemo_Recive_Amount As TextBox
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cashmemo))
            Me.Lbl_CashMemo_Id = New System.Windows.Forms.Label()
            Me.Cbo_CashMemo_Id = New System.Windows.Forms.ComboBox()
            Me.Txt_CashMemo_Id = New System.Windows.Forms.TextBox()
            Me.Btn_Add_CashMemo_Id = New System.Windows.Forms.Button()
            Me.Btn_Edit_CashMemo_Id = New System.Windows.Forms.Button()
            Me.Btn_Del_CashMemo_Id = New System.Windows.Forms.Button()
            Me.Lbl_CashMemo_Date = New System.Windows.Forms.Label()
            Me.Txt_CashMemo_Date = New System.Windows.Forms.TextBox()
            Me.Dtp_CashMemo_Date = New System.Windows.Forms.DateTimePicker()
            Me.Lbl_Profile_Id = New System.Windows.Forms.Label()
            Me.Cbo_Profile_Id = New System.Windows.Forms.ComboBox()
            Me.Txt_Profile_Id = New System.Windows.Forms.TextBox()
            Me.Btn_Add_Profile_Id = New System.Windows.Forms.Button()
            Me.Btn_Edit_Profile_Id = New System.Windows.Forms.Button()
            Me.Btn_Del_Profile_Id = New System.Windows.Forms.Button()
            Me.Lbl_CashMemo_Payment_Amount = New System.Windows.Forms.Label()
            Me.Txt_CashMemo_Payment_Amount = New System.Windows.Forms.TextBox()
            Me.Lbl_CashMemo_Recive_Amount = New System.Windows.Forms.Label()
            Me.Txt_CashMemo_Recive_Amount = New System.Windows.Forms.TextBox()
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
            'Lbl_CashMemo_Id
            '
            Me.Lbl_CashMemo_Id.AutoSize = True
            Me.Lbl_CashMemo_Id.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_CashMemo_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_CashMemo_Id.ForeColor = System.Drawing.Color.White
            Me.Lbl_CashMemo_Id.Location = New System.Drawing.Point(18, 62)
            Me.Lbl_CashMemo_Id.Name = "Lbl_CashMemo_Id"
            Me.Lbl_CashMemo_Id.Size = New System.Drawing.Size(26, 14)
            Me.Lbl_CashMemo_Id.TabIndex = 0
            Me.Lbl_CashMemo_Id.Text = "Id:"
            '
            'Cbo_CashMemo_Id
            '
            Me.Cbo_CashMemo_Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.Cbo_CashMemo_Id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.Cbo_CashMemo_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cbo_CashMemo_Id.FormattingEnabled = True
            Me.Cbo_CashMemo_Id.Location = New System.Drawing.Point(148, 59)
            Me.Cbo_CashMemo_Id.Name = "Cbo_CashMemo_Id"
            Me.Cbo_CashMemo_Id.Size = New System.Drawing.Size(200, 22)
            Me.Cbo_CashMemo_Id.TabIndex = 0
            '
            'Txt_CashMemo_Id
            '
            Me.Txt_CashMemo_Id.BackColor = System.Drawing.SystemColors.Window
            Me.Txt_CashMemo_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_CashMemo_Id.ForeColor = System.Drawing.Color.Black
            Me.Txt_CashMemo_Id.Location = New System.Drawing.Point(356, 59)
            Me.Txt_CashMemo_Id.Name = "Txt_CashMemo_Id"
            Me.Txt_CashMemo_Id.ReadOnly = True
            Me.Txt_CashMemo_Id.Size = New System.Drawing.Size(40, 22)
            Me.Txt_CashMemo_Id.TabIndex = 0
            Me.Txt_CashMemo_Id.TabStop = False
            Me.Txt_CashMemo_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Btn_Add_CashMemo_Id
            '
            Me.Btn_Add_CashMemo_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Add_CashMemo_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Add_CashMemo_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Add_CashMemo_Id.Image = CType(resources.GetObject("Btn_Add_CashMemo_Id.Image"), System.Drawing.Image)
            Me.Btn_Add_CashMemo_Id.Location = New System.Drawing.Point(404, 56)
            Me.Btn_Add_CashMemo_Id.Name = "Btn_Add_CashMemo_Id"
            Me.Btn_Add_CashMemo_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Add_CashMemo_Id.TabIndex = 0
            Me.Btn_Add_CashMemo_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Add_CashMemo_Id, "Add")
            Me.Btn_Add_CashMemo_Id.UseVisualStyleBackColor = True
            '
            'Btn_Edit_CashMemo_Id
            '
            Me.Btn_Edit_CashMemo_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Edit_CashMemo_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Edit_CashMemo_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Edit_CashMemo_Id.Image = CType(resources.GetObject("Btn_Edit_CashMemo_Id.Image"), System.Drawing.Image)
            Me.Btn_Edit_CashMemo_Id.Location = New System.Drawing.Point(440, 56)
            Me.Btn_Edit_CashMemo_Id.Name = "Btn_Edit_CashMemo_Id"
            Me.Btn_Edit_CashMemo_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Edit_CashMemo_Id.TabIndex = 0
            Me.Btn_Edit_CashMemo_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Edit_CashMemo_Id, "Edit")
            Me.Btn_Edit_CashMemo_Id.UseVisualStyleBackColor = True
            '
            'Btn_Del_CashMemo_Id
            '
            Me.Btn_Del_CashMemo_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Del_CashMemo_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Del_CashMemo_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Del_CashMemo_Id.Image = CType(resources.GetObject("Btn_Del_CashMemo_Id.Image"), System.Drawing.Image)
            Me.Btn_Del_CashMemo_Id.Location = New System.Drawing.Point(476, 56)
            Me.Btn_Del_CashMemo_Id.Name = "Btn_Del_CashMemo_Id"
            Me.Btn_Del_CashMemo_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Del_CashMemo_Id.TabIndex = 0
            Me.Btn_Del_CashMemo_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Del_CashMemo_Id, "Delete")
            Me.Btn_Del_CashMemo_Id.UseVisualStyleBackColor = True
            '
            'Lbl_CashMemo_Date
            '
            Me.Lbl_CashMemo_Date.AutoSize = True
            Me.Lbl_CashMemo_Date.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_CashMemo_Date.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_CashMemo_Date.ForeColor = System.Drawing.Color.White
            Me.Lbl_CashMemo_Date.Location = New System.Drawing.Point(18, 88)
            Me.Lbl_CashMemo_Date.Name = "Lbl_CashMemo_Date"
            Me.Lbl_CashMemo_Date.Size = New System.Drawing.Size(43, 14)
            Me.Lbl_CashMemo_Date.TabIndex = 1
            Me.Lbl_CashMemo_Date.Text = "Date:"
            '
            'Txt_CashMemo_Date
            '
            Me.Txt_CashMemo_Date.BackColor = System.Drawing.Color.White
            Me.Txt_CashMemo_Date.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_CashMemo_Date.ForeColor = System.Drawing.Color.Black
            Me.Txt_CashMemo_Date.Location = New System.Drawing.Point(148, 85)
            Me.Txt_CashMemo_Date.Name = "Txt_CashMemo_Date"
            Me.Txt_CashMemo_Date.Size = New System.Drawing.Size(200, 22)
            Me.Txt_CashMemo_Date.TabIndex = 1
            '
            'Dtp_CashMemo_Date
            '
            Me.Dtp_CashMemo_Date.CalendarFont = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Dtp_CashMemo_Date.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Dtp_CashMemo_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.Dtp_CashMemo_Date.Location = New System.Drawing.Point(356, 85)
            Me.Dtp_CashMemo_Date.Name = "Dtp_CashMemo_Date"
            Me.Dtp_CashMemo_Date.Size = New System.Drawing.Size(130, 22)
            Me.Dtp_CashMemo_Date.TabIndex = 1
            '
            'Lbl_Profile_Id
            '
            Me.Lbl_Profile_Id.AutoSize = True
            Me.Lbl_Profile_Id.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Profile_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Profile_Id.ForeColor = System.Drawing.Color.White
            Me.Lbl_Profile_Id.Location = New System.Drawing.Point(18, 111)
            Me.Lbl_Profile_Id.Name = "Lbl_Profile_Id"
            Me.Lbl_Profile_Id.Size = New System.Drawing.Size(26, 14)
            Me.Lbl_Profile_Id.TabIndex = 2
            Me.Lbl_Profile_Id.Text = "Id:"
            '
            'Cbo_Profile_Id
            '
            Me.Cbo_Profile_Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.Cbo_Profile_Id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.Cbo_Profile_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cbo_Profile_Id.FormattingEnabled = True
            Me.Cbo_Profile_Id.Location = New System.Drawing.Point(148, 111)
            Me.Cbo_Profile_Id.Name = "Cbo_Profile_Id"
            Me.Cbo_Profile_Id.Size = New System.Drawing.Size(200, 22)
            Me.Cbo_Profile_Id.TabIndex = 2
            '
            'Txt_Profile_Id
            '
            Me.Txt_Profile_Id.BackColor = System.Drawing.SystemColors.Window
            Me.Txt_Profile_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Profile_Id.ForeColor = System.Drawing.Color.Black
            Me.Txt_Profile_Id.Location = New System.Drawing.Point(356, 111)
            Me.Txt_Profile_Id.Name = "Txt_Profile_Id"
            Me.Txt_Profile_Id.ReadOnly = True
            Me.Txt_Profile_Id.Size = New System.Drawing.Size(40, 22)
            Me.Txt_Profile_Id.TabIndex = 2
            Me.Txt_Profile_Id.TabStop = False
            Me.Txt_Profile_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Btn_Add_Profile_Id
            '
            Me.Btn_Add_Profile_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Add_Profile_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Add_Profile_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Add_Profile_Id.Image = CType(resources.GetObject("Btn_Add_Profile_Id.Image"), System.Drawing.Image)
            Me.Btn_Add_Profile_Id.Location = New System.Drawing.Point(404, 108)
            Me.Btn_Add_Profile_Id.Name = "Btn_Add_Profile_Id"
            Me.Btn_Add_Profile_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Add_Profile_Id.TabIndex = 2
            Me.Btn_Add_Profile_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Add_Profile_Id, "Add")
            Me.Btn_Add_Profile_Id.UseVisualStyleBackColor = True
            '
            'Btn_Edit_Profile_Id
            '
            Me.Btn_Edit_Profile_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Edit_Profile_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Edit_Profile_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Edit_Profile_Id.Image = CType(resources.GetObject("Btn_Edit_Profile_Id.Image"), System.Drawing.Image)
            Me.Btn_Edit_Profile_Id.Location = New System.Drawing.Point(440, 108)
            Me.Btn_Edit_Profile_Id.Name = "Btn_Edit_Profile_Id"
            Me.Btn_Edit_Profile_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Edit_Profile_Id.TabIndex = 2
            Me.Btn_Edit_Profile_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Edit_Profile_Id, "Edit")
            Me.Btn_Edit_Profile_Id.UseVisualStyleBackColor = True
            '
            'Btn_Del_Profile_Id
            '
            Me.Btn_Del_Profile_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Del_Profile_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Del_Profile_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Del_Profile_Id.Image = CType(resources.GetObject("Btn_Del_Profile_Id.Image"), System.Drawing.Image)
            Me.Btn_Del_Profile_Id.Location = New System.Drawing.Point(476, 108)
            Me.Btn_Del_Profile_Id.Name = "Btn_Del_Profile_Id"
            Me.Btn_Del_Profile_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Del_Profile_Id.TabIndex = 2
            Me.Btn_Del_Profile_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Del_Profile_Id, "Delete")
            Me.Btn_Del_Profile_Id.UseVisualStyleBackColor = True
            '
            'Lbl_CashMemo_Payment_Amount
            '
            Me.Lbl_CashMemo_Payment_Amount.AutoSize = True
            Me.Lbl_CashMemo_Payment_Amount.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_CashMemo_Payment_Amount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_CashMemo_Payment_Amount.ForeColor = System.Drawing.Color.White
            Me.Lbl_CashMemo_Payment_Amount.Location = New System.Drawing.Point(18, 140)
            Me.Lbl_CashMemo_Payment_Amount.Name = "Lbl_CashMemo_Payment_Amount"
            Me.Lbl_CashMemo_Payment_Amount.Size = New System.Drawing.Size(124, 14)
            Me.Lbl_CashMemo_Payment_Amount.TabIndex = 3
            Me.Lbl_CashMemo_Payment_Amount.Text = "Payment Amount:"
            '
            'Txt_CashMemo_Payment_Amount
            '
            Me.Txt_CashMemo_Payment_Amount.BackColor = System.Drawing.Color.White
            Me.Txt_CashMemo_Payment_Amount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_CashMemo_Payment_Amount.ForeColor = System.Drawing.Color.Black
            Me.Txt_CashMemo_Payment_Amount.Location = New System.Drawing.Point(148, 137)
            Me.Txt_CashMemo_Payment_Amount.Name = "Txt_CashMemo_Payment_Amount"
            Me.Txt_CashMemo_Payment_Amount.Size = New System.Drawing.Size(200, 22)
            Me.Txt_CashMemo_Payment_Amount.TabIndex = 3
            '
            'Lbl_CashMemo_Recive_Amount
            '
            Me.Lbl_CashMemo_Recive_Amount.AutoSize = True
            Me.Lbl_CashMemo_Recive_Amount.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_CashMemo_Recive_Amount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_CashMemo_Recive_Amount.ForeColor = System.Drawing.Color.White
            Me.Lbl_CashMemo_Recive_Amount.Location = New System.Drawing.Point(18, 166)
            Me.Lbl_CashMemo_Recive_Amount.Name = "Lbl_CashMemo_Recive_Amount"
            Me.Lbl_CashMemo_Recive_Amount.Size = New System.Drawing.Size(110, 14)
            Me.Lbl_CashMemo_Recive_Amount.TabIndex = 4
            Me.Lbl_CashMemo_Recive_Amount.Text = "Recive Amount:"
            '
            'Txt_CashMemo_Recive_Amount
            '
            Me.Txt_CashMemo_Recive_Amount.BackColor = System.Drawing.Color.White
            Me.Txt_CashMemo_Recive_Amount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_CashMemo_Recive_Amount.ForeColor = System.Drawing.Color.Black
            Me.Txt_CashMemo_Recive_Amount.Location = New System.Drawing.Point(148, 163)
            Me.Txt_CashMemo_Recive_Amount.Name = "Txt_CashMemo_Recive_Amount"
            Me.Txt_CashMemo_Recive_Amount.Size = New System.Drawing.Size(200, 22)
            Me.Txt_CashMemo_Recive_Amount.TabIndex = 4
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
            Me.Lbl_Header.Size = New System.Drawing.Size(524, 48)
            Me.Lbl_Header.TabIndex = 28
            Me.Lbl_Header.Text = "       Add Cashmemo Here !!!"
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
            Me.Btn_Exit.Location = New System.Drawing.Point(434, 0)
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
            Me.Btn_Save.Location = New System.Drawing.Point(344, 0)
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
            Me.Btn_New.Location = New System.Drawing.Point(254, 0)
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
            Me.Pnl_Top.Size = New System.Drawing.Size(524, 48)
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
            Me.Pnl_Bottom.Location = New System.Drawing.Point(0, 196)
            Me.Pnl_Bottom.Name = "Pnl_Bottom"
            Me.Pnl_Bottom.Size = New System.Drawing.Size(524, 48)
            Me.Pnl_Bottom.TabIndex = 74
            '
            'Cashmemo
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.Controls.Add(Me.Lbl_CashMemo_Id)
            Me.Controls.Add(Me.Cbo_CashMemo_Id)
            Me.Controls.Add(Me.Txt_CashMemo_Id)
            Me.Controls.Add(Me.Btn_Add_CashMemo_Id)
            Me.Controls.Add(Me.Btn_Edit_CashMemo_Id)
            Me.Controls.Add(Me.Btn_Del_CashMemo_Id)
            Me.Controls.Add(Me.Lbl_CashMemo_Date)
            Me.Controls.Add(Me.Txt_CashMemo_Date)
            Me.Controls.Add(Me.Dtp_CashMemo_Date)
            Me.Controls.Add(Me.Lbl_Profile_Id)
            Me.Controls.Add(Me.Cbo_Profile_Id)
            Me.Controls.Add(Me.Txt_Profile_Id)
            Me.Controls.Add(Me.Btn_Add_Profile_Id)
            Me.Controls.Add(Me.Btn_Edit_Profile_Id)
            Me.Controls.Add(Me.Btn_Del_Profile_Id)
            Me.Controls.Add(Me.Lbl_CashMemo_Payment_Amount)
            Me.Controls.Add(Me.Txt_CashMemo_Payment_Amount)
            Me.Controls.Add(Me.Lbl_CashMemo_Recive_Amount)
            Me.Controls.Add(Me.Txt_CashMemo_Recive_Amount)
            Me.Controls.Add(Me.Pnl_Bottom)
            Me.Controls.Add(Me.Pnl_Top)
            Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.Black
            Me.Name = "Cashmemo"
            Me.Size = New System.Drawing.Size(524, 244)
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
            MyBase.SetBoundsCore(x, y, 524, 244, specified)
        End Sub
        Private Sub CashMemo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            FormTitle = "CashMemo"
            clsFeature.SizeLock(SizeLock, ParentForm, FormTitle, Me)
            Cbo_CashMemo_Id.SelectedIndex = -1
            Cbo_Profile_Id.SelectedIndex = -1
            AddEdit = "Add"
        End Sub
        Private Sub CashMemo_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
            clsCashMemo.BoundComboBox(Cbo_CashMemo_Id)
            clsProfiles.BoundComboBox(Cbo_Profile_Id)
        End Sub
        Private Sub CashMemo_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
            ucCashMemo = Nothing
            frmCashMemo = Nothing
        End Sub
        Private Sub Btn_Add_CashMemo_Id_Click(sender As Object, e As EventArgs) Handles Btn_Add_CashMemo_Id.Click
            Btn_New.PerformClick()
        End Sub
        Private Sub Btn_Edit_CashMemo_Id_Click(sender As Object, e As EventArgs) Handles Btn_Edit_CashMemo_Id.Click
            clsCashMemo.Load(Txt_CashMemo_Id, Txt_CashMemo_Date, Txt_Profile_Id, Txt_CashMemo_Payment_Amount, Txt_CashMemo_Recive_Amount)
            If Not String.IsNullOrWhiteSpace(Txt_CashMemo_Id.Text) Then AddEdit = "Edit"
            If Not String.IsNullOrWhiteSpace(Txt_CashMemo_Id.Text) Then Cbo_CashMemo_Id.SelectedValue = Txt_CashMemo_Id.Text
            If Not String.IsNullOrWhiteSpace(Txt_Profile_Id.Text) Then Cbo_Profile_Id.SelectedValue = Txt_Profile_Id.Text
        End Sub
        Private Sub Btn_Del_CashMemo_Id_Click(sender As Object, e As EventArgs) Handles Btn_Del_CashMemo_Id.Click
            clsCashMemo.Delete(Txt_CashMemo_Id, Txt_CashMemo_Date, Txt_Profile_Id, Txt_CashMemo_Payment_Amount, Txt_CashMemo_Recive_Amount)
            clsCashMemo.BoundComboBox(Cbo_CashMemo_Id)
        End Sub
        Private Sub Cbo_CashMemo_Id_GotFocus(sender As Object, e As EventArgs) Handles Cbo_CashMemo_Id.GotFocus
            If Cbo_CashMemo_Id.SelectedIndex = -1 Then ComboBoxUpdate = True
        End Sub
        Private Sub Cbo_CashMemo_Id_DropDown(sender As Object, e As EventArgs) Handles Cbo_CashMemo_Id.DropDown
            clsCashMemo.BoundComboBox(Cbo_CashMemo_Id)
        End Sub
        Private Sub Cbo_CashMemo_Id_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Cbo_CashMemo_Id.PreviewKeyDown
            If ComboBoxUpdate = True Then
                clsCashMemo.BoundComboBox(Cbo_CashMemo_Id)
                ComboBoxUpdate = False
            End If
        End Sub
        Private Sub Cbo_CashMemo_Id_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cbo_CashMemo_Id.SelectionChangeCommitted
            If Not Cbo_CashMemo_Id.SelectedIndex = -1 Then Txt_CashMemo_Id.Text = Cbo_CashMemo_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_CashMemo_Id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_CashMemo_Id.SelectedIndexChanged
            If Not Cbo_CashMemo_Id.SelectedIndex = -1 Then Txt_CashMemo_Id.Text = Cbo_CashMemo_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_CashMemo_Id_LostFocus(sender As Object, e As EventArgs) Handles Cbo_CashMemo_Id.LostFocus
            If Cbo_CashMemo_Id.SelectedIndex = -1 Then
                Cbo_CashMemo_Id.Text = String.Empty
                Txt_CashMemo_Id.Clear()
            End If
        End Sub
        Private Sub Btn_Add_Profile_Id_Click(sender As Object, e As EventArgs) Handles Btn_Add_Profile_Id.Click
            If ucProfiles Is Nothing Then ucProfiles = New UIForm.Profiles
            If frmProfiles Is Nothing Then
                frmProfiles = New UIForm.DialogBox
                ucProfiles.SizeLock = True
                frmProfiles.Controls.Add(ucProfiles)
                frmProfiles.Show()
            Else
                frmProfiles.BringToFront()
            End If
        End Sub
        Private Sub Btn_Edit_Profile_Id_Click(sender As Object, e As EventArgs) Handles Btn_Edit_Profile_Id.Click
            If String.IsNullOrWhiteSpace(Txt_Profile_Id.Text) Then Exit Sub
            If ucProfiles Is Nothing Then ucProfiles = New UIForm.Profiles
            If frmProfiles Is Nothing Then
                frmProfiles = New UIForm.DialogBox
                ucProfiles.SizeLock = True
                frmProfiles.Controls.Add(ucProfiles)
                frmProfiles.Show()
                ucProfiles.Txt_Profile_Id.Text = Txt_Profile_Id.Text
                ucProfiles.Btn_Edit_Profile_Id.PerformClick()
            Else
                frmProfiles.BringToFront()
            End If
        End Sub
        Private Sub Btn_Del_Profile_Id_Click(sender As Object, e As EventArgs) Handles Btn_Del_Profile_Id.Click
            Try
                If Not String.IsNullOrWhiteSpace(Txt_Profile_Id.Text) Then
                    Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If result = DialogResult.Yes Then
                        clsCashMemo.Delete("Profile_Id", Txt_Profile_Id.Text)
                        clsProfiles.Delete(Txt_Profile_Id.Text)
                        clsProfiles.BoundComboBox(Cbo_Profile_Id)
                        MessageBox.Show("Record delete sucessfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Record not selected for delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub Cbo_Profile_Id_GotFocus(sender As Object, e As EventArgs) Handles Cbo_Profile_Id.GotFocus
            If Cbo_Profile_Id.SelectedIndex = -1 Then ComboBoxUpdate = True
        End Sub
        Private Sub Cbo_Profile_Id_DropDown(sender As Object, e As EventArgs) Handles Cbo_Profile_Id.DropDown
            clsProfiles.BoundComboBox(Cbo_Profile_Id)
        End Sub
        Private Sub Cbo_Profile_Id_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Cbo_Profile_Id.PreviewKeyDown
            If ComboBoxUpdate = True Then
                clsProfiles.BoundComboBox(Cbo_Profile_Id)
                ComboBoxUpdate = False
            End If
        End Sub
        Private Sub Cbo_Profile_Id_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cbo_Profile_Id.SelectionChangeCommitted
            If Not Cbo_Profile_Id.SelectedIndex = -1 Then Txt_Profile_Id.Text = Cbo_Profile_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_Profile_Id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Profile_Id.SelectedIndexChanged
            If Not Cbo_Profile_Id.SelectedIndex = -1 Then Txt_Profile_Id.Text = Cbo_Profile_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_Profile_Id_LostFocus(sender As Object, e As EventArgs) Handles Cbo_Profile_Id.LostFocus
            If Cbo_Profile_Id.SelectedIndex = -1 Then
                Cbo_Profile_Id.Text = String.Empty
                Txt_Profile_Id.Clear()
            End If
        End Sub
        Private Sub Dtp_CashMemo_Date_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_CashMemo_Date.ValueChanged
            Txt_CashMemo_Date.Text = Dtp_CashMemo_Date.Value
        End Sub
        Private Sub Dtp_CashMemo_Date_Leave(sender As Object, e As EventArgs) Handles Dtp_CashMemo_Date.Leave
            Txt_CashMemo_Date.Text = Dtp_CashMemo_Date.Value
        End Sub
        Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
            clsCashMemo.Clear(Txt_CashMemo_Id, Txt_CashMemo_Date, Txt_Profile_Id, Txt_CashMemo_Payment_Amount, Txt_CashMemo_Recive_Amount)
            AddEdit = "Add"
        End Sub
        Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
            clsCashMemo.Auto(True, AddEdit, Txt_CashMemo_Id, Txt_CashMemo_Date, Txt_Profile_Id, Txt_CashMemo_Payment_Amount, Txt_CashMemo_Recive_Amount)
            Cbo_CashMemo_Id.SelectedIndex = -1
            Cbo_Profile_Id.SelectedIndex = -1
            AddEdit = "Add"
        End Sub
        Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
            Me.ParentForm.Close()
        End Sub
#End Region
    End Class
End Namespace