use master
GO
IF EXISTS(SELECT * FROM sys.sysdatabases WHERE name='WSC2019_Session2')
DROP DATABASE WSC2019_Session2
GO
CREATE DATABASE WSC2019_Session2
GO
USE WSC2019_Session2

go
create table AssetGroups(
	ID nvarchar(100) primary key,
	Name nvarchar(100)
)

go 
create table Employees (
	ID nvarchar(100) primary key,
	FirstName nvarchar(100),
	LastName nvarchar(100) ,
	Phone  nvarchar(100) ,
	isAdmin bit,
	Usernname nvarchar(100),
	Password nvarchar(100)
)

go 
create table Priorities(
	ID nvarchar(100) primary key,
	Name nvarchar(100)
)

go
create table Locations(
	ID nvarchar(100) primary key,
	Name nvarchar(100)
)

go
create table Departments(
	ID nvarchar(100) primary key,
	Name nvarchar(100)
)

go 
create table Parts(
	ID nvarchar(100) primary key,
	Name nvarchar(100),
	EffectiveLife nvarchar(100)
)

go
create table DepartmentLocations (
	ID nvarchar(100) primary key,
	DepartmentID nvarchar(100),
	LocationID nvarchar(100),
	StartDate date,
	EndDate date,
	constraint FK_DepartmentLocations_Departments foreign key (DepartmentID) references Departments(ID),
	constraint FK_DepartmentLocations_Locations foreign key (LocationID) references Locations(ID)
)

go
create table Assets(
	ID nvarchar(100) primary key,
	AssetSN NVARCHAR(100),
	AssetName nvarchar(100),
	DepartmentLocationID nvarchar(100),
	EmployeeID nvarchar(100),
	AssetGroupID nvarchar(100),
	Description nvarchar(100),
	WarrantyDate date,
	constraint FK_Assets_AssetGroups foreign key (AssetGroupID) references AssetGroups(ID),
	constraint FK_Assets_DeparmentLocations foreign key (DepartmentLocationID) references DepartmentLocations(ID),
	constraint FK_Assets_Employee foreign key (EmployeeID) references Employees(ID)
)

go
create table EmergencyMaintenances (
	ID INT IDENTITY(1, 1) PRIMARY KEY ,
	AssetID nvarchar(100),
	PriorityID nvarchar(100),
	DescriptionEmergency nvarchar(100),
	OtherConsiderations nvarchar(100),
	EMReportDate date,
	EMStartDate date,
	EMEndDate date,
	EMTechnicianNote nvarchar(100),
	constraint FK_EmergencyMaintenances_Assets foreign key (AssetID) references Assets(ID),
	constraint FK_EmergencyMaintenances_Priorities foreign key (PriorityID) references Priorities(ID)
)

go
create table ChangedParts (
	ID nvarchar(100) primary key,
	EmergencyMaintenanceID INT,
	PartID nvarchar(100),
	Amount float ,
	constraint FK_ChangedParts_EmergencyMaintenances foreign key (EmergencyMaintenanceID) references EmergencyMaintenances(ID),
	constraint FK_ChangedParts_Parts foreign key (PartID) references Parts(ID)
)
SELECT * FROM dbo.ChangedParts
insert into AssetGroups values ('asg1','Asset Group 1')
insert into AssetGroups values ('asg2','Asset Group 2')
insert into AssetGroups values ('asg3','Asset Group 3')
insert into AssetGroups values ('asg4','Asset Group 4')
insert into AssetGroups values ('asg5','Asset Group 5')
SELECT * FROM dbo.AssetGroups

insert into Employees values ('emp7','Doan Quang','Vinh','18082010',1,'admin','admin')
insert into Employees values ('emp6','Nguyen Duc','Linh','0123456',0,'linh','abc123')
insert into Employees values ('emp3','Pham Thi Hai','Yen','012345678',0,'user3','abc123')
insert into Employees values ('emp4','Nguyen Cong','Thang','0123456789',0,'user4','abc123')
insert into Employees values ('emp5','Nguyen Hai','Duong','9213903',0,'user5','abc123')
SELECT * FROM dbo.Employees

