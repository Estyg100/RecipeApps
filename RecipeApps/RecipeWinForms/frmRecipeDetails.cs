namespace RecipeWinForms
{

    public partial class frmRecipeDetails : Form
    {
        DataTable dtRecipe = new();
        DataTable dtRecipeIngredient = new();
        DataTable dtRecipeSteps = new();
        BindingSource bindsource = new();
        int recipeid = 0;

        public frmRecipeDetails()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            this.FormClosing += FrmRecipeDetails_FormClosing;
            btnIngredientSave.Click += BtnIngredientSave_Click;
            btnStepsSave.Click += BtnStepsSave_Click;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            this.Shown += FrmRecipeDetails_Shown;
            this.Activated += FrmRecipeDetails_Activated;
        }

        private void FrmRecipeDetails_Activated(object? sender, EventArgs e)
        {
            LoadRecipeDetailsForm(recipeid);
        }

        public void LoadRecipeDetailsForm(int recipeval)
        {
            recipeid = recipeval;
            this.Tag = recipeid;
            dtRecipe = HeartyHearthGeneral.Load(recipeid, "Recipe");
            bindsource.DataSource = dtRecipe;
            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtUserName = HeartyHearthGeneral.GetUserList();
            DataTable dtCuisineName = HeartyHearthGeneral.GetCuisineList();
            WindowsFormsUtility.SetListBinding(lstUserName, dtUserName, dtRecipe, "Users");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetListBinding(lstCuisineName, dtCuisineName, dtRecipe, "Cuisine");
            WindowsFormsUtility.SetControlBinding(txtCaloriesPerServing, bindsource);
            WindowsFormsUtility.SetControlBinding(lblCurrentStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateDraft, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, bindsource);
            this.Text = GetRecipeDesc();
            SetButtonsEnabledBasedOnNewRecord();
        }

        private void LoadRecipeIngredients()
        {
            dtRecipeIngredient = ChildRecords.LoadByRecipeId(recipeid, "RecipeIngredient");
            gIngredients.Columns.Clear();
            gIngredients.DataSource = dtRecipeIngredient;
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("MeasurementType", true), "MeasurementType", "MeasurementTypeName");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Ingredient"), "Ingredient", "IngredientName");
            WindowsFormsUtility.FormatGridForEdit(gIngredients, "RecipeIngredient");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredients, "Delete");
        }

        private void LoadRecipeSteps()
        {
            dtRecipeSteps = ChildRecords.LoadByRecipeId(recipeid, "RecipeDirections");
            gSteps.Columns.Clear();
            gSteps.DataSource = dtRecipeSteps;
            WindowsFormsUtility.FormatGridForEdit(gSteps, "RecipeDirections");
            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, "Delete");
        }

        private void LoadRecipeChildRecord()
        {
            LoadRecipeIngredients();
            LoadRecipeSteps();
        }

        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtRecipe, "RecipeName");
            }
            return value;
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnIngredientSave.Enabled = b;
            btnStepsSave.Enabled = b;
            btnChangeStatus.Enabled = b;
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                HeartyHearthGeneral.Save(dtRecipe, "Recipe");
                b = true;
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
                LoadRecipeDetailsForm(recipeid);
                this.Tag = recipeid;
                this.Text = GetRecipeDesc();
                SetButtonsEnabledBasedOnNewRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to permenantly delete this recipe with all its related records?!", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                HeartyHearthGeneral.Delete(dtRecipe, "Recipe");
                this.Close();
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

        private void SaveRecipeIngredients()
        {
            try
            {
                ChildRecords.SaveTable(dtRecipeIngredient, recipeid, "RecipeIngredient", "Recipe");
                LoadRecipeIngredients();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void SaveRecipeSteps()
        {
            try
            {
                ChildRecords.SaveTable(dtRecipeSteps, recipeid, "RecipeDirections", "Recipe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteRecipeIngredients(int rowIndex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gIngredients, rowIndex, "RecipeIngredientId");
            if (id > 0)
            {
                try
                {
                    ChildRecords.Delete(id, "RecipeIngredient");
                    LoadRecipeIngredients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gIngredients.Rows.Count)
            {
                gIngredients.Rows.RemoveAt(rowIndex);
            }
        }

        private void DeleteRecipeSteps(int rowIndex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gSteps, rowIndex, "RecipeDirectionsId");
            if (id > 0)
            {
                try
                {
                    ChildRecords.Delete(id, "RecipeDirections");
                    LoadRecipeSteps();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gSteps.Rows.Count)
            {
                gSteps.Rows.RemoveAt(rowIndex);
            }
        }

        public void ShowRecipeChangeStatusForm(int recipeid)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeRecipeStatus), recipeid);
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnIngredientSave_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredients();
        }

        private void BtnStepsSave_Click(object? sender, EventArgs e)
        {
            SaveRecipeSteps();
        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var sendergrid = (DataGridView)sender;
            if (sendergrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DeleteRecipeIngredients(e.RowIndex);
            }
        }

        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var sendergrid = (DataGridView)sender;
            if (sendergrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DeleteRecipeSteps(e.RowIndex);
            }
        }

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            ShowRecipeChangeStatusForm(recipeid);
        }

        private void FrmRecipeDetails_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtRecipe))
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

        private void FrmRecipeDetails_Shown(object? sender, EventArgs e)
        {
            LoadRecipeChildRecord();
        }

        private void btnIngredientSave_Click_1(object sender, EventArgs e)
        {

        }
    }
}
