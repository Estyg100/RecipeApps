using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmCookbookDetails : Form
    {

        int cookbookid = 0;
        DataTable dtCookbook = new();
        BindingSource bindsource = new();
        DataTable dtCookbookRecipe = new();

        public frmCookbookDetails()
        {
            InitializeComponent();
            this.Activated += FrmCookbookDetails_Activated;
            this.Shown += FrmCookbookDetails_Shown;
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnCookbookRecipeSave.Click += BtnCookbookRecipeSave_Click;
            gCookbookRecipe.CellContentClick += GCookbookRecipe_CellContentClick;
            gCookbookRecipe.DataError += GCookbookRecipe_DataError;
            txtPrice.Validating += TxtPrice_Validating;
        }

        public void LoadCookbookDetailsForm(int cookval)
        {
            cookbookid = cookval;
            this.Tag = cookbookid;
            dtCookbook = HeartyHearthGeneral.Load(cookbookid, "Cookbook");
            bindsource.DataSource = dtCookbook;
            if (cookbookid == 0)
            {
                dtCookbook.Rows.Add();
                dtCookbook.Rows[0]["CookbookActive"] = 0;
            }
            DataTable dtUserName = HeartyHearthGeneral.GetUserList();
            WindowsFormsUtility.SetListBinding(lstUserName, dtUserName, dtCookbook, "Users", true);
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateCreated, bindsource);
            WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(ckActive, bindsource);
            ckActive.Checked = (bool)dtCookbook.Rows[0]["CookbookActive"];
            this.Text = GetCookbookName();
            SetButtonsEnabledBasedOnNewRecord();
        }

        private void LoadCookbookRecipes()
        {
            dtCookbookRecipe = ChildRecords.LoadByCookbookId(cookbookid, "CookbookRecipe");
            gCookbookRecipe.Columns.Clear();
            gCookbookRecipe.DataSource = dtCookbookRecipe;
            WindowsFormsUtility.AddComboBoxToGrid(gCookbookRecipe, DataMaintenance.GetDataList("Recipe"), "Recipe", "RecipeName");
            WindowsFormsUtility.FormatGridForEdit(gCookbookRecipe, "CookbookRecipe");
            WindowsFormsUtility.AddDeleteButtonToGrid(gCookbookRecipe, "Delete");
        }

        private string GetCookbookName()
        {
            string value = "Cookbook - New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtCookbook, "CookbookId");
            if (pkvalue > 0)
            {
                value = "Cookbook - " + SQLUtility.GetValueFromFirstRowAsString(dtCookbook, "CookbookName");
            }
            return value;
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                if (ckActive.Checked)
                {
                    dtCookbook.Rows[0]["CookbookActive"] = 1;
                }
                else
                {
                    dtCookbook.Rows[0]["CookbookActive"] = 0;
                }
                HeartyHearthGeneral.Save(dtCookbook, "Cookbook");
                b = true;
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtCookbook, "CookbookId");
                this.Tag = cookbookid;
                this.Text = GetCookbookName();
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

        private void SaveCookbookRecipe()
        {
            try
            {
                ChildRecords.SaveTable(dtCookbookRecipe, cookbookid, "CookbookRecipe", "Cookbook");
                LoadCookbookRecipes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteCookbookRecipe(int rowIndex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gCookbookRecipe, rowIndex, "CookbookRecipeId");
            if (id > 0)
            {
                try
                {
                    ChildRecords.Delete(id, "CookbookRecipe");
                    LoadCookbookRecipes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gCookbookRecipe.Rows.Count)
            {
                gCookbookRecipe.Rows.RemoveAt(rowIndex);
            }
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to permenantly delete this cookbook with all its related records?!", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                HeartyHearthGeneral.Delete(dtCookbook, "Cookbook");
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

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnCookbookRecipeSave.Enabled = b;
            if (b == false)
            {
                btnDelete.FlatStyle = FlatStyle.System;
                btnCookbookRecipeSave.FlatStyle = FlatStyle.System;
            }
            else
            {
                btnDelete.FlatStyle = FlatStyle.Standard;
                btnCookbookRecipeSave.FlatStyle = FlatStyle.Standard;
            }
        }

        private void FrmCookbookDetails_Activated(object? sender, EventArgs e)
        {
            LoadCookbookDetailsForm(cookbookid);
        }

        private void FrmCookbookDetails_Shown(object? sender, EventArgs e)
        {
            LoadCookbookRecipes();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnCookbookRecipeSave_Click(object? sender, EventArgs e)
        {
            SaveCookbookRecipe();
        }

        private void GCookbookRecipe_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var sendergrid = (DataGridView)sender;
            if (sendergrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && sendergrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DeleteCookbookRecipe(e.RowIndex);
            }
        }

        private void TxtPrice_Validating(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            if (int.TryParse(txtPrice.Text, out int n) == false)
            {
                MessageBox.Show("Cannot enter a non numeric value for Price.");
            }
        }

        private void GCookbookRecipe_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            if (view.Columns[e.ColumnIndex].Name == "RecipeSequence")
            {
                MessageBox.Show("Cannot enter a non numeric Recipe Sequence.");
            }
        }

    }
}
