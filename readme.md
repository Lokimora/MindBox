1)Сложность O(n), т.к. ищем в словаре у которого и так по поиску О(1)

2) SELECT ProductId, COUNT(ProductId) FROM SALES s1
INNER JOIN
(
	SELECT CustomerId, MIN(DateCreated) as DateCreated FROM SALES
	GROUP BY CustomerId
)s2
on s1.CustomerId = s2.CustomerID AND s1.DateCreated = s2.DateCreated
GROUP BY ProductId

3) Привет. Я Андрей и мне 23. Занимаюсь разработкой на c# примерно 2.5 года. В работе по стекам использовал: asp.net mvc 4, web api 2, MongoDb, PostgreSql, MsSql. Из фронта знаю дефолтную верстку с jquery, но опыта мало, и хотелось бы пересесть на нормальные фреймворки типа ангуляра.

4) Skype: lokimora. Свободен я обычно по будням с 7-8 вечера, т.к. еще работаю. В выходные я все время свободен естественно. 