namespace RecipeWinForms
{
    partial class frmRecipeList
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
            gRecipes = new DataGridView();
            btnNewRecipe = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipes).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tblMain.Controls.Add(gRecipes, 0, 1);
            tblMain.Controls.Add(btnNewRecipe, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4444447F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 89.55556F));
            tblMain.Size = new Size(750, 671);
            tblMain.TabIndex = 0;
            // 
            // gRecipes
            // 
            gRecipes.BackgroundColor = Color.Lavender;
            gRecipes.BorderStyle = BorderStyle.None;
            gRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipes.Dock = DockStyle.Fill;
            gRecipes.Location = new Point(30, 74);
            gRecipes.Margin = new Padding(30, 4, 30, 4);
            gRecipes.Name = "gRecipes";
            gRecipes.RowHeadersVisible = false;
            gRecipes.RowHeadersWidth = 51;
            gRecipes.Size = new Size(690, 593);
            gRecipes.TabIndex = 0;
            // 
            // btnNewRecipe
            // 
            btnNewRecipe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnNewRecipe.AutoSize = true;
            btnNewRecipe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewRecipe.ForeColor = Color.DarkSlateBlue;
            btnNewRecipe.Location = new Point(30, 7);
            btnNewRecipe.Margin = new Padding(30, 7, 4, 7);
            btnNewRecipe.Name = "btnNewRecipe";
            btnNewRecipe.Size = new Size(169, 56);
            btnNewRecipe.TabIndex = 1;
            btnNewRecipe.Text = "New Recipe";
            btnNewRecipe.UseVisualStyleBackColor = true;
            // 
            // frmRecipeList
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(750, 671);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmRecipeList";
            Text = "Recipe List";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView gRecipes;
        private Button btnNewRecipe;
    }
}