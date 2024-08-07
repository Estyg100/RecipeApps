create or alter procedure dbo.RecipeIngredientGet(
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @RecipeId = isnull(@RecipeId, 0)

	select ri.Quantity, IngredientSequence = ri.ISequence, i.IngredientId, m.MeasurementTypeId, r.RecipeId, ri.RecipeIngredientId
    from Recipe r
    join RecipeIngredient ri 
    on r.RecipeId = ri.RecipeId
    join  Ingredient i
    on i.IngredientId = ri.IngredientId
    left join MeasurementType m 
    on ri.MeasurementTypeId = m.MeasurementTypeId
	where @All = 1
	or r.RecipeId = @RecipeId
    order by ri.ISequence

	return @return
end
go

declare @RecipeId int 
select top 1 @RecipeId = RecipeId from Recipe
select @RecipeId

exec RecipeIngredientGet @RecipeId = 29

exec RecipeIngredientGet @All = 1