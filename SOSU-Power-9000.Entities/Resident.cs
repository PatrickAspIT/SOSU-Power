using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private string notes;
        #endregion

        #region Constructors
        public Resident(int id, string name, string roomNumber, string notes)
        {
            this.residentId = id;
            this.name = name;
            this.roomNumber = roomNumber;
            this.notes = notes;
        }
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
            set => name = value;
        }

        public string RoomNumber
        {
            get => roomNumber;
            set => roomNumber = value;
        }

        public string Notes
        {
            get => notes;
            set => notes = value;
        }
        #endregion


    }
}
