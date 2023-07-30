SELECT P.Name ProductName, C.Name CategoryName
FROM Products P
         LEFT JOIN ProductsCategories PC on P.ID = PC.ProductId
         LEFT JOIN Categories C on PC.CategoryId = C.ID