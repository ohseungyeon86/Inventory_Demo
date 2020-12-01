Imports System.ComponentModel
Namespace UIForm
    ' Build Action Embedded Resource
    <ToolboxBitmap(GetType(MenuStyle), "MenuStyle.ico"), ToolboxItem(False)>
    Public Class MenuStyle
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
        Friend WithEvents MStrp_Inventory_Menu As MenuStrip
        Friend WithEvents TStrpMItm_Database As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Access As ToolStripMenuItem
        Friend WithEvents TStrpMItm_MSSQL As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Exit As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Add As ToolStripMenuItem
        Friend WithEvents TStrpMItm_List As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Help As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Helps As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Register As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Version As ToolStripMenuItem
        Friend WithEvents TStrpMItm_About As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Report As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Add_Login As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Add_Business As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Add_Units As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Add_Catagores As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Add_Products As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Add_ProductBarcodes As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Add_Reletionships As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Add_Profiles As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Add_Purchases As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Add_PurchaseDetails As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Add_PurchaseBarcodes As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Add_Sales As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Add_SaleDetails As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Add_SaleBarcodes As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Add_CashBalance As ToolStripMenuItem
        Friend WithEvents TStrpMItm_Add_CashMemo As ToolStripMenuItem
        Friend WithEvents TStrpMItm_List_Login As ToolStripMenuItem
        Friend WithEvents TStrpMItm_List_Business As ToolStripMenuItem
        Friend WithEvents TStrpMItm_List_Units As ToolStripMenuItem
        Friend WithEvents TStrpMItm_List_Catagores As ToolStripMenuItem
        Friend WithEvents TStrpMItm_List_Products As ToolStripMenuItem
        Friend WithEvents TStrpMItm_List_ProductBarcodes As ToolStripMenuItem
        Friend WithEvents TStrpMItm_List_Reletionships As ToolStripMenuItem
        Friend WithEvents TStrpMItm_List_Profiles As ToolStripMenuItem
        Friend WithEvents TStrpMItm_List_Purchases As ToolStripMenuItem
        Friend WithEvents TStrpMItm_List_PurchaseDetails As ToolStripMenuItem
        Friend WithEvents TStrpMItm_List_PurchaseBarcodes As ToolStripMenuItem
        Friend WithEvents TStrpMItm_List_Sales As ToolStripMenuItem
        Friend WithEvents TStrpMItm_List_SaleDetails As ToolStripMenuItem
        Friend WithEvents TStrpMItm_List_SaleBarcodes As ToolStripMenuItem
        Friend WithEvents TStrpMItm_List_CashBalance As ToolStripMenuItem
        Friend WithEvents TStrpMItm_List_CashMemo As ToolStripMenuItem
        Friend WithEvents Pnl_MainScreen As Panel
        Friend WithEvents Broadcast As Broadcast
        Friend WithEvents TStrpMItm_SaleEntry As ToolStripMenuItem
        Friend WithEvents TStrpMItm_PruchaseEntry As ToolStripMenuItem
        Friend WithEvents TStrpMItm_OpenCalculator As ToolStripMenuItem
        'Required by the Control Designer
        Private components As IContainer
        ' NOTE: The following procedure is required by the Component Designer
        ' It can be modified using the Component Designer.Do not modify it
        ' using the code editor.
        <DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuStyle))
            Me.MStrp_Inventory_Menu = New System.Windows.Forms.MenuStrip()
            Me.TStrpMItm_Database = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Access = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_MSSQL = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Exit = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Add = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Add_Business = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Add_CashBalance = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Add_CashMemo = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Add_Catagores = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Add_Login = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Add_ProductBarcodes = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Add_Products = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Add_Profiles = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Add_PurchaseBarcodes = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Add_PurchaseDetails = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Add_Purchases = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Add_Reletionships = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Add_SaleBarcodes = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Add_SaleDetails = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Add_Sales = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Add_Units = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_List = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_List_Business = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_List_CashBalance = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_List_CashMemo = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_List_Catagores = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_List_Login = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_List_ProductBarcodes = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_List_Products = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_List_Profiles = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_List_PurchaseBarcodes = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_List_PurchaseDetails = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_List_Purchases = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_List_Reletionships = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_List_SaleBarcodes = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_List_SaleDetails = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_List_Sales = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_List_Units = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Report = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_OpenCalculator = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_SaleEntry = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_PruchaseEntry = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Help = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Helps = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Register = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_Version = New System.Windows.Forms.ToolStripMenuItem()
            Me.TStrpMItm_About = New System.Windows.Forms.ToolStripMenuItem()
            Me.Pnl_MainScreen = New System.Windows.Forms.Panel()
            Me.Broadcast = New Inventory_Demo.UIForm.Broadcast()
            Me.MStrp_Inventory_Menu.SuspendLayout()
            Me.SuspendLayout()
            '
            'MStrp_Inventory_Menu
            '
            Me.MStrp_Inventory_Menu.Enabled = False
            Me.MStrp_Inventory_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TStrpMItm_Database, Me.TStrpMItm_Add, Me.TStrpMItm_List, Me.TStrpMItm_Report, Me.TStrpMItm_Help})
            Me.MStrp_Inventory_Menu.Location = New System.Drawing.Point(0, 0)
            Me.MStrp_Inventory_Menu.Name = "MStrp_Inventory_Menu"
            Me.MStrp_Inventory_Menu.Size = New System.Drawing.Size(503, 24)
            Me.MStrp_Inventory_Menu.TabIndex = 0
            Me.MStrp_Inventory_Menu.Text = "MenuStrip1"
            '
            'TStrpMItm_Database
            '
            Me.TStrpMItm_Database.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TStrpMItm_Access, Me.TStrpMItm_MSSQL, Me.TStrpMItm_Exit})
            Me.TStrpMItm_Database.Image = CType(resources.GetObject("TStrpMItm_Database.Image"), System.Drawing.Image)
            Me.TStrpMItm_Database.Name = "TStrpMItm_Database"
            Me.TStrpMItm_Database.Size = New System.Drawing.Size(83, 20)
            Me.TStrpMItm_Database.Text = "Database"
            '
            'TStrpMItm_Access
            '
            Me.TStrpMItm_Access.Image = CType(resources.GetObject("TStrpMItm_Access.Image"), System.Drawing.Image)
            Me.TStrpMItm_Access.Name = "TStrpMItm_Access"
            Me.TStrpMItm_Access.Size = New System.Drawing.Size(115, 22)
            Me.TStrpMItm_Access.Text = "Access"
            '
            'TStrpMItm_MSSQL
            '
            Me.TStrpMItm_MSSQL.Image = CType(resources.GetObject("TStrpMItm_MSSQL.Image"), System.Drawing.Image)
            Me.TStrpMItm_MSSQL.Name = "TStrpMItm_MSSQL"
            Me.TStrpMItm_MSSQL.Size = New System.Drawing.Size(115, 22)
            Me.TStrpMItm_MSSQL.Text = "MS SQL"
            '
            'TStrpMItm_Exit
            '
            Me.TStrpMItm_Exit.Image = CType(resources.GetObject("TStrpMItm_Exit.Image"), System.Drawing.Image)
            Me.TStrpMItm_Exit.Name = "TStrpMItm_Exit"
            Me.TStrpMItm_Exit.Size = New System.Drawing.Size(115, 22)
            Me.TStrpMItm_Exit.Text = "Exit"
            '
            'TStrpMItm_Add
            '
            Me.TStrpMItm_Add.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TStrpMItm_Add_Business, Me.TStrpMItm_Add_CashBalance, Me.TStrpMItm_Add_CashMemo, Me.TStrpMItm_Add_Catagores, Me.TStrpMItm_Add_Login, Me.TStrpMItm_Add_ProductBarcodes, Me.TStrpMItm_Add_Products, Me.TStrpMItm_Add_Profiles, Me.TStrpMItm_Add_PurchaseBarcodes, Me.TStrpMItm_Add_PurchaseDetails, Me.TStrpMItm_Add_Purchases, Me.TStrpMItm_Add_Reletionships, Me.TStrpMItm_Add_SaleBarcodes, Me.TStrpMItm_Add_SaleDetails, Me.TStrpMItm_Add_Sales, Me.TStrpMItm_Add_Units})
            Me.TStrpMItm_Add.Image = CType(resources.GetObject("TStrpMItm_Add.Image"), System.Drawing.Image)
            Me.TStrpMItm_Add.Name = "TStrpMItm_Add"
            Me.TStrpMItm_Add.Size = New System.Drawing.Size(57, 20)
            Me.TStrpMItm_Add.Text = "Add"
            '
            'TStrpMItm_Add_Business
            '
            Me.TStrpMItm_Add_Business.Image = CType(resources.GetObject("TStrpMItm_Add_Business.Image"), System.Drawing.Image)
            Me.TStrpMItm_Add_Business.Name = "TStrpMItm_Add_Business"
            Me.TStrpMItm_Add_Business.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_Add_Business.Text = "Business"
            '
            'TStrpMItm_Add_CashBalance
            '
            Me.TStrpMItm_Add_CashBalance.Image = CType(resources.GetObject("TStrpMItm_Add_CashBalance.Image"), System.Drawing.Image)
            Me.TStrpMItm_Add_CashBalance.Name = "TStrpMItm_Add_CashBalance"
            Me.TStrpMItm_Add_CashBalance.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_Add_CashBalance.Text = "CashBalance"
            '
            'TStrpMItm_Add_CashMemo
            '
            Me.TStrpMItm_Add_CashMemo.Image = CType(resources.GetObject("TStrpMItm_Add_CashMemo.Image"), System.Drawing.Image)
            Me.TStrpMItm_Add_CashMemo.Name = "TStrpMItm_Add_CashMemo"
            Me.TStrpMItm_Add_CashMemo.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_Add_CashMemo.Text = "CashMemo"
            '
            'TStrpMItm_Add_Catagores
            '
            Me.TStrpMItm_Add_Catagores.Image = CType(resources.GetObject("TStrpMItm_Add_Catagores.Image"), System.Drawing.Image)
            Me.TStrpMItm_Add_Catagores.Name = "TStrpMItm_Add_Catagores"
            Me.TStrpMItm_Add_Catagores.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_Add_Catagores.Text = "Catagores"
            '
            'TStrpMItm_Add_Login
            '
            Me.TStrpMItm_Add_Login.Image = CType(resources.GetObject("TStrpMItm_Add_Login.Image"), System.Drawing.Image)
            Me.TStrpMItm_Add_Login.Name = "TStrpMItm_Add_Login"
            Me.TStrpMItm_Add_Login.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_Add_Login.Text = "Login"
            '
            'TStrpMItm_Add_ProductBarcodes
            '
            Me.TStrpMItm_Add_ProductBarcodes.Image = CType(resources.GetObject("TStrpMItm_Add_ProductBarcodes.Image"), System.Drawing.Image)
            Me.TStrpMItm_Add_ProductBarcodes.Name = "TStrpMItm_Add_ProductBarcodes"
            Me.TStrpMItm_Add_ProductBarcodes.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_Add_ProductBarcodes.Text = "ProductBarcodes"
            '
            'TStrpMItm_Add_Products
            '
            Me.TStrpMItm_Add_Products.Image = CType(resources.GetObject("TStrpMItm_Add_Products.Image"), System.Drawing.Image)
            Me.TStrpMItm_Add_Products.Name = "TStrpMItm_Add_Products"
            Me.TStrpMItm_Add_Products.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_Add_Products.Text = "Products"
            '
            'TStrpMItm_Add_Profiles
            '
            Me.TStrpMItm_Add_Profiles.Image = CType(resources.GetObject("TStrpMItm_Add_Profiles.Image"), System.Drawing.Image)
            Me.TStrpMItm_Add_Profiles.Name = "TStrpMItm_Add_Profiles"
            Me.TStrpMItm_Add_Profiles.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_Add_Profiles.Text = "Profiles"
            '
            'TStrpMItm_Add_PurchaseBarcodes
            '
            Me.TStrpMItm_Add_PurchaseBarcodes.Image = CType(resources.GetObject("TStrpMItm_Add_PurchaseBarcodes.Image"), System.Drawing.Image)
            Me.TStrpMItm_Add_PurchaseBarcodes.Name = "TStrpMItm_Add_PurchaseBarcodes"
            Me.TStrpMItm_Add_PurchaseBarcodes.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_Add_PurchaseBarcodes.Text = "PurchaseBarcodes"
            '
            'TStrpMItm_Add_PurchaseDetails
            '
            Me.TStrpMItm_Add_PurchaseDetails.Image = CType(resources.GetObject("TStrpMItm_Add_PurchaseDetails.Image"), System.Drawing.Image)
            Me.TStrpMItm_Add_PurchaseDetails.Name = "TStrpMItm_Add_PurchaseDetails"
            Me.TStrpMItm_Add_PurchaseDetails.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_Add_PurchaseDetails.Text = "PurchaseDetails"
            '
            'TStrpMItm_Add_Purchases
            '
            Me.TStrpMItm_Add_Purchases.Image = CType(resources.GetObject("TStrpMItm_Add_Purchases.Image"), System.Drawing.Image)
            Me.TStrpMItm_Add_Purchases.Name = "TStrpMItm_Add_Purchases"
            Me.TStrpMItm_Add_Purchases.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_Add_Purchases.Text = "Purchases"
            '
            'TStrpMItm_Add_Reletionships
            '
            Me.TStrpMItm_Add_Reletionships.Image = CType(resources.GetObject("TStrpMItm_Add_Reletionships.Image"), System.Drawing.Image)
            Me.TStrpMItm_Add_Reletionships.Name = "TStrpMItm_Add_Reletionships"
            Me.TStrpMItm_Add_Reletionships.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_Add_Reletionships.Text = "Reletionships"
            '
            'TStrpMItm_Add_SaleBarcodes
            '
            Me.TStrpMItm_Add_SaleBarcodes.Image = CType(resources.GetObject("TStrpMItm_Add_SaleBarcodes.Image"), System.Drawing.Image)
            Me.TStrpMItm_Add_SaleBarcodes.Name = "TStrpMItm_Add_SaleBarcodes"
            Me.TStrpMItm_Add_SaleBarcodes.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_Add_SaleBarcodes.Text = "SaleBarcodes"
            '
            'TStrpMItm_Add_SaleDetails
            '
            Me.TStrpMItm_Add_SaleDetails.Image = CType(resources.GetObject("TStrpMItm_Add_SaleDetails.Image"), System.Drawing.Image)
            Me.TStrpMItm_Add_SaleDetails.Name = "TStrpMItm_Add_SaleDetails"
            Me.TStrpMItm_Add_SaleDetails.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_Add_SaleDetails.Text = "SaleDetails"
            '
            'TStrpMItm_Add_Sales
            '
            Me.TStrpMItm_Add_Sales.Image = CType(resources.GetObject("TStrpMItm_Add_Sales.Image"), System.Drawing.Image)
            Me.TStrpMItm_Add_Sales.Name = "TStrpMItm_Add_Sales"
            Me.TStrpMItm_Add_Sales.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_Add_Sales.Text = "Sales"
            '
            'TStrpMItm_Add_Units
            '
            Me.TStrpMItm_Add_Units.Image = CType(resources.GetObject("TStrpMItm_Add_Units.Image"), System.Drawing.Image)
            Me.TStrpMItm_Add_Units.Name = "TStrpMItm_Add_Units"
            Me.TStrpMItm_Add_Units.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_Add_Units.Text = "Units"
            '
            'TStrpMItm_List
            '
            Me.TStrpMItm_List.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TStrpMItm_List_Business, Me.TStrpMItm_List_CashBalance, Me.TStrpMItm_List_CashMemo, Me.TStrpMItm_List_Catagores, Me.TStrpMItm_List_Login, Me.TStrpMItm_List_ProductBarcodes, Me.TStrpMItm_List_Products, Me.TStrpMItm_List_Profiles, Me.TStrpMItm_List_PurchaseBarcodes, Me.TStrpMItm_List_PurchaseDetails, Me.TStrpMItm_List_Purchases, Me.TStrpMItm_List_Reletionships, Me.TStrpMItm_List_SaleBarcodes, Me.TStrpMItm_List_SaleDetails, Me.TStrpMItm_List_Sales, Me.TStrpMItm_List_Units})
            Me.TStrpMItm_List.Image = CType(resources.GetObject("TStrpMItm_List.Image"), System.Drawing.Image)
            Me.TStrpMItm_List.Name = "TStrpMItm_List"
            Me.TStrpMItm_List.Size = New System.Drawing.Size(53, 20)
            Me.TStrpMItm_List.Text = "List"
            '
            'TStrpMItm_List_Business
            '
            Me.TStrpMItm_List_Business.Image = CType(resources.GetObject("TStrpMItm_List_Business.Image"), System.Drawing.Image)
            Me.TStrpMItm_List_Business.Name = "TStrpMItm_List_Business"
            Me.TStrpMItm_List_Business.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_List_Business.Text = "Business"
            '
            'TStrpMItm_List_CashBalance
            '
            Me.TStrpMItm_List_CashBalance.Image = CType(resources.GetObject("TStrpMItm_List_CashBalance.Image"), System.Drawing.Image)
            Me.TStrpMItm_List_CashBalance.Name = "TStrpMItm_List_CashBalance"
            Me.TStrpMItm_List_CashBalance.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_List_CashBalance.Text = "CashBalance"
            '
            'TStrpMItm_List_CashMemo
            '
            Me.TStrpMItm_List_CashMemo.Image = CType(resources.GetObject("TStrpMItm_List_CashMemo.Image"), System.Drawing.Image)
            Me.TStrpMItm_List_CashMemo.Name = "TStrpMItm_List_CashMemo"
            Me.TStrpMItm_List_CashMemo.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_List_CashMemo.Text = "CashMemo"
            '
            'TStrpMItm_List_Catagores
            '
            Me.TStrpMItm_List_Catagores.Image = CType(resources.GetObject("TStrpMItm_List_Catagores.Image"), System.Drawing.Image)
            Me.TStrpMItm_List_Catagores.Name = "TStrpMItm_List_Catagores"
            Me.TStrpMItm_List_Catagores.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_List_Catagores.Text = "Catagores"
            '
            'TStrpMItm_List_Login
            '
            Me.TStrpMItm_List_Login.Image = CType(resources.GetObject("TStrpMItm_List_Login.Image"), System.Drawing.Image)
            Me.TStrpMItm_List_Login.Name = "TStrpMItm_List_Login"
            Me.TStrpMItm_List_Login.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_List_Login.Text = "Login"
            '
            'TStrpMItm_List_ProductBarcodes
            '
            Me.TStrpMItm_List_ProductBarcodes.Image = CType(resources.GetObject("TStrpMItm_List_ProductBarcodes.Image"), System.Drawing.Image)
            Me.TStrpMItm_List_ProductBarcodes.Name = "TStrpMItm_List_ProductBarcodes"
            Me.TStrpMItm_List_ProductBarcodes.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_List_ProductBarcodes.Text = "ProductBarcodes"
            '
            'TStrpMItm_List_Products
            '
            Me.TStrpMItm_List_Products.Image = CType(resources.GetObject("TStrpMItm_List_Products.Image"), System.Drawing.Image)
            Me.TStrpMItm_List_Products.Name = "TStrpMItm_List_Products"
            Me.TStrpMItm_List_Products.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_List_Products.Text = "Products"
            '
            'TStrpMItm_List_Profiles
            '
            Me.TStrpMItm_List_Profiles.Image = CType(resources.GetObject("TStrpMItm_List_Profiles.Image"), System.Drawing.Image)
            Me.TStrpMItm_List_Profiles.Name = "TStrpMItm_List_Profiles"
            Me.TStrpMItm_List_Profiles.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_List_Profiles.Text = "Profiles"
            '
            'TStrpMItm_List_PurchaseBarcodes
            '
            Me.TStrpMItm_List_PurchaseBarcodes.Image = CType(resources.GetObject("TStrpMItm_List_PurchaseBarcodes.Image"), System.Drawing.Image)
            Me.TStrpMItm_List_PurchaseBarcodes.Name = "TStrpMItm_List_PurchaseBarcodes"
            Me.TStrpMItm_List_PurchaseBarcodes.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_List_PurchaseBarcodes.Text = "PurchaseBarcodes"
            '
            'TStrpMItm_List_PurchaseDetails
            '
            Me.TStrpMItm_List_PurchaseDetails.Image = CType(resources.GetObject("TStrpMItm_List_PurchaseDetails.Image"), System.Drawing.Image)
            Me.TStrpMItm_List_PurchaseDetails.Name = "TStrpMItm_List_PurchaseDetails"
            Me.TStrpMItm_List_PurchaseDetails.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_List_PurchaseDetails.Text = "PurchaseDetails"
            '
            'TStrpMItm_List_Purchases
            '
            Me.TStrpMItm_List_Purchases.Image = CType(resources.GetObject("TStrpMItm_List_Purchases.Image"), System.Drawing.Image)
            Me.TStrpMItm_List_Purchases.Name = "TStrpMItm_List_Purchases"
            Me.TStrpMItm_List_Purchases.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_List_Purchases.Text = "Purchases"
            '
            'TStrpMItm_List_Reletionships
            '
            Me.TStrpMItm_List_Reletionships.Image = CType(resources.GetObject("TStrpMItm_List_Reletionships.Image"), System.Drawing.Image)
            Me.TStrpMItm_List_Reletionships.Name = "TStrpMItm_List_Reletionships"
            Me.TStrpMItm_List_Reletionships.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_List_Reletionships.Text = "Reletionships"
            '
            'TStrpMItm_List_SaleBarcodes
            '
            Me.TStrpMItm_List_SaleBarcodes.Image = CType(resources.GetObject("TStrpMItm_List_SaleBarcodes.Image"), System.Drawing.Image)
            Me.TStrpMItm_List_SaleBarcodes.Name = "TStrpMItm_List_SaleBarcodes"
            Me.TStrpMItm_List_SaleBarcodes.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_List_SaleBarcodes.Text = "SaleBarcodes"
            '
            'TStrpMItm_List_SaleDetails
            '
            Me.TStrpMItm_List_SaleDetails.Image = CType(resources.GetObject("TStrpMItm_List_SaleDetails.Image"), System.Drawing.Image)
            Me.TStrpMItm_List_SaleDetails.Name = "TStrpMItm_List_SaleDetails"
            Me.TStrpMItm_List_SaleDetails.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_List_SaleDetails.Text = "SaleDetails"
            '
            'TStrpMItm_List_Sales
            '
            Me.TStrpMItm_List_Sales.Image = CType(resources.GetObject("TStrpMItm_List_Sales.Image"), System.Drawing.Image)
            Me.TStrpMItm_List_Sales.Name = "TStrpMItm_List_Sales"
            Me.TStrpMItm_List_Sales.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_List_Sales.Text = "Sales"
            '
            'TStrpMItm_List_Units
            '
            Me.TStrpMItm_List_Units.Image = CType(resources.GetObject("TStrpMItm_List_Units.Image"), System.Drawing.Image)
            Me.TStrpMItm_List_Units.Name = "TStrpMItm_List_Units"
            Me.TStrpMItm_List_Units.Size = New System.Drawing.Size(170, 22)
            Me.TStrpMItm_List_Units.Text = "Units"
            '
            'TStrpMItm_Report
            '
            Me.TStrpMItm_Report.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TStrpMItm_OpenCalculator, Me.TStrpMItm_SaleEntry, Me.TStrpMItm_PruchaseEntry})
            Me.TStrpMItm_Report.Image = CType(resources.GetObject("TStrpMItm_Report.Image"), System.Drawing.Image)
            Me.TStrpMItm_Report.Name = "TStrpMItm_Report"
            Me.TStrpMItm_Report.Size = New System.Drawing.Size(70, 20)
            Me.TStrpMItm_Report.Text = "Report"
            '
            'TStrpMItm_OpenCalculator
            '
            Me.TStrpMItm_OpenCalculator.Image = CType(resources.GetObject("TStrpMItm_OpenCalculator.Image"), System.Drawing.Image)
            Me.TStrpMItm_OpenCalculator.Name = "TStrpMItm_OpenCalculator"
            Me.TStrpMItm_OpenCalculator.Size = New System.Drawing.Size(180, 22)
            Me.TStrpMItm_OpenCalculator.Text = "Open Calculator"
            '
            'TStrpMItm_SaleEntry
            '
            Me.TStrpMItm_SaleEntry.Image = CType(resources.GetObject("TStrpMItm_SaleEntry.Image"), System.Drawing.Image)
            Me.TStrpMItm_SaleEntry.Name = "TStrpMItm_SaleEntry"
            Me.TStrpMItm_SaleEntry.Size = New System.Drawing.Size(180, 22)
            Me.TStrpMItm_SaleEntry.Text = "Sale Entry"
            '
            'TStrpMItm_PruchaseEntry
            '
            Me.TStrpMItm_PruchaseEntry.Image = CType(resources.GetObject("TStrpMItm_PruchaseEntry.Image"), System.Drawing.Image)
            Me.TStrpMItm_PruchaseEntry.Name = "TStrpMItm_PruchaseEntry"
            Me.TStrpMItm_PruchaseEntry.Size = New System.Drawing.Size(180, 22)
            Me.TStrpMItm_PruchaseEntry.Text = "Pruchase Entry"
            '
            'TStrpMItm_Help
            '
            Me.TStrpMItm_Help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TStrpMItm_Helps, Me.TStrpMItm_Register, Me.TStrpMItm_Version, Me.TStrpMItm_About})
            Me.TStrpMItm_Help.Image = CType(resources.GetObject("TStrpMItm_Help.Image"), System.Drawing.Image)
            Me.TStrpMItm_Help.Name = "TStrpMItm_Help"
            Me.TStrpMItm_Help.Size = New System.Drawing.Size(60, 20)
            Me.TStrpMItm_Help.Text = "Help"
            '
            'TStrpMItm_Helps
            '
            Me.TStrpMItm_Helps.Image = CType(resources.GetObject("TStrpMItm_Helps.Image"), System.Drawing.Image)
            Me.TStrpMItm_Helps.Name = "TStrpMItm_Helps"
            Me.TStrpMItm_Helps.Size = New System.Drawing.Size(116, 22)
            Me.TStrpMItm_Helps.Text = "Help"
            '
            'TStrpMItm_Register
            '
            Me.TStrpMItm_Register.Image = CType(resources.GetObject("TStrpMItm_Register.Image"), System.Drawing.Image)
            Me.TStrpMItm_Register.Name = "TStrpMItm_Register"
            Me.TStrpMItm_Register.Size = New System.Drawing.Size(116, 22)
            Me.TStrpMItm_Register.Text = "Register"
            '
            'TStrpMItm_Version
            '
            Me.TStrpMItm_Version.Image = CType(resources.GetObject("TStrpMItm_Version.Image"), System.Drawing.Image)
            Me.TStrpMItm_Version.Name = "TStrpMItm_Version"
            Me.TStrpMItm_Version.Size = New System.Drawing.Size(116, 22)
            Me.TStrpMItm_Version.Text = "Version"
            '
            'TStrpMItm_About
            '
            Me.TStrpMItm_About.Image = CType(resources.GetObject("TStrpMItm_About.Image"), System.Drawing.Image)
            Me.TStrpMItm_About.Name = "TStrpMItm_About"
            Me.TStrpMItm_About.Size = New System.Drawing.Size(116, 22)
            Me.TStrpMItm_About.Text = "About"
            '
            'Pnl_MainScreen
            '
            Me.Pnl_MainScreen.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Pnl_MainScreen.Location = New System.Drawing.Point(0, 24)
            Me.Pnl_MainScreen.Name = "Pnl_MainScreen"
            Me.Pnl_MainScreen.Size = New System.Drawing.Size(503, 278)
            Me.Pnl_MainScreen.TabIndex = 1
            '
            'Broadcast
            '
            Me.Broadcast.BackColor = System.Drawing.Color.Teal
            Me.Broadcast.BackgroundImage = CType(resources.GetObject("Broadcast.BackgroundImage"), System.Drawing.Image)
            Me.Broadcast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Broadcast.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Broadcast.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Broadcast.ForeColor = System.Drawing.Color.White
            Me.Broadcast.Location = New System.Drawing.Point(0, 302)
            Me.Broadcast.Message = "Message"
            Me.Broadcast.Name = "Broadcast"
            Me.Broadcast.Size = New System.Drawing.Size(1360, 30)
            Me.Broadcast.Start = True
            Me.Broadcast.TabIndex = 2
            '
            'MenuStyle
            '
            Me.Controls.Add(Me.Pnl_MainScreen)
            Me.Controls.Add(Me.Broadcast)
            Me.Controls.Add(Me.MStrp_Inventory_Menu)
            Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "MenuStyle"
            Me.Size = New System.Drawing.Size(503, 332)
            Me.MStrp_Inventory_Menu.ResumeLayout(False)
            Me.MStrp_Inventory_Menu.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region
