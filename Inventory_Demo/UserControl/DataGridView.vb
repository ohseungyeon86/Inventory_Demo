Imports System.ComponentModel
Imports Microsoft.Office.Interop
Namespace UIForm
    ' Build Action Embedded Resource
    <ToolboxBitmap(GetType(DataGridView), "DataGridView.ico"), ToolboxItem(False)>
    Public Class DataGridView
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
        Friend WithEvents Lbl_Header As Label
        Friend WithEvents UIFormTips As ToolTip
        Friend WithEvents Pnl_Top As Panel
        Friend WithEvents DgvInventory As Windows.Forms.DataGridView
        Friend WithEvents Pnl_Search As Panel
        Friend WithEvents Pnl_Bottom As Panel
        Friend WithEvents Btn_Refresh As Button
        Friend WithEvents Btn_Save_Excel As Button
        Friend WithEvents Btn_Exit As Button
        Friend WithEvents Btn_Search As Button
        Friend WithEvents Txt_Search As TextBox
        Friend WithEvents Lbl_Quick_Search As Label
        Friend WithEvents Btn_Close As Button
        Friend WithEvents Btn_Settings As Button
        Friend WithEvents Btn_Del As Button
        Friend WithEvents Btn_Edit As Button
        Friend WithEvents Btn_Add As Button
        'Required by the Control Designer
        Private components As IContainer
        ' NOTE: The following procedure is required by the Component Designer
        ' It can be modified using the Component Designer.Do not modify it
        ' using the code editor.
        <DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataGridView))
            Me.Lbl_Header = New System.Windows.Forms.Label()
            Me.UIFormTips = New System.Windows.Forms.ToolTip(Me.components)
            Me.Btn_Refresh = New System.Windows.Forms.Button()
            Me.Btn_Save_Excel = New System.Windows.Forms.Button()
            Me.Btn_Exit = New System.Windows.Forms.Button()
            Me.Btn_Search = New System.Windows.Forms.Button()
            Me.Btn_Settings = New System.Windows.Forms.Button()
            Me.Btn_Close = New System.Windows.Forms.Button()
            Me.Btn_Del = New System.Windows.Forms.Button()
            Me.Btn_Edit = New System.Windows.Forms.Button()
            Me.Btn_Add = New System.Windows.Forms.Button()
            Me.Pnl_Top = New System.Windows.Forms.Panel()
            Me.DgvInventory = New System.Windows.Forms.DataGridView()
            Me.Pnl_Search = New System.Windows.Forms.Panel()
            Me.Lbl_Quick_Search = New System.Windows.Forms.Label()
            Me.Txt_Search = New System.Windows.Forms.TextBox()
            Me.Pnl_Bottom = New System.Windows.Forms.Panel()
            Me.Pnl_Top.SuspendLayout()
            CType(Me.DgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Pnl_Search.SuspendLayout()
            Me.Pnl_Bottom.SuspendLayout()
            Me.SuspendLayout()
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
            Me.Lbl_Header.Size = New System.Drawing.Size(711, 48)
            Me.Lbl_Header.TabIndex = 28
            Me.Lbl_Header.Text = "       DataGridView !!!"
            Me.Lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Btn_Refresh
            '
            Me.Btn_Refresh.BackgroundImage = CType(resources.GetObject("Btn_Refresh.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Refresh.Dock = System.Windows.Forms.DockStyle.Right
            Me.Btn_Refresh.FlatAppearance.BorderSize = 0
            Me.Btn_Refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Refresh.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Refresh.ForeColor = System.Drawing.Color.White
            Me.Btn_Refresh.Image = CType(resources.GetObject("Btn_Refresh.Image"), System.Drawing.Image)
            Me.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Refresh.Location = New System.Drawing.Point(430, 0)
            Me.Btn_Refresh.Name = "Btn_Refresh"
            Me.Btn_Refresh.Size = New System.Drawing.Size(101, 48)
            Me.Btn_Refresh.TabIndex = 4
            Me.Btn_Refresh.Text = "    REFRESH"
            Me.Btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.UIFormTips.SetToolTip(Me.Btn_Refresh, "Refresh")
            Me.Btn_Refresh.UseVisualStyleBackColor = True
            '
            'Btn_Save_Excel
            '
            Me.Btn_Save_Excel.BackgroundImage = CType(resources.GetObject("Btn_Save_Excel.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Save_Excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Save_Excel.Dock = System.Windows.Forms.DockStyle.Right
            Me.Btn_Save_Excel.FlatAppearance.BorderSize = 0
            Me.Btn_Save_Excel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Save_Excel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Save_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Save_Excel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Save_Excel.ForeColor = System.Drawing.Color.White
            Me.Btn_Save_Excel.Image = CType(resources.GetObject("Btn_Save_Excel.Image"), System.Drawing.Image)
            Me.Btn_Save_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Save_Excel.Location = New System.Drawing.Point(531, 0)
            Me.Btn_Save_Excel.Name = "Btn_Save_Excel"
            Me.Btn_Save_Excel.Size = New System.Drawing.Size(90, 48)
            Me.Btn_Save_Excel.TabIndex = 5
            Me.Btn_Save_Excel.Text = "EXCEL"
            Me.Btn_Save_Excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.UIFormTips.SetToolTip(Me.Btn_Save_Excel, "Export to excel")
            Me.Btn_Save_Excel.UseVisualStyleBackColor = True
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
            Me.Btn_Exit.Location = New System.Drawing.Point(621, 0)
            Me.Btn_Exit.Name = "Btn_Exit"
            Me.Btn_Exit.Size = New System.Drawing.Size(90, 48)
            Me.Btn_Exit.TabIndex = 6
            Me.Btn_Exit.Text = "EXIT"
            Me.Btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.UIFormTips.SetToolTip(Me.Btn_Exit, "Exit")
            Me.Btn_Exit.UseVisualStyleBackColor = True
            '
            'Btn_Search
            '
            Me.Btn_Search.BackgroundImage = CType(resources.GetObject("Btn_Search.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Search.Dock = System.Windows.Forms.DockStyle.Right
            Me.Btn_Search.FlatAppearance.BorderSize = 0
            Me.Btn_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Search.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Search.ForeColor = System.Drawing.Color.White
            Me.Btn_Search.Image = CType(resources.GetObject("Btn_Search.Image"), System.Drawing.Image)
            Me.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Search.Location = New System.Drawing.Point(333, 0)
            Me.Btn_Search.Name = "Btn_Search"
            Me.Btn_Search.Size = New System.Drawing.Size(97, 48)
            Me.Btn_Search.TabIndex = 7
            Me.Btn_Search.Text = "   SEARCH"
            Me.Btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.UIFormTips.SetToolTip(Me.Btn_Search, "Quick search")
            Me.Btn_Search.UseVisualStyleBackColor = True
            '
            'Btn_Settings
            '
            Me.Btn_Settings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Btn_Settings.FlatAppearance.BorderSize = 0
            Me.Btn_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Settings.Image = CType(resources.GetObject("Btn_Settings.Image"), System.Drawing.Image)
            Me.Btn_Settings.Location = New System.Drawing.Point(642, 5)
            Me.Btn_Settings.Name = "Btn_Settings"
            Me.Btn_Settings.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Settings.TabIndex = 5
            Me.UIFormTips.SetToolTip(Me.Btn_Settings, "Advance Search")
            Me.Btn_Settings.UseVisualStyleBackColor = True
            '
            'Btn_Close
            '
            Me.Btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Btn_Close.FlatAppearance.BorderSize = 0
            Me.Btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Close.Image = CType(resources.GetObject("Btn_Close.Image"), System.Drawing.Image)
            Me.Btn_Close.Location = New System.Drawing.Point(676, 5)
            Me.Btn_Close.Name = "Btn_Close"
            Me.Btn_Close.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Close.TabIndex = 4
            Me.UIFormTips.SetToolTip(Me.Btn_Close, "Show/Hide")
            Me.Btn_Close.UseVisualStyleBackColor = True
            '
            'Btn_Del
            '
            Me.Btn_Del.BackgroundImage = CType(resources.GetObject("Btn_Del.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Del.Dock = System.Windows.Forms.DockStyle.Left
            Me.Btn_Del.FlatAppearance.BorderSize = 0
            Me.Btn_Del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Del.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Del.ForeColor = System.Drawing.Color.White
            Me.Btn_Del.Image = CType(resources.GetObject("Btn_Del.Image"), System.Drawing.Image)
            Me.Btn_Del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Del.Location = New System.Drawing.Point(180, 0)
            Me.Btn_Del.Name = "Btn_Del"
            Me.Btn_Del.Size = New System.Drawing.Size(90, 48)
            Me.Btn_Del.TabIndex = 8
            Me.Btn_Del.Text = "DELETE"
            Me.Btn_Del.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.UIFormTips.SetToolTip(Me.Btn_Del, "Delete one or more record")
            Me.Btn_Del.UseVisualStyleBackColor = True
            '
            'Btn_Edit
            '
            Me.Btn_Edit.BackgroundImage = CType(resources.GetObject("Btn_Edit.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Edit.Dock = System.Windows.Forms.DockStyle.Left
            Me.Btn_Edit.FlatAppearance.BorderSize = 0
            Me.Btn_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Edit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Edit.ForeColor = System.Drawing.Color.White
            Me.Btn_Edit.Image = CType(resources.GetObject("Btn_Edit.Image"), System.Drawing.Image)
            Me.Btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Edit.Location = New System.Drawing.Point(90, 0)
            Me.Btn_Edit.Name = "Btn_Edit"
            Me.Btn_Edit.Size = New System.Drawing.Size(90, 48)
            Me.Btn_Edit.TabIndex = 9
            Me.Btn_Edit.Text = "EDIT"
            Me.Btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.UIFormTips.SetToolTip(Me.Btn_Edit, "Edit one or more record")
            Me.Btn_Edit.UseVisualStyleBackColor = True
            '
            'Btn_Add
            '
            Me.Btn_Add.BackgroundImage = CType(resources.GetObject("Btn_Add.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Add.Dock = System.Windows.Forms.DockStyle.Left
            Me.Btn_Add.FlatAppearance.BorderSize = 0
            Me.Btn_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Add.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Add.ForeColor = System.Drawing.Color.White
            Me.Btn_Add.Image = CType(resources.GetObject("Btn_Add.Image"), System.Drawing.Image)
            Me.Btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Add.Location = New System.Drawing.Point(0, 0)
            Me.Btn_Add.Name = "Btn_Add"
            Me.Btn_Add.Size = New System.Drawing.Size(90, 48)
            Me.Btn_Add.TabIndex = 10
            Me.Btn_Add.Text = "ADD"
            Me.Btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.UIFormTips.SetToolTip(Me.Btn_Add, "Add new record")
            Me.Btn_Add.UseVisualStyleBackColor = True
            '
            'Pnl_Top
            '
            Me.Pnl_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.Pnl_Top.BackgroundImage = CType(resources.GetObject("Pnl_Top.BackgroundImage"), System.Drawing.Image)
            Me.Pnl_Top.Controls.Add(Me.Lbl_Header)
            Me.Pnl_Top.Dock = System.Windows.Forms.DockStyle.Top
            Me.Pnl_Top.Location = New System.Drawing.Point(0, 0)
            Me.Pnl_Top.Name = "Pnl_Top"
            Me.Pnl_Top.Size = New System.Drawing.Size(711, 48)
            Me.Pnl_Top.TabIndex = 61
            '
            'DgvInventory
            '
            Me.DgvInventory.AllowUserToAddRows = False
            Me.DgvInventory.AllowUserToDeleteRows = False
            Me.DgvInventory.BackgroundColor = System.Drawing.Color.White
            Me.DgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DgvInventory.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DgvInventory.Location = New System.Drawing.Point(0, 86)
            Me.DgvInventory.Name = "DgvInventory"
            Me.DgvInventory.ReadOnly = True
            Me.DgvInventory.Size = New System.Drawing.Size(711, 382)
            Me.DgvInventory.TabIndex = 78
            '
            'Pnl_Search
            '
            Me.Pnl_Search.Controls.Add(Me.Btn_Settings)
            Me.Pnl_Search.Controls.Add(Me.Btn_Close)
            Me.Pnl_Search.Controls.Add(Me.Lbl_Quick_Search)
            Me.Pnl_Search.Controls.Add(Me.Txt_Search)
            Me.Pnl_Search.Dock = System.Windows.Forms.DockStyle.Top
            Me.Pnl_Search.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Pnl_Search.ForeColor = System.Drawing.Color.White
            Me.Pnl_Search.Location = New System.Drawing.Point(0, 48)
            Me.Pnl_Search.Name = "Pnl_Search"
            Me.Pnl_Search.Size = New System.Drawing.Size(711, 38)
            Me.Pnl_Search.TabIndex = 79
            Me.Pnl_Search.Visible = False
            '
            'Lbl_Quick_Search
            '
            Me.Lbl_Quick_Search.AutoSize = True
            Me.Lbl_Quick_Search.Location = New System.Drawing.Point(17, 12)
            Me.Lbl_Quick_Search.Name = "Lbl_Quick_Search"
            Me.Lbl_Quick_Search.Size = New System.Drawing.Size(93, 14)
            Me.Lbl_Quick_Search.TabIndex = 3
            Me.Lbl_Quick_Search.Text = "Quick search"
            '
            'Txt_Search
            '
            Me.Txt_Search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Txt_Search.Location = New System.Drawing.Point(116, 9)
            Me.Txt_Search.Name = "Txt_Search"
            Me.Txt_Search.Size = New System.Drawing.Size(520, 22)
            Me.Txt_Search.TabIndex = 2
            '
            'Pnl_Bottom
            '
            Me.Pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.Pnl_Bottom.BackgroundImage = CType(resources.GetObject("Pnl_Bottom.BackgroundImage"), System.Drawing.Image)
            Me.Pnl_Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Pnl_Bottom.Controls.Add(Me.Btn_Del)
            Me.Pnl_Bottom.Controls.Add(Me.Btn_Edit)
            Me.Pnl_Bottom.Controls.Add(Me.Btn_Add)
            Me.Pnl_Bottom.Controls.Add(Me.Btn_Search)
            Me.Pnl_Bottom.Controls.Add(Me.Btn_Refresh)
            Me.Pnl_Bottom.Controls.Add(Me.Btn_Save_Excel)
            Me.Pnl_Bottom.Controls.Add(Me.Btn_Exit)
            Me.Pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Pnl_Bottom.Location = New System.Drawing.Point(0, 468)
            Me.Pnl_Bottom.Name = "Pnl_Bottom"
            Me.Pnl_Bottom.Size = New System.Drawing.Size(711, 48)
            Me.Pnl_Bottom.TabIndex = 80
            '
            'DataGridView
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.Controls.Add(Me.DgvInventory)
            Me.Controls.Add(Me.Pnl_Search)
            Me.Controls.Add(Me.Pnl_Top)
            Me.Controls.Add(Me.Pnl_Bottom)
            Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.Black
            Me.Name = "DataGridView"
            Me.Size = New System.Drawing.Size(711, 516)
            Me.Pnl_Top.ResumeLayout(False)
            CType(Me.DgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Pnl_Search.ResumeLayout(False)
            Me.Pnl_Search.PerformLayout()
            Me.Pnl_Bottom.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region
#Region " Component Events "
        Private _TableName As String
        Public Property TableName As String
            Get
                Return _TableName
            End Get
            Set(value As String)
                _TableName = value
                Select Case _TableName
                    Case "Login"
                        Lbl_Header.Text = "       Login Record !!!"
                        clsLogin.BoundDataGridView(DgvInventory)
                    Case "Business"
                        Lbl_Header.Text = "       Business Record !!!"
                        clsBusiness.BoundDataGridView(DgvInventory)
                    Case "Units"
                        Lbl_Header.Text = "       Units Record !!!"
                        clsUnits.BoundDataGridView(DgvInventory)
                    Case "Catagores"
                        Lbl_Header.Text = "       Catagores Record !!!"
                        clsCatagores.BoundDataGridView(DgvInventory)
                    Case "Products"
                        Lbl_Header.Text = "       Products Record !!!"
                        clsProducts.BoundDataGridView(DgvInventory)
                    Case "ProductBarcodes"
                        Lbl_Header.Text = "       ProductBarcodes Record !!!"
                        clsProductBarcodes.BoundDataGridView(DgvInventory)
                    Case "Reletionships"
                        Lbl_Header.Text = "       Reletionships Record !!!"
                        clsReletionships.BoundDataGridView(DgvInventory)
                    Case "Profiles"
                        Lbl_Header.Text = "       Profiles Record !!!"
                        clsProfiles.BoundDataGridView(DgvInventory)
                    Case "Purchases"
                        Lbl_Header.Text = "       Purchases Record !!!"
                        clsPurchases.BoundDataGridView(DgvInventory)
                    Case "PurchaseDetails"
                        Lbl_Header.Text = "       PurchaseDetails Record !!!"
                        clsPurchaseDetails.BoundDataGridView(DgvInventory)
                    Case "PurchaseBarcodes"
                        Lbl_Header.Text = "       PurchaseBarcodes Record !!!"
                        clsPurchaseBarcodes.BoundDataGridView(DgvInventory)
                    Case "Sales"
                        Lbl_Header.Text = "       Sales Record !!!"
                        clsSales.BoundDataGridView(DgvInventory)
                    Case "SaleDetails"
                        Lbl_Header.Text = "       SaleDetails Record !!!"
                        clsSaleDetails.BoundDataGridView(DgvInventory)
                    Case "SaleBarcodes"
                        Lbl_Header.Text = "       SaleBarcodes Record !!!"
                        clsSaleBarcodes.BoundDataGridView(DgvInventory)
                    Case "CashBalance"
                        Lbl_Header.Text = "       CashBalance Record !!!"
                        clsCashBalance.BoundDataGridView(DgvInventory)
                    Case "CashMemo"
                        Lbl_Header.Text = "       CashMemo Record !!!"
                        clsCashMemo.BoundDataGridView(DgvInventory)
                End Select
            End Set
        End Property
        Private Sub TableSearch()
            Dim _SearchSyntax As String = String.Empty
            Select Case _TableName
                Case "Login"
                    _SearchSyntax = String.Format("Login_Id LIKE '%{0}%' OR Login_Name LIKE '%{0}%' OR Login_Password LIKE '%{0}%' OR Login_Phone LIKE '%{0}%' OR Login_Mail LIKE '%{0}%' OR Login_Permission LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                    clsLogin.BoundDataGridView(DgvInventory, _SearchSyntax)
                Case "Business"
                    _SearchSyntax = String.Format("Business_Id LIKE '%{0}%' OR Business_Name LIKE '%{0}%' OR Business_Phone LIKE '%{0}%' OR Business_Mail LIKE '%{0}%' OR Business_GST_No LIKE '%{0}%' OR Business_Pan_No LIKE '%{0}%' OR Business_CGST LIKE '%{0}%' OR Business_SGST LIKE '%{0}%' OR Business_IGST LIKE '%{0}%' OR Business_Tin LIKE '%{0}%' OR Business_Bank_Account LIKE '%{0}%' OR Business_Bill_No LIKE '%{0}%' OR Business_Address LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                    clsBusiness.BoundDataGridView(DgvInventory, _SearchSyntax)
                Case "Units"
                    _SearchSyntax = String.Format("Unit_Id LIKE '%{0}%' OR Unit_Name LIKE '%{0}%' OR Unit_Note LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                    clsUnits.BoundDataGridView(DgvInventory, _SearchSyntax)
                Case "Catagores"
                    _SearchSyntax = String.Format("Category_Id LIKE '%{0}%' OR Category_Name LIKE '%{0}%' OR Category_Note LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                    clsCatagores.BoundDataGridView(DgvInventory, _SearchSyntax)
                Case "Products"
                    _SearchSyntax = String.Format("Product_Id LIKE '%{0}%' OR Category_Id LIKE '%{0}%' OR Category_Name LIKE '%{0}%' OR Product_Name LIKE '%{0}%' OR Unit_Id LIKE '%{0}%' OR Unit_Name LIKE '%{0}%' OR HSN_Code LIKE '%{0}%' OR Product_Stock LIKE '%{0}%' OR Product_Single_Amount LIKE '%{0}%' OR Product_Note LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                    clsProducts.BoundDataGridView(DgvInventory, _SearchSyntax)
                Case "ProductBarcodes"
                    _SearchSyntax = String.Format("ProductBarcode_Id LIKE '%{0}%' OR PurchaseDetail_Id LIKE '%{0}%' OR Product_Id LIKE '%{0}%' OR ProductBarcode_Barcode LIKE '%{0}%' OR ProductBarcode_Stock LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                    clsProductBarcodes.BoundDataGridView(DgvInventory, _SearchSyntax)
                Case "Reletionships"
                    _SearchSyntax = String.Format("Reletionship_Id LIKE '%{0}%' OR Reletionship_Name LIKE '%{0}%' OR Reletionship_Note LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                    clsReletionships.BoundDataGridView(DgvInventory, _SearchSyntax)
                Case "Profiles"
                    _SearchSyntax = String.Format("Profile_Id LIKE '%{0}%' OR Profile_Name LIKE '%{0}%' OR Reletionship_Id LIKE '%{0}%' OR Reletionship_Name LIKE '%{0}%' OR Profile_Phone LIKE '%{0}%' OR Profile_Mail LIKE '%{0}%' OR Profile_GST_No LIKE '%{0}%' OR Profile_PAN_No LIKE '%{0}%' OR Profile_Bank_Account LIKE '%{0}%' OR Profile_Address LIKE '%{0}%' OR Profile_Remark LIKE '%{0}%' OR Profile_State LIKE '%{0}%' OR Profile_Note LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                    clsProfiles.BoundDataGridView(DgvInventory, _SearchSyntax)
                Case "Purchases"
                    _SearchSyntax = String.Format("Purchase_Id LIKE '%{0}%' OR Purchase_Date LIKE '%{0}%' OR Profile_Id LIKE '%{0}%' OR Purchase_CGST_Amount LIKE '%{0}%' OR Purchase_SGST_Amount LIKE '%{0}%' OR Purchase_IGST_Amount LIKE '%{0}%' OR Purchase_Grandtotal_Amount LIKE '%{0}%' OR Purchase_Payment_Amount LIKE '%{0}%' OR Purchase_Due_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                    clsPurchases.BoundDataGridView(DgvInventory, _SearchSyntax)
                Case "PurchaseDetails"
                    _SearchSyntax = String.Format("PurchaseDetail_Id LIKE '%{0}%' OR Purchase_Id LIKE '%{0}%' OR Product_Id LIKE '%{0}%' OR Product_Name LIKE '%{0}%' OR HSN_Code LIKE '%{0}%' OR Purchase_Quantity LIKE '%{0}%' OR Unit_Name LIKE '%{0}%' OR Purchase_Rate_Amount LIKE '%{0}%' OR Purchase_Subtotal_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                    clsPurchaseDetails.BoundDataGridView(DgvInventory, _SearchSyntax)
                Case "PurchaseBarcodes"
                    _SearchSyntax = String.Format("PurchaseBarcode_Id LIKE '%{0}%' OR PurchaseDetail_Id LIKE '%{0}%' OR Product_Id LIKE '%{0}%' OR Product_Barcode LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                    clsPurchaseBarcodes.BoundDataGridView(DgvInventory, _SearchSyntax)
                Case "Sales"
                    _SearchSyntax = String.Format("Sale_Id LIKE '%{0}%' OR Sale_Date LIKE '%{0}%' OR Profile_Id LIKE '%{0}%' OR Sale_CGST_Amount LIKE '%{0}%' OR Sale_SGST_Amount LIKE '%{0}%' OR Sale_IGST_Amount LIKE '%{0}%' OR Sale_Grandtotal_Amount LIKE '%{0}%' OR Sale_Recive_Amount LIKE '%{0}%' OR Sale_Due_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                    clsSales.BoundDataGridView(DgvInventory, _SearchSyntax)
                Case "SaleDetails"
                    _SearchSyntax = String.Format("SaleDetail_Id LIKE '%{0}%' OR Sale_Id LIKE '%{0}%' OR Product_Id LIKE '%{0}%' OR Product_Name LIKE '%{0}%' OR HSN_Code LIKE '%{0}%' OR Sale_Quantity LIKE '%{0}%' OR Unit_Name LIKE '%{0}%' OR Sale_Rate_Amount LIKE '%{0}%' OR Sale_Subtotal_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                    clsSaleDetails.BoundDataGridView(DgvInventory, _SearchSyntax)
                Case "SaleBarcodes"
                    _SearchSyntax = String.Format("SaleBarcode_Id LIKE '%{0}%' OR SaleDetail_Id LIKE '%{0}%' OR Product_Id LIKE '%{0}%' OR SaleBarcode_Barcode LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                    clsSaleBarcodes.BoundDataGridView(DgvInventory, _SearchSyntax)
                Case "CashBalance"
                    _SearchSyntax = String.Format("CashBalance_Id LIKE '%{0}%' OR CashBalance_Date LIKE '%{0}%' OR Profile_Id LIKE '%{0}%' OR CashBalance_Payment_Amount LIKE '%{0}%' OR CashBalance_Recive_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                    clsCashBalance.BoundDataGridView(DgvInventory, _SearchSyntax)
                Case "CashMemo"
                    _SearchSyntax = String.Format("CashMemo_Id LIKE '%{0}%' OR CashMemo_Date LIKE '%{0}%' OR Profile_Id LIKE '%{0}%' OR CashMemo_Payment_Amount LIKE '%{0}%' OR CashMemo_Recive_Amount LIKE '%{0}%'", Txt_Search.Text.Replace("'", "''"))
                    clsCashMemo.BoundDataGridView(DgvInventory, _SearchSyntax)
            End Select
        End Sub
        Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
            Select Case _TableName
                Case "Login"
                    If ucLogin Is Nothing Then ucLogin = New UIForm.Login
                    If frmLogin Is Nothing Then
                        frmLogin = New UIForm.DialogBox
                        ucLogin.SizeLock = True
                        frmLogin.Controls.Add(ucLogin)
                        frmLogin.Show()
                    Else
                        frmLogin.BringToFront()
                    End If
                Case "Business"
                    If ucBusiness Is Nothing Then ucBusiness = New UIForm.Business
                    If frmBusiness Is Nothing Then
                        frmBusiness = New UIForm.DialogBox
                        ucBusiness.SizeLock = True
                        frmBusiness.Controls.Add(ucBusiness)
                        frmBusiness.Show()
                    Else
                        frmBusiness.BringToFront()
                    End If
                Case "Units"
                    If ucUnits Is Nothing Then ucUnits = New UIForm.Units
                    If frmUnits Is Nothing Then
                        frmUnits = New UIForm.DialogBox
                        ucUnits.SizeLock = True
                        frmUnits.Controls.Add(ucUnits)
                        frmUnits.Show()
                    Else
                        frmUnits.BringToFront()
                    End If
                Case "Catagores"
                    If ucCatagores Is Nothing Then ucCatagores = New UIForm.Catagores
                    If frmCatagores Is Nothing Then
                        frmCatagores = New UIForm.DialogBox
                        ucCatagores.SizeLock = True
                        frmCatagores.Controls.Add(ucCatagores)
                        frmCatagores.Show()
                    Else
                        frmCatagores.BringToFront()
                    End If
                Case "Products"
                    If ucProducts Is Nothing Then ucProducts = New UIForm.Products
                    If frmProducts Is Nothing Then
                        frmProducts = New UIForm.DialogBox
                        ucProducts.SizeLock = True
                        frmProducts.Controls.Add(ucProducts)
                        frmProducts.Show()
                    Else
                        frmProducts.BringToFront()
                    End If
                Case "ProductBarcodes"
                    If ucProductBarcodes Is Nothing Then ucProductBarcodes = New UIForm.Productbarcodes
                    If frmProductBarcodes Is Nothing Then
                        frmProductBarcodes = New UIForm.DialogBox
                        ucProductBarcodes.SizeLock = True
                        frmProductBarcodes.Controls.Add(ucProductBarcodes)
                        frmProductBarcodes.Show()
                    Else
                        frmProductBarcodes.BringToFront()
                    End If
                Case "Reletionships"
                    If ucReletionships Is Nothing Then ucReletionships = New UIForm.Reletionships
                    If frmReletionships Is Nothing Then
                        frmReletionships = New UIForm.DialogBox
                        ucReletionships.SizeLock = True
                        frmReletionships.Controls.Add(ucReletionships)
                        frmReletionships.Show()
                    Else
                        frmReletionships.BringToFront()
                    End If
                Case "Profiles"
                    If ucProfiles Is Nothing Then ucProfiles = New UIForm.Profiles
                    If frmProfiles Is Nothing Then
                        frmProfiles = New UIForm.DialogBox
                        ucProfiles.SizeLock = True
                        frmProfiles.Controls.Add(ucProfiles)
                        frmProfiles.Show()
                    Else
                        frmProfiles.BringToFront()
                    End If
                Case "Purchases"
                    If ucPurchases Is Nothing Then ucPurchases = New UIForm.Purchases
                    If frmPurchases Is Nothing Then
                        frmPurchases = New UIForm.DialogBox
                        ucPurchases.SizeLock = True
                        frmPurchases.Controls.Add(ucPurchases)
                        frmPurchases.Show()
                    Else
                        frmPurchases.BringToFront()
                    End If
                Case "PurchaseDetails"
                    If ucPurchaseDetails Is Nothing Then ucPurchaseDetails = New UIForm.Purchasedetails
                    If frmPurchaseDetails Is Nothing Then
                        frmPurchaseDetails = New UIForm.DialogBox
                        ucPurchaseDetails.SizeLock = True
                        frmPurchaseDetails.Controls.Add(ucPurchaseDetails)
                        frmPurchaseDetails.Show()
                    Else
                        frmPurchaseDetails.BringToFront()
                    End If
                Case "PurchaseBarcodes"
                    If ucPurchaseBarcodes Is Nothing Then ucPurchaseBarcodes = New UIForm.Purchasebarcodes
                    If frmPurchaseBarcodes Is Nothing Then
                        frmPurchaseBarcodes = New UIForm.DialogBox
                        ucPurchaseBarcodes.SizeLock = True
                        frmPurchaseBarcodes.Controls.Add(ucPurchaseBarcodes)
                        frmPurchaseBarcodes.Show()
                    Else
                        frmPurchaseBarcodes.BringToFront()
                    End If
                Case "Sales"
                    If ucSales Is Nothing Then ucSales = New UIForm.Sales
                    If frmSales Is Nothing Then
                        frmSales = New UIForm.DialogBox
                        ucSales.SizeLock = True
                        frmSales.Controls.Add(ucSales)
                        frmSales.Show()
                    Else
                        frmSales.BringToFront()
                    End If
                Case "SaleDetails"
                    If ucSaleDetails Is Nothing Then ucSaleDetails = New UIForm.Saledetails
                    If frmSaleDetails Is Nothing Then
                        frmSaleDetails = New UIForm.DialogBox
                        ucSaleDetails.SizeLock = True
                        frmSaleDetails.Controls.Add(ucSaleDetails)
                        frmSaleDetails.Show()
                    Else
                        frmSaleDetails.BringToFront()
                    End If
                Case "SaleBarcodes"
                    If ucSaleBarcodes Is Nothing Then ucSaleBarcodes = New UIForm.Salebarcodes
                    If frmSaleBarcodes Is Nothing Then
                        frmSaleBarcodes = New UIForm.DialogBox
                        ucSaleBarcodes.SizeLock = True
                        frmSaleBarcodes.Controls.Add(ucSaleBarcodes)
                        frmSaleBarcodes.Show()
                    Else
                        frmSaleBarcodes.BringToFront()
                    End If
                Case "CashBalance"
                    If ucCashBalance Is Nothing Then ucCashBalance = New UIForm.Cashbalance
                    If frmCashBalance Is Nothing Then
                        frmCashBalance = New UIForm.DialogBox
                        ucCashBalance.SizeLock = True
                        frmCashBalance.Controls.Add(ucCashBalance)
                        frmCashBalance.Show()
                    Else
                        frmCashBalance.BringToFront()
                    End If
                Case "CashMemo"
                    If ucCashMemo Is Nothing Then ucCashMemo = New UIForm.Cashmemo
                    If frmCashMemo Is Nothing Then
                        frmCashMemo = New UIForm.DialogBox
                        ucCashMemo.SizeLock = True
                        frmCashMemo.Controls.Add(ucCashMemo)
                        frmCashMemo.Show()
                    Else
                        frmCashMemo.BringToFront()
                    End If
            End Select
        End Sub
        Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
            If DgvInventory.SelectedRows.Count = 0 Then Exit Sub
            If MessageBox.Show("There is no undo once data is edit?" & vbNewLine & "Are you sure you want to edit those record?" & vbNewLine &
            "Total record(s) Seleted " & DgvInventory.SelectedRows.Count, "Edit",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                For i As Integer = 0 To DgvInventory.SelectedRows.Count - 1
                    Dim DgvSelectedRows As DataGridViewRow = DgvInventory.SelectedRows(i)
                    Select Case _TableName
                        Case "Login"
                            Dim xLogin As New UIForm.Login
                            Dim xDialogBox As New UIForm.DialogBox
                            xLogin.SizeLock = True
                            xDialogBox.Controls.Add(xLogin)
                            xDialogBox.Show()
                            xLogin.Txt_Login_Id.Text = DgvSelectedRows.Cells(0).Value.ToString()
                            xLogin.Btn_Edit_Login_Id.PerformClick()
                        Case "Business"
                            Dim xBusiness As New UIForm.Business
                            Dim xDialogBox As New UIForm.DialogBox
                            xBusiness.SizeLock = True
                            xDialogBox.Controls.Add(xBusiness)
                            xDialogBox.Show()
                            xBusiness.Txt_Business_Id.Text = DgvSelectedRows.Cells(0).Value.ToString()
                            xBusiness.Btn_Edit_Business_Id.PerformClick()
                        Case "Units"
                            Dim xUnits As New UIForm.Units
                            Dim xDialogBox As New UIForm.DialogBox
                            xUnits.SizeLock = True
                            xDialogBox.Controls.Add(xUnits)
                            xDialogBox.Show()
                            xUnits.Txt_Unit_Id.Text = DgvSelectedRows.Cells(0).Value.ToString()
                            xUnits.Btn_Edit_Unit_Id.PerformClick()
                        Case "Catagores"
                            Dim xCatagores As New UIForm.Catagores
                            Dim xDialogBox As New UIForm.DialogBox
                            xCatagores.SizeLock = True
                            xDialogBox.Controls.Add(xCatagores)
                            xDialogBox.Show()
                            xCatagores.Txt_Category_Id.Text = DgvSelectedRows.Cells(0).Value.ToString()
                            xCatagores.Btn_Edit_Category_Id.PerformClick()
                        Case "Products"
                            Dim xProducts As New UIForm.Products
                            Dim xDialogBox As New UIForm.DialogBox
                            xProducts.SizeLock = True
                            xDialogBox.Controls.Add(xProducts)
                            xDialogBox.Show()
                            xProducts.Txt_Product_Id.Text = DgvSelectedRows.Cells(0).Value.ToString()
                            xProducts.Btn_Edit_Product_Id.PerformClick()
                        Case "ProductBarcodes"
                            Dim xProductBarcodes As New UIForm.Productbarcodes
                            Dim xDialogBox As New UIForm.DialogBox
                            xProductBarcodes.SizeLock = True
                            xDialogBox.Controls.Add(xProductBarcodes)
                            xDialogBox.Show()
                            xProductBarcodes.Txt_ProductBarcode_Id.Text = DgvSelectedRows.Cells(0).Value.ToString()
                            xProductBarcodes.Btn_Edit_ProductBarcode_Id.PerformClick()
                        Case "Reletionships"
                            Dim xReletionships As New UIForm.Reletionships
                            Dim xDialogBox As New UIForm.DialogBox
                            xReletionships.SizeLock = True
                            xDialogBox.Controls.Add(xReletionships)
                            xDialogBox.Show()
                            xReletionships.Txt_Reletionship_Id.Text = DgvSelectedRows.Cells(0).Value.ToString()
                            xReletionships.Btn_Edit_Reletionship_Id.PerformClick()
                        Case "Profiles"
                            Dim xProfiles As New UIForm.Profiles
                            Dim xDialogBox As New UIForm.DialogBox
                            xProfiles.SizeLock = True
                            xDialogBox.Controls.Add(xProfiles)
                            xDialogBox.Show()
                            xProfiles.Txt_Profile_Id.Text = DgvSelectedRows.Cells(0).Value.ToString()
                            xProfiles.Btn_Edit_Profile_Id.PerformClick()
                        Case "Purchases"
                            Dim xPurchases As New UIForm.Purchases
                            Dim xDialogBox As New UIForm.DialogBox
                            xPurchases.SizeLock = True
                            xDialogBox.Controls.Add(xPurchases)
                            xDialogBox.Show()
                            xPurchases.Txt_Purchase_Id.Text = DgvSelectedRows.Cells(0).Value.ToString()
                            xPurchases.Btn_Edit_Purchase_Id.PerformClick()
                        Case "PurchaseDetails"
                            Dim xPurchaseDetails As New UIForm.Purchasedetails
                            Dim xDialogBox As New UIForm.DialogBox
                            xPurchaseDetails.SizeLock = True
                            xDialogBox.Controls.Add(xPurchaseDetails)
                            xDialogBox.Show()
                            xPurchaseDetails.Txt_PurchaseDetail_Id.Text = DgvSelectedRows.Cells(0).Value.ToString()
                            xPurchaseDetails.Btn_Edit_PurchaseDetail_Id.PerformClick()
                        Case "PurchaseBarcodes"
                            Dim xPurchaseBarcodes As New UIForm.Purchasebarcodes
                            Dim xDialogBox As New UIForm.DialogBox
                            xPurchaseBarcodes.SizeLock = True
                            xDialogBox.Controls.Add(xPurchaseBarcodes)
                            xDialogBox.Show()
                            xPurchaseBarcodes.Txt_PurchaseBarcode_Id.Text = DgvSelectedRows.Cells(0).Value.ToString()
                            xPurchaseBarcodes.Btn_Edit_PurchaseBarcode_Id.PerformClick()
                        Case "Sales"
                            Dim xSales As New UIForm.Sales
                            Dim xDialogBox As New UIForm.DialogBox
                            xSales.SizeLock = True
                            xDialogBox.Controls.Add(xSales)
                            xDialogBox.Show()
                            xSales.Txt_Sale_Id.Text = DgvSelectedRows.Cells(0).Value.ToString()
                            xSales.Btn_Edit_Sale_Id.PerformClick()
                        Case "SaleDetails"
                            Dim xSaleDetails As New UIForm.Saledetails
                            Dim xDialogBox As New UIForm.DialogBox
                            xSaleDetails.SizeLock = True
                            xDialogBox.Controls.Add(xSaleDetails)
                            xDialogBox.Show()
                            xSaleDetails.Txt_SaleDetail_Id.Text = DgvSelectedRows.Cells(0).Value.ToString()
                            xSaleDetails.Btn_Edit_SaleDetail_Id.PerformClick()
                        Case "SaleBarcodes"
                            Dim xSaleBarcodes As New UIForm.Salebarcodes
                            Dim xDialogBox As New UIForm.DialogBox
                            xSaleBarcodes.SizeLock = True
                            xDialogBox.Controls.Add(xSaleBarcodes)
                            xDialogBox.Show()
                            xSaleBarcodes.Txt_SaleBarcode_Id.Text = DgvSelectedRows.Cells(0).Value.ToString()
                            xSaleBarcodes.Btn_Edit_SaleBarcode_Id.PerformClick()
                        Case "CashBalance"
                            Dim xCashBalance As New UIForm.Cashbalance
                            Dim xDialogBox As New UIForm.DialogBox
                            xCashBalance.SizeLock = True
                            xDialogBox.Controls.Add(xCashBalance)
                            xDialogBox.Show()
                            xCashBalance.Txt_CashBalance_Id.Text = DgvSelectedRows.Cells(0).Value.ToString()
                            xCashBalance.Btn_Edit_CashBalance_Id.PerformClick()
                        Case "CashMemo"
                            Dim xCashMemo As New UIForm.Cashmemo
                            Dim xDialogBox As New UIForm.DialogBox
                            xCashMemo.SizeLock = True
                            xDialogBox.Controls.Add(xCashMemo)
                            xDialogBox.Show()
                            xCashMemo.Txt_CashMemo_Id.Text = DgvSelectedRows.Cells(0).Value.ToString()
                            xCashMemo.Btn_Edit_CashMemo_Id.PerformClick()
                    End Select
                Next
            End If
        End Sub
        Private Sub Btn_Del_Click(sender As Object, e As EventArgs) Handles Btn_Del.Click
            If DgvInventory.SelectedRows.Count = 0 Then Exit Sub
            If MessageBox.Show("There is no undo once data is delete?" & vbNewLine & "Are you sure you want to delete those record?" & vbNewLine &
            "Total record(s) Seleted " & DgvInventory.SelectedRows.Count, "Delete",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Dim SelectedRowsIndex As String = String.Empty
                For i As Integer = 0 To DgvInventory.SelectedRows.Count - 1
                    Dim DgvSelectedRows As DataGridViewRow = DgvInventory.SelectedRows(i)
                    If String.IsNullOrWhiteSpace(SelectedRowsIndex) Then
                        SelectedRowsIndex = DgvSelectedRows.Index
                    Else
                        SelectedRowsIndex += "," & DgvSelectedRows.Index
                    End If
                    Select Case _TableName
                        Case "Login"
                            clsLogin.Delete(DgvSelectedRows.Cells(0).Value.ToString())
                        Case "Business"
                            clsBusiness.Delete(DgvSelectedRows.Cells(0).Value.ToString())
                        Case "Units"
                            clsUnits.Delete(DgvSelectedRows.Cells(0).Value.ToString())
                        Case "Catagores"
                            clsCatagores.Delete(DgvSelectedRows.Cells(0).Value.ToString())
                        Case "Products"
                            clsProducts.Delete(DgvSelectedRows.Cells(0).Value.ToString())
                        Case "ProductBarcodes"
                            clsProductBarcodes.Delete(DgvSelectedRows.Cells(0).Value.ToString())
                        Case "Reletionships"
                            clsReletionships.Delete(DgvSelectedRows.Cells(0).Value.ToString())
                        Case "Profiles"
                            clsProfiles.Delete(DgvSelectedRows.Cells(0).Value.ToString())
                        Case "Purchases"
                            clsPurchases.Delete(DgvSelectedRows.Cells(0).Value.ToString())
                        Case "PurchaseDetails"
                            clsPurchaseDetails.Delete(DgvSelectedRows.Cells(0).Value.ToString())
                        Case "PurchaseBarcodes"
                            clsPurchaseBarcodes.Delete(DgvSelectedRows.Cells(0).Value.ToString())
                        Case "Sales"
                            clsSales.Delete(DgvSelectedRows.Cells(0).Value.ToString())
                        Case "SaleDetails"
                            clsSaleDetails.Delete(DgvSelectedRows.Cells(0).Value.ToString())
                        Case "SaleBarcodes"
                            clsSaleBarcodes.Delete(DgvSelectedRows.Cells(0).Value.ToString())
                        Case "CashBalance"
                            clsCashBalance.Delete(DgvSelectedRows.Cells(0).Value.ToString())
                        Case "CashMemo"
                            clsCashMemo.Delete(DgvSelectedRows.Cells(0).Value.ToString())
                    End Select
                Next
                For j As Integer = 0 To SelectedRowsIndex.Split(",").Count - 1
                    DgvInventory.Rows.RemoveAt(SelectedRowsIndex.Split(",")(j))
                Next
                SelectedRowsIndex = String.Empty
            End If
        End Sub
        Private Sub DataGridViewToMSExcel(ByVal DataGridView As Windows.Forms.DataGridView)
            If DataGridView.RowCount = Nothing Then
                MessageBox.Show("Sorry nothing to export into excel sheet..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim _Rows As Integer
            Dim _Columns As Integer
            Dim _Excel As New Excel.Application
            Dim _Workbook As Excel.Workbook = _Excel.Workbooks.Add
            Dim _Worksheet As Excel.Worksheet = CType(_Workbook.Worksheets(1), Excel.Worksheet)
            Try
                _Excel.Visible = True
                _Rows = DataGridView.RowCount
                _Columns = DataGridView.Columns.Count - 1
                With _Worksheet
                    .Cells.Select()
                    .Cells.Delete()
                    For i As Integer = 0 To _Columns
                        .Cells(1, i + 1).Value = DataGridView.Columns(i).HeaderText
                    Next
                    For j As Integer = 0 To _Rows - 1
                        For k As Integer = 0 To _Columns
                            .Cells(j + 2, k + 1).value = DataGridView.Rows(j).Cells(k).Value
                        Next
                    Next
                    .Rows("1:1").Font.FontStyle = "Bold"
                    .Rows("1:1").Font.Size = 12
                    .Cells.Columns.AutoFit()
                    .Cells.Select()
                    .Cells.EntireColumn.AutoFit()
                    .Cells(1, 1).Select()
                End With
            Catch ex As Exception
                _Excel = Nothing
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub DataGridView_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
            ucDataGridView = Nothing
            frmDataGridView = Nothing
        End Sub
        Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
            Pnl_Search.Visible = Not Pnl_Search.Visible
        End Sub
        Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
            Pnl_Search.Visible = Not Pnl_Search.Visible
        End Sub
        Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
            Me.ParentForm.Close()
        End Sub
        Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
            TableSearch()
        End Sub
        Private Sub Btn_Refresh_Click(sender As Object, e As EventArgs) Handles Btn_Refresh.Click
            TableName = TableName
        End Sub
        Private Sub Btn_Save_Excel_Click(sender As Object, e As EventArgs) Handles Btn_Save_Excel.Click
            DataGridViewToMSExcel(DgvInventory)
        End Sub
        Private Sub Btn_Settings_Click(sender As Object, e As EventArgs) Handles Btn_Settings.Click
            If ucSearch Is Nothing Then ucSearch = New UIForm.Search
            If frmSearch Is Nothing Then
                frmSearch = New UIForm.DialogBox
                ucSearch.SizeLock = True
                frmSearch.Controls.Add(ucSearch)
                frmSearch.Show()
            Else
                frmSearch.BringToFront()
            End If
        End Sub
#End Region
    End Class
End Namespace