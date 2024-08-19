create or alter procedure dbo.UsersDelete(
	@UsersId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @UsersId = isnull(@UsersId,0)

begin try
    begin tran
	    delete cr 
        from CookbookRecipe cr
        join cookbook c  
        on c.CookbookId = cr.CookbookId 
        where c.UsersId = @UsersId

        delete c 
        from Cookbook c  
        where c.UsersId = @UsersId

        delete mcr 
        from MealCourseRecipe mcr
        join MealCourse mc 
        on mc.MealCourseId = mcr.MealcourseId
        join Meal m 
        on mc.MealId = m.MealId  
        where m.UsersId = @UsersId

        delete mcr 
        from MealCourseRecipe mcr
        join Recipe r 
        on mcr.RecipeId = r.RecipeId
        where r.UsersId = @UsersId

        delete mc 
        from MealCourse mc 
        join Meal m 
        on mc.MealId = m.MealId 
        where m.UsersId = @UsersId

        delete m 
        from Meal m 
        where m.UsersId = @UsersId

        delete rd 
        from RecipeDirections rd 
        join Recipe r 
        on r.RecipeId = rd.RecipeId
        where r.UsersId = @UsersId

        delete ri 
        from RecipeIngredient ri 
        join Recipe r 
        on r.RecipeId = ri.RecipeId
        where r.UsersId = @UsersId

        delete r 
        from Recipe r 
        where r.UsersId = @UsersId

        delete u  
        from Users u 
        where u.UsersId = @UsersId
    commit 
end try 
begin catch 
    rollback;
    throw
end catch
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