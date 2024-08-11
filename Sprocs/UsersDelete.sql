create or alter procedure dbo.UsersDelete(
	@UsersId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @UsersId = isnull(@UsersId,0)

	delete cr 
    from CookbookRecipe cr
    join cookbook c  
    on c.CookbookId = cr.CookbookId 
    join Users u 
    on c.UsersId = u.UsersId 
    where u.UsersId = @UsersId

    delete cr 
    from CookbookRecipe cr
    join Recipe r 
    on cr.RecipeId = r.RecipeId
    join Users u 
    on r.UsersId = u.UsersId 
    where u.UsersId = @UsersId

    delete c 
    from Cookbook c  
    join Users u 
    on u.UsersId = c.UsersId 
    where u.UsersId = @UsersId

    delete mcr 
    from MealCourseRecipe mcr
    join MealCourse mc 
    on mc.MealCourseId = mcr.MealcourseId
    join Meal m 
    on mc.MealId = m.MealId  
    join Users u 
    on m.UsersId = u.UsersId
    where u.UsersId = @UsersId

    delete mcr 
    from MealCourseRecipe mcr
    join Recipe r 
    on mcr.RecipeId = r.RecipeId
    join Users u 
    on r.UsersId = u.UsersId
    and mcr.RecipeId = r.RecipeId
    where u.UsersId = @UsersId

    delete mc 
    from MealCourse mc 
    join Meal m 
    on mc.MealId = m.MealId 
    join Users u 
    on u.UsersId = m.UsersId 
    where u.UsersId = @UsersId

    delete m 
    from Meal m 
    join Users u 
    on u.UsersId = m.UsersId
    where u.UsersId = @UsersId

    delete rd 
    from RecipeDirections rd 
    join Recipe r 
    on r.RecipeId = rd.RecipeId
    join Users u 
    on u.UsersId = r.UsersId 
    where u.UsersId = @UsersId

    delete ri 
    from RecipeIngredient ri 
    join Recipe r 
    on r.RecipeId = ri.RecipeId
    join Users u 
    on u.UsersId = r.UsersId 
    where u.UsersId = @UsersId

    delete r 
    from Recipe r 
    join Users u 
    on u.UsersId = r.UsersId 
    where u.UsersId = @UsersId

    delete u  
    from Users u 
    where u.UsersId = @UsersId

	return @return
end
go

/*
declare @UsersId int 
select top 1 @UsersId = UsersId from Users

select @UsersId

exec UsersDelete @UsersId = @UsersId

select * from Users where UsersId = @UsersId
*/