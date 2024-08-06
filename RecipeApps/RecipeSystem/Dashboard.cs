
namespace RecipeSystem
{
    public class Dashboard
    {
        public static DataTable GetDashboard()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("DashboardGet");
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
