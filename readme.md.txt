1)��������� O(n), �.�. ���� � ������� � �������� � ��� �� ������ �(1)

2) SELECT ProductId, COUNT(ProductId) FROM SALES s1
INNER JOIN
(
	SELECT CustomerId, MIN(DateCreated) as DateCreated FROM SALES
	GROUP BY CustomerId
)s2
on s1.CustomerId = s2.CustomerID AND s1.DateCreated = s2.DateCreated
GROUP BY ProductId

3) ������. � ������ � ��� 23. ��������� ����������� �� c# �������� 2.5 ����. � ������ �� ������ �����������: asp.net mvc 4, web api 2, MongoDb, PostgreSql, MsSql. �� ������ ���� ��������� ������� � jquery, �� ����� ����, � �������� �� ��������� �� ���������� ���������� ���� ��������.

4) Skype: lokimora. �������� � ������ �� ������ � 7-8 ������, �.�. ��� �������. � �������� � ��� ����� �������� �����������. 