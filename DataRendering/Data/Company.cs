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
                OnPropertyChanged();
            }
        }        

        public static ICollection<Company> GetCompanies()
        {
            return new List<Company>
            {
                new Company {Name = "Samsung" },
                new Company {Name = "Philips"},
                new Company {Name = "DeLonghi"}
            };
        }
        #region 1st method
        //public override string ToString()
        //{
        //    return Name;
        //}
        #endregion


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null) // with these two parametrs null and CallerMember.. 
                                                                                               //i can call event without paremeter. Compiler will automatically passed the property name it is callsed from
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
