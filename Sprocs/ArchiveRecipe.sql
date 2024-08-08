create or alter proc dbo.ArchiveRecipe(
    @RecipeId int output
)
as 
begin 
    declare @return int 

    update Recipe 
    set 
    DateArchived = cast(getdate() as date)
    where RecipeId = @RecipeId

    return @return
end
go
