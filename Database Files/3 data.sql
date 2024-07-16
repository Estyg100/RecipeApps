-- SM 100%
use HeartyHearthDB 
go 

delete CookbookRecipe
go 
delete Cookbook 
go
delete MealCourseRecipe
go
delete MealCourse 
go 
delete Course 
go 
delete Meal
go
delete RecipeDirections
go
delete RecipeIngredient 
go 
delete MeasurementType 
go 
delete Ingredient 
go 
delete Recipe 
go 
delete Cuisine 
go 
delete Users 
go 

insert Users (FirstName, LastName, UserName)
select 'Anna', 'Billy', 'A.Billy'
union select 'Carl', 'Deagout', 'C.Deagout'
union select 'Freeda', 'Green', 'F.Green'
union select 'Hannah', 'Inuit', 'H.Inuit'
union select 'Paul', 'Fast', 'P.Fast'

insert Cuisine (CuisineName)
select 'American'
union select 'French'
union select 'English'

;with x as (
    select UserName = 'H.Inuit', CuisineName = 'American', RecipeName = 'Chocolate Chip Cookies', CaloriesPerServing = 65, DateDrafted = '2020-04-24', DatePublished = '2020-11-05', DateArchived = null
    union select 'H.Inuit', 'French', 'Apple Yogurt Smoothie', 140, '2023-08-09', '2023-11-23', null
    union select 'F.Green', 'English', 'Cheese Bread', 71, '2023-02-15', null, null
    union select 'C.Deagout', 'American', 'Butter Muffins', 321, '2023-09-08', null, '2024-01-02'
    union select 'A.Billy', 'English', 'Squash Soup', 100, '2023-08-26', '2023-11-24', '2024-02-14'
    union select 'H.Inuit', 'English', 'Lotus Pie', 267, '2024-01-15', '2024-02-18', null
    union select 'F.Green', 'French', 'Pastrami Salad', 390, '2023-11-19', '2024-01-27', null 
)

insert Recipe (UsersId, CuisineId, RecipeName, CaloriesPerServing, DateDraft, DatePublished, DateArchived)
select u.UsersId, c.CuisineId, x.RecipeName, x.CaloriesPerServing, x.DateDrafted, x.DatePublished, x.DateArchived 
from x 
join Users u 
on x.UserName = u.UserName 
join Cuisine c 
on x.CuisineName = c.CuisineName

insert Ingredient (IngredientName)
select 'Sugar'
union select 'Oil'
union select 'Eggs'
union select 'Flour'
union select 'Vanilla Sugar'
union select 'Baking Powder'
union select 'Baking Soda'
union select 'Chocolate Chips'
union select 'Granny Smith Apples'
union select 'Vanilla Yogurt'
union select 'Orange Juice'
union select 'Honey'
union select 'Ice Cubes'
union select 'Bread'
union select 'Butter'
union select 'Shredded Cheese'
union select 'Garlic (crushed)'
union select 'Black Pepper'
union select 'Salt'
union select 'Vanilla Pudding'
union select 'Whipped Cream Cheese'
union select 'Sour Cream Cheese'
union select 'Yellow Zuchini'
union select 'Potatoes'
union select 'Paprika'
union select 'Water'
union select 'Onion'
union select 'Butternut Squash'
union select 'Green Zuchini'
union select 'Vanilla Ice Cream'
union select 'Lotus Cream'
union select 'Lotus Cookies'
union select 'Peanut Butter'
union select 'Caramel Chips'
union select 'Coffee (disolved)'
union select '9" Pie Crust'
union select 'Romaine Lettuce'
union select 'Pastrami'
union select 'Chickpeas'
union select 'Fresh Mushrooms'
union select 'Red Pepper'
union select 'Cherry Tomatoes'
union select 'Mayonnaise'
union select 'Lemon Juice'
union select 'Mustard'
union select 'Parsley Flakes'

