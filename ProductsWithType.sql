SELECT 
 p.IdProduct,
 p.Description,
 p.Name AS ProductName,
 p.Price,
 p.IdProductType,
 pt.Name AS ProductTypeName
FROM Product p
INNER JOIN ProductType pt
  ON p.IdProductType = pt.IdProductType;