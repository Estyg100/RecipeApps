namespace RecipeWinForms
{
    partial class frmRecipe
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
            lblDateArchived = new Label();
            txtDateArchived = new TextBox();
            lblDatePublished = new Label();
            txtDatePublished = new TextBox();
            lblDateDraft = new Label();
            txtDateDraft = new TextBox();
            lblCaloriesPerServing = new Label();
            txtCaloriesPerServing = new TextBox();
            lblCuisine = new Label();
            lblRecipeName = new Label();
            txtRecipeName = new TextBox();
            lblUsers = new Label();
            tblButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            lstUserName = new ComboBox();
            lstCuisineName = new ComboBox();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.21053F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.7894745F));
            tblMain.Controls.Add(lblDateArchived, 0, 6);
            tblMain.Controls.Add(txtDateArchived, 1, 6);
            tblMain.Controls.Add(lblDatePublished, 0, 5);
            tblMain.Controls.Add(txtDatePublished, 1, 5);
            tblMain.Controls.Add(lblDateDraft, 0, 4);
            tblMain.Controls.Add(txtDateDraft, 1, 4);
            tblMain.Controls.Add(lblCaloriesPerServing, 0, 3);
            tblMain.Controls.Add(txtCaloriesPerServing, 1, 3);
            tblMain.Controls.Add(lblCuisine, 0, 2);
            tblMain.Controls.Add(lblRecipeName, 0, 1);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(lblUsers, 0, 0);
            tblMain.Controls.Add(tblButtons, 1, 7);
            tblMain.Controls.Add(lstUserName, 1, 0);
            tblMain.Controls.Add(lstCuisineName, 1, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 5, 4, 5);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(569, 333);
            tblMain.TabIndex = 0;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.Location = new Point(3, 251);
            lblDateArchived.Margin = new Padding(3, 7, 3, 0);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(135, 28);
            lblDateArchived.TabIndex = 5;
            lblDateArchived.Text = "Date Archived";
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(197, 247);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(369, 34);
            txtDateArchived.TabIndex = 11;
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Left;
            lblDatePublished.AutoSize = true;
            lblDatePublished.Location = new Point(3, 210);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(143, 28);
            lblDatePublished.TabIndex = 4;
            lblDatePublished.Text = "Date Published";
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(197, 207);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(369, 34);
            txtDatePublished.TabIndex = 10;
            // 
            // lblDateDraft
            // 
            lblDateDraft.Anchor = AnchorStyles.Left;
            lblDateDraft.AutoSize = true;
            lblDateDraft.Location = new Point(3, 170);
            lblDateDraft.Name = "lblDateDraft";
            lblDateDraft.Size = new Size(102, 28);
            lblDateDraft.TabIndex = 3;
            lblDateDraft.Text = "Date Draft";
            // 
            // txtDateDraft
            // 
            txtDateDraft.Dock = DockStyle.Fill;
            txtDateDraft.Location = new Point(197, 167);
            txtDateDraft.Name = "txtDateDraft";
            txtDateDraft.ReadOnly = true;
            txtDateDraft.Size = new Size(369, 34);
            txtDateDraft.TabIndex = 9;
            // 
            // lblCaloriesPerServing
            // 
            lblCaloriesPerServing.Anchor = AnchorStyles.Left;
            lblCaloriesPerServing.AutoSize = true;
            lblCaloriesPerServing.Location = new Point(3, 130);
            lblCaloriesPerServing.Name = "lblCaloriesPerServing";
            lblCaloriesPerServing.Size = new Size(184, 28);
            lblCaloriesPerServing.TabIndex = 2;
            lblCaloriesPerServing.Text = "Calories Per Serving";
            // 
            // txtCaloriesPerServing
            // 
            txtCaloriesPerServing.Dock = DockStyle.Fill;
            txtCaloriesPerServing.Location = new Point(197, 127);
            txtCaloriesPerServing.Name = "txtCaloriesPerServing";
            txtCaloriesPerServing.Size = new Size(369, 34);
            txtCaloriesPerServing.TabIndex = 8;
            // 
            // lblCuisine
            // 
            lblCuisine.Anchor = AnchorStyles.Left;
            lblCuisine.AutoSize = true;
            lblCuisine.Location = new Point(3, 89);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(74, 28);
            lblCuisine.TabIndex = 1;
            lblCuisine.Text = "Cuisine";
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Left;
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(4, 48);
            lblRecipeName.Margin = new Padding(4, 0, 4, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(126, 28);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            lblRecipeName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(197, 45);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(369, 34);
            txtRecipeName.TabIndex = 6;
            // 
            // lblUsers
            // 
            lblUsers.Anchor = AnchorStyles.Left;
            lblUsers.AutoSize = true;
            lblUsers.Location = new Point(3, 7);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(51, 28);
            lblUsers.TabIndex = 12;
            lblUsers.Text = "User";
            lblUsers.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 2;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.Controls.Add(btnSave, 0, 0);
            tblButtons.Controls.Add(btnDelete, 1, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(197, 287);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblButtons.Size = new Size(369, 125);
            tblButtons.TabIndex = 14;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(178, 38);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(187, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(179, 38);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lstUserName
            // 
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(197, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(369, 36);
            lstUserName.TabIndex = 15;
            // 
            // lstCuisineName
            // 
            lstCuisineName.Dock = DockStyle.Fill;
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(197, 85);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(369, 36);
            lstCuisineName.TabIndex = 16;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 333);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRecipe";
            Text = "frmRecipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblCuisine;
        private Label lblCaloriesPerServing;
        private Label lblDateDraft;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private TextBox txtRecipeName;
        private TextBox txtCaloriesPerServing;
        private TextBox txtDateDraft;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private Label lblUsers;
        private TableLayoutPanel tblButtons;
        private Button btnSave;
        private Button btnDelete;
        private ComboBox lstUserName;
        private ComboBox lstCuisineName;
    }
}