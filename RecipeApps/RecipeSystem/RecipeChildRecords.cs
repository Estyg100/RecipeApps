namespace RecipeSystem
{
    public class RecipeChildRecords
    {
        public static DataTable LoadByRecipeId(int recipeid, string sprocprefix)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand(sprocprefix + "Get");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void SaveTable(DataTable dt, int recipeid, string sprocprefix)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["RecipeId"] = recipeid;
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
