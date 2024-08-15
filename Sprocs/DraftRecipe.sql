create or alter proc dbo.DraftRecipe(
--LB: Remove parameters that are not being used.
    @RecipeId int output,
    @DateDraft datetime output,
    @DatePublished datetime output,
    @DateArchived datetime output
)
as 
begin 
    declare @return int 

    select @DateDraft = cast(getdate() as date), @DatePublished = null, @DateArchived = null

    update Recipe 
    set
    DateDraft = @DateDraft,
    DatePublished = @DatePublished, 
    DateArchived = @DateArchived
    where RecipeId = @RecipeId

    return @return
end
go
