use mydb_sql;
--display the current date and time
select getdate();
--DROP TABLE Employee_salary;
create table Employee_salary(Emp_id int primary key IDENTITY(1,1),Employee_name varchar(20),Emp_sal int);
insert into Employee_salary values('RRR',4567);
insert into Employee_salary values('SSS',4999);
insert into Employee_salary values('RQE',4777);
insert into Employee_salary values('OQP',6666);
insert into Employee_salary values('PPP',5000);
SELECT * FROM Employee_salary;

SELECT TOP 1 Emp_sal FROM
(SELECT TOP 3 Emp_sal FROM Employee_salary ORDER BY Emp_sal DESC )
AS EMP ORDER BY Emp_sal ASC;