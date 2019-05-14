using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MarkupExtensionSample.Extensions
{
    public class FontSizeExtension : IMarkupExtension<double>
    {
        public Button Button { set; get; }
      
        public double ProvideValue(IServiceProvider serviceProvider)
        {
            if(Button!=null)
             return Button.HeightRequest / 2;

            return 0;
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return (this as IMarkupExtension<double>).ProvideValue(serviceProvider);
        }
    }
}
