-- SM Excellent! See comment, no need to resubmit.
use HeartyHearthDB 
go 

drop table if exists CookbookRecipe
go
drop table if exists Cookbook
go 
drop table if exists MealCourseRecipe
go 
drop table if exists MealCourse 
go 
drop table if exists Course 
go 
drop table if exists Meal 
go 
drop table if exists RecipeDirections
go 
drop table if exists RecipeIngredient 
go 
drop table if exists MeasurementType
go 
drop table if exists Ingredient 
go
drop table if exists Recipe 
go 
drop table if exists Cuisine
go 
drop table if exists Users 
go 

create table dbo.Users (
    UsersId int not null identity primary key,
    FirstName varchar (15) not null constraint ck_Users_FirstName_cannot_be_blank check(FirstName <> ''),
    LastName varchar (15) not null constraint ck_Users_LastName_cannot_be_blank check(LastName <> ''),
    UserName varchar (25) constraint u_Users_UserName unique 
        constraint ck_Users_UserName_cannot_be_blank check(UserName <> '')
)
go 

create table dbo.Cuisine (
    CuisineId int not null identity primary key,
    CuisineName varchar (25) not null constraint u_Cuisine_CuisineName unique
        constraint ck_Cuisine_CuisineName_cannot_be_blank check(CuisineName <> '') 
)
go 

create table dbo.Recipe (
    RecipeId int not null identity primary key,
    UsersId int not null constraint f_Users_Recipe foreign key references Users(UsersId),
    CuisineId int not null constraint f_Cuisine_Recipe foreign key references Cuisine(CuisineId),
    RecipeName varchar (30) not null constraint u_Recipe_RecipeName unique
        constraint ck_Recipe_RecipeName_cannot_be_blank check(RecipeName <> ''),
    CaloriesPerServing int not null constraint ck_Recipe_Calories_cannot_be_negative check(CaloriesPerServing >= 0),
    DateDraft datetime not null default convert(varchar(10), getutcdate() at time zone 'UTC' at time zone 'Eastern Standard Time') constraint ck_Recipe_DateDrafted_cannot_be_future check(DateDraft <= getutcdate() at time zone 'UTC' at time zone 'Eastern Standard Time'),
    DatePublished datetime constraint ck_Recipe_DatePublished_cannot_be_future check(DatePublished <= getutcdate() at time zone 'UTC' at time zone 'Eastern Standard Time'),
    DateArchived datetime constraint ck_Recipe_DateArchived_cannot_be_future check(DateArchived <= getutcdate() at time zone 'UTC' at time zone 'Eastern Standard Time'),
-- SM Dates must always be in order Draft -> Publish -> Archive. Adjust computed column.
    CurrentStatus as 
        case 
        when DateDraft <= DatePublished and DateArchived is null then 'Published'
        when DatePublished is null and DateArchived is null then 'Draft'
        else 'Archived'
        end 
        persisted,
    RecipePicture as concat('Recipe_', replace(RecipeName, ' ', '_'), '.jpg') persisted,
        constraint ck_Recipe_DateDraft_must_be_first check(DateDraft <= DatePublished and DateDraft <= DateArchived),
        constraint ck_Recipe_DatePublished_must_be_before_DateArchived check(DatePublished <= DateArchived)
)
go 

create table dbo.Ingredient (
    IngredientId int not null identity primary key,
    IngredientName varchar (40) not null constraint u_Ingredient_IngredientName unique
        constraint ck_Ingredient_IngredientName_cannot_be_blank check(IngredientName <> ''),
    IngredientPicture as concat('Inridient_', replace(IngredientName, ' ', '_'), '.jpg') persisted 
)
go 

create table dbo.MeasurementType (
    MeasurementTypeId int not null identity primary key,
    MeasurementTypeName varchar (10) not null constraint u_MeasurementType_MeasurementTypeName unique 
        constraint ck_MeasurementType_MeasurementTypeName_cannot_be_blank check(MeasurementTypeName <> '')
)
go

create table dbo.RecipeIngredient (
    RecipeIngredientId int not null identity primary key,
    RecipeId int not null constraint f_Recipe_RecipeIngredient foreign key references Recipe(RecipeId),
    IngredientId int not null constraint f_Ingredient_RecipeIngredient foreign key references Ingredient(IngredientId),
    MeasurementTypeId int constraint f_MeasurementType_RecipeIngredient foreign key references MeasurementType(MeasurementTypeId),
    Quantity decimal (5,2) not null constraint ck_RecipeIngredient_Quantity_cannot_be_negative check(Quantity >= 0),
    ISequence int not null constraint ck_RecipeIngredient_ISequence_must_be_greater_than_zero check(ISequence > 0)
        constraint u_RecipeIngredient_RecipeId_and_IngredientId unique(RecipeId, IngredientId),
        constraint u_RecipeIngredient_RecipeId_and_ISequence unique(RecipeId, ISequence)
)
go 

