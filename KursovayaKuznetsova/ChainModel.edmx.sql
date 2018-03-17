
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/17/2018 00:59:38
-- Generated from EDMX file: C:\Users\opelo\source\repos\kursovayaKuznetsova\kursovayaKuznetsova\ChainModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [KursovayaVol4];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ChainStock]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StockSet] DROP CONSTRAINT [FK_ChainStock];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductStock]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductSet] DROP CONSTRAINT [FK_ProductStock];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductManufactor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductSet] DROP CONSTRAINT [FK_ProductManufactor];
GO
IF OBJECT_ID(N'[dbo].[FK_StockStore]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StoreSet] DROP CONSTRAINT [FK_StockStore];
GO
IF OBJECT_ID(N'[dbo].[FK_StoreShift]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ShiftSet] DROP CONSTRAINT [FK_StoreShift];
GO
IF OBJECT_ID(N'[dbo].[FK_ShiftCheck]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CheckSet] DROP CONSTRAINT [FK_ShiftCheck];
GO
IF OBJECT_ID(N'[dbo].[FK_CheckCheckUnit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CheckUnitSet] DROP CONSTRAINT [FK_CheckCheckUnit];
GO
IF OBJECT_ID(N'[dbo].[FK_CheckUnitCheckDiscount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CheckDiscountSet] DROP CONSTRAINT [FK_CheckUnitCheckDiscount];
GO
IF OBJECT_ID(N'[dbo].[FK_SellerShift]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ShiftSet] DROP CONSTRAINT [FK_SellerShift];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductProductDiscount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductDiscountSet] DROP CONSTRAINT [FK_ProductProductDiscount];
GO
IF OBJECT_ID(N'[dbo].[FK_Administrator_inherits_Seller]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SellerSet_Administrator] DROP CONSTRAINT [FK_Administrator_inherits_Seller];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ChainSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ChainSet];
GO
IF OBJECT_ID(N'[dbo].[StockSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StockSet];
GO
IF OBJECT_ID(N'[dbo].[ProductSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductSet];
GO
IF OBJECT_ID(N'[dbo].[ManufactorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ManufactorSet];
GO
IF OBJECT_ID(N'[dbo].[StoreSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StoreSet];
GO
IF OBJECT_ID(N'[dbo].[ShiftSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ShiftSet];
GO
IF OBJECT_ID(N'[dbo].[CheckSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CheckSet];
GO
IF OBJECT_ID(N'[dbo].[CheckUnitSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CheckUnitSet];
GO
IF OBJECT_ID(N'[dbo].[CheckDiscountSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CheckDiscountSet];
GO
IF OBJECT_ID(N'[dbo].[SellerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SellerSet];
GO
IF OBJECT_ID(N'[dbo].[ProductDiscountSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductDiscountSet];
GO
IF OBJECT_ID(N'[dbo].[SellerSet_Administrator]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SellerSet_Administrator];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ChainSet'
CREATE TABLE [dbo].[ChainSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Percent] int  NOT NULL,
    [StartWage] int  NOT NULL,
    [InTerminal] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StockSet'
CREATE TABLE [dbo].[StockSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ChainId] int  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [IsActive] bit  NOT NULL
);
GO

-- Creating table 'ProductSet'
CREATE TABLE [dbo].[ProductSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StockId] int  NOT NULL,
    [Amount] int  NOT NULL,
    [ProductTypeId] int  NOT NULL,
    [IsParfume] bit  NOT NULL
);
GO

-- Creating table 'ManufactorSet'
CREATE TABLE [dbo].[ManufactorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StoreSet'
CREATE TABLE [dbo].[StoreSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RealMoney] int  NOT NULL,
    [Money] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [IsActive] bit  NOT NULL,
    [Stock_Id] int  NOT NULL
);
GO

-- Creating table 'ShiftSet'
CREATE TABLE [dbo].[ShiftSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DateStart] datetime  NOT NULL,
    [DateEnd] datetime  NOT NULL,
    [StartMoney] int  NOT NULL,
    [FinishMoney] int  NOT NULL,
    [FinishCardMoney] int  NOT NULL,
    [Remainder] int  NOT NULL,
    [StoreId] int  NOT NULL,
    [SellerId] int  NOT NULL
);
GO

-- Creating table 'CheckSet'
CREATE TABLE [dbo].[CheckSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Money] int  NOT NULL,
    [Card] int  NOT NULL,
    [ShiftId] int  NOT NULL
);
GO

-- Creating table 'CheckUnitSet'
CREATE TABLE [dbo].[CheckUnitSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CurrentPrice] int  NOT NULL,
    [Amount] int  NOT NULL,
    [CheckId] int  NOT NULL
);
GO

-- Creating table 'CheckDiscountSet'
CREATE TABLE [dbo].[CheckDiscountSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Value] int  NOT NULL,
    [CheckUnit_Id] int  NOT NULL
);
GO

-- Creating table 'SellerSet'
CREATE TABLE [dbo].[SellerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NOT NULL,
    [IsHired] bit  NOT NULL
);
GO

-- Creating table 'ProductDiscountSet'
CREATE TABLE [dbo].[ProductDiscountSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Value] int  NOT NULL,
    [ComboId] int  NULL,
    [FromNum] int  NULL,
    [FromNumCombo] nvarchar(max)  NOT NULL,
    [ProductType_Id] int  NOT NULL
);
GO

-- Creating table 'ProductTypeSet'
CREATE TABLE [dbo].[ProductTypeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Price] int  NOT NULL,
    [RealPrice] int  NOT NULL,
    [ManufactorId] int  NOT NULL,
    [Minimum] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RequestSet'
CREATE TABLE [dbo].[RequestSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IsActive] bit  NOT NULL,
    [Stock_Id] int  NOT NULL
);
GO

-- Creating table 'RequestProductSet'
CREATE TABLE [dbo].[RequestProductSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProductTypeId] nvarchar(max)  NOT NULL,
    [ManufactorId] nvarchar(max)  NOT NULL,
    [Amount] nvarchar(max)  NOT NULL,
    [RequestId] int  NOT NULL,
    [RequestId1] int  NOT NULL
);
GO

-- Creating table 'SellerSet_Administrator'
CREATE TABLE [dbo].[SellerSet_Administrator] (
    [Email] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ChainSet'
ALTER TABLE [dbo].[ChainSet]
ADD CONSTRAINT [PK_ChainSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StockSet'
ALTER TABLE [dbo].[StockSet]
ADD CONSTRAINT [PK_StockSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProductSet'
ALTER TABLE [dbo].[ProductSet]
ADD CONSTRAINT [PK_ProductSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ManufactorSet'
ALTER TABLE [dbo].[ManufactorSet]
ADD CONSTRAINT [PK_ManufactorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StoreSet'
ALTER TABLE [dbo].[StoreSet]
ADD CONSTRAINT [PK_StoreSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ShiftSet'
ALTER TABLE [dbo].[ShiftSet]
ADD CONSTRAINT [PK_ShiftSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CheckSet'
ALTER TABLE [dbo].[CheckSet]
ADD CONSTRAINT [PK_CheckSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CheckUnitSet'
ALTER TABLE [dbo].[CheckUnitSet]
ADD CONSTRAINT [PK_CheckUnitSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CheckDiscountSet'
ALTER TABLE [dbo].[CheckDiscountSet]
ADD CONSTRAINT [PK_CheckDiscountSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SellerSet'
ALTER TABLE [dbo].[SellerSet]
ADD CONSTRAINT [PK_SellerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProductDiscountSet'
ALTER TABLE [dbo].[ProductDiscountSet]
ADD CONSTRAINT [PK_ProductDiscountSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProductTypeSet'
ALTER TABLE [dbo].[ProductTypeSet]
ADD CONSTRAINT [PK_ProductTypeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RequestSet'
ALTER TABLE [dbo].[RequestSet]
ADD CONSTRAINT [PK_RequestSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RequestProductSet'
ALTER TABLE [dbo].[RequestProductSet]
ADD CONSTRAINT [PK_RequestProductSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SellerSet_Administrator'
ALTER TABLE [dbo].[SellerSet_Administrator]
ADD CONSTRAINT [PK_SellerSet_Administrator]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ChainId] in table 'StockSet'
ALTER TABLE [dbo].[StockSet]
ADD CONSTRAINT [FK_ChainStock]
    FOREIGN KEY ([ChainId])
    REFERENCES [dbo].[ChainSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ChainStock'
CREATE INDEX [IX_FK_ChainStock]
ON [dbo].[StockSet]
    ([ChainId]);
GO

-- Creating foreign key on [StockId] in table 'ProductSet'
ALTER TABLE [dbo].[ProductSet]
ADD CONSTRAINT [FK_ProductStock]
    FOREIGN KEY ([StockId])
    REFERENCES [dbo].[StockSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductStock'
CREATE INDEX [IX_FK_ProductStock]
ON [dbo].[ProductSet]
    ([StockId]);
GO

-- Creating foreign key on [Stock_Id] in table 'StoreSet'
ALTER TABLE [dbo].[StoreSet]
ADD CONSTRAINT [FK_StockStore]
    FOREIGN KEY ([Stock_Id])
    REFERENCES [dbo].[StockSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StockStore'
CREATE INDEX [IX_FK_StockStore]
ON [dbo].[StoreSet]
    ([Stock_Id]);
GO

-- Creating foreign key on [StoreId] in table 'ShiftSet'
ALTER TABLE [dbo].[ShiftSet]
ADD CONSTRAINT [FK_StoreShift]
    FOREIGN KEY ([StoreId])
    REFERENCES [dbo].[StoreSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StoreShift'
CREATE INDEX [IX_FK_StoreShift]
ON [dbo].[ShiftSet]
    ([StoreId]);
GO

-- Creating foreign key on [ShiftId] in table 'CheckSet'
ALTER TABLE [dbo].[CheckSet]
ADD CONSTRAINT [FK_ShiftCheck]
    FOREIGN KEY ([ShiftId])
    REFERENCES [dbo].[ShiftSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ShiftCheck'
CREATE INDEX [IX_FK_ShiftCheck]
ON [dbo].[CheckSet]
    ([ShiftId]);
GO

-- Creating foreign key on [CheckId] in table 'CheckUnitSet'
ALTER TABLE [dbo].[CheckUnitSet]
ADD CONSTRAINT [FK_CheckCheckUnit]
    FOREIGN KEY ([CheckId])
    REFERENCES [dbo].[CheckSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CheckCheckUnit'
CREATE INDEX [IX_FK_CheckCheckUnit]
ON [dbo].[CheckUnitSet]
    ([CheckId]);
GO

-- Creating foreign key on [CheckUnit_Id] in table 'CheckDiscountSet'
ALTER TABLE [dbo].[CheckDiscountSet]
ADD CONSTRAINT [FK_CheckUnitCheckDiscount]
    FOREIGN KEY ([CheckUnit_Id])
    REFERENCES [dbo].[CheckUnitSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CheckUnitCheckDiscount'
CREATE INDEX [IX_FK_CheckUnitCheckDiscount]
ON [dbo].[CheckDiscountSet]
    ([CheckUnit_Id]);
GO

-- Creating foreign key on [SellerId] in table 'ShiftSet'
ALTER TABLE [dbo].[ShiftSet]
ADD CONSTRAINT [FK_SellerShift]
    FOREIGN KEY ([SellerId])
    REFERENCES [dbo].[SellerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SellerShift'
CREATE INDEX [IX_FK_SellerShift]
ON [dbo].[ShiftSet]
    ([SellerId]);
GO

-- Creating foreign key on [ProductTypeId] in table 'ProductSet'
ALTER TABLE [dbo].[ProductSet]
ADD CONSTRAINT [FK_ProductTypeProduct]
    FOREIGN KEY ([ProductTypeId])
    REFERENCES [dbo].[ProductTypeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductTypeProduct'
CREATE INDEX [IX_FK_ProductTypeProduct]
ON [dbo].[ProductSet]
    ([ProductTypeId]);
GO

-- Creating foreign key on [ProductType_Id] in table 'ProductDiscountSet'
ALTER TABLE [dbo].[ProductDiscountSet]
ADD CONSTRAINT [FK_ProductTypeProductDiscount]
    FOREIGN KEY ([ProductType_Id])
    REFERENCES [dbo].[ProductTypeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductTypeProductDiscount'
CREATE INDEX [IX_FK_ProductTypeProductDiscount]
ON [dbo].[ProductDiscountSet]
    ([ProductType_Id]);
GO

-- Creating foreign key on [ManufactorId] in table 'ProductTypeSet'
ALTER TABLE [dbo].[ProductTypeSet]
ADD CONSTRAINT [FK_ProductTypeManufactor]
    FOREIGN KEY ([ManufactorId])
    REFERENCES [dbo].[ManufactorSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductTypeManufactor'
CREATE INDEX [IX_FK_ProductTypeManufactor]
ON [dbo].[ProductTypeSet]
    ([ManufactorId]);
GO

-- Creating foreign key on [Stock_Id] in table 'RequestSet'
ALTER TABLE [dbo].[RequestSet]
ADD CONSTRAINT [FK_StockRequest]
    FOREIGN KEY ([Stock_Id])
    REFERENCES [dbo].[StockSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StockRequest'
CREATE INDEX [IX_FK_StockRequest]
ON [dbo].[RequestSet]
    ([Stock_Id]);
GO

-- Creating foreign key on [RequestId1] in table 'RequestProductSet'
ALTER TABLE [dbo].[RequestProductSet]
ADD CONSTRAINT [FK_RequestRequestProduct]
    FOREIGN KEY ([RequestId1])
    REFERENCES [dbo].[RequestSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RequestRequestProduct'
CREATE INDEX [IX_FK_RequestRequestProduct]
ON [dbo].[RequestProductSet]
    ([RequestId1]);
GO

-- Creating foreign key on [Id] in table 'SellerSet_Administrator'
ALTER TABLE [dbo].[SellerSet_Administrator]
ADD CONSTRAINT [FK_Administrator_inherits_Seller]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[SellerSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------