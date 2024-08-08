create or alter proc dbo.PublishRecipe(
    @RecipeId int output,
    @DateDraft datetime output,
    @DatePublished datetime output,
    @DateArchived datetime output
)
as 
begin 
    declare @return int 

    select @DatePublished = cast(getdate() as date)

    update Recipe 
    set
    DatePublished = @DatePublished
    where RecipeId = @RecipeId

    return @return
end
go
