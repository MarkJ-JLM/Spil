USE [Demo2016]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 12/16/2022 4:55:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[DCLink] [int] IDENTITY(1,1) NOT NULL,
	[Account] [varchar](20) NULL,
	[Name] [varchar](50) NULL,
	[Title] [varchar](5) NULL,
	[PriceHalf] [decimal](18, 2) NOT NULL,
	[Init] [varchar](6) NULL,
	[Contact_Person] [varchar](30) NULL,
	[Physical1] [varchar](40) NULL,
	[Physical2] [varchar](40) NULL,
	[Physical3] [varchar](40) NULL,
	[Physical4] [varchar](40) NULL,
	[Physical5] [varchar](40) NULL,
	[PhysicalPC] [varchar](15) NULL,
	[Addressee] [varchar](30) NULL,
	[Post1] [varchar](40) NULL,
	[Post2] [varchar](40) NULL,
	[Post3] [varchar](40) NULL,
	[Post4] [varchar](40) NULL,
	[Post5] [varchar](40) NULL,
	[PostPC] [varchar](15) NULL,
	[Delivered_To] [varchar](30) NULL,
	[Telephone] [varchar](25) NULL,
	[Telephone2] [varchar](25) NULL,
	[Fax1] [varchar](25) NULL,
	[Fax2] [varchar](25) NULL,
	[AccountTerms] [int] NULL,
	[CT] [bit] NOT NULL,
	[Tax_Number] [varchar](15) NULL,
	[Registration] [varchar](20) NULL,
	[Credit_Limit] [float] NULL,
	[RepID] [int] NULL,
	[Interest_Rate] [float] NULL,
	[Discount] [float] NULL,
	[On_Hold] [bit] NOT NULL,
	[BFOpenType] [int] NULL,
	[EMail] [varchar](60) NULL,
	[BankLink] [int] NULL,
	[BranchCode] [varchar](30) NULL,
	[BankAccNum] [varchar](30) NULL,
	[BankAccType] [varchar](30) NULL,
	[AutoDisc] [float] NULL,
	[DiscMtrxRow] [int] NULL,
	[MainAccLink] [int] NULL,
	[CashDebtor] [bit] NOT NULL,
	[DCBalance] [float] NULL,
	[CheckTerms] [bit] NOT NULL,
	[UseEmail] [bit] NOT NULL,
	[iIncidentTypeID] [int] NULL,
	[iBusTypeID] [int] NULL,
	[iBusClassID] [int] NULL,
	[iCountryID] [int] NULL,
	[iAgentID] [int] NULL,
	[dTimeStamp] [datetime] NULL,
	[cAccDescription] [varchar](80) NULL,
	[cWebPage] [varchar](50) NULL,
	[iClassID] [int] NULL,
	[iAreasID] [int] NULL,
	[cBankRefNr] [varchar](30) NULL,
	[iCurrencyID] [int] NULL,
	[bStatPrint] [bit] NOT NULL,
	[bStatEmail] [bit] NOT NULL,
	[cStatEmailPass] [varchar](20) NULL,
	[bForCurAcc] [bit] NOT NULL,
	[fForeignBalance] [float] NULL,
	[bTaxPrompt] [bit] NOT NULL,
	[iARPriceListNameID] [int] NULL,
	[iSettlementTermsID] [int] NOT NULL,
	[bSourceDocPrint] [bit] NOT NULL,
	[bSourceDocEmail] [bit] NOT NULL,
	[iEUCountryID] [int] NOT NULL,
	[iDefTaxTypeID] [int] NOT NULL,
	[bCODAccount] [bit] NOT NULL,
	[udARDate] [datetime] NULL,
	[uiARDeliveryMethod] [int] NULL,
	[tOrderNotes] [text] NULL,
	[uiARCATID] [int] NULL,
	[FuelLevyPercen] [decimal](18, 2) NOT NULL,
	[FLID] [int] NOT NULL,
	[AccountStatusID] [int] NOT NULL,
	[IGUFabRate] [float] NOT NULL,
	[CreditPercentage] [float] NOT NULL,
	[TotalDebitBalance] [float] NOT NULL,
	[TotInvoiced] [float] NOT NULL,
	[TotPending] [float] NOT NULL,
	[TotReceived] [float] NOT NULL,
	[IsGlobalAcc] [bit] NOT NULL,
	[IsProspect] [bit] NOT NULL,
	[CardIdentification] [varchar](50) NOT NULL,
	[LegalName] [varchar](50) NULL,
	[TrustName] [varchar](50) NULL,
	[BusinessEstablished] [smalldatetime] NULL,
	[RegistrationNo] [varchar](20) NULL,
	[ACN] [varchar](20) NULL,
	[Token] [varchar](30) NULL,
	[EntityStructureID] [int] NOT NULL,
	[InsuredID] [int] NOT NULL,
	[CreditApplicationDate] [smalldatetime] NULL,
	[PPS_ExpiryDate] [smalldatetime] NULL,
	[PersonalGurantee] [varchar](200) NULL,
	[CC_NameOnCard] [varchar](20) NULL,
	[CC_CardNumber] [varchar](16) NULL,
	[CC_ExpiryDate] [smalldatetime] NULL,
	[BSB] [varchar](6) NULL,
	[AcountNumber] [varchar](20) NULL,
	[AcountName] [varchar](20) NULL,
	[CreditSearch] [smalldatetime] NULL,
	[GONI] [varchar](20) NULL,
	[bSendOrderConfirmations] [bit] NOT NULL,
	[EmailOrderConfirmationTo] [varchar](200) NOT NULL,
	[EmailTaxInvoicesTo] [varchar](200) NOT NULL,
	[EmailStatementsTo] [varchar](200) NOT NULL,
	[RebateID] [int] NOT NULL,
	[XeroGUID] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CLIENT] PRIMARY KEY CLUSTERED 
