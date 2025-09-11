namespace TP01
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        public void Verification(object sender, EventArgs e)
        {
            string id = EntryId.Text;
            string pass = EntryPass.Text;


            if (id.Trim() == "admin" && pass.Trim() == "senha@dmin")
            {
                DisplayAlert("Login", $"Acesso permitido! \nSenha digitada: {pass}", "OK");

            }
            else {
                DisplayAlert("Login", $"Acesso negado! \nSenha digitada: {pass}", "OK");
            }

        }

        public void Clean(object sender, EventArgs e)
        {
            EntryId.Text = "";
            EntryPass.Text = string.Empty;

            EntryId.Focus();
        }

        private async void Creditos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Creditos());
        }


    }
}
