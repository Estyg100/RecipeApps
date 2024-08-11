create or alter proc CuisineDelete(
    @CuisineId int = 0,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

	select @CuisineId = isnull(@CuisineId,0)

    delete Recipe where CuisineId = @CuisineId
    delete Cuisine where CuisineId = @CuisineId

    return @return
end
go
