create or alter function dbo.NumOfCaloriesPerMeal(@MealId int)
returns int 
as 
begin 
    declare @value int 
    
    select @value = sum(r.CaloriesPerServing)
    from Meal m 
    join MealCourse mc 
    on m.MealId = mc.MealId
    join MealCourseRecipe mcr
    on mc.MealCourseId = mcr.MealcourseId
    join Recipe r 
    on mcr.RecipeId = r.RecipeId
    where m.MealId = @MealId

    return @value
end
go 

select m.MealName, NumOfCalories = dbo.NumOfCaloriesPerMeal(m.MealId)
from Meal m