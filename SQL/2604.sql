select products.name, providers.name from products, providers, categories
where products.id_providers = providers.id and products.id_categories = 6
group by products.name, providers.name
order by 1 desc