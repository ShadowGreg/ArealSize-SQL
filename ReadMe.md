# Задание 1
 Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

- Юнит-тесты

- Легкость добавления других фигур

- Вычисление площади фигуры без знания типа фигуры в compile-time

- Проверку на то, является ли треугольник прямоугольным

Алгоритм решения задания по ссылке:



# Задание 2 
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

_Решение задачи:_

**Сначала создадим структуру таблиц:**

````SQL
CREATE TABLE Products(
id INT PRIMARY KEY IDENTITY, 
name VARCHAR(255) NOT NULL);

CREATE TABLE Category(
id INT PRIMARY KEY IDENTITY,
name VARCHAR(255) NOT NULL);

CREATE TABLE ProdCat(
products_id INT NOT NULL,
category_id INT NOT NULL,
FOREIGN KEY(products_id) REFERENCES Products(id) ON DELETE CASCADE,
FOREIGN KEY(category_id) REFERENCES Category(id) ON DELETE CASCADE);

CREATE UNIQUE INDEX prod_cat ON ProdCat(products_id, category_id);
````

**Заполнение таблиц:**

````SQL
INSERT INTO Products VALUES('Кеды Nike'), ('Тренчкот Brurbery'), ('Бейсболка'), ('Перчатки');
INSERT INTO Category VALUES('Обувь'), ('Верхняя одежда'), ('Наборы для рыбалки');
INSERT INTO ProdCat VALUES(1, 1), (2, 2), (3, 3), (4, 3);
````

**Выборка**

````SQL
SELECT p.name AS product, c.name AS category FROM Products AS p
LEFT JOIN ProdCat AS pc ON p.id = pc.products_id
INNER JOIN Category AS c ON c.id = pc.category_id
ORDER BY product;
````

