-- 2618 - Produtos Importados
select pd.name, pv.name, c.name
from products pd, providers pv, categories c
where pv.name = 'Sansul SA' and 
      c.name = 'Imported' and 
      pv.id = pd.id_providers and
      c.id  = pd.id_categories
      