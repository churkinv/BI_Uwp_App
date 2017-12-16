using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GroupingData.Data
{
    /// <summary>
    /// We use this class to group our clients
    /// </summary>
    public class ClientGroup
    {
        public string GroupName { get; set; }
        public ObservableCollection <Client> Clients { get; set; }
    }
}
