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
            Title = "SOSU Power 9000";
            this.sosuService = sosuService;
        }

        private async void UpdateTasks(int employeeId)
        {
            TodaysTasks.Clear();

            var result = await sosuService.GetTasksForAsync(new DateTime(2024, 05, 24), new Employee() { EmployeeId = employeeId });
            foreach (var task in result) 
            {
                TodaysTasks.Add(task);
            }
        }
    }
}
