using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TheListView.Data;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TheListView
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.DataContext = ClientLoader.LoadClients();
        }

        private async void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var client = e.ClickedItem as Client;
            if (client != null)
            {
                var dlg = new MessageDialog("has been clicked")
                {
                    Title = client.Name
                };
               await dlg.ShowAsync();
            }
        }
    }
}
