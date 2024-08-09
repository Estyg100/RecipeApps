create or alter procedure dbo.MealListGet
as 
begin
    select m.MealName, UserName = concat(u.FirstName, ' ', u.LastName), NumOfCalories = sum(r.CaloriesPerServing), NumOfCourses = count(distinct mc.CourseId), NumOfRecipes = count(distinct r.RecipeId)
    from Meal m 
    join Users u 
    on m.UsersId = u.UsersId
    left join MealCourse mc 
    on m.MealId = mc.MealId
    left join MealCourseRecipe mcr
    on mc.MealCourseId = mcr.MealcourseId
    left join Recipe r 
    on mcr.RecipeId = r.RecipeId
    group by m.MealName, u.FirstName, u.LastName
    order by m.MealName
end
go 

exec MealListGet