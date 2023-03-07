namespace Xamarin;

public partial class MainPage : ContentPage
{
    //Button greetButton;
    //StackLayout layout = new();
    int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);

        //greetButton = new Button()
        //{
        //    HorizontalOptions = LayoutOptions.Center,
        //    VerticalOptions = LayoutOptions.CenterAndExpand,
        //    Text = "Greet"
        //};
        //greetButton.Clicked += GreetButton_Clicked;
        //layout.Children.Add(greetButton);
        //Content = layout;
    }

    //private void GreetButton_Clicked(object sender, EventArgs e)
    //{
    //    DisplayAlert("Greet", "Hola amigos", "OK");
    //}

    //private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    //{
    //    double value = e.NewValue;
    //    rotatingLabel.Rotation = value;
    //    sliderValue.Text = value.ToString();
    //}

}

