create or alter proc dbo.CuisineUpdate(
    @CuisineId int output,
    @CuisineName varchar(25),
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0 

    select @CuisineId = isnull(@CuisineId, 0)

    if @CuisineId = 0
    begin 
        insert Cuisine (CuisineName)
        values (@CuisineName)

        select @CuisineId = scope_identity()
    end 
    else 
    begin 
        update Cuisine
        set 
        CuisineName = @CuisineName 
        where CuisineId = @CuisineId
    end

    return @return
end 
go