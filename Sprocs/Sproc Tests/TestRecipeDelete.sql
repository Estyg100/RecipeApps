
-- With related records
declare @recipeid int

select top 1 @recipeid = r.RecipeId
from Recipe r 
join RecipeIngredient ri 
on ri.RecipeId = r.RecipeId
join RecipeDirections rd
on rd.RecipeId = r.RecipeId
order by r.RecipeId

select TableName = 'Recipe', Id = r.RecipeId, Record = r.RecipeName from Recipe r where r.RecipeId = @recipeid
union select 'RecipeIngredient', ri.RecipeIngredientId, i.IngredientName from RecipeIngredient ri join Ingredient i on ri.IngredientId = i.IngredientId where ri.RecipeId = @recipeid
union select 'RecipeDirections', rd.RecipeDirectionsId, rd.DirectionDesc from RecipeDirections rd where rd.RecipeId = @recipeid

exec RecipeDelete @RecipeId = @recipeid


select TableName = 'Recipe', Id = r.RecipeId, Record = r.RecipeName from Recipe r where r.RecipeId = @recipeid
union select 'RecipeIngredient', ri.RecipeIngredientId, i.IngredientName from RecipeIngredient ri join Ingredient i on ri.IngredientId = i.IngredientId where ri.RecipeId = @recipeid
union select 'RecipeDirections', rd.RecipeDirectionsId, rd.DirectionDesc from RecipeDirections rd where rd.RecipeId = @recipeid

-- Without related records
declare @recipeid int

select top 1 @recipeid = r.RecipeId
from Recipe r 
left join RecipeIngredient ri 
on ri.RecipeId = r.RecipeId
left join RecipeDirections rd
on rd.RecipeId = r.RecipeId
where ri.RecipeIngredientId is null 
and rd.RecipeDirectionsId is null
order by r.RecipeId

select TableName = 'Recipe', Id = r.RecipeId, Record = r.RecipeName from Recipe r where r.RecipeId = @recipeid
union select 'RecipeIngredient', ri.RecipeIngredientId, i.IngredientName from RecipeIngredient ri join Ingredient i on ri.IngredientId = i.IngredientId where ri.RecipeId = @recipeid
union select 'RecipeDirections', rd.RecipeDirectionsId, rd.DirectionDesc from RecipeDirections rd where rd.RecipeId = @recipeid

exec RecipeDelete @RecipeId = @recipeid


select TableName = 'Recipe', Id = r.RecipeId, Record = r.RecipeName from Recipe r where r.RecipeId = @recipeid
union select 'RecipeIngredient', ri.RecipeIngredientId, i.IngredientName from RecipeIngredient ri join Ingredient i on ri.IngredientId = i.IngredientId where ri.RecipeId = @recipeid
union select 'RecipeDirections', rd.RecipeDirectionsId, rd.DirectionDesc from RecipeDirections rd where rd.RecipeId = @recipeid
