using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    
    public partial class frmRecipe : Form
    {
        DataTable dtRecipe;
        
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        public void ShowForm(int recipeid)
        {
            dtRecipe = Recipe.Load(recipeid);
            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtUserName = Recipe.GetUserList();
            DataTable dtCuisineName = Recipe.GetCuisineList();
            WindowsFormsUtility.SetListBinding(lstUserName, dtUserName, dtRecipe, "users");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtRecipe);
            WindowsFormsUtility.SetListBinding(lstCuisineName, dtCuisineName, dtRecipe, "cuisine");
            WindowsFormsUtility.SetControlBinding(txtCaloriesPerServing, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtDateDraft, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, dtRecipe);
            this.Show();
        }

        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                if ((int)dtRecipe.Rows[0]["RecipeId"] == 0 && txtDateDraft.Text == "")
                {
                    txtDateDraft.Text = DateTime.Now.ToString();
                }
                Recipe.Save(dtRecipe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hearty Hearth");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            
        }

        private void Delete()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtRecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HeartyHearth");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

    }
}
