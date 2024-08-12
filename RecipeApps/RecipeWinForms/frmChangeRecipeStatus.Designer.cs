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
            lblCurrentStatusText = new Label();
            lblCurrentStatus = new Label();
            tblStatusDates = new TableLayoutPanel();
            lblStatusDates = new Label();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            lblDateDraft = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
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
            lblRecipeName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRecipeName.AutoSize = true;
            lblRecipeName.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecipeName.Location = new Point(3, 20);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(626, 60);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblCurrentStatusInfo
            // 
            tblCurrentStatusInfo.ColumnCount = 2;
            tblCurrentStatusInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCurrentStatusInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCurrentStatusInfo.Controls.Add(lblCurrentStatusText, 0, 0);
            tblCurrentStatusInfo.Controls.Add(lblCurrentStatus, 1, 0);
            tblCurrentStatusInfo.Dock = DockStyle.Fill;
            tblCurrentStatusInfo.Location = new Point(3, 83);
            tblCurrentStatusInfo.Name = "tblCurrentStatusInfo";
            tblCurrentStatusInfo.RowCount = 1;
            tblCurrentStatusInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCurrentStatusInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblCurrentStatusInfo.Size = new Size(626, 74);
            tblCurrentStatusInfo.TabIndex = 1;
            // 
            // lblCurrentStatusText
            // 
            lblCurrentStatusText.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCurrentStatusText.AutoSize = true;
            lblCurrentStatusText.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentStatusText.Location = new Point(150, 43);
            lblCurrentStatusText.Margin = new Padding(3, 0, 0, 0);
            lblCurrentStatusText.Name = "lblCurrentStatusText";
            lblCurrentStatusText.Size = new Size(163, 31);
            lblCurrentStatusText.TabIndex = 0;
            lblCurrentStatusText.Text = "Current Status:";
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentStatus.Location = new Point(313, 43);
            lblCurrentStatus.Margin = new Padding(0, 0, 3, 0);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(0, 31);
            lblCurrentStatus.TabIndex = 1;
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
            tblStatusDates.Controls.Add(lblDateDraft, 1, 1);
            tblStatusDates.Controls.Add(lblDatePublished, 2, 1);
            tblStatusDates.Controls.Add(lblDateArchived, 3, 1);
            tblStatusDates.Dock = DockStyle.Fill;
            tblStatusDates.Location = new Point(3, 163);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 2;
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 49.1124268F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50.8875732F));
            tblStatusDates.Size = new Size(626, 119);
            tblStatusDates.TabIndex = 2;
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatusDates.AutoSize = true;
            lblStatusDates.Location = new Point(13, 58);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(119, 28);
            lblStatusDates.TabIndex = 0;
            lblStatusDates.Text = "Status Dates";
            // 
            // lblDrafted
            // 
            lblDrafted.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDrafted.AutoSize = true;
            lblDrafted.Location = new Point(138, 30);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(116, 28);
            lblDrafted.TabIndex = 1;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            lblPublished.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPublished.AutoSize = true;
            lblPublished.Location = new Point(260, 30);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(116, 28);
            lblPublished.TabIndex = 2;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblArchived.AutoSize = true;
            lblArchived.Location = new Point(382, 30);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(116, 28);
            lblArchived.TabIndex = 3;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateDraft
            // 
            lblDateDraft.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDateDraft.AutoSize = true;
            lblDateDraft.BackColor = SystemColors.Window;
            lblDateDraft.BorderStyle = BorderStyle.FixedSingle;
            lblDateDraft.ForeColor = Color.DarkSlateBlue;
            lblDateDraft.Location = new Point(138, 58);
            lblDateDraft.Name = "lblDateDraft";
            lblDateDraft.Size = new Size(116, 30);
            lblDateDraft.TabIndex = 4;
            lblDateDraft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDatePublished.AutoSize = true;
            lblDatePublished.BackColor = SystemColors.Window;
            lblDatePublished.BorderStyle = BorderStyle.FixedSingle;
            lblDatePublished.ForeColor = Color.DarkSlateBlue;
            lblDatePublished.Location = new Point(260, 58);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(116, 30);
            lblDatePublished.TabIndex = 5;
            lblDatePublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateArchived
            // 
            lblDateArchived.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDateArchived.AutoSize = true;
            lblDateArchived.BackColor = SystemColors.Window;
            lblDateArchived.BorderStyle = BorderStyle.FixedSingle;
            lblDateArchived.ForeColor = Color.DarkSlateBlue;
            lblDateArchived.Location = new Point(382, 58);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(116, 30);
            lblDateArchived.TabIndex = 6;
            lblDateArchived.TextAlign = ContentAlignment.MiddleCenter;
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
            btnPublish.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPublish.AutoSize = true;
            btnPublish.ForeColor = Color.DarkSlateBlue;
            btnPublish.Location = new Point(227, 3);
            btnPublish.Margin = new Padding(15, 3, 15, 3);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(170, 38);
            btnPublish.TabIndex = 1;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnDraft
            // 
            btnDraft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDraft.AutoSize = true;
            btnDraft.ForeColor = Color.DarkSlateBlue;
            btnDraft.Location = new Point(39, 3);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(170, 38);
            btnDraft.TabIndex = 0;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.AutoSize = true;
            btnArchive.ForeColor = Color.DarkSlateBlue;
            btnArchive.Location = new Point(415, 3);
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
            BackColor = Color.Lavender;
            ClientSize = new Size(632, 451);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
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
        private Label lblCurrentStatusText;
        private Label lblCurrentStatus;
        private TableLayoutPanel tblStatusDates;
        private Label lblStatusDates;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private TableLayoutPanel tblButtons;
        private Button btnPublish;
        private Button btnDraft;
        private Button btnArchive;
        private Label lblDateDraft;
        private Label lblDatePublished;
        private Label lblDateArchived;
    }
}