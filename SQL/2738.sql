-- 2738 - Concurso
select c.name,round(((s.math*2)+(s.specific*3)+(s.project_plan*5))/ 10,2) as avg 
from candidate c, score s
where c.id = s.candidate_id
group by name, avg
order by avg desc

