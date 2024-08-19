create or alter procedure dbo.CookbookRecipeGet(
	@CookbookRecipeId int = 0 output,
	@CookbookId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All, 0), @CookbookId = isnull(@CookbookId, 0), @CookbookRecipeId = isnull(@CookbookRecipeId, 0)

	select cr.CookbookRecipeId, cr.CookbookId, cr.RecipeId, RecipeSequence = cr.ISequence
    from CookbookRecipe cr 
	where @All = 1
	or cr.CookbookId = @CookbookId
    order by cr.ISequence

	return @return
end
go

exec CookbookRecipeGet @All = 1

declare @CookbookId int 
select top 1 @CookbookId= CookbookId from Cookbook 
select @CookbookId

exec CookbookRecipeGet @CookbookId = @CookbookId