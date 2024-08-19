-- SM Excellent sketch! See comments. I think you can start creating the DB. Good luck!
/*
-- SM You wont be able to use user as a table name. Either use Users (and PK should be UsersId) or use Staff.|:
Users 
    UsersId int pk
    FirstName varchar(15)
    LastName varchar (15)
-- SM Should be unique.
    UserName varchar (25) unique 

Cuisine 
    CuisineId int pk
    CuisineName varchar (20) unique

Recipe 
    RecipeId int pk
    UsersId int fk to Users
    CuisineId int fk to Cuisine
    RecipeName varchar (30) unique
-- SM Computed columns should be at the bottom.
    Calories int 
-- SM FKs should be at the top.
    DateDrafted date 
    DatePublished date 
    DateArchived date
    CurrentStatus computed column
    RecipePicture computed column

Ingridient
    IngridientId int pk
    IngridientName varchar (40) unique
    IngridientPicture computed column

MeasurementType 
    MeasurmentTypeId int pk
    MeasurmentTypeName varchar(10) unique 

RecipeIngridient 
    RecipeIngridientId int pk 
    RecipeId int fk to Recipe
    IngridientId int fk to Ingridient
    MeasurmentType int fk to MeasurmentType
    Quantity int
    Sequence int  
-- SM Sequence should also be unique to recipe.
        unique RecipeId & IngridientId
        unique RecipeId & Sequence

RecipeDirections
    RecipeDirectionId int pk
    RecipeId int fk to Recipe
    DirectionStepsNum int 
    DirectionDesc varchar(200)
-- SM No need to include direction desc in unique constraint.
        unique RecipeId & DirectionStepsNum

Meal 
   MealId int pk 
   UserId int fk to Users
   MealName varchar (20) unique 
-- SM Computed columns should be at the bottom.
   DateCreated date 
   MealActive bit
-- SM FKs should be at the top.
   MealPicture computed column

Course 
    CourseId int pk
    CourseName varchar (30)
    Sequence int unique

MealCourse 
    MealCourseId int pk 
    MealId int fk to Meal
    CourseId int fk to Course
-- SM Sequence should be a unique column in course table. The sequence of the course will always be the same. 
-- SM No need for this column.
        unique MealId & CourseId

-- SM You're including the right columns in here. Just rename the table.
MealCourseRecipe 
    MealCourseRecipeId int pk
    MealCourseId int fk to MealCourse
    RecipeId int fk to Recipe
-- SM This should be a bit column. And name it question sounding it should make sense a true/false value.
    MainDish bit 

Cookbook 
    CookbookId int pk
    UserId int fk to Users
    CookbookName varchar (20) unique
    Price decimal
-- SM Computed columns should be at the bottom.
    DateCreated
    CookbookActive bit
-- SM FKs should be at the top.
CookbookPicture computed column
    

CookbookRecipe 
    CookbookRecipeId int pk
    CookbookId int fk to Cookbook
    RecipeId int fk to Recipe
    Sequence int 

*/