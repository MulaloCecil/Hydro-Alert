using TradeTalk.Services.TradeTalk.Services;

namespace HydroAlert;

public partial class Register : ContentPage
{
	public readonly FirebaseAuthService _authService = new FirebaseAuthService();
	public Register()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var fullName = FullNameEntry.Text;
        var email = EmailEntry.Text;
        var password = PasswordEntry.Text;
        var confirmPassword = ConfirmPasswordEntry.Text;
        var phoneNumber = PhoneNumberEntry.Text;




        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(phoneNumber))
        {
            await DisplayAlert("Error", "Please fill in all the required fields.", "OK");
            return;
        }

        if (password != confirmPassword)
        {
            await DisplayAlert("Error", "Passwords do not match.", "OK");
            return;
        }

        try
        {
            await _authService.RegisterAsync(email, password);
            // Here, you can save the additional user information (username, fullName, phoneNumber, dateOfBirth) to the database or perform any other necessary actions
            await DisplayAlert("Success", "Registration successful", "OK");
            await Navigation.PushAsync(new LoginPage());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
       // await Navigation.PushAsync(new LoginPage());
        await Navigation.PopModalAsync();
    }

    private void showPasswordCheckbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        PasswordEntry.IsPassword = !e.Value;
        ConfirmPasswordEntry.IsPassword = !e.Value;
    }
}