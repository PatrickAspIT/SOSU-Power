﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SOSU_Power_9000.Entities;

namespace SOSU_Power_9000.DataAccess
{
    /// <summary>
    /// Inherits from ITaskRepository which is a interface.
    /// Implements the inherited methods.
    /// </summary>
    /// <param name="dataContext"></param>
    public class TaskRepository(DataContext dataContext) : Repository<Entities.Task>(dataContext), ITaskRepository
    {
        public IEnumerable<Entities.Task> GetTasksForEmployee(Employee employee)
        {
            return dataContext.Task.Where(a => a.Employees.Contains(employee));
        }

        public IEnumerable<Entities.Task> GetTasksForEmployeeByDate(int employeeId, DateTime date)
        {
            Employee employee = dataContext.Employee.Find(employeeId);
            return dataContext.Task.Where(a => a.TimeStart == date.Date);
        }

        public IEnumerable<Entities.Task> GetTasksOnDate(DateTime date)
        {
            return dataContext.Task.Where(a => a.TimeStart == date.Date);
        }

        public override Entities.Task GetBy(int id)
        {
            return dataContext.Task.Include(a => a.Employees).FirstOrDefault(a => a.TaskId == id);
        }
    }
}
