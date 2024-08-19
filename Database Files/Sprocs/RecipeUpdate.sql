create or alter proc dbo.RecipeUpdate(
    @RecipeId int output,
    @UsersId int,
    @CuisineId int,
    @RecipeName varchar (35),
    @CaloriesPerServing int,
    @DateDraft datetime output,
    @DatePublished datetime output,
    @DateArchived datetime output,
    @CurrentStatus varchar(20) output,
    @Message varchar (500) = '' output
)
as 
begin 
    declare @return int = 0;

    select @RecipeId = isnull(@RecipeId, 0)

    if @RecipeId = 0
    begin 
        insert Recipe (UsersId, CuisineId, RecipeName, CaloriesPerServing)
        values (@UsersId, @CuisineId, @RecipeName, @CaloriesPerServing)
        
        select @RecipeId = scope_identity()

        select @DateDraft = r.DateDraft, @CurrentStatus = r.CurrentStatus 
        from Recipe r 
        where r.RecipeId = @RecipeId
    end
    else 
    begin
        if @CurrentStatus = 'Archived'
        begin 
            select @DateDraft = convert(varchar(10), getutcdate() at time zone 'UTC' at time zone 'Eastern Standard Time'), @DatePublished = null, @DateArchived = null
        end
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