namespace RecipeWinForms
{
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            this.Activated += FrmMealList_Activated;
        }

        private void GetMealList()
        {
            try
            {
                DataTable dt = HeartyHearthGeneral.GetList("Meal");
                gMealList.DataSource = dt;
                WindowsFormsUtility.FormatGridForSearchResults(gMealList, "Meals");
                if (gMealList.Rows.Count > 0)
                {
                    gMealList.Focus();
                    gMealList.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void FrmMealList_Activated(object? sender, EventArgs e)
        {
            GetMealList();
        }
    }
}
