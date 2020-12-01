Imports System.ComponentModel
Namespace UIForm
    ' Build Action Embedded Resource
    <ToolboxBitmap(GetType(Products), "Products.ico"), ToolboxItem(False)>
    Public Class Products
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
        Friend WithEvents Lbl_Product_Id As Label
        Friend WithEvents Cbo_Product_Id As ComboBox
        Friend WithEvents Txt_Product_Id As TextBox
        Friend WithEvents Btn_Add_Product_Id As Button
        Friend WithEvents Btn_Edit_Product_Id As Button
        Friend WithEvents Btn_Del_Product_Id As Button
        Friend WithEvents Lbl_Category_Id As Label
        Friend WithEvents Cbo_Category_Id As ComboBox
        Friend WithEvents Txt_Category_Id As TextBox
        Friend WithEvents Btn_Add_Category_Id As Button
        Friend WithEvents Btn_Edit_Category_Id As Button
        Friend WithEvents Btn_Del_Category_Id As Button
        Friend WithEvents Lbl_Category_Name As Label
        Friend WithEvents Txt_Category_Name As TextBox
        Friend WithEvents Lbl_Product_Name As Label
        Friend WithEvents Txt_Product_Name As TextBox
        Friend WithEvents Lbl_Unit_Id As Label
        Friend WithEvents Cbo_Unit_Id As ComboBox
        Friend WithEvents Txt_Unit_Id As TextBox
        Friend WithEvents Btn_Add_Unit_Id As Button
        Friend WithEvents Btn_Edit_Unit_Id As Button
        Friend WithEvents Btn_Del_Unit_Id As Button
        Friend WithEvents Lbl_Unit_Name As Label
        Friend WithEvents Txt_Unit_Name As TextBox
        Friend WithEvents Lbl_HSN_Code As Label
        Friend WithEvents Txt_HSN_Code As TextBox
        Friend WithEvents Lbl_Product_Stock As Label
        Friend WithEvents Txt_Product_Stock As TextBox
        Friend WithEvents Lbl_Product_Single_Amount As Label
        Friend WithEvents Txt_Product_Single_Amount As TextBox
        Friend WithEvents Lbl_Product_Note As Label
        Friend WithEvents Txt_Product_Note As TextBox
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Products))
            Me.Lbl_Product_Id = New System.Windows.Forms.Label()
            Me.Cbo_Product_Id = New System.Windows.Forms.ComboBox()
            Me.Txt_Product_Id = New System.Windows.Forms.TextBox()
            Me.Btn_Add_Product_Id = New System.Windows.Forms.Button()
            Me.Btn_Edit_Product_Id = New System.Windows.Forms.Button()
            Me.Btn_Del_Product_Id = New System.Windows.Forms.Button()
            Me.Lbl_Category_Id = New System.Windows.Forms.Label()
            Me.Cbo_Category_Id = New System.Windows.Forms.ComboBox()
            Me.Txt_Category_Id = New System.Windows.Forms.TextBox()
            Me.Btn_Add_Category_Id = New System.Windows.Forms.Button()
            Me.Btn_Edit_Category_Id = New System.Windows.Forms.Button()
            Me.Btn_Del_Category_Id = New System.Windows.Forms.Button()
            Me.Lbl_Category_Name = New System.Windows.Forms.Label()
            Me.Txt_Category_Name = New System.Windows.Forms.TextBox()
            Me.Lbl_Product_Name = New System.Windows.Forms.Label()
            Me.Txt_Product_Name = New System.Windows.Forms.TextBox()
            Me.Lbl_Unit_Id = New System.Windows.Forms.Label()
            Me.Cbo_Unit_Id = New System.Windows.Forms.ComboBox()
            Me.Txt_Unit_Id = New System.Windows.Forms.TextBox()
            Me.Btn_Add_Unit_Id = New System.Windows.Forms.Button()
            Me.Btn_Edit_Unit_Id = New System.Windows.Forms.Button()
            Me.Btn_Del_Unit_Id = New System.Windows.Forms.Button()
            Me.Lbl_Unit_Name = New System.Windows.Forms.Label()
            Me.Txt_Unit_Name = New System.Windows.Forms.TextBox()
            Me.Lbl_HSN_Code = New System.Windows.Forms.Label()
            Me.Txt_HSN_Code = New System.Windows.Forms.TextBox()
            Me.Lbl_Product_Stock = New System.Windows.Forms.Label()
            Me.Txt_Product_Stock = New System.Windows.Forms.TextBox()
            Me.Lbl_Product_Single_Amount = New System.Windows.Forms.Label()
            Me.Txt_Product_Single_Amount = New System.Windows.Forms.TextBox()
            Me.Lbl_Product_Note = New System.Windows.Forms.Label()
            Me.Txt_Product_Note = New System.Windows.Forms.TextBox()
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
            'Lbl_Product_Id
            '
            Me.Lbl_Product_Id.AutoSize = True
            Me.Lbl_Product_Id.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Product_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Product_Id.ForeColor = System.Drawing.Color.White
            Me.Lbl_Product_Id.Location = New System.Drawing.Point(18, 62)
            Me.Lbl_Product_Id.Name = "Lbl_Product_Id"
            Me.Lbl_Product_Id.Size = New System.Drawing.Size(26, 14)
            Me.Lbl_Product_Id.TabIndex = 0
            Me.Lbl_Product_Id.Text = "Id:"
            '
            'Cbo_Product_Id
            '
            Me.Cbo_Product_Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.Cbo_Product_Id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.Cbo_Product_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cbo_Product_Id.FormattingEnabled = True
            Me.Cbo_Product_Id.Location = New System.Drawing.Point(131, 59)
            Me.Cbo_Product_Id.Name = "Cbo_Product_Id"
            Me.Cbo_Product_Id.Size = New System.Drawing.Size(200, 22)
            Me.Cbo_Product_Id.TabIndex = 0
            '
            'Txt_Product_Id
            '
            Me.Txt_Product_Id.BackColor = System.Drawing.SystemColors.Window
            Me.Txt_Product_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Product_Id.ForeColor = System.Drawing.Color.Black
            Me.Txt_Product_Id.Location = New System.Drawing.Point(339, 59)
            Me.Txt_Product_Id.Name = "Txt_Product_Id"
            Me.Txt_Product_Id.ReadOnly = True
            Me.Txt_Product_Id.Size = New System.Drawing.Size(40, 22)
            Me.Txt_Product_Id.TabIndex = 0
            Me.Txt_Product_Id.TabStop = False
            Me.Txt_Product_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Btn_Add_Product_Id
            '
            Me.Btn_Add_Product_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Add_Product_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Add_Product_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Add_Product_Id.Image = CType(resources.GetObject("Btn_Add_Product_Id.Image"), System.Drawing.Image)
            Me.Btn_Add_Product_Id.Location = New System.Drawing.Point(387, 56)
            Me.Btn_Add_Product_Id.Name = "Btn_Add_Product_Id"
            Me.Btn_Add_Product_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Add_Product_Id.TabIndex = 0
            Me.Btn_Add_Product_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Add_Product_Id, "Add")
            Me.Btn_Add_Product_Id.UseVisualStyleBackColor = True
            '
            'Btn_Edit_Product_Id
            '
            Me.Btn_Edit_Product_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Edit_Product_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Edit_Product_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Edit_Product_Id.Image = CType(resources.GetObject("Btn_Edit_Product_Id.Image"), System.Drawing.Image)
            Me.Btn_Edit_Product_Id.Location = New System.Drawing.Point(423, 56)
            Me.Btn_Edit_Product_Id.Name = "Btn_Edit_Product_Id"
            Me.Btn_Edit_Product_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Edit_Product_Id.TabIndex = 0
            Me.Btn_Edit_Product_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Edit_Product_Id, "Edit")
            Me.Btn_Edit_Product_Id.UseVisualStyleBackColor = True
            '
            'Btn_Del_Product_Id
            '
            Me.Btn_Del_Product_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Del_Product_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Del_Product_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Del_Product_Id.Image = CType(resources.GetObject("Btn_Del_Product_Id.Image"), System.Drawing.Image)
            Me.Btn_Del_Product_Id.Location = New System.Drawing.Point(459, 56)
            Me.Btn_Del_Product_Id.Name = "Btn_Del_Product_Id"
            Me.Btn_Del_Product_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Del_Product_Id.TabIndex = 0
            Me.Btn_Del_Product_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Del_Product_Id, "Delete")
            Me.Btn_Del_Product_Id.UseVisualStyleBackColor = True
            '
            'Lbl_Category_Id
            '
            Me.Lbl_Category_Id.AutoSize = True
            Me.Lbl_Category_Id.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Category_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Category_Id.ForeColor = System.Drawing.Color.White
            Me.Lbl_Category_Id.Location = New System.Drawing.Point(18, 85)
            Me.Lbl_Category_Id.Name = "Lbl_Category_Id"
            Me.Lbl_Category_Id.Size = New System.Drawing.Size(26, 14)
            Me.Lbl_Category_Id.TabIndex = 1
            Me.Lbl_Category_Id.Text = "Id:"
            '
            'Cbo_Category_Id
            '
            Me.Cbo_Category_Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.Cbo_Category_Id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.Cbo_Category_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cbo_Category_Id.FormattingEnabled = True
            Me.Cbo_Category_Id.Location = New System.Drawing.Point(131, 85)
            Me.Cbo_Category_Id.Name = "Cbo_Category_Id"
            Me.Cbo_Category_Id.Size = New System.Drawing.Size(200, 22)
            Me.Cbo_Category_Id.TabIndex = 1
            '
            'Txt_Category_Id
            '
            Me.Txt_Category_Id.BackColor = System.Drawing.SystemColors.Window
            Me.Txt_Category_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Category_Id.ForeColor = System.Drawing.Color.Black
            Me.Txt_Category_Id.Location = New System.Drawing.Point(339, 85)
            Me.Txt_Category_Id.Name = "Txt_Category_Id"
            Me.Txt_Category_Id.ReadOnly = True
            Me.Txt_Category_Id.Size = New System.Drawing.Size(40, 22)
            Me.Txt_Category_Id.TabIndex = 1
            Me.Txt_Category_Id.TabStop = False
            Me.Txt_Category_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Btn_Add_Category_Id
            '
            Me.Btn_Add_Category_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Add_Category_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Add_Category_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Add_Category_Id.Image = CType(resources.GetObject("Btn_Add_Category_Id.Image"), System.Drawing.Image)
            Me.Btn_Add_Category_Id.Location = New System.Drawing.Point(387, 82)
            Me.Btn_Add_Category_Id.Name = "Btn_Add_Category_Id"
            Me.Btn_Add_Category_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Add_Category_Id.TabIndex = 1
            Me.Btn_Add_Category_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Add_Category_Id, "Add")
            Me.Btn_Add_Category_Id.UseVisualStyleBackColor = True
            '
            'Btn_Edit_Category_Id
            '
            Me.Btn_Edit_Category_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Edit_Category_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Edit_Category_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Edit_Category_Id.Image = CType(resources.GetObject("Btn_Edit_Category_Id.Image"), System.Drawing.Image)
            Me.Btn_Edit_Category_Id.Location = New System.Drawing.Point(423, 82)
            Me.Btn_Edit_Category_Id.Name = "Btn_Edit_Category_Id"
            Me.Btn_Edit_Category_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Edit_Category_Id.TabIndex = 1
            Me.Btn_Edit_Category_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Edit_Category_Id, "Edit")
            Me.Btn_Edit_Category_Id.UseVisualStyleBackColor = True
            '
            'Btn_Del_Category_Id
            '
            Me.Btn_Del_Category_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Del_Category_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Del_Category_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Del_Category_Id.Image = CType(resources.GetObject("Btn_Del_Category_Id.Image"), System.Drawing.Image)
            Me.Btn_Del_Category_Id.Location = New System.Drawing.Point(459, 82)
            Me.Btn_Del_Category_Id.Name = "Btn_Del_Category_Id"
            Me.Btn_Del_Category_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Del_Category_Id.TabIndex = 1
            Me.Btn_Del_Category_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Del_Category_Id, "Delete")
            Me.Btn_Del_Category_Id.UseVisualStyleBackColor = True
            '
            'Lbl_Category_Name
            '
            Me.Lbl_Category_Name.AutoSize = True
            Me.Lbl_Category_Name.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Category_Name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Category_Name.ForeColor = System.Drawing.Color.White
            Me.Lbl_Category_Name.Location = New System.Drawing.Point(18, 114)
            Me.Lbl_Category_Name.Name = "Lbl_Category_Name"
            Me.Lbl_Category_Name.Size = New System.Drawing.Size(50, 14)
            Me.Lbl_Category_Name.TabIndex = 2
            Me.Lbl_Category_Name.Text = "Name:"
            '
            'Txt_Category_Name
            '
            Me.Txt_Category_Name.BackColor = System.Drawing.Color.White
            Me.Txt_Category_Name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Category_Name.ForeColor = System.Drawing.Color.Black
            Me.Txt_Category_Name.Location = New System.Drawing.Point(131, 111)
            Me.Txt_Category_Name.Name = "Txt_Category_Name"
            Me.Txt_Category_Name.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Category_Name.TabIndex = 2
            '
            'Lbl_Product_Name
            '
            Me.Lbl_Product_Name.AutoSize = True
            Me.Lbl_Product_Name.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Product_Name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Product_Name.ForeColor = System.Drawing.Color.White
            Me.Lbl_Product_Name.Location = New System.Drawing.Point(18, 140)
            Me.Lbl_Product_Name.Name = "Lbl_Product_Name"
            Me.Lbl_Product_Name.Size = New System.Drawing.Size(50, 14)
            Me.Lbl_Product_Name.TabIndex = 3
            Me.Lbl_Product_Name.Text = "Name:"
            '
            'Txt_Product_Name
            '
            Me.Txt_Product_Name.BackColor = System.Drawing.Color.White
            Me.Txt_Product_Name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Product_Name.ForeColor = System.Drawing.Color.Black
            Me.Txt_Product_Name.Location = New System.Drawing.Point(131, 137)
            Me.Txt_Product_Name.Name = "Txt_Product_Name"
            Me.Txt_Product_Name.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Product_Name.TabIndex = 3
            '
            'Lbl_Unit_Id
            '
            Me.Lbl_Unit_Id.AutoSize = True
            Me.Lbl_Unit_Id.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Unit_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Unit_Id.ForeColor = System.Drawing.Color.White
            Me.Lbl_Unit_Id.Location = New System.Drawing.Point(18, 163)
            Me.Lbl_Unit_Id.Name = "Lbl_Unit_Id"
            Me.Lbl_Unit_Id.Size = New System.Drawing.Size(26, 14)
            Me.Lbl_Unit_Id.TabIndex = 4
            Me.Lbl_Unit_Id.Text = "Id:"
            '
            'Cbo_Unit_Id
            '
            Me.Cbo_Unit_Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.Cbo_Unit_Id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.Cbo_Unit_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cbo_Unit_Id.FormattingEnabled = True
            Me.Cbo_Unit_Id.Location = New System.Drawing.Point(131, 163)
            Me.Cbo_Unit_Id.Name = "Cbo_Unit_Id"
            Me.Cbo_Unit_Id.Size = New System.Drawing.Size(200, 22)
            Me.Cbo_Unit_Id.TabIndex = 4
            '
            'Txt_Unit_Id
            '
            Me.Txt_Unit_Id.BackColor = System.Drawing.SystemColors.Window
            Me.Txt_Unit_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Unit_Id.ForeColor = System.Drawing.Color.Black
            Me.Txt_Unit_Id.Location = New System.Drawing.Point(339, 163)
            Me.Txt_Unit_Id.Name = "Txt_Unit_Id"
            Me.Txt_Unit_Id.ReadOnly = True
            Me.Txt_Unit_Id.Size = New System.Drawing.Size(40, 22)
            Me.Txt_Unit_Id.TabIndex = 4
            Me.Txt_Unit_Id.TabStop = False
            Me.Txt_Unit_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Btn_Add_Unit_Id
            '
            Me.Btn_Add_Unit_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Add_Unit_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Add_Unit_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Add_Unit_Id.Image = CType(resources.GetObject("Btn_Add_Unit_Id.Image"), System.Drawing.Image)
            Me.Btn_Add_Unit_Id.Location = New System.Drawing.Point(387, 160)
            Me.Btn_Add_Unit_Id.Name = "Btn_Add_Unit_Id"
            Me.Btn_Add_Unit_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Add_Unit_Id.TabIndex = 4
            Me.Btn_Add_Unit_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Add_Unit_Id, "Add")
            Me.Btn_Add_Unit_Id.UseVisualStyleBackColor = True
            '
            'Btn_Edit_Unit_Id
            '
            Me.Btn_Edit_Unit_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Edit_Unit_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Edit_Unit_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Edit_Unit_Id.Image = CType(resources.GetObject("Btn_Edit_Unit_Id.Image"), System.Drawing.Image)
            Me.Btn_Edit_Unit_Id.Location = New System.Drawing.Point(423, 160)
            Me.Btn_Edit_Unit_Id.Name = "Btn_Edit_Unit_Id"
            Me.Btn_Edit_Unit_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Edit_Unit_Id.TabIndex = 4
            Me.Btn_Edit_Unit_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Edit_Unit_Id, "Edit")
            Me.Btn_Edit_Unit_Id.UseVisualStyleBackColor = True
            '
            'Btn_Del_Unit_Id
            '
            Me.Btn_Del_Unit_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Del_Unit_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Del_Unit_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Del_Unit_Id.Image = CType(resources.GetObject("Btn_Del_Unit_Id.Image"), System.Drawing.Image)
            Me.Btn_Del_Unit_Id.Location = New System.Drawing.Point(459, 160)
            Me.Btn_Del_Unit_Id.Name = "Btn_Del_Unit_Id"
            Me.Btn_Del_Unit_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Del_Unit_Id.TabIndex = 4
            Me.Btn_Del_Unit_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Del_Unit_Id, "Delete")
            Me.Btn_Del_Unit_Id.UseVisualStyleBackColor = True
            '
            'Lbl_Unit_Name
            '
            Me.Lbl_Unit_Name.AutoSize = True
            Me.Lbl_Unit_Name.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Unit_Name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Unit_Name.ForeColor = System.Drawing.Color.White
            Me.Lbl_Unit_Name.Location = New System.Drawing.Point(18, 192)
            Me.Lbl_Unit_Name.Name = "Lbl_Unit_Name"
            Me.Lbl_Unit_Name.Size = New System.Drawing.Size(50, 14)
            Me.Lbl_Unit_Name.TabIndex = 5
            Me.Lbl_Unit_Name.Text = "Name:"
            '
            'Txt_Unit_Name
            '
            Me.Txt_Unit_Name.BackColor = System.Drawing.Color.White
            Me.Txt_Unit_Name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Unit_Name.ForeColor = System.Drawing.Color.Black
            Me.Txt_Unit_Name.Location = New System.Drawing.Point(131, 189)
            Me.Txt_Unit_Name.Name = "Txt_Unit_Name"
            Me.Txt_Unit_Name.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Unit_Name.TabIndex = 5
            '
            'Lbl_HSN_Code
            '
            Me.Lbl_HSN_Code.AutoSize = True
            Me.Lbl_HSN_Code.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_HSN_Code.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_HSN_Code.ForeColor = System.Drawing.Color.White
            Me.Lbl_HSN_Code.Location = New System.Drawing.Point(18, 218)
            Me.Lbl_HSN_Code.Name = "Lbl_HSN_Code"
            Me.Lbl_HSN_Code.Size = New System.Drawing.Size(45, 14)
            Me.Lbl_HSN_Code.TabIndex = 6
            Me.Lbl_HSN_Code.Text = "Code:"
            '
            'Txt_HSN_Code
            '
            Me.Txt_HSN_Code.BackColor = System.Drawing.Color.White
            Me.Txt_HSN_Code.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_HSN_Code.ForeColor = System.Drawing.Color.Black
            Me.Txt_HSN_Code.Location = New System.Drawing.Point(131, 215)
            Me.Txt_HSN_Code.Name = "Txt_HSN_Code"
            Me.Txt_HSN_Code.Size = New System.Drawing.Size(200, 22)
            Me.Txt_HSN_Code.TabIndex = 6
            '
            'Lbl_Product_Stock
            '
            Me.Lbl_Product_Stock.AutoSize = True
            Me.Lbl_Product_Stock.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Product_Stock.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Product_Stock.ForeColor = System.Drawing.Color.White
            Me.Lbl_Product_Stock.Location = New System.Drawing.Point(18, 244)
            Me.Lbl_Product_Stock.Name = "Lbl_Product_Stock"
            Me.Lbl_Product_Stock.Size = New System.Drawing.Size(49, 14)
            Me.Lbl_Product_Stock.TabIndex = 7
            Me.Lbl_Product_Stock.Text = "Stock:"
            '
            'Txt_Product_Stock
            '
            Me.Txt_Product_Stock.BackColor = System.Drawing.Color.White
            Me.Txt_Product_Stock.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Product_Stock.ForeColor = System.Drawing.Color.Black
            Me.Txt_Product_Stock.Location = New System.Drawing.Point(131, 241)
            Me.Txt_Product_Stock.Name = "Txt_Product_Stock"
            Me.Txt_Product_Stock.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Product_Stock.TabIndex = 7
            '
            'Lbl_Product_Single_Amount
            '
            Me.Lbl_Product_Single_Amount.AutoSize = True
            Me.Lbl_Product_Single_Amount.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Product_Single_Amount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Product_Single_Amount.ForeColor = System.Drawing.Color.White
            Me.Lbl_Product_Single_Amount.Location = New System.Drawing.Point(18, 270)
            Me.Lbl_Product_Single_Amount.Name = "Lbl_Product_Single_Amount"
            Me.Lbl_Product_Single_Amount.Size = New System.Drawing.Size(107, 14)
            Me.Lbl_Product_Single_Amount.TabIndex = 8
            Me.Lbl_Product_Single_Amount.Text = "Single Amount:"
            '
            'Txt_Product_Single_Amount
            '
            Me.Txt_Product_Single_Amount.BackColor = System.Drawing.Color.White
            Me.Txt_Product_Single_Amount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Product_Single_Amount.ForeColor = System.Drawing.Color.Black
            Me.Txt_Product_Single_Amount.Location = New System.Drawing.Point(131, 267)
            Me.Txt_Product_Single_Amount.Name = "Txt_Product_Single_Amount"
            Me.Txt_Product_Single_Amount.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Product_Single_Amount.TabIndex = 8
            '
            'Lbl_Product_Note
            '
            Me.Lbl_Product_Note.AutoSize = True
            Me.Lbl_Product_Note.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Product_Note.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Product_Note.ForeColor = System.Drawing.Color.White
            Me.Lbl_Product_Note.Location = New System.Drawing.Point(18, 296)
            Me.Lbl_Product_Note.Name = "Lbl_Product_Note"
            Me.Lbl_Product_Note.Size = New System.Drawing.Size(43, 14)
            Me.Lbl_Product_Note.TabIndex = 9
            Me.Lbl_Product_Note.Text = "Note:"
            '
            'Txt_Product_Note
            '
            Me.Txt_Product_Note.BackColor = System.Drawing.Color.White
            Me.Txt_Product_Note.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Product_Note.ForeColor = System.Drawing.Color.Black
            Me.Txt_Product_Note.Location = New System.Drawing.Point(131, 293)
            Me.Txt_Product_Note.Name = "Txt_Product_Note"
            Me.Txt_Product_Note.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Product_Note.TabIndex = 9
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
            Me.Lbl_Header.Size = New System.Drawing.Size(507, 48)
            Me.Lbl_Header.TabIndex = 28
            Me.Lbl_Header.Text = "       Add Products Here !!!"
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
            Me.Btn_Exit.Location = New System.Drawing.Point(417, 0)
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
            Me.Btn_Save.Location = New System.Drawing.Point(327, 0)
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
            Me.Btn_New.Location = New System.Drawing.Point(237, 0)
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
            Me.Pnl_Top.Size = New System.Drawing.Size(507, 48)
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
            Me.Pnl_Bottom.Location = New System.Drawing.Point(0, 326)
            Me.Pnl_Bottom.Name = "Pnl_Bottom"
            Me.Pnl_Bottom.Size = New System.Drawing.Size(507, 48)
            Me.Pnl_Bottom.TabIndex = 74
            '
            'Products
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.Controls.Add(Me.Lbl_Product_Id)
            Me.Controls.Add(Me.Cbo_Product_Id)
            Me.Controls.Add(Me.Txt_Product_Id)
            Me.Controls.Add(Me.Btn_Add_Product_Id)
            Me.Controls.Add(Me.Btn_Edit_Product_Id)
            Me.Controls.Add(Me.Btn_Del_Product_Id)
            Me.Controls.Add(Me.Lbl_Category_Id)
            Me.Controls.Add(Me.Cbo_Category_Id)
            Me.Controls.Add(Me.Txt_Category_Id)
            Me.Controls.Add(Me.Btn_Add_Category_Id)
            Me.Controls.Add(Me.Btn_Edit_Category_Id)
            Me.Controls.Add(Me.Btn_Del_Category_Id)
            Me.Controls.Add(Me.Lbl_Category_Name)
            Me.Controls.Add(Me.Txt_Category_Name)
            Me.Controls.Add(Me.Lbl_Product_Name)
            Me.Controls.Add(Me.Txt_Product_Name)
            Me.Controls.Add(Me.Lbl_Unit_Id)
            Me.Controls.Add(Me.Cbo_Unit_Id)
            Me.Controls.Add(Me.Txt_Unit_Id)
            Me.Controls.Add(Me.Btn_Add_Unit_Id)
            Me.Controls.Add(Me.Btn_Edit_Unit_Id)
            Me.Controls.Add(Me.Btn_Del_Unit_Id)
            Me.Controls.Add(Me.Lbl_Unit_Name)
            Me.Controls.Add(Me.Txt_Unit_Name)
            Me.Controls.Add(Me.Lbl_HSN_Code)
            Me.Controls.Add(Me.Txt_HSN_Code)
            Me.Controls.Add(Me.Lbl_Product_Stock)
            Me.Controls.Add(Me.Txt_Product_Stock)
            Me.Controls.Add(Me.Lbl_Product_Single_Amount)
            Me.Controls.Add(Me.Txt_Product_Single_Amount)
            Me.Controls.Add(Me.Lbl_Product_Note)
            Me.Controls.Add(Me.Txt_Product_Note)
            Me.Controls.Add(Me.Pnl_Bottom)
            Me.Controls.Add(Me.Pnl_Top)
            Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.Black
            Me.Name = "Products"
            Me.Size = New System.Drawing.Size(507, 374)
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
            MyBase.SetBoundsCore(x, y, 507, 374, specified)
        End Sub
        Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            FormTitle = "Products"
            clsFeature.SizeLock(SizeLock, ParentForm, FormTitle, Me)
            Cbo_Product_Id.SelectedIndex = -1
            Cbo_Category_Id.SelectedIndex = -1
            Cbo_Unit_Id.SelectedIndex = -1
            AddEdit = "Add"
        End Sub
        Private Sub Products_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
            clsProducts.BoundComboBox(Cbo_Product_Id)
            clsCatagores.BoundComboBox(Cbo_Category_Id)
            clsUnits.BoundComboBox(Cbo_Unit_Id)
        End Sub
        Private Sub Products_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
            ucProducts = Nothing
            frmProducts = Nothing
        End Sub
        Private Sub Btn_Add_Product_Id_Click(sender As Object, e As EventArgs) Handles Btn_Add_Product_Id.Click
            Btn_New.PerformClick()
        End Sub
        Private Sub Btn_Edit_Product_Id_Click(sender As Object, e As EventArgs) Handles Btn_Edit_Product_Id.Click
            clsProducts.Load(Txt_Product_Id, Txt_Category_Id, Txt_Category_Name, Txt_Product_Name, Txt_Unit_Id, Txt_Unit_Name, Txt_HSN_Code, Txt_Product_Stock, Txt_Product_Single_Amount, Txt_Product_Note)
            If Not String.IsNullOrWhiteSpace(Txt_Product_Id.Text) Then AddEdit = "Edit"
            If Not String.IsNullOrWhiteSpace(Txt_Product_Id.Text) Then Cbo_Product_Id.SelectedValue = Txt_Product_Id.Text
            If Not String.IsNullOrWhiteSpace(Txt_Category_Id.Text) Then Cbo_Category_Id.SelectedValue = Txt_Category_Id.Text
            If Not String.IsNullOrWhiteSpace(Txt_Unit_Id.Text) Then Cbo_Unit_Id.SelectedValue = Txt_Unit_Id.Text
        End Sub
        Private Sub Btn_Del_Product_Id_Click(sender As Object, e As EventArgs) Handles Btn_Del_Product_Id.Click
            clsProducts.Delete(Txt_Product_Id, Txt_Category_Id, Txt_Category_Name, Txt_Product_Name, Txt_Unit_Id, Txt_Unit_Name, Txt_HSN_Code, Txt_Product_Stock, Txt_Product_Single_Amount, Txt_Product_Note)
            clsProducts.BoundComboBox(Cbo_Product_Id)
        End Sub
        Private Sub Cbo_Product_Id_GotFocus(sender As Object, e As EventArgs) Handles Cbo_Product_Id.GotFocus
            If Cbo_Product_Id.SelectedIndex = -1 Then ComboBoxUpdate = True
        End Sub
        Private Sub Cbo_Product_Id_DropDown(sender As Object, e As EventArgs) Handles Cbo_Product_Id.DropDown
            clsProducts.BoundComboBox(Cbo_Product_Id)
        End Sub
        Private Sub Cbo_Product_Id_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Cbo_Product_Id.PreviewKeyDown
            If ComboBoxUpdate = True Then
                clsProducts.BoundComboBox(Cbo_Product_Id)
                ComboBoxUpdate = False
            End If
        End Sub
        Private Sub Cbo_Product_Id_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cbo_Product_Id.SelectionChangeCommitted
            If Not Cbo_Product_Id.SelectedIndex = -1 Then Txt_Product_Id.Text = Cbo_Product_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_Product_Id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Product_Id.SelectedIndexChanged
            If Not Cbo_Product_Id.SelectedIndex = -1 Then Txt_Product_Id.Text = Cbo_Product_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_Product_Id_LostFocus(sender As Object, e As EventArgs) Handles Cbo_Product_Id.LostFocus
            If Cbo_Product_Id.SelectedIndex = -1 Then
                Cbo_Product_Id.Text = String.Empty
                Txt_Product_Id.Clear()
            End If
        End Sub
        Private Sub Btn_Add_Category_Id_Click(sender As Object, e As EventArgs) Handles Btn_Add_Category_Id.Click
            If ucCatagores Is Nothing Then ucCatagores = New UIForm.Catagores
            If frmCatagores Is Nothing Then
                frmCatagores = New UIForm.DialogBox
                ucCatagores.SizeLock = True
                frmCatagores.Controls.Add(ucCatagores)
                frmCatagores.Show()
            Else
                frmCatagores.BringToFront()
            End If
        End Sub
        Private Sub Btn_Edit_Category_Id_Click(sender As Object, e As EventArgs) Handles Btn_Edit_Category_Id.Click
            If String.IsNullOrWhiteSpace(Txt_Category_Id.Text) Then Exit Sub
            If ucCatagores Is Nothing Then ucCatagores = New UIForm.Catagores
            If frmCatagores Is Nothing Then
                frmCatagores = New UIForm.DialogBox
                ucCatagores.SizeLock = True
                frmCatagores.Controls.Add(ucCatagores)
                frmCatagores.Show()
                ucCatagores.Txt_Category_Id.Text = Txt_Category_Id.Text
                ucCatagores.Btn_Edit_Category_Id.PerformClick()
            Else
                frmCatagores.BringToFront()
            End If
        End Sub
        Private Sub Btn_Del_Category_Id_Click(sender As Object, e As EventArgs) Handles Btn_Del_Category_Id.Click
            Try
                If Not String.IsNullOrWhiteSpace(Txt_Category_Id.Text) Then
                    Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If result = DialogResult.Yes Then
                        clsProducts.Delete("Category_Id", Txt_Category_Id.Text)
                        clsCatagores.Delete(Txt_Category_Id.Text)
                        clsCatagores.BoundComboBox(Cbo_Category_Id)
                        MessageBox.Show("Record delete sucessfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Record not selected for delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub Cbo_Category_Id_GotFocus(sender As Object, e As EventArgs) Handles Cbo_Category_Id.GotFocus
            If Cbo_Category_Id.SelectedIndex = -1 Then ComboBoxUpdate = True
        End Sub
        Private Sub Cbo_Category_Id_DropDown(sender As Object, e As EventArgs) Handles Cbo_Category_Id.DropDown
            clsCatagores.BoundComboBox(Cbo_Category_Id)
        End Sub
        Private Sub Cbo_Category_Id_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Cbo_Category_Id.PreviewKeyDown
            If ComboBoxUpdate = True Then
                clsCatagores.BoundComboBox(Cbo_Category_Id)
                ComboBoxUpdate = False
            End If
        End Sub
        Private Sub Cbo_Category_Id_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cbo_Category_Id.SelectionChangeCommitted
            If Not Cbo_Category_Id.SelectedIndex = -1 Then Txt_Category_Id.Text = Cbo_Category_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_Category_Id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Category_Id.SelectedIndexChanged
            If Not Cbo_Category_Id.SelectedIndex = -1 Then Txt_Category_Id.Text = Cbo_Category_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_Category_Id_LostFocus(sender As Object, e As EventArgs) Handles Cbo_Category_Id.LostFocus
            If Cbo_Category_Id.SelectedIndex = -1 Then
                Cbo_Category_Id.Text = String.Empty
                Txt_Category_Id.Clear()
            End If
        End Sub
        Private Sub Btn_Add_Unit_Id_Click(sender As Object, e As EventArgs) Handles Btn_Add_Unit_Id.Click
            If ucUnits Is Nothing Then ucUnits = New UIForm.Units
            If frmUnits Is Nothing Then
                frmUnits = New UIForm.DialogBox
                ucUnits.SizeLock = True
                frmUnits.Controls.Add(ucUnits)
                frmUnits.Show()
            Else
                frmUnits.BringToFront()
            End If
        End Sub
        Private Sub Btn_Edit_Unit_Id_Click(sender As Object, e As EventArgs) Handles Btn_Edit_Unit_Id.Click
            If String.IsNullOrWhiteSpace(Txt_Unit_Id.Text) Then Exit Sub
            If ucUnits Is Nothing Then ucUnits = New UIForm.Units
            If frmUnits Is Nothing Then
                frmUnits = New UIForm.DialogBox
                ucUnits.SizeLock = True
                frmUnits.Controls.Add(ucUnits)
                frmUnits.Show()
                ucUnits.Txt_Unit_Id.Text = Txt_Unit_Id.Text
                ucUnits.Btn_Edit_Unit_Id.PerformClick()
            Else
                frmUnits.BringToFront()
            End If
        End Sub
        Private Sub Btn_Del_Unit_Id_Click(sender As Object, e As EventArgs) Handles Btn_Del_Unit_Id.Click
            Try
                If Not String.IsNullOrWhiteSpace(Txt_Unit_Id.Text) Then
                    Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If result = DialogResult.Yes Then
                        clsProducts.Delete("Unit_Id", Txt_Unit_Id.Text)
                        clsUnits.Delete(Txt_Unit_Id.Text)
                        clsUnits.BoundComboBox(Cbo_Unit_Id)
                        MessageBox.Show("Record delete sucessfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Record not selected for delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub Cbo_Unit_Id_GotFocus(sender As Object, e As EventArgs) Handles Cbo_Unit_Id.GotFocus
            If Cbo_Unit_Id.SelectedIndex = -1 Then ComboBoxUpdate = True
        End Sub
        Private Sub Cbo_Unit_Id_DropDown(sender As Object, e As EventArgs) Handles Cbo_Unit_Id.DropDown
            clsUnits.BoundComboBox(Cbo_Unit_Id)
        End Sub
        Private Sub Cbo_Unit_Id_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Cbo_Unit_Id.PreviewKeyDown
            If ComboBoxUpdate = True Then
                clsUnits.BoundComboBox(Cbo_Unit_Id)
                ComboBoxUpdate = False
            End If
        End Sub
        Private Sub Cbo_Unit_Id_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cbo_Unit_Id.SelectionChangeCommitted
            If Not Cbo_Unit_Id.SelectedIndex = -1 Then Txt_Unit_Id.Text = Cbo_Unit_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_Unit_Id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Unit_Id.SelectedIndexChanged
            If Not Cbo_Unit_Id.SelectedIndex = -1 Then Txt_Unit_Id.Text = Cbo_Unit_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_Unit_Id_LostFocus(sender As Object, e As EventArgs) Handles Cbo_Unit_Id.LostFocus
            If Cbo_Unit_Id.SelectedIndex = -1 Then
                Cbo_Unit_Id.Text = String.Empty
                Txt_Unit_Id.Clear()
            End If
        End Sub
        Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
            clsProducts.Clear(Txt_Product_Id, Txt_Category_Id, Txt_Category_Name, Txt_Product_Name, Txt_Unit_Id, Txt_Unit_Name, Txt_HSN_Code, Txt_Product_Stock, Txt_Product_Single_Amount, Txt_Product_Note)
            AddEdit = "Add"
        End Sub
        Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
            clsProducts.Auto(True, AddEdit, Txt_Product_Id, Txt_Category_Id, Txt_Category_Name, Txt_Product_Name, Txt_Unit_Id, Txt_Unit_Name, Txt_HSN_Code, Txt_Product_Stock, Txt_Product_Single_Amount, Txt_Product_Note)
            Cbo_Product_Id.SelectedIndex = -1
            Cbo_Category_Id.SelectedIndex = -1
            Cbo_Unit_Id.SelectedIndex = -1
            AddEdit = "Add"
        End Sub
        Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
            Me.ParentForm.Close()
        End Sub
#End Region
    End Class
End Namespace