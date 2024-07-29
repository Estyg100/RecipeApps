
exec RecipeGet

exec RecipeGet @All = 1

exec RecipeGet @RecipeName = ''
exec RecipeGet @RecipeName = null
exec RecipeGet @RecipeName = 'a'

declare @Id int 
select top 1 @Id = r.RecipeId from Recipe r 
exec RecipeGet @RecipeId = @Id
