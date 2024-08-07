namespace RecipeSystem
{
    public class RecipeChildRecords
    {
        public static DataTable LoadByRecipeId(int recipeid, string paramnameprefix)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand(paramnameprefix + "Get");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void SaveTable(DataTable dt, int recipeid, string paramprefix)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["RecipeId"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, paramprefix + "Update");
        }

    }
}
