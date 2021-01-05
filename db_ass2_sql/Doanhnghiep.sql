create table Doanhnghiep 
(
	Madoanhnghiep int not null primary key,
	Ten nvarchar(50) not null,
	Diachi nvarchar(100) not null,
	Thoigianbatdau datetime,
	Thoigiankethuc datetime
);