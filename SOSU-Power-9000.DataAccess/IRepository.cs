using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOSU_Power_9000.Entities;

namespace SOSU_Power_9000.DataAccess
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        IEnumerable<T> GetAll();
        T GetBy(int id);
    }

    public interface ITaskRepository : IRepository<Entities.Task>
    {
        IEnumerable<Entities.Task> GetTasksOnDate(DateTime date);
        IEnumerable<Entities.Task> GetTasksForEmployee(Employee employee);
        IEnumerable<Entities.Task> GetTasksForEmployeeByDate(int employeeId, DateTime date);
    }

    public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<Employee> GetEmployeeTasks(Entities.Task task);
    }
}
