-- В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
-- Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
-- По возможности — положите ответ рядом с кодом из первого вопроса.


CREATE TABLE Products
(
    ID int identity PRIMARY KEY,
    Name nvarchar(max)
)

CREATE TABLE Categories
(
    ID int IDENTITY PRIMARY KEY,
    Name nvarchar(max)
)

CREATE TABLE ProductsCategories
(
    ProductId int,
    CategoryId int,
    PRIMARY KEY (ProductId, CategoryId),
    FOREIGN KEY (ProductId) REFERENCES Products(ID),
    FOREIGN KEY (CategoryId) REFERENCES Categories(ID)
)

INSERT INTO Products VALUES
                         ('A'), ('B'), ('C')

INSERT INTO Categories VALUES
                           ('X'), ('Y'), ('Z')

INSERT INTO ProductsCategories VALUES
                                   (1, 1), (2, 1), (2, 2)

SELECT * FROM Products
SELECT * FROM Categories
SELECT * FROM ProductsCategories