insert into Priorities values ('prio1','Very High')
insert into Priorities values ('prio2','High')
insert into Priorities values ('prio3','Normal')
SELECT * FROM dbo.Priorities

insert into Locations values ('loc1','Ha Noi')
insert into Locations values ('loc2','Ho Chi Minh')
insert into Locations values ('loc3','Da Nang')
insert into Locations values ('loc4','Nha Trang')
insert into Locations values ('loc5','Ninh Binh')
SELECT * FROM dbo.Locations

insert into Departments values ('dep1','Department 1')
insert into Departments values ('dep2','Department 2')
insert into Departments values ('dep3','Department 3')
insert into Departments values ('dep4','Department 4')
insert into Departments values ('dep5','Department 5')
SELECT * FROM dbo.Departments

insert into Parts values ('p1','Part 1','EffectiveLife 1')
insert into Parts values ('p2','Part 2','EffectiveLife 2')
insert into Parts values ('p3','Part 3','EffectiveLife 3')
insert into Parts values ('p4','Part 4','EffectiveLife 4')
insert into Parts values ('p5','Part 5','EffectiveLife 5')
SELECT * FROM dbo.Parts 

insert into DepartmentLocations values ('dep_loc1','dep1','loc1','2019/10/21','2019/10/21')
insert into DepartmentLocations VALUES ('dep_loc2','dep2','loc2','2019/10/21','2019/10/22')
insert into DepartmentLocations VALUES ('dep_loc3','dep3','loc3','2019/10/21','2019/10/23')
insert into DepartmentLocations VALUES ('dep_loc4','dep4','loc4','2019/10/21','2019/10/23')
insert into DepartmentLocations VALUES ('dep_loc5','dep5','loc5','2019/10/21','2019/10/23')
 SELECT * FROM dbo.DepartmentLocations


insert into Assets values ('as1','019/11/20','Assets 1','dep_loc1','emp6','asg1','descrition 1','2019/10/24')
insert into Assets VALUES ('as2','019/11/24','Assets 2','dep_loc2','emp6','asg2','descrition 2','2019/10/25')
insert into Assets VALUES ('as3','019/12/09','Assets 3','dep_loc3','emp6','asg3','descrition 3','2019/10/26')
insert into Assets VALUES ('as4','019/12/23','Assets 4','dep_loc4','emp6','asg4','descrition 4','2019/10/27')
insert into Assets VALUES ('as5','019/80/11','Assets 5','dep_loc4','emp7','asg4','descrition 4','2019/10/27')
insert into Assets VALUES ('as6','018/10/01','Assets 6','dep_loc4','emp7','asg4','descrition 4','2019/10/27')
insert into Assets VALUES ('as7','019/10/22','Assets 7','dep_loc4','emp7','asg4','descrition 4','2019/10/27')
insert into Assets VALUES ('as8','019/10/22','Assets 8','dep_loc4','emp7','asg4','descrition 4','2019/09/14')
insert into Assets VALUES ('as9','019/10/22','Assets 9','dep_loc4','emp7','asg4','descrition 4','2019/09/14')
SELECT * FROM dbo.Assets

