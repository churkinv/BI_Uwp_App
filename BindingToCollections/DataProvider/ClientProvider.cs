using BindingToCollections.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToCollections.DataProvider
{
    class ClientProvider
    {
        public IEnumerable<Client> LoadClient()
        {
            return new List<Client>
            {
                new Client{FirstName = "John" },
                new Client{FirstName = "Ivanka"},
                new Client{FirstName = "Panas"},
                new Client{FirstName = "Stepan"}
            };
        }
    }
}
