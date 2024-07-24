using System.Data;
using System.Diagnostics;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipe(string recipename)
        {
            string sql = "Select RecipeId, RecipeName from Recipe r where r.RecipeName like '%" + recipename + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            string sql = "select r.*, u.UserName, c.CuisineName from Recipe r join Cuisine c on c.CuisineId = r.CuisineId  join users u on u.UsersId = r.UsersId where r.RecipeId = " + recipeid.ToString();
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable GetUserList()
        {
            DataTable dtUserName = SQLUtility.GetDataTable("select UsersId, UserName from users");
            return dtUserName;
        }

        public static DataTable GetCuisineList()
        {
            DataTable dtCuisineName = SQLUtility.GetDataTable("select CuisineId, CuisineName from cuisine");
            return dtCuisineName;
        }

        public static void Save(DataTable dtRecipe)
        {
            SQLUtility.DEbugPrintDataTable(dtRecipe);
            DataRow r = dtRecipe.Rows[0];
            string sql = "";
            int id = (int)r["RecipeId"];
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine,
                $"update Recipe set",
                $"UsersId = '{r["UsersId"]}',",
                $"CuisineId = '{r["CuisineId"]}',",
                $"RecipeName = '{r["RecipeName"]}',",
                $"CaloriesPerServing = {r["CaloriesPerServing"]},",
                $"DateDraft = '{r["DateDraft"]}'",
                $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert Recipe (UsersId, RecipeName, CuisineId, CaloriesPerServing, DateDraft) ";
                sql += $"select '{r["UsersId"]}', '{r["RecipeName"]}', '{r["CuisineId"]}', {r["CaloriesPerServing"]}, '{r["DateDraft"]}'";
            }
            Debug.Print("-----------------");
            SQLUtility.ExecuteSQL(sql);
        }

        public static void Delete(DataTable dtRecipe)
        {
            int id = (int)dtRecipe.Rows[0]["RecipeId"];
            string sql = "delete Recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}
