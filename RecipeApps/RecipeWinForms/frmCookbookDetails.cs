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
                dtCookbook.Rows[0]["CookbookActive"] = 0;
            }
            DataTable dtUserName = Recipe.GetUserList();
            WindowsFormsUtility.SetListBinding(lstUserName, dtUserName, dtCookbook, "Users");
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateCreated, bindsource);
            WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(ckActive, bindsource);
            ckActive.Checked = (bool)dtCookbook.Rows[0]["CookbookActive"];
            this.Text = GetCookbookName();
            SetButtonsEnabledBasedOnNewRecord();
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

        private string GetCookbookName()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtCookbook, "CookbookId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtCookbook, "CookbookName");
            }
            return value;
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnCookbookRecipeSave.Enabled = b;
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
