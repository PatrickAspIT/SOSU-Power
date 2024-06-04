namespace SOSU_Power_9000.Entities
{
    public class Employee
    {
        #region Fields
        private int employeeId;
        private List<Task> tasks;
        private List<Role> roles;
        private string name;
        //private CareCenter careCenter;
        #endregion

        #region Constructors
        //public Employee(int id, List<Task> tasks, List<Role> roles, string name, CareCenter careCenter)
        //{
        //    EmployeeId = id;
        //    Tasks = tasks;
        //    Roles = roles;
        //    Name = name;
        //    CareCenter = careCenter;
        //}
        #endregion

        #region Properties
        public int EmployeeId
        {
            get => employeeId;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value);
                if (employeeId != value)
                {
                    employeeId = value;
                }
            }
        }

        public List<Task> Tasks
        {
            get => tasks;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                if (tasks != value)
                {
                    tasks = value;
                }
            }
        }

        public List<Role> Roles
        {
            get => roles;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                if (roles != value)
                {
                    roles = value;
                }
            }
        }

        public string Name
        {
            get => name;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNullOrWhiteSpace(value);
                if (name != value)
                {
                    name = value;
                }
            }
        }

        //public CareCenter CareCenter
        //{
        //    get => careCenter;
        //    set
        //    {
        //        ArgumentNullException.ThrowIfNull(value);
        //        if (careCenter != value)
        //        {
        //            careCenter = value;
        //        }
        //    }
        //}
        #endregion
    }
}
