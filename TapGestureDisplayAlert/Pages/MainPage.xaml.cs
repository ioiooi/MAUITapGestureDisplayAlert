namespace TapGestureDisplayAlert.Pages;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");

        Console.WriteLine("Button clicked. Answer: " + answer.ToString());
    }

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");

        Console.WriteLine("Label tapped. Answer: " + answer.ToString());
    }
}
