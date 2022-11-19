namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    async void OnCounterClicked(object sender, EventArgs e)
    {
        try
        {
            WebAuthenticatorResult authResult = await WebAuthenticator.Default.AuthenticateAsync(
                //copy first URL from https://openidconnect.net/
                new Uri("https://samples.auth0.com/authorize?client_id=kbyuFDidLLm280LIwVFiazOqjO3ty8KH&redirect_uri=https://openidconnect.net/callback&scope=openid profile email phone address&response_type=code&state=cacd4a6f8fc20c1c8b19b4947c04a9137d60ba0d"),
                new Uri("myapp://"));
        }
        catch (TaskCanceledException)
        {

        }

        //this throws exception
        Application.Current.MainPage = new DifferentPage();
    }
}