using GroupingData.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace GroupingData
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // first option is to use newly created class (ClientGroup) and method + XAML
            // this.DataContext = ClientLoader.LoadClientGroups(); 

            // second option: if we don`t have ClientGroup class 
            // we can use LINQ to group items as below. We also don`t need to use 
            //ItemsPath in XAML of our CollectionViewSource + adjsut HeaderTemplate

            ObservableCollection<Client> clients = ClientLoader.LoadClients();
            this.DataContext = clients.OrderBy(f => f.Name).GroupBy(f => f.Name[0]); // we are ordering by name and grouping by the first character of the name
                                                                                     // LINQ will create IGrouping object

            //************* The ICollectionViewGroup *************
            // to understand to what kind of properties we are binding to from XAML
            // public interface ICollectionView : IObservable<object>, IList<object>, IEnumerable<object>
            // {
            //     ....
            //     IObservableVector<object> CollectionGroups { get; }
            // }

            //public interface ICollectionViewGroup 
            //{
            //     object Group { get; }
            //     IObservableVector<object> GroupItems { get; }
            //}
        }
    }
}
