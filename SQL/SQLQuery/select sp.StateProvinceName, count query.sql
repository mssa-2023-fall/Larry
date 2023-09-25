select sp.StateProvinceName, count(s.SupplierID) as supplierCount,COUNT(cust.customerID) as customerCount
FROM Application.StateProvinces sp LEFT JOIN Application.Cities c on sp.StateProvinceID = c. StateProvinceID
left Join Purchasing.Suppliers s on c.CityID = s.PostalCityID
left join Sales.Customers cust on c.CityID = cust.PostalCityID
Group by sp.StateProvinceName