﻿namespace SOSU_Power_9000.Entities
{
    public class Address
    {
        #region Fields
        private int addressId;
        private string street;
        private string city;
        private string state;
        private int zip;
        #endregion

        #region Constructors
        //public Address(int id, string street, string city, string state, int zip)
        //{
        //    AddressId = id;
        //    Street = street;
        //    City = city;
        //    State = state;
        //    Zip = zip;
        //}
        #endregion

        #region Properties
        /// <summary>
        /// Simple incapsulation of the addressId, street, city, state, and zip fields.
        /// </summary>
        public int AddressId
        {
            get => addressId;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value);
                if (addressId != value)
                {
                    addressId = value;
                }
            }
        }

        public string Street
        {
            get => street;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNullOrWhiteSpace(value);
                if (street != value)
                {
                    street = value;
                }
            }
        }

        public string City
        {
            get => city;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNullOrWhiteSpace(value);
                if (city != value)
                {
                    city = value;
                }
            }
        }

        public string State
        {
            get => state;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNullOrWhiteSpace(value);
                if (state != value)
                {
                    state = value;
                }
            }
        }

        public int Zip
        {
            get => zip;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value);
                if (zip != value)
                {
                    zip = value;
                }
            }
        }
        #endregion
    }
}