insert MeasurementType (MeasurementTypeName)
select 'Cups'
union select 'Tsp'
union select 'Tbsp'
union select 'Club'
union select 'oz.'
union select 'Clove'
union select 'Pinch'
union select 'Stick'
union select 'Pkg.'
union select 'lb.'
union select 'Slices'

;with x as (
    select RecipeName = 'Chocolate Chip Cookies', IngredientName = 'Sugar', MeasurementTypeName = 'Cups', Quantity = '1', ISequence = 1
    union select 'Chocolate Chip Cookies', 'Oil', 'Cups', '0.5', 2
    union select 'Chocolate Chip Cookies', 'Eggs', null, '3', 3
    union select 'Chocolate Chip Cookies', 'Flour', 'Cups', '2', 4
    union select 'Chocolate Chip Cookies', 'Vanillla Sugar', 'Tsp', '1', 5
    union select 'Chocolate Chip Cookies', 'Baking Powder', 'Tsp', '2', 6
    union select 'Chocolate Chip Cookies', 'Baking Soda', 'Tsp', '0.5', 7
    union select 'Chocolate Chip Cookies', 'Chocolate Chips', 'Cups', '1', 8
    union select 'Apple Yogurt Smoothie', 'Granny Smith Apples', null, '3', 1
    union select 'Apple Yogurt Smoothie', 'Vanilla Yogurt', 'Cups', '2', 2
    union select 'Apple Yogurt Smoothie', 'Sugar', 'Tsp', '2', 3
    union select 'Apple Yogurt Smoothie', 'Orange Juice', 'Cups', '0.5', 4
    union select 'Apple Yogurt Smoothie', 'Honey', 'Tbsp', '2', 5
    union select 'Apple Yogurt Smoothie', 'Ice Cubes', null, '5', 6
    union select 'Cheese Bread', 'Bread', 'Club', '1', 1
    union select 'Cheese Bread', 'Butter', 'oz.', '4', 2
    union select 'Cheese Bread', 'Shredded Cheese', 'oz.', '8', 3
    union select 'Cheese Bread', 'Crushed Garlic', 'Clove', '2', 4
    union select 'Cheese Bread', 'Black Pepper', 'Tsp', '0.25', 5
    union select 'Cheese Bread', 'Salt', 'Pinch', '1', 6
    union select 'Butter Muffins', 'Butter', 'Stick', '1', 1
    union select 'Butter Muffins', 'Sugar', 'Cups', '3', 2
    union select 'Butter Muffins', 'Vanilla Pudding', 'Tbsp', '2', 3
    union select 'Butter Muffins', 'Eggs', null, '4', 4
    union select 'Butter Muffins', 'Wihpped Cream Cheese', 'oz.', '8', 5
    union select 'Butter Muffins', 'Sour Cream Cheese', 'oz.', '8', 6
    union select 'Butter Muffins', 'Flour', 'Cups', '1', 7
    union select 'Butter Muffins', 'Baking Powder', 'Tsp', '2', 8
    union select 'Squash Soup', 'Crushed Garlic', 'Cloves', '3', 1
    union select 'Squash Soup', 'Onion', null, '1', 2
    union select 'Squash Soup', 'Green Zuchini', null, '2', 3
    union select 'Squash Soup', 'Yellow Zuchini', null, '2', 4
    union select 'Squash Soup', 'Butternut Squash', null, '1', 5
    union select 'Squash Soup', 'Potatoes', null, '3', 6
    union select 'Squash Soup', 'Water', 'Cups', '3', 7
    union select 'Squash Soup', 'Salt', 'Tsp', '1', 8
    union select 'Squash Soup', 'Black Pepper', 'Tsp', '1', 9
    union select 'Squash Soup', 'Paprika', 'Tsp', '1', 10
    union select 'Squash Soup', 'Oil', 'Cup', '0.25', 11
    union select 'Lotus Pie', 'Vanilla Ice Cream', 'lb.', '1', 1
    union select 'Lotus Pie', 'Lotus Cream', 'Tbsp', '4', 2
    union select 'Lotus Pie', 'Peanut Butter', 'Tbsp', '1', 3
    union select 'Lotus Pie', 'Coffee (disolved)', 'Tbsp', '2', 4
    union select 'Lotus Pie', 'Chocolate Chips', 'Cups', '0.125', 5
    union select 'Lotus Pie', 'Caramel Chips', 'Cups', '0.125', 6
    union select 'Lotus Pie', '9" Pie Crust', null, '2', 7
    union select 'Lotus Pie', 'Lotus Cookies', 'Pkg.', '1', 8
    union select 'Pastrami Salad', 'Pastrami', 'Slices', '5', 1
    union select 'Pastrami Salad', 'Romaine Lettuce', 'Pkg.', '1', 2
    union select 'Pastrami Salad', 'Chickpeas', 'oz.', '16', 3
    union select 'Pastrami Salad', 'Fresh Mushrooms', 'oz.', '16', 4
    union select 'Pastrami Salad', 'Red Pepper', null, '1', 5
    union select 'Pastrami Salad', 'Cherry Tomatoes', null, '20', 6
    union select 'Pastrami Salad', 'Mayonnaise', 'Cups', '0.5', 7
    union select 'Pastrami Salad', 'Water', 'Cups', '0.5', 8
    union select 'Pastrami Salad', 'Mustard', 'Tsp', '1', 9
    union select 'Pastrami Salad', 'Lemon juice', 'Tsp', '1', 10
    union select 'Pastrami Salad', 'Vanilla Sugar', 'Tbsp', '2', 11
    union select 'Pastrami Salad', 'Salt', 'Tsp', '0.5', 12
    union select 'Pastrami Salad', 'Parsley Flakes', 'Tbsp', '2', 13
    union select 'Pastrami Salad', 'Oil', 'Cup', '0.5', 14
)

