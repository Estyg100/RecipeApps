create or alter procedure dbo.RecipeGet(
    @RecipeId int = 0, 
    @RecipeName varchar(30) = ' ',
    @All bit = 0,
    @IncludeBlank bit = 0
)
as 
begin
    
    select @RecipeId = isnull(@RecipeId, 0), @IncludeBlank = isnull(@IncludeBlank, 0), @RecipeName = nullif(@RecipeName, ' ')
    
    select r.RecipeId, r.UsersId, r.CuisineId, r.RecipeName, r.CurrentStatus, UserName = concat(u.FirstName, ' ', u.LastName), r.CaloriesPerServing, NumOfIngredients = isnull(count(ri.RecipeIngredientId), 0), r.DateDraft, r.DatePublished, r.DateArchived
    from Recipe r 
    join Users u 
    on u.UsersId = r.UsersId
    left join RecipeIngredient ri 
    on r.RecipeId = ri.RecipeId
    where @All = 1
    or r.RecipeId = @RecipeId
    or r.RecipeName like '%' + @RecipeName + '%'
    group by r.RecipeId, r.UsersId, r.CuisineId, r.RecipeName, r.CurrentStatus, u.UserName, r.CaloriesPerServing, u.FirstName, u.LastName, r.DateDraft, r.DatePublished, r.DateArchived
    union select 0, 0, 0,'', '', '', 0, 0, '', '', ''
	where @IncludeBlank = 1
    order by r.currentStatus desc
    
end
go 

exec RecipeGet @All = 1