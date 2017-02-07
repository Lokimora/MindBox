1)Сложность O(n), т.к. ищем в словаре у которого и так по поиску О(1)

2) SELECT ProductId, COUNT(ProductId) FROM SALES s1
INNER JOIN
(
	SELECT CustomerId, MIN(DateCreated) as DateCreated FROM SALES
	GROUP BY CustomerId
)s2
on s1.CustomerId = s2.CustomerID AND s1.DateCreated = s2.DateCreated
GROUP BY ProductId

![alt tag](https://i.ytimg.com/vi/fOE9vFtZooA/maxresdefault.jpg)
