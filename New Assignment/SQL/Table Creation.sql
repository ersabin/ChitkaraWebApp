CREATE DATABASE Chitkara;

USE Chitkara 
GO

CREATE TABLE StudentDetails(
	StudentID int identity(1,1) PRIMARY KEY,
	StudentName varchar(30),
	StudentAge int,
	StudentContact bigint,
	StudentDepartment varchar(6)
);





