using RecipeSystem;
using System.Data;

namespace RecipeMAUI;

public partial class RecipeList : ContentPage
{
	public RecipeList()
	{
		InitializeComponent();
        this.Loaded += RecipeList_Loaded;
	}

    private void RecipeList_Loaded(object? sender, EventArgs e)
    {
        GetRecipeList();
    }

    private void GetRecipeList()
    {
        DataTable dt = HeartyHearthGeneral.GetList("Recipe");
        RecipeLst.ItemsSource = dt.Rows;
    }

}