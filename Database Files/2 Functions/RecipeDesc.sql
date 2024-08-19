create or alter function dbo.RecipeDesc (@RecipeId int)
returns varchar (100)
as 
begin 
    declare @value varchar (100) = ''
    
    select @value = concat(r.RecipeName, ' (', c.CuisineName, ') has ', count(distinct ri.RecipeIngredientId), ' ingredients and ', count(distinct rd.RecipeDirectionsId), ' steps.') 
    from Recipe r
    join Cuisine c 
    on c.CuisineId = r.CuisineId
    join RecipeIngredient ri 
    on r.RecipeId = ri.RecipeId
    join RecipeDirections rd 
    on rd.RecipeId = r.RecipeId
    where r.RecipeId = @RecipeId
    group by r.RecipeName, c.CuisineName

    return @value
end
go 

select RecipeDesc = dbo.RecipeDesc(r.RecipeId)
from Recipe r
