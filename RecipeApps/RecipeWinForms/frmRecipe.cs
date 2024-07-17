using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPUFramework;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        public void ShowForm(int recipeid)
        {
            string sql = "select r.*, c.CuisineName from Recipe r join Cuisine c on c.CuisineId = r.CuisineId where r.RecipeId = " + recipeid.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            txtRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            txtCuisine.DataBindings.Add("Text", dt, "CuisineName");
            txtCaloriesPerServing.DataBindings.Add("Text", dt, "CaloriesPerServing");
            txtDateDraft.DataBindings.Add("Text", dt, "DateDraft");
            txtDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            txtDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            this.Show();
        }

        

    }
}
