create or alter proc dbo.RecipeClone(
    @RecipeId int = null output,
    @BaseRecipeId int,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int

    insert Recipe (RecipeName, UsersId, CuisineId, CaloriesPerServing, DateDraft, DatePublished, DateArchived)
    select concat(r.RecipeName, ' - clone'), r.UsersId, r.CuisineId, r.CaloriesPerServing, r.DateDraft, r.DatePublished, r.DateArchived
    from Recipe r 
    where r.RecipeId = @BaseRecipeId

    select @RecipeId = scope_identity()

--LB: There is no need to use a CTE. The code should be simplified to a regular insert statement. i.e. use @RecipeId in the insert statement and the @BaseRecipeId in the where condition.
    ;with x as (
	    select r.RecipeId, ri.IngredientId, ri.MeasurementTypeId, ri.Quantity, ri.ISequence, r.UsersId
	    from Recipe r
	    join RecipeIngredient ri 
	    on r.RecipeId = ri.RecipeId
	    where r.RecipeId = @BaseRecipeId
    )

    insert RecipeIngredient (RecipeId, IngredientId, MeasurementTypeId, Quantity, ISequence)
    select r.RecipeId, x.IngredientId, x.MeasurementTypeId, x.Quantity, x.ISequence 
    from x 
    join Recipe r 
    on x.UsersId = r.UsersId
    where r.RecipeId = @RecipeId

    ;with x as (
    	select r.RecipeId, rd.DirectionStepNum, rd.DirectionDesc, r.UsersId
    	from Recipe r 
    	join RecipeDirections rd 
    	on r.RecipeId = rd.RecipeId
    	where r.RecipeId = @BaseRecipeId
    )

    insert RecipeDirections (RecipeId, DirectionStepNum, DirectionDesc)
    select r.RecipeId, x.DirectionStepNum, x.DirectionDesc
    from x 
    join Recipe r 
    on x.UsersId = r.UsersId
    where r.RecipeId = @RecipeId

    return @return
end 
go

/*
declare @BaseRecipeId int 
select top 1 @BaseRecipeId = r.RecipeId from Recipe r 

select @BaseRecipeId 

exec RecipeClone @BaseRecipeId = @BaseRecipeId 

select * from Recipe
*/