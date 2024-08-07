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
        }

        public void LoadForm(int recipeval)
        {
            recipeid = recipeval;
            this.Tag = recipeid;
            dtRecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtRecipe;
            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtUserName = Recipe.GetUserList();
            DataTable dtCuisineName = Recipe.GetCuisineList();
            WindowsFormsUtility.SetListBinding(lstUserName, dtUserName, dtRecipe, "Users");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetListBinding(lstCuisineName, dtCuisineName, dtRecipe, "Cuisine");
            WindowsFormsUtility.SetControlBinding(txtCaloriesPerServing, bindsource);
            WindowsFormsUtility.SetControlBinding(lblCurrentStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateDraft, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, bindsource);
            this.Text = GetRecipeDesc();
            LoadRecipeChildRecord();
            SetButtonsEnabledBasedOnNewRecord();
        }

        private void LoadRecipeIngredients()
        {
            dtRecipeIngredient = RecipeChildRecords.LoadByRecipeId(recipeid, "RecipeIngredient");
            gIngredients.Columns.Clear();
            gIngredients.DataSource = dtRecipeIngredient;
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("MeasurementType"), "MeasurementType", "MeasurementTypeName");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Ingredient"), "Ingredient", "IngredientName");
            WindowsFormsUtility.FormatGridForEdit(gIngredients, "RecipeIngredient");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredients, "Delete");
        }

        private void LoadRecipeSteps()
        {
            dtRecipeSteps = RecipeChildRecords.LoadByRecipeId(recipeid, "RecipeDirections");
            gSteps.Columns.Clear();
            gSteps.DataSource = dtRecipeSteps;
            WindowsFormsUtility.FormatGridForEdit(gSteps, "RecipeDirections");
            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, "Delete");
        }

        private void LoadRecipeChildRecord()
        {
            LoadRecipeIngredients();
            LoadRecipeSteps();
            gIngredients.AutoGenerateColumns = false;
            gSteps.AutoGenerateColumns = false;
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
        }
        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                if (lblDateDraft.Text == "" && recipeid == 0)
                {
                    lblDateDraft.Text = DateTime.Now.ToString("MMM d yyyy");
                    lblCurrentStatus.Text = "Draft";
                }
                Recipe.Save(dtRecipe);
                b = true;
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
                this.Tag = recipeid;
                this.Text = GetRecipeDesc();
                SetButtonsEnabledBasedOnNewRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hearty Hearth");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to permenantly delete this recipe with all its related records?!", "Hearty Hearth", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtRecipe);
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
                RecipeChildRecords.SaveTable(dtRecipeIngredient, recipeid, "RecipeIngredient");
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
                RecipeChildRecords.SaveTable(dtRecipeSteps, recipeid, "RecipeDirections");
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
                    RecipeChildRecords.Delete(id, "RecipeIngredient");
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
                    RecipeChildRecords.Delete(id, "RecipeDirections");
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
            DeleteRecipeIngredients(e.RowIndex);
        }

        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeSteps(e.RowIndex);
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
    }
}
