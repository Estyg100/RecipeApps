namespace RecipeWinForms
{
    partial class frmMain
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
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuDashboard = new ToolStripMenuItem();
            mnuRecipes = new ToolStripMenuItem();
            mnuRecipeList = new ToolStripMenuItem();
            mnuNewRecipe = new ToolStripMenuItem();
            mnuCloneRecipe = new ToolStripMenuItem();
            mnuMeals = new ToolStripMenuItem();
            mnuMealList = new ToolStripMenuItem();
            mnuCookbooks = new ToolStripMenuItem();
            mnuCookbookList = new ToolStripMenuItem();
            mnuNewCookbook = new ToolStripMenuItem();
            mnuAutoCreateCookbook = new ToolStripMenuItem();
            mnuDataMaintenance = new ToolStripMenuItem();
            mnuEditData = new ToolStripMenuItem();
            mnuWindows = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuMain.ImageScalingSize = new Size(20, 20);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuRecipes, mnuMeals, mnuCookbooks, mnuDataMaintenance, mnuWindows });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Padding = new Padding(8, 3, 0, 3);
            mnuMain.Size = new Size(971, 38);
            mnuMain.TabIndex = 1;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuDashboard });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(56, 32);
            mnuFile.Text = "File";
            // 
            // mnuDashboard
            // 
            mnuDashboard.Name = "mnuDashboard";
            mnuDashboard.Size = new Size(194, 32);
            mnuDashboard.Text = "Dashboard";
            // 
            // mnuRecipes
            // 
            mnuRecipes.DropDownItems.AddRange(new ToolStripItem[] { mnuRecipeList, mnuNewRecipe, mnuCloneRecipe });
            mnuRecipes.Name = "mnuRecipes";
            mnuRecipes.Size = new Size(91, 32);
            mnuRecipes.Text = "Recipes";
            // 
            // mnuRecipeList
            // 
            mnuRecipeList.Name = "mnuRecipeList";
            mnuRecipeList.Size = new Size(225, 32);
            mnuRecipeList.Text = "List";
            // 
            // mnuNewRecipe
            // 
            mnuNewRecipe.Name = "mnuNewRecipe";
            mnuNewRecipe.Size = new Size(225, 32);
            mnuNewRecipe.Text = "New Recipe";
            // 
            // mnuCloneRecipe
            // 
            mnuCloneRecipe.Name = "mnuCloneRecipe";
            mnuCloneRecipe.Size = new Size(225, 32);
            mnuCloneRecipe.Text = "Clone a Recipe";
            // 
            // mnuMeals
            // 
            mnuMeals.DropDownItems.AddRange(new ToolStripItem[] { mnuMealList });
            mnuMeals.Name = "mnuMeals";
            mnuMeals.Size = new Size(77, 32);
            mnuMeals.Text = "Meals";
            // 
            // mnuMealList
            // 
            mnuMealList.Name = "mnuMealList";
            mnuMealList.Size = new Size(127, 32);
            mnuMealList.Text = "List";
            // 
            // mnuCookbooks
            // 
            mnuCookbooks.DropDownItems.AddRange(new ToolStripItem[] { mnuCookbookList, mnuNewCookbook, mnuAutoCreateCookbook });
            mnuCookbooks.Name = "mnuCookbooks";
            mnuCookbooks.Size = new Size(126, 32);
            mnuCookbooks.Text = "Cookbooks";
            // 
            // mnuCookbookList
            // 
            mnuCookbookList.Name = "mnuCookbookList";
            mnuCookbookList.Size = new Size(231, 32);
            mnuCookbookList.Text = "List";
            // 
            // mnuNewCookbook
            // 
            mnuNewCookbook.Name = "mnuNewCookbook";
            mnuNewCookbook.Size = new Size(231, 32);
            mnuNewCookbook.Text = "New cookbook";
            // 
            // mnuAutoCreateCookbook
            // 
            mnuAutoCreateCookbook.Name = "mnuAutoCreateCookbook";
            mnuAutoCreateCookbook.Size = new Size(231, 32);
            mnuAutoCreateCookbook.Text = "Auto-Create";
            // 
            // mnuDataMaintenance
            // 
            mnuDataMaintenance.DropDownItems.AddRange(new ToolStripItem[] { mnuEditData });
            mnuDataMaintenance.Name = "mnuDataMaintenance";
            mnuDataMaintenance.Size = new Size(184, 32);
            mnuDataMaintenance.Text = "Data Maintenance";
            // 
            // mnuEditData
            // 
            mnuEditData.Name = "mnuEditData";
            mnuEditData.Size = new Size(178, 32);
            mnuEditData.Text = "Edit Data";
            // 
            // mnuWindows
            // 
            mnuWindows.Name = "mnuWindows";
            mnuWindows.Size = new Size(107, 32);
            mnuWindows.Text = "Windows";
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Location = new Point(0, 38);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(971, 25);
            tsMain.TabIndex = 3;
            tsMain.Text = "toolStrip1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 831);
            Controls.Add(tsMain);
            Controls.Add(mnuMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Hearty Hearth";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuDashboard;
        private ToolStripMenuItem mnuRecipes;
        private ToolStripMenuItem mnuRecipeList;
        private ToolStripMenuItem mnuNewRecipe;
        private ToolStripMenuItem mnuCloneRecipe;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuMealList;
        private ToolStripMenuItem mnuCookbooks;
        private ToolStripMenuItem mnuCookbookList;
        private ToolStripMenuItem mnuNewCookbook;
        private ToolStripMenuItem mnuAutoCreateCookbook;
        private ToolStripMenuItem mnuDataMaintenance;
        private ToolStripMenuItem mnuEditData;
        private ToolStripMenuItem mnuWindows;
        private ToolStrip tsMain;
    }
}