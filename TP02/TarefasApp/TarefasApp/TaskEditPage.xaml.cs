// ---------------------------------------------------------------- //
// Nome do Arquivo: TaskEditPage.xaml.cs
// Projeto:         TarefasApp
// Autor:           Alice Marinho
// Criado em:       02/10/2025
// ---------------------------------------------------------------- //


using TarefasApp.Models;

namespace TarefasApp;

public partial class TaskEditPage : ContentPage
{
    private TaskItem task;

    public TaskEditPage(TaskItem task)
    {
        InitializeComponent();
        this.task = task;
        BindingContext = task;
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Sucesso!", "Tarefa editada com sucesso!!", "Ok");
        await Navigation.PopModalAsync();// volta mantendo alterações
        
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
    private async void OnSaveAndGoHomeClicked(object sender, EventArgs e)
    {

        var existingPages = Navigation.NavigationStack.ToList();

        foreach (var page in existingPages)
        {
            if (page is TaskDetail)
            {
                Navigation.RemovePage(page);
            }
        }

        await Navigation.PopAsync(); 
    }
}
