using DataRendering.Data;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DataRendering
{
    public class ClientDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate SelectTemplateCore(object item)
        {
            var company = (Company)item;
            var companyTemplate = (DataTemplate)App.Current.Resources["MyTemplate"];
            var companyTemplatePrivate = (DataTemplate)App.Current.Resources["MyTemplatePrivate"];

            if (company.Name == "samsung") return companyTemplatePrivate;

            return companyTemplate;
        }
    }
}
