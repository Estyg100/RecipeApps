create or alter procedure dbo.CookbookGet(@CookbookId int = 0, @All bit = 0)
as 
begin
    select *
    from Cookbook c 
    where c.CookbookId = @CookbookId
    or @All = 1
end
go 
