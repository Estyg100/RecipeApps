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
            btnSave = new Button();
            btnDelete = new Button();
            lblCookbookName = new Label();
            txtRecipeName = new TextBox();
            lblUser = new Label();
            lstUserName = new ComboBox();
            tblInfo = new TableLayoutPanel();
            lblDateCreated = new Label();
            txtPrice = new TextBox();
            txtDateCreated = new TextBox();
            lblPrice = new Label();
            lblActive = new Label();
            ckActive = new CheckBox();
            tblCookbookRecipeRecords = new TableLayoutPanel();
            btnCookbookRecipeSave = new Button();
            gCookbookRecipe = new DataGridView();
            tblMain.SuspendLayout();
            tblInfo.SuspendLayout();
            tblCookbookRecipeRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.23065F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.769352F));
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Controls.Add(btnDelete, 1, 0);
            tblMain.Controls.Add(lblCookbookName, 0, 1);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(tblInfo, 1, 4);
            tblMain.Controls.Add(lblPrice, 0, 4);
            tblMain.Controls.Add(lblActive, 0, 5);
            tblMain.Controls.Add(ckActive, 1, 5);
            tblMain.Controls.Add(tblCookbookRecipeRecords, 0, 6);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 7;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.389716F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.336942F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.201624F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.3667116F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.577808F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 53.1799736F));
            tblMain.Size = new Size(665, 647);
            tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnSave.Location = new Point(52, 5);
            btnSave.Margin = new Padding(3, 5, 3, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 44);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(257, 5);
            btnDelete.Margin = new Padding(3, 5, 3, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 44);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
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
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRecipeName.Location = new Point(257, 67);
            txtRecipeName.Margin = new Padding(3, 3, 15, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(393, 34);
            txtRecipeName.TabIndex = 3;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(15, 130);
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
            lstUserName.Location = new Point(257, 126);
            lstUserName.Margin = new Padding(3, 3, 15, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(393, 36);
            lstUserName.TabIndex = 5;
            // 
            // tblInfo
            // 
            tblInfo.ColumnCount = 2;
            tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblInfo.Controls.Add(lblDateCreated, 1, 0);
            tblInfo.Controls.Add(txtPrice, 0, 1);
            tblInfo.Controls.Add(txtDateCreated, 1, 1);
            tblInfo.Dock = DockStyle.Fill;
            tblInfo.Location = new Point(257, 177);
            tblInfo.Margin = new Padding(3, 3, 15, 3);
            tblInfo.Name = "tblInfo";
            tblInfo.RowCount = 2;
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 42.3076935F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 57.6923065F));
            tblInfo.Size = new Size(393, 68);
            tblInfo.TabIndex = 6;
            // 
            // lblDateCreated
            // 
            lblDateCreated.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(229, 0);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(130, 28);
            lblDateCreated.TabIndex = 0;
            lblDateCreated.Text = "Date Created:";
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Left;
            txtPrice.Location = new Point(3, 31);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(82, 34);
            txtPrice.TabIndex = 1;
            // 
            // txtDateCreated
            // 
            txtDateCreated.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDateCreated.Location = new Point(199, 31);
            txtDateCreated.Name = "txtDateCreated";
            txtDateCreated.ReadOnly = true;
            txtDateCreated.Size = new Size(191, 34);
            txtDateCreated.TabIndex = 2;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(15, 205);
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
            lblActive.Location = new Point(15, 258);
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
            ckActive.Location = new Point(257, 264);
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
            tblCookbookRecipeRecords.Location = new Point(3, 300);
            tblCookbookRecipeRecords.Name = "tblCookbookRecipeRecords";
            tblCookbookRecipeRecords.RowCount = 2;
            tblCookbookRecipeRecords.RowStyles.Add(new RowStyle());
            tblCookbookRecipeRecords.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCookbookRecipeRecords.Size = new Size(659, 344);
            tblCookbookRecipeRecords.TabIndex = 10;
            // 
            // btnCookbookRecipeSave
            // 
            btnCookbookRecipeSave.AutoSize = true;
            btnCookbookRecipeSave.Location = new Point(3, 15);
            btnCookbookRecipeSave.Margin = new Padding(3, 15, 3, 3);
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
            gCookbookRecipe.Location = new Point(3, 59);
            gCookbookRecipe.Name = "gCookbookRecipe";
            gCookbookRecipe.RowHeadersVisible = false;
            gCookbookRecipe.RowHeadersWidth = 51;
            gCookbookRecipe.Size = new Size(653, 282);
            gCookbookRecipe.TabIndex = 1;
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private Button btnDelete;
        private Label lblCookbookName;
        private TextBox txtRecipeName;
        private Label lblUser;
        private ComboBox lstUserName;
        private TableLayoutPanel tblInfo;
        private Label lblDateCreated;
        private Label lblPrice;
        private TextBox txtPrice;
        private TextBox txtDateCreated;
        private Label lblActive;
        private CheckBox ckActive;
        private TableLayoutPanel tblCookbookRecipeRecords;
        private Button btnCookbookRecipeSave;
        private DataGridView gCookbookRecipe;
    }
}