(
	[DCLink] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HomeDetails]    Script Date: 12/16/2022 4:55:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HomeDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NULL,
	[InvoiceNo] [varchar](50) NULL,
	[InvoiceDate] [datetime] NULL,
	[ReferenceNo] [varchar](50) NULL,
	[Note] [varchar](max) NULL,
	[TotalExcel] [decimal](8, 2) NULL,
	[TotalTax] [decimal](8, 2) NULL,
	[TotalIncl] [decimal](8, 2) NULL,
	[CustomerName] [varchar](150) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesOrder]    Script Date: 12/16/2022 4:55:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesOrder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HomeDet] [int] NULL,
	[ItemCode] [int] NULL,
	[Note] [varchar](100) NULL,
	[Quantity] [int] NULL,
	[Price] [decimal](8, 2) NULL,
	[Tax] [decimal](8, 2) NULL,
	[ExcelAmount] [decimal](8, 2) NULL,
	[TaxAmount] [decimal](8, 2) NULL,
	[InclAmount] [decimal](8, 2) NULL,
	[CreateDate] [datetime] NULL,
	[EditDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StkItem]    Script Date: 12/16/2022 4:55:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StkItem](
	[StockLink] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](255) NULL,
	[Description_1] [varchar](255) NULL,
	[Description_2] [varchar](255) NULL,
	[Description_3] [varchar](255) NULL,
	[ItemGroup] [varchar](20) NULL,
	[Pack] [varchar](5) NULL,
	[TTI] [varchar](4) NULL,
	[TTC] [varchar](4) NULL,
	[TTG] [varchar](4) NULL,
	[TTR] [varchar](4) NULL,
	[Bar_Code] [varchar](255) NULL,
	[Re_Ord_Lvl] [float] NULL,
	[Re_Ord_Qty] [float] NULL,
	[Min_Lvl] [float] NULL,
	[Max_Lvl] [float] NULL,
	[AveUCst] [float] NULL,
	[LatUCst] [float] NULL,
	[LowUCst] [float] NULL,
	[HigUCst] [float] NULL,
	[StdUCst] [float] NULL,
	[Qty_On_Hand] [float] NULL,
	[LGrvCount] [float] NULL,
	[ServiceItem] [bit] NOT NULL,
	[ItemActive] [bit] NOT NULL,
	[ReservedQty] [float] NULL,
	[QtyOnPO] [float] NULL,
	[QtyOnSO] [float] NULL,
	[WhseItem] [bit] NOT NULL,
	[SerialItem] [bit] NOT NULL,
	[DuplicateSN] [bit] NOT NULL,
	[StrictSN] [bit] NOT NULL,
	[BomCode] [varchar](1) NULL,
	[SMtrxCol] [int] NULL,
	[PMtrxCol] [int] NULL,
	[JobQty] [float] NULL,
	[cModel] [varchar](50) NULL,
	[cRevision] [varchar](50) NULL,
	[cComponent] [varchar](50) NULL,
	[dDateReleased] [smalldatetime] NULL,
	[iBinLocationID] [int] NULL,
	[dStkitemTimeStamp] [datetime] NULL,
	[iInvSegValue1ID] [int] NULL,
	[iInvSegValue2ID] [int] NULL,
	[iInvSegValue3ID] [int] NULL,
	[iInvSegValue4ID] [int] NULL,
	[iInvSegValue5ID] [int] NULL,
	[iInvSegValue6ID] [int] NULL,
	[iInvSegValue7ID] [int] NULL,
	[cExtDescription] [varchar](255) NULL,
	[cSimpleCode] [varchar](20) NULL,
	[bCommissionItem] [bit] NOT NULL,
	[MFPQty] [float] NULL,
	[bLotItem] [bit] NOT NULL,
	[iLotStatus] [int] NULL,
	[bLotMustExpire] [bit] NOT NULL,
	[iItemCostingMethod] [int] NOT NULL,
	[fItemLastGRVCost] [float] NOT NULL,
	[iEUCommodityID] [int] NOT NULL,
	[iEUSupplementaryUnitID] [int] NOT NULL,
	[fNetMass] [float] NOT NULL,
	[iUOMStockingUnitID] [int] NULL,
	[iUOMDefPurchaseUnitID] [int] NULL,
	[iUOMDefSellUnitID] [int] NULL,
	[uiIISRVPRICEID] [int] NULL,
	[ubIIEDGEALLOWANCE] [bit] NULL,
	[ufIIThickness] [float] NULL,
	[ubIITemplate] [bit] NULL,
	[uiIITemplPriceID] [int] NULL,
	[ubIIGLASSSERVICE] [bit] NULL,
	[uiIIItemType] [int] NULL,
	[ufIIMINCHRG] [float] NULL,
	[ufIIMINSQM] [float] NULL,
	[ufIIWEIGHT] [float] NULL,
	[uiIIPRICETYPEID] [int] NULL,
	[ubIIPrintLabels] [bit] NULL,
	[DefaultGlassService] [bit] NOT NULL,
	[IsLaminateItem] [bit] NOT NULL,
	[ufIIQtyInVolume] [float] NULL,
	[uiIIMainItemLink] [int] NULL,
	[ubIIAllowNegative] [bit] NULL,
	[uiIISupplier] [int] NULL,
	[uiIIWidth] [int] NULL,
	[uiIIHeight] [int] NULL,
	[ufIILotQty] [float] NULL,
	[ufIIGrvQty] [float] NULL,
	[ufIISOQtyVolume] [float] NULL,
	[uiIIWarehouse] [float] NULL,
	[ShowPODes] [bit] NOT NULL,
	[IsNonStockItem] [bit] NOT NULL,
	[IsExternalItem] [bit] NOT NULL,
	[POMinimumArea] [float] NOT NULL,
	[AccountNumber] [varchar](50) NOT NULL,
	[CostCentre] [int] NOT NULL,
	[AddDetails] [varchar](255) NULL,
	[SalesAccount] [varchar](50) NULL,
	[PurchaseAccount] [varchar](50) NULL,
	[Length] [float] NULL,
	[BulkQty] [float] NULL,
	[BulkRate] [float] NULL,
	[PriceListItem] [bit] NOT NULL,
	[CalcPriceAsPercentage] [bit] NOT NULL,
	[CalcPricePercentage] [float] NOT NULL,
	[BOMItem] [bit] NOT NULL,
 CONSTRAINT [PK_STKITEM] PRIMARY KEY CLUSTERED 
