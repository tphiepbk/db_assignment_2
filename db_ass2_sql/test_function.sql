select * from Taikhoan join Nhanvien on Manhanvien = NhanvienID 
order by Machinhanh 


drop function if exists f_get_total_number_of_admin_account_of_an_branch 

select count(*) from Taikhoan join Nhanvien on NhanvienID = Manhanvien where Covaitroquantri = 1 and Machinhanh = 'HCM100'

print dbo.f_get_total_number_of_admin_account_of_an_branch('HCM100')