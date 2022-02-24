create table Delete_truncate(id int primary key identity(1,1),Productname varchar(20),Price decimal);
insert into Delete_truncate values('grains',2455.3);
insert into Delete_truncate values('suncream',2455.3);
insert into Delete_truncate values('facewash',2455.3);
insert into Delete_truncate values('oil',2455.3);
select * from Delete_truncate;--dml(data manuplication laguage) slower than trncate
delete from Delete_truncate where id=2;
truncate table Delete_truncate;--ddl(data defination language) its is fast 

