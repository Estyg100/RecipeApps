create or alter proc dbo.RecipeDirectionsUpdate(
    @RecipeDirectionsId int output,
    @RecipeId int, 
    @DirectionDesc varchar(200),
    @DirectionStepNum int,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    select @RecipeDirectionsId = isnull(@RecipeDirectionsId, 0)

    if @RecipeDirectionsId = 0
    begin 
        insert RecipeDirections(RecipeId, DirectionDesc, DirectionStepNum)
        values (@RecipeId, @DirectionDesc, @DirectionStepNum)

        select @RecipeDirectionsId = scope_identity()
    end
    else 
    begin 
        update RecipeDirections
        set 
        RecipeId = @RecipeId, 
        DirectionDesc = @DirectionDesc,
        DirectionStepNum = @DirectionStepNum
        where RecipeDirectionsId = @RecipeDirectionsId
    end

    return @return
end