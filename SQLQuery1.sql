create database MyAttendanceDB
use MyAttendanceDB

create table TechnologyTbl
(
	TechID int primary key identity,
	TechName varchar(50)
)
insert into TechnologyTbl values('PHP'),('.NET'),('Android'),('Java'),('WD'),('Software Testing'),('IPhone')

create table ProgramTbl
(
	PID int primary key identity,
	PName varchar(50)
)
alter table ProgramTbl add Duration varchar(50)
insert into ProgramTbl values('Advantage','2 Hours'),('Industry','2 Hours'),('Placement - 3Pack','4 Hours'),('Placement - 5Pack','4 Hours'),('Placement - 7Pack','4 Hours'),('Placement - 12Pack','4 Hours'),('CDP','6 Hours')

create table AttendanceTbl
(
	ATID bigint primary key identity,
	fname varchar(50),
	lname varchar(50),
	FkTechID int references TEchnologyTbl(TechID),
	FkPID int references ProgramTbl(PID),
	InTime varchar(50),
	OutTime varchar(50),
	AtDate datetime
)