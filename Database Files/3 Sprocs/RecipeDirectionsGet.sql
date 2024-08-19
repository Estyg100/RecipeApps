create or alter procedure dbo.RecipeDirectionsGet(
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @RecipeId = isnull(@RecipeId, 0)

	select rd.DirectionDesc, rd.DirectionStepNum, r.RecipeId, rd.RecipeDirectionsId
    from Recipe r
    join RecipeDirections rd 
    on r.RecipeId = rd.RecipeId
	where @All = 1
	or r.RecipeId = @RecipeId
    order by rd.DirectionStepNum

	return @return
end
go

exec RecipeDirectionsGet @All = 1

declare @RecipeId int 
select top 1 @RecipeId = RecipeId from Recipe r 
select @RecipeId 

exec RecipeDirectionsGet @RecipeId = @RecipeId