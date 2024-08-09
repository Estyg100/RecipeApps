using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            gCookbookList.CellDoubleClick += GCookbookList_CellDoubleClick;
            gCookbookList.KeyDown += GCookbookList_KeyDown;
            btnNewCookbook.Click += BtnNewCookbook_Click;
            this.Activated += FrmCookbookList_Activated;
        }

        private void GetCookbookList()
        {
            try
            {
                DataTable dt = HeartyHearthGeneral.GetList("Cookbook");
                gCookbookList.DataSource = dt;
                WindowsFormsUtility.FormatGridForSearchResults(gCookbookList, "Cookbooks");
                if (gCookbookList.Rows.Count > 0)
                {
                    gCookbookList.Focus();
                    gCookbookList.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void ShowCookbookForm(int rowindex)
        {
            int cookbookid = 0;
            if (rowindex > -1)
            {
                cookbookid = WindowsFormsUtility.GetIdFromGrid(gCookbookList, rowindex, "CookbookId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookDetails), cookbookid);
            }
        }

        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            GetCookbookList();
        }

        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(-1);
        }

        private void GCookbookList_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gCookbookList.SelectedRows.Count > 0)
            {
                ShowCookbookForm(gCookbookList.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void GCookbookList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookForm(e.RowIndex);
        }
    }
}
