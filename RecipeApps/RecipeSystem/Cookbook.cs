using System.Diagnostics;

namespace RecipeSystem
{
    public class Cookbook
    {
        public static DataTable GetCookbookList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookListGet");
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int cookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookGet");
            cmd.Parameters["@CookbookId"].Value = cookbookid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtCookbook)
        {
            if (dtCookbook.Rows.Count == 0)
            {
                throw new Exception("Cannot call cookbook save method because there are no rows in the table.");
            }
            DataRow r = dtCookbook.Rows[0];
            SQLUtility.SaveDataRow(r, "CookbookUpdate");
            Debug.Print("-----------------");
        }

        public static void Delete(DataTable dtCookbook)
        {
            int id = (int)dtCookbook.Rows[0]["CookbookId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookDelete");
            SQLUtility.SetParamValue(cmd, "@CookbookId", id);
            SQLUtility.ExecuteSQL(cmd);
        }

    }
}
