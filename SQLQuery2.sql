create database AdvancedDb
use AdvancedDb

create table Emps
(Id int primary key,
Fname nvarchar(58) not null,
Lname nvarchar(58) not null,
Designation nvarchar(50),
Salary float,
DOJ date
)

insert into Emps values (1, 'Ajay', 'Kumar', 'Developer',90860.90,' 12/12/2021') 
Insert into Emps values (2, 'Vijay', 'Kiran', 'Tester', 85000.90, '02/01/2023')
insert into Emps values (3, 'Nishi', 'Vats', 'HR', 77000.90, '05/23/2020') 
insert into Emps values (9, 'Krunal', 'Garg', 'Developer', 98080.98, '02/25/2022')

select * from Emps