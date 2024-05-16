namespace SOSU_Power_9000.Entities
{
    public class CareCenter
    {
        #region Fields
        private int careCenterId;
        private string name;
        private Address address;
        private List<Resident> residents;
        #endregion

        #region Constructors
        //public CareCenter(int id, string name, Address address, List<Resident> residents)
        //{
        //    this.careCenterId = id;
        //    this.name = name;
        //    this.address = address;
        //    this.residents = residents;
        //}
        #endregion

        #region Properties
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
        #endregion
    }
}
