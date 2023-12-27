use Employee_Info;
Alter table Employee
add Constraint FK_Employee_Project foreign key (Project_id)
references Project(Projectid)
on delete cascade
on update cascade


select * from Employee5;

select Employee.employeeid, Employee.employeename, project.pname from employee inner join project on employee.project_id=project.projectid;