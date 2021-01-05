create trigger t_insert_account_check_duplicate_username on Taikhoan instead of insert
as
begin
	declare @inserted_date date
	declare @inserted_username varchar(20)
	declare @inserted_password varchar(20)
	declare @inserted_admin bit
	declare @inserted_emp_id char(7) 

	set @inserted_date = (select i.Ngaycap from inserted i)
	set @inserted_username = (select i.Username from inserted i)
	set @inserted_password = (select i.Matkhau from inserted i)
	set @inserted_admin = (select i.Covaitroquantri from inserted i)
	set @inserted_emp_id = (select i.Manhanvien from inserted i)

	if (select Username from Taikhoan where Username = @inserted_username) is not null
	begin
		declare @new_username varchar(20)
		set @new_username = @inserted_username + '_new';
		insert into Taikhoan values (@new_username, @inserted_password, @inserted_admin, @inserted_date, @inserted_emp_id)
	end
	else
	begin
		insert into Taikhoan values (@inserted_username, @inserted_password, @inserted_admin, @inserted_date, @inserted_emp_id)
	end
end

-- DONE !!!!

drop trigger if exists t_insert_account_check_duplicate_username
