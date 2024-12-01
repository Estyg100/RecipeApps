create or alter proc dbo.IngredientGet(
    @All bit = 0,
    @IncludeBlank bit = 0,
    @IngredientName varchar (40) = ' '
)
as 
begin 

    select @IncludeBlank = isnull(@IncludeBlank, 0), @IngredientName = nullif(@IngredientName, ' ')

    select i.IngredientName, i.IngredientId
    from Ingredient i 
    where @All = 1
    or i.IngredientName like '%' + @IngredientName + '%'
    union select '', 0
    where @IncludeBlank = 1
    order by i.IngredientName
end
go

exec IngredientGet @IngredientName = 'e'