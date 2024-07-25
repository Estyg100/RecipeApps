create or alter procedure dbo.CuisineGet(@CuisineId int = 0, @All bit = 0, @CuisineName varchar(25) = '')
as 
begin 
    select @CuisineName = nullif(@CuisineName, '')
    select c.CuisineId, c.CuisineName
    from Cuisine c 
    where c.CuisineId = @CuisineId
    or @All = 1
    or c.CuisineName like '%' + @CuisineName + '%'
end

/*
exec CuisineGet

exec CuisineGet @All = 1

exec CuisineGet @CuisineName = ''
exec CuisineGet @CuisineName = null
exec CuisineGet @CuisineName = 'm'

declare @Id int 
select top 1 @Id = c.CuisineId from Cuisine c 
exec CuisineGet @CuisineId = @Id
*/