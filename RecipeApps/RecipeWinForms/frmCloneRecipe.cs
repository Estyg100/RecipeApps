namespace RecipeWinForms
{
    public partial class frmCloneRecipe : Form
    {
        DataTable dtRecipe = new();
        BindingSource bindsource = new();

        public frmCloneRecipe()
        {
            InitializeComponent();
            this.Shown += FrmCloneRecipe_Shown;
        }

        public void LoadCloneRecipeForm()
        {
            dtRecipe = DataMaintenance.GetDataList("Recipe");
            bindsource.DataSource = dtRecipe;
            WindowsFormsUtility.SetListBinding(lstRecipeName, dtRecipe, dtRecipe, "Recipe");
        }

        private void FrmCloneRecipe_Shown(object? sender, EventArgs e)
        {
            LoadCloneRecipeForm();
        }
    }
}
