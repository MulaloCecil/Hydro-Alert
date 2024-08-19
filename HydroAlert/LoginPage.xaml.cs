
using HydroAlert.Views;
using TradeTalk.Services.TradeTalk.Services;

namespace HydroAlert;

public partial class LoginPage : ContentPage
{
    private readonly FirebaseAuthService _authService  = new FirebaseAuthService();
	public LoginPage()

	{
		InitializeComponent();
	}


    private void ShowPasswordCheckbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        passwordEntry.IsPassword = !e.Value;
    }
    private async void btnSignup_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Register());
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var email = EmailEntry.Text;
        var password = passwordEntry.Text;

        try
        {
            var token = await _authService.LoginAsync(email, password);
            await SecureStorage.SetAsync("firebase_token", token);
            await Navigation.PushAsync(new MainPage());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }

    }
}