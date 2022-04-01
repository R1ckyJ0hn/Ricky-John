use AdventureWorks2019
go
-----Task 1--------
select FirstName,LastName
from Person.Person 
where Title is not null

-------task  2--------

select FirstName,LastName
from Person.Person 
where FirstName like'%a%' or LastName like '%a%'

-------task  3--------
select sal.Name as [CurrencyCode],[Name]
from [Sales].[Currency] sal
join [Sales].[CountryRegionCurrency] salcrc
on sal.[CurrencyCode]=salcrc.[CurrencyCode]
create view View_Currency
as
select [CurrencyCode],[Name]
from [Sales].[Currency]
go
select * from View_Currency

-------task  4--------


-------task  5--------
create table NewTable
(
Sno int identity(1,1),
FName varchar(50),
LName varchar(50),
Gender char,
ModifiedDate date default getdate()
)
insert into NewTable (Fname,LName,Gender)values('HARIS','S','M')
insert into NewTable (Fname,LName,Gender)values('JAGA','Z','M')
insert into NewTable (Fname,LName,Gender)values('GIRI','S','M')
insert into NewTable (Fname,LName,Gender)values('VENKAT','I','M')
insert into NewTable (Fname,LName,Gender)values('ABDUL','L','M')

select * from NewTable


-------task  6---------

select BusinessEntityID, AddressTypeID
from Person.BusinessEntityAddress

-------task  7--------

select distinct GroupName
from HumanResources.Department

-------task  8--------

select cosh.StandardCost,Sum(cosh.StandardCost) as STanCost , Sum(ListPrice) as Tot_Listprice
from Production.Product prod, Production.ProductCostHistory cosh
group by cosh.StandardCost


-------task  9--------

select BusinessEntityID,DATEDIFF (YY,StartDate,EndDate) as YearsOnAge
from HumanResources.EmployeeDepartmentHistory 

-------task  10--------
select sum(SalesQuota) as SumOfSalesQuota
 from Sales.SalesPersonQuotaHistory
 where SalesQuota>5000 and salesquota<100000
 group by SalesQuota

-------task  11--------

select Max(TaxRate) as Max_TaxRate
from [Sales].[SalesTaxRate]

-------task  12 & task 13--------
create view View_name
as
select His.ShiftID,Emp.BirthDate,datediff(YY,emp.BirthDate,Getdate()) as age
from HumanResources.Employee emp
join HumanResources.EmployeeDepartmentHistory His
on His.BusinessEntityID=emp.BusinessEntityID
join HumanResources.Department dept
on His.BusinessEntityID =dept.DepartmentID

go

select*from View_name
-------task  14--------

select Count(*) as NoOfRowns_inHR
from [HumanResources].[Department],[HumanResources].[EmployeePayHistory],[HumanResources].[JobCandidate],[HumanResources].[Shift]

-------task  15--------

select max(rate) MaxRateOfEachDept,Name
from HumanResources.EmployeePayHistory pay
join HumanResources.EmployeeDepartmentHistory dhis
on pay.BusinessEntityID = dhis.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID = dhis.DepartmentID
GRoup By name


-------task  16--------


select ent.BusinessEntityID,Title,FirstName,MiddleName,LastName,AddressTypeID
from Person.Person per
left outer join Person.BusinessEntityAddress ent
on per.BusinessEntityID= ent.BusinessEntityID
where Title is not null

-------task  17----------

select Shelf,ProductID,LocationID
from Production.ProductInventory
where ProductID>300 and ProductID<350 and Shelf='E'


-------task  18----------

select ProductID,inv.LocationID,Shelf,Name
from Production.ProductInventory inv
join Production.Location loc
on inv.LocationID = loc.LocationID

-------task  19----------

select AddressID,AddressLine1,AddressLine2, pa.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince psp
join Person.Address pa
on psp.StateProvinceID=pa.StateProvinceID

-------task  20----------

select sum(SubTotal),sum(TaxAmt)
from Sales.CountryRegionCurrency reg
join sales.SalesTerritory ster
on reg.CountryRegionCode= ster.CountryRegionCode
join Sales.SalesOrderHeader hed
on ster.TerritoryID = hed.TerritoryID 
group by ster.TerritoryID




