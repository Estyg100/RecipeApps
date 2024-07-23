insert Recipe (UsersId, RecipeName, CuisineId, CaloriesPerServing, DateDraft, DatePublished, DateArchived)
select '1', 'Lolly Pops', '2', 100, '2024-01-01', null, null 
union select '3', 'Smores', '3', 200, '2023-05-05', '2024-01-01', null 
union select '4', 'Cheese Cake', '1', 250, '2022-01-06', '2022-11-05', null 
