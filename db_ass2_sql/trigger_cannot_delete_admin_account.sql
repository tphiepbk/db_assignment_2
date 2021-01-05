create trigger t_cannot_delete_admin_account on Taikhoan instead of delete
as
begin
	declare @Username varchar(20);
	declare @Covaitroquantri bit;

	set @Username = (select d.Username from deleted d);
	set @Covaitroquantri = (select d.Covaitroquantri from deleted d);

	if @Covaitroquantri = 0
	begin
		delete from Taikhoan where Username = @Username
	end
end

-- DONE !!!

drop trigger if exists t_cannot_delete_admin_account

select * from Taikhoan

delete from Taikhoan where Username = 'tiendat456'

rollback tran