-- SM Excellent! 100%
use HeartyHearthDB 
go

/*
Home Page
    One result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
*/

select ItemName = 'Recipes', Count = count(*)
from Recipe r 
union select 'Meals', count(*)
from Meal m 
union select 'Cookbooks', count(*)
from Cookbook c

/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
	Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived in mm/dd/yyyy format (blank if not archived), user, number of calories and number of ingredients.
    Tip: You'll need to use the convert function for the dates
*/
select RecipeName = 
case 
when r.CurrentStatus = 'Archived' then concat('<span style="color:gray">',r.recipename, '</span>')
else r.RecipeName
end, 
r.CurrentStatus, DatePublished = isnull(convert(varchar, r.DatePublished, 101), ''), DateArchived = isnull(convert(varchar, r.DateArchived, 101), ''), u.UserName, r.CaloriesPerServing, NumOfInridients = count(ri.IngredientId)
from Recipe r 
join Users u 
on r.UsersId = u.UsersId
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
where r.CurrentStatus in ('Published', 'Archived')
group by r.RecipeName, r.CurrentStatus, r.DatePublished, r.DateArchived, u.UserName, r.CaloriesPerServing
order by r.CurrentStatus desc 

/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement quantity, measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/

--a)

select r.RecipeName, r.CaloriesPerServing, NumOfIngredients = count(distinct ri.RecipeIngredientId), NumOfDirections = count(distinct rd.RecipeDirectionsId), r.RecipePicture
from Recipe r 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join RecipeDirections rd
on r.RecipeId = rd.RecipeId
where r.RecipeName = 'Apple Yogurt Smoothie'
group by r.RecipeName, r.CaloriesPerServing, r.RecipePicture

--b)
select ListOfIngredients = concat(ri.Quantity, ' ', isnull(m.MeasurementTypeName, ''), ' ', i.IngredientName), i.IngredientPicture 
from Ingredient i 
join RecipeIngredient ri 
on i.IngredientId = ri.IngredientId
left join MeasurementType m 
on ri.MeasurementTypeId = m.MeasurementTypeId
join Recipe r 
on ri.RecipeId = r.RecipeId
where r.RecipeName = 'Apple Yogurt Smoothie'
order by ri.ISequence

--c)

select rd.DirectionDesc
from Recipe r 
join RecipeDirections rd 
on r.RecipeId = rd.RecipeId
where r.RecipeName = 'Apple Yogurt Smoothie'
order by rd.DirectionStepNum

/*
Meal list page:
    For all active meals, show the meal name, user that created the meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/

select m.MealName, u.UserName, NumOfCalories = sum(r.CaloriesPerServing), NumOfCourses = count(distinct mc.CourseId), NumOfRecipes = count(distinct r.RecipeId)
from Meal m 
join Users u 
on m.UsersId = u.UsersId
join MealCourse mc 
on m.MealId = mc.MealId
join MealCourseRecipe mcr
on mc.MealCourseId = mcr.MealcourseId
join Recipe r 
on mcr.RecipeId = r.RecipeId
where m.MealActive = 1
group by m.MealName, u.UserName
order by m.MealName

/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes: Result set should have one column, including the course type, whether the dish is serverd as main/side (if it's the main course), and recipe name. 
			Format for main course: CourseType: Main/Side dish - Recipe Name. 
            Format for non-main course: CourseType: Recipe Name
            Main dishes of the main course should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/

--a)

select m.MealName, u.UserName, m.DateCreated, m.MealPicture 
from Meal m 
join Users u 
on m.UsersId = u.UsersId
where m.MealName = 'Birthday Blast'

--b)

select ListOfRecipes = 
case c.CourseName
when 'Main Course' then 
    case mcr.MainDish 
    when 1 then concat('<b>', c.CourseName, ': ', 'Main Dish - ', r.RecipeName, '</b>')
    when 0 then concat(c.CourseName, ': ', 'Side Dish - ', r.RecipeName)
    end
else concat(c.CourseName, ': ', r.RecipeName)
end, r.RecipePicture
from Recipe r 
join MealCourseRecipe mcr 
on mcr.RecipeId = r.RecipeId
join MealCourse mc 
on mcr.MealcourseId = mc.MealCourseId
join Course c 
on mc.CourseId = c.CourseId
join Meal m 
on m.MealId = mc.MealId
where m.MealName = 'Birthday Blast'

/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/

select c.CookbookName, u.UserName, NumOfRecipes = count(cr.RecipeId)
from Cookbook c 
join Users u 
on c.UsersId = u.UsersId
join CookbookRecipe cr 
on c.CookbookId = cr.CookbookId
where c.CookbookActive = 1
group by c.CookbookName, u.UserName
order by c.CookbookName

/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/

--a)

select c.CookbookName, u.UserName, c.DateCreated, c.Price, NumOfRecipes = count(cr.RecipeId), c.CookbookPicture 
from Cookbook c
join Users u 
on c.UsersId = u.UsersId
join CookbookRecipe cr 
on c.CookbookId = cr.CookbookId 
where c.CookbookName = 'Unreal'
group by c.CookbookName, u.UserName, c.DateCreated, c.Price, c.CookbookPicture

--b)

select r.RecipeName, c.CuisineName, NumOfIngredients = count(distinct ri.RecipeIngredientId), NumOfSteps = count(distinct rd.RecipeDirectionsId), r.RecipePicture
from Recipe r 
join CookbookRecipe cr
on r.RecipeId = cr.RecipeId
join Cookbook ck 
on ck.CookbookId = cr.CookbookId
join Cuisine c 
on r.CuisineId = c.CuisineId
join RecipeDirections rd
on r.RecipeId = rd.RecipeId
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
where ck.CookbookName = 'Unreal'
group by r.RecipeName, c.CuisineName, r.RecipePicture, cr.ISequence
order by cr.ISequence

/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name with the first letter capitalized and all others lower case.
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
        Note: ".jpg" file extension must be at the end of the reversed picture name EX: Recipe_Seikooc_pihc_etalocohc.jpg
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
        Hint: Use CTE
*/