create table dbo.RecipeDirections (
    RecipeDirectionsId int not null identity primary key,
    RecipeId int not null constraint f_Recipe_RecipeDirections foreign key references Recipe(RecipeId),
    DirectionStepNum int not null constraint ck_RecipeDirections_DirectionStepNum_must_be_greater_than_zero check(DirectionStepNum > 0),
    DirectionDesc varchar (200) not null constraint ck_RecipeDirections_DirectionDesc_cannot_be_blank check(DirectionDesc <> ''),
        constraint u_RecipeDirections_DirectionStepNum unique(RecipeId, DirectionStepNum)
)
go

create table dbo.Meal (
    MealId int not null identity primary key,
    UsersId int not null constraint f_Users_Meal foreign key references Users(UsersId),
    MealName varchar (20) constraint u_Meal_MealName unique
        constraint ck_Meal_MealName_cannot_be_blank check(MealName <> ''),
    DateCreated date not null default convert(varchar(10), getutcdate() at time zone 'UTC' at time zone 'Eastern Standard Time') constraint ck_Meal_DateCreated_cannot_be_future check(DateCreated <= getutcdate() at time zone 'UTC' at time zone 'Eastern Standard Time'),
    MealActive bit not null default 1,
    MealPicture as concat('Meal_', replace(MealName, ' ', '_'), '.jpg')
)
go 

create table dbo.Course (
    CourseId int not null identity primary key,
    CourseName varchar (30) not null constraint u_Course_CourseName unique
        constraint ck_Course_CourseName_cannot_be_blank check(CourseName <> ''),
    ISequence int not null constraint u_Course_ISequence unique
        constraint ck_Course_ISequence_should_be_greater_than_0 check(ISequence > 0) 
)
go 

create table dbo.MealCourse (
    MealCourseId int not null identity primary key,
    MealId int not null constraint f_Meal_MealCourse foreign key references Meal(MealId),
    CourseId int not null constraint f_Course_MealCourse foreign key references Course(CourseId),
        constraint u_MealCourse_MealId_and_CourseId unique(MealId, CourseId)
)
go 

create table dbo.MealCourseRecipe (
    MealCourseRecipeId int not null identity primary key,
    MealcourseId int not null constraint f_Mealcourse_MealCourserecipe foreign key references MealCourse(MealcourseId),
    RecipeId int not null constraint f_Recipe_MealCourseRecipe foreign key references Recipe(RecipeId),
    MainDish bit not null
        constraint u_MealCourseRecipe_MealCourseId_and_RecipeId unique (MealCourseId, RecipeId)
)
go 

create table dbo.Cookbook (
    CookbookId int not null identity primary key,
    UsersId int not null constraint f_Users_Cookbook foreign key references Users(UsersId),
    CookbookName varchar (40) constraint u_Cookbook_CookbookName unique
        constraint ck_Cookbook_CookbookName_cannot_be_blank check(CookbookName <> ''),
    Price decimal(5,2) not null constraint ck_Cookbook_Price_must_be_greater_than_zero check(Price > 0),
    DateCreated date not null default convert(varchar(10), getutcdate() at time zone 'UTC' at time zone 'Eastern Standard Time') constraint ck_Cookbook_DateCreated_cannot_be_future check(DateCreated <= getutcdate() at time zone 'UTC' at time zone 'Eastern Standard Time'),
    CookbookActive bit not null default 1,
    CookbookPicture as concat('Cookbook_', replace(CookbookName, ' ', '_'), '.jpg')
)
go 

create table dbo.CookbookRecipe (
    CookbookRecipeId int not null identity primary key,
    CookbookId int not null constraint f_Cookbook_CookbookReicpe foreign key references Cookbook(CookbookId),
    RecipeId int not null constraint f_Recipe_CookbookRecipe foreign key references Recipe(RecipeId),
    ISequence int not null constraint ck_CookbookRecipe_ISequence_must_be_greater_than_0 check(ISequence > 0)
        constraint u_CookbookRecipe_CookbookId_ISequence unique(CookbookId, ISequence),
        constraint u_CookbookRecipe_CookbookId_RecipeId unique(CookbookId, RecipeId)
)
go 
