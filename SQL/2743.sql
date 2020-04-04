-- 2743 - Quantidade de Caracteres
select name, length(name) as "length" from people
order by length desc