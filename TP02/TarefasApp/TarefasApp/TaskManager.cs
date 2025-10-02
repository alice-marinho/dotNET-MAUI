// ---------------------------------------------------------------- //
// Nome do Arquivo: TaskManager.xaml.cs
// Projeto:         TarefasApp
// Autor:           Alice Marinho
// Criado em:       02/10/2025
// ---------------------------------------------------------------- //



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace TarefasApp.Models
{
    public class TaskItem: INotifyPropertyChanged
    {
        private string? title;
        private string? description;
        private DateTime creationDate;
        private string priority;

        public string Title
        {
            get => title;
            set { if (value == title) return; title = value; OnPropertyChanged(); }
        }

        public string Description
        {
            get => description;
            set { if (value == description) return; description = value; OnPropertyChanged(); }
        }

        public DateTime CreationDate
        {
            get => creationDate;
            set { if (value == creationDate) return; creationDate = value; OnPropertyChanged(); }
        }

        public string Priority
        {
            get => priority;
            set { if (value == priority) return; priority = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

}
