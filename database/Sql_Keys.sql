use EmpData;
CREATE TABLE Employee3(employeeid int,employeename varchar(50),JobTitle varchar(50),Sallary int ,Dept_id int, project_id int);
insert into Employee3 Values(1,'Pratik','Software-Devloper',25000,1,1),
							(2,'Pankaj','Web-Devloper',35000,2,2),
							(3,'Mayur','QA',45000,3,3);

Create table Departments(deptId int,deptname varchar(50),cityId int);
insert into Departments Values  (1,'Hr-Dept',1),
								(2,'testing',2),
								(3,'Web-Dept',3);

create table Project(Projectid int, PName varchar(50));
insert into Project values(1,'Healthcare'),
						(2,'webService'),
						(3,'operation');

create table city(cityid int,cityName varchar(50));
insert into city Values(1,'Pune'),
					   (2,'Shirdi');

select * from Employee3;