insert RecipeIngredient (RecipeId, IngredientId, MeasurementTypeId, Quantity, ISequence)
select r.RecipeId, i.IngredientId, m.MeasurementTypeId, x.Quantity, x.ISequence
from x 
join Recipe r
on x.RecipeName = r.RecipeName
join Ingredient i 
on x.IngredientName = i.IngredientName
left join MeasurementType m 
on x.MeasurementTypeName = m.MeasurementTypeName

;with x as (
    select RecipeName = 'Chocolate Chip Cookies', DirectionStepNum = 1, DirectionDesc = 'First combine sugar, oil and eggs in a bowl'
    union select 'Chocolate Chip Cookies', 2, 'mix well'
    union select 'Chocolate Chip Cookies', 3, 'add flour, vanilla sugar, baking powder and baking soda'
    union select 'Chocolate Chip Cookies', 4, 'beat for 5 minutes'
    union select 'Chocolate Chip Cookies', 5, 'add chocolate chips'
    union select 'Chocolate Chip Cookies', 6, 'freeze for 1-2 hours'
    union select 'Chocolate Chip Cookies', 7, 'roll into balls and place spread out on a cookie sheet'
    union select 'Chocolate Chip Cookies', 8, 'bake on 350 for 10 min.'
    union select 'Apple Yogurt Smoothie', 1, 'Peel the apples and dice'
    union select 'Apple Yogurt Smoothie', 2, 'Combine all ingredients in bowl except for apples and ice cubes'
    union select 'Apple Yogurt Smoothie', 3, 'mix until smooth'
    union select 'Apple Yogurt Smoothie', 4, 'add apples and ice cubes'
    union select 'Apple Yogurt Smoothie', 5, 'pour into glasses.'
    union select 'Cheese Bread', 1, 'Slit bread every 3/4 inch'
    union select 'Cheese Bread', 2, 'Combine all ingredients in bowl'
    union select 'Cheese Bread', 3, 'fill slits with cheese mixture'
    union select 'Cheese Bread', 4, 'wrap bread into a foil and bake for 30 minutes.'
    union select 'Butter Muffins', 1, 'Cream butter with sugars'
    union select 'Butter Muffins', 2, 'Add eggs and mix well'
    union select 'Butter Muffins', 3, 'Slowly add rest of ingredients and mix well'
    union select 'Butter Muffins', 4, 'fill muffin pans 3/4 full and bake for 30 minutes.'
    union select 'Squash Soup', 1, 'Dice the onions' 
    union select 'Squash Soup', 2, 'Pour the oil into a pot and put the flame on low'
    union select 'Squash Soup', 3, 'Add the onions and garlic and let it simmer for 10 minutes'
    union select 'Squash Soup', 4, 'Meanwhile, Peel the vegetables and cut them so that they fit into the pot'
    union select 'Squash Soup', 5, 'After the 10 minutes are over, add the vegetables, water and spices, and set the flame to medium'
    union select 'Squash Soup', 6, 'Let it boil until vegetables are soft'
    union select 'Squash Soup', 7, 'Blend, and serve warm'
    union select 'Lotus Pie', 1, 'Put the ice cream in a large bowl and let it sit for a few minutes so that it''s not too stiff, but easy to work with'
    union select 'Lotus Pie', 2, 'Add Lotus Cream, Peanut Butter, Coffee, Chocolate Chips and caramel chips.'
    union select 'Lotus Pie', 3, 'Devide the mixture between both pie crusts'
    union select 'Lotus Pie', 4, 'Freeze overnight'
    union select 'Lotus Pie', 5, 'Cut into Slices and serve with Lotus Cookies'
    union select 'Pastrami Salad', 1, 'Cut Pastrami into small pieces'
    union select 'Pastrami Salad', 2, 'Pour half of the oil into a frying pan, and add the Pastrami'
    union select 'Pastrami Salad', 3, 'Fry until the edges are crispy, and then put aside'
    union select 'Pastrami Salad', 4, 'Cut the mushrooms into pieces'
    union select 'Pastrami Salad', 5, 'Put the cut mushrooms and chickpeas into a lined cookie sheet'
    union select 'Pastrami Salad', 6, 'Add the remaining oil as well as some spices of your choice'
    union select 'Pastrami Salad', 7, 'Mix well and bake until golden'
    union select 'Pastrami Salad', 8, 'Por the lettuce into a large bowl'
    union select 'Pastrami Salad', 9, 'Add the Pastrami and Chickpeas and mushrooms'
    union select 'Pastrami Salad', 10, 'Dice the pepper and add to bowl'
    union select 'Pastrami Salad', 11, 'Cut the Cherry tomatoes in half, and add to bowl'
    union select 'Pastrami Salad', 12, 'In a separate small bowl, combine the remaining the Ingredients'
    union select 'Pastrami Salad', 13, 'Mix well'
    union select 'Pastrami Salad', 14, 'Serve Salad topped with dressing'
)

