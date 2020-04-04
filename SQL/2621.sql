-- 2621 - Quantidades Entre 10 e 20
select pd.name
from products pd, providers pv
where pd.amount between 10 and 20
and pv.id = pd.id_providers and 
pv.name like 'P%'