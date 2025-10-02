// ---------------------------------------------------------------- //
// Nome do Arquivo: App.xaml.cs
// Projeto:         TarefasApp
// Autor:           Alice Marinho
// Criado em:       02/10/2025
// ---------------------------------------------------------------- //

namespace TarefasApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}