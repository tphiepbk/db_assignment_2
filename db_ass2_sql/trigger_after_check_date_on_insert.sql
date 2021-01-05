create trigger t_insert_account_check_date on Taikhoan after insert
as
begin
	declare @inserted_date date
	declare @inserted_username varchar(20) 
	set @inserted_date = (select i.Ngaycap from inserted i)
	set @inserted_username = (select i.Username from inserted i)

	-- check valid date
	if (@inserted_date > getdate()) 
	begin
		update Taikhoan
			set Ngaycap = getdate()
			where Username = @inserted_username
	end
end

-- DONE !!!!

insert into Taikhoan values ('thaihiep456', 'thaiphuchiep', 1, '01/24/2021', 'HCM322M')

delete from Taikhoan where Username = 'thaihiep456'

drop trigger if exists t_insert_account_check_date;