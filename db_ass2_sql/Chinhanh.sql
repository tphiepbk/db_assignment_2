create table Chinhanh (
	Machinhanh char(6) not null,
	Tenchinhanh varchar(50) not null unique,
	Fax char(15) not null unique,
	Email char(50) unique,
	Dienthoai varchar(22),
	Diachi nvarchar(50),
	Soluongnhanvien int ,
	Tinhtrang char(5) check (tinhtrang in('close','open')), 
	PRIMARY KEY (Machinhanh)
)

--Insert


insert into Chinhanh (Machinhanh,Tenchinhanh,Fax,Email,Dienthoai,Diachi,Soluongnhanvien,Tinhtrang)
values ('HCM100','TNHH_ABC','+84 123456','abc@database.com','+84 123456',N'1, Đinh Tiên Hoàng',4,'open');
insert into Chinhanh (Machinhanh,Tenchinhanh,Fax,Email,Dienthoai,Diachi,Soluongnhanvien,Tinhtrang)
values ('HCM101','TNHH_XYZ','+84 135790','xyz@database.com','+84 135790',N'400/1, Ngô Gia Tự',4,'open');
insert into Chinhanh (Machinhanh,Tenchinhanh,Fax,Email,Dienthoai,Diachi,Soluongnhanvien,Tinhtrang)
values ('HCM102','TNHH_MTV_GAM','+84 123986','gam@database.com','+84 123456',N'147, Lý Thường Kiệt',4,'open');
insert into Chinhanh (Machinhanh,Tenchinhanh,Fax,Email,Dienthoai,Diachi,Soluongnhanvien,Tinhtrang)
values ('DN100','CP_CES','+84 124471','ces@database.com','+84 124471',N'321, Trần Phú',4,'open');
insert into Chinhanh (Machinhanh,Tenchinhanh,Fax,Email,Dienthoai,Diachi,Soluongnhanvien,Tinhtrang)
values ('DN101','TNHH_EVOS','+84 136256','evos@database.com','+84 136256',N'1, Nguyễn Chí Thanh',4,'open');
insert into Chinhanh (Machinhanh,Tenchinhanh,Fax,Email,Dienthoai,Diachi,Soluongnhanvien,Tinhtrang)
values ('HN100','TNHH_SBTC','+84 199999','sbtc@database.com','+84 199999',N'46, Hàng Lược',4,'open');
insert into Chinhanh (Machinhanh,Tenchinhanh,Fax,Email,Dienthoai,Diachi,Soluongnhanvien,Tinhtrang)
values ('HN101','MTV_FLASH','+84 152241','flash@database.com','+84 152241',N'32, Trần Duy Hưng',3,'open');
insert into Chinhanh (Machinhanh,Tenchinhanh,Fax,Email,Dienthoai,Diachi,Soluongnhanvien,Tinhtrang)
values ('HN102','Noname1','+84 1521241','1@database.com','+84 1512241',N'32, Trần Duy Hưng',3,'close');
insert into Chinhanh (Machinhanh,Tenchinhanh,Fax,Email,Dienthoai,Diachi,Soluongnhanvien,Tinhtrang)
values ('DN102','Noname2','+84 1522241','2@database.com','+84 1522241',N'32, Trần Duy Hưng',3,'close');
insert into Chinhanh (Machinhanh,Tenchinhanh,Fax,Email,Dienthoai,Diachi,Soluongnhanvien,Tinhtrang)
values ('HCM103','Noname3','+84 1523241','3@database.com','+84 1532241',N'32, Trần Duy Hưng',3,'close');

CREATE INDEX idx_Machinhanh
ON Chinhanh (Machinhanh);
