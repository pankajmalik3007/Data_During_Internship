use sakila;
select * from actor;


/* Like As Operator*/
select * from actor where last_name like '%s';
select * from actor where last_name like 's%';
select * from actor where last_name like '%s%';

/* Between and AND operator*/
select * from actor where actor_id between 1 and 20;
select * from actor where last_name between 'GUINESS' and 'CAGE'; 

/* Arithmetic op*/
select 30 + 20;
alter table actor Add Sallary double;
update actor set Sallary  = 15000 where actor_id between 1 and 30;
select * from actor;

select 40 - 50;
select 40 / 50;
select 40 * 50;


/* Comparison Operator */
select * from actor
where last_name = 'TRACY';

select * from actor 
where last_name >= 'TRACY';

select * from actor 
where last_name <> 'TRACY';
