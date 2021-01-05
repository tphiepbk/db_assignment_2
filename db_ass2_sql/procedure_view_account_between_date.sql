create procedure p_view_account_created_between
	@begin_date date,
	@end_date date
as
begin
	set nocount on
	if @end_date > getdate() or @begin_date > getdate()
	begin
		print 'Ngày không phù hợp'
	end
	else
	begin
		select * from Taikhoan where Ngaycap >= @begin_date and Ngaycap <= @end_date
	end
end

drop procedure if exists p_view_account_created_between 

exec p_view_account_created_between '01/06/2016', '12/25/2017'