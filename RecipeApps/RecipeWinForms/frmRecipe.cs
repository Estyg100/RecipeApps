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
using CPUFramework;
using CPUWindowsFormsFramework;

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
            string sql = "select r.*, u.UserName, c.CuisineName from Recipe r join Cuisine c on c.CuisineId = r.CuisineId  join users u on u.UsersId = r.UsersId where r.RecipeId = " + recipeid.ToString();
            dtRecipe = SQLUtility.GetDataTable(sql);
            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtCuisineName = SQLUtility.GetDataTable("select CuisineId, CuisineName from cuisine");
            DataTable dtUserName = SQLUtility.GetDataTable("select UsersId, UserName from users");
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
            SQLUtility.DEbugPrintDataTable(dtRecipe);
            DataRow r = dtRecipe.Rows[0];
            string sql = "";
            int id = (int)r["RecipeId"];
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine,
                $"update Recipe set",
                $"UsersId = '{r["UsersId"]}',",
                $"CuisineId = '{r["CuisineId"]}',",
                $"RecipeName = '{r["RecipeName"]}',",
                $"CaloriesPerServing = {r["CaloriesPerServing"]},",
                $"DateDraft = '{r["DateDraft"]}'",
                $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert Recipe (UsersId, RecipeName, CuisineId, CaloriesPerServing, DateDraft) ";
                sql += $"select '{r["UsersId"]}', '{r["RecipeName"]}', '{r["CuisineId"]}', {r["CaloriesPerServing"]}, '{r["DateDraft"]}'";
            }
            Debug.Print("-----------------");
            SQLUtility.ExecuteSQL(sql);
        }

        private void Delete()
        {
            int id = (int)dtRecipe.Rows[0]["RecipeId"];
            string sql = "delete Recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
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
