namespace Xamarin;

public partial class RotatingTextPage : ContentPage
{
	public RotatingTextPage()
	{
		InitializeComponent();
	}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		double value = e.NewValue;
		rotatingLabel.Rotation = value;
		sliderValue.Text = value.ToString();
    }
}