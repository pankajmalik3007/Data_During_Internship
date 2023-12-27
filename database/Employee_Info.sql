use Employee;

create table Emp
( empid int auto_increment primary key, empname varchar(20), job_Title varchar(25), sallary int,
  dept_name varchar(30), Project_name varchar(30)
);
insert into  Emp (empname,job_Title,sallary,dept_name,Project_name)
				 values ('Pankaj','Software Devloper',35000,'Web Devlopement','healthcare'),
						('Rahul','trainee',45000,'HrDept','E-Commerse'),
                        ('Pratik','Automation',25000,'Web Devlopement','Banking'),
                        ('Pawan','Automation',15000,'HrDept','healthcare'),
                        ('Mayur','traineer',25000,'Web Devlopement','Banking'),
                        ('Rohan','Software Devloper',35000,'HrDept','healthcare'),
                        ('Sawant','Automation',45000,'Web Devlopement','healthcare'),
                        ('roshni','trainee',55000,'HrDept','healthcare'),
                        ('santosh','Software Devloper',65000,'Web Devlopement','healthcare'),
                        ('sandy','Automation',33000,'HrDept','healthcare'),
                        ('Sanjay','trainee',55000,'Web Devlopement','Banking'),
                        ('Sanket','Software Devloper',60000,'HrDept','healthcare'),
                        ('pranjal','trainee',35000,'Web Devlopement','healthcare'),
                        ('devesh','Software Devloper',34000,'HrDept','Banking'),
                        ('swarup','Automation',35000,'Web Devlopement','healthcare'),
                        ('nandu','traineer',35000,'HrDept','healthcare'),
                        ('shikhar','Software Devloper',35000,'Web Devlopement','Banking'),
                        ('virat','Software Devloper',35000,'HrDept','healthcare'),
                        ('dhoni','Automation',35000,'HrDept','healthcare'),
                        ('dhananjay','trainee',35000,'Web Devlopement','Banking');
	
    
    select * from Emp;
    
    select * from Emp
    order by empname asc;
    
    select * from Emp
    order by empname desc;
    
    select * from Emp 
    order by dept_name asc;
    
    select * from Emp
    where empname = 'Pankaj' or sallary = 3522000;
    
    select * from Emp
    where dept_name = 'HrDept' and Project_name = 'Banking';
    
    select * from Emp
    where not empname = 'pankaj';
    
    select * from Emp 
    where job_Title = 'Software Devloper' and (dept_name = 'Hrdept' or dept_name = 'Web Devlopement');
    
    alter table Emp
    add email varchar (255);
    
    select * from Emp;
    
    update Emp set email = 'Pankaj@123' where empid = 1; 
    
    update Emp set email = "Rahul@123" where empid = 2;
    
    select * from Emp;
    
    alter table Emp 
    drop Project_name;
    
      select * from Emp;
    
