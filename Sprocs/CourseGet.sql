create or alter procedure dbo.CourseGet(@CourseId int = 0, @All bit = 0)
as 
begin 
    select c.CourseId, c.CourseName, ISequence
    from Course c
    where @All = 1
    order by ISequence
end
