using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Button_exercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1Xaml : ContentPage
    {
        public Page1Xaml()
        {
            InitializeComponent();
        }
       

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2Xaml());
        }
        async void OnNextPageButtonClickedA(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2Xaml());
        }
        async void OnNextPageButtonClickedB(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2Xaml());
        }
    }
}