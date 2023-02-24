CREATE TABLE [dbo].[ContactsTable]
(
    [ProductNumber] NVARCHAR(50) NOT NULL, 
    [ProductName] NVARCHAR(50) NOT NULL, 
    [NumberOfProducts] NVARCHAR(50) NOT NULL, 
    [Price] NVARCHAR(50) NOT NULL, 
    [CommodityCategory] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_ContactsTable] PRIMARY KEY ([ProductNumber])
)
