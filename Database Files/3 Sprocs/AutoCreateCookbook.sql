create or alter proc dbo.AutoCreateCookbook(
    @Cookbookid int = null output,
    @BaseUsersId int,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int 

    insert Cookbook (UsersId, CookbookName, Price, CookbookActive)
    select u.UsersId, concat('Recipes by ', u.FirstName, ' ', u.LastName), count(r.RecipeId) * 1.33, 1
    from Users u 
    join Recipe r 
    on u.UsersId = r.UsersId 
    where u.UsersId = @BaseUsersId
    group by u.UsersId, u.FirstName, u.LastName

    select @CookbookId = scope_identity()

    insert CookbookRecipe (CookbookId, RecipeId, ISequence)
    select @CookbookId, r.RecipeId, row_number() over (order by r.RecipeName)
    from Users u
    join Recipe r 
    on u.UsersId = r.UsersId 
    where u.UsersId = @BaseUsersId

    return @return
end
go 

/*
declare @BaseUsersId int
select top 1 @BaseUsersId = UsersId from Users u
select @BaseUsersId 

exec AutoCreateCookbook @BaseUsersId = @BaseUsersId
*/