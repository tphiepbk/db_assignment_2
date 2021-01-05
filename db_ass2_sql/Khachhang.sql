CREATE TABLE Khachhang (
    Makhachhang	varchar(10) primary key NOT NULL,
    SoCMND		bigint NOT NULL,
    Gioitinh	char(3) check (Gioitinh IN ('Nam','Nu')),
	Ho			nvarchar(15) NOT NULL,
	Chulot		nvarchar(15) NOT NULL,
	Ten			nvarchar(15) NOT NULL       ,
	Ngaysinh	date NOT NULL   ,
	Dienthoai	varchar (22),
	Email		varchar(50) 
); 	




INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('CN1001', 301791266, 'Nam', N'Phan', N'Lê Tuấn', N'Anh','2000-09-15', '0362590315', 'anhphan@gmal.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('PN1002', 301791894, 'Nam', N'Đoàn', N'Thanh', N'Nam','2000-02-03','0934657487', 'nam.doan@gmail.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('CV1003', 301791255, 'Nam', N'Nguyễn', N'Công', N'Minh','2000-03-03','09785554446', 'ming.cong@hcmut.edu.vn');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('PN1004', 301586231, 'Nam', N'Bùi', N'Ngọc', N'Minh','1997-08-08','0909051955', 'ngocbui@gmail.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('PV1005', 301687232, 'Nu', N'Nguyễn', N'Thị', N'Vụ','1977-01-07','0983626424', 'thivu@gmail.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('CN1006', 301788238, 'Nu', N'Nguyễn', N'Thị Bích', N'Nga','1981-02-03','0909359509', 'nga@gmail.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('PV1007', 401799238, 'Nu', N'Phạm', N'Ngọc Thuỵ', N'Vi','1998-02-02','0979859519', 'ngocthuyconchi@gmail.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('PN1008', 401899338, 'Nam', N'Trịnh', N'Văn', N'Tưởng','1999-03-12','0963645695', 'tuong.trinh@enet.vn');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('CV1009', 301877833, 'Nam', N'Nguyễn', N'Vũ Khắc', N'Khanh','2001-04-18','0962779799', 'beckhamtitan@yahoo.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('PV1010', 37199783381, 'Nam', N'Đoàn', N'Chí' ,N'Linh','1995-04-30','0963883091', 'chilinh25@yahoo.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('PN1011', 30199793382, 'Nam', N'Lê', N'Đức', N'Dần','1996-12-19','0962519327', 'danleduc@yahoo.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('PV1012', 30169593333, 'Nam', N'Đinh', N'Quốc', N'Cường','1997-12-20','0962518271', 'dinhcuong1507@yahoo.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('PN1013', 30133333334, 'Nu', N'Ngô', N'Minh', N'Mẫn','1999-01-22','0963994944', 'mandltd@yahoo.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('CN1014', 30177443345, 'Nu', N'Biện', N'Thị', N'Thúy','1997-11-25','0963600688', 'thuybc@gmail.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('PV1015', 30177443348, 'Nu', N'Hoàng', N'Thanh', N'Phương','1897-10-26','082055085', 'phuonghoang@gmail.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('PV1016', 30188447747, 'Nu', N'Nguyễn', N'Thị Ngọc', N'Liễu','1988-12-23','0903704305', '123@gmail.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('CV1017', 3017944885, 'Nu', N'Nguyễn', N'Thị Ngọc', N'Hoa','1985-10-24','0903704431', 'hoa123@gmail.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('PN1018', 30458889122, 'Nu',N'Nguyễn', N'Thị Ngọc', N'Dung','1986-10-25','0913725245', 'dungngoc@gmail.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('CN1019', 30174485, 'Nu', N'Nguyễn', N'Thị Ngọc', N'Hạnh','1997-11-27','0913752285', 'hanhngoxngech@gmail.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('CV1020', 30174447747, 'Nam', N'Phạm', N'Tiến', N'Dũng','1997-11-23','0988889539', '123@gmail.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('PN1021', 3018044885, 'Nam', N'Nguyễn', N'Văn', N'Lèo','1995-04-24','0908570211', 'vitoleo@gmail.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('PN1022', 40458889142, 'Nam',N'Nguyễn', N'Duy', N'Long','1988-11-25','0988889544', 'longduy_soaicac@gmail.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('CN1023', 35174489, 'Nu', N'Nguyễn', N'Thị Ngọc', N'Thu','1989-10-27','0988889588', 'thuxd@gmail.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('PV1024', 30174887747, 'Nam', N'Say', N'Chan', N'Than','1997-11-28','0903745586', 'schanthan@gmail.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('CV1025', 3017444885, 'Nam', N'Nguyễn', N'Hồng', N'Khâm','1993-05-25','0908235794', 'hongkham@gmail.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('PV1026', 40459881142, 'Nam',N'Trần', N'Văn', N'Tự','1996-11-27','0908227725', 'vantuc@gmail.com');
INSERT INTO Khachhang (Makhachhang, SoCMND, Gioitinh, Ho, Chulot, Ten, Ngaysinh,Dienthoai, Email)
VALUES ('PN1027', 35274489, 'Nu', N'Phan', N'Thị Diệu', N'Ánh','1984-12-29','0918424978', 'anhphan1984@gmail.com');


CREATE INDEX idx_Makhachhang
ON Khachhang (Makhachhang);