go
insert into EmergencyMaintenances values('as1','prio1','Description emergency 1','OtherConsideration 1','2019/10/11','2019/10/31',NULL,'abcxyz')
insert into EmergencyMaintenances values('as2','prio2','Description emergency 2','OtherConsideration 2','2019/11/1','2019/11/1','2019/11/2','abcxyz')
insert into EmergencyMaintenances values('as3','prio3','Description emergency 3','OtherConsideration 3','2019/11/2','2019/11/2','2019/11/3','abcxyz')
insert into EmergencyMaintenances values('as4','prio3','Description emergency 4','OtherConsideration 4','2019/11/3','2019/11/3','2019/11/4','abcxyz')
insert into EmergencyMaintenances values('as4','prio3','Description emergency 4','OtherConsideration 4','2019/11/3','2019/11/3','2019/11/4','abcxyz')
insert into EmergencyMaintenances values('as4','prio3','Description emergency 4','OtherConsideration 4','2019/11/3','2018/1/3','2017/12/4','abcxyz')
insert into EmergencyMaintenances values('as4','prio3','Description emergency 4','OtherConsideration 4','2019/11/1','2018/1/30',NULL,'abcxyz')
insert into EmergencyMaintenances values('as5','prio2','Description emergency 5','OtherConsideration 5','2019/11/1','2018/1/30','2017/03/13','abcxyz')
insert into EmergencyMaintenances values('as5','prio2','Description emergency 5','OtherConsideration 5','2019/11/1','2018/1/30',null,'abcxyz')
insert into EmergencyMaintenances values('as6','prio2','Description emergency 5','OtherConsideration 5','2019/11/10','2018/1/30',null,'abcxyz')
insert into EmergencyMaintenances values('as7','prio1','Description emergency 5','OtherConsideration 5','2019/11/10','2018/1/30',null,'abcxyz')
insert into EmergencyMaintenances values('as8','prio3','Description emergency 5','OtherConsideration 5','2019/07/20','2018/12/10',null,'abcxyz')
insert into EmergencyMaintenances values('as9','prio2','Description emergency 5','OtherConsideration 5','2019/1/20','2018/12/10',null,'abcxyz')

--DELETE dbo.EmergencyMaintenances WHERE EMEndDate IS NULL
SELECT * FROM dbo.EmergencyMaintenances
go
insert into ChangedParts values ('chp1',1,'p1',1000)
insert into ChangedParts VALUES ('chp2',2,'p2',2000)
insert into ChangedParts VALUES ('chp3',3,'p3',3000)
insert into ChangedParts VALUES ('chp4',4,'p4',4000)
insert into ChangedParts VALUES ('chp5',5,'p5',4000)
insert into ChangedParts VALUES ('chp6',6,'p4',4000)
insert into ChangedParts VALUES ('chp7',7,'p3',4000)
insert into ChangedParts VALUES ('chp8',8,'p2',4000)
insert into ChangedParts VALUES ('chp9',9,'p1',4000)

SELECT * FROM dbo.ChangedParts WHERE EmergencyMaintenanceID=1


--GO
--ALTER PROC sp_AvailableAssets
--@EmployeeID NVARCHAR(100)
--AS
--BEGIN
--    SELECT AssetID, AssetSN, AssetName,CONVERT(CHAR(10), MAX(EMEndDate),103) AS LastEMEndDate, COUNT(AssetID) AS NumberOfEMs
--	FROM dbo.Assets INNER JOIN dbo.EmergencyMaintenances ON EmergencyMaintenances.AssetID = Assets.ID
--	WHERE EmployeeID=@EmployeeID AND EMEndDate IS NOT NULL
--	GROUP BY AssetID, AssetSN, AssetName
--	UNION 
--	SELECT AssetID, AssetSN, AssetName,'-',  0 AS NumberOfEMs
--	FROM dbo.Assets INNER JOIN dbo.EmergencyMaintenances ON EmergencyMaintenances.AssetID = Assets.ID
--	WHERE EmployeeID=@EmployeeID AND EMEndDate IS NULL  
--		AND AssetID NOT IN (SELECT AssetID FROM dbo.EmergencyMaintenances WHERE EMEndDate IS NOT NULL)
	
--END
----DROP PROC sp_AvailableAssets
--go
--EXEC dbo.sp_AvailableAssets @EmployeeID = N'emp2' -- nvarchar(100)
--GO

