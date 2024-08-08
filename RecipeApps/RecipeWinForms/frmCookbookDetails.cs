using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmCookbookDetails : Form
    {

        int cookbookid = 0;
        DataTable dtCookbook = new();
        BindingSource bindsource = new();
        
        public frmCookbookDetails()
        {
            InitializeComponent();
        }

        public void LoadCookbookDetailsForm(int recipeval)
        {
            cookbookid = recipeval;
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

    }
}
