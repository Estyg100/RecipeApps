namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {

        private enum TableTypeEnum { Users, Cuisine, Ingredient, MeasurementType, Course }
        TableTypeEnum currenttabletype = TableTypeEnum.Users;
        DataTable dtlist = new();

        public frmDataMaintenance()
        {
            InitializeComponent();
            this.Shown += FrmDataMaintenance_Shown;
            btnSave.Click += BtnSave_Click;
            gData.CellContentClick += GData_CellContentClick;
            this.FormClosing += FrmDataMaintenance_FormClosing;
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

        private void Delete(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, currenttabletype.ToString() + "Id");
            if (id != 0)
            {
                try
                {
                    DataMaintenance.DeleteRow(currenttabletype.ToString(), id);
                    BindData(currenttabletype);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id == 0 && rowindex < gData.Rows.Count)
            {
                gData.Rows.Remove(gData.Rows[rowindex]);
            }
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

        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var sendergrid = (DataGridView)sender;
            if (sendergrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && sendergrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string message = "";
                switch (currenttabletype)
                {
                    case TableTypeEnum.Users:
                        message = "Are you sure you want to delete this User and all related recipes, meals, and cookbooks?!";
                        break;
                    case TableTypeEnum.Course:
                        message = "Are you sure you want to delete this Course and all related meal course records?";
                        break;
                    case TableTypeEnum.Cuisine:
                    case TableTypeEnum.Ingredient:
                    case TableTypeEnum.MeasurementType:
                        message = "Are you sure you want to delete this " + currenttabletype.ToString() + " and all its recipe records?";
                        break;
                }
                var response = MessageBox.Show(message, Application.ProductName, MessageBoxButtons.YesNo);
                if (response == DialogResult.No)
                {
                    return;
                }
                Application.UseWaitCursor = true;
                try
                {
                    Delete(e.RowIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
                finally
                {
                    Application.UseWaitCursor = false;
                }
            }
        }

        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (SQLUtility.TableHasChanges(dtlist))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing ?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }

    }
}
