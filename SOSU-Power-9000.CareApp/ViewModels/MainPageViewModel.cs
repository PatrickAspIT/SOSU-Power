using SOSU_Power_9000.Entities;
using SOSU_Power_9000.Services;

using System.Collections.ObjectModel;

namespace SOSU_Power_9000.CareApp.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        private readonly ISosuService sosuService;

        public ObservableCollection<Entites.Task> TodaysTask { get; } = new();

        public MainPageViewModel(ISosuService sosuService)
        {
            Title = "FORSIDEN";
            this.sosuService = sosuService;
            UpdateTasks();
        }
    }
}