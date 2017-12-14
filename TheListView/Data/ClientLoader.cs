using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media.Imaging;

namespace TheListView.Data
{
    class ClientLoader
    {
        public static ObservableCollection<Client> LoadClients()
        {
            return new ObservableCollection<Client> // Note reorder mechanizm on listview works only with ObservableCollections 
            {
                new Client
                {
                    Name = "Al Pachino",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/AlPachino2.jpg"))
                },
                new Client
                {
                    Name = "Arnold Schwarzenegger",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/ArnoldSchwarzenegger.jpeg"))
                },
                new Client
                {
                    Name = "Audrey Hepburn",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/AudreyHepburn.jpg"))
                },
                new Client
                {
                    Name = "Bogdan Stupka",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/BogdanStupka.jpg"))
                },
                new Client
                {
                    Name = "Brad Pitt",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/BradPitt.jpg"))
                },
                new Client
                {
                    Name = "Cameron Diaz",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/CameronDiaz2.jpg"))
                },
                new Client
                {
                    Name = "Emma Watson",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/EmmaWatson.jpg"))
                },
                new Client
                {
                    Name = "Lena Headey",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/LenaHeadey.jpg"))
                },
                new Client
                {
                    Name = "Robert Shiller",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/RobertShiller.jpg"))
                },
                new Client
                {
                    Name = "Stephen Hawking",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/StephenHawking.jpg"))
                },
                new Client
                {
                    Name = "Sylvester Stallone",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/SylvesterStallone.jpg"))
                }
            };
        }
    }
}

