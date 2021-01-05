CREATE TABLE Nhanvien (
    NhanvienID char(7) not null,
	Gioitinh char(3) check (gioitinh in ('Nam','Nu')),
	Diachi nvarchar(50),
	Dienthoai varchar(22),
	Hoten nvarchar(50) not null,
	Ngaysinh Date,
	Email char(50) unique,
	Machinhanh char(6),
	Ngaybatdau date,
    PRIMARY KEY(NhanvienID),
	FOREIGN KEY (Machinhanh) REFERENCES Chinhanh(Machinhanh) on delete set null on update cascade
);


---- HCM
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HCM265E','Nam',N'400, Ngô Gia Tự','0847732066',N'Đoàn Thanh Nam','2000-02-03','doannam@database.com','HCM100','2018-12-25');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HCM948E','Nu','26/3, D5','0856987916',N'Nguyễn Thị Xuân Mai','1999-06-01','xuanmai@database.com','HCM100','2017-07-13');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HCM322M','Nam',N'73, Tú Xương','0561784623',N'Phan Lê Tuấn Đú','1997-02-03','tuandu@database.com','HCM100','2015-12-25');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HCM002D','Nu',N'3, Trần Hưng Đạo','0877777562',N'Lê Anh Thy','1985-01-01','anhthy@database.com','HCM100','2012-06-17');

--
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HCM275E','Nu',N'400, Điện Biên Phủ',null,N'Dương Thị Minh Châu','1990-08-10','chauduong@database.com','HCM101','2017-12-25');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HCM662M','Nu',N'7, Nguyễn Thị Minh Khai','0795612354',N'Tăng Lê Nhi','1990-01-08','nhitang@database.com','HCM101','2016-07-25');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HCM255E',N'Nam',N'300, Nguyễn Đình Chiểu','0754623148',N'Nguyễn Thanh Phú','1990-07-05','phunguyen@database.com','HCM101','2017-12-25');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HCM123E','Nu',N'403, Nguyễn Xí','036254781',N'Nguyễn Thu Thanh','1995-03-10','thanhnguyen@database.com','HCM101','2017-12-25');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HCM114M','Nu',N'6, Trần Đình Xu','0999587412',N'Võ Thị Mỵ Nương','1990-04-10','nuongvo@database.com','HCM102','2016-06-01');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HCM661E','Nam',N'16, Chợ Bàn Cờ ','0945617412',N'Lê Phước Thịnh','1989-12-22','thinhle@database.com','HCM102','2018-04-01');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HCM357E','Nam',N'4, Võ Văn Ngân','0979587412',N'Hoàng Anh Tuấn','1989-05-10','tuanhoang@database.com','HCM102','2018-04-01');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HCM159E','Nu',N'78, Tôn Đản',null,N'Lê Diệp Chi','1990-10-20','chilediep@database.com','HCM102','2016-04-01');

--- DN
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('DN355E','Nu',N'109/1195G, Lê Văn Thọ','090 316 4564',N'Phạm Ngọc Thuỵ Vi','1980-02-03','vipham@database.com','DN100','2017-04-11');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('DN145E','Nu',N'Diêm Điền, An Ninh','098 8961 988',N'Trần Thị Minh Trang','1982-03-20','trangtran@database.com','DN100','2017-06-12');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('DN196M','Nam',N'15/3A, Đường 30/4 ','090 377 1961',N'Nguyễn Khắc Qui','1980-03-11','quynguyen@database.com','DN100','2015-01-01');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('DN545E','Nam',N'203, Khu I','091 907 4005',N'Nguyễn Văn Dũng','1980-04-11','dungnguyen@database.com','DN100','2018-04-11');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('DN664E','Nam',N'996, Nguyễn Thị Minh Khai','0903704305',N'Phạm Đình Thi','1986-03-22','thipham@database.com','DN101','2018-04-11');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('DN745E','Nu',N'3, Lê Văn Duyệt','0903643660',N'Tống Thị Thu Thanh','1996-03-02','thanhtong@database.com','DN101','2018-04-11');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('DN221M','Nam',N'151, Lý Thường Kiệt','0988889539',N'Nguyễn Văn Triệu','1980-01-01','trieunguyen@database.com','DN101','2016-05-11');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('DN456D','Nam',N'C4/20A, Đoàn Nguyễn Tuân','0918260809',N'Nguyễn Văn Chiểu','1980-02-11','chieunguyen@database.com','DN101','2015-04-26');

--HN
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HN162E','Nu',N'01, Phạm Hồng Thái','0908268763',N'Hoàng Thanh Phương','2000-05-11','phuonghoang@database.com','HN100','2019-03-15');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HN995E','Nam',N'121, Cô Giang','0918253193',N'Trần Đăng Tạo','2000-06-01','taodang@database.com','HN100','2019-03-15');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HN163E','Nu',N'05, Hà Huy Giáp','0908276739',N'Nguyễn Ngọc Binh','1999-07-22','binhnguyen@database.com','HN100','2019-03-15');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HN168M','Nam',N'652, Bùi Đình Túy','0918114956',N'Nguyễn Trường An','1988-05-26','annguyen@database.com','HN100','2017-09-11');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HN553E','Nam',N'300, Ba Đình','0963645695',N'Nguyễn Vũ Khắc Khanh','1997-04-15','khanhnguyen@database.com','HN101','2018-09-11');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HN111M','Nam',N'200, Hàng Lược','0962755766',N'Nguyễn Hoàng Nam','1988-05-26','namhoang@database.com','HN101','2016-07-12');
insert into Nhanvien(NhanvienID,Gioitinh,Diachi,Dienthoai,Hoten,Ngaysinh,Email,Machinhanh,Ngaybatdau)
values ('HN232D','Nam',N'155, Ngã Tư Sở','0918114956',N'Trương Tấn Việt','1977-08-15','viettruong@database.com','HN101','2015-03-02');





CREATE INDEX idx_NhanvienID
ON Nhanvien(NhanvienID);



