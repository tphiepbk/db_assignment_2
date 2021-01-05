create trigger t_update_account_check_date on Taikhoan instead of update
as
begin
	declare @inserted_date date
	declare @inserted_username varchar(20) 
	declare @inserted_password varchar(20)
	declare @inserted_admin varchar(20)

	set @inserted_date = (select i.Ngaycap from inserted i)
	set @inserted_username = (select i.Username from inserted i)
	set @inserted_password = (select i.Matkhau from inserted i)
	set @inserted_admin = (select i.Covaitroquantri from inserted i) 

	if (@inserted_date > getdate()) 
	begin
		update Taikhoan
			set Ngaycap = getdate(), Matkhau = @inserted_password, Covaitroquantri = @inserted_admin
			where Username = @inserted_username
	end
	else
	begin
		update Taikhoan
			set Ngaycap = @inserted_date, Matkhau = @inserted_password, Covaitroquantri = @inserted_admin
			where Username = @inserted_username
	end
end

-- DONE !!!!!

drop trigger if exists t_update_account_check_date;

update Taikhoan 
set Ngaycap = convert(date, '01/22/2021', 101),
Matkhau = '123456hiep'
where Username = 'xuanmai123'