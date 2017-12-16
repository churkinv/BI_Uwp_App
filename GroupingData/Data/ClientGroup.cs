using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GroupingData.Data
{
    public class ClientGroup
    {
        public string GroupName { get; set; }
        public ObservableCollection <Client> Clients { get; set; }
    }
}
