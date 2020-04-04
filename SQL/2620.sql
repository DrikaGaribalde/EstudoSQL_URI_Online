-- 2620 - Pedidos no Primeiro Semestre
select distinct c.name, o.id
from customers c, orders o
where orders_date between '2016-01-01' and '2016-06-30'
and c.id = o.id_customers 
order by o.id
