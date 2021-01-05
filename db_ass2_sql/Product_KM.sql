
DROP TABLE IF EXISTS Magiamgia,Sanphamtang,Khuyenmai,Sanphamnhap,Sanpham


CREATE TABLE Sanpham(

 SPID int not null primary key,
 Ten varchar(255),
 Soluong int not null ,
 Dongia DECIMAL(12,2),
 Mahoadon varchar(10) NOT NULL,
 Loai varchar(255) not null,
 constraint pk_mahoadon foreign key (Mahoadon) references Hoadon(Mahoadon),
 constraint uni unique (SPID,Mahoadon)
)

CREATE TABLE Sanphamnhap(
	SPID int not null   ,
	Ngaynhaphang smalldatetime,
	CONSTRAINT fk_spid FOREIGN KEY (SPID) REFERENCES Sanpham(SPID) 
	on DELETE cascade,
	primary key ( SPID,Ngaynhaphang)
	
)



CREATE TABLE Khuyenmai (
	
	Makhuyenmai varchar(255) not null primary key,
	Ngaybatdau smalldatetime,
	Ngayketthuc smalldatetime,
	Loaikhuyenmai varchar(255),



)

CREATE TABLE Sanphamtang (

	SPID int not null ,
	Makhuyenmai varchar(255),
	
	primary key (SPID,Makhuyenmai),
	CONSTRAINT pk_spid FOREIGN KEY (SPID) REFERENCES Sanpham(SPID) 
		on DELETE CASCADE ,
	CONSTRAINT pk_Makhuyenmai FOREIGN KEY (Makhuyenmai) REFERENCES Khuyenmai(Makhuyenmai) 
		on DELETE CASCADE 
)

CREATE Table Magiamgia (
	
	Makhuyenmai varchar(255) not null,
	Giatri numeric(15),
	primary key (Makhuyenmai),
	CONSTRAINT pk_makhuyenmai1 FOREIGN KEY (Makhuyenmai) REFERENCES Khuyenmai(Makhuyenmai) 
		on DELETE CASCADE 
)



--Phần Insert
INSERT INTO Sanpham 
	
	values (1,'Kem danh rang P/S',123,0,'B12151000','HangTang'),
	(2,'Goi dau Clear',245,0,'B12151001','HangTang'),
	(3,'Cây lược ngà',132,14500,'B12151002','HangBan'),
	(4,'Bút bi thiên long',321,65000,'B12151003','HangBan')

INSERT INTO Sanphamnhap values (1,'02/10/2010 12:34')
	,(1,'02/10/2010 12:35')
	,(2,'02/10/2010 12:36')
	,(3,'02/10/2010 12:37')
	,(4,'02/10/2010 12:38')

INSERT INTO Khuyenmai values ('ABCXYZ','04/10/2010 12:34','06/10/2010 12:34','GiftCard')
INSERT INTO Khuyenmai values ('123456','05/10/2010 12:34','07/10/2010 12:34','Discount')
INSERT INTO Khuyenmai values ('ABC123','06/10/2010 12:34','08/10/2010 12:34','Discount')


INSERT INTO Sanphamtang values (1,'ABCXYZ')

INSERT INTO Magiamgia values ('123456',10000)
INSERT INTO Magiamgia values ('ABC123',20000)



