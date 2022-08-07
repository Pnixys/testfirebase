
using testfirebase.Services;

namespace testfirebase;

public partial class MainPage : ContentPage
{
    int count = 0;
    private FirebaseCustomService fbService;

    public MainPage()
    {
        InitializeComponent();
        fbService = new FirebaseCustomService();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        //fbService.EventLogger();
        //throw new ArgumentNullException("THIS IS A TEST");

        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

