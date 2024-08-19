create or alter proc dbo.CookbookUpdate(
    @CookbookId int output,
    @UsersId int,
    @CookbookName varchar (40),
    @Price int = 0,
    @DateCreated datetime = null output,
    @CookbookActive bit,
    @Message varchar (500) = '' output
)
as 
begin 
    declare @return int = 0;

    select @CookbookId = isnull(@CookbookId, 0)

    if @CookbookId = 0
    begin 
        insert Cookbook (UsersId, CookbookName, Price, CookbookActive)
        values (@UsersId, @CookbookName, @Price, @CookbookActive)
        
        select @CookbookId = scope_identity()

        select @DateCreated = DateCreated 
        from Cookbook c 
        where c.CookbookId = @CookbookId

    end
    else 
    begin 
        update Cookbook 
        set 
        UsersId = @UsersId,
        CookbookName = @CookbookName,
        Price = @Price,
        CookbookActive = @CookbookActive
        where CookbookId = @CookbookId
    end
    return @return
end
go

