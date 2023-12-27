create database School;
use School;
create table Student
(
Rollno Int,
FirstName varchar(200),
LastName varchar(20),
Adress varchar(20)
);
insert into Student (Rollno,FirstName,LastName,Adress)
values(1,'Pankaj','Malik','Kopargaon');
insert into Student values(2,'Pratik','Navanare','Shirdi');

update Student set FirstName = 'PAWAN', Adress = 'Kasali' where Rollno = 1;

select * from Student where Rollno =1;

select FirstName from Student ;
select adress from Student;

delete from Student where Rollno = 2;

select*from Student;