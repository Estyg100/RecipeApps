using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipe(string recipename)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipename;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetUserList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("UsersGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetCuisineList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }


        public static void Save(DataTable dtRecipe)
        {
            //SQLUtility.DEbugPrintDataTable(dtRecipe);
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
