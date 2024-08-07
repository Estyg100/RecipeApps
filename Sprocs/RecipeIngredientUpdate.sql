create or alter proc dbo.RecipeIngredientUpdate(
    @RecipeIngredientId int output,
    @RecipeId int, 
    @IngredientId int,
    @MeasurementTypeId int,
    @Quantity decimal (5, 2),
    @IngredientSequence int,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    select @RecipeIngredientId = isnull(@RecipeIngredientId, 0)

    if @RecipeIngredientId = 0
    begin 
        insert RecipeIngredient(RecipeId, IngredientId, MeasurementTypeId, Quantity, ISequence)
        values (@RecipeId, @IngredientId, @MeasurementTypeId, @Quantity, @IngredientSequence)

        select @RecipeIngredientId = scope_identity()
    end
    else 
    begin 
        update RecipeIngredient 
        set 
        RecipeId = @RecipeId, 
        IngredientId = @IngredientId,
        MeasurementTypeId = @MeasurementTypeId,
        Quantity = @Quantity,
        ISequence = @IngredientSequence
        where RecipeIngredientId = @RecipeIngredientId
    end

    return @return
end