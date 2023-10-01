create table LoginDB (

	EmailID varchar(100) not null unique,
	Password nvarchar (50) not null

);

insert into LoginDB(EmailID, Password)
values ('abdullahashik666@gmail.com',1234);

insert into LoginDB(EmailID, Password)
values ('abdullah11@gmail.com',1234);

insert into LoginDB(EmailID, Password)
values ('ashik11@gmail.com',1234);

select * from LoginDB;
select * from crud;



CREATE TABLE crud (

	EmployeeID int not null unique,
	EmployeeName varchar(100) not null,
	EmployeeSalary int not null,
	EmployeeCity varchar(100) not null

);

