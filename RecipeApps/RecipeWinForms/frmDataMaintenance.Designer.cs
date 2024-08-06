namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            tblRadioButtons = new TableLayoutPanel();
            optUsers = new RadioButton();
            optCuisines = new RadioButton();
            optIngredients = new RadioButton();
            optMeasurements = new RadioButton();
            optCourses = new RadioButton();
            tblData = new TableLayoutPanel();
            btnSave = new Button();
            gData = new DataGridView();
            tblMain.SuspendLayout();
            tblRadioButtons.SuspendLayout();
            tblData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.1138229F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.88618F));
            tblMain.Controls.Add(tblRadioButtons, 0, 0);
            tblMain.Controls.Add(tblData, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 4, 4, 4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 932F));
            tblMain.Size = new Size(644, 649);
            tblMain.TabIndex = 0;
            // 
            // tblRadioButtons
            // 
            tblRadioButtons.ColumnCount = 1;
            tblRadioButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRadioButtons.Controls.Add(optUsers, 0, 0);
            tblRadioButtons.Controls.Add(optCuisines, 0, 1);
            tblRadioButtons.Controls.Add(optIngredients, 0, 2);
            tblRadioButtons.Controls.Add(optMeasurements, 0, 3);
            tblRadioButtons.Controls.Add(optCourses, 0, 4);
            tblRadioButtons.Dock = DockStyle.Fill;
            tblRadioButtons.Location = new Point(3, 3);
            tblRadioButtons.Name = "tblRadioButtons";
            tblRadioButtons.RowCount = 6;
            tblRadioButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblRadioButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblRadioButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblRadioButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblRadioButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblRadioButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblRadioButtons.Size = new Size(200, 643);
            tblRadioButtons.TabIndex = 0;
            // 
            // optUsers
            // 
            optUsers.Anchor = AnchorStyles.Left;
            optUsers.AutoSize = true;
            optUsers.Location = new Point(15, 32);
            optUsers.Margin = new Padding(15, 3, 3, 3);
            optUsers.Name = "optUsers";
            optUsers.Size = new Size(80, 32);
            optUsers.TabIndex = 0;
            optUsers.TabStop = true;
            optUsers.Text = "Users";
            optUsers.UseVisualStyleBackColor = true;
            // 
            // optCuisines
            // 
            optCuisines.Anchor = AnchorStyles.Left;
            optCuisines.AutoSize = true;
            optCuisines.Location = new Point(15, 128);
            optCuisines.Margin = new Padding(15, 3, 3, 3);
            optCuisines.Name = "optCuisines";
            optCuisines.Size = new Size(103, 32);
            optCuisines.TabIndex = 1;
            optCuisines.TabStop = true;
            optCuisines.Text = "Cuisines";
            optCuisines.UseVisualStyleBackColor = true;
            // 
            // optIngredients
            // 
            optIngredients.Anchor = AnchorStyles.Left;
            optIngredients.AutoSize = true;
            optIngredients.Location = new Point(15, 224);
            optIngredients.Margin = new Padding(15, 3, 3, 3);
            optIngredients.Name = "optIngredients";
            optIngredients.Size = new Size(131, 32);
            optIngredients.TabIndex = 2;
            optIngredients.TabStop = true;
            optIngredients.Text = "Ingredients";
            optIngredients.UseVisualStyleBackColor = true;
            // 
            // optMeasurements
            // 
            optMeasurements.Anchor = AnchorStyles.Left;
            optMeasurements.AutoSize = true;
            optMeasurements.Location = new Point(15, 320);
            optMeasurements.Margin = new Padding(15, 3, 3, 3);
            optMeasurements.Name = "optMeasurements";
            optMeasurements.Size = new Size(160, 32);
            optMeasurements.TabIndex = 3;
            optMeasurements.TabStop = true;
            optMeasurements.Text = "Meausrements";
            optMeasurements.UseVisualStyleBackColor = true;
            // 
            // optCourses
            // 
            optCourses.Anchor = AnchorStyles.Left;
            optCourses.AutoSize = true;
            optCourses.Location = new Point(15, 416);
            optCourses.Margin = new Padding(15, 3, 3, 3);
            optCourses.Name = "optCourses";
            optCourses.Size = new Size(101, 32);
            optCourses.TabIndex = 4;
            optCourses.TabStop = true;
            optCourses.Text = "Courses";
            optCourses.UseVisualStyleBackColor = true;
            // 
            // tblData
            // 
            tblData.ColumnCount = 1;
            tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblData.Controls.Add(btnSave, 0, 1);
            tblData.Controls.Add(gData, 0, 0);
            tblData.Dock = DockStyle.Fill;
            tblData.Location = new Point(209, 3);
            tblData.Name = "tblData";
            tblData.RowCount = 2;
            tblData.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblData.RowStyles.Add(new RowStyle());
            tblData.Size = new Size(432, 643);
            tblData.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.Location = new Point(323, 590);
            btnSave.Margin = new Padding(3, 15, 15, 15);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 38);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(3, 3);
            gData.Name = "gData";
            gData.RowHeadersWidth = 51;
            gData.Size = new Size(426, 569);
            gData.TabIndex = 1;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 649);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmDataMaintenance";
            Text = "Data Maintenance";
            tblMain.ResumeLayout(false);
            tblRadioButtons.ResumeLayout(false);
            tblRadioButtons.PerformLayout();
            tblData.ResumeLayout(false);
            tblData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblRadioButtons;
        private RadioButton optUsers;
        private RadioButton optCuisines;
        private RadioButton optIngredients;
        private RadioButton optMeasurements;
        private RadioButton optCourses;
        private TableLayoutPanel tblData;
        private Button btnSave;
        private DataGridView gData;
    }
}