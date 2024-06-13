namespace SOSU_Power_9000.Entities
{
    public class CareCenter
    {
        #region Fields
        private int careCenterId;
        private string name;
        private Address address;
        private List<Resident> residents;
        private List<Employee> employees;
        #endregion

        #region Constructors
        //public CareCenter(int id, string name, Address address, List<Resident> residents)
        //{
        //    CareCenterId = id;
        //    Name = name;
        //    Address = address;
        //    Residents = residents;
        //}
        #endregion

        #region Properties
        /// <summary>
        /// Simple incapsulation of the careCenterId, name, address, residents, and employees fields.
        /// </summary>
        public int CareCenterId
        {
            get => careCenterId;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value);
                if (careCenterId != value)
                {
                    careCenterId = value;
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

        public Address Address
        {
            get => address;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                if (address != value)
                {
                    address = value;
                }
            }
        }

        public List<Resident> Residents
        {
            get => residents;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                if (residents != value)
                {
                    residents = value;
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
        #endregion
    }
}
