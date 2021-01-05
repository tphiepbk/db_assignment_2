create trigger t_update_account_check_date on Taikhoan instead of update
as
begin
	declare @inserted_date date
	declare @inserted_username varchar(20) 
	set @inserted_date = (select i.Ngaycap from inserted i)
	set @inserted_username = (select i.Username from inserted i)
	if (@inserted_date > getdate()) 
	begin
		update Taikhoan
			set Ngaycap = getdate()
			where Username = @inserted_username
	end
end

-- DONE !!!!!

drop trigger if exists t_update_account_check_date;