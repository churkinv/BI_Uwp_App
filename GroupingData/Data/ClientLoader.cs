using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media.Imaging;

namespace GroupingData.Data
{
    public class ClientLoader
    {
        /// <summary>
        /// Method for DataContext to group our clients.
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<ClientGroup> LoadClientGroups()
        {
            return new ObservableCollection<ClientGroup>
            {
                new ClientGroup
                {
                    GroupName = "Male", Clients = new ObservableCollection<Client>
                    {
                        new Client
                        {
                            Name = "Stephen Hawking",
                            ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/StephenHawking.jpg"))
                        },
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
                            Name = "Robert Shiller",
                            ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/RobertShiller.jpg"))
                        },
                        new Client
                        {
                            Name = "Sylvester Stallone",
                            ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/SylvesterStallone.jpg"))
                        }
                    }
                },
                new ClientGroup
                {
                    GroupName = "Female", Clients = new ObservableCollection<Client>
                    {
                        new Client
                        {
                            Name = "Audrey Hepburn",
                            ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/AudreyHepburn.jpg"))
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
                            Name = "Jennifer Aniston",
                            ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/JenniferAniston.jpg"))
                        },
                        new Client
                        {
                            Name = "Milla Jovovich",
                            ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/MillaJovovich.jpg"))
                        },
                        new Client
                        {
                            Name = "Olga Freimut",
                            ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/OlgaFreimut.jpg"))
                        },
                        new Client
                        {
                            Name = "Lena Headey",
                            ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/LenaHeadey.jpg"))
                        }
                    }
                }
            };
        }

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
                    Name = "Jennifer Aniston",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/JenniferAniston.jpg"))
                },
                new Client
                {
                    Name = "Milla Jovovich",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/MillaJovovich.jpg"))
                },
                new Client
                {
                    Name = "Olga Freimut",
                    ImageSource = new BitmapImage(new Uri("ms-appx:///Data/Images/OlgaFreimut.jpg"))
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

