namespace SOSU_Power_9000.CareApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LoginBtn_Clicked(object sender, EventArgs e)
        {
            string userId = UserId.Text;
            
            if (string.IsNullOrEmpty(userId))
            {
                await DisplayAlert("Error", "Please enter a user id", "OK");
                return;
            }

            await Navigation.PushAsync(new UserPage(userId));
        }
    }
}
