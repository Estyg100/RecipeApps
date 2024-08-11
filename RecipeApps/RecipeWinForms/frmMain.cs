namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Shown += FrmMain_Shown;
            mnuDashboard.Click += MnuDashboard_Click;
            mnuRecipeList.Click += MnuRecipeList_Click;
            mnuMealList.Click += MnuMealList_Click;
            mnuCookbookList.Click += MnuCookbookList_Click;
            mnuNewRecipe.Click += MnuNewRecipe_Click;
            mnuNewCookbook.Click += MnuNewCookbook_Click;
            mnuEditData.Click += MnuDataMaintenance_Click;
            mnuCloneRecipe.Click += MnuCloneRecipe_Click;
            mnuAutoCreateCookbook.Click += MnuAutoCreateCookbook_Click;
            mnuWindowsTile.Click += MnuWindowsTile_Click;
            mnuWindowsCascade.Click += MnuWindowsCascade_Click;
        }

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype, pkvalue);
            if (b == false)
            {
                Form? frm = null;
                if (frmtype == typeof(frmRecipeDetails))
                {
                    frmRecipeDetails f = new();
                    frm = f;
                    f.LoadRecipeDetailsForm(pkvalue);
                }
                if (frmtype == typeof(frmChangeRecipeStatus))
                {
                    frmChangeRecipeStatus f = new();
                    frm = f;
                    f.LoadChangeRecipeStatusForm(pkvalue);
                }
                if (frmtype == typeof(frmCookbookDetails))
                {
                    frmCookbookDetails f = new();
                    frm = f;
                    f.LoadCookbookDetailsForm(pkvalue);
                }
                if (frmtype == typeof(frmRecipeList))
                {
                    frmRecipeList f = new();
                    frm = f;
                }
                else if (frmtype == typeof(frmMealList))
                {
                    frmMealList f = new();
                    frm = f;
                }
                else if (frmtype == typeof(frmCookbookList))
                {
                    frmCookbookList f = new();
                    frm = f;
                }
                else if (frmtype == typeof(frmDataMaintenance))
                {
                    frmDataMaintenance f = new();
                    frm = f;
                }
                else if (frmtype == typeof(frmDashboard))
                {
                    frmDashboard f = new();
                    frm = f;
                }
                else if (frmtype == typeof(frmCloneRecipe))
                {
                    frmCloneRecipe f = new();
                    frm = f;
                }
                else if (frmtype == typeof(frmAutoCreateCookbook))
                {
                    frmAutoCreateCookbook f = new();
                    frm = f;
                }
                if (frm != null)
                {
                    frm.MdiParent = this;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.FormClosed += Frm_FormClosed;
                    frm.TextChanged += Frm_TextChanged;
                    frm.Show();
                }
                WindowsFormsUtility.SetUpNav(tsMain);
            }
        }

        private void Frm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormsUtility.SetUpNav(tsMain);
        }

        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormsUtility.SetUpNav(tsMain);
        }

        private void MnuCookbookList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }

        private void MnuMealList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealList));
        }

        private void MnuRecipeList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }

        private void MnuDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

        private void MnuNewRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeDetails));
        }

        private void MnuNewCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookDetails));
        }

        private void MnuDataMaintenance_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
        }

        private void MnuCloneRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCloneRecipe));
        }

        private void MnuAutoCreateCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmAutoCreateCookbook));
        }

        private void MnuWindowsCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuWindowsTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
