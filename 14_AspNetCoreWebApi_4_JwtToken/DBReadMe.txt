

use Northwind

create table WebApiUsers
(
	Id int identity(1,1),
	UserName nvarchar(50),
	Password nvarchar(50),
	FirmName nvarchar(500),
	ContactName nvarchar(150)
)
go
alter table WebApiUsers
	add constraint pk_WebApiUsers primary key(Id)

go
alter table WebApiUsers
	add PhoneNumber nvarchar(50)


insert WebApiUsers
(UserName,Password,FirmName,ContactName)
values
('eseyyarer','!123','Seyyarer AŞ','EbuBekir Seyyarer')

insert WebApiUsers
(UserName,Password,FirmName,ContactName)
values
('gcaliskan','!321','Çalışkan Fatura AŞ','Gökhan Çalışkan')
