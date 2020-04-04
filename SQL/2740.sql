-- 2740 - Liga
(select 'Podium: '|| team as name from league limit 3)
union all
select 'Demoted: '|| team as name from league
where position > (select count(*)-2 from league)
