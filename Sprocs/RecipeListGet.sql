create or alter procedure dbo.RecipeListGet(@RecipeId int = 0, @All bit = 0)
as 
begin
    select r.RecipeId, r.RecipeName, r.CurrentStatus, UserFullName = concat(u.FirstName, ' ', u.LastName), r.CaloriesPerServing, NumOfIngredients = count(ri.RecipeIngredientId)
    from Recipe r 
    join Users u 
    on u.UsersId = r.UsersId
    join RecipeIngredient ri 
    on r.RecipeId = ri.RecipeId
    where r.RecipeId = @RecipeId
    or @All = 1
    group by r.RecipeId, r.RecipeName, r.CurrentStatus, u.UserName, r.CaloriesPerServing, u.FirstName, u.LastName
    order by r.currentStatus desc
end
go 