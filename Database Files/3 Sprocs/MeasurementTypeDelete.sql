create or alter proc dbo.MeasurementTypeDelete(
    @MeasurementTypeId int = 0,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int 

    select @MeasurementTypeId = isnull(@MeasurementTypeId, 0)

    delete RecipeIngredient where MeasurementTypeId = @MeasurementTypeId
    delete MeasurementType where MeasurementTypeId = @MeasurementTypeId

    return @return
end