namespace RecipeWinForms
{
    partial class frmChangeRecipeStatus
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
            tblCurrentStatusInfo = new TableLayoutPanel();
            lblCurrentStatus = new Label();
            lblCurrentStatusResults = new Label();
            tblStatusDates = new TableLayoutPanel();
            lblStatusDates = new Label();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            txtDateDraft = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            tblButtons = new TableLayoutPanel();
            btnPublish = new Button();
            btnDraft = new Button();
            btnArchive = new Button();
            tblMain.SuspendLayout();
            tblCurrentStatusInfo.SuspendLayout();
            tblStatusDates.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(tblCurrentStatusInfo, 0, 1);
            tblMain.Controls.Add(tblStatusDates, 0, 2);
            tblMain.Controls.Add(tblButtons, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 17.9600887F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 17.9600887F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 27.9379158F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 36.5853653F));
            tblMain.Size = new Size(632, 451);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(626, 80);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblCurrentStatusInfo
            // 
            tblCurrentStatusInfo.ColumnCount = 2;
            tblCurrentStatusInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCurrentStatusInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCurrentStatusInfo.Controls.Add(lblCurrentStatus, 0, 0);
            tblCurrentStatusInfo.Controls.Add(lblCurrentStatusResults, 1, 0);
            tblCurrentStatusInfo.Dock = DockStyle.Fill;
            tblCurrentStatusInfo.Location = new Point(3, 83);
            tblCurrentStatusInfo.Name = "tblCurrentStatusInfo";
            tblCurrentStatusInfo.RowCount = 1;
            tblCurrentStatusInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCurrentStatusInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblCurrentStatusInfo.Size = new Size(626, 74);
            tblCurrentStatusInfo.TabIndex = 1;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Right;
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Location = new Point(174, 23);
            lblCurrentStatus.Margin = new Padding(3, 0, 0, 0);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(139, 28);
            lblCurrentStatus.TabIndex = 0;
            lblCurrentStatus.Text = "Current Status:";
            // 
            // lblCurrentStatusResults
            // 
            lblCurrentStatusResults.Anchor = AnchorStyles.Left;
            lblCurrentStatusResults.AutoSize = true;
            lblCurrentStatusResults.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentStatusResults.Location = new Point(313, 23);
            lblCurrentStatusResults.Margin = new Padding(0, 0, 3, 0);
            lblCurrentStatusResults.Name = "lblCurrentStatusResults";
            lblCurrentStatusResults.Size = new Size(0, 28);
            lblCurrentStatusResults.TabIndex = 1;
            // 
            // tblStatusDates
            // 
            tblStatusDates.ColumnCount = 5;
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.6984062F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.544178F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.544178F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.544178F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.6690636F));
            tblStatusDates.Controls.Add(lblStatusDates, 0, 1);
            tblStatusDates.Controls.Add(lblDrafted, 1, 0);
            tblStatusDates.Controls.Add(lblPublished, 2, 0);
            tblStatusDates.Controls.Add(lblArchived, 3, 0);
            tblStatusDates.Controls.Add(txtDateDraft, 1, 1);
            tblStatusDates.Controls.Add(txtDatePublished, 2, 1);
            tblStatusDates.Controls.Add(txtDateArchived, 3, 1);
            tblStatusDates.Dock = DockStyle.Fill;
            tblStatusDates.Location = new Point(3, 175);
            tblStatusDates.Margin = new Padding(3, 15, 3, 3);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 2;
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 49.1124268F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50.8875732F));
            tblStatusDates.Size = new Size(626, 107);
            tblStatusDates.TabIndex = 2;
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Right;
            lblStatusDates.AutoSize = true;
            lblStatusDates.Location = new Point(13, 65);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(119, 28);
            lblStatusDates.TabIndex = 0;
            lblStatusDates.Text = "Status Dates";
            // 
            // lblDrafted
            // 
            lblDrafted.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDrafted.AutoSize = true;
            lblDrafted.Location = new Point(138, 12);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(116, 28);
            lblDrafted.TabIndex = 1;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            lblPublished.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPublished.AutoSize = true;
            lblPublished.Location = new Point(260, 12);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(116, 28);
            lblPublished.TabIndex = 2;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblArchived.AutoSize = true;
            lblArchived.Location = new Point(382, 12);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(116, 28);
            lblArchived.TabIndex = 3;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDateDraft
            // 
            txtDateDraft.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDateDraft.Location = new Point(138, 62);
            txtDateDraft.Name = "txtDateDraft";
            txtDateDraft.ReadOnly = true;
            txtDateDraft.Size = new Size(116, 34);
            txtDateDraft.TabIndex = 4;
            txtDateDraft.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDatePublished.Location = new Point(260, 62);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(116, 34);
            txtDatePublished.TabIndex = 5;
            txtDatePublished.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDateArchived.Location = new Point(382, 62);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(116, 34);
            txtDateArchived.TabIndex = 6;
            txtDateArchived.TextAlign = HorizontalAlignment.Center;
            // 
            // tblButtons
            // 
            tblButtons.AutoSize = true;
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9999962F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tblButtons.Controls.Add(btnPublish, 1, 0);
            tblButtons.Controls.Add(btnDraft, 0, 0);
            tblButtons.Controls.Add(btnArchive, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 288);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(626, 160);
            tblButtons.TabIndex = 3;
            // 
            // btnPublish
            // 
            btnPublish.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnPublish.AutoSize = true;
            btnPublish.Location = new Point(227, 61);
            btnPublish.Margin = new Padding(15, 3, 15, 3);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(170, 38);
            btnPublish.TabIndex = 0;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnDraft
            // 
            btnDraft.Anchor = AnchorStyles.Right;
            btnDraft.AutoSize = true;
            btnDraft.Location = new Point(39, 61);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(170, 38);
            btnDraft.TabIndex = 1;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.Anchor = AnchorStyles.Left;
            btnArchive.AutoSize = true;
            btnArchive.Location = new Point(415, 61);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(170, 38);
            btnArchive.TabIndex = 2;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // frmChangeRecipeStatus
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 451);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmChangeRecipeStatus";
            Text = "Recipe - Change Status";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblCurrentStatusInfo.ResumeLayout(false);
            tblCurrentStatusInfo.PerformLayout();
            tblStatusDates.ResumeLayout(false);
            tblStatusDates.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private TableLayoutPanel tblCurrentStatusInfo;
        private Label lblCurrentStatus;
        private Label lblCurrentStatusResults;
        private TableLayoutPanel tblStatusDates;
        private Label lblStatusDates;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private TextBox txtDateDraft;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TableLayoutPanel tblButtons;
        private Button btnPublish;
        private Button btnDraft;
        private Button btnArchive;
    }
}