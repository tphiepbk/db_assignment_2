CREATE TABLE Diachi (
    Makhachhang	varchar(10)  NOT NULL,
    Sonha		nchar(20) NOT NULL,
    Tenduong	nchar(20) NOT NULL,
	Thanhpho	nchar(20) NOT NULL,
	PRIMARY KEY (Makhachhang,Sonha,Tenduong, Thanhpho),
	FOREIGN KEY (Makhachhang) REFERENCES Khachhang(Makhachhang)
);


INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('CN1001', '15', N'Trần Phú', N'Đà Nẵng');

INSERT INTO Diachi(Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('PN1002', '25/3', N'Trần Bình Trọng', N'Quãng Ngãi');

INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('CV1003', '28/3/15/64', N'Trần Cao Vân', N'Đà Nẵng');


INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('PN1004', '28/45/15/64', N'Trần Cao Đạt', N'Huế');


INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('PV1005', '8/3', N'Trần Cao Vân', N'Đà Nẵng');


INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('CN1006', '64/12', N'Nguyễn Trãi', N'Vinh');


INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('PV1007', '1', N'Phạm Hồng Thái', N'TPHCM');
INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('PN1008', '151', N'Lý Thường Kiệt', N'TPHCM');
INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('CV1009', '121', N'Cô Giang', N'TPHCM');

INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('PV1010', 'C4/20A', N'Hà Huy Giáp', N'TPHCM');
INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('PN1011', '1129/18', N'Huỳnh Tấn Phát', N'TPHCM');
INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('PV1012', '290/156A', N'Lạc Long Quân', N'TPHCM');


INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('PN1013', '3A', N'Nguyễn Trãi', N'TPHCM');

INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('CN1014', '703/13', N'Đoàn Nguyễn Tuân', N'Nghệ An');
INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('PV1015', '18/6A', N'Lê Văn Lương', N'TPHCM');
INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('PV1016', '1/1B', N'An Dương Vương', N'TPHCM');
INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('CV1017', '75', N' Lê Quang Sung', N'Ninh Bình');
INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('PN1018', '98', N'Trần Não', N'TPHCM');
INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('CN1019', '72/8B/58', N'Phan Văn Trị', N'TPHCM');

INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('CV1020', '65', N'Mã Phú Lèng', N'Lào Cai');
INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('PN1021', '78/12', N'Tỉnh lộ 12', N'Long An');
INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('PN1022', '1/5/3B/88', N'Nguyễn Trãi', N'Long An');
INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('CN1023', '8/5/6', N'Trần Bình Trọng', N'Trà Vinh');
INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('PV1024', '28', N'Trần Bình Trọng', 'Long An');
INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('CV1025', '45', '30/4', N'Vũng Tàu');
INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('PV1026', '64', N'Vành đai 2', N'Bình Dương');
INSERT INTO Diachi (Makhachhang, Sonha, Tenduong,Thanhpho)
VALUES ('PN1027', '77', N'Tỉnh đèo 22', N'Bình Dương');