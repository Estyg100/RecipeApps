using System.Configuration;

namespace RecipeWinForms
{
    public partial class frmLogin : Form
    {

        bool loginsuccess = false;
        
        public frmLogin()
        {
            InitializeComponent();
            btnOK.Click += BtnOK_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        public bool ShowLogin()
        {
#if DEBUG
            this.Text = this.Text + " - DEV";
#endif
            this.ShowDialog();
            return loginsuccess;
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOK_Click(object? sender, EventArgs e)
        {
            try
            {
                string connstingkey = "";
#if DEBUG
                connstingkey = "devconn";
#else
                connstingkey = "liveconn";
#endif
                string connstring = ConfigurationManager.ConnectionStrings[connstingkey].ConnectionString;
                DBManager.SetConnectionString(connstring, true, txtUserId.Text, txtPassword.Text);
                loginsuccess = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid login. Try again.", Application.ProductName);
            }
        }
    }
}
