using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media.Imaging;

namespace TheFlipView.Data
{
    public class ClientLoader
    {
        public static ObservableCollection<Client> LoadClients()
        {
            return new ObservableCollection<Client> // Note reorder mechanizm on listview works only with ObservableCollections 
            {
                new Client
                {
                    Name = "Antonio",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/Antonio.jpg"))
                },
                new Client
                {
                    Name = "Carlos",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/Caty.jpg"))
                },
                new Client
                {
                    Name = "Chandler",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/Chandler.jpg"))
                },
                new Client
                {
                    Name = "Lacky",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/Lacky.jpg"))
                },
                new Client
                {
                    Name = "MrWolf",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/MrWolf.jpg"))
                },
                new Client
                {
                    Name = "Simon",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/Simon.jpg"))
                }
            };
        }
    }
}
