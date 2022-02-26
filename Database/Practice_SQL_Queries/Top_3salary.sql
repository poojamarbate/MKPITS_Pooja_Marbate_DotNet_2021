use mydb_sql;
--drop table Organization;
create table Organization(EmpID int primary key identity(1,1),firstname varchar(20),lastname varchar(20),
salary decimal(10,2),Emp_address varchar(20),addresscode int);
insert into Organization values('Suraj','Marbate',75678.89,'Nagpur',440035);
insert into Organization values('Riya','sharvan',60000.89,'Raipur',440678);
insert into Organization values('sujal','Marbate',70000.89,'jaypur',445555);
insert into Organization values('ishant','sharma',69000.89,'khanpur',449090);
insert into Organization values('jay','sharma',45678.89,'dehli',440022);
insert into Organization values('raj','verma',45678.89,'mumbai',440023);

select * from Organization;

select top 1 salary from(select top 3 salary from Organization order by salary desc)as Emp order by salary asc;
---create sp
create proc spOrganization
as
begin
select * from Organization;
end

sporganization