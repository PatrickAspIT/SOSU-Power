using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSU_Power_9000.DataAccess
{
    public class TaskRepository(DataContext dataContext) : Repository<Task>(dataContext), ITaskRepository
    {
        public IEnumerable<Task> GetTasksForDate(DateTime date)
        {
            return default;
            //return dataContext.Task.Where(a => a.TimeStart == date.Date);
        }

        public IEnumerable<Task> GetTasksForEmployee(int employeeId)
        {
            return default;
        }
    }
}
