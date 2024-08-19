create or alter proc dbo.IngredientGet(
    @All bit = 1
)
as 
begin 
    select i.IngredientName, i.IngredientId
    from Ingredient i 
    where @All = 1
    order by i.IngredientName
end
go

exec IngredientGet