using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WingtipToys.TayfunDeneme
{
    public class Customer
    {
        string _customerId;
        public string CustomerId
        {
            get
            {
                return _customerId;
            }
            set
            {
                _customerId = value;
            }
        }

        string _contactName;
        public string ContactName
        {
            get
            {
                return _contactName;
            }
            set
            {
                _contactName = value;
            }
        }

        string _city;
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        string _country;
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }

    }
}