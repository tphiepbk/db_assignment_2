create function f_get_total_number_of_admin_account_of_an_branch 
(
	@input_branchname char(6)
)
returns int
as
begin
	declare @res as int
	if (select count(*) from Nhanvien where Machinhanh = @input_branchname) = 0
	begin
		set @res = -1
	end
	else
	begin
		set @res = (select count(*) from Taikhoan join Nhanvien on Manhanvien = NhanvienID where Covaitroquantri = 1 and Machinhanh = @input_branchname)
	end
	return @res
end
