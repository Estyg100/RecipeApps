create or alter proc dbo.CourseUpdate(
    @CourseId int output,
    @CourseName varchar(30),
    @ISequence int,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0 

    select @CourseId = isnull(@CourseId, 0)

    if @CourseId = 0
    begin 
        insert Course (CourseName, ISequence)
        values (@CourseName, @ISequence)

        select @CourseId = scope_identity()
    end 
    else 
    begin 
        update Course 
        set 
        CourseName = @CourseName,
        ISequence = @ISequence 
        where CourseId = @CourseId
    end

    return @return
end 
go