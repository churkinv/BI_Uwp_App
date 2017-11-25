using System.Collections.Generic;
using BindingToCollections.Model;

namespace BindingToCollections.DataProvider
{
    interface IClientProvider
    {
        IEnumerable<Client> LoadClients();
    }
}