using SOSU_Power_9000.CareApp.ViewModels;
using SOSU_Power_9000.Services;

namespace SOSU_Power_9000.CareApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        /// <summary>
        /// When the login button is clicked, the user is navigated to the UserPage with the inputted userId.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void LoginBtn_Clicked(object sender, EventArgs e)
        {
            string name = UserId.Text;

            if (string.IsNullOrEmpty(name))
            {
                await DisplayAlert("Error", "Please enter a user id", "OK");
                return;
            }

            // Navigate to the UserPage with the inputted userId.
            await Navigation.PushAsync(new UserPage(name));
        }

        /// <summary>
        /// When the user presses enter in the userId entry, the login button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserId_Completed(object sender, EventArgs e)
        {
            LoginBtn_Clicked(sender, e);
        }
    }
}
