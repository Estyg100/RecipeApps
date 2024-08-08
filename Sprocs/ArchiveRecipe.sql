create or alter proc dbo.ArchiveRecipe(
    @RecipeId int output,
    @DateArchived datetime output
)
as 
begin 
    declare @return int 

    select @DateArchived = cast(getdate() as date)

    update Recipe 
    set 
    DateArchived = @DateArchived
    where RecipeId = @RecipeId

    return @return
end
go
