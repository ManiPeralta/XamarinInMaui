namespace Xamarin;

public partial class GreetButtonPage : ContentPage
{
	Button greetButton;
	StackLayout layout = new();
	Label greetLabel;
	public GreetButtonPage()
	{
		InitializeComponent();
		greetButton = new()
		{
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			Text = "Greet"
		};

		greetLabel = new()
		{
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};

        greetButton.Clicked += GreetButton_Clicked;
		layout.Children.Add( greetButton );
		layout.Children.Add( greetLabel );
		Content = layout;
	}

    private void GreetButton_Clicked(object sender, EventArgs e)
    {
		greetLabel.Text = "Today is the day chacra!";
    }
}