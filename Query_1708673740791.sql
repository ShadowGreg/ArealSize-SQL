-- Active: 1708673642977@@127.0.0.1@5433@postgres@public
-- Создание таблицы Products
CREATE TABLE Products (
    ProductID INT PRIMARY KEY, ProductName VARCHAR(50)
);

-- Создание таблицы Categories
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY, CategoryName VARCHAR(50)
);

-- Создание таблицы ProductCategory для отношения многие ко многим
CREATE TABLE ProductCategory (
    ProductID INT, CategoryID INT, PRIMARY KEY (ProductID, CategoryID), FOREIGN KEY (ProductID) REFERENCES Products (ProductID), FOREIGN KEY (CategoryID) REFERENCES Categories (CategoryID)
);

-- Заполнение таблицы Products
INSERT INTO
    Products (ProductID, ProductName)
VALUES (1, 'Product A'),
    (2, 'Product B'),
    (3, 'Product C');

-- Заполнение таблицы Categories
INSERT INTO
    Categories (CategoryID, CategoryName)
VALUES (1, 'Category X'),
    (2, 'Category Y'),
    (3, 'Category Z');

-- Заполнение таблицы ProductCategory
INSERT INTO
    ProductCategory (ProductID, CategoryID)
VALUES (1, 1), -- Product A - Category X
    (1, 2), -- Product A - Category Y
    (2, 2), -- Product B - Category Y
    (3, 3); -- Product C - Category Z

/*В базе данных MS SQL Server есть продукты и категории. 
Одному продукту может соответствовать много категорий,
в одной категории может быть много продуктов.
Напишите SQL запрос для выбора всех пар 
«Имя продукта – Имя категории». Если у продукта нет категорий, 
то его имя все равно должно выводиться.*/

SELECT P.ProductName, COALESCE(C.CategoryName, 'No Category') AS CategoryName
FROM
    Products P
    LEFT JOIN ProductCategory PC ON P.ProductID = PC.ProductID
    LEFT JOIN Categories C ON PC.CategoryID = C.CategoryID



