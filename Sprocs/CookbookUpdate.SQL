create or alter proc dbo.CookbookUpdate(
    @CookbookId int output,
    @UsersId int,
    @CookbookName varchar (40),
    @Price int = 0,
    @DateCreated datetime output,
    @CookbookActive bit,
    @Message varchar (500) = '' output
)
as 
begin 
    declare @return int = 0;

    select @CookbookId = isnull(@CookbookId, 0)

    if @CookbookId = 0
    begin 
        if @DateCreated is null 
        begin 
        select @DateCreated = cast(getdate() as date)
        end
        insert Cookbook (UsersId, CookbookName, Price, DateCreated, CookbookActive)
        values (@UsersId, @CookbookName, @Price, @DateCreated, @CookbookActive)
        select @CookbookId = scope_identity()
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
