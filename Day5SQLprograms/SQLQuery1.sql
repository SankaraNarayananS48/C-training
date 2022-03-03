
create table studreg(rollno varchar(10),name varchar(10),phoneno varchar(10));

create table marktable(rollno varchar(10),mark1 int,mark2 int,mark3 int);

select * from studreg;

select * from marktable;

select st.rollno,st.name,mk.mark1,mk.mark2,mk.mark3 from studreg st JOIN marktable  mk on st.rollno = mk.rollno;

insert into studreg values('73' ,'rakesh','1234567890')

select st.rollno,st.name,ISNULL(mk.mark1,0),ISNULL(mk.mark2,0),ISNULL(mk.mark3,0) from studreg st LEFT JOIN marktable  mk on st.rollno = mk.rollno;