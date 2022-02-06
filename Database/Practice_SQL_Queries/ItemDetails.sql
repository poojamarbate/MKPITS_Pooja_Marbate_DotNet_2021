use mydb_sql;
create table ItemDetails(ItemID int primary key Identity(1,1),ItemName varchar(30),ItemPrice decimal,
ItemCode binary,MFD date);
insert into ItemDetails values('Biscuits',245.6,0101,'2012-12-3');
insert into ItemDetails values('Ice-creams',400.6,0011,'2012-10-3');
insert into ItemDetails values('Grains',245.6,0111,'2012-11-3');
insert into ItemDetails values('Shampoo',245.6,1101,'2012-12-3');
insert into ItemDetails values('HAmdwash',245.6,0100,'2012-12-3');
insert into ItemDetails values('MilkPowder',245.6,0100,'2012-12-3');
insert into ItemDetails values('OOATS',245.6,1111,'2012-12-3');
insert into ItemDetails values('Wapess',245.6,0000,'2012-12-3');
insert into ItemDetails values('Cholates',245.6,0110,'2012-12-3');
insert into ItemDetails values('Cookies',245.6,0101,'2012-12-3');
select cast(0x65 as varchar);--Cast function is used to Change binary to varchar data.
select Distinct Itemname,MFD from ItemDetails;--selecting different values of Column
select COUNT(Distinct Itemname)from ItemDetails;
select Itemname from ItemDetails where ItemID=1;
select * from ItemDetails;
select Itemname from ItemDetails order by ItemName asc;
select Itemname from ItemDetails order by ItemName desc;
update ItemDetails set Itemname='HAPPYHAPPY'WHERE ITEMID=1;
delete from ItemDetails where ItemID=10;
delete from ItemDetails;--delete all data from table
SELECT TOP 3 * FROM ItemDetails;
--SELECT * FROM ItemDetails fetch first 3 rows only;
SELECT TOP 50 PERCENT * FROM  ItemDetails;