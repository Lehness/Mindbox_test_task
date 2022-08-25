
-- ��� ����������� ����� "������ �� ������" ���� ������������ ������������� ������� "Relation"
-- ��������� ������ ����� ���������� �� ��������� 
select 
	p.Product,
	c.Category
from Products p 
left join 
Relation r 
on p.id = r.id_product 
left join 
Categories c 
on c.id = r.id_category 

