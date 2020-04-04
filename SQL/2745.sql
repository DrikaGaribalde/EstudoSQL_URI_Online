-- 2745 - Taxas
select name, round(salary * 10/100,2) from people
where salary > 3000