insert RecipeDirections (RecipeId, DirectionStepNum, DirectionDesc)
select r.RecipeId, x.DirectionStepNum, x.DirectionDesc 
from x 
join Recipe r 
on x.RecipeName = r.RecipeName

;with x as (
    select UserName = 'P.Fast', MealName = 'Breakfast bash', MealActive = 1
    union select 'P.Fast', 'Birthday Blast', 1
    union select 'H.Inuit', 'Dinner', 1
    union select 'H.Inuit', 'Mid-day Snack', 0
)

insert Meal (UsersId, MealName, MealActive)
select u.UsersId, x.MealName, x.MealActive 
from x 
join Users u 
on x.UserName = u.UserName

insert Course (CourseName, ISequence)
select 'Appetizer', 1
union select 'Main Course', 2
union select 'Dessert', 3

;with x as (
    select MealName = 'Breakfast Bash', CourseName = 'Main Course'
    union select 'Breakfast Bash', 'Appetizer'
    union select 'Birthday Blast', 'Main Course'
    union select 'Birthday Blast', 'Dessert'
    union select 'Dinner', 'Appetizer'
    union select 'Dinner', 'Main Course'
    union select 'Dinner', 'Dessert'
    union select 'Mid-day Snack', 'Main Course'
)

insert MealCourse (MealId, CourseId)
select m.MealId, c.CourseId 
from x 
join Meal m 
on x.MealName = m.MealName
join Course c 
on x.CourseName = c.CourseName

