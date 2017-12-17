using Windows.UI.Xaml.Media;

namespace IncrementalLoading
{
    public class Client : Observable
    {
        private string _name;
        private ImageSource _imageSource;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public ImageSource ImageSource
        {
            get { return _imageSource; }
            set
            {
                _imageSource = value;
                OnPropertyChanged();
            }
        }
    }
}