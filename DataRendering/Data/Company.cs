using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataRendering.Data
{
    public class Company : INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set {
                _name = value;
                ///OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //public override OnPopertyChanged([CallerMemberName])
        //{

        //}

        public static ICollection<Company> GetCompanies()
        {
            return new List<Company>
            {
                new Company {Name = "Samsung" },
                new Company {Name = "Philips"},
                new Company {Name = "DeLonghi"}
            };
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
