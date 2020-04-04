-- 2739 - Dia de Pagamento
select name, cast(extract(day from payday)as integer)as day from loan
