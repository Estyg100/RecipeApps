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

    insert RecipeIngredient (RecipeId, IngredientId, MeasurementTypeId, Quantity, ISequence)
    select @RecipeId, ri.IngredientId, ri.MeasurementTypeId, ri.Quantity, ri.ISequence 
    from RecipeIngredient ri
    where ri.RecipeId = @BaseRecipeId

    insert RecipeDirections (RecipeId, DirectionStepNum, DirectionDesc)
    select @RecipeId, rd.DirectionStepNum, rd.DirectionDesc
    from RecipeDirections rd  
    where rd.RecipeId = @BaseRecipeId

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