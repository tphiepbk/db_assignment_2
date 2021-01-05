insert into Taikhoan values('xuanmai123', '123456', 0, convert(date, '12/1/2021', 101), 'HN995E')

update Taikhoan 
set Ngaycap = convert(date, '12/01/2021', 101)
where Username = 'xuanmai123'

delete from Taikhoan where Manhanvien = 'HN995E';

delete from Taikhoan where Username = 'xuanmai123new'