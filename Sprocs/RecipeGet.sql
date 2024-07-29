create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @All bit = 0, @RecipeName varchar(30) = '')
as 
begin 
    select @RecipeName = nullif(@RecipeName, '')
    select *
    from Recipe r 
    where r.RecipeId = @RecipeId
    or @All = 1
    or (@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
end
