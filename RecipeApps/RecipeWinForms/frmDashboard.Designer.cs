namespace RecipeWinForms
{
    partial class frmDashboard
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
            lblHeartyHearth = new Label();
            lblDescription = new Label();
            gData = new DataGridView();
            tblButtons = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMain.Controls.Add(lblHeartyHearth, 0, 0);
            tblMain.Controls.Add(lblDescription, 0, 1);
            tblMain.Controls.Add(gData, 0, 2);
            tblMain.Controls.Add(tblButtons, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 21.2698421F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 24.4444447F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 40.15873F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4444447F));
            tblMain.Size = new Size(675, 625);
            tblMain.TabIndex = 0;
            // 
            // lblHeartyHearth
            // 
            lblHeartyHearth.AutoSize = true;
            lblHeartyHearth.Dock = DockStyle.Fill;
            lblHeartyHearth.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeartyHearth.Location = new Point(3, 0);
            lblHeartyHearth.Margin = new Padding(3, 0, 3, 20);
            lblHeartyHearth.Name = "lblHeartyHearth";
            lblHeartyHearth.Size = new Size(669, 112);
            lblHeartyHearth.TabIndex = 0;
            lblHeartyHearth.Text = "Hearty Hearth Desktop App";
            lblHeartyHearth.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Location = new Point(40, 132);
            lblDescription.Margin = new Padding(40, 0, 40, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(595, 152);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Welcome to the Hearty Hearth desktop app. In this app you can create recipes and cookbooks. You can also......";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gData
            // 
            gData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Location = new Point(122, 287);
            gData.Name = "gData";
            gData.RowHeadersWidth = 51;
            gData.Size = new Size(430, 244);
            gData.TabIndex = 2;
            // 
            // tblButtons
            // 
            tblButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.Controls.Add(btnRecipeList, 0, 0);
            tblButtons.Controls.Add(btnMealList, 1, 0);
            tblButtons.Controls.Add(btnCookbookList, 2, 0);
            tblButtons.Location = new Point(106, 537);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.Size = new Size(463, 85);
            tblButtons.TabIndex = 3;
            // 
            // btnRecipeList
            // 
            btnRecipeList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnRecipeList.AutoSize = true;
            btnRecipeList.Location = new Point(3, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(148, 87);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            btnMealList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnMealList.AutoSize = true;
            btnMealList.Location = new Point(157, 3);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(148, 87);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnCookbookList.AutoSize = true;
            btnCookbookList.Location = new Point(311, 3);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(149, 87);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 625);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblHeartyHearth;
        private Label lblDescription;
        private DataGridView gData;
        private TableLayoutPanel tblButtons;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
    }
}