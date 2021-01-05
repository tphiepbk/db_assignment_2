CREATE TABLE Hoadon (
    Mahoadon			varchar(10) NOT NULL,
    VAT					decimal(4,2),
	Thanhtien			decimal(19,2) NOT NULL,
    Phuongthucthanhtoan	varchar(7) check (Phuongthucthanhtoan IN ('Tienmat','The')) NOT NULL,
	Ngayxuat			date NOT NULL,
	Makhachhang			varchar(10) NOT NULL,
	Machinhanh			char(6)
	PRIMARY KEY (Mahoadon),
	FOREIGN KEY (Makhachhang) REFERENCES Khachhang(Makhachhang),
	FOREIGN KEY (Machinhanh) REFERENCES Chinhanh(Machinhanh)
);

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151000', 5.00,  100000.00,'The', '2020-01-02', 'CN1001','DN100');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151001', 0.05,  123400.00,'Tienmat', '2020-01-02', 'PN1008','HN100');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151002', 0.65,  115000.00,'The', '2020-01-02', 'CV1009','HN100');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151003', 10.0,  500000.00,'Tienmat', '2020-01-02', 'CV1017','DN100');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151004', 7.5,  1800000.00,'The', '2020-01-02', 'CN1023','HCM100');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151005', 8.6,  188252.00,'The', '2020-01-02', 'PV1024','HN100');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151006', 7.05,  1005000.00,'The', '2020-01-03', 'CV1025','HCM100');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151007', 5.02,  437598.00,'Tienmat', '2020-01-03', 'CV1025','DN100');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151008', 0.55,  598200.00,'The', '2020-01-04', 'CN1014','DN100');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151009', 10.02,  725500.00,'Tienmat', '2020-01-05', 'CV1020','DN100');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151010', 4.1,  589600.00,'The', '2020-01-06', 'CV1009','DN100');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151011', 5.01,  1425230.00,'The', '2020-02-02', 'PN1008','HCM100');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151012', 0.1,  123000.00,'Tienmat', '2020-02-05', 'CN1019','HN100');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151013', 0.2 , 200000.00,'Tienmat', '2020-02-08', 'CV1020','HCM100');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151014', 0.2,  223000.00,'The', '2020-02-19', 'CN1023','HN100');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151015', null,  12123600.00,'The', '2020-02-20', 'PV1024','HCM100');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151016', 0.2,  123456200.00,'Tienmat', '2020-02-20', 'CV1025','HN100');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151017', 7.5,  1678500.00,'Tienmat', '2020-03-01', 'PN1008','HCM100');
INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151018', 0.8 ,  123700.00,'Tienmat', '2020-03-01', 'PN1008','HCM100');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151019', 0.2,  313900.00,'The', '2020-03-01', 'CN1014','HCM100');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151020', null,  748000.00,'Tienmat', '2020-03-01', 'PV1024','HCM100');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151021', null,  672000.00,'Tienmat', '2020-03-01', 'CV1025','HCM100');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151022', null,  123000.00,'Tienmat', '2020-03-01', 'CV1025','HCM101');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151023', 4.2,  456000.00,'Tienmat', '2020-02-03', 'CN1014','HCM101');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151024', null,  786000.00,'The', '2020-03-02', 'CV1025','HCM101');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151025', null,  789000.00,'Tienmat', '2020-03-02', 'CV1025','HCM101');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151026', 8.0,  256000.00,'Tienmat', '2020-03-02', 'CN1014','HCM101');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151027', null,  569500.00,'The', '2020-03-02', 'CV1020','HCM101');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151028', 7.2,  236200.00,'The', '2020-03-02', 'CV1020','HCM101');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151029', null,  432000.00,'The', '2020-11-02', 'CV1020','HCM101');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151030', null,  1897000.00,'The', '2020-11-02', 'CV1020','HCM101');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151031', null,  123000.00,'Tienmat', '2020-11-02', 'CV1009','HCM100');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151032', 4.1,  123000.00,'Tienmat', '2020-11-02', 'PN1008','HCM100');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151033', null,  456300.00,'The', '2020-11-02', 'CN1019','HCM100');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151034', 4.1, 789000.00,'Tienmat', '2020-11-02', 'CV1020','HCM100');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151035', null,  12325200.00,'Tienmat', '2020-11-08', 'CN1001','HCM100');

INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151036', null,  1236500.00,'Tienmat', '2020-11-08', 'CV1003','HCM100');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151037', 4.1,  69123800.00,'Tienmat', '2020-12-18', 'PN1004','HN100');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151038', null,  73153980.00,'Tienmat', '2020-12-18', 'PV1010','HN100');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151039', null,  193230.00,'The', '2020-12-22', 'CV1025','HN101');


INSERT INTO Hoadon (Mahoadon, VAT, Thanhtien,Phuongthucthanhtoan, Ngayxuat, Makhachhang,Machinhanh)
VALUES ('B12151040', 8.05,  20000.00,'The', '2020-12-22', 'CV1025','HN101');


CREATE INDEX idx_Mahoadon
ON Hoadon ( Mahoadon);



