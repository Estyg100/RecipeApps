create or alter proc dbo.MeasurementTypeGet(
    @All bit = 1
)
as 
begin 
    select m.MeasurementTypeName, m.MeasurementTypeId
    from MeasurementType m
    union select ' ', 0
    where @All = 1
    order by m.MeasurementTypeName
end
go

exec MeasurementTypeGet