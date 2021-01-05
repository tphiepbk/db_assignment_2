select count(*) as Soluong, Gioitinh, Machinhanh from Taikhoan join Nhanvien on Manhanvien = NhanvienID
where Covaitroquantri = 1
group by Gioitinh, Machinhanh
having Gioitinh = 'Nam'
order by Machinhanh

select min(Ngaysinh) as NgaySinhNhoNhat, Machinhanh from Taikhoan join Nhanvien on Manhanvien = NhanvienID
where Covaitroquantri = 1
group by Machinhanh

select * from Taikhoan join Nhanvien on Manhanvien = NhanvienID
where Covaitroquantri = 1
order by Username

select * from Taikhoan join Nhanvien on Manhanvien = NhanvienID
where datediff(DAY,Ngaybatdau,Ngaycap) > 30
order by Username