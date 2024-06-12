namespace SOSU_Power_9000.CareApp;

public partial class UserPage : ContentPage
{
	public UserPage(string userInput)
	{
		InitializeComponent();
		UserName.Text = userInput;
	}
}