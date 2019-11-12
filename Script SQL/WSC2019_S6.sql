use master

go
create database WSC2019_Session6

go
use WSC2019_Session6 

go 
create table Parts (
	ID int identity(1,1) primary key,
	Name nvarchar(100),
	EffectiveLife int,
	MinimumQuantity int,
	BatchNumberHasRequired bit
)

go
create table Departments (
	ID int identity(1,1) primary key,
	Name nvarchar(100)
)

go 
create table Locations (
	ID int identity(1,1) primary key,
	Name nvarchar(100)
)

go
create table Suppliers (
	ID int identity(1,1) primary key,
	Name nvarchar(100)
)

go
create table TransactionTypes (
	ID int identity(1,1) primary key,
	Name nvarchar(100)
)

go 
create table Warehouses (
	ID int identity(1,1) primary key,
	Name nvarchar(100)
)

go
create table DepartmentLocations (
	ID int identity(1,1) primary key,
	DepartmentID int,
	LocationID int,
	StartDate date,
	EndDate date,
	constraint FK_DepartmentLocations_Departments foreign key (DepartmentID) references Departments(ID),
	constraint FK_DepartmentLocations_Locations foreign key (LocationID) references Locations(ID)
)

go
create table Assets (
	ID int identity(1,1) primary key, 
	AssetSN nvarchar(100),
	AssetName nvarchar(100),
	DepartmentLocationID int,
	EmployeeID int,
	AssetGroupID int,
	Description nvarchar(100),
	WarrantyDate date,
	constraint FK_Assets_DepartmentLocations foreign key (DepartmentLocationID) references DepartmentLocations(ID)
)

go
create table EmergencyMaintenances (
	ID int identity(1,1) primary key,
	AssetID int,
	PriorityID int,
	DescriptionEmergency nvarchar(100),
	OtherConsiderations nvarchar(100),
	EMRequestDate date,
	EMStartDate date,
	EMEndDate date,
	EMTechnicianNote nvarchar(100),
	constraint FK_EmergencyMaintenances_Assets foreign key (AssetID) references Assets(ID)
)

go
create table Orders (
	ID int identity(1,1) primary key,
	TransactionTypeID int,
	SupplierID int,
	EmergencyMaintenancesID int,
	SourceWarehouseID int,
	DestinationWarehouseID int,
	Date date,
	Time nvarchar(100),
	constraint FK_Orders_TransactionTypes foreign key (TransactionTypeID) references TransactionTypes(ID),
	constraint FK_Orders_SupplierID foreign key (SupplierID) references Suppliers(ID),
	constraint FK_Orders_EmergencyMaintenances foreign key (EmergencyMaintenancesID) references EmergencyMaintenances(ID),
	constraint FK_Orders_Warehouses1 foreign key (SourceWarehouseID) references Warehouses(ID),
	constraint FK_Orders_Warehouses2 foreign key (DestinationWarehouseID) references Warehouses(ID)
)

go
create table OrderItems (
	ID int identity(1,1) primary key,
	OrderID int,
	PartID int,
	Amount float,
	UnitPrice nvarchar(100),
	BatchNumber nvarchar(100),
	Stock nvarchar(100),
	constraint FK_OrderItems_Orders foreign key (OrderID) references Orders(ID),
	constraint FK_OrderItems_Parts foreign key (PartID) references Parts(ID)
)

insert into Departments values ('Department 1'),('Department 2'),('Department 3'),('Department 4'),('Department 5')

insert into Locations values ('Location 1'),('Location 2'),('Location 3'),('Location 4'),('Location 5')

insert into DepartmentLocations values (1,1,'2019-11-1','2019-12-1')
insert into DepartmentLocations values (2,2,'2019-11-2','2019-12-2')
insert into DepartmentLocations values (3,3,'2019-11-3','2019-12-3')
insert into DepartmentLocations values (4,4,'2019-11-4','2019-12-4')
insert into DepartmentLocations values (3,3,'2019-11-5','2019-12-5')

insert into Assets values ('AN001','Asset 1',1,1,1,'abcxyz','2018-11-1')
insert into Assets values ('AN002','Asset 2',2,2,2,'abcxyz','2018-11-2')
insert into Assets values ('AN003','Asset 3',3,3,3,'abcxyz','2018-11-3')
insert into Assets values ('AN004','Asset 4',4,4,4,'abcxyz','2018-11-4')
insert into Assets values ('AN005','Asset 5',5,5,5,'abcxyz','2018-11-5')

insert into EmergencyMaintenances values (1,1,'abcxyz','abcxyz','2019-1-1','2019-1-2','2019-1-3','technician note')
insert into EmergencyMaintenances values (2,2,'abcxyz','abcxyz','2019-2-1','2019-2-2','2019-2-3','technician note')
insert into EmergencyMaintenances values (3,3,'abcxyz','abcxyz','2019-3-1','2019-3-2','2019-3-3','technician note')
insert into EmergencyMaintenances values (4,4,'abcxyz','abcxyz','2019-4-1','2019-4-2','2019-4-3','technician note')
insert into EmergencyMaintenances values (5,5,'abcxyz','abcxyz','2019-5-1','2019-5-2','2019-5-3','technician note')

insert into Warehouses values ('Warehouse 1'),('Warehouse 2'),('Warehouse 3'),('Warehouse 4'),('Warehouse 5')

insert into Suppliers values ('Supplier 1'),('Supplier 2'),('Supplier 3'),('Supplier 4'),('Supplier 5')

insert into Parts values ('Part 1',60,10,1)
insert into Parts values ('Part 2',60,20,1)
insert into Parts values ('Part 3',60,30,1)
insert into Parts values ('Part 4',60,40,0)
insert into Parts values ('Part 5',60,50,0)

insert into TransactionTypes values ('Purchase Order')
insert into TransactionTypes values ('Warehouse Management')

insert into Orders values (1,1,1,1,1,'2019-11-1','13:00:00')
insert into Orders values (2,2,2,2,2,'2019-11-2','14:00:00')
insert into Orders values (1,3,3,3,3,'2019-11-3','15:00:00')
insert into Orders values (2,4,4,4,4,'2019-11-4','16:00:00')
insert into Orders values (1,5,5,5,5,'2019-11-5','17:00:00')

insert into OrderItems values (1,1,100,'USD','BA001','Current Stock')
insert into OrderItems values (2,2,200,'USD','BA002','Received Stock')
insert into OrderItems values (3,3,300,'USD','BA003','Out of Stock')
insert into OrderItems values (4,4,400,'USD','BA004','Current Stock')
insert into OrderItems values (5,5,500,'USD','BA005','Received Stock')