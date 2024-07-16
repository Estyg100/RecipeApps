-- SM Excellent! 100%
use HeartyHearthDB 
go 

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.

delete cr 
from CookbookRecipe cr
join cookbook c  
on c.CookbookId = cr.CookbookId 
join Users u 
on c.UsersId = u.UsersId 
where u.UserName = 'F.Green'

delete cr 
from CookbookRecipe cr
join Recipe r 
on cr.RecipeId = r.RecipeId
join Users u 
on r.UsersId = u.UsersId 
where u.UserName = 'F.Green'

delete c 
from Cookbook c  
join Users u 
on u.UsersId = c.UsersId 
where u.UserName = 'F.Green'

delete mcr 
from MealCourseRecipe mcr
join MealCourse mc 
on mc.MealCourseId = mcr.MealcourseId
join Meal m 
on mc.MealId = m.MealId  
join Users u 
on m.UsersId = u.UsersId
where u.UserName = 'F.Green'

delete mcr 
from MealCourseRecipe mcr
join Recipe r 
on mcr.RecipeId = r.RecipeId
join Users u 
on r.UsersId = u.UsersId
and mcr.RecipeId = r.RecipeId
where u.UserName = 'F.Green'

delete mc 
from MealCourse mc 
join Meal m 
on mc.MealId = m.MealId 
join Users u 
on u.UsersId = m.UsersId 
where u.UserName = 'F.Green'

delete m 
from Meal m 
join Users u 
on u.UsersId = m.UsersId
where u.UserName = 'F.Green'

delete rd 
from RecipeDirections rd 
join Recipe r 
on r.RecipeId = rd.RecipeId
join Users u 
on u.UsersId = r.UsersId 
where u.UserName = 'F.Green'

delete ri 
from RecipeIngredient ri 
join Recipe r 
on r.RecipeId = ri.RecipeId
join Users u 
on u.UsersId = r.UsersId 
where u.UserName = 'F.Green'

delete r 
from Recipe r 
join Users u 
on u.UsersId = r.UsersId 
where u.UserName = 'F.Green'

delete u  
from Users u 
where u.UserName = 'F.Green'

--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.

insert Recipe (RecipeName, UsersId, CuisineId, CaloriesPerServing, DateDraft, DatePublished, DateArchived)
select concat(r.RecipeName, ' - clone'), r.UsersId, r.CuisineId, r.CaloriesPerServing, r.DateDraft, r.DatePublished, r.DateArchived
from Recipe r 
where r.RecipeName = 'Apple Yogurt Smoothie'


;with x as (
	select r.RecipeId, ri.IngredientId, ri.MeasurementTypeId, ri.Quantity, ri.ISequence, r.UsersId
	from Recipe r
	join RecipeIngredient ri 
	on r.RecipeId = ri.RecipeId
	where r.RecipeName = 'Apple Yogurt Smoothie'
)

insert RecipeIngredient (RecipeId, IngredientId, MeasurementTypeId, Quantity, ISequence)
select r.RecipeId, x.IngredientId, x.MeasurementTypeId, x.Quantity, x.ISequence 
from x 
join Recipe r 
on x.UsersId = r.UsersId
where r.RecipeName = 'Apple Yogurt Smoothie - clone'


;with x as (
	select r.RecipeId, rd.DirectionStepNum, rd.DirectionDesc, r.UsersId
	from Recipe r 
	join RecipeDirections rd 
	on r.RecipeId = rd.RecipeId
	where r.RecipeName = 'Apple Yogurt Smoothie'
)

insert RecipeDirections (RecipeId, DirectionStepNum, DirectionDesc)
select r.RecipeId, x.DirectionStepNum, x.DirectionDesc
from x 
join Recipe r 
on x.UsersId = r.UsersId
where r.RecipeName =  'Apple Yogurt Smoothie - clone'

/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/

insert Cookbook (UsersId, CookbookName, Price, CookbookActive)
select u.UsersId, concat('Recipes by ', u.FirstName, ' ', u.LastName), count(r.RecipeId) * 1.33, 1
from Users u 
join Recipe r 
on u.UsersId = r.UsersId 
where u.UserName = 'F.Green'
group by u.UsersId, u.FirstName, u.LastName


;with x as (
	select c.CookbookId, c.UsersId 
	from Cookbook c 
	where c.CookbookName = 'Recipes by Freeda Green'
)

insert CookbookRecipe (CookbookId, RecipeId, ISequence)
select x.CookbookId, r.RecipeId, row_number() over (order by r.RecipeName)
from x 
join Users u 
on x.UsersId = u.UsersId
join Recipe r 
on u.UsersId = r.UsersId 
where u.UserName = 'F.Green'

/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/

update r 
set CaloriesPerServing = r.CaloriesPerServing - (ri.Quantity * 
case mt.MeasurementTypeName
when 'Tsp' then 1
when 'Cups' then 5
end)
from Ingredient i 
join RecipeIngredient ri 
on i.IngredientId = ri.IngredientId
join MeasurementType mt 
on mt.MeasurementTypeId = ri.MeasurementTypeId
join Recipe r 
on ri.RecipeId = r.RecipeId
where i.IngredientName = 'Sugar'

/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;with x as (
	select AvgHours = avg(datediff(hour, r.DateDraft, r.DatePublished))
	from Recipe r 
)

select u.FirstName, u.LastName, EmailAddress = lower(concat(substring(u.FirstName, 1, 1), u.LastName, '@heartyhearth.com')), 
Alert = concat('Your Recipe ', r.RecipeName, ' is sitting in draft for ', datediff(hour, r.DateDraft, getdate()), ' hours. That is ', datediff(hour, r.DateDraft, getdate()) - x.AvgHours, ' hours more than the average ', x.AvgHours, ' hours all recipes took to be published.') 
from Users u 
join Recipe r
on u.UsersId = r.UsersId 
cross join x
where r.CurrentStatus = 'Draft'
and datediff(hour, r.DateDraft, getdate()) >= x.AvgHours

/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and receive a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
select EmailBody = concat('Order cookbooks from HeartyHearth.com! We have ', count(*), ' books for sale, average price is ', convert(decimal (5,2), avg(c.Price)), '. You can order them all and receive a 25% discount, for a total of ', convert(decimal (5,2), sum(c.Price) * 0.75), '.
Click <a href = "www.heartyhearth.com/order/',newid(),'">here</a> to order.')
from Cookbook c 
