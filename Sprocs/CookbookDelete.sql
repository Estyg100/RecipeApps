create or alter procedure dbo.CookbookDelete(
	@CookbookId int,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0
		delete CookbookRecipe where CookbookId = @CookbookId
        delete Cookbook where CookbookId = @cookbookId
	return @return
end
go
