
namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipes.CellDoubleClick += GRecipes_CellDoubleClick;
            btnNew.Click += BtnNew_Click;
            WindowsFormsUtility.FormatGridForSearchResults(gRecipes, "Recipes");
        }

        private void SearchForPresident(string recipename)
        {
            DataTable dt = Recipe.SearchRecipe(recipename);
            gRecipes.DataSource = dt;
            gRecipes.Columns["RecipeId"].Visible = false;
            gRecipes.AutoResizeColumns();
        }

        private void ShowRecipeForm(int rowindex)
        {
            int recipeid = 0;
            if (rowindex > -1)
            {
                recipeid = (int)gRecipes.Rows[rowindex].Cells["RecipeId"].Value;
            }
            frmRecipeDetails frm = new frmRecipeDetails();
            frm.ShowForm(recipeid);
        }

        private void GRecipes_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForPresident(txtReipeName.Text);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }

    }
}
