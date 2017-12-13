using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace DataRendering.Data
{
    public class Company : ViewModelBase
    {
        private string _name;
        private ImageSource _image;
        private Address _companyAddress;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
       
        public ImageSource Image
        {
            get { return _image; }
            set
            {
                _image = value;
                OnPropertyChanged();
            }
        }
      
        public Address CompanyAddress
        {
            get { return _companyAddress; }
            set
            {
                _companyAddress = value;
                OnPropertyChanged();
            }
        }

        public static ICollection<Company> GetCompanies()
        {
            return new List<Company>
            {
                new Company
                {
                    Name = "Samsung",
                    Image = new BitmapImage (new Uri("ms-appx:///Data/Images/delonghi.jpg")),
                    CompanyAddress = new Address("London")
                },
                new Company
                {
                    Name = "Philips",
                    Image = new BitmapImage (new Uri("ms-appx:///Data/Images/Philips_logo_neu.JPG")),
                    CompanyAddress = new Address("NewYork")
                },
                new Company
                {
                    Name = "DeLonghi",
                    Image = new BitmapImage (new Uri("ms-appx:///Data/Images/samsung-logo.jpg")),
                    CompanyAddress = new Address("Paris")
                }
            };
        }

        #region 1st method
        //public override string ToString()
        //{
        //    return Name;
        //}
        #endregion

    }
}
