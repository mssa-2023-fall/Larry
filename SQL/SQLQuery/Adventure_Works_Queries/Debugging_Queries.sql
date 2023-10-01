SELECT c.CustomerID, CONCAT(c.LastName,' ', c.FirstName) AS CustomerName,
c.EmailAddress,
c.Phone,
o.SalesOrderID as OrderID, 
o.SubTotal as OrderSubTotal, 
o.TaxAmt as OrderTaxAmt, 
o.TotalDue as OrderTotalDue
FROM SalesLT.Customer as c
LEFT JOIN SalesLT.SalesOrderHeader as o
on c.CustomerID = o.CustomerID
WHERE 
(c.LastName LIKE 'FilterName%' OR c.FirstName LIKE 'FilterName%') AND
(o.TotalDue >= 'FilterMinTotalAmount%' OR 'FilterMinTotalAmount%' IS NULL) AND
(o.TotalDue <= 'FilterMaxTotalAmount%' OR 'FilterMaxTotalAmount%' IS NULL)

ORDER BY CustomerName ASC, OrderTotalDue DESC;