namespace RecipeSystem
{
    public class HeartyHearthGeneral
    {
        public static DataTable GetList(string subject)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand(subject + "ListGet");
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid, string subject)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand(subject + "Get");
            cmd.Parameters["@" + subject + "Id"].Value = recipeid;
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

        public static void Save(DataTable dtRecipe, string subject)
        {
            if (dtRecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call " +  subject  + "save method because there are no rows in the table.");
            }
            DataRow r = dtRecipe.Rows[0];
            SQLUtility.SaveDataRow(r, subject + "Update");
            Debug.Print("-----------------");
        }

        public static void Delete(DataTable dtRecipe, string subject)
        {
            int id = (int)dtRecipe.Rows[0][subject + "Id"];
            SqlCommand cmd = SQLUtility.GetSqlCommand(subject + "Delete");
            SQLUtility.SetParamValue(cmd, "@" + subject + "Id", id);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
