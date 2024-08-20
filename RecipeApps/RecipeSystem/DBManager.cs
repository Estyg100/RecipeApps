namespace RecipeSystem
{
    public class DBManager
    {
        public static void SetConnectionString(string connectionstring, bool tryopen = false, string userid = "", string password = "")
        {
            SQLUtility.SetConnectionString(connectionstring, tryopen, userid, password);
        }
    }
}
