Create database School1;
use  School1;
create table Student
(
Rollno Int,
FirstName varchar(200),
LastName varchar(20),
MobNo varchar(20),
Email varchar (25),
Adress varchar(20)
);
insert into Student values
(1,"Pankaj","Malik","9284373007","p@gmail.com","Rahata"),
(2,"Rahul","Malik","9284373007","R@gmail.com","Shirdi"),
(3,"Pratik","Nanavare","9284373007","p@gmail.com","Dhamori"),
(4,"Pawan","Sonawane","9284373007","p@gmail.com","Delhi"),
(5,"mayur","Runwal","9284373007","m@gmail.com","Kopargaon"),
(6,"Sanket","Malik","9284373007","sa@gmail.com","Kopargaon"),
(7,"Vishal","Deshmukh","9284373007","vi@gmail.com","Mumbai");

alter table student
add DOB date;

alter table Student
drop column DOB;

alter table Student
rename column RollNo to Stud_ID;

update Student set Firstname = 'Santosh' , Adress = 'pune' where Stud_Id = 4;

delete from student where FirstName = "Vishal";

select * from Student;