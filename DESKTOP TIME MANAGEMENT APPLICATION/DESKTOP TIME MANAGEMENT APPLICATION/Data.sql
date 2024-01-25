CREATE DATABASE POE;

CREATE TABLE STUDENT_INFOR(
First_name VARCHAR(20) NOT NULL,
Last_name VARCHAR(20) NOT NULL,
Email VARCHAR(50) PRIMARY KEY NOT NULL,
Password VARCHAR(MAX) NOT NULL);

select * from STUDENT_INFOR;

CREATE TABLE MODULES(
Id int identity PRIMARY KEY NOT NULL,
Email VARCHAR(50) FOREIGN KEY REFERENCES STUDENT_INFOR(Email) NOT NULL,
Code VARCHAR(8) NOT NULL,
Name VARCHAR(20) NOT NULL,
Credit int not null,
ClassPerHour DECIMAL(18,0) NOT NULL,
Weeks int not null,
Used_hours DECIMAL(18,0) NOT NULL,
Self_study DECIMAL(18,0) NOT NULL,
Remaining_Hours DECIMAL(18,0) NOT NULL);

select * from MODULES;