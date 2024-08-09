create or alter procedure dbo.CourseGet(@CourseId int = 0, @All bit = 0)
as 
begin 
    select c.CourseId, c.CourseName
    from Course c
    where @All = 1
end
