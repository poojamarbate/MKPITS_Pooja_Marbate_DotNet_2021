use ADO_Db;
Create table tbl_Course(CID int primary key Identity(1,1),
Course_name varchar(30));
insert tbl_Course values('Dotnet'),('Operation management'),
('Developer'),('Designer')
select * from tbl_Course;

create table tbl_Student(Id int primary key identity(101,1),
Student_name varchar(30),Email varchar(30),Fee money,CourseId int);

insert into tbl_student values('Rahul','rahul@123',5000,1);
select * from tbl_Student;

create proc SpGetAllCourse
as
begin
select * from tbl_Course;
end

create proc SpGetAllStudent
as
begin
select Id,Email,Fee,Course_name from tbl_Student,tbl_Course
where CourseId=CID
end

SpGetAllCourse

Spgetallstudent