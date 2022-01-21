DROP TABLE Errands
DROP TABLE Customers
DROP TABLE Addresses

CREATE TABLE Addresses (
	Id int not null identity primary key,
	StreetName nvarchar(50) not null,
	PostalCode char(5) not null,
	City nvarchar(50) not null,
	Country nvarchar(50) not null
)
GO

CREATE TABLE Customers(
	Id int not null identity primary key,
	FirstName nvarchar(50) not null,
	LastName nvarchar(50) not null,
	Email varchar(100) not null unique,
	PhoneNumber varchar(15) not null,
	MobileNumber varchar(15) not null,
	AddressId int not null references Addresses(Id)
)
GO

CREATE TABLE Errands(
	Id int not null identity primary key,
	CustomerId int not null references Customers(Id),
	Title nvarchar(30) not null,
	ErrandDescription nvarchar(100) not null,
	CreatedTime datetime2(7) not null,
	ChangedTime datetime2(7) not null,
	ErrandStatus nvarchar(20) not null,
	Adminstrator nvarchar(30) not null
)