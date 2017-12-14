using DataRendering.Data;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DataRendering
{
    /// <summary>
    /// Using this class we can select which DataTemplate in App.xaml use 
    /// depending on specific property (company`s name in our case)
    /// </summary>
    public class ClientDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate SelectTemplateCore(object item)
        {
            var company = (Company)item;
            var companyTemplate = (DataTemplate)App.Current.Resources["MyTemplate"];
            var companyTemplatePrivate = (DataTemplate)App.Current.Resources["MyTemplatePrivate"];

            if (company.Name == "Samsung")
            {
                return companyTemplatePrivate;
            }
            return companyTemplate;
        }
    }
}