;with x as (
    select MealName = 'Breakfast Bash', CourseName = 'Main Course', RecipeName = 'Cheese Bread', MainDish = 1
    union select 'Breakfast Bash', 'Main Course', 'Butter Muffins', 0
    union select 'Breakfast Bash', 'Appetizer', 'Apple Yogurt Smoothie', 1
    union select 'Birthday Blast', 'Main Course', 'Apple Yogurt Smoothie', 1
    union select 'Birthday Blast', 'Main Course', 'Butter Muffins', 0
    union select 'Birthday Blast', 'Dessert', 'Chocolate Chip Cookies', 0
    union select 'Birthday Blast', 'Dessert', 'Lotus Pie', 1
    union select 'Dinner', 'Appetizer', 'Squash Soup', 1
    union select 'Dinner', 'Main Course', 'Pastrami Salad', 1
    union select 'Dinner', 'Dessert', 'Lotus Pie', 1
    union select 'Mid-day Snack', 'Main Course', 'Butter Muffins', 1
    union select 'Mid-day Snack', 'Main Course', 'Chocolate Chip Cookies', 0
)

insert MealCourseRecipe (MealcourseId, RecipeId, MainDish)
select mc.MealCourseId, r.RecipeId, x.MainDish
from x 
join Meal m 
on x.MealName = m.MealName
join Course c 
on x.CourseName = c.CourseName
join MealCourse mc 
on m.MealId = mc.MealId
and c.CourseId = mc.CourseId
join Recipe r 
on x.RecipeName = r.RecipeName

;with x as (
    select UserName = 'P.Fast', CookbookName = 'Treats for two', Price = '30', CookbookActive = 1
    union select 'H.Inuit', 'Heaven on Earth', '50.45', 1
    union select 'F.Green', 'Tablescape', '26.99', 0
    union select 'C.Deagout', 'Unreal', '32.75', 1
)

insert Cookbook (UsersId, CookbookName, Price, CookbookActive)
select u.UsersId, x.CookbookName, x.Price, x.CookbookActive
from x 
join Users u 
on x.UserName = u.UserName

;with x as (
    select CookbookName = 'Treats for Two', RecipeName = 'Chocolate Chip Cookies', ISequence = 1
    union select 'Treats for Two', 'Apple Yogurt Smoothie', 2
    union select 'Treats for Two', 'Cheese Bread', 3
    union select 'Treats for Two', 'Butter Muffins', 4
    union select 'Heaven on Earth', 'Chocolate Chip Cookies', 1
    union select 'Heaven on Earth', 'Lotus Pie', 2
    union select 'Heaven on Earth', 'Butter Muffins', 3
    union select 'Heaven on Earth', 'Pastrami Salad', 4
    union select 'Tablescape', 'Squash Soup', 1
    union select 'Tablescape', 'Apple Yogurt Smoothie', 2
    union select 'Tablescape', 'Butter Muffins', 3
    union select 'Unreal', 'Pasrtrami Salad', 1
    union select 'Unreal', 'Cheese Bread', 2
    union select 'Unreal', 'Lotus Pie', 3
    union select 'Unreal', 'Apple Yogurt Smoothie', 4
)

insert CookbookRecipe (CookbookId, RecipeId, ISequence)
select c.CookbookId, r.RecipeId, x.ISequence 
from x 
join Cookbook c 
on x.CookbookName = c.CookbookName
join Recipe r 
on x.RecipeName = r.RecipeName