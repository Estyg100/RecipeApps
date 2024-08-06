namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Activated += FrmDashboard_Activated;
            btnRecipeList.Click += BtnRecipeList_Click;
            btnMealList.Click += BtnMealList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            DataTable dt = Dashboard.GetDashboard();
            gData.DataSource = dt;
            gData.ClearSelection();
        }

        private void ShowForm(Type frmtype)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(frmtype);
            }
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmRecipeList));
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmMealList));
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmCookbookList));
        }

    }
}
