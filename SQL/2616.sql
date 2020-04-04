-- 2616 - Nenhuma Locação
select c.id, c.name
from customers c
where not exists(select * from locations l 
                 where c.id = l.id_customers)
