select * from studreg

create proc select_studreg
as
select * from studreg;

create proc update_studreg
@rollno varchar(10),@name varchar(10),@phoneno varchar(10)
as
update studreg set name=@name,phoneno=@phoneno where rollno=@rollno

create proc delete_studreg
@rollno varchar(10)
as
delete from studreg where rollno=@rollno

