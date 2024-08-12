namespace RecipeWinForms
{
    public partial class frmAutoCreateCookbook : Form
    {
        public frmAutoCreateCookbook()
        {
            InitializeComponent();
            this.Shown += FrmAutoCreateCookbook_Shown;
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
        }

        private void BindData()
        {
            WindowsFormsUtility.SetListBinding(lstUserName, DataMaintenance.GetDataList("Users"), null, "Users", true);
        }

        private void AutoCreateCookbook()
        {
            int basedonid = WindowsFormsUtility.GetIdFromComboBox(lstUserName);
            Cursor = Cursors.WaitCursor;
            try
            {
                int cookbookid = Cookbook.AutoCreateCookbook(basedonid);
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookDetails), cookbookid);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void FrmAutoCreateCookbook_Shown(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            AutoCreateCookbook();
        }

    }
}
