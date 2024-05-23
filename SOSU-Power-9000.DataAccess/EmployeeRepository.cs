using SOSU_Power_9000.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSU_Power_9000.DataAccess
{
    public class EmployeeRepository(DataContext dataContext) : Repository<Employee>(dataContext), IEmployeeRepository
    {
        public IEnumerable<Employee> GetEmployeeTasks(Entities.Task task)
        {
            return dataContext.Employee.Where(a => a.Tasks.Contains(task));
        }
    }
}
