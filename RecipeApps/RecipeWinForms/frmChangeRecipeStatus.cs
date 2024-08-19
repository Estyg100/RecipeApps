namespace RecipeWinForms
{
    public partial class frmChangeRecipeStatus : Form
    {
        DataTable dtRecipe = new();
        int recipeid = 0;
        BindingSource bindsource = new();

        public frmChangeRecipeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
            btnArchive.Click += BtnArchive_Click;
        }

        public void LoadChangeRecipeStatusForm(int recipeval)
        {
            recipeid = recipeval;
            this.Tag = recipeid;
            dtRecipe = HeartyHearthGeneral.Load(recipeid, "Recipe");
            bindsource.DataSource = dtRecipe;
            WindowsFormsUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(lblCurrentStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateDraft, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, bindsource);
            SetButtonsEnabledBasedOnCurrentStatus();
        }

        private void SetButtonsEnabledBasedOnCurrentStatus()
        {
            switch (dtRecipe.Rows[0]["CurrentStatus"])
            {
                case "Draft":
                    btnDraft.Enabled = false;
                    btnDraft.FlatStyle = FlatStyle.System;
                    btnPublish.Enabled = true;
                    btnArchive.Enabled = true;
                    btnPublish.FlatStyle = FlatStyle.Standard;
                    btnArchive.FlatStyle = FlatStyle.Standard;
                    break;
                case "Published":
                    btnPublish.Enabled = false;
                    btnPublish.FlatStyle = FlatStyle.System;
                    btnDraft.Enabled = false;
                    btnArchive.Enabled = true;
                    btnDraft.FlatStyle = FlatStyle.Standard;
                    btnArchive.FlatStyle = FlatStyle.Standard;
                    break;
                case "Archived":
                    btnArchive.Enabled = false;
                    btnArchive.FlatStyle = FlatStyle.System;
                    btnDraft.Enabled = true;
                    btnPublish.Enabled = false;
                    btnDraft.FlatStyle = FlatStyle.Standard;
                    btnPublish.FlatStyle = FlatStyle.Standard;
                    break;
            }
        }

        private void ChangeRecipeStatus()
        {
            SQLUtility.SaveDataRow(dtRecipe.Rows[0], "RecipeUpdate", true);
            dtRecipe = HeartyHearthGeneral.Load(recipeid, "Recipe");
            bindsource.DataSource = dtRecipe;
            SetButtonsEnabledBasedOnCurrentStatus();
        }

        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to change this Recipe to Archived?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            dtRecipe.Rows[0]["DateArchived"] = DateTime.Now.ToLongDateString();
            ChangeRecipeStatus();
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to change this Recipe to Published?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            dtRecipe.Rows[0]["DatePublished"] = DateTime.Now.ToLongDateString();
            ChangeRecipeStatus();
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to change this Recipe to Drafted?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            ChangeRecipeStatus();
        }

    }
}
