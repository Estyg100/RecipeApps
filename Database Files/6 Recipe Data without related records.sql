;with x as (
    select UserName = 'H.Inuit', CuisineName = 'American', RecipeName = 'Lolly Pops', CaloriesPerServing = 100, DateDrafted = '2024-01-01', DatePublished = null, DateArchived = null 
    union select 'F.Green', 'French', 'Smores', 200, '2023-05-05', '2024-01-01', null 
    union select 'A.Billy', 'English', 'Cheese Cake',  250, '2022-01-06', '2022-11-05', null 
)

insert Recipe (UsersId, CuisineId, RecipeName, CaloriesPerServing, DateDraft, DatePublished, DateArchived)
select u.UsersId, c.CuisineId, x.RecipeName, x.CaloriesPerServing, x.DateDrafted, x.DatePublished, x.DateArchived 
from x 
join Users u 
on x.UserName = u.UserName 
join Cuisine c 
on x.CuisineName = c.CuisineName