
exec RecipeGet

exec RecipeGet @All = 1

declare @Id int 
select top 1 @Id = r.RecipeId from Recipe r 
exec RecipeGet @RecipeId = @Id
