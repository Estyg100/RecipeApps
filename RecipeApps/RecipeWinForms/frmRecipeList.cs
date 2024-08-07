namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            gRecipes.CellDoubleClick += GRecipes_CellDoubleClick;
            gRecipes.KeyDown += GRecipes_KeyDown;
            btnNewRecipe.Click += BtnNewRecipe_Click;
            this.Activated += FrmRecipeList_Activated;
        }

        private void GetRecipeList()
        {
            try
            {
                DataTable dt = Recipe.GetRecipeList();
                gRecipes.DataSource = dt;
                WindowsFormsUtility.FormatGridForSearchResults(gRecipes, "Recipes");
                if (gRecipes.Rows.Count > 0)
                {
                    gRecipes.Focus();
                    gRecipes.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            GetRecipeList();
        }

        private void ShowRecipeForm(int rowindex)
        {
            int recipeid = 0;
            if (rowindex > -1)
            {
                recipeid = WindowsFormsUtility.GetIdFromGrid(gRecipes, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeDetails), recipeid);
            }
        }

        private void GRecipes_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void GRecipes_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gRecipes.SelectedRows.Count > 0)
            {
                ShowRecipeForm(gRecipes.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }

    }
}
