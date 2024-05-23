using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOSU_Power_9000.Entities;

namespace SOSU_Power_9000.DataAccess
{
    public class TaskRepository(DataContext dataContext) : Repository<Entities.Task>(dataContext), ITaskRepository
    {
        public IEnumerable<Entities.Task> GetTasksForEmployee(Employee employee)
        {
            return dataContext.Task.Where(a => a.Employees.Contains(employee));
        }

        public IEnumerable<Entities.Task> GetTasksOnDate(DateTime date)
        {
            return dataContext.Task.Where(a => a.TimeStart == date.Date);
        }        
    }
}
