CREATE DATABASE COMMERCE;
USE COMMERCE;

CREATE TABLE Login(
	User_ID VARCHAR(15) NOT NULL,
    User_name VARCHAR(50),
	User_password VARCHAR(50),
	PRIMARY KEY (User_ID));


CREATE TABLE Customer(
	Account_Number VARCHAR(15) NOT NULL,
	User_id VARCHAR(15) NOT NULL,
	First_Name VARCHAR(50),
	Last_Name VARCHAR(50),
	Date_of_birth DATE,
	Gender CHAR(1),
	Address VARCHAR(255),
	Email VARCHAR(70),
	Phone_number VARCHAR(10),
	SSN CHAR(9),
	PRIMARY KEY (Account_Number, User_id),
	CONSTRAINT u_customer UNIQUE (User_id, Account_Number, SSN),
	CONSTRAINT fK_id FOREIGN KEY (User_id)
	REFERENCES Login(User_ID)
	ON DELETE CASCADE
	ON UPDATE CASCADE
	);


CREATE TABLE Account(
	Account_Num VARCHAR(15),
	Account_type VARCHAR(55),
	Creation_date DATETIME,
	PRIMARY KEY (Account_Num),
	);


CREATE TABLE Notification(
	Notification_ID VARCHAR(15) NOT NULL, 
	Acc_number VARCHAR(15),
	Notification_Message VARCHAR(50),
	PRIMARY KEY (Notification_ID)
	);

CREATE TABLE Trigger_(
	Trigger_ID VARCHAR(15),
	Trigger_description VARCHAR(50)
	PRIMARY KEY (Trigger_ID)
	);


CREATE TABLE Transaction_(
	Transaction_ID VARCHAR(15) NOT NULL,
	Account_No VARCHAR(15),
	Transaction_type VARCHAR(10),
	Amount FLOAT,
	Balance FLOAT,
	Processing_Date DATETIME,
	Description VARCHAR(100),
	Location VARCHAR(60),
	PRIMARY KEY (Transaction_ID),
	);
	
/*CHANGES MADE: there is no attributes with datatype INT: ALL that was INT has been changed to VARCHAR(15) */