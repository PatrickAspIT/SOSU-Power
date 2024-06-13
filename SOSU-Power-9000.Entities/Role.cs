namespace SOSU_Power_9000.Entities
{
    public class Role
    {
        #region Fields
        private int roleId;
        private string roleName;
        private List<Employee> employees;
        #endregion

        #region Constructors
        //public Role(int id, string roleName)
        //{
        //    RoleId = id;
        //    RoleName = roleName;
        //}
        #endregion

        #region Properties
        /// <summary>
        /// Simple incapsulation of roleId, roleName and employees fields.
        /// </summary>
        public int RoleId
        {
            get => roleId;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value);
                if (roleId != value)
                {
                    roleId = value;
                }
            }
        }

        public string RoleName
        {
            get => roleName;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNullOrWhiteSpace(value);
                if (roleName != value)
                {
                    roleName = value;
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
