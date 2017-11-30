using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRendering.Data
{
    public class Address : ViewModelBase
    {
        private string _city;

        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                OnPropertyChanged();
            }
        }

        public Address(string city)
        {
            City = city;
        }
    }
}
