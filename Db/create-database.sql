CREATE DATABASE [product-db]
GO

USE [product-db];
GO

CREATE TABLE product (
	Id INT NOT NULL IDENTITY,
	Name TEXT NOT NULL,
	Description TEXT NOT NULL,
	PRIMARY KEY (Id)
);
GO

INSERT INTO [product] (Name, Description)
VALUES 
('Dependency Injection Principles, Practices, and Patterns', 'Book by Steven van Deursen and Mark Seemann'),
('Agile Software Development, Principles, Patterns, and Practices', 'Book by Robert C. Martin'); 
GO