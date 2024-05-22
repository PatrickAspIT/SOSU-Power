namespace SOSU_Power_9000.Entities
{
    public class Task
    {
        #region Fields and constants
        public readonly DateTime EarliestDateTime = new DateTime(2000, 1, 1);

        private int taskId;
        private string name;
        private DateTime timeStart;
        private DateTime timeEnd;
        private Resident resident;
        private List<Employee> employees;
        private List<Medicine> medicines;
        private bool isCompleted;
        private string note;
        #endregion

        #region Constructors
        public Task(int id, string name, DateTime timeStart, DateTime timeEnd, Resident resident, List<Employee> employees, List<Medicine> medicines, bool isCompleted, string note)
        {
            TaskId = id;
            Name = name;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
            Resident = resident;
            Employees = employees;
            Medicines = medicines;
            IsCompleted = isCompleted;
            Note = note;
        }
        #endregion

        #region Properties
        public int TaskId
        {
            get => taskId;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value);
                if (taskId != value)
                {
                    taskId = value;
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

        public DateTime TimeStart
        {
            get => timeStart;
            set
            { 
                ArgumentOutOfRangeException.ThrowIfLessThan(value, EarliestDateTime);
                if (timeStart != value)
                {
                    timeStart = value;
                }
            }
        }

        public DateTime TimeEnd
        {
            get => timeEnd;
            set
            {
                if (timeEnd != value)
                {
                    timeEnd = value;
                }
            }
        }

        public Resident Resident
        {
            get => resident;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                if (resident != value)
                {
                    resident = value;
                }
            }
        }

        public List<Employee> Employees
        {
            get => employees;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                if (employees != value)
                {
                    employees = value;
                }
            }
        }

        public List<Medicine> Medicines
        {
            get => medicines;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                if (medicines != value)
                {
                    medicines = value;
                }
            }
        }

        public bool IsCompleted
        {
            get => isCompleted;
            set
            {
                if (isCompleted != value)
                {
                    isCompleted = value;
                }
            }
        }

        public string Note
        {
            get => note;
            set
            {
                if (note != value)
                {
                    note = value;
                }
            }
        }
        #endregion
    }
}
