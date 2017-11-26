using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToCollections.DataProvider
{
    public class PhoneProvider
    {
        public List<string> LoadPhones()
        {
            return new List<string>
            {
                "HTC M8",
                "HTC M9",
                "Samsung Galaxy",
                "Nokia 9910",
                "Meizu M5"
            };
        }
    }
}
