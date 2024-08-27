namespace RecipeWinForms
{
    partial class frmLogin
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
            lblUserId = new Label();
            txtUserId = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            tblButtons = new TableLayoutPanel();
            btnOK = new Button();
            btnCancel = new Button();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.Controls.Add(lblUserId, 0, 0);
            tblMain.Controls.Add(txtUserId, 1, 0);
            tblMain.Controls.Add(lblPassword, 0, 1);
            tblMain.Controls.Add(txtPassword, 1, 1);
            tblMain.Controls.Add(tblButtons, 1, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblMain.Size = new Size(385, 195);
            tblMain.TabIndex = 0;
            // 
            // lblUserId
            // 
            lblUserId.Anchor = AnchorStyles.Left;
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(3, 18);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(103, 28);
            lblUserId.TabIndex = 0;
            lblUserId.Text = "UserName";
            // 
            // txtUserId
            // 
            txtUserId.Anchor = AnchorStyles.Left;
            txtUserId.Location = new Point(112, 15);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(230, 34);
            txtUserId.TabIndex = 1;
            txtUserId.Text = "appadmin";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Left;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(3, 82);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 28);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left;
            txtPassword.Location = new Point(112, 79);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(230, 34);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "HELlo753(!)";
            // 
            // tblButtons
            // 
            tblButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tblButtons.AutoSize = true;
            tblButtons.ColumnCount = 2;
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.Controls.Add(btnOK, 0, 0);
            tblButtons.Controls.Add(btnCancel, 1, 0);
            tblButtons.Location = new Point(182, 148);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblButtons.Size = new Size(200, 44);
            tblButtons.TabIndex = 4;
            // 
            // btnOK
            // 
            btnOK.AutoSize = true;
            btnOK.Location = new Point(3, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 38);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.Location = new Point(103, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 38);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 195);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmLogin";
            Text = "Hearty Hearth Login";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblUserId;
        private TextBox txtUserId;
        private Label lblPassword;
        private TextBox txtPassword;
        private TableLayoutPanel tblButtons;
        private Button btnOK;
        private Button btnCancel;
    }
}