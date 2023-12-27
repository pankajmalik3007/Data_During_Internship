use EMP_Details;
create table Employees(Employee_Id	int primary key, Employee_Name varchar(50),Jod_title varchar(50),Salary bigint,Dep_Id int,Project_Id int)

create table Departments(Dep_Id int primary key,Dep_Name varchar(20), City_Id int)

create table Project(Project_Id int primary key,Project_Name varchar(50))

create table City(City_Id int primary key,City_Name varchar(20),Country_Id int)

create table Country(Country_Id int primary key,Countri_Abbr varchar(10),Country_Name varchar(20))


insert into Employees values(101,'Pankaj','Software Engineer',40000,1,250),(102,'Pratik','Tester',40000,2,251)
							,(103,'Mayur','IT Coordinator',46000,3,252),(104,'Pawan','Trainee',60000,4,253)




insert into Departments values(1,'Data Analysis',1),(2,'Developer',2),(3,'hr',3),(4,'Training',4),(5,'Cybersecurity',5)

insert into Departments values(6,'Tester',6)



--------------- Foreign key for Emplpoyee From Department ---------
alter table Employees add constraint
FK_Employees_Departments foreign key (Dep_Id) references Departments(Dep_Id)
on delete cascade
on update cascade

------------INNER JOIN-----------------
select Employees.Employee_Name, Employees.Jod_title,Departments.Dep_Name from Employees inner join Departments on Employees.Dep_Id = Departments.Dep_Id






insert into City values(15,'Kopargaon',1),(17,'Shirdi',1),(43,'SambhajiNagar',1),(51,'Rajyastan',1),

(54,'Jaypur',22),(19,'Kashi',22),(65,'tamil',42),(81,'Surat',42)

insert into Country values(1,'MH','Maharastra'),(22,'AUS','Australia'),(42,'BI','Belgium')

------------------Foreign key for city from country---------------------
alter table City add constraint FK_City_Country foreign key (country_Id)
references Country(country_Id)
on delete cascade
on update cascade
------------INNER JOIN-----------------
Select City.City_Name,City.City_Id,Country.Countri_Abbr from City inner join Country on City.Country_Id = Country.Country_Id




Select * from Employees
select * from Departments
select * from Country
select * From City
Select * from Project