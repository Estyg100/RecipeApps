create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @All bit = 0)
as 
begin
    
    select @RecipeId = isnull(@RecipeId, 0)

    select *
    from Recipe r 
    where r.RecipeId = @RecipeId
    or @All = 1
end
go 
