using System.Collections.ObjectModel;
using TarefasApp.Models;


namespace TarefasApp;

// ---------------------------------------------------------------- //
// Nome do Arquivo: TaskDetail.xaml.cs
// Projeto:         TarefasApp
// Autor:           Alice Marinho
// Criado em:       02/10/2025
// ---------------------------------------------------------------- //


public partial class TaskDetail : ContentPage
{
	private TaskItem task;
	private ObservableCollection<TaskItem> tasks;
	public TaskDetail(TaskItem task, ObservableCollection<TaskItem> tasks)
	{
        InitializeComponent();
        this.task = task;
        this.tasks = tasks;
        BindingContext = task;
    }

    private async void OnEditClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new TaskEditPage(task));
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        bool confirm = await DisplayAlert("Confirmação", "Deseja excluir esta tarefa?", "Sim", "Não");
        if (confirm)
        {
            tasks.Remove(task);
            await Navigation.PopAsync();
        }
    }

}