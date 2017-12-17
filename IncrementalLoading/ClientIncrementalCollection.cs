using IncrementalLoading;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml.Data;

namespace IncrementalLoading
{
    public class ClientIncrementalCollection : ObservableCollection<Client>, ISupportIncrementalLoading
    {
        const uint totalClientOnServer = 100; // faking the server)

        public bool HasMoreItems => this.Count < totalClientOnServer; // true if Count less than on the server 

        public IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync(uint count) // count contains the count of the elements are requested by the listview
        {
            uint unloadedClientCount = totalClientOnServer - (uint)this.Count; // count client that has not been loaded yet
            uint clientsToLoadCount = Math.Min(unloadedClientCount, count);// to know real number of clients to load we need to take minimum value out of the count and out of the unloadedClientCount
            return LoadMoreItemsInternalAsync(clientsToLoadCount).AsAsyncOperation(); // as we return Task from the pointed method and here we have to return IAsync op. we use .AsAsyncOperation()
        }

        private async Task<LoadMoreItemsResult> LoadMoreItemsInternalAsync(uint clientsToLoadCount)
        { 
            // this is fake server implementation, in real use loading from server

            for (int i = 0; i < clientsToLoadCount; i++)
            {
                await Task.Delay(100);

                this.Add(new Client { Name = "Client # " + (this.Count + 1) });
            }
            return new LoadMoreItemsResult { Count = clientsToLoadCount };
        }
    }
}
