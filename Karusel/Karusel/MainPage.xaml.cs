using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Karusel
{
    public partial class MainPage : CarouselPage
    {
      
        public MainPage()
        {
            var redContedPage = new ContentPage //nimetus
            {
                Content = new StackLayout
                {
                    Children =
                   {
                       new Label
                       {
                           Text = "Red",//tekst
                           FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                           HorizontalOptions = LayoutOptions.Center
                       },
                       new BoxView
                       { Color = Color.Red,//värv
                        WidthRequest = 200,
                        HeightRequest = 200,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                       }
                   }
                }
            };
            var blueContedPage = new ContentPage //nimetus
            {
                Content = new StackLayout
                {
                    Children =
                   {
                       new Label
                       {
                           Text = "Blue",//tekst
                           FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                           HorizontalOptions = LayoutOptions.Center
                       },
                       new BoxView
                       { Color = Color.Blue,//värv
                        WidthRequest = 200,
                        HeightRequest = 200,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                       }
                   }
                }
            };
            var yellowContedPage = new ContentPage //nimetus
            {
                Content = new StackLayout
                {
                    Children =
                   {
                       new Label
                       {
                           Text = "Yellow",//tekst
                           FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                           HorizontalOptions = LayoutOptions.Center
                       },
                       new BoxView
                       { Color = Color.Yellow,//värv
                        WidthRequest = 200,
                        HeightRequest = 200,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                       }
                   }
                }
            };
            Children.Add(yellowContedPage);
            Children.Add(blueContedPage);
            Children.Add(redContedPage);
        }   
    }
}
