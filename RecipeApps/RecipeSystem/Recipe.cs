namespace RecipeSystem
{
    public class Recipe
    {
        public static int CloneRecipe(int basedonid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeClone");
            SQLUtility.SetParamValue(cmd, "@BaseRecipeId", basedonid);
            SQLUtility.ExecuteSQL(cmd);
            return (int)cmd.Parameters["@RecipeId"].Value;
        }
    }
}
