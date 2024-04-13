create database FastFood
use FastFood
select*from Category

create table Category(
ID int primary key identity,
[Name] nvarchar not null)
ALTER TABLE FastFood.dbo.Category
ALTER COLUMN Name VARCHAR(255);
create table Product(
Id int primary key identity,
[Name] nvarchar(50) not null,
Description nvarchar(50) not null,
Prize float not null,
ImageUrl nvarchar(200) not null,
CategoryID int not null ,
foreign key (CategoryID) references Category(ID)
)





