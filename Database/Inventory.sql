/****** Object:Database [Inventory] Script Date: 30/12/2019 11:53:12 AM                                  ******/ 
/****** created by PRASENJIT HALDER EMAIL ID pro99der@gmail.com FROM INDIA      ******/ 
/****** Change the file size dependon SQL Server				******/ 
/****** SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB 		******/ 
/****** SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%			******/

USE [master]
GO

CREATE DATABASE [Inventory] ONPRIMARY
( NAME = N'Inventory', FILENAME = N'C:\Inventory.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
LOG ON
( NAME = N'Inventory_log', FILENAME = N'C:\Inventory_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [Inventory] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Inventory].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Inventory] SET ANSI_NULL_DEFAULT OFF
GO

ALTER DATABASE [Inventory] SET ANSI_NULLS OFF
GO

ALTER DATABASE [Inventory] SET ANSI_PADDING OFF
GO

ALTER DATABASE [Inventory] SET ANSI_WARNINGS OFF
GO

ALTER DATABASE [Inventory] SET ARITHABORT OFF
GO

ALTER DATABASE [Inventory] SET AUTO_CLOSE OFF
GO

ALTER DATABASE [Inventory] SET AUTO_CREATE_STATISTICS ON
GO

ALTER DATABASE [Inventory] SET AUTO_SHRINK OFF
GO

ALTER DATABASE [Inventory] SET AUTO_UPDATE_STATISTICS ON
GO

ALTER DATABASE [Inventory] SET CURSOR_CLOSE_ON_COMMIT OFF
GO

ALTER DATABASE [Inventory] SET CURSOR_DEFAULTGLOBAL
GO

ALTER DATABASE [Inventory] SET CONCAT_NULL_YIELDS_NULL OFF
GO

ALTER DATABASE [Inventory] SET NUMERIC_ROUNDABORT OFF
GO

ALTER DATABASE [Inventory] SET QUOTED_IDENTIFIER OFF
GO

ALTER DATABASE [Inventory] SET RECURSIVE_TRIGGERS OFF
GO

ALTER DATABASE [Inventory] SETDISABLE_BROKER
GO

ALTER DATABASE [Inventory] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO

ALTER DATABASE [Inventory] SET DATE_CORRELATION_OPTIMIZATION OFF
GO

ALTER DATABASE [Inventory] SET TRUSTWORTHY OFF
GO

ALTER DATABASE [Inventory] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO

ALTER DATABASE [Inventory] SET PARAMETERIZATION SIMPLE
GO

ALTER DATABASE [Inventory] SET READ_COMMITTED_SNAPSHOT OFF
GO

ALTER DATABASE [Inventory] SET HONOR_BROKER_PRIORITY OFF
GO

ALTER DATABASE [Inventory] SETREAD_WRITE
GO

ALTER DATABASE [Inventory] SET RECOVERY FULL
GO

ALTER DATABASE [Inventory] SETMULTI_USER
GO

ALTER DATABASE [Inventory] SET PAGE_VERIFY CHECKSUM 
GO

ALTER DATABASE [Inventory] SET DB_CHAINING OFF
GO

/****** Tables Script Start From Here   ******/
USE [Inventory]
GO

/****** Object:  Table [dbo].[Login]    Object Create Date: 2019/12/30 11:53:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Login](
        [Login_Id] [bigint] IDENTITY(1,1) NOT NULL,
        [Login_Name] nvarchar(30) NOT NULL,
        [Login_Password] nvarchar(50) NULL,
        [Login_Phone] nvarchar(10) NOT NULL,
        [Login_Mail] nvarchar(50) NULL,
        [Login_Permission] nvarchar(50) NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[Login_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Business]    Object Create Date: 2019/12/30 11:53:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Business](
        [Business_Id] [bigint] IDENTITY(1,1) NOT NULL,
        [Business_Name] nvarchar(30) NOT NULL,
        [Business_Phone] nvarchar(10) NOT NULL,
        [Business_Mail] nvarchar(50) NULL,
        [Business_GST_No] nvarchar(50) NULL,
        [Business_Pan_No] nvarchar(50) NULL,
        [Business_CGST] nvarchar(50) NULL,
        [Business_SGST] nvarchar(50) NULL,
        [Business_IGST] nvarchar(50) NULL,
        [Business_Tin] nvarchar(50) NULL,
        [Business_Bank_Account] nvarchar(50) NULL,
        [Business_Bill_No] nvarchar(50) NULL,
        [Business_Address] nvarchar(150) NULL,
 CONSTRAINT [PK_Business] PRIMARY KEY CLUSTERED 
(
	[Business_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Units]    Object Create Date: 2019/12/30 11:53:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Units](
        [Unit_Id] [bigint] IDENTITY(1,1) NOT NULL,
        [Unit_Name] nvarchar(30) NOT NULL,
        [Unit_Note] nvarchar(50) NULL,
 CONSTRAINT [PK_Units] PRIMARY KEY CLUSTERED 
(
	[Unit_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Catagores]    Object Create Date: 2019/12/30 11:53:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Catagores](
        [Category_Id] [bigint] IDENTITY(1,1) NOT NULL,
        [Category_Name] nvarchar(30) NOT NULL,
        [Category_Note] nvarchar(50) NULL,
 CONSTRAINT [PK_Catagores] PRIMARY KEY CLUSTERED 
(
	[Category_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Products]    Object Create Date: 2019/12/30 11:53:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
        [Product_Id] [bigint] IDENTITY(1,1) NOT NULL,
        [Category_Id] [bigint] NOT NULL,
        [Category_Name] nvarchar(30) NOT NULL,
        [Product_Name] nvarchar(30) NOT NULL,
        [Unit_Id] [bigint] NOT NULL,
        [Unit_Name] nvarchar(30) NOT NULL,
        [HSN_Code] nvarchar(50) NULL,
        [Product_Stock] nvarchar(50) NULL,
        [Product_Single_Amount] [money] NOT NULL,
        [Product_Note] nvarchar(50) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Product_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Catagores] FOREIGN KEY([Category_Id])
REFERENCES [dbo].[Catagores] ([Category_Id])
GO

ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Catagores]
GO

ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Units] FOREIGN KEY([Unit_Id])
REFERENCES [dbo].[Units] ([Unit_Id])
GO

ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Units]
GO

/****** Object:  Table [dbo].[ProductBarcodes]    Object Create Date: 2019/12/30 11:53:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProductBarcodes](
        [ProductBarcode_Id] [bigint] IDENTITY(1,1) NOT NULL,
        [PurchaseDetail_Id] [bigint] NOT NULL,
        [Product_Id] [bigint] NOT NULL,
        [ProductBarcode_Barcode] nvarchar(50) NULL,
        [ProductBarcode_Stock] nvarchar(50) NULL,
 CONSTRAINT [PK_ProductBarcodes] PRIMARY KEY CLUSTERED 
(
	[ProductBarcode_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ProductBarcodes]  WITH CHECK ADD  CONSTRAINT [FK_ProductBarcodes_PurchaseDetails] FOREIGN KEY([PurchaseDetail_Id])
REFERENCES [dbo].[PurchaseDetails] ([PurchaseDetail_Id])
GO

ALTER TABLE [dbo].[ProductBarcodes] CHECK CONSTRAINT [FK_ProductBarcodes_PurchaseDetails]
GO

ALTER TABLE [dbo].[ProductBarcodes]  WITH CHECK ADD  CONSTRAINT [FK_ProductBarcodes_Products] FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Products] ([Product_Id])
GO

ALTER TABLE [dbo].[ProductBarcodes] CHECK CONSTRAINT [FK_ProductBarcodes_Products]
GO

/****** Object:  Table [dbo].[Reletionships]    Object Create Date: 2019/12/30 11:53:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Reletionships](
        [Reletionship_Id] [bigint] IDENTITY(1,1) NOT NULL,
        [Reletionship_Name] nvarchar(30) NOT NULL,
        [Reletionship_Note] nvarchar(50) NULL,
 CONSTRAINT [PK_Reletionships] PRIMARY KEY CLUSTERED 
(
	[Reletionship_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Profiles]    Object Create Date: 2019/12/30 11:53:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Profiles](
        [Profile_Id] [bigint] IDENTITY(1,1) NOT NULL,
        [Profile_Name] nvarchar(30) NOT NULL,
        [Reletionship_Id] [bigint] NOT NULL,
        [Reletionship_Name] nvarchar(30) NOT NULL,
        [Profile_Phone] nvarchar(10) NOT NULL,
        [Profile_Mail] nvarchar(50) NULL,
        [Profile_GST_No] nvarchar(50) NULL,
        [Profile_PAN_No] nvarchar(50) NULL,
        [Profile_Bank_Account] nvarchar(50) NULL,
        [Profile_Address] nvarchar(150) NULL,
        [Profile_Remark] nvarchar(50) NULL,
        [Profile_State] nvarchar(50) NULL,
        [Profile_Note] nvarchar(50) NULL,
 CONSTRAINT [PK_Profiles] PRIMARY KEY CLUSTERED 
(
	[Profile_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Profiles]  WITH CHECK ADD  CONSTRAINT [FK_Profiles_Reletionships] FOREIGN KEY([Reletionship_Id])
REFERENCES [dbo].[Reletionships] ([Reletionship_Id])
GO

ALTER TABLE [dbo].[Profiles] CHECK CONSTRAINT [FK_Profiles_Reletionships]
GO

/****** Object:  Table [dbo].[Purchases]    Object Create Date: 2019/12/30 11:53:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Purchases](
        [Purchase_Id] [bigint] IDENTITY(1,1) NOT NULL,
        [Purchase_Date] [date] NOT NULL,
        [Profile_Id] [bigint] NOT NULL,
        [Purchase_CGST_Amount] [money] NOT NULL,
        [Purchase_SGST_Amount] [money] NOT NULL,
        [Purchase_IGST_Amount] [money] NOT NULL,
        [Purchase_Grandtotal_Amount] [money] NOT NULL,
        [Purchase_Payment_Amount] [money] NOT NULL,
        [Purchase_Due_Amount] [money] NOT NULL,
 CONSTRAINT [PK_Purchases] PRIMARY KEY CLUSTERED 
(
	[Purchase_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [FK_Purchases_Profiles] FOREIGN KEY([Profile_Id])
REFERENCES [dbo].[Profiles] ([Profile_Id])
GO

ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [FK_Purchases_Profiles]
GO

/****** Object:  Table [dbo].[PurchaseDetails]    Object Create Date: 2019/12/30 11:53:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PurchaseDetails](
        [PurchaseDetail_Id] [bigint] IDENTITY(1,1) NOT NULL,
        [Purchase_Id] [bigint] NOT NULL,
        [Product_Id] [bigint] NOT NULL,
        [Product_Name] nvarchar(30) NOT NULL,
        [HSN_Code] nvarchar(50) NULL,
        [Purchase_Quantity] nvarchar(50) NULL,
        [Unit_Name] nvarchar(30) NOT NULL,
        [Purchase_Rate_Amount] [money] NOT NULL,
        [Purchase_Subtotal_Amount] [money] NOT NULL,
 CONSTRAINT [PK_PurchaseDetails] PRIMARY KEY CLUSTERED 
(
	[PurchaseDetail_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[PurchaseDetails]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseDetails_Purchases] FOREIGN KEY([Purchase_Id])
REFERENCES [dbo].[Purchases] ([Purchase_Id])
GO

ALTER TABLE [dbo].[PurchaseDetails] CHECK CONSTRAINT [FK_PurchaseDetails_Purchases]
GO

ALTER TABLE [dbo].[PurchaseDetails]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseDetails_Products] FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Products] ([Product_Id])
GO

ALTER TABLE [dbo].[PurchaseDetails] CHECK CONSTRAINT [FK_PurchaseDetails_Products]
GO

/****** Object:  Table [dbo].[PurchaseBarcodes]    Object Create Date: 2019/12/30 11:53:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PurchaseBarcodes](
        [PurchaseBarcode_Id] [bigint] IDENTITY(1,1) NOT NULL,
        [PurchaseDetail_Id] [bigint] NOT NULL,
        [Product_Id] [bigint] NOT NULL,
        [Product_Barcode] nvarchar(50) NULL,
 CONSTRAINT [PK_PurchaseBarcodes] PRIMARY KEY CLUSTERED 
(
	[PurchaseBarcode_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[PurchaseBarcodes]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseBarcodes_PurchaseDetails] FOREIGN KEY([PurchaseDetail_Id])
REFERENCES [dbo].[PurchaseDetails] ([PurchaseDetail_Id])
GO

ALTER TABLE [dbo].[PurchaseBarcodes] CHECK CONSTRAINT [FK_PurchaseBarcodes_PurchaseDetails]
GO

ALTER TABLE [dbo].[PurchaseBarcodes]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseBarcodes_Products] FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Products] ([Product_Id])
GO

ALTER TABLE [dbo].[PurchaseBarcodes] CHECK CONSTRAINT [FK_PurchaseBarcodes_Products]
GO

/****** Object:  Table [dbo].[Sales]    Object Create Date: 2019/12/30 11:53:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sales](
        [Sale_Id] [bigint] IDENTITY(1,1) NOT NULL,
        [Sale_Date] [date] NOT NULL,
        [Profile_Id] [bigint] NOT NULL,
        [Sale_CGST_Amount] [money] NOT NULL,
        [Sale_SGST_Amount] [money] NOT NULL,
        [Sale_IGST_Amount] [money] NOT NULL,
        [Sale_Grandtotal_Amount] [money] NOT NULL,
        [Sale_Recive_Amount] [money] NOT NULL,
        [Sale_Due_Amount] [money] NOT NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[Sale_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Profiles] FOREIGN KEY([Profile_Id])
REFERENCES [dbo].[Profiles] ([Profile_Id])
GO

ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Profiles]
GO

/****** Object:  Table [dbo].[SaleDetails]    Object Create Date: 2019/12/30 11:53:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SaleDetails](
        [SaleDetail_Id] [bigint] IDENTITY(1,1) NOT NULL,
        [Sale_Id] [bigint] NOT NULL,
        [Product_Id] [bigint] NOT NULL,
        [Product_Name] nvarchar(30) NOT NULL,
        [HSN_Code] nvarchar(50) NULL,
        [Sale_Quantity] nvarchar(50) NULL,
        [Unit_Name] nvarchar(30) NOT NULL,
        [Sale_Rate_Amount] [money] NOT NULL,
        [Sale_Subtotal_Amount] [money] NOT NULL,
 CONSTRAINT [PK_SaleDetails] PRIMARY KEY CLUSTERED 
(
	[SaleDetail_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[SaleDetails]  WITH CHECK ADD  CONSTRAINT [FK_SaleDetails_Sales] FOREIGN KEY([Sale_Id])
REFERENCES [dbo].[Sales] ([Sale_Id])
GO

ALTER TABLE [dbo].[SaleDetails] CHECK CONSTRAINT [FK_SaleDetails_Sales]
GO

ALTER TABLE [dbo].[SaleDetails]  WITH CHECK ADD  CONSTRAINT [FK_SaleDetails_Products] FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Products] ([Product_Id])
GO

ALTER TABLE [dbo].[SaleDetails] CHECK CONSTRAINT [FK_SaleDetails_Products]
GO

/****** Object:  Table [dbo].[SaleBarcodes]    Object Create Date: 2019/12/30 11:53:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SaleBarcodes](
        [SaleBarcode_Id] [bigint] IDENTITY(1,1) NOT NULL,
        [SaleDetail_Id] [bigint] NOT NULL,
        [Product_Id] [bigint] NOT NULL,
        [SaleBarcode_Barcode] nvarchar(50) NULL,
 CONSTRAINT [PK_SaleBarcodes] PRIMARY KEY CLUSTERED 
(
	[SaleBarcode_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[SaleBarcodes]  WITH CHECK ADD  CONSTRAINT [FK_SaleBarcodes_SaleDetails] FOREIGN KEY([SaleDetail_Id])
REFERENCES [dbo].[SaleDetails] ([SaleDetail_Id])
GO

ALTER TABLE [dbo].[SaleBarcodes] CHECK CONSTRAINT [FK_SaleBarcodes_SaleDetails]
GO

ALTER TABLE [dbo].[SaleBarcodes]  WITH CHECK ADD  CONSTRAINT [FK_SaleBarcodes_Products] FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Products] ([Product_Id])
GO

ALTER TABLE [dbo].[SaleBarcodes] CHECK CONSTRAINT [FK_SaleBarcodes_Products]
GO

/****** Object:  Table [dbo].[CashBalance]    Object Create Date: 2019/12/30 11:53:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CashBalance](
        [CashBalance_Id] [bigint] IDENTITY(1,1) NOT NULL,
        [CashBalance_Date] [date] NOT NULL,
        [Profile_Id] [bigint] NOT NULL,
        [CashBalance_Payment_Amount] [money] NOT NULL,
        [CashBalance_Recive_Amount] [money] NOT NULL,
 CONSTRAINT [PK_CashBalance] PRIMARY KEY CLUSTERED 
(
	[CashBalance_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[CashBalance]  WITH CHECK ADD  CONSTRAINT [FK_CashBalance_Profiles] FOREIGN KEY([Profile_Id])
REFERENCES [dbo].[Profiles] ([Profile_Id])
GO

ALTER TABLE [dbo].[CashBalance] CHECK CONSTRAINT [FK_CashBalance_Profiles]
GO

/****** Object:  Table [dbo].[CashMemo]    Object Create Date: 2019/12/30 11:53:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CashMemo](
        [CashMemo_Id] [bigint] IDENTITY(1,1) NOT NULL,
        [CashMemo_Date] [date] NOT NULL,
        [Profile_Id] [bigint] NOT NULL,
        [CashMemo_Payment_Amount] [money] NOT NULL,
        [CashMemo_Recive_Amount] [money] NOT NULL,
 CONSTRAINT [PK_CashMemo] PRIMARY KEY CLUSTERED 
(
	[CashMemo_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[CashMemo]  WITH CHECK ADD  CONSTRAINT [FK_CashMemo_Profiles] FOREIGN KEY([Profile_Id])
REFERENCES [dbo].[Profiles] ([Profile_Id])
GO

ALTER TABLE [dbo].[CashMemo] CHECK CONSTRAINT [FK_CashMemo_Profiles]
GO