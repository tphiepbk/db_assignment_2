DROP TABLE IF EXISTS Loaithe, Gioithieu, Taikhoan, Thekhachhang

-- CREATE TABLE Thekhachhang
CREATE TABLE Thekhachhang
(
	Mathe varchar(10) PRIMARY KEY NOT NULL,
	Diemtichluy INT DEFAULT 0,
	Makhachhang varchar(10) NOT NULL,
	Machinhanh char(6) NOT NULL,
	Ngaycapthe Date NOT NULL,
	FOREIGN KEY (Makhachhang) REFERENCES Khachhang(Makhachhang),
	FOREIGN KEY (Machinhanh) REFERENCES Chinhanh(Machinhanh)
)

GO

-- INSERT DATA

INSERT INTO Thekhachhang(Mathe, Makhachhang, Machinhanh, Ngaycapthe)
VALUES 
	('CC1', 'CN1001', 'DN100', '2020-09-15'),
	('CC2', 'PN1002','DN100', '2020-12-15'),
	('CC3', 'CV1003','DN101', '2020-12-07'),
	('CC4', 'PN1004', 'DN101', '2020-10-17'),
	('CC5', 'PV1005', 'HN101','2020-10-17'),
	('CC6', 'CN1006','HCM100', '2020-01-27'),
	('CC7', 'PV1007', 'HN101', '2020-11-09'),
	('CC8', 'PN1008', 'HN101', '2020-05-28'),
	('CC9', 'CV1009', 'HCM101' ,'2020-01-22'),
	('CC10', 'PV1010', 'HCM102','2020-02-18');

--------------------------------------------------------------------------------------

-- CREATE TABLE Loaithe

CREATE TABLE Loaithe
(
	Maloaithe varchar(10) PRIMARY KEY NOT NULL,
	Thoigianhieuluc Date,
	Chinhsachuudai Text,
	Quyenloi Text,
	Diemtoithieu SMALLINT DEFAULT 0,
	Mathe varchar(10) NOT NULL,
	FOREIGN KEY (Mathe) REFERENCES Thekhachhang(Mathe)
)

GO

-- INSERT DATA

INSERT INTO Loaithe (Maloaithe, Thoigianhieuluc, Mathe)
VALUES 
	('T1', '2020-09-15', 'CC1'),
	('T2', '2020-12-15', 'CC2'),
	('T3', '2020-12-07', 'CC3'),
	('T4', '2020-10-17', 'CC4'),
	('T5', '2020-10-17', 'CC5'),
	('T6', '2020-01-27', 'CC6'),
	('T7', '2020-11-09', 'CC7'),
	('T8', '2020-05-28', 'CC8'),
	('T9', '2020-01-22', 'CC9'),
	('T10', '2020-02-18', 'CC10');

--------------------------------------------------------------------------------------

-- CREATE TABLE Gioithieu

CREATE TABLE Gioithieu
(
	Makhachhang varchar(10) NOT NULL,
	Manhanvien char(7) NOT NULL,
	Mathe varchar(10) NOT NULL,
	FOREIGN KEY (Makhachhang) REFERENCES Khachhang(Makhachhang),
	FOREIGN KEY (Manhanvien) REFERENCES Nhanvien(NhanvienID),
	FOREIGN KEY (Mathe) REFERENCES Thekhachhang(Mathe),
	PRIMARY KEY (Makhachhang, Manhanvien, Mathe)
);

GO

-- INSERT DATA
INSERT INTO Gioithieu
VALUES 
	('CN1001', 'HCM265E', 'CC1'),
	('PN1002', 'HCM948E', 'CC2'),
	('CV1003', 'HCM322M', 'CC3'),
	('PN1004', 'HCM002D', 'CC4'),
	('CN1006', 'HCM275E', 'CC5'),
	('PV1005', 'HCM662M', 'CC6'),
	('PN1008', 'HCM255E', 'CC7'),
	('PV1007', 'HCM123E', 'CC8'),
	('CV1009', 'HCM114M', 'CC9'),
	('PV1010', 'HCM661E', 'CC10');

--------------------------------------------------------------------------------------

-- CREATE TABLE Taikhoan

CREATE TABLE Taikhoan
(
	Username varchar(20) PRIMARY KEY NOT NULL,
	Matkhau varchar(20) NOT NULL,
	Covaitroquantri BIT DEFAULT 0,
	Ngaycap Date,
	Manhanvien char(7) NOT NULL,
	FOREIGN KEY (Manhanvien) REFERENCES Nhanvien(NhanvienID)
)

GO

-- INSERT DATA

INSERT INTO Taikhoan
VALUES 
	('tiendat123', 'tiendat123', 1, '2018-12-25', 'HCM265E'),
	('tuananh123', 'tuananh123', 0, '2017-07-13', 'HCM948E'),
	('phuchiep123', 'phuchiep123', 0, '2015-12-25', 'HCM322M'),
	('thanhnam123', 'thanhnam123', 0, '2012-06-17', 'HCM002D'),
	('congminh123', 'congminh123', 0, '2017-12-25', 'HCM275E'),
	('xuanmai123', 'xuanmai123', 0, '2016-07-25', 'HCM662M'),
	('hoainam123', 'hoainam123', 0, '2017-12-25', 'HCM255E'),
	('taminhtam123', 'taminhtam123', 0, '2017-12-25', 'HCM123E'),
	('duyhung123', 'duyhung123', 0, '2016-06-01', 'HCM114M'),
	('tiendat456', 'tiendat456', 1, '2018-04-01', 'HCM661E');

--------------------------------------------------------------------------------------

-- CREATE TABLE Duoccap

GO

-- INSERT DATA

-------------------------------------------------------------------------------------

