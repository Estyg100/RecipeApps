create or alter proc dbo.MeasurementTypeGet(
    @All bit = 1,
    @IncludeBlank bit = 0
)
as 
begin 
    select m.MeasurementTypeName, m.MeasurementTypeId
    from MeasurementType m
    where @All = 1
    union select ' ', 0
    where @IncludeBlank = 1
    order by m.MeasurementTypeName
end
go

exec MeasurementTypeGet