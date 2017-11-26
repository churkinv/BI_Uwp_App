using BindingToCollections.DataProvider;
using BindingToCollections.ViewModel;
using TheObservableDictionary.Common;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BindingToCollections
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableDictionary _observableDictionary; 

        public MainPage()
        {
            this.InitializeComponent();
            _observableDictionary = new ObservableDictionary();
            this.DataContext = _observableDictionary;//new MainViewModel(new ClientProvider());
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            _observableDictionary["MainViewModel"] = new MainViewModel(new ClientProvider());
            //((MainViewModel)DataContext).LoadData();
            _observableDictionary["Phones"] = new PhoneProvider().LoadPhones();
        }
    }
}
