select * from studentlogin;

create database votedatabase;

use votedatabase;

create table politicalparty(id int,name varchar(10))

create table city(id int,name varchar(10))

create table nominationlist(cityid int,partyid int)

create table votecount(cityid int,partyid int,countofvote int)


create proc insert_party
@id int,@name varchar(10)

as

insert into politicalparty values(@id,@name)


create proc insert_city
@id int,@name varchar(10)

as

insert into city values(@id,@name)


create proc insert_nominationlistt
@cityid int,@partyid int

as

insert into nominationlist values(@cityid,@partyid)


create proc update_party
@id int,@name varchar(10)

as

update politicalparty set name=@name where id = @id


create proc update_city
@id int,@name varchar(10)

as

update city set name=@name where id = @id

create proc update_nominationlist
@cityid int,@partyid int

as

update nominationlist set partyid=@partyid where cityid = @cityid


create proc delete_party
@id int,@name varchar(10)

as

delete  politicalparty where id = @id


create proc delete_city
@id int,@name varchar(10)

as

delete  city where id = @id


create proc delete_nominationlist
@cityid int,@partyid int

as

delete  nominationlist where partyid = @partyid


select * from politicalparty


select * from city;

select * from nominationlist;



create proc select_party
as

select * from politicalparty;

create proc select_city
as

select * from city;

create proc select_nominationlist
as

select * from nominationlist;


create proc select_nominatedparty
@cityid int

as

select partyid from nominationlist where cityid = @cityid


create proc select_partyname
@partyid int

as

select  ISNULL(name,0) from politicalparty where id = @partyid

select * from politicalparty

select * from nominationlist

insert into politicalparty values(4,'MMK')

insert into politicalparty values(3,'ADMK')

insert into politicalparty values(2,'Cong')

insert into nominationlist values(2,1)

insert into nominationlist values(2,2)

insert into nominationlist values(2,3)

insert into nominationlist values(2,4)


update politicalparty set name ='DMK' where id = 1

select ISNULL(countofvote,0) from votecount where cityid = 1 and partyid = 1

create proc insert_vote
@cityid int,@partyid int,@countofvote int

as
insert into votecount values(@cityid,@partyid,@countofvote)

create proc get_votecount
@cityid int,@partyid int,@countofvote int

as
select ISNULL(countofvote,0) from votecount where cityid = @cityid and partyid = @partyid

select * from votecount

delete from city where id = 1

insert into city values(1,'chennai')

select * from city

update city set name ='madurai' where id = 2

insert into city values(3,'Erode')

insert into city values(4,'TVL')

insert into city values(5,'TTY')

create proc update_vote
@cityid int,@partyid int,@countofvote int

as
update votecount set countofvote=@countofvote where cityid = @cityid and partyid = @partyid

delete from votecount where cityid = 1;

create proc get_votecounnt
@cityid int,@partyid int

as
select ISNULL(countofvote,0) from votecount where cityid = @cityid and partyid = @partyid

create proc report
as
select cityid,partyid,countofvote from votecount order by cityid,partyid,countofvote

create proc reporrt
as
select cityid,partyid,countofvote from votecount order by cityid,countofvote desc


select vc.cityid,p.name,vc.countofvote from votecount vc  join politicalparty p on vc.partyid = p.id order by cityid,countofvote desc


create proc repoort
as
select vc.cityid,p.name,vc.countofvote from votecount vc  join politicalparty p on vc.partyid = p.id order by cityid,countofvote desc


select * from votecount

select * from politicalparty order by id

delete from politicalparty where id = 5

delete from politicalparty where id = 6

select * from city order by id

select cy.name,p.name,vc.countofvote from votecount vc  join politicalparty p join city cy on vc.partyid = p.id , cy.id = vc.cityid order by cy.name,countofvote desc



create proc select_partynamee
@partyid int

as

select  ISNULL(name,0) from politicalparty where id = @partyid

select * from nominationlist;

select * from politicalparty;


create proc finalreport
as

select cy.name,p.name,vc.countofvote from votecount vc  join politicalparty p  on vc.partyid = p.id join city cy on cy.id = vc.cityid order by cy.name,countofvote desc