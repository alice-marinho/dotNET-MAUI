// ---------------------------------------------------------------- //
// Nome do Arquivo: TaskAddPage.xaml.cs
// Projeto:         TarefasApp
// Autor:           Alice Marinho
// Criado em:       02/10/2025
// ---------------------------------------------------------------- //

using TarefasApp.Models;
using System.Collections.ObjectModel;

namespace TarefasApp;

public partial class TaskAddPage : ContentPage
{
    private ObservableCollection<TaskItem> tasks;

    public TaskAddPage(ObservableCollection<TaskItem> tasks)
    {
        InitializeComponent();
        this.tasks = tasks;
    }

    private async void OnAddClicked(object sender, EventArgs e)
    {
        var newTask = new TaskItem
        {
            Title = TitleEntry.Text ?? "Sem título",
            Description = DescriptionEditor.Text ?? "",
            CreationDate = DatePicker.Date,
            Priority = PriorityPicker.SelectedItem?.ToString() ?? "Normal"
        };

        tasks.Add(newTask);
        await Navigation.PopModalAsync();
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}
