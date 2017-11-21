using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BI_Uwp_App
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();         
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var textBox = new TextBox();

            var binding = new Binding
            {
                Source = slider,  // or ElementName = slider.Name,
                Path = new PropertyPath("Value")
            };
            textBox.SetBinding(TextBox.TextProperty, binding);
            //txtbl_SliderValur.SetBinding(TextBox.TextProperty, binding);
            //or (it is actually under the hood of calling framework element`s setbindoing method above  )
            //BindingOperations.SetBinding(txtbl_SliderValur, TextBox.TextProperty, binding);
            sp_MainStackPanel.Children.Add(textBox);
        }
    }
}
