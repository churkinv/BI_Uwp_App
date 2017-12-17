using Windows.UI.Xaml.Controls;

namespace IncrementalLoading
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = new ClientIncrementalCollection();
        }
    }
}
