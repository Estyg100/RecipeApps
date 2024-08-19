create or alter procedure dbo.CookbookGet(
    @CookbookId int = 0, 
    @All bit = 0
)
as 
begin

    select c.CookbookId, c.UsersId, c.CookbookName, Author = concat(u.FirstName, ' ', u.LastName), NumOfRecipes = count(cr.RecipeId), c.Price, c.DateCreated, c.CookbookActive
    from Cookbook c 
    join Users u 
    on u.UsersId = c.UsersId
    left join CookbookRecipe cr 
    on c.CookbookId = cr.CookbookId
    where @All = 1 
    or c.CookbookId = @CookbookId
    group by c.UsersId, c.CookbookId, c.CookbookName, u.FirstName, u.LastName, c.Price, c.DateCreated, c.CookbookActive
    order by c.CookbookName

end
go 

exec CookbookGet @All = 1