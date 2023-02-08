create table Products(
 Id int primary key identity,
 ProductName varchar(50)
);

create table Categoryes(
 Id int primary key identity,
 CategoryName varchar(50)
);

create table Couple(
 ProductId int,
 CategoryId int,
 foreign key (ProductId) references Products(Id) on delete cascade,
 foreign key (CategoryId) references Categoryes(Id) on delete cascade
);

insert into Products(ProductName) values
('�������1'),
('�������2'),
('����3���'),
('�4������'),
('����5���'),
('����23���');
--6
insert into Categoryes(CategoryName) values
('����1�����'),
('�������2��'),
('�3��������');
--3

insert into Couple values
(1,2),(1,1),(4,3),(5,1),(6,2),(3,1),(4,2);

select prod.ProductName [�������], cat.CategoryName [���������]
from Products prod
left join Couple couple on prod.id = couple.ProductId 
inner join Categoryes cat on cat.id = couple.CategoryId

order by prod.ProductName
