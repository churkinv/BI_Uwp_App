using BindingToCollections.Common;
using BindingToCollections.DataProvider;
using BindingToCollections.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BindingToCollections.ViewModel
{
    class MainViewModel : Observable
    {
        private IClientProvider _clientsProvider;

        public MainViewModel(IClientProvider clientProvider)
        {
            _clientsProvider = clientProvider;
            DeleteCommand = new RelayCommand(OnDeleteExecute, OnDeleteCanExecute);
            Clients = new List<Client>();
            LoadData();
        }

        public List<Client> Clients { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        private Client _selectedClient;

        public Client SelectedClient
        {
            get { return _selectedClient; }
            set
            {
                _selectedClient = value;
                RaisePropertyChanged("SelectedClient");
                ((RelayCommand)DeleteCommand).RaiseCanExecuteChanged();
            }
        }

        public void LoadData()
        {
            foreach (Client client in _clientsProvider.LoadClients())
            {
                Clients.Add(client);
            }
        }

        private void OnDeleteExecute()
        {
            if (SelectedClient != null)
                Clients.Remove(SelectedClient);
        }
        private bool OnDeleteCanExecute()
        {
            return SelectedClient != null;
        }        
    }
}