(
	[StockLink] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_PriceHalf]  DEFAULT ((0)) FOR [PriceHalf]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF__CLIENT__CT__6C390A4C]  DEFAULT ((0)) FOR [CT]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF__CLIENT__On_Hold__6D2D2E85]  DEFAULT ((0)) FOR [On_Hold]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF__CLIENT__CashDebt__6E2152BE]  DEFAULT ((0)) FOR [CashDebtor]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF__CLIENT__CheckTer__6F1576F7]  DEFAULT ((0)) FOR [CheckTerms]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF__CLIENT__UseEmail__70099B30]  DEFAULT ((0)) FOR [UseEmail]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_bStatPrint]  DEFAULT ((0)) FOR [bStatPrint]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_bStatEmail]  DEFAULT ((0)) FOR [bStatEmail]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_bForCurAcc]  DEFAULT ((0)) FOR [bForCurAcc]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_bTaxPrompt]  DEFAULT ((1)) FOR [bTaxPrompt]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_CLIENT_iSettlementTermsID]  DEFAULT ((0)) FOR [iSettlementTermsID]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_CLIENT_bSourceDocPrint]  DEFAULT ((1)) FOR [bSourceDocPrint]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_CLIENT_bSourceDocEmail]  DEFAULT ((0)) FOR [bSourceDocEmail]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_iEUCountryID]  DEFAULT ((0)) FOR [iEUCountryID]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_iDefTaxTypeID]  DEFAULT ((0)) FOR [iDefTaxTypeID]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_bCODAccount]  DEFAULT ((0)) FOR [bCODAccount]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_tOrderNotes_1]  DEFAULT ('') FOR [tOrderNotes]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_FuelLevyPercen]  DEFAULT ((0)) FOR [FuelLevyPercen]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_FLID]  DEFAULT ((0)) FOR [FLID]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_AccountStatusID]  DEFAULT ((1)) FOR [AccountStatusID]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_IGUFabRate]  DEFAULT ((0)) FOR [IGUFabRate]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_CreditPercentage]  DEFAULT ((0)) FOR [CreditPercentage]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_TotalDebitBalance]  DEFAULT ((0)) FOR [TotalDebitBalance]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_TotInvoiced]  DEFAULT ((0)) FOR [TotInvoiced]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_TotPending]  DEFAULT ((0)) FOR [TotPending]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_TotReceived]  DEFAULT ((0)) FOR [TotReceived]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_IsGlobalAcc]  DEFAULT ((0)) FOR [IsGlobalAcc]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_IsProspect]  DEFAULT ((0)) FOR [IsProspect]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_CardIdentification]  DEFAULT ('') FOR [CardIdentification]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_CardIdentification1]  DEFAULT ('') FOR [RegistrationNo]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_RegistrationNo1_1]  DEFAULT ('') FOR [ACN]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_RegistrationNo1]  DEFAULT ('') FOR [Token]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_FLID1]  DEFAULT ((0)) FOR [EntityStructureID]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_EntityStructureID1]  DEFAULT ((0)) FOR [InsuredID]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_bSendOrderConfirmations]  DEFAULT ((0)) FOR [bSendOrderConfirmations]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_EmailOrderConfirmationTo]  DEFAULT ('') FOR [EmailOrderConfirmationTo]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_EmailOrderConfirmationTo1]  DEFAULT ('') FOR [EmailTaxInvoicesTo]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_EmailOrderConfirmationTo2]  DEFAULT ('') FOR [EmailStatementsTo]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_RebateID]  DEFAULT ((1)) FOR [RebateID]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_XeroGUID]  DEFAULT ('') FOR [XeroGUID]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF__STKITEM__Service__290D0E62]  DEFAULT ((0)) FOR [ServiceItem]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF__STKITEM__ItemAct__2A01329B]  DEFAULT ((1)) FOR [ItemActive]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF__STKITEM__WhseIte__2AF556D4]  DEFAULT ((0)) FOR [WhseItem]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF__STKITEM__SerialI__2BE97B0D]  DEFAULT ((0)) FOR [SerialItem]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF__STKITEM__Duplica__2CDD9F46]  DEFAULT ((0)) FOR [DuplicateSN]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF__STKITEM__StrictS__2DD1C37F]  DEFAULT ((0)) FOR [StrictSN]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_bCommissionItem]  DEFAULT ((1)) FOR [bCommissionItem]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_bLotItem]  DEFAULT ((0)) FOR [bLotItem]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_bLotMustExpire]  DEFAULT ((1)) FOR [bLotMustExpire]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_iItemCostingMethod]  DEFAULT ((0)) FOR [iItemCostingMethod]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_fItemLastGRVCost]  DEFAULT ((0)) FOR [fItemLastGRVCost]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_iEUCommodityID]  DEFAULT ((0)) FOR [iEUCommodityID]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_iEUSupplementaryUnitID]  DEFAULT ((0)) FOR [iEUSupplementaryUnitID]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_fNetMass]  DEFAULT ((0)) FOR [fNetMass]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_DefaultGlassService]  DEFAULT ((0)) FOR [DefaultGlassService]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_IsLaminateItem_1]  DEFAULT ((0)) FOR [IsLaminateItem]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_ShowPODes]  DEFAULT ((0)) FOR [ShowPODes]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_IsNonStockItem]  DEFAULT ((0)) FOR [IsNonStockItem]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_IsExternalItem]  DEFAULT ((0)) FOR [IsExternalItem]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_POMinimumArea]  DEFAULT ((0)) FOR [POMinimumArea]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_AccountNumber]  DEFAULT ('') FOR [AccountNumber]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_CostCentre]  DEFAULT ((0)) FOR [CostCentre]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_PriceListItem]  DEFAULT ((1)) FOR [PriceListItem]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_PriceListItem1]  DEFAULT ((0)) FOR [CalcPriceAsPercentage]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_CalcPricePercentage]  DEFAULT ((0)) FOR [CalcPricePercentage]
