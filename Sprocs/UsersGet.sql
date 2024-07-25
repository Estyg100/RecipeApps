create or alter procedure dbo.UsersGet(@UsersId int = 0, @All bit = 0, @UserName varchar(25) = '')
as 
begin 
    select @UserName = nullif(@UserName, '')
    select u.UsersId, u.UserName
    from Users u 
    where u.UsersId = @UsersId
    or @All = 1
    or u.UserName like '%' + @UserName + '%'
end

/*
exec UsersGet

exec UsersGet @All = 1

exec UsersGet @UserName = ''
exec UsersGet @UserName = null
exec UsersGet @UserName = 'g'

declare @Id int 
select top 1 @Id = u.UsersId from Users u
exec UsersGet @UsersId = @Id
*/