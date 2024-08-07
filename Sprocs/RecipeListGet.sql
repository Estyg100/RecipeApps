create or alter procedure dbo.RecipeListGet
as 
begin
    select r.RecipeId, r.RecipeName, r.CurrentStatus, UserFullName = concat(u.FirstName, ' ', u.LastName), r.CaloriesPerServing, NumOfIngredients = isnull(count(ri.RecipeIngredientId), 0)
    from Recipe r 
    join Users u 
    on u.UsersId = r.UsersId
    left join RecipeIngredient ri 
    on r.RecipeId = ri.RecipeId
    group by r.RecipeId, r.RecipeName, r.CurrentStatus, u.UserName, r.CaloriesPerServing, u.FirstName, u.LastName
    order by r.currentStatus desc
end
go 

exec RecipeListGet