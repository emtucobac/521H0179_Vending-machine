create database ticket
create table destination(
	id varchar(10),
    Transportation  nvarchar(100),
    place nvarchar(100)
)
insert into destination values('SO1',N'Xe buyt',N'Vung Tau')
insert into destination values('SO2',N'Xe hoi',N'Ha noi')
insert into destination values('SO3',N'May bay',N'Vung Tau')
insert into destination values('SO4',N'Xe may',N'Da Nang')

select * from destination


create table customer(
    customerid  varchar(10),
    customername nvarchar(100),
	customeridnum varchar(100)
)
insert into destination values('SO1',N'Nguyen Thi Hue',N'123556')
insert into destination values('SO2',N'Mai Van Truong',N'325345')
insert into destination values('SO3',N'Le Ba Kha',N'547123')
insert into destination values('SO4',N'Le Van Thong',N'563721')