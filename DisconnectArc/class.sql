create database Day7Db
use Day7Db

create table Customer
(Id int primary key,
Name nvarchar(50) not null,
ODLimit float not null,
SStartDate date not null,
SEndDate date not null)

insert into Customer values (1,'Sam',598000,'12/12/2019','12/12/2024')
insert into Customer values (2,'Raj',698000,'12/11/2018','12/12/2025')
insert into Customer values (3,'Shafi',798000,'12/10/2017','12/12/2026')

select * from Customer