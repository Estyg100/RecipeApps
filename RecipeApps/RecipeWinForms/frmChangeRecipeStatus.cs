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
                    btnPublish.Enabled = true;
                    btnArchive.Enabled = true;
                    break;
                case "Published":
                    btnPublish.Enabled = false;
                    btnDraft.Enabled = false;
                    btnArchive.Enabled = true;
                    break;
                case "Archived":
                    btnArchive.Enabled = false;
                    btnDraft.Enabled = true;
                    btnPublish.Enabled = false;
                    break;
            }
        }

        private void ArchiveRecipe()
        {
            SQLUtility.SaveDataRow(dtRecipe.Rows[0], "ArchiveRecipe", true);
            dtRecipe = HeartyHearthGeneral.Load(recipeid, "Recipe");
            bindsource.DataSource = dtRecipe;
            SetButtonsEnabledBasedOnCurrentStatus();
        }

        private void DraftRecipe()
        {
            SQLUtility.SaveDataRow(dtRecipe.Rows[0], "DraftRecipe", true);
            dtRecipe = HeartyHearthGeneral.Load(recipeid, "Recipe");
            bindsource.DataSource = dtRecipe;
            SetButtonsEnabledBasedOnCurrentStatus();
        }

        private void PublishRecipe()
        {
            SQLUtility.SaveDataRow(dtRecipe.Rows[0], "PublishRecipe", true);
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
            ArchiveRecipe();
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to change this Recipe to Published?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            PublishRecipe();
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to change this Recipe to Drafted?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            DraftRecipe();
        }

    }
}
