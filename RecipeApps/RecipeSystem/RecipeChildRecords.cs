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
    }
}
