using SOSU_Power_9000.Services;

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
            string name = UserId.Text;

            if (string.IsNullOrEmpty(name))
            {
                await DisplayAlert("Error", "Please enter a user id", "OK");
                return;
            }

            //CareAppMethods careAppMethods = new CareAppMethods();
            //string name = await careAppMethods.GetNameByIdAsync(userId);

            //UserId.Text = name;

            await Navigation.PushAsync(new UserPage(name));
        }

        private void UserId_Completed(object sender, EventArgs e)
        {
            LoginBtn_Clicked(sender, e);
        }
    }
}
