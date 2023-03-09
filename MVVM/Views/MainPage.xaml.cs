namespace MVVM;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
    {
        (sender as ListView).SelectedItem = null;

        if (args.SelectedItem != null)
        {
            DataViewModel pageData = args.SelectedItem as DataViewModel;
            Page page = (Page)Activator.CreateInstance(pageData.Type);
            await Navigation.PushAsync(page);
        }
    }


}

