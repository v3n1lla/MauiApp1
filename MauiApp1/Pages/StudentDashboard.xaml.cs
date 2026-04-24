namespace MauiApp1.Pages;

public partial class StudentDashboard : ContentPage
{
	public StudentDashboard()
	{
		InitializeComponent();
	}
    private async void OnBookSlotClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Booking");
    }

    private async void OnManageSlotsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//ManagedSlots");
    }
}