#Region " Event Proerty "
        Private _LoadUserControl As String
        Public Property LoadUserControl As String
            Get
                Return _LoadUserControl
            End Get
            Set(value As String)
                _LoadUserControl = value
                ucDataGridView = Nothing
                Select Case _LoadUserControl
                    Case "TStrpMItm_Access"
                        MStrp_Inventory_Menu.Enabled = False
                        If ucAccessLogin Is Nothing Then ucAccessLogin = New UIForm.AccessLogin
                        clsFeature.PanelView(ucAccessLogin, False, Pnl_MainScreen)
                        Broadcast.Message = "Login through username admin and password admin. For database setup click SETTING"
                    Case "TStrpMItm_MSSQL"
                        MStrp_Inventory_Menu.Enabled = False
                        If ucSQLLogin Is Nothing Then ucSQLLogin = New UIForm.SQLLogin
                        clsFeature.PanelView(ucSQLLogin, False, Pnl_MainScreen)
                        Broadcast.Message = "Create and save ms sql database then login"
                    Case "TStrpMItm_Exit"
                        Application.Exit()
                    Case "TStrpMItm_Helps"
                        Dim _HelpFile As String = String.Empty
                        _HelpFile = Application.StartupPath & "\Help\Index.html"
                        If My.Computer.FileSystem.FileExists(_HelpFile) = True Then
                            Process.Start(_HelpFile)
                        Else
                            MessageBox.Show("Help file not found re-install fixed the error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Case "TStrpMItm_Register"
                        If ucRegister Is Nothing Then ucRegister = New UIForm.Register
                        clsFeature.PanelView(ucRegister, False, Pnl_MainScreen)
                        Broadcast.Message = "This application is running on trails mode please purchase to continue..."
                    Case "TStrpMItm_Version"
                        If ucVersion Is Nothing Then ucVersion = New UIForm.Version
                        clsFeature.PanelView(ucVersion, False, Pnl_MainScreen)
                        Broadcast.Message = "This application is build by PRASENJIT HALDER and POWER BY HALDER PRIVATE LIMITED"
                    Case "TStrpMItm_About"
                        If ucAbout Is Nothing Then ucAbout = New UIForm.About
                        clsFeature.PanelView(ucAbout, False, Pnl_MainScreen)
                        Broadcast.Message = "This application can run through access and ms sql sever"
                    Case "TStrpMItm_Add_Business"
                        If ucBusiness Is Nothing Then ucBusiness = New UIForm.Business
                        clsFeature.PanelView(ucBusiness, False, Pnl_MainScreen)
                        Broadcast.Message = "Add business details information"
                    Case "TStrpMItm_Add_CashBalance"
                        If ucCashBalance Is Nothing Then ucCashBalance = New UIForm.Cashbalance
                        clsFeature.PanelView(ucCashBalance, False, Pnl_MainScreen)
                    Case "TStrpMItm_Add_CashMemo"
                        If ucCashMemo Is Nothing Then ucCashMemo = New UIForm.Cashmemo
                        clsFeature.PanelView(ucCashMemo, False, Pnl_MainScreen)
                    Case "TStrpMItm_Add_Catagores"
                        If ucCatagores Is Nothing Then ucCatagores = New UIForm.Catagores
                        clsFeature.PanelView(ucCatagores, False, Pnl_MainScreen)
                    Case "TStrpMItm_Add_Login"
                        If ucLogin Is Nothing Then ucLogin = New UIForm.Login
                        clsFeature.PanelView(ucLogin, False, Pnl_MainScreen)
                        Broadcast.Message = "Create user for login"
                    Case "TStrpMItm_Add_ProductBarcodes"
                        If ucProductBarcodes Is Nothing Then ucProductBarcodes = New UIForm.Productbarcodes
                        clsFeature.PanelView(ucProductBarcodes, False, Pnl_MainScreen)
                    Case "TStrpMItm_Add_Products"
                        If ucProducts Is Nothing Then ucProducts = New UIForm.Products
                        clsFeature.PanelView(ucProducts, False, Pnl_MainScreen)
                    Case "TStrpMItm_Add_Profiles"
                        If ucProfiles Is Nothing Then ucProfiles = New UIForm.Profiles
                        clsFeature.PanelView(ucProfiles, False, Pnl_MainScreen)
                    Case "TStrpMItm_Add_PurchaseBarcodes"
                        If ucPurchaseBarcodes Is Nothing Then ucPurchaseBarcodes = New UIForm.Purchasebarcodes
                        clsFeature.PanelView(ucPurchaseBarcodes, False, Pnl_MainScreen)
                    Case "TStrpMItm_Add_PurchaseDetails"
                        If ucPurchaseDetails Is Nothing Then ucPurchaseDetails = New UIForm.Purchasedetails
                        clsFeature.PanelView(ucPurchaseDetails, False, Pnl_MainScreen)
                    Case "TStrpMItm_Add_Purchases"
                        If ucPurchases Is Nothing Then ucPurchases = New UIForm.Purchases
                        clsFeature.PanelView(ucPurchases, False, Pnl_MainScreen)
                    Case "TStrpMItm_Add_Reletionships"
                        If ucReletionships Is Nothing Then ucReletionships = New UIForm.Reletionships
                        clsFeature.PanelView(ucReletionships, False, Pnl_MainScreen)
                    Case "TStrpMItm_Add_SaleBarcodes"
                        If ucSaleBarcodes Is Nothing Then ucSaleBarcodes = New UIForm.Salebarcodes
                        clsFeature.PanelView(ucSaleBarcodes, False, Pnl_MainScreen)
                    Case "TStrpMItm_Add_SaleDetails"
                        If ucSaleDetails Is Nothing Then ucSaleDetails = New UIForm.Saledetails
                        clsFeature.PanelView(ucSaleDetails, False, Pnl_MainScreen)
                    Case "TStrpMItm_Add_Sales"
                        If ucSales Is Nothing Then ucSales = New UIForm.Sales
                        clsFeature.PanelView(ucSales, False, Pnl_MainScreen)
                    Case "TStrpMItm_Add_Units"
                        If ucUnits Is Nothing Then ucUnits = New UIForm.Units
                        clsFeature.PanelView(ucUnits, False, Pnl_MainScreen)
                    Case "TStrpMItm_List_Business"
                        If ucDataGridView Is Nothing Then ucDataGridView = New UIForm.DataGridView With {.TableName = "Business"}
                        clsFeature.PanelView(ucDataGridView, True, Pnl_MainScreen)
                    Case "TStrpMItm_List_CashBalance"
                        If ucDataGridView Is Nothing Then ucDataGridView = New UIForm.DataGridView With {.TableName = "CashBalance"}
                        clsFeature.PanelView(ucDataGridView, True, Pnl_MainScreen)
                    Case "TStrpMItm_List_CashMemo"
                        If ucDataGridView Is Nothing Then ucDataGridView = New UIForm.DataGridView With {.TableName = "CashMemo"}
                        clsFeature.PanelView(ucDataGridView, True, Pnl_MainScreen)
                    Case "TStrpMItm_List_Catagores"
                        If ucDataGridView Is Nothing Then ucDataGridView = New UIForm.DataGridView With {.TableName = "Catagores"}
                        clsFeature.PanelView(ucDataGridView, True, Pnl_MainScreen)
                    Case "TStrpMItm_List_Login"
                        If ucDataGridView Is Nothing Then ucDataGridView = New UIForm.DataGridView With {.TableName = "Login"}
                        clsFeature.PanelView(ucDataGridView, True, Pnl_MainScreen)
                    Case "TStrpMItm_List_ProductBarcodes"
                        If ucDataGridView Is Nothing Then ucDataGridView = New UIForm.DataGridView With {.TableName = "ProductBarcodes"}
                        clsFeature.PanelView(ucDataGridView, True, Pnl_MainScreen)
                    Case "TStrpMItm_List_Products"
                        If ucDataGridView Is Nothing Then ucDataGridView = New UIForm.DataGridView With {.TableName = "Products"}
                        clsFeature.PanelView(ucDataGridView, True, Pnl_MainScreen)
                    Case "TStrpMItm_List_Profiles"
                        If ucDataGridView Is Nothing Then ucDataGridView = New UIForm.DataGridView With {.TableName = "Profiles"}
                        clsFeature.PanelView(ucDataGridView, True, Pnl_MainScreen)
                    Case "TStrpMItm_List_PurchaseBarcodes"
                        If ucDataGridView Is Nothing Then ucDataGridView = New UIForm.DataGridView With {.TableName = "PurchaseBarcodes"}
                        clsFeature.PanelView(ucDataGridView, True, Pnl_MainScreen)
                    Case "TStrpMItm_List_PurchaseDetails"
                        If ucDataGridView Is Nothing Then ucDataGridView = New UIForm.DataGridView With {.TableName = "PurchaseDetails"}
                        clsFeature.PanelView(ucDataGridView, True, Pnl_MainScreen)
                    Case "TStrpMItm_List_Purchases"
                        If ucDataGridView Is Nothing Then ucDataGridView = New UIForm.DataGridView With {.TableName = "Purchases"}
                        clsFeature.PanelView(ucDataGridView, True, Pnl_MainScreen)
                    Case "TStrpMItm_List_Reletionships"
                        If ucDataGridView Is Nothing Then ucDataGridView = New UIForm.DataGridView With {.TableName = "Reletionships"}
                        clsFeature.PanelView(ucDataGridView, True, Pnl_MainScreen)
                    Case "TStrpMItm_List_SaleBarcodes"
                        If ucDataGridView Is Nothing Then ucDataGridView = New UIForm.DataGridView With {.TableName = "SaleBarcodes"}
                        clsFeature.PanelView(ucDataGridView, True, Pnl_MainScreen)
                    Case "TStrpMItm_List_SaleDetails"
                        If ucDataGridView Is Nothing Then ucDataGridView = New UIForm.DataGridView With {.TableName = "SaleDetails"}
                        clsFeature.PanelView(ucDataGridView, True, Pnl_MainScreen)
                    Case "TStrpMItm_List_Sales"
                        If ucDataGridView Is Nothing Then ucDataGridView = New UIForm.DataGridView With {.TableName = "Sales"}
                        clsFeature.PanelView(ucDataGridView, True, Pnl_MainScreen)
                    Case "TStrpMItm_List_Units"
                        If ucDataGridView Is Nothing Then ucDataGridView = New UIForm.DataGridView With {.TableName = "Units"}
                        clsFeature.PanelView(ucDataGridView, True, Pnl_MainScreen)
                End Select
            End Set
        End Property
        Private Sub TStrpMItm_Access_Click(sender As Object, e As EventArgs) Handles TStrpMItm_Access.Click, TStrpMItm_MSSQL.Click, TStrpMItm_Exit.Click,
        TStrpMItm_Add_Business.Click, TStrpMItm_Add_CashBalance.Click, TStrpMItm_Add_CashMemo.Click, TStrpMItm_Add_Catagores.Click, TStrpMItm_Add_Login.Click, TStrpMItm_Add_ProductBarcodes.Click, TStrpMItm_Add_Products.Click, TStrpMItm_Add_Profiles.Click, TStrpMItm_Add_PurchaseBarcodes.Click, TStrpMItm_Add_PurchaseDetails.Click, TStrpMItm_Add_Purchases.Click, TStrpMItm_Add_Reletionships.Click, TStrpMItm_Add_SaleBarcodes.Click, TStrpMItm_Add_SaleDetails.Click, TStrpMItm_Add_Sales.Click, TStrpMItm_Add_Units.Click,
        TStrpMItm_List_Business.Click, TStrpMItm_List_CashBalance.Click, TStrpMItm_List_CashMemo.Click, TStrpMItm_List_Catagores.Click, TStrpMItm_List_Login.Click, TStrpMItm_List_ProductBarcodes.Click, TStrpMItm_List_Products.Click, TStrpMItm_List_Profiles.Click, TStrpMItm_List_PurchaseBarcodes.Click, TStrpMItm_List_PurchaseDetails.Click, TStrpMItm_List_Purchases.Click, TStrpMItm_List_Reletionships.Click, TStrpMItm_List_SaleBarcodes.Click, TStrpMItm_List_SaleDetails.Click, TStrpMItm_List_Sales.Click, TStrpMItm_List_Units.Click,
        TStrpMItm_Helps.Click, TStrpMItm_Register.Click, TStrpMItm_Version.Click, TStrpMItm_About.Click
            LoadUserControl = sender.Name
            MainForm.Text = My.Application.Info.ProductName & " - {" & sender.Name.Replace("TStrpMItm_", "").Replace("_", " ") & "}"
        End Sub
        Private Sub MenuStyle_Resize(sender As Object, e As EventArgs) Handles Me.Resize
            LoadUserControl = LoadUserControl
        End Sub
        Private Sub MenuStyle_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
            ucMenuStyle = Nothing
            frmMenuStyle = Nothing
        End Sub
        Private Sub MenuStyle_Load(sender As Object, e As EventArgs) Handles Me.Load
            Broadcast.Start = True
        End Sub
        Private Sub TStrpMItm_PruchaseEntry_Click(sender As Object, e As EventArgs) Handles TStrpMItm_PruchaseEntry.Click
            MsgBox("Update demo next release")
        End Sub
        Private Sub TStrpMItm_SaleEntry_Click(sender As Object, e As EventArgs) Handles TStrpMItm_SaleEntry.Click
            MsgBox("Update demo next release")
        End Sub
        Private Sub TStrpMItm_OpenCalculator_Click(sender As Object, e As EventArgs) Handles TStrpMItm_OpenCalculator.Click
            MsgBox("Update demo next release")
        End Sub
#End Region
    End Class
End Namespace