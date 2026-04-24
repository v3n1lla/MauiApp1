namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ErrorLabel.Text = "Please fill in all Requirements.";
                ErrorLabel.IsVisible = true;
                return;
            }

            // Replace this with your actual authentication logic
            if (email == "@gmail" && password == "1234")
            {
                await Shell.Current.GoToAsync("//Home");
            }
            else
            {
                ErrorLabel.Text = "Invalid email or password.";
                ErrorLabel.IsVisible = true;
            }
        }
    }
}
