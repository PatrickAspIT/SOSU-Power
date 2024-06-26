﻿namespace SOSU_Power_9000.Entities
{
    public class Medicine
    {
        #region Fields
        private int medicineId;
        private string name;
        private string unit;
        private int amount;
        private bool administered;
        #endregion

        #region Constructors
        //public Medicine(int id, string name, string unit, int amount, bool administered)
        //{
        //    MedicineId = id;
        //    Name = name;
        //    Unit = unit;
        //    Amount = amount;
        //    Administered = administered;
        //}
        #endregion

        #region Properties
        /// <summary>
        /// Simple incapsulation of the medicineId, name, unit, amount and administered fields.
        /// </summary>
        public int MedicineId
        {
            get => medicineId;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value);
                if (medicineId != value)
                {
                    medicineId = value;
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
        
        public string Unit
        {
            get => unit;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNullOrWhiteSpace(value);
                if (unit != value)
                {
                    unit = value;
                }
            }
        }

        public int Amount
        {
            get => amount;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value);
                if (amount != value)
                {
                    amount = value;
                }
            }
        }

        public bool Administered
        {
            get => administered;
            set
            {
                if (administered != value)
                {
                    administered = value;
                }
            }
        }
        #endregion
    }
}
