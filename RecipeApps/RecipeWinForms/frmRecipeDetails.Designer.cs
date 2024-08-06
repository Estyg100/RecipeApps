namespace RecipeWinForms
{
    partial class frmRecipeDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblMain = new TableLayoutPanel();
            tblButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            btnChangeStatus = new Button();
            lblRecipeNAme = new Label();
            txtRecipeName = new TextBox();
            lblUser = new Label();
            lstUserName = new ComboBox();
            lblCuisine = new Label();
            lstCuisineName = new ComboBox();
            lblCaloriesPerServing = new Label();
            txtCaloriesPerServing = new TextBox();
            lblCurrentStatus = new Label();
            txtCurrentStatus = new TextBox();
            lblStatusDates = new Label();
            tblStatusDates = new TableLayoutPanel();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            txtDateDraft = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            tbcChildRecords = new TabControl();
            tbcIngredients = new TabPage();
            tbcSteps = new TabPage();
            tblSteps = new TableLayoutPanel();
            btnStepsSave = new Button();
            gSteps = new DataGridView();
            tblIngredients = new TableLayoutPanel();
            btnIngredientSave = new Button();
            gIngredients = new DataGridView();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            tblStatusDates.SuspendLayout();
            tbcChildRecords.SuspendLayout();
            tbcIngredients.SuspendLayout();
            tbcSteps.SuspendLayout();
            tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.273922F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.726078F));
            tblMain.Controls.Add(tblButtons, 0, 0);
            tblMain.Controls.Add(lblRecipeNAme, 0, 1);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(lblCuisine, 0, 3);
            tblMain.Controls.Add(lstCuisineName, 1, 3);
            tblMain.Controls.Add(lblCaloriesPerServing, 0, 4);
            tblMain.Controls.Add(txtCaloriesPerServing, 1, 4);
            tblMain.Controls.Add(lblCurrentStatus, 0, 5);
            tblMain.Controls.Add(txtCurrentStatus, 1, 5);
            tblMain.Controls.Add(lblStatusDates, 0, 6);
            tblMain.Controls.Add(tblStatusDates, 1, 6);
            tblMain.Controls.Add(tbcChildRecords, 0, 7);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.196721F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.818411F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.566204F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.196721F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.205548F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2807016F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 39.6491241F));
            tblMain.Size = new Size(533, 855);
            tblMain.TabIndex = 0;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblMain.SetColumnSpan(tblButtons, 2);
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.2063484F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.7936516F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.Controls.Add(btnSave, 0, 0);
            tblButtons.Controls.Add(btnDelete, 1, 0);
            tblButtons.Controls.Add(btnChangeStatus, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 3);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblButtons.Size = new Size(527, 63);
            tblButtons.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 57);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(130, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 57);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.AutoSize = true;
            btnChangeStatus.Dock = DockStyle.Right;
            btnChangeStatus.Location = new Point(360, 3);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(164, 57);
            btnChangeStatus.TabIndex = 2;
            btnChangeStatus.Text = "Change Status";
            btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // lblRecipeNAme
            // 
            lblRecipeNAme.Anchor = AnchorStyles.Left;
            lblRecipeNAme.AutoSize = true;
            lblRecipeNAme.Location = new Point(15, 88);
            lblRecipeNAme.Margin = new Padding(15, 0, 3, 0);
            lblRecipeNAme.Name = "lblRecipeNAme";
            lblRecipeNAme.Size = new Size(126, 28);
            lblRecipeNAme.TabIndex = 1;
            lblRecipeNAme.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRecipeName.Location = new Point(207, 85);
            txtRecipeName.Margin = new Padding(3, 3, 15, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(311, 34);
            txtRecipeName.TabIndex = 2;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(15, 153);
            lblUser.Margin = new Padding(15, 0, 3, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(51, 28);
            lblUser.TabIndex = 3;
            lblUser.Text = "User";
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(207, 149);
            lstUserName.Margin = new Padding(3, 3, 15, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(311, 36);
            lstUserName.TabIndex = 4;
            // 
            // lblCuisine
            // 
            lblCuisine.Anchor = AnchorStyles.Left;
            lblCuisine.AutoSize = true;
            lblCuisine.Location = new Point(15, 219);
            lblCuisine.Margin = new Padding(15, 0, 3, 0);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(74, 28);
            lblCuisine.TabIndex = 5;
            lblCuisine.Text = "Cuisine";
            // 
            // lstCuisineName
            // 
            lstCuisineName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(207, 216);
            lstCuisineName.Margin = new Padding(3, 3, 15, 3);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(311, 36);
            lstCuisineName.TabIndex = 6;
            // 
            // lblCaloriesPerServing
            // 
            lblCaloriesPerServing.Anchor = AnchorStyles.Left;
            lblCaloriesPerServing.AutoSize = true;
            lblCaloriesPerServing.Location = new Point(15, 286);
            lblCaloriesPerServing.Margin = new Padding(15, 0, 3, 0);
            lblCaloriesPerServing.Name = "lblCaloriesPerServing";
            lblCaloriesPerServing.Size = new Size(184, 28);
            lblCaloriesPerServing.TabIndex = 7;
            lblCaloriesPerServing.Text = "Calories Per Serving";
            // 
            // txtCaloriesPerServing
            // 
            txtCaloriesPerServing.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCaloriesPerServing.Location = new Point(207, 283);
            txtCaloriesPerServing.Margin = new Padding(3, 3, 15, 3);
            txtCaloriesPerServing.Name = "txtCaloriesPerServing";
            txtCaloriesPerServing.Size = new Size(311, 34);
            txtCaloriesPerServing.TabIndex = 8;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Left;
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Location = new Point(15, 358);
            lblCurrentStatus.Margin = new Padding(15, 0, 3, 0);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(135, 28);
            lblCurrentStatus.TabIndex = 9;
            lblCurrentStatus.Text = "Current Status";
            // 
            // txtCurrentStatus
            // 
            txtCurrentStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCurrentStatus.Location = new Point(207, 355);
            txtCurrentStatus.Margin = new Padding(3, 3, 15, 3);
            txtCurrentStatus.Name = "txtCurrentStatus";
            txtCurrentStatus.ReadOnly = true;
            txtCurrentStatus.Size = new Size(311, 34);
            txtCurrentStatus.TabIndex = 10;
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Left;
            lblStatusDates.AutoSize = true;
            lblStatusDates.Location = new Point(15, 449);
            lblStatusDates.Margin = new Padding(15, 0, 3, 0);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(119, 28);
            lblStatusDates.TabIndex = 11;
            lblStatusDates.Text = "Status Dates";
            // 
            // tblStatusDates
            // 
            tblStatusDates.ColumnCount = 3;
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.Controls.Add(lblDrafted, 0, 0);
            tblStatusDates.Controls.Add(lblPublished, 1, 0);
            tblStatusDates.Controls.Add(lblArchived, 2, 0);
            tblStatusDates.Controls.Add(txtDateDraft, 0, 1);
            tblStatusDates.Controls.Add(txtDatePublished, 1, 1);
            tblStatusDates.Controls.Add(txtDateArchived, 2, 1);
            tblStatusDates.Dock = DockStyle.Fill;
            tblStatusDates.Location = new Point(207, 414);
            tblStatusDates.Margin = new Padding(3, 3, 15, 3);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 2;
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.Size = new Size(311, 98);
            tblStatusDates.TabIndex = 12;
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.Dock = DockStyle.Fill;
            lblDrafted.Location = new Point(3, 0);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(97, 49);
            lblDrafted.TabIndex = 0;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Dock = DockStyle.Fill;
            lblPublished.Location = new Point(106, 0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(97, 49);
            lblPublished.TabIndex = 1;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Dock = DockStyle.Fill;
            lblArchived.Location = new Point(209, 0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(99, 49);
            lblArchived.TabIndex = 2;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDateDraft
            // 
            txtDateDraft.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDateDraft.Location = new Point(3, 56);
            txtDateDraft.Name = "txtDateDraft";
            txtDateDraft.ReadOnly = true;
            txtDateDraft.Size = new Size(97, 34);
            txtDateDraft.TabIndex = 3;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDatePublished.Location = new Point(106, 56);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(97, 34);
            txtDatePublished.TabIndex = 4;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDateArchived.Location = new Point(209, 56);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(99, 34);
            txtDateArchived.TabIndex = 5;
            // 
            // tbcChildRecords
            // 
            tblMain.SetColumnSpan(tbcChildRecords, 2);
            tbcChildRecords.Controls.Add(tbcIngredients);
            tbcChildRecords.Controls.Add(tbcSteps);
            tbcChildRecords.Dock = DockStyle.Fill;
            tbcChildRecords.Location = new Point(15, 518);
            tbcChildRecords.Margin = new Padding(15, 3, 15, 3);
            tbcChildRecords.Name = "tbcChildRecords";
            tbcChildRecords.SelectedIndex = 0;
            tbcChildRecords.Size = new Size(503, 334);
            tbcChildRecords.TabIndex = 13;
            // 
            // tbcIngredients
            // 
            tbcIngredients.Controls.Add(tblIngredients);
            tbcIngredients.Location = new Point(4, 37);
            tbcIngredients.Name = "tbcIngredients";
            tbcIngredients.Padding = new Padding(3);
            tbcIngredients.Size = new Size(495, 293);
            tbcIngredients.TabIndex = 0;
            tbcIngredients.Text = "Ingredients";
            tbcIngredients.UseVisualStyleBackColor = true;
            // 
            // tbcSteps
            // 
            tbcSteps.Controls.Add(tblSteps);
            tbcSteps.Location = new Point(4, 37);
            tbcSteps.Name = "tbcSteps";
            tbcSteps.Padding = new Padding(3);
            tbcSteps.Size = new Size(495, 293);
            tbcSteps.TabIndex = 1;
            tbcSteps.Text = "Steps";
            tbcSteps.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblSteps.Controls.Add(btnStepsSave, 0, 0);
            tblSteps.Controls.Add(gSteps, 0, 1);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(3, 3);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblSteps.Size = new Size(489, 287);
            tblSteps.TabIndex = 0;
            // 
            // btnStepsSave
            // 
            btnStepsSave.AutoSize = true;
            btnStepsSave.Location = new Point(3, 3);
            btnStepsSave.Name = "btnStepsSave";
            btnStepsSave.Size = new Size(94, 38);
            btnStepsSave.TabIndex = 0;
            btnStepsSave.Text = "Save";
            btnStepsSave.UseVisualStyleBackColor = true;
            // 
            // gSteps
            // 
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 47);
            gSteps.Name = "gSteps";
            gSteps.RowHeadersWidth = 51;
            gSteps.Size = new Size(483, 237);
            gSteps.TabIndex = 1;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblIngredients.Controls.Add(btnIngredientSave, 0, 0);
            tblIngredients.Controls.Add(gIngredients, 0, 1);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblIngredients.Size = new Size(489, 287);
            tblIngredients.TabIndex = 0;
            // 
            // btnIngredientSave
            // 
            btnIngredientSave.AutoSize = true;
            btnIngredientSave.Location = new Point(3, 3);
            btnIngredientSave.Name = "btnIngredientSave";
            btnIngredientSave.Size = new Size(94, 38);
            btnIngredientSave.TabIndex = 0;
            btnIngredientSave.Text = "Save";
            btnIngredientSave.UseVisualStyleBackColor = true;
            // 
            // gIngredients
            // 
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 47);
            gIngredients.Name = "gIngredients";
            gIngredients.RowHeadersWidth = 51;
            gIngredients.Size = new Size(483, 237);
            gIngredients.TabIndex = 1;
            // 
            // frmRecipeDetails
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 855);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRecipeDetails";
            Text = "Recipe Details";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            tblStatusDates.ResumeLayout(false);
            tblStatusDates.PerformLayout();
            tbcChildRecords.ResumeLayout(false);
            tbcIngredients.ResumeLayout(false);
            tbcSteps.ResumeLayout(false);
            tblSteps.ResumeLayout(false);
            tblSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
            tblIngredients.ResumeLayout(false);
            tblIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblButtons;
        private Button btnSave;
        private Button btnDelete;
        private Button btnChangeStatus;
        private Label lblRecipeNAme;
        private TextBox txtRecipeName;
        private Label lblUser;
        private ComboBox lstUserName;
        private Label lblCuisine;
        private ComboBox lstCuisineName;
        private Label lblCaloriesPerServing;
        private TextBox txtCaloriesPerServing;
        private Label lblCurrentStatus;
        private TextBox txtCurrentStatus;
        private Label lblStatusDates;
        private TableLayoutPanel tblStatusDates;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private TextBox txtDateDraft;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TabControl tbcChildRecords;
        private TabPage tbcIngredients;
        private TabPage tbcSteps;
        private TableLayoutPanel tblIngredients;
        private Button btnIngredientSave;
        private DataGridView gIngredients;
        private TableLayoutPanel tblSteps;
        private Button btnStepsSave;
        private DataGridView gSteps;
    }
}