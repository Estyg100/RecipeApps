create or alter proc dbo.DashboardGet(
    @Messsage varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    select Type = 'Recipes', Number =  count(*)
	from Recipe
	union select 'Meals', count(*)
	from Meal m 
    union select 'Coobooks', count(*) 
    from Cookbook c
    order by Type desc

    return @return
end 
go 

exec DashboardGet
