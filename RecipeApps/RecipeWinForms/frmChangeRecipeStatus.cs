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
            dtRecipe = Recipe.Load(recipeid);
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
                    btnPublish.Enabled = true;
                    btnArchive.Enabled = true;
                    break;
                case "Published":
                    btnPublish.Enabled = false;
                    btnDraft.Enabled = true;
                    btnArchive.Enabled = true;
                    break;
                case "Archived":
                    btnArchive.Enabled = false;
                    btnDraft.Enabled = true;
                    btnPublish.Enabled = true;
                    break;
            }
        }

        private void ArchiveRecipe()
        {
            SQLUtility.SaveDataRow(dtRecipe.Rows[0], "ArchiveRecipe", true);
            dtRecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtRecipe;
            SetButtonsEnabledBasedOnCurrentStatus();
        }

        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            ArchiveRecipe();
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            
        }

    }
}
