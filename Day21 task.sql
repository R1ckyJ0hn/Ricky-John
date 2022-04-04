use [Newdatabase]
go

create procedure sp_Enrolldata
as
select StudID,StuFullName,StuLAstNAme,Gender,EmailID,PhnNO
from tbl_enrollment

exec sp_Enrolldata

create procedure sp_EnrollDataBYstudID
@studid int
as
select StudID,StuFullName,StuLAstNAme,Gender,EmailID,PhnNO
from tbl_enrollment
where StudID= @studid

exec sp_EnrollDataBYstudID 193
go

select * from [dbo].[table2]
go


create procedure sp_insF
@name varchar (50)
as
insert into [dbo].[table2](StuName)
values (@name)

sp_insF 'BroCode'



select * from [dbo].[table2]




