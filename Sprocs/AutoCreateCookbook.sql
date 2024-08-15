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

    ;with x as (
    	select c.CookbookId, c.UsersId 
    	from Cookbook c 
    	where c.CookbookId = @CookbookId
    )
--LB: The CTE is unnecessary. You can use the @CookbookId in the insert statement directly and the @BaseUsersId in the where condition.
    insert CookbookRecipe (CookbookId, RecipeId, ISequence)
    select x.CookbookId, r.RecipeId, row_number() over (order by r.RecipeName)
    from x 
    join Users u 
    on x.UsersId = u.UsersId
    join Recipe r 
    on u.UsersId = r.UsersId 
    where u.UsersId = @BaseUsersId

    return @return
end