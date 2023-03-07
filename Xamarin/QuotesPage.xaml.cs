using Microsoft.Maui.Graphics.Converters;

namespace Xamarin;

public partial class QuotesPage : ContentPage
{
    int counter =1;
    string[] einsteinQuotes = new string[]
    {
        "Imagination is more important than knowledge.",
        "The important thing is not to stop questioning. Curiosity has its own reason for existing.",
        "Try not to become a man of success, but rather try to become a man of value.",
        "If you can't explain it simply, you don't understand it well enough.",
        "The difference between stupidity and genius is that genius has its limits.",
        "Education is not the learning of facts, but the training of the mind to think.",
        "Logic will get you from A to B. Imagination will take you everywhere.",
        "A person who never made a mistake never tried anything new.",
        "I have no special talent. I am only passionately curious.",
        "Science without religion is lame, religion without science is blind.",
        "Peace cannot be kept by force; it can only be achieved by understanding.",
        "The most beautiful thing we can experience is the mysterious. It is the source of all true art and all science.",
        "We cannot solve our problems with the same thinking we used when we created them.",
        "We should take care not to make the intellect our god; it has, of course, powerful muscles, but no personality.",
        "The true sign of intelligence is not knowledge but imagination.",
        "The important thing is not to stop questioning. Curiosity has its own reason for existing.",
        "Reality is merely an illusion, albeit a very persistent one.",
        "The only source of knowledge is experience.",
        "In the middle of difficulty lies opportunity.",
        "You cannot simultaneously prevent and prepare for war."
    };
    string[] colors = { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Pink", "Brown", "Black", "lightCoral", "Gray", "Silver", "Gold" };
	public QuotesPage()
	{  
        InitializeComponent();
        quoteLabel.Text = einsteinQuotes[0];
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if(counter == einsteinQuotes.Length)
        {
            counter = 0;
        }
        quoteLabel.Text = einsteinQuotes[counter];
        counter++;
    }
    private void NexQuote(int next)
    {
        // this renders quotes randomly
        //Random rand = new Random();        
        //quoteLabel.Text = einsteinQuotes[rand.Next(einsteinQuotes.Length)];        
    }

    private void fontSizeSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        int fontSize = (int)Math.Ceiling(value);
        quoteLabel.FontSize = fontSize;
        fontSizeLabel.Text = $"Font size: {fontSize}";
    }

    private void fontColourSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        var coloursLength = colors.Length-1;
        int value = (int)e.NewValue;

        ColorTypeConverter converter = new ColorTypeConverter();
        fontColourSlider.Maximum = coloursLength;
        quoteLabel.TextColor = (Color)(converter.ConvertFromInvariantString(colors[value]));
    }
}