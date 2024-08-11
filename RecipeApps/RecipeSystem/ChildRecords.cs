namespace RecipeSystem
{
    public class ChildRecords
    {
        public static DataTable LoadByRecipeId(int recipeid, string sprocprefix)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand(sprocprefix + "Get");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable LoadByCookbookId(int cookbookid, string sprocprefix)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand(sprocprefix + "Get");
            cmd.Parameters["@CookbookId"].Value = cookbookid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void SaveTable(DataTable dt, int id, string sprocprefix, string subject)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r[subject + "Id"] = id;
            }
            SQLUtility.SaveDataTable(dt, sprocprefix + "Update");
        }

        public static void Delete(int id, string sprocprefix)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(sprocprefix + "Delete");
            cmd.Parameters["@" + sprocprefix + "Id"].Value = id;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
