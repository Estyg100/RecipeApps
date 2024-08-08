create or alter procedure dbo.CookbookListGet
as 
begin
    select c.CookbookId, c.CookbookName, Author = concat(u.FirstName, ' ', u.LastName), NumOfRecipes = count(cr.RecipeId), c.Price
    from Cookbook c 
    join Users u 
    on u.UsersId = c.UsersId
    left join CookbookRecipe cr 
    on c.CookbookId = cr.CookbookId
    group by c.CookbookId, c.CookbookName, u.FirstName, u.LastName, c.Price
    order by c.CookbookName
end
go 

exec CookbookListGet