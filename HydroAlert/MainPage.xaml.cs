namespace HydroAlert
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void CounterBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }

}
