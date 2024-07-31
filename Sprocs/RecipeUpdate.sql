create or alter proc dbo.RecipeUpdate(
    @RecipeId int output,
    @UsersId int,
    @CuisineId int,
    @RecipeName varchar (35),
    @CaloriesPerServing int,
    @DateDraft datetime,
    @DatePublished datetime,
    @DateArchived datetime,
    @Message varchar (500) = '' output
)
as 
begin 
    declare @return int = 0;

    select @RecipeId = isnull(@RecipeId, 0)

    if @RecipeId = 0
    begin 
        insert Recipe (UsersId, CuisineId, RecipeName, CaloriesPErServing, DateDraft, DatePublished, DateArchived)
        values (@UsersId, @CuisineId, @RecipeName, @CaloriesPerServing, @DateDraft, @DatePublished, @DateArchived)
        select @RecipeId = scope_identity()
    end
    else 
    begin 
        update Recipe 
        set 
        UsersId = @UsersId,
        CuisineId = @cuisineId,
        RecipeName = @RecipeName,
        CaloriesPerServing = @CaloriesPerServing,
        DateDraft = @DateDraft,
        DatePublished = @DatePublished,
        DateArchived = @DateArchived
        where RecipeId = @RecipeId
    end
    return @return
end
go