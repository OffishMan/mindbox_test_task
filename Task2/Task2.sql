SELECT p.Name AS ProductName, c.Name as CategoryName
FROM Products p
INNER JOIN ProductsToCategories ptc 
	ON ptc.ProductId = p.Id
LEFT JOIN Categories c 
	ON c.Id = ptc.CategoryId