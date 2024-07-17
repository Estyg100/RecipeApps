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
            lblRecipeName = new Label();
            lblCuisine = new Label();
            lblCaloriesPerServing = new Label();
            lblDateDraft = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            txtRecipeName = new TextBox();
            txtCuisine = new TextBox();
            txtCaloriesPerServing = new TextBox();
            txtDateDraft = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.21053F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.7894745F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(lblCuisine, 0, 1);
            tblMain.Controls.Add(lblCaloriesPerServing, 0, 2);
            tblMain.Controls.Add(lblDateDraft, 0, 3);
            tblMain.Controls.Add(lblDatePublished, 0, 4);
            tblMain.Controls.Add(lblDateArchived, 0, 5);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(txtCuisine, 1, 1);
            tblMain.Controls.Add(txtCaloriesPerServing, 1, 2);
            tblMain.Controls.Add(txtDateDraft, 1, 3);
            tblMain.Controls.Add(txtDatePublished, 1, 4);
            tblMain.Controls.Add(txtDateArchived, 1, 5);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 5, 4, 5);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 6;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(569, 239);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Left;
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(4, 6);
            lblRecipeName.Margin = new Padding(4, 0, 4, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(126, 28);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            lblRecipeName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCuisine
            // 
            lblCuisine.Anchor = AnchorStyles.Left;
            lblCuisine.AutoSize = true;
            lblCuisine.Location = new Point(3, 46);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(74, 28);
            lblCuisine.TabIndex = 1;
            lblCuisine.Text = "Cuisine";
            // 
            // lblCaloriesPerServing
            // 
            lblCaloriesPerServing.Anchor = AnchorStyles.Left;
            lblCaloriesPerServing.AutoSize = true;
            lblCaloriesPerServing.Location = new Point(3, 86);
            lblCaloriesPerServing.Name = "lblCaloriesPerServing";
            lblCaloriesPerServing.Size = new Size(184, 28);
            lblCaloriesPerServing.TabIndex = 2;
            lblCaloriesPerServing.Text = "Calories Per Serving";
            // 
            // lblDateDraft
            // 
            lblDateDraft.Anchor = AnchorStyles.Left;
            lblDateDraft.AutoSize = true;
            lblDateDraft.Location = new Point(3, 126);
            lblDateDraft.Name = "lblDateDraft";
            lblDateDraft.Size = new Size(102, 28);
            lblDateDraft.TabIndex = 3;
            lblDateDraft.Text = "Date Draft";
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Left;
            lblDatePublished.AutoSize = true;
            lblDatePublished.Location = new Point(3, 166);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(143, 28);
            lblDatePublished.TabIndex = 4;
            lblDatePublished.Text = "Date Published";
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.Location = new Point(3, 207);
            lblDateArchived.Margin = new Padding(3, 7, 3, 0);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(135, 28);
            lblDateArchived.TabIndex = 5;
            lblDateArchived.Text = "Date Archived";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(197, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(369, 34);
            txtRecipeName.TabIndex = 6;
            // 
            // txtCuisine
            // 
            txtCuisine.Dock = DockStyle.Fill;
            txtCuisine.Location = new Point(197, 43);
            txtCuisine.Name = "txtCuisine";
            txtCuisine.Size = new Size(369, 34);
            txtCuisine.TabIndex = 7;
            // 
            // txtCaloriesPerServing
            // 
            txtCaloriesPerServing.Dock = DockStyle.Fill;
            txtCaloriesPerServing.Location = new Point(197, 83);
            txtCaloriesPerServing.Name = "txtCaloriesPerServing";
            txtCaloriesPerServing.Size = new Size(369, 34);
            txtCaloriesPerServing.TabIndex = 8;
            // 
            // txtDateDraft
            // 
            txtDateDraft.Dock = DockStyle.Fill;
            txtDateDraft.Location = new Point(197, 123);
            txtDateDraft.Name = "txtDateDraft";
            txtDateDraft.Size = new Size(369, 34);
            txtDateDraft.TabIndex = 9;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(197, 163);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(369, 34);
            txtDatePublished.TabIndex = 10;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(197, 203);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(369, 34);
            txtDateArchived.TabIndex = 11;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 239);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRecipe";
            Text = "frmRecipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
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
        private TextBox txtCuisine;
        private TextBox txtCaloriesPerServing;
        private TextBox txtDateDraft;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
    }
}