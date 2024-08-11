namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {
        
        private enum TableTypeEnum { Users, Cuisine, Ingredient, MeasurementType, Course}
        TableTypeEnum currenttabletype = TableTypeEnum.Users;
        DataTable dtlist = new();
        
        public frmDataMaintenance()
        {
            InitializeComponent();
            this.Shown += FrmDataMaintenance_Shown;
            btnSave.Click += BtnSave_Click;
        }

        private void FrmDataMaintenance_Shown(object? sender, EventArgs e)
        {
            BindData(currenttabletype);
            SetupRadiobuttons();
        }

        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetDataList(currenttabletype.ToString());
            gData.Columns.Clear();
            gData.DataSource = dtlist;
            WindowsFormsUtility.AddDeleteButtonToGrid(gData, "Delete");
            WindowsFormsUtility.FormatGridForEdit(gData, currenttabletype.ToString());
        }

        private void SetupRadiobuttons()
        {
            foreach (Control c in tblRadioButtons.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click;
                }
            }
            optUsers.Tag = TableTypeEnum.Users;
            optCuisines.Tag = TableTypeEnum.Cuisine;
            optIngredients.Tag = TableTypeEnum.Ingredient;
            optMeasurements.Tag = TableTypeEnum.MeasurementType;
            optCourses.Tag = TableTypeEnum.Course;
        }

        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenance.SaveDataList(dtlist, currenttabletype.ToString());
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return b;
        }

        private void C_Click(object? sender, EventArgs e)
        {
            if (sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

    }
}
