namespace RecipeWinForms
{
    partial class frmCookbookDetails
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
            lblCookbookName = new Label();
            txtCookbookName = new TextBox();
            lblUser = new Label();
            lstUserName = new ComboBox();
            tblInfo = new TableLayoutPanel();
            lblDateCreatedText = new Label();
            txtPrice = new TextBox();
            lblDateCreated = new Label();
            lblPrice = new Label();
            lblActive = new Label();
            ckActive = new CheckBox();
            tblCookbookRecipeRecords = new TableLayoutPanel();
            btnCookbookRecipeSave = new Button();
            gCookbookRecipe = new DataGridView();
            tblButtons = new TableLayoutPanel();
            btnDelete = new Button();
            btnSave = new Button();
            tblMain.SuspendLayout();
            tblInfo.SuspendLayout();
            tblCookbookRecipeRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookRecipe).BeginInit();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.3684216F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.63158F));
            tblMain.Controls.Add(lblCookbookName, 0, 1);
            tblMain.Controls.Add(txtCookbookName, 1, 1);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(tblInfo, 1, 4);
            tblMain.Controls.Add(lblPrice, 0, 4);
            tblMain.Controls.Add(lblActive, 0, 5);
            tblMain.Controls.Add(ckActive, 1, 5);
            tblMain.Controls.Add(tblCookbookRecipeRecords, 0, 6);
            tblMain.Controls.Add(tblButtons, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 7;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.389716F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.336942F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.201624F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.577808F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 53.1799736F));
            tblMain.Size = new Size(665, 647);
            tblMain.TabIndex = 0;
            // 
            // lblCookbookName
            // 
            lblCookbookName.Anchor = AnchorStyles.Left;
            lblCookbookName.AutoSize = true;
            lblCookbookName.Location = new Point(15, 70);
            lblCookbookName.Margin = new Padding(15, 0, 3, 0);
            lblCookbookName.Name = "lblCookbookName";
            lblCookbookName.Size = new Size(161, 28);
            lblCookbookName.TabIndex = 2;
            lblCookbookName.Text = "Cookbook Name";
            // 
            // txtCookbookName
            // 
            txtCookbookName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCookbookName.Location = new Point(185, 67);
            txtCookbookName.Margin = new Padding(3, 3, 15, 3);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(465, 34);
            txtCookbookName.TabIndex = 3;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(15, 131);
            lblUser.Margin = new Padding(15, 0, 3, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(51, 28);
            lblUser.TabIndex = 4;
            lblUser.Text = "User";
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(185, 131);
            lstUserName.Margin = new Padding(3, 3, 15, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(465, 36);
            lstUserName.TabIndex = 5;
            // 
            // tblInfo
            // 
            tblInfo.ColumnCount = 3;
            tblInfo.ColumnStyles.Add(new ColumnStyle());
            tblInfo.ColumnStyles.Add(new ColumnStyle());
            tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.76344F));
            tblInfo.Controls.Add(lblDateCreatedText, 1, 0);
            tblInfo.Controls.Add(txtPrice, 0, 1);
            tblInfo.Controls.Add(lblDateCreated, 1, 1);
            tblInfo.Dock = DockStyle.Fill;
            tblInfo.Location = new Point(185, 178);
            tblInfo.Margin = new Padding(3, 3, 15, 3);
            tblInfo.Name = "tblInfo";
            tblInfo.RowCount = 2;
            tblInfo.RowStyles.Add(new RowStyle());
            tblInfo.RowStyles.Add(new RowStyle());
            tblInfo.Size = new Size(465, 68);
            tblInfo.TabIndex = 6;
            // 
            // lblDateCreatedText
            // 
            lblDateCreatedText.AutoSize = true;
            lblDateCreatedText.Dock = DockStyle.Fill;
            lblDateCreatedText.Location = new Point(105, 0);
            lblDateCreatedText.Name = "lblDateCreatedText";
            lblDateCreatedText.Size = new Size(130, 28);
            lblDateCreatedText.TabIndex = 0;
            lblDateCreatedText.Text = "Date Created:";
            lblDateCreatedText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(3, 31);
            txtPrice.Margin = new Padding(3, 3, 30, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(69, 34);
            txtPrice.TabIndex = 1;
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.BorderStyle = BorderStyle.FixedSingle;
            lblDateCreated.Dock = DockStyle.Fill;
            lblDateCreated.Location = new Point(105, 33);
            lblDateCreated.Margin = new Padding(3, 5, 3, 0);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(130, 35);
            lblDateCreated.TabIndex = 2;
            lblDateCreated.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(15, 206);
            lblPrice.Margin = new Padding(15, 0, 3, 15);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(54, 28);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price";
            // 
            // lblActive
            // 
            lblActive.Anchor = AnchorStyles.Left;
            lblActive.AutoSize = true;
            lblActive.Location = new Point(15, 259);
            lblActive.Margin = new Padding(15, 0, 3, 0);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(66, 28);
            lblActive.TabIndex = 8;
            lblActive.Text = "Active";
            // 
            // ckActive
            // 
            ckActive.Anchor = AnchorStyles.Left;
            ckActive.AutoSize = true;
            ckActive.Location = new Point(185, 265);
            ckActive.Name = "ckActive";
            ckActive.Size = new Size(18, 17);
            ckActive.TabIndex = 9;
            ckActive.UseVisualStyleBackColor = true;
            // 
            // tblCookbookRecipeRecords
            // 
            tblCookbookRecipeRecords.ColumnCount = 1;
            tblMain.SetColumnSpan(tblCookbookRecipeRecords, 2);
            tblCookbookRecipeRecords.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblCookbookRecipeRecords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblCookbookRecipeRecords.Controls.Add(btnCookbookRecipeSave, 0, 0);
            tblCookbookRecipeRecords.Controls.Add(gCookbookRecipe, 0, 1);
            tblCookbookRecipeRecords.Dock = DockStyle.Fill;
            tblCookbookRecipeRecords.Location = new Point(3, 328);
            tblCookbookRecipeRecords.Margin = new Padding(3, 30, 3, 3);
            tblCookbookRecipeRecords.Name = "tblCookbookRecipeRecords";
            tblCookbookRecipeRecords.RowCount = 2;
            tblCookbookRecipeRecords.RowStyles.Add(new RowStyle());
            tblCookbookRecipeRecords.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCookbookRecipeRecords.Size = new Size(659, 316);
            tblCookbookRecipeRecords.TabIndex = 10;
            // 
            // btnCookbookRecipeSave
            // 
            btnCookbookRecipeSave.AutoSize = true;
            btnCookbookRecipeSave.Location = new Point(30, 15);
            btnCookbookRecipeSave.Margin = new Padding(30, 15, 3, 3);
            btnCookbookRecipeSave.Name = "btnCookbookRecipeSave";
            btnCookbookRecipeSave.Size = new Size(132, 38);
            btnCookbookRecipeSave.TabIndex = 0;
            btnCookbookRecipeSave.Text = "Save";
            btnCookbookRecipeSave.UseVisualStyleBackColor = true;
            // 
            // gCookbookRecipe
            // 
            gCookbookRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gCookbookRecipe.Dock = DockStyle.Fill;
            gCookbookRecipe.Location = new Point(30, 59);
            gCookbookRecipe.Margin = new Padding(30, 3, 30, 30);
            gCookbookRecipe.Name = "gCookbookRecipe";
            gCookbookRecipe.RowHeadersVisible = false;
            gCookbookRecipe.RowHeadersWidth = 51;
            gCookbookRecipe.Size = new Size(599, 227);
            gCookbookRecipe.TabIndex = 1;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 2;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.Controls.Add(btnDelete, 1, 0);
            tblButtons.Controls.Add(btnSave, 0, 0);
            tblButtons.Location = new Point(3, 3);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblButtons.Size = new Size(176, 48);
            tblButtons.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(91, 5);
            btnDelete.Margin = new Padding(3, 5, 3, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 38);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnSave.Location = new Point(3, 5);
            btnSave.Margin = new Padding(3, 5, 3, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 38);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmCookbookDetails
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 647);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCookbookDetails";
            Text = "Cookbook Details";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblInfo.ResumeLayout(false);
            tblInfo.PerformLayout();
            tblCookbookRecipeRecords.ResumeLayout(false);
            tblCookbookRecipeRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookRecipe).EndInit();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private Button btnDelete;
        private Label lblCookbookName;
        private TextBox txtCookbookName;
        private Label lblUser;
        private ComboBox lstUserName;
        private TableLayoutPanel tblInfo;
        private Label lblDateCreatedText;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblActive;
        private CheckBox ckActive;
        private TableLayoutPanel tblCookbookRecipeRecords;
        private Button btnCookbookRecipeSave;
        private DataGridView gCookbookRecipe;
        private Label lblDateCreated;
        private TableLayoutPanel tblButtons;
    }
}