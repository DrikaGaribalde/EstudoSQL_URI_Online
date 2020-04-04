-- 2625 - Máscara de CPF
select substr(np.cpf,1,3)|| '.' || substr(np.cpf,4,3)|| '.' ||
substr(np.cpf,7,3)|| '-' || substr(np.cpf,10,2) as CPF
from natural_person np, customers c
where c.id = np.id_customers