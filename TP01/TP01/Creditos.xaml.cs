namespace TP01;

public partial class Creditos : ContentPage
{
	public Creditos()
	{
		InitializeComponent();
	}

    private async void Voltar(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}