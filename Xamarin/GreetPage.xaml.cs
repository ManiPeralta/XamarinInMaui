namespace Xamarin;

public partial class GreetPage : ContentPage
{
	public GreetPage()
	{
		InitializeComponent();
		
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        //DisplayAlert("Greet", "Hola a todos!", "OK");
        showMessageLabel.Text = "Hola cabron!";
    }
}