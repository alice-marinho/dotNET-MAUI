// ---------------------------------------------------------------- //
// Nome do Arquivo: MainPage.xaml.cs
// Projeto:         TarefasApp
// Autor:           Alice Marinho
// Criado em:       02/10/2025
// ---------------------------------------------------------------- //


using System.Collections.ObjectModel;
using System.ComponentModel;
using TarefasApp.Models;


namespace TarefasApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public ObservableCollection<TaskItem> Tasks { get; set; }
        public MainPage()
        {
            InitializeComponent();

            Tasks = new ObservableCollection<TaskItem>
            {
                new TaskItem {Title = "Prova", Description= "Prova de gramática sobre tempos verbais", Priority="Alta"},
                new TaskItem{Title="Ir ao mercado", Description="Comprar frutas, verduras e carne.", Priority="Media"}
            };

            BindingContext = this;
        }

        public async void OnAddTaskClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TaskAddPage(Tasks));
        }

        public async void OnTaskSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is TaskItem selectedTask)
            {
                await Navigation.PushAsync(new TaskDetail(selectedTask, Tasks));
            }
        }
    }
}