GO
ALTER TABLE [dbo].[StkItem] ADD  CONSTRAINT [DF_StkItem_BOMItem]  DEFAULT ((0)) FOR [BOMItem]
GO
/****** Object:  StoredProcedure [dbo].[spInsertMain]    Script Date: 12/16/2022 4:55:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spInsertMain](
@InvoiceNo VARCHAR(50),
@InvoiceDate date,
@ReferenceNo varchar(100),
@Note varchar(max),
@TotalExcel decimal(18,2),
@TotalTax decimal(18,2),
@TotalIncl decimal(18,2),
@CustomerName varchar(50)
)
as
begin
declare @clientId int;
declare @lastid int;

select @clientId = DCLink from Client where [Name] = @CustomerName;

Insert into HomeDetails values (@clientId,@InvoiceNo,@InvoiceDate,@ReferenceNo,@Note,@TotalExcel,@TotalTax,@TotalIncl,@CustomerName)

select @lastid = SCOPE_IDENTITY();
end
GO
/****** Object:  StoredProcedure [dbo].[spSalesOrder]    Script Date: 12/16/2022 4:55:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spSalesOrder](
@HomeDet int,
@ItemCode varchar(100),
@Note varchar(100),
@Quantity decimal(18,2),
@Price decimal(18,2),
@Tax decimal(18,2),
@ExcelAmount decimal(18,2),
@TaxAmount decimal(18,2),
@InclAmount decimal(18,2)
)
as
begin
declare @clientId int;
declare @lastid int;

Insert into SalesOrder values (@HomeDet,@ItemCode,@Note,@Quantity,@Price,@Tax,@ExcelAmount,@TaxAmount,@InclAmount,GETDATE(),null)

--select @lastid = SCOPE_IDENTITY();
end
GO
