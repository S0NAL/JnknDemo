using System;
using Xamarin.Forms;

namespace JenkinsDemo
{
	public class HomePage : ContentPage
	{
		public HomePage ()
		{


//			var menuImage = new Image { WidthRequest = 20d, HeightRequest = 20d };
//			menuImage.Source = ImageSource.FromFile("ic_drawer_toggle.png");


			Image kixie = new Image {
				WidthRequest=200d, HeightRequest=200d,
				BackgroundColor = Color.Aqua
			};
			kixie.Source = ImageSource.FromFile ("kixie.jpg");

			Content = new StackLayout {
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					kixie
				}
			};
		}
	}
}

