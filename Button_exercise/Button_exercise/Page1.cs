using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Button_exercise
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            var nextPageButton = new Button { Text = "Na nič", VerticalOptions = LayoutOptions.CenterAndExpand };
            nextPageButton.Clicked += OnNextPageButtonClicked;

            var nextPageButtonA = new Button { Text = "Nedobre", VerticalOptions = LayoutOptions.CenterAndExpand };
            nextPageButtonA.Clicked += OnNextPageButtonClickedA;

            var nextPageButtonB = new Button { Text = "že si sa snažil", VerticalOptions = LayoutOptions.CenterAndExpand };
            nextPageButtonB.Clicked += OnNextPageButtonClickedB;

			Title = "Príznaky";
			Content = new StackLayout
			{
				Children = {
					nextPageButton,
					nextPageButtonA,
					nextPageButtonB,
				
				}
			};
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
