create database productdatabase

use  productdatabase

create table category(catid int,catname varchar(10))

create table subcategory(catid int,subcatid int,subcatname varchar(10))

create table product(catid int,subcatid int,prodid int,prodname varchar(10))

create proc insert_category
@id int,@name varchar(10)

as

insert into category values(@id,@name)

create proc insert_subcategoryy
@catid int,@subcatid int,@name varchar(10)

as

insert into subcategory values(@catid,@subcatid,@name)

create proc insert_product
@catid int,@subcat int,@prodid int,@prodname varchar(10)

as

insert into product values(@catid,@subcat,@prodid,@prodname)



create proc update_category
@catid int,@catname varchar(10)

as

update category set catname=@catname where catid = @catid

create proc update_subcategory
@catid int,@subcatid int,@subcatname varchar(10)

as

update subcategory set catid=@catid,subcatname=@subcatname where subcatid = @subcatid

create proc update_productt
@catid int,@subcatid int,@prodid int,@prodname varchar(10)

as

update product set catid=@catid,subcatid=@subcatid,prodname=@prodname where prodid = @prodid

create proc delete_category
@catid int

as

delete  from category where catid = @catid

create proc delete_subcategory
@subcatid int

as

delete  from subcategory where subcatid = @subcatid

create proc delete_product
@prodid int

as

delete  from product where prodid = @prodid

create proc select_category
as

select * from category;

create proc select_subcategory
as

select * from subcategory;

create proc select_product
as

select * from product;

select * from category

select * from subcategory

delete  from product where prodid = 1

insert into product values(3,2,1,'Apple');

insert into product values(1,2,3,'banana');

insert into product values(2,1,3,'cookie');

insert into product values(4,3,1,'biscuit');

insert into product values(1,1,2,'notebook');
insert into product values(1,3,1,'Atlas');
insert into product values(3,1,3,'choco');

create proc reportjoin
as
select c.catname,sc.subcatname from product p join category c on p.catid = c.catid join subcategory sc on p.subcatid = sc.subcatid 

delete from category where catid =1

delete from subcategory where catid =1

insert into category values(1,'CatA')

insert into category values(2,'CatB')

insert into category values(3,'CatC')

insert into category values(4,'CatD')

insert into subcategory values(1,1,'SubCatA1')

insert into subcategory values(1,2,'SubCatA2')

insert into subcategory values(1,3,'SubCatA3')

insert into subcategory values(2,1,'SubCatB1')

insert into subcategory values(3,1,'SubCatC1')

insert into subcategory values(3,2,'SubCatC2')

insert into subcategory values(4,3,'SubCatD1')

insert into subcategory values(1,1,'SubCatA')

create proc reporttjoin
as
select c.catname,sc.subcatname from product p join category c on p.catid = c.catid join subcategory sc on p.subcatid = sc.subcatid and p.catid = sc.catid where p.catid =@catid and p.subcatid = @subcatid

select c.catname,sc.subcatname from product p join category c on p.catid = c.catid join subcategory sc on p.subcatid = sc.subcatid and p.catid = sc.catid


create proc finalreport
@catid int,@subcatid int
as
select c.catname,sc.subcatname from product p join category c on p.catid = c.catid join subcategory sc on p.subcatid = sc.subcatid and p.catid = sc.catid where p.catid =@catid and p.subcatid = @subcatid

create table userlogintable(id varchar(10),password varchar(10))

create proc select_pass
@id varchar(10)
as
select password from userlogintable where id = @id

insert into userlogintable values('1','abcd')

insert into userlogintable values('2','efgh')

insert into userlogintable values('3','ijk')

insert into userlogintable values('4','lmn')

select * from userlogintable

create proc final
as
select * from product order by catid,subcatid,prodid

insert into userlogintable values('sankar','abc')
