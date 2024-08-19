
-- Update

declare 
@Message varchar (500) = '', 
@return int, @recipeid int, 
@usersid int, @cuisineid int, 
@recipename varchar (30), 
@caloriesperserving int, 
@datedraft datetime, 
@datepublished datetime, 
@datearchived datetime 

select top 1 
@recipeid = r.RecipeId,
@UsersId = r.UsersId,
@CuisineId = r.CuisineId,
@recipename = r.RecipeName,
@caloriesperserving = r.CaloriesPerServing,
@datedraft = r.DateDraft,
@datepublished = r.DatePublished,
@datearchived = r.DateArchived
from Recipe r 

select @recipename = reverse(@recipename)

exec @return = RecipeUpdate
@RecipeId = @recipeid output,
@UsersId = @usersid,
@CuisineId = @cuisineid,
@RecipeName = @recipename,
@CaloriesPerServing = @caloriesperserving,
@DateDraft = @datedraft,
@DatePublished = @datepublished,
@DateArchived = @datearchived,
@Message = @Message output 

select @return, @Message, @recipeid

select top 1 *
from Recipe r 
where r.RecipeId = @recipeid

go

--Insert 

declare 
@Message varchar (500) = '', 
@return int, @recipeid int, 
@usersid int, @cuisineid int, 
@recipename varchar (30), 
@caloriesperserving int, 
@datedraft datetime, 
@datepublished datetime, 
@datearchived datetime

select top 1 @usersid = u.UsersId from Users u
select top 1 @cuisineid = c.CuisineId from Cuisine c 

exec @return = RecipeUpdate 
@RecipeId = @recipeid output,
@UsersId = @usersid,
@CuisineId = @cuisineid,
@RecipeName = 'Hellot',
@CaloriesPerServing = 100,
@DateDraft = '1/1/2024',
@DatePublished = '5/6/2024',
@DateArchived = null,
@Message = @Message output 

select @return, @Message, @recipeid

select top 1 *
from Recipe r 
where r.RecipeId = @recipeid

delete Recipe where RecipeId = @recipeid

go

select * 
from Recipe