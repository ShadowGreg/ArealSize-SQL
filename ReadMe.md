# Задание 1
 Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

- Юнит-тесты

- Легкость добавления других фигур

- Вычисление площади фигуры без знания типа фигуры в compile-time

- Проверку на то, является ли треугольник прямоугольным

Алгоритм решения задания по ссылке:

https://drive.google.com/file/d/1CP87JBZE3P-XxAOgjJgxL3iCvqO3Ss4-/view?usp=sharing

# Задание 2 
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

_Решение задачи:_

SELECT prod.name [продукт], cat.name [категория] FROM Products prod
    LEFT FOIN ProdCat prodcat ON prod.id = prodcat.products_id
    INNER JOIN Category cat ON cat.id = prodcat.category_id
ORDER BY prod.name;

## The employer wrote that this is a weak solution. If you have a desire, you can offer your options.
