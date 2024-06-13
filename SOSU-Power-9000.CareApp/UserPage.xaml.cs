namespace SOSU_Power_9000.CareApp;

public partial class UserPage : ContentPage
{
	/// <summary>
	/// Constructor for the UserPage.
	/// Simply sets the username to the input string.
	/// </summary>
	/// <param name="userInput"></param>
	public UserPage(string userInput)
	{
		InitializeComponent();
		UserName.Text = userInput;
	}
}