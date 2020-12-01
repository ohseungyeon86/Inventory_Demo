Imports System.ComponentModel
Namespace UIForm
    ' Build Action Embedded Resource
    <ToolboxBitmap(GetType(Salebarcodes), "Salebarcodes.ico"), ToolboxItem(False)>
    Public Class Salebarcodes
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
        Friend WithEvents Lbl_SaleBarcode_Id As Label
        Friend WithEvents Cbo_SaleBarcode_Id As ComboBox
        Friend WithEvents Txt_SaleBarcode_Id As TextBox
        Friend WithEvents Btn_Add_SaleBarcode_Id As Button
        Friend WithEvents Btn_Edit_SaleBarcode_Id As Button
        Friend WithEvents Btn_Del_SaleBarcode_Id As Button
        Friend WithEvents Lbl_SaleDetail_Id As Label
        Friend WithEvents Cbo_SaleDetail_Id As ComboBox
        Friend WithEvents Txt_SaleDetail_Id As TextBox
        Friend WithEvents Btn_Add_SaleDetail_Id As Button
        Friend WithEvents Btn_Edit_SaleDetail_Id As Button
        Friend WithEvents Btn_Del_SaleDetail_Id As Button
        Friend WithEvents Lbl_Product_Id As Label
        Friend WithEvents Cbo_Product_Id As ComboBox
        Friend WithEvents Txt_Product_Id As TextBox
        Friend WithEvents Btn_Add_Product_Id As Button
        Friend WithEvents Btn_Edit_Product_Id As Button
        Friend WithEvents Btn_Del_Product_Id As Button
        Friend WithEvents Lbl_SaleBarcode_Barcode As Label
        Friend WithEvents Txt_SaleBarcode_Barcode As TextBox
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salebarcodes))
            Me.Lbl_SaleBarcode_Id = New System.Windows.Forms.Label()
            Me.Cbo_SaleBarcode_Id = New System.Windows.Forms.ComboBox()
            Me.Txt_SaleBarcode_Id = New System.Windows.Forms.TextBox()
            Me.Btn_Add_SaleBarcode_Id = New System.Windows.Forms.Button()
            Me.Btn_Edit_SaleBarcode_Id = New System.Windows.Forms.Button()
            Me.Btn_Del_SaleBarcode_Id = New System.Windows.Forms.Button()
            Me.Lbl_SaleDetail_Id = New System.Windows.Forms.Label()
            Me.Cbo_SaleDetail_Id = New System.Windows.Forms.ComboBox()
            Me.Txt_SaleDetail_Id = New System.Windows.Forms.TextBox()
            Me.Btn_Add_SaleDetail_Id = New System.Windows.Forms.Button()
            Me.Btn_Edit_SaleDetail_Id = New System.Windows.Forms.Button()
            Me.Btn_Del_SaleDetail_Id = New System.Windows.Forms.Button()
            Me.Lbl_Product_Id = New System.Windows.Forms.Label()
            Me.Cbo_Product_Id = New System.Windows.Forms.ComboBox()
            Me.Txt_Product_Id = New System.Windows.Forms.TextBox()
            Me.Btn_Add_Product_Id = New System.Windows.Forms.Button()
            Me.Btn_Edit_Product_Id = New System.Windows.Forms.Button()
            Me.Btn_Del_Product_Id = New System.Windows.Forms.Button()
            Me.Lbl_SaleBarcode_Barcode = New System.Windows.Forms.Label()
            Me.Txt_SaleBarcode_Barcode = New System.Windows.Forms.TextBox()
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
            'Lbl_SaleBarcode_Id
            '
            Me.Lbl_SaleBarcode_Id.AutoSize = True
            Me.Lbl_SaleBarcode_Id.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_SaleBarcode_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_SaleBarcode_Id.ForeColor = System.Drawing.Color.White
            Me.Lbl_SaleBarcode_Id.Location = New System.Drawing.Point(18, 62)
            Me.Lbl_SaleBarcode_Id.Name = "Lbl_SaleBarcode_Id"
            Me.Lbl_SaleBarcode_Id.Size = New System.Drawing.Size(26, 14)
            Me.Lbl_SaleBarcode_Id.TabIndex = 0
            Me.Lbl_SaleBarcode_Id.Text = "Id:"
            '
            'Cbo_SaleBarcode_Id
            '
            Me.Cbo_SaleBarcode_Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.Cbo_SaleBarcode_Id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.Cbo_SaleBarcode_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cbo_SaleBarcode_Id.FormattingEnabled = True
            Me.Cbo_SaleBarcode_Id.Location = New System.Drawing.Point(92, 59)
            Me.Cbo_SaleBarcode_Id.Name = "Cbo_SaleBarcode_Id"
            Me.Cbo_SaleBarcode_Id.Size = New System.Drawing.Size(200, 22)
            Me.Cbo_SaleBarcode_Id.TabIndex = 0
            '
            'Txt_SaleBarcode_Id
            '
            Me.Txt_SaleBarcode_Id.BackColor = System.Drawing.SystemColors.Window
            Me.Txt_SaleBarcode_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_SaleBarcode_Id.ForeColor = System.Drawing.Color.Black
            Me.Txt_SaleBarcode_Id.Location = New System.Drawing.Point(300, 59)
            Me.Txt_SaleBarcode_Id.Name = "Txt_SaleBarcode_Id"
            Me.Txt_SaleBarcode_Id.ReadOnly = True
            Me.Txt_SaleBarcode_Id.Size = New System.Drawing.Size(40, 22)
            Me.Txt_SaleBarcode_Id.TabIndex = 0
            Me.Txt_SaleBarcode_Id.TabStop = False
            Me.Txt_SaleBarcode_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Btn_Add_SaleBarcode_Id
            '
            Me.Btn_Add_SaleBarcode_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Add_SaleBarcode_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Add_SaleBarcode_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Add_SaleBarcode_Id.Image = CType(resources.GetObject("Btn_Add_SaleBarcode_Id.Image"), System.Drawing.Image)
            Me.Btn_Add_SaleBarcode_Id.Location = New System.Drawing.Point(348, 56)
            Me.Btn_Add_SaleBarcode_Id.Name = "Btn_Add_SaleBarcode_Id"
            Me.Btn_Add_SaleBarcode_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Add_SaleBarcode_Id.TabIndex = 0
            Me.Btn_Add_SaleBarcode_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Add_SaleBarcode_Id, "Add")
            Me.Btn_Add_SaleBarcode_Id.UseVisualStyleBackColor = True
            '
            'Btn_Edit_SaleBarcode_Id
            '
            Me.Btn_Edit_SaleBarcode_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Edit_SaleBarcode_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Edit_SaleBarcode_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Edit_SaleBarcode_Id.Image = CType(resources.GetObject("Btn_Edit_SaleBarcode_Id.Image"), System.Drawing.Image)
            Me.Btn_Edit_SaleBarcode_Id.Location = New System.Drawing.Point(384, 56)
            Me.Btn_Edit_SaleBarcode_Id.Name = "Btn_Edit_SaleBarcode_Id"
            Me.Btn_Edit_SaleBarcode_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Edit_SaleBarcode_Id.TabIndex = 0
            Me.Btn_Edit_SaleBarcode_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Edit_SaleBarcode_Id, "Edit")
            Me.Btn_Edit_SaleBarcode_Id.UseVisualStyleBackColor = True
            '
            'Btn_Del_SaleBarcode_Id
            '
            Me.Btn_Del_SaleBarcode_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Del_SaleBarcode_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Del_SaleBarcode_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Del_SaleBarcode_Id.Image = CType(resources.GetObject("Btn_Del_SaleBarcode_Id.Image"), System.Drawing.Image)
            Me.Btn_Del_SaleBarcode_Id.Location = New System.Drawing.Point(420, 56)
            Me.Btn_Del_SaleBarcode_Id.Name = "Btn_Del_SaleBarcode_Id"
            Me.Btn_Del_SaleBarcode_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Del_SaleBarcode_Id.TabIndex = 0
            Me.Btn_Del_SaleBarcode_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Del_SaleBarcode_Id, "Delete")
            Me.Btn_Del_SaleBarcode_Id.UseVisualStyleBackColor = True
            '
            'Lbl_SaleDetail_Id
            '
            Me.Lbl_SaleDetail_Id.AutoSize = True
            Me.Lbl_SaleDetail_Id.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_SaleDetail_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_SaleDetail_Id.ForeColor = System.Drawing.Color.White
            Me.Lbl_SaleDetail_Id.Location = New System.Drawing.Point(18, 85)
            Me.Lbl_SaleDetail_Id.Name = "Lbl_SaleDetail_Id"
            Me.Lbl_SaleDetail_Id.Size = New System.Drawing.Size(26, 14)
            Me.Lbl_SaleDetail_Id.TabIndex = 1
            Me.Lbl_SaleDetail_Id.Text = "Id:"
            '
            'Cbo_SaleDetail_Id
            '
            Me.Cbo_SaleDetail_Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.Cbo_SaleDetail_Id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.Cbo_SaleDetail_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cbo_SaleDetail_Id.FormattingEnabled = True
            Me.Cbo_SaleDetail_Id.Location = New System.Drawing.Point(92, 85)
            Me.Cbo_SaleDetail_Id.Name = "Cbo_SaleDetail_Id"
            Me.Cbo_SaleDetail_Id.Size = New System.Drawing.Size(200, 22)
            Me.Cbo_SaleDetail_Id.TabIndex = 1
            '
            'Txt_SaleDetail_Id
            '
            Me.Txt_SaleDetail_Id.BackColor = System.Drawing.SystemColors.Window
            Me.Txt_SaleDetail_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_SaleDetail_Id.ForeColor = System.Drawing.Color.Black
            Me.Txt_SaleDetail_Id.Location = New System.Drawing.Point(300, 85)
            Me.Txt_SaleDetail_Id.Name = "Txt_SaleDetail_Id"
            Me.Txt_SaleDetail_Id.ReadOnly = True
            Me.Txt_SaleDetail_Id.Size = New System.Drawing.Size(40, 22)
            Me.Txt_SaleDetail_Id.TabIndex = 1
            Me.Txt_SaleDetail_Id.TabStop = False
            Me.Txt_SaleDetail_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Btn_Add_SaleDetail_Id
            '
            Me.Btn_Add_SaleDetail_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Add_SaleDetail_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Add_SaleDetail_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Add_SaleDetail_Id.Image = CType(resources.GetObject("Btn_Add_SaleDetail_Id.Image"), System.Drawing.Image)
            Me.Btn_Add_SaleDetail_Id.Location = New System.Drawing.Point(348, 82)
            Me.Btn_Add_SaleDetail_Id.Name = "Btn_Add_SaleDetail_Id"
            Me.Btn_Add_SaleDetail_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Add_SaleDetail_Id.TabIndex = 1
            Me.Btn_Add_SaleDetail_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Add_SaleDetail_Id, "Add")
            Me.Btn_Add_SaleDetail_Id.UseVisualStyleBackColor = True
            '
            'Btn_Edit_SaleDetail_Id
            '
            Me.Btn_Edit_SaleDetail_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Edit_SaleDetail_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Edit_SaleDetail_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Edit_SaleDetail_Id.Image = CType(resources.GetObject("Btn_Edit_SaleDetail_Id.Image"), System.Drawing.Image)
            Me.Btn_Edit_SaleDetail_Id.Location = New System.Drawing.Point(384, 82)
            Me.Btn_Edit_SaleDetail_Id.Name = "Btn_Edit_SaleDetail_Id"
            Me.Btn_Edit_SaleDetail_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Edit_SaleDetail_Id.TabIndex = 1
            Me.Btn_Edit_SaleDetail_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Edit_SaleDetail_Id, "Edit")
            Me.Btn_Edit_SaleDetail_Id.UseVisualStyleBackColor = True
            '
            'Btn_Del_SaleDetail_Id
            '
            Me.Btn_Del_SaleDetail_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Del_SaleDetail_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Del_SaleDetail_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Del_SaleDetail_Id.Image = CType(resources.GetObject("Btn_Del_SaleDetail_Id.Image"), System.Drawing.Image)
            Me.Btn_Del_SaleDetail_Id.Location = New System.Drawing.Point(420, 82)
            Me.Btn_Del_SaleDetail_Id.Name = "Btn_Del_SaleDetail_Id"
            Me.Btn_Del_SaleDetail_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Del_SaleDetail_Id.TabIndex = 1
            Me.Btn_Del_SaleDetail_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Del_SaleDetail_Id, "Delete")
            Me.Btn_Del_SaleDetail_Id.UseVisualStyleBackColor = True
            '
            'Lbl_Product_Id
            '
            Me.Lbl_Product_Id.AutoSize = True
            Me.Lbl_Product_Id.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Product_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Product_Id.ForeColor = System.Drawing.Color.White
            Me.Lbl_Product_Id.Location = New System.Drawing.Point(18, 111)
            Me.Lbl_Product_Id.Name = "Lbl_Product_Id"
            Me.Lbl_Product_Id.Size = New System.Drawing.Size(26, 14)
            Me.Lbl_Product_Id.TabIndex = 2
            Me.Lbl_Product_Id.Text = "Id:"
            '
            'Cbo_Product_Id
            '
            Me.Cbo_Product_Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.Cbo_Product_Id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.Cbo_Product_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cbo_Product_Id.FormattingEnabled = True
            Me.Cbo_Product_Id.Location = New System.Drawing.Point(92, 111)
            Me.Cbo_Product_Id.Name = "Cbo_Product_Id"
            Me.Cbo_Product_Id.Size = New System.Drawing.Size(200, 22)
            Me.Cbo_Product_Id.TabIndex = 2
            '
            'Txt_Product_Id
            '
            Me.Txt_Product_Id.BackColor = System.Drawing.SystemColors.Window
            Me.Txt_Product_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Product_Id.ForeColor = System.Drawing.Color.Black
            Me.Txt_Product_Id.Location = New System.Drawing.Point(300, 111)
            Me.Txt_Product_Id.Name = "Txt_Product_Id"
            Me.Txt_Product_Id.ReadOnly = True
            Me.Txt_Product_Id.Size = New System.Drawing.Size(40, 22)
            Me.Txt_Product_Id.TabIndex = 2
            Me.Txt_Product_Id.TabStop = False
            Me.Txt_Product_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Btn_Add_Product_Id
            '
            Me.Btn_Add_Product_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Add_Product_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Add_Product_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Add_Product_Id.Image = CType(resources.GetObject("Btn_Add_Product_Id.Image"), System.Drawing.Image)
            Me.Btn_Add_Product_Id.Location = New System.Drawing.Point(348, 108)
            Me.Btn_Add_Product_Id.Name = "Btn_Add_Product_Id"
            Me.Btn_Add_Product_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Add_Product_Id.TabIndex = 2
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
            Me.Btn_Edit_Product_Id.Location = New System.Drawing.Point(384, 108)
            Me.Btn_Edit_Product_Id.Name = "Btn_Edit_Product_Id"
            Me.Btn_Edit_Product_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Edit_Product_Id.TabIndex = 2
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
            Me.Btn_Del_Product_Id.Location = New System.Drawing.Point(420, 108)
            Me.Btn_Del_Product_Id.Name = "Btn_Del_Product_Id"
            Me.Btn_Del_Product_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Del_Product_Id.TabIndex = 2
            Me.Btn_Del_Product_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Del_Product_Id, "Delete")
            Me.Btn_Del_Product_Id.UseVisualStyleBackColor = True
            '
            'Lbl_SaleBarcode_Barcode
            '
            Me.Lbl_SaleBarcode_Barcode.AutoSize = True
            Me.Lbl_SaleBarcode_Barcode.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_SaleBarcode_Barcode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_SaleBarcode_Barcode.ForeColor = System.Drawing.Color.White
            Me.Lbl_SaleBarcode_Barcode.Location = New System.Drawing.Point(18, 140)
            Me.Lbl_SaleBarcode_Barcode.Name = "Lbl_SaleBarcode_Barcode"
            Me.Lbl_SaleBarcode_Barcode.Size = New System.Drawing.Size(66, 14)
            Me.Lbl_SaleBarcode_Barcode.TabIndex = 3
            Me.Lbl_SaleBarcode_Barcode.Text = "Barcode:"
            '
            'Txt_SaleBarcode_Barcode
            '
            Me.Txt_SaleBarcode_Barcode.BackColor = System.Drawing.Color.White
            Me.Txt_SaleBarcode_Barcode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_SaleBarcode_Barcode.ForeColor = System.Drawing.Color.Black
            Me.Txt_SaleBarcode_Barcode.Location = New System.Drawing.Point(92, 137)
            Me.Txt_SaleBarcode_Barcode.Name = "Txt_SaleBarcode_Barcode"
            Me.Txt_SaleBarcode_Barcode.Size = New System.Drawing.Size(200, 22)
            Me.Txt_SaleBarcode_Barcode.TabIndex = 3
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
            Me.Lbl_Header.Size = New System.Drawing.Size(468, 48)
            Me.Lbl_Header.TabIndex = 28
            Me.Lbl_Header.Text = "       Add Salebarcodes Here !!!"
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
            Me.Btn_Exit.Location = New System.Drawing.Point(378, 0)
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
            Me.Btn_Save.Location = New System.Drawing.Point(288, 0)
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
            Me.Btn_New.Location = New System.Drawing.Point(198, 0)
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
            Me.Pnl_Top.Size = New System.Drawing.Size(468, 48)
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
            Me.Pnl_Bottom.Location = New System.Drawing.Point(0, 170)
            Me.Pnl_Bottom.Name = "Pnl_Bottom"
            Me.Pnl_Bottom.Size = New System.Drawing.Size(468, 48)
            Me.Pnl_Bottom.TabIndex = 74
            '
            'Salebarcodes
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.Controls.Add(Me.Lbl_SaleBarcode_Id)
            Me.Controls.Add(Me.Cbo_SaleBarcode_Id)
            Me.Controls.Add(Me.Txt_SaleBarcode_Id)
            Me.Controls.Add(Me.Btn_Add_SaleBarcode_Id)
            Me.Controls.Add(Me.Btn_Edit_SaleBarcode_Id)
            Me.Controls.Add(Me.Btn_Del_SaleBarcode_Id)
            Me.Controls.Add(Me.Lbl_SaleDetail_Id)
            Me.Controls.Add(Me.Cbo_SaleDetail_Id)
            Me.Controls.Add(Me.Txt_SaleDetail_Id)
            Me.Controls.Add(Me.Btn_Add_SaleDetail_Id)
            Me.Controls.Add(Me.Btn_Edit_SaleDetail_Id)
            Me.Controls.Add(Me.Btn_Del_SaleDetail_Id)
            Me.Controls.Add(Me.Lbl_Product_Id)
            Me.Controls.Add(Me.Cbo_Product_Id)
            Me.Controls.Add(Me.Txt_Product_Id)
            Me.Controls.Add(Me.Btn_Add_Product_Id)
            Me.Controls.Add(Me.Btn_Edit_Product_Id)
            Me.Controls.Add(Me.Btn_Del_Product_Id)
            Me.Controls.Add(Me.Lbl_SaleBarcode_Barcode)
            Me.Controls.Add(Me.Txt_SaleBarcode_Barcode)
            Me.Controls.Add(Me.Pnl_Bottom)
            Me.Controls.Add(Me.Pnl_Top)
            Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.Black
            Me.Name = "Salebarcodes"
            Me.Size = New System.Drawing.Size(468, 218)
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
            MyBase.SetBoundsCore(x, y, 468, 218, specified)
        End Sub
        Private Sub SaleBarcodes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            FormTitle = "SaleBarcodes"
            clsFeature.SizeLock(SizeLock, ParentForm, FormTitle, Me)
            Cbo_SaleBarcode_Id.SelectedIndex = -1
            Cbo_SaleDetail_Id.SelectedIndex = -1
            Cbo_Product_Id.SelectedIndex = -1
            AddEdit = "Add"
        End Sub
        Private Sub SaleBarcodes_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
            clsSaleBarcodes.BoundComboBox(Cbo_SaleBarcode_Id)
            clsSaleDetails.BoundComboBox(Cbo_SaleDetail_Id)
            clsProducts.BoundComboBox(Cbo_Product_Id)
        End Sub
        Private Sub SaleBarcodes_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
            ucSaleBarcodes = Nothing
            frmSaleBarcodes = Nothing
        End Sub
        Private Sub Btn_Add_SaleBarcode_Id_Click(sender As Object, e As EventArgs) Handles Btn_Add_SaleBarcode_Id.Click
            Btn_New.PerformClick()
        End Sub
        Private Sub Btn_Edit_SaleBarcode_Id_Click(sender As Object, e As EventArgs) Handles Btn_Edit_SaleBarcode_Id.Click
            clsSaleBarcodes.Load(Txt_SaleBarcode_Id, Txt_SaleDetail_Id, Txt_Product_Id, Txt_SaleBarcode_Barcode)
            If Not String.IsNullOrWhiteSpace(Txt_SaleBarcode_Id.Text) Then AddEdit = "Edit"
            If Not String.IsNullOrWhiteSpace(Txt_SaleBarcode_Id.Text) Then Cbo_SaleBarcode_Id.SelectedValue = Txt_SaleBarcode_Id.Text
            If Not String.IsNullOrWhiteSpace(Txt_SaleDetail_Id.Text) Then Cbo_SaleDetail_Id.SelectedValue = Txt_SaleDetail_Id.Text
            If Not String.IsNullOrWhiteSpace(Txt_Product_Id.Text) Then Cbo_Product_Id.SelectedValue = Txt_Product_Id.Text
        End Sub
        Private Sub Btn_Del_SaleBarcode_Id_Click(sender As Object, e As EventArgs) Handles Btn_Del_SaleBarcode_Id.Click
            clsSaleBarcodes.Delete(Txt_SaleBarcode_Id, Txt_SaleDetail_Id, Txt_Product_Id, Txt_SaleBarcode_Barcode)
            clsSaleBarcodes.BoundComboBox(Cbo_SaleBarcode_Id)
        End Sub
        Private Sub Cbo_SaleBarcode_Id_GotFocus(sender As Object, e As EventArgs) Handles Cbo_SaleBarcode_Id.GotFocus
            If Cbo_SaleBarcode_Id.SelectedIndex = -1 Then ComboBoxUpdate = True
        End Sub
        Private Sub Cbo_SaleBarcode_Id_DropDown(sender As Object, e As EventArgs) Handles Cbo_SaleBarcode_Id.DropDown
            clsSaleBarcodes.BoundComboBox(Cbo_SaleBarcode_Id)
        End Sub
        Private Sub Cbo_SaleBarcode_Id_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Cbo_SaleBarcode_Id.PreviewKeyDown
            If ComboBoxUpdate = True Then
                clsSaleBarcodes.BoundComboBox(Cbo_SaleBarcode_Id)
                ComboBoxUpdate = False
            End If
        End Sub
        Private Sub Cbo_SaleBarcode_Id_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cbo_SaleBarcode_Id.SelectionChangeCommitted
            If Not Cbo_SaleBarcode_Id.SelectedIndex = -1 Then Txt_SaleBarcode_Id.Text = Cbo_SaleBarcode_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_SaleBarcode_Id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_SaleBarcode_Id.SelectedIndexChanged
            If Not Cbo_SaleBarcode_Id.SelectedIndex = -1 Then Txt_SaleBarcode_Id.Text = Cbo_SaleBarcode_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_SaleBarcode_Id_LostFocus(sender As Object, e As EventArgs) Handles Cbo_SaleBarcode_Id.LostFocus
            If Cbo_SaleBarcode_Id.SelectedIndex = -1 Then
                Cbo_SaleBarcode_Id.Text = String.Empty
                Txt_SaleBarcode_Id.Clear()
            End If
        End Sub
        Private Sub Btn_Add_SaleDetail_Id_Click(sender As Object, e As EventArgs) Handles Btn_Add_SaleDetail_Id.Click
            If ucSaleDetails Is Nothing Then ucSaleDetails = New UIForm.Saledetails
            If frmSaleDetails Is Nothing Then
                frmSaleDetails = New UIForm.DialogBox
                ucSaleDetails.SizeLock = True
                frmSaleDetails.Controls.Add(ucSaleDetails)
                frmSaleDetails.Show()
            Else
                frmSaleDetails.BringToFront()
            End If
        End Sub
        Private Sub Btn_Edit_SaleDetail_Id_Click(sender As Object, e As EventArgs) Handles Btn_Edit_SaleDetail_Id.Click
            If String.IsNullOrWhiteSpace(Txt_SaleDetail_Id.Text) Then Exit Sub
            If ucSaleDetails Is Nothing Then ucSaleDetails = New UIForm.Saledetails
            If frmSaleDetails Is Nothing Then
                frmSaleDetails = New UIForm.DialogBox
                ucSaleDetails.SizeLock = True
                frmSaleDetails.Controls.Add(ucSaleDetails)
                frmSaleDetails.Show()
                ucSaleDetails.Txt_SaleDetail_Id.Text = Txt_SaleDetail_Id.Text
                ucSaleDetails.Btn_Edit_SaleDetail_Id.PerformClick()
            Else
                frmSaleDetails.BringToFront()
            End If
        End Sub
        Private Sub Btn_Del_SaleDetail_Id_Click(sender As Object, e As EventArgs) Handles Btn_Del_SaleDetail_Id.Click
            Try
                If Not String.IsNullOrWhiteSpace(Txt_SaleDetail_Id.Text) Then
                    Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If result = DialogResult.Yes Then
                        clsSaleBarcodes.Delete("SaleDetail_Id", Txt_SaleDetail_Id.Text)
                        clsSaleDetails.Delete(Txt_SaleDetail_Id.Text)
                        clsSaleDetails.BoundComboBox(Cbo_SaleDetail_Id)
                        MessageBox.Show("Record delete sucessfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Record not selected for delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub Cbo_SaleDetail_Id_GotFocus(sender As Object, e As EventArgs) Handles Cbo_SaleDetail_Id.GotFocus
            If Cbo_SaleDetail_Id.SelectedIndex = -1 Then ComboBoxUpdate = True
        End Sub
        Private Sub Cbo_SaleDetail_Id_DropDown(sender As Object, e As EventArgs) Handles Cbo_SaleDetail_Id.DropDown
            clsSaleDetails.BoundComboBox(Cbo_SaleDetail_Id)
        End Sub
        Private Sub Cbo_SaleDetail_Id_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Cbo_SaleDetail_Id.PreviewKeyDown
            If ComboBoxUpdate = True Then
                clsSaleDetails.BoundComboBox(Cbo_SaleDetail_Id)
                ComboBoxUpdate = False
            End If
        End Sub
        Private Sub Cbo_SaleDetail_Id_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cbo_SaleDetail_Id.SelectionChangeCommitted
            If Not Cbo_SaleDetail_Id.SelectedIndex = -1 Then Txt_SaleDetail_Id.Text = Cbo_SaleDetail_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_SaleDetail_Id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_SaleDetail_Id.SelectedIndexChanged
            If Not Cbo_SaleDetail_Id.SelectedIndex = -1 Then Txt_SaleDetail_Id.Text = Cbo_SaleDetail_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_SaleDetail_Id_LostFocus(sender As Object, e As EventArgs) Handles Cbo_SaleDetail_Id.LostFocus
            If Cbo_SaleDetail_Id.SelectedIndex = -1 Then
                Cbo_SaleDetail_Id.Text = String.Empty
                Txt_SaleDetail_Id.Clear()
            End If
        End Sub
        Private Sub Btn_Add_Product_Id_Click(sender As Object, e As EventArgs) Handles Btn_Add_Product_Id.Click
            If ucProducts Is Nothing Then ucProducts = New UIForm.Products
            If frmProducts Is Nothing Then
                frmProducts = New UIForm.DialogBox
                ucProducts.SizeLock = True
                frmProducts.Controls.Add(ucProducts)
                frmProducts.Show()
            Else
                frmProducts.BringToFront()
            End If
        End Sub
        Private Sub Btn_Edit_Product_Id_Click(sender As Object, e As EventArgs) Handles Btn_Edit_Product_Id.Click
            If String.IsNullOrWhiteSpace(Txt_Product_Id.Text) Then Exit Sub
            If ucProducts Is Nothing Then ucProducts = New UIForm.Products
            If frmProducts Is Nothing Then
                frmProducts = New UIForm.DialogBox
                ucProducts.SizeLock = True
                frmProducts.Controls.Add(ucProducts)
                frmProducts.Show()
                ucProducts.Txt_Product_Id.Text = Txt_Product_Id.Text
                ucProducts.Btn_Edit_Product_Id.PerformClick()
            Else
                frmProducts.BringToFront()
            End If
        End Sub
        Private Sub Btn_Del_Product_Id_Click(sender As Object, e As EventArgs) Handles Btn_Del_Product_Id.Click
            Try
                If Not String.IsNullOrWhiteSpace(Txt_Product_Id.Text) Then
                    Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If result = DialogResult.Yes Then
                        clsSaleBarcodes.Delete("Product_Id", Txt_Product_Id.Text)
                        clsProducts.Delete(Txt_Product_Id.Text)
                        clsProducts.BoundComboBox(Cbo_Product_Id)
                        MessageBox.Show("Record delete sucessfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Record not selected for delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
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
        Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
            clsSaleBarcodes.Clear(Txt_SaleBarcode_Id, Txt_SaleDetail_Id, Txt_Product_Id, Txt_SaleBarcode_Barcode)
            AddEdit = "Add"
        End Sub
        Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
            clsSaleBarcodes.Auto(True, AddEdit, Txt_SaleBarcode_Id, Txt_SaleDetail_Id, Txt_Product_Id, Txt_SaleBarcode_Barcode)
            Cbo_SaleBarcode_Id.SelectedIndex = -1
            Cbo_SaleDetail_Id.SelectedIndex = -1
            Cbo_Product_Id.SelectedIndex = -1
            AddEdit = "Add"
        End Sub
        Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
            Me.ParentForm.Close()
        End Sub
#End Region
    End Class
End Namespace