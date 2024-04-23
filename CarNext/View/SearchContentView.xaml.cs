namespace CarNext.View;

public partial class SearchContentView : ListView
{
	public SearchContentView()
	{
		InitializeComponent();
	}

    void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        SelectedItem = null;
    }
}