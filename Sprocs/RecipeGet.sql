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

/*
exec RecipeGet

exec RecipeGet @All = 1

exec RecipeGet @RecipeName = ''
exec RecipeGet @RecipeName = null
exec RecipeGet @RecipeName = 'a'

declare @Id int 
select top 1 @Id = r.RecipeId from Recipe r 
exec RecipeGet @RecipeId = @Id
*/