/*DECLARE @RC int
DECLARE @StartingLetterOfCustomerName nvarchar(10)
DECLARE @FilterAmountLow int
DECLARE @FilterAmountHigh int*/

-- TODO: Set parameter values here.
'C',15000.0
EXECUTE [dbo].[GetCustomerPurchaseData-LN]
GO