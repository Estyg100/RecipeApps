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
            this.FormClosing += FrmChangeRecipeStatus_FormClosing;
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
            switch (lblCurrentStatus.Text)
            {
                case "Draft":
                    btnDraft.Enabled = false;
                    break;
                case "Published":
                    btnPublish.Enabled = false;
                    break;
                case "Archived":
                    btnArchive.Enabled = false;
                    break;
            }
        }

        private void ArchiveRecipe()
        {
            SQLUtility.SaveDataRow(dtRecipe.Rows[0], "ArchiveRecipe", true);
            LoadChangeRecipeStatusForm(recipeid);
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

        private void FrmChangeRecipeStatus_FormClosing(object? sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }


    }
}
