namespace SOSU_Power_9000.Entities
{
    public class Resident
    {
        #region Fields
        private int residentId;
        private string name;
        private string roomNumber;

        // Maybe add these later
        //private string List<Diagnosis>;
        //private string List<Prescription>;
        private string note;
        #endregion

        #region Constructors
        //public Resident(int id, string name, string roomNumber, string notes)
        //{
        //    ResidentId = id;
        //    Name = name;
        //    RoomNumber = roomNumber;
        //    Notes = notes;
        //}
        #endregion

        #region Properties
        public int ResidentId
        {
            get => residentId;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value);
                if (residentId != value)
                {
                    residentId = value;
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

        public string RoomNumber
        {
            get => roomNumber;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNullOrWhiteSpace(value);
                if (roomNumber != value)
                {
                    roomNumber = value;
                }
            }
        }

        public string Note
        {
            get => note;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNullOrWhiteSpace(value);
                if (note != value)
                {
                    note = value;
                }
            }
        }
        #endregion
    }
}
