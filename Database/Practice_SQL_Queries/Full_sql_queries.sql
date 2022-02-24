use myDB_SQL;
create table Students(Rollno int primary key identity(1,1),Firstname varchar(20),
lastname varchar(20),Addresscode int);
insert into Students values('ishan','sharmar',234);
insert into Students values('Gishan','shahu',555);
insert into Students values('hishan','singh',244);
insert into Students values('prishan','varma',256);
select * from students;

create table Homeadd(Id int primary key identity(1,1),addresscode int,City varchar(20));
insert into Homeadd values(234,'nagpur');
insert into Homeadd values(555,'jaypur');
insert into Homeadd values(244,'rampur');
insert into Homeadd values(256,'solapur');
select * from Homeadd;

select count(*) from Homeadd; 
select firstname,lastname from Students where Addresscode in
                                   (select Addresscode from Homeadd where City='solapur');


select rollno from students
   intersect
select Id from Homeadd;

select rollno from students
  UNION
select Id from Homeadd;

--alias name
select Stud.rollno,hadd.Id from Students stud,Homeadd as hadd
where stud.Rollno=hadd.Id;

create table Student_table(ID int identity(1,1),studentName varchar(20),Marks int,Age int);
insert into Student_table values('Harsh',90,19);
insert into Student_table values('suresh',50,20);
insert into Student_table values('pratik',80,19);
insert into Student_table values('dhanraj',95,21);
insert into Student_table values('ram',85,18);

select * from Student_table;

--aggregate funtion
select AVG(marks)as average_marks from Student_table;
select avg(age)as average_age from  Student_table;
select count(*) as number_student from  Student_table;
select count(distinct age) as number_student from  Student_table;
select MAX(MARKS) AS MARKSFIRST FROM Student_table;
select MIN(MARKS) AS MARKSFIRST FROM Student_table;
select sum(marks) as total from  Student_table;


--display even number record

select* from Student_table where studentName like '%h';
select* from Student_table where studentName like 'p%';
select* from Student_table where studentName like '%esh%';

--unique record selected 
select distinct studentname from Student_table;

--fetch first 5 character of string
select SUBSTRING(studentname,1,4) as studentname from Student_table;--starting se fetch 
select RIGHT(studentname,3)as student_Name from Student_table;--ending fetch

--how to create stored procdure
Create Procedure spList
as
begin
select * from Student_table where id=1;
end

create proc spstudent
as
begin
select * from Student_table;
end


spList
execute splist
exec spList

--how to modified sp
alter proc spstudent
as
begin
select * from Student_table;
select * from Student_table where marks=95;
end
spstudent

--drop procedure
Drop proc splist


--parameters in stored procdure
create proc spParaList
@marks int,
@studentname varchar(30)
as
begin
select * from Student_table where Marks=@marks;
select * from Student_table where studentName=@studentname;
end

spParaList @studentname='dhanraj',@marks=95

--output parameter
create proc spAddition
@num1 int,
@num2 int,
@result int output
as
begin
set @result=@num1+@num2;
end

declare @Id int
exec spAddition 23,27,@Id output
select @Id as Total;


--stored procedure security with encryption
sp_helptext spAddition

--store procedure Secure
alter proc spAddition
@num1 int,
@num2 int,
@result int output
with encryption
as
begin
set @result=@num1+@num2;
end
