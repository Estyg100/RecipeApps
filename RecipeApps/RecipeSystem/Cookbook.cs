namespace RecipeSystem
{
    public class Cookbook
    {
        public static int AutoCreateCookbook(int basedonid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("AutoCreateCookbook");
            SQLUtility.SetParamValue(cmd, "@BaseUsersId", basedonid);
            SQLUtility.ExecuteSQL(cmd);
            return (int)cmd.Parameters["@CookbookId"].Value;
        }
    }
}
