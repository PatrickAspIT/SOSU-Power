using SOSU_Power_9000.Services;
using SOSU_Power_9000.Entities;

using System.Collections.ObjectModel;

namespace SOSU_Power_9000.CareApp.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        private readonly ISosuService sosuService;

        public ObservableCollection<Entities.Task> TodaysTasks { get; } = new();

        public MainPageViewModel(ISosuService sosuService)
        {
            Title = "FORSIDEN";
            this.sosuService = sosuService;
            UpdateTasks();
        }

        private async void UpdateTasks()
        {
            TodaysTasks.Clear();

            var result = await sosuService.GetTasksForAsync(new DateTime(2024, 05, 24), new Employee() { EmployeeId = 2000 });
            foreach (var task in result) 
            {
                TodaysTasks.Add(task);
            }
        }
    }
}
