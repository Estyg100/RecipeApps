create or alter proc dbo.UsersUpdate(
    @UsersId int output,
    @FirstName varchar(15),
    @LastName varchar(15),
    @UserName varchar(25),
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0 

    select @UsersId = isnull(@UsersId, 0)

    if @UsersId = 0
    begin 
        insert Users (FirstName, LastName, UserName)
        values (@FirstName, @LastName, @UserName)

        select @UsersId = scope_identity()
    end 
    else 
    begin 
        update Users 
        set 
        FirstName = @FirstName,
        LastName = @LastName,
        UserName = @UserName 
        where UsersId = @UsersId
    end

    return @return
end 
go