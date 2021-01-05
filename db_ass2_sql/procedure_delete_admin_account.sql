create procedure p_delete_admin_account
	@input_username varchar(20)
as
begin
	if (select Covaitroquantri from Taikhoan where Username = @input_username) = 0
	begin
		print 'Đây không phải là tài khoản quản trị'
	end
	else
	begin
		if (select count(*) from Taikhoan where Covaitroquantri = 1) > 1
		begin
			delete from Taikhoan where Username = @input_username
		end
	end
end

drop procedure if exists p_delete_admin_account

exec p_delete_admin_account 'xuanmai123'