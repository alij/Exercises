use master;
GO

IF EXISTS(select * from sys.databases where name='Projects')
DROP DATABASE Projects;
GO

create database Projects;
GO

Use Projects;
GO

Begin Transaction;

create table Departments
(
	PK_DEPARTMENT_ID int identity(1, 1) not null primary key,
	Department_Name varchar(40) not null
);

create table Projects
(
	PK_PROJECT_ID int identity(1, 1) not null primary key,
	Project_Name varchar(40) not null,
	Start_Date date not null
);

create table Employees
(
	PK_EMPLOYEE_ID int identity(1, 1) not null primary key,
	FK_Department_ID int not null,
	FK_Project_ID int not null,
	First_Name varchar(20) not null,
	Last_Name varchar(30) not null,
	Job_Title varchar(50) not null,
	Birth_Date date not null,
	Gender varchar(10),
	Hire_Date date not null,

	foreign key (FK_Department_ID) references Departments(PK_DEPARTMENT_ID),
	foreign key (FK_Project_ID) references Projects(PK_PROJECT_ID),
	constraint gender_check check ((gender = 'Male') OR (gender = 'Female') or (gender = 'Other'))
);

insert into Projects values ('War of the Five Kings', '1972-05-12'), ('Battle of the Blackwater', '1972-12-20'), ('Red Wedding', '1973-06-16'), ('Kings Wedding', '1973-01-05');
insert into Departments values ('Kings Landing'), ('Winterfell'), ('Highgarden');
insert into Employees values 
(1, 1, 'Joffrey', 'Baratheon', 'King', '1968-05-17', 'Male', '1972-04-01'),
(1, 2, 'Tyrion', 'Lannister', 'Kings Hand', '1958-04-15', 'Male', '1972-05-15'),
(2, 3, 'Robb', 'Stark', 'King of the North', '1964-02-02', 'Male', '1972-04-21'),
(3, 4, 'Margaery', 'Tyrell', 'Queen', '1965-10-05', 'Female', '1973-06-16'),
(2, 3, 'Catelyn', 'Stark', 'Kings Adviser', '1936-11-11', 'Female', '1964-02-02'),
(3, 4, 'Olenna', 'Tyrell', 'Queen of Thorns', '1904-04-07', 'Female', '1936-05-07'),
(1, 1, 'Varys', 'The Spider', 'Master of Whispers', '1927-10-15', 'Other', '1964-03-17'),
(1, 3, 'Tywin', 'Lannister', 'Lord of Casterly Rock', '1911-08-08', 'Male', '1931-01-01');



commit transaction;