--ALTER PROC sp_ListOfAssets
--AS
--BEGIN
--    SELECT EmergencyMaintenances.ID, AssetID,AssetSN, AssetName, EMReportDate, 
--	(FirstName+' '+LastName) AS Fullname, Departments.Name AS DepartmentName,
--	 Priorities.Name AS PriorityName
--	FROM dbo.Assets INNER JOIN dbo.EmergencyMaintenances 
--	ON EmergencyMaintenances.AssetID = Assets.ID
--	INNER JOIN dbo.Employees ON Employees.ID = Assets.EmployeeID
--	INNER JOIN dbo.DepartmentLocations ON DepartmentLocations.ID = Assets.DepartmentLocationID
--	INNER JOIN dbo.Departments ON Departments.ID = DepartmentLocations.DepartmentID
--	INNER JOIN dbo.Priorities ON Priorities.ID = EmergencyMaintenances.PriorityID
--	WHERE EMEndDate IS NULL 
	
--END
--GO
----DROP PROC dbo.sp_ListOfAssets 
--EXEC dbo.sp_ListOfAssets
--GO

--CREATE PROC sp_loadReplaceDepartment
--@ID INT 
--AS
--BEGIN
--    SELECT ChangedParts.ID, Name, Amount, 'Remove' AS Action FROM dbo.Parts 
--	INNER JOIN dbo.ChangedParts ON ChangedParts.PartID = Parts.ID
--	WHERE EmergencyMaintenanceID = @ID
--END
--EXEC dbo.sp_loadReplaceDepartment @ID = 1 -- int




alter proc SP_GetdgvEmergency (@username nvarchar(100))
as begin
	select 
		AssetSN, AssetName, MAX(EMEndDate) as LastClosedEM, count(AssetID) as NumberOfEMs, Assets.ID as AssetID
	from
		Assets inner join EmergencyMaintenances on Assets.ID = EmergencyMaintenances.AssetID
		inner join Employees on Employees.ID = Assets.EmployeeID
	where 
		@username = Employees.Usernname and EMEndDate is not null
	group by AssetSN, AssetName,Assets.ID
	union
	select 
		AssetSN, AssetName, NULL as LastClosedEM, 0 as NumberOfEms, Assets.ID as AssetID
	from 
		Assets inner join EmergencyMaintenances on Assets.ID = EmergencyMaintenances.AssetID
		inner join Employees on Employees.ID = Assets.EmployeeID
	where 
		@username=Employees.Usernname and 
		EMEndDate is null and 
		AssetID not in 
			(Select AssetID 
			from Assets inner join EmergencyMaintenances on Assets.ID = EmergencyMaintenances.AssetID
			inner join Employees on Employees.ID = Assets.EmployeeID
			where @username = Employees.Usernname and EMEndDate is not null)
	group by AssetSN, AssetName,Assets.ID
	union 
	select AssetSN, AssetName, NULL as LastClosedEM, 0 as NumberOfEms, Assets.ID as AssetID
		from Assets 
		where Assets.ID not in (Select AssetID from EmergencyMaintenances)
end

exec SP_GetdgvEmergency 'admin'


alter proc SP_GetdgvRequest
as begin
	select AssetSN, AssetName, EMReportDate as 'RequestDate', FirstName+LastName as EmployeeFullName, Departments.Name as 'Department', Assets.ID as 'AssetID',
		EmergencyMaintenances.ID as 'EmergencyMaintenanceID', Assets.EmployeeID as 'EmployeeID', DepartmentLocations.ID as 'DepartmentLocationID',
		Departments.ID as 'DepartmentID', Priorities.Name as'PriorityName'
	from 
		Assets inner join EmergencyMaintenances on Assets.ID = EmergencyMaintenances.AssetID
		inner join DepartmentLocations on DepartmentLocations.ID = Assets.DepartmentLocationID
		inner join Departments on Departments.ID = DepartmentLocations.DepartmentID
		inner join Priorities on Priorities.ID = EmergencyMaintenances.PriorityID
		inner join Employees on Assets.EmployeeID = Employees.ID
	where EMStartDate is not null and EMEndDate is null
end

exec SP_GetdgvRequest