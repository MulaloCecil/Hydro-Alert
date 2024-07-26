namespace HydroAlert;

public partial class LoginPage : ContentPage
{
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
}