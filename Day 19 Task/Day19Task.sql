use [Newdatabase]
go 
create table Tbl_RegForm
(
SlNo int identity (101,1),
Fullname varchar(20),
Lastname varchar(20),
Gender char(2),
age int,
constraint ck_age check (age>18),
MailID varchar(20),
LocTion varchar(20),
EduQual varchar(10),
Backlog char(1),
PassoutYR int,
ColName Varchar(50),
cgpa int 
constraint ck_cgpa check (cgpa>6),
SchoolName varchar(50),
School_12th int,
constraint ck_12th check (School_12th>75),
School_10th int,
constraint ck_10th check (School_10th>60),
)
select*from [dbo].[Tbl_RegForm]

insert [dbo].[Tbl_RegForm] values ('Ricky','john','M',22,'rj27john2000','Chennai','B.E','0',2022,'sjce',8,'Stm',88,66)
insert [dbo].[Tbl_RegForm] values ('Giri','Dharan','M',24,'dhkjcjchs2000','Chennai','B.E','0',2022,'sjce',8,'Stm',86,69)
insert [dbo].[Tbl_RegForm] values ('sid','idhayathirudan','M',22,'ajdfnkdjs89','Chennai','B.E','0',2022,'sjce',8,'Stm',88,99)
insert [dbo].[Tbl_RegForm] values ('Anandh','thangam','M',22,'hasshdahs12','Chennai','B.E','0',2022,'sjce',7,'Stm',88,69)

alter table [dbo].[Tbl_RegForm]
add constraint pk_Sno primary key (Slno)