--a)
select distinct RecipeName = concat(upper(left(reverse(r.RecipeName), 1)), lower(substring(reverse(r.RecipeName),2,100))), RecipePicture = concat('Recipe_', replace(concat(upper(left(reverse(r.RecipeName), 1)), lower(substring(reverse(r.RecipeName),2,100))), ' ', '_'), '.jpg')
from Recipe r 
join CookbookRecipe cr 
on r.RecipeId = cr.RecipeId

--b)

;with x as (
    select r.RecipeName, LastStep = max(rd.DirectionStepNum)
    from Recipe r 
    join RecipeDirections rd 
    on r.RecipeId = rd.RecipeId
    group by r.RecipeName
)
select rd.DirectionDesc
from x 
join recipe r 
on r.recipename = x.recipename
join RecipeDirections rd 
on r.recipeid = rd.RecipeId
where rd.DirectionStepNum = x.LastStep

/*
For site administration page:
5 seperate reports
    a) List of how many recipes each user created per status. Show 0 if user has no recipes at all.
    b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
    c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    e) List of archived recipes that were never published, and how long it took for them to be archived.
*/

--a)

select NumOfRecipes = count(r.RecipeId), u.UserName, CurrentStatus = isnull(r.CurrentStatus, '') 
from Users u 
left join Recipe r 
on u.UsersId = r.UsersId 
group by u.UserName, CurrentStatus

--b)

select NumOfRecipes = count(r.RecipeId), u.UserName, AvgDaysFromDraftToPublished = isnull(avg(datediff(day, r.DateDraft, r.DatePublished)), 0) 
from Users u 
join Recipe r 
on u.UsersId = r.UsersId 
group by u.UserName

--c

select u.UserName, TotalNumOfMeals = count(m.MealId), 
TotalActiveMeals = sum(
case m.MealActive
when 1 then 1 
else 0
end
),
TotalInactiveMeals = sum(
case m.MealActive
when 0 then 1 
else 0 
end
)
from Users u 
left join Meal m 
on u.UsersId = m.UsersId
group by u.UserName 

--d
select u.UserName, TotalNumOfCookbooks = count(c.CookbookId), 
TotalActiveCookbooks = sum(
case c.CookbookActive
when 1 then 1 
else 0
end
),
TotalInactiveCookbooks = sum(
case c.CookbookActive
when 0 then 1 
else 0 
end
)
from Users u 
left join cookbook c 
on u.UsersId = c.UsersId
group by u.UserName 

--e)

select r.RecipeName, DaysUntilArchived = datediff(day, r.DateDraft, r.DateArchived)
from Recipe r 
where r.CurrentStatus = 'Archived'
and r.DatePublished is null

/*
For user dashboard page:
    a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
        Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select
    b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status

    OPTIONAL CHALLENGE QUESTION
    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
        Hint: Start by writing a CTE to give you cuisines for which the user does have recipes. 
*/

--a)

;with x as (
    select u.UsersId 
    from Users u 
    where u.UserName = 'F.Green'
)

select ItemName = 'Recipes', Count = count(r.RecipeId)
from x 
left join Recipe r 
on x.UsersId = r.UsersId
union select 'Meals', count(m.MealId)
from x 
left join Meal m 
on x.UsersId = m.UsersId
union select 'Cookbooks', count(c.CookbookId)
from x 
left join Cookbook c 
on x.UsersId = c.UsersId

--b)

select r.RecipeName, r.CurrentStatus, 
NumOfHoursBetweenPreviousStatus = datediff(hour, 
case 
when r.CurrentStatus = 'Published' then r.DateDraft
when r.CurrentStatus = 'Archived' then isnull(r.DatePublished, r.DateDraft)
end,
case 
when r.CurrentStatus = 'Published' then r.DatePublished
when r.CurrentStatus = 'Archived' then r.DateArchived
end
),
r.RecipePicture
from Users u 
join Recipe r 
on u.UsersId = r.UsersId 
where r.CurrentStatus <> 'Draft'
and u.UserName = 'F.Green'

--c)

;with x as (
    select u.UsersId, u.UserName, r.RecipeId, r.RecipeName, r.CuisineId
    from Users u 
    join Recipe r 
    on u.UsersId = r.UsersId 
    where u.UserName = 'F.Green'
)

select c.CuisineName, NumOfRecipes = count(x.RecipeId) 
from Cuisine c  
left join x 
on x.CuisineId = c.CuisineId
group by c.CuisineName