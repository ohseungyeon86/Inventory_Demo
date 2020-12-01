Module ClassLink
    ' UICode declaration cls = class
    ' UICode.Database.ConnectionString.sqlConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatabasePath & ";Persist Security Info=True;User ID=" & Username & ";Jet OLEDB:Database Password=" & Password ' direct cast
    Public clsConnectionString As New UICode.Database.ConnectionString
    Public clsRegistration As New UICode.Registration
    Public clsEncryptDecrypt As New UICode.EncryptDecrypt
    '  Public clsPanelDrag As New UICode.PanelDrag
    Public clsFeature As New UICode.Feature
    '  Public clsFontSetup As New UICode.FontSetup
    '  Public clsComponentsBitmap As New UICode.ComponentsBitmap
    Public clsBoundControls As New UICode.Database.BoundControls
    Public clsRelationshipTable As New UICode.Database.RelationshipTable
    Public clsLogin As New UICode.Database.Inventory.Login
    Public clsBusiness As New UICode.Database.Inventory.Business
    Public clsUnits As New UICode.Database.Inventory.Units
    Public clsCatagores As New UICode.Database.Inventory.Catagores
    Public clsProducts As New UICode.Database.Inventory.Products
    Public clsProductBarcodes As New UICode.Database.Inventory.ProductBarcodes
    Public clsReletionships As New UICode.Database.Inventory.Reletionships
    Public clsProfiles As New UICode.Database.Inventory.Profiles
    Public clsPurchases As New UICode.Database.Inventory.Purchases
    Public clsPurchaseDetails As New UICode.Database.Inventory.PurchaseDetails
    Public clsPurchaseBarcodes As New UICode.Database.Inventory.PurchaseBarcodes
    Public clsSales As New UICode.Database.Inventory.Sales
    Public clsSaleDetails As New UICode.Database.Inventory.SaleDetails
    Public clsSaleBarcodes As New UICode.Database.Inventory.SaleBarcodes
    Public clsCashBalance As New UICode.Database.Inventory.CashBalance
    Public clsCashMemo As New UICode.Database.Inventory.CashMemo
    ' UIForm declaration frm = Form / uc = UserControl
    Public frmVersion As UIForm.DialogBox
    Public ucVersion As UIForm.Version
    Public frmAbout As UIForm.DialogBox
    Public ucAbout As UIForm.About
    Public frmSearch As UIForm.DialogBox
    Public ucSearch As UIForm.Search
    Public frmRegister As UIForm.DialogBox
    Public ucRegister As UIForm.Register
    Public frmSQLSetting As UIForm.DialogBox
    Public ucSQLSetting As UIForm.SQLSetting
    Public frmSQLLogin As UIForm.DialogBox
    Public ucSQLLogin As UIForm.SQLLogin
    Public frmAccessSetting As UIForm.DialogBox
    Public ucAccessSetting As UIForm.AccessSetting
    Public frmAccessLogin As UIForm.DialogBox
    Public ucAccessLogin As UIForm.AccessLogin
    Public frmMenuStyle As UIForm.DialogBox
    Public ucMenuStyle As UIForm.MenuStyle
    Public frmDataGridView As UIForm.DialogBox
    Public ucDataGridView As UIForm.DataGridView
    Public frmLogin As UIForm.DialogBox
    Public ucLogin As UIForm.Login
    Public frmBusiness As UIForm.DialogBox
    Public ucBusiness As UIForm.Business
    Public frmUnits As UIForm.DialogBox
    Public ucUnits As UIForm.Units
    Public frmCatagores As UIForm.DialogBox
    Public ucCatagores As UIForm.Catagores
    Public frmProducts As UIForm.DialogBox
    Public ucProducts As UIForm.Products
    Public frmProductBarcodes As UIForm.DialogBox
    Public ucProductBarcodes As UIForm.Productbarcodes
    Public frmReletionships As UIForm.DialogBox
    Public ucReletionships As UIForm.Reletionships
    Public frmProfiles As UIForm.DialogBox
    Public ucProfiles As UIForm.Profiles
    Public frmPurchases As UIForm.DialogBox
    Public ucPurchases As UIForm.Purchases
    Public frmPurchaseDetails As UIForm.DialogBox
    Public ucPurchaseDetails As UIForm.Purchasedetails
    Public frmPurchaseBarcodes As UIForm.DialogBox
    Public ucPurchaseBarcodes As UIForm.Purchasebarcodes
    Public frmSales As UIForm.DialogBox
    Public ucSales As UIForm.Sales
    Public frmSaleDetails As UIForm.DialogBox
    Public ucSaleDetails As UIForm.Saledetails
    Public frmSaleBarcodes As UIForm.DialogBox
    Public ucSaleBarcodes As UIForm.Salebarcodes
    Public frmCashBalance As UIForm.DialogBox
    Public ucCashBalance As UIForm.Cashbalance
    Public frmCashMemo As UIForm.DialogBox
    Public ucCashMemo As UIForm.Cashmemo
End Module