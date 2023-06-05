-- this is a comment	
CREATE DATABASE PMB;
GO

USE PMB;
GO 

-- default schema dbo
CREATE SCHEMA PM; 
GO

CREATE TABLE PM.Companies
(
	CRNNO int primary key,
	CompanyName varchar(50) not null
);
GO

CREATE TABLE PM.Managers
(
	Id int not null,
	Email varchar(100) not null,
	primary key(Id)
);
GO

CREATE TABLE PM.Projects
(
	PRJNO int primary key,
	Title varchar(100) not null,
	ManagerId int foreign key references PM.Managers(Id) not null,
	StartDate datetime2 not null,
	InitialCost decimal(18,2) not null, -- 9999.99
	Parked bit not null,
	CRNNO int not null,
	foreign key (CRNNO) references PM.Companies(CRNNO)
);
GO

CREATE TABLE PM.Technology
(
	Id int not null,
	Name varchar(100) not null,
	primary key(Id)
);
GO

CREATE TABLE PM.ProjectTechnology
(
	PRJNO int foreign key references PM.Projects(PRJNO) not null,
	TechnologyId int foreign key references PM.Technology(Id) not null,
	primary key(PRJNO,TechnologyId) -- composite key 
);
GO