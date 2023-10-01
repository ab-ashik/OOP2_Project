select * from crud;
select * from LoginDB;

ALTER TABLE crud
ADD UNIQUE (EmployeeID); 

DROP TABLE CRUD;

CREATE TABLE crud (

	EmployeeID int not null unique,
	EmployeeName varchar(100) not null,
	EmployeeSalary int not null,
	EmployeeCity varchar(100) not null

);