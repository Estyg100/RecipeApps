using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmCookbookDetails : Form
    {

        int cookbookid = 0;
        DataTable dtCookbook = new();
        BindingSource bindsource = new();
        DataTable dtCookbookRecipe = new();
        
        public frmCookbookDetails()
        {
            InitializeComponent();
            this.Activated += FrmCookbookDetails_Activated;
            this.Shown += FrmCookbookDetails_Shown;
        }

        public void LoadCookbookDetailsForm(int cookval)
        {
            cookbookid = cookval;
            this.Tag = cookbookid;
            dtCookbook = Cookbook.Load(cookbookid);
            bindsource.DataSource = dtCookbook;
            if (cookbookid == 0)
            {
                dtCookbook.Rows.Add();
            }
            DataTable dtUserName = Recipe.GetUserList();
            WindowsFormsUtility.SetListBinding(lstUserName, dtUserName, dtCookbook, "Users");
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateCreated, bindsource);
            WindowsFormsUtility.SetControlBinding(ckActive, bindsource);
            WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
            //this.Text = GetRecipeDesc();
            //SetButtonsEnabledBasedOnNewRecord();
        }

        private void LoadCookbookRecipes()
        {
            dtCookbookRecipe = CookbookRecipe.LoadByCookbookId(cookbookid, "CookbookRecipe");
            gCookbookRecipe.Columns.Clear();
            gCookbookRecipe.DataSource = dtCookbookRecipe;
            WindowsFormsUtility.AddComboBoxToGrid(gCookbookRecipe, DataMaintenance.GetDataList("Recipe"), "Recipe", "RecipeName");
            WindowsFormsUtility.FormatGridForEdit(gCookbookRecipe, "CookbookRecipe");
            WindowsFormsUtility.AddDeleteButtonToGrid(gCookbookRecipe, "Delete");
        }

        private void FrmCookbookDetails_Activated(object? sender, EventArgs e)
        {
            LoadCookbookDetailsForm(cookbookid);
        }

        private void FrmCookbookDetails_Shown(object? sender, EventArgs e)
        {
            LoadCookbookRecipes();
        }

    }
}
