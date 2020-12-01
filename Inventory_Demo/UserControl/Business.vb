Imports System.ComponentModel
Namespace UIForm
    ' Build Action Embedded Resource
    <ToolboxBitmap(GetType(Business), "Business.ico"), ToolboxItem(False)>
    Public Class Business
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
        Friend WithEvents Lbl_Business_Id As Label
        Friend WithEvents Cbo_Business_Id As ComboBox
        Friend WithEvents Txt_Business_Id As TextBox
        Friend WithEvents Btn_Add_Business_Id As Button
        Friend WithEvents Btn_Edit_Business_Id As Button
        Friend WithEvents Btn_Del_Business_Id As Button
        Friend WithEvents Lbl_Business_Name As Label
        Friend WithEvents Txt_Business_Name As TextBox
        Friend WithEvents Lbl_Business_Phone As Label
        Friend WithEvents Txt_Business_Phone As TextBox
        Friend WithEvents Lbl_Business_Mail As Label
        Friend WithEvents Txt_Business_Mail As TextBox
        Friend WithEvents Lbl_Business_GST_No As Label
        Friend WithEvents Txt_Business_GST_No As TextBox
        Friend WithEvents Lbl_Business_Pan_No As Label
        Friend WithEvents Txt_Business_Pan_No As TextBox
        Friend WithEvents Lbl_Business_CGST As Label
        Friend WithEvents Txt_Business_CGST As TextBox
        Friend WithEvents Lbl_Business_SGST As Label
        Friend WithEvents Txt_Business_SGST As TextBox
        Friend WithEvents Lbl_Business_IGST As Label
        Friend WithEvents Txt_Business_IGST As TextBox
        Friend WithEvents Lbl_Business_Tin As Label
        Friend WithEvents Txt_Business_Tin As TextBox
        Friend WithEvents Lbl_Business_Bank_Account As Label
        Friend WithEvents Txt_Business_Bank_Account As TextBox
        Friend WithEvents Lbl_Business_Bill_No As Label
        Friend WithEvents Txt_Business_Bill_No As TextBox
        Friend WithEvents Lbl_Business_Address As Label
        Friend WithEvents Txt_Business_Address As TextBox
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Business))
            Me.Lbl_Business_Id = New System.Windows.Forms.Label()
            Me.Cbo_Business_Id = New System.Windows.Forms.ComboBox()
            Me.Txt_Business_Id = New System.Windows.Forms.TextBox()
            Me.Btn_Add_Business_Id = New System.Windows.Forms.Button()
            Me.Btn_Edit_Business_Id = New System.Windows.Forms.Button()
            Me.Btn_Del_Business_Id = New System.Windows.Forms.Button()
            Me.Lbl_Business_Name = New System.Windows.Forms.Label()
            Me.Txt_Business_Name = New System.Windows.Forms.TextBox()
            Me.Lbl_Business_Phone = New System.Windows.Forms.Label()
            Me.Txt_Business_Phone = New System.Windows.Forms.TextBox()
            Me.Lbl_Business_Mail = New System.Windows.Forms.Label()
            Me.Txt_Business_Mail = New System.Windows.Forms.TextBox()
            Me.Lbl_Business_GST_No = New System.Windows.Forms.Label()
            Me.Txt_Business_GST_No = New System.Windows.Forms.TextBox()
            Me.Lbl_Business_Pan_No = New System.Windows.Forms.Label()
            Me.Txt_Business_Pan_No = New System.Windows.Forms.TextBox()
            Me.Lbl_Business_CGST = New System.Windows.Forms.Label()
            Me.Txt_Business_CGST = New System.Windows.Forms.TextBox()
            Me.Lbl_Business_SGST = New System.Windows.Forms.Label()
            Me.Txt_Business_SGST = New System.Windows.Forms.TextBox()
            Me.Lbl_Business_IGST = New System.Windows.Forms.Label()
            Me.Txt_Business_IGST = New System.Windows.Forms.TextBox()
            Me.Lbl_Business_Tin = New System.Windows.Forms.Label()
            Me.Txt_Business_Tin = New System.Windows.Forms.TextBox()
            Me.Lbl_Business_Bank_Account = New System.Windows.Forms.Label()
            Me.Txt_Business_Bank_Account = New System.Windows.Forms.TextBox()
            Me.Lbl_Business_Bill_No = New System.Windows.Forms.Label()
            Me.Txt_Business_Bill_No = New System.Windows.Forms.TextBox()
            Me.Lbl_Business_Address = New System.Windows.Forms.Label()
            Me.Txt_Business_Address = New System.Windows.Forms.TextBox()
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
            'Lbl_Business_Id
            '
            Me.Lbl_Business_Id.AutoSize = True
            Me.Lbl_Business_Id.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Business_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Business_Id.ForeColor = System.Drawing.Color.White
            Me.Lbl_Business_Id.Location = New System.Drawing.Point(18, 62)
            Me.Lbl_Business_Id.Name = "Lbl_Business_Id"
            Me.Lbl_Business_Id.Size = New System.Drawing.Size(26, 14)
            Me.Lbl_Business_Id.TabIndex = 0
            Me.Lbl_Business_Id.Text = "Id:"
            '
            'Cbo_Business_Id
            '
            Me.Cbo_Business_Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.Cbo_Business_Id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.Cbo_Business_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cbo_Business_Id.FormattingEnabled = True
            Me.Cbo_Business_Id.Location = New System.Drawing.Point(125, 59)
            Me.Cbo_Business_Id.Name = "Cbo_Business_Id"
            Me.Cbo_Business_Id.Size = New System.Drawing.Size(200, 22)
            Me.Cbo_Business_Id.TabIndex = 0
            '
            'Txt_Business_Id
            '
            Me.Txt_Business_Id.BackColor = System.Drawing.SystemColors.Window
            Me.Txt_Business_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Business_Id.ForeColor = System.Drawing.Color.Black
            Me.Txt_Business_Id.Location = New System.Drawing.Point(333, 59)
            Me.Txt_Business_Id.Name = "Txt_Business_Id"
            Me.Txt_Business_Id.ReadOnly = True
            Me.Txt_Business_Id.Size = New System.Drawing.Size(40, 22)
            Me.Txt_Business_Id.TabIndex = 0
            Me.Txt_Business_Id.TabStop = False
            Me.Txt_Business_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Btn_Add_Business_Id
            '
            Me.Btn_Add_Business_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Add_Business_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Add_Business_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Add_Business_Id.Image = CType(resources.GetObject("Btn_Add_Business_Id.Image"), System.Drawing.Image)
            Me.Btn_Add_Business_Id.Location = New System.Drawing.Point(381, 56)
            Me.Btn_Add_Business_Id.Name = "Btn_Add_Business_Id"
            Me.Btn_Add_Business_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Add_Business_Id.TabIndex = 0
            Me.Btn_Add_Business_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Add_Business_Id, "Add")
            Me.Btn_Add_Business_Id.UseVisualStyleBackColor = True
            '
            'Btn_Edit_Business_Id
            '
            Me.Btn_Edit_Business_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Edit_Business_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Edit_Business_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Edit_Business_Id.Image = CType(resources.GetObject("Btn_Edit_Business_Id.Image"), System.Drawing.Image)
            Me.Btn_Edit_Business_Id.Location = New System.Drawing.Point(417, 56)
            Me.Btn_Edit_Business_Id.Name = "Btn_Edit_Business_Id"
            Me.Btn_Edit_Business_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Edit_Business_Id.TabIndex = 0
            Me.Btn_Edit_Business_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Edit_Business_Id, "Edit")
            Me.Btn_Edit_Business_Id.UseVisualStyleBackColor = True
            '
            'Btn_Del_Business_Id
            '
            Me.Btn_Del_Business_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Del_Business_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Del_Business_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Del_Business_Id.Image = CType(resources.GetObject("Btn_Del_Business_Id.Image"), System.Drawing.Image)
            Me.Btn_Del_Business_Id.Location = New System.Drawing.Point(453, 56)
            Me.Btn_Del_Business_Id.Name = "Btn_Del_Business_Id"
            Me.Btn_Del_Business_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Del_Business_Id.TabIndex = 0
            Me.Btn_Del_Business_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Del_Business_Id, "Delete")
            Me.Btn_Del_Business_Id.UseVisualStyleBackColor = True
            '
            'Lbl_Business_Name
            '
            Me.Lbl_Business_Name.AutoSize = True
            Me.Lbl_Business_Name.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Business_Name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Business_Name.ForeColor = System.Drawing.Color.White
            Me.Lbl_Business_Name.Location = New System.Drawing.Point(18, 88)
            Me.Lbl_Business_Name.Name = "Lbl_Business_Name"
            Me.Lbl_Business_Name.Size = New System.Drawing.Size(50, 14)
            Me.Lbl_Business_Name.TabIndex = 1
            Me.Lbl_Business_Name.Text = "Name:"
            '
            'Txt_Business_Name
            '
            Me.Txt_Business_Name.BackColor = System.Drawing.Color.White
            Me.Txt_Business_Name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Business_Name.ForeColor = System.Drawing.Color.Black
            Me.Txt_Business_Name.Location = New System.Drawing.Point(125, 85)
            Me.Txt_Business_Name.Name = "Txt_Business_Name"
            Me.Txt_Business_Name.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Business_Name.TabIndex = 1
            '
            'Lbl_Business_Phone
            '
            Me.Lbl_Business_Phone.AutoSize = True
            Me.Lbl_Business_Phone.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Business_Phone.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Business_Phone.ForeColor = System.Drawing.Color.White
            Me.Lbl_Business_Phone.Location = New System.Drawing.Point(18, 114)
            Me.Lbl_Business_Phone.Name = "Lbl_Business_Phone"
            Me.Lbl_Business_Phone.Size = New System.Drawing.Size(53, 14)
            Me.Lbl_Business_Phone.TabIndex = 2
            Me.Lbl_Business_Phone.Text = "Phone:"
            '
            'Txt_Business_Phone
            '
            Me.Txt_Business_Phone.BackColor = System.Drawing.Color.White
            Me.Txt_Business_Phone.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Business_Phone.ForeColor = System.Drawing.Color.Black
            Me.Txt_Business_Phone.Location = New System.Drawing.Point(125, 111)
            Me.Txt_Business_Phone.Name = "Txt_Business_Phone"
            Me.Txt_Business_Phone.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Business_Phone.TabIndex = 2
            '
            'Lbl_Business_Mail
            '
            Me.Lbl_Business_Mail.AutoSize = True
            Me.Lbl_Business_Mail.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Business_Mail.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Business_Mail.ForeColor = System.Drawing.Color.White
            Me.Lbl_Business_Mail.Location = New System.Drawing.Point(18, 140)
            Me.Lbl_Business_Mail.Name = "Lbl_Business_Mail"
            Me.Lbl_Business_Mail.Size = New System.Drawing.Size(39, 14)
            Me.Lbl_Business_Mail.TabIndex = 3
            Me.Lbl_Business_Mail.Text = "Mail:"
            '
            'Txt_Business_Mail
            '
            Me.Txt_Business_Mail.BackColor = System.Drawing.Color.White
            Me.Txt_Business_Mail.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Business_Mail.ForeColor = System.Drawing.Color.Black
            Me.Txt_Business_Mail.Location = New System.Drawing.Point(125, 137)
            Me.Txt_Business_Mail.Name = "Txt_Business_Mail"
            Me.Txt_Business_Mail.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Business_Mail.TabIndex = 3
            '
            'Lbl_Business_GST_No
            '
            Me.Lbl_Business_GST_No.AutoSize = True
            Me.Lbl_Business_GST_No.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Business_GST_No.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Business_GST_No.ForeColor = System.Drawing.Color.White
            Me.Lbl_Business_GST_No.Location = New System.Drawing.Point(18, 166)
            Me.Lbl_Business_GST_No.Name = "Lbl_Business_GST_No"
            Me.Lbl_Business_GST_No.Size = New System.Drawing.Size(61, 14)
            Me.Lbl_Business_GST_No.TabIndex = 4
            Me.Lbl_Business_GST_No.Text = "GST No:"
            '
            'Txt_Business_GST_No
            '
            Me.Txt_Business_GST_No.BackColor = System.Drawing.Color.White
            Me.Txt_Business_GST_No.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Business_GST_No.ForeColor = System.Drawing.Color.Black
            Me.Txt_Business_GST_No.Location = New System.Drawing.Point(125, 163)
            Me.Txt_Business_GST_No.Name = "Txt_Business_GST_No"
            Me.Txt_Business_GST_No.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Business_GST_No.TabIndex = 4
            '
            'Lbl_Business_Pan_No
            '
            Me.Lbl_Business_Pan_No.AutoSize = True
            Me.Lbl_Business_Pan_No.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Business_Pan_No.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Business_Pan_No.ForeColor = System.Drawing.Color.White
            Me.Lbl_Business_Pan_No.Location = New System.Drawing.Point(18, 192)
            Me.Lbl_Business_Pan_No.Name = "Lbl_Business_Pan_No"
            Me.Lbl_Business_Pan_No.Size = New System.Drawing.Size(59, 14)
            Me.Lbl_Business_Pan_No.TabIndex = 5
            Me.Lbl_Business_Pan_No.Text = "Pan No:"
            '
            'Txt_Business_Pan_No
            '
            Me.Txt_Business_Pan_No.BackColor = System.Drawing.Color.White
            Me.Txt_Business_Pan_No.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Business_Pan_No.ForeColor = System.Drawing.Color.Black
            Me.Txt_Business_Pan_No.Location = New System.Drawing.Point(125, 189)
            Me.Txt_Business_Pan_No.Name = "Txt_Business_Pan_No"
            Me.Txt_Business_Pan_No.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Business_Pan_No.TabIndex = 5
            '
            'Lbl_Business_CGST
            '
            Me.Lbl_Business_CGST.AutoSize = True
            Me.Lbl_Business_CGST.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Business_CGST.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Business_CGST.ForeColor = System.Drawing.Color.White
            Me.Lbl_Business_CGST.Location = New System.Drawing.Point(18, 218)
            Me.Lbl_Business_CGST.Name = "Lbl_Business_CGST"
            Me.Lbl_Business_CGST.Size = New System.Drawing.Size(48, 14)
            Me.Lbl_Business_CGST.TabIndex = 6
            Me.Lbl_Business_CGST.Text = "CGST:"
            '
            'Txt_Business_CGST
            '
            Me.Txt_Business_CGST.BackColor = System.Drawing.Color.White
            Me.Txt_Business_CGST.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Business_CGST.ForeColor = System.Drawing.Color.Black
            Me.Txt_Business_CGST.Location = New System.Drawing.Point(125, 215)
            Me.Txt_Business_CGST.Name = "Txt_Business_CGST"
            Me.Txt_Business_CGST.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Business_CGST.TabIndex = 6
            '
            'Lbl_Business_SGST
            '
            Me.Lbl_Business_SGST.AutoSize = True
            Me.Lbl_Business_SGST.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Business_SGST.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Business_SGST.ForeColor = System.Drawing.Color.White
            Me.Lbl_Business_SGST.Location = New System.Drawing.Point(18, 244)
            Me.Lbl_Business_SGST.Name = "Lbl_Business_SGST"
            Me.Lbl_Business_SGST.Size = New System.Drawing.Size(48, 14)
            Me.Lbl_Business_SGST.TabIndex = 7
            Me.Lbl_Business_SGST.Text = "SGST:"
            '
            'Txt_Business_SGST
            '
            Me.Txt_Business_SGST.BackColor = System.Drawing.Color.White
            Me.Txt_Business_SGST.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Business_SGST.ForeColor = System.Drawing.Color.Black
            Me.Txt_Business_SGST.Location = New System.Drawing.Point(125, 241)
            Me.Txt_Business_SGST.Name = "Txt_Business_SGST"
            Me.Txt_Business_SGST.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Business_SGST.TabIndex = 7
            '
            'Lbl_Business_IGST
            '
            Me.Lbl_Business_IGST.AutoSize = True
            Me.Lbl_Business_IGST.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Business_IGST.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Business_IGST.ForeColor = System.Drawing.Color.White
            Me.Lbl_Business_IGST.Location = New System.Drawing.Point(18, 270)
            Me.Lbl_Business_IGST.Name = "Lbl_Business_IGST"
            Me.Lbl_Business_IGST.Size = New System.Drawing.Size(45, 14)
            Me.Lbl_Business_IGST.TabIndex = 8
            Me.Lbl_Business_IGST.Text = "IGST:"
            '
            'Txt_Business_IGST
            '
            Me.Txt_Business_IGST.BackColor = System.Drawing.Color.White
            Me.Txt_Business_IGST.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Business_IGST.ForeColor = System.Drawing.Color.Black
            Me.Txt_Business_IGST.Location = New System.Drawing.Point(125, 267)
            Me.Txt_Business_IGST.Name = "Txt_Business_IGST"
            Me.Txt_Business_IGST.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Business_IGST.TabIndex = 8
            '
            'Lbl_Business_Tin
            '
            Me.Lbl_Business_Tin.AutoSize = True
            Me.Lbl_Business_Tin.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Business_Tin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Business_Tin.ForeColor = System.Drawing.Color.White
            Me.Lbl_Business_Tin.Location = New System.Drawing.Point(18, 296)
            Me.Lbl_Business_Tin.Name = "Lbl_Business_Tin"
            Me.Lbl_Business_Tin.Size = New System.Drawing.Size(32, 14)
            Me.Lbl_Business_Tin.TabIndex = 9
            Me.Lbl_Business_Tin.Text = "Tin:"
            '
            'Txt_Business_Tin
            '
            Me.Txt_Business_Tin.BackColor = System.Drawing.Color.White
            Me.Txt_Business_Tin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Business_Tin.ForeColor = System.Drawing.Color.Black
            Me.Txt_Business_Tin.Location = New System.Drawing.Point(125, 293)
            Me.Txt_Business_Tin.Name = "Txt_Business_Tin"
            Me.Txt_Business_Tin.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Business_Tin.TabIndex = 9
            '
            'Lbl_Business_Bank_Account
            '
            Me.Lbl_Business_Bank_Account.AutoSize = True
            Me.Lbl_Business_Bank_Account.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Business_Bank_Account.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Business_Bank_Account.ForeColor = System.Drawing.Color.White
            Me.Lbl_Business_Bank_Account.Location = New System.Drawing.Point(18, 322)
            Me.Lbl_Business_Bank_Account.Name = "Lbl_Business_Bank_Account"
            Me.Lbl_Business_Bank_Account.Size = New System.Drawing.Size(101, 14)
            Me.Lbl_Business_Bank_Account.TabIndex = 10
            Me.Lbl_Business_Bank_Account.Text = "Bank Account:"
            '
            'Txt_Business_Bank_Account
            '
            Me.Txt_Business_Bank_Account.BackColor = System.Drawing.Color.White
            Me.Txt_Business_Bank_Account.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Business_Bank_Account.ForeColor = System.Drawing.Color.Black
            Me.Txt_Business_Bank_Account.Location = New System.Drawing.Point(125, 319)
            Me.Txt_Business_Bank_Account.Name = "Txt_Business_Bank_Account"
            Me.Txt_Business_Bank_Account.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Business_Bank_Account.TabIndex = 10
            '
            'Lbl_Business_Bill_No
            '
            Me.Lbl_Business_Bill_No.AutoSize = True
            Me.Lbl_Business_Bill_No.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Business_Bill_No.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Business_Bill_No.ForeColor = System.Drawing.Color.White
            Me.Lbl_Business_Bill_No.Location = New System.Drawing.Point(18, 348)
            Me.Lbl_Business_Bill_No.Name = "Lbl_Business_Bill_No"
            Me.Lbl_Business_Bill_No.Size = New System.Drawing.Size(55, 14)
            Me.Lbl_Business_Bill_No.TabIndex = 11
            Me.Lbl_Business_Bill_No.Text = "Bill No:"
            '
            'Txt_Business_Bill_No
            '
            Me.Txt_Business_Bill_No.BackColor = System.Drawing.Color.White
            Me.Txt_Business_Bill_No.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Business_Bill_No.ForeColor = System.Drawing.Color.Black
            Me.Txt_Business_Bill_No.Location = New System.Drawing.Point(125, 345)
            Me.Txt_Business_Bill_No.Name = "Txt_Business_Bill_No"
            Me.Txt_Business_Bill_No.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Business_Bill_No.TabIndex = 11
            '
            'Lbl_Business_Address
            '
            Me.Lbl_Business_Address.AutoSize = True
            Me.Lbl_Business_Address.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Business_Address.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Business_Address.ForeColor = System.Drawing.Color.White
            Me.Lbl_Business_Address.Location = New System.Drawing.Point(18, 374)
            Me.Lbl_Business_Address.Name = "Lbl_Business_Address"
            Me.Lbl_Business_Address.Size = New System.Drawing.Size(65, 14)
            Me.Lbl_Business_Address.TabIndex = 12
            Me.Lbl_Business_Address.Text = "Address:"
            '
            'Txt_Business_Address
            '
            Me.Txt_Business_Address.BackColor = System.Drawing.Color.White
            Me.Txt_Business_Address.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Business_Address.ForeColor = System.Drawing.Color.Black
            Me.Txt_Business_Address.Location = New System.Drawing.Point(125, 371)
            Me.Txt_Business_Address.Name = "Txt_Business_Address"
            Me.Txt_Business_Address.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Business_Address.TabIndex = 12
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
            Me.Lbl_Header.Size = New System.Drawing.Size(501, 48)
            Me.Lbl_Header.TabIndex = 28
            Me.Lbl_Header.Text = "       Add Business Here !!!"
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
            Me.Btn_Exit.Location = New System.Drawing.Point(411, 0)
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
            Me.Btn_Save.Location = New System.Drawing.Point(321, 0)
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
            Me.Btn_New.Location = New System.Drawing.Point(231, 0)
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
            Me.Pnl_Top.Size = New System.Drawing.Size(501, 48)
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
            Me.Pnl_Bottom.Location = New System.Drawing.Point(0, 404)
            Me.Pnl_Bottom.Name = "Pnl_Bottom"
            Me.Pnl_Bottom.Size = New System.Drawing.Size(501, 48)
            Me.Pnl_Bottom.TabIndex = 74
            '
            'Business
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.Controls.Add(Me.Lbl_Business_Id)
            Me.Controls.Add(Me.Cbo_Business_Id)
            Me.Controls.Add(Me.Txt_Business_Id)
            Me.Controls.Add(Me.Btn_Add_Business_Id)
            Me.Controls.Add(Me.Btn_Edit_Business_Id)
            Me.Controls.Add(Me.Btn_Del_Business_Id)
            Me.Controls.Add(Me.Lbl_Business_Name)
            Me.Controls.Add(Me.Txt_Business_Name)
            Me.Controls.Add(Me.Lbl_Business_Phone)
            Me.Controls.Add(Me.Txt_Business_Phone)
            Me.Controls.Add(Me.Lbl_Business_Mail)
            Me.Controls.Add(Me.Txt_Business_Mail)
            Me.Controls.Add(Me.Lbl_Business_GST_No)
            Me.Controls.Add(Me.Txt_Business_GST_No)
            Me.Controls.Add(Me.Lbl_Business_Pan_No)
            Me.Controls.Add(Me.Txt_Business_Pan_No)
            Me.Controls.Add(Me.Lbl_Business_CGST)
            Me.Controls.Add(Me.Txt_Business_CGST)
            Me.Controls.Add(Me.Lbl_Business_SGST)
            Me.Controls.Add(Me.Txt_Business_SGST)
            Me.Controls.Add(Me.Lbl_Business_IGST)
            Me.Controls.Add(Me.Txt_Business_IGST)
            Me.Controls.Add(Me.Lbl_Business_Tin)
            Me.Controls.Add(Me.Txt_Business_Tin)
            Me.Controls.Add(Me.Lbl_Business_Bank_Account)
            Me.Controls.Add(Me.Txt_Business_Bank_Account)
            Me.Controls.Add(Me.Lbl_Business_Bill_No)
            Me.Controls.Add(Me.Txt_Business_Bill_No)
            Me.Controls.Add(Me.Lbl_Business_Address)
            Me.Controls.Add(Me.Txt_Business_Address)
            Me.Controls.Add(Me.Pnl_Bottom)
            Me.Controls.Add(Me.Pnl_Top)
            Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.Black
            Me.Name = "Business"
            Me.Size = New System.Drawing.Size(501, 452)
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
            MyBase.SetBoundsCore(x, y, 501, 452, specified)
        End Sub
        Private Sub Business_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            FormTitle = "Business"
            clsFeature.SizeLock(SizeLock, ParentForm, FormTitle, Me)
            Cbo_Business_Id.SelectedIndex = -1
            AddEdit = "Add"
        End Sub
        Private Sub Business_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
            clsBusiness.BoundComboBox(Cbo_Business_Id)
        End Sub
        Private Sub Business_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
            ucBusiness = Nothing
            frmBusiness = Nothing
        End Sub
        Private Sub Btn_Add_Business_Id_Click(sender As Object, e As EventArgs) Handles Btn_Add_Business_Id.Click
            Btn_New.PerformClick()
        End Sub
        Private Sub Btn_Edit_Business_Id_Click(sender As Object, e As EventArgs) Handles Btn_Edit_Business_Id.Click
            clsBusiness.Load(Txt_Business_Id, Txt_Business_Name, Txt_Business_Phone, Txt_Business_Mail, Txt_Business_GST_No, Txt_Business_Pan_No, Txt_Business_CGST, Txt_Business_SGST, Txt_Business_IGST, Txt_Business_Tin, Txt_Business_Bank_Account, Txt_Business_Bill_No, Txt_Business_Address)
            If Not String.IsNullOrWhiteSpace(Txt_Business_Id.Text) Then AddEdit = "Edit"
            If Not String.IsNullOrWhiteSpace(Txt_Business_Id.Text) Then Cbo_Business_Id.SelectedValue = Txt_Business_Id.Text
        End Sub
        Private Sub Btn_Del_Business_Id_Click(sender As Object, e As EventArgs) Handles Btn_Del_Business_Id.Click
            clsBusiness.Delete(Txt_Business_Id, Txt_Business_Name, Txt_Business_Phone, Txt_Business_Mail, Txt_Business_GST_No, Txt_Business_Pan_No, Txt_Business_CGST, Txt_Business_SGST, Txt_Business_IGST, Txt_Business_Tin, Txt_Business_Bank_Account, Txt_Business_Bill_No, Txt_Business_Address)
            clsBusiness.BoundComboBox(Cbo_Business_Id)
        End Sub
        Private Sub Cbo_Business_Id_GotFocus(sender As Object, e As EventArgs) Handles Cbo_Business_Id.GotFocus
            If Cbo_Business_Id.SelectedIndex = -1 Then ComboBoxUpdate = True
        End Sub
        Private Sub Cbo_Business_Id_DropDown(sender As Object, e As EventArgs) Handles Cbo_Business_Id.DropDown
            clsBusiness.BoundComboBox(Cbo_Business_Id)
        End Sub
        Private Sub Cbo_Business_Id_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Cbo_Business_Id.PreviewKeyDown
            If ComboBoxUpdate = True Then
                clsBusiness.BoundComboBox(Cbo_Business_Id)
                ComboBoxUpdate = False
            End If
        End Sub
        Private Sub Cbo_Business_Id_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cbo_Business_Id.SelectionChangeCommitted
            If Not Cbo_Business_Id.SelectedIndex = -1 Then Txt_Business_Id.Text = Cbo_Business_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_Business_Id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Business_Id.SelectedIndexChanged
            If Not Cbo_Business_Id.SelectedIndex = -1 Then Txt_Business_Id.Text = Cbo_Business_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_Business_Id_LostFocus(sender As Object, e As EventArgs) Handles Cbo_Business_Id.LostFocus
            If Cbo_Business_Id.SelectedIndex = -1 Then
                Cbo_Business_Id.Text = String.Empty
                Txt_Business_Id.Clear()
            End If
        End Sub
        Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
            clsBusiness.Clear(Txt_Business_Id, Txt_Business_Name, Txt_Business_Phone, Txt_Business_Mail, Txt_Business_GST_No, Txt_Business_Pan_No, Txt_Business_CGST, Txt_Business_SGST, Txt_Business_IGST, Txt_Business_Tin, Txt_Business_Bank_Account, Txt_Business_Bill_No, Txt_Business_Address)
            AddEdit = "Add"
        End Sub
        Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
            clsBusiness.Auto(True, AddEdit, Txt_Business_Id, Txt_Business_Name, Txt_Business_Phone, Txt_Business_Mail, Txt_Business_GST_No, Txt_Business_Pan_No, Txt_Business_CGST, Txt_Business_SGST, Txt_Business_IGST, Txt_Business_Tin, Txt_Business_Bank_Account, Txt_Business_Bill_No, Txt_Business_Address)
            Cbo_Business_Id.SelectedIndex = -1
            AddEdit = "Add"
        End Sub
        Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
            Me.ParentForm.Close()
        End Sub
#End Region
    End Class
End Namespace