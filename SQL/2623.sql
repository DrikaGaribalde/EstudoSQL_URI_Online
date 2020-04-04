-- 2623 - Categorias com Vários Produtos
select pd.name, c.name
from products pd inner join categories c
on pd.id_categories = c.id
where pd.amount > 100
and pd.id_categories in ('1','2','3','6','9')