use master

IF DB_ID('WSC2019_Session4') IS NOT NULL
BEGIN
    DROP DATABASE WSC2019_Session4
END

go
create database WSC2019_Session4

go
use WSC2019_Session4

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
create table Parts (
	ID int identity (1,1) primary key,
	Name nvarchar(100),
	EffectiveLife int,
	BatchNumberHasRequired bit,
	MinimumAmount float
)

go
create table Orders (
	ID int identity(1,1) primary key,
	TransactionTypeID int,
	SupplierID int,
	SourceWarehouseID int,
	DestinationWarehouseID int,
	Date date,
	constraint FK_Orders_TransactionTypes foreign key (TransactionTypeID) references TransactionTypes(ID),
	constraint FK_Orders_Suppliers foreign key (SupplierID) references Suppliers(ID),
	constraint FK_Orders_Warehouse1 foreign key (SourceWarehouseID) references Warehouses(ID),
	constraint FK_Orders_Warehouse2 foreign key (DestinationWarehouseID) references Warehouses(ID)
)

go 
create table OrderItems (
	ID int identity(1,1) primary key,
	OrderID int,
	PartID int,
	BatchNumber nvarchar(100),
	Amount float,
	constraint FK_OrderItems_Orders foreign key (OrderID) references Orders(ID),
	constraint FK_OrderItems_Parts foreign key (PartID) references Parts(ID)
)

insert into TransactionTypes values ('Purchase Order'),('Warehouse Management')

insert into Suppliers values ('Supplier 1'),('Supplier 2'),('Supplier 3'),('Supplier 4')

insert into Warehouses values ('Warehouse 1'),('Warehouse 2'),('Warehouse 3'),('Warehouse 4')

insert into Parts values ('Part 1',60,1,1000)
insert into Parts values ('Part 2',80,0,2000)
insert into Parts values ('Part 3',100,0,3000)
insert into Parts values ('Part 4',120,1,4000)

insert into Orders values (1,1,1,1,'1999-11-30')
insert into Orders values (2,2,2,2,'1999-12-30')
insert into Orders values (1,3,3,3,'2000-1-10')
insert into Orders values (2,4,4,4,'2002-2-28')


insert into OrderItems values (1,1,'BA001',10001)
insert into OrderItems values (2,2,'BA002',20002)
insert into OrderItems values (3,3,'BA003',30003)
insert into OrderItems values (4,4,'BA004',40004)
insert into OrderItems values (1,2,'BA005',50005)

select * from OrderItems
select * from Orders 
select * from Parts
select * from Suppliers
select * from TransactionTypes

create proc SP_GetdgvCurrentInventory
as begin
	select Parts.Name as 'PartName', TransactionTypes.Name as TransactionType, Orders.Date, Amount, 
		Orders.SourceWarehouseID as SourceID, Orders.DestinationWarehouseID as DestinationID
	from Parts inner join OrderItems on Parts.ID=OrderItems.PartID
		inner join Orders on Orders.ID = OrderItems.OrderID
		inner join TransactionTypes on TransactionTypes.ID = Orders.TransactionTypeID
end

exec SP_GetdgvCurrentInventory