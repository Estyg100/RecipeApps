create or alter procedure dbo.RecipeDelete(
	@RecipeId int,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0
	if exists (select * from Recipe r where ((getdate() - r.DateArchived < 30 and r.CurrentStatus = 'Archived') or r.CurrentStatus = 'Published') and r.RecipeId = @RecipeId)
	begin 
		select @return = 1, @Message = 'Cannot delete Recipe that is currently published, or either archived for under 30 days.'
		goto finished
	end 

--LB: All delete statements should be inside a transaction.
		delete MealCourseRecipe where RecipeId = @RecipeId
		delete CookbookRecipe where RecipeId = @RecipeId
		delete RecipeIngredient where RecipeId = @RecipeId
		delete RecipeDirections where RecipeId = @RecipeId
        delete Recipe where RecipeId = @RecipeId
	finished:
	return @return
end
go
