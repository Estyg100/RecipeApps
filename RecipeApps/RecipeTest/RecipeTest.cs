using System.Configuration;
using System.Data;

namespace RecipeTest
{
    public class Tests
    {

        //string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
        string testconnstring = ConfigurationManager.ConnectionStrings["unittestconn"].ConnectionString;

        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString(testconnstring, true);
        }

        private DataTable GetDataTable(string sql)
        {
            DataTable dt = new();
            //DBManager.SetConnectionString(testconnstring);
            dt = SQLUtility.GetDataTable(sql);
            //DBManager.SetConnectionString(connstring);
            return dt;
        }

        private int GetFirstColumnFirstRowValueAsInt(string sql)
        {
            int n = new();
            //DBManager.SetConnectionString(testconnstring);
            n = SQLUtility.GetFirstColumnFirstRowValue(sql);
            //DBManager.SetConnectionString(connstring);
            return n;
        }

        private string GetFirstColumnFirstRowValueAsString(string sql)
        {
            string s = "";
            //DBManager.SetConnectionString(testconnstring);
            DataTable dt = SQLUtility.GetDataTable(sql);
            if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                if (dt.Rows[0][0] != DBNull.Value)
                {
                    s = dt.Rows[0][0].ToString();
                }
            }
            //DBManager.SetConnectionString(connstring);
            return s;
        }

        [Test]
        public void InsertNewRecipe()
        {
            DataTable dt = GetDataTable("select * from Recipe where RecipeId = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int usersid = GetFirstColumnFirstRowValueAsInt("select top 1 UsersId from Users");
            Assume.That(usersid > 0, "Can't run test, no users in DB");
            int cuisineid = GetFirstColumnFirstRowValueAsInt("select top 1 CuisineId from Cuisine");
            Assume.That(cuisineid > 0, "Can't run test, no cuisines in DB");
            string recipename = "Hello" + DateTime.Now;
            int calories = 100;
            string datedraft = "1800-01-01 12:00:00 AM";
            TestContext.WriteLine("insert recipe with UsersId = " + usersid + Environment.NewLine + "RecipeName = " + recipename + Environment.NewLine + "CuisineId = " + cuisineid + Environment.NewLine + "CaloriesPerServing = " + calories + Environment.NewLine + "DateDraft = " + datedraft);
            r["UsersId"] = usersid;
            r["RecipeName"] = recipename;
            r["CuisineId"] = cuisineid;
            r["CaloriesPerServing"] = calories;
            r["DateDraft"] = datedraft;
            HeartyHearthGeneral.Save(dt, "Recipe");
            int newid = GetFirstColumnFirstRowValueAsInt("select * from Recipe where RecipeName = " + "'" + recipename + "'");
            int pkid = 0;
            if (r["RecipeId"] != DBNull.Value)
            {
                pkid = (int)r["RecipeId"];
            }
            Assert.IsTrue(newid > 0, "Recipe with RecipeName: " + recipename + " is not found in DB");
            Assert.IsTrue(pkid > 0, "Primary key not updated in data table");
            TestContext.WriteLine("Recipe with RecipeName: " + recipename + " is found in DB with pk value = " + newid);
            TestContext.WriteLine("new primary key = " + pkid);
        }

        [Test]
        public void ChangeExistingRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            DataTable dtRecipe = GetDataTable("select * from Recipe r join Users u on u.UsersId = r.UsersId join Cuisine c on c.CuisineId = r.CuisineId where RecipeId = " + recipeid.ToString());
            int userid = (int)dtRecipe.Rows[0]["UsersId"];
            string recipename = dtRecipe.Rows[0]["RecipeName"].ToString();
            int cuisineid = (int)dtRecipe.Rows[0]["CuisineId"];
            int calories = (int)dtRecipe.Rows[0]["CaloriesPerServing"];
            string datedraft = dtRecipe.Rows[0]["DateDraft"].ToString();
            TestContext.WriteLine("Info for recipe with RecipeId " + recipeid + " is: " + Environment.NewLine + "UserId = " + userid + Environment.NewLine + "RecipeName = " + recipename + Environment.NewLine + "CuisineId = " + cuisineid + Environment.NewLine + "CaloriesPerServing = " + calories + Environment.NewLine + "DateDraft = " + datedraft);
            userid = GetFirstColumnFirstRowValueAsInt("select top 1 UsersId from Users where UsersId <> " + userid);
            int recipenamelength = recipename.Length;
            if (recipenamelength >= 25)
            {
                recipenamelength = 25;
            }
            recipename = recipename.Substring(0, recipenamelength) + " - m";
            cuisineid = GetFirstColumnFirstRowValueAsInt("select top 1 CuisineId from Cuisine where CuisineId <> " + cuisineid);
            calories = calories + 1;
            datedraft = "1800-01-01 12:00:00 AM";
            TestContext.WriteLine(Environment.NewLine + "Change UsersId to " + userid + Environment.NewLine + "RecipeName to " + recipename + Environment.NewLine + "CuisineId to " + cuisineid + Environment.NewLine + "CaloriesPerServing to " + calories + Environment.NewLine + "DateDraft to " + datedraft);
            DataTable dt = HeartyHearthGeneral.Load(recipeid, "Recipe");
            dt.Rows[0]["UsersId"] = userid;
            dt.Rows[0]["RecipeName"] = recipename;
            dt.Rows[0]["CuisineId"] = cuisineid;
            dt.Rows[0]["CaloriesPerServing"] = calories;
            dt.Rows[0]["DateDraft"] = datedraft;
            HeartyHearthGeneral.Save(dt, "Recipe");
            DataTable newdtRecipe = GetDataTable("select * from Recipe r join Users u on u.UsersId = r.UsersId join Cuisine c on c.CuisineId = r.CuisineId where RecipeId = " + recipeid.ToString());
            int newuserid = (int)newdtRecipe.Rows[0]["UsersId"];
            string newrecipename = newdtRecipe.Rows[0]["RecipeName"].ToString();
            int newcuisineid = (int)newdtRecipe.Rows[0]["CuisineId"];
            int newcalories = (int)newdtRecipe.Rows[0]["CaloriesPerServing"];
            string newdatedraft = newdtRecipe.Rows[0]["DateDraft"].ToString();
            Assert.IsTrue(newuserid == userid && newrecipename == recipename && newcuisineid == cuisineid && newcalories == calories && newdatedraft == datedraft, "Info for recipe with RecipeId " + recipeid + " is: " + Environment.NewLine + "UserId = " + userid + Environment.NewLine + "RecipeName = " + recipename + Environment.NewLine + "CuisineId = " + cuisineid + Environment.NewLine + "CaloriesPerServing = " + calories + Environment.NewLine + "DateDraft = " + datedraft);
            TestContext.WriteLine("Info for recipe with RecipeId " + recipeid + " is: " + Environment.NewLine + "UserId = " + newuserid + Environment.NewLine + "RecipeName = " + newrecipename + Environment.NewLine + "CuisineId = " + newcuisineid + Environment.NewLine + "CaloriesPerServing = " + newcalories + Environment.NewLine + "DateDraft = " + newdatedraft);
        }

        [Test]
        public void ChangeExistingRecipeInvalidCaloriesPerServing()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            DataTable dtRecipe = GetDataTable("select * from Recipe r join Users u on u.UsersId = r.UsersId join Cuisine c on c.CuisineId = r.CuisineId where RecipeId = " + recipeid.ToString());
            int userid = (int)dtRecipe.Rows[0]["UsersId"];
            string recipename = dtRecipe.Rows[0]["RecipeName"].ToString();
            int cuisineid = (int)dtRecipe.Rows[0]["CuisineId"];
            int calories = (int)dtRecipe.Rows[0]["CaloriesPerServing"];
            string datedraft = dtRecipe.Rows[0]["DateDraft"].ToString();
            TestContext.WriteLine("Info for recipe with RecipeId " + recipeid + " is: " + Environment.NewLine + "UserId = " + userid + Environment.NewLine + "RecipeName = " + recipename + Environment.NewLine + "CuisineId = " + cuisineid + Environment.NewLine + "CaloriesPerServing = " + calories + Environment.NewLine + "DateDraft = " + datedraft);
            userid = GetFirstColumnFirstRowValueAsInt("select top 1 UsersId from Users where UsersId <> " + userid);
            int recipenamelength = recipename.Length;
            if (recipenamelength >= 25)
            {
                recipenamelength = 25;
            }
            recipename = recipename.Substring(0, recipenamelength) + " - m";
            cuisineid = GetFirstColumnFirstRowValueAsInt("select top 1 CuisineId from Cuisine where CuisineId <> " + cuisineid);
            calories = -1;
            datedraft = "1800-01-01 12:00:00 AM";
            TestContext.WriteLine(Environment.NewLine + "Change UsersId to " + userid + Environment.NewLine + "RecipeName to " + recipename + Environment.NewLine + "CuisineId to " + cuisineid + Environment.NewLine + "CaloriesPerServing to " + calories + Environment.NewLine + "DateDraft to " + datedraft);
            DataTable dt = HeartyHearthGeneral.Load(recipeid, "Recipe");
            dt.Rows[0]["UsersId"] = userid;
            dt.Rows[0]["RecipeName"] = recipename;
            dt.Rows[0]["CuisineId"] = cuisineid;
            dt.Rows[0]["CaloriesPerServing"] = calories;
            dt.Rows[0]["DateDraft"] = datedraft;
            Exception ex = Assert.Throws<Exception>(()=> HeartyHearthGeneral.Save(dt, "Recipe"));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void ChangeExistingRecipeDuplicateValue()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            DataTable dtRecipe = GetDataTable("select * from Recipe r join Users u on u.UsersId = r.UsersId join Cuisine c on c.CuisineId = r.CuisineId where RecipeId = " + recipeid.ToString());
            int userid = (int)dtRecipe.Rows[0]["UsersId"];
            string recipename = dtRecipe.Rows[0]["RecipeName"].ToString();
            int cuisineid = (int)dtRecipe.Rows[0]["CuisineId"];
            int calories = (int)dtRecipe.Rows[0]["CaloriesPerServing"];
            string datedraft = dtRecipe.Rows[0]["DateDraft"].ToString();
            TestContext.WriteLine("Info for recipe with RecipeId " + recipeid + " is: " + Environment.NewLine + "UserId = " + userid + Environment.NewLine + "RecipeName = " + recipename + Environment.NewLine + "CuisineId = " + cuisineid + Environment.NewLine + "CaloriesPerServing = " + calories + Environment.NewLine + "DateDraft = " + datedraft);
            userid = GetFirstColumnFirstRowValueAsInt("select top 1 UsersId from Users where UsersId <> " + userid);
            string otherrecipename = GetFirstColumnFirstRowValueAsString("select top 1 r.RecipeName from Recipe r where r.RecipeId<> " + recipeid);
            recipename = otherrecipename;
            cuisineid = GetFirstColumnFirstRowValueAsInt("select top 1 CuisineId from Cuisine where CuisineId <> " + cuisineid);
            calories = calories + 1;
            datedraft = "1800-01-01 12:00:00 AM";
            TestContext.WriteLine(Environment.NewLine + "Change UsersId to " + userid + Environment.NewLine + "RecipeName to " + recipename + Environment.NewLine + "CuisineId to " + cuisineid + Environment.NewLine + "CaloriesPerServing to " + calories + Environment.NewLine + "DateDraft to " + datedraft);
            DataTable dt = HeartyHearthGeneral.Load(recipeid, "Recipe");
            dt.Rows[0]["UsersId"] = userid;
            dt.Rows[0]["RecipeName"] = recipename;
            dt.Rows[0]["CuisineId"] = cuisineid;
            dt.Rows[0]["CaloriesPerServing"] = calories;
            dt.Rows[0]["DateDraft"] = datedraft;
            Exception ex = Assert.Throws<Exception>(() => HeartyHearthGeneral.Save(dt, "Recipe"));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeleteRecipe()
        {
            string sql = @"
            select top 1 r.RecipeId, r.RecipeName
            from Recipe r
            left join MealCourseRecipe mcr 
            on mcr.RecipeId = r.RecipeId
            left join CookbookRecipe cr
            on cr.RecipeId = r.RecipeId
            where  
            mcr.MealCourseRecipeId is null
            and cr.CookbookRecipeId is null
            and
            (
            r.Currentstatus = 'Draft' 
            or getdate() - r.DateArchived > 30
            )
            order by r.RecipeId
            ";
            DataTable dt = GetDataTable(sql);
            int recipeid = 0;
            string recipename = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["RecipeId"];
                recipename = dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes without ingrideients and cookbooks in DB that are either in draft or archived for over 30 days, can't run test");
            TestContext.WriteLine("Existing recipe without ingridients and cookbooks that is in draft or archived for over 30 days, with id = " + recipeid + " " + recipename);
            TestContext.WriteLine("Ensure that app can delete " + recipeid);
            HeartyHearthGeneral.Delete(dt, "Recipe");
            DataTable dtafterdelete = GetDataTable("select * from Recipe where RecipeId = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "Record with RecipeId " + recipeid + " exists in DB");
            TestContext.WriteLine("Record with RecipeId " + recipeid + " does not exist in DB");
        }

        [Test]
        public void DeleteRecipeThatIsPublishedOrArchivedForUnder30Days()
        {
            string sql = @"
            select top 1 r.RecipeId, r.RecipeName
            from Recipe r 
            where r.CurrentStatus = 'Published'
            or getdate() - r.DateArchived < 30
            ";
            DataTable dt = GetDataTable(sql);
            int recipeid = 0;
            string recipename = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["RecipeId"];
                recipename = dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes in DB are published or archived for under 30 days, can't run test");
            TestContext.WriteLine("Existing recipe published or archived for under 30 days, with id = " + recipeid + " " + recipename);
            TestContext.WriteLine("Ensure that app cannot delete " + recipeid);
            Exception ex = Assert.Throws<Exception>(() => HeartyHearthGeneral.Delete(dt, "Recipe"));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("Existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);
            DataTable dt = HeartyHearthGeneral.Load(recipeid, "Recipe");
            int loadedid = (int)dt.Rows[0]["RecipeId"];
            Assert.IsTrue(loadedid == recipeid, loadedid + " <> " + recipeid);
            TestContext.WriteLine("Loaded recipe (" + recipeid + ")" + recipeid);
        }

        [Test]
        public void LoadRecipes()
        {
            int num = GetFirstColumnFirstRowValueAsInt("select total = count(*) from Recipe");
            Assume.That(num > 0, "Can't run test, there are no recipes in DB.");
            TestContext.WriteLine(num + " recipes in DB.");
            TestContext.WriteLine("Ensure that recipe search returns  " + num + " rows");
            DataTable dt = HeartyHearthGeneral.GetList("Recipe");
            int results = dt.Rows.Count;
            Assert.IsTrue(results == num, "Results of recipe search does not match num of recipes, " + results + " is not equal to " + num);
            TestContext.WriteLine("Num of rows returned by recipe search is " + results);
        }


        [Test]
        public void GetListOfUsers()
        {
            int usercount = GetFirstColumnFirstRowValueAsInt("select total = count(*) from Users");
            Assume.That(usercount > 0, "No users in DB, can't test");
            TestContext.WriteLine("Number of Rows in DB = " + usercount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + usercount);
            DataTable dt = HeartyHearthGeneral.GetUserList();
            Assert.IsTrue(dt.Rows.Count == usercount, "num rows returned by app (" + dt.Rows.Count + ") <> " + usercount);
            TestContext.WriteLine("Number of Rows in Users returned by app =  " + dt.Rows.Count);
        }

        [Test]
        public void GetListOfCuisines()
        {
            int cuisinecount = GetFirstColumnFirstRowValueAsInt("select total = count(*) from Cuisine");
            Assume.That(cuisinecount > 0, "No cuisines in DB, can't test");
            TestContext.WriteLine("Number of Rows in DB = " + cuisinecount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + cuisinecount);
            DataTable dt = HeartyHearthGeneral.GetCuisineList();
            Assert.IsTrue(dt.Rows.Count == cuisinecount, "num rows returned by app (" + dt.Rows.Count + ") <> " + cuisinecount);
            TestContext.WriteLine("Number of Rows in Cuisine returned by app =  " + dt.Rows.Count);
        }

        private int GetExistingRecipeId()
        {
            return GetFirstColumnFirstRowValueAsInt("select top 1 RecipeId from Recipe");
        }

    }
}