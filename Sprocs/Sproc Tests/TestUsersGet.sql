
exec UsersGet

exec UsersGet @All = 1

exec UsersGet @UserName = ''
exec UsersGet @UserName = null
exec UsersGet @UserName = 'g'

declare @Id int 
select top 1 @Id = u.UsersId from Users u
exec UsersGet @UsersId = @Id
