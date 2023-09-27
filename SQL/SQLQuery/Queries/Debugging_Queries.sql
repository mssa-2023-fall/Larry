/*CREATE TABLE lsn.demoTable(
    ColA int,
    ColB int UNIQUE,
    ColC varchar(10) UNIQUE,
    ColD varchar(10) NOT NULL,
    ColE varchar(10),
    ColF varchar(10)
    CONSTRAINT [PK_lsn_demoTable] PRIMARY KEY CLUSTERED (ColE,ColF)
);

insert into lsn.demoTable(ColA,ColB,ColC,ColD,ColE,ColF)
values (1,1,'test','test2','test3','test4')



create table lsn.Category(
CategoryID int identity primary key clustered,
CategoryName nvarchar(20) not null unique,
CategoryDescription nvarchar(1000)

)


create table lsn.Product(
ProductID int identity primary key clustered,
CategoryID int References lsn.Category (CategoryID),
ProductName nvarchar(50) not null unique,
ProductDescription nvarchar(100)

)


insert into lsn.Category(CategoryName,CategoryDescription)
values('Hardware','Things you put inside a computer box');
insert into lsn.Category(CategoryName,CategoryDescription)
values('Software','Things you install');*/


