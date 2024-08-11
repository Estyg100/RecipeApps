namespace RecipeWinForms
{
    public partial class frmCloneRecipe : Form
    {

        public frmCloneRecipe()
        {
            InitializeComponent();
            this.Shown += FrmCloneRecipe_Shown;
            btnClone.Click += BtnClone_Click;
        }

        private void BindData()
        {
            WindowsFormsUtility.SetListBinding(lstRecipeName, DataMaintenance.GetDataList("Recipe"), null, "Recipe");
        }

        private void CloneRecipe()
        {
            int basedonid = WindowsFormsUtility.GetIdFromComboBox(lstRecipeName);
            Cursor = Cursors.WaitCursor;
            try
            {
                int recipeid = Recipe.CloneRecipe(basedonid);
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeDetails), recipeid);
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

        private void FrmCloneRecipe_Shown(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            CloneRecipe();
        }

    }
}
