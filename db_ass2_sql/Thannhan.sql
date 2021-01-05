drop table if exists Thannhan;
go

create table Thannhan
(
	Ten nvarchar(50) not null,
	Makhachhang varchar(10) not null,
	Gioitinh nvarchar(3) not null check (Gioitinh in ('Nam', N'Nữ')),
	Ngaysinh date not null,
	Moiquanhe nvarchar(10) check (Moiquanhe in (N'Bố', N'Mẹ', N'Vợ', N'Chồng', 'Anh', N'Chị', 'Em', 'Con', N'Chú', N'Bác', N'Dì', N'Cô', N'Cậu', N'Ông', N'Bà', N'Thím')),
	primary key(Ten, Makhachhang),
	constraint fk_makhachhang foreign key (Makhachhang) references Khachhang(Makhachhang)
);
go

insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Thái Phúc Hiệp', 'CN1001', 'Nam', '2000-09-29', 'Anh');
insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Nguyễn Văn Hiếu', 'CN1006', 'Nam', '1956-10-01', N'Bố');
insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Biện Thị Lành', 'CN1014', N'Nữ', '1967-07-19', N'Mẹ');
insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Trần Tiến Đạt', 'CN1019', 'Nam', '1995-05-20', N'Chồng');
insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Nguyễn Thị Triều Tiên', 'CN1023', N'Nữ', '2001-06-01', 'Em');
insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Nguyễn Vũ Phi Trường', 'CV1009', 'Nam', '2000-01-30', 'Anh');
insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Phạm Thị Hoa', 'CV1020', N'Nữ', '1975-04-30', N'Dì');
insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Nguyễn Vũ Hoàng Uyên', 'CV1025', N'Nữ', '2004-07-19', 'Con');

insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Bùi Chí Cường', 'PN1004', 'Nam', '1967-08-20', N'Bố');
insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Trịnh Tiến Dũng', 'PN1008', 'Nam', '2000-11-21', 'Em');
insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Lê Công Vinh', 'PN1011', 'Nam', '1983-07-06', N'Cậu');
insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Ngô Thị Thuỳ Dương', 'PN1013', N'Nữ', '2000-12-21', N'Vợ');
insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Nguyễn Tiến Đạt', 'PN1018', 'Nam', '2000-05-30', N'Chồng');
insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Phạm Thị Bạch', 'PN1022', N'Nữ', '1945-06-20', N'Bà');
insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Phan Văn Đức', 'PN1027', 'Nam', '1994-10-20', 'Em');

insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Nguyến Tiến Thịnh', 'PV1005', 'Nam', '1990-08-18', 'Con');
insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Phạm Ngọc Thuỵ An', 'PV1007', N'Nữ', '1998-02-02', N'Chị');
insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Đinh Văn Linh', 'PV1012', 'Nam', '1965-12-20', N'Bố');
insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Hoàng Đức Anh Nguyên', 'PV1015', 'Nam', '2000-12-21', 'Anh');
insert into Thannhan(Ten, Makhachhang, Gioitinh, Ngaysinh, Moiquanhe)
values (N'Trần Tiến Linh', 'PV1026', 'Nam', '1990-03-21', 'Anh');
go